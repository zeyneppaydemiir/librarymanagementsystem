using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace KutuphaneOtomasyonu
{
    public partial class FrmKisiIslemleri : Form
    {
        public FrmKisiIslemleri()
        {
            InitializeComponent();
        }

        // SQL bağlantı sınıfından bir nesne
        SqlBaglantisi bgl = new SqlBaglantisi();

       
        void KisileriListele()
        {
            using (SqlDataAdapter da = new SqlDataAdapter(
                "SELECT ID, ADSOYAD, DOGUMTARIHI, TELEFON FROM TBL_KISILER",
                bgl.BaglantiAc()))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;

                
                dataGridView2.DataSource = dt.Copy();

                dataGridView3.DataSource = dt.Copy();
            }
        }

        
        void AlanlariTemizle()
        {
            
            MskID.Text = "";
            MskAD.Text = "";
            MskDT.Text = "";
            MskTEL.Text = "";

            
            MskIDG.Text = "";
            MskADG.Text = "";
            MskDTG.Text = "";
            MskTELG.Text = "";

          
            MskIDS.Text = "";
            MskADS.Text = "";
            MskDTS.Text = "";
            MskTELS.Text = "";
        }

       
        void SatirdanAlanlariDoldur(DataGridViewRow satir)
        {
            if (satir == null) return;

            string id = satir.Cells["ID"].Value?.ToString();
            string ad = satir.Cells["ADSOYAD"].Value?.ToString();
            string dt = satir.Cells["DOGUMTARIHI"].Value?.ToString();
            string tel = satir.Cells["TELEFON"].Value?.ToString();

            
            MskID.Text = id;
            MskAD.Text = ad;
            MskDT.Text = dt;
            MskTEL.Text = tel;

            
            MskIDG.Text = id;
            MskADG.Text = ad;
            MskDTG.Text = dt;
            MskTELG.Text = tel;

           
            MskIDS.Text = id;
            MskADS.Text = ad;
            MskDTS.Text = dt;
            MskTELS.Text = tel;
        }

       
        private void FrmKisiIslemleri_Load(object sender, EventArgs e)
        {
            KisileriListele();
        }

        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            SatirdanAlanlariDoldur(dataGridView1.Rows[e.RowIndex]);
        }

        // 2. gridde satır seçme
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            SatirdanAlanlariDoldur(dataGridView2.Rows[e.RowIndex]);
        }

        // 3. gridde satır seçme
        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            SatirdanAlanlariDoldur(dataGridView3.Rows[e.RowIndex]);
        }

        // --------------------------------------------------------------------
        // EKLE BUTONU  (Stored Procedure kullanılıyor burada da
        // --------------------------------------------------------------------
        private void BtnKAYDET_Click(object sender, EventArgs e)
        {
            try
            {
                
                using (SqlCommand komut = new SqlCommand("sp_KisiEkle", bgl.BaglantiAc()))
                {
                    komut.CommandType = CommandType.StoredProcedure;

                    komut.Parameters.AddWithValue("@AdSoyad", MskAD.Text);
                    komut.Parameters.AddWithValue("@DogumTarihi", MskDT.Text);
                    komut.Parameters.AddWithValue("@Telefon", MskTEL.Text);

                    komut.ExecuteNonQuery();
                }

                MessageBox.Show("Kişi başarıyla eklendi.",
                    "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                KisileriListele();
                AlanlariTemizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt eklenirken hata oluştu:\n" + ex.Message,
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --------------------------------------------------------------------
        // GÜNCELLE BUTONU
        // --------------------------------------------------------------------
        private void BtnGUNCELLE_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(MskIDG.Text))
            {
                MessageBox.Show("Lütfen güncellenecek kişiyi listeden seçin.",
                    "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlCommand komut = new SqlCommand(
                    "UPDATE TBL_KISILER SET ADSOYAD=@ad, DOGUMTARIHI=@dt, TELEFON=@tel WHERE ID=@id",
                    bgl.BaglantiAc()))
                {
                    komut.Parameters.AddWithValue("@ad", MskADG.Text);
                    komut.Parameters.AddWithValue("@dt", MskDTG.Text);
                    komut.Parameters.AddWithValue("@tel", MskTELG.Text);
                    komut.Parameters.AddWithValue("@id", Convert.ToInt32(MskIDG.Text));

                    komut.ExecuteNonQuery();
                }

                MessageBox.Show("Kişi bilgileri güncellendi.",
                    "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                KisileriListele();
                AlanlariTemizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme sırasında hata oluştu:\n" + ex.Message,
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --------------------------------------------------------------------
        // SİL BUTONU
        // --------------------------------------------------------------------
        private void BtnSIL_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(MskIDS.Text))
            {
                MessageBox.Show("Lütfen silinecek kişiyi listeden seçin.",
                    "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show("Bu kişiyi silmek istediğinize emin misiniz?",
                "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr != DialogResult.Yes)
                return;

            try
            {
                using (SqlCommand komut = new SqlCommand(
                    "DELETE FROM TBL_KISILER WHERE ID=@id",
                    bgl.BaglantiAc()))
                {
                    komut.Parameters.AddWithValue("@id", Convert.ToInt32(MskIDS.Text));
                    komut.ExecuteNonQuery();
                }

                MessageBox.Show("Kişi kaydı silindi.",
                    "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                KisileriListele();
                AlanlariTemizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme sırasında hata oluştu:\n" + ex.Message,
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

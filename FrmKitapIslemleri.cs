using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace KutuphaneOtomasyonu
{
    public partial class FrmKitapIslemleri : Form
    {
        public FrmKitapIslemleri()
        {
            InitializeComponent();
        }

        // SQL bağlantı sınıfından bir nesne
        SqlBaglantisi bgl = new SqlBaglantisi();

      
        int secilenID = -1;

        
        void KitaplariListele()
        {
            using (SqlDataAdapter da = new SqlDataAdapter(
                "SELECT ID, KITAPAD, KITAPKONUSU, YAYINEVI, YAZARI FROM TBL_KITAPLAR",
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
            
            MskKitapAD.Text = "";
            MskKONUSU.Text = "";
            MskYAYINEVI.Text = "";
            MskYAZARI.Text = "";

            
            MskKitapADG.Text = "";
            MskKONUSUG.Text = "";
            MskYAYINEVIG.Text = "";
            MskYAZARIG.Text = "";

            
            MskKitapADS.Text = "";
            MskKONUSUS.Text = "";
            MskYAYINEVIS.Text = "";
            MskYAZARIS.Text = "";

            secilenID = -1;
        }

       
        void SatirdanAlanlariDoldur(DataGridViewRow satir)
        {
            if (satir.Cells["ID"].Value != null)
                secilenID = Convert.ToInt32(satir.Cells["ID"].Value);

            string ad = satir.Cells["KITAPAD"].Value?.ToString();
            string konu = satir.Cells["KITAPKONUSU"].Value?.ToString();
            string yayinevi = satir.Cells["YAYINEVI"].Value?.ToString();
            string yazar = satir.Cells["YAZARI"].Value?.ToString();

            // Ekle sekmesi
            MskKitapAD.Text = ad;
            MskKONUSU.Text = konu;
            MskYAYINEVI.Text = yayinevi;
            MskYAZARI.Text = yazar;

            // Güncelle sekmesi
            MskKitapADG.Text = ad;
            MskKONUSUG.Text = konu;
            MskYAYINEVIG.Text = yayinevi;
            MskYAZARIG.Text = yazar;

            // Sil sekmesi
            MskKitapADS.Text = ad;
            MskKONUSUS.Text = konu;
            MskYAYINEVIS.Text = yayinevi;
            MskYAZARIS.Text = yazar;
        }

        // ========== Form açıldığında ==========
        private void FrmKitapIslemleri_Load(object sender, EventArgs e)
        {
            KitaplariListele();
        }

        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            SatirdanAlanlariDoldur(dataGridView1.Rows[e.RowIndex]);
        }

        
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            SatirdanAlanlariDoldur(dataGridView2.Rows[e.RowIndex]);
        }

       
        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            SatirdanAlanlariDoldur(dataGridView3.Rows[e.RowIndex]);
        }

        // ===================== EKLE (Stored Procedure ile) =====================
        private void BtnEKLE_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand komut = new SqlCommand("sp_KitapEkle", bgl.BaglantiAc()))
                {
                    komut.CommandType = CommandType.StoredProcedure;

                    komut.Parameters.AddWithValue("@KitapAd", MskKitapAD.Text);
                    komut.Parameters.AddWithValue("@KitapKonusu", MskKONUSU.Text);
                    komut.Parameters.AddWithValue("@Yayinevi", MskYAYINEVI.Text);
                    komut.Parameters.AddWithValue("@Yazari", MskYAZARI.Text);

                    komut.ExecuteNonQuery();
                }

                MessageBox.Show("Kitap sisteme eklendi.", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                KitaplariListele();
                AlanlariTemizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kitap eklerken hata oluştu:\n" + ex.Message,
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ===================== GÜNCELLE =====================
        private void BtnGUNCELLE_Click(object sender, EventArgs e)
        {
            if (secilenID == -1)
            {
                MessageBox.Show("Güncellenecek kitabı listeden seçiniz.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlCommand komut = new SqlCommand(
                    "UPDATE TBL_KITAPLAR SET " +
                    "KITAPAD=@ad, KITAPKONUSU=@konu, YAYINEVI=@yayinevi, YAZARI=@yazar " +
                    "WHERE ID=@id",
                    bgl.BaglantiAc()))
                {
                    komut.Parameters.AddWithValue("@ad", MskKitapADG.Text);
                    komut.Parameters.AddWithValue("@konu", MskKONUSUG.Text);
                    komut.Parameters.AddWithValue("@yayinevi", MskYAYINEVIG.Text);
                    komut.Parameters.AddWithValue("@yazar", MskYAZARIG.Text);
                    komut.Parameters.AddWithValue("@id", secilenID);

                    komut.ExecuteNonQuery();
                }

                MessageBox.Show("Kitap bilgileri güncellendi.", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                KitaplariListele();
                AlanlariTemizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme sırasında hata oluştu:\n" + ex.Message,
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ===================== SİL =====================
        private void BtnSIL_Click(object sender, EventArgs e)
        {
            if (secilenID == -1)
            {
                MessageBox.Show("Silinecek kitabı listeden seçiniz.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlCommand komut = new SqlCommand(
                    "DELETE FROM TBL_KITAPLAR WHERE ID=@id",
                    bgl.BaglantiAc()))
                {
                    komut.Parameters.AddWithValue("@id", secilenID);
                    komut.ExecuteNonQuery();
                }

                MessageBox.Show("Kitap kaydı silindi.", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                KitaplariListele();
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

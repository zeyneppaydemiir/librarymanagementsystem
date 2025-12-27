using System;
using System.Windows.Forms;
using System.Data;
using Microsoft.Data.SqlClient;

namespace KutuphaneOtomasyonu
{
    public partial class FrmTeslimAlma : Form
    {
        SqlBaglantisi bgl = new SqlBaglantisi();

        public FrmTeslimAlma()
        {
            InitializeComponent();
        }

        private void FrmTeslimAlma_Load(object sender, EventArgs e)
        {
            
        }

        
        private void btnTeslimEt_Click(object sender, EventArgs e)
        {
            EmanetVer();
        }

        private void btnTeslimEt_Click_1(object sender, EventArgs e)
        {
            EmanetVer();
        }

        
        private void EmanetVer()
        {
           
            if (string.IsNullOrWhiteSpace(txtKisiID.Text) ||
                string.IsNullOrWhiteSpace(txtKitapID.Text))
            {
                MessageBox.Show("Lütfen Kişi ID ve Kitap ID alanlarını doldurun.");
                return;
            }

            
            if (!int.TryParse(txtKisiID.Text, out int kisiID) ||
                !int.TryParse(txtKitapID.Text, out int kitapID))
            {
                MessageBox.Show("ID alanlarına sadece sayı girin.");
                return;
            }

            using (SqlConnection conn = bgl.BaglantiAc())
            {
                
                string kontrolSql =
                    "SELECT COUNT(*) FROM TBL_EMANETLER " +
                    "WHERE KITAP_ID = @kitap AND TESLIM_TARIH IS NULL";

                using (SqlCommand cmdKontrol = new SqlCommand(kontrolSql, conn))
                {
                    cmdKontrol.Parameters.AddWithValue("@kitap", kitapID);

                    int sayi = (int)cmdKontrol.ExecuteScalar();

                    if (sayi > 0)
                    {
                        MessageBox.Show("Bu kitap zaten emanet verilmiş!");
                        return;
                    }
                }

                string insertSql =
                    "INSERT INTO TBL_EMANETLER (KISI_ID, KITAP_ID) " +
                    "VALUES (@kisi, @kitap)";

                using (SqlCommand cmdInsert = new SqlCommand(insertSql, conn))
                {
                    cmdInsert.Parameters.AddWithValue("@kisi", kisiID);
                    cmdInsert.Parameters.AddWithValue("@kitap", kitapID);

                    try
                    {
                        cmdInsert.ExecuteNonQuery();
                        MessageBox.Show("Kitap başarıyla emanet verildi.");
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("SQL Hatası: " + ex.Message);
                        return;
                    }
                }
            }

            
            txtKisiID.Clear();
            txtKitapID.Clear();
            txtKisiID.Focus();
        }
    }
}


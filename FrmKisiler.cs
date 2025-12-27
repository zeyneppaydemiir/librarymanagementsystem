using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Data;


namespace KutuphaneOtomasyonu
{
    public partial class FrmKisiler : Form
    {
        
        SqlBaglantisi bgl = new SqlBaglantisi();

        public FrmKisiler()
        {
            InitializeComponent();
        }

        void Listele()
        {
            // sql kayıtlarını buradan çekiyoruz.
            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT * FROM TBL_KISILER",
                bgl.BaglantiAc()
            );

            DataTable dt = new DataTable();
            da.Fill(dt);

            
            dataGridView1.DataSource = dt;
        }

        private void FrmKisiler_Load(object sender, EventArgs e)
        {
            Listele();   
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Microsoft.Data.SqlClient;

namespace KutuphaneOtomasyonu
{
    public partial class FrmKitaplar : Form
    {
        SqlBaglantisi bgl = new SqlBaglantisi();

        public FrmKitaplar()
        {
            InitializeComponent();
        }

        void Listele()
        {
            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT * FROM TBL_KITAPLAR",
                bgl.BaglantiAc()
            );

            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void FrmKitaplar_Load(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
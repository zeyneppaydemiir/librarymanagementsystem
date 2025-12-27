using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;

namespace KutuphaneOtomasyonu
{
    internal class SqlBaglantisi
    {
        private SqlConnection baglanti = new SqlConnection(
            "Data Source=MITHAT\\SQLEXPRESS;Initial Catalog=DboKutuphaneOtomasyon;Integrated Security=True;Encrypt=False;TrustServerCertificate=True"
        );

        public SqlConnection BaglantiAc()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            return baglanti;
        }
    }
}
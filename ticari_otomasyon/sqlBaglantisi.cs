using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ticari_otomasyon
{
    class sqlBaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source = (localdb)\mssqllocaldb ; Initial Catalog = TicariOtomasyon; Integrated Security = True");
            baglan.Open();
            return baglan;
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraCharts;

namespace ticari_otomasyon
{
    public partial class FrmStoklar : Form
    {
        public FrmStoklar()
        {
            InitializeComponent();
        }

        sqlBaglantisi bgl = new sqlBaglantisi();

        

        private void FrmStoklar_Load(object sender, EventArgs e)
        {
            //chartControl1.Series["Series 1"].Points.AddPoint("İstanbul", 4);
            //chartControl1.Series["Series 1"].Points.AddPoint("ankara", 5);
            //chartControl1.Series["Series 1"].Points.AddPoint("izmir", 8);
            //chartControl1.Series["Series 1"].Points.AddPoint("çorum", 10);
            
            SqlDataAdapter da = new SqlDataAdapter("Select UrunAd,Sum(Adet) As 'Miktar' from TBL_URUNLER group by UrunAd",
                bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;

            //Charta stok miktarı listeleme
            SqlCommand komut = new SqlCommand("Select UrunAd,Sum(Adet) As 'Miktar' from TBL_URUNLER group by UrunAd",
                bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));
                chartControl1.Series[0].LegendTextPattern = ("{A}"); 
            }
            bgl.baglanti().Close();

            SqlCommand komut2 = new SqlCommand("Select IL,Count(*) From Tbl_Fırmalar Group By IL", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                chartControl2.Series["Series 1"].Points.AddPoint(Convert.ToString(dr2[0]), int.Parse(dr2[1].ToString()));
                
            }
            bgl.baglanti().Close();
        }
    }
}

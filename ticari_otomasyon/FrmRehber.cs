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

namespace ticari_otomasyon
{
    public partial class FrmRehber : Form
    {
        public FrmRehber()
        {
            InitializeComponent();
        }

        sqlBaglantisi bgl = new sqlBaglantisi();
        private void FrmRehber_Load(object sender, EventArgs e)
        {
            //müşteri bilgileri
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select AD,SOYAD,TELEFON,TELEFON2,MAIL from TBL_MUSTERILER", bgl.baglanti());
            da.Fill(dt);
            gridControl3.DataSource = dt;

            //firma bilgileri
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select AD,YETKILIADSOYAD,TELEFON1,TELEFON2,telefon3, MAIL,fax from TBL_FIRMALAR", bgl.baglanti());
            da2.Fill(dt2);
            gridControl4.DataSource = dt2;
        }

        private void gridControl3_Click(object sender, EventArgs e)
        {

        }

        private void gridView3_DoubleClick(object sender, EventArgs e)
        {
            FrmMail frm = new FrmMail();
            DataRow dr = gridView3.GetDataRow(gridView3.FocusedRowHandle);

            if (dr != null)
            {
                frm.mail = dr["MAIL"].ToString();

            }
            frm.Show();
        }

        private void gridView4_DoubleClick(object sender, EventArgs e)
        {
            FrmMail frm = new FrmMail();
            DataRow dr = gridView4.GetDataRow(gridView4.FocusedRowHandle);

            if (dr != null)
            {
                frm.mail = dr["MAIL"].ToString();

            }
            frm.Show();
        }
    }
}
 
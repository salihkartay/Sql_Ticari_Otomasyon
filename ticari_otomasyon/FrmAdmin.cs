using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ticari_otomasyon
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }
        sqlBaglantisi bgl=new sqlBaglantisi();

        private void button1_MouseHover(object sender, EventArgs e)
        {
            btnGiris.BackColor = Color.Green;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            btnGiris.BackColor = Color.LightSalmon;
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From TBL_ADMIN where KullaniciAd=@p1 and Sifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmAnaModul fr = new FrmAnaModul();
                fr.kullanici = txtKullaniciAdi.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı adı ya da Şifre", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {

        }
 

        private void txtSifre_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SqlCommand komut = new SqlCommand("Select * From TBL_ADMIN where KullaniciAd=@p1 and Sifre=@p2", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
                komut.Parameters.AddWithValue("@p2", txtSifre.Text);
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    FrmAnaModul fr = new FrmAnaModul();
                    fr.kullanici = txtKullaniciAdi.Text;
                    fr.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı Kullanıcı adı ya da Şifre", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }
        private void txtKullaniciAdi_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}

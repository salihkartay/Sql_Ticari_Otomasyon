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
    public partial class FrmUrunler : Form
    {
        public FrmUrunler()
        {
            InitializeComponent(); //form nesnelerimizin oluştuğu .net framework interface i
        }
        sqlBaglantisi bgl = new sqlBaglantisi();
        void listele()
        {
            DataTable dt = new DataTable(); //forma sqlden gelen sorguyu atmamız için datatable türünde nesne olusturuyoruz 
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_URUNLER", bgl.baglanti()); // sql de sorgulama yapmak için sqladapter nesnesi oluşturuyoruz ve içine sorgumuzu yazıyoruz ; hangi database de sorgu yapmak istiyorsak bağlantımızı veriyoruz
            da.Fill(dt); //sql den gelen sorguyu fill fonksiyonu ile datatable tablomuzu içine atıyoruz 
            gridControl1.DataSource = dt; //burda da grid tablosuna datatable türünde verimizi atıyoruz

        }

        void temizle()
        {
            txtAd.Text = "";
            txtAlis.Text = "";
            txtId.Text = "";
            txtMarka.Text = "";
            txtModel.Text = "";
            txtSatis.Text = "";
            maskedYil.Text = "";
            numericAdet.Value = 0;
            RchDetay.Text = "";
        }
        private void FrmUrunler_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //veri kaydetme
            SqlCommand komut = new SqlCommand("insert into TBL_URUNLER (URUNAD,MARKA,MODEL,YIL,ADET,ALISFIYAT,SATISFIYAT,DETAY) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti()) ; //sqladapter veri çekmek için kullanılırken sqlcommand ile veri gönderiyoruz
            komut.Parameters.AddWithValue("@p1", txtAd.Text);                                                           //sql adapter return yani geri dönüş değeri alıyor o yüzden sadece sorgularda kullanırız sqlcommand geriye değer döndermez database de sql komutlarını çalılştırır
            komut.Parameters.AddWithValue("@p2", txtMarka.Text);
            komut.Parameters.AddWithValue("@p3", txtModel.Text);
            komut.Parameters.AddWithValue("@p4", maskedYil.Text);
            komut.Parameters.AddWithValue("@p5", int.Parse((numericAdet.Value).ToString()));
            komut.Parameters.AddWithValue("@p6", decimal.Parse(txtAlis.Text));
            komut.Parameters.AddWithValue("@p7", decimal.Parse(txtSatis.Text));
            komut.Parameters.AddWithValue("@p8", RchDetay.Text);
            komut.ExecuteNonQuery(); //sql komutlarını çalıştırır
            bgl.baglanti().Close(); 
            MessageBox.Show("Ürün sisteme eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komutSil = new SqlCommand("Delete From TBL_URUNLER where ID=@p1", bgl.baglanti());
            komutSil.Parameters.AddWithValue("@p1", txtId.Text);
            komutSil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle); // bu fonksiyon hangi rowa tıklandıysa o rowun bilgilerini datarow nesnesinin içine atar 
            txtId.Text = dr["ID"].ToString();                     //sonra o nesnenin değişkenlerini ekrandaki text nesnelerinin içine atar
            txtAd.Text = dr["URUNAD"].ToString();
            txtMarka.Text = dr["MARKA"].ToString();
            txtModel.Text = dr["MODEL"].ToString();
            maskedYil.Text = dr["YIL"].ToString();
            numericAdet.Value =decimal.Parse( dr["ADET"].ToString());
            txtAlis.Text = dr["ALISFIYAT"].ToString();
            txtSatis.Text = dr["SATISFIYAT"].ToString();
            RchDetay.Text = dr["DETAY"].ToString();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_URUNLER set URUNAD=@P1, MARKA=@P2,MODEL=@P3,YIL=@P4,ADET=@P5,ALISFIYAT=@P6,SATISFIYAT=@P7,DETAY=@P8 where ID=@P9",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtMarka.Text);
            komut.Parameters.AddWithValue("@p3", txtModel.Text);
            komut.Parameters.AddWithValue("@p4", maskedYil.Text);
            komut.Parameters.AddWithValue("@p5", int.Parse((numericAdet.Value).ToString()));
            komut.Parameters.AddWithValue("@p6", decimal.Parse(txtAlis.Text));
            komut.Parameters.AddWithValue("@p7", decimal.Parse(txtSatis.Text));
            komut.Parameters.AddWithValue("@p8", RchDetay.Text);
            komut.Parameters.AddWithValue("@p9", txtId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();

        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}

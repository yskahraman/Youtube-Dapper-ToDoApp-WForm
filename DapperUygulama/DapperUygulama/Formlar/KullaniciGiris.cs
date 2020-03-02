using DapperUygulama.Concrete.Dapper;
using DapperUygulama.Functions;
using System;
using System.Windows.Forms;

namespace DapperUygulama.Formlar
{
    public partial class KullaniciGiris : Form
    {
        DapperKullaniciRepository kullaniciRepository;
        public KullaniciGiris()
        {
            kullaniciRepository = new DapperKullaniciRepository();
            InitializeComponent();
        }

        private void KullaniciGiris_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydol_Click(object sender, EventArgs e)
        {
            FrmKullaniciKayit frm = new FrmKullaniciKayit();
            frm.ShowDialog();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (Islemler.BosKontrol(txtKullaniciAd.Text) && Islemler.BosKontrol(txtSifre.Text))
            {
                var kullanici = kullaniciRepository.KullaniciGirisKontrol(txtKullaniciAd.Text, txtSifre.Text);
                if (kullanici != null)
                {

                    //giriş başarılı
                    //MessageBox.Show("Giriş yapan kullanici :" + kullanici.Ad);
                    FrmIsler frmIsler = new FrmIsler(kullanici);
                    frmIsler.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanici adı veya şifreniz hatalı");
                }
            }
        }
    }
}

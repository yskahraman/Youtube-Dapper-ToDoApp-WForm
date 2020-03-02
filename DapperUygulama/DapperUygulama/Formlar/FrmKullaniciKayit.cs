using DapperUygulama.Concrete.Dapper;
using DapperUygulama.Entities;
using DapperUygulama.Functions;
using System;
using System.Windows.Forms;

namespace DapperUygulama.Formlar
{
    public partial class FrmKullaniciKayit : Form
    {
        DapperKullaniciRepository dapperKullaniciRepository;
        public FrmKullaniciKayit()
        {
            dapperKullaniciRepository = new DapperKullaniciRepository();
            InitializeComponent();
        }

        private void btnKaydol_Click(object sender, EventArgs e)
        {
            if (Islemler.BosKontrol(txtKullaniciAd.Text) && Islemler.BosKontrol(txtSifre.Text) && Islemler.BosKontrol(txtAd.Text) && Islemler.BosKontrol(txtSoyad.Text))
            {
                dapperKullaniciRepository.Kaydet(new Kullanici()
                {
                    Ad=txtAd.Text,
                    KullaniciAd=txtKullaniciAd.Text,
                    Sifre=txtSifre.Text,
                    Soyad=txtSoyad.Text
                });

                MessageBox.Show("Kayıt işleminiz başarı ile gerçekleşti, sisteme giriş yapabilirsiniz","Başarılı",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                lblDurum.Visible = true;
                lblDurum.Text = "Alanlardan herhangi biri boş geçilemez";
            }
        }

      
    }
}

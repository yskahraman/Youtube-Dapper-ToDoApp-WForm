using DapperUygulama.Concrete.Dapper;
using DapperUygulama.Entities;
using DapperUygulama.Functions;
using System;
using System.Windows.Forms;

namespace DapperUygulama.Formlar
{
    public partial class FrmYeniIs : Form
    {
        Kullanici kullanici;
        DapperYapilacakIsRepository yapilacakIsRepository;
        public FrmYeniIs(Kullanici _kullanici)
        {
            yapilacakIsRepository = new DapperYapilacakIsRepository();
            kullanici = _kullanici;
            InitializeComponent();
        }

        private void FrmYeniIs_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if(Islemler.BosKontrol(txtAd.Text)&& Islemler.BosKontrol(txtAciklama.Text))
            {
                yapilacakIsRepository.Ekle(new YapilacakIs()
                {
                    Aciklama = txtAciklama.Text,
                    Tanim = txtAd.Text,
                    KullaniciId = kullanici.Id
                });
                MessageBox.Show("İş eklendi");

                this.Close();
            }
            else
            {
                MessageBox.Show("Alanları boş bırakmayınız");
            }
        }
    }
}

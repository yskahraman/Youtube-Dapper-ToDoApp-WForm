using DapperUygulama.Concrete.Dapper;
using DapperUygulama.Entities;
using System.Windows.Forms;

namespace DapperUygulama.Formlar
{
    public partial class FrmBekleyenler : Form
    {
        Kullanici kullanici;
        int yapilacakIsId;
        DapperYapilacakIsRepository yapilacakIsRepository;
        public FrmBekleyenler(Kullanici _kullanici)
        {
            yapilacakIsRepository = new DapperYapilacakIsRepository();
            kullanici = _kullanici;
            InitializeComponent();
            Doldur();
        }

        private void Doldur()
        {
            dataGridBekleyen.DataSource = yapilacakIsRepository.BekleyenleriGetir(kullanici.Id);
            dataGridBekleyen.Columns["KullaniciId"].Visible = false;
            dataGridBekleyen.Columns["Id"].Visible = false;
            dataGridBekleyen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridBekleyen.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnYeniIs_Click(object sender, System.EventArgs e)
        {
            yapilacakIsId = 0;
            FrmYeniIs frm = new FrmYeniIs(kullanici);
            frm.ShowDialog();
            Doldur();
        }

        private void dataGridBekleyen_Click(object sender, System.EventArgs e)
        {
            yapilacakIsId= (int)dataGridBekleyen.CurrentRow.Cells["Id"].Value;
        }

        private void btnTamamla_Click(object sender, System.EventArgs e)
        {
            if (yapilacakIsId != 0)
            {
                yapilacakIsRepository.Tamamla(yapilacakIsId);
                Doldur();
            }
            else
            {
                MessageBox.Show("Listeden eleman seçiniz");
            }
        }
    }
}

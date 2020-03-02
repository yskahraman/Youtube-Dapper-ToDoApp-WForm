using DapperUygulama.Concrete.Dapper;
using DapperUygulama.Entities;
using System.Windows.Forms;

namespace DapperUygulama.Formlar
{
    public partial class FrmTamamlananlar : Form
    {
        Kullanici kullanici;
        DapperYapilacakIsRepository yapilacakIsRepository;
        public FrmTamamlananlar(Kullanici _kullanici)
        {
            yapilacakIsRepository = new DapperYapilacakIsRepository();
            kullanici = _kullanici;
            InitializeComponent();
            Doldur();
        }

        private void Doldur()
        {
            dataGridTamamlanan.DataSource = yapilacakIsRepository.TamamlananlariGetir(kullanici.Id);
            dataGridTamamlanan.Columns["KullaniciId"].Visible = false;
            dataGridTamamlanan.Columns["Id"].Visible = false;
            dataGridTamamlanan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridTamamlanan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}

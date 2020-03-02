using DapperUygulama.Entities;
using System;
using System.Windows.Forms;

namespace DapperUygulama.Formlar
{
    public partial class FrmIsler : Form
    {
        Kullanici kullanici;
        public FrmIsler(Kullanici _kullanici)
        {
            kullanici = _kullanici;
            InitializeComponent();
        }

        private void FrmIsler_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnBekleyen_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            FrmBekleyenler frm = new FrmBekleyenler(kullanici);
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.BringToFront();
            panel1.Controls.Add(frm);
            frm.Show();
        }

        private void btnTamamlananlar_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            FrmTamamlananlar frm = new FrmTamamlananlar(kullanici);
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.BringToFront();
            panel1.Controls.Add(frm);
            frm.Show();
        }

        private void FrmIsler_Load(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            FrmBekleyenler frm = new FrmBekleyenler(kullanici);
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.BringToFront();
            panel1.Controls.Add(frm);
            frm.Show();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

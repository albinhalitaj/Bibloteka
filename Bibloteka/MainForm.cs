using System;
using System.Windows.Forms;
using Bibloteka.BusinessObjects;
using Bibloteka.Forms;
using Bibloteka.Forms.Reports.HuazimetReport;
using Bibloteka.Forms.Reports.KlientetReport;
using Bibloteka.Forms.Reports.KthimetReport;
using Bibloteka.Forms.Reports.LibratReport;

namespace Bibloteka
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private readonly Perdoruesi _perdoruesi;
        public MainForm(Perdoruesi perdoruesi)
        {
            _perdoruesi = perdoruesi;
            InitializeComponent();
            Customize();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblUser.Text = @"User:   " + _perdoruesi.Username;
            OpenForm(new frm_Ballina(_perdoruesi.Stafi));
        }

        private Form _fromActive;
        private void OpenForm(Form form)
        {
            _fromActive?.Close();
            _fromActive = form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            Wrapper.Controls.Add(form);
            Wrapper.Tag = form;
            form.BringToFront();
            form.Show();
        }

        private void Customize() => panelReportsSubMenu.Visible = false;

        private void HideSubMenu()
        {
            if (panelReportsSubMenu.Visible) panelReportsSubMenu.Visible = false;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnBallina_Click(object sender, EventArgs e) => OpenForm(new frm_Ballina(_perdoruesi.Stafi));

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) => Application.Exit();

        private void btnKategorite_Click(object sender, EventArgs e) => OpenForm(new frm_Kategorite(_perdoruesi.Stafi));

        private void btnKlientet_Click(object sender, EventArgs e) => OpenForm(new frm_Klientet(_perdoruesi.Stafi));

        private void btnHuazimet_Click(object sender, EventArgs e) => OpenForm(new frm_Huazimet(_perdoruesi.Stafi));

        private void btnLibrat_Click(object sender, EventArgs e) => OpenForm(new frm_Librat(_perdoruesi.Stafi));

        private void btnRaportet_Click(object sender, EventArgs e) => ShowSubMenu(panelReportsSubMenu);

        private void btnKlientReport_Click(object sender, EventArgs e)
        {
            var klientReport = new frm_KlientReport();
            klientReport.ShowDialog();
        }

        private void btnLibratReport_Click(object sender, EventArgs e)
        {
            var libratReport = new frm_LibratReport();
            libratReport.ShowDialog();
        }

        private void btnHuazimetReport_Click(object sender, EventArgs e)
        {
            var huazimetReport = new frm_HuazimetReport();
            huazimetReport.ShowDialog();
        }

        private void btnKthimetReport_Click(object sender, EventArgs e)
        {
            var kthimetReport = new frm_KthimetReport();
            kthimetReport.ShowDialog();
        }

        private void btnStafi_Click_1(object sender, EventArgs e) => OpenForm(new frm_Stafi(_perdoruesi.Stafi));

        private void btnLogout_Click(object sender, EventArgs e) => Application.Restart();
    }
}

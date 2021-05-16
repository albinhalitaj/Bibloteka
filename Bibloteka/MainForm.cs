using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bibloteka.BusinessObjects;
using Bibloteka.Forms;

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
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblPunetori.Text = @"User:     " + _perdoruesi.Username;
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

        private void btnBallina_Click(object sender, EventArgs e) => OpenForm(new frm_Ballina(_perdoruesi.Stafi));

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) => Application.Exit();
    }
}

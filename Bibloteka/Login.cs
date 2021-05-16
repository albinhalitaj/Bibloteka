using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bibloteka.BusinessLogicLayer;
using Bibloteka.BusinessObjects;

namespace Bibloteka
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnKyqu_Click(object sender, EventArgs e)
        {
            var signInManager = new SignInManager();
            if (txtPerdoruesi.Text.Trim().Length == 0) epLogin.SetError(txtPerdoruesi, "Ju lutem shënoni përdoruesin!");
            if (txtFjalekalimi.Text.Trim().Length == 0)
                epLogin.SetError(txtPerdoruesi, "Ju lutem shënoni fjalëkalimin!");
            else
            {
                var model = new Perdoruesi()
                {
                    Username = txtPerdoruesi.Text,
                    Password = txtFjalekalimi.Text
                };
                var user = signInManager.LoginUser(model);
                if (user!=null)
                {
                    var dashboard = new MainForm(user);
                    dashboard.Show();
                    Hide();
                }
                else
                    MessageBox.Show(@"Përdoruesi ose fjalëkalimi është gabim!", @"Information", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }
        }
    }
}

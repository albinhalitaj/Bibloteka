using System;
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
                var model = new Perdoruesi
                {
                    Username = txtPerdoruesi.Text,
                    Password = txtFjalekalimi.Text
                };
                var user = signInManager.LoginUser(model);
                if (user!=null)
                {
                    switch (user.Roli.Emertimi)
                    {
                        case "Administrator":
                        {
                            var dashboard = new MainForm(user);
                            dashboard.Show();
                            Hide();
                            break;
                        }
                        case "Punëtor":
                        {
                            var dashboard = new MainForm(user);
                            dashboard.Show();
                            Hide();
                            break;
                        }
                        case "Public":
                        {
                            var klienti = new KlientiMain();
                            klienti.Show();
                            Hide();
                            break;
                        }
                    }
                }
                else
                    MessageBox.Show(@"Përdoruesi ose fjalëkalimi është gabim!", @"Information", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }
        }
    }
}

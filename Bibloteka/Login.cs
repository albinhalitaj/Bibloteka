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

        public bool RememberMe { get; set; }

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
                if (chkMeMbajMend.Checked)
                {
                    Properties.Settings.Default.userName = model.Username;
                    Properties.Settings.Default.password = model.Password;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.userName = string.Empty;
                    Properties.Settings.Default.password = string.Empty;
                    Properties.Settings.Default.Save();
                }
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

        private void Login_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Properties.Settings.Default.userName)) return;
            txtPerdoruesi.Text = Properties.Settings.Default.userName;
            txtFjalekalimi.Text = Properties.Settings.Default.password;
            chkMeMbajMend.Checked = true;
        }
    }
}

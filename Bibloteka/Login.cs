using System;
using System.Windows.Forms;
using Bibloteka.BusinessLogicLayer;
using Bibloteka.BusinessObjects;
using static System.String;
using static Bibloteka.Properties.Settings;

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
                if (chkMeMbajMend.Checked)
                {
                    Default.userName = model.Username;
                    Default.password = model.Password;
                    Default.Save();
                }
                else
                {
                    Default.userName = Empty;
                    Default.password = Empty;
                    Default.Save();
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
            if (IsNullOrEmpty(Default.userName)) return;
            txtPerdoruesi.Text = Default.userName;
            txtFjalekalimi.Text = Default.password;
            chkMeMbajMend.Checked = true;
        }

        private void btnEnUS_Click(object sender, EventArgs e)
        {
            var lang = new ChangeLanguage();
            lang.UpdateLang("language","en-US");
            Application.Restart();
        }

        private void btnSqXK_Click(object sender, EventArgs e)
        {
            var lang = new ChangeLanguage();
            lang.UpdateLang("language","sq-XK");
            Application.Restart();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Help-Manual.chm", HelpNavigator.Topic, "Login_topic.htm");
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {
                btnHelp_Click(sender,e);
            }
        }
    }
}

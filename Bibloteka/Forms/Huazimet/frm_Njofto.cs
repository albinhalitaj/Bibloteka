using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bibloteka.BusinessLogicLayer;

namespace Bibloteka.Forms.Huazimet
{
    public partial class frm_Njofto : Form
    {
        private readonly string _emaili;
        private readonly string _fullName;
        private readonly NjoftimiService _service;
        public frm_Njofto(string emaili,string fullName)
        {
            _emaili = emaili;
            _fullName = fullName;
            _service = new NjoftimiService();
            InitializeComponent();
        }

        private void frm_Njofto_Load(object sender, EventArgs e)
        {
            txtSubjekti.Focus();
            txtKlienti.Text = _fullName;
            txtKlienti.Enabled = false;
            txtEmaili.Text = _emaili;
            txtEmaili.Enabled = false;
        }

        private void btnAnulo_Click(object sender, EventArgs e) => Close();

        private void btnNjofto_Click(object sender, EventArgs e)
        {
            if (txtSubjekti.Text.Trim().Length == 0)
            {
                epNjoftimi.SetError(txtSubjekti,"Ju lutem shkruani subjektin e mesazhit!");
            }
            else if (txtMesazhi.BodyText.Trim().Length == 0)
            {
                epNjoftimi.SetError(txtMesazhi,"Ju lutem shkruani mesazhin!");
            }
            else
            {
                var client = _service.ConfigureClient();
                var from = new MailAddress(_service.Email, _service.From);
                var to = new MailAddress(txtEmaili.Text, txtKlienti.Text);
                var message = new MailMessage
                {
                    From = from,
                    Subject = txtSubjekti.Text,
                    Body = txtMesazhi.BodyText,
                    IsBodyHtml = true
                };
                message.To.Add(to);
                try
                {
                    client.Send(message);
                    MessageBox.Show(@"Mesazhi u dërgua me sukses!", @"Information", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    Close();
                }
                catch (Exception)
                {
                    MessageBox.Show(@"Ndodhi nje gabim. Ju lutem provoni perseri", @"Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:\\Users\\albikk\\source\\repos\\Bibloteka\\Bibloteka\\Help-Manual.chm",
                HelpNavigator.Topic, "Njoftimi_i_klientit.htm");
        }
    }
}

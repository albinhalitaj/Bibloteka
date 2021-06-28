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

namespace Bibloteka.Forms
{
    public partial class frm_Shto : Form
    {
        private readonly frm_Kategorite _main;
        private readonly Stafi _stafi;
        private readonly KategoriaManager _kategoriaManager;

        public frm_Shto(frm_Kategorite main,Stafi stafi)
        {
            _main = main;
            _stafi = stafi;
            _kategoriaManager = new KategoriaManager();
            InitializeComponent();
        }

        private void btnShto_Click(object sender, EventArgs e)
        {
            if (txtEmertimi.Text.Trim().Length == 0)
                epKategorite.SetError(txtEmertimi, "Ju lutem shkruani emertimin e kategorisë!");
            else
            {
                var kategoria = new Kategoria
                {
                    Emertimi = txtEmertimi.Text,
                    Pershkrimi = txtPershkrimi.Text,
                    InsertBy = _stafi.StafiId,
                    InsertDate = DateTime.Now
                };
                _kategoriaManager.Add(kategoria);
                MessageBox.Show(@"Kategoria u ruajt me sukses", @"Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Close();
                _main.LoadCategories();
            }
        }
        private void btnAnulo_Click(object sender, EventArgs e) => Close();


        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:\\Users\\albikk\\source\\repos\\Bibloteka\\Bibloteka\\Help-Manual.chm",
                HelpNavigator.Topic, "Instertimi_i_Kategorise.htm");
        }
    }
}

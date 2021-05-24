using System;
using System.Windows.Forms;
using Bibloteka.BusinessLogicLayer;
using Bibloteka.BusinessObjects;

namespace Bibloteka.Forms
{
    public partial class frm_Edito : Form
    {
        private readonly frm_Kategorite _main;
        private readonly Stafi _stafi;
        private readonly KategoriaManager _kategoriaManager;
        private readonly int _id;
        private readonly Kategoria _kategoria;

        public frm_Edito(Stafi stafi, 
            frm_Kategorite main,int id, Kategoria kategoria)
        {
            _stafi = stafi;
            _main = main;
            _id = id;
            _kategoria = kategoria;
            _kategoriaManager = new KategoriaManager();
            InitializeComponent();
        }

        private void frm_Edito_Load(object sender, EventArgs e)
        {
            txtEmertimi.Text = _kategoria.Emertimi;
            txtPershkrimi.Text = _kategoria.Pershkrimi;
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
                    Lun = _main.LastUpdatedNumber(_id),
                    Lud = DateTime.Now,
                    Lub = _stafi.StafiId
                };
                _kategoriaManager.Update(_id, kategoria);
                MessageBox.Show(@"Kategoria u përditësua me sukses!", @"Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                _main.LoadCategories();
                Close();
            }

        }

        private void btnAnulo_Click(object sender, EventArgs e) => Close();
    }
}

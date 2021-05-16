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
    public partial class frm_Kategorite : Form
    {
        private readonly Stafi _stafi;
        private readonly KategoriaManager _kategoriaManager;
        public frm_Kategorite(Stafi stafi)
        {
            _kategoriaManager = new KategoriaManager();
            _stafi = stafi;
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
                MessageBox.Show("Kategoria u ruajt me sukses", "Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                LoadCategories();
                ClearForm();
            }
        }

        private void LoadCategories()
        {
            dgv_Kategorite.Rows.Clear();
            var dt = _kategoriaManager.Load();
            if (dt.Rows.Count <= 0) return;
            foreach (DataRow kategori in dt.Rows)
            {
                var categoryRow = new DataGridViewRow();
                categoryRow.CreateCells(dgv_Kategorite);
                categoryRow.Cells[0].Value = Convert.ToInt32(kategori[0]);
                categoryRow.Cells[1].Value = Convert.ToString(kategori[1]);
                categoryRow.Cells[2].Value = Convert.ToString(kategori[2]);
                dgv_Kategorite.Rows.Add(categoryRow);
            }
        }

        private void frm_Kategorite_Load(object sender, EventArgs e) => LoadCategories();

        private void ClearForm()
        {
            txtEmertimi.Clear();
            txtPershkrimi.Clear();
            txtEmertimi.Focus();
            epKategorite.Clear();
        }
    }
}

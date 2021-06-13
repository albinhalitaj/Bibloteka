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
using Bibloteka.Forms.Librat;

namespace Bibloteka.Forms
{
    public partial class frm_Librat : Form
    {
        private readonly Stafi _stafi;
        private readonly LibriManager _libriManager;
        private readonly GjuhaManager _gjuhaManager;
        private readonly FormatiManager _formatiManager;
        private readonly KategoriaManager _kategoriaManager;
        public frm_Librat(Stafi stafi)
        {
            _gjuhaManager = new GjuhaManager();
            _formatiManager = new FormatiManager();
            _kategoriaManager = new KategoriaManager();
            _stafi = stafi;
            _libriManager = new LibriManager();
            InitializeComponent();
        }

        private void frm_Librat_Load(object sender, EventArgs e)
        {
            LoadLibrat();
        }

        private void btnShto_Click(object sender, EventArgs e)
        {
            var frmShto = new frm_ShtoLiber(_stafi,null,new Libri());
            frmShto.ShowDialog();
            LoadLibrat();
            lblTotalLibra.Text = @"Total Libra: " + _libriManager.Count();
        }

        private void LoadLibrat()
        {
            dgv_Librat.Rows.Clear();
            var dt = _libriManager.Load();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow liber in dt.Rows)
                {
                    var liberRow = new DataGridViewRow();
                    liberRow.CreateCells(dgv_Librat);
                    liberRow.Cells[0].Value = Convert.ToString(liber[0]);
                    liberRow.Cells[1].Value = Convert.ToString(liber[1]);
                    liberRow.Cells[2].Value = Convert.ToString(liber[2]);
                    liberRow.Cells[3].Value = Convert.ToString(liber[3]);
                    liberRow.Cells[4].Value = Convert.ToString(liber[4]);
                    liberRow.Cells[5].Value = Convert.ToString(liber[5]);
                    liberRow.Cells[6].Value = Convert.ToString(liber[6]);
                    liberRow.Cells[7].Value = Convert.ToString(liber[7]);
                    liberRow.Cells[8].Value = Convert.ToString(liber[8]);
                    liberRow.Cells[9].Value = Convert.ToString(liber[9]);
                    liberRow.Cells[10].Value = Convert.ToBoolean(liber[10]) ? imageList1.Images[0] : imageList1.Images[1];
                    liberRow.Cells[11].Value = imageList2.Images[0];
                    liberRow.Cells[12].Value = imageList2.Images[1];
                    dgv_Librat.Rows.Add(liberRow);
                }
            }
            lblTotalLibra.Text = @"Total Libra: " + _libriManager.Count();
        }

        private void dgv_Librat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Librat.CurrentCell.ColumnIndex.Equals(12)) FshiLibrin();
            if (dgv_Librat.CurrentCell.ColumnIndex.Equals(11)) EditoLibrin();
        }

        private void EditoLibrin()
        {
            var id = Convert.ToString(dgv_Librat.CurrentRow?.Cells[0].Value);
            var editoLiber = new frm_ShtoLiber(_stafi,id,GetLibriDetails());
            editoLiber.ShowDialog();
            LoadLibrat();
        }

        public Libri GetLibriDetails()
        {
            if (dgv_Librat.Rows.Count <= 0)
                return null;
            if (dgv_Librat.SelectedRows.Count <= 0)
                return null;
            var libri = new Libri
            {
                Titulli = Convert.ToString(dgv_Librat.CurrentRow?.Cells[1].Value),
                Autori = Convert.ToString(dgv_Librat.CurrentRow?.Cells[2].Value),
                Botuesi = Convert.ToString(dgv_Librat.CurrentRow?.Cells[3].Value),
                GjuhaId = _gjuhaManager.GetId(Convert.ToString(dgv_Librat.CurrentRow?.Cells[4].Value)),
                TipiId = _formatiManager.GetId(Convert.ToString(dgv_Librat.CurrentRow?.Cells[5].Value)),
                KategoriaId = _kategoriaManager.GetId(Convert.ToString(dgv_Librat.CurrentRow?.Cells[6].Value)),
                Isbn = Convert.ToString(dgv_Librat.CurrentRow?.Cells[7].Value),
                Editioni = Convert.ToString(dgv_Librat.CurrentRow?.Cells[8].Value),
                NumriKopjeve = Convert.ToInt32(dgv_Librat.CurrentRow?.Cells[9].Value),
            };
            libri.Statusi = libri.NumriKopjeve > 0;
            return libri;
        }

        private void FshiLibrin()
        {
            if (MessageBox.Show(@"A jeni i sigurt qe deshironi ta fshihni këtë libër?",@"Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var id = Convert.ToString(dgv_Librat.CurrentRow?.Cells[0].Value);
                _libriManager.Remove(id);
                MessageBox.Show(@"Libri u fshi me sukses!", @"Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                LoadLibrat();
                lblTotalLibra.Text = @"Total Libra: " + _libriManager.Count();
            }
        }

        private void txtKerko_TextChanged(object sender, EventArgs e)
        {
            if (txtKerko.Text.Trim().Length != 0)
            {
                dgv_Librat.Rows.Clear();
                try
                {
                    var librat = _libriManager.Search(txtKerko.Text);
                    if (librat.Rows.Count > 0)
                    {
                        foreach (DataRow liber in librat.Rows)
                        {
                            var liberRow = new DataGridViewRow();
                            liberRow.CreateCells(dgv_Librat);
                            liberRow.Cells[0].Value = Convert.ToString(liber[0]);
                            liberRow.Cells[1].Value = Convert.ToString(liber[1]);
                            liberRow.Cells[2].Value = Convert.ToString(liber[2]);
                            liberRow.Cells[3].Value = Convert.ToString(liber[3]);
                            liberRow.Cells[4].Value = Convert.ToString(liber[4]);
                            liberRow.Cells[5].Value = Convert.ToString(liber[5]);
                            liberRow.Cells[6].Value = Convert.ToString(liber[6]);
                            liberRow.Cells[7].Value = Convert.ToString(liber[7]);
                            liberRow.Cells[8].Value = Convert.ToString(liber[8]);
                            liberRow.Cells[9].Value = Convert.ToString(liber[9]);
                            liberRow.Cells[10].Value = Convert.ToBoolean(liber[10]) ? imageList1.Images[0] : imageList1.Images[1];
                            liberRow.Cells[11].Value = imageList2.Images[0];
                            liberRow.Cells[12].Value = imageList2.Images[1];
                            dgv_Librat.Rows.Add(liberRow);
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show(@"Ndodhi nje gabim. Ju lutem provoni perseri", @"Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
                LoadLibrat();
        }
    }
}

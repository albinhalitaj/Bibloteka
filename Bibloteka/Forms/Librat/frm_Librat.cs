using System;
using System.Data;
using System.Windows.Forms;
using Bibloteka.BusinessLogicLayer;
using Bibloteka.BusinessObjects;
using Bibloteka.Forms.Librat;
using ClosedXML.Excel;

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
            LoadLibrat(_libriManager.Load());
        }

        private void btnShto_Click(object sender, EventArgs e)
        {
            var frmShto = new frm_ShtoLiber(_stafi,null,new Libri());
            frmShto.ShowDialog();
            LoadLibrat(_libriManager.Load());
            lblTotalLibra.Text = @"Total Libra: " + _libriManager.Count();
        }

        private void LoadLibrat(DataTable dt)
        {
            dgv_Librat.Rows.Clear();
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
            LoadLibrat(_libriManager.Load());
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
            if (MessageBox.Show(@"A jeni i sigurt qe deshironi ta fshihni këtë libër?", @"Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;
            var id = Convert.ToString(dgv_Librat.CurrentRow?.Cells[0].Value);
            var result = _libriManager.Remove(id);
            MessageBox.Show(result ? @"Libri u fshi me sukses!" : @"Ky libër nuk mund të fshihet!", @"Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            LoadLibrat(_libriManager.Load());
            lblTotalLibra.Text = @"Total Libra: " + _libriManager.Count();
        }

        private void txtKerko_TextChanged(object sender, EventArgs e)
        {
            if (txtKerko.Text.Trim().Length != 0)
            {
                dgv_Librat.Rows.Clear();
                try
                {
                    var librat = _libriManager.Search(txtKerko.Text);
                    LoadLibrat(librat);
                }
                catch (Exception)
                {
                    MessageBox.Show(@"Ndodhi nje gabim. Ju lutem provoni perseri", @"Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
                LoadLibrat(_libriManager.Load());
        }

        private void btnShkarko_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog { Filter = @"Excel WorkBook|*.xlsx" })
            {
                if (sfd.ShowDialog() != DialogResult.OK) return;
                try
                {
                    using (var workbook = new XLWorkbook())
                    {
                        var ts = workbook.Worksheets.Add(_libriManager.Load(), "Librat");
                        ts.Columns().AdjustToContents();
                        ts.Rows().AdjustToContents();
                        workbook.SaveAs(sfd.FileName);
                    }
                    MessageBox.Show(@"Të dhënat janë eksportuar me sukses!", @"Information", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show(@"Ndodhi një gabim ju lutem provoni përsëri", @"Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
    }
}

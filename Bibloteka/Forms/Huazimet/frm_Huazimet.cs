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
using Bibloteka.Forms.Huazimet;
using Microsoft.VisualBasic;

namespace Bibloteka.Forms
{
    public partial class frm_Huazimet : Form
    {
        private readonly Stafi _stafi;
        private readonly HuazimetManager _huazimetManager;
        private readonly KlientiManager _klientiManager;
        private readonly KthimetManager _kthimetManager;

        public frm_Huazimet(Stafi stafi)
        {
            _stafi = stafi;
            _huazimetManager = new HuazimetManager();
            _klientiManager = new KlientiManager();
            _kthimetManager = new KthimetManager();
            InitializeComponent();
        }

        private void btnHuazo_Click(object sender, EventArgs e)
        {
            var frmHuazo = new frm_HuazoLiber(this,_stafi);
            frmHuazo.Show();
        }


        public void LoadData(DataTable huazimet)
        {
            dgv_Huazimet.Rows.Clear();
            if (huazimet.Rows.Count <= 0) return;
            foreach (DataRow huazimetRow in huazimet.Rows)
            {
                var huazimiRow = new DataGridViewRow();
                huazimiRow.CreateCells(dgv_Huazimet);
                huazimiRow.Cells[0].Value = Convert.ToInt32(huazimetRow[0]);
                huazimiRow.Cells[1].Value = Convert.ToString(huazimetRow[2]);
                huazimiRow.Cells[2].Value = Convert.ToString(huazimetRow[1]);
                huazimiRow.Cells[3].Value = Convert.ToInt32(huazimetRow[3]);
                huazimiRow.Cells[4].Value = Convert.ToDateTime(huazimetRow[4]).ToString("dd/MM/yyyy");
                huazimiRow.Cells[5].Value = Convert.ToDateTime(huazimetRow[5]).ToString("dd/MM/yyyy");
                if (Convert.ToBoolean(huazimetRow[6]))
                {
                    huazimiRow.Cells[6].Value = imageList1.Images[0];
                    huazimiRow.Cells[7].Value = imageList2.Images[0];
                    huazimiRow.DefaultCellStyle.NullValue = null;
                    if (Convert.ToDateTime(huazimetRow[5]) < DateTime.Now)
                    {
                        huazimiRow.Cells[8].Value = imageList2.Images[1];
                    }
                }
                else
                {
                    huazimiRow.Cells[6].Value = imageList1.Images[1];
                    huazimiRow.DefaultCellStyle.NullValue = null;
                }
                dgv_Huazimet.Rows.AddRange(huazimiRow);
            }
        }

        private void frm_Huazimet_Load(object sender, EventArgs e)
        {
            LoadData(_huazimetManager.GetHuazimetEMuajitAktual());
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            var nga = Convert.ToDateTime(ngaData.Value);
            var deri = Convert.ToDateTime(deriData.Value);
            LoadData(_huazimetManager.Filtro(nga,deri));
        }

        private void txtKerko_TextChanged(object sender, EventArgs e)
        {
            if (txtKerko.Text.Trim().Length != 0)
            {
                dgv_Huazimet.Rows.Clear();
                try
                {
                    LoadData(_huazimetManager.Search(txtKerko.Text));
                }
                catch (Exception)
                {
                    MessageBox.Show(@"Ndodhi nje gabim. Ju lutem provoni perseri", @"Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
                LoadData(_huazimetManager.GetHuazimetEMuajitAktual());
        }

        private void dgv_Huazimet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var huazimiId = Convert.ToInt32(dgv_Huazimet.CurrentRow?.Cells[0].Value);
            if (dgv_Huazimet.CurrentCell.ColumnIndex.Equals(8))
            {
                var huazimi = _huazimetManager.GetHuazimiById(huazimiId);
                var dt = _klientiManager.GetById(huazimi.KlientiId);
                var emaili = string.Empty;
                var fullName = string.Empty;
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        emaili = Convert.ToString(row[11]);
                        fullName = string.Concat(Convert.ToString(row[1]), " ", Convert.ToString(row[2]));
                    }
                }
                var frmNjofto = new frm_Njofto(emaili,fullName);
                frmNjofto.ShowDialog();
            }

            if (dgv_Huazimet.CurrentCell.ColumnIndex.Equals(7))
            {
                var kthimi = _kthimetManager.GetKthimiData(huazimiId);
                var frmKthe = new frm_Kthimet(this,kthimi,_stafi);
                frmKthe.ShowDialog();
            }
        }
    }
}

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

namespace Bibloteka.Forms.Librat
{
    public partial class frm_ShtoLiber : Form
    {
        private readonly KategoriaManager _kategoriaManager;
        private readonly GjuhaManager _gjuhaManager;
        private readonly FormatiManager _formatiManager;
        private readonly Stafi _stafi;
        public frm_ShtoLiber(Stafi stafi)
        {
            _stafi = stafi;
            _formatiManager = new FormatiManager();
            _kategoriaManager = new KategoriaManager();
            _gjuhaManager = new GjuhaManager();
            InitializeComponent();
        }

        private void btnAnulo_Click(object sender, EventArgs e) => Close();

        private void frm_ShtoLiber_Load(object sender, EventArgs e)
        {
            LoadComboBoxses();
        }

        public void LoadComboBoxses()
        {
            var kategorite = new List<Kategoria>();
            var dt = _kategoriaManager.Load();
            if (dt.Rows.Count > 0)
                kategorite.AddRange(from DataRow category in dt.Rows
                    select new Kategoria {Emertimi = Convert.ToString(category[1])});
            foreach (var kategoria in kategorite) comboKategoria.Items.Add(kategoria.Emertimi);
            comboKategoria.Items.Add("Shto Kategori të re...");
            var gjuhet = _gjuhaManager.Load();
            foreach (var gjuha in gjuhet) comboGjuha.Items.Add(gjuha.Emertimi);

            var formatet = _formatiManager.Load();
            foreach (var formati in formatet) comboTipi.Items.Add(formati.Emri);
            comboStatusi.SelectedIndex = 1;
            comboKategoria.SelectedIndex = 0;
            comboGjuha.SelectedIndex = 0;
            comboTipi.SelectedIndex = 0;
        }

        private void txtSasia_ValueChanged(object sender, EventArgs e) => comboStatusi.SelectedIndex = Convert.ToInt32(txtSasia.Value) > 0 ? 0 : 1;

        private void comboKategoria_Click(object sender, EventArgs e)
        {
            comboKategoria.Items.Clear();
            LoadComboBoxses();
        }

        private void comboKategoria_SelectedValueChanged(object sender, EventArgs e)
        {
            var totalCategories = _kategoriaManager.Total();
            if (comboKategoria.SelectedIndex == totalCategories)
            {
                var frmmain = new frm_Kategorite(_stafi);
                var frmShtoKategori = new frm_Shto(frmmain, _stafi);
                frmShtoKategori.ShowDialog();
            }
        }
    }
}

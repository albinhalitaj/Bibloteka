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
        private readonly LibriManager _libriManager;
        public frm_ShtoLiber(Stafi stafi)
        {
            _stafi = stafi;
            _formatiManager = new FormatiManager();
            _kategoriaManager = new KategoriaManager();
            _gjuhaManager = new GjuhaManager();
            _libriManager = new LibriManager();
            InitializeComponent();
        }

        private void btnAnulo_Click(object sender, EventArgs e) => Close();

        private void frm_ShtoLiber_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadComboBoxses();
        }

        public void LoadComboBoxses()
        {
            var gjuhet = _gjuhaManager.Load();
            foreach (var gjuha in gjuhet) comboGjuha.Items.Add(gjuha.Emertimi);

            var formatet = _formatiManager.Load();
            foreach (var formati in formatet) comboTipi.Items.Add(formati.Emri);
            comboStatusi.SelectedIndex = 1;
            comboKategoria.SelectedIndex = 1;
            comboGjuha.SelectedIndex = 1;
            comboTipi.SelectedIndex = 1;
        }

        public void LoadCategories()
        {
            comboKategoria.Items.Add("Zgjedh Kategorinë");
            var kategorite = new List<Kategoria>();
            var dt = _kategoriaManager.Load();
            if (dt.Rows.Count > 0)
                kategorite.AddRange(from DataRow category in dt.Rows
                    select new Kategoria {Emertimi = Convert.ToString(category[1])});
            foreach (var kategoria in kategorite) comboKategoria.Items.Add(kategoria.Emertimi);
            comboKategoria.Items.Add("Shto Kategori të re...");
        }

        private void txtSasia_ValueChanged(object sender, EventArgs e) => comboStatusi.SelectedIndex = Convert.ToInt32(txtSasia.Value) > 0 ? 0 : 1;

        private void comboKategoria_Click(object sender, EventArgs e)
        {
            comboKategoria.Items.Clear();
            LoadCategories();
        }

        private void comboKategoria_SelectedValueChanged(object sender, EventArgs e)
        {
            var totalCategories = _kategoriaManager.Total();
            if (comboKategoria.SelectedIndex == totalCategories + 1)
            {
                var frmmain = new frm_Kategorite(_stafi);
                var frmShtoKategori = new frm_Shto(frmmain, _stafi);
                frmShtoKategori.ShowDialog();
                comboKategoria.Items.Clear();
                LoadCategories();
                //comboKategoria.SelectedIndex = totalCategories;
            }
        }

        private void btnShto_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsValid()) return;
                var statusi = comboStatusi.SelectedIndex == 0;
                var libri = new Libri
                {
                    Titulli = txtTitulli.Text,
                    Autori = txtAutori.Text,
                    Botuesi = txtBotuesi.Text,
                    GjuhaId = _gjuhaManager.GetId(Convert.ToString(comboGjuha.SelectedItem)),
                    TipiId = _formatiManager.GetId(Convert.ToString(comboTipi.SelectedItem)),
                    KategoriaId = _kategoriaManager.GetId(Convert.ToString(comboKategoria.SelectedItem)),
                    Isbn = txtISBN.Text,
                    Editioni = txtEdtitioni.Text,
                    Sasia = txtSasia.Value,
                    Statusi = statusi,
                    InsertBy = _stafi.StafiId,
                    InsertDate = DateTime.Now
                };
                _libriManager.Add(libri);
                MessageBox.Show(@"Libri u shtua me sukses!", @"Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        public bool IsValid()
        {
            epLibri.Clear();
            var status = true;
            if (txtTitulli.Text.Trim().Length == 0)
            {
                epLibri.SetError(txtTitulli,"Ju lutem shkruani titullin e librit!");
                status = false;
            }
            else if (txtAutori.Text.Trim().Length == 0)
            {
                epLibri.SetError(txtAutori,"Ju lutem shkurani autorin/ët e librit");
                status = false;
            }
            else if (txtAutori.Text.Trim().Length == 0)
            {
                epLibri.SetError(txtBotuesi,"Ju lutem shkruani botuesin e librit");
                status = false;
            }
            else if (comboGjuha.SelectedIndex == 0)
            {
                epLibri.SetError(comboGjuha,"Ju lutem selektoni një gjuhë");
                status = false;
            }
            else if (comboTipi.SelectedIndex == 0)
            {
                epLibri.SetError(comboTipi,"Ju lutem selektoni një format");
                status = false;
            }
            else if (comboKategoria.SelectedIndex == 0)
            {
                epLibri.SetError(comboKategoria,"Ju lutem selektoni një kategori");
                status = false;
            }
            else if (txtISBN.Text.Trim().Length == 0)
            {
                epLibri.SetError(txtISBN,"Ju lutem shkruani ISBN-n");
                status = false;
            }
            return status;
        }
    }
}

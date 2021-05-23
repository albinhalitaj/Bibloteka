using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bibloteka.BusinessObjects;
using Bibloteka.DataAccessLayer;

namespace Bibloteka.BusinessLogicLayer
{
    public class KategoriaManager
    {
        private readonly KategoriaDal _context;
        public KategoriaManager() => _context = new KategoriaDal();

        public void Add(Kategoria kategoria) => _context.ShtoKategori(kategoria);

        public void Update(int id, Kategoria kategoria) => _context.EditoKategori(id, kategoria);

        public void Remove(int id) => _context.FshiKategori(id);

        public DataTable GetById(int id) => _context.GetCategoryById(id);

        public DataTable Load() => _context.GetAllCategories();

        public DataTable Search(string query) => _context.SearchCategories(query);

        public int Total() => _context.Total();
        public int GetId(string emri) => _context.GetCategoryId(emri);
    }
}

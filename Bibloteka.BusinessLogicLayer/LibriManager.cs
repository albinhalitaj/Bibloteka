using System.Data;
using Bibloteka.BusinessObjects;
using Bibloteka.DataAccessLayer;

namespace Bibloteka.BusinessLogicLayer
{
    public class LibriManager
    {
        private readonly LibriDal _libriDal;
        public LibriManager() => _libriDal = new LibriDal();
        public void Add(Libri libri) => _libriDal.InsertLiber(libri);
        public void Update(string id, Libri libri) => _libriDal.UpdateLiber(id, libri);
        public void Remove(string id) => _libriDal.DeleteLiber(id);
        public DataTable Load() => _libriDal.GetAllLibrat();
        public Libri FindById(string id) => _libriDal.GetLiberById(id);
        public int Count() => _libriDal.GetTotal();
        public DataTable Search(string query) => _libriDal.SearchLibra(query);
    } 
}

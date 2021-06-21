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
    public class KlientiManager
    {
        private readonly KlientiDal _klientiDal;
        public KlientiManager() => _klientiDal = new KlientiDal();
        public void Add(Klienti klienti) => _klientiDal.ShtoKlient(klienti);
        public DataTable Load() => _klientiDal.GetAllKlients();
        public bool Remove(string id) => _klientiDal.FshiKlient(id);
        public int Count() => _klientiDal.TotalKlients();
        public void Update(string id, Klienti klienti) => _klientiDal.Ndrysho(id, klienti);
        public DataTable GetById(string id) => _klientiDal.GetKlientById(id);
        public DataTable Search(string query) => _klientiDal.SearchKlients(query);
    }
}

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
    public class HuazimetManager
    {
        private readonly HuazimetDal _huazimetDal;
        public HuazimetManager()
        {
            _huazimetDal = new HuazimetDal();
        }

        public List<Klienti> GetKlients() => _huazimetDal.GetKlientet();
        public List<Libri> GetLibrat() => _huazimetDal.GetLibrat();

        public void Huazo(Huazimi huazimi) => _huazimetDal.HuazoLiber(huazimi);
        public void ShtoAktivitet(Aktiviteti act) => _huazimetDal.ShtoAktivitetin(act);
        public DataTable GetHuazimetEMuajitAktual() => _huazimetDal.LoadHuazimetMuajtiAktual();
        public DataTable Filtro(DateTime nga, DateTime deri) => _huazimetDal.FiltroHuazimet(nga, deri);
        public DataTable Search(string query) => _huazimetDal.Kerko(query);
        public Huazimi GetHuazimiById(int id) => _huazimetDal.GetHuazimById(id);
    }
}

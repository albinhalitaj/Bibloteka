using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bibloteka.BusinessObjects;
using Bibloteka.DataAccessLayer;

namespace Bibloteka.BusinessLogicLayer
{
    public class KthimetManager
    {
        private readonly KthimetDal _kthimetDal;
        public KthimetManager()
        {
            _kthimetDal = new KthimetDal();
        }

        public Kthimi GetKthimiData(int id) => _kthimetDal.GetHuazimiById(id);
        public void ShtoGjobe(Gjoba gjoba) => _kthimetDal.ShtoGjobe(gjoba);
        public void Kthe(string libriId, int id, int sasia) => _kthimetDal.KtheLibrin(libriId, id, sasia);
    }
}

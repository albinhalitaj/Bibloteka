using Bibloteka.BusinessObjects;
using Bibloteka.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteka.BusinessLogicLayer
{
    public class RoliManager
    {
        public readonly RoliDal RoliDal;
        public RoliManager() => RoliDal = new RoliDal();
        public List<Roli> Load() => RoliDal.GetRoli();
        public int GetId(string emri) => RoliDal.GetRoliById(emri);
        public string GetName(int id) => RoliDal.GetNameById(id);
    }
}

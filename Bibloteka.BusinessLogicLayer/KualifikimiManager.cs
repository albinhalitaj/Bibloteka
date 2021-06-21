using Bibloteka.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bibloteka.DataAccessLayer;

namespace Bibloteka.BusinessLogicLayer
{
    public class KualifikimiManager
    {
        public readonly KualifikimiDal KualifikimDal;
        public KualifikimiManager() => KualifikimDal = new KualifikimiDal();
        public List<Kualifikimi> Load() => KualifikimDal.GetKualifikimin();
        public int GetId(string emri) => KualifikimDal.GetKualifikimetById(emri);
        public string GetName(int id) => KualifikimDal.GetNameById(id);
    }
}

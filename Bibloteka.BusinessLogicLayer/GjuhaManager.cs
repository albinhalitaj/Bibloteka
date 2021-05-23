using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bibloteka.BusinessObjects;
using Bibloteka.DataAccessLayer;

namespace Bibloteka.BusinessLogicLayer
{
    public class GjuhaManager
    {
        public readonly GjuhaDal GjuhaDal;
        public GjuhaManager() => GjuhaDal = new GjuhaDal();
        public List<Gjuha> Load() => GjuhaDal.GetLanguages();
        public int GetId(string emri) => GjuhaDal.GetGjuhaById(emri);
        public string GetName(int id) => GjuhaDal.GetNameById(id);
    }
}

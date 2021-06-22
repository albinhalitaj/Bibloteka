using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteka.BusinessLogicLayer
{
    public static class Cities
    {
        public static object[] GetCities(string shteti)
        {
            object[] qytetet = null;
            switch (shteti)
            {
                case "Kosovë":
                    qytetet = new object[] {
                    "Deçan","Gjakovë","Gllogoc","Gjilan", "Dragash", "Istog", "Kaçanik", "Klinë", "Fushë Kosovë", "Kamenicë", "Leposaviq", "Lipjan","Obiliq",
                    "Rahovec", "Pejë","Podujevë","Prishtinë","Prizren","Skënderaj","Shtime","Shtërpcë","Suharekë", "Ferizaj", "Viti", "Vushtrri", "Zubin Potok", "Zveçan", "Malishevë",
                    "Novobërdë","Mitrovicë e Veriu", "Mitrovicë e Jugu", "Junik", "Hani i Elezit", "Mamushë", "Graçanicë", "Ranillug", "Partesh", "Kllokot"};
                    break;
                case "Shqipëri":
                    qytetet = new object[] {"Tirana", "Durrësi", "Shkodra", "Elbasani", "Vlora", "Korça", "Fieri", "Berati", "Lushnja", "Pogradeci", "Kavaja", "Laçi", "Lezha", "Kukësi", "Gjirokastra",
                            "Patosi","Kruja","Kuçova","Saranda","Peshkopia","Burreli","Cërriku","Çorovoda","Shijaku", "Librazhdi", "Tepelena", "Gramshi", "Poliçani", "Bulqiza", "Përmeti", "Fushë-Kruja", "Kamëza",
                            "Rrësheni","Ballshi","Mamurrasi","Bajram Curri", "Erseka", "Peqini", "Divjaka", "Selenica", "Bilishti", "Roskoveci", "Këlcyra", "Puka", "Memaliaj", "Rrogozhina", "Ura Vajgurore", "Himara",
                            "Delvina","Vora", "Kopliku", "Maliqi", "Përrenjasi", "Shtërmeni", "Kruma", "Libohova", "Orikumi", "Fushë-Arrëza", "Shëngjini", "Rubiku", "Miloti", "Leskoviku", "Konispoli", "Krasta", "Kërraba"};
                    break;
                case "Maqedoni":
                    qytetet = new object[] {
                        "Berova", "Dellçeva", "Koçani", "Kamenica", "Peçeva", "Probishtipi", "Shtipi", "Vinica", "Kratova", "Kriva Pallanka", "Kumanova", "Manastiri", "Demir Hisari", "Krusheva", "Prilepi","Resnja",
                        "Gostivari","Tetova", "Shkupi", "Bogdanca", "Gjevgjelia", "Radovishti", "Strumica", "Vallandova", "Dibra", "Kërçova", "Brod", "Ohri", "Struga", "Demir Kapia", "Kavadari", "Negotina","Sveti Nikolla","Velesi"
                    };
                    break;
                case "Mali i Zi":
                    qytetet = new object[] {
                    "Podgorica", "Nikšić", "Herceg Novi", "Pljevlja", "Bar", "Bijelo Polje", "Cetinje", "Budva", "Kotor",
                    "Berane", "Ulcinj", "Tivat", "Rožaje"};
                    break;
            }

            return qytetet;
        }
    }
}

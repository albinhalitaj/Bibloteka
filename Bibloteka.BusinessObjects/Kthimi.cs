using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteka.BusinessObjects
{
    public class Kthimi
    {
        public int HuazimiId { get; set; }
        public string KlientiId { get; set; }
        public string Klienti { get; set; }
        public string LibriId { get; set; }
        public string Libri { get; set; }
        public DateTime DataHuazimit { get; set; }
        public DateTime DataKthimit { get; set; }
        public int Sasia { get; set; }
        public string Pershkrimi { get; set; }
    }
}

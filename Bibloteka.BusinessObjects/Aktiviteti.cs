using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteka.BusinessObjects
{
    public class Aktiviteti
    {
        public string KlientiId { get; set; }
        public string LibriId { get; set; }
        public DateTime Data { get; set; }
        public Tipi Tipi { get; set; }
        public int InsertBy { get; set; }

        public string Klienti { get; set; }
        public string Libri { get; set; }
        
    }

    public enum Tipi
    {
        Huazim,
        Kthim
    }
}

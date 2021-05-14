using System;

namespace Bibloteka.BusinessObjects
{
    public class Kategoria
    {
        public int KategoriaId { get; set; }

        public string Emertimi { get; set; }

        public string Pershkrimi { get; set; }

        public string InsertBy { get; set; }

        public DateTime? InsertDate { get; set; }

        public int? Lub { get; set; }

        public int? Lun { get; set; }

        public DateTime? Lud { get; set; }
    }
}
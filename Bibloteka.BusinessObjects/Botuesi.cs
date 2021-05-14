using System;

namespace Bibloteka.BusinessObjects
{
    public class Botuesi
    {
        public int BotuesiId { get; set; }

        public string Emertimi { get; set; }

        public string Adresa { get; set; }

        public string Qyteti { get; set; }

        public string Shteti { get; set; }

        public string KodiPostal { get; set; }

        public string Telefoni { get; set; }

        public string InsertBy { get; set; }

        public DateTime? InsertDate { get; set; }

        public int? Lub { get; set; }

        public int? Lun { get; set; }

        public DateTime? Lud { get; set; }
    }
}
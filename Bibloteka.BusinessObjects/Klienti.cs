using System;

namespace Bibloteka.BusinessObjects
{
    public class Klienti
    {
        public string KlientiId { get; set; }

        public string Emri { get; set; }

        public string Mbiemri { get; set; }

        public DateTime Datalindjes { get; set; }

        public string Gjinia { get; set; }

        public string NrPersonal { get; set; }

        public string NrKontaktues { get; set; }

        public string Adresa { get; set; }

        public string Qyteti { get; set; }

        public string Shteti { get; set; }

        public string KodiPostal { get; set; }

        public string Emaili { get; set; }

        public string InsertBy { get; set; }

        public DateTime? InsertDate { get; set; }

        public int? Lub { get; set; }

        public int? Lun { get; set; }

        public DateTime? Lud { get; set; }
    }
}
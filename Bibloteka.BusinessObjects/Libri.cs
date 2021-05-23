using System;

namespace Bibloteka.BusinessObjects
{
    public class Libri
    {

        public string LibriId { get; set; }

        public string Titulli { get; set; }

        public string Autori { get; set; }

        public string Botuesi { get; set; }

        public int GjuhaId { get; set; }

        public int TipiId { get; set; }

        public int KategoriaId { get; set; }

        public string Isbn { get; set; }

        public string Editioni { get; set; }
        public long Sasia { get; set; }

        public bool Statusi { get; set; }

        public int? InsertBy { get; set; }

        public DateTime? InsertDate { get; set; }

        public int? Lub { get; set; }

        public int? Lun { get; set; }

        public DateTime? Lud { get; set; }

    }
}
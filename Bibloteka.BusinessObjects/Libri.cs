using System;

namespace Bibloteka.BusinessObjects
{
    public class Libri
    {
        public Libri()
        {
            
        }

        public string LibriId { get; set; }

        public string Titulli { get; set; }

        public int AutoriId { get; set; }

        public int BotuesiId { get; set; }

        public int GjuhaId { get; set; }

        public int TipiId { get; set; }

        public int KategoriaId { get; set; }

        public string Isbn { get; set; }

        public bool Statusi { get; set; }

        public string InsertBy { get; set; }


        public DateTime? InsertDate { get; set; }

        public int? Lub { get; set; }

        public int? Lun { get; set; }

        public DateTime? Lud { get; set; }

    }
}
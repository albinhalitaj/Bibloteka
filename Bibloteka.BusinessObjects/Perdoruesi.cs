using System;

namespace Bibloteka.BusinessObjects
{
    public class Perdoruesi
    {
        public int PerdoruesiId { get; set; }
        public int StafiId { get; set; }
        public int RoliId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool Statusi { get; set; }
        public int? InsertBy { get; set; }
        public DateTime? InsertDate { get; set; }
        public int? Lub { get; set; }
        public int? Lun { get; set; }
        public DateTime? Lud { get; set; }
    }
}
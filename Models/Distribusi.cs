using System;

namespace AgroWasteNexus.Models
{
    public class Distribusi : BaseEntity
    {
        public int IdDistribusi { get; set; }
        public decimal JumlahProduk { get; set; }
        public DateTime TanggalDistribusi { get; set; }
        public decimal HargaSatuan { get; set; }
        public string Status { get; set; }
        public int IdProduk { get; set; }
        public int IdPenerima { get; set; }

        public override int GetId()
        {
            return IdDistribusi;
        }
    }
}
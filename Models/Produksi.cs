using System;

namespace AgroWasteNexus.Models
{
    public class Produksi : BaseEntity
    {
        public int IdProduksi { get; set; }
        public decimal JumlahBahan { get; set; }
        public decimal JumlahHasil { get; set; }
        public decimal BiayaProduksi { get; set; }
        public DateTime TanggalProduksi { get; set; }
        public string Status { get; set; }
        public int IdBatch { get; set; }
        public int IdPengguna { get; set; }

        public override int GetId()
        {
            return IdProduksi;
        }
    }
}
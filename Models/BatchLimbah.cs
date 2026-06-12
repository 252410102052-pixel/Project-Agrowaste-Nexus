using System;

namespace AgroWasteNexus.Models
{
    public class BatchLimbah : BaseEntity
    {
        public int IdBatch { get; set; }
        public decimal Jumlah { get; set; }
        public DateTime TanggalMasuk { get; set; }
        public string Status { get; set; }

        public string GambarBarang { get; set; }
        public string Keterangan { get; set; }

        public int IdPabrik { get; set; }
        public int? IdJadwal { get; set; }

        public override int GetId()
        {
            return IdBatch;
        }
    }
}
using System;

namespace AgroWasteNexus.Models
{
    public class KontrolKualitas : BaseEntity
    {
        public int IdKontrol { get; set; }
        public int NilaiKualitas { get; set; }
        public string StatusKualitas { get; set; }
        public string Catatan { get; set; }
        public DateTime TanggalPemeriksaan { get; set; }
        public int IdPengguna { get; set; }
        public int IdProduksi { get; set; }

        public override int GetId()
        {
            return IdKontrol;
        }
    }
} 
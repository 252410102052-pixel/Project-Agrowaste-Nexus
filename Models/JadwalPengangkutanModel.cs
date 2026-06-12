using System;

namespace AgroWasteNexus.Models
{
    public class JadwalPengangkutanModel : BaseEntity
    {
        public int IdJadwal { get; set; }
        public DateTime TanggalPengangkutan { get; set; }
        public string Status { get; set; }
        public string Catatan { get; set; }
        public int IdPetugas { get; set; }
        public int IdKendaraan { get; set; }

        public override int GetId()
        {
            return IdJadwal;
        }
    }
}
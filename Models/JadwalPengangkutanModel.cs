using System;

namespace AgroWasteNexus.Models
{
    public class JadwalPengangkutan
    {
        public int IdJadwal { get; set; }
        public DateTime TanggalPengangkutan { get; set; }
        public string Status { get; set; }
        public string Catatan { get; set; }
        public int IdPetugas { get; set; }
        public int IdKendaraan { get; set; }
    }
}

namespace AgroWasteNexus.Models
{
    public class JadwalPengangkutanGrid
    {
        public int id_jadwal { get; set; }
        public int petugas_id_petugas { get; set; }
        public int kendaraan_id_kendaraan { get; set; }
        public DateTime tanggal_pengangkutan { get; set; }
        public string status_pengangkutan { get; set; }
        public string catatan { get; set; }
        public string nama_driver { get; set; }
        public string kontak_driver { get; set; }
        public string nama_kendaraan { get; set; }
        public string kapasitas_maksimal { get; set; }
    }
}
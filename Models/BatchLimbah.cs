using System;

namespace AgroWasteNexus.Models
{
    public class BatchLimbah
    {
        public int IdBatch { get; set; }
        public decimal Jumlah { get; set; }
        public DateTime TanggalMasuk { get; set; }
        public string Status { get; set; }
        public string GambarBarang { get; set; }
        public string Keterangan { get; set; }
        public int IdPabrik { get; set; }
        public int? IdJadwal { get; set; }
    }
}

namespace AgroWasteNexus.Models
{
    public class BatchLimbahGrid
    {
        public int id_batch { get; set; }
        public int pabrik_id_pabrik { get; set; }
        public int? jadwal_pengangkutan_id_jadwal { get; set; }
        public decimal volume_kg { get; set; }
        public DateTime tanggal_masuk { get; set; }
        public string status_batch { get; set; }
        public string keterangan { get; set; }
        public string nama_pabrik { get; set; }
        public string alamat_pabrik { get; set; }
        public string kontak_pabrik { get; set; }
    }
}
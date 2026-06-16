using System;

namespace AgroWasteNexus.Models
{
    public class KontrolKualitas
    {
        public int IdKontrol { get; set; }
        public decimal JumlahLolos { get; set; }
        public decimal JumlahGagal { get; set; }
        public int NilaiKualitas { get; set; }
        public string Catatan { get; set; }
        public DateTime TanggalPemeriksaan { get; set; }
        public int IdPengguna { get; set; }
        public int IdProduksi { get; set; }
    }
}

namespace AgroWasteNexus.Models
{
    public class KontrolKualitasGrid
    {
        public int id_kontrol { get; set; }
        public int produksi_id_produksi { get; set; }
        public int pengguna_id_pengguna { get; set; }
        public string nama_produk { get; set; }
        public DateTime tanggal_pemeriksaan { get; set; }
        public decimal jumlah_lolos { get; set; }
        public decimal jumlah_gagal { get; set; }
        public decimal total_diperiksa { get; set; }
        public string catatan { get; set; }
    }
}
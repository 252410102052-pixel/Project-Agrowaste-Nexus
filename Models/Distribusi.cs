using System;

namespace AgroWasteNexus.Models
{
    public class Distribusi
    {
        public int IdDistribusi { get; set; }
        public decimal JumlahProduk { get; set; }
        public DateTime TanggalDistribusi { get; set; }
        public string Status { get; set; }
        public int IdProduk { get; set; }
        public int IdPenerima { get; set; }
    }
}

namespace AgroWasteNexus.Models
{
    public class DistribusiGrid
    {
        public int id_distribusi { get; set; }
        public int id_produk { get; set; }
        public int id_penerima { get; set; }
        public DateTime tanggal_distribusi { get; set; }
        public decimal jumlah_keluar_kg { get; set; }
        public string status_distribusi { get; set; }
        public string nama_produk { get; set; }
        public string satuan { get; set; }
        public string nama_distributor { get; set; }
        public string alamat_tujuan { get; set; }
    }
}
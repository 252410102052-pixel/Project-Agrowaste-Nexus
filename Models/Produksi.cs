using System;
using System.Drawing;

namespace AgroWasteNexus.Models
{
    public class Produksi
    {
        public int IdProduksi { get; set; }
        public decimal JumlahBahan { get; set; }
        public decimal JumlahHasil { get; set; }
        public decimal BiayaProduksi { get; set; }
        public DateTime TanggalProduksi { get; set; }
        public string Status { get; set; }
        public int IdBatch { get; set; }
        public int IdPengguna { get; set; }
        public int IdProduk { get; set; }
    }

    public class ProduksiGrid
    {
        public int id_produksi { get; set; }
        public int id_batch_asal { get; set; }
        public int id_produk { get; set; }
        public int id_pengguna { get; set; }
        public string asal_pabrik_limbah { get; set; }
        public DateTime tanggal_produksi { get; set; }
        public decimal bahan_baku_kg { get; set; }
        public decimal target_hasil_kg { get; set; }
        public decimal biaya_produksi { get; set; }
        public string status_produksi { get; set; }
        public string nama_produk { get; set; }

        public string gambar_produk { get; set; }
        public Image foto_produk { get; set; }
    }
}
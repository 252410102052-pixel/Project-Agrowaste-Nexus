# 🌾 Agrowaste Nexus - Database Management System

Agrowaste Nexus adalah sistem manajemen basis data (DBMS) berbasis **PostgreSQL** yang dirancang untuk mengotomatisasi, mencatat, dan memantau siklus pengolahan limbah industri pertanian (*agrowaste*) menjadi produk sekunder bernilai ekonomis (seperti Arang Briket, Pupuk Kompos, dan Pakan Ternak). 

Sistem ini mendukung integrasi multi-aktor mulai dari Petugas Lapangan (Driver), Operator Produksi, hingga Tim *Quality Control* (QC).

---

## 🚀 Fitur Utama & Keunggulan Sistem

1. **Siklus Logistik Terlacak:** Mencatat jadwal pengangkutan limbah dari pabrik sumber (mitra) secara *real-time* hingga masuk ke gudang sebagai *Batch* limbah.
2. **Kendali Mutu Terintegrasi (QC):** Memiliki prosedur otomatis untuk memisahkan produk lolos jual (menambah stok) dan produk gagal (otomatis masuk antrean reproduksi internal).
3. **Audit Trail / Log Perubahan Otomatis:** Menggunakan *Database Trigger* untuk mencatat setiap aktivitas `INSERT`, `UPDATE`, dan `DELETE` ke tabel riwayat demi keamanan data.
4. **Pelaporan Operasional Cepat:** Fungsi bawaan (*Stored Function*) yang dapat menyajikan laporan komprehensif bahan baku, hasil produksi, efisiensi QC, dan total log dalam satu kali panggil berdasarkan periode tanggal.

---

## 📐 Arsitektur & Skema Basis Data

### 1. Hubungan Antar Tabel (Relational Database)
Sistem ini dibangun di atas struktur relasional yang kokoh dengan tipe data khusus (*Custom Enum*) untuk menjaga konsistensi status operasional. 

* **Tabel Master:** `pengguna`, `pabrik`, `penerima`, `petugas`, `kendaraan`, `produk`
* **Tabel Transaksi:** `jadwal_pengangkutan`, `batch_limbah`, `produksi`, `kontrol_kualitas`, `distribusi`
* **Tabel Audit:** `riwayat_perubahan`

---

## 🛠️ Cara Penggunaan & Penerapan Query

Semua struktur tabel, data awal (*dummy data*), views, trigger, dan store procedure sudah disatukan ke dalam file script SQL proyek ini.

### 1. Inisialisasi Database
Kamu bisa langsung mengeksekusi file SQL utama untuk membangun arsitektur database dari awal. Script sudah dilengkapi pengaman `DROP IF EXISTS` agar bisa dijalankan ulang tanpa merusak objek yang ada.

### 2. Memanggil Laporan Operasional Periode
Untuk melihat rangkuman seluruh aktivitas bisnis (Bahan Baku, Produksi, Distribusi, dan Log Perubahan) pada rentang waktu tertentu, jalankan perintah berikut:

```sql
SELECT * FROM fn_laporan_operasional_periode('2026-01-01', '2026-12-31');

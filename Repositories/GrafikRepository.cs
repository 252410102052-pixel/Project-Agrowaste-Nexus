using AgrowasteNexus.Database;
using Npgsql;
using System.Data;

namespace AgroWasteNexus.Repositories
{
    public class GrafikRepository
    {
        public DataTable GetStatusBatch()
        {
            DataTable dt = new DataTable();

            using (var conn = DbConnectionHelper.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT 
                        status::text AS status_batch,
                        COUNT(*) AS jumlah
                    FROM batch_limbah
                    GROUP BY status
                    ORDER BY status";

                using (var da = new NpgsqlDataAdapter(query, conn))
                {
                    da.Fill(dt);
                }
            }

            return dt;
        }

        public DataTable GetProduksiPerProduk()
        {
            DataTable dt = new DataTable();

            using (var conn = DbConnectionHelper.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT 
                        pr.nama_produk,
                        COALESCE(SUM(p.jumlah_hasil), 0) AS total_produksi
                    FROM produksi p
                    JOIN produk pr 
                        ON p.produk_id_produk = pr.id_produk
                    GROUP BY pr.nama_produk
                    ORDER BY pr.nama_produk";

                using (var da = new NpgsqlDataAdapter(query, conn))
                {
                    da.Fill(dt);
                }
            }

            return dt;
        }

        public DataTable GetQcLolosGagal()
        {
            DataTable dt = new DataTable();

            using (var conn = DbConnectionHelper.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT 
                        COALESCE(SUM(jumlah_lolos), 0) AS total_lolos,
                        COALESCE(SUM(jumlah_gagal), 0) AS total_gagal
                    FROM kontrol_kualitas";

                using (var da = new NpgsqlDataAdapter(query, conn))
                {
                    da.Fill(dt);
                }
            }

            return dt;
        }
    }
}
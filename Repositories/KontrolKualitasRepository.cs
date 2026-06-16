using AgrowasteNexus.Database;
using AgroWasteNexus.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;

namespace AgroWasteNexus.Repositories
{
    public class KontrolKualitasRepository : BaseRepository<KontrolKualitas>
    {
        public override List<KontrolKualitas> GetAll()
        {
            List<KontrolKualitas> list = new List<KontrolKualitas>();

            using (var conn = DbConnectionHelper.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT
                        id_kontrol,
                        jumlah_lolos,
                        jumlah_gagal,
                        nilai_kualitas,
                        catatan,
                        tanggal_pemeriksaan,
                        pengguna_id_pengguna,
                        produksi_id_produksi
                    FROM kontrol_kualitas
                    ORDER BY id_kontrol";

                using (var cmd = new NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new KontrolKualitas
                        {
                            IdKontrol = reader.GetInt32(0),
                            JumlahLolos = reader.GetDecimal(1),
                            JumlahGagal = reader.GetDecimal(2),
                            NilaiKualitas = reader.IsDBNull(3) ? 0 : reader.GetInt32(3),
                            Catatan = reader.IsDBNull(4) ? "" : reader.GetString(4),
                            TanggalPemeriksaan = reader.GetDateTime(5),
                            IdPengguna = reader.GetInt32(6),
                            IdProduksi = reader.GetInt32(7)
                        });
                    }
                }
            }

            return list;
        }

        public DataTable GetGrid()
        {
            DataTable dt = new DataTable();

            using (var conn = DbConnectionHelper.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT
                        kk.id_kontrol,
                        kk.produksi_id_produksi,
                        kk.pengguna_id_pengguna,
                        pr.nama_produk,
                        kk.tanggal_pemeriksaan,
                        kk.nilai_kualitas,
                        kk.jumlah_lolos,
                        kk.jumlah_gagal,
                        (kk.jumlah_lolos + kk.jumlah_gagal) AS total_diperiksa,
                        kk.catatan
                    FROM kontrol_kualitas kk
                    LEFT JOIN produksi p 
                        ON kk.produksi_id_produksi = p.id_produksi
                    LEFT JOIN produk pr 
                        ON p.produk_id_produk = pr.id_produk
                    ORDER BY kk.id_kontrol";

                using (var cmd = new NpgsqlCommand(query, conn))
                using (var adapter = new NpgsqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
            }

            return dt;
        }

        public int? GetProduksiBelumQc()
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT p.id_produksi
                    FROM produksi p
                    LEFT JOIN kontrol_kualitas kk
                        ON kk.produksi_id_produksi = p.id_produksi
                    WHERE kk.id_kontrol IS NULL
                    ORDER BY p.id_produksi
                    LIMIT 1";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    object result = cmd.ExecuteScalar();

                    if (result == null || result == DBNull.Value)
                        return null;

                    return Convert.ToInt32(result);
                }
            }
        }

        public bool ProduksiSudahPunyaQc(int idProduksi)
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT COUNT(*)
                    FROM kontrol_kualitas
                    WHERE produksi_id_produksi = @idProduksi";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idProduksi", idProduksi);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count > 0;
                }
            }
        }

        public override void Insert(KontrolKualitas entity)
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                conn.Open();

                string query = @"
                    INSERT INTO kontrol_kualitas
                    (
                        jumlah_lolos,
                        jumlah_gagal,
                        nilai_kualitas,
                        catatan,
                        tanggal_pemeriksaan,
                        pengguna_id_pengguna,
                        produksi_id_produksi
                    )
                    VALUES
                    (
                        @jumlahLolos,
                        @jumlahGagal,
                        @nilaiKualitas,
                        @catatan,
                        @tanggalPemeriksaan,
                        @idPengguna,
                        @idProduksi
                    )";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@jumlahLolos", entity.JumlahLolos);
                    cmd.Parameters.AddWithValue("@jumlahGagal", entity.JumlahGagal);
                    cmd.Parameters.AddWithValue("@nilaiKualitas", entity.NilaiKualitas);
                    cmd.Parameters.AddWithValue("@catatan", entity.Catatan ?? "");
                    cmd.Parameters.AddWithValue("@tanggalPemeriksaan", entity.TanggalPemeriksaan.Date);
                    cmd.Parameters.AddWithValue("@idPengguna", entity.IdPengguna);
                    cmd.Parameters.AddWithValue("@idProduksi", entity.IdProduksi);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public override void Update(KontrolKualitas entity)
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                conn.Open();

                string query = @"
                    UPDATE kontrol_kualitas
                    SET
                        jumlah_lolos = @jumlahLolos,
                        jumlah_gagal = @jumlahGagal,
                        nilai_kualitas = @nilaiKualitas,
                        catatan = @catatan,
                        tanggal_pemeriksaan = @tanggalPemeriksaan,
                        pengguna_id_pengguna = @idPengguna,
                        produksi_id_produksi = @idProduksi
                    WHERE id_kontrol = @idKontrol";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idKontrol", entity.IdKontrol);
                    cmd.Parameters.AddWithValue("@jumlahLolos", entity.JumlahLolos);
                    cmd.Parameters.AddWithValue("@jumlahGagal", entity.JumlahGagal);
                    cmd.Parameters.AddWithValue("@nilaiKualitas", entity.NilaiKualitas);
                    cmd.Parameters.AddWithValue("@catatan", entity.Catatan ?? "");
                    cmd.Parameters.AddWithValue("@tanggalPemeriksaan", entity.TanggalPemeriksaan.Date);
                    cmd.Parameters.AddWithValue("@idPengguna", entity.IdPengguna);
                    cmd.Parameters.AddWithValue("@idProduksi", entity.IdProduksi);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void FinalisasiQcTotal(
            int idKontrol,
            int idProduksi,
            decimal jumlahLolos,
            decimal jumlahGagal,
            int nilaiKualitas,
            DateTime tanggalPemeriksaan,
            string catatan)
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                conn.Open();

                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        string query = @"
                            CALL sp_finalisasi_qc_total(
                                @idKontrol,
                                @idProduksi,
                                @jumlahLolos,
                                @jumlahGagal,
                                @nilaiKualitas,
                                @tanggalPemeriksaan,
                                @catatan
                            )";

                        using (var cmd = new NpgsqlCommand(query, conn))
                        {
                            cmd.Transaction = transaction;

                            cmd.Parameters.AddWithValue("@idKontrol", idKontrol);
                            cmd.Parameters.AddWithValue("@idProduksi", idProduksi);
                            cmd.Parameters.AddWithValue("@jumlahLolos", jumlahLolos);
                            cmd.Parameters.AddWithValue("@jumlahGagal", jumlahGagal);
                            cmd.Parameters.AddWithValue("@nilaiKualitas", nilaiKualitas);
                            cmd.Parameters.AddWithValue("@tanggalPemeriksaan", tanggalPemeriksaan.Date);
                            cmd.Parameters.AddWithValue("@catatan", catatan ?? "");

                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        public override void Delete(int id)
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                conn.Open();

                string query = @"
                    DELETE FROM kontrol_kualitas
                    WHERE id_kontrol = @id";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
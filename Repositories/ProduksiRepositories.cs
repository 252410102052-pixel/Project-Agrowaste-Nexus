using AgrowasteNexus.Database;
using AgroWasteNexus.Models;
using Npgsql;
using System.Collections.Generic;

namespace AgroWasteNexus.Repositories
{
    public class ProduksiRepository : BaseRepository<Produksi>
    {
        public override List<Produksi> GetAll()
        {
            List<Produksi> list = new List<Produksi>();

            using (var conn = DbConnectionHelper.GetConnection())
            {
                conn.Open();

                string query = @"SELECT id_produksi, jumlah_bahan, jumlah_hasil, biaya_produksi, 
                                        tanggal_produksi, status::text, id_batch, id_pengguna
                                 FROM produksi
                                 ORDER BY id_produksi";

                using (var cmd = new NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Produksi
                        {
                            IdProduksi = reader.GetInt32(0),
                            JumlahBahan = reader.GetDecimal(1),
                            JumlahHasil = reader.GetDecimal(2),
                            BiayaProduksi = reader.GetDecimal(3),
                            TanggalProduksi = reader.GetDateTime(4),
                            Status = reader.GetString(5),
                            IdBatch = reader.GetInt32(6),
                            IdPengguna = reader.GetInt32(7)
                        });
                    }
                }
            }

            return list;
        }

        public override void Insert(Produksi entity)
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                conn.Open();

                string query = @"INSERT INTO produksi 
                                (id_produksi, jumlah_bahan, jumlah_hasil, biaya_produksi, 
                                 tanggal_produksi, status, id_batch, id_pengguna)
                                VALUES
                                (@id, @bahan, @hasil, @biaya, @tanggal, 
                                 @status::enum_status_produksi, @idBatch, @idPengguna)";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", entity.IdProduksi);
                    cmd.Parameters.AddWithValue("@bahan", entity.JumlahBahan);
                    cmd.Parameters.AddWithValue("@hasil", entity.JumlahHasil);
                    cmd.Parameters.AddWithValue("@biaya", entity.BiayaProduksi);
                    cmd.Parameters.AddWithValue("@tanggal", entity.TanggalProduksi);
                    cmd.Parameters.AddWithValue("@status", entity.Status);
                    cmd.Parameters.AddWithValue("@idBatch", entity.IdBatch);
                    cmd.Parameters.AddWithValue("@idPengguna", entity.IdPengguna);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public override void Update(Produksi entity)
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                conn.Open();

                string query = @"UPDATE produksi SET
                                 jumlah_bahan = @bahan,
                                 jumlah_hasil = @hasil,
                                 biaya_produksi = @biaya,
                                 tanggal_produksi = @tanggal,
                                 status = @status::enum_status_produksi,
                                 id_batch = @idBatch,
                                 id_pengguna = @idPengguna
                                 WHERE id_produksi = @id";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", entity.IdProduksi);
                    cmd.Parameters.AddWithValue("@bahan", entity.JumlahBahan);
                    cmd.Parameters.AddWithValue("@hasil", entity.JumlahHasil);
                    cmd.Parameters.AddWithValue("@biaya", entity.BiayaProduksi);
                    cmd.Parameters.AddWithValue("@tanggal", entity.TanggalProduksi);
                    cmd.Parameters.AddWithValue("@status", entity.Status);
                    cmd.Parameters.AddWithValue("@idBatch", entity.IdBatch);
                    cmd.Parameters.AddWithValue("@idPengguna", entity.IdPengguna);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public override void Delete(int id)
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                conn.Open();

                string query = "DELETE FROM produksi WHERE id_produksi = @id";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
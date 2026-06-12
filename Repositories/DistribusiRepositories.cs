using AgrowasteNexus.Database;
using AgroWasteNexus.Models;
using Npgsql;
using System.Collections.Generic;

namespace AgroWasteNexus.Repositories
{
    public class DistribusiRepository : BaseRepository<Distribusi>
    {
        public override List<Distribusi> GetAll()
        {
            List<Distribusi> list = new List<Distribusi>();

            using (var conn = DbConnectionHelper.GetConnection())
            {
                conn.Open();

                string query = @"SELECT id_distribusi, jumlah_produk, tanggal_distribusi, 
                                        harga_satuan, status::text, id_produk, id_penerima
                                 FROM distribusi
                                 ORDER BY id_distribusi";

                using (var cmd = new NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Distribusi
                        {
                            IdDistribusi = reader.GetInt32(0),
                            JumlahProduk = reader.GetDecimal(1),
                            TanggalDistribusi = reader.GetDateTime(2),
                            HargaSatuan = reader.GetDecimal(3),
                            Status = reader.GetString(4),
                            IdProduk = reader.GetInt32(5),
                            IdPenerima = reader.GetInt32(6)
                        });
                    }
                }
            }

            return list;
        }

        public override void Insert(Distribusi entity)
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                conn.Open();

                string query = @"INSERT INTO distribusi
                                (id_distribusi, jumlah_produk, tanggal_distribusi, harga_satuan,
                                 status, id_produk, id_penerima)
                                VALUES
                                (@id, @jumlah, @tanggal, @harga, 
                                 @status::enum_status_distribusi, @idProduk, @idPenerima)";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", entity.IdDistribusi);
                    cmd.Parameters.AddWithValue("@jumlah", entity.JumlahProduk);
                    cmd.Parameters.AddWithValue("@tanggal", entity.TanggalDistribusi);
                    cmd.Parameters.AddWithValue("@harga", entity.HargaSatuan);
                    cmd.Parameters.AddWithValue("@status", entity.Status);
                    cmd.Parameters.AddWithValue("@idProduk", entity.IdProduk);
                    cmd.Parameters.AddWithValue("@idPenerima", entity.IdPenerima);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public override void Update(Distribusi entity)
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                conn.Open();

                string query = @"UPDATE distribusi SET
                                 jumlah_produk = @jumlah,
                                 tanggal_distribusi = @tanggal,
                                 harga_satuan = @harga,
                                 status = @status::enum_status_distribusi,
                                 id_produk = @idProduk,
                                 id_penerima = @idPenerima
                                 WHERE id_distribusi = @id";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", entity.IdDistribusi);
                    cmd.Parameters.AddWithValue("@jumlah", entity.JumlahProduk);
                    cmd.Parameters.AddWithValue("@tanggal", entity.TanggalDistribusi);
                    cmd.Parameters.AddWithValue("@harga", entity.HargaSatuan);
                    cmd.Parameters.AddWithValue("@status", entity.Status);
                    cmd.Parameters.AddWithValue("@idProduk", entity.IdProduk);
                    cmd.Parameters.AddWithValue("@idPenerima", entity.IdPenerima);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public override void Delete(int id)
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                conn.Open();

                string query = "DELETE FROM distribusi WHERE id_distribusi = @id";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
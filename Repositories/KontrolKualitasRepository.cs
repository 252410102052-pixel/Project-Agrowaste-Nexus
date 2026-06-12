using AgrowasteNexus.Database;
using AgroWasteNexus.Models;
using Npgsql;
using System.Collections.Generic;

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

                string query = @"SELECT id_kontrol, nilai_kualitas, status_kualitas::text, catatan,
                                        tanggal_pemeriksaan, id_pengguna, id_produksi
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
                            NilaiKualitas = reader.GetInt32(1),
                            StatusKualitas = reader.GetString(2),
                            Catatan = reader.IsDBNull(3) ? "" : reader.GetString(3),
                            TanggalPemeriksaan = reader.GetDateTime(4),
                            IdPengguna = reader.GetInt32(5),
                            IdProduksi = reader.GetInt32(6)
                        });
                    }
                }
            }

            return list;
        }

        public override void Insert(KontrolKualitas entity)
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                conn.Open();

                string query = @"INSERT INTO kontrol_kualitas
                                (id_kontrol, nilai_kualitas, status_kualitas, catatan, 
                                 tanggal_pemeriksaan, id_pengguna, id_produksi)
                                VALUES
                                (@id, @nilai, @status::enum_status_qc, @catatan, 
                                 @tanggal, @idPengguna, @idProduksi)";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", entity.IdKontrol);
                    cmd.Parameters.AddWithValue("@nilai", entity.NilaiKualitas);
                    cmd.Parameters.AddWithValue("@status", entity.StatusKualitas);
                    cmd.Parameters.AddWithValue("@catatan", entity.Catatan);
                    cmd.Parameters.AddWithValue("@tanggal", entity.TanggalPemeriksaan);
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

                string query = @"UPDATE kontrol_kualitas SET
                                 nilai_kualitas = @nilai,
                                 status_kualitas = @status::enum_status_qc,
                                 catatan = @catatan,
                                 tanggal_pemeriksaan = @tanggal,
                                 id_pengguna = @idPengguna,
                                 id_produksi = @idProduksi
                                 WHERE id_kontrol = @id";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", entity.IdKontrol);
                    cmd.Parameters.AddWithValue("@nilai", entity.NilaiKualitas);
                    cmd.Parameters.AddWithValue("@status", entity.StatusKualitas);
                    cmd.Parameters.AddWithValue("@catatan", entity.Catatan);
                    cmd.Parameters.AddWithValue("@tanggal", entity.TanggalPemeriksaan);
                    cmd.Parameters.AddWithValue("@idPengguna", entity.IdPengguna);
                    cmd.Parameters.AddWithValue("@idProduksi", entity.IdProduksi);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public override void Delete(int id)
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                conn.Open();

                string query = "DELETE FROM kontrol_kualitas WHERE id_kontrol = @id";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
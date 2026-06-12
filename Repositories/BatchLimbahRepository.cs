using AgrowasteNexus.Database;
using AgroWasteNexus.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;

namespace AgroWasteNexus.Repositories
{
    public class BatchLimbahRepository : BaseRepository<BatchLimbah>
    {
        public override List<BatchLimbah> GetAll()
        {
            List<BatchLimbah> list = new List<BatchLimbah>();

            using (var conn = DbConnectionHelper.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT
                        id_batch,
                        pabrik_id_pabrik,
                        jumlah,
                        tanggal_masuk,
                        status
                    FROM batch_limbah
                    ORDER BY id_batch";

                using (var cmd = new NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new BatchLimbah
                        {
                            IdBatch = reader.GetInt32(0),
                            IdPabrik = reader.GetInt32(1),
                            Jumlah = reader.GetDecimal(2),
                            TanggalMasuk = reader.GetDateTime(3),
                            Status = reader.GetString(4)
                        });
                    }
                }
            }

            return list;
        }
        public DataTable GetGridData()
        {
            DataTable dt = new DataTable();

            using (var conn = DbConnectionHelper.GetConnection())
            {
                conn.Open();

                string query = "SELECT * FROM v_grid_batch_limbah";

                using (var cmd = new NpgsqlCommand(query, conn))
                using (var adapter = new NpgsqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
            }

            return dt;
        }
        public override void Insert(BatchLimbah entity)
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                conn.Open();

                string query = @"
        INSERT INTO batch_limbah
        (
            id_batch,
            jumlah,
            tanggal_masuk,
            status,
            keterangan,
            pabrik_id_pabrik,
            jadwal_pengangkutan_id_jadwal
        )
        VALUES
        (
            @idBatch,
            @jumlah,
            @tanggal,
            CAST(@status AS enum_status_batch)
            @keterangan,
            @idPabrik,
            @idJadwal
        )";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idBatch", entity.IdBatch);
                    cmd.Parameters.AddWithValue("@jumlah", entity.Jumlah);
                    cmd.Parameters.AddWithValue("@tanggal", entity.TanggalMasuk);
                    cmd.Parameters.AddWithValue("@status", entity.Status);
                    cmd.Parameters.AddWithValue("@keterangan", entity.Keterangan ?? "");
                    cmd.Parameters.AddWithValue("@idPabrik", entity.IdPabrik);
                    cmd.Parameters.AddWithValue("@idJadwal",
                        (object)entity.IdJadwal ?? DBNull.Value);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public override void Update(BatchLimbah entity)
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                conn.Open();

                string query = @"
                    UPDATE batch_limbah
                    SET
                        id_pabrik = @idPabrik,
                        id_kategori = @idKategori,
                        jumlah = @jumlah,
                        tanggal_masuk = @tanggal,
                        status = @status
                    WHERE id_batch = @id";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", entity.IdBatch);
                    cmd.Parameters.AddWithValue("@idPabrik", entity.IdPabrik);
                    cmd.Parameters.AddWithValue("@jumlah", entity.Jumlah);
                    cmd.Parameters.AddWithValue("@tanggal", entity.TanggalMasuk);
                    cmd.Parameters.AddWithValue("@status", entity.Status);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public override void Delete(int id)
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                conn.Open();

                string query =
                    "DELETE FROM batch_limbah WHERE id_batch = @id";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<string> GetStatusBatch()
        {
            List<string> statusList = new List<string>();

            using (var conn = DbConnectionHelper.GetConnection())
            {
                conn.Open();

                string query = @"
            SELECT enumlabel
            FROM pg_enum
            WHERE enumtypid = (
                SELECT oid
                FROM pg_type
                WHERE typname = 'enum_status_batch'
            )";

                using (var cmd = new NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        statusList.Add(reader.GetString(0));
                    }
                }
            }

            return statusList;
        }
    }
}
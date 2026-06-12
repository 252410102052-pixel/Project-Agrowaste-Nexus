using AgrowasteNexus.Database;
using AgroWasteNexus.Models;
using Npgsql;
using System.Collections.Generic;
using System.Data;


namespace AgroWasteNexus.Repositories
{
    public class JadwalPengangkutanRepository
        : BaseRepository<JadwalPengangkutanModel>
    {
        public override List<JadwalPengangkutanModel> GetAll()
        {
            List<JadwalPengangkutanModel> list =
                new List<JadwalPengangkutanModel>();

            using (var conn = DbConnectionHelper.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT
                        id_jadwal,
                        tanggal_pengangkutan,
                        status,
                        catatan,
                        petugas_id_petugas,
                        kendaraan_id_kendaraan
                    FROM jadwal_pengangkutan
                    ORDER BY id_jadwal";

                using (var cmd = new NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new JadwalPengangkutanModel
                        {
                            IdJadwal = reader.GetInt32(0),
                            TanggalPengangkutan = reader.GetDateTime(1),
                            Status = reader.GetString(2),
                            Catatan = reader.IsDBNull(3) ? "" : reader.GetString(3),
                            IdPetugas = reader.GetInt32(4),
                            IdKendaraan = reader.GetInt32(5)
                        });
                    }
                }
            }

            return list;
        }

        public List<string> GetStatusJadwal()
        {
            List<string> list = new List<string>();

            using (var conn = DbConnectionHelper.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT enumlabel
                    FROM pg_enum
                    WHERE enumtypid = (
                        SELECT oid
                        FROM pg_type
                        WHERE typname = 'enum_status_jadwal'
                    )";

                using (var cmd = new NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(reader.GetString(0));
                    }
                }
            }

            return list;
        }
        public DataTable GetPetugas()
        {
            DataTable dt = new DataTable();

            using (var conn = DbConnectionHelper.GetConnection())
            {
                conn.Open();

                string query =
                    "SELECT id_petugas, nama_petugas FROM petugas ORDER BY nama_petugas";

                using (var da = new NpgsqlDataAdapter(query, conn))
                {
                    da.Fill(dt);
                }
            }

            return dt;
        }

        public DataTable GetKendaraan()
        {
            DataTable dt = new DataTable();

            using (var conn = DbConnectionHelper.GetConnection())
            {
                conn.Open();

                string query =
                    "SELECT id_kendaraan, nama_kendaraan FROM kendaraan ORDER BY nama_kendaraan";

                using (var da = new NpgsqlDataAdapter(query, conn))
                {
                    da.Fill(dt);
                }
            }

            return dt;
        }
        public override void Insert(JadwalPengangkutanModel entity)
        {
            throw new System.NotImplementedException();
        }

        public override void Update(JadwalPengangkutanModel entity)
        {
            throw new System.NotImplementedException();
        }

        public override void Delete(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
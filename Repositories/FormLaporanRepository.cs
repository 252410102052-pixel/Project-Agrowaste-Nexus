using AgrowasteNexus.Database;
using AgroWasteNexus.Models;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;

namespace AgroWasteNexus.Repositories
{
    public class FormLaporanRepository
    {
        public List<LaporanOperasional> GetLaporanPeriode(DateTime tanggalAwal, DateTime tanggalAkhir)
        {
            List<LaporanOperasional> list = new List<LaporanOperasional>();

            using (var conn = DbConnectionHelper.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT 
                        kategori_operasional,
                        nama_item,
                        total,
                        keterangan
                    FROM fn_laporan_operasional_periode(@awal, @akhir)";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@awal", NpgsqlDbType.Date, tanggalAwal.Date);
                    cmd.Parameters.AddWithValue("@akhir", NpgsqlDbType.Date, tanggalAkhir.Date);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            LaporanOperasional data = new LaporanOperasional();

                            data.kategori_operasional = reader["kategori_operasional"].ToString();
                            data.nama_item = reader["nama_item"].ToString();
                            data.total = Convert.ToDecimal(reader["total"]);
                            data.keterangan = reader["keterangan"].ToString();

                            list.Add(data);
                        }
                    }
                }
            }

            return list;
        }
    }
}
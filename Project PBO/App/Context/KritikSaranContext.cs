using Npgsql;
using Project_PBO.App.Core;
using System;
using System.Data;

namespace Project_PBO.App.Context
{
    public class kritikSaranContext : dataconn
    {
        private static string keluhantable = "keluhan";
        private static string profiltable = "profil";

        public static DataTable all()
        {
            // Menambahkan nomor urut menggunakan ROW_NUMBER()
            string query = $@"
                SELECT 
                    ROW_NUMBER() OVER (ORDER BY nama) AS No,
                    a.id_keluhan,
                    a.detail_kritik AS kritik, 
                    a.detail_saran AS saran, 
                    p.nama AS nama
                FROM {keluhantable} a
                JOIN {profiltable} p ON a.id_pelanggan = p.id_profil";
            return queryExecutor(query);
        }

        //insert kritik dan sarannya
        public static void Insert(string kritik, string saran, int userId)
        {
            // SQL query with parameter placeholders
            string query = $@"
                INSERT INTO {keluhantable} (detail_kritik, detail_saran, id_pelanggan)
                VALUES (@kritik, @saran, @userId)";

            // Create a list of parameters
            NpgsqlParameter[] param = {
                new NpgsqlParameter("@kritik", kritik),
                new NpgsqlParameter("@saran", saran),
                new NpgsqlParameter("@userId", userId)
                };
            commandExecutor(query, param);
        }

    }

}
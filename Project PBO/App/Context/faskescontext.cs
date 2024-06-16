using Npgsql;
using NpgsqlTypes;
using Project_PBO.App.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PBO.App.Context
{
    public class faskescontext : dataconn
    {
        public static DataTable GetAllFaskes()
        {
            string query = $@"SELECT * FROM faskes";

            return queryExecutor(query);
        }
        //cari faskes terdekat dari inputan user
        public static DataTable cariFaskes(string namaKota)
        {
            string query = $@"
    SELECT 
        id_faskes, 
        nama_faskes AS Nama, 
        alamat AS Alamat, 
        no_telfon AS ""No. Telfon"",  -- Menggunakan tanda kutip ganda untuk delimeter
        kota AS Kota, 
        website AS Website, 
        jam_operasional AS ""Jam Operasional"" -- Menggunakan tanda kutip ganda untuk delimeter
    FROM faskes
    WHERE kota ilike '{namaKota}'";
            return queryExecutor(query);
        }

        public static void delete(int id)
        {
            string query = $"DELETE FROM faskes WHERE id_faskes = @id";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id", NpgsqlDbType.Integer){Value = id},
            };
            commandExecutor(query, parameters);
        }

        public static void insert(string nama_faskes, string alamat, string kota, int no_telfon, string website, string jamoperasional)
        {
            string query = @"INSERT INTO faskes (nama_faskes, alamat, kota, no_telfon, website, jam_operasional) 
                           VALUES (@nama_faskes, @alamat, @kota, @no_telfon, @website, @jamoperasional)";
            NpgsqlParameter[] param =
            {
                new NpgsqlParameter ("@nama_faskes", NpgsqlDbType.Varchar) {Value = nama_faskes},
                new NpgsqlParameter ("@alamat", NpgsqlDbType.Varchar) {Value = alamat},
                new NpgsqlParameter ("@kota", NpgsqlDbType.Varchar) {Value = kota},
                new NpgsqlParameter ("@no_telfon", NpgsqlDbType.Integer) {Value = no_telfon},
                new NpgsqlParameter ("@website", NpgsqlDbType.Varchar) {Value = website},
                new NpgsqlParameter ("@jamoperasional", NpgsqlDbType.Varchar) {Value = jamoperasional}
            };
            commandExecutor(query, param);
        }




    }
}


using Project_PBO.App.Core;
using System;
using System.Data;

namespace Project_PBO.App.Context
{
    public class dataAnggotaContext : dataconn
    {
        private static string table = "profil";

        public static DataTable all()
        {
            // Menambahkan nomor urut menggunakan ROW_NUMBER()
            string query = $@"
                SELECT 
                    ROW_NUMBER() OVER (ORDER BY nama) AS No,
                    id_profil,
                    nama AS Nama, 
                    alamat AS Alamat, 
                    no_telfon AS Nomor_Telpon, 
                    kota AS Kota 
                FROM {table} 
                WHERE id_jenis_profil = 2";
            return queryExecutor(query);
        }

        public static void delete(int id)
        {
            string query = $"DELETE FROM {table} WHERE id_profil = {id}";
            queryExecutor(query);
        }
    }
}
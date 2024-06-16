using Npgsql;
using Project_PBO.App.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Project_PBO.App.Context
{
    public class ProfilContext : dataconn
    {
        public static DataTable all(string query) 
        {
            DataTable dataTable = queryExecutor(query);
            return dataTable;
        }

        public static void InsertProfil(string nama, string email, string password, string alamat, string kota, string negara, long noTelfon)
        {
            string query = @"
            INSERT INTO profil (nama, email, password, alamat, kota, negara, no_telfon, id_jenis_profil)
            VALUES (@nama, @email, @password, @alamat, @kota, @negara, @no_telfon, @id_jenis_profil)
            ";
            NpgsqlParameter[] param =
            {
                new NpgsqlParameter("@nama", DbType.String){Value = nama},
                new NpgsqlParameter("@email", DbType.String){ Value = email},
                new NpgsqlParameter("@password", DbType.String) { Value = password},
                new NpgsqlParameter("@alamat", DbType.String) { Value = alamat},
                new NpgsqlParameter("@kota", DbType.String) {Value = kota},
                new NpgsqlParameter("@negara", DbType.String) { Value = negara},
                new NpgsqlParameter("@no_telfon", DbType.Int64) {Value=noTelfon},
                new NpgsqlParameter("@id_jenis_profil", DbType.Int32) {Value = 2}
            };
            queryExecutor(query, param);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;
using Project_PBO.App.Core;

namespace Project_PBO.App.Context
{
    public class obatcontext : dataconn
    {


        private static string obatTable = "obat";
        private static string penyakitTable = "penyakit";
        private static string jenisTable = "jenis_obat";

        //menampilkan data
        public DataTable getAll()
        {
            string query = $@"
            SELECT 
                a.nama_obat, 
                a.fungsi, 
                a.dosis, 
                p.nama_penyakit AS Penyakit, 
                j.jenis AS Jenis
            FROM {obatTable} a
            JOIN {penyakitTable} p ON a.id_penyakit = p.id_penyakit
            JOIN {jenisTable} j ON a.id_jenis = j.id_jenis";
            return queryExecutor(query);
        }

        //insert data
        public void insert(string nama_obat, string fungsi, string dosis, int penyakit, int jenis)
        {
            string query = $"INSERT INTO {obatTable} (nama_obat, fungsi, dosis, id_penyakit, id_jenis) VALUES (@nama_obat, @fungsi, @dosis, @penyakit, @jenis)";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@nama_obat", NpgsqlTypes.NpgsqlDbType.Varchar){Value = nama_obat},
                new NpgsqlParameter("@fungsi", NpgsqlTypes.NpgsqlDbType.Varchar){Value = fungsi},
                new NpgsqlParameter("@dosis", NpgsqlTypes.NpgsqlDbType.Varchar){Value = dosis},
                new NpgsqlParameter("@penyakit", NpgsqlTypes.NpgsqlDbType.Integer){Value = penyakit},
                new NpgsqlParameter("@jenis", NpgsqlTypes.NpgsqlDbType.Integer){Value = jenis},
            };
            commandExecutor(query, parameters);
        }

        public static DataTable getJenis()
        {
            string query = $"SELECT * FROM jenis_obat";
            return queryExecutor(query);
        }
    }

}


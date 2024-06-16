using Npgsql;
using Project_PBO.App.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PBO.App.Context
{
    public class KaloriContext : dataconn
    {
        public static DataTable getAllMakanan()
        {
            string query = "SELECT nama_makanan FROM kalori_makanan";
            DataTable dt = queryExecutor(query);
            return dt;
        }

        public static int getKandungan(string name)
        {
            string query = "SELECT * from kalori_makanan WHERE nama_makanan = @nama_makanan";
            NpgsqlParameter[] param =
            {
                new NpgsqlParameter("@nama_makanan", DbType.String){Value = name},
            };
            DataTable dt = queryExecutor(query, param);
            string kandunganMakanan = dt.Rows[0]["kandungan"].ToString();
            int kandunganMakananInteger = Int32.Parse(kandunganMakanan);
            return kandunganMakananInteger;
        }

        public static double countKalori(string name, double berat)
        {
            string query = "SELECT * from kalori_makanan WHERE nama_makanan = @nama_makanan";
            NpgsqlParameter[] param =
            {
                new NpgsqlParameter("@nama_makanan", DbType.String){Value = name},
            };
            DataTable dt = queryExecutor(query, param);
            string kandunganMakanan = dt.Rows[0]["kandungan"].ToString();
            double kandunganMakananInteger = Double.Parse(kandunganMakanan);
            double beratfix = berat / 100;
            double totalKalori = beratfix * kandunganMakananInteger;
            return totalKalori;
        }
    }
}

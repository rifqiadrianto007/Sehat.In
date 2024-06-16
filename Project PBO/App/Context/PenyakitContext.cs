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
    public class PenyakitContext : dataconn
    {
        public static DataTable getAllPenyakit()
        {
            string query = "SELECT * FROM penyakit";
            DataTable dt = queryExecutor(query);
            return dt;
        }
    }
}

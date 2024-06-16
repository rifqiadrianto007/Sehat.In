using System.Data;
using Npgsql;
using Project_PBO.App.Core;

namespace Project_PBO.App.Context
{
    public class datadiricontext : dataconn
    {
        public static DataTable getdatadiriid(string email)
        {
            string query = "SELECT id_profil FROM profil WHERE email = @Email";
            NpgsqlParameter[] parameters = {
                new NpgsqlParameter("@Email", email) { NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar }
            };
            return queryExecutor(query, parameters);
        }
        // Mengambil nama user yang login
        public static DataTable getdatadirinama(string email)
        {
            string query = "SELECT nama FROM profil WHERE email = @Email";
            NpgsqlParameter[] parameters = {
                new NpgsqlParameter("@Email", email) { NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar }
            };
            return queryExecutor(query, parameters);
        }

        // Mengambil nomor telepon user yang login
        public static DataTable getdatadirinotelp(string email)
        {
            string query = "SELECT no_telfon FROM profil WHERE email = @Email";
            NpgsqlParameter[] parameters = {
                new NpgsqlParameter("@Email", email) { NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar }
            };
            return queryExecutor(query, parameters);
        }

        // Mengambil alamat user yang login
        public static DataTable getdatadirialamat(string email)
        {
            string query = "SELECT alamat From profil WHERE email = @Email";
            NpgsqlParameter[] parameters = {
                new NpgsqlParameter("@Email", email) { NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar }
            };
            return queryExecutor(query, parameters);
        }
        public static void editdatadiri(string email, string nama, long no_telfon, string alamat)
        {
            string query = "UPDATE profil SET nama = @Nama, no_telfon = @No_telfon, alamat = @Alamat WHERE email = @Email";
            NpgsqlParameter[] parameters =
            {
        new NpgsqlParameter("@Nama", nama) { NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar },
        new NpgsqlParameter("@No_telfon", no_telfon) { NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Integer },
        new NpgsqlParameter("@Alamat", alamat) { NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar },
        new NpgsqlParameter("@Email", email) { NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar }
    };
            commandExecutor(query, parameters);
        }
    }
}

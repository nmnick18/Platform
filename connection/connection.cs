using System;
using Npgsql;

namespace Platform
{
    class connection
    {
        public static string connectionstatus() {

            var cs = "Host=localhost; Username=postgres; Password=password; Database=postgres";

            using var con = new NpgsqlConnection(cs);
            con.Open();

            var sql = "SELECT version()";

            using var cmd = new NpgsqlCommand(sql, con);

            var version = cmd.ExecuteScalar().ToString();
            return $"{version}";

        }
        


    }
}    
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeCare
{
    class DB
    {
        public static string Server;
        public static string Database;
        public static string Username;
        public static string Password;
        public static string Timeout;

        public static SqlConnection Open(ref SqlConnection sqlConn)
        {
            Server = Properties.Settings.Default.DBServer;
            Database = Properties.Settings.Default.DBName;
            Username = Properties.Settings.Default.DBUser;
            Password = Properties.Settings.Default.DBPass;

            var connStr = new StringBuilder();
            connStr.Append("Data Source=" + Server + ";");
            connStr.Append("User ID=" + Username + ";");
            connStr.Append("Password=" + Password + ";");
            connStr.Append("Connect Timeout=" + Timeout + "30;");
            connStr.Append("Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            try
            {
                if (sqlConn.State == System.Data.ConnectionState.Open)
                    return sqlConn;

                sqlConn.ConnectionString = connStr.ToString();
                sqlConn.Open();
            }
            catch (Exception e)
            {
                return null;
            }

            //var connString =
            //    "Data Source=wecare-srv2;User ID=wcu;Password=********;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            return sqlConn;
        }
    }
}

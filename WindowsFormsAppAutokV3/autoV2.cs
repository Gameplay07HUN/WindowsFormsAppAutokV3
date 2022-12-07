using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using WindowsFormsAppAuutók;

namespace WindowsFormsAppAutokV3
{
    internal class autoV2
    {
        public MySqlConnection connection;
        public MySqlCommand sqlCommand;
        public string hibaSzöveg = null;
        public autoV2(string host, string user, string password, string db)
        {
            MySqlConnectionStringBuilder stringBuilder = new MySqlConnectionStringBuilder();
            stringBuilder.Server = host;
            stringBuilder.UserID = user;
            stringBuilder.Password = password;
            stringBuilder.Database = db;
            connection = new MySqlConnection(stringBuilder.ConnectionString);
            sqlCommand = connection.CreateCommand();
        }
        private bool dbOpen()
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }
            }
            catch (MySqlException ex)
            {
                hibaSzöveg = ex.Message;
                return false;
            }
            return true;
        }
        private bool dbClose()
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
            catch (MySqlException ex)
            {
                hibaSzöveg = ex.Message;
                return false;
            }
            return true;
        }
        public List<auto> getAllAuto()
        {
            List<auto> autok = new List<auto>();
            sqlCommand.CommandText = "SELECT `id`,`marka`,`nev`,`motor`,`uzembehelyezve`,`szin` FROM `autokv2` WHERE 1;";
            if (dbOpen())
            {
                using (MySqlDataReader dr = sqlCommand.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        auto uj = new auto(dr.GetInt32("id"), dr.GetString("marka"), dr.GetString("nev"), dr.GetString("motor"), dr.GetInt32("uzembehelyezve"), dr.GetString("szin"));
                        autok.Add(uj);
                    }
                }
            }
            else
            {
                MessageBox.Show(hibaSzöveg);
            }
            dbClose();
            return autok;
        }
    }
}

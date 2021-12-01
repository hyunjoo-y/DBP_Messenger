using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace on_off_proj
{
    class FriendManagement
    {
        static string conn = connection.connect();
 
        public static bool addFriend(string friendid)
        {
            string query = "";
            string userid = connection.userId;
            using (MySqlConnection connect = new MySqlConnection(conn))
            {
                connect.Open();

                query = "SELECT * FROM FRIENDLIST WHERE ID = '" + userid + "' && FRIENDID = '" + friendid + "'";

                MySqlCommand cmd = new MySqlCommand(query, connect);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    if (rdr != null)
                    {
                        return false;
                    }
                }

                query = "INSERT INTO FRIENDLIST(ID,FRIENDID) VALUES('" + userid + "', '" + friendid + "')";
                cmd = new MySqlCommand(query, connect);
                rdr.Close();
                cmd.ExecuteNonQuery();

                return true;
            }
        }

        public static void deleteFriend(string friendid)
        {
            string userid = connection.userId;
            string query = "DELETE FROM FRIENDLIST WHERE ID = '" + userid + "' && FRIENDID = '" + friendid + "'";
            using (MySqlConnection connect = new MySqlConnection(conn))
            {
                connect.Open();

                MySqlCommand cmd = new MySqlCommand(query, connect);
                MySqlDataReader rdr = cmd.ExecuteReader();

            }
        }
    }
}

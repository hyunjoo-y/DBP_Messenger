using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace on_off_proj
{
    class add_friend
    {

        public static void create_table(string ID_text)
        {


            string myConnection = "Server=27.96.130.41;Port=3306;Database=s5671252;Uid=s5671252;Pwd=s5671252";
            using (MySqlConnection connection = new MySqlConnection(myConnection))
            {
                connection.Open();

                try//예외 처리
                {

                    string createQuery = "CREATE TABLE Friend" + ID_text +
                                        "(id Integer unsigned NOT NULL AUTO_INCREMENT, " +
                                        "FID VARCHAR(45) NOT NULL, " +
                                        "PRIMARY KEY (id))";
                    MySqlCommand mySqlCommand = new MySqlCommand(createQuery, connection);
                    mySqlCommand.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("실패");
                    Console.WriteLine(ex.ToString());
                }
            }
        }
    }
}

using DB_SNS;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace on_off_proj
{
    public partial class MainScreen : Form
    {
        public string login_id { get; set; }
        public string login_pw { get; set; }

        public MainScreen(string login_id, string login_pw)
        {
            InitializeComponent();
            this.login_id = login_id;
            this.login_pw = login_pw;
        }

        private void button_private_Click(object sender, EventArgs e)
        {
            changeMemInfo change = new changeMemInfo(login_id, login_pw);
            change.ShowDialog();
        }

        private void button_profile_Click(object sender, EventArgs e)
        {
            changeData change = new changeData(login_id, login_pw);
            change.ShowDialog();
        }

        private void button_addfriend_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(Config.getInstance().getAddress()))
            {
                connection.Open();

                string query = "SELECT * FROM on_off WHERE ID = '" + textBox_searchId.Text + "'";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    if (rdr["ID"].ToString() == textBox_searchId.Text)
                    {
                        string searchid = rdr["ID"].ToString();
                        rdr.Close();
                        MessageBox.Show(Check_AddFriend(connection, searchid));
                        return;
                    }

                }

                MessageBox.Show("해당 ID가 없습니다");
            }
        }

        string Check_AddFriend(MySqlConnection conn, string searchid)
        {
            bool exist = true;
            using (conn)
            {
                string query = "SELECT * FROM Friend" + login_id + " WHERE FID = '" + searchid + "'";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    if (rdr["FID"].ToString() == searchid) return "이미 친구로 등록되어있습니다";

                }

                rdr.Close();
                query = "INSERT INTO Friend" + login_id + "(FID)" + "VALUES('" + searchid + "')";
                cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();


                return "등록이 완료되었습니다";
            }
        }
    }
}

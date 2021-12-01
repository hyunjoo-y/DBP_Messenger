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
    public partial class SearchFriend : Form
    {
        string conn = connection.connect();

        string userid;
        string friendid;
        public SearchFriend(string friendid)
        {
            InitializeComponent();

            this.userid = connection.userId;
            this.friendid = friendid;
        }
        
        //검색창 친구 데이터 불러오기
        private void SearchFriend_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM on_off WHERE ID = '" + friendid + "'";
            string name = "";
            string nickname = "";
            byte[] profile = null;

            using(MySqlConnection connect = new MySqlConnection(conn))
            {
                connect.Open();

                MySqlCommand cmd = new MySqlCommand(query, connect);
                MySqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        nickname = rdr["별명"].ToString();

                        try { profile = (byte[])rdr["프로필사진"];
                            pictureBox_profile.Image = imageBt.read_imagebyte(profile);
                             }
                        catch(Exception d) { }

                        label_friendname.Text = name;
                        label_friendnickname.Text = nickname;
                        
                        break;
                    }
                rdr.Close();
                
                query = query = "SELECT * FROM FRIENDLIST WHERE ID = '" + userid + "' && FRIENDID = '" + friendid + "'";
                cmd = new MySqlCommand(query, connect);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    if (rdr != null)
                    {
                        button_add.Visible = false;
                        button_delete.Visible = true;
                        label_alarm.Visible = true;
                        return;
                    }
                }
                
            }
        }

        private void button_addfriend_Click(object sender, EventArgs e)
        {
            string addid = friendid;

            if(FriendManagement.addFriend(addid))
            {
                label_alarm.Visible = true;
                label_alarm.Text = "등록완료";

                button_add.Visible = false;
                button_delete.Visible = true;
            }
            else
            {
                label_alarm.Visible = true;
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            string addid = friendid;

            FriendManagement.deleteFriend(addid);

            button_delete.Visible = false;
            button_add.Visible = true;
            label_alarm.Visible = true;
            label_alarm.Text = "삭제완료";
        }

    }
}

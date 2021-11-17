using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_SNS
{
    public partial class changeData : Form
    {

        public string login_id { get; set; }
        public string login_pw { get; set; }

        public changeData(string login_id, string login_pw)
        {
            InitializeComponent();
            this.login_id = login_id;
            this.login_pw = login_pw;
            SetForm();

        }
        string strconn = "Server=27.96.130.41;Port=3306;Database=s5671252;Uid=s5671252;Pwd=s5671252";


        //USERID, USERPW,NAME,ADDRESS,NICKNAME
        //로그인 완료 후 데이터를 불러오는 메소드
        public void SetForm()
        {
            byte[] imgData = null;

            using (MySqlConnection conn = new MySqlConnection(strconn))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM on_off WHERE ID='" + login_id + "'";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        textBox_cgnickname.Text = (string)rdr["별명"];
                        textBox_cdstmsg.Text = (string)rdr["상태메시지"];
                        //imgData = (byte[])rdr["프로필사진"];

                        //ProfilePicture.Image = imageBt.read_imagebyte(imgData);         

                    }
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show("Error " + ex.Number + " has occurred: " + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }

            }

        }

        //패스워드,이름,주소,별명을 저장하는 버튼 이벤트
        private void button_cgsave_Click(object sender, EventArgs e)
        {
            int count = 1;

            string nickname = textBox_cgnickname.Text;
            string messeage = textBox_cdstmsg.Text;

            using (MySqlConnection conn = new MySqlConnection(strconn))
            {
                conn.Open();

                string query = "SELECT * FROM on_off WHERE ID = '" + login_id + "'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    count = Convert.ToInt32(rdr["count"]);
                }
                Console.WriteLine(count);
                rdr.Close();

                query = query = "UPDATE on_off SET 상태메시지='" + messeage + "',별명='" + nickname + "' WHERE ID ='" + login_id + "'";
                cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("SAVED");

            }
        }

        //버튼 클릭시 이미지 표시, DB 저장
        private void button_change_picture_Click(object sender, EventArgs e)
        {
            OpenFileDialog pFileDlg = new OpenFileDialog();
            pFileDlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";

            byte[] imgData = null;

            if (pFileDlg.ShowDialog() == DialogResult.OK)
            {
                string filename = pFileDlg.FileName.ToString();
                ProfilePicture.ImageLocation = filename;

                if (filename != "")
                {
                    imgData = on_off_proj.imageBt.insert_imagebyte(filename);
                }

                ProfilePicture.SizeMode = PictureBoxSizeMode.StretchImage;

                using (MySqlConnection conn = new MySqlConnection(strconn))
                {
                    try
                    {
                        conn.Open();

                        string query = "UPDATE on_off SET 프로필사진='" + imgData
                            + "'WHERE ID ='" + login_id + "'";
                        MySqlCommand cmd = new MySqlCommand(query, conn);


                        cmd.ExecuteNonQuery();
                    }
                    catch (MySql.Data.MySqlClient.MySqlException ex)
                    {
                        MessageBox.Show("Error " + ex.Number + " has occurred: " + ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


    }
}

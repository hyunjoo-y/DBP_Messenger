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
    public partial class changeMemInfo : Form
    {
        public string login_id { get; set; }
        public string login_pw { get; set; }

        public changeMemInfo(string login_id, string login_pw)
        {
            InitializeComponent();
            this.login_id = login_id;
            this.login_pw = login_pw;
            SetForm();
        }

        string strconn = "Server=27.96.130.41;Port=3306;Database=s5671252;Uid=s5671252;Pwd=s5671252";
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
                        textBox_CMIpassword.Text = login_pw;
                        textBox_CMIname.Text = (string)rdr["이름"];
                        ef.Text = (string)rdr["우편번호"];
                        textBox_CMIaddress.Text = (string)rdr["주소"];
                        textBox_cgaddress3.Text = (string)rdr["상세주소"];

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

            if (textBox_CMInewPsw.Text != textBox_CMInewPswCer.Text)
            {
                MessageBox.Show("확인 비밀번호와 다름");
                return;
            }
            int count = 1;
            string password = textBox_CMInewPswCer.Text;
            string name = textBox_CMIname.Text;
            string Postalcode = textBox_CMIpostalcode.Text;
            string address1 = textBox_CMIaddress.Text;
            string address2 = textBox_CMIdetail.Text;

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
                string pw = AES.Encryption(password, count.ToString());
                rdr.Close();

                query = query = "UPDATE on_off SET PW='" + pw + "',이름='" + name + "',우편번호='" + Postalcode + "',주소='" + address1
                    + "',상세주소='" + address2 + "' WHERE ID ='" + login_id + "'";
                cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("SAVED");

            }
        }


        private void button_searchaddress_Click(object sender, EventArgs e)
        {
            address frm = new address();
            frm.ShowDialog();

            // 창이 닫히면 반환값을 반환한다.
            if (frm.gstrZipCode != "")
            {
                textBox_CMIpostalcode.Text = frm.gstrZipCode;
                textBox_CMIaddress.Text = frm.gstrAddress1;
            }

            frm = null;
        }
    }

}


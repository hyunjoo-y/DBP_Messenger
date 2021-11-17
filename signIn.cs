using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace on_off_proj
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();

            setUp();
        }
        string strconn = "Server=27.96.130.41;Port=3306;Database=s5671252;Uid=s5671252;Pwd=s5671252";

        //로그인 버튼 클릭했을 때
        private void button_login_Click(object sender, EventArgs e)
        {
            BinaryWriter brChecked = new BinaryWriter(new FileStream("setting.stu", FileMode.OpenOrCreate));
            bool login = false;

            int count = 1;

            using (MySqlConnection conn = new MySqlConnection(strconn))
            {
                conn.Open();

                string login_id = textBox_id.Text;
                string login_pw = textBox_pw.Text;

                string query = "SELECT * FROM on_off WHERE ID = '" + login_id + "'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    count = Convert.ToInt32(rdr["count"].ToString());
                    Console.WriteLine(count);
                    string pw = AES.Decryption(rdr["PW"].ToString(), count.ToString());

                    if (login_id == (string)rdr["ID"] && login_pw == pw)
                    {
                        login = true;
                    }
                }
                rdr.Close();
                
                if (login)
                {
                    if (checkBox_Remember.Checked)
                    {
                        brChecked.Write("Remember_Account=true");
                        brChecked.Write("ID=" + textBox_id.Text);
                        brChecked.Write("PW=" + DB_SNS.Encrypt.encryptAES128(textBox_pw.Text));
                    }
                    else
                    {
                        brChecked.Write("Remember_Account=false");
                    }
                    MessageBox.Show("LOGIN SUCCESS");
                    this.Visible = false;
                    MainScreen change = new MainScreen(login_id, login_pw);
                    change.ShowDialog();
                    brChecked.Close();

                }
                else
                {
                    MessageBox.Show("LOGIN FAILED");
                }

                brChecked.Close();
            }
        }

        public void setUp()
        {
            BinaryReader brChecked = new BinaryReader(new FileStream("setting.stu", FileMode.OpenOrCreate));
            try
            {
                string check = brChecked.ReadString();

                if (check.Substring(17) == "false")
                {
                    return;
                }
                else if (check.Substring(17) == "true")
                {
                    string id = brChecked.ReadString();
                    string pw = brChecked.ReadString();

                    checkBox_Remember.Checked = true;
                    textBox_id.Text = id.Substring(3);
                    textBox_pw.Text = DB_SNS.Encrypt.decryptAES128(pw.Substring(3));
                }
            }
            catch (EndOfStreamException)
            {
                Console.WriteLine("Error");
                return;
            }
            finally
            {
                brChecked.Close();
            }


        }

        private void button_legister_Click(object sender, EventArgs e)
        {
            sign_up signup = new sign_up();
            signup.ShowDialog();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
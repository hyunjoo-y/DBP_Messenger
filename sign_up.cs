using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using System.IO;

namespace on_off_proj
{
    public partial class sign_up : Form
    {
        public sign_up()
        {
            InitializeComponent();
        }

        private void sing_up_save_button_Click(object sender, EventArgs e)
        {

            string myConnection = "Server=27.96.130.41;Port=3306;Database=s5671252;Uid=s5671252;Pwd=s5671252";
            using (MySqlConnection connection = new MySqlConnection(myConnection))
            {
                connection.Open();
                int count = 1; // 비밀키

                //아이디 중복확인 처리
                Boolean ID_check = true;

                try//예외 처리
                {
                    string Query = "SELECT * FROM on_off";

                    MySqlCommand mySqlCommand = new MySqlCommand(Query, connection);
                    MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

                    if(mySqlDataReader.HasRows == true) //db에 1개 이상의 값이 있다면 실행
                    {
                        while (mySqlDataReader.Read())
                        {
                            if (textBox_sign_up_ID.Text == mySqlDataReader["ID"].ToString())
                            {
                                MessageBox.Show("아이디가 중복됩니다.");
                                ID_check = false;
                            }
                        }
                        count = Convert.ToInt32(mySqlDataReader["count"].ToString()) + 1;
                    }
                    mySqlDataReader.Close();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("실패");
                    Console.WriteLine(ex.ToString());
                }

                //비밀번호 암호화
                AES aes = new AES();
                string pw = aes.Encryption(textBox_sign_up_PW.Text, count.ToString());

                //이미지파일 바이트단위저장
                byte[] imageBt = null;
                if (textBox_sign_up_image_path.Text != "")
                {
                    FileStream fstream = new FileStream(this.textBox_sign_up_image_path.Text, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fstream);
                    imageBt = br.ReadBytes((int)fstream.Length);
                }



                //회원가입
                string insertQuery = "INSERT INTO on_off(ID, PW, 이름, 주소, 별명, 프로필사진)" +
                   "VALUES('" + this.textBox_sign_up_ID.Text + "','" + pw + "','" + this.textBox_sign_up_Name.Text + "','"
                   + this.textBox_sign_up_Address.Text + "','" + this.textBox_sign_up_Nickname.Text + "',@IMG)";
                try
                {
                    MySqlCommand mySqlInsertCommand = new MySqlCommand(insertQuery, connection);
                    
                    mySqlInsertCommand.Parameters.Add(new MySqlParameter("@IMG", imageBt));
                    

                    if(ID_check == true)
                    {
                        mySqlInsertCommand.ExecuteNonQuery();
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }

            }

        }

        private void sign_up_pictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog dig = new OpenFileDialog();
            dig.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";

            if(dig.ShowDialog() == DialogResult.OK)
            {
                string picLoc = dig.FileName.ToString();
                textBox_sign_up_image_path.Text = picLoc;
                pictureBox_sign_up.ImageLocation = picLoc;


            }
        }
    }
}

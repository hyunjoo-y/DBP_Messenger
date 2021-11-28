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
    public partial class TestForm : Form
    {
        private string strconn = "Server=118.67.143.130;Port=3306;Database=DBP;Uid=root;Pwd=B3J5RmHYibc;Charset=utf8";

        public TestForm()
        {

            InitializeComponent();

            using (MySqlConnection conn = new MySqlConnection(strconn))
            {
                conn.Open();
                String userid = "AFSDFASDF"; //여기는 현재 로그인 된 유저id로 받아올 것.

                String query = "SELECT bgColor FROM on_off WHERE ID =\'" + userid + "\';";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    String col = rdr["bgColor"].ToString(); //백그라운드 컬러를 16진수 문자열로 
                      this.BackColor = System.Drawing.ColorTranslator.FromHtml(col);

                }
                rdr.Close();
                conn.Close();
            }
        }
    }
}

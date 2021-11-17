using DB_SNS;
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
    }
}

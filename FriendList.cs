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
    public partial class FriendList : Form
    {
        public FriendList()
        {
            InitializeComponent();
            
           

        }
        private void FriendList_Load_1(object sender, EventArgs e)
        {
            createFriendItems();
            createUserItem();
        }

        private void createUserItem()
        {
            UserControl1 listItem = new UserControl1();

            listItem.Uname = "유저 이름";
            listItem.Icon = Properties.Resources.imoji1;

            panel1.Controls.Add(listItem);
           
        }


        private void createFriendItems()
        {
            

            UserControl1[] listItems = new UserControl1[20]; //이건 친구수 count로 select해와서 생성하셔야 됨. 20은 그냥 제가 임의로 적은거

            for (int i = 0; i < 20; i++)
            {
                
                listItems[i] = new UserControl1();
                
                listItems[i].Id = "유저 식별할 아이디"; //아이디 넣고
                if (i == 5) {
                    listItems[5].Id = "rlqknrql";
                }
                listItems[i].Icon = Properties.Resources.imoji1; //유저 이미지 넣고
                listItems[i].Uname = Convert.ToString(i); //유저이름 넣으세요 그럼 리스트에 출력됨
             //   if (i < 10)
             //   { 그냥 테스트
             //       listItems[i].Uname = "김다운";
              //  }
               // else
               //     listItems[i].Uname = "박예리";
                
                
                    flowLayoutPanel1.Controls.Add(listItems[i]);
                listItems[i].Cursor = Cursors.Hand;
                listItems[i].Click += new EventHandler(view_detail);
            }
        }

        public void view_detail(object sender, EventArgs e)
        {
            //여기서 가져오시면 됨.
            UserControl1 user = sender as UserControl1;
            MessageBox.Show(user.Id);
            
        }

       public void search_friend()
        {
            foreach (Control c in flowLayoutPanel1.Controls)
            {
                if (c.GetType() == typeof(UserControl1))
                {
                    UserControl1 targetf = (UserControl1)c;
                    if (!targetf.Uname.Contains(textBoxSearchFriend.Text))
                    {
                        flowLayoutPanel1.Controls.Remove(c);
                    }
                }
            }

            foreach (Control c in flowLayoutPanel1.Controls)
            {
                if (c.GetType() == typeof(UserControl1))
                {
                    UserControl1 targetf = (UserControl1)c;
                    if (!targetf.Uname.Contains(textBoxSearchFriend.Text))
                    {
                        flowLayoutPanel1.Controls.Remove(c);
                    }
                }
            }
            foreach (Control c in flowLayoutPanel1.Controls)
            {
                if (c.GetType() == typeof(UserControl1))
                {
                    UserControl1 targetf = (UserControl1)c;
                    if (!targetf.Uname.Contains(textBoxSearchFriend.Text))
                    {
                        flowLayoutPanel1.Controls.Remove(c);
                    }
                }
            }
            foreach (Control c in flowLayoutPanel1.Controls)
            {
                if (c.GetType() == typeof(UserControl1))
                {
                    UserControl1 targetf = (UserControl1)c;
                    if (!targetf.Uname.Contains(textBoxSearchFriend.Text))
                    {
                        flowLayoutPanel1.Controls.Remove(c);

                    }
                }
            }
            foreach (Control c in flowLayoutPanel1.Controls)
            {
                if (c.GetType() == typeof(UserControl1))
                {
                    UserControl1 targetf = (UserControl1)c;
                    if (!targetf.Uname.Contains(textBoxSearchFriend.Text))
                    {
                        flowLayoutPanel1.Controls.Remove(c);

                    }
                }
            }

        }
        private void pictureBoxClick_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            createFriendItems();
            search_friend();
        }

        private void pictureBox_addsearch_Click(object sender, EventArgs e)
        {
            string userid = "User1";
            string friendid = textBoxSearchFriend.Text;
            SearchFriend search = new SearchFriend(friendid);

            search.Show();
        }
    }
}

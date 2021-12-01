
namespace on_off_proj
{
    partial class FriendList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxSearchFriend = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxClick = new System.Windows.Forms.PictureBox();
            this.pictureBox_addsearch = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_addsearch)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Location = new System.Drawing.Point(350, -1);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(81, 650);
            this.panel2.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 184);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(351, 465);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 46);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 82);
            this.panel1.TabIndex = 3;
            // 
            // textBoxSearchFriend
            // 
            this.textBoxSearchFriend.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSearchFriend.Font = new System.Drawing.Font("굴림", 13F);
            this.textBoxSearchFriend.Location = new System.Drawing.Point(18, 142);
            this.textBoxSearchFriend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxSearchFriend.Name = "textBoxSearchFriend";
            this.textBoxSearchFriend.Size = new System.Drawing.Size(223, 25);
            this.textBoxSearchFriend.TabIndex = 4;
            this.textBoxSearchFriend.TextChanged += new System.EventHandler(this.pictureBoxClick_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(-7, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(358, 19);
            this.label2.TabIndex = 9;
            // 
            // pictureBoxClick
            // 
            this.pictureBoxClick.Image = global::on_off_proj.Properties.Resources.search_icon;
            this.pictureBoxClick.Location = new System.Drawing.Point(259, 136);
            this.pictureBoxClick.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxClick.Name = "pictureBoxClick";
            this.pictureBoxClick.Size = new System.Drawing.Size(38, 35);
            this.pictureBoxClick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClick.TabIndex = 7;
            this.pictureBoxClick.TabStop = false;
            this.pictureBoxClick.Click += new System.EventHandler(this.pictureBoxClick_Click);
            // 
            // pictureBox_addsearch
            // 
            this.pictureBox_addsearch.Image = global::on_off_proj.Properties.Resources.search_icon;
            this.pictureBox_addsearch.Location = new System.Drawing.Point(306, 136);
            this.pictureBox_addsearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox_addsearch.Name = "pictureBox_addsearch";
            this.pictureBox_addsearch.Size = new System.Drawing.Size(38, 35);
            this.pictureBox_addsearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_addsearch.TabIndex = 10;
            this.pictureBox_addsearch.TabStop = false;
            this.pictureBox_addsearch.Click += new System.EventHandler(this.pictureBox_addsearch_Click);
            // 
            // FriendList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(431, 650);
            this.Controls.Add(this.pictureBox_addsearch);
            this.Controls.Add(this.pictureBoxClick);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSearchFriend);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FriendList";
            this.Text = "FriendList";
            this.Load += new System.EventHandler(this.FriendList_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_addsearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxSearchFriend;
        private System.Windows.Forms.PictureBox pictureBoxClick;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox_addsearch;
    }
}
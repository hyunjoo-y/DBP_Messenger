
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
            this.pictureBoxClick = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClick)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Location = new System.Drawing.Point(306, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(71, 520);
            this.panel2.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 147);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(307, 372);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 66);
            this.panel1.TabIndex = 3;
            // 
            // textBoxSearchFriend
            // 
            this.textBoxSearchFriend.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSearchFriend.Font = new System.Drawing.Font("굴림", 13F);
            this.textBoxSearchFriend.Location = new System.Drawing.Point(16, 114);
            this.textBoxSearchFriend.Name = "textBoxSearchFriend";
            this.textBoxSearchFriend.Size = new System.Drawing.Size(236, 20);
            this.textBoxSearchFriend.TabIndex = 4;
            this.textBoxSearchFriend.TextChanged += new System.EventHandler(this.pictureBoxClick_Click);
            // 
            // pictureBoxClick
            // 
            this.pictureBoxClick.Image = global::on_off_proj.Properties.Resources.search_icon;
            this.pictureBoxClick.Location = new System.Drawing.Point(266, 110);
            this.pictureBoxClick.Name = "pictureBoxClick";
            this.pictureBoxClick.Size = new System.Drawing.Size(33, 28);
            this.pictureBoxClick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClick.TabIndex = 7;
            this.pictureBoxClick.TabStop = false;
            this.pictureBoxClick.Click += new System.EventHandler(this.pictureBoxClick_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(-6, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 15);
            this.label2.TabIndex = 9;
            // 
            // FriendList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(377, 520);
            this.Controls.Add(this.pictureBoxClick);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSearchFriend);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FriendList";
            this.Text = "FriendList";
            this.Load += new System.EventHandler(this.FriendList_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClick)).EndInit();
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
    }
}
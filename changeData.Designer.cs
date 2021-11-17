
namespace DB_SNS
{
    partial class changeData
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
            this.textBox_cgnickname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_cdstmsg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_change_picture = new on_off_proj.RoundedButton();
            this.button_cgsave = new on_off_proj.RoundedButton();
            this.ProfilePicture = new on_off_proj.RoundPictureBox();
            this.roundedButton1 = new on_off_proj.RoundedButton();
            this.roundedButton2 = new on_off_proj.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_cgnickname
            // 
            this.textBox_cgnickname.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox_cgnickname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_cgnickname.Location = new System.Drawing.Point(81, 451);
            this.textBox_cgnickname.Name = "textBox_cgnickname";
            this.textBox_cgnickname.Size = new System.Drawing.Size(344, 18);
            this.textBox_cgnickname.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(62, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "별명";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(62, 514);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "상태메시지";
            // 
            // textBox_cdstmsg
            // 
            this.textBox_cdstmsg.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox_cdstmsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_cdstmsg.Location = new System.Drawing.Point(81, 558);
            this.textBox_cdstmsg.Name = "textBox_cdstmsg";
            this.textBox_cdstmsg.Size = new System.Drawing.Size(344, 18);
            this.textBox_cdstmsg.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(24, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 30);
            this.label3.TabIndex = 15;
            this.label3.Text = "프로필 설정";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 10);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // button_change_picture
            // 
            this.button_change_picture.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_change_picture.FlatAppearance.BorderSize = 0;
            this.button_change_picture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_change_picture.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold);
            this.button_change_picture.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.button_change_picture.Location = new System.Drawing.Point(300, 269);
            this.button_change_picture.Name = "button_change_picture";
            this.button_change_picture.Size = new System.Drawing.Size(75, 72);
            this.button_change_picture.TabIndex = 19;
            this.button_change_picture.Text = "+";
            this.button_change_picture.UseVisualStyleBackColor = false;
            this.button_change_picture.Click += new System.EventHandler(this.button_change_picture_Click);
            // 
            // button_cgsave
            // 
            this.button_cgsave.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_cgsave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_cgsave.FlatAppearance.BorderSize = 0;
            this.button_cgsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cgsave.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.button_cgsave.ForeColor = System.Drawing.Color.Black;
            this.button_cgsave.Location = new System.Drawing.Point(150, 678);
            this.button_cgsave.Name = "button_cgsave";
            this.button_cgsave.Size = new System.Drawing.Size(236, 66);
            this.button_cgsave.TabIndex = 14;
            this.button_cgsave.Text = "프로필 수정";
            this.button_cgsave.UseVisualStyleBackColor = false;
            this.button_cgsave.Click += new System.EventHandler(this.button_cgsave_Click);
            // 
            // ProfilePicture
            // 
            this.ProfilePicture.BackgroundImage = global::on_off_proj.Properties.Resources.유튜브_기본프로필_하늘색;
            this.ProfilePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ProfilePicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.ProfilePicture.InitialImage = null;
            this.ProfilePicture.Location = new System.Drawing.Point(150, 126);
            this.ProfilePicture.Name = "ProfilePicture";
            this.ProfilePicture.Size = new System.Drawing.Size(215, 215);
            this.ProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProfilePicture.TabIndex = 11;
            this.ProfilePicture.TabStop = false;
            // 
            // roundedButton1
            // 
            this.roundedButton1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.roundedButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.roundedButton1.FlatAppearance.BorderSize = 0;
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.roundedButton1.ForeColor = System.Drawing.Color.Black;
            this.roundedButton1.Location = new System.Drawing.Point(65, 434);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(375, 48);
            this.roundedButton1.TabIndex = 17;
            this.roundedButton1.UseVisualStyleBackColor = false;
            // 
            // roundedButton2
            // 
            this.roundedButton2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.roundedButton2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.roundedButton2.FlatAppearance.BorderSize = 0;
            this.roundedButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.roundedButton2.ForeColor = System.Drawing.Color.Black;
            this.roundedButton2.Location = new System.Drawing.Point(65, 541);
            this.roundedButton2.Name = "roundedButton2";
            this.roundedButton2.Size = new System.Drawing.Size(375, 48);
            this.roundedButton2.TabIndex = 18;
            this.roundedButton2.UseVisualStyleBackColor = false;
            // 
            // changeData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(520, 853);
            this.Controls.Add(this.button_change_picture);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_cgsave);
            this.Controls.Add(this.textBox_cdstmsg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProfilePicture);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_cgnickname);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.roundedButton1);
            this.Controls.Add(this.roundedButton2);
            this.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "changeData";
            this.Text = "ON-OFF";
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_cgnickname;
        private System.Windows.Forms.Label label2;
        private on_off_proj.RoundPictureBox ProfilePicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_cdstmsg;
        private on_off_proj.RoundedButton button_cgsave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private on_off_proj.RoundedButton roundedButton1;
        private on_off_proj.RoundedButton roundedButton2;
        private on_off_proj.RoundedButton button_change_picture;
    }
}
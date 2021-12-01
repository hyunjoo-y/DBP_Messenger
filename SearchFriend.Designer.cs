
namespace on_off_proj
{
    partial class SearchFriend
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
            this.pictureBox_profile = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.label_friendname = new System.Windows.Forms.Label();
            this.label_friendnickname = new System.Windows.Forms.Label();
            this.label_alarm = new System.Windows.Forms.Label();
            this.button_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_profile)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_profile
            // 
            this.pictureBox_profile.Image = global::on_off_proj.Properties.Resources.유튜브_기본프로필_하늘색;
            this.pictureBox_profile.Location = new System.Drawing.Point(117, 27);
            this.pictureBox_profile.Name = "pictureBox_profile";
            this.pictureBox_profile.Size = new System.Drawing.Size(151, 130);
            this.pictureBox_profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_profile.TabIndex = 0;
            this.pictureBox_profile.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "별명";
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(151, 371);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 3;
            this.button_add.Text = "친구추가";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_addfriend_Click);
            // 
            // label_friendname
            // 
            this.label_friendname.AutoSize = true;
            this.label_friendname.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label_friendname.Location = new System.Drawing.Point(148, 209);
            this.label_friendname.Name = "label_friendname";
            this.label_friendname.Size = new System.Drawing.Size(45, 15);
            this.label_friendname.TabIndex = 4;
            this.label_friendname.Text = "label3";
            // 
            // label_friendnickname
            // 
            this.label_friendnickname.AutoSize = true;
            this.label_friendnickname.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label_friendnickname.Location = new System.Drawing.Point(148, 246);
            this.label_friendnickname.Name = "label_friendnickname";
            this.label_friendnickname.Size = new System.Drawing.Size(45, 15);
            this.label_friendnickname.TabIndex = 5;
            this.label_friendnickname.Text = "label4";
            // 
            // label_alarm
            // 
            this.label_alarm.AutoSize = true;
            this.label_alarm.BackColor = System.Drawing.SystemColors.Info;
            this.label_alarm.Location = new System.Drawing.Point(114, 328);
            this.label_alarm.Name = "label_alarm";
            this.label_alarm.Size = new System.Drawing.Size(167, 15);
            this.label_alarm.TabIndex = 6;
            this.label_alarm.Text = "이미 등록된 친구입니다";
            this.label_alarm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_alarm.Visible = false;
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(154, 401);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 23);
            this.button_delete.TabIndex = 7;
            this.button_delete.Text = "친구삭제";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Visible = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // SearchFriend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 476);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.label_alarm);
            this.Controls.Add(this.label_friendnickname);
            this.Controls.Add(this.label_friendname);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_profile);
            this.Name = "SearchFriend";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SearchFriend_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_profile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_profile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Label label_friendname;
        private System.Windows.Forms.Label label_friendnickname;
        private System.Windows.Forms.Label label_alarm;
        private System.Windows.Forms.Button button_delete;
    }
}
﻿
namespace on_off_proj
{
    partial class sign_up
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox_sign_up = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_sign_up_ID = new System.Windows.Forms.TextBox();
            this.textBox_sign_up_PW = new System.Windows.Forms.TextBox();
            this.textBox_sign_up_Name = new System.Windows.Forms.TextBox();
            this.textBox_sign_up_Nickname = new System.Windows.Forms.TextBox();
            this.textBox_sign_up_Address = new System.Windows.Forms.TextBox();
            this.button_sing_up_save = new System.Windows.Forms.Button();
            this.textBox_sign_up_image_path = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_sign_up)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_sign_up
            // 
            this.pictureBox_sign_up.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pictureBox_sign_up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox_sign_up.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_sign_up.Location = new System.Drawing.Point(60, 37);
            this.pictureBox_sign_up.Name = "pictureBox_sign_up";
            this.pictureBox_sign_up.Size = new System.Drawing.Size(265, 265);
            this.pictureBox_sign_up.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_sign_up.TabIndex = 0;
            this.pictureBox_sign_up.TabStop = false;
            this.pictureBox_sign_up.Click += new System.EventHandler(this.sign_up_pictureBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 413);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 490);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "주소";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 451);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "별명";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "PW";
            // 
            // textBox_sign_up_ID
            // 
            this.textBox_sign_up_ID.Location = new System.Drawing.Point(119, 336);
            this.textBox_sign_up_ID.Name = "textBox_sign_up_ID";
            this.textBox_sign_up_ID.Size = new System.Drawing.Size(177, 25);
            this.textBox_sign_up_ID.TabIndex = 6;
            // 
            // textBox_sign_up_PW
            // 
            this.textBox_sign_up_PW.Location = new System.Drawing.Point(119, 372);
            this.textBox_sign_up_PW.Name = "textBox_sign_up_PW";
            this.textBox_sign_up_PW.Size = new System.Drawing.Size(177, 25);
            this.textBox_sign_up_PW.TabIndex = 7;
            // 
            // textBox_sign_up_Name
            // 
            this.textBox_sign_up_Name.Location = new System.Drawing.Point(119, 413);
            this.textBox_sign_up_Name.Name = "textBox_sign_up_Name";
            this.textBox_sign_up_Name.Size = new System.Drawing.Size(177, 25);
            this.textBox_sign_up_Name.TabIndex = 8;
            // 
            // textBox_sign_up_Nickname
            // 
            this.textBox_sign_up_Nickname.Location = new System.Drawing.Point(119, 451);
            this.textBox_sign_up_Nickname.Name = "textBox_sign_up_Nickname";
            this.textBox_sign_up_Nickname.Size = new System.Drawing.Size(177, 25);
            this.textBox_sign_up_Nickname.TabIndex = 9;
            // 
            // textBox_sign_up_Address
            // 
            this.textBox_sign_up_Address.Location = new System.Drawing.Point(119, 490);
            this.textBox_sign_up_Address.Name = "textBox_sign_up_Address";
            this.textBox_sign_up_Address.Size = new System.Drawing.Size(177, 25);
            this.textBox_sign_up_Address.TabIndex = 10;
            // 
            // button_sing_up_save
            // 
            this.button_sing_up_save.Location = new System.Drawing.Point(132, 565);
            this.button_sing_up_save.Name = "button_sing_up_save";
            this.button_sing_up_save.Size = new System.Drawing.Size(107, 76);
            this.button_sing_up_save.TabIndex = 11;
            this.button_sing_up_save.Text = "완료";
            this.button_sing_up_save.UseVisualStyleBackColor = true;
            this.button_sing_up_save.Click += new System.EventHandler(this.sing_up_save_button_Click);
            // 
            // textBox_sign_up_image_path
            // 
            this.textBox_sign_up_image_path.Location = new System.Drawing.Point(132, 116);
            this.textBox_sign_up_image_path.Name = "textBox_sign_up_image_path";
            this.textBox_sign_up_image_path.Size = new System.Drawing.Size(100, 25);
            this.textBox_sign_up_image_path.TabIndex = 12;
            // 
            // sign_up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(382, 653);
            this.Controls.Add(this.button_sing_up_save);
            this.Controls.Add(this.textBox_sign_up_Address);
            this.Controls.Add(this.textBox_sign_up_Nickname);
            this.Controls.Add(this.textBox_sign_up_Name);
            this.Controls.Add(this.textBox_sign_up_PW);
            this.Controls.Add(this.textBox_sign_up_ID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_sign_up);
            this.Controls.Add(this.textBox_sign_up_image_path);
            this.Name = "sign_up";
            this.Text = "sign_up";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_sign_up)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_sign_up;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_sign_up_ID;
        private System.Windows.Forms.TextBox textBox_sign_up_PW;
        private System.Windows.Forms.TextBox textBox_sign_up_Name;
        private System.Windows.Forms.TextBox textBox_sign_up_Nickname;
        private System.Windows.Forms.TextBox textBox_sign_up_Address;
        private System.Windows.Forms.Button button_sing_up_save;
        private System.Windows.Forms.TextBox textBox_sign_up_image_path;
    }
}


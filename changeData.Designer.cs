
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
            this.textBox_cgpassword = new System.Windows.Forms.TextBox();
            this.textBox_cgname = new System.Windows.Forms.TextBox();
            this.textBox_cgnickname = new System.Windows.Forms.TextBox();
            this.textBox_cgaddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_cgsave = new System.Windows.Forms.Button();
            this.ProfilePicture = new System.Windows.Forms.PictureBox();
            this.button_change_picture = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_cgpassword
            // 
            this.textBox_cgpassword.Location = new System.Drawing.Point(131, 202);
            this.textBox_cgpassword.Name = "textBox_cgpassword";
            this.textBox_cgpassword.Size = new System.Drawing.Size(100, 25);
            this.textBox_cgpassword.TabIndex = 0;
            // 
            // textBox_cgname
            // 
            this.textBox_cgname.Location = new System.Drawing.Point(131, 245);
            this.textBox_cgname.Name = "textBox_cgname";
            this.textBox_cgname.Size = new System.Drawing.Size(100, 25);
            this.textBox_cgname.TabIndex = 1;
            // 
            // textBox_cgnickname
            // 
            this.textBox_cgnickname.Location = new System.Drawing.Point(131, 290);
            this.textBox_cgnickname.Name = "textBox_cgnickname";
            this.textBox_cgnickname.Size = new System.Drawing.Size(100, 25);
            this.textBox_cgnickname.TabIndex = 2;
            // 
            // textBox_cgaddress
            // 
            this.textBox_cgaddress.Location = new System.Drawing.Point(131, 322);
            this.textBox_cgaddress.Name = "textBox_cgaddress";
            this.textBox_cgaddress.Size = new System.Drawing.Size(100, 25);
            this.textBox_cgaddress.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "NICKNAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "ADDRESS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "PASSWORD";
            // 
            // button_cgsave
            // 
            this.button_cgsave.Location = new System.Drawing.Point(84, 397);
            this.button_cgsave.Name = "button_cgsave";
            this.button_cgsave.Size = new System.Drawing.Size(75, 23);
            this.button_cgsave.TabIndex = 8;
            this.button_cgsave.Text = "SAVE";
            this.button_cgsave.UseVisualStyleBackColor = true;
            this.button_cgsave.Click += new System.EventHandler(this.button_cgsave_Click);
            // 
            // ProfilePicture
            // 
            this.ProfilePicture.Location = new System.Drawing.Point(131, 33);
            this.ProfilePicture.Name = "ProfilePicture";
            this.ProfilePicture.Size = new System.Drawing.Size(100, 120);
            this.ProfilePicture.TabIndex = 9;
            this.ProfilePicture.TabStop = false;
            // 
            // button_change_picture
            // 
            this.button_change_picture.Location = new System.Drawing.Point(146, 159);
            this.button_change_picture.Name = "button_change_picture";
            this.button_change_picture.Size = new System.Drawing.Size(75, 23);
            this.button_change_picture.TabIndex = 10;
            this.button_change_picture.Text = "Change Picture";
            this.button_change_picture.UseVisualStyleBackColor = true;
            this.button_change_picture.Click += new System.EventHandler(this.button_change_picture_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 653);
            this.Controls.Add(this.button_change_picture);
            this.Controls.Add(this.ProfilePicture);
            this.Controls.Add(this.button_cgsave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_cgaddress);
            this.Controls.Add(this.textBox_cgnickname);
            this.Controls.Add(this.textBox_cgname);
            this.Controls.Add(this.textBox_cgpassword);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_cgpassword;
        private System.Windows.Forms.TextBox textBox_cgname;
        private System.Windows.Forms.TextBox textBox_cgnickname;
        private System.Windows.Forms.TextBox textBox_cgaddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_cgsave;
        private System.Windows.Forms.PictureBox ProfilePicture;
        private System.Windows.Forms.Button button_change_picture;
    }
}

namespace on_off_proj
{
    partial class MainScreen
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
            this.button_private = new System.Windows.Forms.Button();
            this.button_profile = new System.Windows.Forms.Button();
            this.textBox_searchId = new System.Windows.Forms.TextBox();
            this.button_addfriend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_private
            // 
            this.button_private.Location = new System.Drawing.Point(83, 362);
            this.button_private.Name = "button_private";
            this.button_private.Size = new System.Drawing.Size(126, 23);
            this.button_private.TabIndex = 0;
            this.button_private.Text = "회원정보수정";
            this.button_private.UseVisualStyleBackColor = true;
            this.button_private.Click += new System.EventHandler(this.button_private_Click);
            // 
            // button_profile
            // 
            this.button_profile.Location = new System.Drawing.Point(215, 362);
            this.button_profile.Name = "button_profile";
            this.button_profile.Size = new System.Drawing.Size(127, 23);
            this.button_profile.TabIndex = 1;
            this.button_profile.Text = "프로필 수정";
            this.button_profile.UseVisualStyleBackColor = true;
            this.button_profile.Click += new System.EventHandler(this.button_profile_Click);
            // 
            // textBox_searchId
            // 
            this.textBox_searchId.Location = new System.Drawing.Point(126, 169);
            this.textBox_searchId.Name = "textBox_searchId";
            this.textBox_searchId.Size = new System.Drawing.Size(100, 25);
            this.textBox_searchId.TabIndex = 2;
            // 
            // button_addfriend
            // 
            this.button_addfriend.Location = new System.Drawing.Point(256, 170);
            this.button_addfriend.Name = "button_addfriend";
            this.button_addfriend.Size = new System.Drawing.Size(114, 23);
            this.button_addfriend.TabIndex = 3;
            this.button_addfriend.Text = "add Friend";
            this.button_addfriend.UseVisualStyleBackColor = true;
            this.button_addfriend.Click += new System.EventHandler(this.button_addfriend_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 653);
            this.Controls.Add(this.button_addfriend);
            this.Controls.Add(this.textBox_searchId);
            this.Controls.Add(this.button_profile);
            this.Controls.Add(this.button_private);
            this.Name = "MainScreen";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_private;
        private System.Windows.Forms.Button button_profile;
        private System.Windows.Forms.TextBox textBox_searchId;
        private System.Windows.Forms.Button button_addfriend;
    }
}
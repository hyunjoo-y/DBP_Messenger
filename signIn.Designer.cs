
namespace on_off_proj
{
    partial class SignIn
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
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_pw = new System.Windows.Forms.TextBox();
            this.button_login = new System.Windows.Forms.Button();
            this.checkBox_Remember = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_legister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(121, 138);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(100, 25);
            this.textBox_id.TabIndex = 0;
            // 
            // textBox_pw
            // 
            this.textBox_pw.Location = new System.Drawing.Point(121, 195);
            this.textBox_pw.Name = "textBox_pw";
            this.textBox_pw.Size = new System.Drawing.Size(100, 25);
            this.textBox_pw.TabIndex = 1;
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(129, 285);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(75, 23);
            this.button_login.TabIndex = 2;
            this.button_login.Text = "LogIN";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // checkBox_Remember
            // 
            this.checkBox_Remember.AutoSize = true;
            this.checkBox_Remember.Location = new System.Drawing.Point(103, 341);
            this.checkBox_Remember.Name = "checkBox_Remember";
            this.checkBox_Remember.Size = new System.Drawing.Size(156, 19);
            this.checkBox_Remember.TabIndex = 3;
            this.checkBox_Remember.Text = "Remember Account";
            this.checkBox_Remember.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "PASSWORD";
            // 
            // button_legister
            // 
            this.button_legister.Location = new System.Drawing.Point(129, 247);
            this.button_legister.Name = "button_legister";
            this.button_legister.Size = new System.Drawing.Size(75, 23);
            this.button_legister.TabIndex = 6;
            this.button_legister.Text = "button";
            this.button_legister.UseVisualStyleBackColor = true;
            this.button_legister.Click += new System.EventHandler(this.button_legister_Click);
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 653);
            this.Controls.Add(this.button_legister);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox_Remember);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.textBox_pw);
            this.Controls.Add(this.textBox_id);
            this.Name = "SignIn";
            this.Text = "SNS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_pw;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.CheckBox checkBox_Remember;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_legister;
    }
}


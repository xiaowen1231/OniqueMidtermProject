namespace prjBackgroundManagementSystem
{
    partial class FormEmployeeManagerLogin
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
            this.btnDemo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMangerEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMangerPassword = new System.Windows.Forms.TextBox();
            this.btnLoginManager = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnForgetManager = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDemo
            // 
            this.btnDemo.BackColor = System.Drawing.Color.White;
            this.btnDemo.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDemo.Location = new System.Drawing.Point(256, 320);
            this.btnDemo.Name = "btnDemo";
            this.btnDemo.Size = new System.Drawing.Size(75, 23);
            this.btnDemo.TabIndex = 5;
            this.btnDemo.Text = "Demo";
            this.btnDemo.UseVisualStyleBackColor = false;
            this.btnDemo.Click += new System.EventHandler(this.btnDemo_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.BurlyWood;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 93);
            this.label1.TabIndex = 8;
            this.label1.Text = "管理員登入系統";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(132, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "請輸入電子郵件:";
            // 
            // txtMangerEmail
            // 
            this.txtMangerEmail.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMangerEmail.Location = new System.Drawing.Point(240, 186);
            this.txtMangerEmail.Name = "txtMangerEmail";
            this.txtMangerEmail.Size = new System.Drawing.Size(100, 25);
            this.txtMangerEmail.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(158, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "請輸入密碼:";
            // 
            // txtMangerPassword
            // 
            this.txtMangerPassword.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMangerPassword.Location = new System.Drawing.Point(240, 227);
            this.txtMangerPassword.Name = "txtMangerPassword";
            this.txtMangerPassword.Size = new System.Drawing.Size(100, 25);
            this.txtMangerPassword.TabIndex = 1;
            // 
            // btnLoginManager
            // 
            this.btnLoginManager.BackColor = System.Drawing.Color.White;
            this.btnLoginManager.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLoginManager.Location = new System.Drawing.Point(256, 291);
            this.btnLoginManager.Name = "btnLoginManager";
            this.btnLoginManager.Size = new System.Drawing.Size(75, 23);
            this.btnLoginManager.TabIndex = 2;
            this.btnLoginManager.Text = "登入";
            this.btnLoginManager.UseVisualStyleBackColor = false;
            this.btnLoginManager.Click += new System.EventHandler(this.btnLoginManager_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClose.Location = new System.Drawing.Point(163, 291);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "關閉";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnForgetManager
            // 
            this.btnForgetManager.BackColor = System.Drawing.Color.White;
            this.btnForgetManager.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnForgetManager.Location = new System.Drawing.Point(372, 421);
            this.btnForgetManager.Name = "btnForgetManager";
            this.btnForgetManager.Size = new System.Drawing.Size(75, 23);
            this.btnForgetManager.TabIndex = 4;
            this.btnForgetManager.Text = "忘記密碼";
            this.btnForgetManager.UseVisualStyleBackColor = false;
            this.btnForgetManager.Visible = false;
            this.btnForgetManager.Click += new System.EventHandler(this.btnForgetManager_Click);
            // 
            // FormEmployeeManagerLogin
            // 
            this.AcceptButton = this.btnLoginManager;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 481);
            this.Controls.Add(this.btnDemo);
            this.Controls.Add(this.btnForgetManager);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLoginManager);
            this.Controls.Add(this.txtMangerPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMangerEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 520);
            this.MinimumSize = new System.Drawing.Size(500, 520);
            this.Name = "FormEmployeeManagerLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理員登入";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEmployeeManagerLogin_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDemo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMangerEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMangerPassword;
        private System.Windows.Forms.Button btnLoginManager;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnForgetManager;
    }
}
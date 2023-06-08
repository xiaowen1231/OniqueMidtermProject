namespace prjBackgroundManagementSystem
{
    partial class FormProductSizeColor
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
            this.buttonSettingProductStock = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.comboBoxSize = new System.Windows.Forms.ComboBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSettingProductStock
            // 
            this.buttonSettingProductStock.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonSettingProductStock.ForeColor = System.Drawing.Color.Black;
            this.buttonSettingProductStock.Location = new System.Drawing.Point(170, 328);
            this.buttonSettingProductStock.Name = "buttonSettingProductStock";
            this.buttonSettingProductStock.Size = new System.Drawing.Size(127, 29);
            this.buttonSettingProductStock.TabIndex = 82;
            this.buttonSettingProductStock.Text = "新增庫存資料";
            this.buttonSettingProductStock.UseVisualStyleBackColor = true;
            this.buttonSettingProductStock.Click += new System.EventHandler(this.buttonSettingProductStock_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonExit.ForeColor = System.Drawing.Color.Red;
            this.buttonExit.Location = new System.Drawing.Point(63, 328);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 29);
            this.buttonExit.TabIndex = 83;
            this.buttonExit.Text = "離開";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(60, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 87;
            this.label4.Text = "商品顏色:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Location = new System.Drawing.Point(138, 258);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(159, 27);
            this.comboBoxColor.TabIndex = 81;
            // 
            // comboBoxSize
            // 
            this.comboBoxSize.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBoxSize.FormattingEnabled = true;
            this.comboBoxSize.Location = new System.Drawing.Point(138, 209);
            this.comboBoxSize.Name = "comboBoxSize";
            this.comboBoxSize.Size = new System.Drawing.Size(159, 27);
            this.comboBoxSize.TabIndex = 80;
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtProductName.Location = new System.Drawing.Point(138, 162);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.ReadOnly = true;
            this.txtProductName.Size = new System.Drawing.Size(159, 25);
            this.txtProductName.TabIndex = 79;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(60, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 85;
            this.label3.Text = "商品尺寸:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(60, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 86;
            this.label2.Text = "商品名稱:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.BurlyWood;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 86);
            this.label1.TabIndex = 84;
            this.label1.Text = "商品尺寸、顏色設定";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormProductSizeColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 377);
            this.Controls.Add(this.buttonSettingProductStock);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxColor);
            this.Controls.Add(this.comboBoxSize);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(373, 416);
            this.MinimumSize = new System.Drawing.Size(373, 416);
            this.Name = "FormProductSizeColor";
            this.Text = "FormProductSizeColor";
            this.Load += new System.EventHandler(this.FormProductSizeColor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSettingProductStock;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.ComboBox comboBoxSize;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
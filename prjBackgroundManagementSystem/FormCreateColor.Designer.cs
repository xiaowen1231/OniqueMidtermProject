namespace prjBackgroundManagementSystem
{
    partial class FormCreateColor
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAddColor = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColorId,
            this.ColorName});
            this.dataGridView1.Location = new System.Drawing.Point(43, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(171, 188);
            this.dataGridView1.TabIndex = 64;
            // 
            // ColorId
            // 
            this.ColorId.DataPropertyName = "ColorId";
            this.ColorId.HeaderText = "ColorId";
            this.ColorId.Name = "ColorId";
            this.ColorId.ReadOnly = true;
            this.ColorId.Visible = false;
            // 
            // ColorName
            // 
            this.ColorName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColorName.DataPropertyName = "ColorName";
            this.ColorName.HeaderText = "顏色";
            this.ColorName.Name = "ColorName";
            this.ColorName.ReadOnly = true;
            // 
            // buttonAddColor
            // 
            this.buttonAddColor.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonAddColor.Location = new System.Drawing.Point(336, 317);
            this.buttonAddColor.Name = "buttonAddColor";
            this.buttonAddColor.Size = new System.Drawing.Size(84, 29);
            this.buttonAddColor.TabIndex = 59;
            this.buttonAddColor.Text = "確認新增";
            this.buttonAddColor.UseVisualStyleBackColor = true;
            this.buttonAddColor.Click += new System.EventHandler(this.buttonAddColor_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonExit.ForeColor = System.Drawing.Color.Red;
            this.buttonExit.Location = new System.Drawing.Point(244, 317);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(86, 29);
            this.buttonExit.TabIndex = 60;
            this.buttonExit.Text = "取消";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // txtColor
            // 
            this.txtColor.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtColor.Location = new System.Drawing.Point(270, 191);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(133, 29);
            this.txtColor.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(266, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 63;
            this.label2.Text = "新增顏色 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(39, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 62;
            this.label3.Text = "現有顏色 :";
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
            this.label1.Size = new System.Drawing.Size(445, 86);
            this.label1.TabIndex = 61;
            this.label1.Text = "新增顏色";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormCreateColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 365);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonAddColor);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(479, 404);
            this.MinimumSize = new System.Drawing.Size(479, 404);
            this.Name = "FormCreateColor";
            this.Text = "FormCreateColor";
            this.Load += new System.EventHandler(this.FormCreateColor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorName;
        private System.Windows.Forms.Button buttonAddColor;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}
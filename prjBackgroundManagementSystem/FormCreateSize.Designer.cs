namespace prjBackgroundManagementSystem
{
    partial class FormCreateSize
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
            this.SizeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAddSize = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SizeId,
            this.SizeName});
            this.dataGridView1.Location = new System.Drawing.Point(37, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(171, 188);
            this.dataGridView1.TabIndex = 57;
            // 
            // SizeId
            // 
            this.SizeId.DataPropertyName = "SizeId";
            this.SizeId.HeaderText = "SizeId";
            this.SizeId.Name = "SizeId";
            this.SizeId.ReadOnly = true;
            this.SizeId.Visible = false;
            // 
            // SizeName
            // 
            this.SizeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SizeName.DataPropertyName = "SizeName";
            this.SizeName.HeaderText = "尺寸";
            this.SizeName.Name = "SizeName";
            this.SizeName.ReadOnly = true;
            // 
            // buttonAddSize
            // 
            this.buttonAddSize.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonAddSize.Location = new System.Drawing.Point(331, 317);
            this.buttonAddSize.Name = "buttonAddSize";
            this.buttonAddSize.Size = new System.Drawing.Size(84, 29);
            this.buttonAddSize.TabIndex = 52;
            this.buttonAddSize.Text = "確認新增";
            this.buttonAddSize.UseVisualStyleBackColor = true;
            this.buttonAddSize.Click += new System.EventHandler(this.buttonAddSize_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonExit.ForeColor = System.Drawing.Color.Red;
            this.buttonExit.Location = new System.Drawing.Point(239, 317);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(86, 29);
            this.buttonExit.TabIndex = 53;
            this.buttonExit.Text = "取消";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // txtSize
            // 
            this.txtSize.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSize.Location = new System.Drawing.Point(260, 194);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(133, 29);
            this.txtSize.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(256, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 55;
            this.label2.Text = "新增尺寸 :";
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
            this.label1.TabIndex = 54;
            this.label1.Text = "新增尺寸";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(33, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 56;
            this.label3.Text = "現有尺寸 :";
            // 
            // FormCreateSize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 365);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonAddSize);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(479, 404);
            this.MinimumSize = new System.Drawing.Size(479, 404);
            this.Name = "FormCreateSize";
            this.Text = "FormCreateSize";
            this.Load += new System.EventHandler(this.FormCreateSize_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SizeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SizeName;
        private System.Windows.Forms.Button buttonAddSize;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}
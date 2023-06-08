namespace prjBackgroundManagementSystem
{
    partial class FormEmployee
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
            this.btnEmployeeAdd = new System.Windows.Forms.Button();
            this.照片路徑 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.入職日 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.職位 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.生日 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.住址 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.地區 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.縣市 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.性別 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.信箱 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.密碼 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.員工名稱 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.編號 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.聯絡電話 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEmployeeSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEmployeeAdd
            // 
            this.btnEmployeeAdd.BackColor = System.Drawing.Color.White;
            this.btnEmployeeAdd.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnEmployeeAdd.Location = new System.Drawing.Point(1036, 118);
            this.btnEmployeeAdd.Name = "btnEmployeeAdd";
            this.btnEmployeeAdd.Size = new System.Drawing.Size(75, 23);
            this.btnEmployeeAdd.TabIndex = 2;
            this.btnEmployeeAdd.Text = "新增員工";
            this.btnEmployeeAdd.UseVisualStyleBackColor = false;
            this.btnEmployeeAdd.Click += new System.EventHandler(this.btnEmployeeAdd_Click);
            // 
            // 照片路徑
            // 
            this.照片路徑.DataPropertyName = "PhotoPath";
            this.照片路徑.HeaderText = "照片路徑";
            this.照片路徑.Name = "照片路徑";
            this.照片路徑.ReadOnly = true;
            this.照片路徑.Visible = false;
            // 
            // 入職日
            // 
            this.入職日.DataPropertyName = "RegisterDate";
            this.入職日.HeaderText = "入職日";
            this.入職日.Name = "入職日";
            this.入職日.ReadOnly = true;
            // 
            // 職位
            // 
            this.職位.DataPropertyName = "Position";
            this.職位.HeaderText = "職位";
            this.職位.Name = "職位";
            this.職位.ReadOnly = true;
            // 
            // 生日
            // 
            this.生日.DataPropertyName = "DateOfBirth";
            this.生日.HeaderText = "生日";
            this.生日.Name = "生日";
            this.生日.ReadOnly = true;
            // 
            // 住址
            // 
            this.住址.DataPropertyName = "Address";
            this.住址.HeaderText = "住址";
            this.住址.Name = "住址";
            this.住址.ReadOnly = true;
            this.住址.Visible = false;
            // 
            // 地區
            // 
            this.地區.DataPropertyName = "Areas";
            this.地區.HeaderText = "地區";
            this.地區.Name = "地區";
            this.地區.ReadOnly = true;
            // 
            // 縣市
            // 
            this.縣市.DataPropertyName = "Citys";
            this.縣市.HeaderText = "縣市";
            this.縣市.Name = "縣市";
            this.縣市.ReadOnly = true;
            // 
            // 性別
            // 
            this.性別.DataPropertyName = "Gender";
            this.性別.HeaderText = "性別";
            this.性別.Name = "性別";
            this.性別.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.BurlyWood;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1102, 89);
            this.label1.TabIndex = 25;
            this.label1.Text = "員工管理";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // 信箱
            // 
            this.信箱.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.信箱.DataPropertyName = "Email";
            this.信箱.HeaderText = "信箱";
            this.信箱.Name = "信箱";
            this.信箱.ReadOnly = true;
            // 
            // 密碼
            // 
            this.密碼.DataPropertyName = "Password";
            this.密碼.HeaderText = "密碼";
            this.密碼.Name = "密碼";
            this.密碼.ReadOnly = true;
            this.密碼.Visible = false;
            // 
            // 員工名稱
            // 
            this.員工名稱.DataPropertyName = "EmployeeName";
            this.員工名稱.HeaderText = "員工名稱";
            this.員工名稱.Name = "員工名稱";
            this.員工名稱.ReadOnly = true;
            // 
            // 編號
            // 
            this.編號.DataPropertyName = "EmployeeId";
            this.編號.HeaderText = "編號";
            this.編號.Name = "編號";
            this.編號.ReadOnly = true;
            this.編號.Visible = false;
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEmployeeName.Location = new System.Drawing.Point(75, 118);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(100, 25);
            this.txtEmployeeName.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Name:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.編號,
            this.員工名稱,
            this.密碼,
            this.聯絡電話,
            this.信箱,
            this.性別,
            this.縣市,
            this.地區,
            this.住址,
            this.生日,
            this.職位,
            this.入職日,
            this.照片路徑});
            this.dataGridView1.Location = new System.Drawing.Point(15, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1096, 548);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // 聯絡電話
            // 
            this.聯絡電話.DataPropertyName = "Phone";
            this.聯絡電話.HeaderText = "聯絡電話";
            this.聯絡電話.Name = "聯絡電話";
            this.聯絡電話.ReadOnly = true;
            // 
            // btnEmployeeSearch
            // 
            this.btnEmployeeSearch.BackColor = System.Drawing.Color.White;
            this.btnEmployeeSearch.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnEmployeeSearch.Location = new System.Drawing.Point(191, 118);
            this.btnEmployeeSearch.Name = "btnEmployeeSearch";
            this.btnEmployeeSearch.Size = new System.Drawing.Size(75, 23);
            this.btnEmployeeSearch.TabIndex = 1;
            this.btnEmployeeSearch.Text = "查詢";
            this.btnEmployeeSearch.UseVisualStyleBackColor = false;
            this.btnEmployeeSearch.Click += new System.EventHandler(this.btnEmployeeSearch_Click);
            // 
            // FormEmployee
            // 
            this.AcceptButton = this.btnEmployeeSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 715);
            this.Controls.Add(this.btnEmployeeAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEmployeeSearch);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1136, 754);
            this.MinimumSize = new System.Drawing.Size(1136, 754);
            this.Name = "FormEmployee";
            this.Text = "員工管理";
            this.Load += new System.EventHandler(this.FormEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEmployeeAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn 照片路徑;
        private System.Windows.Forms.DataGridViewTextBoxColumn 入職日;
        private System.Windows.Forms.DataGridViewTextBoxColumn 職位;
        private System.Windows.Forms.DataGridViewTextBoxColumn 生日;
        private System.Windows.Forms.DataGridViewTextBoxColumn 住址;
        private System.Windows.Forms.DataGridViewTextBoxColumn 地區;
        private System.Windows.Forms.DataGridViewTextBoxColumn 縣市;
        private System.Windows.Forms.DataGridViewTextBoxColumn 性別;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 信箱;
        private System.Windows.Forms.DataGridViewTextBoxColumn 密碼;
        private System.Windows.Forms.DataGridViewTextBoxColumn 員工名稱;
        private System.Windows.Forms.DataGridViewTextBoxColumn 編號;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 聯絡電話;
        private System.Windows.Forms.Button btnEmployeeSearch;
    }
}
namespace prjBackgroundManagementSystem
{
    partial class FormOrder
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxOrderStatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxOrderId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.編號 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.會員名稱 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.運送方式 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.運送地址 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.訂單狀態 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.下訂日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.出貨日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.完成日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.付款方式 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.折扣內容 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSearchAll = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.labelHint = new System.Windows.Forms.Label();
            this.buttonCreateOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.BurlyWood;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1066, 104);
            this.label1.TabIndex = 73;
            this.label1.Text = "訂單管理";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxOrderStatus
            // 
            this.comboBoxOrderStatus.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBoxOrderStatus.FormattingEnabled = true;
            this.comboBoxOrderStatus.Location = new System.Drawing.Point(768, 119);
            this.comboBoxOrderStatus.Name = "comboBoxOrderStatus";
            this.comboBoxOrderStatus.Size = new System.Drawing.Size(142, 24);
            this.comboBoxOrderStatus.TabIndex = 1;
            this.comboBoxOrderStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxOrderStatus_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(699, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 80;
            this.label4.Text = "訂單狀態:";
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.White;
            this.buttonSearch.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonSearch.Location = new System.Drawing.Point(916, 118);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "查詢";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxOrderId
            // 
            this.textBoxOrderId.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxOrderId.Location = new System.Drawing.Point(593, 118);
            this.textBoxOrderId.Name = "textBoxOrderId";
            this.textBoxOrderId.Size = new System.Drawing.Size(100, 25);
            this.textBoxOrderId.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(524, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 83;
            this.label2.Text = "訂單編號:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.編號,
            this.會員名稱,
            this.運送方式,
            this.運送地址,
            this.訂單狀態,
            this.下訂日期,
            this.出貨日期,
            this.完成日期,
            this.付款方式,
            this.折扣內容});
            this.dataGridView1.Location = new System.Drawing.Point(15, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1057, 470);
            this.dataGridView1.TabIndex = 85;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // 編號
            // 
            this.編號.DataPropertyName = "Id";
            this.編號.HeaderText = "編號";
            this.編號.Name = "編號";
            this.編號.ReadOnly = true;
            // 
            // 會員名稱
            // 
            this.會員名稱.DataPropertyName = "MemberName";
            this.會員名稱.HeaderText = "會員名稱";
            this.會員名稱.Name = "會員名稱";
            this.會員名稱.ReadOnly = true;
            // 
            // 運送方式
            // 
            this.運送方式.DataPropertyName = "ShippingMethod";
            this.運送方式.HeaderText = "運送方式";
            this.運送方式.Name = "運送方式";
            this.運送方式.ReadOnly = true;
            // 
            // 運送地址
            // 
            this.運送地址.DataPropertyName = "Address";
            this.運送地址.HeaderText = "運送地址";
            this.運送地址.Name = "運送地址";
            this.運送地址.ReadOnly = true;
            // 
            // 訂單狀態
            // 
            this.訂單狀態.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.訂單狀態.DataPropertyName = "OrderStatus";
            this.訂單狀態.HeaderText = "訂單狀態";
            this.訂單狀態.Name = "訂單狀態";
            this.訂單狀態.ReadOnly = true;
            // 
            // 下訂日期
            // 
            this.下訂日期.DataPropertyName = "OrderDate";
            this.下訂日期.HeaderText = "下訂日期";
            this.下訂日期.Name = "下訂日期";
            this.下訂日期.ReadOnly = true;
            // 
            // 出貨日期
            // 
            this.出貨日期.DataPropertyName = "ShippingDate";
            this.出貨日期.HeaderText = "出貨日期";
            this.出貨日期.Name = "出貨日期";
            this.出貨日期.ReadOnly = true;
            // 
            // 完成日期
            // 
            this.完成日期.DataPropertyName = "CompletionDate";
            this.完成日期.HeaderText = "完成日期";
            this.完成日期.Name = "完成日期";
            this.完成日期.ReadOnly = true;
            // 
            // 付款方式
            // 
            this.付款方式.DataPropertyName = "PaymentMethod";
            this.付款方式.HeaderText = "付款方式";
            this.付款方式.Name = "付款方式";
            this.付款方式.ReadOnly = true;
            // 
            // 折扣內容
            // 
            this.折扣內容.DataPropertyName = "Discount";
            this.折扣內容.HeaderText = "折扣內容";
            this.折扣內容.Name = "折扣內容";
            this.折扣內容.ReadOnly = true;
            // 
            // buttonSearchAll
            // 
            this.buttonSearchAll.BackColor = System.Drawing.Color.White;
            this.buttonSearchAll.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonSearchAll.Location = new System.Drawing.Point(997, 623);
            this.buttonSearchAll.Name = "buttonSearchAll";
            this.buttonSearchAll.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchAll.TabIndex = 4;
            this.buttonSearchAll.Text = "顯示所有";
            this.buttonSearchAll.UseVisualStyleBackColor = false;
            this.buttonSearchAll.Click += new System.EventHandler(this.buttonSearchAll_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.White;
            this.buttonReset.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonReset.Location = new System.Drawing.Point(997, 118);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 3;
            this.buttonReset.Text = "清除查詢";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // labelHint
            // 
            this.labelHint.AutoSize = true;
            this.labelHint.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelHint.ForeColor = System.Drawing.Color.Red;
            this.labelHint.Location = new System.Drawing.Point(415, 121);
            this.labelHint.Name = "labelHint";
            this.labelHint.Size = new System.Drawing.Size(103, 17);
            this.labelHint.TabIndex = 88;
            this.labelHint.Text = "請確認查詢條件!";
            this.labelHint.Visible = false;
            // 
            // buttonCreateOrder
            // 
            this.buttonCreateOrder.BackColor = System.Drawing.Color.White;
            this.buttonCreateOrder.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonCreateOrder.Location = new System.Drawing.Point(15, 633);
            this.buttonCreateOrder.Name = "buttonCreateOrder";
            this.buttonCreateOrder.Size = new System.Drawing.Size(75, 23);
            this.buttonCreateOrder.TabIndex = 5;
            this.buttonCreateOrder.Text = "新增訂單";
            this.buttonCreateOrder.UseVisualStyleBackColor = false;
            this.buttonCreateOrder.Click += new System.EventHandler(this.buttonCreateOrder_Click);
            // 
            // FormOrder
            // 
            this.AcceptButton = this.buttonSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 681);
            this.Controls.Add(this.buttonCreateOrder);
            this.Controls.Add(this.labelHint);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonSearchAll);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxOrderId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.comboBoxOrderStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1100, 720);
            this.MinimumSize = new System.Drawing.Size(1100, 720);
            this.Name = "FormOrder";
            this.Text = "訂單管理";
            this.Load += new System.EventHandler(this.FormOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxOrderStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxOrderId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonSearchAll;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label labelHint;
        private System.Windows.Forms.DataGridViewTextBoxColumn 編號;
        private System.Windows.Forms.DataGridViewTextBoxColumn 會員名稱;
        private System.Windows.Forms.DataGridViewTextBoxColumn 運送方式;
        private System.Windows.Forms.DataGridViewTextBoxColumn 運送地址;
        private System.Windows.Forms.DataGridViewTextBoxColumn 訂單狀態;
        private System.Windows.Forms.DataGridViewTextBoxColumn 下訂日期;
        private System.Windows.Forms.DataGridViewTextBoxColumn 出貨日期;
        private System.Windows.Forms.DataGridViewTextBoxColumn 完成日期;
        private System.Windows.Forms.DataGridViewTextBoxColumn 付款方式;
        private System.Windows.Forms.DataGridViewTextBoxColumn 折扣內容;
        private System.Windows.Forms.Button buttonCreateOrder;
    }
}
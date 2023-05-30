namespace prjBackgroundManagementSystem
{
    partial class FormOrderDetail
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1ShippingMethod = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.labelFreight = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelPayment = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.textBoxOrderDate = new System.Windows.Forms.TextBox();
            this.textBoxShippingDate = new System.Windows.Forms.TextBox();
            this.textBoxCompletionDate = new System.Windows.Forms.TextBox();
            this.編號 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.商品名稱 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.商品價格 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.下單數量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.商品尺寸 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.商品顏色 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(1015, 104);
            this.label1.TabIndex = 73;
            this.label1.Text = "訂單明細檢視";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FloralWhite;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1ShippingMethod);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.labelAddress);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.comboBoxStatus);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.labelTotal);
            this.panel1.Controls.Add(this.labelDiscount);
            this.panel1.Controls.Add(this.labelFreight);
            this.panel1.Controls.Add(this.labelPrice);
            this.panel1.Controls.Add(this.labelPayment);
            this.panel1.Controls.Add(this.labelStatus);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.panel1.Location = new System.Drawing.Point(716, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 537);
            this.panel1.TabIndex = 74;
            // 
            // label1ShippingMethod
            // 
            this.label1ShippingMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1ShippingMethod.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label1ShippingMethod.Location = new System.Drawing.Point(101, 55);
            this.label1ShippingMethod.Name = "label1ShippingMethod";
            this.label1ShippingMethod.Size = new System.Drawing.Size(199, 24);
            this.label1ShippingMethod.TabIndex = 105;
            this.label1ShippingMethod.Text = "未選擇";
            this.label1ShippingMethod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label20.Location = new System.Drawing.Point(4, 59);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(63, 17);
            this.label20.TabIndex = 104;
            this.label20.Text = "運送方式:";
            // 
            // labelAddress
            // 
            this.labelAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAddress.ForeColor = System.Drawing.Color.DarkMagenta;
            this.labelAddress.Location = new System.Drawing.Point(73, 264);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(227, 90);
            this.labelAddress.TabIndex = 103;
            this.labelAddress.Text = "未選擇";
            this.labelAddress.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label17.Location = new System.Drawing.Point(4, 264);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 17);
            this.label17.TabIndex = 102;
            this.label17.Text = "運送地址:";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(118, 357);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(182, 25);
            this.comboBoxStatus.TabIndex = 101;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(3, 509);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 100;
            this.button3.Text = "刪除訂單";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(142, 509);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 99;
            this.button2.Text = "取消更改";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.Location = new System.Drawing.Point(3, 362);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(109, 20);
            this.label14.TabIndex = 98;
            this.label14.Text = "更改訂單狀態:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(225, 509);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 97;
            this.button1.Text = "確認更改";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // labelTotal
            // 
            this.labelTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotal.ForeColor = System.Drawing.Color.Red;
            this.labelTotal.Location = new System.Drawing.Point(139, 429);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(161, 24);
            this.labelTotal.TabIndex = 96;
            this.labelTotal.Text = "未選擇";
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelDiscount
            // 
            this.labelDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDiscount.ForeColor = System.Drawing.Color.Red;
            this.labelDiscount.Location = new System.Drawing.Point(139, 219);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(161, 24);
            this.labelDiscount.TabIndex = 95;
            this.labelDiscount.Text = "未選擇";
            this.labelDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelFreight
            // 
            this.labelFreight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFreight.ForeColor = System.Drawing.Color.Red;
            this.labelFreight.Location = new System.Drawing.Point(139, 178);
            this.labelFreight.Name = "labelFreight";
            this.labelFreight.Size = new System.Drawing.Size(161, 24);
            this.labelFreight.TabIndex = 94;
            this.labelFreight.Text = "未選擇";
            this.labelFreight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPrice
            // 
            this.labelPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPrice.ForeColor = System.Drawing.Color.Red;
            this.labelPrice.Location = new System.Drawing.Point(139, 137);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(161, 24);
            this.labelPrice.TabIndex = 93;
            this.labelPrice.Text = "未選擇";
            this.labelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPayment
            // 
            this.labelPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPayment.ForeColor = System.Drawing.Color.DarkMagenta;
            this.labelPayment.Location = new System.Drawing.Point(139, 96);
            this.labelPayment.Name = "labelPayment";
            this.labelPayment.Size = new System.Drawing.Size(161, 24);
            this.labelPayment.TabIndex = 92;
            this.labelPayment.Text = "未選擇";
            this.labelPayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelStatus
            // 
            this.labelStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStatus.ForeColor = System.Drawing.Color.DarkMagenta;
            this.labelStatus.Location = new System.Drawing.Point(101, 14);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(199, 24);
            this.labelStatus.TabIndex = 91;
            this.labelStatus.Text = "未選擇";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(3, 433);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 90;
            this.label7.Text = "總計金額:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(4, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 89;
            this.label6.Text = "使用優惠:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(4, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 88;
            this.label5.Text = "運送費用:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(4, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 87;
            this.label4.Text = "商品金額:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(4, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 86;
            this.label3.Text = "買家付款方式:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(4, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 84;
            this.label2.Text = "訂單狀態:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.編號,
            this.商品名稱,
            this.商品價格,
            this.下單數量,
            this.商品尺寸,
            this.商品顏色});
            this.dataGridView1.Location = new System.Drawing.Point(12, 224);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(695, 429);
            this.dataGridView1.TabIndex = 75;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label15.Location = new System.Drawing.Point(13, 133);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 17);
            this.label15.TabIndex = 102;
            this.label15.Text = "訂單編號:";
            // 
            // textBoxId
            // 
            this.textBoxId.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxId.Location = new System.Drawing.Point(82, 129);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(141, 25);
            this.textBoxId.TabIndex = 103;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button4.Location = new System.Drawing.Point(601, 130);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 102;
            this.button4.Text = "聯絡買家";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxName.Location = new System.Drawing.Point(308, 129);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(141, 25);
            this.textBoxName.TabIndex = 105;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label16.Location = new System.Drawing.Point(238, 133);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 17);
            this.label16.TabIndex = 104;
            this.label16.Text = "買家名稱:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label21.Location = new System.Drawing.Point(12, 177);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(63, 17);
            this.label21.TabIndex = 106;
            this.label21.Text = "下單日期:";
            this.label21.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label22.Location = new System.Drawing.Point(238, 177);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(63, 17);
            this.label22.TabIndex = 108;
            this.label22.Text = "出貨日期:";
            this.label22.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label23.Location = new System.Drawing.Point(466, 177);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(63, 17);
            this.label23.TabIndex = 110;
            this.label23.Text = "完成日期:";
            this.label23.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxOrderDate
            // 
            this.textBoxOrderDate.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxOrderDate.Location = new System.Drawing.Point(82, 173);
            this.textBoxOrderDate.Name = "textBoxOrderDate";
            this.textBoxOrderDate.ReadOnly = true;
            this.textBoxOrderDate.Size = new System.Drawing.Size(141, 25);
            this.textBoxOrderDate.TabIndex = 111;
            // 
            // textBoxShippingDate
            // 
            this.textBoxShippingDate.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxShippingDate.Location = new System.Drawing.Point(307, 173);
            this.textBoxShippingDate.Name = "textBoxShippingDate";
            this.textBoxShippingDate.ReadOnly = true;
            this.textBoxShippingDate.Size = new System.Drawing.Size(141, 25);
            this.textBoxShippingDate.TabIndex = 112;
            // 
            // textBoxCompletionDate
            // 
            this.textBoxCompletionDate.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxCompletionDate.Location = new System.Drawing.Point(535, 173);
            this.textBoxCompletionDate.Name = "textBoxCompletionDate";
            this.textBoxCompletionDate.ReadOnly = true;
            this.textBoxCompletionDate.Size = new System.Drawing.Size(141, 25);
            this.textBoxCompletionDate.TabIndex = 113;
            // 
            // 編號
            // 
            this.編號.DataPropertyName = "OrderDetailId";
            this.編號.HeaderText = "編號";
            this.編號.Name = "編號";
            this.編號.ReadOnly = true;
            this.編號.Visible = false;
            // 
            // 商品名稱
            // 
            this.商品名稱.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.商品名稱.DataPropertyName = "ProductName";
            this.商品名稱.HeaderText = "商品名稱";
            this.商品名稱.Name = "商品名稱";
            this.商品名稱.ReadOnly = true;
            // 
            // 商品價格
            // 
            this.商品價格.DataPropertyName = "Price";
            this.商品價格.HeaderText = "商品價格";
            this.商品價格.Name = "商品價格";
            this.商品價格.ReadOnly = true;
            // 
            // 下單數量
            // 
            this.下單數量.DataPropertyName = "OrderQuantity";
            this.下單數量.HeaderText = "下單數量";
            this.下單數量.Name = "下單數量";
            this.下單數量.ReadOnly = true;
            // 
            // 商品尺寸
            // 
            this.商品尺寸.DataPropertyName = "SizeName";
            this.商品尺寸.HeaderText = "商品尺寸";
            this.商品尺寸.Name = "商品尺寸";
            this.商品尺寸.ReadOnly = true;
            // 
            // 商品顏色
            // 
            this.商品顏色.DataPropertyName = "ColorName";
            this.商品顏色.HeaderText = "商品顏色";
            this.商品顏色.Name = "商品顏色";
            this.商品顏色.ReadOnly = true;
            // 
            // FormOrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 658);
            this.Controls.Add(this.textBoxCompletionDate);
            this.Controls.Add(this.textBoxShippingDate);
            this.Controls.Add(this.textBoxOrderDate);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1049, 697);
            this.MinimumSize = new System.Drawing.Size(1049, 697);
            this.Name = "FormOrderDetail";
            this.Text = "訂單明細檢視";
            this.Load += new System.EventHandler(this.FormOrderDetail_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.Label labelFreight;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelPayment;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label1ShippingMethod;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBoxOrderDate;
        private System.Windows.Forms.TextBox textBoxShippingDate;
        private System.Windows.Forms.TextBox textBoxCompletionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn 編號;
        private System.Windows.Forms.DataGridViewTextBoxColumn 商品名稱;
        private System.Windows.Forms.DataGridViewTextBoxColumn 商品價格;
        private System.Windows.Forms.DataGridViewTextBoxColumn 下單數量;
        private System.Windows.Forms.DataGridViewTextBoxColumn 商品尺寸;
        private System.Windows.Forms.DataGridViewTextBoxColumn 商品顏色;
    }
}
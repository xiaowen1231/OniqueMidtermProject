namespace prjBackgroundManagementSystem
{
    partial class FormCreateProduct
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.comboBoxSupplier = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePickerAdded = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePickerShelf = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDescription.Location = new System.Drawing.Point(283, 370);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(380, 202);
            this.txtDescription.TabIndex = 73;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.White;
            this.buttonClose.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonClose.Location = new System.Drawing.Point(602, 589);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(117, 23);
            this.buttonClose.TabIndex = 74;
            this.buttonClose.Text = "取消新增";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.White;
            this.buttonAdd.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonAdd.Location = new System.Drawing.Point(725, 589);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(117, 23);
            this.buttonAdd.TabIndex = 75;
            this.buttonAdd.Text = "加入商品";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // comboBoxSupplier
            // 
            this.comboBoxSupplier.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBoxSupplier.FormattingEnabled = true;
            this.comboBoxSupplier.Location = new System.Drawing.Point(283, 240);
            this.comboBoxSupplier.Name = "comboBoxSupplier";
            this.comboBoxSupplier.Size = new System.Drawing.Size(198, 25);
            this.comboBoxSupplier.TabIndex = 70;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(214, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 17);
            this.label8.TabIndex = 83;
            this.label8.Text = "供應商:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dateTimePickerAdded
            // 
            this.dateTimePickerAdded.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePickerAdded.Location = new System.Drawing.Point(283, 282);
            this.dateTimePickerAdded.Name = "dateTimePickerAdded";
            this.dateTimePickerAdded.Size = new System.Drawing.Size(200, 25);
            this.dateTimePickerAdded.TabIndex = 71;
            this.dateTimePickerAdded.ValueChanged += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(214, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 17);
            this.label7.TabIndex = 82;
            this.label7.Text = "上架時間:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dateTimePickerShelf
            // 
            this.dateTimePickerShelf.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePickerShelf.Location = new System.Drawing.Point(283, 324);
            this.dateTimePickerShelf.Name = "dateTimePickerShelf";
            this.dateTimePickerShelf.Size = new System.Drawing.Size(200, 25);
            this.dateTimePickerShelf.TabIndex = 72;
            this.dateTimePickerShelf.ValueChanged += new System.EventHandler(this.dateTimePickerShelf_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(214, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 81;
            this.label6.Text = "下架時間:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(214, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 80;
            this.label5.Text = "商品描述:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxPrice.Location = new System.Drawing.Point(283, 156);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 25);
            this.textBoxPrice.TabIndex = 68;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(214, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 79;
            this.label4.Text = "商品價格:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(283, 198);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(198, 25);
            this.comboBoxCategory.TabIndex = 69;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(214, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 78;
            this.label3.Text = "商品分類:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxName.Location = new System.Drawing.Point(283, 114);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(158, 25);
            this.textBoxName.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(214, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 77;
            this.label2.Text = "商品名稱:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            this.label1.Size = new System.Drawing.Size(836, 95);
            this.label1.TabIndex = 76;
            this.label1.Text = "新增商品";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormCreateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 623);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboBoxSupplier);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePickerAdded);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePickerShelf);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(870, 662);
            this.MinimumSize = new System.Drawing.Size(870, 662);
            this.Name = "FormCreateProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "新增商品";
            this.Load += new System.EventHandler(this.FormCreateProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ComboBox comboBoxSupplier;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePickerAdded;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePickerShelf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
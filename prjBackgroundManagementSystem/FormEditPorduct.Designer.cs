namespace prjBackgroundManagementSystem
{
    partial class FormEditPorduct
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
            this.buttonStockSet = new System.Windows.Forms.Button();
            this.buttonSize = new System.Windows.Forms.Button();
            this.buttonColor = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSizeColor = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.comboBoxSupplier = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePickerAdded = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePickerShelf = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStockSet
            // 
            this.buttonStockSet.BackColor = System.Drawing.Color.White;
            this.buttonStockSet.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonStockSet.Location = new System.Drawing.Point(59, 166);
            this.buttonStockSet.Name = "buttonStockSet";
            this.buttonStockSet.Size = new System.Drawing.Size(133, 36);
            this.buttonStockSet.TabIndex = 3;
            this.buttonStockSet.Text = "庫存量設定";
            this.buttonStockSet.UseVisualStyleBackColor = false;
            this.buttonStockSet.Click += new System.EventHandler(this.buttonStockSet_Click);
            // 
            // buttonSize
            // 
            this.buttonSize.BackColor = System.Drawing.Color.White;
            this.buttonSize.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonSize.Location = new System.Drawing.Point(59, 74);
            this.buttonSize.Name = "buttonSize";
            this.buttonSize.Size = new System.Drawing.Size(133, 36);
            this.buttonSize.TabIndex = 1;
            this.buttonSize.Text = "新增尺寸";
            this.buttonSize.UseVisualStyleBackColor = false;
            this.buttonSize.Click += new System.EventHandler(this.buttonSize_Click);
            // 
            // buttonColor
            // 
            this.buttonColor.BackColor = System.Drawing.Color.White;
            this.buttonColor.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonColor.Location = new System.Drawing.Point(59, 120);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(133, 36);
            this.buttonColor.TabIndex = 2;
            this.buttonColor.Text = "新增顏色";
            this.buttonColor.UseVisualStyleBackColor = false;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.White;
            this.buttonDelete.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonDelete.ForeColor = System.Drawing.Color.Red;
            this.buttonDelete.Location = new System.Drawing.Point(35, 578);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(105, 30);
            this.buttonDelete.TabIndex = 91;
            this.buttonDelete.Text = "刪除商品";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDescription.Location = new System.Drawing.Point(157, 447);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(344, 127);
            this.txtDescription.TabIndex = 87;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.buttonSizeColor);
            this.groupBox1.Controls.Add(this.buttonStockSet);
            this.groupBox1.Controls.Add(this.buttonSize);
            this.groupBox1.Controls.Add(this.buttonColor);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(568, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 231);
            this.groupBox1.TabIndex = 88;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "細部編輯";
            // 
            // buttonSizeColor
            // 
            this.buttonSizeColor.BackColor = System.Drawing.Color.White;
            this.buttonSizeColor.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonSizeColor.Location = new System.Drawing.Point(59, 28);
            this.buttonSizeColor.Name = "buttonSizeColor";
            this.buttonSizeColor.Size = new System.Drawing.Size(133, 36);
            this.buttonSizeColor.TabIndex = 0;
            this.buttonSizeColor.Text = "尺寸、顏色設定";
            this.buttonSizeColor.UseVisualStyleBackColor = false;
            this.buttonSizeColor.Click += new System.EventHandler(this.buttonSizeColor_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.White;
            this.buttonClose.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonClose.Location = new System.Drawing.Point(559, 568);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(127, 40);
            this.buttonClose.TabIndex = 89;
            this.buttonClose.Text = "取消編輯";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.White;
            this.buttonUpdate.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonUpdate.Location = new System.Drawing.Point(692, 568);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(127, 40);
            this.buttonUpdate.TabIndex = 90;
            this.buttonUpdate.Text = "編輯完成";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // comboBoxSupplier
            // 
            this.comboBoxSupplier.Enabled = false;
            this.comboBoxSupplier.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBoxSupplier.FormattingEnabled = true;
            this.comboBoxSupplier.Location = new System.Drawing.Point(159, 303);
            this.comboBoxSupplier.Name = "comboBoxSupplier";
            this.comboBoxSupplier.Size = new System.Drawing.Size(198, 25);
            this.comboBoxSupplier.TabIndex = 84;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(92, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 17);
            this.label8.TabIndex = 99;
            this.label8.Text = "供應商:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dateTimePickerAdded
            // 
            this.dateTimePickerAdded.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePickerAdded.Location = new System.Drawing.Point(157, 351);
            this.dateTimePickerAdded.Name = "dateTimePickerAdded";
            this.dateTimePickerAdded.Size = new System.Drawing.Size(200, 25);
            this.dateTimePickerAdded.TabIndex = 85;
            this.dateTimePickerAdded.ValueChanged += new System.EventHandler(this.dateTimePickerAdded_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(92, 357);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 17);
            this.label7.TabIndex = 98;
            this.label7.Text = "上架時間:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dateTimePickerShelf
            // 
            this.dateTimePickerShelf.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePickerShelf.Location = new System.Drawing.Point(157, 399);
            this.dateTimePickerShelf.Name = "dateTimePickerShelf";
            this.dateTimePickerShelf.Size = new System.Drawing.Size(200, 25);
            this.dateTimePickerShelf.TabIndex = 86;
            this.dateTimePickerShelf.ValueChanged += new System.EventHandler(this.dateTimePickerShelf_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(92, 405);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 97;
            this.label6.Text = "下架時間:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(92, 450);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 96;
            this.label5.Text = "商品描述:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPrice.Location = new System.Drawing.Point(157, 207);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(200, 25);
            this.txtPrice.TabIndex = 82;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(88, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 95;
            this.label4.Text = "商品價格:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.Enabled = false;
            this.comboBoxCategory.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(159, 255);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(198, 25);
            this.comboBoxCategory.TabIndex = 83;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(88, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 94;
            this.label3.Text = "商品分類:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtProductName.Location = new System.Drawing.Point(157, 159);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.ReadOnly = true;
            this.txtProductName.Size = new System.Drawing.Size(200, 25);
            this.txtProductName.TabIndex = 81;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(88, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 93;
            this.label2.Text = "商品名稱:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
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
            this.label1.Size = new System.Drawing.Size(836, 113);
            this.label1.TabIndex = 92;
            this.label1.Text = "編輯商品資料";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormEditPorduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 623);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.comboBoxSupplier);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePickerAdded);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePickerShelf);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(870, 662);
            this.MinimumSize = new System.Drawing.Size(870, 662);
            this.Name = "FormEditPorduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "編輯商品";
            this.Load += new System.EventHandler(this.FormEditPorduct_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStockSet;
        private System.Windows.Forms.Button buttonSize;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSizeColor;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.ComboBox comboBoxSupplier;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePickerAdded;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePickerShelf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
    }
}
namespace prjBackgroundManagementSystem
{
    partial class FormEditCategory
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtDisplayOrder = new System.Windows.Forms.TextBox();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnCancelEdit = new System.Windows.Forms.Button();
            this.btnComfirmEdit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(99, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 86;
            this.label5.Text = "類別序號:";
            // 
            // txtDisplayOrder
            // 
            this.txtDisplayOrder.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDisplayOrder.Location = new System.Drawing.Point(168, 224);
            this.txtDisplayOrder.Name = "txtDisplayOrder";
            this.txtDisplayOrder.Size = new System.Drawing.Size(196, 25);
            this.txtDisplayOrder.TabIndex = 84;
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCategoryName.Location = new System.Drawing.Point(168, 182);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(196, 25);
            this.txtCategoryName.TabIndex = 85;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(99, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 83;
            this.label4.Text = "類別名稱:";
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.BackColor = System.Drawing.Color.White;
            this.btnDeleteCategory.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDeleteCategory.Location = new System.Drawing.Point(13, 326);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteCategory.TabIndex = 81;
            this.btnDeleteCategory.Text = "刪除分類";
            this.btnDeleteCategory.UseVisualStyleBackColor = false;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // btnCancelEdit
            // 
            this.btnCancelEdit.BackColor = System.Drawing.Color.White;
            this.btnCancelEdit.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCancelEdit.Location = new System.Drawing.Point(313, 326);
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.Size = new System.Drawing.Size(75, 23);
            this.btnCancelEdit.TabIndex = 82;
            this.btnCancelEdit.Text = "取消編輯";
            this.btnCancelEdit.UseVisualStyleBackColor = false;
            this.btnCancelEdit.Click += new System.EventHandler(this.btnCancelEdit_Click);
            // 
            // btnComfirmEdit
            // 
            this.btnComfirmEdit.BackColor = System.Drawing.Color.White;
            this.btnComfirmEdit.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnComfirmEdit.Location = new System.Drawing.Point(393, 326);
            this.btnComfirmEdit.Name = "btnComfirmEdit";
            this.btnComfirmEdit.Size = new System.Drawing.Size(75, 23);
            this.btnComfirmEdit.TabIndex = 80;
            this.btnComfirmEdit.Text = "確認編輯";
            this.btnComfirmEdit.UseVisualStyleBackColor = false;
            this.btnComfirmEdit.Click += new System.EventHandler(this.btnComfirmUpdate_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.BurlyWood;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(-1, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(481, 95);
            this.label1.TabIndex = 79;
            this.label1.Text = "編輯商品分類";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormEditCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 355);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDisplayOrder);
            this.Controls.Add(this.txtCategoryName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDeleteCategory);
            this.Controls.Add(this.btnCancelEdit);
            this.Controls.Add(this.btnComfirmEdit);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(495, 394);
            this.MinimumSize = new System.Drawing.Size(495, 394);
            this.Name = "FormEditCategory";
            this.Text = "FormEditCategory";
            this.Load += new System.EventHandler(this.FormEditCategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDisplayOrder;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnCancelEdit;
        private System.Windows.Forms.Button btnComfirmEdit;
        private System.Windows.Forms.Label label1;
    }
}
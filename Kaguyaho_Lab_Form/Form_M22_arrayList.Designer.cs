namespace Kaguyaho_Lab_Form
{
    partial class Form_M22_arrayList
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
            this.label2 = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.button_insert = new System.Windows.Forms.Button();
            this.button_removeAt = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.textBox_productName = new System.Windows.Forms.TextBox();
            this.textBox_productPrice = new System.Windows.Forms.TextBox();
            this.listBox_Products = new System.Windows.Forms.ListBox();
            this.labShow = new System.Windows.Forms.Label();
            this.button_addDiffType = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "產品名稱";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "產品單價";
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(308, 95);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(109, 23);
            this.button_add.TabIndex = 2;
            this.button_add.Text = "新增 &Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_insert
            // 
            this.button_insert.Location = new System.Drawing.Point(308, 124);
            this.button_insert.Name = "button_insert";
            this.button_insert.Size = new System.Drawing.Size(109, 23);
            this.button_insert.TabIndex = 3;
            this.button_insert.Text = "插入 &Insert";
            this.button_insert.UseVisualStyleBackColor = true;
            this.button_insert.Click += new System.EventHandler(this.button_insert_Click);
            // 
            // button_removeAt
            // 
            this.button_removeAt.Location = new System.Drawing.Point(308, 153);
            this.button_removeAt.Name = "button_removeAt";
            this.button_removeAt.Size = new System.Drawing.Size(109, 23);
            this.button_removeAt.TabIndex = 4;
            this.button_removeAt.Text = "&Remove At 0";
            this.button_removeAt.UseVisualStyleBackColor = true;
            this.button_removeAt.Click += new System.EventHandler(this.button_removeAt_Click);
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(308, 182);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(109, 23);
            this.button_clear.TabIndex = 5;
            this.button_clear.Text = "&Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // textBox_productName
            // 
            this.textBox_productName.Location = new System.Drawing.Point(152, 96);
            this.textBox_productName.Name = "textBox_productName";
            this.textBox_productName.Size = new System.Drawing.Size(100, 25);
            this.textBox_productName.TabIndex = 6;
            // 
            // textBox_productPrice
            // 
            this.textBox_productPrice.Location = new System.Drawing.Point(152, 136);
            this.textBox_productPrice.Name = "textBox_productPrice";
            this.textBox_productPrice.Size = new System.Drawing.Size(100, 25);
            this.textBox_productPrice.TabIndex = 7;
            // 
            // listBox_Products
            // 
            this.listBox_Products.FormattingEnabled = true;
            this.listBox_Products.ItemHeight = 15;
            this.listBox_Products.Location = new System.Drawing.Point(450, 182);
            this.listBox_Products.Margin = new System.Windows.Forms.Padding(4);
            this.listBox_Products.Name = "listBox_Products";
            this.listBox_Products.Size = new System.Drawing.Size(327, 229);
            this.listBox_Products.TabIndex = 12;
            // 
            // labShow
            // 
            this.labShow.AutoSize = true;
            this.labShow.BackColor = System.Drawing.Color.DeepPink;
            this.labShow.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labShow.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.labShow.Location = new System.Drawing.Point(445, 20);
            this.labShow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labShow.Name = "labShow";
            this.labShow.Size = new System.Drawing.Size(61, 30);
            this.labShow.TabIndex = 11;
            this.labShow.Text = "產品";
            // 
            // button_addDiffType
            // 
            this.button_addDiffType.Location = new System.Drawing.Point(29, 235);
            this.button_addDiffType.Margin = new System.Windows.Forms.Padding(4);
            this.button_addDiffType.Name = "button_addDiffType";
            this.button_addDiffType.Size = new System.Drawing.Size(309, 48);
            this.button_addDiffType.TabIndex = 13;
            this.button_addDiffType.Text = "加入不同資料型態";
            this.button_addDiffType.UseVisualStyleBackColor = true;
            this.button_addDiffType.Click += new System.EventHandler(this.button_addDiffType_Click);
            // 
            // Form_M22_arrayList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 452);
            this.Controls.Add(this.button_addDiffType);
            this.Controls.Add(this.listBox_Products);
            this.Controls.Add(this.labShow);
            this.Controls.Add(this.textBox_productPrice);
            this.Controls.Add(this.textBox_productName);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_removeAt);
            this.Controls.Add(this.button_insert);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_M22_arrayList";
            this.Text = "Form_M22_arrayList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_insert;
        private System.Windows.Forms.Button button_removeAt;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.TextBox textBox_productName;
        private System.Windows.Forms.TextBox textBox_productPrice;
        private System.Windows.Forms.ListBox listBox_Products;
        private System.Windows.Forms.Label labShow;
        private System.Windows.Forms.Button button_addDiffType;
    }
}
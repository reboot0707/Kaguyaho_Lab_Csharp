namespace Kaguyaho_Lab_Form
{
    partial class Form_M15_struct
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
            this.label_productName = new System.Windows.Forms.Label();
            this.label_price = new System.Windows.Forms.Label();
            this.textBox_productName = new System.Windows.Forms.TextBox();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.button_save = new System.Windows.Forms.Button();
            this.button_show = new System.Windows.Forms.Button();
            this.label_productList = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_productName
            // 
            this.label_productName.AutoSize = true;
            this.label_productName.Location = new System.Drawing.Point(125, 70);
            this.label_productName.Name = "label_productName";
            this.label_productName.Size = new System.Drawing.Size(71, 15);
            this.label_productName.TabIndex = 0;
            this.label_productName.Text = "產品名稱:";
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Location = new System.Drawing.Point(125, 112);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(71, 15);
            this.label_price.TabIndex = 1;
            this.label_price.Text = "產品單價:";
            // 
            // textBox_productName
            // 
            this.textBox_productName.Location = new System.Drawing.Point(214, 65);
            this.textBox_productName.Name = "textBox_productName";
            this.textBox_productName.Size = new System.Drawing.Size(100, 25);
            this.textBox_productName.TabIndex = 2;
            // 
            // textBox_price
            // 
            this.textBox_price.Location = new System.Drawing.Point(214, 106);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(100, 25);
            this.textBox_price.TabIndex = 3;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(128, 186);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 4;
            this.button_save.Text = "儲存";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_show
            // 
            this.button_show.Location = new System.Drawing.Point(240, 186);
            this.button_show.Name = "button_show";
            this.button_show.Size = new System.Drawing.Size(75, 23);
            this.button_show.TabIndex = 5;
            this.button_show.Text = "顯示";
            this.button_show.UseVisualStyleBackColor = true;
            this.button_show.Click += new System.EventHandler(this.button_show_Click);
            // 
            // label_productList
            // 
            this.label_productList.AutoSize = true;
            this.label_productList.Location = new System.Drawing.Point(421, 53);
            this.label_productList.Name = "label_productList";
            this.label_productList.Size = new System.Drawing.Size(37, 15);
            this.label_productList.TabIndex = 6;
            this.label_productList.Text = "產品";
            // 
            // Form_M15_struct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_productList);
            this.Controls.Add(this.button_show);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.textBox_price);
            this.Controls.Add(this.textBox_productName);
            this.Controls.Add(this.label_price);
            this.Controls.Add(this.label_productName);
            this.Name = "Form_M15_struct";
            this.Text = "Form_M15_struct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_productName;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.TextBox textBox_productName;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_show;
        private System.Windows.Forms.Label label_productList;
    }
}
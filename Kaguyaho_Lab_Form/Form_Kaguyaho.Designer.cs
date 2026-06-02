namespace Kaguyaho_Lab_Form
{
    partial class Form_Kaguyaho
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Kaguyaho));
            this.button_hello = new System.Windows.Forms.Button();
            this.label_enterYourName = new System.Windows.Forms.Label();
            this.text_yourName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_hello
            // 
            this.button_hello.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_hello.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_hello.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_hello.Location = new System.Drawing.Point(646, 378);
            this.button_hello.Name = "button_hello";
            this.button_hello.Size = new System.Drawing.Size(125, 51);
            this.button_hello.TabIndex = 0;
            this.button_hello.Text = "早安！";
            this.button_hello.UseVisualStyleBackColor = true;
            this.button_hello.Click += new System.EventHandler(this.buttonHello_Click);
            // 
            // label_enterYourName
            // 
            this.label_enterYourName.AutoSize = true;
            this.label_enterYourName.BackColor = System.Drawing.Color.Transparent;
            this.label_enterYourName.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_enterYourName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_enterYourName.Location = new System.Drawing.Point(47, 25);
            this.label_enterYourName.Name = "label_enterYourName";
            this.label_enterYourName.Size = new System.Drawing.Size(262, 50);
            this.label_enterYourName.TabIndex = 1;
            this.label_enterYourName.Text = "請輸入姓名：";
            this.label_enterYourName.Click += new System.EventHandler(this.buttonHello_Click);
            // 
            // text_yourName
            // 
            this.text_yourName.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.text_yourName.Location = new System.Drawing.Point(294, 22);
            this.text_yourName.Name = "text_yourName";
            this.text_yourName.Size = new System.Drawing.Size(241, 61);
            this.text_yourName.TabIndex = 2;
            // 
            // Form_Kaguyaho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.text_yourName);
            this.Controls.Add(this.label_enterYourName);
            this.Controls.Add(this.button_hello);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Name = "Form_Kaguyaho";
            this.Text = "Kaguyaho!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_hello;
        private System.Windows.Forms.Label label_enterYourName;
        private System.Windows.Forms.TextBox text_yourName;
    }
}


namespace Kaguyaho_Lab_Form
{
    partial class Form_countKoHits
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
            this.label_hitCount = new System.Windows.Forms.Label();
            this.button_marryMe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_hitCount
            // 
            this.label_hitCount.AutoSize = true;
            this.label_hitCount.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_hitCount.Location = new System.Drawing.Point(41, 34);
            this.label_hitCount.Name = "label_hitCount";
            this.label_hitCount.Size = new System.Drawing.Size(230, 38);
            this.label_hitCount.TabIndex = 0;
            this.label_hitCount.Text = "0 hit(s) by IroP!";
            // 
            // button_marryMe
            // 
            this.button_marryMe.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_marryMe.Location = new System.Drawing.Point(124, 106);
            this.button_marryMe.Name = "button_marryMe";
            this.button_marryMe.Size = new System.Drawing.Size(139, 46);
            this.button_marryMe.TabIndex = 1;
            this.button_marryMe.Text = "Marry Me!";
            this.button_marryMe.UseVisualStyleBackColor = true;
            this.button_marryMe.Click += new System.EventHandler(this.button_marryMe_Click);
            // 
            // Form_countKoHits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_marryMe);
            this.Controls.Add(this.label_hitCount);
            this.Name = "Form_countKoHits";
            this.Text = "Marry me! Kaguya <3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_hitCount;
        private System.Windows.Forms.Button button_marryMe;
    }
}
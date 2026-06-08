namespace Kaguyaho_Lab_Form
{
    partial class Form18_ifelse
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
            this.button_reverse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_reverse
            // 
            this.button_reverse.Location = new System.Drawing.Point(284, 172);
            this.button_reverse.Name = "button_reverse";
            this.button_reverse.Size = new System.Drawing.Size(241, 125);
            this.button_reverse.TabIndex = 0;
            this.button_reverse.Text = "非黑/即白";
            this.button_reverse.UseVisualStyleBackColor = true;
            this.button_reverse.Click += new System.EventHandler(this.button_reverse_Click);
            // 
            // Form18_ifelse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_reverse);
            this.Name = "Form18_ifelse";
            this.Text = "Form18_ifelse";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_reverse;
    }
}
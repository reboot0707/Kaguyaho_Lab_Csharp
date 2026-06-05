namespace Kaguyaho_Lab_Form
{
    partial class Form_M13_call
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
            this.button_callByValue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_callByValue
            // 
            this.button_callByValue.Location = new System.Drawing.Point(101, 54);
            this.button_callByValue.Name = "button_callByValue";
            this.button_callByValue.Size = new System.Drawing.Size(193, 55);
            this.button_callByValue.TabIndex = 0;
            this.button_callByValue.Text = "Call by Value";
            this.button_callByValue.UseVisualStyleBackColor = true;
            this.button_callByValue.Click += new System.EventHandler(this.button_callByValue_Click);
            // 
            // Form_M13_call
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_callByValue);
            this.Name = "Form_M13_call";
            this.Text = "Form_M13_call";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_callByValue;
    }
}
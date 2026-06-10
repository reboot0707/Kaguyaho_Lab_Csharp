namespace Kaguyaho_Lab_Form
{
    partial class Form_M23_String
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
            this.button_demoString = new System.Windows.Forms.Button();
            this.button_demoStringBuilder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_demoString
            // 
            this.button_demoString.Location = new System.Drawing.Point(229, 78);
            this.button_demoString.Name = "button_demoString";
            this.button_demoString.Size = new System.Drawing.Size(130, 41);
            this.button_demoString.TabIndex = 0;
            this.button_demoString.Text = "String";
            this.button_demoString.UseVisualStyleBackColor = true;
            this.button_demoString.Click += new System.EventHandler(this.button_demoString_Click);
            // 
            // button_demoStringBuilder
            // 
            this.button_demoStringBuilder.Location = new System.Drawing.Point(229, 147);
            this.button_demoStringBuilder.Name = "button_demoStringBuilder";
            this.button_demoStringBuilder.Size = new System.Drawing.Size(130, 41);
            this.button_demoStringBuilder.TabIndex = 1;
            this.button_demoStringBuilder.Text = "String Builder";
            this.button_demoStringBuilder.UseVisualStyleBackColor = true;
            this.button_demoStringBuilder.Click += new System.EventHandler(this.button_demoStringBuilder_Click);
            // 
            // Form_M23_String
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_demoStringBuilder);
            this.Controls.Add(this.button_demoString);
            this.Name = "Form_M23_String";
            this.Text = "Form_M23_String";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_demoString;
        private System.Windows.Forms.Button button_demoStringBuilder;
    }
}
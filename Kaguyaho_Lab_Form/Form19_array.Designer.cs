namespace Kaguyaho_Lab_Form
{
    partial class Form19_array
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
            this.button_trigArray = new System.Windows.Forms.Button();
            this.button_testArray2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_trigArray
            // 
            this.button_trigArray.Location = new System.Drawing.Point(285, 120);
            this.button_trigArray.Name = "button_trigArray";
            this.button_trigArray.Size = new System.Drawing.Size(293, 149);
            this.button_trigArray.TabIndex = 0;
            this.button_trigArray.Text = "test Array";
            this.button_trigArray.UseVisualStyleBackColor = true;
            this.button_trigArray.Click += new System.EventHandler(this.button_trigArray_Click);
            // 
            // button_testArray2
            // 
            this.button_testArray2.Location = new System.Drawing.Point(126, 289);
            this.button_testArray2.Name = "button_testArray2";
            this.button_testArray2.Size = new System.Drawing.Size(293, 149);
            this.button_testArray2.TabIndex = 1;
            this.button_testArray2.Text = "test Array 2";
            this.button_testArray2.UseVisualStyleBackColor = true;
            this.button_testArray2.Click += new System.EventHandler(this.button_testArray2_Click);
            // 
            // Form19_array
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_testArray2);
            this.Controls.Add(this.button_trigArray);
            this.Name = "Form19_array";
            this.Text = "Form19_array";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_trigArray;
        private System.Windows.Forms.Button button_testArray2;
    }
}
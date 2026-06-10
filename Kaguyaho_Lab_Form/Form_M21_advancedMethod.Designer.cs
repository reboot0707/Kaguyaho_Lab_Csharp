namespace Kaguyaho_Lab_Form
{
    partial class Form_M21_advancedMethod
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
            this.button_overloadDouble = new System.Windows.Forms.Button();
            this.button_overloadInt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_overloadDouble
            // 
            this.button_overloadDouble.Location = new System.Drawing.Point(60, 113);
            this.button_overloadDouble.Margin = new System.Windows.Forms.Padding(4);
            this.button_overloadDouble.Name = "button_overloadDouble";
            this.button_overloadDouble.Size = new System.Drawing.Size(197, 48);
            this.button_overloadDouble.TabIndex = 7;
            this.button_overloadDouble.Text = "多載swap(double a, double b)";
            this.button_overloadDouble.UseVisualStyleBackColor = true;
            this.button_overloadDouble.Click += new System.EventHandler(this.button_overloadDouble_Click);
            // 
            // button_overloadInt
            // 
            this.button_overloadInt.Location = new System.Drawing.Point(60, 58);
            this.button_overloadInt.Margin = new System.Windows.Forms.Padding(4);
            this.button_overloadInt.Name = "button_overloadInt";
            this.button_overloadInt.Size = new System.Drawing.Size(197, 48);
            this.button_overloadInt.TabIndex = 6;
            this.button_overloadInt.Text = "多載swap(int a, int b)";
            this.button_overloadInt.UseVisualStyleBackColor = true;
            this.button_overloadInt.Click += new System.EventHandler(this.button_overloadInt_Click);
            // 
            // Form_M21_advancedMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_overloadDouble);
            this.Controls.Add(this.button_overloadInt);
            this.Name = "Form_M21_advancedMethod";
            this.Text = "Form_M21_advancedMethod";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_overloadDouble;
        private System.Windows.Forms.Button button_overloadInt;
    }
}
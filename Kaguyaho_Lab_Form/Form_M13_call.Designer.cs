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
            this.button_callByRef = new System.Windows.Forms.Button();
            this.button_callbyString = new System.Windows.Forms.Button();
            this.button_callbyRealRef = new System.Windows.Forms.Button();
            this.button_callbyOut = new System.Windows.Forms.Button();
            this.button_scoreTotal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_callByValue
            // 
            this.button_callByValue.Location = new System.Drawing.Point(90, 29);
            this.button_callByValue.Name = "button_callByValue";
            this.button_callByValue.Size = new System.Drawing.Size(193, 55);
            this.button_callByValue.TabIndex = 0;
            this.button_callByValue.Text = "Call by Value";
            this.button_callByValue.UseVisualStyleBackColor = true;
            this.button_callByValue.Click += new System.EventHandler(this.button_callByValue_Click);
            // 
            // button_callByRef
            // 
            this.button_callByRef.Location = new System.Drawing.Point(90, 111);
            this.button_callByRef.Name = "button_callByRef";
            this.button_callByRef.Size = new System.Drawing.Size(193, 55);
            this.button_callByRef.TabIndex = 1;
            this.button_callByRef.Text = "Call by Reference";
            this.button_callByRef.UseVisualStyleBackColor = true;
            this.button_callByRef.Click += new System.EventHandler(this.button_callByRef_Click);
            // 
            // button_callbyString
            // 
            this.button_callbyString.Location = new System.Drawing.Point(90, 193);
            this.button_callbyString.Name = "button_callbyString";
            this.button_callbyString.Size = new System.Drawing.Size(193, 55);
            this.button_callbyString.TabIndex = 2;
            this.button_callbyString.Text = "Call by String";
            this.button_callbyString.UseVisualStyleBackColor = true;
            this.button_callbyString.Click += new System.EventHandler(this.button_callbyString_Click);
            // 
            // button_callbyRealRef
            // 
            this.button_callbyRealRef.Location = new System.Drawing.Point(90, 275);
            this.button_callbyRealRef.Name = "button_callbyRealRef";
            this.button_callbyRealRef.Size = new System.Drawing.Size(193, 55);
            this.button_callbyRealRef.TabIndex = 3;
            this.button_callbyRealRef.Text = "Call by \"ref\"";
            this.button_callbyRealRef.UseVisualStyleBackColor = true;
            this.button_callbyRealRef.Click += new System.EventHandler(this.button_callbyRealRef_Click);
            // 
            // button_callbyOut
            // 
            this.button_callbyOut.Location = new System.Drawing.Point(90, 357);
            this.button_callbyOut.Name = "button_callbyOut";
            this.button_callbyOut.Size = new System.Drawing.Size(193, 55);
            this.button_callbyOut.TabIndex = 4;
            this.button_callbyOut.Text = "Call by \"out\"";
            this.button_callbyOut.UseVisualStyleBackColor = true;
            this.button_callbyOut.Click += new System.EventHandler(this.button_callbyOut_Click);
            // 
            // button_scoreTotal
            // 
            this.button_scoreTotal.Location = new System.Drawing.Point(346, 29);
            this.button_scoreTotal.Name = "button_scoreTotal";
            this.button_scoreTotal.Size = new System.Drawing.Size(193, 55);
            this.button_scoreTotal.TabIndex = 5;
            this.button_scoreTotal.Text = "Call \"Total Score\"";
            this.button_scoreTotal.UseVisualStyleBackColor = true;
            this.button_scoreTotal.Click += new System.EventHandler(this.button_scoreTotal_Click);
            // 
            // Form_M13_call
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_scoreTotal);
            this.Controls.Add(this.button_callbyOut);
            this.Controls.Add(this.button_callbyRealRef);
            this.Controls.Add(this.button_callbyString);
            this.Controls.Add(this.button_callByRef);
            this.Controls.Add(this.button_callByValue);
            this.Name = "Form_M13_call";
            this.Text = "Form_M13_call";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_callByValue;
        private System.Windows.Forms.Button button_callByRef;
        private System.Windows.Forms.Button button_callbyString;
        private System.Windows.Forms.Button button_callbyRealRef;
        private System.Windows.Forms.Button button_callbyOut;
        private System.Windows.Forms.Button button_scoreTotal;
    }
}
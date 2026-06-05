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
            this.button_ppcount = new System.Windows.Forms.Button();
            this.button_countpp = new System.Windows.Forms.Button();
            this.label_ppcount = new System.Windows.Forms.Label();
            this.label_countpp = new System.Windows.Forms.Label();
            this.groupBox_varplay = new System.Windows.Forms.GroupBox();
            this.label_playVar1 = new System.Windows.Forms.Label();
            this.button_changeVar = new System.Windows.Forms.Button();
            this.groupBox_varplay.SuspendLayout();
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
            // button_ppcount
            // 
            this.button_ppcount.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_ppcount.Location = new System.Drawing.Point(124, 182);
            this.button_ppcount.Name = "button_ppcount";
            this.button_ppcount.Size = new System.Drawing.Size(139, 46);
            this.button_ppcount.TabIndex = 2;
            this.button_ppcount.Text = "++count";
            this.button_ppcount.UseVisualStyleBackColor = true;
            this.button_ppcount.Click += new System.EventHandler(this.button_ppcount_Click);
            // 
            // button_countpp
            // 
            this.button_countpp.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_countpp.Location = new System.Drawing.Point(124, 263);
            this.button_countpp.Name = "button_countpp";
            this.button_countpp.Size = new System.Drawing.Size(139, 46);
            this.button_countpp.TabIndex = 3;
            this.button_countpp.Text = "count++";
            this.button_countpp.UseVisualStyleBackColor = true;
            this.button_countpp.Click += new System.EventHandler(this.button_countpp_Click);
            // 
            // label_ppcount
            // 
            this.label_ppcount.AutoSize = true;
            this.label_ppcount.Location = new System.Drawing.Point(124, 231);
            this.label_ppcount.Name = "label_ppcount";
            this.label_ppcount.Size = new System.Drawing.Size(104, 15);
            this.label_ppcount.TabIndex = 4;
            this.label_ppcount.Text = "? = ++count -> 0";
            // 
            // label_countpp
            // 
            this.label_countpp.AutoSize = true;
            this.label_countpp.Location = new System.Drawing.Point(124, 316);
            this.label_countpp.Name = "label_countpp";
            this.label_countpp.Size = new System.Drawing.Size(104, 15);
            this.label_countpp.TabIndex = 5;
            this.label_countpp.Text = "? = count++ -> 0";
            // 
            // groupBox_varplay
            // 
            this.groupBox_varplay.Controls.Add(this.button_changeVar);
            this.groupBox_varplay.Controls.Add(this.label_playVar1);
            this.groupBox_varplay.Location = new System.Drawing.Point(335, 14);
            this.groupBox_varplay.Name = "groupBox_varplay";
            this.groupBox_varplay.Size = new System.Drawing.Size(375, 232);
            this.groupBox_varplay.TabIndex = 6;
            this.groupBox_varplay.TabStop = false;
            this.groupBox_varplay.Text = "Var Playground";
            // 
            // label_playVar1
            // 
            this.label_playVar1.AutoSize = true;
            this.label_playVar1.Location = new System.Drawing.Point(35, 42);
            this.label_playVar1.Name = "label_playVar1";
            this.label_playVar1.Size = new System.Drawing.Size(41, 15);
            this.label_playVar1.TabIndex = 0;
            this.label_playVar1.Text = "label1";
            // 
            // button_changeVar
            // 
            this.button_changeVar.Location = new System.Drawing.Point(50, 71);
            this.button_changeVar.Name = "button_changeVar";
            this.button_changeVar.Size = new System.Drawing.Size(75, 23);
            this.button_changeVar.TabIndex = 1;
            this.button_changeVar.Text = "button1";
            this.button_changeVar.UseVisualStyleBackColor = true;
            this.button_changeVar.Click += new System.EventHandler(this.button_changeVar_Click);
            // 
            // Form_countKoHits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox_varplay);
            this.Controls.Add(this.label_countpp);
            this.Controls.Add(this.label_ppcount);
            this.Controls.Add(this.button_countpp);
            this.Controls.Add(this.button_ppcount);
            this.Controls.Add(this.button_marryMe);
            this.Controls.Add(this.label_hitCount);
            this.Name = "Form_countKoHits";
            this.Text = "Marry me! Kaguya <3";
            this.groupBox_varplay.ResumeLayout(false);
            this.groupBox_varplay.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_hitCount;
        private System.Windows.Forms.Button button_marryMe;
        private System.Windows.Forms.Button button_ppcount;
        private System.Windows.Forms.Button button_countpp;
        private System.Windows.Forms.Label label_ppcount;
        private System.Windows.Forms.Label label_countpp;
        private System.Windows.Forms.GroupBox groupBox_varplay;
        private System.Windows.Forms.Label label_playVar1;
        private System.Windows.Forms.Button button_changeVar;
    }
}
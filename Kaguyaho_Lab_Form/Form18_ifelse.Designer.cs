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
            this.components = new System.ComponentModel.Container();
            this.button_reverse = new System.Windows.Forms.Button();
            this.button_tri = new System.Windows.Forms.Button();
            this.label_dateTime = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button_selectDateTime = new System.Windows.Forms.Button();
            this.timer_datetime = new System.Windows.Forms.Timer(this.components);
            this.timer_blink = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button_reverse
            // 
            this.button_reverse.Location = new System.Drawing.Point(235, 22);
            this.button_reverse.Name = "button_reverse";
            this.button_reverse.Size = new System.Drawing.Size(241, 125);
            this.button_reverse.TabIndex = 0;
            this.button_reverse.Text = "非黑/即白";
            this.button_reverse.UseVisualStyleBackColor = true;
            this.button_reverse.Click += new System.EventHandler(this.button_reverse_Click);
            // 
            // button_tri
            // 
            this.button_tri.Location = new System.Drawing.Point(235, 153);
            this.button_tri.Name = "button_tri";
            this.button_tri.Size = new System.Drawing.Size(241, 116);
            this.button_tri.TabIndex = 1;
            this.button_tri.Text = "三元判斷式";
            this.button_tri.UseVisualStyleBackColor = true;
            this.button_tri.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_tri_MouseClick);
            // 
            // label_dateTime
            // 
            this.label_dateTime.AutoSize = true;
            this.label_dateTime.Location = new System.Drawing.Point(58, 416);
            this.label_dateTime.Name = "label_dateTime";
            this.label_dateTime.Size = new System.Drawing.Size(169, 15);
            this.label_dateTime.TabIndex = 2;
            this.label_dateTime.Text = "{Date and time placeholder}";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(260, 300);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // button_selectDateTime
            // 
            this.button_selectDateTime.Location = new System.Drawing.Point(316, 331);
            this.button_selectDateTime.Name = "button_selectDateTime";
            this.button_selectDateTime.Size = new System.Drawing.Size(75, 23);
            this.button_selectDateTime.TabIndex = 5;
            this.button_selectDateTime.Text = "決定";
            this.button_selectDateTime.UseVisualStyleBackColor = true;
            this.button_selectDateTime.Click += new System.EventHandler(this.button_selectDateTime_Click);
            // 
            // timer_datetime
            // 
            this.timer_datetime.Enabled = true;
            this.timer_datetime.Interval = 1000;
            this.timer_datetime.Tick += new System.EventHandler(this.timer_datetime_Tick);
            // 
            // timer_blink
            // 
            this.timer_blink.Enabled = true;
            this.timer_blink.Tick += new System.EventHandler(this.timer_blink_Tick);
            // 
            // Form18_ifelse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_selectDateTime);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label_dateTime);
            this.Controls.Add(this.button_tri);
            this.Controls.Add(this.button_reverse);
            this.Name = "Form18_ifelse";
            this.Text = "Form18_ifelse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_reverse;
        private System.Windows.Forms.Button button_tri;
        private System.Windows.Forms.Label label_dateTime;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button_selectDateTime;
        private System.Windows.Forms.Timer timer_datetime;
        private System.Windows.Forms.Timer timer_blink;
    }
}
namespace Event_Scheduler
{
    partial class Form1
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
            this.startTimeNUD = new System.Windows.Forms.NumericUpDown();
            this.durationNUD = new System.Windows.Forms.NumericUpDown();
            this.eventNameTXT = new System.Windows.Forms.TextBox();
            this.addEventBTN = new System.Windows.Forms.Button();
            this.resetBTN = new System.Windows.Forms.Button();
            this.activityTXT = new System.Windows.Forms.TextBox();
            this.scheduleTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.startTimeNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // startTimeNUD
            // 
            this.startTimeNUD.Location = new System.Drawing.Point(248, 41);
            this.startTimeNUD.Name = "startTimeNUD";
            this.startTimeNUD.Size = new System.Drawing.Size(120, 20);
            this.startTimeNUD.TabIndex = 0;
            // 
            // durationNUD
            // 
            this.durationNUD.Location = new System.Drawing.Point(403, 41);
            this.durationNUD.Name = "durationNUD";
            this.durationNUD.Size = new System.Drawing.Size(120, 20);
            this.durationNUD.TabIndex = 1;
            // 
            // eventNameTXT
            // 
            this.eventNameTXT.Location = new System.Drawing.Point(12, 40);
            this.eventNameTXT.Name = "eventNameTXT";
            this.eventNameTXT.Size = new System.Drawing.Size(208, 20);
            this.eventNameTXT.TabIndex = 3;
            // 
            // addEventBTN
            // 
            this.addEventBTN.Location = new System.Drawing.Point(113, 116);
            this.addEventBTN.Name = "addEventBTN";
            this.addEventBTN.Size = new System.Drawing.Size(75, 23);
            this.addEventBTN.TabIndex = 4;
            this.addEventBTN.Text = "Add Event";
            this.addEventBTN.UseVisualStyleBackColor = true;
            this.addEventBTN.Click += new System.EventHandler(this.addEventBTN_Click);
            // 
            // resetBTN
            // 
            this.resetBTN.Location = new System.Drawing.Point(335, 116);
            this.resetBTN.Name = "resetBTN";
            this.resetBTN.Size = new System.Drawing.Size(75, 23);
            this.resetBTN.TabIndex = 5;
            this.resetBTN.Text = "Reset";
            this.resetBTN.UseVisualStyleBackColor = true;
            this.resetBTN.Click += new System.EventHandler(this.resetBTN_Click);
            // 
            // activityTXT
            // 
            this.activityTXT.Location = new System.Drawing.Point(29, 193);
            this.activityTXT.Multiline = true;
            this.activityTXT.Name = "activityTXT";
            this.activityTXT.Size = new System.Drawing.Size(197, 133);
            this.activityTXT.TabIndex = 6;
            // 
            // scheduleTXT
            // 
            this.scheduleTXT.Location = new System.Drawing.Point(295, 193);
            this.scheduleTXT.Multiline = true;
            this.scheduleTXT.Name = "scheduleTXT";
            this.scheduleTXT.Size = new System.Drawing.Size(197, 133);
            this.scheduleTXT.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Activities";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Start Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(445, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Duration";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(371, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Schedule";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Event Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 375);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scheduleTXT);
            this.Controls.Add(this.activityTXT);
            this.Controls.Add(this.resetBTN);
            this.Controls.Add(this.addEventBTN);
            this.Controls.Add(this.eventNameTXT);
            this.Controls.Add(this.durationNUD);
            this.Controls.Add(this.startTimeNUD);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.startTimeNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown startTimeNUD;
        private System.Windows.Forms.NumericUpDown durationNUD;
        private System.Windows.Forms.TextBox eventNameTXT;
        private System.Windows.Forms.Button addEventBTN;
        private System.Windows.Forms.Button resetBTN;
        private System.Windows.Forms.TextBox activityTXT;
        private System.Windows.Forms.TextBox scheduleTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
    }
}


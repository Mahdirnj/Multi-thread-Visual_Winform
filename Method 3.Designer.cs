
namespace Multi_thread_Visual
{
    partial class Method_3
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblThread1time = new System.Windows.Forms.Label();
            this.lblThread2Time = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "This method will show the\r\nexecution time of 2 the threads \r\nthat run 3 billion t" +
    "imes\r\n\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(127, 154);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(89, 27);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start thread";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(24, 188);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(96, 17);
            this.label.TabIndex = 2;
            this.label.Text = "Thread 1 time";
            this.label.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Thread 2 time";
            this.label2.Visible = false;
            // 
            // lblThread1time
            // 
            this.lblThread1time.AutoSize = true;
            this.lblThread1time.Location = new System.Drawing.Point(24, 243);
            this.lblThread1time.Name = "lblThread1time";
            this.lblThread1time.Size = new System.Drawing.Size(0, 17);
            this.lblThread1time.TabIndex = 4;
            // 
            // lblThread2Time
            // 
            this.lblThread2Time.AutoSize = true;
            this.lblThread2Time.Location = new System.Drawing.Point(220, 243);
            this.lblThread2Time.Name = "lblThread2Time";
            this.lblThread2Time.Size = new System.Drawing.Size(0, 17);
            this.lblThread2Time.TabIndex = 5;
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(127, 278);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(89, 42);
            this.btnMenu.TabIndex = 6;
            this.btnMenu.Text = "back to the menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Sitka Display", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 74);
            this.label3.TabIndex = 7;
            this.label3.Text = "NOTE: This process can take\r\na few sec cause in total it takes\r\n6 billion runs ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Method_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(350, 332);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.lblThread2Time);
            this.Controls.Add(this.lblThread1time);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Name = "Method_3";
            this.Text = "Method_3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblThread1time;
        private System.Windows.Forms.Label lblThread2Time;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label label3;
    }
}
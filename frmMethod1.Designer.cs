
namespace Multi_thread_Visual
{
    partial class frmMethod1
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
            this.btnStart = new System.Windows.Forms.Button();
            this.LstThread2 = new System.Windows.Forms.ListView();
            this.lstThread1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBacktoMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.AutoSize = true;
            this.btnStart.Location = new System.Drawing.Point(337, 127);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(117, 40);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start the thread";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // LstThread2
            // 
            this.LstThread2.HideSelection = false;
            this.LstThread2.Location = new System.Drawing.Point(12, 127);
            this.LstThread2.Name = "LstThread2";
            this.LstThread2.Size = new System.Drawing.Size(258, 329);
            this.LstThread2.TabIndex = 1;
            this.LstThread2.UseCompatibleStateImageBehavior = false;
            // 
            // lstThread1
            // 
            this.lstThread1.HideSelection = false;
            this.lstThread1.Location = new System.Drawing.Point(522, 127);
            this.lstThread1.Name = "lstThread1";
            this.lstThread1.Size = new System.Drawing.Size(259, 329);
            this.lstThread1.TabIndex = 2;
            this.lstThread1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(556, 68);
            this.label1.TabIndex = 3;
            this.label1.Text = "      This method will run each thread as normal \r\n                        in an " +
    "easy way";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic Semilight", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Thread 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic Semilight", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(606, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Thread 1";
            // 
            // btnBacktoMenu
            // 
            this.btnBacktoMenu.Location = new System.Drawing.Point(337, 334);
            this.btnBacktoMenu.Name = "btnBacktoMenu";
            this.btnBacktoMenu.Size = new System.Drawing.Size(117, 61);
            this.btnBacktoMenu.TabIndex = 6;
            this.btnBacktoMenu.Text = "Back to Menu";
            this.btnBacktoMenu.UseVisualStyleBackColor = true;
            this.btnBacktoMenu.Click += new System.EventHandler(this.btnBacktoMenu_Click);
            // 
            // frmMethod1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 468);
            this.Controls.Add(this.btnBacktoMenu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstThread1);
            this.Controls.Add(this.LstThread2);
            this.Controls.Add(this.btnStart);
            this.Name = "frmMethod1";
            this.Text = "frmMethod1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListView LstThread2;
        private System.Windows.Forms.ListView lstThread1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBacktoMenu;
    }
}

namespace Multi_thread_Visual
{
    partial class Method_2
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
            this.Lst2 = new System.Windows.Forms.ListView();
            this.Lst1 = new System.Windows.Forms.ListView();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnBacktomenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lst2
            // 
            this.Lst2.HideSelection = false;
            this.Lst2.Location = new System.Drawing.Point(12, 137);
            this.Lst2.Name = "Lst2";
            this.Lst2.Size = new System.Drawing.Size(245, 319);
            this.Lst2.TabIndex = 0;
            this.Lst2.UseCompatibleStateImageBehavior = false;
            // 
            // Lst1
            // 
            this.Lst1.HideSelection = false;
            this.Lst1.Location = new System.Drawing.Point(536, 137);
            this.Lst1.Name = "Lst1";
            this.Lst1.Size = new System.Drawing.Size(245, 319);
            this.Lst1.TabIndex = 1;
            this.Lst1.UseCompatibleStateImageBehavior = false;
            // 
            // btnStart
            // 
            this.btnStart.AutoSize = true;
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(339, 137);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(122, 66);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start the\r\nthread\r\n";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnBacktomenu
            // 
            this.btnBacktomenu.AutoSize = true;
            this.btnBacktomenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBacktomenu.Location = new System.Drawing.Point(293, 320);
            this.btnBacktomenu.Name = "btnBacktomenu";
            this.btnBacktomenu.Size = new System.Drawing.Size(221, 68);
            this.btnBacktomenu.TabIndex = 3;
            this.btnBacktomenu.Text = "Back to the \r\nmenu";
            this.btnBacktomenu.UseVisualStyleBackColor = true;
            this.btnBacktomenu.Click += new System.EventHandler(this.btnBacktomenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiLight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(289, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 87);
            this.label1.TabIndex = 4;
            this.label1.Text = "Method 2 will stop\r\none thread for 3 sec\r\nand then resume it";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Thread 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(629, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "Thread 1";
            // 
            // Method_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(793, 468);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBacktomenu);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.Lst1);
            this.Controls.Add(this.Lst2);
            this.Name = "Method_2";
            this.Text = "Method_2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView Lst2;
        private System.Windows.Forms.ListView Lst1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnBacktomenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
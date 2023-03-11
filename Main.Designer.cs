namespace Multi_thread_Visual
{
    partial class frmMain
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
            this.btnMethod1 = new System.Windows.Forms.Button();
            this.btnMethod = new System.Windows.Forms.Button();
            this.btnMethod3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "Multi-Thread ";
            // 
            // btnMethod1
            // 
            this.btnMethod1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMethod1.AutoSize = true;
            this.btnMethod1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMethod1.BackColor = System.Drawing.Color.Transparent;
            this.btnMethod1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMethod1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnMethod1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMethod1.Location = new System.Drawing.Point(63, 213);
            this.btnMethod1.Name = "btnMethod1";
            this.btnMethod1.Size = new System.Drawing.Size(136, 41);
            this.btnMethod1.TabIndex = 1;
            this.btnMethod1.Text = "Method 1";
            this.btnMethod1.UseVisualStyleBackColor = false;
            this.btnMethod1.Click += new System.EventHandler(this.btnMethod1_Click);
            // 
            // btnMethod
            // 
            this.btnMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMethod.AutoSize = true;
            this.btnMethod.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMethod.BackColor = System.Drawing.Color.Transparent;
            this.btnMethod.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMethod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMethod.Location = new System.Drawing.Point(301, 213);
            this.btnMethod.Name = "btnMethod";
            this.btnMethod.Size = new System.Drawing.Size(136, 41);
            this.btnMethod.TabIndex = 2;
            this.btnMethod.Text = "Method 2";
            this.btnMethod.UseVisualStyleBackColor = false;
            this.btnMethod.Click += new System.EventHandler(this.btnMethod_Click);
            // 
            // btnMethod3
            // 
            this.btnMethod3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMethod3.AutoSize = true;
            this.btnMethod3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMethod3.BackColor = System.Drawing.Color.Transparent;
            this.btnMethod3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMethod3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnMethod3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMethod3.Location = new System.Drawing.Point(546, 213);
            this.btnMethod3.Name = "btnMethod3";
            this.btnMethod3.Size = new System.Drawing.Size(136, 41);
            this.btnMethod3.TabIndex = 3;
            this.btnMethod3.Text = "Method 3";
            this.btnMethod3.UseVisualStyleBackColor = false;
            this.btnMethod3.Click += new System.EventHandler(this.btnMethod3_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(298, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mahdi Ranjkesh";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(754, 287);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMethod3);
            this.Controls.Add(this.btnMethod);
            this.Controls.Add(this.btnMethod1);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMethod1;
        private System.Windows.Forms.Button btnMethod;
        private System.Windows.Forms.Button btnMethod3;
        private System.Windows.Forms.Label label2;
    }
}


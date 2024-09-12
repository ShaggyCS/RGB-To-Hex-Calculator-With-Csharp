namespace RGB_To_HEX
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
            this.txtRed = new System.Windows.Forms.TextBox();
            this.txtGreen = new System.Windows.Forms.TextBox();
            this.txtBlue = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHexColor = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblColorShow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtRed
            // 
            this.txtRed.Location = new System.Drawing.Point(100, 26);
            this.txtRed.Name = "txtRed";
            this.txtRed.Size = new System.Drawing.Size(130, 20);
            this.txtRed.TabIndex = 0;
            // 
            // txtGreen
            // 
            this.txtGreen.Location = new System.Drawing.Point(100, 52);
            this.txtGreen.Name = "txtGreen";
            this.txtGreen.Size = new System.Drawing.Size(130, 20);
            this.txtGreen.TabIndex = 0;
            // 
            // txtBlue
            // 
            this.txtBlue.Location = new System.Drawing.Point(100, 78);
            this.txtBlue.Name = "txtBlue";
            this.txtBlue.Size = new System.Drawing.Size(130, 20);
            this.txtBlue.TabIndex = 0;
            // 
            // btnRun
            // 
            this.btnRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnRun.Location = new System.Drawing.Point(12, 133);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(164, 42);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label1.Location = new System.Drawing.Point(29, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Red";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Green";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label3.Location = new System.Drawing.Point(25, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Blue";
            // 
            // lblHexColor
            // 
            this.lblHexColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F);
            this.lblHexColor.Location = new System.Drawing.Point(8, 199);
            this.lblHexColor.Name = "lblHexColor";
            this.lblHexColor.Size = new System.Drawing.Size(151, 55);
            this.lblHexColor.TabIndex = 2;
            this.lblHexColor.Click += new System.EventHandler(this.lblHexColor_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Titr", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(160, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 33);
            this.label4.TabIndex = 4;
            this.label4.Text = "HEX کد رنگ ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblColorShow
            // 
            this.lblColorShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F);
            this.lblColorShow.Location = new System.Drawing.Point(182, 124);
            this.lblColorShow.Name = "lblColorShow";
            this.lblColorShow.Size = new System.Drawing.Size(107, 51);
            this.lblColorShow.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 271);
            this.Controls.Add(this.lblColorShow);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHexColor);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.txtBlue);
            this.Controls.Add(this.txtGreen);
            this.Controls.Add(this.txtRed);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRed;
        private System.Windows.Forms.TextBox txtGreen;
        private System.Windows.Forms.TextBox txtBlue;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHexColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblColorShow;
    }
}


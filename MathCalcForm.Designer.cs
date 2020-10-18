namespace MathCalc
{
    partial class MathCalcFrm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mathCalcButton4 = new MathCalc.MathCalcButton();
            this.mathCalcButton3 = new MathCalc.MathCalcButton();
            this.btnClose = new MathCalc.MathCalcButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mathCalcButton2 = new MathCalc.MathCalcButton();
            this.mathCalcButton1 = new MathCalc.MathCalcButton();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.mathCalcButton4);
            this.panel1.Controls.Add(this.mathCalcButton3);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1333, 124);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(280, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kalkulátor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(137, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Másodfokú Egyenlet";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MathCalc.Properties.Resources.brain;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // mathCalcButton4
            // 
            this.mathCalcButton4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mathCalcButton4.ForeColor = System.Drawing.Color.White;
            this.mathCalcButton4.Location = new System.Drawing.Point(1222, 12);
            this.mathCalcButton4.Name = "mathCalcButton4";
            this.mathCalcButton4.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(84)))), ((int)(((byte)(161)))));
            this.mathCalcButton4.Size = new System.Drawing.Size(29, 23);
            this.mathCalcButton4.TabIndex = 0;
            this.mathCalcButton4.Text = "?";
            // 
            // mathCalcButton3
            // 
            this.mathCalcButton3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mathCalcButton3.ForeColor = System.Drawing.Color.White;
            this.mathCalcButton3.Location = new System.Drawing.Point(1257, 12);
            this.mathCalcButton3.Name = "mathCalcButton3";
            this.mathCalcButton3.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(84)))), ((int)(((byte)(161)))));
            this.mathCalcButton3.Size = new System.Drawing.Size(29, 23);
            this.mathCalcButton3.TabIndex = 0;
            this.mathCalcButton3.Text = "_";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1292, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(84)))), ((int)(((byte)(161)))));
            this.btnClose.Size = new System.Drawing.Size(29, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::MathCalc.Properties.Resources.honeycomb;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.mathCalcButton2);
            this.panel2.Controls.Add(this.mathCalcButton1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 124);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1333, 603);
            this.panel2.TabIndex = 1;
            // 
            // mathCalcButton2
            // 
            this.mathCalcButton2.ForeColor = System.Drawing.Color.White;
            this.mathCalcButton2.Location = new System.Drawing.Point(1138, 544);
            this.mathCalcButton2.Name = "mathCalcButton2";
            this.mathCalcButton2.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(84)))), ((int)(((byte)(161)))));
            this.mathCalcButton2.Size = new System.Drawing.Size(165, 36);
            this.mathCalcButton2.TabIndex = 0;
            this.mathCalcButton2.Text = "Mentés másként";
            // 
            // mathCalcButton1
            // 
            this.mathCalcButton1.ForeColor = System.Drawing.Color.White;
            this.mathCalcButton1.Location = new System.Drawing.Point(954, 544);
            this.mathCalcButton1.Name = "mathCalcButton1";
            this.mathCalcButton1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(84)))), ((int)(((byte)(161)))));
            this.mathCalcButton1.Size = new System.Drawing.Size(165, 36);
            this.mathCalcButton1.TabIndex = 0;
            this.mathCalcButton1.Text = "Mentés";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(12, 573);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "© 2020 - Jóföldi Krisztián";
            // 
            // MathCalcFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 727);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MathCalcFrm";
            this.Text = "Másodrendű Egyenlet Kalkulátor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MathCalcButton mathCalcButton1;
        private MathCalcButton mathCalcButton2;
        private MathCalcButton btnClose;
        private MathCalcButton mathCalcButton4;
        private MathCalcButton mathCalcButton3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}


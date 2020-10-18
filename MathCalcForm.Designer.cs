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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.grpBxEgyenletek = new System.Windows.Forms.GroupBox();
            this.grpBxUjEgyenlet = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mathCalcButton5 = new MathCalc.MathCalcButton();
            this.mathCalcButton1 = new MathCalc.MathCalcButton();
            this.mathCalcButton2 = new MathCalc.MathCalcButton();
            this.mathCalcButton4 = new MathCalc.MathCalcButton();
            this.mathCalcButton3 = new MathCalc.MathCalcButton();
            this.btnClose = new MathCalc.MathCalcButton();
            this.mathCalcButton6 = new MathCalc.MathCalcButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.grpBxEgyenletek.SuspendLayout();
            this.grpBxUjEgyenlet.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.mathCalcButton4);
            this.panel1.Controls.Add(this.mathCalcButton6);
            this.panel1.Controls.Add(this.mathCalcButton3);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 124);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
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
            // panel2
            // 
            this.panel2.BackgroundImage = global::MathCalc.Properties.Resources.honeycomb;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.grpBxUjEgyenlet);
            this.panel2.Controls.Add(this.grpBxEgyenletek);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 124);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 603);
            this.panel2.TabIndex = 1;
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
            // grpBxEgyenletek
            // 
            this.grpBxEgyenletek.BackColor = System.Drawing.Color.Transparent;
            this.grpBxEgyenletek.Controls.Add(this.mathCalcButton1);
            this.grpBxEgyenletek.Controls.Add(this.mathCalcButton2);
            this.grpBxEgyenletek.Location = new System.Drawing.Point(604, 39);
            this.grpBxEgyenletek.Name = "grpBxEgyenletek";
            this.grpBxEgyenletek.Size = new System.Drawing.Size(349, 541);
            this.grpBxEgyenletek.TabIndex = 2;
            this.grpBxEgyenletek.TabStop = false;
            this.grpBxEgyenletek.Text = "Egyenletek";
            // 
            // grpBxUjEgyenlet
            // 
            this.grpBxUjEgyenlet.BackColor = System.Drawing.Color.Transparent;
            this.grpBxUjEgyenlet.Controls.Add(this.mathCalcButton5);
            this.grpBxUjEgyenlet.Location = new System.Drawing.Point(34, 39);
            this.grpBxUjEgyenlet.Name = "grpBxUjEgyenlet";
            this.grpBxUjEgyenlet.Size = new System.Drawing.Size(540, 239);
            this.grpBxUjEgyenlet.TabIndex = 3;
            this.grpBxUjEgyenlet.TabStop = false;
            this.grpBxUjEgyenlet.Text = "Új egyenlet rögzítése";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Location = new System.Drawing.Point(34, 294);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(540, 239);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Egyenlet megoldása";
            // 
            // mathCalcButton5
            // 
            this.mathCalcButton5.ForeColor = System.Drawing.Color.White;
            this.mathCalcButton5.Location = new System.Drawing.Point(402, 187);
            this.mathCalcButton5.Name = "mathCalcButton5";
            this.mathCalcButton5.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(84)))), ((int)(((byte)(161)))));
            this.mathCalcButton5.Size = new System.Drawing.Size(118, 36);
            this.mathCalcButton5.TabIndex = 0;
            this.mathCalcButton5.Text = "Rögzít";
            // 
            // mathCalcButton1
            // 
            this.mathCalcButton1.ForeColor = System.Drawing.Color.White;
            this.mathCalcButton1.Location = new System.Drawing.Point(23, 487);
            this.mathCalcButton1.Name = "mathCalcButton1";
            this.mathCalcButton1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(84)))), ((int)(((byte)(161)))));
            this.mathCalcButton1.Size = new System.Drawing.Size(118, 36);
            this.mathCalcButton1.TabIndex = 0;
            this.mathCalcButton1.Text = "Mentés";
            // 
            // mathCalcButton2
            // 
            this.mathCalcButton2.ForeColor = System.Drawing.Color.White;
            this.mathCalcButton2.Location = new System.Drawing.Point(159, 487);
            this.mathCalcButton2.Name = "mathCalcButton2";
            this.mathCalcButton2.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(84)))), ((int)(((byte)(161)))));
            this.mathCalcButton2.Size = new System.Drawing.Size(165, 36);
            this.mathCalcButton2.TabIndex = 0;
            this.mathCalcButton2.Text = "Mentés másként";
            // 
            // mathCalcButton4
            // 
            this.mathCalcButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mathCalcButton4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mathCalcButton4.ForeColor = System.Drawing.Color.White;
            this.mathCalcButton4.Location = new System.Drawing.Point(865, 12);
            this.mathCalcButton4.Name = "mathCalcButton4";
            this.mathCalcButton4.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(84)))), ((int)(((byte)(161)))));
            this.mathCalcButton4.Size = new System.Drawing.Size(29, 23);
            this.mathCalcButton4.TabIndex = 0;
            this.mathCalcButton4.Text = "?";
            this.mathCalcButton4.Click += new System.EventHandler(this.mathCalcButton4_Click);
            // 
            // mathCalcButton3
            // 
            this.mathCalcButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mathCalcButton3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mathCalcButton3.ForeColor = System.Drawing.Color.White;
            this.mathCalcButton3.Location = new System.Drawing.Point(927, 12);
            this.mathCalcButton3.Name = "mathCalcButton3";
            this.mathCalcButton3.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(84)))), ((int)(((byte)(161)))));
            this.mathCalcButton3.Size = new System.Drawing.Size(29, 23);
            this.mathCalcButton3.TabIndex = 0;
            this.mathCalcButton3.Text = "❏";
            this.mathCalcButton3.Click += new System.EventHandler(this.mathCalcButton3_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(958, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(84)))), ((int)(((byte)(161)))));
            this.btnClose.Size = new System.Drawing.Size(29, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // mathCalcButton6
            // 
            this.mathCalcButton6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mathCalcButton6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mathCalcButton6.ForeColor = System.Drawing.Color.White;
            this.mathCalcButton6.Location = new System.Drawing.Point(896, 12);
            this.mathCalcButton6.Name = "mathCalcButton6";
            this.mathCalcButton6.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(84)))), ((int)(((byte)(161)))));
            this.mathCalcButton6.Size = new System.Drawing.Size(29, 23);
            this.mathCalcButton6.TabIndex = 0;
            this.mathCalcButton6.Text = "_";
            this.mathCalcButton6.Click += new System.EventHandler(this.mathCalcButton6_Click);
            // 
            // MathCalcFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 727);
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
            this.grpBxEgyenletek.ResumeLayout(false);
            this.grpBxUjEgyenlet.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox grpBxUjEgyenlet;
        private MathCalcButton mathCalcButton5;
        private System.Windows.Forms.GroupBox grpBxEgyenletek;
        private MathCalcButton mathCalcButton6;
    }
}


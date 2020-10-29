namespace MathCalc
{
    partial class SettingsFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsFrm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rBNem = new System.Windows.Forms.RadioButton();
            this.rBIgen = new System.Windows.Forms.RadioButton();
            this.lblKerdes = new System.Windows.Forms.Label();
            this.btnMegsem = new MathCalc.MathCalcButton();
            this.btnAlkalmaz = new MathCalc.MathCalcButton();
            this.btnClose = new MathCalc.MathCalcButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rBNem);
            this.groupBox1.Controls.Add(this.rBIgen);
            this.groupBox1.Controls.Add(this.lblKerdes);
            this.groupBox1.Location = new System.Drawing.Point(12, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 177);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Általános beállítások";
            // 
            // rBNem
            // 
            this.rBNem.AutoSize = true;
            this.rBNem.Location = new System.Drawing.Point(309, 86);
            this.rBNem.Name = "rBNem";
            this.rBNem.Size = new System.Drawing.Size(65, 25);
            this.rBNem.TabIndex = 1;
            this.rBNem.Text = "Nem";
            this.rBNem.UseVisualStyleBackColor = true;
            this.rBNem.CheckedChanged += new System.EventHandler(this.rdBtn_CheckedChanged);
            // 
            // rBIgen
            // 
            this.rBIgen.AutoSize = true;
            this.rBIgen.Location = new System.Drawing.Point(162, 86);
            this.rBIgen.Name = "rBIgen";
            this.rBIgen.Size = new System.Drawing.Size(64, 25);
            this.rBIgen.TabIndex = 1;
            this.rBIgen.Text = "Igen";
            this.rBIgen.UseVisualStyleBackColor = true;
            this.rBIgen.CheckedChanged += new System.EventHandler(this.rdBtn_CheckedChanged);
            // 
            // lblKerdes
            // 
            this.lblKerdes.AutoSize = true;
            this.lblKerdes.Location = new System.Drawing.Point(33, 47);
            this.lblKerdes.Name = "lblKerdes";
            this.lblKerdes.Size = new System.Drawing.Size(498, 21);
            this.lblKerdes.TabIndex = 0;
            this.lblKerdes.Text = "Kérdezzen rá az egyenlet(ek) törlésére azok végrehajtása előtt.";
            // 
            // btnMegsem
            // 
            this.btnMegsem.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMegsem.ForeColor = System.Drawing.Color.White;
            this.btnMegsem.Location = new System.Drawing.Point(286, 238);
            this.btnMegsem.Name = "btnMegsem";
            this.btnMegsem.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(84)))), ((int)(((byte)(161)))));
            this.btnMegsem.Size = new System.Drawing.Size(132, 33);
            this.btnMegsem.TabIndex = 5;
            this.btnMegsem.Text = "Mégse";
            // 
            // btnAlkalmaz
            // 
            this.btnAlkalmaz.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAlkalmaz.ForeColor = System.Drawing.Color.White;
            this.btnAlkalmaz.Location = new System.Drawing.Point(437, 238);
            this.btnAlkalmaz.Name = "btnAlkalmaz";
            this.btnAlkalmaz.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(84)))), ((int)(((byte)(161)))));
            this.btnAlkalmaz.Size = new System.Drawing.Size(132, 33);
            this.btnAlkalmaz.TabIndex = 5;
            this.btnAlkalmaz.Text = "Alkalmaz";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(543, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(84)))), ((int)(((byte)(161)))));
            this.btnClose.Size = new System.Drawing.Size(29, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "X";
            // 
            // SettingsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::MathCalc.Properties.Resources.honeycomb;
            this.ClientSize = new System.Drawing.Size(581, 285);
            this.Controls.Add(this.btnMegsem);
            this.Controls.Add(this.btnAlkalmaz);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SettingsFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Beállítások";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MathCalcButton btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private MathCalcButton btnAlkalmaz;
        private System.Windows.Forms.RadioButton rBNem;
        private System.Windows.Forms.RadioButton rBIgen;
        private System.Windows.Forms.Label lblKerdes;
        private MathCalcButton btnMegsem;
    }
}
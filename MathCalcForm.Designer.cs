﻿namespace MathCalc
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MathCalcFrm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grpBxUjEgyenlet = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtBxC = new System.Windows.Forms.TextBox();
            this.txtBxB = new System.Windows.Forms.TextBox();
            this.txtBxA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpBxEgyenletek = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.clmnHAEgyutthato = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnHBEgyutthato = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnHCEgyutthato = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.lblMentes = new System.Windows.Forms.Label();
            this.btnRogzit = new MathCalc.MathCalcButton();
            this.mthClcBtnTorles = new MathCalc.MathCalcButton();
            this.cstmImgBtnMentes = new MathCalc.CustomImageButton();
            this.mathCalcButton4 = new MathCalc.MathCalcButton();
            this.mathCalcButton6 = new MathCalc.MathCalcButton();
            this.btnClose = new MathCalc.MathCalcButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.grpBxUjEgyenlet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.grpBxEgyenletek.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cstmImgBtnMentes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.lblMentes);
            this.panel1.Controls.Add(this.cstmImgBtnMentes);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.mathCalcButton4);
            this.panel1.Controls.Add(this.mathCalcButton6);
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
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
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
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Location = new System.Drawing.Point(34, 294);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(520, 239);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Egyenlet megoldása";
            // 
            // grpBxUjEgyenlet
            // 
            this.grpBxUjEgyenlet.BackColor = System.Drawing.Color.Transparent;
            this.grpBxUjEgyenlet.Controls.Add(this.pictureBox2);
            this.grpBxUjEgyenlet.Controls.Add(this.txtBxC);
            this.grpBxUjEgyenlet.Controls.Add(this.txtBxB);
            this.grpBxUjEgyenlet.Controls.Add(this.txtBxA);
            this.grpBxUjEgyenlet.Controls.Add(this.label6);
            this.grpBxUjEgyenlet.Controls.Add(this.label5);
            this.grpBxUjEgyenlet.Controls.Add(this.label4);
            this.grpBxUjEgyenlet.Controls.Add(this.btnRogzit);
            this.grpBxUjEgyenlet.Location = new System.Drawing.Point(34, 39);
            this.grpBxUjEgyenlet.Name = "grpBxUjEgyenlet";
            this.grpBxUjEgyenlet.Size = new System.Drawing.Size(520, 239);
            this.grpBxUjEgyenlet.TabIndex = 3;
            this.grpBxUjEgyenlet.TabStop = false;
            this.grpBxUjEgyenlet.Text = "Új egyenlet rögzítése";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(282, 54);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(189, 72);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // txtBxC
            // 
            this.txtBxC.Location = new System.Drawing.Point(75, 146);
            this.txtBxC.Name = "txtBxC";
            this.txtBxC.Size = new System.Drawing.Size(163, 27);
            this.txtBxC.TabIndex = 2;
            // 
            // txtBxB
            // 
            this.txtBxB.Location = new System.Drawing.Point(75, 104);
            this.txtBxB.Name = "txtBxB";
            this.txtBxB.Size = new System.Drawing.Size(163, 27);
            this.txtBxB.TabIndex = 2;
            // 
            // txtBxA
            // 
            this.txtBxA.Location = new System.Drawing.Point(75, 61);
            this.txtBxA.Name = "txtBxA";
            this.txtBxA.Size = new System.Drawing.Size(163, 27);
            this.txtBxA.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(45, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "c:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(44, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "b:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(44, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "a:";
            // 
            // grpBxEgyenletek
            // 
            this.grpBxEgyenletek.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBxEgyenletek.BackColor = System.Drawing.Color.Transparent;
            this.grpBxEgyenletek.Controls.Add(this.listView1);
            this.grpBxEgyenletek.Controls.Add(this.mthClcBtnTorles);
            this.grpBxEgyenletek.Location = new System.Drawing.Point(571, 39);
            this.grpBxEgyenletek.Name = "grpBxEgyenletek";
            this.grpBxEgyenletek.Size = new System.Drawing.Size(382, 541);
            this.grpBxEgyenletek.TabIndex = 2;
            this.grpBxEgyenletek.TabStop = false;
            this.grpBxEgyenletek.Text = "Egyenletek";
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmnHAEgyutthato,
            this.clmnHBEgyutthato,
            this.clmnHCEgyutthato});
            this.listView1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 26);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(370, 441);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // clmnHAEgyutthato
            // 
            this.clmnHAEgyutthato.Text = "\"a\" együttható";
            this.clmnHAEgyutthato.Width = 120;
            // 
            // clmnHBEgyutthato
            // 
            this.clmnHBEgyutthato.Text = "\"b\" együttható";
            this.clmnHBEgyutthato.Width = 120;
            // 
            // clmnHCEgyutthato
            // 
            this.clmnHCEgyutthato.Text = "\"c\" együttható";
            this.clmnHCEgyutthato.Width = 120;
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
            // lblMentes
            // 
            this.lblMentes.AutoSize = true;
            this.lblMentes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMentes.ForeColor = System.Drawing.Color.White;
            this.lblMentes.Location = new System.Drawing.Point(490, 94);
            this.lblMentes.Name = "lblMentes";
            this.lblMentes.Size = new System.Drawing.Size(64, 20);
            this.lblMentes.TabIndex = 4;
            this.lblMentes.Text = "Mentés";
            // 
            // btnRogzit
            // 
            this.btnRogzit.ForeColor = System.Drawing.Color.White;
            this.btnRogzit.Location = new System.Drawing.Point(309, 168);
            this.btnRogzit.Name = "btnRogzit";
            this.btnRogzit.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(84)))), ((int)(((byte)(161)))));
            this.btnRogzit.Size = new System.Drawing.Size(118, 36);
            this.btnRogzit.TabIndex = 0;
            this.btnRogzit.Text = "💾 Rögzít";
            this.btnRogzit.Click += new System.EventHandler(this.btnRogzit_Click);
            // 
            // mthClcBtnTorles
            // 
            this.mthClcBtnTorles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.mthClcBtnTorles.ForeColor = System.Drawing.Color.White;
            this.mthClcBtnTorles.Location = new System.Drawing.Point(108, 488);
            this.mthClcBtnTorles.Name = "mthClcBtnTorles";
            this.mthClcBtnTorles.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(84)))), ((int)(((byte)(161)))));
            this.mthClcBtnTorles.Size = new System.Drawing.Size(192, 36);
            this.mthClcBtnTorles.TabIndex = 0;
            this.mthClcBtnTorles.Text = "🗑 Kijelölt(ek) törlése";
            this.mthClcBtnTorles.Click += new System.EventHandler(this.mthClcBtnTorles_Click);
            // 
            // cstmImgBtnMentes
            // 
            this.cstmImgBtnMentes.Image = global::MathCalc.Properties.Resources.floppy_white;
            this.cstmImgBtnMentes.ImageEnter = global::MathCalc.Properties.Resources.floppy_orange;
            this.cstmImgBtnMentes.ImageNormal = global::MathCalc.Properties.Resources.floppy_white;
            this.cstmImgBtnMentes.Location = new System.Drawing.Point(490, 35);
            this.cstmImgBtnMentes.Name = "cstmImgBtnMentes";
            this.cstmImgBtnMentes.Size = new System.Drawing.Size(64, 56);
            this.cstmImgBtnMentes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cstmImgBtnMentes.TabIndex = 3;
            this.cstmImgBtnMentes.TabStop = false;
            this.cstmImgBtnMentes.MouseEnter += new System.EventHandler(this.cstmImgBtnMentes_MouseEnter);
            this.cstmImgBtnMentes.MouseLeave += new System.EventHandler(this.cstmImgBtnMentes_MouseLeave);
            // 
            // mathCalcButton4
            // 
            this.mathCalcButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mathCalcButton4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mathCalcButton4.ForeColor = System.Drawing.Color.White;
            this.mathCalcButton4.Location = new System.Drawing.Point(893, 12);
            this.mathCalcButton4.Name = "mathCalcButton4";
            this.mathCalcButton4.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(84)))), ((int)(((byte)(161)))));
            this.mathCalcButton4.Size = new System.Drawing.Size(29, 23);
            this.mathCalcButton4.TabIndex = 0;
            this.mathCalcButton4.Text = "?";
            this.mathCalcButton4.Click += new System.EventHandler(this.mathCalcButton4_Click);
            // 
            // mathCalcButton6
            // 
            this.mathCalcButton6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mathCalcButton6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mathCalcButton6.ForeColor = System.Drawing.Color.White;
            this.mathCalcButton6.Location = new System.Drawing.Point(924, 12);
            this.mathCalcButton6.Name = "mathCalcButton6";
            this.mathCalcButton6.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(84)))), ((int)(((byte)(161)))));
            this.mathCalcButton6.Size = new System.Drawing.Size(29, 23);
            this.mathCalcButton6.TabIndex = 0;
            this.mathCalcButton6.Text = "_";
            this.mathCalcButton6.Click += new System.EventHandler(this.mathCalcButton6_Click);
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
            this.grpBxUjEgyenlet.ResumeLayout(false);
            this.grpBxUjEgyenlet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.grpBxEgyenletek.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cstmImgBtnMentes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MathCalcButton mthClcBtnTorles;
        private MathCalcButton btnClose;
        private MathCalcButton mathCalcButton4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox grpBxUjEgyenlet;
        private MathCalcButton btnRogzit;
        private System.Windows.Forms.GroupBox grpBxEgyenletek;
        private MathCalcButton mathCalcButton6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtBxC;
        private System.Windows.Forms.TextBox txtBxB;
        private System.Windows.Forms.TextBox txtBxA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader clmnHAEgyutthato;
        private System.Windows.Forms.ColumnHeader clmnHBEgyutthato;
        private System.Windows.Forms.ColumnHeader clmnHCEgyutthato;
        private System.Windows.Forms.Label lblMentes;
        private CustomImageButton cstmImgBtnMentes;
    }
}


using System.Drawing;
using System.Windows.Forms;

namespace MathCalc
{
    partial class CustomImageButton
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public SizeF AutoScaleDimensions { get; private set; }
        public AutoScaleMode AutoScaleMode { get; private set; }

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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomImageButton
            // 
            this.MouseEnter += new System.EventHandler(this.CustomImageButton_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.CustomImageButton_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}

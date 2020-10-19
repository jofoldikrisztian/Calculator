using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathCalc
{
    public partial class CustomImageButton : PictureBox
    {
        public CustomImageButton()
        {
            InitializeComponent();
        }

        private Image NormalImage;
        private Image enterImage;

        public Image ImageNormal
        {
            get { return NormalImage; }
            set { NormalImage = value; }
        }

        public Image ImageEnter
        {
            get { return enterImage; }
            set { enterImage = value; }
        }


        private void CustomImageButton_MouseLeave(object sender, EventArgs e)
        {
            this.Image = NormalImage;
        }

        private void CustomImageButton_MouseEnter(object sender, EventArgs e)
        {
            this.Image = enterImage;
        }
    }
}

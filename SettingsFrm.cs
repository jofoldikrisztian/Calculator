using System;
using System.Windows.Forms;

namespace MathCalc
{
    public partial class SettingsFrm : Form
    {
        
        public SettingsFrm()
        {
            InitializeComponent();

            if (MathCalcFrm.askToDeleteHelper)
            {
                rBIgen.Checked = true;
            }
            else
            {
                rBNem.Checked = true;
            }
        }


        private void rdBtn_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdBtn = (RadioButton)sender;
            if (rdBtn.Checked)
            {
                switch (rdBtn.Name)
                {
                    case "rBNem":
                        MathCalcFrm.askToDeleteHelper = false;
                        break;
                    case "rBIgen":
                        MathCalcFrm.askToDeleteHelper = true;
                        break;
                }
            }
        }
    }
}

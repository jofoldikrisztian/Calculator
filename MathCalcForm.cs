using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathCalc
{


    public partial class MathCalcFrm : Form
    {
        private const int buttondown = 0xA1;
        private const int HT_CAPTION = 0x2;


        public MathCalcFrm()
        {
            InitializeComponent();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mathCalcButton4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ez lesz a segítség menü..", "Segítség", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, buttondown, HT_CAPTION, 0);
            }
        }

        private void mathCalcButton6_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        private void btnRogzit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBxA.Text) || string.IsNullOrEmpty(txtBxB.Text) || string.IsNullOrEmpty(txtBxC.Text))
            {
                return;
            }

            ListViewItem item = new ListViewItem(new string[] {"", txtBxA.Text + "x²+" + txtBxB.Text + "x+" + txtBxC.Text, txtBxA.Text, txtBxB.Text, txtBxC.Text });

            listView1.Items.Add(item);
            txtBxA.Clear();
            txtBxB.Clear();
            txtBxC.Clear();
        }

        private void cstmImgBtnMentes_MouseEnter(object sender, EventArgs e)
        {
            lblMentes.ForeColor = Color.Orange;
            Cursor = Cursors.Hand;
        }

        private void cstmImgBtnMentes_MouseLeave(object sender, EventArgs e)
        {
            lblMentes.ForeColor = Color.White;
            Cursor = Cursors.Default;
        }

        private void mthClcBtnTorles_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count > 0)
            {

                if (MessageBox.Show("Biztos vagy benne?", "Figyelmeztetés", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    foreach (ListViewItem item in listView1.SelectedItems)
                    {
                        listView1.Items.Remove(item);
                    }
                }
            }
            else
            {
                MessageBox.Show("Nem jelöltél ki egy elemet sem!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
          

            ListViewItem item = listView1.SelectedItems[0];

            var aValue = item.SubItems[clmnHAEgyutthato.Index].Text;
            var bValue = item.SubItems[clmnHBEgyutthato.Index].Text;
            var cValue = item.SubItems[clmnHCEgyutthato.Index].Text;

            MessageBox.Show(aValue.ToString() + bValue.ToString() + cValue.ToString(), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

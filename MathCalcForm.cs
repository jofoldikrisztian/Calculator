using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
using System.IO;

namespace MathCalc
{
    public partial class MathCalcFrm : Form
    {

        #region Mezők

        private const int buttondown = 0xA1;
        private const int HT_CAPTION = 0x2;
        private readonly QuadraticEquation _quadraticEquation;

        #endregion

        #region Konstruktor
        public MathCalcFrm()
        {
            InitializeComponent();
            _quadraticEquation = new QuadraticEquation();

        }
        #endregion

        #region Események

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mathCalcButton4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ez lesz a segítség menü..", "Segítség", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
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
                MessageBox.Show("Hiányzó adat!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (int.TryParse(txtBxA.Text, out _) && int.TryParse(txtBxB.Text, out _) && int.TryParse(txtBxC.Text, out _))
            {
                string equation = txtBxA.Text + "x² + " + txtBxB.Text + "x + " + txtBxC.Text;
                ListViewItem newItem = new ListViewItem(new string[] { (listView.Items.Count + 1).ToString(), equation, txtBxA.Text, txtBxB.Text, txtBxC.Text });
                newItem.Name = equation;

                if (!listView.Items.ContainsKey(newItem.Name))
                {
                    listView.Items.Add(newItem);
                    clearTextBoxes();
                }
                else
                {
                    MessageBox.Show("A táblázat már tartalmazza ezt az egyenletet!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearTextBoxes();
                }

            }
            else
            {
                MessageBox.Show("Hibás paraméter!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearTextBoxes();
            }

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

            if (listView.SelectedItems.Count > 0)
            {

                if (MessageBox.Show("Biztos vagy benne?", "Figyelmeztetés", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    foreach (ListViewItem item in listView.SelectedItems)
                    {
                        listView.Items.Remove(item);
                    }
                    lblBxX1.Text = "";
                    lblBxX2.Text = "";
                    lblBxEgyenlet.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Nem jelöltél ki egy elemet sem!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {


            if (listView.SelectedItems.Count > 0)
            {

                ListViewItem item = listView.SelectedItems[0];

                var aValue = float.Parse(item.SubItems[clmnHAEgyutthato.Index].Text);
                var bValue = float.Parse(item.SubItems[clmnHBEgyutthato.Index].Text);
                var cValue = float.Parse(item.SubItems[clmnHCEgyutthato.Index].Text);

                QuadraticResult result = _quadraticEquation.GetResult(aValue, bValue, cValue);

                lblBxEgyenlet.Text = item.SubItems[clmnHEgyenlet.Index].Text;
                lblBxX1.Text = result.FirstValue;
                lblBxX2.Text = result.SecondValue;
            }

        }

        private void cstmImgBtnMentes_Click(object sender, EventArgs e)
        {

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFile.FileName;
                //MessageBox.Show(fileName, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                SaveToXml(fileName);
            }

        }

        private void cstmImgBtnBetoltes_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFile.FileName;

                LoadFromXml(fileName);
            }
        }

        #endregion

        #region Metódusok

        public void SaveToXml(string XmlFilePath)
        {
            List<Data> datas = new List<Data>();
            Data data;

            foreach (ListViewItem item in listView.Items)
            {
                data = new Data();
                data.Id = int.Parse(item.SubItems[clmnHId.Index].Text);
                data.A = item.SubItems[clmnHAEgyutthato.Index].Text;
                data.B = item.SubItems[clmnHBEgyutthato.Index].Text;
                data.C = item.SubItems[clmnHCEgyutthato.Index].Text;
                datas.Add(data);
            }

            XmlSerializer serializer = new XmlSerializer(typeof(List<Data>));

            using (FileStream stream = File.OpenWrite(XmlFilePath))
            {
                serializer.Serialize(stream, datas);
            }
        }

        public void LoadFromXml(string xmlFilePath)
        {
        //    listView.Clear();
            List<Data> datas = new List<Data>();

            if (File.Exists(xmlFilePath))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Data>));

                using (FileStream stream = File.OpenRead(xmlFilePath))
                {
                    datas = (List<Data>)serializer.Deserialize(stream);
                }
            }

            foreach (Data item in datas)
            {
                string equation = item.A + "x² + " + item.B + "x + " + item.C;
                ListViewItem newItem = new ListViewItem(new string[] { item.Id.ToString(), equation, item.A, item.B, item.C });
                newItem.Name = equation;
                listView.Items.Add(newItem);
            }
        }

        private void clearTextBoxes()
        {
            txtBxA.Clear();
            txtBxB.Clear();
            txtBxC.Clear();
        }

        #endregion

    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
using System.IO;
using System.Linq;

namespace MathCalc
{
    public partial class MathCalcFrm : Form
    {

        #region Mezők

        private const int buttondown = 0xA1;
        private const int HT_CAPTION = 0x2;
        private readonly QuadraticEquation _quadraticEquation;
        private bool askToDelete;
        public static bool askToDeleteHelper;


        #endregion

        #region Konstruktor
        public MathCalcFrm()
        {
            InitializeComponent();
            _quadraticEquation = new QuadraticEquation();
            askToDelete = true;
         
        }
        #endregion

        #region Események

        #region Ablakvezérlők
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {

            btnSegitseg_Click(sender, e);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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

        #endregion

        #region Menüsáv

        private void btnMentes_Click(object sender, EventArgs e)
        {

            if (listView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Egy elem sincs kijelölve!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    string fileName = saveFile.FileName;
                    SaveToXml(fileName);
                }
            }

        }
        private void BtnMentes_MouseEnter(object sender, EventArgs e)
        {
            lblMentes.Font = new Font(lblMentes.Font, FontStyle.Bold);
            Cursor = Cursors.Hand;
        }
        private void BtnMentes_MouseLeave(object sender, EventArgs e)
        {
            lblMentes.Font = new Font(lblMentes.Font, FontStyle.Regular);
            Cursor = Cursors.Default;
        }

        private void btnMegnyitas_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFile.FileName;

                LoadFromXml(fileName);
            }
        }
        private void btnMegnyitas_MouseEnter(object sender, EventArgs e)
        {
            lblMegnyitas.Font = new Font(lblMegnyitas.Font, FontStyle.Bold);
            Cursor = Cursors.Hand;
        }
        private void btnMegnyitas_MouseLeave(object sender, EventArgs e)
        {
            lblMegnyitas.Font = new Font(lblMegnyitas.Font, FontStyle.Regular);
            Cursor = Cursors.Default;
        }

        private void btnBeallitasok_Click(object sender, EventArgs e)
        {


            askToDeleteHelper = askToDelete;

            try
            {
                using (SettingsFrm settingsFrm = new SettingsFrm())
                {
                    var defaultOpacity = Opacity;
                    Opacity = .50d;

                    DialogResult dialogResult = settingsFrm.ShowDialog();
                    if (dialogResult == DialogResult.OK)
                    {
                        askToDelete = askToDeleteHelper;
                        Opacity = defaultOpacity;
                    }
                    else
                    {
                        Opacity = defaultOpacity;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnBeallitasok_MouseEnter(object sender, EventArgs e)
        {
            lblBeallitasok.Font = new Font(lblBeallitasok.Font, FontStyle.Bold);
            Cursor = Cursors.Hand;
        }
        private void btnBeallitasok_MouseLeave(object sender, EventArgs e)
        {
            lblBeallitasok.Font = new Font(lblBeallitasok.Font, FontStyle.Regular);
            Cursor = Cursors.Default;
        }

        private void btnSegitseg_Click(object sender, EventArgs e)
        {
            try
            {
                using (HelpFrm helpFrm = new HelpFrm())
                {
                    var defaultOpacity = Opacity;
                    Opacity = .50d;

                    DialogResult dialogResult = helpFrm.ShowDialog();
                    if (dialogResult == DialogResult.OK)
                    {
                        Opacity = defaultOpacity;
                    }
                    else
                    {
                        Opacity = defaultOpacity;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void btnSegitseg_MouseEnter(object sender, EventArgs e)
        {
            lblSegitseg.Font = new Font(lblSegitseg.Font, FontStyle.Bold);
            Cursor = Cursors.Hand;
        }
        private void btnSegitseg_MouseLeave(object sender, EventArgs e)
        {
            lblSegitseg.Font = new Font(lblSegitseg.Font, FontStyle.Regular);
            Cursor = Cursors.Default;
        }

        #endregion

        #region Adatműveletek

        private void btnRogzit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBxA.Text) || string.IsNullOrEmpty(txtBxB.Text) || string.IsNullOrEmpty(txtBxC.Text))
            {
                MessageBox.Show("Hiányzó adat!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (float.TryParse(txtBxA.Text, out float a) && float.TryParse(txtBxB.Text, out float b) && float.TryParse(txtBxC.Text, out float c))
            {
                // string equation = txtBxA.Text + "x² + " + txtBxB.Text + "x + " + txtBxC.Text;
                string equation = EquationGenerator(a, b, c);
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


        private void btnTorles_Click(object sender, EventArgs e)
        {

            if (listView.SelectedItems.Count > 0)
            {

                if (askToDelete ? MessageBox.Show("Biztos vagy benne?", "Figyelmeztetés", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK : true)
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

        private void lV(object sender, MouseEventArgs e)
        {
            if (listView.SelectedItems.Count == 1)
            {

                ListViewItem item = listView.SelectedItems[0];

                var aegyutthato = float.Parse(item.SubItems[clmnHAEgyutthato.Index].Text);
                var begyutthato = float.Parse(item.SubItems[clmnHBEgyutthato.Index].Text);
                var cegyutthato = float.Parse(item.SubItems[clmnHCEgyutthato.Index].Text);

                QuadraticResult result = _quadraticEquation.GetResult(aegyutthato, begyutthato, cegyutthato);

                lblBxEgyenlet.Text = item.SubItems[clmnHEgyenlet.Index].Text;
                lblBxX1.Text = result.FirstValue;
                lblBxX2.Text = result.SecondValue;
            }
            else
            {
                lblBxEgyenlet.Text = "Több egyenlet van kijelölve!";
                lblBxX1.Text = "";
                lblBxX2.Text = "";
            }


        }

        #endregion

        #region Gyorsbillentyűk

        private void MathCalcFrm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.X)
            {
                Application.Exit();
            }
            else if (e.Control && e.KeyCode == Keys.O)
            {
                btnMegnyitas_Click(sender, e);
            }
            else if (e.Control && e.KeyCode == Keys.S)
            {
                btnMentes_Click(sender, e);
            }
            else if (e.Control && e.KeyCode == Keys.R)
            {
                btnRogzit_Click(sender, e);
            }
            else if (e.Control && e.KeyCode == Keys.D)
            {
                btnTorles_Click(sender, e);
            }
            else if (e.Control && e.KeyCode == Keys.I)
            {
                foreach (ListViewItem item in listView.Items)
                {
                    item.Selected = !(item.Selected);
                }
            }
            else if (e.Control && e.KeyCode == Keys.A)
            {
                foreach (ListViewItem item in listView.Items)
                {
                    item.Selected = true;
                }
            }
            else if (e.Control && e.KeyCode == Keys.N)
            {
                foreach (ListViewItem item in listView.SelectedItems)
                {
                    item.Selected = false;
                }
            }
            else if (e.KeyCode == Keys.F1)
            {
                btnHelp_Click(sender, e);
            }
        }

        #endregion

        #endregion

        #region Metódusok

        public void SaveToXml(string XmlFilePath)
        {

            List<Data> datas = new List<Data>();
            Data data;

            Parallel.ForEach(listView.SelectedItems.Cast<ListViewItem>(), item =>
            {
                data = new Data();
                data.Id = int.Parse(item.SubItems[clmnHId.Index].Text);
                data.A = item.SubItems[clmnHAEgyutthato.Index].Text;
                data.B = item.SubItems[clmnHBEgyutthato.Index].Text;
                data.C = item.SubItems[clmnHCEgyutthato.Index].Text;
                datas.Add(data);
            });

            List<Data> sortedData = datas.OrderBy(o => o.Id).ToList();
            //foreach (ListViewItem item in listView.SelectedItems)
            //{
            //    data = new Data();
            //    data.Id = int.Parse(item.SubItems[clmnHId.Index].Text);
            //    data.A = item.SubItems[clmnHAEgyutthato.Index].Text;
            //    data.B = item.SubItems[clmnHBEgyutthato.Index].Text;
            //    data.C = item.SubItems[clmnHCEgyutthato.Index].Text;
            //    datas.Add(data);
            //}



            XmlSerializer serializer = new XmlSerializer(typeof(List<Data>));

            using (FileStream stream = File.OpenWrite(XmlFilePath))
            {
                serializer.Serialize(stream, sortedData);
            }

        }

        public void LoadFromXml(string xmlFilePath)
        {
            //  listView.Items.Clear();
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

                string equation = EquationGenerator(float.Parse(item.A), float.Parse(item.B), float.Parse(item.C));
                ListViewItem newItem = new ListViewItem(new string[] { item.Id.ToString(), equation, item.A, item.B, item.C });
                newItem.Name = equation;

                if (!listView.Items.ContainsKey(newItem.Name))
                {
                    listView.Items.Add(newItem);
                }
            }
        }

        private void clearTextBoxes()
        {
            txtBxA.Clear();
            txtBxB.Clear();
            txtBxC.Clear();
        }


        private string EquationGenerator(float a, float b, float c)
        {
            if (b < 0 && c < 0)
            {
                return $"{a}x² {b}x {c}";
            }
            else if (b > 0 && c < 0)
            {
                return $"{a}x² + {b}x {c}";
            }
            else if (b < 0 && c > 0)
            {
                return $"{a}x² {b}x + {c}";
            }
            else
            {
                return $"{a}x² + {b}x + {c}";
            }
        }

        #endregion

    }
}

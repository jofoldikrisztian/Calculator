using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
using System.IO;
using System.Linq;
using System.Threading;

namespace MathCalc
{
    public partial class MathCalcFrm : Form
    {

        #region Mezők

        private const int buttondown = 0xA1;
        private const int HT_CAPTION = 0x2;
        private bool askToDelete;
        public static bool askToDeleteHelper;
        public static QuadraticResult quadraticResult;
        public static string tempEquation;



        #endregion

        #region Konstruktor
        public MathCalcFrm()
        {
            InitializeComponent();
            quadraticResult = new QuadraticResult();
            askToDelete = true;
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
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

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count == 1)
            {
                if (backgroundWorker1.IsBusy != true)
                {
                   
                    backgroundWorker1.RunWorkerAsync(sender);
                }
            }
            else
            {
                lblBxX1.Text = "";
                lblBxX2.Text = "";
                lblBxEgyenlet.Text = "";
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

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

            if (lblBxEgyenlet.InvokeRequired)
            {
                lblBxEgyenlet.Invoke(new Action(() => lblBxEgyenlet.Text = "Türelem.... Éppen számolunk..."));
            }
            else
            {
                lblBxEgyenlet.Text = "Türelem... Éppen számolunk...";
            }

            if (lblBxX1.InvokeRequired)
            {
                lblBxX1.Invoke(new Action(() => lblBxX1.Text = ""));
            }
            else
            {
                lblBxX1.Text = "";
            }

            if (lblBxX2.InvokeRequired)
            {
                lblBxX2.Invoke(new Action(() => lblBxX2.Text = ""));
            }
            else
            {
                lblBxX2.Text = "";
            }

            var item = new ListViewItem();
            if (listView.InvokeRequired)
            {

                listView.Invoke(new Action(() => item = listView.SelectedItems[0]));
            }
            else
            {
                item = listView.SelectedItems[0];
            }

            var aegyutthato = double.Parse(item.SubItems[clmnHAEgyutthato.Index].Text);
            var begyutthato = double.Parse(item.SubItems[clmnHBEgyutthato.Index].Text);
            var cegyutthato = double.Parse(item.SubItems[clmnHCEgyutthato.Index].Text);

            QuadraticEquation quadraticEquation = new QuadraticEquation(aegyutthato, begyutthato, cegyutthato);

            try
            {
                GetResult(quadraticEquation);
            }
            catch (Exception)
            {

                throw;
            }

            tempEquation = item.SubItems[clmnHEgyenlet.Index].Text;

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                lblBxEgyenlet.Text = "Error: " + e.Error.Message;
            }
            else
            {
                lblBxEgyenlet.Text = tempEquation;
                lblBxX1.Text = quadraticResult.FirstValue;
                lblBxX2.Text = quadraticResult.SecondValue;
            }
        }

        #endregion

        #endregion

        #region Metódusok

        private void SaveToXml(string XmlFilePath)
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

            XmlSerializer serializer = new XmlSerializer(typeof(List<Data>));

            using (FileStream stream = File.OpenWrite(XmlFilePath))
            {
                serializer.Serialize(stream, sortedData);
            }
        }
        private void LoadFromXml(string xmlFilePath)
        {
            listView.Items.Clear();
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

        private string EquationGenerator(double a, double b, double c)
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

        private void GetResult(object Data)
        {
            if (Data is QuadraticEquation qe)
            {
                double discriminant = Math.Pow(qe.B, 2) - 4 * qe.A * qe.C;
                bool isComplex = discriminant < 0;
                double discriminantSqrt = Math.Sqrt(Math.Abs(discriminant));
                double firstPart = (-qe.B) / (2 * qe.A);
                double secondPart = discriminantSqrt / (2 * qe.A);

                Thread.Sleep(1000);

                if (isComplex)
                {
                    quadraticResult.FirstValue = $"{Math.Round(firstPart, 2)} + {Math.Round(secondPart, 2)}i";
                    quadraticResult.SecondValue = $"{Math.Round(firstPart, 2)} - {Math.Round(secondPart, 2)}i";
                }
                else
                {
                    quadraticResult.FirstValue = (Math.Round(firstPart, 2) + Math.Round(secondPart, 2)).ToString();
                    quadraticResult.SecondValue = (Math.Round(firstPart, 2) - Math.Round(secondPart, 2)).ToString();
                }
            }
        }

        #endregion    
    }
}

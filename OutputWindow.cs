using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Textlow.MainWindow;

namespace Textlow
{
    public partial class OutputWindow : Form
    {
        MainWindow mainWindow;
        public string lastReceived = "";
        Dictionary<string, string> outputHistory = new Dictionary<string, string>();
        public OutputWindow(MainWindow mw)
        {
            InitializeComponent();
            mainWindow = mw;
            updateColors();
        }
       

        private Color _fcolor;

        public Color MainTextboxForecolor
        {
            get { return _fcolor; }
            set { _fcolor = value; outputTextBox.ForeColor = _fcolor; }
        }

        private Color _bcolor;

        public Color MainTextboxBackcolor
        {
            get { return _bcolor; }
            set { _bcolor = value; outputTextBox.BackColor = _bcolor; }
        }



        public void receiveData(string text, string operation)
        {
            DateTime now = DateTime.Now;
            string id = now.Year.ToString() + now.Month + now.Day + now.Hour + now.Minute + now.Second + now.Millisecond;
            string output = "<" + now.ToString("F") + ", " + operation + ", ID: " + id + ">\n" + text + "\n";
            outputTextBox.Text += output;
            lastReceived = text;
            outputHistory.Add(id, text);
        }

        private void sendToMainWindowButton_Click(object sender, EventArgs e)
        {
            if (outputHistory.ContainsKey(idTextBox.Text))
            {
                mainWindow.receiveDataFromOutput(outputHistory[idTextBox.Text], false);
            }
            else
            {
                mainWindow.receiveDataFromOutput(lastReceived, false);
            }
            
        }

        private void appendToMainWindowButton_Click(object sender, EventArgs e)
        {
            if (outputHistory.ContainsKey(idTextBox.Text))
            {
                mainWindow.receiveDataFromOutput(outputHistory[idTextBox.Text], true);
            }
            else
            {
                mainWindow.receiveDataFromOutput(lastReceived, true);
            }
            
        }

        public void updateColors()
        {
            outputTextBox.ForeColor = mainWindow.mainTextBox.BackColor;
            outputTextBox.BackColor = mainWindow.mainTextBox.ForeColor;
        }

        private void copyToClipboardButton_Click(object sender, EventArgs e)
        {
            if (outputHistory.ContainsKey(idTextBox.Text))
            {
                Clipboard.SetText(outputHistory[idTextBox.Text]);
            }                       
            else
            {
                Clipboard.SetText(lastReceived);
            }
            
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            outputTextBox.Text = "";
            lastReceived = "";
            outputHistory.Clear();
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            if (outputHistory.ContainsKey(idTextBox.Text))
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "Save file:";
                saveFileDialog.Filter = mainWindow.getExtension();
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                    streamWriter.Write(outputHistory[idTextBox.Text]);
                    streamWriter.Close();
                }
            }
            else
            {
                if (lastReceived != "")
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Title = "Save file:";
                    saveFileDialog.Filter = mainWindow.getExtension();
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                        streamWriter.Write(lastReceived);
                        streamWriter.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Last received output is empty");
                }
            }
                  
        }

        private void exportFullButton_Click(object sender, EventArgs e)
        {
            if (outputTextBox.Text != "")
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "Save file:";
                saveFileDialog.Filter = mainWindow.getExtension();
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                    streamWriter.Write(outputTextBox.Text);
                    streamWriter.Close();
                }
            }
            else
            {
                MessageBox.Show("Output is empty");
            }
        }
        private void OutputWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainWindow.Close();
            Application.Exit();
        }

        private void receiveTextButton_Click(object sender, EventArgs e)
        {
            receiveData(mainWindow.mainTextBox.Text, "Text received from main window");
        }

        private void outputInfo_Click(object sender, EventArgs e)
        {
            if (outputTextBox.Text != "")
            {
                string oText = "";
                if (outputHistory.ContainsKey(idTextBox.Text))
                {
                    oText = outputHistory[idTextBox.Text];
                }
                else
                {
                    oText = lastReceived;
                }
                string usedCharacters = $@"";
                foreach (char ch in oText)
                {
                    usedCharacters = usedCharacters + (usedCharacters.Contains(ch) ? "" : ch.ToString());
                }
                List<char> charList = usedCharacters.ToList();
                charList.Sort();
                usedCharacters = string.Join(" ", charList.ToArray());
                string result =
                    additionalFunctions.setDistance("Length: ", oText.Length.ToString(), 30) + "\n" +
                    additionalFunctions.setDistance("Length (without spaces): ", oText.Replace(" ", "").Replace("\n", "").Length.ToString(), 30) + "\n" +
                    additionalFunctions.setDistance("Lines: ", oText.Split('\n').Length.ToString(), 30) + "\n" +
                    additionalFunctions.setDistance("Is ASCII: ", oText.All(c => c < 128).ToString(), 30) + "\n"+
                    additionalFunctions.setDistance("Is upper: ", oText.All(Char.IsUpper).ToString(), 30) + "\n" +
                    additionalFunctions.setDistance("Is lower: ", oText.All(Char.IsLower).ToString(), 30) + "\n" +
                    additionalFunctions.setDistance("Is hash: ", additionalFunctions.isHash(oText), 30) + "\n" +
                    additionalFunctions.setDistance("String type: ", additionalFunctions.stringType(oText), 30) + "\n" +
                    "\n" +
                    ("Used characters: " + "\n" + usedCharacters.Replace("  ", "<space> ").Replace("\n", "<enter> ").Replace("\t", "<tab> ")).Replace("  ", " ");

                TextlowDialogResults.BetterMessageBoxOnlyOk(result);
            }
            else
            {
                MessageBox.Show("Output is empty");
            }
            
        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {
            if (outputHistory.ContainsKey(idTextBox.Text))
            {
                idTextBox.BackColor = Color.FromArgb(128, 255, 128);
            }
            else if (idTextBox.Text == "")
            {
                idTextBox.BackColor = SystemColors.Window;
            }
            else
            {
                idTextBox.BackColor = Color.FromArgb(255, 128, 128);
            }
        }
    }
}

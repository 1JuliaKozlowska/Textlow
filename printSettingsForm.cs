using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Textlow
{
    public partial class printSettingsForm : Form
    {
        Font selectedFont;
        MainWindow mw;
        public printSettingsForm(MainWindow mainWindow)
        {
            InitializeComponent();
            mw = mainWindow;
            selectedFont = Properties.Settings.Default.PrintFont;
            sameAsMainWindowCheckBox.Checked = Properties.Settings.Default.SamePrintFontAsMW;
            printFontButton.Enabled = !sameAsMainWindowCheckBox.Checked;
            Size tempSize = Properties.Settings.Default.DefaultPrintPaperSize;
            Point tempPoint = Properties.Settings.Default.PrintTextMargins;
            psWidthTextBox.Text = tempSize.Width.ToString();
            psHeightTextBox.Text = tempSize.Height.ToString();
            marginWidthTextBox.Text = tempPoint.X.ToString();
            marginHeightTextBox.Text = tempPoint.Y.ToString();
            resetButtonFont();
            sameAsMainWindowCheckBox.Text = "Use the same font as in the main window (" + mw.mainTextBox.Font.Name + ", " + mw.mainTextBox.Font.Size.ToString() + "pt)";
            comboBoxSizeReset();
        }
       

        private void resetButtonFont()
        {
            printFontButton.Text = selectedFont.Name + ", " + selectedFont.Size.ToString() + "pt";
        }

        private void comboBoxSizeReset()
        {
            if (psWidthTextBox.Text == "1240" && psHeightTextBox.Text == "1754")
            {
                paperTypeComboBox.Text = "A4 (150 PPI)";
            }
            else if (psWidthTextBox.Text == "874" && psHeightTextBox.Text == "1240")
            {
                paperTypeComboBox.Text = "A5 (150 PPI)";
            }
            else if (psWidthTextBox.Text == "1754" && psHeightTextBox.Text == "2480")
            {
                paperTypeComboBox.Text = "A3 (150 PPI)";
            }
            else
            {
                paperTypeComboBox.Text = "Custom";
            }
        }

        private void comboBoxMarginReset()
        {
            if (marginWidthTextBox.Text == "10" && marginHeightTextBox.Text == "10")
            {
                textMarginsComboBox.Text = "Minimal";
            }
            else if (marginWidthTextBox.Text == "50" && marginHeightTextBox.Text == "50")
            {
                textMarginsComboBox.Text = "Small";
            }
            else if (marginWidthTextBox.Text == "100" && marginHeightTextBox.Text == "100")
            {
                textMarginsComboBox.Text = "Normal";
            }
            else if (marginWidthTextBox.Text == "150" && marginHeightTextBox.Text == "150")
            {
                textMarginsComboBox.Text = "Big";
            }
            else
            {
                textMarginsComboBox.Text = "Custom";
            }
        }
        private void sameAsMainWindowCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            printFontButton.Enabled = !sameAsMainWindowCheckBox.Checked;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.PrintFont = selectedFont;
            Properties.Settings.Default.SamePrintFontAsMW = sameAsMainWindowCheckBox.Checked;
            Properties.Settings.Default.DefaultPrintPaperSize = new Size(int.Parse(psWidthTextBox.Text), int.Parse(psHeightTextBox.Text));
            Properties.Settings.Default.PrintTextMargins = new Point(int.Parse(marginWidthTextBox.Text), int.Parse(marginHeightTextBox.Text));
            Close();
        }

        private void printFontButton_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = selectedFont;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                selectedFont = fontDialog1.Font;                
            }
            resetButtonFont();
        }

        private void paperTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (paperTypeComboBox.Text == "A4 (150 PPI)")
            {
                psWidthTextBox.Text = "1240";
                psHeightTextBox.Text = "1754";
            }
            else if (paperTypeComboBox.Text == "A5 (150 PPI)")
            {
                psWidthTextBox.Text = "874";
                psHeightTextBox.Text = "1240";
            }
            else if (paperTypeComboBox.Text == "A3 (150 PPI)")
            {
                psWidthTextBox.Text = "1754";
                psHeightTextBox.Text = "2480";
            }
        }

        private void psWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            comboBoxSizeReset();
        }

        private void psHeightTextBox_TextChanged(object sender, EventArgs e)
        {
            comboBoxSizeReset();
        }

        private void textMarginsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textMarginsComboBox.Text == "Minimal")
            {
                marginWidthTextBox.Text = "10";
                marginHeightTextBox.Text = "10";
            }
            else if (textMarginsComboBox.Text == "Small")
            {
                marginWidthTextBox.Text = "50";
                marginHeightTextBox.Text = "50";
            }
            else if (textMarginsComboBox.Text == "Normal")
            {
                marginWidthTextBox.Text = "100";
                marginHeightTextBox.Text = "100";
            }
            else if (textMarginsComboBox.Text == "Big")
            {
                marginWidthTextBox.Text = "150";
                marginHeightTextBox.Text = "150";
            }
        }

        private void marginWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            comboBoxMarginReset();
        }

        private void marginHeightTextBox_TextChanged(object sender, EventArgs e)
        {
            comboBoxMarginReset();
        }

       
    }
}

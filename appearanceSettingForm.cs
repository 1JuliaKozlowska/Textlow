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
    public partial class appearanceSettingForm : Form
    {
        MainWindow mw;
        bool onstart;
        public appearanceSettingForm(MainWindow mainWindow)
        {
            mw = mainWindow;
            InitializeComponent();
            onstart = true;
            previewLabel.ForeColor = mw.mainTextBox.ForeColor;
            previewLabel.BackColor = mw.mainTextBox.BackColor;
            previewLabel.Font = mw.mainTextBox.Font;
            switch (Properties.Settings.Default.ToolbarPosition)
            {
                case 1:
                    toolBarPositionComboBox.Text = "Top";
                    break;
                case 2:
                    toolBarPositionComboBox.Text = "Bottom";
                    break;
                case 3:
                    toolBarPositionComboBox.Text = "Left";
                    break;
                case 4:
                    toolBarPositionComboBox.Text = "Right";
                    break;
                default:
                    break;
            }
            if (previewLabel.ForeColor == Color.Yellow && previewLabel.BackColor == Color.Black)
            {
                editorColorsComboBox.Text = "Textlow";
            }
            else if(previewLabel.ForeColor == Color.Black && previewLabel.BackColor == Color.White)
            {
                editorColorsComboBox.Text = "Classic";
            }
            else if(previewLabel.ForeColor == Color.White && previewLabel.BackColor == Color.Black)
            {
                editorColorsComboBox.Text = "Classic (reversed colors)";
            }
            else if(previewLabel.ForeColor == Color.FromArgb(188, 194, 205) && previewLabel.BackColor == Color.FromArgb(40, 42, 54))
            {
                editorColorsComboBox.Text = "Dracula";
            }
            else if (previewLabel.ForeColor == Color.White && previewLabel.BackColor == Color.DarkRed)
            {
                editorColorsComboBox.Text = "Candy cane";
            }
            else
            {
                editorColorsComboBox.Text = "Custom";
            }
            onstart = false;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.MainTextboxFont = previewLabel.Font;
            Properties.Settings.Default.MainTextboxForecolor = previewLabel.ForeColor;
            Properties.Settings.Default.MainTextboxBackcolor = previewLabel.BackColor;
            switch (toolBarPositionComboBox.Text)
            {
                case "Top":
                    Properties.Settings.Default.ToolbarPosition = 1;
                    break;
                case "Bottom":
                    Properties.Settings.Default.ToolbarPosition = 2;
                    break;
                case "Right":
                    Properties.Settings.Default.ToolbarPosition = 4;
                    break;
                case "Left":
                    Properties.Settings.Default.ToolbarPosition = 3;
                    break;
                default:
                    break;
            }
            mw.ResetAppearance();
            Close();
        }

        private void editorColorsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (editorColorsComboBox.Text)
            {
                case "Textlow":
                    previewLabel.ForeColor = Color.Yellow;
                    previewLabel.BackColor = Color.Black;
                    break;
                case "Classic":
                    previewLabel.ForeColor = Color.Black;
                    previewLabel.BackColor = Color.White;
                    break;
                case "Classic (reversed colors)":
                    previewLabel.ForeColor = Color.White;
                    previewLabel.BackColor = Color.Black;
                    break;
                case "Dracula":
                    previewLabel.ForeColor = Color.FromArgb(188, 194, 205);
                    previewLabel.BackColor = Color.FromArgb(40, 42, 54); 
                    break;
                case "Candy cane":
                    previewLabel.ForeColor = Color.White;
                    previewLabel.BackColor = Color.DarkRed;
                    break;
                case "Custom":
                    if (!onstart)
                    {
                        ColorSelectForm colorSelectForm = new ColorSelectForm(this);
                        colorSelectForm.Show();
                    }                   
                    break;
                default:
                    break;
                    
            }
        }

        private void changeFontButton_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = previewLabel.Font;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                previewLabel.Font = fontDialog1.Font;
            }
        }

        

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        private void restoreButton_Click(object sender, EventArgs e)
        {
            editorColorsComboBox.SelectedIndex = 0;
            toolBarPositionComboBox.SelectedIndex = 0;
            previewLabel.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
        }
    }
}

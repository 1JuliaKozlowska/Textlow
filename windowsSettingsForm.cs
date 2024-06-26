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
    public partial class windowsSettingsForm : Form
    {
        MainWindow mw;
        public const string adminKey = "DefaultAdminKey";
        public windowsSettingsForm(MainWindow mainWindow)
        {
            InitializeComponent();
            mw = mainWindow;
            keepWindowsPostitionCheckBox.Checked = Properties.Settings.Default.KeepWindowsPosAndSize;
            rememberOutputHiddenShownCheckBox.Checked = Properties.Settings.Default.RememberOutputShownHidden;
            showOutputInTaskBarCheckBox.Checked = Properties.Settings.Default.ShowOutputInTaskBar;
            keepOutputAboveCheckBox.Checked = mw.outputWindow.TopMost;
            askToSaveCheckBox.Checked = Properties.Settings.Default.AskToSave;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.OutputMostTop = keepOutputAboveCheckBox.Checked;
            Properties.Settings.Default.RememberOutputShownHidden = rememberOutputHiddenShownCheckBox.Checked;
            Properties.Settings.Default.KeepWindowsPosAndSize = keepWindowsPostitionCheckBox.Checked;

            Properties.Settings.Default.MainWindowMaximized = mw.WindowState == FormWindowState.Maximized;

            if (mw.WindowState != FormWindowState.Maximized)
            {
                Properties.Settings.Default.MainWindowPos = mw.Location;
                Properties.Settings.Default.MainWindowSize = mw.Size;
                Properties.Settings.Default.OutputWindowPos = mw.outputWindow.Location;
                Properties.Settings.Default.OutputWindowSize = mw.outputWindow.Size;
            }
            
           
            Properties.Settings.Default.OutputHidden = mw.hideOutputWindowButton.Checked;

            Properties.Settings.Default.ShowOutputInTaskBar = showOutputInTaskBarCheckBox.Checked;
            Properties.Settings.Default.AskToSave = askToSaveCheckBox.Checked;

            mw.ResetWindowsSettings();
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

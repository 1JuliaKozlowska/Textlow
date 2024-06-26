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
    public partial class extensionsManagementForm : Form
    {
        public extensionsManagementForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string extension;
            if (descriptionTextBox.Text != "" && extensionTextBox.Text != "")
            {
                extension = "|" + descriptionTextBox.Text.Replace("|", "") + " (*." + extensionTextBox.Text.Replace("|", "").Replace("*", "").Replace(" ", "") + ")|*." + extensionTextBox.Text.Replace("|", "").Replace("*", "").Replace(" ", "");
                Properties.Settings.Default.ExtensionsList.Add(extension);
                resetExtensionDisplay();
            }
            else
            {
                MessageBox.Show("Please enter description and extension");
            }
        }

        public void resetExtensionDisplay()
        {
            extensionsLayoutPanel.Controls.Clear();
            ExtensionDisplayControl[] extensionDisplayControls = new ExtensionDisplayControl[Properties.Settings.Default.ExtensionsList.Count];
            for (int i = 0; i < extensionDisplayControls.Length; i++)
            {
                extensionDisplayControls[i] = new ExtensionDisplayControl(this);
                extensionDisplayControls[i].FullName = Properties.Settings.Default.ExtensionsList[i];
            }
            ExtensionDisplayControl top = new ExtensionDisplayControl(this);
            top.hideButton();
            extensionsLayoutPanel.Controls.Add(top);
            foreach (ExtensionDisplayControl control in extensionDisplayControls)
            {
                extensionsLayoutPanel.Controls.Add(control);
            }
        }

        private void extensionsManagementForm_Load(object sender, EventArgs e)
        {
            resetExtensionDisplay();
        }
    }
}

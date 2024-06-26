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
    public partial class ExtensionDisplayControl : UserControl
    {
        extensionsManagementForm Emf;
        public ExtensionDisplayControl(extensionsManagementForm emf)
        {
            InitializeComponent();
            Emf = emf;
        }

        private string _fullName;

        public string FullName
        {
            get { return _fullName; }
            set { 
                _fullName = value;
                string[] tab = _fullName.Split('|');
                descriptionLabel.Text = tab[1].Replace("(" + tab[2] + ")", "");
                extensionLabel.Text = tab[2].Replace("*", "");
            }
        }

        public void hideButton()
        {
            removeButton.Visible = false;
            extensionLabel.Text = "Extension";
            descriptionLabel.Text = "Description";
            extensionLabel.TextAlign = ContentAlignment.MiddleCenter;
            descriptionLabel.TextAlign = ContentAlignment.MiddleCenter;
            extensionLabel.BorderStyle = BorderStyle.None;
            descriptionLabel.BorderStyle = BorderStyle.None;
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ExtensionsList.Remove(_fullName);
            Emf.resetExtensionDisplay();
        }
    }
}

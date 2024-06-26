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
    public partial class ColorSelectForm : Form
    {
        appearanceSettingForm asf;
        public ColorSelectForm(appearanceSettingForm appearanceSetting)
        {
            asf = appearanceSetting;
            InitializeComponent();
            fcPanel.BackColor = appearanceSetting.previewLabel.ForeColor;
            bcPanel.BackColor = appearanceSetting.previewLabel.BackColor;
        }

        private void fcButton_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = fcPanel.BackColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                fcPanel.BackColor = colorDialog1.Color;
            }
        }

        private void bcButton_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = bcPanel.BackColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                bcPanel.BackColor = colorDialog1.Color;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            asf.previewLabel.ForeColor = fcPanel.BackColor;
            asf.previewLabel.BackColor = bcPanel.BackColor;
            Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Textlow
{
    public static class TextlowDialogResults
    {
        public static DialogResult InputBox(string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = "Input";
            label.Text = promptText;
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            textBox.AcceptsTab = true;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }

        public static DialogResult DoubleInputBox(string firstText, string secondText, ref string firstValue, ref string secondValue)
        {
            Form form = new Form();
            Label firstLabel = new Label();
            Label secondLabel = new Label();
            TextBox firstTextBox = new TextBox();
            TextBox secondTextBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = "Input";
            firstLabel.Text = firstText;
            secondLabel.Text = secondText;
            firstTextBox.Text = firstValue;
            secondTextBox.Text = secondValue;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            firstLabel.SetBounds(9, 10, 372, 13);
            firstTextBox.SetBounds(12, 26, 372, 20);
            secondLabel.SetBounds(9, 49, 372, 13);
            secondTextBox.SetBounds(12, 65, 372, 20);
            buttonOk.SetBounds(228, 90, 75, 23);
            buttonCancel.SetBounds(309, 90, 75, 23);

            firstLabel.AutoSize = true;
            firstTextBox.Anchor = firstTextBox.Anchor | AnchorStyles.Right;
            secondLabel.AutoSize = true;
            secondTextBox.Anchor = secondTextBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 120);
            form.Controls.AddRange(new Control[] { firstLabel, firstTextBox, secondLabel, secondTextBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, firstLabel.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            firstTextBox.AcceptsTab = true;
            secondTextBox.AcceptsTab = true;

            DialogResult dialogResult = form.ShowDialog();
            firstValue = firstTextBox.Text;
            secondValue = secondTextBox.Text;
            return dialogResult;
        }
        
        public static DialogResult DoubleInputBoxWithCheckBox(string firstText, string secondText, string checkBoxText, ref string firstValue, ref string secondValue, ref bool checkBoxChecked)
        {
            Form form = new Form();
            Label firstLabel = new Label();
            Label secondLabel = new Label();
            TextBox firstTextBox = new TextBox();
            TextBox secondTextBox = new TextBox();
            CheckBox checkBox = new CheckBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();         

            form.Text = "Input";
            firstLabel.Text = firstText;
            secondLabel.Text = secondText;
            checkBox.Text = checkBoxText;
            firstTextBox.Text = firstValue;
            secondTextBox.Text = secondValue;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            firstLabel.SetBounds(9, 10, 372, 13);
            firstTextBox.SetBounds(12, 26, 372, 20);
            secondLabel.SetBounds(9, 49, 372, 13);
            secondTextBox.SetBounds(12, 65, 372, 20);
            checkBox.SetBounds(12, 88, 372, 13);
            buttonOk.SetBounds(228, 103, 75, 23);
            buttonCancel.SetBounds(309, 103, 75, 23);

            firstLabel.AutoSize = true;
            firstTextBox.Anchor = firstTextBox.Anchor | AnchorStyles.Right;
            secondLabel.AutoSize = true;
            secondTextBox.Anchor = secondTextBox.Anchor | AnchorStyles.Right;
            checkBox.AutoSize = true;
            checkBox.Anchor = checkBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 133);
            form.Controls.AddRange(new Control[] { firstLabel, firstTextBox, secondLabel, secondTextBox, checkBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, firstLabel.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            firstTextBox.AcceptsTab = true;
            secondTextBox.AcceptsTab = true;

            DialogResult dialogResult = form.ShowDialog();
            firstValue = firstTextBox.Text;
            secondValue = secondTextBox.Text;
            checkBoxChecked = checkBox.Checked;
            return dialogResult;
        }

        public static DialogResult BetterMessageBoxOnlyOk(string promptText)
        {
            Form form = new Form();
            Label label = new Label();
            Button buttonOk = new Button();

            form.Text = "Result";
            label.Text = promptText;

            buttonOk.Text = "Close";
            buttonOk.DialogResult = DialogResult.OK;

            label.AutoSize = true;
            label.MaximumSize = new Size(400, 1000);
            label.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;            

            
            form.Controls.AddRange(new Control[] { label, buttonOk, });
            label.Location = new Point(9, 20);            
            form.ClientSize = new Size(396, 70 + label.Size.Height);
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            buttonOk.Location = new Point(9, label.Size.Height + 40);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;

            DialogResult dialogResult = form.ShowDialog();
            return dialogResult;
        }
    }
}

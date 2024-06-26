
namespace Textlow
{
    partial class printSettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.printFontButton = new System.Windows.Forms.Button();
            this.psWidthTextBox = new System.Windows.Forms.MaskedTextBox();
            this.psHeightTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sameAsMainWindowCheckBox = new System.Windows.Forms.CheckBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.paperTypeComboBox = new System.Windows.Forms.ComboBox();
            this.marginWidthTextBox = new System.Windows.Forms.MaskedTextBox();
            this.marginHeightTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textMarginsComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Print font: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Paper size: ";
            // 
            // printFontButton
            // 
            this.printFontButton.Location = new System.Drawing.Point(82, 6);
            this.printFontButton.Name = "printFontButton";
            this.printFontButton.Size = new System.Drawing.Size(270, 23);
            this.printFontButton.TabIndex = 2;
            this.printFontButton.Text = "font";
            this.printFontButton.UseVisualStyleBackColor = true;
            this.printFontButton.Click += new System.EventHandler(this.printFontButton_Click);
            // 
            // psWidthTextBox
            // 
            this.psWidthTextBox.Location = new System.Drawing.Point(170, 64);
            this.psWidthTextBox.Mask = "00000";
            this.psWidthTextBox.Name = "psWidthTextBox";
            this.psWidthTextBox.PromptChar = ' ';
            this.psWidthTextBox.Size = new System.Drawing.Size(60, 20);
            this.psWidthTextBox.TabIndex = 6;
            this.psWidthTextBox.ValidatingType = typeof(int);
            this.psWidthTextBox.TextChanged += new System.EventHandler(this.psWidthTextBox_TextChanged);
            // 
            // psHeightTextBox
            // 
            this.psHeightTextBox.Location = new System.Drawing.Point(292, 64);
            this.psHeightTextBox.Mask = "00000";
            this.psHeightTextBox.Name = "psHeightTextBox";
            this.psHeightTextBox.PromptChar = ' ';
            this.psHeightTextBox.Size = new System.Drawing.Size(60, 20);
            this.psHeightTextBox.TabIndex = 7;
            this.psHeightTextBox.ValidatingType = typeof(int);
            this.psHeightTextBox.TextChanged += new System.EventHandler(this.psHeightTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(119, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Width:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(236, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Height:";
            // 
            // sameAsMainWindowCheckBox
            // 
            this.sameAsMainWindowCheckBox.AutoSize = true;
            this.sameAsMainWindowCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sameAsMainWindowCheckBox.Location = new System.Drawing.Point(15, 38);
            this.sameAsMainWindowCheckBox.Name = "sameAsMainWindowCheckBox";
            this.sameAsMainWindowCheckBox.Size = new System.Drawing.Size(219, 17);
            this.sameAsMainWindowCheckBox.TabIndex = 10;
            this.sameAsMainWindowCheckBox.Text = "Use the same font as in the main window";
            this.sameAsMainWindowCheckBox.UseVisualStyleBackColor = true;
            this.sameAsMainWindowCheckBox.CheckedChanged += new System.EventHandler(this.sameAsMainWindowCheckBox_CheckedChanged);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(12, 366);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 23);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(118, 366);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 23);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(12, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Set paper size:";
            // 
            // paperTypeComboBox
            // 
            this.paperTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paperTypeComboBox.FormattingEnabled = true;
            this.paperTypeComboBox.Items.AddRange(new object[] {
            "A3 (150 PPI)",
            "A4 (150 PPI)",
            "A5 (150 PPI)",
            "Custom"});
            this.paperTypeComboBox.Location = new System.Drawing.Point(122, 90);
            this.paperTypeComboBox.Name = "paperTypeComboBox";
            this.paperTypeComboBox.Size = new System.Drawing.Size(230, 21);
            this.paperTypeComboBox.TabIndex = 14;
            this.paperTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.paperTypeComboBox_SelectedIndexChanged);
            // 
            // marginWidthTextBox
            // 
            this.marginWidthTextBox.Location = new System.Drawing.Point(196, 117);
            this.marginWidthTextBox.Mask = "000";
            this.marginWidthTextBox.Name = "marginWidthTextBox";
            this.marginWidthTextBox.PromptChar = ' ';
            this.marginWidthTextBox.Size = new System.Drawing.Size(45, 20);
            this.marginWidthTextBox.TabIndex = 16;
            this.marginWidthTextBox.TextChanged += new System.EventHandler(this.marginWidthTextBox_TextChanged);
            // 
            // marginHeightTextBox
            // 
            this.marginHeightTextBox.Location = new System.Drawing.Point(307, 117);
            this.marginHeightTextBox.Mask = "000";
            this.marginHeightTextBox.Name = "marginHeightTextBox";
            this.marginHeightTextBox.PromptChar = ' ';
            this.marginHeightTextBox.Size = new System.Drawing.Size(45, 20);
            this.marginHeightTextBox.TabIndex = 17;
            this.marginHeightTextBox.ValidatingType = typeof(int);
            this.marginHeightTextBox.TextChanged += new System.EventHandler(this.marginHeightTextBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(119, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Horizontal:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(245, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Vertical:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(12, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Text margins: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(12, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "Set text margins:";
            // 
            // textMarginsComboBox
            // 
            this.textMarginsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.textMarginsComboBox.FormattingEnabled = true;
            this.textMarginsComboBox.Items.AddRange(new object[] {
            "Minimal",
            "Small",
            "Normal",
            "Big",
            "Custom"});
            this.textMarginsComboBox.Location = new System.Drawing.Point(122, 143);
            this.textMarginsComboBox.Name = "textMarginsComboBox";
            this.textMarginsComboBox.Size = new System.Drawing.Size(230, 21);
            this.textMarginsComboBox.TabIndex = 22;
            this.textMarginsComboBox.SelectedIndexChanged += new System.EventHandler(this.textMarginsComboBox_SelectedIndexChanged);
            // 
            // printSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 401);
            this.ControlBox = false;
            this.Controls.Add(this.textMarginsComboBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.marginHeightTextBox);
            this.Controls.Add(this.marginWidthTextBox);
            this.Controls.Add(this.paperTypeComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.sameAsMainWindowCheckBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.psHeightTextBox);
            this.Controls.Add(this.psWidthTextBox);
            this.Controls.Add(this.printFontButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "printSettingsForm";
            this.Text = "Print settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button printFontButton;
        private System.Windows.Forms.MaskedTextBox psWidthTextBox;
        private System.Windows.Forms.MaskedTextBox psHeightTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox sameAsMainWindowCheckBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox paperTypeComboBox;
        private System.Windows.Forms.MaskedTextBox marginWidthTextBox;
        private System.Windows.Forms.MaskedTextBox marginHeightTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox textMarginsComboBox;
    }
}
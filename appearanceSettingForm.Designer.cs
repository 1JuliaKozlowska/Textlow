
namespace Textlow
{
    partial class appearanceSettingForm
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
            this.toolBarPositionComboBox = new System.Windows.Forms.ComboBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.editorColorsComboBox = new System.Windows.Forms.ComboBox();
            this.changeFontButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.previewLabel = new System.Windows.Forms.TextBox();
            this.restoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tool bar position:";
            // 
            // toolBarPositionComboBox
            // 
            this.toolBarPositionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolBarPositionComboBox.FormattingEnabled = true;
            this.toolBarPositionComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.toolBarPositionComboBox.Items.AddRange(new object[] {
            "Top",
            "Bottom",
            "Right",
            "Left"});
            this.toolBarPositionComboBox.Location = new System.Drawing.Point(231, 8);
            this.toolBarPositionComboBox.Name = "toolBarPositionComboBox";
            this.toolBarPositionComboBox.Size = new System.Drawing.Size(121, 21);
            this.toolBarPositionComboBox.TabIndex = 1;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(12, 366);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(100, 23);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(118, 366);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Editor colors:";
            // 
            // editorColorsComboBox
            // 
            this.editorColorsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.editorColorsComboBox.FormattingEnabled = true;
            this.editorColorsComboBox.Items.AddRange(new object[] {
            "Textlow",
            "Classic",
            "Classic (reversed colors)",
            "Dracula",
            "Candy cane",
            "Custom"});
            this.editorColorsComboBox.Location = new System.Drawing.Point(231, 35);
            this.editorColorsComboBox.Name = "editorColorsComboBox";
            this.editorColorsComboBox.Size = new System.Drawing.Size(121, 21);
            this.editorColorsComboBox.TabIndex = 5;
            this.editorColorsComboBox.SelectedIndexChanged += new System.EventHandler(this.editorColorsComboBox_SelectedIndexChanged);
            // 
            // changeFontButton
            // 
            this.changeFontButton.Location = new System.Drawing.Point(231, 62);
            this.changeFontButton.Name = "changeFontButton";
            this.changeFontButton.Size = new System.Drawing.Size(121, 21);
            this.changeFontButton.TabIndex = 6;
            this.changeFontButton.Text = "Change Font";
            this.changeFontButton.UseVisualStyleBackColor = true;
            this.changeFontButton.Click += new System.EventHandler(this.changeFontButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Font:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Preview:";
            // 
            // previewLabel
            // 
            this.previewLabel.Location = new System.Drawing.Point(15, 118);
            this.previewLabel.Multiline = true;
            this.previewLabel.Name = "previewLabel";
            this.previewLabel.Size = new System.Drawing.Size(337, 229);
            this.previewLabel.TabIndex = 11;
            this.previewLabel.Text = "The quick brown fox jumps over the lazy dog";
            // 
            // restoreButton
            // 
            this.restoreButton.Location = new System.Drawing.Point(224, 366);
            this.restoreButton.Name = "restoreButton";
            this.restoreButton.Size = new System.Drawing.Size(100, 23);
            this.restoreButton.TabIndex = 12;
            this.restoreButton.Text = "Restore Defaults";
            this.restoreButton.UseVisualStyleBackColor = true;
            this.restoreButton.Click += new System.EventHandler(this.restoreButton_Click);
            // 
            // appearanceSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 401);
            this.ControlBox = false;
            this.Controls.Add(this.restoreButton);
            this.Controls.Add(this.previewLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.changeFontButton);
            this.Controls.Add(this.editorColorsComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.toolBarPositionComboBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "appearanceSettingForm";
            this.ShowInTaskbar = false;
            this.Text = "Appearance Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox toolBarPositionComboBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox editorColorsComboBox;
        private System.Windows.Forms.Button changeFontButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox previewLabel;
        private System.Windows.Forms.Button restoreButton;
    }
}
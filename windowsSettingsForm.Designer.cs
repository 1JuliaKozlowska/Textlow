
namespace Textlow
{
    partial class windowsSettingsForm
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
            this.keepWindowsPostitionCheckBox = new System.Windows.Forms.CheckBox();
            this.rememberOutputHiddenShownCheckBox = new System.Windows.Forms.CheckBox();
            this.keepOutputAboveCheckBox = new System.Windows.Forms.CheckBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.showOutputInTaskBarCheckBox = new System.Windows.Forms.CheckBox();
            this.askToSaveCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // keepWindowsPostitionCheckBox
            // 
            this.keepWindowsPostitionCheckBox.AutoSize = true;
            this.keepWindowsPostitionCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.keepWindowsPostitionCheckBox.Location = new System.Drawing.Point(12, 12);
            this.keepWindowsPostitionCheckBox.Name = "keepWindowsPostitionCheckBox";
            this.keepWindowsPostitionCheckBox.Size = new System.Drawing.Size(341, 20);
            this.keepWindowsPostitionCheckBox.TabIndex = 0;
            this.keepWindowsPostitionCheckBox.Text = "Remember windows positions and sizes after closing";
            this.keepWindowsPostitionCheckBox.UseVisualStyleBackColor = true;
            // 
            // rememberOutputHiddenShownCheckBox
            // 
            this.rememberOutputHiddenShownCheckBox.AutoSize = true;
            this.rememberOutputHiddenShownCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rememberOutputHiddenShownCheckBox.Location = new System.Drawing.Point(12, 38);
            this.rememberOutputHiddenShownCheckBox.Name = "rememberOutputHiddenShownCheckBox";
            this.rememberOutputHiddenShownCheckBox.Size = new System.Drawing.Size(343, 20);
            this.rememberOutputHiddenShownCheckBox.TabIndex = 1;
            this.rememberOutputHiddenShownCheckBox.Text = "Remember whether output window is shown or hidden";
            this.rememberOutputHiddenShownCheckBox.UseVisualStyleBackColor = true;
            // 
            // keepOutputAboveCheckBox
            // 
            this.keepOutputAboveCheckBox.AutoSize = true;
            this.keepOutputAboveCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.keepOutputAboveCheckBox.Location = new System.Drawing.Point(12, 64);
            this.keepOutputAboveCheckBox.Name = "keepOutputAboveCheckBox";
            this.keepOutputAboveCheckBox.Size = new System.Drawing.Size(232, 20);
            this.keepOutputAboveCheckBox.TabIndex = 2;
            this.keepOutputAboveCheckBox.Text = "Always keep output window above";
            this.keepOutputAboveCheckBox.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(12, 366);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(100, 23);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(118, 366);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // showOutputInTaskBarCheckBox
            // 
            this.showOutputInTaskBarCheckBox.AutoSize = true;
            this.showOutputInTaskBarCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.showOutputInTaskBarCheckBox.Location = new System.Drawing.Point(12, 90);
            this.showOutputInTaskBarCheckBox.Name = "showOutputInTaskBarCheckBox";
            this.showOutputInTaskBarCheckBox.Size = new System.Drawing.Size(210, 20);
            this.showOutputInTaskBarCheckBox.TabIndex = 5;
            this.showOutputInTaskBarCheckBox.Text = "Show output window in task bar";
            this.showOutputInTaskBarCheckBox.UseVisualStyleBackColor = true;
            // 
            // askToSaveCheckBox
            // 
            this.askToSaveCheckBox.AutoSize = true;
            this.askToSaveCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.askToSaveCheckBox.Location = new System.Drawing.Point(12, 116);
            this.askToSaveCheckBox.Name = "askToSaveCheckBox";
            this.askToSaveCheckBox.Size = new System.Drawing.Size(185, 20);
            this.askToSaveCheckBox.TabIndex = 6;
            this.askToSaveCheckBox.Text = "Ask to save before closing";
            this.askToSaveCheckBox.UseVisualStyleBackColor = true;
            // 
            // windowsSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 401);
            this.ControlBox = false;
            this.Controls.Add(this.askToSaveCheckBox);
            this.Controls.Add(this.showOutputInTaskBarCheckBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.keepOutputAboveCheckBox);
            this.Controls.Add(this.rememberOutputHiddenShownCheckBox);
            this.Controls.Add(this.keepWindowsPostitionCheckBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "windowsSettingsForm";
            this.Text = "Windows Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox keepWindowsPostitionCheckBox;
        private System.Windows.Forms.CheckBox rememberOutputHiddenShownCheckBox;
        private System.Windows.Forms.CheckBox keepOutputAboveCheckBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.CheckBox showOutputInTaskBarCheckBox;
        private System.Windows.Forms.CheckBox askToSaveCheckBox;
    }
}
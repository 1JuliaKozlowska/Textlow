
namespace Textlow
{
    partial class ColorSelectForm
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
            this.fcPanel = new System.Windows.Forms.Panel();
            this.bcPanel = new System.Windows.Forms.Panel();
            this.fcButton = new System.Windows.Forms.Button();
            this.bcButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // fcPanel
            // 
            this.fcPanel.Location = new System.Drawing.Point(193, 12);
            this.fcPanel.Name = "fcPanel";
            this.fcPanel.Size = new System.Drawing.Size(100, 30);
            this.fcPanel.TabIndex = 2;
            // 
            // bcPanel
            // 
            this.bcPanel.Location = new System.Drawing.Point(193, 48);
            this.bcPanel.Name = "bcPanel";
            this.bcPanel.Size = new System.Drawing.Size(100, 30);
            this.bcPanel.TabIndex = 3;
            // 
            // fcButton
            // 
            this.fcButton.Location = new System.Drawing.Point(12, 12);
            this.fcButton.Name = "fcButton";
            this.fcButton.Size = new System.Drawing.Size(175, 30);
            this.fcButton.TabIndex = 4;
            this.fcButton.Text = "Change Forecolor";
            this.fcButton.UseVisualStyleBackColor = true;
            this.fcButton.Click += new System.EventHandler(this.fcButton_Click);
            // 
            // bcButton
            // 
            this.bcButton.Location = new System.Drawing.Point(12, 48);
            this.bcButton.Name = "bcButton";
            this.bcButton.Size = new System.Drawing.Size(175, 30);
            this.bcButton.TabIndex = 5;
            this.bcButton.Text = "Change Backcolor";
            this.bcButton.UseVisualStyleBackColor = true;
            this.bcButton.Click += new System.EventHandler(this.bcButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(12, 84);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(281, 35);
            this.okButton.TabIndex = 6;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // ColorSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 131);
            this.ControlBox = false;
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.bcButton);
            this.Controls.Add(this.fcButton);
            this.Controls.Add(this.bcPanel);
            this.Controls.Add(this.fcPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ColorSelectForm";
            this.ShowInTaskbar = false;
            this.Text = "Select Color";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel fcPanel;
        private System.Windows.Forms.Panel bcPanel;
        private System.Windows.Forms.Button fcButton;
        private System.Windows.Forms.Button bcButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}
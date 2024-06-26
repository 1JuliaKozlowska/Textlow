
namespace Textlow
{
    partial class OutputWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OutputWindow));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.exportButton = new System.Windows.Forms.ToolStripButton();
            this.exportFullButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.receiveTextButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.sendToMainWindowButton = new System.Windows.Forms.ToolStripButton();
            this.appendToMainWindowButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.copyToClipboardButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.idTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.outputInfo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.clearButton = new System.Windows.Forms.ToolStripButton();
            this.outputTextBox = new System.Windows.Forms.RichTextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportButton,
            this.exportFullButton,
            this.toolStripSeparator4,
            this.receiveTextButton,
            this.toolStripSeparator3,
            this.sendToMainWindowButton,
            this.appendToMainWindowButton,
            this.toolStripSeparator1,
            this.copyToClipboardButton,
            this.toolStripSeparator2,
            this.idTextBox,
            this.outputInfo,
            this.toolStripSeparator5,
            this.clearButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(534, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // exportButton
            // 
            this.exportButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.exportButton.Image = ((System.Drawing.Image)(resources.GetObject("exportButton.Image")));
            this.exportButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(23, 22);
            this.exportButton.Text = "Export output";
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // exportFullButton
            // 
            this.exportFullButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.exportFullButton.Image = ((System.Drawing.Image)(resources.GetObject("exportFullButton.Image")));
            this.exportFullButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exportFullButton.Name = "exportFullButton";
            this.exportFullButton.Size = new System.Drawing.Size(23, 22);
            this.exportFullButton.Text = "Export full output";
            this.exportFullButton.Click += new System.EventHandler(this.exportFullButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // receiveTextButton
            // 
            this.receiveTextButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.receiveTextButton.Image = ((System.Drawing.Image)(resources.GetObject("receiveTextButton.Image")));
            this.receiveTextButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.receiveTextButton.Name = "receiveTextButton";
            this.receiveTextButton.Size = new System.Drawing.Size(23, 22);
            this.receiveTextButton.Text = "Receive text from main window";
            this.receiveTextButton.Click += new System.EventHandler(this.receiveTextButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // sendToMainWindowButton
            // 
            this.sendToMainWindowButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sendToMainWindowButton.Image = ((System.Drawing.Image)(resources.GetObject("sendToMainWindowButton.Image")));
            this.sendToMainWindowButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sendToMainWindowButton.Name = "sendToMainWindowButton";
            this.sendToMainWindowButton.Size = new System.Drawing.Size(23, 22);
            this.sendToMainWindowButton.Text = "Send to main window";
            this.sendToMainWindowButton.Click += new System.EventHandler(this.sendToMainWindowButton_Click);
            // 
            // appendToMainWindowButton
            // 
            this.appendToMainWindowButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.appendToMainWindowButton.Image = ((System.Drawing.Image)(resources.GetObject("appendToMainWindowButton.Image")));
            this.appendToMainWindowButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.appendToMainWindowButton.Name = "appendToMainWindowButton";
            this.appendToMainWindowButton.Size = new System.Drawing.Size(23, 22);
            this.appendToMainWindowButton.Text = "Append to main window";
            this.appendToMainWindowButton.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.appendToMainWindowButton.Click += new System.EventHandler(this.appendToMainWindowButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // copyToClipboardButton
            // 
            this.copyToClipboardButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToClipboardButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToClipboardButton.Image")));
            this.copyToClipboardButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToClipboardButton.Name = "copyToClipboardButton";
            this.copyToClipboardButton.Size = new System.Drawing.Size(23, 22);
            this.copyToClipboardButton.Text = "Copy to clipboard";
            this.copyToClipboardButton.Click += new System.EventHandler(this.copyToClipboardButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // idTextBox
            // 
            this.idTextBox.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.idTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.idTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.idTextBox.ForeColor = System.Drawing.Color.Black;
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.idTextBox.Size = new System.Drawing.Size(115, 25);
            this.idTextBox.Tag = "";
            this.idTextBox.ToolTipText = "The operations concern the last output or output with the ID entered here";
            this.idTextBox.TextChanged += new System.EventHandler(this.idTextBox_TextChanged);
            // 
            // outputInfo
            // 
            this.outputInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.outputInfo.Image = ((System.Drawing.Image)(resources.GetObject("outputInfo.Image")));
            this.outputInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.outputInfo.Name = "outputInfo";
            this.outputInfo.Size = new System.Drawing.Size(23, 22);
            this.outputInfo.Text = "Output info";
            this.outputInfo.Click += new System.EventHandler(this.outputInfo_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // clearButton
            // 
            this.clearButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clearButton.Image = ((System.Drawing.Image)(resources.GetObject("clearButton.Image")));
            this.clearButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(23, 22);
            this.clearButton.Text = "Clear";
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // outputTextBox
            // 
            this.outputTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.outputTextBox.BackColor = System.Drawing.Color.Yellow;
            this.outputTextBox.CausesValidation = false;
            this.outputTextBox.DetectUrls = false;
            this.outputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputTextBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.outputTextBox.ForeColor = System.Drawing.Color.Black;
            this.outputTextBox.Location = new System.Drawing.Point(0, 25);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Size = new System.Drawing.Size(534, 359);
            this.outputTextBox.TabIndex = 2;
            this.outputTextBox.Text = "";
            // 
            // OutputWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 384);
            this.ControlBox = false;
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(550, 400);
            this.Name = "OutputWindow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Output";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OutputWindow_FormClosed);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.RichTextBox outputTextBox;
        private System.Windows.Forms.ToolStripButton sendToMainWindowButton;
        private System.Windows.Forms.ToolStripButton appendToMainWindowButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton copyToClipboardButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton clearButton;
        private System.Windows.Forms.ToolStripButton exportButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton receiveTextButton;
        private System.Windows.Forms.ToolStripTextBox idTextBox;
        private System.Windows.Forms.ToolStripButton exportFullButton;
        private System.Windows.Forms.ToolStripButton outputInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    }
}

namespace Textlow
{
    partial class ExtensionDisplayControl
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.removeButton = new System.Windows.Forms.Button();
            this.extensionLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // removeButton
            // 
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeButton.Location = new System.Drawing.Point(428, 0);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(30, 30);
            this.removeButton.TabIndex = 0;
            this.removeButton.Text = "-";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // extensionLabel
            // 
            this.extensionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.extensionLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.extensionLabel.Location = new System.Drawing.Point(0, 0);
            this.extensionLabel.Name = "extensionLabel";
            this.extensionLabel.Size = new System.Drawing.Size(100, 30);
            this.extensionLabel.TabIndex = 1;
            this.extensionLabel.Text = "e";
            this.extensionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.descriptionLabel.Location = new System.Drawing.Point(100, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(328, 30);
            this.descriptionLabel.TabIndex = 2;
            this.descriptionLabel.Text = "d";
            this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ExtensionDisplayControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.extensionLabel);
            this.Controls.Add(this.removeButton);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ExtensionDisplayControl";
            this.Size = new System.Drawing.Size(458, 30);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Label extensionLabel;
        private System.Windows.Forms.Label descriptionLabel;
    }
}

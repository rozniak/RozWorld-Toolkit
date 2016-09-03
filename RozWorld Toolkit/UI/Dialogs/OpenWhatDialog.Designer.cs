namespace Oddmatics.RozWorld.Toolkit.UI.Dialogs
{
    partial class OpenWhatDialog
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
            this.InstructionLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.CbfRadioButton = new System.Windows.Forms.RadioButton();
            this.CbiRadioButton = new System.Windows.Forms.RadioButton();
            this.IdvlFileRadioButton = new System.Windows.Forms.RadioButton();
            this.SbfRadioButton = new System.Windows.Forms.RadioButton();
            this.SbiRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // InstructionLabel
            // 
            this.InstructionLabel.AutoSize = true;
            this.InstructionLabel.Location = new System.Drawing.Point(12, 9);
            this.InstructionLabel.Name = "InstructionLabel";
            this.InstructionLabel.Size = new System.Drawing.Size(198, 13);
            this.InstructionLabel.TabIndex = 0;
            this.InstructionLabel.Text = "Select the type of file or object to open:";
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CancelButton.Location = new System.Drawing.Point(192, 164);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.OKButton.Location = new System.Drawing.Point(111, 164);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CbfRadioButton
            // 
            this.CbfRadioButton.AutoSize = true;
            this.CbfRadioButton.Checked = true;
            this.CbfRadioButton.Location = new System.Drawing.Point(30, 36);
            this.CbfRadioButton.Name = "CbfRadioButton";
            this.CbfRadioButton.Size = new System.Drawing.Size(104, 17);
            this.CbfRadioButton.TabIndex = 3;
            this.CbfRadioButton.TabStop = true;
            this.CbfRadioButton.Text = "Client by Folder";
            this.CbfRadioButton.UseVisualStyleBackColor = true;
            // 
            // CbiRadioButton
            // 
            this.CbiRadioButton.AutoSize = true;
            this.CbiRadioButton.Location = new System.Drawing.Point(30, 59);
            this.CbiRadioButton.Name = "CbiRadioButton";
            this.CbiRadioButton.Size = new System.Drawing.Size(114, 17);
            this.CbiRadioButton.TabIndex = 3;
            this.CbiRadioButton.Text = "Client by Instance";
            this.CbiRadioButton.UseVisualStyleBackColor = true;
            // 
            // IdvlFileRadioButton
            // 
            this.IdvlFileRadioButton.AutoSize = true;
            this.IdvlFileRadioButton.Location = new System.Drawing.Point(30, 82);
            this.IdvlFileRadioButton.Name = "IdvlFileRadioButton";
            this.IdvlFileRadioButton.Size = new System.Drawing.Size(95, 17);
            this.IdvlFileRadioButton.TabIndex = 3;
            this.IdvlFileRadioButton.Text = "Individual File";
            this.IdvlFileRadioButton.UseVisualStyleBackColor = true;
            // 
            // SbfRadioButton
            // 
            this.SbfRadioButton.AutoSize = true;
            this.SbfRadioButton.Location = new System.Drawing.Point(30, 105);
            this.SbfRadioButton.Name = "SbfRadioButton";
            this.SbfRadioButton.Size = new System.Drawing.Size(108, 17);
            this.SbfRadioButton.TabIndex = 3;
            this.SbfRadioButton.Text = "Server by Folder";
            this.SbfRadioButton.UseVisualStyleBackColor = true;
            // 
            // SbiRadioButton
            // 
            this.SbiRadioButton.AutoSize = true;
            this.SbiRadioButton.Location = new System.Drawing.Point(30, 128);
            this.SbiRadioButton.Name = "SbiRadioButton";
            this.SbiRadioButton.Size = new System.Drawing.Size(118, 17);
            this.SbiRadioButton.TabIndex = 3;
            this.SbiRadioButton.Text = "Server by Instance";
            this.SbiRadioButton.UseVisualStyleBackColor = true;
            // 
            // OpenWhatDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 199);
            this.Controls.Add(this.SbiRadioButton);
            this.Controls.Add(this.SbfRadioButton);
            this.Controls.Add(this.IdvlFileRadioButton);
            this.Controls.Add(this.CbiRadioButton);
            this.Controls.Add(this.CbfRadioButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.InstructionLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OpenWhatDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Open What?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InstructionLabel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.RadioButton CbfRadioButton;
        private System.Windows.Forms.RadioButton CbiRadioButton;
        private System.Windows.Forms.RadioButton IdvlFileRadioButton;
        private System.Windows.Forms.RadioButton SbfRadioButton;
        private System.Windows.Forms.RadioButton SbiRadioButton;
    }
}
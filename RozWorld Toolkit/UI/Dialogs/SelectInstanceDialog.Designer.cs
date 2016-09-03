namespace Oddmatics.RozWorld.Toolkit.UI.Dialogs
{
    partial class SelectInstanceDialog
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
            this.RelatedProcsCheckBox = new System.Windows.Forms.CheckBox();
            this.ProcessList = new System.Windows.Forms.ListBox();
            this.InstructionLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RelatedProcsCheckBox
            // 
            this.RelatedProcsCheckBox.AutoSize = true;
            this.RelatedProcsCheckBox.Checked = true;
            this.RelatedProcsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RelatedProcsCheckBox.Location = new System.Drawing.Point(12, 204);
            this.RelatedProcsCheckBox.Name = "RelatedProcsCheckBox";
            this.RelatedProcsCheckBox.Size = new System.Drawing.Size(168, 17);
            this.RelatedProcsCheckBox.TabIndex = 1;
            this.RelatedProcsCheckBox.Text = "Hide all unrelated processes";
            this.RelatedProcsCheckBox.UseVisualStyleBackColor = true;
            // 
            // ProcessList
            // 
            this.ProcessList.FormattingEnabled = true;
            this.ProcessList.Location = new System.Drawing.Point(12, 25);
            this.ProcessList.Name = "ProcessList";
            this.ProcessList.Size = new System.Drawing.Size(253, 173);
            this.ProcessList.TabIndex = 0;
            // 
            // InstructionLabel
            // 
            this.InstructionLabel.AutoSize = true;
            this.InstructionLabel.Location = new System.Drawing.Point(12, 9);
            this.InstructionLabel.Name = "InstructionLabel";
            this.InstructionLabel.Size = new System.Drawing.Size(251, 13);
            this.InstructionLabel.TabIndex = 2;
            this.InstructionLabel.Text = "Select $ARTICLE$ $SUBJECT$ instance to open:";
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CancelButton.Location = new System.Drawing.Point(190, 236);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.OKButton.Location = new System.Drawing.Point(109, 236);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 2;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Image = global::Oddmatics.RozWorld.Toolkit.Properties.Resources._112_RefreshArrow_Green_16x16_72;
            this.RefreshButton.Location = new System.Drawing.Point(241, 204);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(24, 24);
            this.RefreshButton.TabIndex = 4;
            this.RefreshButton.UseVisualStyleBackColor = true;
            // 
            // SelectInstanceDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 271);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.InstructionLabel);
            this.Controls.Add(this.ProcessList);
            this.Controls.Add(this.RelatedProcsCheckBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectInstanceDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select Instance...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox RelatedProcsCheckBox;
        private System.Windows.Forms.ListBox ProcessList;
        private System.Windows.Forms.Label InstructionLabel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button RefreshButton;
    }
}
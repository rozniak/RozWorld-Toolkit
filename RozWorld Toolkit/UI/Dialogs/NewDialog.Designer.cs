namespace Oddmatics.RozWorld.Toolkit.UI.Dialogs
{
    partial class NewDialog
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Server");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Client");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("RozWorld", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("World", 0);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("Server", 1);
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("Permission Setup", 5);
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("Language System", 2);
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("Control Scheme", 3);
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("Texture Pack", 4);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewDialog));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ItemEnumTreeView = new System.Windows.Forms.TreeView();
            this.ItemListView = new System.Windows.Forms.ListView();
            this.ImgListItemIcons = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.ItemDescriptionPanel = new System.Windows.Forms.Panel();
            this.ItemTypeTagLabel = new System.Windows.Forms.Label();
            this.ItemTypeNameLabel = new System.Windows.Forms.Label();
            this.ItemDescriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.ItemDescriptionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ItemEnumTreeView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ItemListView);
            this.splitContainer1.Size = new System.Drawing.Size(418, 323);
            this.splitContainer1.SplitterDistance = 154;
            this.splitContainer1.TabIndex = 0;
            // 
            // ItemEnumTreeView
            // 
            this.ItemEnumTreeView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ItemEnumTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemEnumTreeView.Location = new System.Drawing.Point(0, 0);
            this.ItemEnumTreeView.Name = "ItemEnumTreeView";
            treeNode4.Name = "RwServerTreeLeaf";
            treeNode4.Text = "Server";
            treeNode5.Name = "RwClientTreeLeaf";
            treeNode5.Text = "Client";
            treeNode6.Name = "RozWorldTreeRoot";
            treeNode6.Text = "RozWorld";
            this.ItemEnumTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6});
            this.ItemEnumTreeView.Size = new System.Drawing.Size(154, 323);
            this.ItemEnumTreeView.TabIndex = 0;
            // 
            // ItemListView
            // 
            this.ItemListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ItemListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemListView.HideSelection = false;
            this.ItemListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12});
            this.ItemListView.LargeImageList = this.ImgListItemIcons;
            this.ItemListView.Location = new System.Drawing.Point(0, 0);
            this.ItemListView.MinimumSize = new System.Drawing.Size(100, 100);
            this.ItemListView.MultiSelect = false;
            this.ItemListView.Name = "ItemListView";
            this.ItemListView.Size = new System.Drawing.Size(260, 323);
            this.ItemListView.TabIndex = 0;
            this.ItemListView.UseCompatibleStateImageBehavior = false;
            this.ItemListView.View = System.Windows.Forms.View.Tile;
            // 
            // ImgListItemIcons
            // 
            this.ImgListItemIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgListItemIcons.ImageStream")));
            this.ImgListItemIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgListItemIcons.Images.SetKeyName(0, "14.ico");
            this.ImgListItemIcons.Images.SetKeyName(1, "300.ico");
            this.ImgListItemIcons.Images.SetKeyName(2, "FontHS.png");
            this.ImgListItemIcons.Images.SetKeyName(3, "Properties.png");
            this.ImgListItemIcons.Images.SetKeyName(4, "037_Colorize_16x16_72.png");
            this.ImgListItemIcons.Images.SetKeyName(5, "157_GetPermission_16x16_72.png");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.OKButton);
            this.panel1.Controls.Add(this.CancelButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 323);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 35);
            this.panel1.TabIndex = 1;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(546, 6);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(465, 6);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            // 
            // ItemDescriptionPanel
            // 
            this.ItemDescriptionPanel.BackColor = System.Drawing.Color.White;
            this.ItemDescriptionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ItemDescriptionPanel.Controls.Add(this.ItemDescriptionLabel);
            this.ItemDescriptionPanel.Controls.Add(this.ItemTypeNameLabel);
            this.ItemDescriptionPanel.Controls.Add(this.ItemTypeTagLabel);
            this.ItemDescriptionPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ItemDescriptionPanel.Location = new System.Drawing.Point(418, 0);
            this.ItemDescriptionPanel.Name = "ItemDescriptionPanel";
            this.ItemDescriptionPanel.Size = new System.Drawing.Size(215, 323);
            this.ItemDescriptionPanel.TabIndex = 2;
            // 
            // ItemTypeTagLabel
            // 
            this.ItemTypeTagLabel.AutoSize = true;
            this.ItemTypeTagLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemTypeTagLabel.Location = new System.Drawing.Point(5, 8);
            this.ItemTypeTagLabel.Name = "ItemTypeTagLabel";
            this.ItemTypeTagLabel.Size = new System.Drawing.Size(35, 13);
            this.ItemTypeTagLabel.TabIndex = 0;
            this.ItemTypeTagLabel.Text = "Type:";
            // 
            // ItemTypeNameLabel
            // 
            this.ItemTypeNameLabel.AutoSize = true;
            this.ItemTypeNameLabel.Location = new System.Drawing.Point(46, 8);
            this.ItemTypeNameLabel.Name = "ItemTypeNameLabel";
            this.ItemTypeNameLabel.Size = new System.Drawing.Size(36, 13);
            this.ItemTypeNameLabel.TabIndex = 1;
            this.ItemTypeNameLabel.Text = "World";
            // 
            // ItemDescriptionLabel
            // 
            this.ItemDescriptionLabel.Location = new System.Drawing.Point(5, 34);
            this.ItemDescriptionLabel.Name = "ItemDescriptionLabel";
            this.ItemDescriptionLabel.Size = new System.Drawing.Size(197, 358);
            this.ItemDescriptionLabel.TabIndex = 1;
            this.ItemDescriptionLabel.Text = "A full RozWorld level that contains the playspace of the game and its entities/ob" +
    "jects.";
            // 
            // NewDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 358);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.ItemDescriptionPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ItemDescriptionPanel.ResumeLayout(false);
            this.ItemDescriptionPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView ItemEnumTreeView;
        private System.Windows.Forms.ListView ItemListView;
        private System.Windows.Forms.ImageList ImgListItemIcons;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Panel ItemDescriptionPanel;
        private System.Windows.Forms.Label ItemDescriptionLabel;
        private System.Windows.Forms.Label ItemTypeNameLabel;
        private System.Windows.Forms.Label ItemTypeTagLabel;
    }
}
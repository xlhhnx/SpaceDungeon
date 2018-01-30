namespace SpaceDungeon
{
    partial class SystemForm
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
            this.systemTree = new System.Windows.Forms.TreeView();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.systemListBox = new System.Windows.Forms.ListBox();
            this.addSystemButton = new System.Windows.Forms.Button();
            this.editSystemButton = new System.Windows.Forms.Button();
            this.deleteSystemButton = new System.Windows.Forms.Button();
            this.showAllSystems = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // systemTree
            // 
            this.systemTree.Location = new System.Drawing.Point(269, 12);
            this.systemTree.Name = "systemTree";
            this.systemTree.Size = new System.Drawing.Size(290, 381);
            this.systemTree.TabIndex = 0;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(12, 12);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(170, 20);
            this.searchTextBox.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(188, 12);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // systemListBox
            // 
            this.systemListBox.FormattingEnabled = true;
            this.systemListBox.Location = new System.Drawing.Point(12, 70);
            this.systemListBox.Name = "systemListBox";
            this.systemListBox.Size = new System.Drawing.Size(251, 290);
            this.systemListBox.TabIndex = 3;
            this.systemListBox.SelectedIndexChanged += new System.EventHandler(this.systemListBox_SelectedIndexChanged);
            // 
            // addSystemButton
            // 
            this.addSystemButton.Location = new System.Drawing.Point(12, 370);
            this.addSystemButton.Name = "addSystemButton";
            this.addSystemButton.Size = new System.Drawing.Size(75, 23);
            this.addSystemButton.TabIndex = 4;
            this.addSystemButton.Text = "Add System";
            this.addSystemButton.UseVisualStyleBackColor = true;
            this.addSystemButton.Click += new System.EventHandler(this.addSystemButton_Click);
            // 
            // editSystemButton
            // 
            this.editSystemButton.Location = new System.Drawing.Point(93, 370);
            this.editSystemButton.Name = "editSystemButton";
            this.editSystemButton.Size = new System.Drawing.Size(75, 23);
            this.editSystemButton.TabIndex = 5;
            this.editSystemButton.Text = "Edit System";
            this.editSystemButton.UseVisualStyleBackColor = true;
            this.editSystemButton.Click += new System.EventHandler(this.editSystemButton_Click);
            // 
            // deleteSystemButton
            // 
            this.deleteSystemButton.Location = new System.Drawing.Point(174, 370);
            this.deleteSystemButton.Name = "deleteSystemButton";
            this.deleteSystemButton.Size = new System.Drawing.Size(89, 23);
            this.deleteSystemButton.TabIndex = 6;
            this.deleteSystemButton.Text = "Delete System";
            this.deleteSystemButton.UseVisualStyleBackColor = true;
            this.deleteSystemButton.Click += new System.EventHandler(this.deleteSystemButton_Click);
            // 
            // showAllSystems
            // 
            this.showAllSystems.Location = new System.Drawing.Point(188, 41);
            this.showAllSystems.Name = "showAllSystems";
            this.showAllSystems.Size = new System.Drawing.Size(75, 23);
            this.showAllSystems.TabIndex = 7;
            this.showAllSystems.Text = "Show All";
            this.showAllSystems.UseVisualStyleBackColor = true;
            this.showAllSystems.Click += new System.EventHandler(this.showAllSystems_Click);
            // 
            // SystemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 405);
            this.Controls.Add(this.showAllSystems);
            this.Controls.Add(this.deleteSystemButton);
            this.Controls.Add(this.editSystemButton);
            this.Controls.Add(this.addSystemButton);
            this.Controls.Add(this.systemListBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.systemTree);
            this.Name = "SystemForm";
            this.Text = "SystemForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView systemTree;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ListBox systemListBox;
        private System.Windows.Forms.Button addSystemButton;
        private System.Windows.Forms.Button editSystemButton;
        private System.Windows.Forms.Button deleteSystemButton;
        private System.Windows.Forms.Button showAllSystems;
    }
}
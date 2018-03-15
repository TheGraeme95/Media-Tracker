namespace Media_Tracker
{
    partial class MainWindow
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFilmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.filmTab = new System.Windows.Forms.TabPage();
            this.FilmCollectionView = new System.Windows.Forms.DataGridView();
            this.ID_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seen_Column = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.LastSeen_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Owned_Column = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Rating_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BluRay_Column = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gameTab = new System.Windows.Forms.TabPage();
            this.GameCollectionView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlayStatus_Column = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.LastPlayed_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Platform_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.filmTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FilmCollectionView)).BeginInit();
            this.gameTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GameCollectionView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.collectionToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1072, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectUserToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // selectUserToolStripMenuItem
            // 
            this.selectUserToolStripMenuItem.Name = "selectUserToolStripMenuItem";
            this.selectUserToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.selectUserToolStripMenuItem.Text = "Create User";
            this.selectUserToolStripMenuItem.Click += new System.EventHandler(this.selectUserToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // collectionToolStripMenuItem
            // 
            this.collectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFilmToolStripMenuItem,
            this.gameToolStripMenuItem});
            this.collectionToolStripMenuItem.Name = "collectionToolStripMenuItem";
            this.collectionToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.collectionToolStripMenuItem.Text = "Collection";
            // 
            // addFilmToolStripMenuItem
            // 
            this.addFilmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.addFilmToolStripMenuItem.Name = "addFilmToolStripMenuItem";
            this.addFilmToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addFilmToolStripMenuItem.Text = "Film";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem1,
            this.removeToolStripMenuItem1});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.addToolStripMenuItem1.Text = "Add";
            this.addToolStripMenuItem1.Click += new System.EventHandler(this.addToolStripMenuItem1_Click);
            // 
            // removeToolStripMenuItem1
            // 
            this.removeToolStripMenuItem1.Name = "removeToolStripMenuItem1";
            this.removeToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.removeToolStripMenuItem1.Text = "Remove";
            this.removeToolStripMenuItem1.Click += new System.EventHandler(this.removeToolStripMenuItem1_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click_1);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.filmTab);
            this.tabControl1.Controls.Add(this.gameTab);
            this.tabControl1.Location = new System.Drawing.Point(288, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(772, 540);
            this.tabControl1.TabIndex = 1;
            // 
            // filmTab
            // 
            this.filmTab.Controls.Add(this.FilmCollectionView);
            this.filmTab.Location = new System.Drawing.Point(4, 22);
            this.filmTab.Name = "filmTab";
            this.filmTab.Padding = new System.Windows.Forms.Padding(3);
            this.filmTab.Size = new System.Drawing.Size(764, 514);
            this.filmTab.TabIndex = 0;
            this.filmTab.Text = "Films";
            this.filmTab.UseVisualStyleBackColor = true;
            // 
            // FilmCollectionView
            // 
            this.FilmCollectionView.AllowUserToAddRows = false;
            this.FilmCollectionView.AllowUserToDeleteRows = false;
            this.FilmCollectionView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FilmCollectionView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Column,
            this.Title_Column,
            this.Seen_Column,
            this.LastSeen_Column,
            this.Owned_Column,
            this.Rating_Column,
            this.BluRay_Column});
            this.FilmCollectionView.Location = new System.Drawing.Point(6, 6);
            this.FilmCollectionView.Name = "FilmCollectionView";
            this.FilmCollectionView.ReadOnly = true;
            this.FilmCollectionView.Size = new System.Drawing.Size(752, 502);
            this.FilmCollectionView.TabIndex = 0;
            // 
            // ID_Column
            // 
            this.ID_Column.HeaderText = "ID";
            this.ID_Column.Name = "ID_Column";
            this.ID_Column.ReadOnly = true;
            // 
            // Title_Column
            // 
            this.Title_Column.HeaderText = "TItle";
            this.Title_Column.Name = "Title_Column";
            this.Title_Column.ReadOnly = true;
            // 
            // Seen_Column
            // 
            this.Seen_Column.HeaderText = "Seen";
            this.Seen_Column.Name = "Seen_Column";
            this.Seen_Column.ReadOnly = true;
            this.Seen_Column.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Seen_Column.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // LastSeen_Column
            // 
            this.LastSeen_Column.HeaderText = "Last Seen";
            this.LastSeen_Column.Name = "LastSeen_Column";
            this.LastSeen_Column.ReadOnly = true;
            // 
            // Owned_Column
            // 
            this.Owned_Column.HeaderText = "Owned";
            this.Owned_Column.Name = "Owned_Column";
            this.Owned_Column.ReadOnly = true;
            // 
            // Rating_Column
            // 
            this.Rating_Column.HeaderText = "Rating";
            this.Rating_Column.Name = "Rating_Column";
            this.Rating_Column.ReadOnly = true;
            // 
            // BluRay_Column
            // 
            this.BluRay_Column.HeaderText = "BluRay";
            this.BluRay_Column.Name = "BluRay_Column";
            this.BluRay_Column.ReadOnly = true;
            // 
            // gameTab
            // 
            this.gameTab.Controls.Add(this.GameCollectionView);
            this.gameTab.Location = new System.Drawing.Point(4, 22);
            this.gameTab.Name = "gameTab";
            this.gameTab.Padding = new System.Windows.Forms.Padding(3);
            this.gameTab.Size = new System.Drawing.Size(764, 514);
            this.gameTab.TabIndex = 1;
            this.gameTab.Text = "Games";
            this.gameTab.UseVisualStyleBackColor = true;
            // 
            // GameCollectionView
            // 
            this.GameCollectionView.AllowUserToAddRows = false;
            this.GameCollectionView.AllowUserToDeleteRows = false;
            this.GameCollectionView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GameCollectionView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.PlayStatus_Column,
            this.LastPlayed_Column,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.Platform_Column});
            this.GameCollectionView.Location = new System.Drawing.Point(6, 6);
            this.GameCollectionView.Name = "GameCollectionView";
            this.GameCollectionView.ReadOnly = true;
            this.GameCollectionView.Size = new System.Drawing.Size(752, 502);
            this.GameCollectionView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "TItle";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // PlayStatus_Column
            // 
            this.PlayStatus_Column.HeaderText = "Completed";
            this.PlayStatus_Column.Name = "PlayStatus_Column";
            this.PlayStatus_Column.ReadOnly = true;
            // 
            // LastPlayed_Column
            // 
            this.LastPlayed_Column.HeaderText = "Last Played";
            this.LastPlayed_Column.Name = "LastPlayed_Column";
            this.LastPlayed_Column.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.HeaderText = "Owned";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Rating";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // Platform_Column
            // 
            this.Platform_Column.HeaderText = "Platform";
            this.Platform_Column.Name = "Platform_Column";
            this.Platform_Column.ReadOnly = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 579);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Media Tracker";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.filmTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FilmCollectionView)).EndInit();
            this.gameTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GameCollectionView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage filmTab;
        private System.Windows.Forms.DataGridView FilmCollectionView;
        private System.Windows.Forms.TabPage gameTab;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title_Column;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seen_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastSeen_Column;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Owned_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rating_Column;
        private System.Windows.Forms.DataGridViewCheckBoxColumn BluRay_Column;
        private System.Windows.Forms.DataGridView GameCollectionView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PlayStatus_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastPlayed_Column;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Platform_Column;
        private System.Windows.Forms.ToolStripMenuItem collectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFilmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem selectUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
    }
}


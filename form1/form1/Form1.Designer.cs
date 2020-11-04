namespace form1
{
    partial class TEST_Field
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TEST_Field));
            this.DB_Grid1 = new System.Windows.Forms.DataGridView();
            this.Popup_Menu1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MN_addCol = new System.Windows.Forms.ToolStripMenuItem();
            this.MN_addRow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.MN_DBUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.MN_TableClose = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Strip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MN_dbOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MN_dbClose = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.MN_Close = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MN_TestCmd1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MN_TestCmd2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.MN_TestCmd3 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sS_Label1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sS_Label3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sS_Label5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sS_Combo1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.TB_SQLterminer = new System.Windows.Forms.TextBox();
            this.Popup_Menu2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MN_SQLstart = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.MN_TableSave = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DB_Grid1)).BeginInit();
            this.Popup_Menu1.SuspendLayout();
            this.Menu_Strip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.Popup_Menu2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DB_Grid1
            // 
            this.DB_Grid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DB_Grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DB_Grid1.ContextMenuStrip = this.Popup_Menu1;
            this.DB_Grid1.Location = new System.Drawing.Point(5, 6);
            this.DB_Grid1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.DB_Grid1.Name = "DB_Grid1";
            this.DB_Grid1.RowHeadersWidth = 51;
            this.DB_Grid1.Size = new System.Drawing.Size(662, 283);
            this.DB_Grid1.TabIndex = 0;
            this.DB_Grid1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.DB_Grid1_CellBeginEdit);
            // 
            // Popup_Menu1
            // 
            this.Popup_Menu1.AllowDrop = true;
            this.Popup_Menu1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Popup_Menu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MN_addCol,
            this.MN_addRow,
            this.toolStripMenuItem3,
            this.MN_DBUpdate,
            this.toolStripMenuItem4,
            this.MN_TableSave,
            this.MN_TableClose});
            this.Popup_Menu1.Name = "Popup_Menu1";
            this.Popup_Menu1.ShowImageMargin = false;
            this.Popup_Menu1.Size = new System.Drawing.Size(186, 164);
            // 
            // MN_addCol
            // 
            this.MN_addCol.Name = "MN_addCol";
            this.MN_addCol.Size = new System.Drawing.Size(185, 24);
            this.MN_addCol.Text = "Column 추가";
            this.MN_addCol.Click += new System.EventHandler(this.MN_addCol_Click);
            // 
            // MN_addRow
            // 
            this.MN_addRow.Name = "MN_addRow";
            this.MN_addRow.Size = new System.Drawing.Size(185, 24);
            this.MN_addRow.Text = "Row 추가";
            this.MN_addRow.Click += new System.EventHandler(this.MN_addRow_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(182, 6);
            // 
            // MN_DBUpdate
            // 
            this.MN_DBUpdate.Name = "MN_DBUpdate";
            this.MN_DBUpdate.Size = new System.Drawing.Size(185, 24);
            this.MN_DBUpdate.Text = "DB 업데이트";
            this.MN_DBUpdate.Click += new System.EventHandler(this.MN_DBUpdate_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(182, 6);
            // 
            // MN_TableClose
            // 
            this.MN_TableClose.Name = "MN_TableClose";
            this.MN_TableClose.Size = new System.Drawing.Size(185, 24);
            this.MN_TableClose.Text = "Table 닫기";
            this.MN_TableClose.Click += new System.EventHandler(this.MN_TableClose_Click);
            // 
            // Menu_Strip1
            // 
            this.Menu_Strip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu_Strip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.Menu_Strip1.Location = new System.Drawing.Point(0, 0);
            this.Menu_Strip1.Name = "Menu_Strip1";
            this.Menu_Strip1.Padding = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.Menu_Strip1.Size = new System.Drawing.Size(670, 28);
            this.Menu_Strip1.TabIndex = 5;
            this.Menu_Strip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MN_dbOpen,
            this.MN_dbClose,
            this.toolStripMenuItem1,
            this.MN_Close});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.fileToolStripMenuItem.Text = "File(F)";
            // 
            // MN_dbOpen
            // 
            this.MN_dbOpen.Name = "MN_dbOpen";
            this.MN_dbOpen.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.O)));
            this.MN_dbOpen.Size = new System.Drawing.Size(288, 26);
            this.MN_dbOpen.Text = "Database Open";
            this.MN_dbOpen.Click += new System.EventHandler(this.MN_dbOpen_Click);
            // 
            // MN_dbClose
            // 
            this.MN_dbClose.Name = "MN_dbClose";
            this.MN_dbClose.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.X)));
            this.MN_dbClose.Size = new System.Drawing.Size(288, 26);
            this.MN_dbClose.Text = "Database Close";
            this.MN_dbClose.Click += new System.EventHandler(this.MN_dbClose_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(285, 6);
            // 
            // MN_Close
            // 
            this.MN_Close.Name = "MN_Close";
            this.MN_Close.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.X)));
            this.MN_Close.Size = new System.Drawing.Size(288, 26);
            this.MN_Close.Text = "Close(X)";
            this.MN_Close.Click += new System.EventHandler(this.MN_Close_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MN_TestCmd1,
            this.MN_TestCmd2,
            this.toolStripMenuItem2,
            this.MN_TestCmd3});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.editToolStripMenuItem.Text = "Edit(E)";
            // 
            // MN_TestCmd1
            // 
            this.MN_TestCmd1.Name = "MN_TestCmd1";
            this.MN_TestCmd1.Size = new System.Drawing.Size(126, 26);
            this.MN_TestCmd1.Text = "Test1";
            this.MN_TestCmd1.Click += new System.EventHandler(this.MN_TestCmd1_Click);
            // 
            // MN_TestCmd2
            // 
            this.MN_TestCmd2.Name = "MN_TestCmd2";
            this.MN_TestCmd2.Size = new System.Drawing.Size(126, 26);
            this.MN_TestCmd2.Text = "Test2";
            this.MN_TestCmd2.Click += new System.EventHandler(this.MN_TestCmd2_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(123, 6);
            // 
            // MN_TestCmd3
            // 
            this.MN_TestCmd3.Name = "MN_TestCmd3";
            this.MN_TestCmd3.Size = new System.Drawing.Size(126, 26);
            this.MN_TestCmd3.Text = "Test3";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.viewToolStripMenuItem.Text = "View(V)";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sS_Label1,
            this.sS_Label3,
            this.sS_Label5,
            this.sS_Combo1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 478);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 17, 0);
            this.statusStrip1.Size = new System.Drawing.Size(670, 26);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sS_Label1
            // 
            this.sS_Label1.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.sS_Label1.Name = "sS_Label1";
            this.sS_Label1.Size = new System.Drawing.Size(122, 20);
            this.sS_Label1.Text = "Database check...";
            // 
            // sS_Label3
            // 
            this.sS_Label3.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.sS_Label3.Name = "sS_Label3";
            this.sS_Label3.Size = new System.Drawing.Size(0, 20);
            // 
            // sS_Label5
            // 
            this.sS_Label5.Name = "sS_Label5";
            this.sS_Label5.Size = new System.Drawing.Size(106, 20);
            this.sS_Label5.Text = "SQL Message...";
            // 
            // sS_Combo1
            // 
            this.sS_Combo1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.sS_Combo1.Image = ((System.Drawing.Image)(resources.GetObject("sS_Combo1.Image")));
            this.sS_Combo1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sS_Combo1.Name = "sS_Combo1";
            this.sS_Combo1.Size = new System.Drawing.Size(73, 24);
            this.sS_Combo1.Text = "Tables...";
            this.sS_Combo1.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.sS_Combo1_DropDownItemClicked);
            // 
            // TB_SQLterminer
            // 
            this.TB_SQLterminer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_SQLterminer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_SQLterminer.ContextMenuStrip = this.Popup_Menu2;
            this.TB_SQLterminer.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_SQLterminer.Location = new System.Drawing.Point(4, 4);
            this.TB_SQLterminer.Margin = new System.Windows.Forms.Padding(4);
            this.TB_SQLterminer.Multiline = true;
            this.TB_SQLterminer.Name = "TB_SQLterminer";
            this.TB_SQLterminer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TB_SQLterminer.Size = new System.Drawing.Size(662, 130);
            this.TB_SQLterminer.TabIndex = 7;
            this.TB_SQLterminer.Text = "SQLcommends:; ";
            this.TB_SQLterminer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_SQLterminer_KeyPress);
            // 
            // Popup_Menu2
            // 
            this.Popup_Menu2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Popup_Menu2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MN_SQLstart});
            this.Popup_Menu2.Name = "Popup_Menu2";
            this.Popup_Menu2.Size = new System.Drawing.Size(139, 28);
            // 
            // MN_SQLstart
            // 
            this.MN_SQLstart.Name = "MN_SQLstart";
            this.MN_SQLstart.Size = new System.Drawing.Size(138, 24);
            this.MN_SQLstart.Text = "SQL 실행";
            this.MN_SQLstart.Click += new System.EventHandler(this.MN_SQLstart_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 42);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.TB_SQLterminer);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.DB_Grid1);
            this.splitContainer1.Size = new System.Drawing.Size(670, 437);
            this.splitContainer1.SplitterDistance = 134;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 8;
            // 
            // MN_TableSave
            // 
            this.MN_TableSave.Name = "MN_TableSave";
            this.MN_TableSave.Size = new System.Drawing.Size(185, 24);
            this.MN_TableSave.Text = "Table 저장";
            this.MN_TableSave.Click += new System.EventHandler(this.MN_TableSave_Click);
            // 
            // TEST_Field
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 504);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Menu_Strip1);
            this.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.Menu_Strip1;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "TEST_Field";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DB_Grid1)).EndInit();
            this.Popup_Menu1.ResumeLayout(false);
            this.Menu_Strip1.ResumeLayout(false);
            this.Menu_Strip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.Popup_Menu2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DB_Grid1;
        private System.Windows.Forms.ContextMenuStrip Popup_Menu1;
        private System.Windows.Forms.ToolStripMenuItem MN_addCol;
        private System.Windows.Forms.ToolStripMenuItem MN_addRow;
        private System.Windows.Forms.MenuStrip Menu_Strip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MN_dbOpen;
        private System.Windows.Forms.ToolStripMenuItem MN_dbClose;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MN_Close;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sS_Label1;
        private System.Windows.Forms.ToolStripStatusLabel sS_Label3;
        private System.Windows.Forms.TextBox TB_SQLterminer;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripMenuItem MN_TestCmd1;
        private System.Windows.Forms.ToolStripMenuItem MN_TestCmd2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem MN_DBUpdate;
        private System.Windows.Forms.ToolStripMenuItem MN_TestCmd3;
        private System.Windows.Forms.ToolStripStatusLabel sS_Label5;
        private System.Windows.Forms.ToolStripDropDownButton sS_Combo1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem MN_TableClose;
        private System.Windows.Forms.ContextMenuStrip Popup_Menu2;
        private System.Windows.Forms.ToolStripMenuItem MN_SQLstart;
        private System.Windows.Forms.ToolStripMenuItem MN_TableSave;
    }
}


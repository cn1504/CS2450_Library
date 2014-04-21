namespace CS2450_Library
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCatalogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.openCatalogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPatronToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.categoryPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.catalogButtonPanel = new System.Windows.Forms.Panel();
            this.catalogButtonLabel = new System.Windows.Forms.Label();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.patronsButtonPanel = new System.Windows.Forms.Panel();
            this.patronsButtonLabel = new System.Windows.Forms.Label();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.overdueButtonPanel = new System.Windows.Forms.Panel();
            this.overdueButtonLabel = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.addItemButton = new System.Windows.Forms.ToolStripButton();
            this.deleteItemButton = new System.Windows.Forms.ToolStripButton();
            this.addPatronButton = new System.Windows.Forms.ToolStripButton();
            this.deletePatronButton = new System.Windows.Forms.ToolStripButton();
            this.buttonStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.checkInOutButton = new System.Windows.Forms.ToolStripButton();
            this.listView = new System.Windows.Forms.ListView();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tooltipStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.incrementDateLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.decrementDateLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.currentDateStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.libraryOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.librarySaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.categoryPanel.SuspendLayout();
            this.catalogButtonPanel.SuspendLayout();
            this.patronsButtonPanel.SuspendLayout();
            this.overdueButtonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.actionsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(769, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCatalogToolStripMenuItem,
            this.toolStripSeparator2,
            this.openCatalogToolStripMenuItem,
            this.toolStripSeparator3,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newCatalogToolStripMenuItem
            // 
            this.newCatalogToolStripMenuItem.Name = "newCatalogToolStripMenuItem";
            this.newCatalogToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.newCatalogToolStripMenuItem.Text = "New Library File";
            this.newCatalogToolStripMenuItem.Click += new System.EventHandler(this.newCatalogToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(203, 6);
            // 
            // openCatalogToolStripMenuItem
            // 
            this.openCatalogToolStripMenuItem.Name = "openCatalogToolStripMenuItem";
            this.openCatalogToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openCatalogToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.openCatalogToolStripMenuItem.Text = "Open Library File";
            this.openCatalogToolStripMenuItem.Click += new System.EventHandler(this.openCatalogToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(203, 6);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.saveAsToolStripMenuItem.Text = "Save Library File As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(203, 6);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(206, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addItemToolStripMenuItem,
            this.addPatronToolStripMenuItem,
            this.toolStripSeparator4,
            this.deleteItemToolStripMenuItem});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.actionsToolStripMenuItem.Text = "Edit";
            // 
            // addItemToolStripMenuItem
            // 
            this.addItemToolStripMenuItem.Name = "addItemToolStripMenuItem";
            this.addItemToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.addItemToolStripMenuItem.Text = "Add Item";
            this.addItemToolStripMenuItem.Click += new System.EventHandler(this.addItemToolStripMenuItem_Click);
            // 
            // addPatronToolStripMenuItem
            // 
            this.addPatronToolStripMenuItem.Name = "addPatronToolStripMenuItem";
            this.addPatronToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.addPatronToolStripMenuItem.Text = "Add Patron";
            this.addPatronToolStripMenuItem.Click += new System.EventHandler(this.addPatronToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(175, 6);
            // 
            // deleteItemToolStripMenuItem
            // 
            this.deleteItemToolStripMenuItem.Enabled = false;
            this.deleteItemToolStripMenuItem.Name = "deleteItemToolStripMenuItem";
            this.deleteItemToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteItemToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.deleteItemToolStripMenuItem.Text = "Delete Selected";
            this.deleteItemToolStripMenuItem.Click += new System.EventHandler(this.deleteItemToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel1.Controls.Add(this.categoryPanel);
            this.splitContainer1.Panel1MinSize = 90;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2MinSize = 150;
            this.splitContainer1.Size = new System.Drawing.Size(769, 411);
            this.splitContainer1.SplitterDistance = 150;
            this.splitContainer1.TabIndex = 1;
            // 
            // categoryPanel
            // 
            this.categoryPanel.BackColor = System.Drawing.SystemColors.Window;
            this.categoryPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.categoryPanel.Controls.Add(this.splitter1);
            this.categoryPanel.Controls.Add(this.catalogButtonPanel);
            this.categoryPanel.Controls.Add(this.splitter2);
            this.categoryPanel.Controls.Add(this.patronsButtonPanel);
            this.categoryPanel.Controls.Add(this.splitter3);
            this.categoryPanel.Controls.Add(this.overdueButtonPanel);
            this.categoryPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.categoryPanel.Location = new System.Drawing.Point(0, 0);
            this.categoryPanel.Margin = new System.Windows.Forms.Padding(0);
            this.categoryPanel.Name = "categoryPanel";
            this.categoryPanel.Size = new System.Drawing.Size(150, 411);
            this.categoryPanel.TabIndex = 2;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Enabled = false;
            this.splitter1.Location = new System.Drawing.Point(3, 3);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(144, 20);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // catalogButtonPanel
            // 
            this.catalogButtonPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.catalogButtonPanel.Controls.Add(this.catalogButtonLabel);
            this.catalogButtonPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.catalogButtonPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.catalogButtonPanel.Location = new System.Drawing.Point(0, 29);
            this.catalogButtonPanel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.catalogButtonPanel.Name = "catalogButtonPanel";
            this.catalogButtonPanel.Size = new System.Drawing.Size(150, 40);
            this.catalogButtonPanel.TabIndex = 1;
            // 
            // catalogButtonLabel
            // 
            this.catalogButtonLabel.AutoSize = true;
            this.catalogButtonLabel.BackColor = System.Drawing.Color.Transparent;
            this.catalogButtonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catalogButtonLabel.Location = new System.Drawing.Point(40, 10);
            this.catalogButtonLabel.Name = "catalogButtonLabel";
            this.catalogButtonLabel.Size = new System.Drawing.Size(73, 24);
            this.catalogButtonLabel.TabIndex = 0;
            this.catalogButtonLabel.Text = "Catalog";
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Enabled = false;
            this.splitter2.Location = new System.Drawing.Point(3, 75);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(144, 20);
            this.splitter2.TabIndex = 2;
            this.splitter2.TabStop = false;
            // 
            // patronsButtonPanel
            // 
            this.patronsButtonPanel.Controls.Add(this.patronsButtonLabel);
            this.patronsButtonPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.patronsButtonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patronsButtonPanel.Location = new System.Drawing.Point(0, 101);
            this.patronsButtonPanel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.patronsButtonPanel.Name = "patronsButtonPanel";
            this.patronsButtonPanel.Size = new System.Drawing.Size(150, 40);
            this.patronsButtonPanel.TabIndex = 3;
            // 
            // patronsButtonLabel
            // 
            this.patronsButtonLabel.AutoSize = true;
            this.patronsButtonLabel.BackColor = System.Drawing.Color.Transparent;
            this.patronsButtonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patronsButtonLabel.Location = new System.Drawing.Point(40, 10);
            this.patronsButtonLabel.Name = "patronsButtonLabel";
            this.patronsButtonLabel.Size = new System.Drawing.Size(73, 24);
            this.patronsButtonLabel.TabIndex = 2;
            this.patronsButtonLabel.Text = "Patrons";
            // 
            // splitter3
            // 
            this.splitter3.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter3.Enabled = false;
            this.splitter3.Location = new System.Drawing.Point(3, 147);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(144, 20);
            this.splitter3.TabIndex = 4;
            this.splitter3.TabStop = false;
            // 
            // overdueButtonPanel
            // 
            this.overdueButtonPanel.Controls.Add(this.overdueButtonLabel);
            this.overdueButtonPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.overdueButtonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overdueButtonPanel.Location = new System.Drawing.Point(0, 173);
            this.overdueButtonPanel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.overdueButtonPanel.Name = "overdueButtonPanel";
            this.overdueButtonPanel.Size = new System.Drawing.Size(150, 40);
            this.overdueButtonPanel.TabIndex = 5;
            // 
            // overdueButtonLabel
            // 
            this.overdueButtonLabel.AutoSize = true;
            this.overdueButtonLabel.BackColor = System.Drawing.Color.Transparent;
            this.overdueButtonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overdueButtonLabel.Location = new System.Drawing.Point(40, 10);
            this.overdueButtonLabel.Name = "overdueButtonLabel";
            this.overdueButtonLabel.Size = new System.Drawing.Size(84, 24);
            this.overdueButtonLabel.TabIndex = 1;
            this.overdueButtonLabel.Text = "Overdue";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.toolStrip1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.listView);
            this.splitContainer2.Size = new System.Drawing.Size(615, 411);
            this.splitContainer2.SplitterDistance = 25;
            this.splitContainer2.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addItemButton,
            this.deleteItemButton,
            this.addPatronButton,
            this.deletePatronButton,
            this.buttonStripSeparator,
            this.checkInOutButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(615, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // addItemButton
            // 
            this.addItemButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.addItemButton.Image = ((System.Drawing.Image)(resources.GetObject("addItemButton.Image")));
            this.addItemButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(60, 22);
            this.addItemButton.Text = "Add Item";
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // deleteItemButton
            // 
            this.deleteItemButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.deleteItemButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteItemButton.Image")));
            this.deleteItemButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteItemButton.Name = "deleteItemButton";
            this.deleteItemButton.Size = new System.Drawing.Size(71, 22);
            this.deleteItemButton.Text = "Delete Item";
            this.deleteItemButton.Click += new System.EventHandler(this.deleteItemButton_Click);
            // 
            // addPatronButton
            // 
            this.addPatronButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.addPatronButton.Image = ((System.Drawing.Image)(resources.GetObject("addPatronButton.Image")));
            this.addPatronButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addPatronButton.Name = "addPatronButton";
            this.addPatronButton.Size = new System.Drawing.Size(71, 22);
            this.addPatronButton.Text = "Add Patron";
            this.addPatronButton.Click += new System.EventHandler(this.addPatronButton_Click);
            // 
            // deletePatronButton
            // 
            this.deletePatronButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.deletePatronButton.Image = ((System.Drawing.Image)(resources.GetObject("deletePatronButton.Image")));
            this.deletePatronButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deletePatronButton.Name = "deletePatronButton";
            this.deletePatronButton.Size = new System.Drawing.Size(82, 22);
            this.deletePatronButton.Text = "Delete Patron";
            this.deletePatronButton.Click += new System.EventHandler(this.deletePatronButton_Click);
            // 
            // buttonStripSeparator
            // 
            this.buttonStripSeparator.Name = "buttonStripSeparator";
            this.buttonStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // checkInOutButton
            // 
            this.checkInOutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.checkInOutButton.Image = ((System.Drawing.Image)(resources.GetObject("checkInOutButton.Image")));
            this.checkInOutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.checkInOutButton.Name = "checkInOutButton";
            this.checkInOutButton.Size = new System.Drawing.Size(114, 22);
            this.checkInOutButton.Text = "Check In/Out Items";
            this.checkInOutButton.Click += new System.EventHandler(this.checkInOutButton_Click);
            // 
            // listView
            // 
            this.listView.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.FullRowSelect = true;
            this.listView.Location = new System.Drawing.Point(0, 0);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(615, 382);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer3.Location = new System.Drawing.Point(0, 24);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainer3.Size = new System.Drawing.Size(769, 437);
            this.splitContainer3.SplitterDistance = 411;
            this.splitContainer3.SplitterWidth = 1;
            this.splitContainer3.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tooltipStatusLabel,
            this.incrementDateLabel,
            this.decrementDateLabel,
            this.currentDateStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(769, 24);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tooltipStatusLabel
            // 
            this.tooltipStatusLabel.Name = "tooltipStatusLabel";
            this.tooltipStatusLabel.Size = new System.Drawing.Size(649, 19);
            this.tooltipStatusLabel.Spring = true;
            this.tooltipStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // incrementDateLabel
            // 
            this.incrementDateLabel.AutoSize = false;
            this.incrementDateLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.incrementDateLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.incrementDateLabel.Name = "incrementDateLabel";
            this.incrementDateLabel.Size = new System.Drawing.Size(17, 19);
            this.incrementDateLabel.Text = "+";
            // 
            // decrementDateLabel
            // 
            this.decrementDateLabel.AutoSize = false;
            this.decrementDateLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.decrementDateLabel.Name = "decrementDateLabel";
            this.decrementDateLabel.Size = new System.Drawing.Size(17, 19);
            this.decrementDateLabel.Text = "-";
            // 
            // currentDateStatusLabel
            // 
            this.currentDateStatusLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.currentDateStatusLabel.Name = "currentDateStatusLabel";
            this.currentDateStatusLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.currentDateStatusLabel.Size = new System.Drawing.Size(71, 19);
            this.currentDateStatusLabel.Text = "CurrentDate";
            // 
            // libraryOpenDialog
            // 
            this.libraryOpenDialog.DefaultExt = "ldb";
            this.libraryOpenDialog.Filter = "Library Database Files|*.ldb|All files|*.*";
            this.libraryOpenDialog.Title = "Open Library File";
            // 
            // librarySaveDialog
            // 
            this.librarySaveDialog.DefaultExt = "ldb";
            this.librarySaveDialog.Filter = "Library Database Files|*.ldb|All files|*.*";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 461);
            this.Controls.Add(this.splitContainer3);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Library";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.categoryPanel.ResumeLayout(false);
            this.catalogButtonPanel.ResumeLayout(false);
            this.catalogButtonPanel.PerformLayout();
            this.patronsButtonPanel.ResumeLayout(false);
            this.patronsButtonPanel.PerformLayout();
            this.overdueButtonPanel.ResumeLayout(false);
            this.overdueButtonPanel.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newCatalogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openCatalogToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPatronToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tooltipStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel currentDateStatusLabel;
        private System.Windows.Forms.FlowLayoutPanel categoryPanel;
        private System.Windows.Forms.Panel catalogButtonPanel;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label catalogButtonLabel;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Panel patronsButtonPanel;
        private System.Windows.Forms.Label patronsButtonLabel;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Panel overdueButtonPanel;
        private System.Windows.Forms.Label overdueButtonLabel;
        private System.Windows.Forms.ToolStripStatusLabel incrementDateLabel;
        private System.Windows.Forms.ToolStripStatusLabel decrementDateLabel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton addItemButton;
        private System.Windows.Forms.ToolStripButton deleteItemButton;
        private System.Windows.Forms.ToolStripButton addPatronButton;
        private System.Windows.Forms.ToolStripButton deletePatronButton;
        private System.Windows.Forms.OpenFileDialog libraryOpenDialog;
        private System.Windows.Forms.SaveFileDialog librarySaveDialog;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator buttonStripSeparator;
        private System.Windows.Forms.ToolStripButton checkInOutButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem deleteItemToolStripMenuItem;
    }
}


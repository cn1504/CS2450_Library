namespace CS2450_Library
{
    partial class CheckInOutForm
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
            this.leftContainer = new System.Windows.Forms.SplitContainer();
            this.rightContainer = new System.Windows.Forms.SplitContainer();
            this.itemsListView = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.checkoutLabel = new System.Windows.Forms.Label();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.cancelButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.checkoutListView = new System.Windows.Forms.ListView();
            this.moveItemRightButton = new System.Windows.Forms.Button();
            this.moveItemLeftButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.leftContainer)).BeginInit();
            this.leftContainer.Panel1.SuspendLayout();
            this.leftContainer.Panel2.SuspendLayout();
            this.leftContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightContainer)).BeginInit();
            this.rightContainer.Panel1.SuspendLayout();
            this.rightContainer.Panel2.SuspendLayout();
            this.rightContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftContainer
            // 
            this.leftContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.leftContainer.IsSplitterFixed = true;
            this.leftContainer.Location = new System.Drawing.Point(0, 0);
            this.leftContainer.Name = "leftContainer";
            // 
            // leftContainer.Panel1
            // 
            this.leftContainer.Panel1.Controls.Add(this.splitContainer3);
            // 
            // leftContainer.Panel2
            // 
            this.leftContainer.Panel2.Controls.Add(this.rightContainer);
            this.leftContainer.Size = new System.Drawing.Size(691, 393);
            this.leftContainer.SplitterDistance = 347;
            this.leftContainer.TabIndex = 0;
            // 
            // rightContainer
            // 
            this.rightContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.rightContainer.IsSplitterFixed = true;
            this.rightContainer.Location = new System.Drawing.Point(0, 0);
            this.rightContainer.Name = "rightContainer";
            // 
            // rightContainer.Panel1
            // 
            this.rightContainer.Panel1.Controls.Add(this.moveItemLeftButton);
            this.rightContainer.Panel1.Controls.Add(this.moveItemRightButton);
            // 
            // rightContainer.Panel2
            // 
            this.rightContainer.Panel2.Controls.Add(this.splitContainer4);
            this.rightContainer.Size = new System.Drawing.Size(340, 393);
            this.rightContainer.SplitterDistance = 40;
            this.rightContainer.TabIndex = 0;
            // 
            // itemsListView
            // 
            this.itemsListView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.itemsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemsListView.FullRowSelect = true;
            this.itemsListView.HideSelection = false;
            this.itemsListView.Location = new System.Drawing.Point(0, 0);
            this.itemsListView.Name = "itemsListView";
            this.itemsListView.Size = new System.Drawing.Size(347, 359);
            this.itemsListView.TabIndex = 0;
            this.itemsListView.UseCompatibleStateImageBehavior = false;
            this.itemsListView.View = System.Windows.Forms.View.Details;
            this.itemsListView.SelectedIndexChanged += new System.EventHandler(this.itemsListView_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Borrowable Items";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.itemsListView);
            this.splitContainer3.Size = new System.Drawing.Size(347, 393);
            this.splitContainer3.SplitterDistance = 30;
            this.splitContainer3.TabIndex = 2;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer4.IsSplitterFixed = true;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.checkoutLabel);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.checkoutListView);
            this.splitContainer4.Size = new System.Drawing.Size(296, 393);
            this.splitContainer4.SplitterDistance = 30;
            this.splitContainer4.TabIndex = 0;
            // 
            // checkoutLabel
            // 
            this.checkoutLabel.AutoSize = true;
            this.checkoutLabel.Location = new System.Drawing.Point(12, 9);
            this.checkoutLabel.Name = "checkoutLabel";
            this.checkoutLabel.Size = new System.Drawing.Size(98, 13);
            this.checkoutLabel.TabIndex = 0;
            this.checkoutLabel.Text = "Checked Out Items";
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer5.IsSplitterFixed = true;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.leftContainer);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.acceptButton);
            this.splitContainer5.Panel2.Controls.Add(this.cancelButton);
            this.splitContainer5.Size = new System.Drawing.Size(691, 426);
            this.splitContainer5.SplitterDistance = 393;
            this.splitContainer5.TabIndex = 1;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(613, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // acceptButton
            // 
            this.acceptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.acceptButton.Location = new System.Drawing.Point(532, 2);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(75, 23);
            this.acceptButton.TabIndex = 1;
            this.acceptButton.Text = "Accept";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // checkoutListView
            // 
            this.checkoutListView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkoutListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkoutListView.FullRowSelect = true;
            this.checkoutListView.HideSelection = false;
            this.checkoutListView.Location = new System.Drawing.Point(0, 0);
            this.checkoutListView.Name = "checkoutListView";
            this.checkoutListView.Size = new System.Drawing.Size(296, 359);
            this.checkoutListView.TabIndex = 0;
            this.checkoutListView.UseCompatibleStateImageBehavior = false;
            this.checkoutListView.View = System.Windows.Forms.View.Details;
            this.checkoutListView.SelectedIndexChanged += new System.EventHandler(this.checkoutListView_SelectedIndexChanged);
            // 
            // moveItemRightButton
            // 
            this.moveItemRightButton.Location = new System.Drawing.Point(0, 139);
            this.moveItemRightButton.Name = "moveItemRightButton";
            this.moveItemRightButton.Size = new System.Drawing.Size(38, 23);
            this.moveItemRightButton.TabIndex = 0;
            this.moveItemRightButton.Text = "-->";
            this.moveItemRightButton.UseVisualStyleBackColor = true;
            this.moveItemRightButton.Click += new System.EventHandler(this.moveItemRightButton_Click);
            // 
            // moveItemLeftButton
            // 
            this.moveItemLeftButton.Location = new System.Drawing.Point(0, 168);
            this.moveItemLeftButton.Name = "moveItemLeftButton";
            this.moveItemLeftButton.Size = new System.Drawing.Size(38, 23);
            this.moveItemLeftButton.TabIndex = 1;
            this.moveItemLeftButton.Text = "<--";
            this.moveItemLeftButton.UseVisualStyleBackColor = true;
            this.moveItemLeftButton.Click += new System.EventHandler(this.moveItemLeftButton_Click);
            // 
            // CheckInOut
            // 
            this.AcceptButton = this.acceptButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(691, 426);
            this.Controls.Add(this.splitContainer5);
            this.MinimumSize = new System.Drawing.Size(400, 200);
            this.Name = "CheckInOut";
            this.Text = "Check In/Out";
            this.leftContainer.Panel1.ResumeLayout(false);
            this.leftContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.leftContainer)).EndInit();
            this.leftContainer.ResumeLayout(false);
            this.rightContainer.Panel1.ResumeLayout(false);
            this.rightContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rightContainer)).EndInit();
            this.rightContainer.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer leftContainer;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView itemsListView;
        private System.Windows.Forms.SplitContainer rightContainer;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.Label checkoutLabel;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ListView checkoutListView;
        private System.Windows.Forms.Button moveItemLeftButton;
        private System.Windows.Forms.Button moveItemRightButton;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS2450_Library
{
    public partial class MainForm : Form
    {
        Library library = new Library();

        private int selectedCategory = 0;
        private string currentFilepath = "";
        private DateTime currentTime = DateTime.Today;

        private ListViewColumnSorter lvwColumnSorter;

        public MainForm()
        {
            InitializeComponent();
            
            // Initialize GUI Objects
            lvwColumnSorter = new ListViewColumnSorter();
            listView.ListViewItemSorter = lvwColumnSorter;
            listView.DoubleClick += listView_DoubleClick;
            listView.ColumnClick += listView_ColumnClick;

            currentDateStatusLabel.MouseUp += currentDateStatusLabel_Click;
            currentDateStatusLabel.Text = currentTime.ToString("d");

            incrementDateLabel.Click += incrementDateLabel_Click;
            decrementDateLabel.Click += decrementDateLabel_Click;
            
            catalogButtonPanel.Click += catalogButton_Click;
            patronsButtonPanel.Click += patronsButton_Click;
            overdueButtonPanel.Click += overdueButton_Click;
            catalogButtonLabel.Click += catalogButton_Click;
            patronsButtonLabel.Click += patronsButton_Click;
            overdueButtonLabel.Click += overdueButton_Click;

            refreshGUI();
            FormClosing += Form1_FormClosing;

            libraryOpenDialog.FileOk += libraryOpenDialog_FileOk;
            librarySaveDialog.FileOk += librarySaveDialog_FileOk;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            OnExit();
        }

        // Category Selection
        //---------------------------------------------------------------------
        private void catalogButton_Click(object sender, EventArgs e)
        {
            selectedCategory = 0;
            lvwColumnSorter.SortColumn = 0;
            refreshGUI();
        }

        private void patronsButton_Click(object sender, EventArgs e)
        {
            selectedCategory = 1;
            lvwColumnSorter.SortColumn = 0;
            refreshGUI();
        }

        private void overdueButton_Click(object sender, EventArgs e)
        {
            selectedCategory = 2;
            lvwColumnSorter.SortColumn = 0;
            refreshGUI();
        }

        private void refreshGUI()
        {
            catalogButtonPanel.BackColor = (selectedCategory == 0) ? SystemColors.MenuHighlight : SystemColors.Window;
            patronsButtonPanel.BackColor = (selectedCategory == 1) ? SystemColors.MenuHighlight : SystemColors.Window;
            overdueButtonPanel.BackColor = (selectedCategory == 2) ? SystemColors.MenuHighlight : SystemColors.Window;

            addItemButton.Visible = false;
            editItemButton.Visible = false;
            deleteItemButton.Visible = false;
            addPatronButton.Visible = false;
            editPatronButton.Visible = false;
            deletePatronButton.Visible = false;
            checkInOutButton.Visible = false;

            if (selectedCategory == 0)         // Catalog View 
            {
                listView.Columns.Clear();
                listView.Items.Clear();

                listView.Columns.Add("Name", 150);
                listView.Columns.Add("Author", 150);
                listView.Columns.Add("Borrowed By", 150);
                listView.Columns.Add("Borrowed Date", 100);

                foreach (var item in library.GetCatalog())
                {
                    var item1 = new ListViewItem(item.Name);
                    if(item is Book)
                        item1.SubItems.Add((item as Book).Author);
                    else
                        item1.SubItems.Add("");
                    item1.SubItems.Add((item.BorrowedBy == 0) ? "" : item.BorrowedBy.ToString());
                    item1.SubItems.Add((item.BorrowedBy == 0) ? "" : item.BorrowDate.ToString("d"));
                    listView.Items.Add(item1);
                }

                addItemButton.Visible = true;
                editItemButton.Visible = true;
                deleteItemButton.Visible = true;
                editItemButton.Enabled = false;
                deleteItemButton.Enabled = false;
                buttonStripSeparator.Visible = false;
            }
            else if (selectedCategory == 1)    // Patrons View
            {
                listView.Columns.Clear();
                listView.Items.Clear();

                listView.Columns.Add("Id", 30);
                listView.Columns.Add("Name", 150);
                listView.Columns.Add("Address", 200);
                listView.Columns.Add("Date Of Birth", 100);

                foreach (var item in library.GetPatrons())
                {
                    var item1 = new ListViewItem(item.Id.ToString());
                    item1.SubItems.Add(item.Name);
                    item1.SubItems.Add(item.Address);
                    item1.SubItems.Add(item.DateOfBirth.ToString("d"));
                    listView.Items.Add(item1);
                }

                addPatronButton.Visible = true;
                editPatronButton.Enabled = false;
                editPatronButton.Visible = true;
                deletePatronButton.Enabled = false;
                deletePatronButton.Visible = true;
                checkInOutButton.Visible = true;
                checkInOutButton.Enabled = false;
                buttonStripSeparator.Visible = true;
            }
            else if (selectedCategory == 2)    // Overdue Items View
            {
                listView.Columns.Clear();
                listView.Items.Clear();

                listView.Columns.Add("Name", 150);
                listView.Columns.Add("Author", 150);
                listView.Columns.Add("Borrowed By", 150);
                listView.Columns.Add("Borrowed Date", 100);

                foreach (var item in library.GetOverdue(currentTime))
                {
                    var item1 = new ListViewItem(item.Name);
                    if (item is Book)
                        item1.SubItems.Add((item as Book).Author);
                    else
                        item1.SubItems.Add("");
                    item1.SubItems.Add((item.BorrowedBy == 0) ? "" : item.BorrowedBy.ToString());
                    item1.SubItems.Add((item.BorrowedBy == 0) ? "" : item.BorrowDate.ToString("d"));
                    listView.Items.Add(item1);                
                }

                buttonStripSeparator.Visible = false;
            }
        }

        // Date Events
        //---------------------------------------------------------------------
        private void decrementDateLabel_Click(object sender, EventArgs e)
        {
            decrementDate();
        }

        private void incrementDateLabel_Click(object sender, EventArgs e)
        {
            incrementDate();
        }

        private void currentDateStatusLabel_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            if (me.Button == MouseButtons.Left)
            {
                incrementDate();
            } 
            else if (me.Button == MouseButtons.Right)
            {
                decrementDate();
            }
        }
        
        private void incrementDate()
        {
            currentTime = currentTime.AddDays(1);
            currentDateStatusLabel.Text = currentTime.ToString("d");
            if (selectedCategory == 2)  // If current view == Overdue List
            {
                refreshGUI();
            }
        }

        private void decrementDate()
        {
            currentTime = currentTime.AddDays(-1);
            currentDateStatusLabel.Text = currentTime.ToString("d");
            if (selectedCategory == 2)  // If current view == Overdue List
            {
                refreshGUI();
            }
        }

        // List View Events
        //---------------------------------------------------------------------
        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(selectedCategory == 0)       // Catalog View
            {
                if (listView.SelectedItems.Count > 0)
                {
                    editItemButton.Enabled = true;
                    deleteItemButton.Enabled = true;
                }
                else
                {
                    editItemButton.Enabled = false;
                    deleteItemButton.Enabled = false;
                }
            }
            else if(selectedCategory == 1)  // Patrons View
            {
                if (listView.SelectedItems.Count > 0)
                {
                    editPatronButton.Enabled = true;
                    deletePatronButton.Enabled = true;
                    checkInOutButton.Enabled = true;
                }
                else
                {
                    editPatronButton.Enabled = false;
                    deletePatronButton.Enabled = false;
                    checkInOutButton.Enabled = false;
                }
            }
            else if(selectedCategory == 2)  // Overdue View
            {

            }
        }

        private void listView_DoubleClick(object sender, EventArgs e)
        {
            if (selectedCategory == 0)       // Catalog View
            {
                if (listView.SelectedItems.Count > 0)
                {
                    // Show Detailed Item View
                }
            }
            else if (selectedCategory == 1)  // Patrons View
            {
                if (listView.SelectedItems.Count > 0)
                {
                    // Show Check In/Out Dialog for selected patron
                    int patron = int.Parse(listView.SelectedItems[0].Text);
                    var myForm = new CheckInOutForm(library, patron, listView.SelectedItems[1].Text, currentTime);
                    myForm.Show();
                }
            }
            else if (selectedCategory == 2)  // Overdue View
            {
                if (listView.SelectedItems.Count > 0)
                {
                    // Show Check In/Out Dialog for selected item's borrower
                    int patron = int.Parse(listView.SelectedItems[0].Text);
                    var myForm = new CheckInOutForm(library, patron, listView.SelectedItems[1].Text, currentTime);
                    myForm.Show();
                }
            }
        }
        
        void listView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            listView.Sort();
        }

        // Main Menu Events
        //---------------------------------------------------------------------
        private void newCatalogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentFilepath != "")
            {
                library.SaveFile(currentFilepath);
            }

            library = new Library();

            refreshGUI();
        }    

        private void openCatalogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            libraryOpenDialog.ShowDialog();

            refreshGUI();
        }

        private void saveCatalogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(currentFilepath == "")
                librarySaveDialog.ShowDialog();
            else
                library.SaveFile(currentFilepath);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            librarySaveDialog.ShowDialog();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OnExit();
            this.Close();
        }

        private void OnExit()
        {
            if (currentFilepath == "")
            {
                librarySaveDialog.ShowDialog();
            }
            else
            {
                library.SaveFile(currentFilepath);
            }
        }

        // Open and Saving File Dialogs
        //---------------------------------------------------------------------
        private void libraryOpenDialog_FileOk(object sender, CancelEventArgs e)
        {
            this.Activate();
            
            currentFilepath = librarySaveDialog.FileName;

            if(currentFilepath != "")
                library.LoadFile(currentFilepath);
            Text = "Library - " + currentFilepath;
            refreshGUI();
        }

        private void librarySaveDialog_FileOk(object sender, CancelEventArgs e)
        {
            this.Activate();

            currentFilepath = librarySaveDialog.FileName;

            if(currentFilepath != "")
                library.SaveFile(currentFilepath);

            Text = "Library - " + currentFilepath;
        }

        // Toolbar Button Events
        //---------------------------------------------------------------------
        private void addItemButton_Click(object sender, EventArgs e)
        {
            // Show detailed item dialog for a new item
        }

        private void editItemButton_Click(object sender, EventArgs e)
        {
            // Show detailed item dialog for selected item
        }

        private void deleteItemButton_Click(object sender, EventArgs e)
        {
            /*
            if (MessageBox.Show("Are you sure you want to delete " + listView.SelectedItems[0].Text + "?", "Deletion Confirmation", MessageBoxButtons.YesNo) 
                == DialogResult.Yes)
            {
                library.Catalog.Remove(library.Catalog.Find(item => item.Name == listView.SelectedItems[0].Text));
                // library.RemoveItem(listView.SelectedItems[0].Text);
                refreshGUI();
            }
            */
        }

        private void addPatronButton_Click(object sender, EventArgs e)
        {
            // Show detailed item dialog for a new patron
        }

        private void editPatronButton_Click(object sender, EventArgs e)
        {
            // Show detailed item dialog for selected patron
        }

        private void deletePatronButton_Click(object sender, EventArgs e)
        {
            /*
            if (MessageBox.Show("Are you sure you want to delete " + listView.SelectedItems[0].Text + "?", "Deletion Confirmation", MessageBoxButtons.YesNo)
                == DialogResult.Yes)
            {
                // Library.RemovePatron(listView.SelectedItems[0].Text);
                var p = library.Patrons.Find(patron => patron.Name == listView.SelectedItems[0].Text);
                bool hasItem = false;
                foreach (var item in library.Catalog)
                {
                    if (item.BorrowedBy == p.Name)
                        hasItem = true;
                }

                if (hasItem)
                {
                    MessageBox.Show(p.Name + " has borrowed items.", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    library.Patrons.Remove(p);
                    refreshGUI();
                }
            }
            */
        }

        private void checkInOutButton_Click(object sender, EventArgs e)
        {
            // Show Check In/Out Dialog for selected patron
            int patron = int.Parse(listView.SelectedItems[0].Text);
            var myForm = new CheckInOutForm(library, patron, listView.SelectedItems[1].Text, currentTime);
            myForm.Show();
        }
    }
}

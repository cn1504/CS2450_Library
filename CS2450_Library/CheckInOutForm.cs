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
    public partial class CheckInOutForm : Form
    {
        private Library library;
        private int patronId;
        private int patronBorrowLimit;
        private DateTime currentDate;

        private ListViewColumnSorter lvwItemsColumnSorter;
        private ListViewColumnSorter lvwCheckOutColumnSorter;

        public CheckInOutForm(Library library, int patronId, string patronName, DateTime currentDate)
        {
            InitializeComponent();
            
            this.library = library;
            this.currentDate = currentDate;
            this.patronId = patronId;
            Text = Text + " - " + patronName;
            patronBorrowLimit = library.GetPatronBorrowLimit(patronId, currentDate);

            lvwItemsColumnSorter = new ListViewColumnSorter();
            lvwItemsColumnSorter.SortColumn = 0;
            itemsListView.ListViewItemSorter = lvwItemsColumnSorter;
            lvwCheckOutColumnSorter = new ListViewColumnSorter();
            lvwCheckOutColumnSorter.SortColumn = 0;
            checkoutListView.ListViewItemSorter = lvwCheckOutColumnSorter;
            
            itemsListView.ColumnClick += itemsListView_ColumnClick;
            itemsListView.DoubleClick += itemsListView_DoubleClick;
            checkoutListView.ColumnClick += checkoutListView_ColumnClick;
            checkoutListView.DoubleClick += checkoutListView_DoubleClick;

            SizeChanged += CheckInOut_SizeChanged;
            ResizeForm();

            moveItemLeftButton.Enabled = false;
            moveItemRightButton.Enabled = false;

            LoadData();

            checkoutLabel.Text = "Checked Out Items (" + checkoutListView.Items.Count + "/" + patronBorrowLimit + ")";
        }

        void CheckInOut_SizeChanged(object sender, EventArgs e)
        {
            ResizeForm();
        }

        private void ResizeForm()
        {
            leftContainer.SplitterDistance = Width / 2 - 32;
            rightContainer.SplitterDistance = 38;
            moveItemLeftButton.Location = new Point(0, Height / 2 - 46);
            moveItemRightButton.Location = new Point(0, Height / 2 - 23);
        }

        private void LoadData()
        {
            itemsListView.Columns.Add("Name", 150);
            itemsListView.Columns.Add("Author", 150);

            foreach (var item in library.GetAvailableItems(patronId))
            {                
                var item1 = new ListViewItem(item.Name);
                if (item is Book)
                    item1.SubItems.Add((item as Book).Author);
                else
                    item1.SubItems.Add("");
                itemsListView.Items.Add(item1);
            }


            checkoutListView.Columns.Add("Name", 150);
            checkoutListView.Columns.Add("Author", 150);

            foreach (var item in library.GetCheckedItems(patronId))
            {
                var item1 = new ListViewItem(item.Name);
                if (item is Book)
                    item1.SubItems.Add((item as Book).Author);
                else
                    item1.SubItems.Add("");
                checkoutListView.Items.Add(item1);
            }
        }

        // Button Events
        //---------------------------------------------------------------------
        private void acceptButton_Click(object sender, EventArgs e)
        {
            var items = from ListViewItem item in checkoutListView.Items
                        select item.Text;
            library.SetCheckOut(patronId, items, currentDate);           

            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void moveItemRightButton_Click(object sender, EventArgs e)
        {
            MoveItemsRight();
        }

        private void moveItemLeftButton_Click(object sender, EventArgs e)
        {
            MoveItemsLeft();
        }

        private void checkoutListView_DoubleClick(object sender, EventArgs e)
        {
            MoveItemsLeft();
        }

        private void itemsListView_DoubleClick(object sender, EventArgs e)
        {
            MoveItemsRight();
        }

        private void MoveItemsLeft()
        {
            foreach (ListViewItem item in checkoutListView.SelectedItems)
            {
                checkoutListView.Items.Remove(item);
                itemsListView.Items.Add(item);
            }

            checkoutLabel.Text = "Checked Out Items (" + checkoutListView.Items.Count + "/" + patronBorrowLimit + ")";
        }

        private void MoveItemsRight()
        {
            if (itemsListView.SelectedItems.Count + checkoutListView.Items.Count > patronBorrowLimit)
                return;

            foreach (ListViewItem item in itemsListView.SelectedItems)
            {
                itemsListView.Items.Remove(item);
                checkoutListView.Items.Add(item);
            }

            checkoutLabel.Text = "Checked Out Items (" + checkoutListView.Items.Count + "/" + patronBorrowLimit + ")";
        }

        private void itemsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itemsListView.SelectedItems.Count > 0 && 
                itemsListView.SelectedItems.Count + checkoutListView.Items.Count <= patronBorrowLimit)
            {
                moveItemRightButton.Enabled = true;
            }
            else
            {
                moveItemRightButton.Enabled = false;
            }
        }

        private void checkoutListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkoutListView.SelectedItems.Count > 0)
            {
                moveItemLeftButton.Enabled = true;
            }
            else
            {
                moveItemLeftButton.Enabled = false;
            }
        }

        void itemsListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == lvwItemsColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (lvwItemsColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwItemsColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwItemsColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwItemsColumnSorter.SortColumn = e.Column;
                lvwItemsColumnSorter.Order = SortOrder.Ascending;
            }

            itemsListView.Sort();
        }

        void checkoutListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == lvwCheckOutColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (lvwCheckOutColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwCheckOutColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwCheckOutColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwCheckOutColumnSorter.SortColumn = e.Column;
                lvwCheckOutColumnSorter.Order = SortOrder.Ascending;
            }

            checkoutListView.Sort();
        }
    }
}

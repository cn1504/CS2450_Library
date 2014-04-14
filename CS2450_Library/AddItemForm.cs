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
    public partial class AddItemForm : Form
    {
        private Library library;

        public AddItemForm(Library library)
        {
            InitializeComponent();

            this.library = library;
        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            resetGui();
        }

        private void resetGui()
        {
            authorLabel.Visible = false;
            authorTextBox.Visible = false;

            if (typeComboBox.SelectedIndex == 0)  // Adult's book
            {
                authorLabel.Visible = true;
                authorTextBox.Visible = true;
            }
            else if (typeComboBox.SelectedIndex == 1)  // Children's book
            {
                authorLabel.Visible = true;
                authorTextBox.Visible = true;
            }
            else if (typeComboBox.SelectedIndex == 2)  // Dvd
            {
            }
            else if (typeComboBox.SelectedIndex == 3)  // Video tape
            {
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Item item;
            if (typeComboBox.SelectedIndex == 0)  // Adult's book
            {
                item = new Book();
                item.Name = nameTextBox.Text;
                (item as Book).Author = authorTextBox.Text;
                (item as Book).IsChild = false;
            }
            else if (typeComboBox.SelectedIndex == 1)  // Children's book
            {
                item = new Book();
                item.Name = nameTextBox.Text;
                (item as Book).Author = authorTextBox.Text;
                (item as Book).IsChild = true;
            }
            else if (typeComboBox.SelectedIndex == 2)  // Dvd
            {
                item = new Media();
                item.Name = nameTextBox.Text;
                (item as Media).IsDvd = true;
            }
            else // if (typeComboBox.SelectedIndex == 3)  // Video tape
            {
                item = new Media();
                item.Name = nameTextBox.Text;
                (item as Media).IsDvd = false;
            }

            // Validation
            if(item.Name != "")
            {
                if (library.AddItem(item))
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Item already in library.");
                }
            }
            else
            {
                MessageBox.Show("Invalid item name.");
            }
        }

        private void AddItemForm_Load(object sender, EventArgs e)
        {
            typeComboBox.SelectedIndex = 0;
        }
    }
}

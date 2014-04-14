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
    public partial class AddPatronForm : Form
    {
        private Library library;

        public AddPatronForm(Library library)
        {
            InitializeComponent();

            this.library = library;
        }

        private void AddPatronForm_Load(object sender, EventArgs e)
        {
            dobDateTimePicker.MaxDate = DateTime.Today;
            dobDateTimePicker.Value = DateTime.Today;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // Validation
            if (nameTextBox.Text == "" || addressTextBox.Text == "" || dobDateTimePicker.Value == DateTime.Today)
            {
                MessageBox.Show("Invalid data.");
                return;
            }

            var patron = new Patron();
            patron.Name = nameTextBox.Text;
            patron.Address = addressTextBox.Text;
            patron.DateOfBirth = dobDateTimePicker.Value;
            library.AddPatron(patron);
            this.Close();
        }
    }
}

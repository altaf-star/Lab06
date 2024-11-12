using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ListArrayListDemo
{
    public partial class Form1 : Form
    {
        private List<string> itemsList;

        public Form1()
        {
            InitializeComponent();
            itemsList = new List<string>(); // Initialize the list
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text.Trim();
            if (!string.IsNullOrEmpty(input))
            {
                itemsList.Add(input); // Add input to the list
                txtInput.Clear(); // Clear the input field
                lblMessage.Text = "Item added."; // Update the message label
            }
            else
            {
                lblMessage.Text = "Please enter a valid item."; // Show error message
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text.Trim();
            if (itemsList.Remove(input))
            {
                lblMessage.Text = "Item removed."; // Update the message label
            }
            else
            {
                lblMessage.Text = "Item not found."; // Show error message
            }
            txtInput.Clear(); // Clear the input field
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            lstItems.Items.Clear(); // Clear the ListBox
            foreach (string item in itemsList)
            {
                lstItems.Items.Add(item); // Add items to the ListBox
            }
            lblMessage.Text = "Items displayed."; // Update the message label
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            itemsList.Clear(); // Clear the list
            lstItems.Items.Clear(); // Clear the ListBox
            lblMessage.Text = "All items cleared."; // Update the message label
        }
    }
}
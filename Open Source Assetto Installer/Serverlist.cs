using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Serverlist : Form
    {
        public Serverlist()
        {
            InitializeComponent();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Get the selected URL from the ComboBox
            string selectedUrl = guna2ComboBox1.SelectedItem.ToString();
            try
            {
                // Open the selected URL in the default web browser
                Process.Start(new ProcessStartInfo(selectedUrl) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Serverlist_Load(object sender, EventArgs e)
        {

        }
    }
}

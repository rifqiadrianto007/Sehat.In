using Project_PBO.App.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_PBO
{
    public partial class UsKritik : Form
    {
        private string UserID;
        public UsKritik()
        {
            InitializeComponent();
            this.UserID = UserID;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //saran
        }

        private void button2_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Show();
            this.Hide();
            user.FormClosed += (s, args) => this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsArtikel artikel = new UsArtikel();
            artikel.Show();
            this.Hide();
            artikel.FormClosed += (s, args) => this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Datadiri data = new Datadiri();
            data.Show();
            this.Hide();
            data.FormClosed += (s, args) => this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            form.Show();
            this.Hide();
            form.FormClosed += (s, args) => this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //kritik
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Capture feedback from text boxes
            string kritik = tbkritik.Text.Trim();
            string saran = tbsaran.Text.Trim();

            // Ensure that the feedback is not empty
            if (string.IsNullOrEmpty(kritik) && string.IsNullOrEmpty(saran))
            {
                MessageBox.Show("Please enter your feedback.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get the current user's ID from the login session
            int? userId = Login.UserId;

            if (userId == null)
            {
                MessageBox.Show("User ID is not available. Please login again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Insert feedback into the database using the context
                kritikSaranContext.Insert(kritik, saran, userId.Value);
                MessageBox.Show("Thank you for your feedback!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Close the form
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }








    }
    }


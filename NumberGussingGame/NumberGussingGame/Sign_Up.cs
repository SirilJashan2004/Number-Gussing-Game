using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGussingGame
{
    public partial class Sign_Up : Form
    {
        public Sign_Up()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string phoneNumber = txtPhoneNumber.Text.Trim();

            if (string.IsNullOrEmpty(username) || !System.Text.RegularExpressions.Regex.IsMatch(phoneNumber, @"^\d{10}$"))
            {
                MessageBox.Show("Please enter valid username and phone number.");
                return;
            }

            string connectionString = "Data Source=SIRL552\\SQLEXPRESS01;Initial Catalog=GuessingGameDB;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string checkQuery = "SELECT COUNT(*) FROM Users WHERE Username = @Username OR PhoneNumber = @PhoneNumber";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@Username", username);
                    checkCmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);

                    int count = (int)checkCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Username or Phone Number already exists.");
                        return;
                    }
                }

                string query = "INSERT INTO Users (Username, PhoneNumber) VALUES (@Username, @PhoneNumber); SELECT SCOPE_IDENTITY();";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);

                    int userId = Convert.ToInt32(cmd.ExecuteScalar());
                    MessageBox.Show("Sign-Up Successful");

                    Game gameForm = new Game(userId, username);
                    gameForm.Show();
                    this.Hide();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}

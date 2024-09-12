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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace NumberGussingGame
{
    public partial class Game : Form
    {
        private int userId;
        private string username;
        private int targetNumber;
        private int attempts;

        public Game(int userId, string username)
        {
            InitializeComponent();
            this.userId = userId;
            this.username = username;
            lblUsername.Text = $"Username: {username}";
            LoadUserStats();
            StartNewGame();
        }

        private void LoadUserStats()
        {
            string connectionString = "Data Source=SIRL552\\SQLEXPRESS01;Initial Catalog=GuessingGameDB;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT MIN(Attempts), MAX(LastLogin) FROM GameStats WHERE UserID = @UserID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", userId);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        int minAttempts = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                        DateTime lastLogin = reader.IsDBNull(1) ? DateTime.MinValue : reader.GetDateTime(1);

                        lblMinAttempts.Text = $"Minimum Attempts: {minAttempts}";
                        lblLastLogin.Text = $"Last Login: {lastLogin.ToString("g")}";
                    }
                    else
                    {
                        lblMinAttempts.Text = "Minimum Attempts: N/A";
                        lblLastLogin.Text = "Last Login: N/A";
                    }
                }
            }
        }

        private void StartNewGame()
        {
            Random random = new Random();
            targetNumber = random.Next(1, 101);
            attempts = 0;
            lblCurrentAttempts.Text = $"Current Game Attempts: {attempts}";
            txtGuess.Clear(); 
        }

        private void btnSubmitGuess_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtGuess.Text, out int guessedNumber))
            {
                attempts++;
                lblCurrentAttempts.Text = $"Current Game Attempts: {attempts}";

                if (guessedNumber == targetNumber)
                {
                    MessageBox.Show($"Correct! You guessed it in {attempts} attempts.");
                    SaveGameStats();
                }
                else if (guessedNumber < targetNumber)
                {
                    MessageBox.Show("Too low! Try again.");
                    txtGuess.Clear();
                }
                else
                {
                    MessageBox.Show("Too high! Try again.");
                    txtGuess.Clear();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }

        private void SaveGameStats()
        {
            string connectionString = "Data Source=SIRL552\\SQLEXPRESS01;Initial Catalog=GuessingGameDB;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO GameStats (UserID, Attempts, LastLogin) VALUES (@UserID, @Attempts, GETDATE())";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", userId);
                    cmd.Parameters.AddWithValue("@Attempts", attempts);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void btnRestartGame_Click(object sender, EventArgs e)
        {
            StartNewGame(); 
        }

        private void btnPlayerList_Click(object sender, EventArgs e)
        {
            Form playerListForm = new Form
            {
                Text = "Player List Sorted by Attempts",
                Size = new Size(600, 400)
            };

            
            DataGridView dgvPlayers = new DataGridView
            {
                Dock = DockStyle.Fill,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                ReadOnly = true,
                AllowUserToAddRows = false
            };

           
            playerListForm.Controls.Add(dgvPlayers);

           
            LoadPlayerDataSortedByAttempts(dgvPlayers);

          
            playerListForm.ShowDialog();
        }
        private void LoadPlayerDataSortedByAttempts(DataGridView dgv)
        {
            string connectionString = "Data Source=SIRL552\\SQLEXPRESS01;Initial Catalog=GuessingGameDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();


                string query = @"
            SELECT u.Username, 
                   MIN(gs.Attempts) AS MinAttempts, 
                   MAX(gs.LastLogin) AS LastLogin
            FROM Users u
            LEFT JOIN GameStats gs ON u.UserID = gs.UserID
            GROUP BY u.Username
            ORDER BY MinAttempts ASC";  

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable playerData = new DataTable();
                    adapter.Fill(playerData);
                    dgv.DataSource = playerData;
                }
            }
        }
    }
}


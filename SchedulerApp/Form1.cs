using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace SchedulerApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                DBConnection.conn.Open();
                MessageBox.Show("Database Connected!");
                DBConnection.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            string password = txtPass.Text;

            DBConnection.conn.Open();

            string query = "SELECT * FROM users WHERE userName=@user AND password=@pass";
            MySqlCommand cmd = new MySqlCommand(query, DBConnection.conn);

            cmd.Parameters.AddWithValue("@user", username);
            cmd.Parameters.AddWithValue("@pass", password);

            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                MessageBox.Show("Login Successful");
                CheckUpcomingAppointments();

                MainForm main = new MainForm();
                main.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }

            reader.Close();
            DBConnection.conn.Close();
        }

        private void CheckUpcomingAppointments()
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    string query = @"
                SELECT appointmentId, start
                FROM appointments
                WHERE start BETWEEN @now AND @fifteen";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    DateTime now = DateTime.Now;
                    DateTime fifteen = now.AddMinutes(15);

                    cmd.Parameters.AddWithValue("@now", now);
                    cmd.Parameters.AddWithValue("@fifteen", fifteen);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        int apptId = Convert.ToInt32(reader["appointmentId"]);
                        DateTime start = Convert.ToDateTime(reader["start"]);

                        MessageBox.Show(
                            "Upcoming appointment!\n\n" +
                            "Appointment ID: " + apptId +
                            "\nStart Time: " + start
                        );
                    }
                    else
                    {
                        MessageBox.Show("No appointments within 15 minutes.");
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LogLoginHistory(string username)
        {
            try
            {
                string path = "Login_History.txt";

                string log =
                    username + " logged in at " +
                    DateTime.Now.ToString() +
                    Environment.NewLine;

                File.AppendAllText(path, log);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

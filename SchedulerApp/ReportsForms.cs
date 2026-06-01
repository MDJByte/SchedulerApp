using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchedulerApp
{
    public partial class ReportsForms : Form
    {
        public ReportsForms()
        {
            InitializeComponent();
        }

        private void ReportsForms_Load(object sender, EventArgs e)
        {
            cmbReports.Items.Clear();

            cmbReports.Items.Add("Appointment Types By Month");
            cmbReports.Items.Add("Schedule By Customer");
        }

        private void btnLoadReports_Click(object sender, EventArgs e)
        {
            
        }

        private void LoadScheduleByCustomer()
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    string query = @"
                SELECT 
                    c.name AS Customer,
                    a.title,
                    a.type,
                    a.start,
                    a.end
                FROM appointments a
                JOIN customers c ON a.customerId = c.customerId
                ORDER BY c.name, a.start";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dgvReports.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void LoadAppointmentTypesByMonth()
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    MySqlDataAdapter adapter =
                        new MySqlDataAdapter("SELECT * FROM appointments", conn);

                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    MessageBox.Show(table.Rows.Count.ToString());

                    dgvReports.DataSource = null;
                    dgvReports.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLoadReport_Click(object sender, EventArgs e)
        {
            int index = cmbReports.SelectedIndex;

            if (index == -1)
            {
                MessageBox.Show("Select a report.");
                return;
            }

            if (index == 0)
            {
                LoadAppointmentTypesByMonth();
            }
            else if (index == 1)
            {
                LoadScheduleByCustomer();
            }
        }

        private void z(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

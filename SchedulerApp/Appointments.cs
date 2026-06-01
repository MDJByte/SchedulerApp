using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SchedulerApp
{
    public partial class AppointmentForm : Form
    {
        private int selectedAppointmentId = -1;

        public AppointmentForm()
        {
            InitializeComponent();

            dgvAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAppointments.MultiSelect = false;
            dgvAppointments.ReadOnly = true;
            dgvAppointments.AllowUserToAddRows = false;

            dgvAppointments.CellClick += dgvAppointments_CellClick;

            LoadCustomersIntoCombo();
            LoadAppointments();
        }

        // =========================
        // LOAD CUSTOMERS
        // =========================
        private void LoadCustomersIntoCombo()
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    string query =
                        "SELECT customerId, name FROM customers";

                    MySqlDataAdapter adapter =
                        new MySqlDataAdapter(query, conn);

                    DataTable table = new DataTable();

                    adapter.Fill(table);

                    cmbCustomer.DataSource = table;
                    cmbCustomer.DisplayMember = "name";
                    cmbCustomer.ValueMember = "customerId";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // =========================
        // LOAD APPOINTMENTS
        // =========================
        private void LoadAppointments()
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    string query = @"
                        SELECT appointmentId,
                               customerId,
                               title,
                               type,
                               start,
                               end
                        FROM appointments";

                    MySqlDataAdapter adapter =
                        new MySqlDataAdapter(query, conn);

                    DataTable table = new DataTable();

                    adapter.Fill(table);

                    dgvAppointments.DataSource = null;
                    dgvAppointments.DataSource = table;

                    dgvAppointments.ClearSelection();

                    selectedAppointmentId = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // =========================
        // SELECT ROW
        // =========================
        private void dgvAppointments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                DataGridView grid = (DataGridView)sender;

                DataGridViewRow row =
                    grid.Rows[e.RowIndex];

                selectedAppointmentId =
                    Convert.ToInt32(row.Cells[0].Value);

                cmbCustomer.SelectedValue =
                    row.Cells[1].Value;

                txtTitle.Text =
                    row.Cells[2].Value?.ToString() ?? "";

                txtType.Text =
                    row.Cells[3].Value?.ToString() ?? "";

                dtStart.Value =
                    Convert.ToDateTime(row.Cells[4].Value)
                    .ToLocalTime();

                dtEnd.Value =
                    Convert.ToDateTime(row.Cells[5].Value)
                    .ToLocalTime();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Row selection error: " + ex.Message);
            }
        }

        // =========================
        // BUSINESS HOURS CHECK
        // =========================
        private bool IsWithinBusinessHours(DateTime start, DateTime end)
        {
            if (start.DayOfWeek == DayOfWeek.Saturday ||
                start.DayOfWeek == DayOfWeek.Sunday)
            {
                return false;
            }

            TimeSpan open = new TimeSpan(9, 0, 0);
            TimeSpan close = new TimeSpan(17, 0, 0);

            if (start.TimeOfDay < open ||
                end.TimeOfDay > close)
            {
                return false;
            }

            return true;
        }

        // =========================
        // OVERLAP CHECK
        // =========================
        private bool HasOverlap(
            int customerId,
            DateTime start,
            DateTime end)
        {
            using (MySqlConnection conn =
                DBConnection.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT COUNT(*)
                    FROM appointments
                    WHERE customerId = @customerId
                    AND (@start < end
                    AND @end > start)
                    AND appointmentId <> @id";

                MySqlCommand cmd =
                    new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue(
                    "@customerId", customerId);

                cmd.Parameters.AddWithValue(
                    "@start", start.ToUniversalTime());

                cmd.Parameters.AddWithValue(
                    "@end", end.ToUniversalTime());

                cmd.Parameters.AddWithValue(
                    "@id", selectedAppointmentId);

                int count =
                    Convert.ToInt32(cmd.ExecuteScalar());

                return count > 0;
            }
        }

        // =========================
        // ADD APPOINTMENT
        // =========================
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime start = dtStart.Value;
                DateTime end = dtEnd.Value;

                int customerId =
                    Convert.ToInt32(cmbCustomer.SelectedValue);

                if (!IsWithinBusinessHours(start, end))
                {
                    MessageBox.Show(
                        "Appointments must be between 9AM and 5PM Monday-Friday.");

                    return;
                }

                if (HasOverlap(customerId, start, end))
                {
                    MessageBox.Show(
                        "Appointment overlaps with another appointment.");

                    return;
                }

                using (MySqlConnection conn =
                    DBConnection.GetConnection())
                {
                    conn.Open();

                    string query = @"
                        INSERT INTO appointments
                        (customerId, title, type, start, end)
                        VALUES
                        (@customerId, @title, @type, @start, @end)";

                    MySqlCommand cmd =
                        new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue(
                        "@customerId", customerId);

                    cmd.Parameters.AddWithValue(
                        "@title", txtTitle.Text.Trim());

                    cmd.Parameters.AddWithValue(
                        "@type", txtType.Text.Trim());

                    // TIMEZONE FIX
                    cmd.Parameters.AddWithValue(
                        "@start",
                        start.ToUniversalTime());

                    cmd.Parameters.AddWithValue(
                        "@end",
                        end.ToUniversalTime());

                    cmd.ExecuteNonQuery();
                }

                LoadAppointments();
                ClearForm();

                MessageBox.Show("Appointment added.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Add error: " + ex.Message);
            }
        }

        // =========================
        // UPDATE APPOINTMENT
        // =========================
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedAppointmentId <= 0)
                {
                    MessageBox.Show(
                        "Select an appointment first.");

                    return;
                }

                DateTime start = dtStart.Value;
                DateTime end = dtEnd.Value;

                int customerId =
                    Convert.ToInt32(cmbCustomer.SelectedValue);

                if (!IsWithinBusinessHours(start, end))
                {
                    MessageBox.Show(
                        "Appointments must be between 9AM and 5PM Monday-Friday.");

                    return;
                }

                if (HasOverlap(customerId, start, end))
                {
                    MessageBox.Show(
                        "Appointment overlaps with another appointment.");

                    return;
                }

                using (MySqlConnection conn =
                    DBConnection.GetConnection())
                {
                    conn.Open();

                    string query = @"
                        UPDATE appointments
                        SET customerId=@customerId,
                            title=@title,
                            type=@type,
                            start=@start,
                            end=@end
                        WHERE appointmentId=@id";

                    MySqlCommand cmd =
                        new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue(
                        "@customerId", customerId);

                    cmd.Parameters.AddWithValue(
                        "@title", txtTitle.Text.Trim());

                    cmd.Parameters.AddWithValue(
                        "@type", txtType.Text.Trim());

                    // TIMEZONE FIX
                    cmd.Parameters.AddWithValue(
                        "@start",
                        start.ToUniversalTime());

                    cmd.Parameters.AddWithValue(
                        "@end",
                        end.ToUniversalTime());

                    cmd.Parameters.AddWithValue(
                        "@id", selectedAppointmentId);

                    cmd.ExecuteNonQuery();
                }

                LoadAppointments();
                ClearForm();

                MessageBox.Show("Appointment updated.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Update error: " + ex.Message);
            }
        }

        // =========================
        // DELETE APPOINTMENT
        // =========================
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedAppointmentId == -1)
                {
                    MessageBox.Show(
                        "Select an appointment first.");

                    return;
                }

                using (MySqlConnection conn =
                    DBConnection.GetConnection())
                {
                    conn.Open();

                    string query =
                        "DELETE FROM appointments WHERE appointmentId=@id";

                    MySqlCommand cmd =
                        new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue(
                        "@id", selectedAppointmentId);

                    cmd.ExecuteNonQuery();
                }

                LoadAppointments();
                ClearForm();

                MessageBox.Show("Appointment deleted.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Delete error: " + ex.Message);
            }
        }

        // =========================
        // CLEAR FORM
        // =========================
        private void ClearForm()
        {
            selectedAppointmentId = -1;

            txtTitle.Clear();
            txtType.Clear();

            dgvAppointments.ClearSelection();
        }

        // =========================
        // CALENDAR FILTER
        // =========================
        private void monthCalendar1_DateChanged(
            object sender,
            DateRangeEventArgs e)
        {
            try
            {
                using (MySqlConnection conn =
                    DBConnection.GetConnection())
                {
                    conn.Open();

                    string query = @"
                        SELECT appointmentId,
                               customerId,
                               title,
                               type,
                               start,
                               end
                        FROM appointments
                        WHERE DATE(start) = @date";

                    MySqlCommand cmd =
                        new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue(
                        "@date",
                        monthCalendar1.SelectionStart.Date);

                    MySqlDataAdapter adapter =
                        new MySqlDataAdapter(cmd);

                    DataTable table = new DataTable();

                    adapter.Fill(table);

                    dgvAppointments.DataSource = null;
                    dgvAppointments.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnnUpdate_Click(object sender, EventArgs e)
        {
            btnUpdate_Click(sender, e);
        }
    }
}

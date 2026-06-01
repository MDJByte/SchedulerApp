using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SchedulerApp
{
    public partial class CustomerForm : Form
    {
        // Stores currently selected customer ID
        private int selectedId = -1;

        public CustomerForm()
        {
            InitializeComponent();

            // Grid settings
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.MultiSelect = false;
            dgvCustomers.ReadOnly = true;
            dgvCustomers.AllowUserToAddRows = false;

            // IMPORTANT
            dgvCustomers.CellClick += dgvCustomers_CellClick;

            LoadCustomers();
        }

        // =========================
        // LOAD CUSTOMERS
        // =========================
        private void LoadCustomers()
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    string query =
                        "SELECT customerId, name, address, phone FROM customers";

                    MySqlDataAdapter adapter =
                        new MySqlDataAdapter(query, conn);

                    DataTable table = new DataTable();

                    adapter.Fill(table);

                    dgvCustomers.DataSource = null;
                    dgvCustomers.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // =========================
        // CLICK ROW
        // =========================
        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvCustomers.Rows[e.RowIndex];

            selectedId = Convert.ToInt32(row.Cells[0].Value);

            txtName.Text = row.Cells[1].Value.ToString();
            txtAddress.Text = row.Cells[2].Value.ToString();
            txtPhone.Text = row.Cells[3].Value.ToString();

            MessageBox.Show("Selected ID = " + selectedId);
        }

        // =========================
        // ADD CUSTOMER
        // =========================
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    string query = @"
                        INSERT INTO customers (name, address, phone)
                        VALUES (@name, @address, @phone)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@name", txtName.Text.Trim());
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text.Trim());
                    cmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());

                    cmd.ExecuteNonQuery();
                }

                LoadCustomers();

                MessageBox.Show("Customer added.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // =========================
        // UPDATE CUSTOMER
        // =========================
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("UPDATE CLICKED");

                

                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    string query = @"
                UPDATE customers
                SET name=@name,
                    address=@address,
                    phone=@phone
                WHERE customerId=@id";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@name", txtName.Text.Trim());
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text.Trim());
                    cmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());
                    cmd.Parameters.AddWithValue("@id", selectedId);

                    int rows = cmd.ExecuteNonQuery();

                    
                }

                LoadCustomers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // =========================
        // DELETE CUSTOMER
        // =========================
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedId == -1)
                {
                    MessageBox.Show("Select a customer first.");
                    return;
                }

                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    string query =
                        "DELETE FROM customers WHERE customerId=@id";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@id", selectedId);

                    int rows = cmd.ExecuteNonQuery();

                    MessageBox.Show("Rows Deleted: " + rows);
                }

                // RESET
                selectedId = -1;

                dgvCustomers.ClearSelection();

                LoadCustomers();

                txtName.Clear();
                txtAddress.Clear();
                txtPhone.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool IsValidPhone(string phone)
        {
            foreach (char c in phone)
            {
                if (!char.IsDigit(c) && c != '-')
                {
                    return false;
                }
            }

            return phone.Length > 0;
        }
    }
}

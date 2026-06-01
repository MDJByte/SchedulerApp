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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            CustomerForm form = new CustomerForm();
            form.Show();
        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            AppointmentForm form = new AppointmentForm();
            form.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ReportsForms rf = new ReportsForms();
            rf.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}

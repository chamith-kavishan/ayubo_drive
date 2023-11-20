using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AyuboDrive
{
    public partial class formHireCalculator : Form
    {
        public formHireCalculator()
        {
            InitializeComponent();
            labelUsername.Text = login.SetValueForUsername;
        }

        private void formHireCalculator_Load(object sender, EventArgs e)
        {

        }

        private void buttonRates_Click(object sender, EventArgs e)
        {
            FormRates rates = new FormRates();
            rates.Visible = true;
            this.Hide();
        }

        private void buttonRentCal_Click(object sender, EventArgs e)
        {
            formRentCalculator rentCalculator = new formRentCalculator();
            rentCalculator.Visible = true;
            this.Hide();
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            formDashboard dashboard = new formDashboard();
            dashboard.Visible = true;
            this.Hide();
        }

        private void buttonVehicles_Click(object sender, EventArgs e)
        {
            vehicles vehicles = new vehicles();
            vehicles.Visible = true;
            this.Hide();
        }

        private void buttonVehicleType_Click(object sender, EventArgs e)
        {
            vehicleType vehicleType = new vehicleType();
            vehicleType.Visible = true;
            this.Hide();
        }

        private void buttonVehicleTypes_Click(object sender, EventArgs e)
        {
            packages packages = new packages();
            packages.Visible = true;
            this.Hide();
        }

        private void buttonDayTour_Click(object sender, EventArgs e)
        {
            dayTour dayTour = new dayTour();
            dayTour.Visible = true;
            this.Hide();
        }

        private void buttonLongTour_Click(object sender, EventArgs e)
        {
            longTour longTour  = new longTour();
            longTour.Visible = true;
            this.Hide();
        }

        private void buttonClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}

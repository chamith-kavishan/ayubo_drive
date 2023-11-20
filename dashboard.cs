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
    public partial class formDashboard : Form
    {
        public formDashboard()
        {
            InitializeComponent();
            labelUsername.Text = login.SetValueForUsername;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

        private void buttonDashboard_Click(object sender, EventArgs e)
        {

        }

        private void buttonVehicleTypes_Click(object sender, EventArgs e)
        {
            packages packages = new packages();
            packages.Visible = true;
            this.Hide();
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

        private void buttonHireCal_Click(object sender, EventArgs e)
        {
            formHireCalculator hireCalculator = new formHireCalculator();
            hireCalculator.Visible = true;
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}

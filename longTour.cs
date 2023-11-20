using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AyuboDrive
{
    public partial class longTour : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=CHAMITH-ROG-STR;Initial Catalog=AyuboDrive;Integrated Security=True;MultipleActiveResultSets=true");
        public longTour()
        {
            InitializeComponent();
            labelBaseHire.Text = "";
            labelExtraKmCharge.Text = "";
            labelOvernightCharge.Text = "";
            labelVehicleNightParkCharge.Text = "";
            labelTotal.Text = "";
            labelUsername.Text = login.SetValueForUsername;
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

        private void buttonBack_Click(object sender, EventArgs e)
        {
            formHireCalculator hireCalculator = new formHireCalculator();
            hireCalculator.Visible = true;
            this.Hide();
        }

        private void longTour_Load(object sender, EventArgs e)
        {

        }

        private void labelBaseHire_Click(object sender, EventArgs e)
        {

        }

        private void textBoxVehicle_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxPackage_Click(object sender, EventArgs e)
        {
            if (textBoxVehicle.Text != string.Empty)
            {
                int vehicle = Convert.ToInt32(textBoxVehicle.Text);

                con.Open();

                SqlCommand vehicleType = new SqlCommand("SELECT VehicleType FROM Vehicle WHERE ID = " + vehicle, con);
                SqlDataReader d_vehicleType = vehicleType.ExecuteReader();
                int vehicle_Type = 0;
                while (d_vehicleType.Read())
                {
                    vehicle_Type = Convert.ToInt32(d_vehicleType[0]);
                }

                DataRow dataRow;
                SqlCommand cmd = new SqlCommand("SELECT Package.ID, Package.Name FROM Package WHERE PackageType = 2 AND VehicleType = " + vehicle_Type, con);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dataRow = dataTable.NewRow();

                dataRow.ItemArray = new object[] { 0, "Select package type" };
                dataTable.Rows.InsertAt(dataRow, 0);

                comboBoxPackage.ValueMember = "ID";
                comboBoxPackage.DisplayMember = "Name";
                comboBoxPackage.DataSource = dataTable;

                con.Close();
            }
            else
            {
                MessageBox.Show("Please insert vehicle ID");
            }
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            int package = Convert.ToInt32(comboBoxPackage.SelectedValue);

            /*string myString = package.ToString();
            MessageBox.Show(myString);*/

            if (textBoxVehicle.Text != string.Empty && textBoxStartKm.Text != string.Empty && textBoxEndKm.Text != string.Empty)
            {
            //string myString = package.ToString();
            //MessageBox.Show(myString);
            con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Package.MaxKmLimit, Package.MaxHours, Package.PackageCost FROM Package WHERE ID =" + package, con);
                SqlDataReader packageData = cmd.ExecuteReader();
                float maxKmLimit = 0;
                int maxHours = 0;
                int packageCost = 0;
                while (packageData.Read())
                {
                    maxKmLimit = Convert.ToSingle(packageData[0]);
                    maxHours = Convert.ToInt32(packageData[1]);
                    packageCost = Convert.ToInt32(packageData[2]);
                }

                SqlCommand rates = new SqlCommand("SELECT Rate.ExtraKmRate, Rate.DriverOvernightRate, Rate.VehicleNightParkRate FROM Rate WHERE Package =" + package, con);
                SqlDataReader rateData = rates.ExecuteReader();
                float extraKmRate = 0;
                int driverOvernightRate = 0;
                int vehicleNightParkRate = 0;
                while (rateData.Read())
                {
                    extraKmRate = Convert.ToSingle(rateData[0]);
                    driverOvernightRate = Convert.ToInt32(rateData[1]);
                    vehicleNightParkRate = Convert.ToInt32(rateData[2]);
                }

                int days = (dateTimePickerEndDate.Value - dateTimePickerStartDate.Value).Days;
                int hours = days * 24;
                float extraKmCharge = 0;

                float startKm = Convert.ToSingle(textBoxStartKm.Text);
                float endKm = Convert.ToSingle(textBoxEndKm.Text);

                float km = endKm - startKm;

                int driverOvernightCharge = 0;
                int vehicleNightParkCharge = 0;

                if (days > 1)
                {
                    driverOvernightCharge = driverOvernightRate * (days - 1);
                    vehicleNightParkCharge = vehicleNightParkRate * (days - 1);
                }
                else
                {
                    driverOvernightCharge = 0;
                    vehicleNightParkCharge = 0;
                }

                if (km > maxKmLimit)
                {
                    extraKmCharge = (km - maxKmLimit) * extraKmRate;
                }
                else
                {
                    extraKmCharge = 0;
                }

                float Total = packageCost + extraKmCharge + driverOvernightCharge + vehicleNightParkCharge;

                labelBaseHire.Text = "Base hire charge: LKR " + packageCost;
                labelExtraKmCharge.Text = "Extra Km charge: LKR " + extraKmCharge;
                labelOvernightCharge.Text = "Driver overnight charge: LKR " + driverOvernightCharge;
                labelVehicleNightParkCharge.Text = "Vehicle nightpark charge: LKR " + vehicleNightParkCharge;
                labelTotal.Text = "Total hire charge: LKR " + Total;

                int customer = 1;

                SqlCommand add_cmd = new SqlCommand("INSERT INTO [Hire-LongTour] VALUES(@Customer, @Package, @ExtraKmCharge, @DriverOverNightCharge, @VehicleNightParkCharge, @Total)", con);
                add_cmd.Parameters.AddWithValue("Customer", customer);
                add_cmd.Parameters.AddWithValue("Package", package);
                add_cmd.Parameters.AddWithValue("ExtraKmCharge", extraKmCharge);
                add_cmd.Parameters.AddWithValue("DriverOverNightCharge", driverOvernightCharge);
                add_cmd.Parameters.AddWithValue("VehicleNightParkCharge", vehicleNightParkCharge);
                add_cmd.Parameters.AddWithValue("Total", Total);
                add_cmd.ExecuteNonQuery();

                con.Close();
            }
            else
            {
                messageIncorrect messageIncorrect = new messageIncorrect();
                messageIncorrect.Visible = true;
            }
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

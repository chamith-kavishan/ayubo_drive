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
    public partial class FormRates : Form
    {
        //connecting to the database
        SqlConnection con = new SqlConnection(@"Data Source=CHAMITH-ROG-STR;Initial Catalog=AyuboDrive;Integrated Security=True");
        int ID = 0;

        public FormRates()
        {
            InitializeComponent();
            rate_Data();
            selection_DropDown();
            labelUsername.Text = login.SetValueForUsername;
        }

        //rates dropdown
        private void selection_DropDown()
        {
            con.Open();
            DataRow dataRow;

            SqlCommand cmd = new SqlCommand("SELECT Package.ID, VehicleType.VehicleType, Package.Name FROM Package LEFT JOIN VehicleType on Package.VehicleType = VehicleType.ID", con);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataRow = dataTable.NewRow();

            /*dataRow.ItemArray = new object[] { 0, "Select Package" };
            dataTable.Rows.InsertAt(dataRow, 0);*/

            comboBoxPackage.ValueMember = "ID";

            dataTable.Columns.Add("ThePackage", typeof(string), "Name + ' on ' + VehicleType");
            comboBoxPackage.DisplayMember = "ThePackage";
            comboBoxPackage.DataSource = dataTable;

            con.Close();
        }

        private void rate_Data()
        {
            con.Open();
            SqlCommand data = new SqlCommand("SELECT Rate.ID, Package.VehicleType, Package.Name, Rate.ExtraKmRate, Rate.ExtraHourRate, Rate.DriverOvernightRate, Rate.VehicleNightParkRate FROM Rate LEFT JOIN Package on Rate.Package = Package.ID", con);
            dataGridViewRates.AutoGenerateColumns = true;
            SqlDataAdapter v_data = new SqlDataAdapter(data);
            DataTable v_dt = new DataTable();
            v_data.Fill(v_dt);
            dataGridViewRates.DataSource = v_dt;
            dataGridViewRates.Columns[0].HeaderText = "Rate ID";
            dataGridViewRates.Columns[1].HeaderText = "Vehicle Type";
            dataGridViewRates.Columns[2].HeaderText = "Package";
            dataGridViewRates.Columns[3].HeaderText = "Extra Km Rate";
            dataGridViewRates.Columns[4].HeaderText = "Extra Hour Rate";
            dataGridViewRates.Columns[5].HeaderText = "Driver Overnight Rate";
            dataGridViewRates.Columns[6].HeaderText = "Vehicle Night Park Rate";
            con.Close();
        }

        private void ClearData()
        {
            textBoxExtraKmRate.Text = "";
            textBoxExtraHourRate.Text = "";
            textBoxDriverOvernightRate.Text = "";
            textBoxVehicleNightParkRate.Text = "";
            comboBoxPackage.DataSource = null;
            comboBoxPackage.Items.Clear();
        }

        private void dataGridViewRates_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dataGridViewRates.Rows[e.RowIndex].Cells["ID"].Value.ToString());
            textBoxExtraKmRate.Text = dataGridViewRates.Rows[e.RowIndex].Cells["ExtraKmRate"].Value.ToString();
            textBoxExtraHourRate.Text = dataGridViewRates.Rows[e.RowIndex].Cells["ExtraHourRate"].Value.ToString();
            textBoxDriverOvernightRate.Text = dataGridViewRates.Rows[e.RowIndex].Cells["DriverOvernightRate"].Value.ToString();
            textBoxVehicleNightParkRate.Text = dataGridViewRates.Rows[e.RowIndex].Cells["VehicleNightParkRate"].Value.ToString();
        }

        private void textBoxPackageCost_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonHireCal_Click(object sender, EventArgs e)
        {
            formHireCalculator hireCalculator = new formHireCalculator();
            hireCalculator.Visible = true;
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

        private void buttonRentCal_Click(object sender, EventArgs e)
        {
            formRentCalculator rentCalculator = new formRentCalculator();
            rentCalculator.Visible = true;
            this.Hide();
        }

        private void dataGridViewRates_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            int package = comboBoxPackage.SelectedIndex;
            try
            {
                if (textBoxExtraKmRate.Text != string.Empty && textBoxExtraHourRate.Text != string.Empty && package != 0)
                {
                    con.Open();
                    SqlCommand add_cmd = new SqlCommand("INSERT INTO Rate VALUES (@Package, @ExtraKmRate, @ExtraHourRate, @DriverOvernightRate, @VehicleNightParkRate)", con);
                    add_cmd.Parameters.AddWithValue("Package", package);
                    add_cmd.Parameters.AddWithValue("ExtraKmRate", textBoxExtraKmRate.Text);
                    add_cmd.Parameters.AddWithValue("ExtraHourRate", textBoxExtraKmRate.Text);

                    if (textBoxDriverOvernightRate.Text != string.Empty && textBoxVehicleNightParkRate.Text != string.Empty)
                    {
                        add_cmd.Parameters.AddWithValue("DriverOvernightRate", null);
                        add_cmd.Parameters.AddWithValue("VehicleNightParkRate", null);
                        add_cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        add_cmd.Parameters.AddWithValue("DriverOvernightRate", textBoxDriverOvernightRate.Text);
                        add_cmd.Parameters.AddWithValue("VehicleNightParkRate", textBoxVehicleNightParkRate.Text);
                        add_cmd.ExecuteNonQuery();
                    }

                    messageInsert messageInsert = new messageInsert();
                    messageInsert.Visible = true;

                    con.Close();
                    ClearData();
                    rate_Data();
                    selection_DropDown();
                }
                else
                {
                    messageIncorrect messageIncorrect = new messageIncorrect();
                    messageIncorrect.Visible = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int package = comboBoxPackage.SelectedIndex;
            try
            {
                if (textBoxExtraKmRate.Text != string.Empty && textBoxExtraHourRate.Text != string.Empty && package != 0)
                {
                    con.Open();
                    SqlCommand edit_cmd = new SqlCommand("UPDATE Rate SET Package = @Package, ExtraKmRate = @ExtraKmRate, ExtraHourRate = @ExtraHourRate, DriverOvernightRate = @DriverOvernightRate, VehicleNightParkRate = @VehicleNightParkRate WHERE ID = @ID", con);
                    edit_cmd.Parameters.AddWithValue("@ID", ID);
                    edit_cmd.Parameters.AddWithValue("@Package", package);
                    edit_cmd.Parameters.AddWithValue("@ExtraKmRate", textBoxExtraKmRate.Text);
                    edit_cmd.Parameters.AddWithValue("@ExtraHourRate", textBoxExtraHourRate.Text);
                    edit_cmd.Parameters.AddWithValue("@DriverOvernightRate", textBoxDriverOvernightRate.Text);
                    edit_cmd.Parameters.AddWithValue("@VehicleNightParkRate", textBoxVehicleNightParkRate.Text);
                    edit_cmd.ExecuteNonQuery();

                    messageUpdate messageUpdate = new messageUpdate();
                    messageUpdate.Visible = true;

                    con.Close();
                    rate_Data();
                    ClearData();
                    selection_DropDown();
                }
                else
                {
                    messageSelect messageSelect = new messageSelect();
                    messageSelect.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (ID != 0)
                {
                    con.Open();
                    SqlCommand del_cmd = new SqlCommand("DELETE Rate WHERE ID=@ID", con);
                    del_cmd.Parameters.AddWithValue("@ID", ID);
                    del_cmd.ExecuteNonQuery();

                    messageDelete messageDelete = new messageDelete();
                    messageDelete.Visible = true;

                    con.Close();
                    rate_Data();
                    ClearData();
                    selection_DropDown();
                }
                else
                {
                    messageSelect messageSelect = new messageSelect();
                    messageSelect.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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

        private void FormRates_Load(object sender, EventArgs e)
        {

        }
    }
}

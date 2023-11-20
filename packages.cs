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
    public partial class packages : Form
    {
        //Setting up database connection
        SqlConnection con = new SqlConnection(@"Data Source=CHAMITH-ROG-STR;Initial Catalog=AyuboDrive;Integrated Security=True");
        int ID = 0;

        public packages()
        {
            InitializeComponent();
            package_Data();
            selection_DropDown_1();
            selection_DropDown_2();
            labelUsername.Text = login.SetValueForUsername;
        }

        private void ClearData()
        {
            textBoxPackageName.Text = "";
            textBoxMaxKmLimit.Text = "";
            textBoxMaxHours.Text = "";
            textBoxPackageCost.Text = "";
            comboBoxVehicleType.DataSource = null;
            comboBoxVehicleType.Items.Clear();
        }

        //vehicle types dropdown
        private void selection_DropDown_1()
        {
            con.Open();
            DataRow dataRow;

            SqlCommand cmd = new SqlCommand("SELECT * FROM VehicleType", con);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataRow = dataTable.NewRow();

            dataRow.ItemArray = new object[] { 0, "Select Vehicle type" };
            dataTable.Rows.InsertAt(dataRow, 0);

            comboBoxVehicleType.ValueMember = "ID";
            comboBoxVehicleType.DisplayMember = "VehicleType";
            comboBoxVehicleType.DataSource = dataTable;

            con.Close();
        }

        private void selection_DropDown_2()
        {
            con.Open();
            DataRow dataRow;

            SqlCommand cmd = new SqlCommand("SELECT * FROM VehicleType", con);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataRow = dataTable.NewRow();

            dataRow.ItemArray = new object[] { 0, "Select Vehicle type" };
            dataTable.Rows.InsertAt(dataRow, 0);

            comboBoxSearch.ValueMember = "ID";
            comboBoxSearch.DisplayMember = "VehicleType";
            comboBoxSearch.DataSource = dataTable;

            con.Close();
        }

        // data table
        private void package_Data()
        {
            /*con.Open();
            SqlCommand data = new SqlCommand("SELECT Package.ID, VehicleType.VehicleType, Package.Name, Package.MaxKmLimit, Package.MaxHours, Package.PackageCost FROM Package LEFT JOIN VehicleType on Package.VehicleType = VehicleType.ID", con);
            dataGridViewPackages.AutoGenerateColumns = true;
            SqlDataAdapter p_data = new SqlDataAdapter(data);
            DataTable p_dt = new DataTable();
            p_data.Fill(p_dt);
            dataGridViewPackages.DataSource = p_dt;
            dataGridViewPackages.Columns[0].HeaderText = "Package ID";
            dataGridViewPackages.Columns[1].HeaderText = "Vehicle Type";
            dataGridViewPackages.Columns[2].HeaderText = "Package Name";
            dataGridViewPackages.Columns[3].HeaderText = "Max Km Limit";
            dataGridViewPackages.Columns[4].HeaderText = "Max Hours";
            dataGridViewPackages.Columns[5].HeaderText = "Package Cost";
            con.Close();*/
        }

        private void dataGridViewPackages_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dataGridViewPackages.Rows[e.RowIndex].Cells["ID"].Value.ToString());
            textBoxPackageName.Text = dataGridViewPackages.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            textBoxMaxKmLimit.Text = dataGridViewPackages.Rows[e.RowIndex].Cells["MaxKmLimit"].Value.ToString();
            textBoxMaxHours.Text = dataGridViewPackages.Rows[e.RowIndex].Cells["MaxHours"].Value.ToString();
            textBoxPackageCost.Text = dataGridViewPackages.Rows[e.RowIndex].Cells["PackageCost"].Value.ToString();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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

        private void buttonVehicleTypes_Click(object sender, EventArgs e)
        {

        }

        private void buttonHireCal_Click(object sender, EventArgs e)
        {
            formHireCalculator hireCalculator = new formHireCalculator();
            hireCalculator.Visible = true;
            this.Hide();
        }

        private void packages_Load(object sender, EventArgs e)
        {

        }

        //Inserting packages to the database
        private void buttonInsert_Click(object sender, EventArgs e)
        {
            int vehicleType = comboBoxVehicleType.SelectedIndex;
            int packageType = comboBoxPackageType.SelectedIndex;
            try
            {
                if (textBoxPackageName.Text != string.Empty && textBoxMaxKmLimit.Text != string.Empty && textBoxMaxHours.Text != string.Empty && textBoxPackageCost.Text != string.Empty && vehicleType != 0)
                {
                    con.Open();
                    SqlCommand add_cmd = new SqlCommand("INSERT INTO Package values(@VehicleType, @Name, @MaxKmLimit, @MaxHours, @PackageCost, @PackageType)", con);
                    add_cmd.Parameters.AddWithValue("VehicleType", vehicleType);
                    add_cmd.Parameters.AddWithValue("Name", textBoxPackageName.Text);
                    add_cmd.Parameters.AddWithValue("MaxKmLimit", textBoxMaxKmLimit.Text);
                    add_cmd.Parameters.AddWithValue("MaxHours", textBoxMaxHours.Text);
                    add_cmd.Parameters.AddWithValue("PackageCost", textBoxPackageCost.Text);
                    add_cmd.Parameters.AddWithValue("PackageType", packageType);
                    add_cmd.ExecuteNonQuery();

                    messageInsert messageInsert = new messageInsert();
                    messageInsert.Visible = true;

                    con.Close();
                    ClearData();
                    package_Data();
                    selection_DropDown_1();
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
            int vehicleType = comboBoxVehicleType.SelectedIndex;
            try
            {
                if (textBoxPackageName.Text != string.Empty && textBoxMaxKmLimit.Text != string.Empty && textBoxMaxHours.Text != string.Empty && textBoxPackageCost.Text != string.Empty && vehicleType != 0)
                {
                    con.Open();
                    SqlCommand edit_cmd = new SqlCommand("UPDATE Package SET VehicleType = @VehicleType, Name = @PackageName, MaxKmLimit = @MaxKmLimit, MaxHours = @MaxHours, PackageCost = @PackageCost  WHERE ID = @id", con);
                    edit_cmd.Parameters.AddWithValue("@ID", ID); 
                    edit_cmd.Parameters.AddWithValue("VehicleType", vehicleType);
                    edit_cmd.Parameters.AddWithValue("PackageName", textBoxPackageName.Text);
                    edit_cmd.Parameters.AddWithValue("MaxKmLimit", textBoxMaxKmLimit.Text);
                    edit_cmd.Parameters.AddWithValue("MaxHours", textBoxMaxHours.Text);
                    edit_cmd.Parameters.AddWithValue("PackageCost", textBoxPackageCost.Text);
                    edit_cmd.ExecuteNonQuery();

                    messageUpdate messageUpdate = new messageUpdate();
                    messageUpdate.Visible = true;

                    con.Close();
                    package_Data();
                    ClearData();
                    selection_DropDown_1();
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
                if (ID != 0 && textBoxPackageName.Text != string.Empty && textBoxMaxKmLimit.Text != string.Empty && textBoxMaxHours.Text != string.Empty && textBoxPackageCost.Text != string.Empty)
                {
                    con.Open();
                    SqlCommand del_cmd = new SqlCommand("DELETE Package WHERE ID=@ID", con);
                    del_cmd.Parameters.AddWithValue("@ID", ID);
                    del_cmd.ExecuteNonQuery();

                    messageDelete messageDelete = new messageDelete();
                    messageDelete.Visible = true;

                    con.Close();
                    package_Data();
                    ClearData();
                    selection_DropDown_1();
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

        private void comboBoxVehicleType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int vehicleType = Convert.ToInt32(comboBoxVehicleType.SelectedValue);

            //string tring = vehicleType.ToString();
            //MessageBox.Show(tring);

            con.Open();
            SqlCommand data = new SqlCommand("SELECT Package.ID, Package.Name, Package.MaxKmLimit, Package.MaxHours, Package.PackageCost FROM Package WHERE VehicleType ="+ 1, con);
            dataGridViewPackages.AutoGenerateColumns = true;
            SqlDataAdapter p_data = new SqlDataAdapter(data);
            DataTable p_dt = new DataTable();
            p_data.Fill(p_dt);
            dataGridViewPackages.DataSource = p_dt;
            dataGridViewPackages.Columns[0].HeaderText = "Package ID";
            dataGridViewPackages.Columns[1].HeaderText = "Package Name";
            dataGridViewPackages.Columns[2].HeaderText = "Max Km Limit";
            dataGridViewPackages.Columns[3].HeaderText = "Max Hours";
            dataGridViewPackages.Columns[4].HeaderText = "Package Cost";
            con.Close();
        }

        private void dataGridViewRates_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

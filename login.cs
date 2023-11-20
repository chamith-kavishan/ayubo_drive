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
    public partial class login : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=CHAMITH-ROG-STR;Initial Catalog=AyuboDrive;Integrated Security=True");
        public login()
        {
            InitializeComponent();
        }

        public static string SetValueForUsername = "";

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text != string.Empty && textBoxPassword.Text != string.Empty)
            {
                con.Open();
                SqlDataAdapter user = new SqlDataAdapter("SELECT COUNT(*) FROM Admin WHERE Username='" + textBoxUsername.Text + "' AND Password='" + textBoxPassword.Text + "'", con);
                DataTable dt = new DataTable();
                user.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {
                    SetValueForUsername = textBoxUsername.Text;

                    formDashboard formDashboard = new formDashboard();
                    formDashboard.Visible = true;
                    this.Hide();
                    con.Close();
                }
                else
                {
                    messageIncorrect messageIncorrect = new messageIncorrect();
                    messageIncorrect.Visible = true;
                }
            }
            else
            {
                messageIncorrect messageIncorrect = new messageIncorrect();
                messageIncorrect.Visible = true;
            }

        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            signUp signUp = new signUp();
            signUp.Visible = true;
            this.Hide();
        }
    }
}

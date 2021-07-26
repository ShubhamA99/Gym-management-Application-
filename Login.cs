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

namespace MaxMuscleGym
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\LEGION\Documents\gym.mdf;Integrated Security = True; Connect Timeout = 30");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Login where Username = '" + txtusername.Text + "' and Password = '" + txtpass.Text + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Form1 ss = new Form1();
                ss.Show();
            }
            else if (txtusername.Text == "" || txtpass.Text == "")
            {
                MessageBox.Show("Enter Username and Password");
            }
            else
            {

                MessageBox.Show("Please Check Your Username and Password");
            }
        }
    }
}

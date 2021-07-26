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
    public partial class NewStaff : Form
    {
        public NewStaff()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\LEGION\Documents\gym.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();

                String query = "insert into NewStaff values('" + txtfirstname.Text + "','" + txtlastname.Text + "','" + GenderCB.SelectedItem.ToString() + "','" + txtage + "','" + txtmobileno.Text + "','" + txtState.Text + "','" + txtCity.Text +"','"+txtaddr.Text+ "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Member added");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtfirstname.Clear();
            txtlastname.Clear();

            txtmobileno.Clear();
            txtemail.Clear(); 
        }

        private void NewStaff_Load(object sender, EventArgs e)
        {

        }
    }
}

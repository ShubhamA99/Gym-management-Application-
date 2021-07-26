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
    public partial class NewMember : Form
    {
        public NewMember()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\LEGION\Documents\gym.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();

                String query = "insert into NewMember values('" + txtfirstname.Text + "','" + txtlastname.Text + "','" + GenderCB.SelectedItem.ToString() + "','" + txtemail + "','" + txtaddress.Text + "','" + comboBox2.SelectedItem.ToString() + "','" + txtmobileno.Text + "','" + txtage + "')";
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
            comboBox2.ResetText();
        }
    }
}

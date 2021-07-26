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
    public partial class Equipment : Form
    {
        public Equipment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\LEGION\Documents\gym.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();

                String query = "insert into Equipment values('" + txtname.Text + "','" + txtdescription.Text + "','"  + txtMused.Text + "','" + txtcompany.Text + "','"  + txtcost.Text +  "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Equipment  added");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtdescription.Clear();
            txtMused.Clear();
            txtcompany.Clear();
            txtcost.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewEquipment ve = new ViewEquipment();
            ve.Show();
        }
    }
}

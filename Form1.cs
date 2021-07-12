using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace envitechAssignment
{
    public partial class Form1 : Form
    {

        String from_Date, to_Date;
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            to_Date = dateTimePicker2.Value.ToString("MM/dd/yyyy");

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // to get the right values from the table just need to get the columns and mod with 2
            //List<string> items = new List<string>();
            //List<string> = SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('dbo.yourTableName') 
            //comboBox1.DataSource = items;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            from_Date = dateTimePicker1.Value.ToString("MM/dd/yyyy");

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
        }


        /*      using (SqlConnection con = new SqlConnection(strConnect))
         {
         con.Open();
         using (SqlCommand com = new SqlCommand("SELECT listBox1 from table where [Date] between from_Date and to_Date", con))
             {
          
             using (SqlDataReader reader = com.ExecuteReader())
                 {

                 }
             }
        }

          */
    }
}
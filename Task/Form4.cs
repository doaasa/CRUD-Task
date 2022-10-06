using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task
{
    public partial class Form4 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SFDKHS6\SQLEXPRESS; Integrated Security=True;Connect Timeout=30");
        string tname;
        public Form4(string table)
        {
            InitializeComponent();
            tname = table;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 fo = new Form1();
            fo.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("use samples;UPDATE doaa SET name='" + textBox2.Text.ToString()+ "' , phone='"+textBox3.Text.ToString()+"' where Id= '" +textBox1.Text + "' ", con);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("it's done");
            }
            finally
            {
                con.Close();
            }
        }
    }
}

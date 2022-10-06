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

namespace Task
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SFDKHS6\SQLEXPRESS; Integrated Security=True;Connect Timeout=30");
        string tname;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            string tn = textBox1.Text;
            SqlCommand cmd = new SqlCommand("use samples; create table "+tn+"(Id int, name nvarchar(100), phone bigint) " , con);
            cmd.ExecuteNonQuery();
            con.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            string tn = textBox1.Text;
            tname = tn;
            SqlCommand cmd = new SqlCommand("drop table " + tn, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Exit ?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(tname);
            form2.Show();
            this.Hide();
        }
    }
}

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
    public partial class Form3 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SFDKHS6\SQLEXPRESS; Integrated Security=True;Connect Timeout=30");
        string tname;
        public Form3(string table)
        {
            tname = table;
            InitializeComponent();
        }

        private void deleteDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void addDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(tname);
            form2.Show();
            this.Hide();

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
                string id = textBox1.Text;
              //  SqlCommand cmd = new SqlCommand(@"use samples;delete from '"+tname+"' where Id='" + id + "'", con);
            SqlCommand cmd = new SqlCommand(@"use samples;delete from doaa where Id='" + id + "'", con);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("it's done");
            }
            finally { 
                con.Close();
             }
        }

        private void updateDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(tname);
            form4.Show();
            this.Hide();
        }
    }
}

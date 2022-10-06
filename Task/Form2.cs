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
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SFDKHS6\SQLEXPRESS;Database=samples;Integrated Security=True;Connect Timeout=30");
        string table;
        public Form2(string tablename)
        {
            InitializeComponent();
            table = tablename;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void addDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string id = textBox1.Text;
            string name = textBox2.Text;
            string phone = textBox3.Text;
            SqlCommand cmd= new SqlCommand("use samples;insert into doaa(Id, name, phone) values(@Id,@name,@phone); ", con);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 fo = new Form1();
            fo.Show();
            this.Hide();
        }

        private void deleteDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(table);
            form3.Show();
            this.Hide();
        }

        private void updateDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(table);
            form4.Show();
            this.Hide();
        }
    }
}

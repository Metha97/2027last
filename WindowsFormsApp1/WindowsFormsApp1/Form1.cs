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
using MySqlConnector;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            string connStr = "server=172.16.2.26;user id=metha;password=TcaPG-1983;database=metha";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                string query = "select * from memo";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable tbl = new DataTable();
                adapter.Fill(tbl);

                dataGridView1.DataSource = tbl;
                conn.Close();
            }
            catch (MySqlException mse)
            {
                MessageBox.Show(mse.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text)) 
                { 
                
                }
        }
    }
}

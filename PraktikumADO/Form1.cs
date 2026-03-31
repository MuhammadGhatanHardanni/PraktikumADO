using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PraktikumADO
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
        }

        private void Koneksi()
        {
            string connectionString = @"Data Source=LAPTOP-VL5SDNPR\GHATANHARDANNI; Initial Catalog=DBAkademikADO; Integrated Security=True";
            conn = new SqlConnection(connectionString);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void txtHasil_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

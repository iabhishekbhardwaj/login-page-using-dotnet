using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-TONO6RK;Initial Catalog=DATA_NEW;Integrated Security=True;Pooling=False;");
            SqlDataAdapter sda = new SqlDataAdapter

            main ss = new main();
            ss.Show();

        }
    }
}

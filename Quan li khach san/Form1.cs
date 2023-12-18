using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Quan_li_khach_san
{
    public partial class Form1 : Form
    {
        private string CONNECTION_STRING = @"Data Source=HATTIES;Initial Catalog=QLKS;Integrated Security=True;Trust Server Certificate=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = TextBoxUsername.Text.Trim();
            string password = TextBoxPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Tên đăng nhập và mật khẩu không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = CONNECTION_STRING;
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM user_table WHERE username = '" + username + "' AND password = '" + password + "' ";
                SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        FormHome formHome = new FormHome();
                        formHome.Show();
                        this.Hide();
                    }
                    else
                    {
                    MessageBox.Show("Tên người dùng hoặc mật khẩu không hợp lệ!");
                    }
                conn.Close();

            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

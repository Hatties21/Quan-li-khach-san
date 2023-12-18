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
using System.Data;
using System.Data.SqlClient;

namespace Quan_li_khach_san
{
    public partial class FormCustomer : Form
    {
        private string CONNECTION_STRING = @"Data Source=HATTIES;Initial Catalog=QLKS;Integrated Security=True;Trust Server Certificate=True";
        public FormCustomer()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormHome formHome = new FormHome();
            formHome.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string customer_name, customer_identityNo, customer_PhoneNo;
            customer_name = textBoxCusName.Text.Trim();
            customer_identityNo = textBoxCusID.Text.Trim();
            customer_PhoneNo = textBoxCusConNo.Text.Trim();

            if (string.IsNullOrEmpty(customer_name) || string.IsNullOrEmpty(customer_PhoneNo) || string.IsNullOrEmpty(customer_identityNo))
            {
                MessageBox.Show("Không được để trống!");
            }
            else
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
                    {
                        conn.Open();

                        string query = "INSERT INTO customers (customerName, customerPhone, customerId) VALUES (@customerName, @customerPhone, @customerId)";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@customerName", customer_name);
                            cmd.Parameters.AddWithValue("@customerPhone", customer_PhoneNo);
                            cmd.Parameters.AddWithValue("@customerId", customer_identityNo);

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Thêm khách hàng thành công!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                }
            }

        }
    }
}

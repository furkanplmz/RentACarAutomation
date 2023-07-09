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

namespace AraçKiralamaOtomasyon
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
            showCustomers();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
                                        AttachDbFilename=C:\Users\etome\Documents\CarRentaldb.mdf;
                                        Integrated Security=True;Connect Timeout=30");
        private void showCustomers()
        {
            Con.Open();
            string query = "Select * from CustomerTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            customerDataGrid.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (custNameTxt.Text == "" || custSurnameTxt.Text == "")
            {
                MessageBox.Show("Boş Alan Girdiniz");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand query = new SqlCommand("insert into CustomerTbl (CustId,CustName,CustSurname,CustAdd,CustPhone)" +
                        " values(@ID,@CN,@CS,@CA,@CP)", Con);
                    query.Parameters.AddWithValue("@ID", custIdTxt.Text);
                    query.Parameters.AddWithValue("@CN", custNameTxt.Text);
                    query.Parameters.AddWithValue("@CS", custSurnameTxt.Text);
                    query.Parameters.AddWithValue("@CA", custAddTxt.Text);
                    query.Parameters.AddWithValue("@CP", custPhoneTxt.Text);
                    query.ExecuteNonQuery();
                    MessageBox.Show("Müşteri Kaydedildi");
                    Con.Close();
                    showCustomers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
             }

            }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (custNameTxt.Text == ""|| custSurnameTxt.Text == "")
            {
                MessageBox.Show("Boş Alan Girdiniz");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from CustomerTbl Where CustId=@ID", Con);
                    cmd.Parameters.AddWithValue("@ID", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Müşteri Silindi");
                    Con.Close();
                    showCustomers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }
        UInt64 Key = 0;
        private void customerDataGrid_Click(object sender, EventArgs e)
        {
            custNameTxt.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CustName").ToString();
            custSurnameTxt.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CustSurname").ToString();
            custAddTxt.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CustAdd").ToString();
            custPhoneTxt.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CustPhone").ToString();
            Key = Convert.ToUInt64(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CustId"));
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (custNameTxt.Text == "" || custSurnameTxt.Text == "")
            {
                MessageBox.Show("Boş Alan Girdiniz");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update CustomerTbl Set CustId=@ID,CustName=@CN,CustSurname=@CS,CustAdd=@CA,CustPhone=@CP " +
                        "where CustId=@Id", Con);
                    cmd.Parameters.AddWithValue("@ID", custIdTxt.Text);
                    cmd.Parameters.AddWithValue("@CN", custNameTxt.Text);
                    cmd.Parameters.AddWithValue("@CS", custSurnameTxt.Text);
                    cmd.Parameters.AddWithValue("@CA", custAddTxt.Text);
                    cmd.Parameters.AddWithValue("@CP", custPhoneTxt.Text);
                    cmd.Parameters.AddWithValue("@Id", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Müşteri Güncellendi.");
                    Con.Close();
                    showCustomers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm main =new MainForm();
            this.Hide();
            main.Show();    
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }

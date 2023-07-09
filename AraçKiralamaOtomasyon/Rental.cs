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
    public partial class Rental : Form
    {
        public Rental()
        {
            InitializeComponent();
            showRental();
            getLicensePlate();
            getCustomerId();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
                                        AttachDbFilename=C:\Users\etome\Documents\CarRentaldb.mdf;
                                        Integrated Security=True;Connect Timeout=30");
        private void Available()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Update CarTbl Set Available=@AV " +
                "where LicensePlate=@Id", Con);
            cmd.Parameters.AddWithValue("@AV", "Hayır");
            cmd.Parameters.AddWithValue("@Id", carplateCb.SelectedValue.ToString());
            cmd.ExecuteNonQuery();
            Con.Close();
        }
        private void AvailableDelete()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Update CarTbl Set Available=@AV " +
                "where LicensePlate=@Id", Con);
            cmd.Parameters.AddWithValue("@AV", "Evet");
            cmd.Parameters.AddWithValue("@Id",a);
            cmd.ExecuteNonQuery();
            Con.Close();
        }
        private void showRental()
        {
            Con.Open();
            string query = "Select * from RentalTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            RentalDataGrid.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void getLicensePlate()
        {
            Con.Open();
            string query = "select LicensePlate from CarTbl where Available = 'Evet'";
            SqlCommand cmd = new SqlCommand(query,Con);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("LicensePlate",typeof(string));
            dt.Load(reader);
            carplateCb.ValueMember = "LicensePlate";
            carplateCb.DataSource = dt;
            Con.Close();
        }

        private void getCustomerId()
        {
            Con.Open();
            string query = "select CustId from CustomerTbl";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CustId", typeof(string));
            dt.Load(reader);
            custIdCb.ValueMember = "CustId";
            custIdCb.DataSource = dt;
            Con.Close();
        }
        private void getCustomerName()
        {
            Con.Open();
            string Query = "Select * from CustomerTbl where CustId=" + custIdCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                custNameTxt.Text = dr["CustName"].ToString();
                custSurnameTxt.Text = dr["CustSurname"].ToString();
            }
            Con.Close();
        }
        private void updateBtn_Click(object sender, EventArgs e)
        {

        }

        private void carplateCb_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (custNameTxt.Text == "" || custSurnameTxt.Text == "" ||custIdCb.Text==""|| carplateCb.Text=="")
            {
                MessageBox.Show("Boş Alan Girdiniz");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand query = new SqlCommand("insert into RentalTbl (CarPlate,CustName,CustSurname,RentDate,ReturnDate,RentFee)" +
                        " values(@CP,@CN,@CS,@RD,@RE,@RF)", Con);
                    query.Parameters.AddWithValue("@CP", carplateCb.SelectedValue.ToString());
                    query.Parameters.AddWithValue("@CN", custNameTxt.Text);
                    query.Parameters.AddWithValue("@CS", custSurnameTxt.Text);
                    query.Parameters.AddWithValue("@RD", rentalDate.DateTime);
                    query.Parameters.AddWithValue("@RE", returnDate.DateTime);
                    query.Parameters.AddWithValue("@RF", feeTxt.Text);
                    query.ExecuteNonQuery();
                    MessageBox.Show("Kiralama İslemi Kaydedildi");
                    Con.Close();
                    Available();
                    showRental();
                    getLicensePlate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void custIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getCustomerName();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main=new MainForm();
            main.Show();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

            if (custNameTxt.Text == "" || custSurnameTxt.Text=="")
            {
                MessageBox.Show("Boş Alan Girdiniz");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from RentalTbl Where RentId=@CId", Con);
                    cmd.Parameters.AddWithValue("@CId", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kiralama Kaydı Silindi");
                    Con.Close();
                    showRental();
                    AvailableDelete();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }
        int Key = 0;
        string a = "";
        private void RentalDataGrid_Click(object sender, EventArgs e)
        {
            
                custNameTxt.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CustName").ToString();
                custSurnameTxt.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CustSurname").ToString();
                carplateCb.SelectedValue = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "carPlate").ToString();
                a = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "carPlate").ToString();
                rentalDate.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "RentDate").ToString();
                returnDate.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ReturnDate").ToString();
                feeTxt.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "RentFee").ToString();
                Key = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "RentId"));
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }
    }
}

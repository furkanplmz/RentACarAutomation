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
    public partial class ReturnForm : Form
    {
        public ReturnForm()
        {
            InitializeComponent();
            showReturned();
            showRental();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
                                        AttachDbFilename=C:\Users\etome\Documents\CarRentaldb.mdf;
                                        Integrated Security=True;Connect Timeout=30");
        private void showReturned()
        {
            Con.Open();
            string query = "Select * from ReturnTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            returnedDataGrid.DataSource = ds.Tables[0];
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
        private void KullanilabilirMi()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Update CarTbl Set Available=@AV " +
                "where LicensePlate=@Id", Con);
            cmd.Parameters.AddWithValue("@AV", "Evet");
            cmd.Parameters.AddWithValue("@Id", carPlateTxt.Text);
            cmd.ExecuteNonQuery();
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
                    SqlCommand query = new SqlCommand("insert into ReturnTbl (CarPlate,CustName,CustSurname,ReturnDate,Fine,Delay)" +
                        " values(@CP,@CN,@CS,@RE,@RF,@DE)", Con);
                    query.Parameters.AddWithValue("@CP", carPlateTxt.Text);
                    query.Parameters.AddWithValue("@CN", custNameTxt.Text);
                    query.Parameters.AddWithValue("@CS", custSurnameTxt.Text);
                    query.Parameters.AddWithValue("@RE", returnDate.DateTime);
                    query.Parameters.AddWithValue("@DE", delayTxt.Text);
                    query.Parameters.AddWithValue("@RF", Convert.ToInt32(ekücretTxt.Text));
                    query.ExecuteNonQuery();
                    MessageBox.Show("Teslim Etme İşlemi Kaydedildi");
                    Con.Close();
                    KullanilabilirMi();
                    showReturned();
                    Deleteonreturn();
                    
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
            carPlateTxt.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "carPlate").ToString();
            returnDate.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ReturnDate").ToString();
            
            a = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "carPlate").ToString();
            Key = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "RentId"));
            DateTime d1 = returnDate.DateTime.Date;
            DateTime d2 = DateTime.Now;
            TimeSpan t = d2 - d1;
            int days = Convert.ToInt32(t.TotalDays);
            if (days <= 0)
            {
                delayTxt.Text = "0";
                ekücretTxt.Text ="0";
            }
            else
            {
                delayTxt.Text = days.ToString();
                ekücretTxt.Text = (days * 100).ToString();
            }
        }

        private void ReturnForm_Load(object sender, EventArgs e)
        {

        }
        private void Deleteonreturn()
        {
           
            Con.Open();
            SqlCommand cmd = new SqlCommand("Delete from RentalTbl Where RentId=@CId", Con);
            cmd.Parameters.AddWithValue("@CId", Key);
            cmd.ExecuteNonQuery();
            Con.Close();
            showRental();
        }
        private void deleteBtn_Click(object sender, EventArgs e)
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
                    SqlCommand cmd = new SqlCommand("Delete from RentalTbl Where RentId=@CId", Con);
                    cmd.Parameters.AddWithValue("@CId", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kiralama Kaydı Silindi");
                    Con.Close();
                    showRental();
                    //AvailableDelete();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main=new MainForm();
            main.Show();
        }

        private void carPlateTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

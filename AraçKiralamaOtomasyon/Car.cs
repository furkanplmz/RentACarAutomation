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
    public partial class Car : Form
    {
        public Car()
        {
            InitializeComponent();
            showCars();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
                                        AttachDbFilename=C:\Users\etome\Documents\CarRentaldb.mdf;
                                        Integrated Security=True;Connect Timeout=30");
        private void showCars()
        {
            Con.Open();
            string query = "Select LicensePlate as PlakaNo,Brand as Marka,Model,Price as Ücret,Available as KullanılabilirMi from CarTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            carsDataGrid.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
           
        }
        int Key = 0;
        private void carsDataGrid_Click(object sender, EventArgs e)
        {
            plakaNoTxt.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "PlakaNo").ToString();
            markaTxt.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Marka").ToString();
            modelTxt.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Model").ToString();
            priceTxt.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Ücret").ToString();
            availableCb.SelectedItem = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "KullanılabilirMi").ToString();

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm= new MainForm();
            mainForm.Show();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void saveBtn_Click_1(object sender, EventArgs e)
        {
            if (plakaNoTxt.Text == "" || markaTxt.Text == "")
            {
                MessageBox.Show("Boş Alan Girdiniz");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand query = new SqlCommand("insert into CarTbl(LicensePlate,Brand,Model,Price,Available)" +
                        " values(@LP,@BR,@MO,@PR,@AV)", Con);
                    query.Parameters.AddWithValue("@LP", plakaNoTxt.Text);
                    query.Parameters.AddWithValue("@BR", markaTxt.Text);
                    query.Parameters.AddWithValue("@MO", modelTxt.Text);
                    query.Parameters.AddWithValue("@PR", priceTxt.Text);
                    query.Parameters.AddWithValue("@AV", availableCb.SelectedItem.ToString());
                    query.ExecuteNonQuery();
                    MessageBox.Show("Araba Kaydedildi");
                    Con.Close();
                    showCars();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void updateBtn_Click_1(object sender, EventArgs e)
        {
            if (plakaNoTxt.Text == "" || markaTxt.Text == "")
            {
                MessageBox.Show("Boş Alan Girdiniz");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update CarTbl Set Brand=@BR,Model=@MO,Price=@PR,Available=@AV " +
                        "where LicensePlate=@Id", Con);
                    cmd.Parameters.AddWithValue("@BR", markaTxt.Text);
                    cmd.Parameters.AddWithValue("@MO", modelTxt.Text);
                    cmd.Parameters.AddWithValue("@Id", plakaNoTxt.Text);
                    cmd.Parameters.AddWithValue("@PR", priceTxt.Text);
                    cmd.Parameters.AddWithValue("@AV", availableCb.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Araba Güncellendi.");
                    Con.Close();
                    showCars();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void deleteBtn_Click_1(object sender, EventArgs e)
        {
            if (plakaNoTxt.Text == "" || markaTxt.Text == "")
            {
                MessageBox.Show("Boş Alan Girdiniz");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from CarTbl Where LicensePlate=@license", Con);
                    cmd.Parameters.AddWithValue("@License", plakaNoTxt.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Araba Kaydı Silindi");
                    Con.Close();
                    showCars();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }
    }
}

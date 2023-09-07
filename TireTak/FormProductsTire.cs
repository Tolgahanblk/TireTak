using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TireTak.Class;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography.X509Certificates;

namespace TireTak
{
    public partial class FormProductsTire : Form
    {
        #region Form Kenarları Yuvarlama
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
    (
        int nLeftRect,     // x-coordinate of upper-left corner
        int nTopRect,      // y-coordinate of upper-left corner
        int nRightRect,    // x-coordinate of lower-right corner
        int nBottomRect,   // y-coordinate of lower-right corner
        int nWidthEllipse, // height of ellipse
        int nHeightEllipse  // width of ellipse

     );
        #endregion  
        public FormProductsTire()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        SqlConnection conn = new SqlConnection(MainClass.connString);

        private void FormProductsTire_Load(object sender, EventArgs e)
        {
            dgwFillMethod();
            ComboBoxTireBrandFillMethod();
            ComboBoxTireSizeFillMethod();
            ComboBoxTireRFillMethod();
            ComboBoxTireModelFillMethod();
        }
        public void dgwFillMethod()
        {
            conn.Open();
            string tires_select = "Select * from Tires";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(tires_select, conn);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dgwFilterandDisplayMethod();
            conn.Close();
        }
        public void dgwFilterandDisplayMethod()
        {
            dataGridView1.Columns["tire_id"].HeaderText = "ID";
            dataGridView1.Columns["tire_brand"].HeaderText = "Marka";
            dataGridView1.Columns["tire_model"].HeaderText = "Model";
            dataGridView1.Columns["tire_size"].HeaderText = "Ebat";
            dataGridView1.Columns["tire_r"].HeaderText = "R";
            dataGridView1.Columns["tire_db"].HeaderText = "Db";
            dataGridView1.Columns["tire_built_price"].HeaderText = "Geliş Fiyatı";
            dataGridView1.Columns["tire_sale_price"].HeaderText = "Satış Fiyatı";
            dataGridView1.Columns["tire_number"].HeaderText = "Stok Adedi";

            //Görmek istemediğim columnları burada kapatıyorum
            dataGridView1.Columns["tire_id"].Visible = false;
            dataGridView1.Columns["tire_built_price"].Visible = true;

            //Column sıralaması için adlarını değiştiriyorum
            DataGridViewColumn column1 = dataGridView1.Columns["tire_brand"];
            DataGridViewColumn column2 = dataGridView1.Columns["tire_model"];
            DataGridViewColumn column3 = dataGridView1.Columns["tire_size"];
            DataGridViewColumn column4 = dataGridView1.Columns["tire_db"];
            DataGridViewColumn column5 = dataGridView1.Columns["tire_built_price"];
            DataGridViewColumn column6 = dataGridView1.Columns["tire_sale_price"];
            DataGridViewColumn column7 = dataGridView1.Columns["tire_r"];
            DataGridViewColumn column8 = dataGridView1.Columns["tire_number"];

            //Columnları burada sıralıyorum.
            column1.DisplayIndex = 1;
            column2.DisplayIndex = 2;
            column3.DisplayIndex = 3;
            column4.DisplayIndex = 7;
            column5.DisplayIndex = 5;
            column6.DisplayIndex = 6;
            column7.DisplayIndex = 4;
            column8.DisplayIndex = 8;
        }
        public void ComboBoxTireSizeFillMethod()
        {
            conn.Open();
            string tires_size = "Select tire_size from Tire_size";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(tires_size, conn);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);


            foreach (DataRow row in dt.Rows)
            {
                comboBoxTireSize.Items.Add(row["tire_size"].ToString());
                comboBoxTireSizeSearch.Items.Add(row["tire_size"].ToString());
            }
            conn.Close();
        }
        public void ComboBoxTireBrandFillMethod()
        {
            conn.Open();
            string tires_brand = "Select tire_brand from Tires_brand";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(tires_brand, conn);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);


            foreach (DataRow row in dt.Rows)
            {
                comboBoxTireBrand.Items.Add(row["tire_brand"].ToString());
                comboBoxTireBrandSearch.Items.Add(row["tire_brand"].ToString());
            }
            conn.Close();
        }
        public void ComboBoxTireRFillMethod()
        {
            conn.Open();
            string tires_r = "Select tire_r from tire_r";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(tires_r, conn);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);


            foreach (DataRow row in dt.Rows)
            {
                comboBoxTireR.Items.Add(row["tire_r"].ToString());
            }
            conn.Close();
        }
        public void ComboBoxTireModelFillMethod()
        {
            conn.Open();
            string tire_model = "Select tire_model from tire_model";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(tire_model, conn);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);


            foreach (DataRow row in dt.Rows)
            {
                comboBoxTireModel.Items.Add(row["tire_model"].ToString());
            }
            conn.Close();
        }

        private void FormCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
            FormProducts formProducts = new FormProducts();
            formProducts.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgwFillMethod();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;

            comboBoxTireBrand.Text = dataGridView1.Rows[selectedRowIndex].Cells[1].Value.ToString();
            comboBoxTireModel.Text = dataGridView1.Rows[selectedRowIndex].Cells[2].Value.ToString();
            comboBoxTireSize.Text = dataGridView1.Rows[selectedRowIndex].Cells[3].Value.ToString();
            textBoxTireDb.Text = dataGridView1.Rows[selectedRowIndex].Cells[4].Value.ToString();
            comboBoxTireR.Text = dataGridView1.Rows[selectedRowIndex].Cells[7].Value.ToString();
            textBoxBuiltPrice.Text = dataGridView1.Rows[selectedRowIndex].Cells[5].Value.ToString();
            textBoxSalePrice.Text = dataGridView1.Rows[selectedRowIndex].Cells[6].Value.ToString();
            textBoxTireNumber.Text = dataGridView1.Rows[selectedRowIndex].Cells[8].Value.ToString();
        }

        private void comboBoxTireSizeSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxTireSizeSearch.SelectedItem != null)
                {
                    string searchTireSizeItem = comboBoxTireSizeSearch.SelectedItem.ToString();

                    conn.Open();

                    // SQL sorgusu oluşturup filtrelemeyi yap
                    string tires_size_filtered = $"SELECT * FROM Tires WHERE tire_size = '{searchTireSizeItem}'";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(tires_size_filtered, conn);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);

                    // DataGridView'i güncelle
                    dataGridView1.DataSource = dt;

                    conn.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                string tireBrand = comboBoxTireBrand.SelectedItem.ToString();
                string tireModel = comboBoxTireModel.SelectedItem.ToString();
                string tireSize = comboBoxTireSize.SelectedItem.ToString();
                string tireDb = textBoxTireDb.Text;
                string tireR =comboBoxTireR.SelectedItem.ToString();
                string tireBuiltPrice = textBoxBuiltPrice.Text;
                string tireSalePrice = textBoxSalePrice.Text;
                string tireNumber=textBoxTireNumber.Text;

                conn.Open();

                string insertQuery = "INSERT INTO Tires (tire_brand, tire_model, tire_size, tire_db, tire_built_price, tire_sale_price, tire_r, tire_number) VALUES (@tireBrand, @tireModel, @tireSize, @tireDb, @tireBuiltPrice, @tireSalePrice, @tireR, @tireNumber )";

                SqlCommand cmd = new SqlCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@tireBrand", tireBrand);
                cmd.Parameters.AddWithValue("@tireModel", tireModel);
                cmd.Parameters.AddWithValue("@tireSize", tireSize);
                cmd.Parameters.AddWithValue("@tireDb", tireDb);
                cmd.Parameters.AddWithValue("@tireR", tireR);
                cmd.Parameters.AddWithValue("@tireBuiltPrice", tireBuiltPrice);
                cmd.Parameters.AddWithValue("@tireSalePrice", tireSalePrice);
                cmd.Parameters.AddWithValue("@tireNumber", tireNumber);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Kayıt başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Kayıt eklenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int selectedIndex = dataGridView1.SelectedRows[0].Index;
                    string tireid = dataGridView1.Rows[selectedIndex].Cells["tire_id"].Value.ToString();
                    conn.Open();

                    string deleteQuery = "DELETE FROM Tires WHERE tire_id = @tireid";
                    SqlCommand cmd = new SqlCommand(deleteQuery, conn);
                    cmd.Parameters.AddWithValue("@tireid", tireid);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Seçilen kayıt başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Kayıt silinirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Lütfen silinecek bir satır seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int selectedIndex = dataGridView1.SelectedRows[0].Index;
                    string tireid = dataGridView1.Rows[selectedIndex].Cells["tire_id"].Value.ToString();

                    string newTireBrand = comboBoxTireBrand.SelectedItem.ToString();
                    string newTireModel = comboBoxTireModel.SelectedItem.ToString();
                    string newTireSize = comboBoxTireSize.SelectedItem.ToString();
                    string newTireDb = textBoxTireDb.Text;
                    string newTireR = comboBoxTireR.SelectedItem.ToString();
                    string newTireBuiltPrice = textBoxBuiltPrice.Text;
                    string newTireSalePrice = textBoxSalePrice.Text;
                    string newTireNumber = textBoxTireNumber.Text;

                    conn.Open();

                    string updateQuery = "UPDATE Tires SET tire_brand = @newTireBrand, tire_model = @newTireModel, tire_size = @newTireSize, tire_db = @newTireDb, tire_built_price = @newTireBuiltPrice, tire_sale_price = @newTireSalePrice, tire_r = @newTireR, tire_number = @newTireNumber WHERE tire_id = @tireid";


                    SqlCommand cmd = new SqlCommand(updateQuery, conn);
                    cmd.Parameters.AddWithValue("@tireid", tireid);
                    cmd.Parameters.AddWithValue("@newTireBrand", newTireBrand);
                    cmd.Parameters.AddWithValue("@newTireModel", newTireModel);
                    cmd.Parameters.AddWithValue("@newTireSize", newTireSize);
                    cmd.Parameters.AddWithValue("@newTireDb", newTireDb);
                    cmd.Parameters.AddWithValue("@newTireBuiltPrice", newTireBuiltPrice);
                    cmd.Parameters.AddWithValue("@newTireSalePrice", newTireSalePrice);
                    cmd.Parameters.AddWithValue("@newTireR", newTireR);
                    cmd.Parameters.AddWithValue("@newTireNumber", newTireNumber);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Seçilen kayıt başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Kayıt güncellenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Lütfen güncellenecek bir satır seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void comboBoxTireBrandSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                try
                {
                    if (comboBoxTireBrandSearch.SelectedItem != null)
                    {
                        string searchTireBrandItem = comboBoxTireBrandSearch.SelectedItem.ToString();

                        conn.Open();

                        // SQL sorgusu oluşturup filtrelemeyi yap
                        string tires_brand_filtered = $"SELECT * FROM Tires WHERE tire_brand = '{searchTireBrandItem}'";
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(tires_brand_filtered, conn);
                        DataTable dt = new DataTable();
                        dataAdapter.Fill(dt);

                        // DataGridView'i güncelle
                        dataGridView1.DataSource = dt;

                        conn.Close();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void textBoxTireDb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxBuiltPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxSalePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxTireNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnTireBrandAdd_Click(object sender, EventArgs e)
        {
            FormTireBrandAdd formTireBrandAdd = new FormTireBrandAdd();
            this.Hide();
            formTireBrandAdd.Show();
        }

        private void btnTireModelAdd_Click(object sender, EventArgs e)
        {
            FormTireModelAdd formTireModelAdd = new FormTireModelAdd();
            this.Hide();
            formTireModelAdd.Show();
        }

        private void btnTireSizeAdd_Click(object sender, EventArgs e)
        {
            FormTireSizeAdd formTireSizeAdd = new FormTireSizeAdd();
            this.Hide();
            formTireSizeAdd.Show();
        }

        private void btnTireRAdd_Click(object sender, EventArgs e)
        {
            FormTireRAdd formTireRAdd = new FormTireRAdd();
            this.Hide();
            formTireRAdd.Show();
        }
    }
}

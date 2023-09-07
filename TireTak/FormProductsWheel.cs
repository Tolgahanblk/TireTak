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
    public partial class FormProductsWheel : Form
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
        public FormProductsWheel()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        SqlConnection conn = new SqlConnection(MainClass.connString);
        private void FormProductsWheel_Load(object sender, EventArgs e)
        {
            dgwFillMethod();
            ComboBoxWheelBrandFillMethod();
            ComboBoxWheeSizeFillMethod();
            ComboBoxWheeRFillMethod();
            ComboBoxWheeModelFillMethod();
        }

        public void dgwFillMethod()
        {
            conn.Open();
            string wheels_select = "Select * from wheels";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(wheels_select, conn);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dgwFilterandDisplayMethod();
            conn.Close();
        }
        public void dgwFilterandDisplayMethod()
        {
            dataGridView1.Columns["wheel_id"].HeaderText = "ID";
            dataGridView1.Columns["wheel_brand"].HeaderText = "Araç Markası";
            dataGridView1.Columns["wheel_model"].HeaderText = "Jant Modeli";
            dataGridView1.Columns["wheel_size"].HeaderText = "Jant Ebatı";
            dataGridView1.Columns["wheel_r"].HeaderText = "Jant R";
            dataGridView1.Columns["wheel_built_price"].HeaderText = "Geliş Fiyatı";
            dataGridView1.Columns["wheel_sale_price"].HeaderText = "Satış Fiyatı";
            dataGridView1.Columns["wheel_number"].HeaderText = "Stok Adedi";

            //Görmek istemediğim columnları burada kapatıyorum
            dataGridView1.Columns["wheel_id"].Visible = false;
            dataGridView1.Columns["wheel_built_price"].Visible = true;

            //Column sıralaması için adlarını değiştiriyorum

            DataGridViewColumn column1 = dataGridView1.Columns["wheel_brand"];
            DataGridViewColumn column2 = dataGridView1.Columns["wheel_model"];
            DataGridViewColumn column3 = dataGridView1.Columns["wheel_size"];
            DataGridViewColumn column4 = dataGridView1.Columns["wheel_r"];
            DataGridViewColumn column5 = dataGridView1.Columns["wheel_built_price"];
            DataGridViewColumn column6 = dataGridView1.Columns["wheel_sale_price"];
            DataGridViewColumn column7 = dataGridView1.Columns["wheel_number"];

            //Columnları burada sıralıyorum.
            column1.DisplayIndex = 1;
            column2.DisplayIndex = 2;
            column3.DisplayIndex = 3;
            column4.DisplayIndex = 4;
            column5.DisplayIndex = 5;
            column6.DisplayIndex = 6;
            column7.DisplayIndex = 7;
        }
        public void ComboBoxWheelBrandFillMethod()
        {
            conn.Open();
            string wheel_brand_search = "Select wheel_brand from wheel_brand";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(wheel_brand_search, conn);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);


            foreach (DataRow row in dt.Rows)
            {
                comboBoxWheelBrand.Items.Add(row["wheel_brand"].ToString());
                comboBoxWheelBrandSearch.Items.Add(row["wheel_brand"].ToString());
            }
            conn.Close();
        }
        public void ComboBoxWheeSizeFillMethod()
        {
            conn.Open();
            string wheel_size_search = "Select wheel_size from wheel_size";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(wheel_size_search, conn);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);


            foreach (DataRow row in dt.Rows)
            {
                comboBoxWheelSize.Items.Add(row["wheel_size"].ToString());
                comboBoxWheelSizeSearch.Items.Add(row["wheel_size"].ToString());
            }
            conn.Close();
        }
        public void ComboBoxWheeRFillMethod()
        {
            conn.Open();
            string wheel_r_search = "Select wheel_r from wheel_r";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(wheel_r_search, conn);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);


            foreach (DataRow row in dt.Rows)
            {
                comboBoxWheelR.Items.Add(row["wheel_r"].ToString());
                comboBoxWheelRSearch.Items.Add(row["wheel_r"].ToString());
            }
            conn.Close();
        }
        public void ComboBoxWheeModelFillMethod()
        {
            conn.Open();
            string wheel_model_search = "Select wheel_model from wheel_model";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(wheel_model_search, conn);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);


            foreach (DataRow row in dt.Rows)
            {
                comboBoxWheelModel.Items.Add(row["wheel_model"].ToString());
            }
            conn.Close();
        }
        private void FormCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
            FormProducts formProducts = new FormProducts();
            formProducts.Show();
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

        private void textBoxWheelNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboBoxWheelBrandSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxWheelBrandSearch.SelectedItem != null)
                {
                    string searchWheelBrandItem = comboBoxWheelBrandSearch.SelectedItem.ToString();

                    conn.Open();

                    // SQL sorgusu oluşturup filtrelemeyi yap
                    string wheel_brand_filtered = $"SELECT * FROM wheels WHERE wheel_brand = '{searchWheelBrandItem}'";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(wheel_brand_filtered, conn);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);

                    // DataGridView'i güncelle
                    dataGridView1.DataSource = dt;

                    conn.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void comboBoxWheelSizeSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxWheelSizeSearch.SelectedItem != null)
                {
                    string searchWheelSizeItem = comboBoxWheelSizeSearch.SelectedItem.ToString();

                    conn.Open();

                    // SQL sorgusu oluşturup filtrelemeyi yap
                    string wheel_size_filtered = $"SELECT * FROM wheels WHERE wheel_size = '{searchWheelSizeItem}'";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(wheel_size_filtered, conn);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);

                    // DataGridView'i güncelle
                    dataGridView1.DataSource = dt;

                    conn.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void comboBoxWheelRSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxWheelRSearch.SelectedItem != null)
                {
                    string searchWheelRItem = comboBoxWheelRSearch.SelectedItem.ToString();

                    conn.Open();

                    // SQL sorgusu oluşturup filtrelemeyi yap
                    string wheel_r_filtered = $"SELECT * FROM wheels WHERE wheel_r = '{searchWheelRItem}'";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(wheel_r_filtered, conn);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);

                    // DataGridView'i güncelle
                    dataGridView1.DataSource = dt;

                    conn.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgwFillMethod();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                string wheelBrand = comboBoxWheelBrand.SelectedItem.ToString();
                string wheelModel = comboBoxWheelModel.SelectedItem.ToString();
                string wheelSize = comboBoxWheelSize.SelectedItem.ToString();
                string wheelR = comboBoxWheelR.SelectedItem.ToString();
                string wheelBuiltPrice = textBoxBuiltPrice.Text;
                string wheelSalePrice = textBoxSalePrice.Text;
                string wheelNumber = textBoxWheelNumber.Text;

                conn.Open();

                string insertQuery = "INSERT INTO wheels (wheel_brand, wheel_size, wheel_r, wheel_built_price, wheel_sale_price, wheel_number, wheel_model) VALUES (@wheelBrand, @wheelSize, @wheelR, @wheelBuiltPrice, @wheelSalePrice, @wheelNumber, @wheelModel )";

                SqlCommand cmd = new SqlCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@wheelBrand", wheelBrand);
                cmd.Parameters.AddWithValue("@wheelSize", wheelSize);
                cmd.Parameters.AddWithValue("@wheelR", wheelR);
                cmd.Parameters.AddWithValue("@wheelBuiltPrice", wheelBuiltPrice);
                cmd.Parameters.AddWithValue("@wheelSalePrice", wheelSalePrice);
                cmd.Parameters.AddWithValue("@wheelNumber", wheelNumber);
                cmd.Parameters.AddWithValue("@wheelModel", wheelModel);
                
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
                MessageBox.Show(ex.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;

            comboBoxWheelBrand.Text = dataGridView1.Rows[selectedRowIndex].Cells[1].Value.ToString();
            comboBoxWheelModel.Text = dataGridView1.Rows[selectedRowIndex].Cells[7].Value.ToString();
            comboBoxWheelSize.Text = dataGridView1.Rows[selectedRowIndex].Cells[2].Value.ToString();
            comboBoxWheelR.Text = dataGridView1.Rows[selectedRowIndex].Cells[3].Value.ToString();
            textBoxBuiltPrice.Text = dataGridView1.Rows[selectedRowIndex].Cells[4].Value.ToString();
            textBoxSalePrice.Text = dataGridView1.Rows[selectedRowIndex].Cells[5].Value.ToString();
            textBoxWheelNumber.Text = dataGridView1.Rows[selectedRowIndex].Cells[6].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int selectedIndex = dataGridView1.SelectedRows[0].Index;
                    string wheelid = dataGridView1.Rows[selectedIndex].Cells["wheel_id"].Value.ToString();
                    conn.Open();

                    string deleteQuery = "DELETE FROM wheels WHERE wheel_id = @wheelid";
                    SqlCommand cmd = new SqlCommand(deleteQuery, conn);
                    cmd.Parameters.AddWithValue("@wheelid", wheelid);

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
                    string wheelid = dataGridView1.Rows[selectedIndex].Cells["wheel_id"].Value.ToString();

                    string newWheelBrand = comboBoxWheelBrand.SelectedItem.ToString();
                    string newWheelModel = comboBoxWheelModel.SelectedItem.ToString();
                    string newWheelSize = comboBoxWheelSize.SelectedItem.ToString();
                    string newWheelR = comboBoxWheelR.SelectedItem.ToString();
                    string newWheelBuiltPrice = textBoxBuiltPrice.Text;
                    string newWheelSalePrice = textBoxSalePrice.Text;
                    string newWheelNumber = textBoxWheelNumber.Text;

                    conn.Open();

                    string updateQuery = "UPDATE wheels SET wheel_brand = @newWheelBrand, wheel_size = @newWheelSize, wheel_r = @newWheelR, wheel_built_price = @newWheelBuiltPrice, wheel_sale_price = @newWheelSalePrice, wheel_number = @newWheelNumber, wheel_model = @newWheelModel WHERE wheel_id = @wheelid";

                    SqlCommand cmd = new SqlCommand(updateQuery, conn);

                    cmd.Parameters.AddWithValue("@wheelid", wheelid);
                    cmd.Parameters.AddWithValue("@newWheelBrand", newWheelBrand);
                    cmd.Parameters.AddWithValue("@newWheelModel", newWheelModel);
                    cmd.Parameters.AddWithValue("@newWheelSize", newWheelSize);
                    cmd.Parameters.AddWithValue("@newWheelBuiltPrice", newWheelBuiltPrice);
                    cmd.Parameters.AddWithValue("@newWheelSalePrice", newWheelSalePrice);
                    cmd.Parameters.AddWithValue("@newWheelR", newWheelR);
                    cmd.Parameters.AddWithValue("@newWheelNumber", newWheelNumber);

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

        private void btnWheelBrandAdd_Click(object sender, EventArgs e)
        {
            FormWheelBrandAdd formWheelBrandAdd = new FormWheelBrandAdd();
            this.Hide();
            formWheelBrandAdd.Show();
        }

        private void btnWheelModelAdd_Click(object sender, EventArgs e)
        {
            FormWheelModelAdd formWheelModelAdd = new FormWheelModelAdd();
            this.Hide();
            formWheelModelAdd.Show();
        }

        private void btnWheelSizeAdd_Click(object sender, EventArgs e)
        {
            FormWheelSizeAdd formWheelSizeAdd = new FormWheelSizeAdd();
            this.Hide();
            formWheelSizeAdd.Show();
        }

        private void btnWheelRAdd_Click(object sender, EventArgs e)
        {
            FormWheelRAdd formWheelRAdd = new FormWheelRAdd();
            this.Hide();
            formWheelRAdd.Show();
        }
    }
}

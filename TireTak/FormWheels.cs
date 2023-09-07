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
using System.Reflection.Emit;

namespace TireTak
{
    public partial class FormWheels : Form
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
        public FormWheels()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        SqlConnection conn = new SqlConnection(MainClass.connString);
        private void FormWheels_Load(object sender, EventArgs e)
        {
            ComboBoxWheelBrandFillMethod();
            ComboBoxWheeSizeFillMethod();
            ComboBoxWheeRFillMethod();
            dgwFillMethod();
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
                comboBoxWheelRSearch.Items.Add(row["wheel_r"].ToString());
            }
            conn.Close();
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
            dataGridView1.Columns["wheel_built_price"].Visible = false;

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
        public void RecordSale(int wheelId, int quantity, decimal salePrice, decimal builtPrice, string wheelBrand, string wheelSize, string wheelModel, string wheelr)
        {
            conn.Open();
            string insertQuery = $"INSERT INTO wheel_saled (wheel_id, quantity, sale_date, sale_price, built_price, profit, wheel_brand, wheel_size, wheel_model, wheel_r) " + $"VALUES ({wheelId}, {quantity}, GETDATE(), {salePrice}, {builtPrice}, {salePrice - builtPrice}, '{wheelBrand}', '{wheelSize}', '{wheelModel}', '{wheelr}')";
            SqlCommand insertCommand = new SqlCommand(insertQuery, conn);
            insertCommand.ExecuteNonQuery();
            conn.Close();
        }

        private void FormCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
            FormMain formMain = new FormMain();
            formMain.Show();
        }

        private void dgwFillbtn_Click(object sender, EventArgs e)
        {
            dgwFillMethod();
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Tıklanan hücrenin satır indeksi
            int rowIndex = e.RowIndex;

            if (rowIndex >= 0) // Başlıklara tıklanınca -1 döner, kontrol ediyoruz
            {
                // Seçilen satırdaki hücreleri alalım
                DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];
                string wheel_brand = selectedRow.Cells["wheel_brand"].Value.ToString();
                string wheel_model = selectedRow.Cells["wheel_model"].Value.ToString();
                string wheel_size = selectedRow.Cells["wheel_size"].Value.ToString();
                string wheel_r = selectedRow.Cells["wheel_r"].Value.ToString();
                string wheel_sale_price = selectedRow.Cells["wheel_sale_price"].Value.ToString();

                // Label'a aktaralım
                LabelBrand.Text = "Araç Markası : " + wheel_brand;
                LabelModel.Text = "Jant Modeli : " + wheel_model;
                LabelSize.Text = "Jant Ebatı : " + wheel_size;
                LabelR.Text = "Jant R : " + wheel_r;
                LabelSalePrice.Text = "ADET FİYATI : " + wheel_sale_price + " TL";

                int totalPrice = Convert.ToInt32(wheel_sale_price);

                LabelTotalPrice.Text = "TAKIM FİYATI : " + (totalPrice * 4) + " TL";
            }
        }

        private void btnSatis1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(LabelSalePrice.Text + " , 1 Adet satış gerçekleşecektir. Onaylıyor musunuz ?", "Jant Satış Onayı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                        int wheelId = Convert.ToInt32(selectedRow.Cells["wheel_id"].Value);
                        int wheelNumber = Convert.ToInt32(selectedRow.Cells["wheel_number"].Value);
                        decimal wheelSalePrice = Convert.ToDecimal(selectedRow.Cells["wheel_sale_price"].Value);
                        decimal wheelBuiltPrice = Convert.ToDecimal(selectedRow.Cells["wheel_built_price"].Value);
                        string wheelBrand = selectedRow.Cells["wheel_brand"].Value.ToString();
                        string wheelSize = selectedRow.Cells["wheel_size"].Value.ToString();
                        string wheelModel = selectedRow.Cells["wheel_model"].Value.ToString();
                        string wheelr = selectedRow.Cells["wheel_r"].Value.ToString();


                        if (wheelNumber > 0)
                        {
                            // Veritabanında satışı kaydet
                            RecordSale(wheelId, 1, wheelSalePrice, wheelBuiltPrice, wheelBrand, wheelSize, wheelModel, wheelr);

                            conn.Open();
                            string updateQuery = $"UPDATE wheels SET wheel_number = wheel_number - 1 WHERE wheel_id = {wheelId}";
                            SqlCommand updateCommand = new SqlCommand(updateQuery, conn);
                            updateCommand.ExecuteNonQuery();
                            conn.Close();

                            dgwFillMethod();
                        }
                        else
                        {
                            MessageBox.Show("Bu Jant stokta kalmamıştır.", "Stok Yok", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen satış yapmak için bir jant seçin.", "Seçim Yok", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }

            }

        }

        private void btnSatis4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(LabelTotalPrice.Text + " , 4 Adet satış gerçekleşecektir. Onaylıyor musunuz ?", "Jant Satış Onayı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                        int wheelId = Convert.ToInt32(selectedRow.Cells["wheel_id"].Value);
                        int wheelNumber = Convert.ToInt32(selectedRow.Cells["wheel_number"].Value);
                        decimal wheelSalePrice = Convert.ToDecimal(selectedRow.Cells["wheel_sale_price"].Value);
                        decimal wheelBuiltPrice = Convert.ToDecimal(selectedRow.Cells["wheel_built_price"].Value);
                        string wheelBrand = selectedRow.Cells["wheel_brand"].Value.ToString();
                        string wheelSize = selectedRow.Cells["wheel_size"].Value.ToString();
                        string wheelModel = selectedRow.Cells["wheel_model"].Value.ToString();
                        string wheelr = selectedRow.Cells["wheel_r"].Value.ToString();

                        if (wheelNumber >= 4)
                        {
                            // Veritabanında satışı kaydet
                            RecordSale(wheelId, 4, wheelSalePrice * 4, wheelBuiltPrice * 4, wheelBrand, wheelSize, wheelModel, wheelr);

                            conn.Open();
                            string updateQuery = $"UPDATE wheels SET wheel_number = wheel_number - 4 WHERE wheel_id = {wheelId}";
                            SqlCommand updateCommand = new SqlCommand(updateQuery, conn);
                            updateCommand.ExecuteNonQuery();
                            conn.Close();

                            dgwFillMethod();
                        }
                        else
                        {
                            MessageBox.Show("Bu janttan stokta yeterli adet yoktur.", "Stok Yok", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen satış yapmak için bir jant seçin.", "Seçim Yok", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }

            }
        }
    }
}

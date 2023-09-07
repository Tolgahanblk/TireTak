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
    public partial class FormTires : Form
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
        public FormTires()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        SqlConnection conn = new SqlConnection(MainClass.connString);

        private void FormTires_Load(object sender, EventArgs e)
        {
            dgwFillMethod();
            dgwFilterandDisplayMethod();
            ComboBoxTireSizeFillMethod();
            ComboBoxTireBrandFillMethod();
            ComboBoxTireRFillMethod();
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
            dataGridView1.Columns["tire_built_price"].Visible = false;

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
        public void RecordSale(int tireId, int quantity, decimal salePrice, decimal builtPrice, string tireBrand, string tireSize, string tireModel)
        {
            conn.Open();
            string insertQuery = $"INSERT INTO tire_saled (tire_id, quantity, sale_date, sale_price, built_price, profit, tire_brand, tire_size, tire_model) " + $"VALUES ({tireId}, {quantity}, GETDATE(), {salePrice}, {builtPrice}, {salePrice - builtPrice}, '{tireBrand}', '{tireSize}', '{tireModel}')";
            SqlCommand insertCommand = new SqlCommand(insertQuery, conn);
            insertCommand.ExecuteNonQuery();
            conn.Close();
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
        public void ComboBoxTireSizeFillMethod()
        {
            conn.Open();
            string tires_size_search = "Select tire_size from Tire_size";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(tires_size_search, conn);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);


            foreach (DataRow row in dt.Rows)
            {
                comboBoxTireSizeSearch.Items.Add(row["tire_size"].ToString());
            }
            conn.Close();
        }
        public void ComboBoxTireBrandFillMethod()
        {
            conn.Open();
            string tires_brand_search = "Select tire_brand from Tires_brand";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(tires_brand_search, conn);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);


            foreach (DataRow row in dt.Rows)
            {
                comboBoxTireBrandSearch.Items.Add(row["tire_brand"].ToString());
            }
            conn.Close();
        }
        public void ComboBoxTireRFillMethod()
        {
            conn.Open();
            string tires_r_search = "Select tire_r from tire_r";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(tires_r_search, conn);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);


            foreach (DataRow row in dt.Rows)
            {
                comboBoxTireRSearch.Items.Add(row["tire_r"].ToString());
            }
            conn.Close();
        }

        private void FormCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
            FormMain formMain = new FormMain();
            formMain.Show();
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

                MessageBox.Show(ex.ToString());
            }

        }

        private void dgwFillbtn_Click(object sender, EventArgs e)
        {
            dgwFillMethod();

        }

        private void comboBoxTireBrandSearch_SelectedIndexChanged(object sender, EventArgs e)
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

                MessageBox.Show(ex.ToString());
            }

        }

        private void comboBoxTireRSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxTireRSearch.SelectedItem != null)
                {
                    string searchTireRItem = comboBoxTireRSearch.SelectedItem.ToString();

                    conn.Open();

                    // SQL sorgusu oluşturup filtrelemeyi yap
                    string tires_r_filtered = $"SELECT * FROM Tires WHERE tire_r = '{searchTireRItem}'";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(tires_r_filtered, conn);
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
                string tire_brand = selectedRow.Cells["tire_brand"].Value.ToString();
                string tire_model = selectedRow.Cells["tire_model"].Value.ToString();
                string tire_size = selectedRow.Cells["tire_size"].Value.ToString();
                string tire_r = selectedRow.Cells["tire_r"].Value.ToString();
                string tire_db = selectedRow.Cells["tire_db"].Value.ToString();
                string tire_sale_price = selectedRow.Cells["tire_sale_price"].Value.ToString();

                // Label'a aktaralım
                LabelBrand.Text = "Lastik Markası : " + tire_brand;
                LabelModel.Text = "Lastik Modeli : " + tire_model;
                LabelSize.Text = "Lastik Ebatı : " + tire_size + " " + tire_r;
                LabelDb.Text = "Latik Db : " + tire_db;
                LabelSalePrice.Text = "ADET FİYATI : " + tire_sale_price + " TL";

                int totalPrice = Convert.ToInt32(tire_sale_price);

                LabelTotalPrice.Text = "TAKIM FİYATI : " + (totalPrice * 4) + " TL";
            }
        }

        private void btnSatis1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(LabelSalePrice.Text + " , 1 Adet satış gerçekleşecektir. Onaylıyor musunuz ?", "Lastik Satış Onayı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                        int tireId = Convert.ToInt32(selectedRow.Cells["tire_id"].Value);
                        int tireNumber = Convert.ToInt32(selectedRow.Cells["tire_number"].Value);
                        decimal tireSalePrice = Convert.ToDecimal(selectedRow.Cells["tire_sale_price"].Value);
                        decimal tireBuiltPrice = Convert.ToDecimal(selectedRow.Cells["tire_built_price"].Value);
                        string tireBrand = selectedRow.Cells["tire_brand"].Value.ToString();
                        string tireSize = selectedRow.Cells["tire_size"].Value.ToString();
                        string tireModel = selectedRow.Cells["tire_model"].Value.ToString();

                        if (tireNumber > 0)
                        {
                            // Veritabanında satışı kaydet
                            RecordSale(tireId, 1, tireSalePrice, tireBuiltPrice, tireBrand, tireSize, tireModel);

                            conn.Open();
                            string updateQuery = $"UPDATE Tires SET tire_number = tire_number - 1 WHERE tire_id = {tireId}";
                            SqlCommand updateCommand = new SqlCommand(updateQuery, conn);
                            updateCommand.ExecuteNonQuery();
                            conn.Close();

                            dgwFillMethod();
                        }
                        else
                        {
                            MessageBox.Show("Bu lastik stokta kalmamıştır.", "Stok Yok", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen satış yapmak için bir lastik seçin.", "Seçim Yok", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            DialogResult result = MessageBox.Show(LabelTotalPrice.Text + " , 4 Adet satış gerçekleşecektir. Onaylıyor musunuz ?", "Lastik Satış Onayı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                        int tireId = Convert.ToInt32(selectedRow.Cells["tire_id"].Value);
                        int tireNumber = Convert.ToInt32(selectedRow.Cells["tire_number"].Value);
                        decimal tireSalePrice = Convert.ToDecimal(selectedRow.Cells["tire_sale_price"].Value);
                        decimal tireBuiltPrice = Convert.ToDecimal(selectedRow.Cells["tire_built_price"].Value);
                        string tireBrand = selectedRow.Cells["tire_brand"].Value.ToString();
                        string tireSize = selectedRow.Cells["tire_size"].Value.ToString();
                        string tireModel = selectedRow.Cells["tire_model"].Value.ToString();

                        if (tireNumber >= 4)
                        {
                            // Veritabanında satışı kaydet
                            RecordSale(tireId, 4, tireSalePrice * 4, tireBuiltPrice * 4, tireBrand, tireSize, tireModel);

                            conn.Open();
                            string updateQuery = $"UPDATE Tires SET tire_number = tire_number - 4 WHERE tire_id = {tireId}";
                            SqlCommand updateCommand = new SqlCommand(updateQuery, conn);
                            updateCommand.ExecuteNonQuery();
                            conn.Close();

                            dgwFillMethod();
                        }
                        else
                        {
                            MessageBox.Show("Bu lastikten stokta yeterli adet yoktur.", "Stok Yok", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen satış yapmak için bir lastik seçin.", "Seçim Yok", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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


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
using System.Drawing.Printing;

namespace TireTak
{
    public partial class FormSales : Form
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
        public FormSales()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        SqlConnection conn = new SqlConnection(MainClass.connString);
        private PrintDialog printDialog1 = new PrintDialog();

        private void FormSales_Load(object sender, EventArgs e)
        {
            ComboBoxTireBrandSearchFillMethod();
            ComboBoxTireSizeSearchFillMethod();
            ComboBoxWheeSizeFillMethod();
            ComboBoxWheelBrandFillMethod();
            ComboBoxWheelRFillMethod();
        }

        private void FormCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
            FormMain formMain = new FormMain();
            formMain.Show();
        }

        private void dgwFillTiresbtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            string tire_saled = "Select * from tire_saled";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(tire_saled, conn);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dgwTireFilterandDisplayMethod();
            conn.Close();
        }

        private void dgwFillWheelsbtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            string wheel_saled = "Select * from wheel_saled";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(wheel_saled, conn);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dgwWheelFilterandDisplayMethod();
            conn.Close();
        }

        private void dailyWheelSaleReportbtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            string wheel_saled = "SELECT * FROM wheel_saled WHERE CAST(sale_date AS DATE) = CAST(GETDATE() AS DATE)";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(wheel_saled, conn);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dgwWheelFilterandDisplayMethod();
            conn.Close();
        }

        private void dailyTireSaleReportbtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            string tire_saled = "SELECT * FROM tire_saled WHERE CAST(sale_date AS DATE) = CAST(GETDATE() AS DATE)";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(tire_saled, conn);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dgwTireFilterandDisplayMethod();
            conn.Close();
        }

        public void dgwWheelFilterandDisplayMethod()
        {
            dataGridView1.Columns["wheel_id"].HeaderText = "ID";
            dataGridView1.Columns["quantity"].HeaderText = "Satılan Adet";
            dataGridView1.Columns["sale_date"].HeaderText = "Satış Tarihi";
            dataGridView1.Columns["sale_price"].HeaderText = "Satış Fiyatı";
            dataGridView1.Columns["built_price"].HeaderText = "Alış Fiyatı";
            dataGridView1.Columns["profit"].HeaderText = "Kazanç";
            dataGridView1.Columns["wheel_brand"].HeaderText = "Araç Modeli";
            dataGridView1.Columns["wheel_size"].HeaderText = "Jant Ebatı";
            dataGridView1.Columns["wheel_r"].HeaderText = "Jant R";
            dataGridView1.Columns["wheel_model"].HeaderText = "Jant Model";

            //Görmek istemediğim columnları burada kapatıyorum
            dataGridView1.Columns["wheel_id"].Visible = false;

            //Column sıralaması için adlarını değiştiriyorum
            DataGridViewColumn column1 = dataGridView1.Columns["quantity"];
            DataGridViewColumn column2 = dataGridView1.Columns["sale_date"];
            DataGridViewColumn column3 = dataGridView1.Columns["sale_price"];
            DataGridViewColumn column4 = dataGridView1.Columns["built_price"];
            DataGridViewColumn column5 = dataGridView1.Columns["profit"];
            DataGridViewColumn column6 = dataGridView1.Columns["wheel_brand"];
            DataGridViewColumn column7 = dataGridView1.Columns["wheel_size"];
            DataGridViewColumn column8 = dataGridView1.Columns["wheel_r"];
            DataGridViewColumn column9 = dataGridView1.Columns["wheel_model"];

            //Columnları burada sıralıyorum.
            column1.DisplayIndex = 2;
            column2.DisplayIndex = 1;
            column3.DisplayIndex = 3;
            column4.DisplayIndex = 4;
            column5.DisplayIndex = 5;
            column6.DisplayIndex = 6;
            column7.DisplayIndex = 9;
            column8.DisplayIndex = 8;
            column9.DisplayIndex = 7;
        }
        public void dgwTireFilterandDisplayMethod()
        {
            dataGridView1.Columns["tire_id"].HeaderText = "ID";
            dataGridView1.Columns["quantity"].HeaderText = "Satılan Adet";
            dataGridView1.Columns["sale_date"].HeaderText = "Satış Tarihi";
            dataGridView1.Columns["sale_price"].HeaderText = "Satış Fiyatı";
            dataGridView1.Columns["built_price"].HeaderText = "Alış Fiyatı";
            dataGridView1.Columns["profit"].HeaderText = "Kazanç";
            dataGridView1.Columns["tire_brand"].HeaderText = "Lastik Markası";
            dataGridView1.Columns["tire_size"].HeaderText = "Lastik Ebatı";
            dataGridView1.Columns["tire_model"].HeaderText = "Lastik Model";

            //Görmek istemediğim columnları burada kapatıyorum
            dataGridView1.Columns["tire_id"].Visible = false;

            //Column sıralaması için adlarını değiştiriyorum
            DataGridViewColumn column1 = dataGridView1.Columns["quantity"];
            DataGridViewColumn column2 = dataGridView1.Columns["sale_date"];
            DataGridViewColumn column3 = dataGridView1.Columns["sale_price"];
            DataGridViewColumn column4 = dataGridView1.Columns["built_price"];
            DataGridViewColumn column5 = dataGridView1.Columns["profit"];
            DataGridViewColumn column6 = dataGridView1.Columns["tire_brand"];
            DataGridViewColumn column7 = dataGridView1.Columns["tire_size"];
            DataGridViewColumn column8 = dataGridView1.Columns["tire_model"];

            //Columnları burada sıralıyorum.
            column1.DisplayIndex = 2;
            column2.DisplayIndex = 1;
            column3.DisplayIndex = 3;
            column4.DisplayIndex = 4;
            column5.DisplayIndex = 5;
            column6.DisplayIndex = 6;
            column7.DisplayIndex = 8;
            column8.DisplayIndex = 7;
        }

        private void dtpTireDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtpTireDate.Value != null)
                {
                    conn.Open();

                    // SQL sorgusu oluşturup filtrelemeyi yap
                    string tire_by_date_search = "SELECT * FROM tire_saled WHERE sale_date BETWEEN @startDate AND @endDate";

                    SqlCommand cmd = new SqlCommand(tire_by_date_search, conn);
                    cmd.Parameters.AddWithValue("@startDate", dtpTireDate.Value.Date); // Tarihin başlangıcı (00:00:00)
                    cmd.Parameters.AddWithValue("@endDate", dtpTireDate.Value.Date.AddSeconds(86399)); // Tarihin sonu (23:59:59)

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);

                    // DataGridView'i güncelle
                    dataGridView1.DataSource = dt;
                    dgwTireFilterandDisplayMethod();

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void dtpWheelDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtpWheelDate.Value != null)
                {
                    conn.Open();

                    // SQL sorgusu oluşturup filtrelemeyi yap
                    string wheel_by_date_search = "SELECT * FROM wheel_saled WHERE sale_date BETWEEN @startDate AND @endDate";

                    SqlCommand cmd = new SqlCommand(wheel_by_date_search, conn);
                    cmd.Parameters.AddWithValue("@startDate", dtpWheelDate.Value.Date); // Tarihin başlangıcı (00:00:00)
                    cmd.Parameters.AddWithValue("@endDate", dtpWheelDate.Value.Date.AddSeconds(86399)); // Tarihin sonu (23:59:59)

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);

                    // DataGridView'i güncelle
                    dataGridView1.DataSource = dt;
                    dgwWheelFilterandDisplayMethod();

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dtpTireDate_KeyDown(object sender, KeyEventArgs e)
        {
            //klavyeden girişi engelle
            e.SuppressKeyPress = true;
        }

        private void dtpWheelDate_KeyDown(object sender, KeyEventArgs e)
        {
            //klavyeden girişi engelle
            e.SuppressKeyPress = true;
        }

        private void cbxTireBrandSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbxTireBrandSearch.SelectedItem != null)
                {
                    string searchTireBrandItem = cbxTireBrandSearch.SelectedItem.ToString();

                    conn.Open();

                    // SQL sorgusu oluşturup filtrelemeyi yap
                    string tires_brand_filtered = $"SELECT * FROM tire_saled WHERE tire_brand = '{searchTireBrandItem}'";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(tires_brand_filtered, conn);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);

                    // DataGridView'i güncelle
                    dataGridView1.DataSource = dt;
                    dgwTireFilterandDisplayMethod();

                    conn.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        public void ComboBoxTireBrandSearchFillMethod()
        {
            conn.Open();
            string tires_brand_search = "Select tire_brand from Tires_brand";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(tires_brand_search, conn);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);


            foreach (DataRow row in dt.Rows)
            {
                cbxTireBrandSearch.Items.Add(row["tire_brand"].ToString());
            }
            conn.Close();
        }
        public void ComboBoxTireSizeSearchFillMethod()
        {
            conn.Open();
            string tires_size_search = "Select tire_size from Tire_size";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(tires_size_search, conn);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);


            foreach (DataRow row in dt.Rows)
            {
                cbxTireSizeSearch.Items.Add(row["tire_size"].ToString());
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
                cbxWheelSizeSearch.Items.Add(row["wheel_size"].ToString());
            }
            conn.Close();
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
                cbxWheelBrandSearch.Items.Add(row["wheel_brand"].ToString());
            }
            conn.Close();
        }
        public void ComboBoxWheelRFillMethod()
        {
            conn.Open();
            string wheel_r_search = "Select wheel_r from wheel_r";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(wheel_r_search, conn);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);


            foreach (DataRow row in dt.Rows)
            {
                cbxWheelRSearch.Items.Add(row["wheel_r"].ToString());
            }
            conn.Close();
        }

        private void cbxTireSizeSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbxTireSizeSearch.SelectedItem != null)
                {
                    string searchTireSizeItem = cbxTireSizeSearch.SelectedItem.ToString();

                    conn.Open();

                    // SQL sorgusu oluşturup filtrelemeyi yap
                    string tires_size_filtered = $"SELECT * FROM Tire_size WHERE tire_size = '{searchTireSizeItem}'";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(tires_size_filtered, conn);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);

                    // DataGridView'i güncelle
                    dataGridView1.DataSource = dt;
                    dgwTireFilterandDisplayMethod();

                    conn.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void cbxWheelBrandSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbxWheelBrandSearch.SelectedItem != null)
                {
                    string searchWheelBrandItem = cbxWheelBrandSearch.SelectedItem.ToString();

                    conn.Open();

                    // SQL sorgusu oluşturup filtrelemeyi yap
                    string wheel_brand_filtered = $"SELECT * FROM wheel_saled WHERE wheel_brand = '{searchWheelBrandItem}'";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(wheel_brand_filtered, conn);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);

                    // DataGridView'i güncelle
                    dataGridView1.DataSource = dt;
                    dgwWheelFilterandDisplayMethod();

                    conn.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void cbxWheelSizeSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbxWheelSizeSearch.SelectedItem != null)
                {
                    string searchTireSizeItem = cbxWheelSizeSearch.SelectedItem.ToString();

                    conn.Open();

                    // SQL sorgusu oluşturup filtrelemeyi yap
                    string wheel_size_filtered = $"SELECT * FROM wheel_saled WHERE wheel_size = '{searchTireSizeItem}'";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(wheel_size_filtered, conn);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);

                    // DataGridView'i güncelle
                    dataGridView1.DataSource = dt;
                    dgwWheelFilterandDisplayMethod();

                    conn.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void cbxWheelRSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbxWheelRSearch.SelectedItem != null)
                {
                    string searchWheelRItem = cbxWheelRSearch.SelectedItem.ToString();

                    conn.Open();

                    // SQL sorgusu oluşturup filtrelemeyi yap
                    string wheel_r_filtered = $"SELECT * FROM wheel_saled WHERE wheel_r = '{searchWheelRItem}'";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(wheel_r_filtered, conn);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);

                    // DataGridView'i güncelle
                    dataGridView1.DataSource = dt;
                    dgwWheelFilterandDisplayMethod();

                    conn.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {

            //printDocument1.Print();
            // Kullanıcıya yazıcı seçme işlemi için PrintDialog'ı göster.
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                // Seçilen yazıcıyı kullanarak bir PrintDocument nesnesi oluştur.
                PrintDocument printDocument1 = new PrintDocument();
                printDocument1.PrinterSettings = printDialog1.PrinterSettings;

                // PrintDocument'ı kullanarak yazdırma işlemini başlat.
                printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
                printDocument1.Print();
            }
        }


        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Yazdırılacak metni saklamak için bir StringBuilder oluştur.
            StringBuilder sb = new StringBuilder();

            // Yazdırılacak sütunların adlarını belirle (örneğin, "Ad", "Soyad", "Yaş" gibi)
            string[] columnsToPrint = { "Satılan Adet", "Satış Tarihi", "Satış Fiyatı", "Alış Fiyatı", "Kazanç" };

            // Sütun başlıklarını yazdır
            for (int i = 0; i < columnsToPrint.Length; i++)
            {
                sb.Append(columnsToPrint[i]).Append("\t");
                e.Graphics.FillRectangle(Brushes.LightBlue, new Rectangle(i * 150, 0, 150, 40));
                e.Graphics.DrawString(columnsToPrint[i], new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new RectangleF(i * 150, 0, 150, 45));
            }

            // Yeni satır ekle
            sb.AppendLine();

           

            // DataGridView verilerini ekle ve yalnızca belirtilen sütunları ekle
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                int xcor = 20, ycor = 20;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (columnsToPrint.Contains(dataGridView1.Columns[cell.ColumnIndex].HeaderText))
                    {
                        // Hücre içeriğini ekle
                        sb.Append(cell.Value).Append("\t");

                       
                        // Hücre içeriğini çiz
                        e.Graphics.DrawString(cell.Value.ToString(), new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new RectangleF(cell.ColumnIndex * xcor, (row.Index + 1) * 45, 150, 45));

                        xcor += 45;
                        ycor += 10;
                    }
                }
            }

            // Metni yazdır
          //  e.Graphics.DrawString(sb.ToString(), new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new PointF(150, 150));

        }
    }
}

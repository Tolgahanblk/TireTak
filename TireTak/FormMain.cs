using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace TireTak
{
    public partial class FormMain : Form
    {
        #region Form kenarları yuvarlama
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

        public FormMain()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            string newImagePath = "C:\\Users\\BT\\source\\repos\\TireTak\\TireTak\\Images\\blk.PNG";
            pictureBox1.ImageLocation = newImagePath;
        }

        private void btnLastikler_MouseHover(object sender, EventArgs e)
        {
            string newImagePath = "C:\\Users\\BT\\source\\repos\\TireTak\\TireTak\\Images\\tire_login.png";
            pictureBox1.ImageLocation = newImagePath;
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Çıkmak istediğinizden emin misiniz?", "Çıkış Onayı", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnJantlar_MouseHover(object sender, EventArgs e)
        {
            string newImagePath = "C:\\Users\\BT\\source\\repos\\TireTak\\TireTak\\Images\\wheeel.png";
            pictureBox1.ImageLocation = newImagePath;
        }

        private void btnCikis_MouseHover(object sender, EventArgs e)
        {
            string newImagePath = "C:\\Users\\BT\\source\\repos\\TireTak\\TireTak\\Images\\exit2.png";
            pictureBox1.ImageLocation = newImagePath;
        }

        private void btnUrunIslemleri_MouseHover(object sender, EventArgs e)
        {
            string newImagePath = "C:\\Users\\BT\\source\\repos\\TireTak\\TireTak\\Images\\product.png";
            pictureBox1.ImageLocation = newImagePath;
        }

        private void btnSatislar_MouseHover(object sender, EventArgs e)
        {
            string newImagePath = "C:\\Users\\BT\\source\\repos\\TireTak\\TireTak\\Images\\sales.png";
            pictureBox1.ImageLocation = newImagePath;


        }

        private void btnLatikler_Click(object sender, EventArgs e)
        {
            FormTires formTires = new FormTires();
            this.Hide();
            formTires.Show();
        }

        private void btnJantlar_Click(object sender, EventArgs e)
        {
            FormWheels formWheels = new FormWheels();
            this.Hide();
            formWheels.Show();
        }

        private void btnUrunIslemleri_Click(object sender, EventArgs e)
        {
            FormProducts formProducts = new FormProducts();
            this.Hide();
            formProducts.Show();
        }

        private void btnSatislar_Click(object sender, EventArgs e)
        {
            FormSales formSales = new FormSales();
            this.Hide();
            formSales.Show();
        }
    }
}

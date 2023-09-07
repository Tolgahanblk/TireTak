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
    public partial class FormProducts : Form
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
        public FormProducts()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void btnLastikler_Click(object sender, EventArgs e)
        {
            FormProductsTire formProductsTire = new FormProductsTire();
            this.Hide();
            formProductsTire.Show();
        }

        private void btnJantlar_Click(object sender, EventArgs e)
        {
            FormProductsWheel formProductsWheel = new FormProductsWheel();
            this.Hide();
            formProductsWheel.Show();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain();
            this.Hide();
            formMain.Show();
        }

        private void btnLastikler_MouseHover(object sender, EventArgs e)
        {
            string newImagePath = "C:\\Users\\BT\\source\\repos\\TireTak\\TireTak\\Images\\tire_login.png";
            pictureBox1.ImageLocation = newImagePath;
        }

        private void btnJantlar_MouseHover(object sender, EventArgs e)
        {
            string newImagePath = "C:\\Users\\BT\\source\\repos\\TireTak\\TireTak\\Images\\wheeel.png";
            pictureBox1.ImageLocation = newImagePath;
        }

        private void btnGeri_MouseHover(object sender, EventArgs e)
        {
            string newImagePath = "C:\\Users\\BT\\source\\repos\\TireTak\\TireTak\\Images\\exit.png";
            pictureBox1.ImageLocation = newImagePath;
        }
    }
}

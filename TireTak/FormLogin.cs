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
using TireTak.Class;

namespace TireTak
{
    public partial class FormLogin : Form
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
        public FormLogin()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        SqlConnection sqlConn = new SqlConnection(MainClass.connString);
        public static bool Sonuc = false;

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void FormCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();

        }

        private void LoginButton1_Click(object sender, EventArgs e)
        {
            SqlCommand UserLoginCommand = new SqlCommand("Select user_name, user_password from Users", sqlConn);

            if (sqlConn.State == ConnectionState.Closed)
                sqlConn.Open();

            SqlDataReader sqlDr = UserLoginCommand.ExecuteReader();
            bool Adi = false;

            while (sqlDr.Read())
            {
                if (txtKullaniciadi.Text.Trim() == sqlDr["user_name"].ToString() && txtParola.Text.Trim() == sqlDr["user_password"].ToString())
                {
                    Sonuc = true;

                    txtKullaniciadi.Focus();
                }
                else if (txtKullaniciadi.Text.Trim() == sqlDr["user_name"].ToString() && txtParola.Text.Trim() != sqlDr["user_password"].ToString())
                {
                    Adi = true;
                }
            }
            sqlDr.Close();
            sqlConn.Close();

            if (Sonuc)
            {
                this.Hide();
                FormMain formMain = new FormMain();
                formMain.Show();


            }
            else if (txtKullaniciadi.Text == "")
            {
                MessageBox.Show("Kullanıcı Adı Alanı Boş Bırakılamaz !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtParola.Text == "")
            {
                MessageBox.Show("Parola Alanı Boş Bırakılamaz !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Adi == true && Sonuc == false)
            {
                MessageBox.Show("Girmiş olduğunuz parola yanlış !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Girmiş olduğunuz bilgiler hatalı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtKullaniciadi.BackColor = Color.Red;
                txtParola.BackColor = Color.Red;
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

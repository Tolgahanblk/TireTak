namespace TireTak
{
    partial class FormTires
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTires));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSatis1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FormCloseButton = new System.Windows.Forms.Button();
            this.comboBoxTireSizeSearch = new System.Windows.Forms.ComboBox();
            this.dgwFillbtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxTireBrandSearch = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBoxTireRSearch = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSatis4 = new System.Windows.Forms.Button();
            this.LabelTotalPrice = new System.Windows.Forms.Label();
            this.LabelSalePrice = new System.Windows.Forms.Label();
            this.LabelDb = new System.Windows.Forms.Label();
            this.LabelSize = new System.Windows.Forms.Label();
            this.LabelModel = new System.Windows.Forms.Label();
            this.LabelBrand = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 338);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1011, 331);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnSatis1
            // 
            this.btnSatis1.BackColor = System.Drawing.Color.Transparent;
            this.btnSatis1.FlatAppearance.BorderSize = 0;
            this.btnSatis1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSatis1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSatis1.Location = new System.Drawing.Point(236, 178);
            this.btnSatis1.Margin = new System.Windows.Forms.Padding(2);
            this.btnSatis1.Name = "btnSatis1";
            this.btnSatis1.Size = new System.Drawing.Size(100, 58);
            this.btnSatis1.TabIndex = 2;
            this.btnSatis1.Text = "1 Adet Satış Yap";
            this.btnSatis1.UseVisualStyleBackColor = false;
            this.btnSatis1.Click += new System.EventHandler(this.btnSatis1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(730, 31);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 298);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FormCloseButton
            // 
            this.FormCloseButton.BackColor = System.Drawing.Color.Transparent;
            this.FormCloseButton.FlatAppearance.BorderSize = 0;
            this.FormCloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.FormCloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.FormCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FormCloseButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormCloseButton.ForeColor = System.Drawing.Color.Transparent;
            this.FormCloseButton.Image = ((System.Drawing.Image)(resources.GetObject("FormCloseButton.Image")));
            this.FormCloseButton.Location = new System.Drawing.Point(979, -1);
            this.FormCloseButton.Name = "FormCloseButton";
            this.FormCloseButton.Size = new System.Drawing.Size(32, 27);
            this.FormCloseButton.TabIndex = 32;
            this.FormCloseButton.UseVisualStyleBackColor = false;
            this.FormCloseButton.Click += new System.EventHandler(this.FormCloseButton_Click);
            // 
            // comboBoxTireSizeSearch
            // 
            this.comboBoxTireSizeSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTireSizeSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxTireSizeSearch.FormattingEnabled = true;
            this.comboBoxTireSizeSearch.Location = new System.Drawing.Point(6, 24);
            this.comboBoxTireSizeSearch.Name = "comboBoxTireSizeSearch";
            this.comboBoxTireSizeSearch.Size = new System.Drawing.Size(340, 34);
            this.comboBoxTireSizeSearch.TabIndex = 35;
            this.comboBoxTireSizeSearch.SelectedIndexChanged += new System.EventHandler(this.comboBoxTireSizeSearch_SelectedIndexChanged);
            // 
            // dgwFillbtn
            // 
            this.dgwFillbtn.BackColor = System.Drawing.Color.Transparent;
            this.dgwFillbtn.FlatAppearance.BorderSize = 0;
            this.dgwFillbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dgwFillbtn.Location = new System.Drawing.Point(12, 285);
            this.dgwFillbtn.Name = "dgwFillbtn";
            this.dgwFillbtn.Size = new System.Drawing.Size(352, 44);
            this.dgwFillbtn.TabIndex = 36;
            this.dgwFillbtn.Text = "Tüm Lastikleri Görüntüle";
            this.dgwFillbtn.UseVisualStyleBackColor = false;
            this.dgwFillbtn.Click += new System.EventHandler(this.dgwFillbtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.comboBoxTireSizeSearch);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 82);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lastik Ebatına Göre Görüntüle";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.comboBoxTireBrandSearch);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(12, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 81);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lastik Markasına Göre Görüntüle";
            // 
            // comboBoxTireBrandSearch
            // 
            this.comboBoxTireBrandSearch.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxTireBrandSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTireBrandSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxTireBrandSearch.FormattingEnabled = true;
            this.comboBoxTireBrandSearch.Location = new System.Drawing.Point(6, 32);
            this.comboBoxTireBrandSearch.Name = "comboBoxTireBrandSearch";
            this.comboBoxTireBrandSearch.Size = new System.Drawing.Size(340, 34);
            this.comboBoxTireBrandSearch.TabIndex = 0;
            this.comboBoxTireBrandSearch.SelectedIndexChanged += new System.EventHandler(this.comboBoxTireBrandSearch_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.comboBoxTireRSearch);
            this.groupBox3.Location = new System.Drawing.Point(12, 192);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(352, 82);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lastik Çapına Göre Görüntüle";
            // 
            // comboBoxTireRSearch
            // 
            this.comboBoxTireRSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTireRSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxTireRSearch.FormattingEnabled = true;
            this.comboBoxTireRSearch.Location = new System.Drawing.Point(6, 32);
            this.comboBoxTireRSearch.Name = "comboBoxTireRSearch";
            this.comboBoxTireRSearch.Size = new System.Drawing.Size(340, 34);
            this.comboBoxTireRSearch.TabIndex = 36;
            this.comboBoxTireRSearch.SelectedIndexChanged += new System.EventHandler(this.comboBoxTireRSearch_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.btnSatis4);
            this.groupBox4.Controls.Add(this.LabelTotalPrice);
            this.groupBox4.Controls.Add(this.LabelSalePrice);
            this.groupBox4.Controls.Add(this.LabelDb);
            this.groupBox4.Controls.Add(this.LabelSize);
            this.groupBox4.Controls.Add(this.LabelModel);
            this.groupBox4.Controls.Add(this.LabelBrand);
            this.groupBox4.Controls.Add(this.btnSatis1);
            this.groupBox4.Location = new System.Drawing.Point(384, 17);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(341, 312);
            this.groupBox4.TabIndex = 40;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Seçilen Lastik Bilgileri";
            // 
            // btnSatis4
            // 
            this.btnSatis4.BackColor = System.Drawing.Color.Transparent;
            this.btnSatis4.FlatAppearance.BorderSize = 0;
            this.btnSatis4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSatis4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSatis4.Location = new System.Drawing.Point(236, 249);
            this.btnSatis4.Margin = new System.Windows.Forms.Padding(2);
            this.btnSatis4.Name = "btnSatis4";
            this.btnSatis4.Size = new System.Drawing.Size(100, 58);
            this.btnSatis4.TabIndex = 6;
            this.btnSatis4.Text = "4 Adet Satış Yap";
            this.btnSatis4.UseVisualStyleBackColor = false;
            this.btnSatis4.Click += new System.EventHandler(this.btnSatis4_Click);
            // 
            // LabelTotalPrice
            // 
            this.LabelTotalPrice.AutoSize = true;
            this.LabelTotalPrice.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LabelTotalPrice.Location = new System.Drawing.Point(2, 270);
            this.LabelTotalPrice.Name = "LabelTotalPrice";
            this.LabelTotalPrice.Size = new System.Drawing.Size(136, 26);
            this.LabelTotalPrice.TabIndex = 5;
            this.LabelTotalPrice.Text = "TAKIM FİYATI :";
            // 
            // LabelSalePrice
            // 
            this.LabelSalePrice.AutoSize = true;
            this.LabelSalePrice.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LabelSalePrice.Location = new System.Drawing.Point(6, 194);
            this.LabelSalePrice.Name = "LabelSalePrice";
            this.LabelSalePrice.Size = new System.Drawing.Size(126, 26);
            this.LabelSalePrice.TabIndex = 4;
            this.LabelSalePrice.Text = "ADET FİYATI :";
            // 
            // LabelDb
            // 
            this.LabelDb.AutoSize = true;
            this.LabelDb.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDb.Location = new System.Drawing.Point(13, 143);
            this.LabelDb.Name = "LabelDb";
            this.LabelDb.Size = new System.Drawing.Size(106, 26);
            this.LabelDb.TabIndex = 3;
            this.LabelDb.Text = "Lastik Db : ";
            // 
            // LabelSize
            // 
            this.LabelSize.AutoSize = true;
            this.LabelSize.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSize.Location = new System.Drawing.Point(13, 105);
            this.LabelSize.Name = "LabelSize";
            this.LabelSize.Size = new System.Drawing.Size(125, 26);
            this.LabelSize.TabIndex = 2;
            this.LabelSize.Text = "Lastik Ebatı : ";
            // 
            // LabelModel
            // 
            this.LabelModel.AutoSize = true;
            this.LabelModel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelModel.Location = new System.Drawing.Point(13, 70);
            this.LabelModel.Name = "LabelModel";
            this.LabelModel.Size = new System.Drawing.Size(142, 26);
            this.LabelModel.TabIndex = 1;
            this.LabelModel.Text = "Lastik Modeli : ";
            // 
            // LabelBrand
            // 
            this.LabelBrand.AutoSize = true;
            this.LabelBrand.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBrand.Location = new System.Drawing.Point(13, 32);
            this.LabelBrand.Name = "LabelBrand";
            this.LabelBrand.Size = new System.Drawing.Size(150, 26);
            this.LabelBrand.TabIndex = 0;
            this.LabelBrand.Text = "Lastik Markası : ";
            // 
            // FormTires
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1011, 669);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgwFillbtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.FormCloseButton);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormTires";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTires";
            this.Load += new System.EventHandler(this.FormTires_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSatis1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button FormCloseButton;
        private System.Windows.Forms.ComboBox comboBoxTireSizeSearch;
        private System.Windows.Forms.Button dgwFillbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxTireBrandSearch;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBoxTireRSearch;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label LabelBrand;
        private System.Windows.Forms.Label LabelModel;
        private System.Windows.Forms.Label LabelSize;
        private System.Windows.Forms.Label LabelDb;
        private System.Windows.Forms.Label LabelSalePrice;
        private System.Windows.Forms.Label LabelTotalPrice;
        private System.Windows.Forms.Button btnSatis4;
    }
}
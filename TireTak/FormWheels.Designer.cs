namespace TireTak
{
    partial class FormWheels
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWheels));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.LabelModel = new System.Windows.Forms.Label();
            this.btnSatis4 = new System.Windows.Forms.Button();
            this.LabelTotalPrice = new System.Windows.Forms.Label();
            this.LabelSalePrice = new System.Windows.Forms.Label();
            this.LabelR = new System.Windows.Forms.Label();
            this.LabelSize = new System.Windows.Forms.Label();
            this.LabelBrand = new System.Windows.Forms.Label();
            this.btnSatis1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBoxWheelRSearch = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxWheelSizeSearch = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxWheelBrandSearch = new System.Windows.Forms.ComboBox();
            this.dgwFillbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FormCloseButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.LabelModel);
            this.groupBox4.Controls.Add(this.btnSatis4);
            this.groupBox4.Controls.Add(this.LabelTotalPrice);
            this.groupBox4.Controls.Add(this.LabelSalePrice);
            this.groupBox4.Controls.Add(this.LabelR);
            this.groupBox4.Controls.Add(this.LabelSize);
            this.groupBox4.Controls.Add(this.LabelBrand);
            this.groupBox4.Controls.Add(this.btnSatis1);
            this.groupBox4.Location = new System.Drawing.Point(384, 17);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(341, 312);
            this.groupBox4.TabIndex = 48;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Seçilen Lastik Bilgileri";
            // 
            // LabelModel
            // 
            this.LabelModel.AutoSize = true;
            this.LabelModel.Location = new System.Drawing.Point(6, 67);
            this.LabelModel.Name = "LabelModel";
            this.LabelModel.Size = new System.Drawing.Size(128, 26);
            this.LabelModel.TabIndex = 7;
            this.LabelModel.Text = "Jant Modeli : ";
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
            this.LabelTotalPrice.Location = new System.Drawing.Point(6, 268);
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
            // LabelR
            // 
            this.LabelR.AutoSize = true;
            this.LabelR.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelR.Location = new System.Drawing.Point(6, 143);
            this.LabelR.Name = "LabelR";
            this.LabelR.Size = new System.Drawing.Size(79, 26);
            this.LabelR.TabIndex = 2;
            this.LabelR.Text = "Jant R : ";
            // 
            // LabelSize
            // 
            this.LabelSize.AutoSize = true;
            this.LabelSize.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSize.Location = new System.Drawing.Point(6, 106);
            this.LabelSize.Name = "LabelSize";
            this.LabelSize.Size = new System.Drawing.Size(111, 26);
            this.LabelSize.TabIndex = 1;
            this.LabelSize.Text = "Jant Ebatı : ";
            // 
            // LabelBrand
            // 
            this.LabelBrand.AutoSize = true;
            this.LabelBrand.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBrand.Location = new System.Drawing.Point(6, 32);
            this.LabelBrand.Name = "LabelBrand";
            this.LabelBrand.Size = new System.Drawing.Size(139, 26);
            this.LabelBrand.TabIndex = 0;
            this.LabelBrand.Text = "Araç Markası : ";
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
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.comboBoxWheelRSearch);
            this.groupBox3.Location = new System.Drawing.Point(12, 192);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(352, 82);
            this.groupBox3.TabIndex = 47;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Jant Çapına Göre Görüntüle";
            // 
            // comboBoxWheelRSearch
            // 
            this.comboBoxWheelRSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWheelRSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxWheelRSearch.FormattingEnabled = true;
            this.comboBoxWheelRSearch.Location = new System.Drawing.Point(6, 32);
            this.comboBoxWheelRSearch.Name = "comboBoxWheelRSearch";
            this.comboBoxWheelRSearch.Size = new System.Drawing.Size(340, 34);
            this.comboBoxWheelRSearch.TabIndex = 36;
            this.comboBoxWheelRSearch.SelectedIndexChanged += new System.EventHandler(this.comboBoxWheelRSearch_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.comboBoxWheelSizeSearch);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(12, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 81);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Jant Ebatına Göre Görüntüle";
            // 
            // comboBoxWheelSizeSearch
            // 
            this.comboBoxWheelSizeSearch.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxWheelSizeSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWheelSizeSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxWheelSizeSearch.FormattingEnabled = true;
            this.comboBoxWheelSizeSearch.Location = new System.Drawing.Point(6, 32);
            this.comboBoxWheelSizeSearch.Name = "comboBoxWheelSizeSearch";
            this.comboBoxWheelSizeSearch.Size = new System.Drawing.Size(340, 34);
            this.comboBoxWheelSizeSearch.TabIndex = 0;
            this.comboBoxWheelSizeSearch.SelectedIndexChanged += new System.EventHandler(this.comboBoxWheelSizeSearch_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.comboBoxWheelBrandSearch);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 82);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Araç Markasına Göre Görüntüle";
            // 
            // comboBoxWheelBrandSearch
            // 
            this.comboBoxWheelBrandSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWheelBrandSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxWheelBrandSearch.FormattingEnabled = true;
            this.comboBoxWheelBrandSearch.Location = new System.Drawing.Point(6, 24);
            this.comboBoxWheelBrandSearch.Name = "comboBoxWheelBrandSearch";
            this.comboBoxWheelBrandSearch.Size = new System.Drawing.Size(340, 34);
            this.comboBoxWheelBrandSearch.TabIndex = 35;
            this.comboBoxWheelBrandSearch.SelectedIndexChanged += new System.EventHandler(this.comboBoxWheelBrandSearch_SelectedIndexChanged);
            // 
            // dgwFillbtn
            // 
            this.dgwFillbtn.BackColor = System.Drawing.Color.Transparent;
            this.dgwFillbtn.FlatAppearance.BorderSize = 0;
            this.dgwFillbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dgwFillbtn.Location = new System.Drawing.Point(12, 285);
            this.dgwFillbtn.Name = "dgwFillbtn";
            this.dgwFillbtn.Size = new System.Drawing.Size(352, 44);
            this.dgwFillbtn.TabIndex = 44;
            this.dgwFillbtn.Text = "Tüm Jantları Görüntüle";
            this.dgwFillbtn.UseVisualStyleBackColor = false;
            this.dgwFillbtn.Click += new System.EventHandler(this.dgwFillbtn_Click);
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
            this.pictureBox1.TabIndex = 42;
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
            this.FormCloseButton.TabIndex = 43;
            this.FormCloseButton.UseVisualStyleBackColor = false;
            this.FormCloseButton.Click += new System.EventHandler(this.FormCloseButton_Click);
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
            this.dataGridView1.TabIndex = 41;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // FormWheels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 669);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgwFillbtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.FormCloseButton);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormWheels";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormWheels";
            this.Load += new System.EventHandler(this.FormWheels_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSatis4;
        private System.Windows.Forms.Label LabelTotalPrice;
        private System.Windows.Forms.Label LabelSalePrice;
        private System.Windows.Forms.Label LabelR;
        private System.Windows.Forms.Label LabelSize;
        private System.Windows.Forms.Label LabelBrand;
        private System.Windows.Forms.Button btnSatis1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBoxWheelRSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxWheelSizeSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxWheelBrandSearch;
        private System.Windows.Forms.Button dgwFillbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button FormCloseButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label LabelModel;
    }
}
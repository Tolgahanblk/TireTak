namespace TireTak
{
    partial class FormProductsTire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductsTire));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxTireDb = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.textBoxTireNumber = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.textBoxSalePrice = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.textBoxBuiltPrice = new System.Windows.Forms.TextBox();
            this.comboBoxTireR = new System.Windows.Forms.ComboBox();
            this.comboBoxTireSize = new System.Windows.Forms.ComboBox();
            this.comboBoxTireModel = new System.Windows.Forms.ComboBox();
            this.comboBoxTireBrand = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FormCloseButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTireRAdd = new System.Windows.Forms.Button();
            this.btnTireSizeAdd = new System.Windows.Forms.Button();
            this.btnTireModelAdd = new System.Windows.Forms.Button();
            this.btnTireBrandAdd = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBoxTireBrandSearch = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxTireSizeSearch = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 374);
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
            this.dataGridView1.Size = new System.Drawing.Size(1055, 310);
            this.dataGridView1.TabIndex = 46;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 26);
            this.label1.TabIndex = 47;
            this.label1.Text = "Marka : ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.textBoxTireDb);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.textBoxTireNumber);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.textBoxSalePrice);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.textBoxBuiltPrice);
            this.groupBox1.Controls.Add(this.comboBoxTireR);
            this.groupBox1.Controls.Add(this.comboBoxTireSize);
            this.groupBox1.Controls.Add(this.comboBoxTireModel);
            this.groupBox1.Controls.Add(this.comboBoxTireBrand);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 344);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lastikler";
            // 
            // textBoxTireDb
            // 
            this.textBoxTireDb.Location = new System.Drawing.Point(130, 146);
            this.textBoxTireDb.Name = "textBoxTireDb";
            this.textBoxTireDb.Size = new System.Drawing.Size(246, 33);
            this.textBoxTireDb.TabIndex = 63;
            this.textBoxTireDb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTireDb_KeyPress);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdate.Location = new System.Drawing.Point(456, 259);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(115, 85);
            this.btnUpdate.TabIndex = 51;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // textBoxTireNumber
            // 
            this.textBoxTireNumber.Location = new System.Drawing.Point(130, 304);
            this.textBoxTireNumber.Name = "textBoxTireNumber";
            this.textBoxTireNumber.Size = new System.Drawing.Size(246, 33);
            this.textBoxTireNumber.TabIndex = 62;
            this.textBoxTireNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTireNumber_KeyPress);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelete.Location = new System.Drawing.Point(456, 146);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(115, 85);
            this.btnDelete.TabIndex = 50;
            this.btnDelete.Text = "Sil";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // textBoxSalePrice
            // 
            this.textBoxSalePrice.Location = new System.Drawing.Point(130, 267);
            this.textBoxSalePrice.Name = "textBoxSalePrice";
            this.textBoxSalePrice.Size = new System.Drawing.Size(246, 33);
            this.textBoxSalePrice.TabIndex = 61;
            this.textBoxSalePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSalePrice_KeyPress);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd.Location = new System.Drawing.Point(456, 26);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(115, 85);
            this.btnAdd.TabIndex = 49;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // textBoxBuiltPrice
            // 
            this.textBoxBuiltPrice.Location = new System.Drawing.Point(130, 226);
            this.textBoxBuiltPrice.Name = "textBoxBuiltPrice";
            this.textBoxBuiltPrice.Size = new System.Drawing.Size(246, 33);
            this.textBoxBuiltPrice.TabIndex = 60;
            this.textBoxBuiltPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBuiltPrice_KeyPress);
            // 
            // comboBoxTireR
            // 
            this.comboBoxTireR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTireR.FormattingEnabled = true;
            this.comboBoxTireR.Location = new System.Drawing.Point(130, 186);
            this.comboBoxTireR.Name = "comboBoxTireR";
            this.comboBoxTireR.Size = new System.Drawing.Size(246, 34);
            this.comboBoxTireR.TabIndex = 59;
            // 
            // comboBoxTireSize
            // 
            this.comboBoxTireSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTireSize.FormattingEnabled = true;
            this.comboBoxTireSize.Location = new System.Drawing.Point(130, 106);
            this.comboBoxTireSize.Name = "comboBoxTireSize";
            this.comboBoxTireSize.Size = new System.Drawing.Size(246, 34);
            this.comboBoxTireSize.TabIndex = 57;
            // 
            // comboBoxTireModel
            // 
            this.comboBoxTireModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTireModel.FormattingEnabled = true;
            this.comboBoxTireModel.Location = new System.Drawing.Point(130, 66);
            this.comboBoxTireModel.Name = "comboBoxTireModel";
            this.comboBoxTireModel.Size = new System.Drawing.Size(246, 34);
            this.comboBoxTireModel.TabIndex = 56;
            // 
            // comboBoxTireBrand
            // 
            this.comboBoxTireBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTireBrand.FormattingEnabled = true;
            this.comboBoxTireBrand.Location = new System.Drawing.Point(130, 26);
            this.comboBoxTireBrand.Name = "comboBoxTireBrand";
            this.comboBoxTireBrand.Size = new System.Drawing.Size(246, 34);
            this.comboBoxTireBrand.TabIndex = 55;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(6, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 26);
            this.label8.TabIndex = 54;
            this.label8.Text = "Stok Adet :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(6, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 26);
            this.label7.TabIndex = 53;
            this.label7.Text = "R :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(6, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 26);
            this.label6.TabIndex = 52;
            this.label6.Text = "Satış Fiyatı :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(6, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 26);
            this.label5.TabIndex = 51;
            this.label5.Text = "Alış Fiyatı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(6, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 26);
            this.label4.TabIndex = 50;
            this.label4.Text = "Db : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(6, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 26);
            this.label3.TabIndex = 49;
            this.label3.Text = "Ebat : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 26);
            this.label2.TabIndex = 48;
            this.label2.Text = "Model : ";
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
            this.FormCloseButton.Location = new System.Drawing.Point(1023, 2);
            this.FormCloseButton.Name = "FormCloseButton";
            this.FormCloseButton.Size = new System.Drawing.Size(32, 27);
            this.FormCloseButton.TabIndex = 52;
            this.FormCloseButton.UseVisualStyleBackColor = false;
            this.FormCloseButton.Click += new System.EventHandler(this.FormCloseButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnTireRAdd);
            this.groupBox2.Controls.Add(this.btnTireSizeAdd);
            this.groupBox2.Controls.Add(this.btnTireModelAdd);
            this.groupBox2.Controls.Add(this.btnTireBrandAdd);
            this.groupBox2.Location = new System.Drawing.Point(595, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(448, 128);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Diğer Ekleme İşlemleri";
            // 
            // btnTireRAdd
            // 
            this.btnTireRAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnTireRAdd.FlatAppearance.BorderSize = 0;
            this.btnTireRAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTireRAdd.Location = new System.Drawing.Point(357, 26);
            this.btnTireRAdd.Name = "btnTireRAdd";
            this.btnTireRAdd.Size = new System.Drawing.Size(85, 85);
            this.btnTireRAdd.TabIndex = 3;
            this.btnTireRAdd.Text = "R Ekle";
            this.btnTireRAdd.UseVisualStyleBackColor = false;
            this.btnTireRAdd.Click += new System.EventHandler(this.btnTireRAdd_Click);
            // 
            // btnTireSizeAdd
            // 
            this.btnTireSizeAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnTireSizeAdd.FlatAppearance.BorderSize = 0;
            this.btnTireSizeAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTireSizeAdd.Location = new System.Drawing.Point(237, 26);
            this.btnTireSizeAdd.Name = "btnTireSizeAdd";
            this.btnTireSizeAdd.Size = new System.Drawing.Size(85, 85);
            this.btnTireSizeAdd.TabIndex = 2;
            this.btnTireSizeAdd.Text = "Ebat Ekle";
            this.btnTireSizeAdd.UseVisualStyleBackColor = false;
            this.btnTireSizeAdd.Click += new System.EventHandler(this.btnTireSizeAdd_Click);
            // 
            // btnTireModelAdd
            // 
            this.btnTireModelAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnTireModelAdd.FlatAppearance.BorderSize = 0;
            this.btnTireModelAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTireModelAdd.Location = new System.Drawing.Point(119, 26);
            this.btnTireModelAdd.Name = "btnTireModelAdd";
            this.btnTireModelAdd.Size = new System.Drawing.Size(85, 85);
            this.btnTireModelAdd.TabIndex = 1;
            this.btnTireModelAdd.Text = "Model Ekle";
            this.btnTireModelAdd.UseVisualStyleBackColor = false;
            this.btnTireModelAdd.Click += new System.EventHandler(this.btnTireModelAdd_Click);
            // 
            // btnTireBrandAdd
            // 
            this.btnTireBrandAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnTireBrandAdd.FlatAppearance.BorderSize = 0;
            this.btnTireBrandAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTireBrandAdd.Location = new System.Drawing.Point(6, 26);
            this.btnTireBrandAdd.Name = "btnTireBrandAdd";
            this.btnTireBrandAdd.Size = new System.Drawing.Size(85, 85);
            this.btnTireBrandAdd.TabIndex = 0;
            this.btnTireBrandAdd.Text = "Marka Ekle";
            this.btnTireBrandAdd.UseVisualStyleBackColor = false;
            this.btnTireBrandAdd.Click += new System.EventHandler(this.btnTireBrandAdd_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.Location = new System.Drawing.Point(589, 330);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(454, 40);
            this.btnRefresh.TabIndex = 54;
            this.btnRefresh.Text = "Yenile";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.comboBoxTireBrandSearch);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.comboBoxTireSizeSearch);
            this.groupBox3.Location = new System.Drawing.Point(595, 160);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(448, 100);
            this.groupBox3.TabIndex = 55;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ara";
            // 
            // comboBoxTireBrandSearch
            // 
            this.comboBoxTireBrandSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTireBrandSearch.FormattingEnabled = true;
            this.comboBoxTireBrandSearch.Location = new System.Drawing.Point(152, 57);
            this.comboBoxTireBrandSearch.Name = "comboBoxTireBrandSearch";
            this.comboBoxTireBrandSearch.Size = new System.Drawing.Size(290, 34);
            this.comboBoxTireBrandSearch.TabIndex = 52;
            this.comboBoxTireBrandSearch.SelectedIndexChanged += new System.EventHandler(this.comboBoxTireBrandSearch_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(1, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 26);
            this.label10.TabIndex = 51;
            this.label10.Text = "Marka Seçiniz :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(1, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 26);
            this.label9.TabIndex = 50;
            this.label9.Text = "Ebat Seçiniz :";
            // 
            // comboBoxTireSizeSearch
            // 
            this.comboBoxTireSizeSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTireSizeSearch.FormattingEnabled = true;
            this.comboBoxTireSizeSearch.Location = new System.Drawing.Point(152, 21);
            this.comboBoxTireSizeSearch.Name = "comboBoxTireSizeSearch";
            this.comboBoxTireSizeSearch.Size = new System.Drawing.Size(290, 34);
            this.comboBoxTireSizeSearch.TabIndex = 0;
            this.comboBoxTireSizeSearch.SelectedIndexChanged += new System.EventHandler(this.comboBoxTireSizeSearch_SelectedIndexChanged);
            // 
            // FormProductsTire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1055, 684);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.FormCloseButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormProductsTire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProductsTire";
            this.Load += new System.EventHandler(this.FormProductsTire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxTireNumber;
        private System.Windows.Forms.TextBox textBoxSalePrice;
        private System.Windows.Forms.TextBox textBoxBuiltPrice;
        private System.Windows.Forms.ComboBox comboBoxTireR;
        private System.Windows.Forms.ComboBox comboBoxTireSize;
        private System.Windows.Forms.ComboBox comboBoxTireModel;
        private System.Windows.Forms.ComboBox comboBoxTireBrand;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button FormCloseButton;
        private System.Windows.Forms.TextBox textBoxTireDb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTireRAdd;
        private System.Windows.Forms.Button btnTireSizeAdd;
        private System.Windows.Forms.Button btnTireModelAdd;
        private System.Windows.Forms.Button btnTireBrandAdd;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBoxTireSizeSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxTireBrandSearch;
        private System.Windows.Forms.Label label10;
    }
}
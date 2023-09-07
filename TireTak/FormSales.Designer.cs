namespace TireTak
{
    partial class FormSales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSales));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.FormCloseButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgwFillWheelsbtn = new System.Windows.Forms.Button();
            this.dgwFillTiresbtn = new System.Windows.Forms.Button();
            this.dailyTireSaleReportbtn = new System.Windows.Forms.Button();
            this.GroupBoxFilter = new System.Windows.Forms.GroupBox();
            this.cbxTireSizeSearch = new System.Windows.Forms.ComboBox();
            this.cbxTireBrandSearch = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpTireDate = new System.Windows.Forms.DateTimePicker();
            this.dailyWheelSaleReportbtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxWheelRSearch = new System.Windows.Forms.ComboBox();
            this.cbxWheelSizeSearch = new System.Windows.Forms.ComboBox();
            this.cbxWheelBrandSearch = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpWheelDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PrintButton = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.GroupBoxFilter.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            this.FormCloseButton.Location = new System.Drawing.Point(1103, 0);
            this.FormCloseButton.Name = "FormCloseButton";
            this.FormCloseButton.Size = new System.Drawing.Size(35, 31);
            this.FormCloseButton.TabIndex = 44;
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
            this.dataGridView1.Size = new System.Drawing.Size(1138, 331);
            this.dataGridView1.TabIndex = 45;
            // 
            // dgwFillWheelsbtn
            // 
            this.dgwFillWheelsbtn.BackColor = System.Drawing.Color.Transparent;
            this.dgwFillWheelsbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dgwFillWheelsbtn.FlatAppearance.BorderSize = 0;
            this.dgwFillWheelsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dgwFillWheelsbtn.Location = new System.Drawing.Point(4, 217);
            this.dgwFillWheelsbtn.Name = "dgwFillWheelsbtn";
            this.dgwFillWheelsbtn.Size = new System.Drawing.Size(334, 44);
            this.dgwFillWheelsbtn.TabIndex = 46;
            this.dgwFillWheelsbtn.Text = "Jant Satışlarını Görüntüle";
            this.dgwFillWheelsbtn.UseVisualStyleBackColor = false;
            this.dgwFillWheelsbtn.Click += new System.EventHandler(this.dgwFillWheelsbtn_Click);
            // 
            // dgwFillTiresbtn
            // 
            this.dgwFillTiresbtn.BackColor = System.Drawing.Color.Transparent;
            this.dgwFillTiresbtn.FlatAppearance.BorderSize = 0;
            this.dgwFillTiresbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dgwFillTiresbtn.Location = new System.Drawing.Point(6, 217);
            this.dgwFillTiresbtn.Name = "dgwFillTiresbtn";
            this.dgwFillTiresbtn.Size = new System.Drawing.Size(343, 44);
            this.dgwFillTiresbtn.TabIndex = 47;
            this.dgwFillTiresbtn.Text = "Lastik Satışlarını Görüntüle";
            this.dgwFillTiresbtn.UseVisualStyleBackColor = false;
            this.dgwFillTiresbtn.Click += new System.EventHandler(this.dgwFillTiresbtn_Click);
            // 
            // dailyTireSaleReportbtn
            // 
            this.dailyTireSaleReportbtn.BackColor = System.Drawing.Color.Transparent;
            this.dailyTireSaleReportbtn.FlatAppearance.BorderSize = 0;
            this.dailyTireSaleReportbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dailyTireSaleReportbtn.Location = new System.Drawing.Point(6, 267);
            this.dailyTireSaleReportbtn.Name = "dailyTireSaleReportbtn";
            this.dailyTireSaleReportbtn.Size = new System.Drawing.Size(343, 44);
            this.dailyTireSaleReportbtn.TabIndex = 48;
            this.dailyTireSaleReportbtn.Text = "Bu Günün Lastik Satışlarını Görüntüle";
            this.dailyTireSaleReportbtn.UseVisualStyleBackColor = false;
            this.dailyTireSaleReportbtn.Click += new System.EventHandler(this.dailyTireSaleReportbtn_Click);
            // 
            // GroupBoxFilter
            // 
            this.GroupBoxFilter.BackColor = System.Drawing.Color.Transparent;
            this.GroupBoxFilter.Controls.Add(this.cbxTireSizeSearch);
            this.GroupBoxFilter.Controls.Add(this.cbxTireBrandSearch);
            this.GroupBoxFilter.Controls.Add(this.label6);
            this.GroupBoxFilter.Controls.Add(this.label3);
            this.GroupBoxFilter.Controls.Add(this.label1);
            this.GroupBoxFilter.Controls.Add(this.dtpTireDate);
            this.GroupBoxFilter.Controls.Add(this.dgwFillTiresbtn);
            this.GroupBoxFilter.Controls.Add(this.dailyTireSaleReportbtn);
            this.GroupBoxFilter.Location = new System.Drawing.Point(12, 12);
            this.GroupBoxFilter.Name = "GroupBoxFilter";
            this.GroupBoxFilter.Size = new System.Drawing.Size(356, 317);
            this.GroupBoxFilter.TabIndex = 49;
            this.GroupBoxFilter.TabStop = false;
            this.GroupBoxFilter.Text = "LASTİK";
            // 
            // cbxTireSizeSearch
            // 
            this.cbxTireSizeSearch.FormattingEnabled = true;
            this.cbxTireSizeSearch.Location = new System.Drawing.Point(178, 118);
            this.cbxTireSizeSearch.Name = "cbxTireSizeSearch";
            this.cbxTireSizeSearch.Size = new System.Drawing.Size(171, 34);
            this.cbxTireSizeSearch.TabIndex = 56;
            this.cbxTireSizeSearch.SelectedIndexChanged += new System.EventHandler(this.cbxTireSizeSearch_SelectedIndexChanged);
            // 
            // cbxTireBrandSearch
            // 
            this.cbxTireBrandSearch.FormattingEnabled = true;
            this.cbxTireBrandSearch.Location = new System.Drawing.Point(179, 73);
            this.cbxTireBrandSearch.Name = "cbxTireBrandSearch";
            this.cbxTireBrandSearch.Size = new System.Drawing.Size(171, 34);
            this.cbxTireBrandSearch.TabIndex = 54;
            this.cbxTireBrandSearch.SelectedIndexChanged += new System.EventHandler(this.cbxTireBrandSearch_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 26);
            this.label6.TabIndex = 53;
            this.label6.Text = "Ebata Göre :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 26);
            this.label3.TabIndex = 51;
            this.label3.Text = "Markaya Göre :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 26);
            this.label1.TabIndex = 50;
            this.label1.Text = "Tarihe Göre :";
            // 
            // dtpTireDate
            // 
            this.dtpTireDate.Location = new System.Drawing.Point(178, 28);
            this.dtpTireDate.Name = "dtpTireDate";
            this.dtpTireDate.Size = new System.Drawing.Size(171, 33);
            this.dtpTireDate.TabIndex = 49;
            this.dtpTireDate.ValueChanged += new System.EventHandler(this.dtpTireDate_ValueChanged);
            this.dtpTireDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpTireDate_KeyDown);
            // 
            // dailyWheelSaleReportbtn
            // 
            this.dailyWheelSaleReportbtn.BackColor = System.Drawing.Color.Transparent;
            this.dailyWheelSaleReportbtn.FlatAppearance.BorderSize = 0;
            this.dailyWheelSaleReportbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dailyWheelSaleReportbtn.Location = new System.Drawing.Point(4, 267);
            this.dailyWheelSaleReportbtn.Name = "dailyWheelSaleReportbtn";
            this.dailyWheelSaleReportbtn.Size = new System.Drawing.Size(334, 44);
            this.dailyWheelSaleReportbtn.TabIndex = 49;
            this.dailyWheelSaleReportbtn.Text = "Bu Günün Jant Satışlarını Görüntüle";
            this.dailyWheelSaleReportbtn.UseVisualStyleBackColor = false;
            this.dailyWheelSaleReportbtn.Click += new System.EventHandler(this.dailyWheelSaleReportbtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbxWheelRSearch);
            this.groupBox1.Controls.Add(this.cbxWheelSizeSearch);
            this.groupBox1.Controls.Add(this.cbxWheelBrandSearch);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpWheelDate);
            this.groupBox1.Controls.Add(this.dgwFillWheelsbtn);
            this.groupBox1.Controls.Add(this.dailyWheelSaleReportbtn);
            this.groupBox1.Location = new System.Drawing.Point(374, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 317);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "JANT";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 26);
            this.label8.TabIndex = 59;
            this.label8.Text = "R :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 26);
            this.label7.TabIndex = 58;
            this.label7.Text = "Ebata Göre :";
            // 
            // cbxWheelRSearch
            // 
            this.cbxWheelRSearch.FormattingEnabled = true;
            this.cbxWheelRSearch.Location = new System.Drawing.Point(168, 161);
            this.cbxWheelRSearch.Name = "cbxWheelRSearch";
            this.cbxWheelRSearch.Size = new System.Drawing.Size(171, 34);
            this.cbxWheelRSearch.TabIndex = 57;
            this.cbxWheelRSearch.SelectedIndexChanged += new System.EventHandler(this.cbxWheelRSearch_SelectedIndexChanged);
            // 
            // cbxWheelSizeSearch
            // 
            this.cbxWheelSizeSearch.FormattingEnabled = true;
            this.cbxWheelSizeSearch.Location = new System.Drawing.Point(167, 118);
            this.cbxWheelSizeSearch.Name = "cbxWheelSizeSearch";
            this.cbxWheelSizeSearch.Size = new System.Drawing.Size(171, 34);
            this.cbxWheelSizeSearch.TabIndex = 56;
            this.cbxWheelSizeSearch.SelectedIndexChanged += new System.EventHandler(this.cbxWheelSizeSearch_SelectedIndexChanged);
            // 
            // cbxWheelBrandSearch
            // 
            this.cbxWheelBrandSearch.FormattingEnabled = true;
            this.cbxWheelBrandSearch.Location = new System.Drawing.Point(168, 73);
            this.cbxWheelBrandSearch.Name = "cbxWheelBrandSearch";
            this.cbxWheelBrandSearch.Size = new System.Drawing.Size(171, 34);
            this.cbxWheelBrandSearch.TabIndex = 55;
            this.cbxWheelBrandSearch.SelectedIndexChanged += new System.EventHandler(this.cbxWheelBrandSearch_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 26);
            this.label4.TabIndex = 52;
            this.label4.Text = "Araca Göre :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 26);
            this.label2.TabIndex = 51;
            this.label2.Text = "Tarihe Göre :";
            // 
            // dtpWheelDate
            // 
            this.dtpWheelDate.Location = new System.Drawing.Point(168, 28);
            this.dtpWheelDate.Name = "dtpWheelDate";
            this.dtpWheelDate.Size = new System.Drawing.Size(170, 33);
            this.dtpWheelDate.TabIndex = 50;
            this.dtpWheelDate.ValueChanged += new System.EventHandler(this.dtpWheelDate_ValueChanged);
            this.dtpWheelDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpWheelDate_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.PrintButton);
            this.groupBox2.Location = new System.Drawing.Point(725, 263);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 66);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rapor Al";
            // 
            // PrintButton
            // 
            this.PrintButton.FlatAppearance.BorderSize = 0;
            this.PrintButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintButton.Location = new System.Drawing.Point(6, 28);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(389, 31);
            this.PrintButton.TabIndex = 0;
            this.PrintButton.Text = "Yazdır";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // FormSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1138, 669);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GroupBoxFilter);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.FormCloseButton);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSales";
            this.Load += new System.EventHandler(this.FormSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.GroupBoxFilter.ResumeLayout(false);
            this.GroupBoxFilter.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FormCloseButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button dgwFillWheelsbtn;
        private System.Windows.Forms.Button dgwFillTiresbtn;
        private System.Windows.Forms.Button dailyTireSaleReportbtn;
        private System.Windows.Forms.GroupBox GroupBoxFilter;
        private System.Windows.Forms.Button dailyWheelSaleReportbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpTireDate;
        private System.Windows.Forms.DateTimePicker dtpWheelDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxTireSizeSearch;
        private System.Windows.Forms.ComboBox cbxTireBrandSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxWheelBrandSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxWheelRSearch;
        private System.Windows.Forms.ComboBox cbxWheelSizeSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button PrintButton;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}
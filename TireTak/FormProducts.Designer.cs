namespace TireTak
{
    partial class FormProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProducts));
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnJantlar = new System.Windows.Forms.Button();
            this.btnLastikler = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.Transparent;
            this.btnGeri.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGeri.FlatAppearance.BorderSize = 0;
            this.btnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeri.Font = new System.Drawing.Font("Calibri", 20F);
            this.btnGeri.Location = new System.Drawing.Point(0, 279);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(300, 70);
            this.btnGeri.TabIndex = 9;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            this.btnGeri.MouseHover += new System.EventHandler(this.btnGeri_MouseHover);
            // 
            // btnJantlar
            // 
            this.btnJantlar.BackColor = System.Drawing.Color.Transparent;
            this.btnJantlar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnJantlar.FlatAppearance.BorderSize = 0;
            this.btnJantlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJantlar.Font = new System.Drawing.Font("Calibri", 20F);
            this.btnJantlar.Location = new System.Drawing.Point(0, 209);
            this.btnJantlar.Name = "btnJantlar";
            this.btnJantlar.Size = new System.Drawing.Size(300, 70);
            this.btnJantlar.TabIndex = 8;
            this.btnJantlar.Text = "Jantlar";
            this.btnJantlar.UseVisualStyleBackColor = false;
            this.btnJantlar.Click += new System.EventHandler(this.btnJantlar_Click);
            this.btnJantlar.MouseHover += new System.EventHandler(this.btnJantlar_MouseHover);
            // 
            // btnLastikler
            // 
            this.btnLastikler.BackColor = System.Drawing.Color.Transparent;
            this.btnLastikler.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLastikler.FlatAppearance.BorderSize = 0;
            this.btnLastikler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLastikler.Font = new System.Drawing.Font("Calibri", 20F);
            this.btnLastikler.Location = new System.Drawing.Point(0, 139);
            this.btnLastikler.Name = "btnLastikler";
            this.btnLastikler.Size = new System.Drawing.Size(300, 70);
            this.btnLastikler.TabIndex = 7;
            this.btnLastikler.Text = "Lastikler";
            this.btnLastikler.UseVisualStyleBackColor = false;
            this.btnLastikler.Click += new System.EventHandler(this.btnLastikler_Click);
            this.btnLastikler.MouseHover += new System.EventHandler(this.btnLastikler_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // FormProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(300, 348);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnJantlar);
            this.Controls.Add(this.btnLastikler);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Calibri", 13.8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProducts";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnJantlar;
        private System.Windows.Forms.Button btnLastikler;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
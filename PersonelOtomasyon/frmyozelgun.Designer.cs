namespace PersonelOtomasyon
{
    partial class frmyozelgun
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_kapat = new System.Windows.Forms.Button();
            this.lbl_ozel_gun = new System.Windows.Forms.Label();
            this.txtozelgun = new System.Windows.Forms.TextBox();
            this.lbl_og_ad = new System.Windows.Forms.Label();
            this.btn_og_kaydet = new System.Windows.Forms.Button();
            this.lbl_og_tarih = new System.Windows.Forms.Label();
            this.yozelgunt = new System.Windows.Forms.DateTimePicker();
            this.datagridyozelgun = new System.Windows.Forms.DataGridView();
            this.btn_og_sil = new System.Windows.Forms.Button();
            this.btn_geri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridyozelgun)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_kapat
            // 
            this.btn_kapat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_kapat.FlatAppearance.BorderSize = 0;
            this.btn_kapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kapat.ForeColor = System.Drawing.Color.White;
            this.btn_kapat.Location = new System.Drawing.Point(1043, 9);
            this.btn_kapat.Margin = new System.Windows.Forms.Padding(0);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(39, 33);
            this.btn_kapat.TabIndex = 17;
            this.btn_kapat.Text = "X";
            this.btn_kapat.UseVisualStyleBackColor = false;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // lbl_ozel_gun
            // 
            this.lbl_ozel_gun.AutoSize = true;
            this.lbl_ozel_gun.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_ozel_gun.Font = new System.Drawing.Font("Arial", 16F);
            this.lbl_ozel_gun.ForeColor = System.Drawing.Color.Black;
            this.lbl_ozel_gun.Location = new System.Drawing.Point(446, -2);
            this.lbl_ozel_gun.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ozel_gun.Name = "lbl_ozel_gun";
            this.lbl_ozel_gun.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lbl_ozel_gun.Size = new System.Drawing.Size(172, 44);
            this.lbl_ozel_gun.TabIndex = 16;
            this.lbl_ozel_gun.Text = "Özel Günler";
            // 
            // txtozelgun
            // 
            this.txtozelgun.Location = new System.Drawing.Point(202, 84);
            this.txtozelgun.Margin = new System.Windows.Forms.Padding(4);
            this.txtozelgun.Name = "txtozelgun";
            this.txtozelgun.Size = new System.Drawing.Size(224, 22);
            this.txtozelgun.TabIndex = 16;
            // 
            // lbl_og_ad
            // 
            this.lbl_og_ad.AutoSize = true;
            this.lbl_og_ad.Font = new System.Drawing.Font("Arial", 9F);
            this.lbl_og_ad.ForeColor = System.Drawing.Color.Black;
            this.lbl_og_ad.Location = new System.Drawing.Point(23, 88);
            this.lbl_og_ad.Name = "lbl_og_ad";
            this.lbl_og_ad.Size = new System.Drawing.Size(70, 17);
            this.lbl_og_ad.TabIndex = 14;
            this.lbl_og_ad.Text = "Gün Adı : ";
            // 
            // btn_og_kaydet
            // 
            this.btn_og_kaydet.BackColor = System.Drawing.Color.White;
            this.btn_og_kaydet.FlatAppearance.BorderSize = 0;
            this.btn_og_kaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_og_kaydet.Font = new System.Drawing.Font("Arial", 9F);
            this.btn_og_kaydet.ForeColor = System.Drawing.Color.Black;
            this.btn_og_kaydet.Location = new System.Drawing.Point(16, 213);
            this.btn_og_kaydet.Margin = new System.Windows.Forms.Padding(0);
            this.btn_og_kaydet.Name = "btn_og_kaydet";
            this.btn_og_kaydet.Size = new System.Drawing.Size(229, 33);
            this.btn_og_kaydet.TabIndex = 19;
            this.btn_og_kaydet.Text = "Kaydet";
            this.btn_og_kaydet.UseVisualStyleBackColor = false;
            this.btn_og_kaydet.Click += new System.EventHandler(this.btn_og_kaydet_Click);
            // 
            // lbl_og_tarih
            // 
            this.lbl_og_tarih.AutoSize = true;
            this.lbl_og_tarih.Font = new System.Drawing.Font("Arial", 9F);
            this.lbl_og_tarih.ForeColor = System.Drawing.Color.Black;
            this.lbl_og_tarih.Location = new System.Drawing.Point(23, 140);
            this.lbl_og_tarih.Name = "lbl_og_tarih";
            this.lbl_og_tarih.Size = new System.Drawing.Size(54, 17);
            this.lbl_og_tarih.TabIndex = 15;
            this.lbl_og_tarih.Text = "Tarihi : ";
            // 
            // yozelgunt
            // 
            this.yozelgunt.Font = new System.Drawing.Font("Arial", 7F);
            this.yozelgunt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.yozelgunt.Location = new System.Drawing.Point(202, 136);
            this.yozelgunt.Margin = new System.Windows.Forms.Padding(4);
            this.yozelgunt.Name = "yozelgunt";
            this.yozelgunt.Size = new System.Drawing.Size(224, 21);
            this.yozelgunt.TabIndex = 17;
            this.yozelgunt.Value = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            // 
            // datagridyozelgun
            // 
            this.datagridyozelgun.AllowUserToResizeColumns = false;
            this.datagridyozelgun.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridyozelgun.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.datagridyozelgun.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridyozelgun.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.datagridyozelgun.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.datagridyozelgun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridyozelgun.DefaultCellStyle = dataGridViewCellStyle4;
            this.datagridyozelgun.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.datagridyozelgun.Location = new System.Drawing.Point(542, 48);
            this.datagridyozelgun.Margin = new System.Windows.Forms.Padding(4);
            this.datagridyozelgun.Name = "datagridyozelgun";
            this.datagridyozelgun.RowHeadersWidth = 51;
            this.datagridyozelgun.Size = new System.Drawing.Size(509, 227);
            this.datagridyozelgun.TabIndex = 20;
            // 
            // btn_og_sil
            // 
            this.btn_og_sil.BackColor = System.Drawing.Color.White;
            this.btn_og_sil.FlatAppearance.BorderSize = 0;
            this.btn_og_sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_og_sil.Font = new System.Drawing.Font("Arial", 9F);
            this.btn_og_sil.ForeColor = System.Drawing.Color.Black;
            this.btn_og_sil.Location = new System.Drawing.Point(265, 213);
            this.btn_og_sil.Margin = new System.Windows.Forms.Padding(0);
            this.btn_og_sil.Name = "btn_og_sil";
            this.btn_og_sil.Size = new System.Drawing.Size(229, 33);
            this.btn_og_sil.TabIndex = 21;
            this.btn_og_sil.Text = "Sil";
            this.btn_og_sil.UseVisualStyleBackColor = false;
            this.btn_og_sil.Click += new System.EventHandler(this.btn_og_sil_Click);
            // 
            // btn_geri
            // 
            this.btn_geri.BackColor = System.Drawing.Color.White;
            this.btn_geri.FlatAppearance.BorderSize = 0;
            this.btn_geri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_geri.Font = new System.Drawing.Font("Arial", 9F);
            this.btn_geri.ForeColor = System.Drawing.Color.Black;
            this.btn_geri.Location = new System.Drawing.Point(12, 11);
            this.btn_geri.Margin = new System.Windows.Forms.Padding(0);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(88, 33);
            this.btn_geri.TabIndex = 28;
            this.btn_geri.Text = "Geri";
            this.btn_geri.UseVisualStyleBackColor = false;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // frmyozelgun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1091, 301);
            this.Controls.Add(this.yozelgunt);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.txtozelgun);
            this.Controls.Add(this.lbl_og_tarih);
            this.Controls.Add(this.btn_og_sil);
            this.Controls.Add(this.lbl_og_ad);
            this.Controls.Add(this.datagridyozelgun);
            this.Controls.Add(this.btn_og_kaydet);
            this.Controls.Add(this.btn_kapat);
            this.Controls.Add(this.lbl_ozel_gun);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmyozelgun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Özel Günler";
            this.Load += new System.EventHandler(this.frmyozelgun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridyozelgun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_kapat;
        private System.Windows.Forms.Label lbl_ozel_gun;
        private System.Windows.Forms.TextBox txtozelgun;
        private System.Windows.Forms.Label lbl_og_ad;
        private System.Windows.Forms.Button btn_og_kaydet;
        private System.Windows.Forms.Label lbl_og_tarih;
        private System.Windows.Forms.DateTimePicker yozelgunt;
        private System.Windows.Forms.DataGridView datagridyozelgun;
        private System.Windows.Forms.Button btn_og_sil;
        private System.Windows.Forms.Button btn_geri;
    }
}
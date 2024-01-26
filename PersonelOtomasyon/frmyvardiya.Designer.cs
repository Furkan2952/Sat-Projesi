namespace PersonelOtomasyon
{
    partial class frmyvardiya
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
            this.lbl_giris_paneli = new System.Windows.Forms.Label();
            this.btnciktial = new System.Windows.Forms.Button();
            this.datagridvardiya = new System.Windows.Forms.DataGridView();
            this.btn_geri = new System.Windows.Forms.Button();
            this.btnvolustur = new System.Windows.Forms.Button();
            this.btnvsil = new System.Windows.Forms.Button();
            this.lbl_sicil_no = new System.Windows.Forms.Label();
            this.lbl_vardiya = new System.Windows.Forms.Label();
            this.lbl_tarih = new System.Windows.Forms.Label();
            this.cbsicil = new System.Windows.Forms.ComboBox();
            this.dtpvtarih = new System.Windows.Forms.DateTimePicker();
            this.cbvsaat = new System.Windows.Forms.ComboBox();
            this.cbcalismayeri = new System.Windows.Forms.ComboBox();
            this.lbl_lokasyon = new System.Windows.Forms.Label();
            this.btnvguncelle = new System.Windows.Forms.Button();
            this.btnotoolustur = new System.Windows.Forms.Button();
            this.dtpvbas = new System.Windows.Forms.DateTimePicker();
            this.dtpvbitis = new System.Windows.Forms.DateTimePicker();
            this.lbl_vardiya_aralik = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnara = new System.Windows.Forms.Button();
            this.dtp_ara_bitis = new System.Windows.Forms.DateTimePicker();
            this.dtp_ara_baslangic = new System.Windows.Forms.DateTimePicker();
            this.btnvardiyalarisil = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_personel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.datagridvardiya)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnl_personel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_kapat
            // 
            this.btn_kapat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_kapat.FlatAppearance.BorderSize = 0;
            this.btn_kapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kapat.ForeColor = System.Drawing.Color.White;
            this.btn_kapat.Location = new System.Drawing.Point(1437, 11);
            this.btn_kapat.Margin = new System.Windows.Forms.Padding(0);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(39, 33);
            this.btn_kapat.TabIndex = 17;
            this.btn_kapat.Text = "X";
            this.btn_kapat.UseVisualStyleBackColor = false;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // lbl_giris_paneli
            // 
            this.lbl_giris_paneli.AutoSize = true;
            this.lbl_giris_paneli.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_giris_paneli.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_giris_paneli.ForeColor = System.Drawing.Color.Black;
            this.lbl_giris_paneli.Location = new System.Drawing.Point(623, 1);
            this.lbl_giris_paneli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_giris_paneli.Name = "lbl_giris_paneli";
            this.lbl_giris_paneli.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lbl_giris_paneli.Size = new System.Drawing.Size(245, 44);
            this.lbl_giris_paneli.TabIndex = 16;
            this.lbl_giris_paneli.Text = "Vardiyalar Paneli";
            // 
            // btnciktial
            // 
            this.btnciktial.BackColor = System.Drawing.Color.White;
            this.btnciktial.FlatAppearance.BorderSize = 0;
            this.btnciktial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnciktial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnciktial.ForeColor = System.Drawing.Color.Black;
            this.btnciktial.Location = new System.Drawing.Point(1362, 604);
            this.btnciktial.Margin = new System.Windows.Forms.Padding(0);
            this.btnciktial.Name = "btnciktial";
            this.btnciktial.Size = new System.Drawing.Size(113, 43);
            this.btnciktial.TabIndex = 18;
            this.btnciktial.Text = "Çıktı Al";
            this.btnciktial.UseVisualStyleBackColor = false;
            this.btnciktial.Click += new System.EventHandler(this.btnciktial_Click_1);
            // 
            // datagridvardiya
            // 
            this.datagridvardiya.AllowUserToResizeColumns = false;
            this.datagridvardiya.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridvardiya.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.datagridvardiya.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridvardiya.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.datagridvardiya.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.datagridvardiya.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridvardiya.DefaultCellStyle = dataGridViewCellStyle4;
            this.datagridvardiya.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.datagridvardiya.Location = new System.Drawing.Point(638, 58);
            this.datagridvardiya.Margin = new System.Windows.Forms.Padding(4);
            this.datagridvardiya.Name = "datagridvardiya";
            this.datagridvardiya.RowHeadersWidth = 51;
            this.datagridvardiya.Size = new System.Drawing.Size(837, 543);
            this.datagridvardiya.TabIndex = 25;
            this.datagridvardiya.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgw_adm_vardiyalar_CellMouseClick);
            // 
            // btn_geri
            // 
            this.btn_geri.BackColor = System.Drawing.Color.White;
            this.btn_geri.FlatAppearance.BorderSize = 0;
            this.btn_geri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_geri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_geri.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_geri.Location = new System.Drawing.Point(12, 11);
            this.btn_geri.Margin = new System.Windows.Forms.Padding(0);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(113, 33);
            this.btn_geri.TabIndex = 27;
            this.btn_geri.Text = "Geri";
            this.btn_geri.UseVisualStyleBackColor = false;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // btnvolustur
            // 
            this.btnvolustur.BackColor = System.Drawing.Color.White;
            this.btnvolustur.FlatAppearance.BorderSize = 0;
            this.btnvolustur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvolustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnvolustur.ForeColor = System.Drawing.Color.Black;
            this.btnvolustur.Location = new System.Drawing.Point(28, 240);
            this.btnvolustur.Margin = new System.Windows.Forms.Padding(0);
            this.btnvolustur.Name = "btnvolustur";
            this.btnvolustur.Size = new System.Drawing.Size(97, 43);
            this.btnvolustur.TabIndex = 29;
            this.btnvolustur.Text = "Oluştur";
            this.btnvolustur.UseVisualStyleBackColor = false;
            this.btnvolustur.Click += new System.EventHandler(this.btnvolustur_Click);
            // 
            // btnvsil
            // 
            this.btnvsil.BackColor = System.Drawing.Color.White;
            this.btnvsil.FlatAppearance.BorderSize = 0;
            this.btnvsil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnvsil.ForeColor = System.Drawing.Color.Black;
            this.btnvsil.Location = new System.Drawing.Point(278, 240);
            this.btnvsil.Margin = new System.Windows.Forms.Padding(0);
            this.btnvsil.Name = "btnvsil";
            this.btnvsil.Size = new System.Drawing.Size(97, 43);
            this.btnvsil.TabIndex = 30;
            this.btnvsil.Text = "Sil";
            this.btnvsil.UseVisualStyleBackColor = false;
            this.btnvsil.Click += new System.EventHandler(this.btnvsil_Click);
            // 
            // lbl_sicil_no
            // 
            this.lbl_sicil_no.AutoSize = true;
            this.lbl_sicil_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sicil_no.ForeColor = System.Drawing.Color.Black;
            this.lbl_sicil_no.Location = new System.Drawing.Point(23, 22);
            this.lbl_sicil_no.Name = "lbl_sicil_no";
            this.lbl_sicil_no.Size = new System.Drawing.Size(82, 20);
            this.lbl_sicil_no.TabIndex = 14;
            this.lbl_sicil_no.Text = "Sicil No : ";
            // 
            // lbl_vardiya
            // 
            this.lbl_vardiya.AutoSize = true;
            this.lbl_vardiya.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_vardiya.ForeColor = System.Drawing.Color.Black;
            this.lbl_vardiya.Location = new System.Drawing.Point(23, 121);
            this.lbl_vardiya.Name = "lbl_vardiya";
            this.lbl_vardiya.Size = new System.Drawing.Size(80, 20);
            this.lbl_vardiya.TabIndex = 15;
            this.lbl_vardiya.Text = "Vardiya : ";
            // 
            // lbl_tarih
            // 
            this.lbl_tarih.AutoSize = true;
            this.lbl_tarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tarih.ForeColor = System.Drawing.Color.Black;
            this.lbl_tarih.Location = new System.Drawing.Point(23, 89);
            this.lbl_tarih.Name = "lbl_tarih";
            this.lbl_tarih.Size = new System.Drawing.Size(57, 20);
            this.lbl_tarih.TabIndex = 22;
            this.lbl_tarih.Text = "Tarih :";
            // 
            // cbsicil
            // 
            this.cbsicil.Location = new System.Drawing.Point(153, 18);
            this.cbsicil.Name = "cbsicil";
            this.cbsicil.Size = new System.Drawing.Size(211, 24);
            this.cbsicil.TabIndex = 32;
            this.cbsicil.SelectedIndexChanged += new System.EventHandler(this.cbsicil_SelectedIndexChanged);
            // 
            // dtpvtarih
            // 
            this.dtpvtarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpvtarih.Location = new System.Drawing.Point(153, 85);
            this.dtpvtarih.Margin = new System.Windows.Forms.Padding(4);
            this.dtpvtarih.Name = "dtpvtarih";
            this.dtpvtarih.Size = new System.Drawing.Size(211, 22);
            this.dtpvtarih.TabIndex = 29;
            this.dtpvtarih.Value = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            // 
            // cbvsaat
            // 
            this.cbvsaat.FormattingEnabled = true;
            this.cbvsaat.Location = new System.Drawing.Point(153, 119);
            this.cbvsaat.Margin = new System.Windows.Forms.Padding(4);
            this.cbvsaat.Name = "cbvsaat";
            this.cbvsaat.Size = new System.Drawing.Size(211, 24);
            this.cbvsaat.TabIndex = 30;
            // 
            // cbcalismayeri
            // 
            this.cbcalismayeri.FormattingEnabled = true;
            this.cbcalismayeri.Location = new System.Drawing.Point(153, 52);
            this.cbcalismayeri.Margin = new System.Windows.Forms.Padding(4);
            this.cbcalismayeri.Name = "cbcalismayeri";
            this.cbcalismayeri.Size = new System.Drawing.Size(211, 24);
            this.cbcalismayeri.TabIndex = 31;
            this.cbcalismayeri.SelectedIndexChanged += new System.EventHandler(this.cbcalismayeri_SelectedIndexChanged);
            // 
            // lbl_lokasyon
            // 
            this.lbl_lokasyon.AutoSize = true;
            this.lbl_lokasyon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_lokasyon.ForeColor = System.Drawing.Color.Black;
            this.lbl_lokasyon.Location = new System.Drawing.Point(23, 52);
            this.lbl_lokasyon.Name = "lbl_lokasyon";
            this.lbl_lokasyon.Size = new System.Drawing.Size(119, 20);
            this.lbl_lokasyon.TabIndex = 27;
            this.lbl_lokasyon.Text = "Çalışma Yeri : ";
            // 
            // btnvguncelle
            // 
            this.btnvguncelle.BackColor = System.Drawing.Color.White;
            this.btnvguncelle.FlatAppearance.BorderSize = 0;
            this.btnvguncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvguncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnvguncelle.ForeColor = System.Drawing.Color.Black;
            this.btnvguncelle.Location = new System.Drawing.Point(153, 240);
            this.btnvguncelle.Margin = new System.Windows.Forms.Padding(0);
            this.btnvguncelle.Name = "btnvguncelle";
            this.btnvguncelle.Size = new System.Drawing.Size(97, 43);
            this.btnvguncelle.TabIndex = 31;
            this.btnvguncelle.Text = "Güncelle";
            this.btnvguncelle.UseVisualStyleBackColor = false;
            this.btnvguncelle.Click += new System.EventHandler(this.btnvguncelle_Click);
            // 
            // btnotoolustur
            // 
            this.btnotoolustur.BackColor = System.Drawing.Color.White;
            this.btnotoolustur.FlatAppearance.BorderSize = 0;
            this.btnotoolustur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnotoolustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnotoolustur.ForeColor = System.Drawing.Color.Black;
            this.btnotoolustur.Location = new System.Drawing.Point(19, 96);
            this.btnotoolustur.Margin = new System.Windows.Forms.Padding(0);
            this.btnotoolustur.Name = "btnotoolustur";
            this.btnotoolustur.Size = new System.Drawing.Size(356, 43);
            this.btnotoolustur.TabIndex = 32;
            this.btnotoolustur.Text = "Otomatik Oluştur";
            this.btnotoolustur.UseVisualStyleBackColor = false;
            this.btnotoolustur.Click += new System.EventHandler(this.btnotoolustur_Click);
            // 
            // dtpvbas
            // 
            this.dtpvbas.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpvbas.Location = new System.Drawing.Point(19, 54);
            this.dtpvbas.Margin = new System.Windows.Forms.Padding(4);
            this.dtpvbas.Name = "dtpvbas";
            this.dtpvbas.Size = new System.Drawing.Size(167, 22);
            this.dtpvbas.TabIndex = 32;
            this.dtpvbas.Value = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            // 
            // dtpvbitis
            // 
            this.dtpvbitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpvbitis.Location = new System.Drawing.Point(207, 54);
            this.dtpvbitis.Margin = new System.Windows.Forms.Padding(4);
            this.dtpvbitis.Name = "dtpvbitis";
            this.dtpvbitis.Size = new System.Drawing.Size(167, 22);
            this.dtpvbitis.TabIndex = 33;
            this.dtpvbitis.Value = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            // 
            // lbl_vardiya_aralik
            // 
            this.lbl_vardiya_aralik.AutoSize = true;
            this.lbl_vardiya_aralik.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_vardiya_aralik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_vardiya_aralik.ForeColor = System.Drawing.Color.Black;
            this.lbl_vardiya_aralik.Location = new System.Drawing.Point(15, 21);
            this.lbl_vardiya_aralik.Name = "lbl_vardiya_aralik";
            this.lbl_vardiya_aralik.Size = new System.Drawing.Size(209, 20);
            this.lbl_vardiya_aralik.TabIndex = 32;
            this.lbl_vardiya_aralik.Text = "Vardiya Gün Aralığı Girin : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Aranacak Gün Aralığı Girin : ";
            // 
            // btnara
            // 
            this.btnara.BackColor = System.Drawing.Color.White;
            this.btnara.FlatAppearance.BorderSize = 0;
            this.btnara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnara.ForeColor = System.Drawing.Color.Black;
            this.btnara.Location = new System.Drawing.Point(12, 96);
            this.btnara.Margin = new System.Windows.Forms.Padding(0);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(267, 43);
            this.btnara.TabIndex = 32;
            this.btnara.Text = "Ara";
            this.btnara.UseVisualStyleBackColor = false;
            this.btnara.Click += new System.EventHandler(this.btnara_Click);
            // 
            // dtp_ara_bitis
            // 
            this.dtp_ara_bitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ara_bitis.Location = new System.Drawing.Point(159, 54);
            this.dtp_ara_bitis.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_ara_bitis.Name = "dtp_ara_bitis";
            this.dtp_ara_bitis.Size = new System.Drawing.Size(119, 22);
            this.dtp_ara_bitis.TabIndex = 33;
            this.dtp_ara_bitis.Value = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            // 
            // dtp_ara_baslangic
            // 
            this.dtp_ara_baslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ara_baslangic.Location = new System.Drawing.Point(19, 54);
            this.dtp_ara_baslangic.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_ara_baslangic.Name = "dtp_ara_baslangic";
            this.dtp_ara_baslangic.Size = new System.Drawing.Size(128, 22);
            this.dtp_ara_baslangic.TabIndex = 32;
            this.dtp_ara_baslangic.Value = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            // 
            // btnvardiyalarisil
            // 
            this.btnvardiyalarisil.BackColor = System.Drawing.Color.White;
            this.btnvardiyalarisil.FlatAppearance.BorderSize = 0;
            this.btnvardiyalarisil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvardiyalarisil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnvardiyalarisil.ForeColor = System.Drawing.Color.Black;
            this.btnvardiyalarisil.Location = new System.Drawing.Point(638, 605);
            this.btnvardiyalarisil.Margin = new System.Windows.Forms.Padding(0);
            this.btnvardiyalarisil.Name = "btnvardiyalarisil";
            this.btnvardiyalarisil.Size = new System.Drawing.Size(154, 43);
            this.btnvardiyalarisil.TabIndex = 36;
            this.btnvardiyalarisil.Text = "Vardiyaları Sil";
            this.btnvardiyalarisil.UseVisualStyleBackColor = false;
            this.btnvardiyalarisil.Click += new System.EventHandler(this.btnvardiyalarisil_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnara);
            this.panel2.Controls.Add(this.dtp_ara_bitis);
            this.panel2.Controls.Add(this.dtp_ara_baslangic);
            this.panel2.Location = new System.Drawing.Point(13, 462);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(289, 156);
            this.panel2.TabIndex = 35;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lbl_vardiya_aralik);
            this.panel1.Controls.Add(this.btnotoolustur);
            this.panel1.Controls.Add(this.dtpvbitis);
            this.panel1.Controls.Add(this.dtpvbas);
            this.panel1.Location = new System.Drawing.Point(12, 298);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 156);
            this.panel1.TabIndex = 34;
            // 
            // pnl_personel
            // 
            this.pnl_personel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_personel.Controls.Add(this.cbcalismayeri);
            this.pnl_personel.Controls.Add(this.cbvsaat);
            this.pnl_personel.Controls.Add(this.dtpvtarih);
            this.pnl_personel.Controls.Add(this.lbl_lokasyon);
            this.pnl_personel.Controls.Add(this.cbsicil);
            this.pnl_personel.Controls.Add(this.lbl_tarih);
            this.pnl_personel.Controls.Add(this.lbl_vardiya);
            this.pnl_personel.Controls.Add(this.lbl_sicil_no);
            this.pnl_personel.Location = new System.Drawing.Point(12, 69);
            this.pnl_personel.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_personel.Name = "pnl_personel";
            this.pnl_personel.Size = new System.Drawing.Size(393, 161);
            this.pnl_personel.TabIndex = 28;
            // 
            // frmyvardiya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1488, 656);
            this.Controls.Add(this.btnvardiyalarisil);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnvguncelle);
            this.Controls.Add(this.btnvsil);
            this.Controls.Add(this.btnvolustur);
            this.Controls.Add(this.pnl_personel);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.datagridvardiya);
            this.Controls.Add(this.btnciktial);
            this.Controls.Add(this.btn_kapat);
            this.Controls.Add(this.lbl_giris_paneli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmyvardiya";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mesailer";
            this.Load += new System.EventHandler(this.frmyvardiya_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridvardiya)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_personel.ResumeLayout(false);
            this.pnl_personel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_kapat;
        private System.Windows.Forms.Label lbl_giris_paneli;
        private System.Windows.Forms.Button btnciktial;
        private System.Windows.Forms.DataGridView datagridvardiya;
        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.Button btnvolustur;
        private System.Windows.Forms.Button btnvsil;
        private System.Windows.Forms.Label lbl_sicil_no;
        private System.Windows.Forms.Label lbl_vardiya;
        private System.Windows.Forms.Label lbl_tarih;
        private System.Windows.Forms.ComboBox cbsicil;
        private System.Windows.Forms.DateTimePicker dtpvtarih;
        private System.Windows.Forms.ComboBox cbvsaat;
        private System.Windows.Forms.ComboBox cbcalismayeri;
        private System.Windows.Forms.Label lbl_lokasyon;
        private System.Windows.Forms.Button btnvguncelle;
        private System.Windows.Forms.Button btnotoolustur;
        private System.Windows.Forms.DateTimePicker dtpvbas;
        private System.Windows.Forms.DateTimePicker dtpvbitis;
        private System.Windows.Forms.Label lbl_vardiya_aralik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnara;
        private System.Windows.Forms.DateTimePicker dtp_ara_bitis;
        private System.Windows.Forms.DateTimePicker dtp_ara_baslangic;
        private System.Windows.Forms.Button btnvardiyalarisil;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_personel;
    }
}
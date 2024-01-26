namespace PersonelOtomasyon
{
    partial class frmypersonel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnkapat = new System.Windows.Forms.Button();
            this.lbl_giris_paneli = new System.Windows.Forms.Label();
            this.btnsil = new System.Windows.Forms.Button();
            this.datagridpersonel = new System.Windows.Forms.DataGridView();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.lbladres = new System.Windows.Forms.Label();
            this.txtypadres = new System.Windows.Forms.TextBox();
            this.cbypol = new System.Windows.Forms.ComboBox();
            this.lblrol = new System.Windows.Forms.Label();
            this.cbypizin2 = new System.Windows.Forms.ComboBox();
            this.cbypizin1 = new System.Windows.Forms.ComboBox();
            this.cbkadro = new System.Windows.Forms.ComboBox();
            this.txtypunvan = new System.Windows.Forms.TextBox();
            this.lblizin1 = new System.Windows.Forms.Label();
            this.lblizin2 = new System.Windows.Forms.Label();
            this.lblunvan = new System.Windows.Forms.Label();
            this.lbltelefon = new System.Windows.Forms.Label();
            this.txtyptel = new System.Windows.Forms.TextBox();
            this.lblkadro = new System.Windows.Forms.Label();
            this.txtypmail = new System.Windows.Forms.TextBox();
            this.txtypsifre = new System.Windows.Forms.TextBox();
            this.txtyptc = new System.Windows.Forms.TextBox();
            this.lblsifre = new System.Windows.Forms.Label();
            this.lbleposta = new System.Windows.Forms.Label();
            this.lblkimlik = new System.Windows.Forms.Label();
            this.txtypsoyad = new System.Windows.Forms.TextBox();
            this.txtypad = new System.Windows.Forms.TextBox();
            this.lblad = new System.Windows.Forms.Label();
            this.lblsoyad = new System.Windows.Forms.Label();
            this.lblsicilno = new System.Windows.Forms.Label();
            this.btnciktial = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btngeri = new System.Windows.Forms.Button();
            this.txtypsicil = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagridpersonel)).BeginInit();
            this.SuspendLayout();
            // 
            // btnkapat
            // 
            this.btnkapat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnkapat.FlatAppearance.BorderSize = 0;
            this.btnkapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkapat.ForeColor = System.Drawing.Color.White;
            this.btnkapat.Location = new System.Drawing.Point(1496, 12);
            this.btnkapat.Margin = new System.Windows.Forms.Padding(0);
            this.btnkapat.Name = "btnkapat";
            this.btnkapat.Size = new System.Drawing.Size(39, 33);
            this.btnkapat.TabIndex = 17;
            this.btnkapat.Text = "X";
            this.btnkapat.UseVisualStyleBackColor = false;
            this.btnkapat.Click += new System.EventHandler(this.btnkapat_Click);
            // 
            // lbl_giris_paneli
            // 
            this.lbl_giris_paneli.AutoSize = true;
            this.lbl_giris_paneli.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_giris_paneli.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_giris_paneli.ForeColor = System.Drawing.Color.Black;
            this.lbl_giris_paneli.Location = new System.Drawing.Point(737, 1);
            this.lbl_giris_paneli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_giris_paneli.Name = "lbl_giris_paneli";
            this.lbl_giris_paneli.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lbl_giris_paneli.Size = new System.Drawing.Size(137, 44);
            this.lbl_giris_paneli.TabIndex = 16;
            this.lbl_giris_paneli.Text = "Personel";
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.White;
            this.btnsil.FlatAppearance.BorderSize = 0;
            this.btnsil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsil.Font = new System.Drawing.Font("Arial", 9F);
            this.btnsil.ForeColor = System.Drawing.Color.Black;
            this.btnsil.Location = new System.Drawing.Point(500, 634);
            this.btnsil.Margin = new System.Windows.Forms.Padding(0);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(78, 33);
            this.btnsil.TabIndex = 29;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // datagridpersonel
            // 
            this.datagridpersonel.AllowUserToResizeColumns = false;
            this.datagridpersonel.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridpersonel.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridpersonel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridpersonel.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.datagridpersonel.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.datagridpersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridpersonel.DefaultCellStyle = dataGridViewCellStyle2;
            this.datagridpersonel.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.datagridpersonel.Location = new System.Drawing.Point(400, 81);
            this.datagridpersonel.Margin = new System.Windows.Forms.Padding(4);
            this.datagridpersonel.Name = "datagridpersonel";
            this.datagridpersonel.RowHeadersWidth = 51;
            this.datagridpersonel.Size = new System.Drawing.Size(1135, 521);
            this.datagridpersonel.TabIndex = 28;
            this.datagridpersonel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridpersonel_CellContentClick);
            this.datagridpersonel.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridpersonel_CellDoubleClick);
            // 
            // btnkaydet
            // 
            this.btnkaydet.BackColor = System.Drawing.Color.White;
            this.btnkaydet.FlatAppearance.BorderSize = 0;
            this.btnkaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkaydet.Font = new System.Drawing.Font("Arial", 9F);
            this.btnkaydet.ForeColor = System.Drawing.Color.Black;
            this.btnkaydet.Location = new System.Drawing.Point(273, 715);
            this.btnkaydet.Margin = new System.Windows.Forms.Padding(0);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(94, 33);
            this.btnkaydet.TabIndex = 27;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = false;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // lbladres
            // 
            this.lbladres.AutoSize = true;
            this.lbladres.Font = new System.Drawing.Font("Arial", 9F);
            this.lbladres.ForeColor = System.Drawing.Color.Black;
            this.lbladres.Location = new System.Drawing.Point(19, 252);
            this.lbladres.Name = "lbladres";
            this.lbladres.Size = new System.Drawing.Size(58, 17);
            this.lbladres.TabIndex = 55;
            this.lbladres.Text = "Adres : ";
            // 
            // txtypadres
            // 
            this.txtypadres.Location = new System.Drawing.Point(156, 249);
            this.txtypadres.Margin = new System.Windows.Forms.Padding(4);
            this.txtypadres.Multiline = true;
            this.txtypadres.Name = "txtypadres";
            this.txtypadres.Size = new System.Drawing.Size(227, 101);
            this.txtypadres.TabIndex = 54;
            // 
            // cbypol
            // 
            this.cbypol.FormattingEnabled = true;
            this.cbypol.Location = new System.Drawing.Point(156, 483);
            this.cbypol.Margin = new System.Windows.Forms.Padding(4);
            this.cbypol.Name = "cbypol";
            this.cbypol.Size = new System.Drawing.Size(227, 24);
            this.cbypol.TabIndex = 53;
            // 
            // lblrol
            // 
            this.lblrol.AutoSize = true;
            this.lblrol.Font = new System.Drawing.Font("Arial", 9F);
            this.lblrol.ForeColor = System.Drawing.Color.Black;
            this.lblrol.Location = new System.Drawing.Point(19, 483);
            this.lblrol.Name = "lblrol";
            this.lblrol.Size = new System.Drawing.Size(50, 17);
            this.lblrol.TabIndex = 52;
            this.lblrol.Text = "Rolü : ";
            // 
            // cbypizin2
            // 
            this.cbypizin2.FormattingEnabled = true;
            this.cbypizin2.Location = new System.Drawing.Point(156, 440);
            this.cbypizin2.Margin = new System.Windows.Forms.Padding(4);
            this.cbypizin2.Name = "cbypizin2";
            this.cbypizin2.Size = new System.Drawing.Size(227, 24);
            this.cbypizin2.TabIndex = 50;
            this.cbypizin2.SelectedIndexChanged += new System.EventHandler(this.cb_izin2_SelectedIndexChanged);
            // 
            // cbypizin1
            // 
            this.cbypizin1.FormattingEnabled = true;
            this.cbypizin1.Location = new System.Drawing.Point(156, 402);
            this.cbypizin1.Margin = new System.Windows.Forms.Padding(4);
            this.cbypizin1.Name = "cbypizin1";
            this.cbypizin1.Size = new System.Drawing.Size(227, 24);
            this.cbypizin1.TabIndex = 49;
            // 
            // cbkadro
            // 
            this.cbkadro.FormattingEnabled = true;
            this.cbkadro.Location = new System.Drawing.Point(156, 203);
            this.cbkadro.Margin = new System.Windows.Forms.Padding(4);
            this.cbkadro.Name = "cbkadro";
            this.cbkadro.Size = new System.Drawing.Size(227, 24);
            this.cbkadro.TabIndex = 48;
            this.cbkadro.SelectedIndexChanged += new System.EventHandler(this.cb_kadro_SelectedIndexChanged);
            // 
            // txtypunvan
            // 
            this.txtypunvan.Location = new System.Drawing.Point(156, 358);
            this.txtypunvan.Margin = new System.Windows.Forms.Padding(4);
            this.txtypunvan.Name = "txtypunvan";
            this.txtypunvan.Size = new System.Drawing.Size(227, 22);
            this.txtypunvan.TabIndex = 45;
            // 
            // lblizin1
            // 
            this.lblizin1.AutoSize = true;
            this.lblizin1.Font = new System.Drawing.Font("Arial", 9F);
            this.lblizin1.ForeColor = System.Drawing.Color.Black;
            this.lblizin1.Location = new System.Drawing.Point(19, 398);
            this.lblizin1.Name = "lblizin1";
            this.lblizin1.Size = new System.Drawing.Size(93, 17);
            this.lblizin1.TabIndex = 44;
            this.lblizin1.Text = "1. İzin Günü :";
            // 
            // lblizin2
            // 
            this.lblizin2.AutoSize = true;
            this.lblizin2.Font = new System.Drawing.Font("Arial", 9F);
            this.lblizin2.ForeColor = System.Drawing.Color.Black;
            this.lblizin2.Location = new System.Drawing.Point(19, 440);
            this.lblizin2.Name = "lblizin2";
            this.lblizin2.Size = new System.Drawing.Size(93, 17);
            this.lblizin2.TabIndex = 43;
            this.lblizin2.Text = "2. İzin Günü :";
            // 
            // lblunvan
            // 
            this.lblunvan.AutoSize = true;
            this.lblunvan.Font = new System.Drawing.Font("Arial", 9F);
            this.lblunvan.ForeColor = System.Drawing.Color.Black;
            this.lblunvan.Location = new System.Drawing.Point(19, 361);
            this.lblunvan.Name = "lblunvan";
            this.lblunvan.Size = new System.Drawing.Size(64, 17);
            this.lblunvan.TabIndex = 42;
            this.lblunvan.Text = "Ünvanı : ";
            // 
            // lbltelefon
            // 
            this.lbltelefon.AutoSize = true;
            this.lbltelefon.Font = new System.Drawing.Font("Arial", 9F);
            this.lbltelefon.ForeColor = System.Drawing.Color.Black;
            this.lbltelefon.Location = new System.Drawing.Point(19, 647);
            this.lbltelefon.Name = "lbltelefon";
            this.lbltelefon.Size = new System.Drawing.Size(66, 17);
            this.lbltelefon.TabIndex = 41;
            this.lbltelefon.Text = "Telefon : ";
            // 
            // txtyptel
            // 
            this.txtyptel.Location = new System.Drawing.Point(156, 643);
            this.txtyptel.Margin = new System.Windows.Forms.Padding(4);
            this.txtyptel.Name = "txtyptel";
            this.txtyptel.Size = new System.Drawing.Size(227, 22);
            this.txtyptel.TabIndex = 40;
            // 
            // lblkadro
            // 
            this.lblkadro.AutoSize = true;
            this.lblkadro.Font = new System.Drawing.Font("Arial", 9F);
            this.lblkadro.ForeColor = System.Drawing.Color.Black;
            this.lblkadro.Location = new System.Drawing.Point(19, 203);
            this.lblkadro.Name = "lblkadro";
            this.lblkadro.Size = new System.Drawing.Size(85, 17);
            this.lblkadro.TabIndex = 38;
            this.lblkadro.Text = "Kadro Tipi : ";
            // 
            // txtypmail
            // 
            this.txtypmail.Location = new System.Drawing.Point(156, 604);
            this.txtypmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtypmail.Name = "txtypmail";
            this.txtypmail.Size = new System.Drawing.Size(227, 22);
            this.txtypmail.TabIndex = 31;
            // 
            // txtypsifre
            // 
            this.txtypsifre.Location = new System.Drawing.Point(156, 562);
            this.txtypsifre.Margin = new System.Windows.Forms.Padding(4);
            this.txtypsifre.Name = "txtypsifre";
            this.txtypsifre.Size = new System.Drawing.Size(227, 22);
            this.txtypsifre.TabIndex = 30;
            // 
            // txtyptc
            // 
            this.txtyptc.Location = new System.Drawing.Point(156, 525);
            this.txtyptc.Margin = new System.Windows.Forms.Padding(4);
            this.txtyptc.Name = "txtyptc";
            this.txtyptc.Size = new System.Drawing.Size(227, 22);
            this.txtyptc.TabIndex = 29;
            // 
            // lblsifre
            // 
            this.lblsifre.AutoSize = true;
            this.lblsifre.Font = new System.Drawing.Font("Arial", 9F);
            this.lblsifre.ForeColor = System.Drawing.Color.Black;
            this.lblsifre.Location = new System.Drawing.Point(19, 566);
            this.lblsifre.Name = "lblsifre";
            this.lblsifre.Size = new System.Drawing.Size(46, 17);
            this.lblsifre.TabIndex = 28;
            this.lblsifre.Text = "Şifre :";
            // 
            // lbleposta
            // 
            this.lbleposta.AutoSize = true;
            this.lbleposta.Font = new System.Drawing.Font("Arial", 9F);
            this.lbleposta.ForeColor = System.Drawing.Color.Black;
            this.lbleposta.Location = new System.Drawing.Point(19, 608);
            this.lbleposta.Name = "lbleposta";
            this.lbleposta.Size = new System.Drawing.Size(73, 17);
            this.lbleposta.TabIndex = 27;
            this.lbleposta.Text = "E-Posta : ";
            // 
            // lblkimlik
            // 
            this.lblkimlik.AutoSize = true;
            this.lblkimlik.Font = new System.Drawing.Font("Arial", 9F);
            this.lblkimlik.ForeColor = System.Drawing.Color.Black;
            this.lblkimlik.Location = new System.Drawing.Point(19, 529);
            this.lblkimlik.Name = "lblkimlik";
            this.lblkimlik.Size = new System.Drawing.Size(81, 17);
            this.lblkimlik.TabIndex = 26;
            this.lblkimlik.Text = "Kimlik No : ";
            // 
            // txtypsoyad
            // 
            this.txtypsoyad.Location = new System.Drawing.Point(156, 160);
            this.txtypsoyad.Margin = new System.Windows.Forms.Padding(4);
            this.txtypsoyad.Name = "txtypsoyad";
            this.txtypsoyad.Size = new System.Drawing.Size(227, 22);
            this.txtypsoyad.TabIndex = 25;
            // 
            // txtypad
            // 
            this.txtypad.Location = new System.Drawing.Point(156, 118);
            this.txtypad.Margin = new System.Windows.Forms.Padding(4);
            this.txtypad.Name = "txtypad";
            this.txtypad.Size = new System.Drawing.Size(227, 22);
            this.txtypad.TabIndex = 24;
            // 
            // lblad
            // 
            this.lblad.AutoSize = true;
            this.lblad.Font = new System.Drawing.Font("Arial", 9F);
            this.lblad.ForeColor = System.Drawing.Color.Black;
            this.lblad.Location = new System.Drawing.Point(19, 118);
            this.lblad.Name = "lblad";
            this.lblad.Size = new System.Drawing.Size(33, 17);
            this.lblad.TabIndex = 22;
            this.lblad.Text = "Ad :";
            // 
            // lblsoyad
            // 
            this.lblsoyad.AutoSize = true;
            this.lblsoyad.Font = new System.Drawing.Font("Arial", 9F);
            this.lblsoyad.ForeColor = System.Drawing.Color.Black;
            this.lblsoyad.Location = new System.Drawing.Point(19, 160);
            this.lblsoyad.Name = "lblsoyad";
            this.lblsoyad.Size = new System.Drawing.Size(61, 17);
            this.lblsoyad.TabIndex = 15;
            this.lblsoyad.Text = "Soyad : ";
            // 
            // lblsicilno
            // 
            this.lblsicilno.AutoSize = true;
            this.lblsicilno.Font = new System.Drawing.Font("Arial", 9F);
            this.lblsicilno.ForeColor = System.Drawing.Color.Black;
            this.lblsicilno.Location = new System.Drawing.Point(19, 81);
            this.lblsicilno.Name = "lblsicilno";
            this.lblsicilno.Size = new System.Drawing.Size(69, 17);
            this.lblsicilno.TabIndex = 14;
            this.lblsicilno.Text = "Sicil No : ";
            // 
            // btnciktial
            // 
            this.btnciktial.BackColor = System.Drawing.Color.White;
            this.btnciktial.FlatAppearance.BorderSize = 0;
            this.btnciktial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnciktial.Font = new System.Drawing.Font("Arial", 9F);
            this.btnciktial.ForeColor = System.Drawing.Color.Black;
            this.btnciktial.Location = new System.Drawing.Point(1202, 637);
            this.btnciktial.Margin = new System.Windows.Forms.Padding(0);
            this.btnciktial.Name = "btnciktial";
            this.btnciktial.Size = new System.Drawing.Size(86, 33);
            this.btnciktial.TabIndex = 30;
            this.btnciktial.Text = "Çıktı Al";
            this.btnciktial.UseVisualStyleBackColor = false;
            this.btnciktial.Click += new System.EventHandler(this.btnciktial_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.BackColor = System.Drawing.Color.White;
            this.btnguncelle.FlatAppearance.BorderSize = 0;
            this.btnguncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguncelle.Font = new System.Drawing.Font("Arial", 9F);
            this.btnguncelle.ForeColor = System.Drawing.Color.Black;
            this.btnguncelle.Location = new System.Drawing.Point(33, 715);
            this.btnguncelle.Margin = new System.Windows.Forms.Padding(0);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(94, 33);
            this.btnguncelle.TabIndex = 30;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = false;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btngeri
            // 
            this.btngeri.BackColor = System.Drawing.Color.White;
            this.btngeri.FlatAppearance.BorderSize = 0;
            this.btngeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngeri.Font = new System.Drawing.Font("Arial", 9F);
            this.btngeri.ForeColor = System.Drawing.Color.Black;
            this.btngeri.Location = new System.Drawing.Point(9, 9);
            this.btngeri.Margin = new System.Windows.Forms.Padding(0);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(104, 33);
            this.btngeri.TabIndex = 31;
            this.btngeri.Text = "Geri";
            this.btngeri.UseVisualStyleBackColor = false;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // txtypsicil
            // 
            this.txtypsicil.Location = new System.Drawing.Point(156, 81);
            this.txtypsicil.Margin = new System.Windows.Forms.Padding(4);
            this.txtypsicil.Name = "txtypsicil";
            this.txtypsicil.Size = new System.Drawing.Size(227, 22);
            this.txtypsicil.TabIndex = 57;
            // 
            // frmypersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1589, 821);
            this.Controls.Add(this.txtypsicil);
            this.Controls.Add(this.cbypol);
            this.Controls.Add(this.lbladres);
            this.Controls.Add(this.lblrol);
            this.Controls.Add(this.btngeri);
            this.Controls.Add(this.cbypizin2);
            this.Controls.Add(this.txtypadres);
            this.Controls.Add(this.cbypizin1);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.txtypunvan);
            this.Controls.Add(this.lblizin1);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.lblizin2);
            this.Controls.Add(this.datagridpersonel);
            this.Controls.Add(this.lblunvan);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.cbkadro);
            this.Controls.Add(this.btnciktial);
            this.Controls.Add(this.btnkapat);
            this.Controls.Add(this.lbl_giris_paneli);
            this.Controls.Add(this.txtyptc);
            this.Controls.Add(this.lblsicilno);
            this.Controls.Add(this.lbltelefon);
            this.Controls.Add(this.lblsoyad);
            this.Controls.Add(this.txtyptel);
            this.Controls.Add(this.lblad);
            this.Controls.Add(this.lblkadro);
            this.Controls.Add(this.txtypmail);
            this.Controls.Add(this.txtypad);
            this.Controls.Add(this.txtypsifre);
            this.Controls.Add(this.txtypsoyad);
            this.Controls.Add(this.lblkimlik);
            this.Controls.Add(this.lblsifre);
            this.Controls.Add(this.lbleposta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmypersonel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_adm_personel";
            this.Load += new System.EventHandler(this.frmypersonel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridpersonel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnkapat;
        private System.Windows.Forms.Label lbl_giris_paneli;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.DataGridView datagridpersonel;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Label lblad;
        private System.Windows.Forms.Label lblsoyad;
        private System.Windows.Forms.Label lblsicilno;
        private System.Windows.Forms.Button btnciktial;
        private System.Windows.Forms.TextBox txtypunvan;
        private System.Windows.Forms.Label lblizin1;
        private System.Windows.Forms.Label lblizin2;
        private System.Windows.Forms.Label lblunvan;
        private System.Windows.Forms.Label lbltelefon;
        private System.Windows.Forms.TextBox txtyptel;
        private System.Windows.Forms.Label lblkadro;
        private System.Windows.Forms.TextBox txtypmail;
        private System.Windows.Forms.TextBox txtypsifre;
        private System.Windows.Forms.TextBox txtyptc;
        private System.Windows.Forms.Label lblsifre;
        private System.Windows.Forms.Label lbleposta;
        private System.Windows.Forms.Label lblkimlik;
        private System.Windows.Forms.TextBox txtypsoyad;
        private System.Windows.Forms.TextBox txtypad;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.ComboBox cbypizin2;
        private System.Windows.Forms.ComboBox cbypizin1;
        private System.Windows.Forms.ComboBox cbkadro;
        private System.Windows.Forms.ComboBox cbypol;
        private System.Windows.Forms.Label lblrol;
        private System.Windows.Forms.Button btngeri;
        private System.Windows.Forms.Label lbladres;
        private System.Windows.Forms.TextBox txtypadres;
        private System.Windows.Forms.TextBox txtypsicil;
    }
}
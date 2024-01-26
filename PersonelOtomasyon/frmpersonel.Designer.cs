namespace PersonelOtomasyon
{
    partial class frmpersonel
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
            this.datagridpersonelvardiya = new System.Windows.Forms.DataGridView();
            this.btncikti = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.lbl_sicil_no = new System.Windows.Forms.Label();
            this.lbl_telefon = new System.Windows.Forms.Label();
            this.lbl_unvan = new System.Windows.Forms.Label();
            this.lbl_kadro = new System.Windows.Forms.Label();
            this.lbl_eposta = new System.Windows.Forms.Label();
            this.lbl_ad_soyad = new System.Windows.Forms.Label();
            this.pnl_per_profil = new System.Windows.Forms.Panel();
            this.txtadsoy = new System.Windows.Forms.TextBox();
            this.txttel = new System.Windows.Forms.TextBox();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.txtunvan = new System.Windows.Forms.TextBox();
            this.txtsicilno = new System.Windows.Forms.TextBox();
            this.txtprim = new System.Windows.Forms.TextBox();
            this.txtkadro = new System.Windows.Forms.TextBox();
            this.lbl_giris_paneli = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagridpersonelvardiya)).BeginInit();
            this.pnl_per_profil.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnkapat
            // 
            this.btnkapat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnkapat.FlatAppearance.BorderSize = 0;
            this.btnkapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkapat.ForeColor = System.Drawing.Color.White;
            this.btnkapat.Location = new System.Drawing.Point(1016, 11);
            this.btnkapat.Margin = new System.Windows.Forms.Padding(0);
            this.btnkapat.Name = "btnkapat";
            this.btnkapat.Size = new System.Drawing.Size(39, 33);
            this.btnkapat.TabIndex = 17;
            this.btnkapat.Text = "X";
            this.btnkapat.UseVisualStyleBackColor = false;
            this.btnkapat.Click += new System.EventHandler(this.btnkapat_Click);
            // 
            // datagridpersonelvardiya
            // 
            this.datagridpersonelvardiya.AllowUserToResizeColumns = false;
            this.datagridpersonelvardiya.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridpersonelvardiya.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridpersonelvardiya.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridpersonelvardiya.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.datagridpersonelvardiya.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.datagridpersonelvardiya.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridpersonelvardiya.DefaultCellStyle = dataGridViewCellStyle2;
            this.datagridpersonelvardiya.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.datagridpersonelvardiya.Location = new System.Drawing.Point(349, 61);
            this.datagridpersonelvardiya.Margin = new System.Windows.Forms.Padding(4);
            this.datagridpersonelvardiya.Name = "datagridpersonelvardiya";
            this.datagridpersonelvardiya.RowHeadersWidth = 51;
            this.datagridpersonelvardiya.Size = new System.Drawing.Size(702, 427);
            this.datagridpersonelvardiya.TabIndex = 18;
            this.datagridpersonelvardiya.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridpersonelvardiya_CellContentClick);
            // 
            // btncikti
            // 
            this.btncikti.BackColor = System.Drawing.Color.White;
            this.btncikti.FlatAppearance.BorderSize = 0;
            this.btncikti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncikti.Font = new System.Drawing.Font("Arial", 9F);
            this.btncikti.ForeColor = System.Drawing.Color.Black;
            this.btncikti.Location = new System.Drawing.Point(931, 510);
            this.btncikti.Margin = new System.Windows.Forms.Padding(0);
            this.btncikti.Name = "btncikti";
            this.btncikti.Size = new System.Drawing.Size(120, 33);
            this.btncikti.TabIndex = 19;
            this.btncikti.Text = "Çıktı Al";
            this.btncikti.UseVisualStyleBackColor = false;
            this.btncikti.Click += new System.EventHandler(this.btncikti_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Arial", 9F);
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(21, 261);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(43, 17);
            this.label22.TabIndex = 28;
            this.label22.Text = "Prim:";
            // 
            // lbl_sicil_no
            // 
            this.lbl_sicil_no.AutoSize = true;
            this.lbl_sicil_no.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_sicil_no.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sicil_no.ForeColor = System.Drawing.Color.Black;
            this.lbl_sicil_no.Location = new System.Drawing.Point(21, 179);
            this.lbl_sicil_no.Name = "lbl_sicil_no";
            this.lbl_sicil_no.Size = new System.Drawing.Size(118, 17);
            this.lbl_sicil_no.TabIndex = 27;
            this.lbl_sicil_no.Text = "Sicil Numarası :  ";
            // 
            // lbl_telefon
            // 
            this.lbl_telefon.AutoSize = true;
            this.lbl_telefon.Font = new System.Drawing.Font("Arial", 9F);
            this.lbl_telefon.ForeColor = System.Drawing.Color.Black;
            this.lbl_telefon.Location = new System.Drawing.Point(21, 53);
            this.lbl_telefon.Name = "lbl_telefon";
            this.lbl_telefon.Size = new System.Drawing.Size(66, 17);
            this.lbl_telefon.TabIndex = 26;
            this.lbl_telefon.Text = "Telefon : ";
            // 
            // lbl_unvan
            // 
            this.lbl_unvan.AutoSize = true;
            this.lbl_unvan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_unvan.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_unvan.ForeColor = System.Drawing.Color.Black;
            this.lbl_unvan.Location = new System.Drawing.Point(21, 221);
            this.lbl_unvan.Name = "lbl_unvan";
            this.lbl_unvan.Size = new System.Drawing.Size(61, 17);
            this.lbl_unvan.TabIndex = 25;
            this.lbl_unvan.Text = "Ünvan : ";
            // 
            // lbl_kadro
            // 
            this.lbl_kadro.AutoSize = true;
            this.lbl_kadro.Font = new System.Drawing.Font("Arial", 9F);
            this.lbl_kadro.ForeColor = System.Drawing.Color.Black;
            this.lbl_kadro.Location = new System.Drawing.Point(21, 135);
            this.lbl_kadro.Name = "lbl_kadro";
            this.lbl_kadro.Size = new System.Drawing.Size(55, 17);
            this.lbl_kadro.TabIndex = 24;
            this.lbl_kadro.Text = "Kadro :";
            // 
            // lbl_eposta
            // 
            this.lbl_eposta.AutoSize = true;
            this.lbl_eposta.Font = new System.Drawing.Font("Arial", 9F);
            this.lbl_eposta.ForeColor = System.Drawing.Color.Black;
            this.lbl_eposta.Location = new System.Drawing.Point(21, 95);
            this.lbl_eposta.Name = "lbl_eposta";
            this.lbl_eposta.Size = new System.Drawing.Size(73, 17);
            this.lbl_eposta.TabIndex = 23;
            this.lbl_eposta.Text = "E-Posta : ";
            // 
            // lbl_ad_soyad
            // 
            this.lbl_ad_soyad.AutoSize = true;
            this.lbl_ad_soyad.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ad_soyad.ForeColor = System.Drawing.Color.Black;
            this.lbl_ad_soyad.Location = new System.Drawing.Point(21, 11);
            this.lbl_ad_soyad.Name = "lbl_ad_soyad";
            this.lbl_ad_soyad.Size = new System.Drawing.Size(86, 17);
            this.lbl_ad_soyad.TabIndex = 22;
            this.lbl_ad_soyad.Text = "Ad Soyad :  ";
            this.lbl_ad_soyad.Click += new System.EventHandler(this.lbl_ad_soyad_Click);
            // 
            // pnl_per_profil
            // 
            this.pnl_per_profil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_per_profil.Controls.Add(this.txtadsoy);
            this.pnl_per_profil.Controls.Add(this.txttel);
            this.pnl_per_profil.Controls.Add(this.txtmail);
            this.pnl_per_profil.Controls.Add(this.txtunvan);
            this.pnl_per_profil.Controls.Add(this.txtsicilno);
            this.pnl_per_profil.Controls.Add(this.txtprim);
            this.pnl_per_profil.Controls.Add(this.txtkadro);
            this.pnl_per_profil.Controls.Add(this.label22);
            this.pnl_per_profil.Controls.Add(this.lbl_ad_soyad);
            this.pnl_per_profil.Controls.Add(this.lbl_eposta);
            this.pnl_per_profil.Controls.Add(this.lbl_sicil_no);
            this.pnl_per_profil.Controls.Add(this.lbl_kadro);
            this.pnl_per_profil.Controls.Add(this.lbl_unvan);
            this.pnl_per_profil.Controls.Add(this.lbl_telefon);
            this.pnl_per_profil.ForeColor = System.Drawing.Color.Black;
            this.pnl_per_profil.Location = new System.Drawing.Point(13, 96);
            this.pnl_per_profil.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_per_profil.Name = "pnl_per_profil";
            this.pnl_per_profil.Size = new System.Drawing.Size(325, 358);
            this.pnl_per_profil.TabIndex = 20;
            this.pnl_per_profil.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_per_profil_Paint);
            // 
            // txtadsoy
            // 
            this.txtadsoy.Location = new System.Drawing.Point(168, 9);
            this.txtadsoy.Name = "txtadsoy";
            this.txtadsoy.Size = new System.Drawing.Size(117, 22);
            this.txtadsoy.TabIndex = 35;
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(168, 51);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(117, 22);
            this.txttel.TabIndex = 34;
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(168, 93);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(117, 22);
            this.txtmail.TabIndex = 33;
            // 
            // txtunvan
            // 
            this.txtunvan.Location = new System.Drawing.Point(168, 219);
            this.txtunvan.Name = "txtunvan";
            this.txtunvan.Size = new System.Drawing.Size(117, 22);
            this.txtunvan.TabIndex = 32;
            // 
            // txtsicilno
            // 
            this.txtsicilno.Location = new System.Drawing.Point(168, 177);
            this.txtsicilno.Name = "txtsicilno";
            this.txtsicilno.Size = new System.Drawing.Size(117, 22);
            this.txtsicilno.TabIndex = 31;
            // 
            // txtprim
            // 
            this.txtprim.Location = new System.Drawing.Point(168, 261);
            this.txtprim.Name = "txtprim";
            this.txtprim.Size = new System.Drawing.Size(117, 22);
            this.txtprim.TabIndex = 30;
            // 
            // txtkadro
            // 
            this.txtkadro.Location = new System.Drawing.Point(168, 135);
            this.txtkadro.Name = "txtkadro";
            this.txtkadro.Size = new System.Drawing.Size(117, 22);
            this.txtkadro.TabIndex = 29;
            // 
            // lbl_giris_paneli
            // 
            this.lbl_giris_paneli.AutoSize = true;
            this.lbl_giris_paneli.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_giris_paneli.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_giris_paneli.ForeColor = System.Drawing.Color.Black;
            this.lbl_giris_paneli.Location = new System.Drawing.Point(390, 1);
            this.lbl_giris_paneli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_giris_paneli.Name = "lbl_giris_paneli";
            this.lbl_giris_paneli.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lbl_giris_paneli.Size = new System.Drawing.Size(222, 44);
            this.lbl_giris_paneli.TabIndex = 16;
            this.lbl_giris_paneli.Text = "Personel Paneli";
            this.lbl_giris_paneli.Click += new System.EventHandler(this.lbl_giris_paneli_Click);
            // 
            // frmpersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1068, 559);
            this.Controls.Add(this.pnl_per_profil);
            this.Controls.Add(this.btncikti);
            this.Controls.Add(this.datagridpersonelvardiya);
            this.Controls.Add(this.btnkapat);
            this.Controls.Add(this.lbl_giris_paneli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmpersonel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Paneli";
            this.Load += new System.EventHandler(this.frmpersonel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridpersonelvardiya)).EndInit();
            this.pnl_per_profil.ResumeLayout(false);
            this.pnl_per_profil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnkapat;
        private System.Windows.Forms.DataGridView datagridpersonelvardiya;
        private System.Windows.Forms.Button btncikti;
        private System.Windows.Forms.Label lbl_sicil_no;
        private System.Windows.Forms.Label lbl_telefon;
        private System.Windows.Forms.Label lbl_unvan;
        private System.Windows.Forms.Label lbl_kadro;
        private System.Windows.Forms.Label lbl_eposta;
        private System.Windows.Forms.Label lbl_ad_soyad;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Panel pnl_per_profil;
        private System.Windows.Forms.TextBox txtkadro;
        private System.Windows.Forms.TextBox txtadsoy;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.TextBox txtunvan;
        private System.Windows.Forms.TextBox txtsicilno;
        private System.Windows.Forms.TextBox txtprim;
        private System.Windows.Forms.Label lbl_giris_paneli;
    }
}
namespace PersonelOtomasyon
{
    partial class frmymesai
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
            this.btn_kapat = new System.Windows.Forms.Button();
            this.lbl_giris_paneli = new System.Windows.Forms.Label();
            this.datagridmesai = new System.Windows.Forms.DataGridView();
            this.btn_geri = new System.Windows.Forms.Button();
            this.btniekle = new System.Windows.Forms.Button();
            this.lblmts = new System.Windows.Forms.Label();
            this.btnmsil = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpizinbit = new System.Windows.Forms.DateTimePicker();
            this.dtpizinbas = new System.Windows.Forms.DateTimePicker();
            this.cbisicilno = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagridmesai)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_kapat
            // 
            this.btn_kapat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_kapat.FlatAppearance.BorderSize = 0;
            this.btn_kapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kapat.ForeColor = System.Drawing.Color.White;
            this.btn_kapat.Location = new System.Drawing.Point(1022, 6);
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
            this.lbl_giris_paneli.Font = new System.Drawing.Font("Arial", 16F);
            this.lbl_giris_paneli.ForeColor = System.Drawing.Color.Black;
            this.lbl_giris_paneli.Location = new System.Drawing.Point(389, -5);
            this.lbl_giris_paneli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_giris_paneli.Name = "lbl_giris_paneli";
            this.lbl_giris_paneli.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lbl_giris_paneli.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_giris_paneli.Size = new System.Drawing.Size(213, 44);
            this.lbl_giris_paneli.TabIndex = 16;
            this.lbl_giris_paneli.Text = "Mesailer Paneli";
            // 
            // datagridmesai
            // 
            this.datagridmesai.AllowUserToResizeColumns = false;
            this.datagridmesai.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridmesai.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridmesai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridmesai.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.datagridmesai.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.datagridmesai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridmesai.DefaultCellStyle = dataGridViewCellStyle2;
            this.datagridmesai.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.datagridmesai.Location = new System.Drawing.Point(455, 60);
            this.datagridmesai.Margin = new System.Windows.Forms.Padding(4);
            this.datagridmesai.Name = "datagridmesai";
            this.datagridmesai.RowHeadersWidth = 51;
            this.datagridmesai.Size = new System.Drawing.Size(602, 474);
            this.datagridmesai.TabIndex = 26;
            this.datagridmesai.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.datagridmesai_CellMouseClick);
            // 
            // btn_geri
            // 
            this.btn_geri.BackColor = System.Drawing.Color.White;
            this.btn_geri.FlatAppearance.BorderSize = 0;
            this.btn_geri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_geri.Font = new System.Drawing.Font("Arial", 9F);
            this.btn_geri.ForeColor = System.Drawing.Color.Black;
            this.btn_geri.Location = new System.Drawing.Point(22, 6);
            this.btn_geri.Margin = new System.Windows.Forms.Padding(0);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(70, 33);
            this.btn_geri.TabIndex = 28;
            this.btn_geri.Text = "Geri";
            this.btn_geri.UseVisualStyleBackColor = false;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // btniekle
            // 
            this.btniekle.BackColor = System.Drawing.Color.White;
            this.btniekle.FlatAppearance.BorderSize = 0;
            this.btniekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btniekle.Font = new System.Drawing.Font("Arial", 9F);
            this.btniekle.ForeColor = System.Drawing.Color.Black;
            this.btniekle.Location = new System.Drawing.Point(246, 63);
            this.btniekle.Margin = new System.Windows.Forms.Padding(0);
            this.btniekle.Name = "btniekle";
            this.btniekle.Size = new System.Drawing.Size(149, 32);
            this.btniekle.TabIndex = 29;
            this.btniekle.Text = "Ekle";
            this.btniekle.UseVisualStyleBackColor = false;
            this.btniekle.Click += new System.EventHandler(this.btniekle_Click);
            // 
            // lblmts
            // 
            this.lblmts.AutoSize = true;
            this.lblmts.Font = new System.Drawing.Font("Arial", 9F);
            this.lblmts.ForeColor = System.Drawing.Color.Black;
            this.lblmts.Location = new System.Drawing.Point(27, 25);
            this.lblmts.Name = "lblmts";
            this.lblmts.Size = new System.Drawing.Size(137, 17);
            this.lblmts.TabIndex = 31;
            this.lblmts.Text = "Mesai Tarihi Seçin : ";
            this.lblmts.Click += new System.EventHandler(this.lblmts_Click);
            // 
            // btnmsil
            // 
            this.btnmsil.BackColor = System.Drawing.Color.White;
            this.btnmsil.FlatAppearance.BorderSize = 0;
            this.btnmsil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmsil.Font = new System.Drawing.Font("Arial", 9F);
            this.btnmsil.ForeColor = System.Drawing.Color.Black;
            this.btnmsil.Location = new System.Drawing.Point(268, 277);
            this.btnmsil.Margin = new System.Windows.Forms.Padding(0);
            this.btnmsil.Name = "btnmsil";
            this.btnmsil.Size = new System.Drawing.Size(149, 32);
            this.btnmsil.TabIndex = 29;
            this.btnmsil.Text = "Sil";
            this.btnmsil.UseVisualStyleBackColor = false;
            this.btnmsil.Click += new System.EventHandler(this.btnmsil_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.dtpizinbit);
            this.panel1.Controls.Add(this.dtpizinbas);
            this.panel1.Controls.Add(this.lblmts);
            this.panel1.Controls.Add(this.btniekle);
            this.panel1.Location = new System.Drawing.Point(22, 60);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 123);
            this.panel1.TabIndex = 32;
            // 
            // dtpizinbit
            // 
            this.dtpizinbit.Location = new System.Drawing.Point(28, 91);
            this.dtpizinbit.Name = "dtpizinbit";
            this.dtpizinbit.Size = new System.Drawing.Size(200, 22);
            this.dtpizinbit.TabIndex = 33;
            this.dtpizinbit.Value = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            // 
            // dtpizinbas
            // 
            this.dtpizinbas.Location = new System.Drawing.Point(28, 63);
            this.dtpizinbas.Name = "dtpizinbas";
            this.dtpizinbas.Size = new System.Drawing.Size(200, 22);
            this.dtpizinbas.TabIndex = 32;
            this.dtpizinbas.Value = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            // 
            // cbisicilno
            // 
            this.cbisicilno.DisplayMember = "adasda";
            this.cbisicilno.FormattingEnabled = true;
            this.cbisicilno.Location = new System.Drawing.Point(52, 277);
            this.cbisicilno.Name = "cbisicilno";
            this.cbisicilno.Size = new System.Drawing.Size(198, 24);
            this.cbisicilno.TabIndex = 32;
            this.cbisicilno.Text = "Kişi Seç";
            // 
            // frmymesai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.cbisicilno);
            this.Controls.Add(this.btnmsil);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.datagridmesai);
            this.Controls.Add(this.btn_kapat);
            this.Controls.Add(this.lbl_giris_paneli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmymesai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmymesai";
            this.Load += new System.EventHandler(this.frmymesai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridmesai)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_kapat;
        private System.Windows.Forms.Label lbl_giris_paneli;
        private System.Windows.Forms.DataGridView datagridmesai;
        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.Button btniekle;
        private System.Windows.Forms.Label lblmts;
        private System.Windows.Forms.Button btnmsil;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpizinbas;
        private System.Windows.Forms.ComboBox cbisicilno;
        private System.Windows.Forms.DateTimePicker dtpizinbit;
    }
}
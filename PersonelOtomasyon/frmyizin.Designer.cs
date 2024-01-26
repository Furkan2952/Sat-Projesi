namespace PersonelOtomasyon
{
    partial class frmyizin
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
            this.btnkapa = new System.Windows.Forms.Button();
            this.lbl_izinler = new System.Windows.Forms.Label();
            this.btnisil = new System.Windows.Forms.Button();
            this.datagridizinler = new System.Windows.Forms.DataGridView();
            this.btnikaydet = new System.Windows.Forms.Button();
            this.txtizinsebep = new System.Windows.Forms.TextBox();
            this.lbl_izin_sebep = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpizinbit = new System.Windows.Forms.DateTimePicker();
            this.cbisicilno = new System.Windows.Forms.ComboBox();
            this.dtpizinbas = new System.Windows.Forms.DateTimePicker();
            this.lbl_izin_tarih = new System.Windows.Forms.Label();
            this.lbl_sicil_no = new System.Windows.Forms.Label();
            this.btngeri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridizinler)).BeginInit();
            this.SuspendLayout();
            // 
            // btnkapa
            // 
            this.btnkapa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnkapa.FlatAppearance.BorderSize = 0;
            this.btnkapa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkapa.ForeColor = System.Drawing.Color.White;
            this.btnkapa.Location = new System.Drawing.Point(1029, 11);
            this.btnkapa.Margin = new System.Windows.Forms.Padding(0);
            this.btnkapa.Name = "btnkapa";
            this.btnkapa.Size = new System.Drawing.Size(39, 33);
            this.btnkapa.TabIndex = 19;
            this.btnkapa.Text = "X";
            this.btnkapa.UseVisualStyleBackColor = false;
            this.btnkapa.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // lbl_izinler
            // 
            this.lbl_izinler.AutoSize = true;
            this.lbl_izinler.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_izinler.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_izinler.ForeColor = System.Drawing.Color.Black;
            this.lbl_izinler.Location = new System.Drawing.Point(452, 1);
            this.lbl_izinler.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_izinler.Name = "lbl_izinler";
            this.lbl_izinler.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lbl_izinler.Size = new System.Drawing.Size(104, 44);
            this.lbl_izinler.TabIndex = 18;
            this.lbl_izinler.Text = "İzinler";
            // 
            // btnisil
            // 
            this.btnisil.BackColor = System.Drawing.Color.White;
            this.btnisil.FlatAppearance.BorderSize = 0;
            this.btnisil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnisil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnisil.ForeColor = System.Drawing.Color.Black;
            this.btnisil.Location = new System.Drawing.Point(278, 248);
            this.btnisil.Margin = new System.Windows.Forms.Padding(0);
            this.btnisil.Name = "btnisil";
            this.btnisil.Size = new System.Drawing.Size(179, 33);
            this.btnisil.TabIndex = 25;
            this.btnisil.Text = "Sil";
            this.btnisil.UseVisualStyleBackColor = false;
            this.btnisil.Click += new System.EventHandler(this.btnisil_Click);
            // 
            // datagridizinler
            // 
            this.datagridizinler.AllowUserToResizeColumns = false;
            this.datagridizinler.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridizinler.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridizinler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridizinler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.datagridizinler.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.datagridizinler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridizinler.DefaultCellStyle = dataGridViewCellStyle2;
            this.datagridizinler.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.datagridizinler.Location = new System.Drawing.Point(478, 66);
            this.datagridizinler.Margin = new System.Windows.Forms.Padding(4);
            this.datagridizinler.Name = "datagridizinler";
            this.datagridizinler.RowHeadersWidth = 51;
            this.datagridizinler.Size = new System.Drawing.Size(600, 434);
            this.datagridizinler.TabIndex = 24;
            // 
            // btnikaydet
            // 
            this.btnikaydet.BackColor = System.Drawing.Color.White;
            this.btnikaydet.FlatAppearance.BorderSize = 0;
            this.btnikaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnikaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnikaydet.ForeColor = System.Drawing.Color.Black;
            this.btnikaydet.Location = new System.Drawing.Point(26, 248);
            this.btnikaydet.Margin = new System.Windows.Forms.Padding(0);
            this.btnikaydet.Name = "btnikaydet";
            this.btnikaydet.Size = new System.Drawing.Size(196, 33);
            this.btnikaydet.TabIndex = 23;
            this.btnikaydet.Text = "Kaydet";
            this.btnikaydet.UseVisualStyleBackColor = false;
            this.btnikaydet.Click += new System.EventHandler(this.btnikaydet_Click);
            // 
            // txtizinsebep
            // 
            this.txtizinsebep.Location = new System.Drawing.Point(151, 142);
            this.txtizinsebep.Margin = new System.Windows.Forms.Padding(4);
            this.txtizinsebep.Name = "txtizinsebep";
            this.txtizinsebep.Size = new System.Drawing.Size(265, 22);
            this.txtizinsebep.TabIndex = 23;
            // 
            // lbl_izin_sebep
            // 
            this.lbl_izin_sebep.AutoSize = true;
            this.lbl_izin_sebep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_izin_sebep.ForeColor = System.Drawing.Color.Black;
            this.lbl_izin_sebep.Location = new System.Drawing.Point(18, 146);
            this.lbl_izin_sebep.Name = "lbl_izin_sebep";
            this.lbl_izin_sebep.Size = new System.Drawing.Size(101, 20);
            this.lbl_izin_sebep.TabIndex = 22;
            this.lbl_izin_sebep.Text = "İzin Sebebi :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.label1.Location = new System.Drawing.Point(274, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "-";
            // 
            // dtpizinbit
            // 
            this.dtpizinbit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpizinbit.Location = new System.Drawing.Point(299, 188);
            this.dtpizinbit.Margin = new System.Windows.Forms.Padding(4);
            this.dtpizinbit.Name = "dtpizinbit";
            this.dtpizinbit.Size = new System.Drawing.Size(117, 22);
            this.dtpizinbit.TabIndex = 20;
            this.dtpizinbit.Value = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            // 
            // cbisicilno
            // 
            this.cbisicilno.FormattingEnabled = true;
            this.cbisicilno.Location = new System.Drawing.Point(151, 99);
            this.cbisicilno.Margin = new System.Windows.Forms.Padding(4);
            this.cbisicilno.Name = "cbisicilno";
            this.cbisicilno.Size = new System.Drawing.Size(265, 24);
            this.cbisicilno.TabIndex = 19;
            this.cbisicilno.SelectedIndexChanged += new System.EventHandler(this.cbisicilno_SelectedIndexChanged);
            // 
            // dtpizinbas
            // 
            this.dtpizinbas.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpizinbas.Location = new System.Drawing.Point(151, 188);
            this.dtpizinbas.Margin = new System.Windows.Forms.Padding(4);
            this.dtpizinbas.Name = "dtpizinbas";
            this.dtpizinbas.Size = new System.Drawing.Size(115, 22);
            this.dtpizinbas.TabIndex = 17;
            this.dtpizinbas.Value = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            // 
            // lbl_izin_tarih
            // 
            this.lbl_izin_tarih.AutoSize = true;
            this.lbl_izin_tarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_izin_tarih.ForeColor = System.Drawing.Color.Black;
            this.lbl_izin_tarih.Location = new System.Drawing.Point(18, 191);
            this.lbl_izin_tarih.Name = "lbl_izin_tarih";
            this.lbl_izin_tarih.Size = new System.Drawing.Size(97, 20);
            this.lbl_izin_tarih.TabIndex = 15;
            this.lbl_izin_tarih.Text = "İzin Tarihi : ";
            // 
            // lbl_sicil_no
            // 
            this.lbl_sicil_no.AutoSize = true;
            this.lbl_sicil_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sicil_no.ForeColor = System.Drawing.Color.Black;
            this.lbl_sicil_no.Location = new System.Drawing.Point(18, 99);
            this.lbl_sicil_no.Name = "lbl_sicil_no";
            this.lbl_sicil_no.Size = new System.Drawing.Size(82, 20);
            this.lbl_sicil_no.TabIndex = 14;
            this.lbl_sicil_no.Text = "Sicil No : ";
            // 
            // btngeri
            // 
            this.btngeri.BackColor = System.Drawing.Color.White;
            this.btngeri.FlatAppearance.BorderSize = 0;
            this.btngeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngeri.ForeColor = System.Drawing.Color.Black;
            this.btngeri.Location = new System.Drawing.Point(12, 11);
            this.btngeri.Margin = new System.Windows.Forms.Padding(0);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(67, 33);
            this.btngeri.TabIndex = 26;
            this.btngeri.Text = "Geri";
            this.btngeri.UseVisualStyleBackColor = false;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // frmyizin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1090, 513);
            this.Controls.Add(this.txtizinsebep);
            this.Controls.Add(this.btngeri);
            this.Controls.Add(this.lbl_izin_sebep);
            this.Controls.Add(this.btnisil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datagridizinler);
            this.Controls.Add(this.dtpizinbit);
            this.Controls.Add(this.btnikaydet);
            this.Controls.Add(this.cbisicilno);
            this.Controls.Add(this.dtpizinbas);
            this.Controls.Add(this.lbl_izin_tarih);
            this.Controls.Add(this.btnkapa);
            this.Controls.Add(this.lbl_sicil_no);
            this.Controls.Add(this.lbl_izinler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmyizin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_adm_izin";
            this.Load += new System.EventHandler(this.frm_adm_izin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridizinler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnkapa;
        private System.Windows.Forms.Label lbl_izinler;
        private System.Windows.Forms.Button btnisil;
        private System.Windows.Forms.DataGridView datagridizinler;
        private System.Windows.Forms.Button btnikaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpizinbit;
        private System.Windows.Forms.ComboBox cbisicilno;
        private System.Windows.Forms.DateTimePicker dtpizinbas;
        private System.Windows.Forms.Label lbl_izin_tarih;
        private System.Windows.Forms.Label lbl_sicil_no;
        private System.Windows.Forms.TextBox txtizinsebep;
        private System.Windows.Forms.Label lbl_izin_sebep;
        private System.Windows.Forms.Button btngeri;
    }
}
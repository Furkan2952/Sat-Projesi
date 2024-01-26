namespace PersonelOtomasyon
{
    partial class frmgiris
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
            this.lbl_giris_paneli = new System.Windows.Forms.Label();
            this.btn_kapat = new System.Windows.Forms.Button();
            this.lbl_eposta = new System.Windows.Forms.Label();
            this.tbx_sifre = new System.Windows.Forms.TextBox();
            this.tbx_eposta = new System.Windows.Forms.TextBox();
            this.lbl_sifre = new System.Windows.Forms.Label();
            this.btn_giris_yap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_giris_paneli
            // 
            this.lbl_giris_paneli.AutoSize = true;
            this.lbl_giris_paneli.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_giris_paneli.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_giris_paneli.ForeColor = System.Drawing.Color.White;
            this.lbl_giris_paneli.Location = new System.Drawing.Point(119, 1);
            this.lbl_giris_paneli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_giris_paneli.Name = "lbl_giris_paneli";
            this.lbl_giris_paneli.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lbl_giris_paneli.Size = new System.Drawing.Size(175, 44);
            this.lbl_giris_paneli.TabIndex = 11;
            this.lbl_giris_paneli.Text = "Giriş Paneli";
            // 
            // btn_kapat
            // 
            this.btn_kapat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_kapat.FlatAppearance.BorderSize = 0;
            this.btn_kapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kapat.ForeColor = System.Drawing.Color.White;
            this.btn_kapat.Location = new System.Drawing.Point(382, 5);
            this.btn_kapat.Margin = new System.Windows.Forms.Padding(0);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(39, 33);
            this.btn_kapat.TabIndex = 13;
            this.btn_kapat.Text = "X";
            this.btn_kapat.UseVisualStyleBackColor = false;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // lbl_eposta
            // 
            this.lbl_eposta.AutoSize = true;
            this.lbl_eposta.Font = new System.Drawing.Font("Arial", 9F);
            this.lbl_eposta.ForeColor = System.Drawing.Color.Black;
            this.lbl_eposta.Location = new System.Drawing.Point(32, 93);
            this.lbl_eposta.Name = "lbl_eposta";
            this.lbl_eposta.Size = new System.Drawing.Size(65, 17);
            this.lbl_eposta.TabIndex = 14;
            this.lbl_eposta.Text = "E-Posta:";
            // 
            // tbx_sifre
            // 
            this.tbx_sifre.Location = new System.Drawing.Point(167, 145);
            this.tbx_sifre.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_sifre.Name = "tbx_sifre";
            this.tbx_sifre.Size = new System.Drawing.Size(224, 22);
            this.tbx_sifre.TabIndex = 17;
            // 
            // tbx_eposta
            // 
            this.tbx_eposta.Location = new System.Drawing.Point(167, 93);
            this.tbx_eposta.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_eposta.Name = "tbx_eposta";
            this.tbx_eposta.Size = new System.Drawing.Size(224, 22);
            this.tbx_eposta.TabIndex = 16;
            // 
            // lbl_sifre
            // 
            this.lbl_sifre.AutoSize = true;
            this.lbl_sifre.Font = new System.Drawing.Font("Arial", 9F);
            this.lbl_sifre.ForeColor = System.Drawing.Color.Black;
            this.lbl_sifre.Location = new System.Drawing.Point(32, 145);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(42, 17);
            this.lbl_sifre.TabIndex = 15;
            this.lbl_sifre.Text = "Şifre:";
            // 
            // btn_giris_yap
            // 
            this.btn_giris_yap.BackColor = System.Drawing.Color.White;
            this.btn_giris_yap.FlatAppearance.BorderSize = 0;
            this.btn_giris_yap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_giris_yap.Font = new System.Drawing.Font("Arial", 9F);
            this.btn_giris_yap.ForeColor = System.Drawing.Color.Black;
            this.btn_giris_yap.Location = new System.Drawing.Point(282, 192);
            this.btn_giris_yap.Margin = new System.Windows.Forms.Padding(0);
            this.btn_giris_yap.Name = "btn_giris_yap";
            this.btn_giris_yap.Size = new System.Drawing.Size(109, 33);
            this.btn_giris_yap.TabIndex = 16;
            this.btn_giris_yap.Text = "Giriş Yap";
            this.btn_giris_yap.UseVisualStyleBackColor = false;
            this.btn_giris_yap.Click += new System.EventHandler(this.btn_giris_yap_Click);
            // 
            // frmgiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(430, 276);
            this.Controls.Add(this.tbx_sifre);
            this.Controls.Add(this.btn_giris_yap);
            this.Controls.Add(this.tbx_eposta);
            this.Controls.Add(this.lbl_sifre);
            this.Controls.Add(this.lbl_eposta);
            this.Controls.Add(this.btn_kapat);
            this.Controls.Add(this.lbl_giris_paneli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmgiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Yap";
            this.Load += new System.EventHandler(this.frm_login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_giris_paneli;
        private System.Windows.Forms.Button btn_kapat;
        private System.Windows.Forms.Label lbl_eposta;
        private System.Windows.Forms.Button btn_giris_yap;
        private System.Windows.Forms.TextBox tbx_sifre;
        private System.Windows.Forms.TextBox tbx_eposta;
        private System.Windows.Forms.Label lbl_sifre;
    }
}


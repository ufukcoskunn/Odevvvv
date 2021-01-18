
namespace Odev4
{
    partial class Ogrenci
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
            this.label7 = new System.Windows.Forms.Label();
            this.TxtSinif = new System.Windows.Forms.TextBox();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.DtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.CbCinsiyet = new System.Windows.Forms.ComboBox();
            this.txtGsm = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.txtSoyAd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.DgvOgrenci = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOgrenci)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(131, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Sınıf";
            // 
            // TxtSinif
            // 
            this.TxtSinif.Location = new System.Drawing.Point(26, 216);
            this.TxtSinif.Name = "TxtSinif";
            this.TxtSinif.Size = new System.Drawing.Size(100, 20);
            this.TxtSinif.TabIndex = 42;
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(190, 30);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(75, 23);
            this.BtnEkle.TabIndex = 41;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // DtpDogumTarihi
            // 
            this.DtpDogumTarihi.Location = new System.Drawing.Point(26, 190);
            this.DtpDogumTarihi.Name = "DtpDogumTarihi";
            this.DtpDogumTarihi.Size = new System.Drawing.Size(100, 20);
            this.DtpDogumTarihi.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(130, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Cinsiyet";
            // 
            // CbCinsiyet
            // 
            this.CbCinsiyet.FormattingEnabled = true;
            this.CbCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.CbCinsiyet.Location = new System.Drawing.Point(24, 163);
            this.CbCinsiyet.Name = "CbCinsiyet";
            this.CbCinsiyet.Size = new System.Drawing.Size(100, 21);
            this.CbCinsiyet.TabIndex = 38;
            this.CbCinsiyet.SelectedIndexChanged += new System.EventHandler(this.CbCinsiyet_SelectedIndexChanged);
            // 
            // txtGsm
            // 
            this.txtGsm.Location = new System.Drawing.Point(24, 137);
            this.txtGsm.Name = "txtGsm";
            this.txtGsm.Size = new System.Drawing.Size(100, 20);
            this.txtGsm.TabIndex = 37;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(24, 111);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 36;
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(24, 85);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(100, 20);
            this.txtTc.TabIndex = 35;
            // 
            // txtSoyAd
            // 
            this.txtSoyAd.Location = new System.Drawing.Point(24, 59);
            this.txtSoyAd.Name = "txtSoyAd";
            this.txtSoyAd.Size = new System.Drawing.Size(100, 20);
            this.txtSoyAd.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(130, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "DogumTarihi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Gsm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Tc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Ad";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(24, 33);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 27;
            this.txtAd.TextChanged += new System.EventHandler(this.txtAd_TextChanged);
            // 
            // DgvOgrenci
            // 
            this.DgvOgrenci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvOgrenci.Location = new System.Drawing.Point(438, 33);
            this.DgvOgrenci.Name = "DgvOgrenci";
            this.DgvOgrenci.Size = new System.Drawing.Size(338, 387);
            this.DgvOgrenci.TabIndex = 26;
            this.DgvOgrenci.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvOgrenci_CellContentClick);
            // 
            // Ogrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtSinif);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.DtpDogumTarihi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CbCinsiyet);
            this.Controls.Add(this.txtGsm);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTc);
            this.Controls.Add(this.txtSoyAd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.DgvOgrenci);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ogrenci";
            this.Text = "Ogrenci";
            this.Load += new System.EventHandler(this.Ogrenci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvOgrenci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtSinif;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.DateTimePicker DtpDogumTarihi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CbCinsiyet;
        private System.Windows.Forms.TextBox txtGsm;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.TextBox txtSoyAd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.DataGridView DgvOgrenci;
    }
}
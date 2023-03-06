namespace AltayPansiyon.UI
{
    partial class FrmRezervasyon
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
            this.flKat4 = new System.Windows.Forms.FlowLayoutPanel();
            this.flKat1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mskTc = new System.Windows.Forms.MaskedTextBox();
            this.mskTelNo = new System.Windows.Forms.MaskedTextBox();
            this.mskDogumDate = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lstRezervasyonBilgileri = new System.Windows.Forms.ListBox();
            this.btnAraToplam = new System.Windows.Forms.Button();
            this.lblGunlukUcretGoster = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nupKisiSayisi = new System.Windows.Forms.NumericUpDown();
            this.dtmpCikis = new System.Windows.Forms.DateTimePicker();
            this.dtmpGiris = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGec = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupKisiSayisi)).BeginInit();
            this.SuspendLayout();
            // 
            // flKat4
            // 
            this.flKat4.Location = new System.Drawing.Point(24, 23);
            this.flKat4.Margin = new System.Windows.Forms.Padding(4);
            this.flKat4.Name = "flKat4";
            this.flKat4.Size = new System.Drawing.Size(568, 78);
            this.flKat4.TabIndex = 0;
            // 
            // flKat1
            // 
            this.flKat1.Location = new System.Drawing.Point(24, 109);
            this.flKat1.Margin = new System.Windows.Forms.Padding(4);
            this.flKat1.Name = "flKat1";
            this.flKat1.Size = new System.Drawing.Size(568, 583);
            this.flKat1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flKat4);
            this.groupBox1.Controls.Add(this.flKat1);
            this.groupBox1.Location = new System.Drawing.Point(31, 32);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(635, 700);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Otelin Genel Durumu";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mskTc);
            this.groupBox2.Controls.Add(this.mskTelNo);
            this.groupBox2.Controls.Add(this.mskDogumDate);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lstRezervasyonBilgileri);
            this.groupBox2.Controls.Add(this.btnAraToplam);
            this.groupBox2.Controls.Add(this.lblGunlukUcretGoster);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.nupKisiSayisi);
            this.groupBox2.Controls.Add(this.dtmpCikis);
            this.groupBox2.Controls.Add(this.dtmpGiris);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnGec);
            this.groupBox2.Controls.Add(this.btnEkle);
            this.groupBox2.Controls.Add(this.txtAdSoyad);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(729, 32);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(601, 668);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Müşteri Bilgileri";
            // 
            // mskTc
            // 
            this.mskTc.Location = new System.Drawing.Point(235, 100);
            this.mskTc.Mask = "00000000000";
            this.mskTc.Name = "mskTc";
            this.mskTc.Size = new System.Drawing.Size(264, 22);
            this.mskTc.TabIndex = 14;
            this.mskTc.ValidatingType = typeof(int);
            // 
            // mskTelNo
            // 
            this.mskTelNo.Location = new System.Drawing.Point(235, 128);
            this.mskTelNo.Mask = "(999) 000-0000";
            this.mskTelNo.Name = "mskTelNo";
            this.mskTelNo.Size = new System.Drawing.Size(267, 22);
            this.mskTelNo.TabIndex = 13;
            // 
            // mskDogumDate
            // 
            this.mskDogumDate.Location = new System.Drawing.Point(235, 66);
            this.mskDogumDate.Mask = "00/00/0000";
            this.mskDogumDate.Name = "mskDogumDate";
            this.mskDogumDate.Size = new System.Drawing.Size(267, 22);
            this.mskDogumDate.TabIndex = 12;
            this.mskDogumDate.ValidatingType = typeof(System.DateTime);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 518);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "Rezervasyon Bilgileri";
            // 
            // lstRezervasyonBilgileri
            // 
            this.lstRezervasyonBilgileri.FormattingEnabled = true;
            this.lstRezervasyonBilgileri.ItemHeight = 16;
            this.lstRezervasyonBilgileri.Location = new System.Drawing.Point(21, 558);
            this.lstRezervasyonBilgileri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstRezervasyonBilgileri.Name = "lstRezervasyonBilgileri";
            this.lstRezervasyonBilgileri.Size = new System.Drawing.Size(559, 84);
            this.lstRezervasyonBilgileri.TabIndex = 10;
            // 
            // btnAraToplam
            // 
            this.btnAraToplam.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAraToplam.Location = new System.Drawing.Point(263, 298);
            this.btnAraToplam.Margin = new System.Windows.Forms.Padding(4);
            this.btnAraToplam.Name = "btnAraToplam";
            this.btnAraToplam.Size = new System.Drawing.Size(100, 28);
            this.btnAraToplam.TabIndex = 9;
            this.btnAraToplam.Text = "=";
            this.btnAraToplam.UseVisualStyleBackColor = true;
            this.btnAraToplam.Click += new System.EventHandler(this.btnAraToplam_Click);
            // 
            // lblGunlukUcretGoster
            // 
            this.lblGunlukUcretGoster.AutoSize = true;
            this.lblGunlukUcretGoster.Location = new System.Drawing.Point(455, 304);
            this.lblGunlukUcretGoster.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGunlukUcretGoster.Name = "lblGunlukUcretGoster";
            this.lblGunlukUcretGoster.Size = new System.Drawing.Size(0, 16);
            this.lblGunlukUcretGoster.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(120, 304);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 18);
            this.label8.TabIndex = 8;
            this.label8.Text = "Günlük Ücret";
            // 
            // nupKisiSayisi
            // 
            this.nupKisiSayisi.Location = new System.Drawing.Point(235, 247);
            this.nupKisiSayisi.Margin = new System.Windows.Forms.Padding(4);
            this.nupKisiSayisi.Name = "nupKisiSayisi";
            this.nupKisiSayisi.Size = new System.Drawing.Size(267, 22);
            this.nupKisiSayisi.TabIndex = 6;
            this.nupKisiSayisi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dtmpCikis
            // 
            this.dtmpCikis.Location = new System.Drawing.Point(235, 204);
            this.dtmpCikis.Margin = new System.Windows.Forms.Padding(4);
            this.dtmpCikis.Name = "dtmpCikis";
            this.dtmpCikis.Size = new System.Drawing.Size(265, 22);
            this.dtmpCikis.TabIndex = 5;
            // 
            // dtmpGiris
            // 
            this.dtmpGiris.Location = new System.Drawing.Point(235, 165);
            this.dtmpGiris.Margin = new System.Windows.Forms.Padding(4);
            this.dtmpGiris.Name = "dtmpGiris";
            this.dtmpGiris.Size = new System.Drawing.Size(265, 22);
            this.dtmpGiris.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(125, 250);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 18);
            this.label7.TabIndex = 3;
            this.label7.Text = "Kişi Sayısı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(88, 212);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tahmini Çıkış Tarihi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(125, 172);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Giriş Tarihi";
            // 
            // btnGec
            // 
            this.btnGec.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGec.Location = new System.Drawing.Point(321, 368);
            this.btnGec.Margin = new System.Windows.Forms.Padding(4);
            this.btnGec.Name = "btnGec";
            this.btnGec.Size = new System.Drawing.Size(224, 36);
            this.btnGec.TabIndex = 2;
            this.btnGec.Text = "Geç";
            this.btnGec.UseVisualStyleBackColor = true;
            this.btnGec.Click += new System.EventHandler(this.btnGec_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(60, 368);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(224, 36);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Rezarvasyonu Tamamla";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(235, 27);
            this.txtAdSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(265, 22);
            this.txtAdSoyad.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(125, 132);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Telefon No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(128, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "TC Kimlik";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(125, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Doğum Tarihi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(125, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.button1.Location = new System.Drawing.Point(55, 738);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 48);
            this.button1.TabIndex = 3;
            this.button1.Text = "Müsait Oda";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.Location = new System.Drawing.Point(435, 738);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 48);
            this.button2.TabIndex = 4;
            this.button2.Text = "Dolu Oda";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // FrmRezervasyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 798);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmRezervasyon";
            this.Text = "Rezervasyon";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupKisiSayisi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flKat4;
        private System.Windows.Forms.FlowLayoutPanel flKat1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtmpCikis;
        private System.Windows.Forms.DateTimePicker dtmpGiris;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGec;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nupKisiSayisi;
        private System.Windows.Forms.Button btnAraToplam;
        private System.Windows.Forms.Label lblGunlukUcretGoster;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lstRezervasyonBilgileri;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox mskTelNo;
        private System.Windows.Forms.MaskedTextBox mskDogumDate;
        private System.Windows.Forms.MaskedTextBox mskTc;
    }
}


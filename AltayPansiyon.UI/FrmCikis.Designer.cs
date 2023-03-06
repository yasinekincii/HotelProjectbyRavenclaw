namespace AltayPansiyon.UI
{
    partial class FrmCikis
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
            this.flEkstra = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTC = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpGercekCikis = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnToplamFiyat = new System.Windows.Forms.Button();
            this.lblToplamFiyat = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnRaporGoruntule = new System.Windows.Forms.Button();
            this.lstFaturaList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // flEkstra
            // 
            this.flEkstra.Location = new System.Drawing.Point(51, 149);
            this.flEkstra.Margin = new System.Windows.Forms.Padding(4);
            this.flEkstra.Name = "flEkstra";
            this.flEkstra.Size = new System.Drawing.Size(416, 151);
            this.flEkstra.TabIndex = 0;
            
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tc Numarası";
            // 
            // cmbTC
            // 
            this.cmbTC.FormattingEnabled = true;
            this.cmbTC.Location = new System.Drawing.Point(200, 30);
            this.cmbTC.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTC.Name = "cmbTC";
            this.cmbTC.Size = new System.Drawing.Size(265, 24);
            this.cmbTC.TabIndex = 2;
            this.cmbTC.SelectedIndexChanged += new System.EventHandler(this.cmbTC_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gerçek Çıkış Tarihi";
            // 
            // dtpGercekCikis
            // 
            this.dtpGercekCikis.Location = new System.Drawing.Point(200, 91);
            this.dtpGercekCikis.Margin = new System.Windows.Forms.Padding(4);
            this.dtpGercekCikis.Name = "dtpGercekCikis";
            this.dtpGercekCikis.Size = new System.Drawing.Size(265, 22);
            this.dtpGercekCikis.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 340);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Toplam Fiyat";
            // 
            // btnToplamFiyat
            // 
            this.btnToplamFiyat.Location = new System.Drawing.Point(213, 334);
            this.btnToplamFiyat.Margin = new System.Windows.Forms.Padding(4);
            this.btnToplamFiyat.Name = "btnToplamFiyat";
            this.btnToplamFiyat.Size = new System.Drawing.Size(100, 28);
            this.btnToplamFiyat.TabIndex = 4;
            this.btnToplamFiyat.Text = "=";
            this.btnToplamFiyat.UseVisualStyleBackColor = true;
            this.btnToplamFiyat.Click += new System.EventHandler(this.btnToplamFiyat_Click);
            // 
            // lblToplamFiyat
            // 
            this.lblToplamFiyat.AutoSize = true;
            this.lblToplamFiyat.Location = new System.Drawing.Point(340, 340);
            this.lblToplamFiyat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToplamFiyat.Name = "lblToplamFiyat";
            this.lblToplamFiyat.Size = new System.Drawing.Size(43, 16);
            this.lblToplamFiyat.TabIndex = 1;
            this.lblToplamFiyat.Text = "---------";
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(51, 398);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(4);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(416, 33);
            this.btnCikis.TabIndex = 5;
            this.btnCikis.Text = "Çıkış Yap";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnRaporGoruntule
            // 
            this.btnRaporGoruntule.Location = new System.Drawing.Point(51, 438);
            this.btnRaporGoruntule.Margin = new System.Windows.Forms.Padding(4);
            this.btnRaporGoruntule.Name = "btnRaporGoruntule";
            this.btnRaporGoruntule.Size = new System.Drawing.Size(416, 33);
            this.btnRaporGoruntule.TabIndex = 5;
            this.btnRaporGoruntule.Text = "Raporu Görüntüle";
            this.btnRaporGoruntule.UseVisualStyleBackColor = true;
            this.btnRaporGoruntule.Click += new System.EventHandler(this.btnRaporGoruntule_Click);
            // 
            // lstFaturaList
            // 
            this.lstFaturaList.FormattingEnabled = true;
            this.lstFaturaList.ItemHeight = 16;
            this.lstFaturaList.Location = new System.Drawing.Point(571, 100);
            this.lstFaturaList.Name = "lstFaturaList";
            this.lstFaturaList.Size = new System.Drawing.Size(456, 308);
            this.lstFaturaList.TabIndex = 6;
            // 
            // FrmCikis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 554);
            this.Controls.Add(this.lstFaturaList);
            this.Controls.Add(this.btnRaporGoruntule);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnToplamFiyat);
            this.Controls.Add(this.dtpGercekCikis);
            this.Controls.Add(this.cmbTC);
            this.Controls.Add(this.lblToplamFiyat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flEkstra);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCikis";
            this.Text = "Müşteri Çıkış";
            this.Load += new System.EventHandler(this.FrmCikis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flEkstra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpGercekCikis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnToplamFiyat;
        private System.Windows.Forms.Label lblToplamFiyat;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnRaporGoruntule;
        private System.Windows.Forms.ListBox lstFaturaList;
    }
}
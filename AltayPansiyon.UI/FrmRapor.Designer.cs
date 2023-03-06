namespace AltayPansiyon.UI
{
    partial class FrmRapor
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
            this.lstMusteriDokumu = new System.Windows.Forms.ListBox();
            this.Satis = new System.Windows.Forms.Label();
            this.cmbTc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblToplamCiro = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstMusteriDokumu
            // 
            this.lstMusteriDokumu.FormattingEnabled = true;
            this.lstMusteriDokumu.ItemHeight = 16;
            this.lstMusteriDokumu.Location = new System.Drawing.Point(113, 159);
            this.lstMusteriDokumu.Name = "lstMusteriDokumu";
            this.lstMusteriDokumu.Size = new System.Drawing.Size(526, 84);
            this.lstMusteriDokumu.TabIndex = 0;
            // 
            // Satis
            // 
            this.Satis.AutoSize = true;
            this.Satis.Location = new System.Drawing.Point(110, 130);
            this.Satis.Name = "Satis";
            this.Satis.Size = new System.Drawing.Size(103, 16);
            this.Satis.TabIndex = 1;
            this.Satis.Text = "Müşteri Dökümü";
            // 
            // cmbTc
            // 
            this.cmbTc.FormattingEnabled = true;
            this.cmbTc.Location = new System.Drawing.Point(295, 70);
            this.cmbTc.Name = "cmbTc";
            this.cmbTc.Size = new System.Drawing.Size(121, 24);
            this.cmbTc.TabIndex = 2;
            this.cmbTc.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "İlgili müşterinin Tc sini Giriniz";
            // 
            // lblToplamCiro
            // 
            this.lblToplamCiro.AutoSize = true;
            this.lblToplamCiro.Location = new System.Drawing.Point(219, 316);
            this.lblToplamCiro.Name = "lblToplamCiro";
            this.lblToplamCiro.Size = new System.Drawing.Size(0, 16);
            this.lblToplamCiro.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Toplam Ciro =";
            // 
            // FrmRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblToplamCiro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTc);
            this.Controls.Add(this.Satis);
            this.Controls.Add(this.lstMusteriDokumu);
            this.Name = "FrmRapor";
            this.Text = "Rapor";
            this.Load += new System.EventHandler(this.FrmRapor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstMusteriDokumu;
        private System.Windows.Forms.Label Satis;
        private System.Windows.Forms.ComboBox cmbTc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblToplamCiro;
        private System.Windows.Forms.Label label3;
    }
}
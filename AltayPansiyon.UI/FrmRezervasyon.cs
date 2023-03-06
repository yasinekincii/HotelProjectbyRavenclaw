using AltayPansiyon.UI.Comman;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using CheckFramework;


namespace AltayPansiyon.UI
{
    public partial class FrmRezervasyon : Form
    {
        List<OdaRezarvasyon> rezarvasyonlar = new List<OdaRezarvasyon>();
        Button tiklanilanButton = null;

        public FrmRezervasyon()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            Button btnKral = new Button();
            btnKral.Text = "Kral Dairesi";
            btnKral.BackColor = Color.Yellow;
            btnKral.Width = 370;
            btnKral.Height = 50;
            btnKral.Tag = new Oda()
            {
                GunlukFiyat = 500,
                OdaDurumu = OdaDurumu.Bos,
                KatNo = 4,
                YatakSayisi = 5
            };

            btnKral.Click += btn_Click;

            flKat4.Controls.Add(btnKral);

            OdaBilgileri(100, 110, 50, 1, 1);
            OdaBilgileri(200, 210, 100, 2, 2);
            OdaBilgileri(300, 310, 150, 3, 3);



            btnEkle.Enabled = false;
            btnAraToplam.Enabled = false;

        }
        private void OdaBilgileri(int ilkOdaNo, int sonOdaNo, double fiyat, sbyte katNo, byte yatakSayisi)
        {


            int sayac = ilkOdaNo;
            for (int i = ilkOdaNo; i < sonOdaNo; i++)
            {
                Button btn = new Button();
                btn.Text = (++sayac).ToString();
                btn.BackColor = Color.Yellow;
                btn.Width = 70;
                btn.Height = 70;
                btn.Tag = new Oda()
                {
                    GunlukFiyat = fiyat,
                    OdaNumarasi = int.Parse(btn.Text),
                    OdaDurumu = OdaDurumu.Bos,
                    KatNo = katNo,
                    YatakSayisi = yatakSayisi

                };


                btn.Click += btn_Click;
                flKat1.Controls.Add(btn);

            }
        }
        
        private void btn_Click(object sender, EventArgs e)
        {
            tiklanilanButton = sender as Button;
            btnEkle.Enabled = true;
            btnAraToplam.Enabled = true;

            


        }

        private void btnEkle_Click(object sender, EventArgs e)
        {


            int kisiSayisi = int.Parse(nupKisiSayisi.Text);

            lstRezervasyonBilgileri.Items.Clear();

            
            Oda oda1 = tiklanilanButton.Tag as Oda;

            
            if ((kisiSayisi <= oda1.YatakSayisi) && (kisiSayisi != 0)
                && CheckFramework.Validation.Validation1(txtAdSoyad.Text, mskDogumDate.Text, mskTc.Text, mskTelNo.Text))
            {

                if (oda1.OdaDurumu == OdaDurumu.Bos)
                {

                    oda1.OdaDurumu = OdaDurumu.Dolu;
                    tiklanilanButton.BackColor = Color.Red;

                    rezarvasyonlar.Add(new OdaRezarvasyon()
                    {
                        OdaBilgileri = oda1,
                        MusteriBilgileri = new Musteri()
                        {
                            AdSoyad = txtAdSoyad.Text,
                            DogumTarihi = mskDogumDate.Text,
                            TC = mskTc.Text,
                            TelefonNo = mskTelNo.Text
                        },

                        GirisTarihi = dtmpGiris.Value,
                        TahminiCikisTarihi = dtmpCikis.Value
                        
                    });

                    foreach (OdaRezarvasyon oda in rezarvasyonlar)
                    {
                        if (mskTc.Text == oda.MusteriBilgileri.TC)
                        {
                            lstRezervasyonBilgileri.Items.Add(oda);
                            FormuTemizle();
                        }

                    }


                }
                else
                {
                    MessageBox.Show("Oda Dolu.");
                }



            }
            else
            {
                MessageBox.Show("Lütfen değerleri eksiksiz ve tam giriniz.(Oda seçmeyi unutmayın).");
            }



        }

        private void btnAraToplam_Click(object sender, EventArgs e)
        {
            Oda rezarvasyon1 = tiklanilanButton.Tag as Oda;
            lblGunlukUcretGoster.Text = rezarvasyon1.GunlukFiyat.ToString();
        }

        private void btnGec_Click(object sender, EventArgs e)
        {
            if (rezarvasyonlar.Count == 0)
            {
                MessageBox.Show("Rezervasyon oluşturmadan diğer forma geçiş yapamazsınız.");
            }
            else
            {
                FrmCikis frmCikis = new FrmCikis(rezarvasyonlar);
                frmCikis.Show();
                this.Hide();

            }
        }

        private void FormuTemizle()
        {
            txtAdSoyad.Text = mskDogumDate.Text = mskTc.Text = mskTelNo.Text = string.Empty;
            
        }
    }
}

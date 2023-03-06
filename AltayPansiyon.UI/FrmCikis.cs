using AltayPansiyon.UI.Comman;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AltayPansiyon.UI
{
    public partial class FrmCikis : Form
    {
        private List<OdaRezarvasyon> rezarvasyonlar;
        private List<Hizmet> hizmetler = new List<Hizmet>();
        


        public FrmCikis()
        {
            InitializeComponent();
        }
        

        public FrmCikis(List<OdaRezarvasyon> rezarvasyonlar):this()
        {
            
            this.rezarvasyonlar = rezarvasyonlar;
            
        }

       
        private void FrmCikis_Load(object sender, EventArgs e)
        {
            btnCikis.Enabled = false;
            btnToplamFiyat.Enabled = false;
            foreach (OdaRezarvasyon odaRezarvasyonTc in rezarvasyonlar)
            {
                cmbTC.Items.Add(odaRezarvasyonTc.MusteriBilgileri.TC);
            }
            MiniDolapDoldur();

        }

        private void MiniDolapDoldur()
        {
            

            List<Malzeme> malzemeler = new List<Malzeme>()
            {
                new Malzeme ()
                {
                    MalzemeAdi = "Tablerone",
                    MalzemeFiyat = 10
                }, new Malzeme()
                {
                    MalzemeAdi = "Su",
                    MalzemeFiyat = 5
                }, new Malzeme()
                {
                    MalzemeAdi = "Soda", 
                    MalzemeFiyat = 20
                }, new Malzeme()
                {
                    MalzemeAdi = "Tekila", 
                    MalzemeFiyat = 100
                }, new Malzeme()
                {
                    MalzemeAdi = "Viski", 
                    MalzemeFiyat = 150
                }


            };

            foreach (Malzeme item in malzemeler)
            {

                CheckBox checkBox = new CheckBox();
                checkBox.Text = item.MalzemeAdi+" "+ item.MalzemeFiyat+"TL";
                checkBox.Tag= item;
                flEkstra.Controls.Add(checkBox);

            }
            
        }

        private void btnToplamFiyat_Click(object sender, EventArgs e)
        {
            List<Malzeme> secilenMalzemeListesi1 = new List<Malzeme>();
            foreach (CheckBox item in flEkstra.Controls)
            {
                if (item.Checked)
                {
                    secilenMalzemeListesi1.Add((Malzeme)item.Tag);                  
                }
            }

            double malzemelerinToplamFiyati = secilenMalzemeListesi1.Sum(item => item.MalzemeFiyat);


            foreach (OdaRezarvasyon item in rezarvasyonlar)
            {
                if (cmbTC.SelectedItem == item.MusteriBilgileri.TC)
                {
                    Hizmet hizmet = new Hizmet()
                    {
                        MusteriTc= cmbTC.SelectedItem.ToString(),
                        GercekCikisTarihi = dtpGercekCikis.Value,
                        malzeme = secilenMalzemeListesi1

                    };
                    
                    hizmet.TopFiyat(item.GirisTarihi, item.OdaBilgileri.GunlukFiyat, malzemelerinToplamFiyati);
                    lblToplamFiyat.Text = hizmet.ToString();
                    
                }
                
            }
            
            btnCikis.Enabled = true;
            
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            List<Malzeme> secilenMalzemeListesi = new List<Malzeme>();
            foreach (CheckBox item in flEkstra.Controls)
            {
                if (item.Checked)
                {
                    secilenMalzemeListesi.Add((Malzeme)item.Tag);
                }
            }
            double secilenMalzemelerinToplamFiyati = secilenMalzemeListesi.Sum(item => item.MalzemeFiyat);


            foreach (OdaRezarvasyon item in rezarvasyonlar)
            {
                if (cmbTC.SelectedItem == item.MusteriBilgileri.TC)
                {
                    Hizmet hizmet = new Hizmet()
                    {
                        MusteriTc = cmbTC.SelectedItem.ToString(),
                        GercekCikisTarihi = dtpGercekCikis.Value,
                        malzeme = secilenMalzemeListesi,

                    };
                    hizmetler.Add(hizmet);
                    hizmet.TopFiyat(item.GirisTarihi, item.OdaBilgileri.GunlukFiyat, secilenMalzemelerinToplamFiyati);
                    FormuTemizle();



                }


            }

            cmbTC.Items.Remove(cmbTC.SelectedItem);

            
            MessageBox.Show("Ödemeniz Başarılı bir şekilde tanımlanmıştır.");
            lstFaturaList.Items.Clear();
            foreach (Hizmet item in hizmetler)
            {
                lstFaturaList.Items.Add(item.MusteriTc + " Tc Numaralı Müşterinin ödeme miktarı " + item.ToplamFiyat);
            }

        }

        private void btnRaporGoruntule_Click(object sender, EventArgs e)
        {
            if (hizmetler.Count == 0)
            {
                MessageBox.Show("Hesap ödeme işlemi bitmeden raporlamaya geçemezsiniz.");
            }
            else
            {
                FrmRapor frmRapor1 = new FrmRapor(hizmetler);
                frmRapor1.Show();
                this.Hide();

            }
        }

        private void cmbTC_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnToplamFiyat.Enabled = true;
            
        }
        private void FormuTemizle()
        {

            dtpGercekCikis.Value=DateTime.Now;
            cmbTC.SelectedIndex = 0;


            foreach (CheckBox checkBox in flEkstra.Controls)
            {
                checkBox.Checked = false;

            }
        } 

    }
}

using AltayPansiyon.UI.Comman;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AltayPansiyon.UI
{
    public partial class FrmRapor : Form
    {
        private List<Hizmet> hizmetler;
        
        public FrmRapor()
        {
            InitializeComponent();
        }

        public FrmRapor(List<Hizmet> hizmetler):this()
        {
            this.hizmetler = hizmetler;
        }


        private void FrmRapor_Load(object sender, EventArgs e)
        {
            // Hizmetler listesindeki bütün TC numaralarını cmbTC combobox'ına ekliyoruz.
            foreach (Hizmet secilenMusteriTc in hizmetler)
            {
               
                cmbTc.Items.Add(secilenMusteriTc.MusteriTc);

            }

            //Otelin bütün cirosu lblToplamCiro labelına yazdırılır.
            lblToplamCiro.Text =  (hizmetler.Sum(a=>a.ToplamFiyat)).ToString();

            //Hizmetler dökümü lstMusteriDokumu listbox'ında görüntülenir
            foreach (Hizmet item in hizmetler)
            {
                lstMusteriDokumu.Items.Add(item.MusteriTc + " Tc Numaralı Müşterinin ödeme miktarı " + item.ToplamFiyat);                
            }
        }

        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Comboboxda seçilen Tc'nin hizmet dökümü listelenir.
            lstMusteriDokumu.Items.Clear();
            foreach (Hizmet item in hizmetler)
            {
                if (cmbTc.SelectedItem.ToString() == item.MusteriTc)
                {
                    lstMusteriDokumu.Items.Add(item.MusteriTc + " Tc Numaralı Müşterinin ödeme miktarı " + item.ToplamFiyat);
                }
            }
        }
    }
}

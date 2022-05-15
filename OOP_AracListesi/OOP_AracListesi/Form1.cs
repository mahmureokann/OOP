using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_AracListesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Araba araba = new Araba();
        ListViewItem lvi = new ListViewItem();
        void Vites()
        {
            //ComboBox
            cmbVites.Items.Add("Otomatik");
            cmbVites.Items.Add("Manuel");
        }
        void Yakit()
        {
            cmbYakit.Items.Add("Benzin");
            cmbYakit.Items.Add("Dizel");
            cmbYakit.Items.Add("Lpg");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Vites();
            Yakit();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            try
            {
                araba.marka = txtMarka.Text;
                araba.model = txtModel.Text;
                araba.uretimYil = Convert.ToInt32(txtUretimYil.Text);
                araba.sase = Convert.ToInt32(txtSase.Text);
                araba.motorGuc = Convert.ToInt32(txtMotorGuc.Text);
                araba.jantBoyut = Convert.ToInt32(txtJant.Text);
                araba.renk = txtRenk.Text;
                araba.kasaTip = txtKasaTip.Text;
                araba.Fiyat = nudFiyat.Value;
                araba.yakitTip = cmbYakit.Text;
                araba.vites = cmbVites.Text;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            lvi.Text = araba.marka;
            lvi.SubItems.Add(araba.model);
            lvi.SubItems.Add(araba.uretimYil.ToString());
            lvi.SubItems.Add(araba.sase.ToString());
            lvi.SubItems.Add(araba.motorGuc.ToString());
            lvi.SubItems.Add(araba.jantBoyut.ToString());
            lvi.SubItems.Add(araba.renk);
            lvi.SubItems.Add(araba.kasaTip);
            lvi.SubItems.Add(araba.Fiyat.ToString("C2"));
            lvi.SubItems.Add(araba.KDVDahilFiyat.ToString());

            listView1.Items.Add(lvi);


            
            
            

           


            
        }
    }

}

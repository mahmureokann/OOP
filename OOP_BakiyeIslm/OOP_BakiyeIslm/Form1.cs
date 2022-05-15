using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_BakiyeIslm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int yatirilacakTutar = 0;
        int cekilecekTutar = 0;
        decimal guncelBakiye = 500;
        BakiyeIslemi bakiyeIslemi = new BakiyeIslemi();
        
        


        private void btnParaCek_Click(object sender, EventArgs e)
        {
            cekilecekTutar = Convert.ToInt32(nudParaCek.Value);
            bakiyeIslemi.cekilenTutar = cekilecekTutar;
            
            

            if (cekilecekTutar<=guncelBakiye)
            {
                guncelBakiye -= cekilecekTutar;
                lblBakiye.Text = (guncelBakiye).ToString("C2");
            }
            else if (cekilecekTutar > guncelBakiye)
            {
                MessageBox.Show("Bakiyeniz yetersiz!");
            }
            

            string format = string.Format($"Çekilecek Tutar: {bakiyeIslemi.cekilenTutar} , Güncel Bakiye: {guncelBakiye}");
            listBox1.Items.Add(format);
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblBakiye.Text = guncelBakiye.ToString("C2"); 
        }

        private void btnParaYatir_Click(object sender, EventArgs e)
        {
            yatirilacakTutar = Convert.ToInt32(nudParaYatir.Value);
            bakiyeIslemi.YatirilanTutar = yatirilacakTutar;

            if (yatirilacakTutar>=0)
            {
                guncelBakiye += yatirilacakTutar;
                lblBakiye.Text = guncelBakiye.ToString("C2");
            }
            string format = string.Format($"Yatırılacak Tutar: {bakiyeIslemi.YatirilanTutar}, Güncel Bakiye: {guncelBakiye}");
            listBox1.Items.Add(format);

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Şifreleme_Programı
{
    public partial class Şifre_Çözme : Form
    {
        Encryption sifreleme;
        public Şifre_Çözme()
        {
            InitializeComponent();
            sifreleme = new Encryption();
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sifreleme.pSifre = txtBox_amac.Text;
            txtBox_Hedef.Text = sifreleme.SifreCozme(cmBox_tur.SelectedIndex, (int)nmr_Key.Value, (int)nmr_Key2.Value, txtBox_key1.Text, txtBox_key2.Text);
        }

        private void cmBox_tur_SelectedIndexChanged(object sender, EventArgs e)
        {
            nmr_Key.Visible = false;
            label4.Visible = false;
            nmr_Key2.Visible = false;
            lbl_key2.Visible = false;
            txtBox_key1.Visible = false;
            txtBox_key2.Visible = false;

            switch (cmBox_tur.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                case 4:
                case 6:
                case 7:
                    nmr_Key.Visible = true;
                    label4.Visible = true;
                    break;
                case 2:
                case 5:
                    nmr_Key.Visible = true;
                    label4.Visible = true;
                    nmr_Key2.Visible = true;
                    lbl_key2.Visible = true;
                    break;
                case 3:
                case 8:
                    txtBox_key1.Visible = true;
                    label4.Visible = true;
                    break;
                case 9:
                    txtBox_key1.Visible = true;
                    label4.Visible = true;
                    txtBox_key2.Visible = true;
                    lbl_key2.Visible = true;
                    break;
                case 10:
                    label4.Visible = true;
                    txtBox_key1.Visible = true;
                    break;
            }
        }

        private void nmr_Key2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string okunanMetin = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string secilenDosyaYolu = openFileDialog1.FileName; // seçtiğimiz txt nin dosya yolunu alıyoruz

                string[] tumSatirlar = File.ReadAllLines(secilenDosyaYolu); //txt nin tüm satırlarını okuyoruz


                foreach (string satir in tumSatirlar)
                {
                    // Güvenlik: Eğer satır boş değilse (sadece Enter'a basılıp geçilmemişse)
                    if (!string.IsNullOrWhiteSpace(satir))
                    {
                        okunanMetin += satir;
                    }
                }
            }
            txtBox_amac.Text = okunanMetin;
        }

        private void Şifre_Çözme_Load(object sender, EventArgs e)
        {
            nmr_Key.Visible = false;
            label4.Visible = false;
            nmr_Key2.Visible = false;
            lbl_key2.Visible = false;
            txtBox_key1.Visible = false;
            txtBox_key2.Visible = false;

        }

        private void nmr_Key_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

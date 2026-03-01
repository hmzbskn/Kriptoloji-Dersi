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
            txtBox_Hedef.Text = sifreleme.SifreCozme(cmBox_tur.SelectedIndex, (int)nmr_Key.Value, (int)nmr_Key2.Value, txtBox_key1.Text);
        }

        private void cmBox_tur_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmBox_tur.SelectedIndex == 0)
            {
                nmr_Key.Visible = false;
                label4.Visible = false;
                nmr_Key2.Visible = false;
                lbl_key2.Visible = false;
            }
            if (cmBox_tur.SelectedIndex == 1 || cmBox_tur.SelectedIndex == 4 || cmBox_tur.SelectedIndex == 6 || cmBox_tur.SelectedIndex == 7)
            {
                nmr_Key2.Visible = false;
                lbl_key2.Visible = false;
                txtBox_key1.Visible = false;

            }
            if (cmBox_tur.SelectedIndex == 2 || cmBox_tur.SelectedIndex == 5)
            {
                nmr_Key.Visible = true;
                label4.Visible = true;
                nmr_Key2.Visible = true;
                lbl_key2.Visible = true;
                txtBox_key1.Visible = false;
            }

            if (cmBox_tur.SelectedIndex == 3)
            {
                nmr_Key.Visible = false;
                label4.Visible = true;
                nmr_Key2.Visible = false;
                lbl_key2.Visible = false;
                txtBox_key1.Visible = true;
            }

            if (cmBox_tur.SelectedIndex == 1 || cmBox_tur.SelectedIndex == 4 || cmBox_tur.SelectedIndex == 6 || cmBox_tur.SelectedIndex == 7 || cmBox_tur.SelectedIndex == 2 || cmBox_tur.SelectedIndex == 5)
            {
                nmr_Key.Visible = true;
                label4.Visible = true;
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



                /*0-6 . satır arasını metadata olarak kullandığımız için almıyoruz
                daha ileri seviyede otomatik kendi kendine algoritmayı anlayıp çözmesi için kodlar yazılabilir*/
                for (int i = 6; i < tumSatirlar.Length; i++)
                {
                    if (tumSatirlar[i].Contains("*")) // mesaj bitiş karakteri olarak son satırı * karakteri ile doldurduk
                    {
                        break;
                    }

                    //Yıldız yoksa, satırı okunanMetin değişkenine uç uca ekle
                    okunanMetin += tumSatirlar[i];
                }
            }
            txtBox_amac.Text = okunanMetin;
        }

        private void Şifre_Çözme_Load(object sender, EventArgs e)
        {
            nmr_Key2.Visible = false;
            lbl_key2.Visible = false;
            nmr_Key.Visible = false;
            label4.Visible = false;
            txtBox_key1.Visible = false;
        }

        private void nmr_Key_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

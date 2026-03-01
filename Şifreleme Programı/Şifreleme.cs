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
using System.Net;
using System.Net.Mail;

namespace Şifreleme_Programı
{
    public partial class Şifreleme : Form
    {
        Encryption sifreleme;
        public Şifreleme()
        {
            InitializeComponent();
            sifreleme = new Encryption();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sifreleme.pSifre = txtbox_amacMetin.Text;
            
            txtbox_sonucMetin.Text = sifreleme.Sifreleme(cmb_Tur.SelectedIndex ,(int)num_key.Value, (int)num_key2.Value , txtBox_key1.Text);

            btn_EpostaGonder.Enabled = true;
        }

        private void Şifreleme_Load(object sender, EventArgs e)
        {
            num_key2.Visible = false;
            lbl_Anahtar2.Visible = false;
            btn_EpostaGonder.Enabled = false;
            num_key.Visible = false;
            label4.Visible = false;
            txtBox_key1.Visible = false;
        }

        private void cmb_Tur_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmb_Tur.SelectedIndex == 0)
            {
                num_key.Visible = false;
                label4.Visible = false;
                num_key2.Visible = false;
                lbl_Anahtar2.Visible = false;
            }
            if (cmb_Tur.SelectedIndex == 1 || cmb_Tur.SelectedIndex == 4 || cmb_Tur.SelectedIndex == 6 || cmb_Tur.SelectedIndex == 7)
            {
                num_key2.Visible = false;
                lbl_Anahtar2.Visible = false;
                txtBox_key1.Visible = false;

            }
            if (cmb_Tur.SelectedIndex == 2 || cmb_Tur.SelectedIndex == 5 )
            {
                num_key.Visible = true;
                label4.Visible = true;
                num_key2.Visible = true;
                lbl_Anahtar2.Visible = true;
                txtBox_key1.Visible = false;
            }

            if (cmb_Tur.SelectedIndex == 3)
            {
                num_key.Visible = false;
                label4.Visible = true;
                num_key2.Visible = false;
                lbl_Anahtar2.Visible = false;
                txtBox_key1.Visible = true;
            }

            if (cmb_Tur.SelectedIndex == 1 || cmb_Tur.SelectedIndex == 4 || cmb_Tur.SelectedIndex == 6 || cmb_Tur.SelectedIndex == 7 || cmb_Tur.SelectedIndex == 2 || cmb_Tur.SelectedIndex == 5)
            {
                num_key.Visible = true;
                label4.Visible = true;
            }

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
            txtbox_amacMetin.Text = okunanMetin;
        }

        private void btn_EpostaGonder_Click(object sender, EventArgs e)
        {
            // Ekranda seçilen/yazılan verileri alıyoruz
            string algoritma = cmb_Tur.Text;
            string anahtar = num_key.Value.ToString();
            string anahtar2 = num_key2.Value.ToString();
            string sifreliMetin = txtbox_sonucMetin.Text;

            // Eğer şifrelenmiş metin yoksa boşuna e-posta ekranını açmasın
            if (string.IsNullOrWhiteSpace(sifreliMetin))
            {
                MessageBox.Show("Lütfen önce bir metin şifreleyin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tam istediğin formattaki mesaj şablonunu oluşturuyoruz (\n bir alt satıra geçer)
            string gonderilecekMesaj = $"Merhaba, Aşağıdaki şifreli metin sana gönderilmiştir.\n" +
                                       $"─────────────────────────────────\n" +
                                       $"Algoritma  : {algoritma}\n"  +
                                       $"Key1  : {anahtar}, Key2 : {anahtar2}\n " +
                                       $"─────────────────────────────────\n" +
                                       $"Şifreli Metin:\n" +
                                       $"{sifreliMetin}\n" +
                                       $"*********************************************";

            // 2. Adımda oluşturacağımız giriş ekranını (FrmEposta) çağırıp mesajı içine yolluyoruz
            E_Posta_Giriş_Ekranı epostaEkrani = new E_Posta_Giriş_Ekranı(gonderilecekMesaj);
            epostaEkrani.ShowDialog();
            btn_EpostaGonder.Enabled = false;
            button1.Enabled = false; 
        }
    }
}

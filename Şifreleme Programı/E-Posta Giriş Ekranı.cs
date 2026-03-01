using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Şifreleme_Programı
{
    public partial class E_Posta_Giriş_Ekranı : Form
    {
        string hazirMesaj;
        public E_Posta_Giriş_Ekranı(string mesaj)
        {
            InitializeComponent();
            hazirMesaj = mesaj;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Alanların boş olup olmadığını kontrol edelir
            if (string.IsNullOrWhiteSpace(txt_gonderen.Text) || string.IsNullOrWhiteSpace(txt_sifre.Text) || string.IsNullOrWhiteSpace(txt_alici.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Gönderim sırasında butonu pasifleştiriyoruz
                button1.Enabled = false;
                button1.Text = "Gönderiliyor...";

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(txt_gonderen.Text);
                mail.To.Add(txt_alici.Text);
                mail.Subject = "Şifreli Mesajınız Var";

                // E-postanın kendi metnine sadece kısa bir bilgilendirme yazıyoruz
                mail.Body = "Bu mesaj, " + txt_gonderen.Text + " tarafından şifreli olarak gönderilmiştir.";

                // Ana formdan gelen o şekilli şablonu (hazirMesaj) byte dizisine çeviriyoruz
                byte[] metinVerisi = Encoding.UTF8.GetBytes(hazirMesaj);

                // Bellekte anlık bir dosya oluşturuyoruz (PC'ye kaydetmeden)
                using (MemoryStream stream = new MemoryStream(metinVerisi))
                {
                    // Bellekteki bu veriyi "Sifreli_Ipucu.txt" adında bir e-posta ekine dönüştürüyoruz
                    Attachment dosyaEki = new Attachment(stream, "Sifreli-Mesaj.txt");
                    mail.Attachments.Add(dosyaEki);

                    // --- GÖNDERİM AYARLARI ---
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                    smtp.Port = 587;
                    smtp.Credentials = new NetworkCredential(txt_gonderen.Text, txt_sifre.Text);
                    smtp.EnableSsl = true;

                    // E-postayı gönderiyoruz
                    smtp.Send(mail);

                    MessageBox.Show("Belge başarıyla iletildi!", "İletim Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // İşlem bitince e-posta ekranını kapat
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mesaj gönderilemedi!\nDetay: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Hata olursa butonu tekrar aktif edilir
                button1.Enabled = true;
                button1.Text = "Gönder";
            }
        }

        private void E_Posta_Giriş_Ekranı_Load(object sender, EventArgs e)
        {

        }
    }
}

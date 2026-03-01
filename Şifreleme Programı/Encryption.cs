using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Şifreleme_Programı
{
    
    public class Encryption
    {
        private const int alfabeUzunlugu = 29;
        char[] kucukHarfler = {
            'a', 'b', 'c', 'ç', 'd', 'e', 'f', 'g', 'ğ', 'h', 'ı', 'i', 'j', 'k', 'l',
            'm', 'n', 'o', 'ö', 'p', 'r', 's', 'ş', 't', 'u', 'ü', 'v', 'y', 'z'
        };

        char[] buyukHarfler = {
            'A', 'B', 'C', 'Ç', 'D', 'E', 'F', 'G', 'Ğ', 'H', 'I', 'İ', 'J', 'K', 'L',
            'M', 'N', 'O', 'Ö', 'P', 'R', 'S', 'Ş', 'T', 'U', 'Ü', 'V', 'Y', 'Z'
        };

        char[] karıstırılmısHarfler = {
            'm', 'ç', 'y', 'ö', 'a', 'h', 'ş', 'v', 'd', 'k', 'p', 'ı', 'e', 'g', 'u',
            'j', 'b', 'ü', 'r', 'f', 'z', 't', 'n', 'c', 'ğ', 's', 'o', 'i', 'l'
        };


        private string sifre;
        public string sonucMetin = ""; // temizlenmiş metindir şifrelenmiş değil şifrelenmiş metin direkt return ediliyor

        public string pSifre
        {
            set { sifre = value; }
        }

        private void metinTemizleme()
        {
            harfKucultme();
            alfabedeOlmayanTemizleme();
            
        }
        private void harfKucultme()
        {
            sonucMetin = ""; 
            for (int i = 0; i < sifre.Length; i++)
            {
                char mevcutKarakter = sifre[i];
                bool alfabedeVarMi = false;


                for (int j = 0; j < kucukHarfler.Length; j++)
                {
                    if (mevcutKarakter == kucukHarfler[j] || mevcutKarakter == buyukHarfler[j])
                    {
                        alfabedeVarMi = true;
                        break;
                    }
                }

                if (alfabedeVarMi)
                {
                    sonucMetin += mevcutKarakter;
                }
            }
        }
        private void alfabedeOlmayanTemizleme()
        {
            string geciciMetin = "";
            for (int i = 0; i < sonucMetin.Length; i++)
            {
                char c = sonucMetin[i];
                bool donusturuldu = false;

                for (int j = 0; j < buyukHarfler.Length; j++)
                {
                    if (c == buyukHarfler[j])
                    {
                        geciciMetin += kucukHarfler[j]; // Büyükse küçüğünü ekle
                        donusturuldu = true;
                        break;
                    }
                }

                if (!donusturuldu)
                {
                    geciciMetin += c; 
                }
            }
            sonucMetin = geciciMetin;


        }

        public string Sifreleme(int tur, int key1 = 0 , int key2 = 0, string sKey1 = "") 
        {

            metinTemizleme();
            switch (tur)
            {
                case 0:
                    return Sezar_Sifreleme(); // Tamam
                case 1:
                    return KaydırmalıAlgoritma_Sifreleme(key1); // tamam
                case 2:
                    return Doğrusal_Sifreleme(key1,key2); // tamam
                case 3:
                    return YerDegistirme_Sifreleme(sKey1); // tamam
                case 4:
                    return SayiAnahtarli_Sifreleme(key1);
                case 5:
                    return Permutasyon_Sifreleme(key1, key2); // tamam
                case 6:
                    return Rota_Sifreleme(key1); 
                case 7:
                    return ZigZag_Sifreleme(key1); // tamam
                default:
                    MessageBox.Show("Algoritma seçilemedi");
                    return null;
                    
            }
        }
        private string Sezar_Sifreleme()
        {
            char[] metinDizisi = sonucMetin.ToCharArray();
            string temp = "";
            for (int i = 0; i < metinDizisi.Length; i++)
            {
                for (int j = 0; j < kucukHarfler.Length; j++)
                {
                    if (metinDizisi[i] == kucukHarfler[j])
                    {
                        temp += kucukHarfler[(j + 3) % 29];
                    }
                }
            }
            return temp;
        }
        private string KaydırmalıAlgoritma_Sifreleme(int key)
        {
            char[] metinDizisi = sonucMetin.ToCharArray();
            string temp = "";
            for (int i = 0; i < metinDizisi.Length; i++)
            {
                for (int j = 0; j < kucukHarfler.Length; j++)
                {
                    if (metinDizisi[i] == kucukHarfler[j])
                    {
                        temp += kucukHarfler[(j + key) % 29];
                    }
                }
            }
            return temp;
        }
        private string Doğrusal_Sifreleme(int key1, int key2)
        {
            char[] metinDizisi = sonucMetin.ToCharArray();
            string temp = "";

            for (int i = 0; i < metinDizisi.Length; i++)
            {
                for (int j = 0; j < kucukHarfler.Length; j++)
                {
                    if (metinDizisi[i] == kucukHarfler[j])
                    {
                        temp += kucukHarfler[(j * key1 + key2) % 29];
                    }
                }
            }
            return temp;
        }
        private string YerDegistirme_Sifreleme(string sKey1)
        {

            char[] metinDizisi = sKey1.Trim().ToCharArray();
            string temp = "";

            for (int i = 0; i < sonucMetin.Length; i++)
            {
                for (int j = 0; j < kucukHarfler.Length; j++)
                {
                    if (metinDizisi[i] == kucukHarfler[j])
                    {
                        temp += karıstırılmısHarfler[j];
                    }
                }
            }
            return temp;
        }
        
        private string SayiAnahtarli_Sifreleme(int key1)
        {
            // Hata kontrolü
            if (key1 <= 1 || sonucMetin.Length == 0)
                return sonucMetin;

            int k = key1; // Sütun sayısı (Tahtadaki k)
            int l = sonucMetin.Length; // Metin uzunluğu (Tahtadaki l)

            // Satır sayısını yukarı yuvarlayarak buluyoruz (Tahtadaki tavan fonksiyonu)
            int satirSayisi = (int)Math.Ceiling((double)l / k);

            // HOCANIN YÖNTEMİ (PADDING): Eksik kalan hücreleri 'r' ile dolduruyoruz
            string doldurulmusMetin = sonucMetin;
            int eksikKarakterSayisi = (satirSayisi * k) - l;
            for (int i = 0; i < eksikKarakterSayisi; i++)
            {
                doldurulmusMetin += 'r'; // Tahtada boşluklara 'r' eklendiği için bunu kullanıyoruz
            }

            char[,] matris = new char[satirSayisi, k];
            int index = 0;

            // 1. ADIM: Matrisi satır satır (soldan sağa) yazarak dolduruyoruz
            for (int i = 0; i < satirSayisi; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    matris[i, j] = doldurulmusMetin[index];
                    index++;
                }
            }

            // 2. ADIM: Matrisi sütun sütun (yukarıdan aşağıya) okuyoruz
            string sifreliMetin = "";
            for (int j = 0; j < k; j++)
            {
                for (int i = 0; i < satirSayisi; i++)
                {
                    sifreliMetin += matris[i, j];
                }
            }

            return sifreliMetin;

        }
        private string Permutasyon_Sifreleme(int key1, int key2)
        {
            // "sifre" yerine "sonucMetin" kullanıldı
            char[,] sifreC = new char[sonucMetin.Length % key1 == 0 ? sonucMetin.Length / key1 : sonucMetin.Length / key1 + 1, key1];
            Random rndSayi = new Random();
            char rndChar = kucukHarfler[rndSayi.Next(0, 29)];

            for (int i = 0; i < sifreC.GetLength(0); i++)
            {
                for (int j = 0; j < sifreC.GetLength(1); j++)
                {
                    // "sifre" yerine "sonucMetin" kullanıldı
                    if (i * key1 + j < sonucMetin.Length)
                        sifreC[i, j] = sonucMetin[i * key1 + j];
                    else
                        sifreC[i, j] = 'r';

                    Console.Write(sifreC[i, j]);
                }
                Console.WriteLine(" ");
            }

            int[] key2Dizisi = new int[key1];
            for (int i = 0; i < key2Dizisi.Length; i++)
            {
                key2Dizisi[i] = key2 % 10;
                key2 /= 10;
            }
            key2Dizisi = key2Dizisi.Reverse().ToArray();

            char[,] karisikSifre = new char[sifreC.GetLength(0), sifreC.GetLength(1)];

            for (int i = 0; i < sifreC.GetLength(0); i++)
            {
                for (int j = 0; j < key2Dizisi.Length; j++)
                {
                    karisikSifre[i, j] = sifreC[i, key2Dizisi[j] - 1];
                }
            }

            string sifreli = "";
            for (int i = 0; i < karisikSifre.GetLength(0); i++)
            {
                for (int j = 0; j < karisikSifre.GetLength(1); j++)
                {
                    sifreli += karisikSifre[i, j];
                }
            }
            return sifreli;
        }
        private string Rota_Sifreleme(int key1)
        {
            // Hata kontrolü: Sütun sayısı 1 veya daha azsa, ya da metin yoksa işlem yapma
            if (key1 <= 1 || sonucMetin.Length == 0)
                return sonucMetin;

            int sutunSayisi = key1;
            // Toplam satır sayısını yukarı yuvarlayarak buluyoruz
            int satirSayisi = (int)Math.Ceiling((double)sonucMetin.Length / sutunSayisi);
            char[,] matris = new char[satirSayisi, sutunSayisi];

            int index = 0;

            // 1. ADIM: Temizlenmiş metni matrise satır satır dolduruyoruz
            for (int i = 0; i < satirSayisi; i++)
            {
                for (int j = 0; j < sutunSayisi; j++)
                {
                    if (index < sonucMetin.Length)
                    {
                        matris[i, j] = sonucMetin[index];
                        index++;
                    }
                }
            }

            // 2. ADIM: Matrisi sütun sütun (yukarıdan aşağıya) okuyoruz
            string temp = "";
            for (int j = 0; j < sutunSayisi; j++)
            {
                for (int i = 0; i < satirSayisi; i++)
                {
                    // Hücre boş değilse karaktere ekle (Eksik kalan son satır hücrelerini atlamak için)
                    if (matris[i, j] != '\0')
                    {
                        temp += matris[i, j];
                    }
                }
            }
            return temp;

        }
        private string ZigZag_Sifreleme(int key1)
        {
            string hedef = "";

            // 1. Matrisi oluştur: Satır sayısı = anahtar, Sütun sayısı = metin uzunluğu
            char[,] sifreC = new char[key1, sonucMetin.Length];

            int row = 0;
            int col = 0;
            bool asagiIniyor = false; // Yönümüzü takip edeceğimiz bayrak değişkeni

            // 2. Metni matrise Zigzag (Rail Fence) kuralına göre yerleştirme
            for (int i = 0; i < sonucMetin.Length; i++)
            {
                // En üst satıra (0) veya en alt satıra (key1 - 1) ulaştığımızda yön değiştir
                if (row == 0 || row == key1 - 1)
                {
                    asagiIniyor = !asagiIniyor;
                }

                sifreC[row, col] = sonucMetin[i];
                col++;

                if (asagiIniyor)
                {
                    row++;
                }

                else
                {
                    row--;
                }
            }
            for (int i = 0; i < key1; i++)
            {
                for (int j = 0; j < sonucMetin.Length; j++)
                {
                    if (sifreC[i, j] != '\0')
                    {
                        hedef += sifreC[i, j];
                    }
                }
            }
            return hedef;
        }
        public string SifreCozme(int tur, int key1 = 0, int key2 = 0, string sKey1 = "") // anahtar için opsiyonel parametre yap
        {

            metinTemizleme();
            switch (tur)
            {
                case 0:
                    return Sezar_SifreCozme();
                case 1:
                    return Kaydırmalı_SifreCozme(key1);
                case 2:
                    return Doğrusal_SifreCozme(key1, key2);
                case 3:
                    return YerDegistirme_SifreCozme(sKey1);
                case 4:
                    return SayiAnahtarli_SifreCozme(key1);
                case 5:
                    return Permutasyon_SifreCozme(key1 , key2);
                case 6:
                    return Rota_SifreCozme(key1);
                case 7:
                    return ZigZag_SifreCozme(key1);
                default:
                    MessageBox.Show("Algoritma seçilemedi");
                    return null;

            }
        }

        private string ZigZag_SifreCozme(int key1)
        {
            char[,] matrix = new char[key1, sonucMetin.Length];

            int row = 0;
            int col = 0;
            bool asagiIniyor = false;

            // Şifreli metnin uzunluğu kadar zikzak çizip harflerin geleceği yerleri '*' ile işaretliyoruz
            for (int i = 0; i < sonucMetin.Length; i++)
            {
                if (row == 0)
                    asagiIniyor = true; // En üste çarpınca aşağı inmeye başla
                if (row == key1 - 1)
                    asagiIniyor = false; // En alta çarpınca yukarı çıkmaya başla

                matrix[row, col] = '*'; // Harfin yerleşeceği koordinatı işaretle
                col++;

                if (asagiIniyor)
                    row++;
                else
                    row--;
            }

            // 2. ADIM: İşaretli yerleri, elimizdeki şifreli metnin harfleriyle doldur (Satır Satır)
            int index = 0; // Şifreli metindeki harfleri sırayla almak için sayaç
            for (int i = 0; i < key1; i++)
            {
                for (int j = 0; j < sonucMetin.Length; j++)
                {
                    // Eğer hücre '*' ile işaretlenmişse, sıradaki harfi oraya koy
                    if (matrix[i, j] == '*' && index < sonucMetin.Length)
                    {
                        matrix[i, j] = sonucMetin[index];
                        index++;
                    }
                }
            }

            // 3. ADIM: Doldurulmuş matrisi zikzak çizerek okuma (Açık Metni Elde Etme)
            string cozulmusMetin = "";

            // Rotayı tekrar sıfırlıyoruz
            row = 0;
            col = 0;
            asagiIniyor = false;

            for (int i = 0; i < sifre.Length; i++)
            {
                if (row == 0)
                    asagiIniyor = true;
                if (row == key1 - 1)
                    asagiIniyor = false;

                // Üzerinden geçtiğimiz harfi sonuca ekliyoruz
                cozulmusMetin += matrix[row, col];
                col++;

                if (asagiIniyor)
                    row++;
                else
                    row--;
            }
            return cozulmusMetin;
        }

        private string Rota_SifreCozme(int key1)
        {
            if (key1 <= 1 || sonucMetin.Length == 0)
                return sonucMetin;

            int sutunSayisi = key1;
            int satirSayisi = (int)Math.Ceiling((double)sonucMetin.Length / sutunSayisi);

            // Matrisin son satırında tam dolu olan sütun sayısını buluyoruz
            int tamDoluSutunSayisi = sonucMetin.Length % sutunSayisi;
            if (tamDoluSutunSayisi == 0)
                tamDoluSutunSayisi = sutunSayisi; // Tam bölünüyorsa hepsi doludur

            char[,] matris = new char[satirSayisi, sutunSayisi];
            int index = 0;

            // 1. ADIM: Şifreli metni matrise sütun sütun yerleştiriyoruz
            for (int j = 0; j < sutunSayisi; j++)
            {
                // Eğer bulunduğumuz sütun, eksik kalan son hücrelere denk geliyorsa 1 satır az okutuyoruz
                int buSutundakiSatirSayisi = (j < tamDoluSutunSayisi) ? satirSayisi : satirSayisi - 1;

                for (int i = 0; i < buSutundakiSatirSayisi; i++)
                {
                    if (index < sonucMetin.Length)
                    {
                        matris[i, j] = sonucMetin[index];
                        index++;
                    }
                }
            }

            // 2. ADIM: Orijinal metni elde etmek için matrisi satır satır okuyoruz
            string temp = "";
            for (int i = 0; i < satirSayisi; i++)
            {
                for (int j = 0; j < sutunSayisi; j++)
                {
                    if (matris[i, j] != '\0')
                    {
                        temp += matris[i, j];
                    }
                }
            }
            return temp;
        }

        private string Permutasyon_SifreCozme(int key1, int key2)
        {
            char[,] sifreC = new char[sonucMetin.Length % key1 == 0 ? sonucMetin.Length / key1 : sonucMetin.Length / key1 + 1, key1];
            Random rndSayi = new Random();
            char rndChar = kucukHarfler[rndSayi.Next(0, 29)];
            for (int i = 0; i < sifreC.GetLength(0); i++)
            {
                for (int j = 0; j < sifreC.GetLength(1); j++)
                {
                    if (i * key1 + j < sonucMetin.Length)
                        sifreC[i, j] = sonucMetin[i * key1 + j];
                    else
                        sifreC[i, j] = 'r'; //burada random sayı ürettik fakat bunun çözme ekibiyle koordineli yapmamız gerekiyor
                    Console.Write(sifreC[i, j]);
                }
                Console.WriteLine(" ");
            }

            int[] key2Dizisi = new int[key1];
            for (int i = 0; i < key2Dizisi.Length; i++)
            {
                key2Dizisi[i] = key2 % 10;
                key2 /= 10;
            }
            key2Dizisi = key2Dizisi.Reverse().ToArray(); // gelen sayı gibi sıralamak için tesine çevirdik

            char[,] karisikSifre = new char[sifreC.GetLength(0), sifreC.GetLength(1)];

            for (int i = 0; i < sifreC.GetLength(0); i++)
            {
                for (int j = 0; j < key2Dizisi.Length; j++)
                {
                    karisikSifre[i, j] = sifreC[i, key2Dizisi[j] - 1];
                }
            }
            string sifreli = "";
            for (int i = 0; i < karisikSifre.GetLength(0); i++)
            {
                for (int j = 0; j < karisikSifre.GetLength(1); j++)
                {
                    sifreli += karisikSifre[i, j];
                }
            }
            return sifreli;
        }

        private string SayiAnahtarli_SifreCozme(int key1)
        {
            if (key1 <= 1 || sonucMetin.Length == 0)
                return sonucMetin;

            int k = key1;
            // Şifrelerken matrisi tam doldurduğumuz için, uzunluk sütun sayısına tam bölünür
            int satirSayisi = sonucMetin.Length / k;

            char[,] matris = new char[satirSayisi, k];
            int index = 0;

            // 1. ADIM: Şifreli metni matrise sütun sütun (yukarıdan aşağıya) yerleştiriyoruz
            for (int j = 0; j < k; j++)
            {
                for (int i = 0; i < satirSayisi; i++)
                {
                    if (index < sonucMetin.Length)
                    {
                        matris[i, j] = sonucMetin[index];
                        index++;
                    }
                }
            }

            // 2. ADIM: Orijinal metni elde etmek için matrisi satır satır (soldan sağa) okuyoruz
            string cozulmusMetin = "";
            for (int i = 0; i < satirSayisi; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    cozulmusMetin += matris[i, j];
                }
            }

            // 3. ADIM: Şifrelerken matrisi tamamlamak için eklediğimiz 'r' harflerini sondan siliyoruz
            return cozulmusMetin.TrimEnd('r');
        }

        private string YerDegistirme_SifreCozme(string sKey1)
        {
            char[] metinDizisi = sKey1.Trim().ToCharArray();
            string temp = "";

            for (int i = 0; i < sonucMetin.Length; i++)
            {
                for (int j = 0; j < metinDizisi.Length; j++)
                {
                    if (sonucMetin[i] == metinDizisi[j])
                    {
                        temp += kucukHarfler[j];
                    }
                }
            }
            return temp;
        }

        private string Doğrusal_SifreCozme(int key1 , int key2)
        {
            int key1_tersi  = 0;
            int yeniIndis;
            int fark;
            char[] metinDizisi = sonucMetin.ToCharArray();
            string temp = "";

            for (int x = 1; x < alfabeUzunlugu; x++)
            {
                if ((key1 * x) % alfabeUzunlugu == 1)
                {
                    key1_tersi = x; 
                    break;
                }
            }
            for (int i = 0; i < metinDizisi.Length; i++)
            {
                for (int j = 0; j < kucukHarfler.Length; j++)
                {
                    if (metinDizisi[i] == kucukHarfler[j])
                    {
                        fark = ((j - key2) % alfabeUzunlugu + alfabeUzunlugu) % alfabeUzunlugu;
                        yeniIndis = (fark * key1_tersi) % alfabeUzunlugu;

                        temp += kucukHarfler[yeniIndis];
                        break;
                    }
                }
            }
            return temp;
        }

        private string Kaydırmalı_SifreCozme(int key)
        {
            int indis = 0;
            char[] metinDizisi = sonucMetin.ToCharArray();
            string temp = "";
            for (int i = 0; i < metinDizisi.Length; i++)
            {
                for (int j = 0; j < kucukHarfler.Length; j++)
                {
                    if (metinDizisi[i] == kucukHarfler[j])
                    {
                        indis = ((j - key) % alfabeUzunlugu + alfabeUzunlugu) % alfabeUzunlugu;
                        temp += kucukHarfler[indis];
                        break;
                    }
                }
            }
            return temp;
        }

        private string Sezar_SifreCozme()
        {
            int indis;
            char[] metinDizisi = sonucMetin.ToCharArray();
            string temp = "";
            for (int i = 0; i < metinDizisi.Length; i++)
            {
                for (int j = 0; j < kucukHarfler.Length; j++)
                {
                    if (metinDizisi[i] == kucukHarfler[j])
                    {
                        indis = ((j - 3) % alfabeUzunlugu + alfabeUzunlugu) % alfabeUzunlugu;
                        temp += kucukHarfler[indis];
                        break;
                    }
                }
            }
            return temp;
        }
    }
}

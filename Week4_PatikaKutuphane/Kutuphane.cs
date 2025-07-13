using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_PatikaKutuphane
{
    public class Kutuphane
    {

        // Property'leri tanımlayalım.

        public string Ad { get; set; }
        public string YazarAdı { get; set; }
        public int SayfaSayisi { get; set; }
        public string Yayinevi { get; set; }
        public DateTime KayitTarihi { get; set; }

        public Kutuphane()      // Default Constructor
        {
            KayitTarihi =DateTime.Now;
        }

       
        
        public Kutuphane(string ad, string yazarAdi, int sayfaSayisi, string yayinEvi)
        {
            Ad = ad;                // ÖNEMLİ NOT: CONSTRUCTOR İÇİNDE FİELD DEĞİL PROPERTY KULLAN !!!
            YazarAdı = yazarAdi;
            SayfaSayisi = sayfaSayisi;
            Yayinevi = yayinEvi;
            KayitTarihi =DateTime.Now;
        }
        public void Yazdir()        // Konsola yazdırmak için metot tanımladık.
        {
            Console.WriteLine($"Bu kitabın Adı: {Ad} Yazarı: {YazarAdı} Sayfa sayisi: {SayfaSayisi} Yayinevi: {Yayinevi} Kayıt Tarihi: {KayitTarihi.ToShortDateString()}");
        }
    }
}

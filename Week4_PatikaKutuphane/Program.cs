using Week4_PatikaKutuphane;

//Parametreli Constructor için;
Kutuphane Kitap1 = new Kutuphane("Adı Aylin", "Ayşe Kulin", 398,"Remzi Kitabevi");

//Default Constructor için;
Kutuphane Kitap2 = new Kutuphane();
Kitap2.Ad = "Adı Aylin";
Kitap2.YazarAdı = "Ayşe Kulin";
Kitap2.SayfaSayisi = 398;
Kitap2.Yayinevi = "Remzi Kitabevi";



Console.WriteLine("Parametreli Constructor ile oluşturulan kitap:");
Kitap1.Yazdir();
Console.WriteLine("Default Constructor ile oluşturulan kitap:");
Kitap2.Yazdir();

// Kodlarınızın altına birer yorum satırıyla örnek üzerinden Class , Property , New , Constructor kavramlarını açıklayınız.

// Class --> "Kutuphane" adında bir sınıf tanımlıyoruz.
// Sınıf (Class), bir nesnenin şablonudur. Kitap nesnelerinin özelliklerini ve davranışlarını tanımlar.

// Property: Her biri Kitap nesnesine ait bir özelliği tanımlar. Bizim örnekte; Ad, YazarAdı, SayfaSayisi gibi..
// Property'ler veri saklar ve dışarıdan erişimi sağlar

// new: "Kutuphane" sınıfından bir nesne (örnek) oluşturuyoruz.
// "new" anahtar kelimesi, bellekte yeni bir Kitap1 nesnesi yaratır.

// Constructor (Yapıcı Metot): Nesne oluşturulurken çalışır. Parametreli ve parametresiz (default) türleri vardır.

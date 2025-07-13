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
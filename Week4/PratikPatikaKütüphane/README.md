Pratik - Patika Kütüphane
Patika Kütüphanesi için bir kitap kayıt uygulaması oluşturmak istiyoruz. Bu nedenle bu aşamada kitap nesneleri oluşturmamız gerekiyor.

Ad, Yazar Adı, Yazar Soyadı, Sayfa Sayısı, Yayınevi, Kayit Tarihi bilgileri ile kitaplar kaydetmek istiyoruz.


Örnek olarak

Ayşe Kulin'in 398 sayfalık, Remzi Kitabevi yayınevinden çıkan Adı Aylin kitabını oluşturunuz.

2 Adet constructor alternatifi olsun.

Bir tanesi default constructor tarzında parmetre almadan çalışan bir metot.

Diğeri Kitap adı, Yazar Adı, Sayfa Sayısı, Yayınevi  bilgilerini alıp bu değerleri nesne üretim aşamasında atayan bir metot.

KayıtTarihi nesne oluşturulunca otomatik olarak o an olarak atansın. (Her iki constructor için de geçerli)

Kodlarınızın altına birer yorum satırıyla örnek üzerinden Class , Property , New , Constructor kavramlarını açıklayınız.
___

Class (Sınıf): Kitap sınıfı, kitapla ilgili bilgileri ve işlemleri barındırır ve kitap nesnelerinin bir şablonunu oluşturur.

Property (Özellik): Ad, YazarAd, YazarSoyad, SayfaSayisi, Yayinevi, KayitTarihi gibi özellikler, her kitap nesnesinin bilgilerini tutar.

New: new anahtar kelimesi, Kitap sınıfından yeni bir nesne oluşturur. Örneğin, Kitap kitap1 = new Kitap("Bir Kitap", "Ahmet", "Yılmaz", 320, "Alfa Yayınları"); ifadesi Kitap sınıfından bir nesne oluşturur.

Constructor: Kitap sınıfında iki adet constructor bulunur:

Default Constructor: Parametre almayan ve KayitTarihini o anki tarih olarak atayan yapıcı metot.
Parametreli Constructor: Kitap adı, yazar adı, yazar soyadı, sayfa sayısı ve yayınevi bilgilerini alarak bu değerleri ilgili özelliklere atar ve KayitTarihi olarak o anki zamanı atar.
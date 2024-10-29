
using PropertyAciklama;

Calısan kaldirimci = new Calısan();
kaldirimci.Ad = "Aykan";
kaldirimci.Yas = 34;

Calısan tirSoforu = new(); // new den sonra Calısan() yazmadan yazılabılır.
tirSoforu.Ad = "Hamit";
tirSoforu.Yas = -33; // fiedls oldugu için clas a mudahale erişim public acık. get set yok. get set ile denetim ayarlanabılır.

kaldirimci.KunyeYazdır();
tirSoforu.KunyeYazdır();

Console.ReadLine();

/* 
   Problem : Yukarıda gözlemlediğimiz üzere, bir field olan yas uyesi public ile dısarıya acıldıgından sınıfı kullanan kişi doğrudan istediği değeri akatarabilir. Bu da istenmeyen değerlerin kolaylıkla atanmasını mumkun kılıyor.
*/
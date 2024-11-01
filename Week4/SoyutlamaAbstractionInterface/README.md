## Soyutlama (Abstraction) - Interface
Abstraction (soyutlama) kavramını basit bir interface (arayüz) örneğiyle açıklayalım. Interface'ler, soyutlama kavramını uygulamanın etkili bir yoludur çünkü sadece bir nesnenin nasıl davranması gerektiğini tanımlar ve iç detayları gizler.

Örneğimizde bir IShape (Şekil) interface'i kullanarak şekillerin alanını hesaplayan sınıfları temsil edelim:
 
 Bu örnekte:

IShape interface'i, CalculateArea() adında bir soyut (abstract) metot tanımlar. Bu metot, şekillerin alanını hesaplamak için kullanılır.

Circle ve Square sınıfları, IShape interface'ini uygular ve CalculateArea() metotunu kendi ihtiyaçlarına göre implement eder.

Main metodu içinde, IShape türünde değişkenler (sekil1 ve sekil2) oluşturulmuş ve bu değişkenler hem Circle hem de Square nesnelerini alabilmektedir. Bu, abstraction kavramını gösterir çünkü Main metodu, her bir şekilin alanını hesaplamak için sadece CalculateArea() metodunu çağırabilir ve şeklin nasıl hesaplandığını bilmek zorunda değildir.

Bu örnekte, interface kullanarak soyutlama kavramı sağlanmış oldu. IShape interface'i, farklı şekillerin (Circle, Square gibi) ortak bir arayüz sağlaması ve bu şekillerin detaylarını gizlemesi sayesinde kodun daha modüler ve genişletilebilir olmasını sağlar.
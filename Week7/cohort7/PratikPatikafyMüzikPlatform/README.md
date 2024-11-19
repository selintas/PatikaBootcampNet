## Pratik - Patikafy Müzik Platformu - Week 7 


![uWPkFJp-Patikafy](https://github.com/user-attachments/assets/4ad2233a-9a15-40c5-bc45-4081ef2487fa)

Yukarıda 11 sanatçımız için bir veri tablosu verilmiştir. Tablodaki her bir satır bir nesneye karşılık gelecek şekilde bu nesnelerden oluşan bir liste tanımlayınız. Ardından bu liste üzerinden aşığıdaki sorguları gerçekleştiriniz.

Adı 'S' ile başlayan şarkıcılar

Albüm satışları 10 milyon'un üzerinde olan şarkıcılar

2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcılar. ( Çıkış yıllarına göre gruplayarak, alfabetik bir sıra ile yazdırınız.

En çok albüm satan şarkıcı

En yeni çıkış yapan şarkıcı ve en eski çıkış yapan şarkıcı



# Sınıf Tanımı:

Singer sınıfı, her sanatçıyı temsil eder. 

Bu sınıf; isim (Name), müzik türü (MusicGenre), çıkış yılı (DebutYear) ve albüm satışları (AlbumSales) özelliklerine sahiptir.

# LINQ Sorguları:

1. Adı 'S' ile başlayan şarkıcılar: StartsWith("S") metodu ile filtreleme yapılır.

2. Albüm satışları 10 milyon'un üzerinde olanlar: Where(s => s.AlbumSales > 10) ile albüm satışları kontrol edilir.
    
3. 2000 yılı öncesi pop müzik yapanlar: Çıkış yılı ve müzik türü için filtre uygulanır, OrderBy ve ThenBy ile sıralanır.
 
4. En çok albüm satan şarkıcı: OrderByDescending ile albüm satışlarına göre sıralama yapılır ve ilk öğe alınır.
   
5. En yeni ve en eski çıkış yapanlar: OrderBy ve OrderByDescending ile sıralama yapılır.
   

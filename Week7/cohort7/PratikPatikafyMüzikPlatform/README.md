## Pratik - Patikafy Müzik Platformu - Week 7

# Sınıf Tanımı:

Singer sınıfı, her sanatçıyı temsil eder. 

Bu sınıf; isim (Name), müzik türü (MusicGenre), çıkış yılı (DebutYear) ve albüm satışları (AlbumSales) özelliklerine sahiptir.

# LINQ Sorguları:

1. Adı 'S' ile başlayan şarkıcılar: StartsWith("S") metodu ile filtreleme yapılır.

2. Albüm satışları 10 milyon'un üzerinde olanlar: Where(s => s.AlbumSales > 10) ile albüm satışları kontrol edilir.
    
3. 2000 yılı öncesi pop müzik yapanlar: Çıkış yılı ve müzik türü için filtre uygulanır, OrderBy ve ThenBy ile sıralanır.
 
4. En çok albüm satan şarkıcı: OrderByDescending ile albüm satışlarına göre sıralama yapılır ve ilk öğe alınır.
   
5. En yeni ve en eski çıkış yapanlar: OrderBy ve OrderByDescending ile sıralama yapılır.
   

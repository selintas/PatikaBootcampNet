# SQL Ödevleri 9, 10, 11

Bu proje, SQL kullanarak çeşitli sorgular ve tablo ilişkileri üzerinde çalıştığım ödev dosyalarını içermektedir. Projede, veritabanı tabloları arasında ilişkiler kurarak `JOIN` işlemleri gerçekleştirdim, veri kümesi üzerinde filtreleme ve sıralama yaptım.

## İçerik

- **odev9.sql**: 
  - `INNER JOIN`, `LEFT JOIN`, `RIGHT JOIN` ve `FULL JOIN` gibi farklı `JOIN` türlerini kullanarak tabloları birleştirme sorguları içerir.
  - `city` ve `country` tablolarında `INNER JOIN` ile şehir ve ülke isimlerinin birlikte gösterilmesi.
  - `customer` ve `payment` tablolarında `RIGHT JOIN` kullanılarak ödeme ve müşteri isimlerinin eşleştirilmesi.
  - `customer` ve `rental` tablolarında `FULL JOIN` ile kiralama ve müşteri isimlerinin eksiksiz gösterilmesi.

- **odev10.sql**:
  - Veritabanı tablolarında belirli koşulları sağlayan kayıtları bulma ve güncelleme sorguları içerir.
  - Belirli müşteri veya aktör bilgilerinin güncellenmesi ve veri manipülasyonu için `UPDATE` ve `DELETE` işlemlerini içerir.
  - Ayrıca belirli şartları sağlayan kayıtların sayısını veya toplamını elde etmek için `COUNT` ve `SUM` gibi toplama fonksiyonlarının kullanımı.

- **odev11.sql**:
  - `actor` ve `customer` tablolarındaki `first_name` sütunları üzerinde farklı sorgular içerir.
  - Tüm `first_name` değerlerini birleştirip sıralama, yalnızca kesişen isimleri bulma ve bir tabloda olup diğerinde olmayan isimleri listeleme.
  - Tekrar eden verilerin gösterilmesi veya hariç tutulması için `UNION`, `INTERSECT`, `EXCEPT` ve `UNION ALL` gibi SQL komutlarının kullanımı.

## Kullanılan SQL Komutları

- **JOIN İşlemleri**: `INNER JOIN`, `LEFT JOIN`, `RIGHT JOIN`, `FULL JOIN` kullanarak tablolar arası ilişki kurulması.
- **Veri Güncelleme ve Silme**: `UPDATE` ve `DELETE` komutlarıyla veritabanındaki kayıtların düzenlenmesi.
- **Set Operatörleri**: `UNION`, `INTERSECT`, `EXCEPT` ile veri kümeleri üzerinde işlem yapılması.
- **Toplama Fonksiyonları**: `COUNT`, `SUM` ile belirli şartlara göre kayıtların toplam veya sayısının bulunması.
- **ORDER BY**: Sonuçların sıralanması için kullanıldı.
  
Bu projede temel SQL komutları, tablolar arası ilişki kurma işlemleri, veri güncelleme ve manipülasyon işlemleri uygulanmıştır. Veritabanı yapısına göre müşteri, aktör, kiralama ve ödeme bilgileri üzerinde çeşitli sorgular gerçekleştirilmiştir.

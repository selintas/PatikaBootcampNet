# SQL Ödevleri 9 10 11

Bu proje, SQL kullanarak farklı sorgular üzerinde çalıştığım ödev dosyalarını içermektedir. Projede, veritabanı tabloları arasında ilişkiler kurarak `JOIN` işlemleri gerçekleştirdim ve farklı tablo sorgularını oluşturdum.

## İçerik

- **odev9.sql**: 
  - `INNER JOIN`, `LEFT JOIN`, `RIGHT JOIN` ve `FULL JOIN` gibi farklı `JOIN` türlerini kullanarak tabloları birleştirme sorguları içerir.
  - `city` ve `country` tablolarında `INNER JOIN` ile şehir ve ülke isimlerinin birlikte gösterilmesi.
  - `customer` ve `payment` tablolarında `RIGHT JOIN` kullanılarak ödeme ve müşteri isimlerinin eşleştirilmesi.
  - `customer` ve `rental` tablolarında `FULL JOIN` ile kiralama ve müşteri isimlerinin eksiksiz gösterilmesi.

- **odev11.sql**:
  - `actor` ve `customer` tablolarındaki `first_name` sütunları üzerinde farklı sorgular içerir.
  - Tüm `first_name` değerlerini birleştirip sıralama, yalnızca kesişen isimleri bulma ve bir tabloda olup diğerinde olmayan isimleri listeleme.
  - Tekrar eden verilerin gösterilmesi veya hariç tutulması için `UNION`, `INTERSECT`, `EXCEPT` ve `UNION ALL` gibi SQL komutlarının kullanımı.

## Kullanılan SQL Komutları

- **JOIN İşlemleri**: `INNER JOIN`, `LEFT JOIN`, `RIGHT JOIN`, `FULL JOIN` kullanarak tablolar arası ilişki kurulması.
- **Set Operatörleri**: `UNION`, `INTERSECT`, `EXCEPT` ile veri kümeleri üzerinde işlem yapılması.
- **ORDER BY**: Sonuçların sıralanması için kullanıldı.
  
Bu projede temel SQL komutları ve tablolar arası ilişki kurma işlemleri uygulanmıştır. Veritabanı yapısına göre müşteri, aktör, kiralama ve ödeme bilgileri üzerinde sorgular gerçekleştirilmiştir.

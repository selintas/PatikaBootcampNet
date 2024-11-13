# SQL JOIN Sorguları - Ödev 9

Bu proje, SQL veritabanında `INNER JOIN` kullanarak iki tablo arasındaki verileri birleştiren çeşitli sorguları içerir.

## Sorgular

### 1. `city` ve `country` tablolarında şehir (`city`) ve ülke (`country`) isimlerini birleştiren INNER JOIN

Bu sorgu, `city` tablosundaki şehir isimleri ile `country` tablosundaki ülke isimlerini `country_id` sütunu aracılığıyla birleştirir ve ilgili şehir-ülke eşleşmelerini görüntüler.

```sql
SELECT city.city_id, city.city, country.country, country.country_id 
FROM city
INNER JOIN country ON city.country_id = country.country_id;


Açıklama:

city.city_id: Şehir kimliği.
city.city: Şehrin ismi.
country.country: Ülkenin ismi.
country.country_id: Ülke kimliği.

2. customer ve payment tablolarında payment_id ile müşteri (customer) isimlerini birleştiren INNER JOIN
Bu sorgu, payment tablosundaki ödeme kimliği (payment_id) ile customer tablosundaki müşteri isimlerini (first_name, last_name) customer_id üzerinden birleştirir ve ilgili ödemelere ait müşteri bilgilerini görüntüler.

SELECT payment.payment_id, customer.first_name, customer.last_name, customer.customer_id 
FROM payment
INNER JOIN customer ON payment.customer_id = customer.customer_id;

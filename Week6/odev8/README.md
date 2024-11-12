odev 8 

1.test veritabanınızda employee isimli sütun bilgileri id(INTEGER), name VARCHAR(50), birthday DATE, email VARCHAR(100) olan bir tablo oluşturalım. 

2.Oluşturduğumuz employee tablosuna 'Mockaroo' servisini kullanarak 50 adet veri ekleyelim. 

3.Sütunların her birine göre diğer sütunları güncelleyecek 5 adet UPDATE işlemi yapalım. 

4.Sütunların her birine göre ilgili satırı silecek 5 adet DELETE işlemi yapalım.



![Screenshot (392)](https://github.com/user-attachments/assets/4cb2041b-cd7a-4de4-953f-c33e984e1502)

 --- 
## Ödev 8 - SQL Komutları ve İşlemleri
 
Bu ödev, SQL veritabanında employee tablosunu oluşturmaya, tablo üzerinde güncelleme (UPDATE), silme (DELETE) ve sorgulama işlemleri gerçekleştirmeye yönelik çeşitli komutları içermektedir.

İçindekiler
Tablo Oluşturma
Güncelleme İşlemleri
Silme İşlemleri
Örnek Sorgular
Tablo Oluşturma
Aşağıdaki komut, employee adlı tabloyu oluşturur. Bu tabloda çalışanların id, name, birthday ve email bilgileri saklanır:



CREATE TABLE employee (
    id SERIAL PRIMARY KEY,
    name VARCHAR(50),
    birthday DATE,
    email VARCHAR(100)
);
Güncelleme İşlemleri

Tablodaki belirli kayıtları id sütununa göre güncelleyebilmek için 5 örnek UPDATE sorgusu:


UPDATE employee
SET
    name = 'Ahmet',
    birthday = '1985-03-15',
    email = 'ahmetyildiz@gmail.com'
WHERE id = 2;

UPDATE employee
SET
    name = 'Elif',
    birthday = '1990-11-12',
    email = 'elifkara@gmail.com'
WHERE id = 3;

-- Diğer güncellemeler de benzer şekilde yapılmaktadır.
Silme İşlemleri
Aşağıdaki DELETE sorguları, employee tablosundaki belirli kayıtları silmek için kullanılmaktadır. Her sorgu farklı bir sütuna göre belirli koşulları sağlayan satırları siler:

sql

DELETE FROM employee WHERE id = 2;
DELETE FROM employee WHERE name = 'Elif';
DELETE FROM employee WHERE birthday = '1978-07-20';
DELETE FROM employee WHERE email = 'zeynepdemir@hotmail.com';
DELETE FROM employee WHERE birthday < '1990-01-01';
Örnek Sorgular
Tablodaki veriler üzerinde analiz yapmak ve bilgi almak için kullanılan bazı örnek sorgular:

rating sütununa göre gruplama ve film sayısı:

sql

SELECT rating, COUNT(*) AS film_count
FROM film
GROUP BY rating;
En fazla şehir sayısına sahip country_id bilgisi ve şehir sayısı:

sql

SELECT country_id, COUNT(*) AS city_count
FROM city
GROUP BY country_id
ORDER BY city_count DESC
LIMIT 1;
Notlar
SERIAL veri tipi, id sütununun otomatik olarak benzersiz değerlerle artmasını sağlar.

Veritabanı işlemlerinin doğru şekilde yapılabilmesi için her UPDATE ve DELETE sorgusu belirli bir koşula (WHERE ifadesine) sahiptir.

GROUP BY, ORDER BY, LIMIT, OFFSET gibi SQL ifadeleri verilerin analizinde önemlidir.

Bu ödev, SQL üzerinde tablo oluşturma, güncelleme, silme ve veri analizini öğrenmeye yönelik olarak hazırlanmıştır.







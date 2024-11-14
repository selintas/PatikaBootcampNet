odev 9
--1.city tablosu ile country tablosunda bulunan şehir (city) ve ülke (country) isimlerini birlikte görebileceğimiz INNER JOIN sorgusunu yazınız.
SELECT city.city_id, city.city, country.country, country.country_id FROM city
INNER JOIN country ON city.country_id = country.country_id;

--2.customer tablosu ile payment tablosunda bulunan payment_id ile customer tablosundaki first_name ve last_name isimlerini birlikte görebileceğimiz INNER JOIN sorgusunu yazınız.
SELECT payment.payment_id, customer.first_name, customer.last_name, customer.customer_id FROM payment
INNER JOIN customer ON payment.customer_id = customer.customer_id;

--3.customer tablosu ile rental tablosunda bulunan rental_id ile customer tablosundaki first_name ve last_name isimlerini birlikte görebileceğimiz INNER JOIN sorgusunu yazınız. 
SELECT rental.rental_id, customer.first_name, customer.last_name, customer.customer_id FROM rental
INNER JOIN customer ON rental.customer_id = customer.customer_id;

--isterlerden fazla olarak tüm id ler ile bilirlikte yazılmıstır.

odev 10

--1.city tablosu ile country tablosunda bulunan şehir (city) ve ülke (country) isimlerini birlikte görebileceğimiz LEFT JOIN sorgusunu yazınız.
SELECT city.city_id, city.city, country.country, country.country_id 
FROM city
LEFT JOIN country 
ON city.country_id = country.country_id; 

--2.customer tablosu ile payment tablosunda bulunan payment_id ile customer tablosundaki first_name ve last_name isimlerini birlikte görebileceğimiz RIGHT JOIN sorgusunu yazınız.
SELECT payment.payment_id, customer.first_name, customer.last_name, customer.customer_id 
FROM payment
RIGHT JOIN customer 
ON payment.customer_id = customer.customer_id;

 
--3.customer tablosu ile rental tablosunda bulunan rental_id ile customer tablosundaki first_name ve last_name isimlerini birlikte görebileceğimiz FULL JOIN sorgusunu yazınız. 
SELECT rental.rental_id, customer.first_name, customer.last_name, customer.customer_id 
FROM rental
FULL JOIN customer 
ON rental.customer_id = customer.customer_id; 

0dev 11

--1.actor ve customer tablolarında bulunan first_name sütunları için tüm verileri sıralayalım.
(SELECT actor.first_name
FROM actor)
UNION
(SELECT customer.first_name
FROM customer)
ORDER BY first_name;

--2.actor ve customer tablolarında bulunan first_name sütunları için kesişen verileri sıralayalım.
SELECT actor.first_name
FROM actor
INTERSECT
SELECT customer.first_name
FROM customer
ORDER BY first_name;

--3.actor ve customer tablolarında bulunan first_name sütunları için ilk tabloda bulunan ancak ikinci tabloda bulunmayan verileri sıralayalım.
SELECT actor.first_name
FROM actor
EXCEPT
SELECT customer.first_name
FROM customer
ORDER BY first_name;
 
 --4.İlk 3 sorguyu tekrar eden veriler için de yapalım.
SELECT actor.first_name
FROM actor
UNION ALL
SELECT customer.first_name
FROM customer
ORDER BY first_name;

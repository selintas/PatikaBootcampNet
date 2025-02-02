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
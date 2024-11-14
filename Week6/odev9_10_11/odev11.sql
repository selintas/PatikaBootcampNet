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
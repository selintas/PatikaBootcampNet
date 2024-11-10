--1.film tablosunda bulunan replacement_cost sütununda bulunan *birbirinden farklı* (DISTINCT)değerleri sıralayınız. 
SELECT DISTINCT replacement_cost FROM film;

--2.film tablosunda bulunan replacement_cost sütununda birbirinden farklı kaç tane veri vardır?
SELECT COUNT(DISTINCT replacement_cost) AS unique_replacement_cost_count FROM film; 


--3.film tablosunda bulunan film isimlerinde (title) kaç tanesini T karakteri ile başlar ve aynı zamanda rating 'G' ye eşittir?
SELECT COUNT(*) FROM film --SELECT COUNT(*) AS count
WHERE title LIKE 'T%' AND rating = 'G';

--4.country tablosunda bulunan ülke isimlerinden (country) kaç tanesi 5 karakterden oluşmaktadır? 
SELECT COUNT(*) AS country_count FROM country WHERE LENGTH(country) = 5;
 

--5.city tablosundaki şehir isimlerinin kaç tanesi 'R' veya r karakteri ile biter?ILIKE BUYUK KUCUK HARF FARKETMEZ
SELECT COUNT(*) AS city_count
FROM city
WHERE city ILIKE '%r';
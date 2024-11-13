Odev 9
1. INNER JOIN for City and Country Tables
To view the city and country names together, we can use the INNER JOIN between the city and country tables on their common column country_id.


SELECT city.city_id, city.city, country.country, country.country_id 
FROM city
INNER JOIN country 
ON city.country_id = country.country_id;
This query retrieves:

city_id from the city table
city name from the city table
country name from the country table
country_id from the country table
2. INNER JOIN for Customer and Payment Tables
To view the payment_id along with the first and last names of customers, we use the INNER JOIN between the payment and customer tables on their common column customer_id.



SELECT payment.payment_id, customer.first_name, customer.last_name, customer.customer_id 
FROM payment
INNER JOIN customer 
ON payment.customer_id = customer.customer_id;
This query retrieves:

payment_id from the payment table
first_name and last_name from the customer table
customer_id from the customer table
3. INNER JOIN for Customer and Rental Tables
To view the rental_id along with the first and last names of customers, we use the INNER JOIN between the rental and customer tables on their common column customer_id.


SELECT rental.rental_id, customer.first_name, customer.last_name, customer.customer_id 
FROM rental
INNER JOIN customer 
ON rental.customer_id = customer.customer_id;
This query retrieves:

rental_id from the rental table
first_name and last_name from the customer table
customer_id from the customer table


Note: The id fields are included as part of the result, as the customer and payment/rental data cannot be fully linked without them

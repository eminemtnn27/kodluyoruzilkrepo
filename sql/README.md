# Sql-Sorguları

## Ödev 1 
1. Film tablosunda bulunan title ve description sütunlarındaki verileri sıralayınız.

`SELECT title, description FROM film;`
                    
2. Film tablosunda bulunan tüm sütunlardaki verileri film uzunluğu (length) 60 dan büyük VE 75 ten küçük olma koşullarıyla sıralayınız.  
  
`SELECT * FROM film WHERE (length>60 AND length<75);`

3. Film tablosunda bulunan tüm sütunlardaki verileri rental_rate 0.99 VE replacement_cost 12.99 VEYA 28.99 olma koşullarıyla sıralayınız.

`SELECT * FROM film WHERE replacement_cost=12.99 OR replacement_cost=28.99;`

4. Customer tablosunda bulunan first_name sütunundaki değeri 'Mary' olan müşterinin last_name sütunundaki değeri nedir?

`SELECT last_name FROM customer WHERE first_name='Mary';`

5. Film tablosundaki uzunluğu(length) 50 ten büyük OLMAYIP aynFı zamanda rental_rate değeri 2.99 veya 4.99 OLMAYAN verileri sıralayınız.                

`SELECT * FROM film WHERE length<50 AND NOT(rental_rate=2.99 OR rental_rate=4.99);`


## Ödev 2


1. Film tablosunda bulunan tüm sütunlardaki verileri replacement cost değeri 12.99 dan büyük eşit ve 16.99 küçük olma koşuluyla sıralayınız ( BETWEEN - AND yapısını kullanınız.)

`SELECT * FROM film WHERE replacement_cost BETWEEN 12.99 AND 16.99;`

2. .actor tablosunda bulunan first_name ve last_name sütunlardaki verileri first_name 'Penelope' veya 'Nick' veya 'Ed' değerleri olması koşuluyla sıralayınız. ( IN operatörünü kullanınız.)

`SELECT first_name, last_name FROM actor WHERE first_name IN('Penelope', 'Nick', 'Ed');`

3. Film tablosunda bulunan tüm sütunlardaki verileri rental_rate 0.99, 2.99, 4.99 VE replacement_cost 12.99, 15.99, 28.99 olma koşullarıyla sıralayınız. ( IN operatörünü kullanınız.)

`SELECT * FROM film WHERE rental_rate IN(0.99, 2.99, 4.99) AND replacement_cost IN(12.99, 15.99, 28.99);`

## Ödev 3

1. Country tablosunda bulunan country sütunundaki ülke isimlerinden 'A' karakteri ile başlayıp 'a' karakteri ile sonlananları sıralayınız.

`SELECT country FROM country WHERE country LIKE 'A%a';`

2. Country tablosunda bulunan country sütunundaki ülke isimlerinden en az 6 karakterden oluşan ve sonu 'n' karakteri ile sonlananları sıralayınız.

`SELECT country FROM country WHERE country LIKE '_____%n';`

3. Film tablosunda bulunan title sütunundaki film isimlerinden en az 4 adet büyük ya da küçük harf farketmesizin 'T' karakteri içeren film isimlerini sıralayınız.

`SELECT title FROM film WHERE title ILIKE '%t%t%t%t%';`

4. Film tablosunda bulunan tüm sütunlardaki verilerden title 'C' karakteri ile başlayan ve uzunluğu (length) 90 dan büyük olan ve rental_rate 2.99 olan verileri sıralayınız.

`SELECT * FROM film WHERE title LIKE 'C%' AND length>90 AND rental_rate=2.99;`

## Ödev 4

1. Film tablosunda bulunan replacement_cost sütununda bulunan birbirinden farklı değerleri sıralayınız.

`SELECT  DISTINCT replacement_cost FROM film;`

2. Film tablosunda bulunan replacement_cost sütununda birbirinden farklı kaç tane veri vardır?

`SELECT COUNT(DISTINCT replacement_cost) FROM film;`

3. Film tablosunda bulunan film isimlerinde (title) kaç tanesini T karakteri ile başlar ve aynı zamanda rating 'G' ye eşittir?

`SELECT COUNT(title) FROM film WHERE title LIKE 'T%' AND rating='G';`

4. Country tablosunda bulunan ülke isimlerinden (country) kaç tanesi 5 karakterden oluşmaktadır?

`SELECT COUNT(country) FROM country WHERE LENGTH(country) = 5;`

5. City tablosundaki şehir isimlerinin kaç tanesi 'R' veya r karakteri ile biter?

`SELECT COUNT(city) FROM city WHERE city LIKE 'R%r'; `

## Ödev 5

1. Film tablosunda bulunan ve film ismi (title) 'n' karakteri ile biten en uzun (length) 5 filmi sıralayınız.

`SELECT title FROM film WHERE title LIKE '%n' ORDER BY length DESC LIMIT 5; `

2. Film tablosunda bulunan ve film ismi (title) 'n' karakteri ile biten en kısa (length) ikinci(6,7,8,9,10) 5 filmi(6,7,8,9,10) sıralayınız.

`SELECT title FROM film WHERE title LIKE '%n' ORDER BY length ASC OFFSET 5 LIMIT 5;`

3. Customer tablosunda bulunan last_name sütununa göre azalan yapılan sıralamada store_id 1 olmak koşuluyla ilk 4 veriyi sıralayınız.

`SELECT title FROM customer WHERE store_id=1 ORDER BY last_name DESC LIMIT 4;`

## Ödev 6

1. Film tablosunda bulunan rental_rate sütunundaki değerlerin ortalaması nedir?

`SELECT ROUND(AVG(rental_rate), 3) FROM film;`

2. Film tablosunda bulunan filmlerden kaç tanesi 'C' karakteri ile başlar?

`SELECT COUNT(title) FROM film WHERE title LIKE 'C%' `

3. Film tablosunda bulunan filmlerden rental_rate değeri 0.99 a eşit olan en uzun (length) film kaç dakikadır?

`SELECT MAX(length) FROM film WHERE rental_rate=0.99`

4. Film tablosunda bulunan filmlerin uzunluğu 150 dakikadan büyük olanlarına ait kaç farklı replacement_cost değeri vardır?

`SELECT COUNT(DISTINCT replacement_cost) FROM film WHERE length>150`

## Ödev 7

1. Film tablosunda bulunan filmleri rating değerlerine göre gruplayınız.

`SELECT rating FROM film GROUP BY rating`

2. Film tablosunda bulunan filmleri replacement_cost sütununa göre grupladığımızda film sayısı 50 den fazla olan replacement_cost değerini ve karşılık gelen film sayısını sıralayınız.

`SELECT replacement_cost, COUNT(*) FROM film GROUP BY replacement_cost HAVING COUNT(*)>50;`

3. Customer tablosunda bulunan store_id değerlerine karşılık gelen müşteri sayılarını nelerdir? 

`SELECT store_id, COUNT(*) FROM customer GROUP BY store_id;`

4. city tablosunda bulunan şehir verilerini country_id sütununa göre gruplandırdıktan sonra en fazla şehir sayısı barındıran country_id bilgisini ve şehir sayısını paylaşınız.

`SELECT country_id, COUNT(*) FROM city GROUP BY country_id ORDER BY COUNT(*) DESC LIMIT 1;`

## Ödev 8

1. Test veritabanınızda employee isimli sütun bilgileri id(INTEGER), name VARCHAR(50), birthday DATE, email VARCHAR(100) olan bir tablo oluşturalım.

```
CREATE TABLE employee(
	id integer PRIMARY KEY, 
	name VARCHAR(50) NOT NULL,
	birthday DATE,
	email VARCHAR(100)
);
```

2. Oluşturduğumuz employee tablosuna 'Mockaroo' servisini kullanarak 50 adet veri ekleyelim.
 ```
insert into employee (id, name, birthday , email) values (1, 'Marcos', '1996/07/16', 'mstlouis0@wordpress.com');
	insert into employee (id, name, birthday , email) values (2, 'Lil', '1953/02/13', 'lhiorn1@theatlantic.com');
	insert into employee (id, name, birthday , email) values (3, 'Grace', null, 'gmarder2@fema.gov');
	insert into employee (id, name, birthday , email) values (4, 'Billy', null, 'bconre3@youku.com');
	insert into employee (id, name, birthday , email) values (5, 'Sigmund', '1972/11/12', 'smcghie4@mapy.cz');
	insert into employee (id, name, birthday , email) values (6, 'Letty', '1911/08/12', 'lholbury5@pcworld.com');
	insert into employee (id, name, birthday , email) values (7, 'Letizia', '1927/02/19', 'loutright6@flavors.me');
	insert into employee (id, name, birthday , email) values (8, 'Fayth', '1958/07/04', 'fbrodest7@xing.com');
	insert into employee (id, name, birthday , email) values (9, 'Jacquelyn', '2002/04/11', 'jtroup8@gmpg.org');
	insert into employee (id, name, birthday , email) values (10, 'Hebert', '1950/05/11', 'hbatistelli9@ucla.edu');
	insert into employee (id, name, birthday , email) values (11, 'Claudianus', '1953/09/18', 'cbridgstocka@tuttocitta.it');
	insert into employee (id, name, birthday , email) values (12, 'Jania', '1948/01/10', 'jpeaseeb@tinyurl.com');
	insert into employee (id, name, birthday , email) values (13, 'Denys', '1944/03/03', 'dstroulgerc@rakuten.co.jp');
	insert into employee (id, name, birthday , email) values (14, 'Charisse', '1983/02/18', 'cduesberryd@paginegialle.it');
	insert into employee (id, name, birthday , email) values (15, 'Hyacinthe', '1939/08/11', 'hramseye@psu.edu');
	insert into employee (id, name, birthday , email) values (16, 'Anissa', '1975/05/07', 'ajoselandf@nsw.gov.au');
	insert into employee (id, name, birthday , email) values (17, 'Dorolisa', null, 'dkerssg@dion.ne.jp');
	insert into employee (id, name, birthday , email) values (18, 'Sheilah', '1932/08/07', 'snorthernh@chronoengine.com');
	insert into employee (id, name, birthday , email) values (19, 'Ethyl', '1957/12/08', 'ebendei@weibo.com');
	insert into employee (id, name, birthday , email) values (20, 'Lari', '1927/11/23', 'lemmetj@blogtalkradio.com');
	insert into employee (id, name, birthday , email) values (21, 'Eugen', '1929/12/02', 'eyashnovk@mozilla.com');
	insert into employee (id, name, birthday , email) values (22, 'Charisse', '1988/02/08', 'chuertasl@list-manage.com');
	insert into employee (id, name, birthday , email) values (23, 'Bartolomeo', null, 'bbaystonm@dedecms.com');
	insert into employee (id, name, birthday , email) values (24, 'Barbaraanne', '2013/05/22', 'bcowderayn@yale.edu');
	insert into employee (id, name, birthday , email) values (25, 'Lyndsey', '2007/02/05', 'lchilderleyo@123-reg.co.uk');
	insert into employee (id, name, birthday , email) values (26, 'Milton', '1911/04/26', 'mlowersp@nymag.com');
	insert into employee (id, name, birthday , email) values (27, 'Patrizia', '1988/02/13', 'pduesburyq@census.gov');
	insert into employee (id, name, birthday , email) values (28, 'Bronnie', '1978/06/20', 'bfawthropr@elpais.com');
	insert into employee (id, name, birthday , email) values (29, 'Artemas', '1928/02/06', 'atighes@wikimedia.org');
	insert into employee (id, name, birthday , email) values (30, 'Zorana', null, 'zvuittet@networkadvertising.org');
	insert into employee (id, name, birthday , email) values (31, 'Calla', '1952/07/18', 'cfidoeu@chronoengine.com');
	insert into employee (id, name, birthday , email) values (32, 'Abran', null, 'alardnarv@rediff.com');
	insert into employee (id, name, birthday , email) values (33, 'Layney', '1933/05/17', 'lmashw@ifeng.com');
	insert into employee (id, name, birthday , email) values (34, 'Guillemette', '1928/05/19', 'gjosephsonx@cbslocal.com');
	insert into employee (id, name, birthday , email) values (35, 'Corissa', '1970/11/21', 'cluttyy@ted.com');
	insert into employee (id, name, birthday , email) values (36, 'Ninetta', null, 'ngreenallz@scientificamerican.com');
	insert into employee (id, name, birthday , email) values (37, 'Donetta', null, 'dennew10@flickr.com');
	insert into employee (id, name, birthday , email) values (38, 'Fanchon', '1984/08/23', 'fscain11@illinois.edu');
	insert into employee (id, name, birthday , email) values (39, 'Sara-ann', null, 'sturvie12@netvibes.com');
	insert into employee (id, name, birthday , email) values (40, 'Cherri', '1904/11/18', 'cpontefract13@liveinternet.ru');
	insert into employee (id, name, birthday , email) values (41, 'Britte', '2008/12/28', 'bmuggeridge14@yelp.com');
	insert into employee (id, name, birthday , email) values (42, 'Shoshanna', null, 'speedell15@histats.com');
	insert into employee (id, name, birthday , email) values (43, 'Jandy', '1902/11/18', 'jrewbottom16@samsung.com');
	insert into employee (id, name, birthday , email) values (44, 'Sebastian', '1944/05/12', 'smckeggie17@skyrock.com');
	insert into employee (id, name, birthday , email) values (45, 'Marys', '2019/10/06', 'mruler18@dyndns.org');
	insert into employee (id, name, birthday , email) values (46, 'Vevay', '1979/08/19', 'vmaccartney19@last.fm');
	insert into employee (id, name, birthday , email) values (47, 'Evie', '1916/08/30', 'ecasetti1a@cnbc.com');
	insert into employee (id, name, birthday , email) values (48, 'Ray', '1938/09/03', 'rwaddington1b@samsung.com');
	insert into employee (id, name, birthday , email) values (49, 'Quinlan', null, 'qstruijs1c@ning.com');
	insert into employee (id, name, birthday , email) values (50, 'Bridie', '1950/04/21', 'blovelock1d@freewebs.com');
	
```


3. Sütunların her birine göre diğer sütunları güncelleyecek 5 adet UPDATE işlemi yapalım.
```
UPDATE employee
SET name = 'Daniel'
WHERE id = 5;	

UPDATE employee
SET birthday = '1958-07-25'
WHERE email LIKE 'vma%'';

UPDATE employee
SET email = 'mkiwitzd@ft.com'
WHERE birthday = '1916/08/30';

UPDATE employee
SET name = 'Null'
WHERE id > 45;

UPDATE employee
SET birthday = '2020-12-17'
WHERE name ILIKE 'B%e';
```

4. Sütunların her birine göre ilgili satırı silecek 5 adet DELETE işlemi yapalım.

```
DELETE FROM employee
WHERE name = 'Sebastian';	



DELETE FROM employee
WHERE email LIKE 'Q%n';

DELETE FROM employee
WHERE birthday > '1938/09/03';

DELETE FROM employee
WHERE name LIKE '%e';

DELETE FROM employee
WHERE id < 8;
```

## Ödev 9

1. City tablosu ile country tablosunda bulunan şehir (city) ve ülke (country) isimlerini birlikte görebileceğimiz INNER JOIN sorgusunu yazınız.

```
SELECT city, country FROM city 
INNER JOIN country ON country.country_id = city.country_id;
```

2. Customer tablosu ile payment tablosunda bulunan payment_id ile customer tablosundaki first_name ve last_name isimlerini birlikte görebileceğimiz INNER JOIN sorgusunu yazınız.

```
SELECT customer.first_name, customer.last_name, payment.payment_id FROM customer
INNER JOIN payment ON customer.store_id = payment.staff_id;
```

3. Customer tablosu ile rental tablosunda bulunan rental_id ile customer tablosundaki first_name ve last_name isimlerini birlikte görebileceğimiz INNER JOIN sorgusunu yazınız.

```
SELECT customer.first_name, customer.last_name, rental.rental_id FROM rental
INNER JOIN customer ON customer.customer_id = rental.customer_id;
```

## Ödev 10 

1. City tablosu ile country tablosunda bulunan şehir (city) ve ülke (country) isimlerini birlikte görebileceğimiz LEFT JOIN sorgusunu yazınız.

```
SELECT city, country 
FROM city 
LEFT JOIN country 
ON city.country_id = country.country_id;
```

2. Customer tablosu ile payment tablosunda bulunan payment_id ile customer tablosundaki first_name ve last_name isimlerini birlikte görebileceğimiz RIGHT JOIN sorgusunu yazınız.

```
SELECT payment.payment_id, customer.first_name, customer.last_name 
FROM customer
RIGHT JOIN payment 
ON customer.store_id = payment.staff_id;
```

3. Customer tablosu ile rental tablosunda bulunan rental_id ile customer tablosundaki first_name ve last_name isimlerini birlikte görebileceğimiz FULL JOIN sorgusunu yazınız.

```
SELECT customer.first_name, customer.last_name, rental.rental_id 
FROM rental
FULL JOIN customer 
ON customer.customer_id = rental.customer_id;
```

## Ödev 11

1. Actor ve customer tablolarında bulunan first_name sütunları için tüm verileri sıralayalım.

```
(SELECT first_name FROM actor)
UNION
(SELECT first_name FROM customer);
```

2. Actor ve customer tablolarında bulunan first_name sütunları için kesişen verileri sıralayalım.

```
(SELECT first_name FROM actor)
INTERSECT
(SELECT first_name FROM customer);
```

3. Actor ve customer tablolarında bulunan first_name sütunları için ilk tabloda bulunan ancak ikinci tabloda bulunmayan verileri sıralayalım.

```
(SELECT first_name FROM actor)
EXCEPT
(SELECT first_name FROM customer);
```

4. İlk 3 sorguyu tekrar eden veriler için de yapalım.

```
(SELECT first_name FROM actor)
UNION ALL
(SELECT first_name FROM customer);
```
```
(SELECT first_name FROM actor)
INTERSECT ALL
(SELECT first_name FROM customer);
```
```
(SELECT first_name FROM actor)
EXCEPT ALL
(SELECT first_name FROM customer);
```

## Ödev 12

1. Film tablosunda film uzunluğu length sütununda gösterilmektedir. Uzunluğu ortalama film uzunluğundan fazla kaç tane film vardır?

`SELECT COUNT(*) FROM film WHERE length > (SELECT AVG(length) FROM film);`

2. Film tablosunda en yüksek rental_rate değerine sahip kaç tane film vardır?

`SELECT COUNT(*) FROM film WHERE rental_rate = (SELECT MAX(rental_rate) FROM film);`

3. Film tablosunda en düşük rental_rate ve en düşün replacement_cost değerlerine sahip filmleri sıralayınız.

```
SELECT * FROM film 
WHERE rental_rate = (SELECT MIN(rental_rate) FROM film) 
AND replacement_cost = (SELECT MIN(replacement_cost) FROM film);
```

4. Payment tablosunda en fazla sayıda alışveriş yapan müşterileri(customer) sıralayınız.

```
SELECT customer.first_name, customer.last_name FROM payment 
INNER JOIN customer ON payment.customer_id = customer.customer_id
WHERE payment.amount = (SELECT MAX(amount) FROM payment);
```



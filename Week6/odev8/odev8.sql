--SELECT * FROM employee; 

 --1.test veritabanınızda employee isimli sütun bilgileri id(INTEGER), name VARCHAR(50), birthday DATE, email VARCHAR(100) olan bir tablo oluşturalım.
--CREATE TABLE employee (
--    id SERIAL PRIMARY KEY, --PRIMARY KEY benzersız ıd verır.
--    name VARCHAR(50),
--    birthday DATE,
--    email VARCHAR(100)
--); 
--2.Oluşturduğumuz employee tablosuna 'Mockaroo' servisini kullanarak 50 adet veri ekleyelim.
--SELECT * fROM employee;
 
 --INSERT INTO employee (name, birtday, email)
 --VALUES 
 --('selin', '1194-06-05', sselintas@gmail.com);
 
--ınsort ınto ile veri ekleme.mockaroo ile
insert into employee (name, email, birthday) values ('Renée', 'mcasterot0@skype.com', '2021-07-02');
insert into employee (name, email, birthday) values ('Maëline', 'wwoollcott1@google.nl', '2010-03-19');
insert into employee (name, email, birthday) values ('Amélie', 'htriggle2@discuz.net', '2019-07-31');
insert into employee (name, email, birthday) values ('Maëlla', 'llabrom3@boston.com', '2016-10-20');
insert into employee (name, email, birthday) values ('Laïla', null, '2022-09-30');
insert into employee (name, email, birthday) values ('Dà', 'alester5@facebook.com', '2001-11-30');
insert into employee (name, email, birthday) values ('Réjane', 'sredmore6@yahoo.com', null);
insert into employee (name, email, birthday) values ('Félicie', 'wvaissiere7@abc.net.au', '2011-03-28');
insert into employee (name, email, birthday) values ('Maëlyss', 'zgartenfeld8@zimbio.com', '2015-11-21');
insert into employee (name, email, birthday) values ('Esbjörn', 'sspeer9@ning.com', '1998-10-06');
insert into employee (name, email, birthday) values ('Anaël', 'oaingella@livejournal.com', '2012-08-02');
insert into employee (name, email, birthday) values ('Mélina', 'arafterb@time.com', '2022-01-04');
insert into employee (name, email, birthday) values ('Mégane', 'maronsteinc@lycos.com', '2009-05-25');
insert into employee (name, email, birthday) values ('Eléa', 'mshowersd@histats.com', null);
insert into employee (name, email, birthday) values ('Mélissandre', 'nchasneye@slashdot.org', null);
insert into employee (name, email, birthday) values ('Pélagie', 'mfalkusf@guardian.co.uk', '2007-05-16');
insert into employee (name, email, birthday) values ('Lén', 'jchatelotg@yahoo.co.jp', '2017-03-18');
insert into employee (name, email, birthday) values ('Marylène', 'bwinstoneh@patch.com', '2005-01-11');
insert into employee (name, email, birthday) values ('Mà', null, '1995-05-05');
insert into employee (name, email, birthday) values ('Gérald', 'ncusiterj@live.com', '2004-03-14');
insert into employee (name, email, birthday) values ('Marlène', 'cmcculloghk@google.nl', '1996-03-22');
insert into employee (name, email, birthday) values ('Bérénice', 'gcappell@posterous.com', '1996-02-10');
insert into employee (name, email, birthday) values ('Méthode', 'amatiashvilim@google.co.jp', null);
insert into employee (name, email, birthday) values ('Mégane', 'myellowleesn@npr.org', '2021-01-14');
insert into employee (name, email, birthday) values ('Marie-noël', 'memminso@taobao.com', '1995-08-25');
insert into employee (name, email, birthday) values ('Maïwenn', null, '2015-08-13');
insert into employee (name, email, birthday) values ('Åke', 'djoutapaviciusq@barnesandnoble.com', '2010-10-29');
insert into employee (name, email, birthday) values ('Yú', 'dketteridger@netlog.com', '2004-09-28');
insert into employee (name, email, birthday) values ('Ruì', 'mstabless@51.la', '1999-11-16');
insert into employee (name, email, birthday) values ('Åke', 'cletherburyt@odnoklassniki.ru', '1996-03-29');
insert into employee (name, email, birthday) values ('Mén', 'sfetherbyu@about.com', '2012-07-26');
insert into employee (name, email, birthday) values ('Séverine', 'dganfordv@goodreads.com', '1992-11-26');
insert into employee (name, email, birthday) values ('Torbjörn', 'atanguyw@wunderground.com', '2008-06-08');
insert into employee (name, email, birthday) values ('Sòng', 'hmaytomx@fema.gov', '1998-04-02');
insert into employee (name, email, birthday) values ('Chloé', 'zpaikey@ow.ly', '2005-09-02');
insert into employee (name, email, birthday) values ('Ruò', 'jstanneringz@google.fr', '1993-07-17');
insert into employee (name, email, birthday) values ('Séverine', 'hmeddemmen10@time.com', '1991-08-05');
insert into employee (name, email, birthday) values ('Dorothée', 'ilott11@globo.com', '2008-01-29');
insert into employee (name, email, birthday) values ('Lyséa', 'nandrejevic12@craigslist.org', '2016-03-03');
insert into employee (name, email, birthday) values ('Maëline', 'pbergeau13@bizjournals.com', '2010-12-03');
insert into employee (name, email, birthday) values ('Maïwenn', 'tveronique14@booking.com', '1994-10-04');
insert into employee (name, email, birthday) values ('Maïlys', 'inorcock15@thetimes.co.uk', '2009-05-01');
insert into employee (name, email, birthday) values ('Lài', 'msturgis16@myspace.com', '2011-06-22');
insert into employee (name, email, birthday) values ('Ophélie', 'jwedge17@xing.com', '2002-12-12');
insert into employee (name, email, birthday) values ('Cléopatre', 'predding18@ask.com', '2006-09-08');
insert into employee (name, email, birthday) values ('Adélie', null, '1997-08-08');
insert into employee (name, email, birthday) values ('Lucrèce', 'inottingham1a@hao123.com', '2004-11-18');
insert into employee (name, email, birthday) values ('Zhì', 'tfells1b@sogou.com', '2012-07-23');
insert into employee (name, email, birthday) values ('Laïla', 'qboal1c@nydailynews.com', '2019-03-24');
insert into employee (name, email, birthday) values ('Nadège', 'rbaugham1d@booking.com', '2010-08-11');

--3.Sütunların her birine göre diğer sütunları güncelleyecek 5 adet UPDATE işlemi yapalım.
 update employee
 set
 name = 'selin',
 birthday = '1994-06-05',
 email = 'sselintas@gmail.com' 
 Where id = 1;

UPDATE employee
SET
    name = 'Elif',
    birthday = '1990-11-12',
    email = 'elifkara@gmail.com'
WHERE id = 3;

UPDATE employee
SET
    name = 'Murat',
    birthday = '1978-07-20',
    email = 'muratcan@yahoo.com'
WHERE id = 4;

UPDATE employee
SET
    name = 'Zeynep',
    birthday = '1992-02-27',
    email = 'zeynepdemir@hotmail.com'
WHERE id = 5;

UPDATE employee
SET
    name = 'Kemal',
    birthday = '1988-09-30',
    email = 'kemalcelik@gmail.com'
WHERE id = 6;
--4.Sütunların her birine göre ilgili satırı silecek 5 adet DELETE işlemi yapalım.

-- 1. id sütununa göre silme
DELETE FROM employee
WHERE id = 2;

-- 2. name sütununa göre silme
DELETE FROM employee
WHERE name = 'Elif';

-- 3. birthday sütununa göre silme
DELETE FROM employee
WHERE birthday = '1978-07-20';

-- 4. email sütununa göre silme
DELETE FROM employee
WHERE email = 'zeynepdemir@hotmail.com';

-- 5. Belirli bir kritere göre silme (örneğin doğum tarihi 1990'dan önce olanları silme)
DELETE FROM employee
WHERE birthday < '1990-01-01';

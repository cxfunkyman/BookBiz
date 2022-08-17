DROP TABLE IF EXISTS book_author;
DROP TABLE IF EXISTS book_category;
DROP TABLE IF EXISTS book;
DROP TABLE IF EXISTS author;
DROP TABLE IF EXISTS category;
DROP TABLE IF EXISTS publisher;
DROP TABLE IF EXISTS client;
DROP TABLE IF EXISTS users;
DROP TABLE IF EXISTS employee;
DROP TABLE IF EXISTS role;

CREATE TABLE "author" (
	"author_Id"	INTEGER NOT NULL UNIQUE,
	"first_Name"	TEXT NOT NULL,
	"last_Name"	TEXT,
	"email"	TEXT,
	PRIMARY KEY("author_Id" AUTOINCREMENT)
);
CREATE TABLE "category" (
	"category_Id"	INTEGER NOT NULL UNIQUE,
	"category_name"	TEXT NOT NULL,
	PRIMARY KEY("category_Id" AUTOINCREMENT)
);
CREATE TABLE "publisher" (
	"publisher_Id"	INTEGER NOT NULL UNIQUE,
	"publisher_name"	TEXT NOT NULL,
	PRIMARY KEY("publisher_Id" AUTOINCREMENT)
);
CREATE TABLE "book" (
	"book_Id"	INTEGER NOT NULL UNIQUE,
	"ISBN"	TEXT NOT NULL,
	"title"	TEXT NOT NULL,
	"unit_price"	REAL NOT NULL,
	"year_of_publish"	TEXT NOT NULL,
	"QOH"	INTEGER NOT NULL,
	"author_Id"	INTEGER NOT NULL,
	"category_Id"	INTEGER NOT NULL,
	"publisher_Id"	INTEGER NOT NULL,
	FOREIGN KEY("publisher_Id") REFERENCES "publisher"("publisher_Id"),
	FOREIGN KEY("author_Id") REFERENCES "author"("Author_Id"),
	FOREIGN KEY("category_Id") REFERENCES "category"("category_Id"),
	PRIMARY KEY("book_Id" AUTOINCREMENT)
);
CREATE TABLE "book_author" (
	"Id"	INTEGER NOT NULL UNIQUE,
	"book_Id"	INTEGER NOT NULL,
	"author_Id"	INTEGER NOT NULL,
	PRIMARY KEY("Id" AUTOINCREMENT),
	FOREIGN KEY("author_Id") REFERENCES "author"("author_Id"),
	FOREIGN KEY("book_Id") REFERENCES "book"("book_Id")
);
CREATE TABLE "book_category" (
	"Id"	INTEGER NOT NULL UNIQUE,
	"book_Id"	INTEGER NOT NULL,
	"category_Id"	INTEGER NOT NULL,
	FOREIGN KEY("book_Id") REFERENCES "book"("book_Id"),
	FOREIGN KEY("category_Id") REFERENCES "category"("category_Id"),
	FOREIGN KEY("book_Id") REFERENCES "book"("book_Id"),
	PRIMARY KEY("Id" AUTOINCREMENT)
);
CREATE TABLE "client" (
	"client_Id"	INTEGER NOT NULL UNIQUE,
	"name"	TEXT NOT NULL,
	"street"	TEXT NOT NULL,
	"city"	TEXT NOT NULL,
	"postal_code"	TEXT NOT NULL,
	"phone_number"	REAL NOT NULL,
	"fax_number"	REAL NOT NULL,
	"credit_limit"	REAL NOT NULL,
	PRIMARY KEY("client_Id" AUTOINCREMENT)
);
CREATE TABLE "role" (
	"role_Id"	INTEGER NOT NULL UNIQUE,
	"role_name"	TEXT NOT NULL,
	PRIMARY KEY("role_Id" AUTOINCREMENT)
);
CREATE TABLE "employee" (
	"employee_Id"	INTEGER NOT NULL UNIQUE,
	"first_name"	TEXT NOT NULL,
	"last_name"	TEXT NOT NULL,
	"email"	TEXT NOT NULL,
	"user_name"	TEXT NOT NULL,
	"password"	TEXT NOT NULL,
	"role_Id"	INTEGER NOT NULL,
	FOREIGN KEY("role_Id") REFERENCES "role"("role_Id"),
	PRIMARY KEY("employee_Id" AUTOINCREMENT)
);
CREATE TABLE "users" (
	"user_Id"	INTEGER NOT NULL UNIQUE,
	"employee_Id" TEXT NOT NULL,
	FOREIGN KEY("employee_Id") REFERENCES "employee"("employee_Id"),			
	PRIMARY KEY("user_Id" AUTOINCREMENT)
);

INSERT INTO author(first_name, last_name, email) VALUES ('Raime', 'Lavoi', 'rlavoi@hotmail.ca');
INSERT INTO author(first_name, last_name, email) VALUES ('Quiver', 'Dion', 'qdion@gmail.ca');
INSERT INTO author(first_name, last_name, email) VALUES ('Lana', 'Lang', 'lanalang@yahoo.com');
INSERT INTO author(first_name, last_name, email) VALUES ('Lorenzo', 'Magallanes', 'lmagallanes@msn.esp');
INSERT INTO author(first_name, last_name, email) VALUES ('Sammy', 'Gutierrez', 'sgutierrez@live.rd');

INSERT INTO category(category_name) VALUES('Horror');
INSERT INTO category(category_name) VALUES('Drama');
INSERT INTO category(category_name) VALUES('Suspense');
INSERT INTO category(category_name) VALUES('Fiction');
INSERT INTO category(category_name) VALUES('Thriller');

INSERT INTO publisher(publisher_name) VALUES('Marvel Studios');
INSERT INTO publisher(publisher_name) VALUES('DC Americas');
INSERT INTO publisher(publisher_name) VALUES('EX Readers');
INSERT INTO publisher(publisher_name) VALUES('Live to Read Corp');

INSERT INTO book(ISBN, title, unit_price, year_of_publish, QOH, author_Id, category_id, publisher_Id) VALUES ('978-1-56619-909-4', 'Harry Potter', '15.25', '2022', '25', '1', '4', '1');
INSERT INTO book(ISBN, title, unit_price, year_of_publish, QOH, author_Id, category_id, publisher_Id) VALUES ('1-4028-9462-7', 'The Other Side', '13.25', '2010', '15', '1', '5', '2');
INSERT INTO book(ISBN, title, unit_price, year_of_publish, QOH, author_Id, category_id, publisher_Id) VALUES ('369-2-4028-9462-6', 'Late Night Club', '28.20', '1999', '10', '2', '3', '3');
INSERT INTO book(ISBN, title, unit_price, year_of_publish, QOH, author_Id, category_id, publisher_Id) VALUES ('1-56619-909-3', 'Quantum Phisics Nightmare', '30.45', '2015', '18', '2', '2', '4');
INSERT INTO book(ISBN, title, unit_price, year_of_publish, QOH, author_Id, category_id, publisher_Id) VALUES ('978-1-56619-909-4', 'Harry Potter', '15.25', '2022', '25', '2', '2', '1');
INSERT INTO book(ISBN, title, unit_price, year_of_publish, QOH, author_Id, category_id, publisher_Id) VALUES ('456-4-25409-454-2', 'Deathstring', '13.13', '1990', '75', '3', '1', '2');
INSERT INTO book(ISBN, title, unit_price, year_of_publish, QOH, author_Id, category_id, publisher_Id) VALUES ('852-7-65699-386-6', 'Bless the Dead', '19.99', '2020', '45', '4', '5', '3');
INSERT INTO book(ISBN, title, unit_price, year_of_publish, QOH, author_Id, category_id, publisher_Id) VALUES ('753-5-45678-300-2', 'Horizontal Craig', '18.75', '2012', '83', '1', '3', '4');
INSERT INTO book(ISBN, title, unit_price, year_of_publish, QOH, author_Id, category_id, publisher_Id) VALUES ('978-1-56619-909-4', 'Harry Potter', '15.25', '2022', '25', '3', '3', '1');
INSERT INTO book(ISBN, title, unit_price, year_of_publish, QOH, author_Id, category_id, publisher_Id) VALUES ('357-8-35741-499-3', 'Pure Rain', '12.35', '2005', '33', '2', '4', '2');
INSERT INTO book(ISBN, title, unit_price, year_of_publish, QOH, author_Id, category_id, publisher_Id) VALUES ('258-9-25647-507-5', 'Ring of Fire', '10.00', '2000', '20', '3', '1', '3');
INSERT INTO book(ISBN, title, unit_price, year_of_publish, QOH, author_Id, category_id, publisher_Id) VALUES ('1-56619-909-3', 'Quantum Phisics Nightmare', '30.45', '2015', '18', '4', '3', '4');

INSERT INTO book_category(book_id, category_id) VALUES ('1', '4');
INSERT INTO book_category(book_id, category_id) VALUES ('2', '5');
INSERT INTO book_category(book_id, category_id) VALUES ('3', '3');
INSERT INTO book_category(book_id, category_id) VALUES ('4', '2');
INSERT INTO book_category(book_id, category_id) VALUES ('5', '2');
INSERT INTO book_category(book_id, category_id) VALUES ('6', '1');
INSERT INTO book_category(book_id, category_id) VALUES ('7', '5');
INSERT INTO book_category(book_id, category_id) VALUES ('8', '3');
INSERT INTO book_category(book_id, category_id) VALUES ('9', '3');
INSERT INTO book_category(book_id, category_id) VALUES ('10', '4');
INSERT INTO book_category(book_id, category_id) VALUES ('11', '1');
INSERT INTO book_category(book_id, category_id) VALUES ('12', '3');

INSERT INTO book_author(book_id, author_Id) VALUES('1','1');
INSERT INTO book_author(book_id, author_Id) VALUES('2','1');
INSERT INTO book_author(book_id, author_Id) VALUES('3','2');
INSERT INTO book_author(book_id, author_Id) VALUES('4','2');
INSERT INTO book_author(book_id, author_Id) VALUES('5','2');
INSERT INTO book_author(book_id, author_Id) VALUES('6','3');
INSERT INTO book_author(book_id, author_Id) VALUES('7','4');
INSERT INTO book_author(book_id, author_Id) VALUES('8','1');
INSERT INTO book_author(book_id, author_Id) VALUES('9','3');
INSERT INTO book_author(book_id, author_Id) VALUES('10','4');
INSERT INTO book_author(book_id, author_Id) VALUES('11','1');
INSERT INTO book_author(book_id, author_Id) VALUES('12','4');

INSERT INTO client(name, street, city, postal_code, phone_number, fax_number, credit_limit) VALUES('Concordia University', '1331 rue Ontario Ouest', 'Longueuil', 'H2X1Y8', '514-333-3333', '437-614-9699', '10,500.00');
INSERT INTO client(name, street, city, postal_code, phone_number, fax_number, credit_limit) VALUES('Vanier College', '3940 chemin du Lac', 'Montreal', 'J4G1E5', '514-604-9268', '416-610-9456', '8,250.00');
INSERT INTO client(name, street, city, postal_code, phone_number, fax_number, credit_limit) VALUES('John Abbot university', '1821 rue Saint-Charles', 'Quebec City', 'J4E1R3', '647-007-5500', '437-701-9880', '13,355.00');
INSERT INTO client(name, street, city, postal_code, phone_number, fax_number, credit_limit) VALUES('Loyola College', '1840 Alness Street', 'Trois-Rivieres', 'M3J2J1', '646-251-2518', '416-706-6387', '20,000.00');
INSERT INTO client(name, street, city, postal_code, phone_number, fax_number, credit_limit) VALUES('Dawson University', '1802 Merivale Road', 'Terrebonne', 'L5L5S1', '646-888-8888', '253-111-5555', '11,250.00');
INSERT INTO client(name, street, city, postal_code, phone_number, fax_number, credit_limit) VALUES('LaSalle College', '1860 Dry Pine Bay Rd', 'Laval', 'K2G3K2', '438-357-3575', '514-357-0001', '25,450.00');

INSERT INTO role(role_name) VALUES('MIS Manager');
INSERT INTO role(role_name) VALUES('Sales Manager');
INSERT INTO role(role_name) VALUES('Inventory Controller');
INSERT INTO role(role_name) VALUES('Order Clerk');

INSERT INTO employee(first_name, last_name, email, user_name, "password", role_id) VALUES('Henry', 'Brown', 'hbrown@bookbiz.ca', 'hbrown', '111111', '1');
INSERT INTO employee(first_name, last_name, email, user_name, "password", role_id) VALUES('Thomas', 'Moore', 'tmoore@bookbiz.ca', 'tmoore', '222222', '2');
INSERT INTO employee(first_name, last_name, email, user_name, "password", role_id) VALUES('Peter', 'Wang', 'pwang@bookbiz.ca', 'pwang', '333333', '3');
INSERT INTO employee(first_name, last_name, email, user_name, "password", role_id) VALUES('Mary', 'Brown', 'mbrown@bookbiz.ca', 'mbrown', '444444', '4');
INSERT INTO employee(first_name, last_name, email, user_name, "password", role_id) VALUES('Jennifer', 'Bouchard', 'jbouchard@bookbiz.ca', 'jbouchard', '555555', '4');

INSERT INTO users("employee_Id") VALUES('1');
INSERT INTO users("employee_Id") VALUES('2');
INSERT INTO users("employee_Id") VALUES('3');
INSERT INTO users("employee_Id") VALUES('4');
INSERT INTO users("employee_Id") VALUES('5');

DROP VIEW IF EXISTS author_view;
DROP VIEW IF EXISTS client_view;
DROP VIEW IF EXISTS users_view;
DROP VIEW IF EXISTS employee_view;
DROP VIEW IF EXISTS book_view;
DROP VIEW IF EXISTS book_author_view;
DROP VIEW IF EXISTS book_category_view;
DROP VIEW IF EXISTS category_view;
DROP VIEW IF EXISTS publisher_view;
DROP VIEW IF EXISTS role_view;

CREATE VIEW author_view as
SELECT 
author_Id as AID, 
first_name || " " || last_name as Name, 
email as Email
FROM author;

CREATE VIEW client_view as
SELECT 
client_Id as CID, 
name as Name, 
street as Street, 
city as City, 
postal_code as "Postal Code", 
phone_number as "Phone Number", 
fax_number as "Fax Number", 
credit_limit as "Credit Limit" 
FROM client;

CREATE VIEW employee_view as
SELECT
employee_Id as EID,
first_name  || " " || last_name as "Name",
email as Email,
user_name as "User Name",
"password" as "Password",
role.role_name as Position
FROM employee
LEFT JOIN role ON
role.role_id = employee.role_id;

CREATE VIEW users_view as
SELECT 
user_Id as UID, 
employee_view.Name, 
employee_view."User Name", 
employee_view."Password", 
employee_view."Position"
FROM users
LEFT JOIN employee_view ON
users.employee_Id = employee_view.EID;

CREATE VIEW book_view as
SELECT
book_Id as BID,
ISBN, 
title as Title, 
unit_price as "Unit Price", 
year_of_publish as "Year Of Publish", 
QOH, 
author_view.Name as "Author", 
category.category_name as "Category", 
publisher.publisher_name as "Publisher"
FROM book
LEFT JOIN author_view ON
author_view.AID = book.author_Id
LEFT JOIN category ON
category.category_Id = book.category_Id
LEFT JOIN publisher ON
publisher.publisher_Id = book.publisher_Id;

CREATE VIEW book_author_view as
SELECT
Id as BAID,
book.title as "Book",
author_view.Name as "Author"
FROM book_author
LEFT JOIN book ON
book.book_Id = book_author.book_Id
LEFT JOIN author_view on
author_view.AID = book_author.author_Id;

CREATE VIEW book_category_view as
SELECT
id as BCID,
book.title as "Book",
category.category_name as "Category"
FROM book_category
LEFT JOIN book ON
book.book_Id = book_category.book_Id
LEFT JOIN category ON
category.category_Id = book_category.category_Id;

CREATE VIEW category_view as
SELECT
category_Id as CID,
category_name as "Category"
FROM category;

CREATE VIEW publisher_view as
SELECT
publisher_Id as PID,
publisher_name as "Publisher"
FROM publisher;

CREATE VIEW role_view as
SELECT
role_Id as RID,
role_name as Name
FROM role;


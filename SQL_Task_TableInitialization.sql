CREATE TABLE products (
	id INT PRIMARY KEY,
	"name" TEXT
);

INSERT INTO products
VALUES
	(1, 'Kinder Bueno'),
	(2, 'Coca-Cola'),
	(3, 'Iphone 15'),
	(4, 'Ikea Chair'),
	(5, 'Spotify subscription'),
	(6, 'Robot vacuum cleaner mi2'),
	(7, 'Elephant');

CREATE TABLE categories (
	id INT PRIMARY KEY,
	"name" TEXT
);

INSERT INTO categories
VALUES
	(1, 'Candies'),
	(2, 'Drinks'),
	(3, 'Smartphones'),
	(4, 'Home goods'),
	(5, 'Digital products'),
	(6, 'Techniques');

CREATE TABLE products_categories (
	product_id INT FOREIGN KEY REFERENCES products(id),
	category_id INT FOREIGN KEY REFERENCES categories(id),
	PRIMARY KEY (product_id, category_id)
);

INSERT INTO products_categories
VALUES
	(1, 1),
	(2, 2),
	(3, 3),
	(3, 6),
	(4, 4),
	(5, 5),
	(6, 4),
	(6, 6);
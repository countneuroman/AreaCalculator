--Структура БД
CREATE TABLE products (
  id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
  name NVARCHAR(30) NOT NULL
);

CREATE TABLE categories (
  id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
  name NVARCHAR(30) NOT NULL
);

CREATE TABLE product_categories (
  product_id INT,
  category_id INT,
  CONSTRAINT movie_cat_pk PRIMARY KEY (product_id, category_id),
  CONSTRAINT FK_movie
      FOREIGN KEY (product_id) REFERENCES products (id),
  CONSTRAINT FK_category
      FOREIGN KEY (category_id) REFERENCES categories (id)
);


--Запрос
SELECT products.name, categories.name
FROM products
LEFT JOIN  product_categories pc ON products.id = pc.product_id
LEFT JOIN categories ON categories.id = pc.category_id
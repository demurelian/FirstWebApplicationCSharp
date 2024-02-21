SELECT products.name AS product_name, categories.name AS category_name
FROM products
LEFT JOIN products_categories ON products_categories.product_id = products.id
LEFT JOIN categories ON products_categories.category_id = categories.id
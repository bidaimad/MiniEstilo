CREATE TABLE mini_estilo.products (
    id SERIAL PRIMARY KEY,

    category_id INTEGER NOT NULL,
    brand_id INTEGER,

    code VARCHAR(30) NOT NULL UNIQUE,
    name VARCHAR(200) NOT NULL,

    description TEXT,

    image_path TEXT,

    is_active BOOLEAN DEFAULT TRUE,

    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP,

    CONSTRAINT fk_products_category
        FOREIGN KEY (category_id)
        REFERENCES mini_estilo.categories(id),

    CONSTRAINT fk_products_brand
        FOREIGN KEY (brand_id)
        REFERENCES mini_estilo.brands(id)
);
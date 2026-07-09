CREATE TABLE mini_estilo.product_variants (
    id SERIAL PRIMARY KEY,

    product_id INTEGER NOT NULL,
    size_id INTEGER NOT NULL,
    color_id INTEGER NOT NULL,

    barcode VARCHAR(50) UNIQUE,

    purchase_price NUMERIC(10,2) NOT NULL,
    selling_price NUMERIC(10,2) NOT NULL,

    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,

    CONSTRAINT fk_variant_product
        FOREIGN KEY (product_id)
        REFERENCES mini_estilo.products(id),

    CONSTRAINT fk_variant_size
        FOREIGN KEY (size_id)
        REFERENCES mini_estilo.sizes(id),

    CONSTRAINT fk_variant_color
        FOREIGN KEY (color_id)
        REFERENCES mini_estilo.colors(id)
);
CREATE TABLE mini_estilo.sale_items (
    id SERIAL PRIMARY KEY,

    sale_id INTEGER NOT NULL,
    product_variant_id INTEGER NOT NULL,

    quantity INTEGER NOT NULL,
    unit_price NUMERIC(12,2) NOT NULL,

    discount NUMERIC(12,2) DEFAULT 0,

    total NUMERIC(12,2) NOT NULL,

    CONSTRAINT fk_sale_items_sale
        FOREIGN KEY (sale_id)
        REFERENCES mini_estilo.sales(id)
        ON DELETE CASCADE,

    CONSTRAINT fk_sale_items_variant
        FOREIGN KEY (product_variant_id)
        REFERENCES mini_estilo.product_variants(id)
);
CREATE TABLE mini_estilo.stock (
    id SERIAL PRIMARY KEY,

    branch_id INTEGER NOT NULL,
    product_variant_id INTEGER NOT NULL,

    quantity INTEGER NOT NULL DEFAULT 0,

    minimum_quantity INTEGER NOT NULL DEFAULT 0,

    updated_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,

    CONSTRAINT fk_stock_branch
        FOREIGN KEY (branch_id)
        REFERENCES mini_estilo.branches(id),

    CONSTRAINT fk_stock_variant
        FOREIGN KEY (product_variant_id)
        REFERENCES mini_estilo.product_variants(id),

    CONSTRAINT uq_stock UNIQUE (branch_id, product_variant_id)
);
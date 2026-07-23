CREATE TABLE mini_estilo.payments (
    id SERIAL PRIMARY KEY,

    sale_id INTEGER NOT NULL,

    payment_method VARCHAR(30) NOT NULL,
    amount NUMERIC(12,2) NOT NULL,

    payment_date TIMESTAMP DEFAULT CURRENT_TIMESTAMP,

    reference_number VARCHAR(100),

    notes TEXT,

    CONSTRAINT fk_payments_sale
        FOREIGN KEY (sale_id)
        REFERENCES mini_estilo.sales(id)
        ON DELETE CASCADE
);
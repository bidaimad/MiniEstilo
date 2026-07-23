CREATE TABLE mini_estilo.sales (
    id SERIAL PRIMARY KEY,

    invoice_number VARCHAR(30) NOT NULL UNIQUE,

    branch_id INTEGER NOT NULL,
    customer_id INTEGER,
    user_id INTEGER NOT NULL,

    sale_date TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,

    subtotal NUMERIC(12,2) NOT NULL DEFAULT 0,
    discount NUMERIC(12,2) NOT NULL DEFAULT 0,
    tax NUMERIC(12,2) NOT NULL DEFAULT 0,
    total NUMERIC(12,2) NOT NULL DEFAULT 0,

    payment_status VARCHAR(20) NOT NULL DEFAULT 'PENDING',

    notes TEXT,

    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,

    CONSTRAINT fk_sales_branch
        FOREIGN KEY (branch_id)
        REFERENCES mini_estilo.branches(id),

    CONSTRAINT fk_sales_customer
        FOREIGN KEY (customer_id)
        REFERENCES mini_estilo.customers(id),

    CONSTRAINT fk_sales_user
        FOREIGN KEY (user_id)
        REFERENCES mini_estilo.users(id)
);
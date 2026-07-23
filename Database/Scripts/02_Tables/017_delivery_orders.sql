CREATE TABLE mini_estilo.delivery_orders (
    id SERIAL PRIMARY KEY,

    sale_id INTEGER NOT NULL UNIQUE,

    customer_name VARCHAR(150) NOT NULL,
    customer_phone VARCHAR(20) NOT NULL,

    delivery_address TEXT NOT NULL,
    city VARCHAR(100),

    delivery_status VARCHAR(30) NOT NULL DEFAULT 'PENDING',

    delivery_fee NUMERIC(12,2) DEFAULT 0,

    assigned_driver VARCHAR(100),

    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    delivered_at TIMESTAMP,

    CONSTRAINT fk_delivery_sale
        FOREIGN KEY (sale_id)
        REFERENCES mini_estilo.sales(id)
        ON DELETE CASCADE
);
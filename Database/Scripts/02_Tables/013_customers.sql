CREATE TABLE mini_estilo.customers (
    id SERIAL PRIMARY KEY,

    code VARCHAR(20) UNIQUE NOT NULL,
    first_name VARCHAR(100) NOT NULL,
    last_name VARCHAR(100),

    phone VARCHAR(20) UNIQUE,
    email VARCHAR(100),

    address TEXT,
    city VARCHAR(100),

    loyalty_points INTEGER DEFAULT 0,

    is_active BOOLEAN DEFAULT TRUE,

    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);
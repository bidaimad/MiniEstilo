CREATE TABLE mini_estilo.suppliers (
    id SERIAL PRIMARY KEY,

    code VARCHAR(20) UNIQUE NOT NULL,
    name VARCHAR(150) NOT NULL,

    phone VARCHAR(20),
    email VARCHAR(100),

    address TEXT,

    contact_person VARCHAR(100),

    notes TEXT,

    is_active BOOLEAN DEFAULT TRUE,

    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);
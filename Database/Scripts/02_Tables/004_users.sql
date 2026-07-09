CREATE TABLE mini_estilo.users (
    id SERIAL PRIMARY KEY,
    branch_id INTEGER NOT NULL,
    role_id INTEGER NOT NULL,

    first_name VARCHAR(100) NOT NULL,
    last_name VARCHAR(100) NOT NULL,

    username VARCHAR(50) NOT NULL UNIQUE,
    password_hash TEXT NOT NULL,

    phone VARCHAR(20),
    email VARCHAR(100),

    is_active BOOLEAN DEFAULT TRUE,

    last_login TIMESTAMP,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,

    CONSTRAINT fk_users_branch
        FOREIGN KEY (branch_id)
        REFERENCES mini_estilo.branches(id),

    CONSTRAINT fk_users_role
        FOREIGN KEY (role_id)
        REFERENCES mini_estilo.roles(id)
);
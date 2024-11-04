DROP DATABASE IF EXISTS grupo12_comc_club;
CREATE DATABASE grupo12_comc_club;

USE grupo12_comc_club;

/* tabla que contiene el usuario administrador */ 
CREATE TABLE empleado (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(50) NOT NULL,
    apellido VARCHAR(50) NOT NULL,
    dni VARCHAR(20) NOT NULL,
    email VARCHAR(100) NOT NULL,
    telefono VARCHAR(20) NOT NULL,
    fecha_nac DATE NOT NULL,
    rol VARCHAR(20) NOT NULL,
    usuario VARCHAR(20) NOT NULL,
    contrasenia VARCHAR(20) NOT NULL,
    CHECK (rol IN ('administrador', 'profesor'))
);

INSERT INTO empleado (nombre, apellido, dni, email, telefono, fecha_nac, rol, usuario, contrasenia)
VALUES ('Mariano', 'Javier', '12345678', 'mariano@clubdeportivo.com', '12222333', '1985-11-18', 'administrador', 'admin', '1234');

CREATE TABLE cliente (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(50) NOT NULL,
    apellido VARCHAR(50) NOT NULL,
    dni VARCHAR(20) NOT NULL,
    email VARCHAR(100) NOT NULL,
    telefono VARCHAR(20) NOT NULL,
    fecha_nac DATE NOT NULL,
    es_socio BOOLEAN NOT NULL,
    es_apto BOOLEAN NOT NULL
);

INSERT INTO cliente (nombre, apellido, dni, email, telefono, fecha_nac, es_socio, es_apto) VALUES
('María', 'González', '12345678A', 'maria.gonzalez@example.com', '611223344', '1990-05-15', TRUE, TRUE),
('Pedro', 'López', '23456789B', 'pedro.lopez@example.com', '622334455', '1985-11-03', FALSE, TRUE),
('Ana', 'Martínez', '34567890C', 'ana.martinez@example.com', '633445566', '1992-07-22', TRUE, FALSE),
('Juan', 'Sánchez', '45678901D', 'juan.sanchez@example.com', '644556677', '1980-03-11', TRUE, TRUE),
('Elena', 'Fernández', '56789012E', 'elena.fernandez@example.com', '655667788', '1995-12-18', FALSE, TRUE),
('Carlos', 'García', '67890123F', 'carlos.garcia@example.com', '666778899', '1987-09-30', TRUE, FALSE),
('Laura', 'Hernández', '78901234G', 'laura.hernandez@example.com', '677889900', '1993-02-08', FALSE, TRUE),
('Miguel', 'Pérez', '89012345H', 'miguel.perez@example.com', '688990011', '1991-06-27', TRUE, TRUE),
('Carmen', 'Rodríguez', '90123456I', 'carmen.rodriguez@example.com', '699001122', '1994-10-14', FALSE, FALSE),
('David', 'Ramírez', '01234567J', 'david.ramirez@example.com', '600112233', '1989-01-05', TRUE, TRUE),
('Sara', 'Flores', '11122334K', 'sara.flores@example.com', '611223344', '1996-04-19', TRUE, FALSE),
('Álvaro', 'Ruiz', '22233445L', 'alvaro.ruiz@example.com', '622334455', '1990-08-23', FALSE, TRUE),
('Isabel', 'Díaz', '33344556M', 'isabel.diaz@example.com', '633445566', '1988-11-07', TRUE, FALSE),
('José', 'Torres', '44455667N', 'jose.torres@example.com', '644556677', '1991-03-15', FALSE, TRUE),
('Patricia', 'Gómez', '55566778O', 'patricia.gomez@example.com', '655667788', '1992-09-05', TRUE, TRUE);

CREATE TABLE cuota_socio (
    id INT AUTO_INCREMENT PRIMARY KEY,
    descripcion VARCHAR(50) NOT NULL,
    monto DECIMAL(10, 2) NOT NULL
);

INSERT INTO cuota_socio (descripcion, monto)
VALUES 
('Regular', 35000.00),
('Premium', 40000.00);

CREATE TABLE actividad (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(50) NOT NULL,
    precio DECIMAL(10, 2) NOT NULL
);

INSERT INTO actividad (nombre, precio)
VALUES 
('Fútbol', 7500.00),
('Voley', 5000.00),
('Natación', 9000.00),
('Gimnasio', 6500.00),
('Pilates', 7000.00),
('Futsal', 7250.00),
('Basket', 6900.00),
('Tenis', 6700.00),
('Acquagym', 9300.00),
('Nutrición', 5500.00);

CREATE TABLE pago (
    id INT AUTO_INCREMENT PRIMARY KEY,
    id_cliente INT NOT NULL,
    monto DECIMAL(10, 2) NOT NULL,
    medio_de_pago VARCHAR(50) NOT NULL,
    fecha_pago DATE NOT NULL,
    periodo_inicio DATE NOT NULL, 
    periodo_fin DATE,    
    socio_al_pagar BOOLEAN NOT NULL, 
    id_cuota INT,  
    FOREIGN KEY (id_cliente) REFERENCES cliente(id),
    FOREIGN KEY (id_cuota) REFERENCES cuota_socio(id)
);

INSERT INTO pago (id_cliente, monto, medio_de_pago, fecha_pago, periodo_inicio, periodo_fin, socio_al_pagar, id_cuota) VALUES
(1, 35000.00, 'Efectivo', '2024-09-15', '2024-09-15', '2024-10-15', TRUE, 1),
(3, 40000.00, 'Tarjeta en 3 cuotas', '2024-08-10', '2024-08-10', '2024-11-10', TRUE, 2),
(4, 35000.00, 'Efectivo', '2024-07-05', '2024-07-05', '2024-08-05', TRUE, 1),
(6, 40000.00, 'Tarjeta en 6 cuotas', '2024-06-20', '2024-06-20', '2024-12-20', TRUE, 2),
(9, 35000.00, 'Efectivo', '2024-05-25', '2024-05-25', '2024-06-25', TRUE, 1),
(10, 40000.00, 'Tarjeta en 3 cuotas', '2024-04-30', '2024-04-30', '2024-07-30', TRUE, 2),
(12, 35000.00, 'Efectivo', '2024-03-15', '2024-03-15', '2024-04-15', TRUE, 1),
(15, 40000.00, 'Tarjeta en 6 cuotas', '2024-02-10', '2024-02-10', '2024-08-10', TRUE, 2),
(1, 35000.00, 'Efectivo', '2024-01-05', '2024-01-05', '2024-02-05', TRUE, 1),
(3, 40000.00, 'Tarjeta en 3 cuotas', '2023-12-20', '2023-12-20', '2024-03-20', TRUE, 2),
(6, 35000.00, 'Efectivo', '2023-11-15', '2023-11-15', '2023-12-15', TRUE, 1),
(9, 40000.00, 'Tarjeta en 6 cuotas', '2023-10-10', '2023-10-10', '2024-04-10', TRUE, 2),
(10, 35000.00, 'Efectivo', '2023-09-05', '2023-09-05', '2023-10-05', TRUE, 1),
(12, 40000.00, 'Tarjeta en 3 cuotas', '2023-08-01', '2023-08-01', '2023-11-01', TRUE, 2),
(15, 35000.00, 'Efectivo', '2023-07-25', '2023-07-25', '2023-08-25', TRUE, 1);

INSERT INTO pago (id_cliente, monto, medio_de_pago, fecha_pago, periodo_inicio, periodo_fin, socio_al_pagar, id_cuota) VALUES
(2, 5000.00, 'Efectivo', '2024-10-01', '2024-10-01', NULL, FALSE, NULL),
(5, 7000.00, 'Tarjeta en 3 cuotas', '2024-09-15', '2024-09-15', NULL, FALSE, NULL),
(14, 7500.00, 'Tarjeta en 6 cuotas', '2024-07-30', '2024-07-30', NULL, FALSE, NULL),
(12, 8000.00, 'Efectivo', '2024-06-25', '2024-06-25', NULL, FALSE, NULL),
(5, 6800.00, 'Tarjeta en 3 cuotas', '2024-05-10', '2024-05-10', NULL, FALSE, NULL),
(2, 5200.00, 'Efectivo', '2024-04-18', '2024-04-18', NULL, FALSE, NULL),
(14, 7600.00, 'Tarjeta en 6 cuotas', '2024-03-22', '2024-03-22', NULL, FALSE, NULL),
(5, 5900.00, 'Efectivo', '2024-02-15', '2024-02-15', NULL, FALSE, NULL),
(2, 7200.00, 'Tarjeta en 3 cuotas', '2024-01-05', '2024-01-05', NULL, FALSE, NULL),
(5, 4800.00, 'Efectivo', '2023-12-12', '2023-12-12', NULL, FALSE, NULL),
(14, 6700.00, 'Tarjeta en 6 cuotas', '2023-11-30', '2023-11-30', NULL, FALSE, NULL),
(2, 5300.00, 'Efectivo', '2023-10-20', '2023-10-20', NULL, FALSE, NULL),
(5, 6900.00, 'Tarjeta en 3 cuotas', '2023-09-15', '2023-09-15', NULL, FALSE, NULL),
(14, 6100.00, 'Efectivo', '2023-08-01', '2023-08-01', NULL, FALSE, NULL);

CREATE TABLE descuentos (
    id INT AUTO_INCREMENT PRIMARY KEY,
    tipo_pago VARCHAR(50) NOT NULL,
    valor_descuento DECIMAL(5, 2) NOT NULL
);

INSERT INTO descuentos (tipo_pago, valor_descuento) VALUES 
    ('Tarjeta en 3 cuotas', 0.10),
    ('Tarjeta en 6 cuotas', 0.05),
    ('Efectivo', 0.20);


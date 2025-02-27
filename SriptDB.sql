CREATE TABLE Producto (
    id_producto INTEGER IDENTITY PRIMARY KEY NOT NULL,
    codigo VARCHAR(50) NOT NULL,
    nombre VARCHAR(50) NOT NULL,
    existencias INTEGER NOT NULL, 
    precio DECIMAL(18,2) NOT NULL
);

CREATE TABLE Factura (
    id_factura INTEGER IDENTITY PRIMARY KEY NOT NULL,
    numero_factura VARCHAR(50) NOT NULL, 
    fecha DATETIME2(7) DEFAULT(getdate()) NOT NULL,
    total DECIMAL(18,2) NOT NULL,
    productos_adquiridos INTEGER NOT NULL
)

-- CREATE TABLE Venta(
--     id_venta INTEGER IDENTITY PRIMARY KEY NOT NULL,
--     id_producto INTEGER NOT NULL,
--     id_factura INTEGER NOT NULL,
-- )
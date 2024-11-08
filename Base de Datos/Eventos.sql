-- Crear la base de datos
CREATE DATABASE Eventos;
GO

USE Eventos;
GO

-- Tabla de Empleados (incluye datos de usuario)
CREATE TABLE Empleados (
    EmpleadoID INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL,
    Apellido NVARCHAR(100) NOT NULL,
    Rol NVARCHAR(50) NOT NULL CHECK (Rol IN ('Administrador', 'Empleado')), -- Validación para el rol
    Email NVARCHAR(100) UNIQUE,
    Telefono NVARCHAR(15),
    NombreUsuario NVARCHAR(50) UNIQUE NOT NULL,
    Contraseña NVARCHAR(255) NOT NULL, -- Almacenamiento simple de contraseñas
    FechaCreacion DATETIME DEFAULT GETDATE()
);
GO

-- Tabla de Salas
CREATE TABLE Salas (
    SalaID INT PRIMARY KEY IDENTITY(1,1),
    NombreSala NVARCHAR(100) NOT NULL UNIQUE, -- Asegura que no haya duplicación de nombres de salas
    Capacidad INT NOT NULL CHECK (Capacidad > 0), -- Asegura que la capacidad sea positiva
    Ubicacion NVARCHAR(200),
    Caracteristicas NVARCHAR(MAX)
);
GO

-- Tabla de Paquetes (incluye detalles de los artículos)
CREATE TABLE Paquetes (
    PaqueteID INT PRIMARY KEY IDENTITY(1,1),
    NombrePaquete NVARCHAR(100) NOT NULL UNIQUE, -- Evita duplicación de nombres de paquetes
    Descripcion NVARCHAR(MAX),
    Articulos NVARCHAR(MAX) -- Lista de artículos y cantidades en formato de texto
);
GO

-- Tabla de Clientes
CREATE TABLE Clientes (
    ClienteID INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL,
    Apellido NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100) UNIQUE,
    Telefono NVARCHAR(15),
    Direccion NVARCHAR(255)
);
GO

-- Tabla de Eventos (con asociación de paquetes, empleado encargado y estado del evento)
CREATE TABLE Eventos (
    EventoID INT PRIMARY KEY IDENTITY(1,1),
    NombreEvento NVARCHAR(100) NOT NULL UNIQUE, -- Evita duplicación de nombres de eventos
    FechaInicio DATETIME NOT NULL,
    FechaFin DATETIME NOT NULL,
    Descripcion NVARCHAR(MAX),
    SalaID INT FOREIGN KEY REFERENCES Salas(SalaID),
    ClienteID INT FOREIGN KEY REFERENCES Clientes(ClienteID),
    PaqueteID INT FOREIGN KEY REFERENCES Paquetes(PaqueteID), -- Asocia un paquete opcionalmente
    EmpleadoID INT FOREIGN KEY REFERENCES Empleados(EmpleadoID), -- Empleado encargado del evento
    Estado NVARCHAR(20) DEFAULT 'Pendiente' CHECK (Estado IN ('Pendiente', 'En curso', 'Completado', 'Cancelado')) -- Estado del evento
);
GO

-- Agregar la restricción CHECK para validar las fechas de los eventos
ALTER TABLE Eventos
ADD CONSTRAINT CHK_FechaFin CHECK (FechaFin > FechaInicio);
GO

-- Tabla de Facturas
CREATE TABLE Facturas (
    FacturaID INT PRIMARY KEY IDENTITY(1,1),
    EventoID INT FOREIGN KEY REFERENCES Eventos(EventoID) ON DELETE CASCADE,
    ClienteID INT FOREIGN KEY REFERENCES Clientes(ClienteID),
    FechaFactura DATETIME DEFAULT GETDATE(),
    MontoTotal DECIMAL(10, 2) NOT NULL CHECK (MontoTotal > 0),
    Estado NVARCHAR(20) DEFAULT 'Pendiente' CHECK (Estado IN ('Pendiente', 'Pagada'))
);
GO

-- Inserción de un Administrador
INSERT INTO Empleados (Nombre, Apellido, Rol, Email, Telefono, NombreUsuario, Contraseña)
VALUES ('Juan', 'Perez', 'Administrador', 'juan@gmail.com', '12345678', 'juan', '1234');

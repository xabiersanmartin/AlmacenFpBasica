--
-- File generated with SQLiteStudio v3.2.1 on mi. oct. 30 11:24:03 2019
--
-- Text encoding used: System
--
PRAGMA foreign_keys = off;
BEGIN TRANSACTION;

-- Table: administrador
CREATE TABLE administrador (Nombre TEXT (255) NOT NULL, Password TEXT (255) NOT NULL);

-- Table: categoria
CREATE TABLE categoria (CodigoCategoria INT PRIMARY KEY DESC NOT NULL, NombreCategoria TEXT (255) NOT NULL);

-- Table: Empresa
CREATE TABLE Empresa (Nombre TEXT (255) NOT NULL, Logo TEXT (255) NOT NULL);

-- Table: productos
CREATE TABLE productos (CodigoProducto INT NOT NULL, Descripcion TEXT (255) NOT NULL, Talla TEXT (255) NOT NULL, Stock INT NOT NULL, Precio DECIMAL NOT NULL, CodigoCategoria INT NOT NULL, CodigoSubCategoria INT NOT NULL, PRIMARY KEY (CodigoProducto DESC), FOREIGN KEY (CodigoCategoria, CodigoSubCategoria) REFERENCES subcategoria (CodigoCategoria, CodigoSubcategoria));

-- Table: subcategoria
CREATE TABLE subcategoria (CodigoSubCategoria INT NOT NULL, CodigoCategoria INT REFERENCES categoria (CodigoCategoria) NOT NULL, NombreSubCategoria TEXT (255) NOT NULL, PRIMARY KEY (CodigoSubCategoria DESC, CodigoCategoria DESC));

COMMIT TRANSACTION;
PRAGMA foreign_keys = on;

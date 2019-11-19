--
-- File generated with SQLiteStudio v3.2.1 on mi. nov. 6 11:15:51 2019
--
-- Text encoding used: System
--
PRAGMA foreign_keys = off;
BEGIN TRANSACTION;

CREATE DATABASE almacen
USE almacen

-- Table: administrador
DROP TABLE IF EXISTS administrador;
CREATE TABLE administrador (Nombre TEXT (255) NOT NULL, Password TEXT (255) NOT NULL);

-- Table: categoria
DROP TABLE IF EXISTS categoria;
CREATE TABLE categoria (CodigoCategoria INTEGER PRIMARY KEY DESC NOT NULL, CodigoTipo INTEGER NOT NULL REFERENCES tipo (CodigoTipo), NombreCategoria TEXT (255) NOT NULL);

-- Table: Empresa
DROP TABLE IF EXISTS Empresa;
CREATE TABLE Empresa (Nombre TEXT (255) NOT NULL, Logo TEXT (255) NOT NULL);

-- Table: medidas
DROP TABLE IF EXISTS medidas;
CREATE TABLE medidas (CodigoMedida INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, CodigoTipo INTEGER NOT NULL REFERENCES tipo (CodigoTipo), Medida TEXT NOT NULL);

-- Table: productos
DROP TABLE IF EXISTS productos;
CREATE TABLE productos (CodigoProducto INTEGER NOT NULL, CodigoCategoria INTEGER NOT NULL, CodigoSubCategoria INTEGER NOT NULL, Descripcion TEXT (255) NOT NULL, Stock INTEGER NOT NULL, Precio DECIMAL NOT NULL, PRIMARY KEY (CodigoProducto DESC), FOREIGN KEY (CodigoCategoria, CodigoSubCategoria) REFERENCES subcategoria (CodigoCategoria, CodigoSubcategoria));

-- Table: subcategoria
DROP TABLE IF EXISTS subcategoria;
CREATE TABLE subcategoria (CodigoCategoria INTEGER REFERENCES categoria (CodigoCategoria) NOT NULL, CodigoSubCategoria INTEGER NOT NULL, NombreSubCategoria TEXT (255) NOT NULL, PRIMARY KEY (CodigoSubCategoria DESC, CodigoCategoria DESC));

-- Table: tipo
DROP TABLE IF EXISTS tipo;
CREATE TABLE tipo (CodigoTipo INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, Tipo TEXT NOT NULL);

COMMIT TRANSACTION;
PRAGMA foreign_keys = on;

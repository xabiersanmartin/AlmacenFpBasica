
DROP DATABASE IF EXISTS almacen;

CREATE DATABASE almacen;

USE almacen;

DROP TABLE IF EXISTS administrador;
CREATE TABLE administrador (Nombre TEXT (255) NOT NULL, Password TEXT (255) NOT NULL);

DROP TABLE IF EXISTS categoria;
CREATE TABLE categoria (CodigoCategoria INTEGER NOT NULL PRIMARY KEY UNIQUE, CodigoTipo INTEGER NOT NULL, NombreCategoria TEXT (255) NOT NULL, FOREIGN KEY (CodigoTipo) REFERENCES tipo (CodigoTipo));

DROP TABLE IF EXISTS Empresa;
CREATE TABLE Empresa (Nombre TEXT (255) NOT NULL, Logo TEXT (255) NOT NULL);

DROP TABLE IF EXISTS medidas;
CREATE TABLE medidas (CodigoMedida INTEGER NOT NULL PRIMARY KEY UNIQUE, CodigoTipo INTEGER NOT NULL, Medida TEXT NOT NULL, FOREIGN KEY (CodigoTipo) REFERENCES tipo (CodigoTipo));

DROP TABLE IF EXISTS productos;
CREATE TABLE productos (CodigoProducto INTEGER NOT NULL PRIMARY KEY UNIQUE, CodigoCategoria INTEGER NOT NULL, CodigoSubCategoria INTEGER NOT NULL, Descripcion TEXT (255) NOT NULL, Stock INTEGER NOT NULL, Precio DECIMAL NOT NULL, FOREIGN KEY (CodigoCategoria, CodigoSubCategoria) REFERENCES subcategoria (CodigoCategoria, CodigoSubcategoria));

DROP TABLE IF EXISTS subcategoria;
CREATE TABLE subcategoria (CodigoCategoria INTEGER NOT NULL, CodigoSubCategoria INTEGER NOT NULL, NombreSubCategoria TEXT (255) NOT NULL, PRIMARY KEY (CodigoSubCategoria DESC, CodigoCategoria DESC), FOREIGN KEY (CodigoCategoria) REFERENCES categoria (CodigoCategoria));

DROP TABLE IF EXISTS tipo;
CREATE TABLE tipo (CodigoTipo INTEGER NOT NULL UNIQUE PRIMARY KEY AUTOINCREMENT, Tipo TEXT NOT NULL);

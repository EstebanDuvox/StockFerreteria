-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Versión del servidor:         5.5.27 - MySQL Community Server (GPL)
-- SO del servidor:              Win32
-- HeidiSQL Versión:             9.5.0.5196
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Volcando estructura de base de datos para stockmanager
CREATE DATABASE IF NOT EXISTS `stockmanager` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `stockmanager`;

-- Volcando estructura para tabla stockmanager.cabecera_facturas
CREATE TABLE IF NOT EXISTS `cabecera_facturas` (
  `Id_Factura` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Id_Cliente` int(10) unsigned NOT NULL,
  `TipoFac_Ca` enum('A','B','C','E','M','T') DEFAULT NULL,
  `CAE` bigint(15) NOT NULL,
  `FechaVen_CAE` date NOT NULL,
  `Total` int(10) NOT NULL,
  PRIMARY KEY (`Id_Factura`),
  KEY `FK_cabecera_facturas_clientes` (`Id_Cliente`),
  CONSTRAINT `FK_cabecera_facturas_clientes` FOREIGN KEY (`Id_Cliente`) REFERENCES `clientes` (`Id_Cliente`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla stockmanager.cabecera_facturas: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `cabecera_facturas` DISABLE KEYS */;
/*!40000 ALTER TABLE `cabecera_facturas` ENABLE KEYS */;

-- Volcando estructura para tabla stockmanager.cabecera_kardex
CREATE TABLE IF NOT EXISTS `cabecera_kardex` (
  `Id_cabKardex` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Cant_Max` smallint(6) NOT NULL,
  `Cant_Min` smallint(6) NOT NULL,
  `Metodo` enum('PEPS','UEPS','Promedio Ponderado') DEFAULT NULL,
  `Codigo_P` int(10) unsigned NOT NULL,
  PRIMARY KEY (`Id_cabKardex`),
  KEY `FK_cabecera_kardex_productos` (`Codigo_P`),
  CONSTRAINT `FK_cabecera_kardex_productos` FOREIGN KEY (`Codigo_P`) REFERENCES `productos` (`Codigo_P`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla stockmanager.cabecera_kardex: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `cabecera_kardex` DISABLE KEYS */;
/*!40000 ALTER TABLE `cabecera_kardex` ENABLE KEYS */;

-- Volcando estructura para tabla stockmanager.categorias_p
CREATE TABLE IF NOT EXISTS `categorias_p` (
  `id_categoria` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `categoria` varchar(25) NOT NULL,
  PRIMARY KEY (`id_categoria`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla stockmanager.categorias_p: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `categorias_p` DISABLE KEYS */;
/*!40000 ALTER TABLE `categorias_p` ENABLE KEYS */;

-- Volcando estructura para tabla stockmanager.clientes
CREATE TABLE IF NOT EXISTS `clientes` (
  `Id_Cliente` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Nombre_C` varchar(20) DEFAULT NULL,
  `Apellido_C` varchar(25) NOT NULL,
  `Cuit` bigint(12) NOT NULL,
  `Direccion_C` varchar(40) DEFAULT NULL,
  `Tipo_Con` enum('IVA Responsable Inscripto','IVA Responsable no incripto','IVA no Responsable','IVA Sujeto Exento','Consumidor Final','Responsable Monotributo','Sujeto no Categorizado','Proveedor del Exterior','Cliente del Exterior','IVA Liberado - Ley N°19.640','IVA Responsable incripto-Agente de Percepcion','Pequeño Contribuyente Eventual','Monotributista Social','Pequeño Contribuyente Eventual Social') DEFAULT NULL,
  `eMail` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Id_Cliente`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla stockmanager.clientes: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `clientes` DISABLE KEYS */;
/*!40000 ALTER TABLE `clientes` ENABLE KEYS */;

-- Volcando estructura para tabla stockmanager.detalles_facturas
CREATE TABLE IF NOT EXISTS `detalles_facturas` (
  `Id_DetFac` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Id_Factura` int(10) unsigned NOT NULL,
  `Codigo_P` int(10) unsigned NOT NULL,
  `Cant` int(10) unsigned NOT NULL,
  `Precio` int(10) unsigned NOT NULL,
  `Subtotal` int(10) unsigned NOT NULL,
  `Iva` enum('10.5%','21%') NOT NULL,
  `Total` int(10) NOT NULL,
  PRIMARY KEY (`Id_DetFac`),
  KEY `Id_Factura` (`Id_Factura`),
  KEY `detalles_facturas_ibfk_1` (`Codigo_P`),
  CONSTRAINT `detalles_facturas_ibfk_1` FOREIGN KEY (`Codigo_P`) REFERENCES `productos` (`Codigo_P`),
  CONSTRAINT `detalles_facturas_ibfk_2` FOREIGN KEY (`Id_Factura`) REFERENCES `cabecera_facturas` (`Id_Factura`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla stockmanager.detalles_facturas: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `detalles_facturas` DISABLE KEYS */;
/*!40000 ALTER TABLE `detalles_facturas` ENABLE KEYS */;

-- Volcando estructura para tabla stockmanager.detalles_kardex
CREATE TABLE IF NOT EXISTS `detalles_kardex` (
  `Id_detKardex` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Id_cabKardex` int(10) unsigned NOT NULL,
  `Fecha_K` date DEFAULT NULL,
  `Cant` smallint(6) DEFAULT NULL,
  `Precio` mediumint(9) DEFAULT NULL,
  `Movimiento` enum('Entrada','Salida') DEFAULT NULL,
  `Cant_Total` smallint(6) DEFAULT NULL,
  PRIMARY KEY (`Id_detKardex`),
  KEY `Id_cabKardex` (`Id_cabKardex`),
  CONSTRAINT `FK_detalles_kardex_cabecera_kardex` FOREIGN KEY (`Id_cabKardex`) REFERENCES `cabecera_kardex` (`Id_cabKardex`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla stockmanager.detalles_kardex: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `detalles_kardex` DISABLE KEYS */;
/*!40000 ALTER TABLE `detalles_kardex` ENABLE KEYS */;

-- Volcando estructura para tabla stockmanager.marcas_p
CREATE TABLE IF NOT EXISTS `marcas_p` (
  `id_Marca` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Marca` varchar(25) NOT NULL,
  PRIMARY KEY (`id_Marca`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla stockmanager.marcas_p: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `marcas_p` DISABLE KEYS */;
/*!40000 ALTER TABLE `marcas_p` ENABLE KEYS */;

-- Volcando estructura para tabla stockmanager.productos
CREATE TABLE IF NOT EXISTS `productos` (
  `Codigo_P` int(10) unsigned NOT NULL,
  `Id_Marca` int(10) unsigned NOT NULL,
  `Modelo` varchar(25) NOT NULL,
  `Precio_E` smallint(6) NOT NULL,
  `Precio_S` smallint(6) DEFAULT NULL,
  `Id_categoria` int(10) unsigned DEFAULT NULL,
  `Id_Proveedores` int(10) unsigned DEFAULT NULL,
  PRIMARY KEY (`Codigo_P`),
  KEY `Id_Marca` (`Id_Marca`),
  KEY `Id_Categoria` (`Id_categoria`),
  KEY `productos_ibfk_2` (`Id_Proveedores`),
  CONSTRAINT `productos_ibfk_1` FOREIGN KEY (`Id_Marca`) REFERENCES `marcas_p` (`id_Marca`),
  CONSTRAINT `productos_ibfk_2` FOREIGN KEY (`Id_Proveedores`) REFERENCES `proveedores` (`Id_Proveedores`),
  CONSTRAINT `productos_ibfk_3` FOREIGN KEY (`Id_categoria`) REFERENCES `categorias_p` (`id_categoria`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla stockmanager.productos: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `productos` DISABLE KEYS */;
/*!40000 ALTER TABLE `productos` ENABLE KEYS */;

-- Volcando estructura para tabla stockmanager.proveedores
CREATE TABLE IF NOT EXISTS `proveedores` (
  `Id_Proveedores` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Empresa_P` varchar(20) NOT NULL,
  `Cuit_P` bigint(12) unsigned NOT NULL,
  `Direccion_P` varchar(20) DEFAULT NULL,
  `Telefono_P` bigint(12) NOT NULL,
  `eMail` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Id_Proveedores`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla stockmanager.proveedores: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `proveedores` DISABLE KEYS */;
/*!40000 ALTER TABLE `proveedores` ENABLE KEYS */;

-- Volcando estructura para tabla stockmanager.usuarios
CREATE TABLE IF NOT EXISTS `usuarios` (
  `Id_Usuario` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Nom_U` varchar(20) NOT NULL,
  `Con_U` varchar(16) NOT NULL,
  `Tipo_U` enum('Gerente','Administrador','Personal') NOT NULL DEFAULT 'Personal',
  PRIMARY KEY (`Id_Usuario`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla stockmanager.usuarios: ~3 rows (aproximadamente)
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` (`Id_Usuario`, `Nom_U`, `Con_U`, `Tipo_U`) VALUES
	(1, 'MED', '1234', 'Administrador'),
	(2, 'GG', '1234', 'Gerente'),
	(3, 'Juan_M', 'hola', 'Personal');
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;

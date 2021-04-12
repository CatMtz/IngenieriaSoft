-- MySQL dump 10.13  Distrib 8.0.19, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: ingsoft
-- ------------------------------------------------------
-- Server version	8.0.19

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `cliente`
--

DROP TABLE IF EXISTS `cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cliente` (
  `IdCliente` int NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(30) NOT NULL,
  `Telefono` varchar(10) NOT NULL,
  `Direccion` varchar(40) NOT NULL,
  PRIMARY KEY (`IdCliente`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cliente`
--

LOCK TABLES `cliente` WRITE;
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
INSERT INTO `cliente` VALUES (1,'Omar Martinez','4451223569','Prol. 5 de mayo #129'),(2,'jesica solorio','123456890','panindicuaro');
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalleproducto`
--

DROP TABLE IF EXISTS `detalleproducto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `detalleproducto` (
  `precio` decimal(10,2) NOT NULL,
  `cantidad` int NOT NULL,
  `idCompra` int NOT NULL,
  `IdProducto` int NOT NULL,
  PRIMARY KEY (`idCompra`,`IdProducto`),
  KEY `fk_detalleproducto_producto1_idx` (`IdProducto`),
  CONSTRAINT `fk_detalleproducto_producto1` FOREIGN KEY (`IdProducto`) REFERENCES `producto` (`IdProducto`),
  CONSTRAINT `fk_detalleproducto_venta1` FOREIGN KEY (`idCompra`) REFERENCES `venta` (`idCompra`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalleproducto`
--

LOCK TABLES `detalleproducto` WRITE;
/*!40000 ALTER TABLE `detalleproducto` DISABLE KEYS */;
/*!40000 ALTER TABLE `detalleproducto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `gerente`
--

DROP TABLE IF EXISTS `gerente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `gerente` (
  `IdGerente` int NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(20) NOT NULL,
  `Apellidos` varchar(30) NOT NULL,
  `UserName` varchar(10) NOT NULL,
  `password` varchar(40) NOT NULL,
  PRIMARY KEY (`IdGerente`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `gerente`
--

LOCK TABLES `gerente` WRITE;
/*!40000 ALTER TABLE `gerente` DISABLE KEYS */;
INSERT INTO `gerente` VALUES (1,'Luis Fernando','Rojas Martinez','ChitoRM','Chito123'),(2,'Karina','Gonzalez Cortez','KarinaGC','Karina123');
/*!40000 ALTER TABLE `gerente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pagos`
--

DROP TABLE IF EXISTS `pagos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pagos` (
  `idPago` int NOT NULL AUTO_INCREMENT,
  `Fecha` datetime NOT NULL,
  `idCompra` int NOT NULL,
  `Cantidad` decimal(10,2) NOT NULL,
  PRIMARY KEY (`idPago`),
  KEY `fk_Pagos_venta1_idx` (`idCompra`),
  CONSTRAINT `fk_Pagos_venta1` FOREIGN KEY (`idCompra`) REFERENCES `venta` (`idCompra`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pagos`
--

LOCK TABLES `pagos` WRITE;
/*!40000 ALTER TABLE `pagos` DISABLE KEYS */;
/*!40000 ALTER TABLE `pagos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `producto`
--

DROP TABLE IF EXISTS `producto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `producto` (
  `IdProducto` int NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(35) NOT NULL,
  `precio` decimal(10,2) NOT NULL,
  `Descripcion` text NOT NULL,
  `Categoria` varchar(15) NOT NULL,
  PRIMARY KEY (`IdProducto`)
) ENGINE=InnoDB AUTO_INCREMENT=60 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `producto`
--

LOCK TABLES `producto` WRITE;
/*!40000 ALTER TABLE `producto` DISABLE KEYS */;
INSERT INTO `producto` VALUES (1,'MATE CANTIMPLORA M1',60.00,'500 ml','Termo'),(2,'PAW PATROL CANTIMPLORA M1',60.00,'500 ml','Termo'),(3,'RAYO MCQUEEN CANTIMPLORA M1',60.00,' 500 ml','Termo'),(4,'THOR',50.00,' 420 ML','Termo'),(5,'PAW PATROL CHUPON',35.00,'530 ml','Termo'),(6,'PAW PATROL ROJO',45.00,'490 ml','Termo'),(7,'VASO ENTRENADOR',25.00,'300 ml','Termo'),(8,'AVENGERS CANTIMPLORA M2',60.00,'500 ml','Termo'),(9,'I NEED SPACE',35.00,'473 ml','Termo'),(10,'JARRA MARVEL (HULK)',20.00,'1.0 litros','Termo'),(11,'PRINCESAS CANTIMPLORA M2',60.00,'500 ml','Termo'),(12,'WOODY  CANTIMPLORA M2',60.00,'500 ml','Termo'),(13,'BUZZ LIGHTYEAR CANTIMPLORA M1',60.00,' 500 ml','Termo'),(14,'BOTELLA MINNIE & MICKEY MOUSE',35.00,'850 ml','Termo'),(15,'PAW PATROL SNACK',85.00,'300 ml','Termo'),(16,'TAZA OSITO',100.00,' ','Termo'),(17,'BOTELLAS TOY STORY',60.00,'900 ml','Termo'),(18,'BOTELLA FROZEN',60.00,'750 ml','Termo'),(19,'PAW PATROL LLAVE',80.00,'550 ml','Termo'),(20,'FROZEN CANTINFLORA M1',60.00,'500 ml','Termo'),(21,'MISTER VASO',35.00,' ','Termo'),(22,'FROZEN CANTINFLORA M2',60.00,'500 ml','Termo'),(23,'TARRO MARVEL',35.00,' ','Termo'),(24,'BOTELLA TROLLS',60.00,'870 ml','Termo'),(25,'SPIDERMAN LLAVE',70.00,'500 ml','Termo'),(26,'BOTELLA AVENGERS',60.00,' 900 ml','Termo'),(27,'BOTELLA MICKEY',60.00,'900 ml','Termo'),(28,'AVENGERS LLAVE',80.00,'700 ml','Termo'),(29,'PRINCESAS CHUPON',35.00,'530 ml','Termo'),(30,'CARS CHUPON',35.00,'530 ml','Termo'),(31,'BOTELLA COLORES',35.00,'850 ml','Termo'),(32,'AVENGERS CHUPON',60.00,'530 ml','Termo'),(33,'BOTELLA DEPORTIVA',35.00,'750 ml ','Termo'),(34,'BOTELLA MINIONS',60.00,'850 ml','Termo'),(35,'BOTELLA MINIE MOUSE',70.00,'500 ml','Termo'),(36,'BOTELLA PRINCESAS ROSA',60.00,' 900 ml','Termo'),(37,'BOTELLA PRINCESAS TRANPARENTE',60.00,'900 ml','Termo'),(38,'BOTELLA REY LEON',80.00,'900 ml','Termo'),(39,'BOTELLA SPIDERMAN',35.00,'900 ml','Termo'),(40,'BOTELLA MINIONS',35.00,'900 ml','Termo'),(41,'BOTELLA FROZEN AZUL',80.00,'900 ml','Termo'),(42,'BOTELLA FROZEN TRANSPARENTE',35.00,'900 ml','Termo'),(43,'BOTELLA AVENGERS',35.00,'900 ml','Termo'),(44,'SHADOW',180.00,'BLANCO VINO','Tenis'),(45,'NIKE',180.00,'N-20','Tenis'),(46,'NIKE KYWIS',180.00,' ','Tenis'),(47,'PUMA ROMA ',180.00,'AMARILLO','Tenis'),(48,'AFI NIKE',180.00,'NEGRO TOTAL','Tenis'),(49,'TRECK 1010 ',180.00,'BLANCO PLATA','Tenis'),(50,'ADIDAS',180.00,'CONCHA FRANCIA','Tenis'),(51,'VANS 500',180.00,'OXFORD','Tenis'),(52,'PUMA',180.00,'TRANSFORT 8.5','Tenis'),(53,'N-020 7.5',180.00,' ','Tenis'),(54,'ADIDAS 006',180.00,'NEGRO BLANCO','Tenis'),(55,'NIKE 1070 6',180.00,'','Tenis'),(56,'NIKE',180.00,'NEGRO NEON','Tenis'),(57,'NIKE XP',180.00,' ','Tenis'),(58,'SOCK DART',180.00,' ','Tenis'),(59,'TENIS TRECK 501',180.00,' ','Tenis');
/*!40000 ALTER TABLE `producto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `venta`
--

DROP TABLE IF EXISTS `venta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `venta` (
  `idCompra` int NOT NULL AUTO_INCREMENT,
  `IdGerente` int NOT NULL,
  `IdCliente` int NOT NULL,
  `Descripcion` text NOT NULL,
  `Cantidad_Venta` decimal(10,2) NOT NULL,
  `Tipo` enum('Credito','Contado') NOT NULL,
  `Saldo` decimal(10,2) NOT NULL,
  `Fecha` datetime NOT NULL,
  PRIMARY KEY (`idCompra`),
  KEY `compra` (`IdGerente`),
  KEY `Cliente_idx` (`IdCliente`),
  CONSTRAINT `Cliente` FOREIGN KEY (`IdCliente`) REFERENCES `cliente` (`IdCliente`),
  CONSTRAINT `Usuario` FOREIGN KEY (`IdGerente`) REFERENCES `gerente` (`IdGerente`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `venta`
--

LOCK TABLES `venta` WRITE;
/*!40000 ALTER TABLE `venta` DISABLE KEYS */;
INSERT INTO `venta` VALUES (6,1,1,'PAW PATROL CANTIMPLORA M1',60.00,'Credito',60.00,'2021-04-06 17:17:30'),(7,1,2,'BOTELLA AVENGERS',35.00,'Credito',35.00,'2021-04-06 17:35:29');
/*!40000 ALTER TABLE `venta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'ingsoft'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-04-11 19:49:54

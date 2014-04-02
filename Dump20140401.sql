CREATE DATABASE  IF NOT EXISTS `punto_venta_autolavado` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `punto_venta_autolavado`;
-- MySQL dump 10.13  Distrib 5.6.13, for Win32 (x86)
--
-- Host: 127.0.0.1    Database: punto_venta_autolavado
-- ------------------------------------------------------
-- Server version	5.6.16

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `cat_puestos`
--

DROP TABLE IF EXISTS `cat_puestos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cat_puestos` (
  `id_puesto` int(11) NOT NULL AUTO_INCREMENT,
  `decripcion` varchar(45) NOT NULL,
  PRIMARY KEY (`id_puesto`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cat_puestos`
--

LOCK TABLES `cat_puestos` WRITE;
/*!40000 ALTER TABLE `cat_puestos` DISABLE KEYS */;
INSERT INTO `cat_puestos` VALUES (1,'sys_admin'),(2,'cajero'),(3,'lavador');
/*!40000 ALTER TABLE `cat_puestos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cat_tamanos`
--

DROP TABLE IF EXISTS `cat_tamanos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cat_tamanos` (
  `id_tamano` int(11) NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(45) NOT NULL,
  `costo` double NOT NULL,
  PRIMARY KEY (`id_tamano`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cat_tamanos`
--

LOCK TABLES `cat_tamanos` WRITE;
/*!40000 ALTER TABLE `cat_tamanos` DISABLE KEYS */;
INSERT INTO `cat_tamanos` VALUES (1,'bocho',0.5);
/*!40000 ALTER TABLE `cat_tamanos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalle_ticket`
--

DROP TABLE IF EXISTS `detalle_ticket`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `detalle_ticket` (
  `id_detalle` int(11) NOT NULL AUTO_INCREMENT,
  `id_ticket` int(11) NOT NULL,
  `id_servicio` int(11) NOT NULL,
  `promocion` bit(1) NOT NULL,
  `ahorro` double NOT NULL,
  PRIMARY KEY (`id_detalle`),
  KEY `fk_detalle_servicio_idx` (`id_servicio`),
  KEY `fk_detalle_ticket_idx` (`id_ticket`),
  CONSTRAINT `fk_detalle_servicio` FOREIGN KEY (`id_servicio`) REFERENCES `servicio` (`idservicio`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_detalle_tamano` FOREIGN KEY (`id_servicio`) REFERENCES `cat_tamanos` (`id_tamano`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_detalle_tocket` FOREIGN KEY (`id_ticket`) REFERENCES `ticket` (`id_ticket`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=174 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalle_ticket`
--

LOCK TABLES `detalle_ticket` WRITE;
/*!40000 ALTER TABLE `detalle_ticket` DISABLE KEYS */;
INSERT INTO `detalle_ticket` VALUES (2,5,1,'',1.6),(3,5,1,'',1.6),(4,5,1,'',1.6),(5,5,1,'',1.6),(6,5,1,'',1.6),(7,5,1,'',1.6),(8,5,1,'',1.6),(9,5,1,'',1.6),(10,5,1,'',1.6),(11,6,1,'',1.6),(12,6,1,'',1.6),(13,6,1,'',1.6),(14,6,1,'',1.6),(15,6,1,'',1.6),(16,6,1,'',1.6),(17,6,1,'',1.6),(18,6,1,'',1.6),(19,6,1,'',1.6),(20,7,1,'',1.6),(21,7,1,'',1.6),(22,7,1,'',1.6),(23,7,1,'',1.6),(24,7,1,'',1.6),(25,7,1,'',1.6),(26,7,1,'',1.6),(27,7,1,'',1.6),(28,7,1,'',1.6),(29,8,1,'',1.6),(30,8,1,'',1.6),(31,8,1,'',1.6),(32,8,1,'',1.6),(33,8,1,'',1.6),(34,8,1,'',1.6),(35,8,1,'',1.6),(36,9,1,'',1.6),(37,9,1,'',1.6),(38,9,1,'',1.6),(39,9,1,'',1.6),(40,9,1,'',1.6),(41,11,1,'',1.6),(42,11,1,'',1.6),(43,11,1,'',1.6),(44,11,1,'',1.6),(45,11,1,'',1.6),(46,11,1,'',1.6),(47,11,1,'',1.6),(48,11,1,'',1.6),(49,11,1,'',1.6),(50,11,1,'',1.6),(51,12,1,'',1.6),(52,12,1,'',1.6),(53,12,1,'',1.6),(54,12,1,'',1.6),(55,14,1,'',-1.3),(56,14,1,'',-1.3),(57,14,1,'',-1.3),(58,14,1,'',-1.3),(59,14,1,'',-1.3),(60,14,1,'',-1.3),(61,14,1,'',-1.3),(62,14,1,'',-1.3),(63,14,1,'',-1.3),(64,14,1,'',-1.3),(65,14,1,'',-1.3),(66,14,1,'',-1.3),(67,14,1,'',-1.3),(68,14,1,'',-1.3),(69,14,1,'',-1.3),(70,14,1,'',-1.3),(71,14,1,'',-1.3),(72,14,1,'',-1.3),(73,14,1,'',-1.3),(74,15,1,'',-1.3),(75,15,1,'',-1.3),(76,15,1,'',-1.3),(77,15,1,'',-1.3),(78,15,1,'',-1.3),(79,15,1,'',-1.3),(80,15,1,'',-1.3),(81,15,1,'',-1.3),(82,16,1,'',-1.3),(83,16,1,'',-1.3),(84,16,1,'',-1.3),(85,16,1,'',-1.3),(86,16,1,'',-1.3),(87,16,1,'',-1.3),(88,16,1,'',-1.3),(89,16,1,'',-1.3),(90,16,1,'',-1.3),(91,16,1,'',-1.3),(92,16,1,'',-1.3),(93,16,1,'',-1.3),(94,16,1,'',-1.3),(95,16,1,'',-1.3),(96,16,1,'',-1.3),(97,16,1,'',-1.3),(98,17,1,'',-1.3),(99,17,1,'',-1.3),(100,17,1,'',-1.3),(101,17,1,'',-1.3),(102,17,1,'',-1.3),(103,17,1,'',-1.3),(104,17,1,'',-1.3),(105,17,1,'',-1.3),(106,17,1,'',-1.3),(107,17,1,'',-1.3),(108,17,1,'',-1.3),(109,17,1,'',-1.3),(110,17,1,'',-1.3),(111,17,1,'',-1.3),(112,17,1,'',-1.3),(113,17,1,'',-1.3),(114,17,1,'',-1.3),(115,17,1,'',-1.3),(116,17,1,'',-1.3),(117,17,1,'',-1.3),(118,17,1,'',-1.3),(119,17,1,'',-1.3),(120,17,1,'',-1.3),(121,17,1,'',-1.3),(122,17,1,'',-1.3),(123,17,1,'',-1.3),(124,17,1,'',-1.3),(125,17,1,'',-1.3),(126,17,1,'',-1.3),(127,17,1,'',-1.3),(128,17,1,'',-1.3),(129,17,1,'',-1.3),(130,17,1,'',-1.3),(131,17,1,'',-1.3),(132,17,1,'',-1.3),(133,17,1,'',-1.3),(134,17,1,'',-1.3),(135,17,1,'',-1.3),(136,17,1,'',-1.3),(137,17,1,'',-1.3),(138,17,1,'',-1.3),(139,17,1,'',-1.3),(140,17,1,'',-1.3),(141,17,1,'',-1.3),(142,17,1,'',-1.3),(143,17,1,'',-1.3),(144,17,1,'',-1.3),(145,17,1,'',-1.3),(146,17,1,'',-1.3),(147,18,1,'',-1.3),(148,18,1,'',-1.3),(149,18,1,'',-1.3),(150,18,1,'',-1.3),(151,18,1,'',-1.3),(152,18,1,'',-1.3),(153,18,1,'',-1.3),(154,18,1,'',-1.3),(155,18,1,'',-1.3),(156,18,1,'',-1.3),(157,18,1,'',-1.3),(158,18,1,'',-1.3),(159,18,1,'',-1.3),(160,19,1,'',-1.3),(161,19,1,'',-1.3),(162,19,1,'',-1.3),(163,19,1,'',-1.3),(164,19,1,'',-1.3),(165,19,1,'',-1.3),(166,19,1,'',-1.3),(167,19,1,'',-1.3),(168,19,1,'',-1.3),(169,20,1,'',-1.3),(170,20,1,'',-1.3),(171,20,1,'',-1.3),(172,20,1,'',-1.3),(173,20,1,'',-1.3);
/*!40000 ALTER TABLE `detalle_ticket` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `empleados`
--

DROP TABLE IF EXISTS `empleados`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `empleados` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nomusu` varchar(10) NOT NULL,
  `contraseña` varchar(25) NOT NULL,
  `curp` varchar(18) NOT NULL,
  `nombre` varchar(20) NOT NULL,
  `paterno` varchar(20) NOT NULL,
  `materno` varchar(20) NOT NULL,
  `fec nacimiento` varchar(45) NOT NULL,
  `direccion` varchar(45) NOT NULL,
  `colonia` varchar(45) NOT NULL,
  `municipio` varchar(45) NOT NULL,
  `estado` varchar(45) NOT NULL,
  `fec ingreso` varchar(45) NOT NULL,
  `puesto` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_puesto_idx` (`puesto`),
  CONSTRAINT `fk_puesto` FOREIGN KEY (`puesto`) REFERENCES `cat_puestos` (`id_puesto`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empleados`
--

LOCK TABLES `empleados` WRITE;
/*!40000 ALTER TABLE `empleados` DISABLE KEYS */;
INSERT INTO `empleados` VALUES (1,'admin','12345','','Emmanuel ','Frias','Gonzalez','1988-05-03 00:00:00','','','','','2014-03-21 00:00:00',1),(2,'cajero1','cajero','','Juan','Perez','Seraz','1989-03-03 00:00:00','','','','','2014-03-21 00:00:00',2),(3,'Usuario','Password','asd','asd','asd','asd','28/03/2014 12:00:00 p.m.','Direccion','Colonia','Municipio','Estado','28/03/2014 12:00:00 p.m.',2),(5,'Usuario','Password','CURP','Nombre','Paterno','Materno','2014-03-00 00:00:00','Direccion','Colonia','Municipio','Estado','2014-03-00 00:00:00',2);
/*!40000 ALTER TABLE `empleados` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `servicio`
--

DROP TABLE IF EXISTS `servicio`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `servicio` (
  `idservicio` int(11) NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(45) NOT NULL,
  `costo` double NOT NULL,
  PRIMARY KEY (`idservicio`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `servicio`
--

LOCK TABLES `servicio` WRITE;
/*!40000 ALTER TABLE `servicio` DISABLE KEYS */;
INSERT INTO `servicio` VALUES (1,'Lavado',12.5),(2,'Secado',20.05),(3,'Cera Economica',15),(4,'Cera Standard',30),(5,'Cera Superlux',150),(7,'servicio2',0),(10,'servicio2',0),(11,'servicio2',0),(12,'engradado de pisto',12.53),(16,'servicio2',0),(18,'encerado',0);
/*!40000 ALTER TABLE `servicio` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ticket`
--

DROP TABLE IF EXISTS `ticket`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ticket` (
  `id_ticket` int(11) NOT NULL AUTO_INCREMENT,
  `id_usuario` int(11) NOT NULL,
  `id_lavador` int(11) NOT NULL,
  `propietario` varchar(45) NOT NULL,
  `placas` varchar(10) NOT NULL,
  `marca` varchar(45) NOT NULL,
  `modelo` varchar(45) NOT NULL,
  `color` varchar(20) NOT NULL,
  `total` double NOT NULL,
  `hora` varchar(20) NOT NULL,
  `fecha` varchar(20) NOT NULL,
  PRIMARY KEY (`id_ticket`),
  KEY `fk_ticket_usuario_idx` (`id_usuario`),
  KEY `fk_ticket_color_idx` (`color`),
  CONSTRAINT `fk_ticket_usuario` FOREIGN KEY (`id_usuario`) REFERENCES `empleados` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ticket`
--

LOCK TABLES `ticket` WRITE;
/*!40000 ALTER TABLE `ticket` DISABLE KEYS */;
INSERT INTO `ticket` VALUES (3,1,321,'ljlkj','lkjlk','lkjlkj','lkjlkj','1',12.5,'00:00:00','0000-00-00'),(4,1,1,'Emilinao Frias','jkhkhjk','BMW','X5','Azul',81.2,'02:14:05.7600770','20/03/2014'),(5,1,1,'Emiliano Frias','xyz-1707','BMW','X5','Azul',104.4,'02:17:29.1709154','20/03/2014'),(6,1,1,'Sebastian Frias','abc-0312','Ferrari','Torito','Rojo',104.4,'02:21:26.5942466','20/03/2014'),(7,1,1,'Lorena Navarro','xxx-6969','Lamborllini','Veneno','Negro oscuro',104.4,'02:24:34.3050050','20/03/2014'),(8,1,1,'Lorena Navarro','xxx-6969','Lambougini','Aventador','Negro',81.2,'02:26:26.3313458','20/03/2014'),(9,1,1,'Elidia Gonzalez','asd-3698','Mercedes','sc100','Rojo',58,'02:27:01.5045410','20/03/2014'),(10,1,1,'Propietario','Placas','Marca','Modelo','Color',0,'15:50:27.8882144','21/03/2014'),(11,1,1,'Samir','xyz-4530','Dodge','Ram','Blanca',116,'15:54:23.9853152','21/03/2014'),(12,1,1,'hhkjhkj','hkhkjhk','jhkhjkhkh','jhkjhkjkjhkhjkh','jkhkjhkjh',46.4,'15:55:50.5323824','21/03/2014'),(13,1,1,'lkñlkñl','kñlkñlk','ñlkñlkñl','kñlkñlk','ñlkñlkñl',0,'23:02:34.3353376','21/03/2014'),(14,1,1,'kjhk','jhkjh','kjhkjh','kjhkjh','kjhkjhk',885.15,'00:22:09.3055024','22/03/2014'),(15,1,1,'poi','poi','poi','poi','poi',287.25,'00:23:18.5039819','22/03/2014'),(16,1,1,'jhkhkjh','kjhkjhkjh','kjhjkhkhkh','jkhkhkjhkjhjk','hkhkjkjkhjh',546.9,'00:27:53.6556587','22/03/2014'),(17,1,1,'lkjlkj','lkjlkj','lkjlkj','lkjlkjl','kjljljk',4468.85,'00:36:05.8305947','22/03/2014'),(18,1,1,'lkjkjl','kjlkjlk','jlkjlj','lkjlkjl','jlkjlkjlkj',238.15,'00:40:25.7326283','22/03/2014'),(19,1,1,'kjlkjl','kjljl','kjlkjlk','jlkjlkjlkj','lkjljlkj',340.86,'16:01:01.9680234','28/03/2014'),(20,1,1,'pillos','dsyrthsur','dsger','2001','amarillo',188.55,'16:49:53.3737707','28/03/2014');
/*!40000 ALTER TABLE `ticket` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'punto_venta_autolavado'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2014-04-01 21:55:29

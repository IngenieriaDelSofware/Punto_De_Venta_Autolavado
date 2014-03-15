CREATE DATABASE  IF NOT EXISTS `punto_venta_autolavado` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `punto_venta_autolavado`;
-- MySQL dump 10.13  Distrib 5.6.13, for Win32 (x86)
--
-- Host: localhost    Database: punto_venta_autolavado
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
-- Table structure for table `cat_color`
--

DROP TABLE IF EXISTS `cat_color`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cat_color` (
  `id_color` int(11) NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(45) NOT NULL,
  PRIMARY KEY (`id_color`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cat_color`
--

LOCK TABLES `cat_color` WRITE;
/*!40000 ALTER TABLE `cat_color` DISABLE KEYS */;
INSERT INTO `cat_color` VALUES (1,'rojo');
/*!40000 ALTER TABLE `cat_color` ENABLE KEYS */;
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
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cat_tamanos`
--

LOCK TABLES `cat_tamanos` WRITE;
/*!40000 ALTER TABLE `cat_tamanos` DISABLE KEYS */;
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
  `id_tamano` int(11) NOT NULL,
  `promocion` bit(1) NOT NULL,
  PRIMARY KEY (`id_detalle`),
  KEY `fk_detalle_servicio_idx` (`id_servicio`),
  KEY `fk_detalle_tamano_idx` (`id_tamano`),
  KEY `fk_detalle_ticket_idx` (`id_ticket`),
  CONSTRAINT `fk_detalle_servicio` FOREIGN KEY (`id_servicio`) REFERENCES `servicio` (`idservicio`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_detalle_tamano` FOREIGN KEY (`id_tamano`) REFERENCES `cat_tamanos` (`id_tamano`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalle_ticket`
--

LOCK TABLES `detalle_ticket` WRITE;
/*!40000 ALTER TABLE `detalle_ticket` DISABLE KEYS */;
/*!40000 ALTER TABLE `detalle_ticket` ENABLE KEYS */;
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
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `servicio`
--

LOCK TABLES `servicio` WRITE;
/*!40000 ALTER TABLE `servicio` DISABLE KEYS */;
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
  `placas` varchar(7) NOT NULL,
  `marca` varchar(45) NOT NULL,
  `modelo` varchar(45) NOT NULL,
  `color` int(11) NOT NULL,
  `total` double NOT NULL,
  `hora` time NOT NULL,
  `fecha` date NOT NULL,
  PRIMARY KEY (`id_ticket`),
  KEY `fk_ticket_usuario_idx` (`id_usuario`),
  KEY `fk_ticket_color_idx` (`color`),
  CONSTRAINT `fk_ticket_color` FOREIGN KEY (`color`) REFERENCES `cat_color` (`id_color`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_ticket_usuario` FOREIGN KEY (`id_usuario`) REFERENCES `usuarios` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ticket`
--

LOCK TABLES `ticket` WRITE;
/*!40000 ALTER TABLE `ticket` DISABLE KEYS */;
INSERT INTO `ticket` VALUES (3,1,321,'ljlkj','lkjlk','lkjlkj','lkjlkj',1,12.5,'00:00:00','0000-00-00');
/*!40000 ALTER TABLE `ticket` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuarios` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nom usu` varchar(10) DEFAULT NULL,
  `contraseña` varchar(25) DEFAULT NULL,
  `nombre` varchar(20) DEFAULT NULL,
  `paterno` varchar(20) DEFAULT NULL,
  `materno` varchar(20) DEFAULT NULL,
  `fec nacimiento` date DEFAULT NULL,
  `fec ingreso` date DEFAULT NULL,
  `puesto` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` VALUES (1,'oiu','oiu','oiu','oiu','oiu','0000-00-00','0000-00-00','lkjlk');
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2014-03-15 12:45:46

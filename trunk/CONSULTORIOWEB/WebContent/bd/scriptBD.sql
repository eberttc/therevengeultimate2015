CREATE DATABASE  IF NOT EXISTS `bdconsultorio` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `bdconsultorio`;
-- MySQL dump 10.13  Distrib 5.6.11, for Win32 (x86)
--
-- Host: localhost    Database: bdconsultorio
-- ------------------------------------------------------
-- Server version	5.6.11

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
-- Table structure for table `usuario_menu`
--

DROP TABLE IF EXISTS `usuario_menu`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuario_menu` (
  `N_Correl` int(11) NOT NULL AUTO_INCREMENT,
  `N_CodUsu` int(11) DEFAULT NULL,
  `N_CodOpc` int(11) DEFAULT NULL,
  `C_TipUsu` varchar(2) DEFAULT NULL,
  `C_EstReg` varchar(2) DEFAULT NULL,
  PRIMARY KEY (`N_Correl`)
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario_menu`
--

LOCK TABLES `usuario_menu` WRITE;
/*!40000 ALTER TABLE `usuario_menu` DISABLE KEYS */;
INSERT INTO `usuario_menu` VALUES (1,1,1,'R','S'),(2,1,2,'R','S'),(3,1,19,'R','S'),(4,1,20,'R','S'),(5,1,17,'R','S'),(6,1,18,'R','S'),(7,1,9,'R','S'),(8,1,10,'R','S'),(9,1,7,'R','S'),(10,1,1,'A','S'),(11,1,2,'A','S'),(12,1,3,'A','S'),(13,1,4,'A','S'),(14,1,5,'A','S'),(15,1,6,'A','S'),(16,1,7,'A','S'),(17,1,8,'A','S'),(18,1,9,'A','S'),(19,1,10,'A','S'),(20,1,11,'A','S'),(21,1,12,'A','S'),(22,1,13,'A','S'),(23,1,14,'A','S'),(24,1,15,'A','S'),(25,1,16,'A','S'),(26,1,17,'A','S'),(27,1,18,'A','S'),(28,1,19,'A','S'),(29,1,20,'A','S'),(30,1,21,'A','S');
/*!40000 ALTER TABLE `usuario_menu` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `menu`
--

DROP TABLE IF EXISTS `menu`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `menu` (
  `N_CodOpc` int(11) NOT NULL,
  `C_Descri` varchar(50) DEFAULT NULL,
  `N_CodPad` int(11) DEFAULT NULL,
  `C_Accion` varchar(100) DEFAULT NULL,
  `C_EstReg` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`N_CodOpc`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `menu`
--

LOCK TABLES `menu` WRITE;
/*!40000 ALTER TABLE `menu` DISABLE KEYS */;
INSERT INTO `menu` VALUES (1,'Cuotas',-1,NULL,'S'),(2,'Mis cuotas Vencidas',1,'/SISTEMACONDOMINIOWEB/pages/ConsultaMisCuotasVencidas.jsp','S'),(3,'Mantenimientos',-1,NULL,'S'),(4,'Vivienda',3,'/SISTEMACONDOMINIOWEB/pages/ViviendaBuscar.jsp','S'),(5,'Residente',3,'/SISTEMACONDOMINIOWEB/pages/ResidenteBuscar.jsp','S'),(6,'Colocacion de Cuotas',1,'/SISTEMACONDOMINIOWEB/pages/CuotaListar.jsp','S'),(7,'Pago cuotas',1,NULL,'S'),(8,'Consulta de Cuotas Vencidas',1,'/SISTEMACONDOMINIOWEB/CuotasServlet?opcion=1','S'),(9,'Quejas',-1,NULL,'S'),(10,'Registro de Quejas',9,'/SISTEMACONDOMINIOWEB/pages/CreaQueja.jsp','S'),(11,'Listado de Quejas',9,'/SISTEMACONDOMINIOWEB/pages/ConsultaQuejas.jsp','S'),(12,'Visitas',-1,NULL,'S'),(13,'Registro de visitas',12,'/SISTEMACONDOMINIOWEB/VisitanteServlet','S'),(14,'Listado de visitas',12,'/SISTEMACONDOMINIOWEB/ConsultaVisitasServlet?opcion=1','S'),(15,'Juntas',-1,NULL,'S'),(16,'Registro Juntas',15,'/SISTEMACONDOMINIOWEB/pages/RegistrarJunta.jsp','S'),(17,'Reservas',-1,'/SISTEMACONDOMINIOWEB/pages/ingresarReserva.jsp','S'),(18,'Espacio comun',17,'/SISTEMACONDOMINIOWEB/pages/ingresarReserva.jsp','S'),(19,'Mensajeria',-1,NULL,'S'),(20,'Ver Mensajes',19,'/SISTEMACONDOMINIOWEB/MensajeServlet','S'),(21,'Registrar Mensajes',19,'/SISTEMACONDOMINIOWEB/pages/ingresarMensaje.jsp','S');
/*!40000 ALTER TABLE `menu` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuariosistema`
--

DROP TABLE IF EXISTS `usuariosistema`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuariosistema` (
  `N_IdUsua` int(11) NOT NULL AUTO_INCREMENT,
  `C_NomUsua` varchar(45) DEFAULT NULL,
  `C_Clave` varchar(45) DEFAULT NULL,
  `C_EstReg` varchar(45) DEFAULT NULL,
  `C_Correo` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`N_IdUsua`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuariosistema`
--

LOCK TABLES `usuariosistema` WRITE;
/*!40000 ALTER TABLE `usuariosistema` DISABLE KEYS */;
INSERT INTO `usuariosistema` VALUES (1,'admin','123','S','admin@hotmail.com');
/*!40000 ALTER TABLE `usuariosistema` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2015-01-21 21:34:08

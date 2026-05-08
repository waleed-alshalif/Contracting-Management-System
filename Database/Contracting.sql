-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Aug 23, 2024 at 12:43 PM
-- Server version: 8.2.0
-- PHP Version: 8.2.13

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `contracting`
--

-- --------------------------------------------------------

--
-- Table structure for table `admines`
--

DROP TABLE IF EXISTS `admines`;
CREATE TABLE IF NOT EXISTS `admines` (
  `Id` int NOT NULL,
  `Username` varchar(30) NOT NULL,
  `Password` varchar(200) NOT NULL,
  `Email` varchar(50) NOT NULL,
  `Phone_Number` bigint NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM AUTO_INCREMENT=5286525 DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `contractors`
--

DROP TABLE IF EXISTS `contractors`;
CREATE TABLE IF NOT EXISTS `contractors` (
  `id_contractor` int NOT NULL,
  `Contractor_Name` varchar(40) NOT NULL,
  `Phone_Number` bigint NOT NULL,
  `Email` varchar(50) NOT NULL,
  `Document` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Major` varchar(30) NOT NULL,
  PRIMARY KEY (`id_contractor`) USING BTREE
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Table structure for table `employees`
--

DROP TABLE IF EXISTS `employees`;
CREATE TABLE IF NOT EXISTS `employees` (
  `id_employee` int NOT NULL,
  `Employee_Name` varchar(30) NOT NULL,
  `Majer` varchar(25) NOT NULL,
  `Phone_Number` int NOT NULL,
  `Email` varchar(50) NOT NULL,
  `CV` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`id_employee`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Table structure for table `projects`
--

DROP TABLE IF EXISTS `projects`;
CREATE TABLE IF NOT EXISTS `projects` (
  `Id_project` int NOT NULL,
  `Project_Name` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Suppporting_Entity` varchar(25) NOT NULL,
  `Location` varchar(20) NOT NULL,
  `Cost` int NOT NULL,
  `Project_Period` int NOT NULL,
  `Workforce_Name` varchar(30) NOT NULL,
  `Employee_Name` varchar(30) NOT NULL,
  `Contractor_Name` varchar(40) NOT NULL,
  PRIMARY KEY (`Id_project`),
  KEY `Workforce_Name` (`Workforce_Name`),
  KEY `Employee_Name` (`Employee_Name`),
  KEY `Contractor_Name` (`Contractor_Name`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
CREATE TABLE IF NOT EXISTS `users` (
  `Id` int NOT NULL,
  `Username` varchar(30) NOT NULL,
  `Password` varchar(200) NOT NULL,
  `Email` varchar(50) NOT NULL,
  `Category` varchar(10) NOT NULL,
  `Phone_Number` bigint NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM AUTO_INCREMENT=36449 DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `workforces`
--

DROP TABLE IF EXISTS `workforces`;
CREATE TABLE IF NOT EXISTS `workforces` (
  `id_workforce` int NOT NULL,
  `Workforce_Name` varchar(30) NOT NULL,
  `Majer` varchar(25) NOT NULL,
  `Phone_Number` int NOT NULL,
  PRIMARY KEY (`id_workforce`) USING BTREE
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

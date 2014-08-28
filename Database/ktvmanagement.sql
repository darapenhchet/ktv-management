/*
Navicat MySQL Data Transfer

Source Server         : ktvManagement
Source Server Version : 60004
Source Host           : localhost:3306
Source Database       : ktvmanagement

Target Server Type    : MYSQL
Target Server Version : 60004
File Encoding         : 65001

Date: 2014-08-28 09:48:09
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for categories
-- ----------------------------
DROP TABLE IF EXISTS `categories`;
CREATE TABLE `categories` (
  `categoryId` int(11) NOT NULL,
  `category` varchar(50) DEFAULT NULL,
  `description` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`categoryId`),
  CONSTRAINT `categories_ibfk_1` FOREIGN KEY (`categoryId`) REFERENCES `songs` (`categoryId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of categories
-- ----------------------------

-- ----------------------------
-- Table structure for guests
-- ----------------------------
DROP TABLE IF EXISTS `guests`;
CREATE TABLE `guests` (
  `guestId` int(11) NOT NULL,
  `roomId` int(11) NOT NULL,
  `timein` varchar(20) NOT NULL,
  `timeout` varchar(20) NOT NULL,
  `amount` double NOT NULL,
  PRIMARY KEY (`guestId`),
  KEY `roomId` (`roomId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of guests
-- ----------------------------

-- ----------------------------
-- Table structure for languages
-- ----------------------------
DROP TABLE IF EXISTS `languages`;
CREATE TABLE `languages` (
  `languageId` int(11) NOT NULL,
  `language` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`languageId`),
  CONSTRAINT `languages_ibfk_1` FOREIGN KEY (`languageId`) REFERENCES `songs` (`langaugeId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of languages
-- ----------------------------

-- ----------------------------
-- Table structure for productions
-- ----------------------------
DROP TABLE IF EXISTS `productions`;
CREATE TABLE `productions` (
  `productionId` int(11) NOT NULL,
  `production` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`productionId`),
  CONSTRAINT `productions_ibfk_1` FOREIGN KEY (`productionId`) REFERENCES `songs` (`productionId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of productions
-- ----------------------------

-- ----------------------------
-- Table structure for rooms
-- ----------------------------
DROP TABLE IF EXISTS `rooms`;
CREATE TABLE `rooms` (
  `roomId` int(11) NOT NULL,
  `roomType` varchar(10) DEFAULT NULL,
  `price` double DEFAULT NULL,
  PRIMARY KEY (`roomId`),
  CONSTRAINT `rooms_ibfk_1` FOREIGN KEY (`roomId`) REFERENCES `guests` (`roomId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of rooms
-- ----------------------------

-- ----------------------------
-- Table structure for singers
-- ----------------------------
DROP TABLE IF EXISTS `singers`;
CREATE TABLE `singers` (
  `singerId` int(11) NOT NULL AUTO_INCREMENT,
  `singerName` varchar(50) DEFAULT NULL,
  `gender` varchar(1) DEFAULT NULL,
  PRIMARY KEY (`singerId`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of singers
-- ----------------------------
INSERT INTO `singers` VALUES ('1', 'Preap Sovath', 'M');
INSERT INTO `singers` VALUES ('2', 'Nob Nico', 'M');

-- ----------------------------
-- Table structure for songdetails
-- ----------------------------
DROP TABLE IF EXISTS `songdetails`;
CREATE TABLE `songdetails` (
  `singerId` int(11) NOT NULL,
  `songId` int(11) NOT NULL,
  KEY `singerId` (`singerId`),
  KEY `songId` (`songId`),
  CONSTRAINT `songdetails_ibfk_1` FOREIGN KEY (`singerId`) REFERENCES `singers` (`singerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of songdetails
-- ----------------------------

-- ----------------------------
-- Table structure for songs
-- ----------------------------
DROP TABLE IF EXISTS `songs`;
CREATE TABLE `songs` (
  `songid` int(11) NOT NULL,
  `title` varchar(200) NOT NULL,
  `album` varchar(50) DEFAULT NULL,
  `categoryId` int(11) NOT NULL,
  `langaugeId` int(11) NOT NULL,
  `productionId` int(11) NOT NULL,
  PRIMARY KEY (`songid`),
  KEY `categoryId` (`categoryId`),
  KEY `langaugeId` (`langaugeId`),
  KEY `productionId` (`productionId`),
  CONSTRAINT `songs_ibfk_1` FOREIGN KEY (`songid`) REFERENCES `songdetails` (`songId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of songs
-- ----------------------------

-- ----------------------------
-- Table structure for users
-- ----------------------------
DROP TABLE IF EXISTS `users`;
CREATE TABLE `users` (
  `userid` int(11) NOT NULL,
  `username` varchar(50) DEFAULT NULL,
  `password` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`userid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of users
-- ----------------------------
INSERT INTO `users` VALUES ('1', 'douen', '123');

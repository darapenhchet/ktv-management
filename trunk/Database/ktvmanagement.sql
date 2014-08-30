/*
Navicat MySQL Data Transfer

Source Server         : ktvmanagement
Source Server Version : 50525
Source Host           : localhost:3306
Source Database       : ktvmanagement

Target Server Type    : MYSQL
Target Server Version : 50525
File Encoding         : 65001

Date: 2014-08-31 03:51:04
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for categories
-- ----------------------------
DROP TABLE IF EXISTS `categories`;
CREATE TABLE `categories` (
  `categoryId` int(11) NOT NULL AUTO_INCREMENT,
  `category` varchar(50) DEFAULT NULL,
  `description` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`categoryId`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of categories
-- ----------------------------
INSERT INTO `categories` VALUES ('1', 'Modern', 'Modern Song in Cambodia');
INSERT INTO `categories` VALUES ('2', 'POP', 'Pop Song in Cambodia');

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
  `languageId` int(11) NOT NULL AUTO_INCREMENT,
  `language` varchar(20) NOT NULL,
  `photo` varchar(100) NOT NULL,
  PRIMARY KEY (`languageId`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of languages
-- ----------------------------
INSERT INTO `languages` VALUES ('1', 'KHMER', '');
INSERT INTO `languages` VALUES ('2', 'ENGLISH', '');

-- ----------------------------
-- Table structure for productions
-- ----------------------------
DROP TABLE IF EXISTS `productions`;
CREATE TABLE `productions` (
  `productionId` int(11) NOT NULL AUTO_INCREMENT,
  `production` varchar(50) DEFAULT NULL,
  `photo` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`productionId`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of productions
-- ----------------------------
INSERT INTO `productions` VALUES ('2', 'RHM', null);
INSERT INTO `productions` VALUES ('3', 'SUNDAY', null);
INSERT INTO `productions` VALUES ('4', 'M', null);
INSERT INTO `productions` VALUES ('5', 'TOWN', null);

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
  `singerName` varchar(50) NOT NULL,
  `gender` varchar(1) NOT NULL,
  `photo` blob NOT NULL,
  PRIMARY KEY (`singerId`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of singers
-- ----------------------------
INSERT INTO `singers` VALUES ('1', 'Preap Sovath', 'M', '');
INSERT INTO `singers` VALUES ('2', 'Nob Nico', 'M', '');

-- ----------------------------
-- Table structure for songdetails
-- ----------------------------
DROP TABLE IF EXISTS `songdetails`;
CREATE TABLE `songdetails` (
  `singerId` int(11) NOT NULL,
  `songId` int(11) NOT NULL,
  KEY `singerId` (`singerId`),
  KEY `songId` (`songId`),
  CONSTRAINT `songdetails_ibfk_1` FOREIGN KEY (`singerId`) REFERENCES `singers` (`singerId`),
  CONSTRAINT `songdetails_ibfk_2` FOREIGN KEY (`songId`) REFERENCES `songs` (`songid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of songdetails
-- ----------------------------
INSERT INTO `songdetails` VALUES ('1', '3');

-- ----------------------------
-- Table structure for songs
-- ----------------------------
DROP TABLE IF EXISTS `songs`;
CREATE TABLE `songs` (
  `songid` int(11) NOT NULL AUTO_INCREMENT,
  `title` varchar(200) NOT NULL,
  `album` varchar(50) DEFAULT NULL,
  `categoryId` int(11) NOT NULL,
  `languageId` int(11) NOT NULL,
  `productionId` int(11) NOT NULL,
  PRIMARY KEY (`songid`),
  KEY `categoryId` (`categoryId`),
  KEY `langaugeId` (`languageId`),
  KEY `productionId` (`productionId`),
  CONSTRAINT `songs_ibfk_1` FOREIGN KEY (`categoryId`) REFERENCES `categories` (`categoryId`),
  CONSTRAINT `songs_ibfk_2` FOREIGN KEY (`languageId`) REFERENCES `languages` (`languageId`),
  CONSTRAINT `songs_ibfk_3` FOREIGN KEY (`productionId`) REFERENCES `productions` (`productionId`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of songs
-- ----------------------------
INSERT INTO `songs` VALUES ('3', 'ចិត្តព្រៃផ្សៃ', '1', '1', '1', '2');

-- ----------------------------
-- Table structure for users
-- ----------------------------
DROP TABLE IF EXISTS `users`;
CREATE TABLE `users` (
  `userid` int(11) NOT NULL,
  `username` varchar(50) DEFAULT NULL,
  `password` varchar(50) DEFAULT NULL,
  `position` int(11) DEFAULT NULL,
  `photo` blob,
  PRIMARY KEY (`userid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of users
-- ----------------------------
INSERT INTO `users` VALUES ('1', 'douen', '123', '1', null);
INSERT INTO `users` VALUES ('2', 'admin', 'admin', '1', null);

-- ----------------------------
-- Procedure structure for spAddNewUser
-- ----------------------------
DROP PROCEDURE IF EXISTS `spAddNewUser`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spAddNewUser`(
	userId INT,
	username VARCHAR(50),
	password VARCHAR(50),
	position INT,
	photo BLOB
)
BEGIN
	INSERT INTO users(userId,username,password,position,photo)
	VALUES(userID,username,password,position,photo);
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for spAddSinger
-- ----------------------------
DROP PROCEDURE IF EXISTS `spAddSinger`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spAddSinger`(singerId INT,singerName VARCHAR(100),
gender VARCHAR(1),photo VARCHAR(100))
BEGIN
	
	INSERT INTO singers(singerId,singerName,gender,photo)
	VALUES(singerId,singerName,gender,photo);

END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for spAddSong
-- ----------------------------
DROP PROCEDURE IF EXISTS `spAddSong`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spAddSong`(title VARCHAR(200),
	singerId INT,
	album VARCHAR(20),
	categoryId INT,
	productionId INT,
	languageId INT)
BEGIN
	INSERT INTO songs(title,album,categoryId,productionId,languageId)
	VALUES(title,album,categoryId,productionId,languageId);
	
	INSERT INTO songdetails(singerId,songId)
	VALUES(singerId,LAST_INSERT_ID());
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for spGetAllUsers
-- ----------------------------
DROP PROCEDURE IF EXISTS `spGetAllUsers`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `spGetAllUsers`()
BEGIN
	SELECT UserId, username, password, position, photo
	FROM users;
END
;;
DELIMITER ;

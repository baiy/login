/*
Navicat MariaDB Data Transfer

Source Server         : localhost
Source Server Version : 100016
Source Host           : localhost:3306
Source Database       : test

Target Server Type    : MariaDB
Target Server Version : 100016
File Encoding         : 65001

Date: 2015-09-04 00:05:55
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for pre_environment
-- ----------------------------
DROP TABLE IF EXISTS `pre_environment`;
CREATE TABLE `pre_environment` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL COMMENT '环境名称',
  `inputtime` int(10) unsigned NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=utf8 COMMENT='使用环境表';

-- ----------------------------
-- Table structure for pre_item
-- ----------------------------
DROP TABLE IF EXISTS `pre_item`;
CREATE TABLE `pre_item` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `sid` int(10) unsigned NOT NULL COMMENT '服务ID',
  `tid` int(10) unsigned NOT NULL COMMENT '分类ID',
  `name` varchar(100) NOT NULL COMMENT '名称',
  `inputtime` int(10) unsigned NOT NULL COMMENT '添加时间',
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 COMMENT='项目表';

-- ----------------------------
-- Table structure for pre_item_data
-- ----------------------------
DROP TABLE IF EXISTS `pre_item_data`;
CREATE TABLE `pre_item_data` (
  `iid` int(10) unsigned NOT NULL COMMENT '项目ID',
  `fieldname` varchar(100) NOT NULL COMMENT '名称',
  `value` varchar(1000) NOT NULL COMMENT '值',
  PRIMARY KEY (`iid`,`fieldname`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COMMENT='项目数据表';

-- ----------------------------
-- Table structure for pre_service
-- ----------------------------
DROP TABLE IF EXISTS `pre_service`;
CREATE TABLE `pre_service` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `title` varchar(100) NOT NULL COMMENT '服务名称',
  `protocol` varchar(30) NOT NULL COMMENT '协议',
  `fields` text NOT NULL COMMENT '字段配置',
  `lists_fields` varchar(255) NOT NULL,
  `inputtime` int(10) unsigned NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8 COMMENT='服务表';

-- ----------------------------
-- Table structure for pre_soft
-- ----------------------------
DROP TABLE IF EXISTS `pre_soft`;
CREATE TABLE `pre_soft` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `sid` int(10) unsigned NOT NULL,
  `name` varchar(100) NOT NULL COMMENT '名称',
  `tpl` varchar(5000) NOT NULL,
  `inputtime` int(10) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `sid` (`sid`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=utf8 COMMENT='软件表';

-- ----------------------------
-- Table structure for pre_soft_path
-- ----------------------------
DROP TABLE IF EXISTS `pre_soft_path`;
CREATE TABLE `pre_soft_path` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `softid` int(10) unsigned NOT NULL,
  `eid` int(10) unsigned NOT NULL,
  `path` varchar(5000) NOT NULL COMMENT '值',
  `inputtime` int(10) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `soft` (`softid`,`eid`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 COMMENT='软件路径表';

-- ----------------------------
-- Table structure for pre_type
-- ----------------------------
DROP TABLE IF EXISTS `pre_type`;
CREATE TABLE `pre_type` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `title` varchar(100) NOT NULL COMMENT '服务名称',
  `inputtime` int(10) unsigned NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=utf8 COMMENT='分类表';

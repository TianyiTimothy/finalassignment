-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- 主机： localhost:3306
-- 生成日期： 2019-12-06 09:01:49
-- 服务器版本： 5.7.24-log
-- PHP 版本： 7.2.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- 数据库： `website`
--

-- --------------------------------------------------------

--
-- 表的结构 `pages`
--

CREATE TABLE `pages` (
  `pageid` int(11) NOT NULL,
  `pagetitle` varchar(20) NOT NULL,
  `pagebody` mediumtext NOT NULL,
  `isPublished` tinyint(1) NOT NULL DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- 转存表中的数据 `pages`
--

INSERT INTO `pages` (`pageid`, `pagetitle`, `pagebody`, `isPublished`) VALUES
(1, 'Diary 1-1', 'haha this is my first diary, written on 2018.1.1', 1),
(2, 'Car Issue', "Yesterday afternoon, my friend asked me to borrow a car to pick up his old mother-in-law from the airport. I thought that my Geely Emperor was nothing to buy a vegetable car, so I borrowed it. When I returned, he returned the car to me and said that he had stopped downstairs. It was cold, so I didn't watch it.
I was about to drive out just now. I saw a scratch on the left rear door. It seemed that the primer had been scratched. I asked my friend and said that he didn't know if he drove so hard. What should I do? ? ? I'm sure my car didn't have this scratch before ...
How much does this repair cost? Can insurance be reported? Let me take a look at it", 1),
(5, 'Bright Sword Discussion', 'There are actually many small characters in the bright sword TV series, such as Yousheng, the five soldiers detonating explosives with the enemy, but what moved me the most is nothing more than these two pictures.', 1),
(6, 'deleted', 'deleted by manager in 2015.8.8', 0);

--
-- 转储表的索引
--

--
-- 表的索引 `pages`
--
ALTER TABLE `pages`
  ADD PRIMARY KEY (`pageid`);

--
-- 在导出的表使用AUTO_INCREMENT
--

--
-- 使用表AUTO_INCREMENT `pages`
--
ALTER TABLE `pages`
  MODIFY `pageid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

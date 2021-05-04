-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Хост: 127.0.0.1
-- Время создания: Янв 23 2020 г., 18:43
-- Версия сервера: 10.1.8-MariaDB
-- Версия PHP: 5.6.14

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `hospital`
--

-- --------------------------------------------------------

--
-- Структура таблицы `consultations`
--

CREATE TABLE `consultations` (
  `Cons_ID` int(11) NOT NULL,
  `Cons_Doctor` int(11) NOT NULL,
  `Cons_Patient` int(11) NOT NULL,
  `Cons_Date_Time` date NOT NULL,
  `Cons_Description` text COLLATE cp1251_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=cp1251 COLLATE=cp1251_bin;

--
-- Дамп данных таблицы `consultations`
--

INSERT INTO `consultations` (`Cons_ID`, `Cons_Doctor`, `Cons_Patient`, `Cons_Date_Time`, `Cons_Description`) VALUES
(1, 1, 4, '2019-12-10', 'efsdwerg'),
(2, 2, 3, '2019-12-04', 'wrdfe'),
(3, 2, 4, '2019-12-11', 'erfgvresv'),
(4, 3, 4, '2019-12-03', 'fdvcrbvdc'),
(5, 2, 2, '2019-12-20', 'efvdsefvd');

-- --------------------------------------------------------

--
-- Структура таблицы `doctors`
--

CREATE TABLE `doctors` (
  `Doc_ID` int(11) NOT NULL,
  `Doc_Name` text COLLATE cp1251_bin NOT NULL,
  `Doc_Surname` text COLLATE cp1251_bin NOT NULL,
  `Doc_Position` text COLLATE cp1251_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=cp1251 COLLATE=cp1251_bin;

--
-- Дамп данных таблицы `doctors`
--

INSERT INTO `doctors` (`Doc_ID`, `Doc_Name`, `Doc_Surname`, `Doc_Position`) VALUES
(1, 'Иван', 'Химеров', 'Терапевт'),
(2, 'Елена', 'Новак', 'Ортопед'),
(3, 'Ольга', 'Аросева', 'Стоматолог');

-- --------------------------------------------------------

--
-- Структура таблицы `patients`
--

CREATE TABLE `patients` (
  `Pat_ID` int(11) NOT NULL,
  `Pat_Name` text COLLATE cp1251_bin NOT NULL,
  `Pat_Surname` text COLLATE cp1251_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=cp1251 COLLATE=cp1251_bin;

--
-- Дамп данных таблицы `patients`
--

INSERT INTO `patients` (`Pat_ID`, `Pat_Name`, `Pat_Surname`) VALUES
(1, 'Виктор', 'Чуркин'),
(2, 'Алексей', 'Кравченков'),
(3, 'Александра', 'Котова'),
(4, 'Вероника', 'Цапко'),
(5, 'Виктория', 'Измайлова'),
(6, 'Сергей', 'Перышев');

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `consultations`
--
ALTER TABLE `consultations`
  ADD PRIMARY KEY (`Cons_ID`),
  ADD KEY `Cons_Doctor` (`Cons_Doctor`),
  ADD KEY `Cons_Patient` (`Cons_Patient`);

--
-- Индексы таблицы `doctors`
--
ALTER TABLE `doctors`
  ADD PRIMARY KEY (`Doc_ID`),
  ADD KEY `Doc_ID` (`Doc_ID`);

--
-- Индексы таблицы `patients`
--
ALTER TABLE `patients`
  ADD PRIMARY KEY (`Pat_ID`),
  ADD KEY `Pat_ID` (`Pat_ID`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

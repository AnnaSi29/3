CREATE DATABASE school_cabinet;

USE school_cabinet;

CREATE TABLE `Кабинет` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `номер кабинета` int(11) NOT NULL,
  `количество рядов` int(11) NOT NULL,
  `количество парт в ряду` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `Ученик` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `ФИО ученика` TEXT(255) NOT NULL,
  `класс` int(11) NOT NULL,
  `ряд` int(11) NOT NULL,
  `партa` int(11) NOT NULL,
  `вариант` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `Занятие` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `id_кабинета` int(11) NOT NULL,
  `предмет` TEXT(255) NOT NULL,
  `началоурока` TIMESTAMP NOT NULL,
  `конецурока` TIMESTAMP NOT NULL,
  PRIMARY KEY (`id`),
  FOREIGN KEY (`id_кабинета`) REFERENCES `Кабинет` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `Сводная` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `id_занятия` int(11) NOT NULL,
  `id_ученика` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  FOREIGN KEY (`id_занятия`) REFERENCES `Занятие` (`id`),
  FOREIGN KEY (`id_ученика`) REFERENCES `Ученик` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;


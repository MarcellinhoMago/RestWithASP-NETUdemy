CREATE TABLE IF NOT EXISTS `books` (
  `id` bigint NOT NULL AUTO_INCREMENT,
  `title` varchar(255) NOT NULL,
  `author` varchar(255) NOT NULL,
  `price` decimal(10, 2) NOT NULL,
  `launch_date` datetime NOT NULL,
  PRIMARY KEY (`id`)
)
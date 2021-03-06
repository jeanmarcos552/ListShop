CREATE TABLE IF NOT EXISTS `shopping` (
    `Id` INT AUTO_INCREMENT PRIMARY KEY,
    `Status` boolean NULL DEFAULT '0',
	`Description` VARCHAR(100) NULL DEFAULT NULL,
    `Person` INT,
    `Value` double NULL DEFAULT '0.0'   
)ENGINE = InnoDB;

ALTER TABLE `shopping` ADD CONSTRAINT FOREIGN KEY (Person) REFERENCES `person` (Id) ON DELETE SET NULL ON UPDATE NO ACTION;


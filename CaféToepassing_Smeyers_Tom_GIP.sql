-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';
-- -----------------------------------------------------
-- Schema bestellingcafé_smeyers_tom_gip
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema bestellingcafé_smeyers_tom_gip
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `cafétoepassing_smeyers_tom_gip` DEFAULT CHARACTER SET utf8 ;
USE `cafétoepassing_smeyers_tom_gip` ;

-- -----------------------------------------------------
-- Table `cafétoepassing_smeyers_tom_gip`.`tafel`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `cafétoepassing_smeyers_tom_gip`.`tafel` ;

CREATE TABLE IF NOT EXISTS `cafétoepassing_smeyers_tom_gip`.`tafel` (
  `tafelNummer` INT NOT NULL AUTO_INCREMENT,
  `positie` VARCHAR(45) NULL DEFAULT NULL,
  PRIMARY KEY (`tafelNummer`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `cafétoepassing_smeyers_tom_gip`.`bestelling`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `cafétoepassing_smeyers_tom_gip`.`bestelling` ;

CREATE TABLE IF NOT EXISTS `cafétoepassing_smeyers_tom_gip`.`bestelling` (
  `idbestelling` INT NOT NULL AUTO_INCREMENT,
  `datum` DATETIME NULL DEFAULT NULL,
  `Betaald` VARCHAR(45) NULL DEFAULT NULL,
  `tafel_tafelNummer` INT NOT NULL,
  `emailadres` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idbestelling`),
  INDEX `fk_bestelling_tafel_idx` (`tafel_tafelNummer` ASC) VISIBLE,
  CONSTRAINT `fk_bestelling_tafel`
    FOREIGN KEY (`tafel_tafelNummer`)
    REFERENCES `cafétoepassing_smeyers_tom_gip`.`tafel` (`tafelNummer`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `cafétoepassing_smeyers_tom_gip`.`producten`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `cafétoepassing_smeyers_tom_gip`.`producten` ;

CREATE TABLE IF NOT EXISTS `cafétoepassing_smeyers_tom_gip`.`producten` (
  `idProducten` INT NOT NULL AUTO_INCREMENT,
  `ProductNaam` VARCHAR(45) NULL DEFAULT NULL,
  `Prijs` FLOAT NULL DEFAULT NULL,
  PRIMARY KEY (`idProducten`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `bestellingcafé_smeyers_tom_gip`.`bestelling_has_producten`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `cafétoepassing_smeyers_tom_gip`.`bestelling_has_Producten` ;
CREATE TABLE IF NOT EXISTS `cafétoepassing_smeyers_tom_gip`.`bestelling_has_Producten` (
  `bestelling_idbestelling` INT NOT NULL,
  `Producten_idProducten` INT NOT NULL,
  `aantal` INT NULL,
  PRIMARY KEY (`bestelling_idbestelling`, `Producten_idProducten`),
  INDEX `fk_bestelling_has_Producten_Producten1_idx` (`Producten_idProducten` ASC) VISIBLE,
  INDEX `fk_bestelling_has_Producten_bestelling1_idx` (`bestelling_idbestelling` ASC) VISIBLE,
  CONSTRAINT `fk_bestelling_has_Producten_bestelling1`
    FOREIGN KEY (`bestelling_idbestelling`)
    REFERENCES `cafétoepassing_smeyers_tom_gip`.`bestelling` (`idbestelling`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_bestelling_has_Producten_Producten1`
    FOREIGN KEY (`Producten_idProducten`)
    REFERENCES `cafétoepassing_smeyers_tom_gip`.`Producten` (`idProducten`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

-- -----------------------------------------------------
-- Data for table `cafétoepassing_smeyers_tom_gip`.`tafel`
-- -----------------------------------------------------
START TRANSACTION;
USE `cafétoepassing_smeyers_tom_gip`;
INSERT INTO `cafétoepassing_smeyers_tom_gip`.`tafel` (`positie`) VALUES ('rechts achter');
INSERT INTO `cafétoepassing_smeyers_tom_gip`.`tafel` (`positie`) VALUES ('links achter');
INSERT INTO `cafétoepassing_smeyers_tom_gip`.`tafel` (`positie`) VALUES ('rechts naast deur');
INSERT INTO `cafétoepassing_smeyers_tom_gip`.`tafel` (`positie`) VALUES ('links aan raam');
INSERT INTO `cafétoepassing_smeyers_tom_gip`.`tafel` (`positie`) VALUES ('links naast deur');

COMMIT;
-- -----------------------------------------------------
-- Data for table `cafétoepassing_smeyers_tom_gip`.`bestelling`
-- -----------------------------------------------------
START TRANSACTION;
USE `cafétoepassing_smeyers_tom_gip`;
INSERT INTO `cafétoepassing_smeyers_tom_gip`.`bestelling` (`datum`, `Betaald`, `tafel_tafelNummer`, `emailadres`) VALUES ('2021-01-09', 'Ja', '1', 'tomsmeyers353@gmail.com');
INSERT INTO `cafétoepassing_smeyers_tom_gip`.`bestelling` (`datum`, `Betaald`, `tafel_tafelNummer`, `emailadres`) VALUES ('2021-01-09', 'Ja', '2', 'joranvg@gmail.com');
INSERT INTO `cafétoepassing_smeyers_tom_gip`.`bestelling` (`datum`, `Betaald`, `tafel_tafelNummer`, `emailadres`) VALUES ('2021-01-09', 'Nee', '3', 'brentslaets@gmail.com');
INSERT INTO `cafétoepassing_smeyers_tom_gip`.`bestelling` (`datum`, `Betaald`, `tafel_tafelNummer`, `emailadres`) VALUES ('2021-01-09', 'Nee', '1', 'tomsmeyers353@gmail.com');

COMMIT;
-- -----------------------------------------------------
-- Data for table `cafétoepassing_smeyers_tom_gip`.`Producten`
-- -----------------------------------------------------
START TRANSACTION;
USE `cafétoepassing_smeyers_tom_gip`;
INSERT INTO `cafétoepassing_smeyers_tom_gip`.`producten` (`ProductNaam`, `Prijs`) VALUES ('Pint bier', '1.40');
INSERT INTO `cafétoepassing_smeyers_tom_gip`.`producten` (`ProductNaam`, `Prijs`) VALUES ('Duvel', '2.50');
INSERT INTO `cafétoepassing_smeyers_tom_gip`.`producten` (`ProductNaam`, `Prijs`) VALUES ('Brugse Zot Blond', '2.50');
INSERT INTO `cafétoepassing_smeyers_tom_gip`.`producten` (`ProductNaam`, `Prijs`) VALUES ('Gouden Carolus', '2.60');
INSERT INTO `cafétoepassing_smeyers_tom_gip`.`producten` (`ProductNaam`, `Prijs`) VALUES ('Kriek', '1.40');
INSERT INTO `cafétoepassing_smeyers_tom_gip`.`producten` (`ProductNaam`, `Prijs`) VALUES ('Kasteel Rouge', '2.50');
INSERT INTO `cafétoepassing_smeyers_tom_gip`.`producten` (`ProductNaam`, `Prijs`) VALUES ('IceTea', '1.20');
INSERT INTO `cafétoepassing_smeyers_tom_gip`.`producten` (`ProductNaam`, `Prijs`) VALUES ('Cola', '1.20');
INSERT INTO `cafétoepassing_smeyers_tom_gip`.`producten` (`ProductNaam`, `Prijs`) VALUES ('Fanta', '1.20');
INSERT INTO `cafétoepassing_smeyers_tom_gip`.`producten` (`ProductNaam`, `Prijs`) VALUES ('Paprika Chips', '1.00');
INSERT INTO `cafétoepassing_smeyers_tom_gip`.`producten` (`ProductNaam`, `Prijs`) VALUES ('Zoute Chips', '1.00');

COMMIT;
-- -----------------------------------------------------
-- Data for table `CaféToepassing_Smeyers_Tom_GIP`.`bestelling_has_Producten`
-- -----------------------------------------------------
START TRANSACTION;
USE `cafétoepassing_smeyers_tom_gip`;
INSERT INTO `cafétoepassing_smeyers_tom_gip`.`bestelling_has_producten` (`bestelling_idbestelling`, `Producten_idProducten`, `aantal`) VALUES ('1', '2', '2');
INSERT INTO `cafétoepassing_smeyers_tom_gip`.`bestelling_has_producten` (`bestelling_idbestelling`, `Producten_idProducten`, `aantal`) VALUES ('1', '1', '5');
INSERT INTO `cafétoepassing_smeyers_tom_gip`.`bestelling_has_producten` (`bestelling_idbestelling`, `Producten_idProducten`, `aantal`) VALUES ('2', '5', '2');
INSERT INTO `cafétoepassing_smeyers_tom_gip`.`bestelling_has_producten` (`bestelling_idbestelling`, `Producten_idProducten`, `aantal`) VALUES ('3', '4', '1');
INSERT INTO `cafétoepassing_smeyers_tom_gip`.`bestelling_has_producten` (`bestelling_idbestelling`, `Producten_idProducten`, `aantal`) VALUES ('3', '6', '1');
INSERT INTO `cafétoepassing_smeyers_tom_gip`.`bestelling_has_producten` (`bestelling_idbestelling`, `Producten_idProducten`, `aantal`) VALUES ('3', '5', '1');
INSERT INTO `cafétoepassing_smeyers_tom_gip`.`bestelling_has_producten` (`bestelling_idbestelling`, `Producten_idProducten`, `aantal`) VALUES ('4', '8', '1');
INSERT INTO `cafétoepassing_smeyers_tom_gip`.`bestelling_has_producten` (`bestelling_idbestelling`, `Producten_idProducten`, `aantal`) VALUES ('4', '2', '2');

COMMIT;
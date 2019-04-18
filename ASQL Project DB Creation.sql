

CREATE DATABASE Kanban

DROP TABLE IF EXISTS Config;
CREATE TABLE Config(
    TimeScale int,              /*How a minute/hour is represented (number would be the factor that a minute/hour is equal to in realtime)*/
    AssemblyStations int,       /*Number of assembly stations (currently 3, could change in future)*/
	Station1Experience int,		/*Level of experience of worker (1-3), 1 is inexperienced, 2 is very experienced*/
	Station2Experience int,		/*Level of experience of worker (1-3), 1 is inexperienced, 2 is very experienced*/
	Station3Experience int,		/*Level of experience of worker (1-3), 1 is inexperienced, 2 is very experienced*/
    HarnessCapacity int,        /*The capacity of the harness bin */
    ReflectorCapacity int,      /*The capacity of the reflector bin */
    HousingCapacity int,        /*The capacity of the housing bin */
    LensCapacity int,           /*The capacity of the lens bin */
    BulbCapacity int,           /*The capacity of the bulb bin */
    BezelCapacity int,          /*The capacity of the bezel bin */
 

)


/*Create tables*/
DROP TABLE IF EXISTS dbo.Parts;
CREATE TABLE dbo.Parts(
	PartID int,					/*ID to identify part */
	PartName varchar(20),		/*Name of part (Harness, Reflector, etc)*/
	Amount int,					/*Amount in the part bin */
	Capacity int
	)
ALTER TABLE Parts ADD PRIMARY KEY(PartID);

DROP TABLE IF EXISTS dbo.CommonTray;
CREATE TABLE dbo.CommonTray(
	CardID int,					/*ID to identify card*/
	Part varchar(10)			/*Name of the part that needs replenishing*/
	)

DROP TABLE IF EXISTS dbo.TestTray;
CREATE TABLE dbo.TestTray(
	TestUnitNum varchar(20),	/*Test unit number (e.g. FL00000101)*/
	PassFail bit			/*Wheather the bulb was successfully made or has a defect*/
	)
	

/*Populate tables*/
INSERT INTO dbo.Parts(PartID,PartName,Amount, Capacity) VALUES
(1, 'Harness', 55, 55),
(2, 'Reflector', 35, 35),
(3, 'Housing', 24, 24),
(4, 'Lens', 40,40),
(5, 'Bulb', 60, 60),
(6, 'Bezel', 75, 60);


/*Gets experiences of each work station worker*/
CREATE PROCEDURE GetExperiences
@StationNum int, @ExpLevel int OUTPUT
AS
BEGIN
	IF @StationNum = 1
	BEGIN
	SELECT @ExpLevel = Station1Experience FROM Config
	END
	
	IF @StationNum = 2
	BEGIN
	SELECT @ExpLevel = Station2Experience FROM Config
	END

	IF @StationNum = 3
	BEGIN 
	SELECT @ExpLevel = Station3Experience FROM Config
	END
END

INSERT INTO Config(TimeScale) VALUES
(2);

select TimeScale from Config;

/*decrement the parts left by 1*/
CREATE PROCEDURE UpdateParts
@partID int
AS
BEGIN
	UPDATE Parts SET Amount = Amount-1 WHERE PartID = @partID

END

DROP PROCEDURE UpdateParts

/*get the amount of parts left in a particular bin*/
CREATE PROCEDURE GetPartsLeft
@partID int, @partsLeft int OUTPUT
AS
BEGIN
	
	SELECT @partsLeft = Amount  FROM Parts WHERE PartID = @partID
	
END

/*reset the database, when config changes the db must be reset*/
CREATE PROCEDURE ResetDB
AS
BEGIN
	DROP TABLE IF EXISTS Config;
CREATE TABLE Config(
    TimeScale int,              /*How a minute/hour is represented (number would be the factor that a minute/hour is equal to in realtime)*/
    AssemblyStations int,       /*Number of assembly stations (currently 3, could change in future)*/
	Station1Experience int,		/*Level of experience of worker (1-3), 1 is inexperienced, 2 is very experienced*/
	Station2Experience int,		/*Level of experience of worker (1-3), 1 is inexperienced, 2 is very experienced*/
	Station3Experience int,		/*Level of experience of worker (1-3), 1 is inexperienced, 2 is very experienced*/
    HarnessCapacity int,        /*The capacity of the harness bin */
    ReflectorCapacity int,      /*The capacity of the reflector bin */
    HousingCapacity int,        /*The capacity of the housing bin */
    LensCapacity int,           /*The capacity of the lens bin */
    BulbCapacity int,           /*The capacity of the bulb bin */
    BezelCapacity int,          /*The capacity of the bezel bin */
 

)


/*Create tables*/
DROP TABLE IF EXISTS dbo.Parts;
CREATE TABLE dbo.Parts(
	PartID int,					/*ID to identify part */
	PartName varchar(20),		/*Name of part (Harness, Reflector, etc)*/
	Amount int,					/*Amount in the part bin */
	Capacity int
	)

ALTER TABLE Parts ADD PRIMARY KEY(PartID);

DROP TABLE IF EXISTS dbo.CommonTray;
CREATE TABLE dbo.CommonTray(
	CardID int,					/*ID to identify card*/
	Part varchar(10)			/*Name of the part that needs replenishing*/
	)

DROP TABLE IF EXISTS dbo.TestTray;
CREATE TABLE dbo.TestTray(
	TestUnitNum varchar(20),	/*Test unit number (e.g. FL00000101)*/
	PassFail varchar(5)			/*Wheather the bulb was successfully made or has a defect*/
	)
	

/*Populate tables*/
INSERT INTO dbo.Parts(PartID,PartName,Amount, Capacity) VALUES
(1, 'Harness', 55, 55),
(2, 'Reflector', 35, 35),
(3, 'Housing', 24, 24),
(4, 'Lens', 40, 40),
(5, 'Bulb', 60, 60),
(6, 'Bezel', 75, 75);


END


/*replenish the amount of parts in a bin*/
CREATE PROCEDURE ReplenishBins
@partID int, @partsLeft int
AS
BEGIN
	UPDATE Parts SET Amount = @partsLeft + Capacity WHERE PartID = @partID
	
END

use Kanban;
UPDATE Parts SET Amount = Capacity;
  DELETE FROM TestTray;
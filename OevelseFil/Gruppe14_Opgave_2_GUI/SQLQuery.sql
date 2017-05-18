--CREATE TABLE opg2_Patient(
--CPR varchar(10) PRIMARY KEY NOT NULL,
--pNavn varchar(50)
--)

--CREATE TABLE opg2_BT(
--CPR varchar(10) FOREIGN KEY REFERENCES opg2_Patient(CPR),
--BT int
--)

--CREATE TABLE opg2_BS(
--CPR varchar(10) FOREIGN KEY REFERENCES opg2_Patient(CPR),
--BS DECIMAL(4,2)
--)

--CREATE TABLE opg2_Vaegt(
--CPR varchar(10) FOREIGN KEY REFERENCES opg2_Patient(CPR),
--Vaegt DECIMAL(5,2)
--)

--ALTER TABLE opg2_BS
--ADD måleTidspunkt DATETIME PRIMARY KEY

--sp_RENAME 'opg2_BS.måleTidspunkt', 'maaleTidspunkt' , 'COLUMN'

--ALTER TABLE opg2_BT
--ADD maaleTidspunkt DATETIME PRIMARY KEY

--ALTER TABLE opg2_Vaegt
--ADD maaleTidspunkt DATETIME PRIMARY KEY

--INSERT INTO opg2_Patient ( CPR, pNavn) VALUES ('1234567890' , 'Svend Henning')

--INSERT INTO opg2_BS (CPR, BS, maaleTidspunkt) VALUES ('1234567890', 6.4, '2015-01-30 08:00:00')
--INSERT INTO opg2_BS (CPR, BS, maaleTidspunkt) VALUES ('1234567890', 5.6, '2015-01-30 12:30:00')
--INSERT INTO opg2_BS (CPR, BS, maaleTidspunkt) VALUES ('1234567890', 11.5, '2015-01-30 18:45:00')
--INSERT INTO opg2_BS (CPR, BS, maaleTidspunkt) VALUES ('1234567890', 3.7, '2015-01-30 22:15:00')
--INSERT INTO opg2_BS (CPR, BS, maaleTidspunkt) VALUES ('1234567890', 6.3, '2015-01-31 08:00:00')
--INSERT INTO opg2_BS (CPR, BS, maaleTidspunkt) VALUES ('1234567890', 6.0, '2015-01-31 12:30:00')
--INSERT INTO opg2_BS (CPR, BS, maaleTidspunkt) VALUES ('1234567890', 7.9, '2015-01-31 18:45:00')
--INSERT INTO opg2_BS (CPR, BS, maaleTidspunkt) VALUES ('1234567890', 4.8, '2015-01-31 22:15:00')

--sp_RENAME 'opg2_BT.BT' , 'sBT' , 'COLUMN' 

--ALTER TABLE opg2_BT
--ADD dBT int

--INSERT INTO opg2_BT (CPR, sBT, maaleTidspunkt , dBT) VALUES ('1234567890' , 120 , '2015-01-30 08:00:00' , 80)
--INSERT INTO opg2_BT (CPR, sBT, maaleTidspunkt , dBT) VALUES ('1234567890' , 110 , '2015-01-31 08:00:00' , 75)

--ALTER TABLE opg2_BT
--ADD puls int

--INSERT INTO opg2_BT (CPR, sBT, maaleTidspunkt , dBT, puls) VALUES ('1234567890' , 140 , '2015-02-10 18:37:00' , 95, 68)
--INSERT INTO opg2_BT (CPR, sBT, maaleTidspunkt , dBT, puls) VALUES ('1234567890' , 145 , '2015-02-11 08:00:00' , 105 , 72 )
--INSERT INTO opg2_BT (CPR, sBT, maaleTidspunkt , dBT) VALUES ('1234567890' , 150 , '2015-02-21 08:00:00' , 110)

--INSERT INTO opg2_Vaegt VALUES ('1234567890' , 86.5, '2015-01-30 08:00:00')
--INSERT INTO opg2_Vaegt VALUES ('1234567890' , 86.9, '2015-01-30 18:00:00')
--INSERT INTO opg2_Vaegt VALUES ('1234567890' , 87.0, '2015-01-31 08:00:00')
--INSERT INTO opg2_Vaegt VALUES ('1234567890' , 83.0, '2015-02-01 08:00:00')
--INSERT INTO opg2_Vaegt VALUES ('1234567890' , 80.7, '2015-02-10 08:00:00')

--ALTER TABLE opg2_Patient
--ADD Hoejde DECIMAL(5,2)

--ALTER TABLE opg2_Patient
--ALTER COLUMN Hoejde DECIMAL(3,2)





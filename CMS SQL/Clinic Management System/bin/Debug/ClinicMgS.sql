CREATE TABLE Patient(
PID VARCHAR(50) null,
Name varchar(50) null,
Age int null,
Gender VARCHAR(50) null,
CNIC int null,
FatherName VARCHAR(50) null,
MobileNum int null,
MotherName VARCHAR(50) null,
Adddress VARCHAR(50) null,
CheckupFees int null,
AdmitDate varchar(50) null,
Disease VARCHAR(50) null,
DoctorID VARCHAR(50) null ,
DoctorName VARCHAR(50) null,
WardType VARCHAR(50) null,
WardNum VARCHAR(50) null,
RoomNum VARCHAR(50) null,
BedNum VARCHAR(50) null)
Insert into Patient(PID,Name,Age,Gender,CNIC,FatherName,MobileNum,MotherName,Adddress,CheckupFees,AdmitDate,Disease,DoctorID,DoctorName,WardType,WardNum,RoomNum,BedNum) values ('P01','Sajid','55','Male','878787987','Ali','0808098','Sharia','B_Block','200','01-07-2018','Fever','01','Wajid','ER','1','2','3');

CREATE TABLE Medicine (
MID VARCHAR(50)  NULL,
MedicinesName VARCHAR(50) null)


Insert into Medicine(MID,MedicinesName) values ('MID1','Arinek');
Insert into Medicine(MID,MedicinesName) values ('MID2','Panadol');
Insert into Medicine(MID,MedicinesName) values ('MID3','Risek');
Insert into Medicine(MID,MedicinesName) values ('MID4','Ponistan');



CREATE TABLE Staff (
SID VARCHAR(50)  NULL,
SName VARCHAR(50) NULL,
StaffType VARCHAR(50) NULL,
Gender VARCHAR(50) NULL,
DOB VARCHAR(50) NULL,
Address VARCHAR(50) NULL,
City VARCHAR(50) NULL,
MobileNum int NULL,
EmailID VARCHAR(50) NULL,
Experience VARCHAR(50) NULL)


Insert into Staff(SID,SName,StaffType,Gender,DOB,Address,City,MobileNum,EmailID,Experience ) values ('01','Iqbal','Whatt Boy','Male','01-07-1988','Gulshan Iqbal','Karachi','03131313','d@gmail.com','Two years');


CREATE TABLE Appointment (
AID VARCHAR(50) NULL,
ConsultantName VARCHAR(50) NULL,
AdmitDate VARCHAR(50) NULL,
ReleaseDate VARCHAR(50) NULL,
PID int null,
PName VARCHAR(50) NULL,
Disease VARCHAR(50) NULL);
Insert into Appointment(AID,ConsultantName,AdmitDate,ReleaseDate,PID,PName,Disease) values ('1','Hammad','01-02-2018','01-07-2018','01','Qamar','Malaria');




CREATE TABLE Invoice(
PID VARCHAR(50) NULL,
PName VARCHAR(50) NULL,
MobileNum int NULL,
UltraSound int NULL,
Drip int NULL,
Lab int NULL,
Others int NULL,
Total int NULL)

Insert into Invoice(PID,PName,MobileNum,UltraSound,Drip,Lab,Others,Total) values ('1','Asalam','0213131','1','3','2','4','4500');


CREATE TABLE Doctor(
DoctorID VARCHAR(50) NULL,
DoctorName VARCHAR(50) null) ;

insert into Doctor (DoctorID,DoctorName) values ('1','Waqar');















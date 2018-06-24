
USE master;

-- Drop database
IF DB_ID('SalaryApp') IS NOT NULL DROP DATABASE SalaryApp;

-- If database could not be created due to open connections, abort
IF @@ERROR = 3702 
   RAISERROR('Database cannot be dropped because there are still open connections.', 127, 127) WITH NOWAIT, LOG;

CREATE DATABASE SalaryApp;
GO
USE SalaryApp;
GO
CREATE TABLE dbo.Users
(
Id				INT				NOT NULL	IDENTITY ,
Username		NVARCHAR(50)	NOT NULL,
Password		NVARCHAR(50)	NOT NULL,
CreateDate		DATETIME		NOT NULL DEFAULT(SYSDATETIME()),	
CreateByUserId	INT				NOT NULL,
IsDeleted		BIT				NOT NULL DEFAULT(0),
DeletedDate		DATETIME		NULL,
DeletedByUserID	INT				NULL,
CONSTRAINT		PK_Users	PRIMARY KEY(Id),
CONSTRAINT		FK_Users_Users	FOREIGN KEY(CreateByUserId)
	REFERENCES dbo.Users(Id),
CONSTRAINT		FK_Users_Users2	FOREIGN KEY(DeletedByUserID)
	REFERENCES dbo.Users(Id),
);
GO
CREATE TABLE dbo.Companies
(
Id				INT				NOT NULL IDENTITY,
Title			NVARCHAR(100)	NOT NULL,
Tel				NVARCHAR(11)	NOT NULL,
Fax				NVARCHAR(11)	NOT NULL,
Address			NVARCHAR(200)	NOT NULL,
CreateDate		DATETIME		NOT NULL DEFAULT(SYSDATETIME()),
CreateByUserId	INT				NOT NULL,
IsDeleted		BIT				NOT NULL DEFAULT(0),
DeletedDate		DATETIME		NULL,
DeletedByUserID	INT				NULL,
CONSTRAINT		PK_Companies	PRIMARY KEY(Id),
CONSTRAINT		FK_Companies_Users	FOREIGN KEY(CreateByUserId)
	REFERENCES dbo.Users(Id),
CONSTRAINT		FK_Companies_Users2	FOREIGN KEY(DeletedByUserID)
	REFERENCES dbo.Users(Id),
);

GO


CREATE TABLE dbo.Worksites
(
Id				INT				NOT NULL IDENTITY,
CompanyId		INT				NOT NULL,
IsAcitve		BIT				NOT NULL,
Title			NVARCHAR(100)	NOT NULL,
EmployerTitle	NVARCHAR(100)	NOT NULL,
ContractNumber	NVARCHAR(100)	NOT NULL,
Tel				NVARCHAR(11)	NOT NULL,
Fax				NVARCHAR(11)	NOT NULL,
Address			NVARCHAR(200)	NOT NULL,
CreateDate		DATETIME		NOT NULL DEFAULT(SYSDATETIME()),
CreateByUserId	INT				NOT NULL,
IsDeleted		BIT				NOT NULL DEFAULT(0),
DeletedDate		DATETIME		NULL,
DeletedByUserID	INT				NULL,
CONSTRAINT		PK_Worksites	PRIMARY KEY(Id),
CONSTRAINT		FK_Worksites_Companies	FOREIGN KEY(CompanyId)
	REFERENCES dbo.Companies(Id),
CONSTRAINT		FK_Worksites_Users	FOREIGN KEY(CreateByUserId)
	REFERENCES dbo.Users(Id),
CONSTRAINT		FK_Worksites_Users2	FOREIGN KEY(DeletedByUserID)
	REFERENCES dbo.Users(Id),
);

GO

CREATE TABLE dbo.SalaryMonths
(
Id					INT				NOT NULL PRIMARY KEY IDENTITY,
WorksiteId			INT				NOT NULL REFERENCES dbo.Worksites(Id),
Identifire			NVARCHAR(6)		NOT NULL,
Year				INT				NOT NULL,
Month				INT				NOT NULL CHECK(Month<=12),
WorkedDays			INT				NOT	NULL CHECK(WorkedDays<=31),
TimeoffDays			INT				NOT NULL CHECK(TimeoffDays<=31),
AbsentDays			INT				NOT NULL CHECK(AbsentDays<=31),
OverTimeHoures		INT				NOT NULL,
);

GO

CREATE TABLE dbo.Cities
(
Id				INT				NOT NULL IDENTITY,
CityName		NVARCHAR(100)	NOT NULL,

CONSTRAINT		PK_Cities		PRIMARY KEY(Id),
);

GO

CREATE TABLE dbo.Countries
(
Id				INT				NOT NULL IDENTITY,
CountryName		NVARCHAR(200)	NOT NULL,

CONSTRAINT		PK_Countries		PRIMARY KEY(Id),
);

GO

CREATE TABLE dbo.Insurences
(
Id				INT				NOT NULL IDENTITY,
Title			NVARCHAR(100)	NOT NULL,

CONSTRAINT		PK_Insurences	PRIMARY KEY (Id),
);


GO

CREATE TABLE dbo.Banks
(
Id				INT				NOT NULL IDENTITY,
Title			NVARCHAR(100)	NOT NULL,

CONSTRAINT		PK_Banks		PRIMARY KEY(Id),
);


GO

CREATE TABLE dbo.MilitayrStatus
(
Id				INT				NOT NULL IDENTITY,
Title			NVARCHAR(200)	NOT NULL,
	CONSTRAINT PK_MilitaryStatus PRIMARY KEY(Id)
);

GO 

CREATE TABLE dbo.EducationDegrees 
(
Id					INT				NOT NULL IDENTITY,
Title				NVARCHAR(200)	NOT NULL,
CONSTRAINT		PK_EducationDegress  PRIMARY KEY(Id),
);

GO

CREATE TABLE dbo.Gender
(
Id				INT				NOT NULL IDENTITY,
Title			NVARCHAR(20)	NOT NULL,
CONSTRAINT		PK_Gender		PRIMARY KEY(Id),
);

GO

CREATE TABLE dbo.Employees
(
Id					INT				NOT NULL IDENTITY,
FirstName			NVARCHAR(200)	NOT NULL,
LastName			NVARCHAR(200)	NOT NULL,	
FatherName			NVARCHAR(200)	NOT NULL,
POB					INT				NOT	NULL,
DOB					DATETIME			NULL,
POI					INT				NOT	NULL,
NationalCode		NVARCHAR(10)	NOT NULL,
IdNumber			NVARCHAR(10)	NOT NULL,
GenderId			INT				NOT	NULL,
Nationality			INT				NOT	NULL,
HireDate			DATE				NULL,
Experience			INT					NULL,
MilitaryServStId	INT				NOT	NULL,
EducationDegreeId	INT				NOT	NULL,
WorksiteId			INT				NOT NULL,
LaborStatus			INT				NOT NULL,
MaritalStatus		BIT				NOT NULL,
ChildrenNumber		INT				NOT NULL DEFAULT(0),
ComplimentaryInsId	INT					NULL,
ComplimentaryNumber	INT				NOT NULL DEFAULT(0),
InsurenceType		INT				NOT NULL,
InsurenceId			NVARCHAR(10)	NOT NULL,
BankName1			INT 				NULL,
BankAccNumber1		NVARCHAR(30)		NULL,
BankName2			INT 				NULL,
BankAccNumber2		NVARCHAR(30)		NULL,
Children			INT				NOT	NULL,
Education			INT					NULL,
Age					INT					NULL,
Telphone			NVARCHAR(21)			NULL,
Mobile				NVARCHAR(21)			NULL,
Address				NVARCHAR(200)			NULL,
Email				NVARCHAR(100)			NULL,
IsWorking			BIT					NOT NULL DEFAULT(1),

	
CONSTRAINT		PK_Employees		PRIMARY KEY(Id),
CONSTRAINT		FK_Employees_Insurences	FOREIGN KEY (InsurenceType)
	REFERENCES	dbo.Insurences(Id),
CONSTRAINT		FK_Employees_Gender		FOREIGN KEY (GenderId)
	REFERENCES	dbo.Gender(Id),
CONSTRAINT		FK_Employees_MilitaryStatus		FOREIGN KEY (MilitaryServStId)
	REFERENCES	dbo.MilitayrStatus(Id),
CONSTRAINT		FK_Employee_EducationDegree FOREIGN KEY(EducationDegreeId)
	REFERENCES  dbo.EducationDegrees(Id),
CONSTRAINT		FK_Employee_Worksites FOREIGN KEY(WorksiteId)
	REFERENCES  dbo.Worksites(Id),
CONSTRAINT		FK_Employees_Banks1		FOREIGN KEY(BankName1)
	REFERENCES	dbo.Banks(Id),
CONSTRAINT		FK_Employees_Countries	FOREIGN KEY(Nationality)
	REFERENCES	dbo.Countries(Id),
CONSTRAINT		FK_Employees_Banks2		FOREIGN KEY(BankName2)
	REFERENCES	dbo.banks(Id),
CONSTRAINT		FK_Employees_Cities		FOREIGN KEY (POB)
	REFERENCES  dbo.Cities(Id),
CONSTRAINT		FK_Employees_IssuCities	FOREIGN KEY(POI)
	REFERENCES	dbo.Cities(Id),
CONSTRAINT		CHK_Employees_Age CHECK (Age<100)

);

GO


CREATE TABLE dbo.Shifts
(
Id				INT				NOT NULL IDENTITY,
Title			NVARCHAR(20)	NOT NULL,
abbreviation	VARCHAR(1)		NOT NULL,
Description		NVARCHAR(200)		NULL,

CONSTRAINT		PK_Shifs		PRIMARY KEY(Id),
);

GO

CREATE TABLE dbo.MonthWork
(
Id					INT				NOT NULL PRIMARY KEY IDENTITY,
MonthId				INT				NOT NULL REFERENCES dbo.SalaryMonths(Id),
EmployeeId			INT				NOT NULL REFERENCES dbo.Employees(Id),
WorkingDays			INT				NOT	NULL,
TimeOffDays			INT				NOT NULL,
AbsentDays			INT				NOT NULL,
OverTimeHoures		INT				NOT NULL,

CONSTRAINT		CHK_MonthWork_WorkingDays	CHECK (WorkingDays<=31),
CONSTRAINT		CHK_MonthWork_OnVacationDays	CHECK (TimeOffDays<=31),
);

GO




CREATE TABLE dbo.TimeSheet
(
Id				INT				NOT NULL PRIMARY KEY IDENTITY,
EmployeeId		INT				NOT NULL REFERENCES dbo.Employees(Id),
Months			INT				NOT NULL,
Day				INT				NOT NULL,
ShiftId			INT				NOT NULL,

CONSTRAINT		FK_TimeSheet_Shifts FOREIGN KEY(ShiftId)
	REFERENCES	dbo.Shifts(Id),
CONSTRAINT		CHK_TimeSheet_Day	CHECK (Day<=31),
);

GO

CREATE TABLE dbo.WageItems
(
Id				INT				NOT NULL IDENTITY,
Code			INT				NOT NULL,
Title			NVARCHAR(60)	NOT NULL,
Value			DECIMAL			NOT NULL,
Taxfree			BIT				NOT NULL,
IncuranceFree	BIT				NOT NULL,
Des				NVARCHAR(200)		NULL
CONSTRAINT		PK_WageItems		PRIMARY KEY(Id),
CONSTRAINT		UN_WageItems_Code	UNIQUE(Code),
);

GO


CREATE TABLE dbo.MainGroups
(
Id				INT				NOT NULL IDENTITY,
FinYearId		INT				NOT NULL,
CompanyId		INT				NOT NULL,
WorksiteId		INT				NOT NULL,
WageItemCode	INT				NOT NULL,
Des				NVARCHAR(200)		NULL,
CONSTRAINT		PK_MainGroups	PRIMARY KEY(Id),
CONSTRAINT		FK_MainGroup_Companies	FOREIGN KEY(CompanyId)
	REFERENCES	dbo.Companies(Id),
CONSTRAINT		FK_MainGroup_Worksites	FOREIGN KEY(WorksiteId)
	REFERENCES	dbo.Worksites(Id),
CONSTRAINT		FK_MainGroup_WageItems	FOREIGN KEY(WageItemCode)
	REFERENCES	dbo.WageItems(Code),
);

GO

CREATE TABLE dbo.Salaries
(
Id				INT				NOT NULL PRIMARY KEY IDENTITY,
MainGroupId		INT				NOT NULL,
EmployeeId		INT				NOT NULL REFERENCES dbo.Employees(Id),
GrossPay		DECIMAL			NOT NULL,
InsurenceAmount DECIMAL			NOT NULL,
TaxAmount		DECIMAL			NOT NULL,
MiscDeduction	DECIMAL			NOT NULL DEFAULT(0),
NetPay			DECIMAL			NOT NULL,
Description		NVARCHAR(200)		NULL,

CONSTRAINT		FK_Salaries_MainGroup	FOREIGN KEY(MainGroupId)
	REFERENCES	dbo.MainGroups(Id),
CONSTRAINT		CHK_GrossPay	CHECK(GrossPay>0),
CONSTRAINT		CHK_NetPay		CHECK(NetPay>0),
);

CREATE TABLE dbo.SalariesDetail
(
Id					INT				NOT NULL PRIMARY KEY IDENTITY,
SalaryId			INT				NOT NULL REFERENCES dbo.Salaries(Id),
DailyAmount			DECIMAL			NOT NULL,
MonthlyAmount		DECIMAL			NOT NULL,
WorkonFridayAmount	DECIMAL			NOT NULL,
MiscDeduction		DECIMAL			NOT NULL DEFAULT(0),
DelayedPay			DECIMAL			NOT NULL DEFAULT(0),
NetPay				DECIMAL			NOT NULL CHECK(NetPay>=0),
Description			NVARCHAR(200)		NULL,

);

 







CREATE TABLE [dbo].[staff]
(
	[Employee Id]			VARCHAR (50) NOT NULL PRIMARY KEY,
	[Fullname]              VARCHAR (50)    NOT NULL,
    [Address]               VARCHAR (50)    NOT NULL,
    [Category]              VARCHAR (50)    NOT NULL,
    [Date_joined]         DATE            NOT NULL,
    [Sex]                   VARCHAR (50)    NOT NULL,
    [NIC_no]                VARCHAR (50)    NOT NULL,
    [DOB]         DATE            NOT NULL,
    [Contact_No]            VARCHAR (50)    NOT NULL,
    [E-mail ID]             VARCHAR (50)    NOT NULL,
    [Emergency_Name]         VARCHAR (50)    NOT NULL,
    [Emergency_Address]      VARCHAR (50)    NOT NULL,
    [Emergency_phoneno]    VARCHAR (50)    NOT NULL,
    [Emergency_Relationship] VARCHAR (50)    NOT NULL

)

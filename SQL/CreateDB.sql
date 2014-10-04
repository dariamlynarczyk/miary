if (not exists(select top 1 1 from sys.tables where name = 'Patients'))
begin
	create table dbo.Patients
	(
		Id int not null identity primary key clustered,
		GivenName nvarchar(100) not null,
		FamilyName nvarchar(100) not null,
		BirthDate datetime2 not null
	)
end

if (not exists (select top 1 1 from sys.tables where Name = 'Notes'))
begin
	create table dbo.Notes
	(
		Id int not null identity primary key clustered,
		PatientId int not null,
		CreateDate datetime2 not null,
		Content nvarchar(500) not null,
		constraint FK_Note_Patient foreign key (PatientId)
			references Patients(Id)
	)
end

if (not exists (select top 1 1 from sys.tables where name = 'Pictures'))
begin
	create table dbo.Pictures
	(
		Id int not null identity primary key clustered,
		PatientId int not null,
		CreateDate datetime2 not null,
		Summary nvarchar(100) not null,
		Picture varbinary(MAX) not null,
		constraint FK_Pisture_patient foreign key (PatientId)
			references Patients(Id)
	)
end
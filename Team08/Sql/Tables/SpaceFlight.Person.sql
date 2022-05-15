CREATE TABLE SpaceFlight.Person
(

    PersonID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
    FirstName NVARCHAR(64) NOT NULL,
    LastName NVARCHAR(64) NOT NULL,
	EmailAddress NVARCHAR(128) NOT NULL,
    
    UNIQUE(EmailAddress),
);
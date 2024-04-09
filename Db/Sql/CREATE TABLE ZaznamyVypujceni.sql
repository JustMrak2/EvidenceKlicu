CREATE TABLE [dbo].[ZaznamyVypujceni]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
	[IdKlice] INT NOT NULL, --fk
	[IdZamestnance] INT NOT NULL, --fk
	[DatumVypujceni] DATETIME NOT NULL DEFAULT GETDATE(),
	[DatumVraceni] DATETIME

	CONSTRAINT FK_ZaznamyVypujceni_Klice
        FOREIGN KEY (IdKlice)
        REFERENCES Klice(Id),
        
    CONSTRAINT FK_ZaznamyVypujceni_Zamestnanci
        FOREIGN KEY (IdZamestnance)
        REFERENCES Zamestnanci(Id)
)
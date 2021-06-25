CREATE TABLE tbl_Utenti
(
ID INT IDENTITY(1,1) NOT NULL,
NomeUtente NVARCHAR(100) UNIQUE NOT NULL,
Nome NVARCHAR(50) NOT NULL,
Cognome NVARCHAR(50) NOT NULL,
Password_Utente NVARCHAR(20) NOT NULL,
Città_Residenza NVARCHAR(50) NULL,
Reparto NVARCHAR(20) NOT NULL,
Livello INT NOT NULL,
Cancellato BIT NOT NULL
CONSTRAINT PK_Utenti PRIMARY KEY CLUSTERED (ID ASC)
);
--CREAZIONE PRIMO INDICE
CREATE INDEX idx_Utenti
ON tbl_Utenti(ID);

TRUNCATE TABLE tbl_Utenti

--QUERY DI INSERIMENTO
INSERT INTO tbl_Utenti(NomeUtente,Nome,Cognome,Password_Utente,
Città_Residenza,Reparto,Livello,Cancellato)
VALUES
('e.verdi','Enrico','Verdi','Ciao3','Bergamo',
'Amministrazione',1,0),
('a.rossii','Antonio','Rossoni','Ciao2','Milano',
'Logistica',2,0),
('k.george','Kevin','George','Ciao2','Messina',
'IT',3,0)

SELECT * FROM tbl_Utenti


--LIVELLO 1 UTENTE BASE
--LIVELLO 2 UTENTE POWER USER
--LIVELLO 3 UTENTE ADMIN

CREATE VIEW vw_Utenti
AS
SELECT * FROM tbl_Utenti
WHERE Cancellato=0

SELECT * FROM vw_Utenti
--LIVELLO 
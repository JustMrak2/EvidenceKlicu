CREATE DATABASE EvidenceKlicu
ON PRIMARY
    (NAME = 'EvidenceKlicu_data',
    FILENAME = '$(DbPath)\Data\EvidenceKlicu.mdf',
    SIZE = 100MB,
    MAXSIZE = UNLIMITED,
    FILEGROWTH = 10MB)
LOG ON
    (NAME = 'EvidenceKlicu_log',
    FILENAME = '$(DbPath)\Log\EvidenceKlicu.ldf',
    SIZE = 50MB,
    MAXSIZE = 100MB,
    FILEGROWTH = 5MB);

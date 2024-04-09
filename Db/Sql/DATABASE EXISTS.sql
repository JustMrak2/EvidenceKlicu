IF EXISTS (SELECT 1 FROM sys.databases WHERE name = 'EvidenceKlicu')
    SELECT 1 AS Result;
ELSE
    SELECT 0 AS Result;
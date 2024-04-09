-- Similarly, check for the presence of the Zamestnanci table and its columns
-- (Repeat the above pattern for each table)
-- Check for Zamestnanci table
IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'Zamestnanci')
BEGIN
    IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'Zamestnanci' AND COLUMN_NAME = 'Id')
        AND EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'Zamestnanci' AND COLUMN_NAME = 'Jmeno')
        AND EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'Zamestnanci' AND COLUMN_NAME = 'Prijmeni')
        AND EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'Zamestnanci' AND COLUMN_NAME = 'Zkratka')
    BEGIN
        SELECT 2 AS Result; --'Table "Zamestnanci" exists with required columns.'
    END
    ELSE
    BEGIN
        SELECT 1 AS Result; --'Table "Zamestnanci" exists but is missing required columns.'
    END
END
ELSE
BEGIN
    SELECT 0 AS Result; --'Table "Zamestnanci" does not exist in the database.'
END
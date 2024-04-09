-- Check for the presence of the Klice table and its columns
IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'Klice')
BEGIN
    IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'Klice' AND COLUMN_NAME = 'Id')
        AND EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'Klice' AND COLUMN_NAME = 'NazevMistnosti')
        AND EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'Klice' AND COLUMN_NAME = 'OznaceniDveri')
        AND EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'Klice' AND COLUMN_NAME = 'PocetKusu')
    BEGIN
        SELECT 2 AS Result; --'Table "Klice" exists with required columns.'
    END
    ELSE
    BEGIN
        SELECT 1 AS Result; --'Table "Klice" exists but is missing required columns.'
    END
END
ELSE
BEGIN
    SELECT 0 AS Result; --'Table "Klice" does not exist in the database.'
END
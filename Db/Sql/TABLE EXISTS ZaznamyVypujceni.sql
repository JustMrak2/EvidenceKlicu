-- Check for ZaznamyVypujceni table
IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'ZaznamyVypujceni')
BEGIN
    IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'ZaznamyVypujceni' AND COLUMN_NAME = 'Id')
        AND EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'ZaznamyVypujceni' AND COLUMN_NAME = 'IdKlice')
        AND EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'ZaznamyVypujceni' AND COLUMN_NAME = 'IdZamestnance')
        AND EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'ZaznamyVypujceni' AND COLUMN_NAME = 'DatumVypujceni')
        AND EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'ZaznamyVypujceni' AND COLUMN_NAME = 'DatumVraceni')
    BEGIN
        SELECT 2 AS Result; --'Table "ZaznamyVypujceni" exists with required columns.'
    END
    ELSE
    BEGIN
        SELECT 1 AS Result; --'Table "ZaznamyVypujceni" exists but is missing required columns.'
    END
END
ELSE
BEGIN
    SELECT 0 AS Result; --'Table "ZaznamyVypujceni" does not exist in the database.'
END
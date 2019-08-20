IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [companies] (
    [id] int NOT NULL IDENTITY,
    [name] nvarchar(max) NULL,
    [startDate] datetime2 NOT NULL,
    CONSTRAINT [PK_companies] PRIMARY KEY ([id])
);

GO

CREATE TABLE [departments] (
    [id] int NOT NULL IDENTITY,
    [companyId] int NOT NULL,
    CONSTRAINT [PK_departments] PRIMARY KEY ([id]),
    CONSTRAINT [FK_departments_companies_companyId] FOREIGN KEY ([companyId]) REFERENCES [companies] ([id]) ON DELETE CASCADE
);

GO

CREATE INDEX [IX_departments_companyId] ON [departments] ([companyId]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20190819111027_Initial', N'2.2.6-servicing-10079');

GO


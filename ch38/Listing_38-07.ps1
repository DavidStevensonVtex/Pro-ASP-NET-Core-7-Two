# Listing 38.7 Creating and applying the database migration

dotnet ef migrations add --context IdentityContext Initial
dotnet ef database update --context IdentityContext

# PS D:\drs\ASPNETCore\Pro-ASP-NET-Core-7-Two\ch38\Advanced> ..\Listing_38-07.ps1
# Build started...
# Build succeeded.
# Done. To undo this action, use 'ef migrations remove'
# Build started...
# Build succeeded.
# info: Microsoft.EntityFrameworkCore.Database.Command[20101]
#       Executed DbCommand (234ms) [Parameters=[], CommandType='Text', CommandTimeout='60']
#       CREATE DATABASE [Identity_7];
# info: Microsoft.EntityFrameworkCore.Database.Command[20101]
#       Executed DbCommand (113ms) [Parameters=[], CommandType='Text', CommandTimeout='60']
#       IF SERVERPROPERTY('EngineEdition') <> 5
#       BEGIN
#           ALTER DATABASE [Identity_7] SET READ_COMMITTED_SNAPSHOT ON;
#       END;
# info: Microsoft.EntityFrameworkCore.Database.Command[20101]
#       Executed DbCommand (6ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
#       SELECT 1
# info: Microsoft.EntityFrameworkCore.Database.Command[20101]
#       Executed DbCommand (7ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
#       CREATE TABLE [__EFMigrationsHistory] (
#           [MigrationId] nvarchar(150) NOT NULL,
#           [ProductVersion] nvarchar(32) NOT NULL,
#           CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
#       );
# info: Microsoft.EntityFrameworkCore.Database.Command[20101]
#       Executed DbCommand (1ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
#       SELECT 1
# info: Microsoft.EntityFrameworkCore.Database.Command[20101]
#       Executed DbCommand (10ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
#       SELECT OBJECT_ID(N'[__EFMigrationsHistory]');
# info: Microsoft.EntityFrameworkCore.Database.Command[20101]
#       Executed DbCommand (9ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
#       SELECT [MigrationId], [ProductVersion]
#       FROM [__EFMigrationsHistory]
#       ORDER BY [MigrationId];
# info: Microsoft.EntityFrameworkCore.Migrations[20402]
#       Applying migration '20241120160019_Initial'.
# Applying migration '20241120160019_Initial'.
# info: Microsoft.EntityFrameworkCore.Database.Command[20101]
#       Executed DbCommand (2ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
#       CREATE TABLE [AspNetRoles] (
#           [Id] nvarchar(450) NOT NULL,
#           [Name] nvarchar(256) NULL,
#           [NormalizedName] nvarchar(256) NULL,
#           [ConcurrencyStamp] nvarchar(max) NULL,
#           CONSTRAINT [PK_AspNetRoles] PRIMARY KEY ([Id])
#       );
# info: Microsoft.EntityFrameworkCore.Database.Command[20101]
#       Executed DbCommand (3ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
#       CREATE TABLE [AspNetUsers] (
#           [Id] nvarchar(450) NOT NULL,
#           [UserName] nvarchar(256) NULL,
#           [NormalizedUserName] nvarchar(256) NULL,
#           [Email] nvarchar(256) NULL,
#           [NormalizedEmail] nvarchar(256) NULL,
#           [EmailConfirmed] bit NOT NULL,
#           [PasswordHash] nvarchar(max) NULL,
#           [SecurityStamp] nvarchar(max) NULL,
#           [ConcurrencyStamp] nvarchar(max) NULL,
#           [PhoneNumber] nvarchar(max) NULL,
#           [PhoneNumberConfirmed] bit NOT NULL,
#           [TwoFactorEnabled] bit NOT NULL,
#           [LockoutEnd] datetimeoffset NULL,
#           [LockoutEnabled] bit NOT NULL,
#           [AccessFailedCount] int NOT NULL,
#           CONSTRAINT [PK_AspNetUsers] PRIMARY KEY ([Id])
#       );
# info: Microsoft.EntityFrameworkCore.Database.Command[20101]
#       Executed DbCommand (9ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
#       CREATE TABLE [AspNetRoleClaims] (
#           [Id] int NOT NULL IDENTITY,
#           [RoleId] nvarchar(450) NOT NULL,
#           [ClaimType] nvarchar(max) NULL,
#           [ClaimValue] nvarchar(max) NULL,
#           CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY ([Id]),
#           CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE
#       );
# info: Microsoft.EntityFrameworkCore.Database.Command[20101]
#       Executed DbCommand (4ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
#       CREATE TABLE [AspNetUserClaims] (
#           [Id] int NOT NULL IDENTITY,
#           [UserId] nvarchar(450) NOT NULL,
#           [ClaimType] nvarchar(max) NULL,
#           [ClaimValue] nvarchar(max) NULL,
#           CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY ([Id]),
#           CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
#       );
# info: Microsoft.EntityFrameworkCore.Database.Command[20101]
#       Executed DbCommand (7ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
#       CREATE TABLE [AspNetUserLogins] (
#           [LoginProvider] nvarchar(450) NOT NULL,
#           [ProviderKey] nvarchar(450) NOT NULL,
#           [ProviderDisplayName] nvarchar(max) NULL,
#           [UserId] nvarchar(450) NOT NULL,
#           CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY ([LoginProvider], [ProviderKey]),
#           CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
#       );
# info: Microsoft.EntityFrameworkCore.Database.Command[20101]
#       Executed DbCommand (5ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
#       CREATE TABLE [AspNetUserRoles] (
#           [UserId] nvarchar(450) NOT NULL,
#           [RoleId] nvarchar(450) NOT NULL,
#           CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY ([UserId], [RoleId]),
#           CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE,
#           CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
#       );
# info: Microsoft.EntityFrameworkCore.Database.Command[20101]
#       Executed DbCommand (4ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
#       CREATE TABLE [AspNetUserTokens] (
#           [UserId] nvarchar(450) NOT NULL,
#           [LoginProvider] nvarchar(450) NOT NULL,
#           [Name] nvarchar(450) NOT NULL,
#           [Value] nvarchar(max) NULL,
#           CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY ([UserId], [LoginProvider], [Name]),
#           CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
#       );
# info: Microsoft.EntityFrameworkCore.Database.Command[20101]
#       Executed DbCommand (3ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
#       CREATE INDEX [IX_AspNetRoleClaims_RoleId] ON [AspNetRoleClaims] ([RoleId]);
# info: Microsoft.EntityFrameworkCore.Database.Command[20101]
#       Executed DbCommand (4ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
#       CREATE UNIQUE INDEX [RoleNameIndex] ON [AspNetRoles] ([NormalizedName]) WHERE [NormalizedName] IS NOT NULL;
# info: Microsoft.EntityFrameworkCore.Database.Command[20101]
#       Executed DbCommand (2ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
#       CREATE INDEX [IX_AspNetUserClaims_UserId] ON [AspNetUserClaims] ([UserId]);
# info: Microsoft.EntityFrameworkCore.Database.Command[20101]
#       Executed DbCommand (2ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
#       CREATE INDEX [IX_AspNetUserLogins_UserId] ON [AspNetUserLogins] ([UserId]);
# info: Microsoft.EntityFrameworkCore.Database.Command[20101]
#       Executed DbCommand (1ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
#       CREATE INDEX [IX_AspNetUserRoles_RoleId] ON [AspNetUserRoles] ([RoleId]);
# info: Microsoft.EntityFrameworkCore.Database.Command[20101]
#       Executed DbCommand (2ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
#       CREATE INDEX [EmailIndex] ON [AspNetUsers] ([NormalizedEmail]);
# info: Microsoft.EntityFrameworkCore.Database.Command[20101]
#       Executed DbCommand (3ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
#       CREATE UNIQUE INDEX [UserNameIndex] ON [AspNetUsers] ([NormalizedUserName]) WHERE [NormalizedUserName] IS NOT NULL;
# info: Microsoft.EntityFrameworkCore.Database.Command[20101]
#       Executed DbCommand (6ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
#       INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
#       VALUES (N'20241120160019_Initial', N'8.0.11');
# Done.


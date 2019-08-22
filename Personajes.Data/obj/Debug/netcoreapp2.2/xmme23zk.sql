CREATE TABLE IF NOT EXISTS "__EFMigrationsHistory" (
    "MigrationId" TEXT NOT NULL CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY,
    "ProductVersion" TEXT NOT NULL
);

CREATE TABLE "Atributos" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_Atributos" PRIMARY KEY AUTOINCREMENT,
    "nombre" TEXT NULL,
    "fuerza" INTEGER NOT NULL,
    "destreza" INTEGER NOT NULL,
    "vitalidad" INTEGER NOT NULL,
    "puntosdegolpe" INTEGER NOT NULL
);

CREATE TABLE "Habilidades" (
    "id" INTEGER NOT NULL CONSTRAINT "PK_Habilidades" PRIMARY KEY AUTOINCREMENT,
    "nombreHabilidad" TEXT NULL,
    "poder" INTEGER NOT NULL,
    "AtributoId" INTEGER NULL,
    CONSTRAINT "FK_Habilidades_Atributos_AtributoId" FOREIGN KEY ("AtributoId") REFERENCES "Atributos" ("Id") ON DELETE RESTRICT
);

CREATE INDEX "IX_Habilidades_AtributoId" ON "Habilidades" ("AtributoId");

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20190822044012_inicial', '2.2.6-servicing-10079');


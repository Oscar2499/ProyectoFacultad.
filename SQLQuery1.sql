--- Crear Table de Alumnos

Drop table dbo.ALumnos
CREATE TABLE dbo.ALumnos(
Id_Control int NOT NULL,
Nombre     varchar(50) NOT NULL,
Ape_Paterno varchar(50) NOT NULL,
Ape_Materno varchar(50) NOT NULL,
Fecha_ing   Datetime    NOT NULL,
Estado_Civil tinyint    NOT NULL,
Sexo_Alu     tinyint    NOT NULL,
Id_Carrera   tinyint    NOT NULL,
Id_Materia   tinyint    NOT NULL
)
---
---Agregar la llave primaria a la tabla de Alumnos.
---
ALTER TABLE ALumnos ADD CONSTRAINT pk_ALumnos_Id PRIMARY KEY (Id_Control)

Insert into ALumnos VALUES(1, 'JUAN', 'PEREZ', 'PEREZ', '20210101',1,1,1,1)
Select * from ALumnos
delete from ALumnos
---
---Agregar a la tabla de Alumnos la llave Foranea de la tabla de Carrera.
---
ALTER TABLE ALumnos
ADD FOREIGN KEY (Id_Carrera) REFERENCES Carreras(Id_Carrera);
---
---Agregar a la tabla de Alumnos la llave Foranea de la tabla de Materias.
---
ALTER TABLE ALumnos
ADD FOREIGN KEY (Id_Materia) REFERENCES Materias(Id_Materia);

---
---Crear Tabla de Carreras
---
Drop table dbo.Carreras
go
CREATE TABLE dbo.Carreras(
Id_Carrera tinyint NOT NULL,
Nom_Carrera varchar(50) NOT NULL
)
go
---
---Agrega llave primaria a la tabla de Carreras.
---
ALTER TABLE Carreras ADD CONSTRAINT pk_Carreras_Id Primary Key (Id_Carrera)
go
SELECT * FROM Carreras
Delete FROM Carreras

Insert into Carreras VALUES(1, 'INGENIERO EN SISTEMAS COMPUTACIONALES')
Insert into Carreras VALUES(2, 'INGENIERO EN MECATRONICA')
Insert into Carreras VALUES(3, 'INGENIERO EN MECANICA ELECTROMECANICO')
Insert into Carreras VALUES(4, 'INGENIERO EN INGENIERIA INDUSTRIAL')
Insert into Carreras VALUES(5, 'INGENIERO EN GESTION EMPRESARIAL')


---
--- Crear tabla de Materias
---

Drop table dbo.Materias
go
CREATE TABLE dbo.Materias(
Id_Materia tinyint NOT NULL,
Nom_Materia varchar(50) NOT NULL
)
go
---
--- Agregar la llave primaria a la tabla materias.
---
ALTER TABLE Materias ADD CONSTRAINT pk_Materias_Id Primary Key (Id_Materia)
go
Insert into Materias VALUES(1, 'MATEMATICAS')
Insert into Materias VALUES(2, 'FISICA')
Insert into Materias VALUES(3, 'TALLER DE BASES DE DATOS')
Insert into Materias VALUES(4, 'PROGRAMACION WEB')
Insert into Materias VALUES(5, 'FUNDAMENTOS DE BASES DE DATOS')

SELECT * FROM Materias
DELETE FROM Materias WHERE Id_Materia = 1
---Drop Procedure sp_Alumnos
Drop Procedure sp_Alumnos
Execute sp_Alumnos 'I', 1, 'Rolando', 'Lopez' , 'Lopez', '20210210', 1,1,1,1
Execute sp_Alumnos 'T'
Execute sp_Alumnos 'L', 1
Execute sp_Alumnos 'C', 1, 'Rolandox', 'Lopezx' , 'Lopezx', '20210211', 2,2,2,2
Execute sp_Alumnos 'D', 1

go
Create Procedure sp_Alumnos
@Operacion char(1),
@Id_Control int = NULL,
@Nombre varchar(50) = NULL,
@Ape_Paterno varchar(50) = NULL,
@Ape_Materno varchar(50) = NULL,
@Fecha_ing Datetime = NULL,
@Estado_Civil tinyint = NULL,
@Sexo_Alu tinyint = NULL,
@Id_Carrera tinyint = NULL,
@Id_Materia tinyint = NULL
as
---
--- Insertar fila de alumnos a la tabla de Alumnos.
---
If @Operacion = 'I'
Begin
Begin Transaction
Insert into ALumnos (Id_Control,
Nombre,
Ape_Paterno,
Ape_Materno,
Fecha_ing,
Estado_Civil,
Sexo_Alu,
Id_Carrera,
Id_Materia)
Values(@Id_Control,
@Nombre,
@Ape_Paterno,
@Ape_Materno,
@Fecha_ing,
@Estado_Civil,
@Sexo_Alu,
@Id_Carrera,
@Id_Materia)
if @@ERROR <> 0
RollBack Transaction
else 
Commit Transaction
End
---
---Listar toda la tabla de Alumnos ordenado por Id_Control.
---
If @Operacion = 'T'
Begin
Select *
from ALumnos 
order by Id_Control
End
---
---Listar un alumno de la tabla de Alumnos
---
If @Operacion = 'L'
Begin
Select *
from ALumnos
where Id_Control = @Id_Control
End
---
--- Cambiar columnas a la tabla de Alumnos.
---
If @Operacion = 'C'
Begin
Begin Transaction
update ALumnos set Nombre = @Nombre,
Ape_Paterno = @Ape_Paterno,
Ape_Materno = @Ape_Materno,
Fecha_ing = @Fecha_ing,
Estado_Civil = @Estado_Civil,
Sexo_Alu = @Sexo_Alu,
Id_Carrera = @Id_Carrera,
Id_Materia = @Id_Materia
where Id_Control = @Id_Control
if @@ERROR <> 0
RollBack Transaction
else
Commit Transaction
End
---
---Borrar una fila de la tabla Alumnos
---
If @Operacion = 'D'
Begin
Begin Transaction
Delete ALumnos
where Id_Control = @Id_Control
if @@ERROR <> 0
RollBack Transaction
else
Commit Transaction
End


--- Drop Procedure Carrera
Execute sp_Carreras 'I', 10, 'INGENIERO MECANICO ELECTRICÓ'
Execute sp_Carreras 'C', 10, 'INGENIERO QUIMICO Y DE SISTEMAS'
Execute sp_Carreras 'D', 10
Execute sp_Carreras 'L', 10
Execute sp_Carreras 'T'

Drop Procedure sp_Carreras
Create Procedure sp_Carreras
@Operacion char(1),
@Id_Carrera tinyint = NULL,
@Nom_Carrera VARCHAR(50) = NULL
as
---
---Listar toda la tabla de Carreraas ordenado por Id_Carrera.
---
If @Operacion = 'T'
Begin
Select *
from Carreras
order by Id_Carrera
End
---
---Listar una fila de la tabla de Carreras.
---
If @Operacion = 'L'
Begin 
Select *
from Carreras
where Id_Carrera = @Id_Carrera
End
---
---Insertar fila de la tabla de Carreras.
---
If @Operacion = 'I'
Begin
Begin Transaction 
Insert into Carreras (Id_Carrera,
Nom_Carrera)
Values(@Id_Carrera,
@Nom_Carrera)
if @@ERROR <> 0
RollBack Transaction 
else
Commit Transaction
End
---
---Cambiar columnas a la table de Carreras.
---
If @Operacion = 'C'
Begin
Begin Transaction
update Carreras set Nom_Carrera = @Nom_Carrera
where Id_Carrera = @Id_Carrera
if @@ERROR <> 0
RollBack Transaction
else
Commit Transaction
End
---
--- Borrar una fila de la tabla de Carreras.
---
If @Operacion = 'D'
Begin 
Begin Transaction
Delete Carreras
where Id_Carrera = @Id_Carrera
if @@ERROR <> 0
RollBack Transaction
else
Commit Transaction
End
---
---Drop Procedure Materias
---
EXECUTE sp_Materias 'I', 5, 'GEOGRAFIA'
EXECUTE sp_Materias 'C', 5, 'Fundamentos de Bases de datos'
EXECUTE sp_Materias 'D', 6
EXECUTE sp_Materias 'L', 5
EXECUTE sp_Materias 'T'

Drop Procedure sp_Materias
Create Procedure sp_Materias
@Operacion char(1),
@Id_Materia tinyint = NULL,
@Nom_Materia VARCHAR(50) = NULL
as
---
---Listar toda la tabla de Materias ordenado por Id_Materia.
---
If @Operacion = 'T'
Begin
Select *
from Materias
order by Id_Materia
End
---
---Listar una fila de la tabla de Materias.
---
If @Operacion = 'L'
Begin 
Select *
from Materias
where Id_Materia = @Id_Materia
End
---
---Insertar fila de la tabla de Materias.
---
If @Operacion = 'I'
Begin
Begin Transaction 
Insert into Materias(Id_Materia,
Nom_Materia)
Values(@Id_Materia,
@Nom_Materia)
if @@ERROR <> 0
RollBack Transaction 
else
Commit Transaction
End
---
---Cambiar columnas a la tabla de Materias.
---
If @Operacion = 'C'
Begin
Begin Transaction
update Materias set Nom_Materia = @Nom_Materia
where Id_Materia = @Id_Materia
if @@ERROR <> 0
RollBack Transaction
else
Commit Transaction
End
---
--- Borrar una fila de la tabla de Materias.
---
If @Operacion = 'D'
Begin 
Begin Transaction
Delete Materias
where Id_Materia = @Id_Materia
if @@ERROR <> 0
RollBack Transaction
else
Commit Transaction
End




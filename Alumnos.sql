create database PrograWeb16


create table Alumnos_BRM
(Id_Control int not null,
Nombre varchar(50) not null,
Ape_Paterno varchar(50) not null,
Ape_Materno varchar(50) not null,
Id_Carrera tinyint not null,
Id_Materia tinyint not null)

create table Carreras_BRM
(Id_Carrera tinyint not null,
Nom_Carrera varchar(50) not null)

create table Materias_BRM
(Id_Materia tinyint not null,
Nom_Materia varchar(50) not null)

create procedure sp_Alumnos_BRM
@Operacion char(1),
@Id_Control int = null,
@Nombre varchar(50) = null,
@Ape_Paterno varchar(50) = null,
@Ape_Materno varchar(50) = null,
@Id_Carrera tinyint = null,
@Id_Materia tinyint = null
As
if (@Operacion = 'I')
begin
begin transaction
INSERT INTO Alumnos_BRM (Id_Control, Nombre, Ape_Paterno, Ape_Materno, Id_Carrera, Id_Materia)
VALUES (@Id_Control, @Nombre, @Ape_Paterno, @Ape_Materno, @Id_Carrera, @Id_Materia)
if @@ERROR<>0
rollback transaction
else
commit transaction
end

if (@Operacion = 'C')
begin
begin transaction
       UPDATE Alumnos_BRM SET
       Nombre = @Nombre,
       Ape_Paterno = @Ape_Paterno,
       Ape_Materno = @Ape_Materno,
	   Id_Carrera = @Id_Carrera,
	   Id_Materia = @Id_Materia
      WHERE Id_Control = @Id_Control
if @@ERROR<>0
rollback transaction
else
commit transaction
end

if (@Operacion = 'D')
begin
begin transaction
delete Alumnos_BRM
where Id_Control = @Id_Control
if @@ERROR<>0
rollback transaction
else
commit transaction
end 

if (@Operacion = 'L')
begin
select * from Alumnos_BRM where Id_Control = @Id_Control
end

if (@Operacion = 'T')
begin
select * from Alumnos_BRM
end

if (@Operacion = 'R')
begin
select al.Id_Control, al.Nombre, al.Ape_Paterno, al.Ape_Materno, ca.Nom_Carrera, mat.Nom_Materia
from Alumnos_BRM as al
join Carreras_BRM as ca on al.Id_Carrera = ca.Id_Carrera
join Materias_BRM as mat on al.Id_Materia = mat.Id_Materia
order by al.Id_Control
end

execute sp_Alumnos_BRM 'C', 1548720, 'ertyu', 'Rios', 'Martinez', 1, 1 
execute sp_Alumnos_BRM 'T'
---------------------------------------------------------------------------------------------------------------

create procedure sp_Carreras_BRM
@Operacion char(1),
@Id_Carrera tinyint = null,
@Nom_Carrera varchar(50) = null
As
if (@Operacion = 'I')
begin
begin transaction
INSERT INTO Carreras_BRM (Id_Carrera, Nom_Carrera)
VALUES (@Id_Carrera, @Nom_Carrera)
if @@ERROR<>0
rollback transaction
else
commit transaction
end

if (@Operacion = 'C')
begin
begin transaction
       UPDATE Carreras_BRM SET
       Nom_Carrera = @Nom_Carrera
      WHERE Id_Carrera = @Id_Carrera
if @@ERROR<>0
rollback transaction
else
commit transaction
end

if (@Operacion = 'D')
begin
begin transaction
delete Carreras_BRM
where Id_Carrera = @Id_Carrera
if @@ERROR<>0
rollback transaction
else
commit transaction
end 

if (@Operacion = 'L')
begin
select * from Carreras_BRM where Id_Carrera = @Id_Carrera
end

if (@Operacion = 'T')
begin
select * from Carreras_BRM
end

execute sp_Carreras_BRM 'T', 1, 'ISC'
-------------------------------------------------------------------------------------------------------------

create procedure sp_Materias_BRM
@Operacion char(1),
@Id_Materia tinyint = null,
@Nom_Materia varchar(50) = null
As
if (@Operacion = 'I')
begin
begin transaction
INSERT INTO Materias_BRM (Id_Materia, Nom_Materia)
VALUES (@Id_Materia, @Nom_Materia)
if @@ERROR<>0
rollback transaction
else
commit transaction
end

if (@Operacion = 'C')
begin
begin transaction
       UPDATE Materias_BRM SET
       Nom_Materia = @Nom_Materia
      WHERE Id_Materia = @Id_Materia
if @@ERROR<>0
rollback transaction
else
commit transaction
end

if (@Operacion = 'D')
begin
begin transaction
delete Materias_BRM
where Id_Materia = @Id_Materia
if @@ERROR<>0
rollback transaction
else
commit transaction
end 

if (@Operacion = 'L')
begin
select * from Materias_BRM where Id_Materia = @Id_Materia
end

if (@Operacion = 'T')
begin
select * from Materias_BRM
end

execute sp_Materias_BRM 'T', 1, 'Precalculo'


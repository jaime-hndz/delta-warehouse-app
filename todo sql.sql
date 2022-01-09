
Create database ALMACEN
go

Use ALMACEN
go

Create table Empleados(
ID_Empleado int identity,
Nombre varchar(30),
Apellido varchar(30),
Puesto varchar(100),
Sexo varchar(20),
Edad int,
Direccion varchar(60),
Telefono_Casa varchar(20),
Telefono_Personal varchar(30),
Tiene_Hijos bit,
Tiene_Pareja bit,
Primary key(ID_Empleado)
)
 go

 Create table Nomina(
ID_Empleado int identity,
Nombre varchar(30),
Apellido varchar(30),
Puesto varchar(20),
Sueldo_Bruto money,
Prestaciones money,
Sueldo_Horas_Extras money,
Primary key(ID_Empleado)
)
go

 select*from Empleados

create table Usuarios
(
Nombre varchar(30) not null,
Apellido varchar(30) not null,
Usuario varchar(20) not null,
Contraseña varchar(20) not null,
Tipo varchar(20) not null, 
primary key(Usuario)

)

create table PRODUCTOS
(
Codigo_Producto int identity,
Nombre_Producto varchar(30) not null,
Categoria varchar(30) not null,
Cantidades int not null,
Precio decimal not null,
Fecha_entrega varchar(50)not null, 
Proveedor varchar(30),
primary key(Codigo_Producto)

)

create table PROVEEDORES
(
Codigo_Proveedor int identity,
Proveedor varchar(30) not null,
Direccion varchar(100) not null,
Pais_procedencia varchar(30),
sucursal_rd bit,
primary key(Codigo_Proveedor)

)

insert into Usuarios values ('Jaime', 'Hernández', 'admin', 'contraseña', 'Admin')

Insert into PRODUCTOS values('Salami Induveca', 'Carnes', 1000, 100, '9/5/2019', 'Induveca')


select * from Usuarios



  -- Estas dos líneas solo son necesarias la primera vez.
  drop table pedidosarticulos;
  drop table pedidos;
  
  DROP TABLE "ARTICULOS" cascade constraints;
  DROP TABLE "CAJA_APUNTES" cascade constraints;
  DROP TABLE "CAJA_COBRODEUDAS" cascade constraints;
  DROP TABLE "CAJA_PROCEDENCIADESTINO" cascade constraints;
  DROP TABLE "CAJA_TIPOSPAGO" cascade constraints;
  DROP TABLE "CAMBIOS" cascade constraints;
  DROP TABLE "CLIENTES" cascade constraints;
  DROP TABLE "FACTURAS_CLIENTES" cascade constraints;
  DROP TABLE "FACTURAS_CLIENTES_DETALLES" cascade constraints;
  DROP TABLE "FORMASDEPAGO" cascade constraints;
  DROP TABLE "PEDIDOS_CLIENTES" cascade constraints;
  DROP TABLE "PEDIDOS_CLIENTES_ARTICULOS" cascade constraints;
  DROP TABLE "PEDIDOS_ESTADOS" cascade constraints;
  DROP TABLE "PEDIDOS_PROVEEDORES" cascade constraints;
  DROP TABLE "PEDIDOS_PROVEEDORES_ARTICULOS" cascade constraints;
  DROP TABLE "PROVEEDORES" cascade constraints;
  DROP TABLE "RELACIONARTICULOS" cascade constraints;
  DROP TABLE "RELACION_FACTURAS_PEDCLIENTES" cascade constraints;
  DROP TABLE "TIPOS" cascade constraints;
  DROP TABLE "USUARIOS" cascade constraints;
  DROP SEQUENCE "IDARTICSEQ";
  DROP SEQUENCE "IDCAJAAPUNTESSEQ";
  DROP SEQUENCE "IDCAJACOBRODEUDASSEQ";
  DROP SEQUENCE "IDCAMBIOSSEQ";
  DROP SEQUENCE "IDCLIENTESSEQ";
  DROP SEQUENCE "IDFPAGOSSEQ";
  DROP SEQUENCE "IDPEDARTICSEQ";
  DROP SEQUENCE "IDPEDIDOSSEQ";
  DROP SEQUENCE "IDTIPOSSEQ";
  DROP SEQUENCE "IDUSUARIOSSEQ";

--------------------------------------------------------
--  File created - martes-enero-28-2014   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Table ARTICULOS
--------------------------------------------------------

  CREATE TABLE "ARTICULOS" 
   (	"IDARTICULO" NUMBER, 
	"NOMBRE" VARCHAR2(40), 
	"REFTIPO" NUMBER, 
	"PRECIO" FLOAT(126), 
	"ELIMINADO" NUMBER, 
	"NUMARTICULO" NUMBER, 
	"STOCK" NUMBER
   ) ;
--------------------------------------------------------
--  DDL for Table CAJA_APUNTES
--------------------------------------------------------

  CREATE TABLE "CAJA_APUNTES" 
   (	"ID" NUMBER, 
	"TIPOAPUNTE" VARCHAR2(1), 
	"PROCED_DESTINO" NUMBER, 
	"TIPO_PAGO" NUMBER, 
	"CONCEPTO" VARCHAR2(250), 
	"IMPORTE" NUMBER, 
	"FECHA" NUMBER, 
	"HORA" NUMBER, 
	"USUARIO" NUMBER
   ) ;
--------------------------------------------------------
--  DDL for Table CAJA_COBRODEUDAS
--------------------------------------------------------

  CREATE TABLE "CAJA_COBRODEUDAS" 
   (	"ID" NUMBER, 
	"PROCEDENCIA" NUMBER, 
	"CONCEPTO" VARCHAR2(100), 
	"IMPORTE" FLOAT(126), 
	"FECHA" NUMBER, 
	"HORA" NUMBER, 
	"TIPO" NUMBER, 
	"USUARIO" NUMBER, 
	"ELIMINADO" NUMBER
   ) ;
--------------------------------------------------------
--  DDL for Table CAJA_PROCEDENCIADESTINO
--------------------------------------------------------

  CREATE TABLE "CAJA_PROCEDENCIADESTINO" 
   (	"ID" NUMBER, 
	"DESCRIPCION" VARCHAR2(100), 
	"TIPO" NUMBER
   ) ;
--------------------------------------------------------
--  DDL for Table CAJA_TIPOSPAGO
--------------------------------------------------------

  CREATE TABLE "CAJA_TIPOSPAGO" 
   (	"ID" NUMBER, 
	"DESCRIPCION" VARCHAR2(100)
   ) ;
--------------------------------------------------------
--  DDL for Table CAMBIOS
--------------------------------------------------------

  CREATE TABLE "CAMBIOS" 
   (	"IDCAMBIO" NUMBER, 
	"NUMCAMBIO" NUMBER, 
	"REFUSUARIO" NUMBER, 
	"FECHA" NUMBER, 
	"HORA" NUMBER, 
	"DESCRIPCION" VARCHAR2(100), 
	"TIPO" CHAR(1)
   ) ;
--------------------------------------------------------
--  DDL for Table CLIENTES
--------------------------------------------------------

  CREATE TABLE "CLIENTES" 
   (	"IDCLIENTE" NUMBER, 
	"NOMBRE" VARCHAR2(30), 
	"APELLIDO1" VARCHAR2(20), 
	"APELLIDO2" VARCHAR2(20), 
	"DIRECCION" VARCHAR2(30), 
	"REFCPPOBLACIONES" NUMBER, 
	"TELEFONO" NUMBER, 
	"MAIL" VARCHAR2(30), 
	"ELIMINADO" NUMBER, 
	"NUMCLIENTE" NUMBER
   ) ;
--------------------------------------------------------
--  DDL for Table FACTURAS_CLIENTES
--------------------------------------------------------

  CREATE TABLE "FACTURAS_CLIENTES" 
   (	"IDFACTURA" NUMBER, 
	"NUMFACTURA" NUMBER, 
	"FECHA" NUMBER, 
	"HORA" NUMBER, 
	"REFCLIENTE" NUMBER, 
	"REFUSUARIO" NUMBER, 
	"IMPORTENETO" NUMBER, 
	"IMPORTETOTAL" NUMBER, 
	"CONTABILIZADA" NUMBER
   ) ;
--------------------------------------------------------
--  DDL for Table FACTURAS_CLIENTES_DETALLES
--------------------------------------------------------

  CREATE TABLE "FACTURAS_CLIENTES_DETALLES" 
   (	"ID" NUMBER, 
	"REFFACTURA" NUMBER, 
	"CONCEPTO" NUMBER, 
	"CANTIDAD" NUMBER, 
	"IMPORTENETOUNITARIO" NUMBER, 
	"IMPORTENETOTOTAL" VARCHAR2(20)
   ) ;
--------------------------------------------------------
--  DDL for Table FORMASDEPAGO
--------------------------------------------------------

  CREATE TABLE "FORMASDEPAGO" 
   (	"IDFORMAPAGO" NUMBER, 
	"FORMAPAGO" VARCHAR2(100), 
	"ACTIVO" NUMBER, 
	"DESCRIPCION" VARCHAR2(100)
   ) ;
--------------------------------------------------------
--  DDL for Table PEDIDOS_CLIENTES
--------------------------------------------------------

  CREATE TABLE "PEDIDOS_CLIENTES" 
   (	"IDPEDIDO" NUMBER, 
	"REFCLIENTE" NUMBER, 
	"REFUSUARIO" NUMBER, 
	"FECHA" NUMBER, 
	"REFFORMAPAGO" NUMBER, 
	"TOTAL" FLOAT(126), 
	"PAGADO" FLOAT(126), 
	"ELIMINADO" NUMBER, 
	"NUMPEDIDO" NUMBER, 
	"HORAPEDIDO" NUMBER, 
	"FECHAENTREGA" NUMBER, 
	"REFESTADO" NUMBER
   ) ;
--------------------------------------------------------
--  DDL for Table PEDIDOS_CLIENTES_ARTICULOS
--------------------------------------------------------

  CREATE TABLE "PEDIDOS_CLIENTES_ARTICULOS" 
   (	"IDPEDIDOSARTICULOS" NUMBER, 
	"REFPEDIDO" NUMBER, 
	"REFARTICULO" NUMBER, 
	"CANTIDAD_OBTENIDA" NUMBER, 
	"PRECIOVENTA" FLOAT(126), 
	"CANTIDAD_ESPERADA" NUMBER
   ) ;
--------------------------------------------------------
--  DDL for Table PEDIDOS_ESTADOS
--------------------------------------------------------

  CREATE TABLE "PEDIDOS_ESTADOS" 
   (	"IDESTADO" NUMBER, 
	"DESCRIPCION" VARCHAR2(20)
   ) ;
--------------------------------------------------------
--  DDL for Table PEDIDOS_PROVEEDORES
--------------------------------------------------------

  CREATE TABLE "PEDIDOS_PROVEEDORES" 
   (	"IDPEDIDO" NUMBER, 
	"REFPROVEEDOR" NUMBER, 
	"REFUSUARIO" NUMBER, 
	"FECHA" NUMBER, 
	"HORA" NUMBER, 
	"REFFORMAPAGO" NUMBER, 
	"TOTAL" FLOAT(126), 
	"PAGADO" FLOAT(126), 
	"COTEJADO" NUMBER, 
	"ELIMINADO" NUMBER, 
	"NUMPEDIDO" NUMBER
   ) ;
--------------------------------------------------------
--  DDL for Table PEDIDOS_PROVEEDORES_ARTICULOS
--------------------------------------------------------

  CREATE TABLE "PEDIDOS_PROVEEDORES_ARTICULOS" 
   (	"IDPEDIDOSARTICULOS" NUMBER, 
	"REFPEDIDO" NUMBER, 
	"REFARTICULO" NUMBER, 
	"CANTIDAD_ESPERADA" NUMBER, 
	"CANTIDAD_OBTENIDA" NUMBER, 
	"PRECIOVENTA" FLOAT(126)
   ) ;
--------------------------------------------------------
--  DDL for Table PROVEEDORES
--------------------------------------------------------

  CREATE TABLE "PROVEEDORES" 
   (	"ID" NUMBER, 
	"CIFNIF" VARCHAR2(20), 
	"NOMBRE" VARCHAR2(50), 
	"DIRECCION" VARCHAR2(100), 
	"CP" NUMBER, 
	"TELEFONO" NUMBER, 
	"ELIMINADO" NUMBER
   ) ;
--------------------------------------------------------
--  DDL for Table RELACIONARTICULOS
--------------------------------------------------------

  CREATE TABLE "RELACIONARTICULOS" 
   (	"ID" NUMBER, 
	"REFARTICULO" NUMBER, 
	"REFPROVEEDOR" NUMBER, 
	"ELIMINADO" NUMBER, 
	"NOMBREPROV" VARCHAR2(50), 
	"PRECIOPROV" FLOAT(126)
   ) ;
--------------------------------------------------------
--  DDL for Table RELACION_FACTURAS_PEDCLIENTES
--------------------------------------------------------

  CREATE TABLE "RELACION_FACTURAS_PEDCLIENTES" 
   (	"ID" NUMBER, 
	"REFPEDIDO" NUMBER, 
	"REFFACTURA" NUMBER
   ) ;
--------------------------------------------------------
--  DDL for Table TIPOS
--------------------------------------------------------

  CREATE TABLE "TIPOS" 
   (	"IDTIPO" NUMBER, 
	"NOMBRE" VARCHAR2(20), 
	"ELIMINADO" NUMBER
   ) ;
--------------------------------------------------------
--  DDL for Table USUARIOS
--------------------------------------------------------

  CREATE TABLE "USUARIOS" 
   (	"IDUSUARIO" NUMBER, 
	"NOMBRE" VARCHAR2(30), 
	"PASSWORD" VARCHAR2(32), 
	"ELIMINADO" NUMBER
   ) ;
   
   
   --------------------------------------------------------
--  File created - martes-enero-28-2014   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Sequence IDARTICSEQ
--------------------------------------------------------

   CREATE SEQUENCE  "IDARTICSEQ"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 NOCACHE  NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence IDCAJAAPUNTESSEQ
--------------------------------------------------------

   CREATE SEQUENCE  "IDCAJAAPUNTESSEQ"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 NOCACHE  NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence IDCAJACOBRODEUDASSEQ
--------------------------------------------------------

   CREATE SEQUENCE  "IDCAJACOBRODEUDASSEQ"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 NOCACHE  NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence IDCAMBIOSSEQ
--------------------------------------------------------

   CREATE SEQUENCE  "IDCAMBIOSSEQ"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 NOCACHE  NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence IDCLIENTESSEQ
--------------------------------------------------------

   CREATE SEQUENCE  "IDCLIENTESSEQ"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 NOCACHE  NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence IDFPAGOSSEQ
--------------------------------------------------------

   CREATE SEQUENCE  "IDFPAGOSSEQ"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 NOCACHE  NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence IDPEDARTICSEQ
--------------------------------------------------------

   CREATE SEQUENCE  "IDPEDARTICSEQ"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 NOCACHE  NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence IDPEDIDOSSEQ
--------------------------------------------------------

   CREATE SEQUENCE  "IDPEDIDOSSEQ"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 NOCACHE  NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence IDTIPOSSEQ
--------------------------------------------------------

   CREATE SEQUENCE  "IDTIPOSSEQ"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 NOCACHE  NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence IDUSUARIOSSEQ
--------------------------------------------------------

   CREATE SEQUENCE  "IDUSUARIOSSEQ"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 NOCACHE  NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Trigger AUTOIDARTIC
--------------------------------------------------------

  CREATE OR REPLACE TRIGGER "AUTOIDARTIC" 
Before Insert on articulos 
for each row 
declare 
valor number; 
begin 
If INSERTING then 
SELECT IDARTICSEQ.NEXTVAL INTO valor FROM DUAL; 
:NEW.idarticulo := valor; 
end if; 
end;
/
ALTER TRIGGER "AUTOIDARTIC" ENABLE;
--------------------------------------------------------
--  DDL for Trigger AUTOIDCAJAAPUNTESSEQ
--------------------------------------------------------

  CREATE OR REPLACE TRIGGER "AUTOIDCAJAAPUNTESSEQ" 
Before Insert on caja_apuntes 
for each row 
declare 
valor number; 
begin 
If INSERTING then 
SELECT IDCAJAAPUNTESSEQ.NEXTVAL INTO valor FROM DUAL; 
:NEW.id := valor; 
end if;  
END;
/
ALTER TRIGGER "AUTOIDCAJAAPUNTESSEQ" ENABLE;
--------------------------------------------------------
--  DDL for Trigger AUTOIDCAJACOBRODEUDAS
--------------------------------------------------------

  CREATE OR REPLACE TRIGGER "AUTOIDCAJACOBRODEUDAS" 
Before Insert on caja_cobrodeudas 
for each row 
declare 
valor number; 
begin 
If INSERTING then 
SELECT IDCAJACOBRODEUDASSEQ.NEXTVAL INTO valor FROM DUAL; 
:NEW.id := valor; 
end if;  
END;
/
ALTER TRIGGER "AUTOIDCAJACOBRODEUDAS" ENABLE;
--------------------------------------------------------
--  DDL for Trigger AUTOIDCAMBIOS
--------------------------------------------------------

  CREATE OR REPLACE TRIGGER "AUTOIDCAMBIOS" 
Before Insert on cambios 
for each row 
declare 
valor number; 
begin 
If INSERTING  then 
 SELECT IDCAMBIOSSEQ.NEXTVAL INTO valor FROM DUAL; 
--      :NEW.idcambio := IDCAMBIOSSEQ.NEXTVAL;
:NEW.idcambio := valor; 
end if; 
end;
/
ALTER TRIGGER "AUTOIDCAMBIOS" ENABLE;
--------------------------------------------------------
--  DDL for Trigger AUTOIDCLIENTES
--------------------------------------------------------

  CREATE OR REPLACE TRIGGER "AUTOIDCLIENTES" 
Before Insert on clientes 
for each row 
declare 
valor number; 
begin 
If INSERTING then 
SELECT IDCLIENTESSEQ.NEXTVAL INTO valor FROM DUAL; 
:NEW.idcliente := valor; 
end if; 
end;
/
ALTER TRIGGER "AUTOIDCLIENTES" ENABLE;
--------------------------------------------------------
--  DDL for Trigger AUTOIDFPAGOS
--------------------------------------------------------

  CREATE OR REPLACE TRIGGER "AUTOIDFPAGOS" 
Before Insert on formasdepago 
for each row 
declare 
valor number; 
begin 
If INSERTING then 
SELECT IDFPAGOSSEQ.NEXTVAL INTO valor FROM DUAL; 
:NEW.idformapago := valor; 
end if;  
end;
/
ALTER TRIGGER "AUTOIDFPAGOS" ENABLE;
--------------------------------------------------------
--  DDL for Trigger AUTOIDPEDARTIC
--------------------------------------------------------

  CREATE OR REPLACE TRIGGER "AUTOIDPEDARTIC" 
Before Insert on PEDIDOS_CLIENTES_ARTICULOS 
for each row 
declare 
valor number; 
begin 
If INSERTING then 
SELECT IDPEDARTICSEQ.NEXTVAL INTO valor FROM DUAL; 
:NEW.idpedidosarticulos := valor; 
end if; 
end;
/
ALTER TRIGGER "AUTOIDPEDARTIC" ENABLE;
--------------------------------------------------------
--  DDL for Trigger AUTOIDPEDIDOS
--------------------------------------------------------

  CREATE OR REPLACE TRIGGER "AUTOIDPEDIDOS" 
Before Insert on PEDIDOS_CLIENTES 
for each row 
declare 
valor number; 
begin 
If INSERTING then 
SELECT IDPEDIDOSSEQ.NEXTVAL INTO valor FROM DUAL; 
:NEW.idpedido := valor; 
end if; 
end;
/
ALTER TRIGGER "AUTOIDPEDIDOS" ENABLE;
--------------------------------------------------------
--  DDL for Trigger AUTOIDTIPOS
--------------------------------------------------------

  CREATE OR REPLACE TRIGGER "AUTOIDTIPOS" 
Before Insert on tipos
for each row 
declare 
valor number; 
begin 
If INSERTING then 
SELECT IDTIPOSSEQ.NEXTVAL INTO valor FROM DUAL; 
:NEW.idtipo := valor; 
end if; 
end;
/
ALTER TRIGGER "AUTOIDTIPOS" ENABLE;
--------------------------------------------------------
--  DDL for Trigger AUTOIDUSUARIOS
--------------------------------------------------------

  CREATE OR REPLACE TRIGGER "AUTOIDUSUARIOS" 
Before Insert on usuarios 
for each row 
declare 
valor number; 
begin 
If INSERTING then 
SELECT IDUSUARIOSSEQ.NEXTVAL INTO valor FROM DUAL; 
:NEW.idusuario := valor; 
end if;  
END;
/
ALTER TRIGGER "AUTOIDUSUARIOS" ENABLE;


---------------------------------------------------
--   DATA FOR TABLE PROVEEDORES
--   FILTER = none used
---------------------------------------------------
REM INSERTING into PROVEEDORES
Insert into PROVEEDORES (ID,CIFNIF,NOMBRE,DIRECCION,CP,TELEFONO,ELIMINADO) values (3,'24598835J','Zavvi','Via digital 4',8555,917788332,0);
Insert into PROVEEDORES (ID,CIFNIF,NOMBRE,DIRECCION,CP,TELEFONO,ELIMINADO) values (4,'53579547N','carers','Calle Ciruela',2228,123456789,0);
Insert into PROVEEDORES (ID,CIFNIF,NOMBRE,DIRECCION,CP,TELEFONO,ELIMINADO) values (1,'14149929F','Game SA','Centro Comercial Eroski',2209,926112233,0);
Insert into PROVEEDORES (ID,CIFNIF,NOMBRE,DIRECCION,CP,TELEFONO,ELIMINADO) values (2,'59194388R','Amazon','Matrix distrito maquina 15',7525,11122332,0);

---------------------------------------------------
--   END DATA FOR TABLE PROVEEDORES
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE CAJA_TIPOSPAGO
--   FILTER = none used
---------------------------------------------------
REM INSERTING into CAJA_TIPOSPAGO
Insert into CAJA_TIPOSPAGO (ID,DESCRIPCION) values (1,'Efectivo');
Insert into CAJA_TIPOSPAGO (ID,DESCRIPCION) values (2,'Cheque');
Insert into CAJA_TIPOSPAGO (ID,DESCRIPCION) values (3,'Recibo');

---------------------------------------------------
--   END DATA FOR TABLE CAJA_TIPOSPAGO
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE RELACION_FACTURAS_PEDCLIENTES
--   FILTER = none used
---------------------------------------------------
REM INSERTING into RELACION_FACTURAS_PEDCLIENTES

---------------------------------------------------
--   END DATA FOR TABLE RELACION_FACTURAS_PEDCLIENTES
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE PEDIDOS_CLIENTES_ARTICULOS
--   FILTER = none used
---------------------------------------------------
REM INSERTING into PEDIDOS_CLIENTES_ARTICULOS

---------------------------------------------------
--   END DATA FOR TABLE PEDIDOS_CLIENTES_ARTICULOS
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE TIPOS
--   FILTER = none used
---------------------------------------------------
REM INSERTING into TIPOS
Insert into TIPOS (IDTIPO,NOMBRE,ELIMINADO) values (1,'RPG japones',0);
Insert into TIPOS (IDTIPO,NOMBRE,ELIMINADO) values (2,'RPG europeo',0);
Insert into TIPOS (IDTIPO,NOMBRE,ELIMINADO) values (3,'Deportes',0);
Insert into TIPOS (IDTIPO,NOMBRE,ELIMINADO) values (4,'Shooter puro',0);

---------------------------------------------------
--   END DATA FOR TABLE TIPOS
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE FORMASDEPAGO
--   FILTER = none used
---------------------------------------------------
REM INSERTING into FORMASDEPAGO
Insert into FORMASDEPAGO (IDFORMAPAGO,FORMAPAGO,ACTIVO,DESCRIPCION) values (1,'TARJETA',0,'4B, Master Card, Visa');
Insert into FORMASDEPAGO (IDFORMAPAGO,FORMAPAGO,ACTIVO,DESCRIPCION) values (2,'METALICO',0,'In Situ en la empresa');
Insert into FORMASDEPAGO (IDFORMAPAGO,FORMAPAGO,ACTIVO,DESCRIPCION) values (3,'PAYPAL',0,'Validar via consultoria');
Insert into FORMASDEPAGO (IDFORMAPAGO,FORMAPAGO,ACTIVO,DESCRIPCION) values (4,'TRANFERENCIA BANCARIA',0,'Excluidos paraisos fiscales');
Insert into FORMASDEPAGO (IDFORMAPAGO,FORMAPAGO,ACTIVO,DESCRIPCION) values (5,'CONTRARREMBOLSO',0,'Pago al repartidor de la agencia de transportes');

---------------------------------------------------
--   END DATA FOR TABLE FORMASDEPAGO
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE RELACIONARTICULOS
--   FILTER = none used
---------------------------------------------------
REM INSERTING into RELACIONARTICULOS
Insert into RELACIONARTICULOS (ID,REFARTICULO,REFPROVEEDOR,ELIMINADO,NOMBREPROV,PRECIOPROV) values (1,5,1,0,'Fifa',50);

---------------------------------------------------
--   END DATA FOR TABLE RELACIONARTICULOS
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE USUARIOS
--   FILTER = none used
---------------------------------------------------
REM INSERTING into USUARIOS
Insert into USUARIOS (IDUSUARIO,NOMBRE,PASSWORD,ELIMINADO) values (1,'admin00','by2vOfvlXFfxdDqy9XE8ALBJi62ms2Qw',0);
Insert into USUARIOS (IDUSUARIO,NOMBRE,PASSWORD,ELIMINADO) values (2,'sergio00','hzoRYrF/vUTruXHMSebnKe6aHsI1O8kO',0);

---------------------------------------------------
--   END DATA FOR TABLE USUARIOS
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE CAJA_PROCEDENCIADESTINO
--   FILTER = none used
---------------------------------------------------
REM INSERTING into CAJA_PROCEDENCIADESTINO
Insert into CAJA_PROCEDENCIADESTINO (ID,DESCRIPCION,TIPO) values (1,'Venta de productos',0);
Insert into CAJA_PROCEDENCIADESTINO (ID,DESCRIPCION,TIPO) values (2,'Ingreso directo de administración',0);
Insert into CAJA_PROCEDENCIADESTINO (ID,DESCRIPCION,TIPO) values (3,'Variación de saldo',0);
Insert into CAJA_PROCEDENCIADESTINO (ID,DESCRIPCION,TIPO) values (4,'Varios',0);
Insert into CAJA_PROCEDENCIADESTINO (ID,DESCRIPCION,TIPO) values (5,'Gastos de personal',1);
Insert into CAJA_PROCEDENCIADESTINO (ID,DESCRIPCION,TIPO) values (6,'Compra de materias primas',1);
Insert into CAJA_PROCEDENCIADESTINO (ID,DESCRIPCION,TIPO) values (7,'Retirada de dinero de administración',1);
Insert into CAJA_PROCEDENCIADESTINO (ID,DESCRIPCION,TIPO) values (8,'Variación de saldo',1);
Insert into CAJA_PROCEDENCIADESTINO (ID,DESCRIPCION,TIPO) values (9,'Varios',1);
Insert into CAJA_PROCEDENCIADESTINO (ID,DESCRIPCION,TIPO) values (10,'Agencia',2);
Insert into CAJA_PROCEDENCIADESTINO (ID,DESCRIPCION,TIPO) values (11,'Varios',2);

---------------------------------------------------
--   END DATA FOR TABLE CAJA_PROCEDENCIADESTINO
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE CAJA_APUNTES
--   FILTER = none used
---------------------------------------------------
REM INSERTING into CAJA_APUNTES
Insert into CAJA_APUNTES (ID,TIPOAPUNTE,PROCED_DESTINO,TIPO_PAGO,CONCEPTO,IMPORTE,FECHA,HORA,USUARIO) values (1,'E',1,3,'Ingreso inicial','150,89',20140123,173730,1);
Insert into CAJA_APUNTES (ID,TIPOAPUNTE,PROCED_DESTINO,TIPO_PAGO,CONCEPTO,IMPORTE,FECHA,HORA,USUARIO) values (2,'S',7,3,'Primera salida de dinero','80,23',20140123,173750,1);

---------------------------------------------------
--   END DATA FOR TABLE CAJA_APUNTES
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE PEDIDOS_PROVEEDORES
--   FILTER = none used
---------------------------------------------------
REM INSERTING into PEDIDOS_PROVEEDORES

---------------------------------------------------
--   END DATA FOR TABLE PEDIDOS_PROVEEDORES
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE FACTURAS_CLIENTES
--   FILTER = none used
---------------------------------------------------
REM INSERTING into FACTURAS_CLIENTES

---------------------------------------------------
--   END DATA FOR TABLE FACTURAS_CLIENTES
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE FACTURAS_CLIENTES_DETALLES
--   FILTER = none used
---------------------------------------------------
REM INSERTING into FACTURAS_CLIENTES_DETALLES

---------------------------------------------------
--   END DATA FOR TABLE FACTURAS_CLIENTES_DETALLES
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE CAMBIOS
--   FILTER = none used
---------------------------------------------------
REM INSERTING into CAMBIOS
Insert into CAMBIOS (IDCAMBIO,NUMCAMBIO,REFUSUARIO,FECHA,HORA,DESCRIPCION,TIPO) values (1,1000,1,20140123,174826,'Inicio de sesión','0');
Insert into CAMBIOS (IDCAMBIO,NUMCAMBIO,REFUSUARIO,FECHA,HORA,DESCRIPCION,TIPO) values (2,1001,1,20140123,174835,'Copia de seguridad parcial creada de la tabla CAMBIOS creada','0');
Insert into CAMBIOS (IDCAMBIO,NUMCAMBIO,REFUSUARIO,FECHA,HORA,DESCRIPCION,TIPO) values (3,1002,1,20140123,174854,'Cierre de sesión','0');
Insert into CAMBIOS (IDCAMBIO,NUMCAMBIO,REFUSUARIO,FECHA,HORA,DESCRIPCION,TIPO) values (4,1003,1,20140127,214733,'Inicio de sesión','0');
Insert into CAMBIOS (IDCAMBIO,NUMCAMBIO,REFUSUARIO,FECHA,HORA,DESCRIPCION,TIPO) values (5,1004,1,20140127,220023,'creación de deuda 3','0');
Insert into CAMBIOS (IDCAMBIO,NUMCAMBIO,REFUSUARIO,FECHA,HORA,DESCRIPCION,TIPO) values (6,1005,1,20140127,222028,'Cierre de sesión','0');

---------------------------------------------------
--   END DATA FOR TABLE CAMBIOS
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE PEDIDOS_PROVEEDORES_ARTICULOS
--   FILTER = none used
---------------------------------------------------
REM INSERTING into PEDIDOS_PROVEEDORES_ARTICULOS

---------------------------------------------------
--   END DATA FOR TABLE PEDIDOS_PROVEEDORES_ARTICULOS
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE CAJA_COBRODEUDAS
--   FILTER = none used
---------------------------------------------------
REM INSERTING into CAJA_COBRODEUDAS
Insert into CAJA_COBRODEUDAS (ID,PROCEDENCIA,CONCEPTO,IMPORTE,FECHA,HORA,TIPO,USUARIO,ELIMINADO) values (1,11,'DINERO QUE NOS DEBE ROSA MAESTRE','40,91',20140123,173816,1,1,0);
Insert into CAJA_COBRODEUDAS (ID,PROCEDENCIA,CONCEPTO,IMPORTE,FECHA,HORA,TIPO,USUARIO,ELIMINADO) values (2,1,'DINERO QUE LE DEBEMOS A ISABEL GUERRERO','0,21',20140123,173839,0,1,0);
Insert into CAJA_COBRODEUDAS (ID,PROCEDENCIA,CONCEPTO,IMPORTE,FECHA,HORA,TIPO,USUARIO,ELIMINADO) values (3,1,'PRUEBA PARA VER TIPO SALIDA CUANDO PASE LA DEUDA A SALIDA','100',20140127,220004,0,1,0);

---------------------------------------------------
--   END DATA FOR TABLE CAJA_COBRODEUDAS
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE ARTICULOS
--   FILTER = none used
---------------------------------------------------
REM INSERTING into ARTICULOS
Insert into ARTICULOS (IDARTICULO,NOMBRE,REFTIPO,PRECIO,ELIMINADO,NUMARTICULO,STOCK) values (1,'GTAV',4,25,0,1005,0);
Insert into ARTICULOS (IDARTICULO,NOMBRE,REFTIPO,PRECIO,ELIMINADO,NUMARTICULO,STOCK) values (2,'nuevo','1',1,0,1006,1);
Insert into ARTICULOS (IDARTICULO,NOMBRE,REFTIPO,PRECIO,ELIMINADO,NUMARTICULO,STOCK) values (3,'Tour de Francia',3,45,0,1002,10);
Insert into ARTICULOS (IDARTICULO,NOMBRE,REFTIPO,PRECIO,ELIMINADO,NUMARTICULO,STOCK) values (4,'Far Cry 3 plus',4,67,0,1003,45);
Insert into ARTICULOS (IDARTICULO,NOMBRE,REFTIPO,PRECIO,ELIMINADO,NUMARTICULO,STOCK) values (5,'Fifa 2014 plus',3,'67,28',0,1000,37);
Insert into ARTICULOS (IDARTICULO,NOMBRE,REFTIPO,PRECIO,ELIMINADO,NUMARTICULO,STOCK) values (6,'Tour de Francia edicion verano',3,'23,34',0,1001,14);
Insert into ARTICULOS (IDARTICULO,NOMBRE,REFTIPO,PRECIO,ELIMINADO,NUMARTICULO,STOCK) values (7,'Dragon Age edi limitada',2,46,0,1004,25);

---------------------------------------------------
--   END DATA FOR TABLE ARTICULOS
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE CLIENTES
--   FILTER = none used
---------------------------------------------------
REM INSERTING into CLIENTES
Insert into CLIENTES (IDCLIENTE,NOMBRE,APELLIDO1,APELLIDO2,DIRECCION,REFCPPOBLACIONES,TELEFONO,MAIL,ELIMINADO,NUMCLIENTE) values (1,'Victor','Roldan','Roldan','calle de victor 1',154,916768594,'victor@indie.com',0,1000);
Insert into CLIENTES (IDCLIENTE,NOMBRE,APELLIDO1,APELLIDO2,DIRECCION,REFCPPOBLACIONES,TELEFONO,MAIL,ELIMINADO,NUMCLIENTE) values (2,'Charlie','Lopez','Nieto','Avenida Churriega SN',2228,926778822,'charlie@ps3.com',0,1001);
Insert into CLIENTES (IDCLIENTE,NOMBRE,APELLIDO1,APELLIDO2,DIRECCION,REFCPPOBLACIONES,TELEFONO,MAIL,ELIMINADO,NUMCLIENTE) values (3,'Daniel','de las Dos Torres','Ibiza','Calle Mordor 4',984,976334455,'daniibiza@manolito.com',0,1002);
Insert into CLIENTES (IDCLIENTE,NOMBRE,APELLIDO1,APELLIDO2,DIRECCION,REFCPPOBLACIONES,TELEFONO,MAIL,ELIMINADO,NUMCLIENTE) values (4,'Juan','Soria','Pozuello','Avenida Carlos I, 15.',922,921112233,'juan@soria.com',0,1003);

---------------------------------------------------
--   END DATA FOR TABLE CLIENTES
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE PEDIDOS_CLIENTES
--   FILTER = none used
---------------------------------------------------
REM INSERTING into PEDIDOS_CLIENTES

---------------------------------------------------
--   END DATA FOR TABLE PEDIDOS_CLIENTES
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE PEDIDOS_ESTADOS
--   FILTER = none used
---------------------------------------------------
REM INSERTING into PEDIDOS_ESTADOS
Insert into PEDIDOS_ESTADOS (IDESTADO,DESCRIPCION) values (1,'SIN CONFIRMAR');
Insert into PEDIDOS_ESTADOS (IDESTADO,DESCRIPCION) values (2,'CONFIRMADO');
Insert into PEDIDOS_ESTADOS (IDESTADO,DESCRIPCION) values (3,'ETIQUETADO');
Insert into PEDIDOS_ESTADOS (IDESTADO,DESCRIPCION) values (4,'ENVIADO');
Insert into PEDIDOS_ESTADOS (IDESTADO,DESCRIPCION) values (5,'FACTURADO');

---------------------------------------------------
--   END DATA FOR TABLE PEDIDOS_ESTADOS
---------------------------------------------------

COMMIT;
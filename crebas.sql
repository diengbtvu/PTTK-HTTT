/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2008                    */
/* Created on:     16/11/2024 8:32:54 AM                        */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('NHANKHAU') and o.name = 'FK_NHANKHAU_THANHVIEN_SOHOKHAU')
alter table NHANKHAU
   drop constraint FK_NHANKHAU_THANHVIEN_SOHOKHAU
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PHUONGXA') and o.name = 'FK_PHUONGXA_CO_QUANHUYE')
alter table PHUONGXA
   drop constraint FK_PHUONGXA_CO_QUANHUYE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SOHOKHAU') and o.name = 'FK_SOHOKHAU_BAOGOM_QUANHUYE')
alter table SOHOKHAU
   drop constraint FK_SOHOKHAU_BAOGOM_QUANHUYE
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('NHANKHAU')
            and   name  = 'THANHVIEN_FK'
            and   indid > 0
            and   indid < 255)
   drop index NHANKHAU.THANHVIEN_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('NHANKHAU')
            and   type = 'U')
   drop table NHANKHAU
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PHUONGXA')
            and   name  = 'CO_FK'
            and   indid > 0
            and   indid < 255)
   drop index PHUONGXA.CO_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PHUONGXA')
            and   type = 'U')
   drop table PHUONGXA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('QUANHUYEN')
            and   type = 'U')
   drop table QUANHUYEN
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('SOHOKHAU')
            and   name  = 'BAOGOM_FK'
            and   indid > 0
            and   indid < 255)
   drop index SOHOKHAU.BAOGOM_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('SOHOKHAU')
            and   type = 'U')
   drop table SOHOKHAU
go

/*==============================================================*/
/* Table: NHANKHAU                                              */
/*==============================================================*/
create table NHANKHAU (
   HOTEN                char(100)            null,
   GIOITINH             bit                  null,
   NGAYSINH             datetime             null,
   MADINHDANH           int                  not null,
   SOSO                 int                  not null,
   constraint PK_NHANKHAU primary key nonclustered (MADINHDANH)
)
go

/*==============================================================*/
/* Index: THANHVIEN_FK                                          */
/*==============================================================*/
create index THANHVIEN_FK on NHANKHAU (
SOSO ASC
)
go

/*==============================================================*/
/* Table: PHUONGXA                                              */
/*==============================================================*/
create table PHUONGXA (
   MAPX                 int                  not null,
   MAQH                 int                  not null,
   TENPX                char(100)            null,
   constraint PK_PHUONGXA primary key nonclustered (MAPX)
)
go

/*==============================================================*/
/* Index: CO_FK                                                 */
/*==============================================================*/
create index CO_FK on PHUONGXA (
MAQH ASC
)
go

/*==============================================================*/
/* Table: QUANHUYEN                                             */
/*==============================================================*/
create table QUANHUYEN (
   MAQH                 int                  not null,
   TENQH                char(50)             null,
   constraint PK_QUANHUYEN primary key nonclustered (MAQH)
)
go

/*==============================================================*/
/* Table: SOHOKHAU                                              */
/*==============================================================*/
create table SOHOKHAU (
   SOSO                 int                  not null,
   MAQH                 int                  not null,
   HOTENCHUHO           char(100)            null,
   SONHA                int                  null,
   TENDUONG             char(100)            null,
   KHUPHO_AP            char(100)            null,
   constraint PK_SOHOKHAU primary key nonclustered (SOSO)
)
go

/*==============================================================*/
/* Index: BAOGOM_FK                                             */
/*==============================================================*/
create index BAOGOM_FK on SOHOKHAU (
MAQH ASC
)
go

alter table NHANKHAU
   add constraint FK_NHANKHAU_THANHVIEN_SOHOKHAU foreign key (SOSO)
      references SOHOKHAU (SOSO)
go

alter table PHUONGXA
   add constraint FK_PHUONGXA_CO_QUANHUYE foreign key (MAQH)
      references QUANHUYEN (MAQH)
go

alter table SOHOKHAU
   add constraint FK_SOHOKHAU_BAOGOM_QUANHUYE foreign key (MAQH)
      references QUANHUYEN (MAQH)
go


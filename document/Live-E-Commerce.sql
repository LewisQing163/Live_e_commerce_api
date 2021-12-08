/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2012                    */
/* Created on:     2021/12/8 15:49:40                           */
/*==============================================================*/


if exists (select 1
            from  sysobjects
           where  id = object_id('Balance')
            and   type = 'U')
   drop table Balance
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Consumption')
            and   type = 'U')
   drop table Consumption
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Member')
            and   type = 'U')
   drop table Member
go

if exists (select 1
            from  sysobjects
           where  id = object_id('"User"')
            and   type = 'U')
   drop table "User"
go

if exists (select 1
            from  sysobjects
           where  id = object_id('User_Base')
            and   type = 'U')
   drop table User_Base
go

if exists (select 1
            from  sysobjects
           where  id = object_id('User_Extra')
            and   type = 'U')
   drop table User_Extra
go

if exists (select 1
            from  sysobjects
           where  id = object_id('User_Info_Update')
            and   type = 'U')
   drop table User_Info_Update
go

if exists (select 1
            from  sysobjects
           where  id = object_id('User_Location')
            and   type = 'U')
   drop table User_Location
go

if exists (select 1
            from  sysobjects
           where  id = object_id('User_Login_Log')
            and   type = 'U')
   drop table User_Login_Log
go

if exists (select 1
            from  sysobjects
           where  id = object_id('User_Register_Log')
            and   type = 'U')
   drop table User_Register_Log
go

/*==============================================================*/
/* Table: Balance                                               */
/*==============================================================*/
create table Balance (
   Id                   uniqueidentifier     not null,
   Balance              int                  null,
   Uid                  uniqueidentifier     null,
   constraint PK_BALANCE primary key (Id)
)
go

/*==============================================================*/
/* Table: Consumption                                           */
/*==============================================================*/
create table Consumption (
   Id                   uniqueidentifier     not null,
   Product_Name         nvarchar(20)         null,
   Product_Price        int                  null,
   Bid                  uniqueidentifier     null,
   constraint PK_CONSUMPTION primary key (Id)
)
go

/*==============================================================*/
/* Table: Member                                                */
/*==============================================================*/
create table Member (
   Id                   uniqueidentifier     not null,
   MemberName           nvarchar(20)         not null,
   Uid                  uniqueidentifier     not null,
   constraint PK_MEMBER primary key (Id)
)
go

/*==============================================================*/
/* Table: "User"                                                */
/*==============================================================*/
create table "User" (
   Id                   uniqueidentifier     not null,
   Name                 nvarchar(50)         null,
   PassWord             nvarchar(50)         null,
   LoginTime            datetime             null,
   constraint PK_USER primary key (Id)
)
go

/*==============================================================*/
/* Table: User_Base                                             */
/*==============================================================*/
create table User_Base (
   Id                   uniqueidentifier     not null,
   UserName             nvarchar(30)         not null,
   Age                  int                  null,
   Sex                  int                  null,
   Hobby                varchar(50)          null,
   Mail                 varchar(20)          null,
   Phone                varchar(20)          not null,
   Avatar               nvarchar(100)        null,
   NikeName             nvarchar(20)         null,
   Sign                 nvarchar(50)         null,
   Birthday             date                 null,
   constraint PK_USER_BASE primary key (Id)
)
go

/*==============================================================*/
/* Table: User_Extra                                            */
/*==============================================================*/
create table User_Extra (
   Id                   uniqueidentifier     not null,
   Uid                  uniqueidentifier     null,
   CreateTime           datetime             null,
   UpdateTime           datetime             null,
   Extend1              nvarchar(50)         null,
   Extend2              nvarchar(50)         null,
   constraint PK_USER_EXTRA primary key (Id)
)
go

/*==============================================================*/
/* Table: User_Info_Update                                      */
/*==============================================================*/
create table User_Info_Update (
   Id                   uniqueidentifier     not null,
   Attribute_Old_Val    nvarchar(20)         null,
   Attribute_New_Val    nvarchar(50)         null,
   Update_Time          datetime             null,
   Uid                  uniqueidentifier     null,
   constraint PK_USER_INFO_UPDATE primary key (Id)
)
go

/*==============================================================*/
/* Table: User_Location                                         */
/*==============================================================*/
create table User_Location (
   Id                   uniqueidentifier     not null,
   Uid                  uniqueidentifier     null,
   Curr_Nation          nvarchar(20)         null,
   Curr_Province        nvarchar(20)         null,
   Curr_City            nvarchar(50)         null,
   Curr_District        nvarchar(50)         null,
   Location             nvarchar(255)        null,
   Create_Time          datetime             null,
   constraint PK_USER_LOCATION primary key (Id)
)
go

/*==============================================================*/
/* Table: User_Login_Log                                        */
/*==============================================================*/
create table User_Login_Log (
   Id                   uniqueidentifier     not null,
   Command              int                  null,
   Create_Time          datetime             null,
   Lid                  uniqueidentifier     null,
   constraint PK_USER_LOGIN_LOG primary key (Id)
)
go

/*==============================================================*/
/* Table: User_Register_Log                                     */
/*==============================================================*/
create table User_Register_Log (
   Id                   uniqueidentifier     not null,
   Uid                  uniqueidentifier     null,
   Register_Method      nvarchar(20)         null,
   Register_Time        datetime             null,
   constraint PK_USER_REGISTER_LOG primary key (Id)
)
go


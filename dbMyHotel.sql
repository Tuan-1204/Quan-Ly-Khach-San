use dbMyHotel

create table rooms (
roomid int identity(1,1) primary key,
roomNo varchar(250) not null,
roomType varchar(250) not null,
bed varchar(250) not null,
price decimal(10, 2) not null,
booked varchar(50) default('No') null
);

go
create table customer(
    cid int identity(1,1) primary key,
    cname varchar(250) not null,
    mobile bigint not null,
    nationality VARCHAR (250) NOT NULL,
    gender VARCHAR (50) NOT NULL,
    dob DATE NOT NULL, 
    idproof VARCHAR (250) NOT NULL,
    address VARCHAR (350) NOT NULL,
    checkin DATETIME NOT NULL,
    checkout DATETIME, 
    checkedout VARCHAR (50) DEFAULT ('NO'), 
    roomid INT NOT NULL,
    FOREIGN KEY (roomid) REFERENCES rooms(roomid) 
);

go
CREATE TABLE [dbo].[employee] (
    [eid]      INT           IDENTITY (1, 1) NOT NULL,
    [ename]    VARCHAR (250) NOT NULL,
    [mobile]   BIGINT        NOT NULL,
    [gender]   VARCHAR (50)  NOT NULL,
    [emailid]  VARCHAR (120) NOT NULL,
    [username] VARCHAR (150) NOT NULL,
    [pass]     VARCHAR (150) NOT NULL,
    PRIMARY KEY CLUSTERED ([eid] ASC)
);
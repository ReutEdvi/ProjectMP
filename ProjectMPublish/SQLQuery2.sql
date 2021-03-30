CREATE TABLE [SaveItem_2021] (
        [id] smallint IDENTITY (1, 1) NOT NULL ,
        [title] nvarchar (50) ,
        [storyNum] INT NOT NULL ,
        [description] nvarchar (900) ,
        
   
	Primary key (Id)
)

select * from SaveItem_2021
select * from Customers_2021
drop TABLE Customers_2021

CREATE TABLE [Customers_2021] (
    [id]       SMALLINT       IDENTITY (1, 1) NOT NULL,
    [fname]    NVARCHAR (30)  NOT NULL,
    [lname]    NVARCHAR (30)  NOT NULL,
    [email]    NVARCHAR (40)  NOT NULL,
    [phoneN]   NVARCHAR (30)  NOT NULL,
    [password] NVARCHAR (30)  NOT NULL,
    Primary key (Id)
)
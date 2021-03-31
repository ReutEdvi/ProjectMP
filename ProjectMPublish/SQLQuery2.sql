CREATE TABLE [SaveItem_2021] (
        [id] smallint IDENTITY (1, 1) NOT NULL ,
        [title] nvarchar (50) ,
        [storyNum] INT NOT NULL ,
        [description] nvarchar (900) ,
        
   
	Primary key (Id)
)
select * from Managers_2021
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
    [access] NVARCHAR (30)  , 
    

    Primary key (id)
)
CREATE TABLE [Managers_2021] (
    [id]       SMALLINT       IDENTITY (1, 1) NOT NULL,
    [email]    NVARCHAR (40)  NOT NULL,
    [password] NVARCHAR (30)  NOT NULL,

    Primary key (id)
)
INSERT INTO [Managers_2021]
           ([email],
            [password]
            
           )
                VALUES
           ('Ashimi2205@gmail.com',
           'Sa123456'
           
	   )

       CREATE TABLE [Campaign_2021] (
		[id] INT NOT NULL ,
        [investedAmount] INT  NOT NULL ,
        [balance] INT NOT NULL ,
        [viewsNum] INT NOT NULL ,
        [clicksNum] INT NOT NULL ,
        [status] bit  NOT NULL DEFAULT 0 ,       

	Primary key (id)
)
select * from Campaign_2021
CREATE TABLE [CustomersM_2021] (
    [id]       SMALLINT       IDENTITY (1, 1) NOT NULL,
    [fname]    NVARCHAR (30)  NOT NULL,
    [lname]    NVARCHAR (30)  NOT NULL,
    [email]    NVARCHAR (40)  NOT NULL,
    [access] NVARCHAR (30)  , 
    

    Primary key (id)
)
INSERT INTO [CustomersM_2021]
           ([fname],
            [lname],
            [email],
            [access]
           )
                VALUES
           ('reut',
           'edvi',
           'edvireut@gmail.com',
           'no'

           
	   )
       select * from CustomersM_2021
       SELECT * FROM Customers_2021 where email = 'edvireut@gmail.com' and password = 'Rere123456' and access <> 'NULL'
       SELECT * FROM Customers_2021 where email = 'edvireut@gmail.com' and password = 'Rere123456' and access <> 'NULL' 
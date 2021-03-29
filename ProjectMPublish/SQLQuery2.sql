CREATE TABLE [SaveItem_2021] (
        [storyId] smallint IDENTITY (1, 1) NOT NULL ,
        [storyNum] INT NOT NULL ,
        [storyText] nvarchar (900) ,
        
   
	Primary key (storyId)
)

select * from SaveItem_2021
drop TABLE SaveItem_2021
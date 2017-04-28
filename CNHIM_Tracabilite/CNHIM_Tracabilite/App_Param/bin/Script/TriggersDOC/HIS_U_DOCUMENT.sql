CREATE TRIGGER [theriaque].[HIS_U_DOCUMENT] ON [theriaque].[DOCUMENT]
 FOR UPDATE AS 
BEGIN 
 SELECT  DO_ID , ID_CATEGORIE , DO_LABEL , DO_FORMAT , DO_DATE , DO_ID_ORIGINE , DO_INFO1 , DO_CONTENU , DO_TAILLE , DO_DATEHEURE , DO_EXTENSION , DO_NOTE , CREATED , UT_ID  into #tempTable  FROM DELETED where 0=1 
 INSERT INTO #tempTable (  ID_CATEGORIE , DO_LABEL , DO_FORMAT , DO_DATE , DO_ID_ORIGINE , DO_INFO1 , DO_CONTENU , DO_TAILLE , DO_DATEHEURE , DO_EXTENSION , DO_NOTE , CREATED , UT_ID  ) 
 SELECT   ID_CATEGORIE , DO_LABEL , DO_FORMAT , DO_DATE , DO_ID_ORIGINE , DO_INFO1 , DO_CONTENU , DO_TAILLE , DO_DATEHEURE , DO_EXTENSION , DO_NOTE , CREATED , UT_ID  FROM DELETED 
 UNION 
 SELECT  ID_CATEGORIE , DO_LABEL , DO_FORMAT , DO_DATE , DO_ID_ORIGINE , DO_INFO1 , DO_CONTENU , DO_TAILLE , DO_DATEHEURE , DO_EXTENSION , DO_NOTE , CREATED , UT_ID  FROM INSERTED 

 
 
 
 DECLARE @CountTmp int 
 DECLARE @Countdelete int 
 DECLARE @CountInsert int 
 
 select @CountTmp=COUNT(*) from #tempTable 
 select @Countdelete=COUNT(*) from DELETED 
 select @CountInsert=COUNT(*) from INSERTED 
 
 if(@CountTmp = @Countdelete + @CountInsert and @CountTmp > 0) 
 BEGIN 
 
 
 DECLARE @CurrentDate datetime 
 DECLARE @USerNAME nvarchar(50)  SET @CurrentDate =  CONVERT(smallDatetime, GETDate()) 
 SET @UserNAME = SUSER_NAME() 
 
    --------
    DECLARE @ref_Deleted int
    DECLARE @ref_Inserted int
    
    DECLARE @Contenu varbinary(max)
    
     -- Deleted content
	select @Contenu=DO_Contenu from DELETED
    
   
    if( not exists(
		select null from [HIS_THERIAQUE].[dbo].[HIS_CONTENU_DOCUMENT] where DO_Contenu=@Contenu
    ))
    
    BEGIN 
		INSERT INTO [HIS_THERIAQUE].[dbo].[HIS_CONTENU_DOCUMENT](DO_Contenu)           
		SELECT DO_CONTENU FROM DELETED         
		--SELECT SCOPE_IDENTITY() AS [@ref_Deleted] 
		 select @ref_Deleted=max(REF_CONTENU) from [HIS_THERIAQUE].[dbo].[HIS_CONTENU_DOCUMENT]

    END
    ELSE
    BEGIN
		select @ref_Deleted=REF_CONTENU from [HIS_THERIAQUE].[dbo].[HIS_CONTENU_DOCUMENT]  where DO_Contenu=@Contenu

    END    
    
    -- Inserted Content
    select @Contenu=DO_Contenu from INSERTED
      
    if( not exists(
		select null from [HIS_THERIAQUE].[dbo].[HIS_CONTENU_DOCUMENT] where DO_Contenu=@Contenu
    ))
    
    BEGIN  
    
		INSERT INTO [HIS_THERIAQUE].[dbo].[HIS_CONTENU_DOCUMENT](DO_Contenu)
	           
		SELECT DO_CONTENU FROM INSERTED         
		--SELECT SCOPE_IDENTITY() AS [@ref_Inserted]   
	    
		select @ref_Inserted=max(REF_CONTENU) from [HIS_THERIAQUE].[dbo].[HIS_CONTENU_DOCUMENT]

    END
    ELSE
    BEGIN
		select @ref_Inserted=REF_CONTENU from [HIS_THERIAQUE].[dbo].[HIS_CONTENU_DOCUMENT]  where DO_Contenu=@Contenu

    END 
    
    
    ----
  
    INSERT INTO HIS_THERIAQUE..HIS_DOCUMENT (DTHIS, HISACTION, SUser, DO_ID , ID_CATEGORIE , DO_LABEL , DO_FORMAT , DO_DATE , DO_ID_ORIGINE , DO_INFO1 , REF_CONTENU , DO_TAILLE , DO_DATEHEURE , DO_EXTENSION , DO_NOTE , CREATED , UT_ID ) 
    SELECT @CurrentDate, 'UPD1', @UserNAME,  DO_ID , ID_CATEGORIE , DO_LABEL , DO_FORMAT , DO_DATE , DO_ID_ORIGINE , DO_INFO1 , @ref_Deleted, DO_TAILLE , DO_DATEHEURE , DO_EXTENSION , DO_NOTE , CREATED , UT_ID  FROM DELETED 
    UNION ALL 
    SELECT @CurrentDate, 'UPD2', @UserNAME,  DO_ID , ID_CATEGORIE , DO_LABEL , DO_FORMAT , DO_DATE , DO_ID_ORIGINE , DO_INFO1 , @ref_Inserted , DO_TAILLE , DO_DATEHEURE , DO_EXTENSION , DO_NOTE , CREATED , UT_ID  FROM INSERTED 



END 
 drop table #tempTable 
END 





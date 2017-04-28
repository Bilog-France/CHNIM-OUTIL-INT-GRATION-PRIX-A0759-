CREATE TRIGGER [theriaque].[HIS_I_DOCUMENT] ON [theriaque].[DOCUMENT]
 FOR INSERT AS 
BEGIN 


    DECLARE @ref_Inserted int
		
	DECLARE @Contenu varbinary(max)
	
    
    -- Inserted content
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
    
    

    INSERT INTO HIS_THERIAQUE..HIS_DOCUMENT (DTHIS, HISACTION, SUser,  DO_ID , ID_CATEGORIE , DO_LABEL , DO_FORMAT , DO_DATE , DO_ID_ORIGINE , DO_INFO1 , REF_CONTENU , DO_TAILLE , DO_DATEHEURE , DO_EXTENSION , DO_NOTE , CREATED , UT_ID ) 
    SELECT GETDATE(), 'INS', SUSER_NAME(),  DO_ID , ID_CATEGORIE , DO_LABEL , DO_FORMAT , DO_DATE , DO_ID_ORIGINE , DO_INFO1 , @ref_Inserted , DO_TAILLE , DO_DATEHEURE , DO_EXTENSION , DO_NOTE , CREATED , UT_ID  FROM INSERTED 
select getDate()
END 




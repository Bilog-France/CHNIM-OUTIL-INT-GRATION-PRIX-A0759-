CREATE TRIGGER [theriaque].[HIS_D_DOCUMENT] ON [theriaque].[DOCUMENT]
 FOR DELETE AS
BEGIN 

	DECLARE @ref_Deleted int
		
	DECLARE @Contenu varbinary(max)
	
    
    -- deleted content
	select @Contenu=DO_Contenu from DELETED
    

   
    if( not exists(
		select null from [HIS_THERIAQUE].[dbo].[HIS_CONTENU_DOCUMENT] where DO_Contenu=@Contenu
    ))
    BEGIN
    
		INSERT INTO [HIS_THERIAQUE].[dbo].[HIS_CONTENU_DOCUMENT](DO_Contenu)
	           
		SELECT DO_CONTENU FROM DELETED         
		--SELECT SCOPE_IDENTITY() AS [@ref_Inserted]   
	    
		select @ref_Deleted=max(REF_CONTENU) from [HIS_THERIAQUE].[dbo].[HIS_CONTENU_DOCUMENT]
    
    END
    ELSE
    BEGIN
		select @ref_Deleted=REF_CONTENU from [HIS_THERIAQUE].[dbo].[HIS_CONTENU_DOCUMENT]  where DO_Contenu=@Contenu

    END 
    	

    INSERT INTO HIS_THERIAQUE..HIS_DOCUMENT (DTHIS, HISACTION, SUser, DO_ID , ID_CATEGORIE , DO_LABEL , DO_FORMAT , DO_DATE , DO_ID_ORIGINE , DO_INFO1 , REF_CONTENU , DO_TAILLE , DO_DATEHEURE , DO_EXTENSION , DO_NOTE , CREATED , UT_ID ) 
    SELECT GETDATE(), 'SUP' , SUSER_NAME(),  DO_ID , ID_CATEGORIE , DO_LABEL , DO_FORMAT , DO_DATE , DO_ID_ORIGINE , DO_INFO1 , @ref_Deleted , DO_TAILLE , DO_DATEHEURE , DO_EXTENSION , DO_NOTE , CREATED , UT_ID  FROM DELETED 
END 





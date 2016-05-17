Public Module ModConstantes

    Public Const APPNAME As String = "Th�riaque"
    Public Const InvalidCode As Integer = -1
    Public Const InvalideControl As String = "###Invalid###"
    Public Const Path_File_Validation As String = "GoMigration.ini"

    Public Enum eMode
        Ajout = 0
        Modification = 1
        Consultation = 2
        Recherche = 3
        Suppression = 4
        StandBy = 5
        Vide = 6
        Duplication = 7
    End Enum

    Public Enum eKeyPressed
        KeyPreditive = Keys.F8
        KeyValidate = Keys.F10
        KeyQuite = Keys.F3
        KeyAdd = Keys.F6
        KeyCancel = Keys.F7
        KeyDelete = Keys.F11
        KeyDeclinaisonGlobale = Keys.F9
        KeyDeclinaisonClassique = Keys.F5
        KeyDeletelkup = Keys.Delete
        KeyDupliquer = Keys.F12
    End Enum

    Public Enum eNomenclature
        Caract�ristique_compl�mentaire_du_conditionnement = 1
        Compl�ment_de_forme_pharmaceutique = 2
        Condition_de_conservation = 3
        Contenant_du_conditionnement = 4
        Forme_pharmaceutique = 6
        Laboratoire = 7
        Liste = 8
        Mat�riau_du_conditionnement = 9
        Nature_substance_auxiliaire = 10
        Origine_du_nom_de_la_substance = 11
        Pr�sentation_unitaire = 12
        R�serv�_h�pitaux = 13
        Statut_de_la_pr�sentation = 14
        Statut_du_laboratoire = 15
        Taux_de_remboursement_SS = 17
        Voie_dadministration = 18
        Unit�_de_dosage_substance = 19
        Unit�_de_prise_par_contenant = 20
        Unit�_de_contenance = 21
        Gal�nique = 22
        Am�lioration_Service_M�dical_Rendu = 23
        Teneur = 24
        Document = 25
        Info_Compl�mentaire_sur_forme_pharmaceutique = 26
        Service_M�dical_Rendu = 27
        Nature_de_vecteur = 28
        Commentaire_dispensation = 29
        Type_texte_crit�re_de_choix = 30
        Commentaire_dose_totale_UCD = 31
    End Enum

    Public Enum eDeclinaison
        CPH = 0
        CCH = 1
        SAU = 2
        SAC = 3
        VOIE = 4
        SP = 5
        PR = 6
        ATC = 7
    End Enum

    Public Enum AttAuto_AnalysOrdo
        SP = 0
        CPH = 1
        CCH = 2
        SUB_AC = 3
        SUB_AUX = 4
    End Enum

    Public Function LibNomenclature(ByVal Numero As String) As String
        Select Case Numero
            Case "01"
                Return "Caract�ristique compl�mentaire du conditionnement"
            Case "02"
                Return "Compl�ment de forme pharmaceutique "
            Case "03"
                Return "Condition de conservation "
            Case "04"
                Return "Contenant du conditionnement"
            Case "06"
                Return "Forme pharmaceutique"
            Case "07"
                Return "Laboratoire"
            Case "08"
                Return "Liste"
            Case "09"
                Return "Mat�riau du conditionnement"
            Case "10"
                Return "Nature substance auxiliaire"
            Case "11"
                Return "Origine du nom de la substance"
            Case "12"
                Return "Pr�sentation unitaire"
            Case "13"
                Return "R�serv� h�pitaux"
            Case "14"
                Return "Statut de la pr�sentation"
            Case "15"
                Return "Statut du laboratoire"
            Case "17"
                Return "Taux de remboursement SS"
            Case "18"
                Return "Voie d'administration"
            Case "19"
                Return "Unit� de dosage substance"
            Case "20"
                Return "Unit� de prise par contenant"
            Case "21"
                Return "Unit� de contenance"
            Case "22"
                Return "Gal�nique"
            Case "23"
                Return "Am�lioration Service M�dical Rendu"
            Case "24"
                Return "Teneur"
            Case "25"
                Return "Document"
            Case "26"
                Return "Info Compl�mentaire sur forme pharmaceutique"
            Case "27"
                Return "Service M�dical Rendu"
            Case "28"
                Return "Nature de vecteur"
            Case "29"
                Return "Commentaire dispensation"
            Case "30"
                Return "Type texte crit�re de choix"
            Case "31"
                Return "Commentaire dose totale UCD"
            Case "PA"
                Return "Donn�es anthropom�triques"
            Case "PC"
                Return "Commentaires"
            Case "PF"
                Return "Fr�quence"
            Case "PN"
                Return "Nature de dose"
            Case "PP"
                Return "Unit� de prise"
            Case "PT"
                Return "Terrain"
            Case "PU"
                Return "Unit� de Temps"
            Case "NA"
                Return "Agent/Etiologie"
            Case "PK"
                Return "Commentaires"
            Case "SC"
                Return "Commentaires"
            Case "NC"
                Return "Commentaires"
            Case "NN"
                Return "Nature (code hi�rarchis�)"
            Case "NV"
                Return "Niveau"
            Case "NY"
                Return "Type"
            Case "NP"
                Return "Nature principale"
            Case "PA"
                Return "Donn�es anthropom�triques"
            Case "PC"
                Return "Commentaires"
            Case "PF"
                Return "Fr�quence"
            Case "PN"
                Return "Nature de dose"
            Case "PP"
                Return "Unit� de prise"
            Case "PT"
                Return "Terrain"
            Case "PU"
                Return "Unit� de Temps"
            Case "RC"
                Return "Commentaires Reconstitution/Administration"
            Case "CC"
                Return "Commentaires"
            Case "CS"
                Return "Famille de terrain"
            Case "HC"
                Return "Interaction RCP"
            Case "GT"
                Return "Conduite � tenir"
            Case "GC"
                Return "Circonstances favorisantes"
            Case "GP"
                Return "P�riode critique"
            Case "GO"
                Return "Observations"
            Case "GR"
                Return "Risques/Recommandations"
            Case "EC"
                Return "Commentaires"
            Case "EN"
                Return "Nature clinique et para-clinique"
            Case "IN"
                Return "Nature"
            Case "IS"
                Return "Sens"
            Case "IY"
                Return "Type"
            Case "IV"
                Return "Validation"
            Case "IC"
                Return "Commentaire Classe"
            Case "MN"
                Return "Nature"
            Case "MV"
                Return "Vecteur"
            Case "MD"
                Return "Dur�e / D�lai"
            Case "ML"
                Return "Lumi�re"
            Case "MT"
                Return "Temp�rature"
            Case "MS"
                Return "Solution"
            Case "TP"
                Return "Terrain p�re "
            Case "MS"
                Return "Solution"
            Case "32"
                Return "Code prestation SS"
            Case Else
                Return "Mise � jour des codifications"

        End Select
    End Function

    Public Structure StructResultPosologieUCD
        Public Valeur As Double
        Public CODE_UCD As String
        Public Libelle_UCD As String
    End Structure

    Public Structure StructResultCode
        Public _Code As String
        Public _Validation As Boolean
    End Structure

    Public Structure StructTxtProperty
        Private strVLookUpTable As String
        Private strVLookUpEditValue As String
        Private strVLookUpDisplayValue As String
        Private strVSSQL As String
        Private boolVOnlyFirst As Boolean
        Private boolVAfficheColNum As Boolean
        Private vDeclinaison As ClsDeclinaison


        Public ReadOnly Property LookUpTable() As String
            Get
                Return strVLookUpTable
            End Get
        End Property

        Public ReadOnly Property LookUpEditValue() As String
            Get
                Return strVLookUpTable
            End Get
        End Property
        Public ReadOnly Property LookUpSSQL() As String
            Get
                Return strVSSQL
            End Get
        End Property
        Public ReadOnly Property LookUpDisplayValue() As String
            Get
                Return strVLookUpDisplayValue
            End Get
        End Property

        Public ReadOnly Property boolOnlyFirst() As Boolean
            Get
                Return boolVOnlyFirst
            End Get
        End Property

        Public ReadOnly Property boolAfficheColNum() As Boolean
            Get
                Return boolVAfficheColNum
            End Get
        End Property

        Public Property Declinaison() As ClsDeclinaison
            Get
                Return vDeclinaison
            End Get
            Set(ByVal value As ClsDeclinaison)
                vDeclinaison = value
            End Set
        End Property

        Public Sub New(ByVal strLookUpTable As String, ByVal _Declinaison As ClsDeclinaison, Optional ByVal strSSQL As String = "", Optional ByVal strLookUpEditValue As String = "", Optional ByVal strLookUpDisplayValue As String = "", Optional ByVal boolOnlyFirst As Boolean = False, Optional ByVal boolAfficheColNum As Boolean = False)
            strVLookUpTable = strLookUpTable
            strLookUpEditValue = strVLookUpEditValue
            strLookUpDisplayValue = strVLookUpDisplayValue
            strVSSQL = strSSQL
            boolVOnlyFirst = boolOnlyFirst
            boolVAfficheColNum = boolAfficheColNum
            vDeclinaison = _Declinaison
        End Sub

    End Structure

    Public Structure StructGVTable
        Private vTable As eDeclinaison
        Private vgc As String
        Private cColum As DevExpress.XtraGrid.Columns.GridColumn

        Property Table() As eDeclinaison
            Get
                Return vTable
            End Get
            Set(ByVal value As eDeclinaison)
                vTable = value
            End Set
        End Property

        ReadOnly Property gc() As String
            Get
                Return vgc
            End Get
        End Property

        ReadOnly Property Column() As DevExpress.XtraGrid.Columns.GridColumn
            Get
                Return cColum
            End Get
        End Property

        Public Sub New(ByRef Gc As String, ByVal Table As eDeclinaison, ByVal Colum As DevExpress.XtraGrid.Columns.GridColumn)
            vTable = Table
            vgc = Gc
            cColum = Colum
        End Sub
    End Structure

    Public Class ClsDeclinaison

        Private VStart As eDeclinaison
        Private VContentIn As System.Collections.Generic.List(Of StructGVTable)

        ''' <summary>
        ''' Table de d�mamrage
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Start() As eDeclinaison
            Get
                Return VStart
            End Get
            Set(ByVal value As eDeclinaison)
                VStart = value
            End Set
        End Property

        Public Property ContentIn() As System.Collections.Generic.List(Of StructGVTable)
            Get
                Return VContentIn
            End Get
            Set(ByVal value As System.Collections.Generic.List(Of StructGVTable))
                VContentIn = value
            End Set
        End Property

        Public Sub New(ByVal Start_ As eDeclinaison, ByVal ContentIn_ As System.Collections.Generic.List(Of StructGVTable))
            VStart = Start_
            VContentIn = ContentIn_
        End Sub

    End Class

    Public Structure ConnexionInfo
        Private Userv As String
        Private Serverv As String
        Private DateBasev As String
        Private Passwordv As String

        Public Property User() As String
            Get
                Return Userv
            End Get
            Set(ByVal Value As String)
                Userv = Value
            End Set
        End Property

        Public Property Server() As String
            Get
                Return Serverv
            End Get
            Set(ByVal Value As String)
                Serverv = Value
            End Set
        End Property

        Public Property DateBase() As String
            Get
                Return DateBasev
            End Get
            Set(ByVal Value As String)
                DateBasev = Value
            End Set
        End Property

        Public Property Password() As String
            Get
                Return Passwordv
            End Get
            Set(ByVal Value As String)
                Passwordv = Value
            End Set
        End Property


    End Structure

End Module


Public Module ModInterface

    Interface InterfaceFormulaire
        Sub Ajouter()
        Function Chercher() As Boolean
        Function ChercherAvance() As Boolean
        Function SpecialiteCommune() As Boolean
        Sub Valider()
        Function Supprimer() As Boolean
        Sub Annuler()
        Sub Fermer()
        Sub Dupliquer()
        Function ChercherMultiCriteres() As Boolean
    End Interface

End Module

Public Class pizza
    Private Sub btnAfficherCommande_Click(sender As Object, e As EventArgs) Handles btnAfficherCommande.Click
        Dim recapitulatif As String = "Récapitulatif de la commande : " & vbCrLf

        ' Sélection de la taille de la pizza
        Dim taille As String = cmbTaille.SelectedItem.ToString()
        recapitulatif &= "Taille : " & taille & vbCrLf

        ' Sélection du type de croûte
        Dim typeCroûte As String = ""
        If radCrouteFine.Checked Then
            typeCroûte = "Croûte fine"
        ElseIf radCrouteClassique.Checked Then
            typeCroûte = "Croûte classique"
        ElseIf radCrouteEpaisse.Checked Then
            typeCroûte = "Croûte épaisse"
        End If
        recapitulatif &= "Type de croûte : " & typeCroûte & vbCrLf

        ' Sélection des ingrédients
        Dim ingredients As String = "Ingrédients supplémentaires : "
        If chkChampignons.Checked Then
            ingredients &= "Champignons, "
        End If
        If chkOlives.Checked Then
            ingredients &= "Olives, "
        End If
        If chkPoivrons.Checked Then
            ingredients &= "Poivrons, "
        End If
        If chkFromage.Checked Then
            ingredients &= "Fromage supplémentaire, "
        End If

        ' Si aucun ingrédient n'est sélectionné
        If ingredients = "Ingrédients supplémentaires : " Then
            ingredients &= "Aucun"
        Else
            ' Supprime la dernière virgule
            ingredients = ingredients.TrimEnd(","c)
        End If

        recapitulatif &= ingredients

        ' Affichage du récapitulatif dans une MessageBox
        MessageBox.Show(recapitulatif, "Détails de la commande")
    End Sub

End Class

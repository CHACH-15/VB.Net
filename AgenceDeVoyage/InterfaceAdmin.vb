Public Class InterfaceAdmin
    Private Sub EffacerChamps()

        NumVolAD.Text = ""
        DestinationAd.Text = ""
        PrixAd.Text = ""
        DateAd.Value = DateTime.Now
        PlacesDispo.Value = PlacesDispo.Minimum
    End Sub





    Private Sub afficherBtn_Click(sender As Object, e As EventArgs) Handles afficherBtn.Click
        If dgvVol.Rows.Count = 0 Then
            MessageBox.Show("Aucun vol à afficher.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Les vols sont affichés dans le tableau.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub ajouterBtn_Click(sender As Object, e As EventArgs) Handles ajouterBtn.Click
        Dim numVol As String = NumVolAD.Text
        Dim destination As String = DestinationAd.Text
        Dim dateHeure As DateTime = DateAd.Value
        Dim placesDisponibles As Integer = CInt(PlacesDispo.Value)

        Dim prix As Decimal = CDec(PrixAd.Text)

        dgvVol.Rows.Add(numVol, dateHeure, destination, placesDisponibles, prix)


        EffacerChamps()
    End Sub

    Private Sub modifierBtn_Click(sender As Object, e As EventArgs) Handles modifierBtn.Click
        If dgvVol.SelectedRows.Count = 0 Then
            MessageBox.Show("Veuillez sélectionner un vol à modifier.")
            Return
        End If


        Dim row As DataGridViewRow = dgvVol.SelectedRows(0)


        row.Cells("numVol").Value = NumVolAD.Text
        row.Cells("dateHeure").Value = DateAd.Value
        row.Cells("destination").Value = DestinationAd.Text
        row.Cells("placesDisponibles").Value = CInt(PlacesDispo.Value)


        EffacerChamps()
    End Sub

    Private Sub SupprimerBtn_Click(sender As Object, e As EventArgs) Handles SupprimerBtn.Click
        If dgvVol.SelectedRows.Count = 0 Then
            MessageBox.Show("Veuillez sélectionner un vol à supprimer.")
            Return
        End If


        dgvVol.Rows.Remove(dgvVol.SelectedRows(0))
        EffacerChamps()
    End Sub

    Private Sub InterfaceAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
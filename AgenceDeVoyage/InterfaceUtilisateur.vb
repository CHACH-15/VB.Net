Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox
Imports System.IO
Public Class InterfaceUtilisateur
    Private vols As New List(Of Vol) From {
        New Vol With {.NumeVol = "V001", .Destination = "Paris", .DateVol = New DateTime(2025, 1, 15), .PDs = 50, .Prix = 150},
        New Vol With {.NumeVol = "V002", .Destination = "New York", .DateVol = New DateTime(2025, 1, 16), .PDs = 30, .Prix = 500},
        New Vol With {.NumeVol = "V003", .Destination = "Tokyo", .DateVol = New DateTime(2025, 1, 17), .PDs = 20, .Prix = 700}
    }

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        ' Charger les données
        For Each vol In vols
            dgvVol.Rows.Add(vol.NumeVol, vol.Destination, vol.DateVol, vol.PDs, vol.Prix)
        Next
    End Sub

    Private Sub BtnRecherche_Click(sender As Object, e As EventArgs) Handles BtnRecherche.Click
        Dim destinationRecherchee As String = DestinaTionTxTb.Text.Trim().ToLower()
        Dim dateRecherchee As Date = DateD.Value.Date

        ' Filtrer et afficher les résultats
        Dim volsTrouves = From vol In vols
                          Where vol.Destination.ToLower().Contains(destinationRecherchee) _
                          AndAlso vol.DateVol.Date = dateRecherchee
                          Select vol
        If Not volsTrouves.Any() Then
            MessageBox.Show("Aucun vol trouvé conforme avec vos critères de destination et de date.")
        End If


        dgvVol.Rows.Clear()
        For Each vol In volsTrouves
            dgvVol.Rows.Add(vol.NumeVol, vol.Destination, vol.DateVol, vol.PDs, vol.Prix)
        Next
    End Sub

    Private Sub BtnReserver_Click(sender As Object, e As EventArgs) Handles BtnReserver.Click
        ' Vérifier si une ligne est sélectionnée
        If dgvVol.SelectedRows.Count = 0 Then
            MessageBox.Show("Veuillez sélectionner un vol.")
            Return
        End If

        ' Vérification du type de l'objet sélectionné


        ' Récupérer les informations du vol sélectionné
        Dim numeroVol As String = dgvVol.SelectedRows(0).Cells("NumeVol").Value.ToString()
        Dim destination As String = dgvVol.SelectedRows(0).Cells("Destination").Value.ToString()
        Dim dateVol As DateTime = CDate(dgvVol.SelectedRows(0).Cells("DateVol").Value)
        Dim prix As Decimal = CDec(dgvVol.SelectedRows(0).Cells("Prix").Value)

        ' Construction du reçu


        Dim nomClient As String = NomTxtBox.Text.Trim()
        Dim prenomClient As String = PrenomTxtBox.Text.Trim()
        Dim telephoneClient As String = NumTelTXTbox.Text.Trim()

        ' Valider les champs
        If String.IsNullOrWhiteSpace(nomClient) OrElse String.IsNullOrWhiteSpace(prenomClient) OrElse String.IsNullOrWhiteSpace(telephoneClient) Then
            MessageBox.Show("Veuillez remplir tous les champs.")
            Return
        End If
        Dim rowIndex As Integer = dgvVol.SelectedRows(0).Index ' Index de la ligne sélectionnée
        Dim placesDisponibles As Integer = CInt(dgvVol.Rows(rowIndex).Cells("PDs").Value)
        dgvVol.Rows(rowIndex).Cells("PDs").Value = placesDisponibles - 1

        ' Générer un reçu
        Dim recu As String = $"RÉSERVATION CONFIRMÉE" & vbCrLf &
                     $"--------------------------" & vbCrLf &
                     $"Nom  {nomClient} {prenomClient}" & vbCrLf &
                     $"Téléphone  {telephoneClient}" & vbCrLf &
                     $"Vol  {numeroVol}" & vbCrLf &
                     $"Destination  {destination}" & vbCrLf &
                     $"Date  {dateVol:dd/ MM / yyyy HH:mm}" & vbCrLf &
                     $"Prix  {prix} €" & vbCrLf &
                     $"--------------------------" & vbCrLf &
                     $"Merci d'avoir choisi notre agence !"


        ' Afficher un aperçu dans une boîte de dialogue
        MessageBox.Show(recu, "Reçu de Réservation", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Optionnel : Enregistrer le reçu dans un fichier texte


        ' Confirmer la réservation
        MessageBox.Show("Réservation effectuée avec succès ! Un reçu a été généré.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class

Public Class Vol
    Public Property NumeVol As String
    Public Property Destination As String
    Public Property DateVol As DateTime
    Public Property PDs As Integer
    Public Property Prix As Decimal
End Class
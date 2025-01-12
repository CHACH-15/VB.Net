Public Class Login
    Public Users As New Dictionary(Of String, String) From {
         {"admin", "admin123"}, ' Admin avec un mot de passe spécifique
         {"chahd", "user123"},  ' Utilisateur simple
         {"hadil", "user456"}   ' Autre utilisateur simple
     }

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim username As String = UserNameBox.Text.Trim()
        Dim password As String = PasswordBox.Text.Trim()

        ' Vérifier les champs vides
        If username = "" Or password = "" Then
            Label3.Text = "Veuillez remplir tous les champs."
            Label3.ForeColor = Color.Red
            Label3.Visible = True
            Return
        End If

        ' Vérifier si le nom d'utilisateur existe
        If Users.ContainsKey(username) Then
            ' Vérifier le mot de passe
            If Users(username) = password Then
                Label3.Visible = False ' Cacher le message d'erreur

                ' Vérifier si c'est un admin
                If username = "admin" Then
                    ' Ouvrir l'interface Admin
                    Dim adminForm As New InterfaceAdmin()
                    adminForm.Show()
                Else
                    ' Ouvrir l'interface Utilisateur
                    Dim userForm As New InterfaceUtilisateur()
                    userForm.Show()
                End If

                ' Cacher le formulaire de connexion
                Me.Hide()
            Else
                ' Mot de passe incorrect
                Label3.Text = "Mot de passe incorrect."
                Label3.ForeColor = Color.Red
                Label3.Visible = True
            End If
        Else
            ' Nom d'utilisateur incorrect
            Label3.Text = "Nom d'utilisateur introuvable."
            Label3.ForeColor = Color.Red
            Label3.Visible = True
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class

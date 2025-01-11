Public Class AddBook
    Public Shared Books As New List(Of Book)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text.Trim() = "" OrElse TextBox2.Text.Trim() = "" OrElse TextBox3.Text.Trim() = "" Then
            MessageBox.Show("Veuillez remplir tous les champs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Dim newBook As New Book(TextBox1.Text, TextBox2.Text, TextBox3.Text)
            Books.Add(newBook)


            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()

            MessageBox.Show("Livre ajouté avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim bookListForm As New listesBook()
        bookListForm.Show()
        Me.Hide()
    End Sub
End Class
Public Structure Book
    Public Name As String
    Public Author As String
    Public Publisher As String


    Public Sub New(bookName As String, bookAuthor As String, bookPublisher As String)
        Name = bookName
        Author = bookAuthor
        Publisher = bookPublisher
    End Sub
End Structure
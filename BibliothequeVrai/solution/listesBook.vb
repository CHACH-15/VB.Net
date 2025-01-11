Public Class listesBook
    Private Sub listesBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()

        For Each book In AddBook.Books
            ListBox1.Items.Add(book.Name)
            ListBox2.Items.Add(book.Author)
            ListBox3.Items.Add(book.Publisher)
        Next
    End Sub
End Class
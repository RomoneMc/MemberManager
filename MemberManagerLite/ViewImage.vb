Public Class ViewImage
    Property ImageUrl As String

    Sub New(URL As String)
        InitializeComponent()
        ImageUrl = URL
    End Sub

    Private Sub ViewImage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ImageBox.ImageLocation = ImageUrl
    End Sub
End Class
Public Class Login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            If Not String.IsNullOrEmpty(txtusername.Text) AndAlso Not String.IsNullOrEmpty(txtpassword.Text) Then
                If UsersTableAdapter1.VerifyCredentials(txtusername.Text, txtpassword.Text) = 1 Then
                    MainForm.Show()
                    Me.Close()
                Else
                    MessageBox.Show("Please check your credentials.", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                End If
            ElseIf String.IsNullOrEmpty(txtpassword.Text) Then
                MessageBox.Show("Please fill out all fields.", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            End If
        Catch ex As DataException
            MessageBox.Show("Please contact your system administrator." & vbNewLine & "Details: The connection string needs to be changed.")
        End Try
    End Sub

    Private Sub txtusername_TextChanged(sender As Object, e As EventArgs) Handles txtusername.TextChanged
        If String.IsNullOrEmpty(txtusername.Text) Then
            btnLogin.Enabled = False
        Else
            btnLogin.Enabled = True
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtusername.Focus()
        btnLogin.Enabled = False
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        SettingsForm.ShowDialog()
    End Sub

    Private Sub txtpassword_TextChanged(sender As Object, e As EventArgs) Handles txtpassword.TextChanged
        If Not String.IsNullOrEmpty(txtusername.Text) Then
            If txtusername.Text.ToLower() = "admin" And txtpassword.Text.ToLower() = "admin" Then
                btnSettings.Show()
            Else
                btnSettings.Hide()
            End If
        End If
    End Sub
End Class
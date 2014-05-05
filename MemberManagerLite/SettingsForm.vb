Imports System.Windows.Forms

Public Class SettingsForm
    Property connection_string As String

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtOldString.Text = My.Settings.ContactConnectionString
    End Sub

    Private Sub btnBrowseForFile_Click(sender As Object, e As EventArgs) Handles btnBrowseForFile.Click
        If ofdDBLocation.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtLocation.Text = ofdDBLocation.FileName
        End If
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        If Not String.IsNullOrEmpty(txtLocation.Text) Then
            If MessageBox.Show("Are you sure you would to like change the application's connection string?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                connection_string = String.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0}", txtLocation.Text)
                My.Settings.SetUserOverride("ContactConnectionString", connection_string)
                My.Settings.Save()
                txtNewConnString.Text = connection_string
            Else
                Exit Sub
            End If
        Else
            MessageBox.Show("Please enter a location and a filename for the database.", "Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Sub btnFindNewLogo_Click(sender As Object, e As EventArgs) Handles btnFindNewLogo.Click
        If ofdFindLogo.ShowDialog() = Windows.Forms.DialogResult.OK Then
            pbxCurrentLogo.ImageLocation = ofdFindLogo.FileName
            My.Settings.LogoLocation = ofdFindLogo.FileName
            My.Settings.Save()
        End If
    End Sub
End Class
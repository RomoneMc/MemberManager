Imports System.Windows.Forms

Public Class ExportOptions
    Property FromDate As Date = Today.ToShortDateString()
    Property ToDate As Date = Today.ToShortDateString()
    Dim no_records As Integer = 0
    Dim adapter = New ContactLiteDataSetTableAdapters.PersonTableAdapter

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If Not no_records = 0 Then
            ToDate = dtpTo.Value.ToShortDateString()
            FromDate = dtpFrom.Value.ToShortDateString()

            ExportProgress.Show()

            Dim ex As ExcelExport = New ExcelExport
            ex.Export(adapter.GetAllMembersSince(dtpFrom.Value, dtpTo.Value))

            ExportProgress.Close()

            MessageBox.Show("All done, check your desktop for export.xlsx")

            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            MessageBox.Show("No records found for this date interval.", "No records found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub ExportOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpFrom.MaxDate = Today.ToShortDateString()
        dtpTo.MaxDate = Today.ToShortDateString()
        dtpTo.Value = Today.ToShortDateString()
        dtpFrom.Value = Today.ToShortDateString()
        dtpTo.MinDate = dtpFrom.Value
    End Sub

    Private Sub dtpTo_ValueChanged(sender As Object, e As EventArgs) Handles dtpTo.ValueChanged, dtpFrom.ValueChanged
        dtpTo.MinDate = dtpFrom.Value
        no_records = adapter.GetAllMembersSince(dtpFrom.Value, dtpTo.Value).Count
        lblRecordsReturned.Text = no_records.ToString() + " Record(s)"
    End Sub
End Class

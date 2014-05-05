Imports System.Windows.Forms
Imports Excel = Microsoft.Office.Interop.Excel

Public Class ExcelExport
    Function Export(dt As DataTable) As Boolean
        Dim ds As DataSet = New DataSet()
        ds.Tables.Add(dt)
        Dim table As DataTable = ds.Tables(0)

        Dim i As Integer = 1
        Dim k As Integer = 1

        Dim filename = My.Computer.FileSystem.SpecialDirectories.Desktop & "\export.xlsx"

        Dim ex As Excel.Application = New Excel.Application
        ex.ScreenUpdating = False

        With ex
            .Workbooks.Add()
            .SheetsInNewWorkbook = 1

            For col = 0 To table.Columns.Count - 1
                .Cells(1, i).Value = table.Columns(col).ColumnName
                .Cells(1, i).EntireRow.Font.Bold = True

                i += 1
            Next

            For col = 0 To table.Columns.Count - 1
                i = 2

                For row = 0 To table.Rows.Count - 1
                    .Cells(i, k).Value = table.Rows(row).ItemArray(col)
                    i += 1
                Next
                k += 1
            Next

            .ActiveCell.Worksheet.SaveAs(filename)
            ex.Quit()
            System.Runtime.InteropServices.Marshal.ReleaseComObject(ex)
        End With
        ds.Dispose()

        Return True
    End Function
End Class
Imports System.Data.OleDb

Public Class ExportDataForm
    'Private Sub exportButton_Click(sender As Object, e As EventArgs) Handles exportButton.Click
    '    Dim query As String = "SELECT * FROM Report_Table WHERE Fecha BETWEEN @StartDate AND @EndDate"

    '    Using connection As New OleDbConnection(connectionString)
    '        Using command As New OleDbCommand(query, connection)
    '            ' Parámetros para las fechas
    '            command.Parameters.AddWithValue("@StartDate", startExportDatePicker.Value)
    '            command.Parameters.AddWithValue("@EndDate", endExportDatePicker.Value)

    '            Using adapter As New OleDbDataAdapter(command)
    '                Dim dataTable As New DataTable()
    '                adapter.Fill(dataTable)

    '                ' Enlaza los datos al DataGridView
    '                DataGridView1.DataSource = dataTable
    '            End Using
    '        End Using
    '    End Using
    'End Sub
End Class
Public Class ToolsForm
    Private Sub exportDataButton_Click(sender As Object, e As EventArgs) Handles exportDataButton.Click
        ExportDataForm.ShowDialog()
    End Sub

    Private Sub toolFormCloseButton_Click(sender As Object, e As EventArgs) Handles toolFormCloseButton.Click
        Me.Close()
    End Sub

    Private Sub refTreeViewButton_Click(sender As Object, e As EventArgs) Handles refTreeViewButton.Click
        RefTreeForm.ShowDialog()
    End Sub

    Private Sub dbQueryFormButton_Click(sender As Object, e As EventArgs) Handles dbQueryFormButton.Click
        dbQueryForm.ShowDialog()
    End Sub
End Class
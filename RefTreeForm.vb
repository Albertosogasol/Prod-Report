Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class RefTreeForm
    Private Sub refTreeView_Builder(sender As Object, e As EventArgs) Handles MyBase.Load
        refTreeView.Nodes.Add("Prueba1")
        refTreeView.Nodes.Add("Prueba2")
        refTreeView.Nodes(1).Nodes.Add("Prueba3")
    End Sub
End Class
Public Class AftermarketReportForm
    Private Sub amLoadDataButton_Click(sender As Object, e As EventArgs) Handles amLoadDataButton.Click
        'Se verifica si los textBox contienen espacios. Si los hay, se eliminan'
        For Each textBoxControl As Control In Me.Controls
            If TypeOf textBoxControl Is TextBox Then
                Dim textBox As TextBox = DirectCast(textBoxControl, TextBox)
                If textBox.Text.Contains(" ") Then
                    textBox.Text = textBox.Text.Replace(" ", "")
                End If
            End If
        Next

        'Copia los datos introducidos en el formulario en el principal
        With MainForm
            .refTextBox.Text = amRefTextbox.Text
            .processTextBox.Text = amProcessComboBox.Text
            .finalRefTextBox.Text = amFinalRefTextBox.Text
            .quantityTextBox.Text = amQuantityTextBox.Text
            .scrapTextBox.Text = amScrapTextBox.Text
            .lineTextBox.Text = amLineTextBox.Text
            .amRefCheckBox.Checked = True
        End With

        'Cierra el formulario'
        Me.Close()
    End Sub

    Private Sub amCancelButton_Click(sender As Object, e As EventArgs) Handles amCancelButton.Click
        Me.Close()
    End Sub

    Public Sub amTextBoxClear()
        'Limpia los textBox una vez que se han cargado los datos en la tabla. 
        'Es llamado principalmente desde el código principal
        amRefTextbox.Clear()
        amProcessComboBox.SelectedIndex = -1
        amFinalRefTextBox.Clear()
        amQuantityTextBox.Clear()
        amScrapTextBox.Clear()
        amLineTextBox.Clear()
    End Sub
End Class
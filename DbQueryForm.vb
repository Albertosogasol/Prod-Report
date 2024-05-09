Imports System.Data.OleDb

Public Class DbQueryForm
    Private Sub dbQueryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Registro_ProduccionDataSet.Managers_Table' table. You can move, or remove it, as needed.
        Me.Managers_TableTableAdapter.Fill(Me.Registro_ProduccionDataSet.Managers_Table)
        'TODO: This line of code loads data into the 'Registro_ProduccionDataSet.Report_Table' table. You can move, or remove it, as needed.
        'Carga todos los datos de la base de datos en el DataGridView al cargar la ventana del formulario
        'Me.Report_TableTableAdapter.Fill(Me.Registro_ProduccionDataSet.Report_Table)

        'Fecha inicial de hoy como predeterminada
        queryFormFilterInitDatePicker.Value = DateTime.Now
        'Fecha final de hoy como predeterminada
        Me.queryFormFilterEndDatePicker.Value = DateTime.Now
        Me.queryFormDataDatePicker.Value = DateTime.Now
        queryFormDataManagerComboBox.SelectedIndex = -1
        'Aplica el filtro a la tabla'
        queryFormDefaultDataGrid()
    End Sub

    Private Sub queryFormDefaultDataGrid()
        'Aplica un filtro de fecha hoy-hoy para que no se cargue la tabla con todos los datos completos
        'Cambio aplicado el 09/05/2024 obligado por la gran cantidad de datos almacenados en report_table
        Dim query As String = "SELECT * FROM Report_Table WHERE type_Date BETWEEN #" & queryFormFilterInitDatePicker.Value.ToString("MM/dd/yyyy") & "# AND #" & queryFormFilterEndDatePicker.Value.ToString("MM/dd/yyyy") & "#"
        Try
            'Consulta a la base de datos'
            Dim queryAdapter As New OleDbDataAdapter(query, MainFunctions.connOleDbBuilder(MainFunctions.conStringBuilder()))
            Dim queryTable As New DataTable()
            queryAdapter.Fill(queryTable)
            DbQueryDataGridView.DataSource = queryTable
        Catch ex As Exception
            MsgBox("Se ha producido un error al cargar los datos en la tabla principal." & ex.Message, vbExclamation, "ERROR")
        End Try
    End Sub

    Private Sub queryFormFilterSearchButton_Click(sender As Object, e As EventArgs) Handles queryFormFilterSearchButton.Click
        'Procedimiento para filtrar la DataGridView
        Try
            'Establece la cadena de consulta. 1=1 para establecer de forma predeterminada el FROM. Después se añaden los AND si hay algún dato en ellos
            'Dim query As String = "SELECT * FROM Report_Table WHERE 1=1"
            Dim query As String = "SELECT * FROM Report_Table"
            'Si los textBox no están vacíos, se aplican como filtro

            'INTERVALO DE FECHAS'
            query &= " WHERE type_Date BETWEEN #" & queryFormFilterInitDatePicker.Value.ToString("MM/dd/yyyy") & "# AND #" & queryFormFilterEndDatePicker.Value.ToString("MM/dd/yyyy") & "#" 'Fechas en US mode para realizar la búsqueda correctamente

            'REFERENCIA
            If Not String.IsNullOrEmpty(queryFormFilterRefTextBox.Text.Trim()) Then
                query &= " AND type_Reference LIKE '%" & queryFormFilterRefTextBox.Text.Trim() & "%'"
            End If

            'SEMANA
            If Not String.IsNullOrEmpty(queryFormFilterWeekTextBox.Text.Trim()) Then
                Dim week As Integer = Integer.Parse(queryFormFilterWeekTextBox.Text.Trim())
                query &= " AND type_Week = " & week & ""
            End If

            'ENCARGADO
            If Not String.IsNullOrEmpty(queryFormFilterManagerComboBox.Text) Then
                query &= " AND type_Manager = '" & queryFormFilterManagerComboBox.Text & "'"
            End If

            'TURNO
            If Not String.IsNullOrEmpty(queryFormFilterShiftComboBox.Text) Then
                query &= " AND type_Shift = '" & queryFormFilterShiftComboBox.Text & "'"
            End If

            'Se comprueba si las fechas están colocadas en el orden correcto
            If queryFormFilterInitDatePicker.Value > queryFormFilterEndDatePicker.Value Then
                MsgBox("ERROR. La fecha inicial debe ser anterior a la fecha final", vbExclamation, "ERROR")
                Exit Sub
            End If

            'Consulta a la base de datos'
            Dim queryAdapter As New OleDbDataAdapter(query, MainFunctions.connOleDbBuilder(MainFunctions.conStringBuilder()))
            Dim queryTable As New DataTable()
            queryAdapter.Fill(queryTable)
            DbQueryDataGridView.DataSource = queryTable
        Catch ex As Exception
            MsgBox("Se ha producido un error en el filtrado de datos: " & ex.Message, vbExclamation, "ERROR")
        End Try
    End Sub

    Private Sub queryFormFilterCleanButton_Click(sender As Object, e As EventArgs) Handles queryFormFilterCleanButton.Click
        'Limpia todos los filtros 
        'queryFormFilterInitDatePicker.Value = New Date(2023, 10, 16)
        queryFormFilterInitDatePicker.Value = DateTime.Now
        queryFormFilterEndDatePicker.Value = DateTime.Now
        queryFormFilterRefTextBox.Clear()
        queryFormFilterManagerComboBox.SelectedIndex = -1
        queryFormFilterWeekTextBox.Clear()
        queryFormFilterShiftComboBox.SelectedIndex = -1

        'Recarga la DataGridView con todos los valores
        queryFormDefaultDataGrid()
        'Método antiguo que cargaba toda la tabla. Empezaba a ser demasiado lenta la carga de muchos registros. Se filtra por la fecha actual
        'DbQueryDataGridView.DataSource = Registro_ProduccionDataSet.Report_Table 


    End Sub

    Private Sub queryFormCloseButton_Click(sender As Object, e As EventArgs) Handles queryFormCloseButton.Click
        queryFormFilterCleanButton_Click(sender, e)
        queryFormDataClearTextBox()
        Me.Close()
    End Sub

    Private Sub queryFormTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DbQueryDataGridView.CellContentDoubleClick
        'Copia de datos de DataGridView a TextBox correspondiente
        Try
            queryFormDataDatePicker.Value = DbQueryDataGridView.Rows(e.RowIndex).Cells(1).Value
            queryFormDataWeekTextBox.Text = DbQueryDataGridView.Rows(e.RowIndex).Cells(7).Value
            queryFormDataIdTextBox.Text = DbQueryDataGridView.Rows(e.RowIndex).Cells(0).Value
            queryFormDataRefTextBox.Text = DbQueryDataGridView.Rows(e.RowIndex).Cells(3).Value
            queryFormDataSage.Checked = DbQueryDataGridView.Rows(e.RowIndex).Cells(6).Value
            queryFormDataQuantityTextBox.Text = DbQueryDataGridView.Rows(e.RowIndex).Cells(4).Value
            queryFormDataScrapTextBox.Text = DbQueryDataGridView.Rows(e.RowIndex).Cells(5).Value
            queryFormDataManagerComboBox.Text = DbQueryDataGridView.Rows(e.RowIndex).Cells(8).Value
            queryFormDataShiftComboBox.Text = DbQueryDataGridView.Rows(e.RowIndex).Cells(9).Value
            queryFormDataLineTextBox.Text = DbQueryDataGridView.Rows(e.RowIndex).Cells(11).Value
            queryFormDataProcessComboBox.Text = DbQueryDataGridView.Rows(e.RowIndex).Cells(10).Value
            queryFormDataCommentTextBox.Text = DbQueryDataGridView.Rows(e.RowIndex).Cells(12).Value
            queryFormDataFinalRefTextBox.Text = DbQueryDataGridView.Rows(e.RowIndex).Cells(2).Value
            queryFormDataAM.Checked = DbQueryDataGridView.Rows(e.RowIndex).Cells(13).Value
        Catch ex As Exception
            MsgBox("Error al copiar los datos: " & ex.Message, vbExclamation, "ERROR")
        End Try
    End Sub

    Private Sub queryFormModifyButton_Click(sender As Object, e As EventArgs) Handles queryFormModifyButton.Click
        'Modifica los valores cambiados en los textBox para almacenarlos en la base de datos
        Try
            Dim queryConn As New OleDbConnection
            queryConn = MainFunctions.connOleDbBuilder(MainFunctions.conStringBuilder)
            Using queryConn
                queryConn.Open()

                Dim queryModifyString As String
                Dim queryLogString As String

                'ID que se va a modificar'
                Dim type_ID As Integer = queryFormDataIdTextBox.Text

                'Cadena para el comando de SQL
                queryModifyString = "UPDATE Report_Table SET type_Date = @Date, type_Reference = @Reference, type_SAGE = @SAGE, type_Manager = @Manager, type_Shift = @Shift, type_Comments = @Comments, type_Process = @Process, type_Line = @Line, type_FinalRef = @FinalRef, type_AM=@AM, type_Quantity=@Quantity, type_Scrap = @Scrap, type_Week = @Week WHERE ID = " & type_ID

                'Comando de SQL
                Dim modifyCmd As New OleDbCommand(queryModifyString, queryConn)

                'Se eliminan espacios de los textBox
                'Referencia
                If queryFormDataRefTextBox.Text.Contains(" ") Then
                    queryFormDataRefTextBox.Text = queryFormDataRefTextBox.Text.Replace(" ", "")
                End If

                'Semana
                If queryFormDataWeekTextBox.Text.Contains(" ") Then
                    queryFormDataWeekTextBox.Text = queryFormDataWeekTextBox.Text.Replace(" ", "")
                End If

                'Cantidad
                If queryFormDataQuantityTextBox.Text.Contains(" ") Then
                    queryFormDataQuantityTextBox.Text = queryFormDataQuantityTextBox.Text.Replace(" ", "")
                End If

                'Scrap
                If queryFormDataScrapTextBox.Text.Contains(" ") Then
                    queryFormDataScrapTextBox.Text = queryFormDataScrapTextBox.Text.Replace(" ", "")
                End If

                'Línea
                If queryFormDataLineTextBox.Text.Contains(" ") Then
                    queryFormDataLineTextBox.Text = queryFormDataLineTextBox.Text.Replace(" ", "")
                End If

                'Referencia Final
                If queryFormDataFinalRefTextBox.Text.Contains(" ") Then
                    queryFormDataFinalRefTextBox.Text = queryFormDataFinalRefTextBox.Text.Replace(" ", "")
                End If

                'Valores de las variables
                With modifyCmd.Parameters
                    .AddWithValue("@Date", queryFormDataDatePicker.Value.ToString("dd/MM/yyyy"))
                    .AddWithValue("@Reference", queryFormDataRefTextBox.Text)
                    .AddWithValue("@SAGE", queryFormDataSage.Checked)
                    .AddWithValue("@Manager", queryFormDataManagerComboBox.Text)
                    .AddWithValue("@Shift", queryFormDataShiftComboBox.Text)
                    .AddWithValue("@Comments", queryFormDataCommentTextBox.Text)
                    .AddWithValue("@Process", queryFormDataProcessComboBox.Text)
                    .AddWithValue("@Line", queryFormDataLineTextBox.Text)
                    .AddWithValue("@FinalRef", queryFormDataFinalRefTextBox.Text)
                    .AddWithValue("@AM", queryFormDataAM.Checked)
                End With

                'Comprobación de valores numéricos
                If IsNumeric(queryFormDataQuantityTextBox.Text) Then
                    modifyCmd.Parameters.AddWithValue("@Quantity", CInt(queryFormDataQuantityTextBox.Text))
                Else
                    MsgBox("ERROR. La cantidad debe ser un valor numérico")
                    Exit Sub
                End If

                If IsNumeric(queryFormDataScrapTextBox.Text) Then
                    modifyCmd.Parameters.AddWithValue("@Scrap", CInt(queryFormDataScrapTextBox.Text))
                Else
                    MsgBox("ERROR. El scrap debe ser un valor numérico")
                    Exit Sub
                End If

                If IsNumeric(queryFormDataWeekTextBox.Text) Then
                    modifyCmd.Parameters.AddWithValue("@Week", CInt(queryFormDataWeekTextBox.Text))
                Else
                    MsgBox("ERROR. La semana debe ser un valor numérico")
                    Exit Sub
                End If

                'Usuario que realiza la modificación
                Dim user As String = SystemInformation.UserName

                'Fecha en la que se realiza la modificación
                Dim currentDate As String = DateTime.Now.ToString("dd/MM/yyyy")

                'String de registro de valores antiguos. Con este registro queda reflejado los valores anteriores al cambio así como el usuario que realizó el cambio
                queryLogString = "INSERT INTO changelog_Report_Table" &
    "(log_Report_Id, log_Report_Reference, log_Report_Date, log_Report_Quantity, log_Report_Scrap, log_Report_SAGE, log_Report_Week, log_Report_Manager, log_Report_Shift, log_Report_Comments, log_Report_Process, log_Report_Line, log_Report_FinalRef, log_Report_AM, log_Date, log_Username) " &
    "Select Id, type_Reference, type_Date, type_Quantity, type_Scrap, type_SAGE, type_Week, type_Manager, type_Shift, type_Comments, type_Process, type_Line, type_FinalRef, type_AM, '" & currentDate & "', '" & user & "' FROM Report_Table WHERE Id = " & type_ID

                'Confirmación del usuario
                Dim confirmModification As DialogResult = MessageBox.Show("¿Desea realizar la modificación del registro? Se realizará una copia de seguridad de los valores antiguos.", "Confirmar modificación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If confirmModification = DialogResult.Yes Then
                    Try
                        'Se construye el comenado del registro en el log
                        Dim logCmd As New OleDbCommand(queryLogString, queryConn)

                        'Se ejecutan las dos consultas
                        logCmd.ExecuteNonQuery()
                        Threading.Thread.Sleep(500)
                        modifyCmd.ExecuteNonQuery()
                        Threading.Thread.Sleep(2000)
                        dbQueryForm_Load(sender, e)

                        'Limpieza de textBox
                        queryFormDataClearTextBox()

                        MessageBox.Show("Modificado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Catch exx As Exception
                        MsgBox("Error. " & exx.Message, vbExclamation, "ERROR")
                    End Try
                End If
            End Using

        Catch ex As Exception
            MsgBox("Error. " & ex.Message, vbExclamation, "ERROR")
        End Try

    End Sub

    Private Sub queryFormRefreshButton_Click(sender As Object, e As EventArgs) Handles queryFormRefreshButton.Click
        'Limpieza de textBox
        queryFormDataWeekTextBox.Clear()
        queryFormDataIdTextBox.Clear()
        queryFormDataFinalRefTextBox.Clear()
        queryFormDataRefTextBox.Clear()
        queryFormDataQuantityTextBox.Clear()
        queryFormDataScrapTextBox.Clear()
        queryFormDataManagerComboBox.SelectedIndex = -1
        queryFormDataShiftComboBox.SelectedIndex = -1
        queryFormDataLineTextBox.Clear()
        queryFormDataProcessComboBox.SelectedIndex = -1
        queryFormDataCommentTextBox.Clear()

        'Recarga de la tabla
        Me.Report_TableTableAdapter.Fill(Me.Registro_ProduccionDataSet.Report_Table)
    End Sub

    Private Sub queryFormDataClearTextBox()
        queryFormDataWeekTextBox.Clear()
        queryFormDataIdTextBox.Clear()
        queryFormDataFinalRefTextBox.Clear()
        queryFormDataRefTextBox.Clear()
        queryFormDataQuantityTextBox.Clear()
        queryFormDataScrapTextBox.Clear()
        queryFormDataManagerComboBox.SelectedIndex = -1
        queryFormDataShiftComboBox.SelectedIndex = -1
        queryFormDataLineTextBox.Clear()
        queryFormDataProcessComboBox.SelectedIndex = -1
        queryFormDataCommentTextBox.Clear()
    End Sub

    Private Sub queryFormDeleteButton_Click(sender As Object, e As EventArgs) Handles queryFormDeleteButton.Click

        'Comprobación de entrada seleccionada
        If queryFormDataIdTextBox.Text <> "" Then
            'Elimina la entrada correspondiente al ID seleccionado
            'ID que se elimina
            Dim idDelete As Integer
            idDelete = queryFormDataIdTextBox.Text

            'Cadena con los datos pertenecientes a la entrada a borrar
            Dim delData As String
            delData = "- Fecha: " & queryFormDataDatePicker.Value.ToString("dd/MM/yyyy") & vbCrLf
            delData = delData & "- Referencia: " & queryFormDataRefTextBox.Text & vbCrLf
            delData = delData & "- Cantidad: " & queryFormDataQuantityTextBox.Text & vbCrLf
            delData = delData & "- Scrap: " & queryFormDataScrapTextBox.Text & vbCrLf
            delData = delData & "- Proceso: " & queryFormDataProcessComboBox.Text & vbCrLf
            delData = delData & "- Turno: " & queryFormDataShiftComboBox.Text & vbCrLf
            delData = delData & "- Encargado: " & queryFormDataManagerComboBox.Text & vbCrLf
            delData = delData & "- Ref. Final: " & queryFormDataFinalRefTextBox.Text

            Dim confirmResult As DialogResult = MessageBox.Show("¿Está seguro de que desea eliminar el registro ID: " & idDelete & "?. Contiene los siguientes datos: " & vbCrLf & delData, "Eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirmResult = DialogResult.Yes Then
                Dim finalConfirmResult As DialogResult = MessageBox.Show("El registro será eliminado definitivamente. ¿Está seguro de que desea continuar?", "Eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If finalConfirmResult = DialogResult.Yes Then
                    Try
                        'Conexión con la base de datos
                        Dim conn As New OleDbConnection
                        conn = MainFunctions.connOleDbBuilder(MainFunctions.conStringBuilder)
                        Using conn
                            'Se abre conexión
                            conn.Open()

                            '------->COPIA DE SEGURIDAD
                            'Usuario que realiza la modificación
                            Dim user As String = SystemInformation.UserName

                            'Fecha en la que se realiza la modificación
                            Dim currentDate As String = DateTime.Now.ToString("dd/MM/yyyy")

                            'Cadena de consulta
                            Dim queryLogString As String
                            queryLogString = "INSERT INTO changelog_Report_Table" &
    "(log_Report_Id, log_Report_Reference, log_Report_Date, log_Report_Quantity, log_Report_Scrap, log_Report_SAGE, log_Report_Week, log_Report_Manager, log_Report_Shift, log_Report_Comments, log_Report_Process, log_Report_Line, log_Report_FinalRef, log_Report_AM, log_Date, log_Username) " &
    "Select Id, type_Reference, type_Date, type_Quantity, type_Scrap, type_SAGE, type_Week, type_Manager, type_Shift, type_Comments, type_Process, type_Line, type_FinalRef, type_AM, '" & currentDate & "', '" & user & "' FROM Report_Table WHERE Id = " & idDelete

                            'Cadena para añadir DELETED 
                            Dim delCommentString As String
                            delCommentString = "UPDATE Report_Table SET type_Comments = @Comments WHERE ID = " & idDelete

                            'Comando de las consultas
                            Dim logCmdQuery As New OleDbCommand(queryLogString, conn)
                            Dim delCommentCmdString As New OleDbCommand(delCommentString, conn)

                            'Variable Comentario #DELETED
                            delCommentCmdString.Parameters.AddWithValue("@Comments", queryFormDataCommentTextBox.Text & " #DELETED")

                            '------->ELIMINACION
                            'Cadena de consulta
                            Dim delStringQuery As String
                            delStringQuery = "DELETE FROM Report_Table WHERE ID = @ID"

                            'Comando de la consulta
                            Dim delCmdQuery As New OleDbCommand(delStringQuery, conn)
                            delCmdQuery.Parameters.AddWithValue("@ID", idDelete)

                            '------->EJECUCION DE CONSULTAS
                            delCommentCmdString.ExecuteNonQuery()
                            logCmdQuery.ExecuteNonQuery()
                            delCmdQuery.ExecuteNonQuery()
                        End Using
                        MessageBox.Show("Registro eliminado con éxito", "Registro eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        'Limpieza de textBox
                        queryFormDataClearTextBox()

                        'Recarga de tabla
                        Me.Report_TableTableAdapter.Fill(Me.Registro_ProduccionDataSet.Report_Table)

                    Catch ex As Exception
                        MessageBox.Show("ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
                Exit Sub
            Else
                Exit Sub
            End If
        Else
            MessageBox.Show("Primero debe seleccionar una entrada del registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
    End Sub

    'PROCEDIMIENTOS PARA DESACTIVAR EL SCROLL EN LAS COMBOBOX
    Public Sub QueryFormDataManagerComboBox_MouseWheel(sender As Object, e As MouseEventArgs) Handles queryFormDataManagerComboBox.MouseWheel
        'Manejar el evento MouseWheel para evitar que se propague
        Dim mwe As HandledMouseEventArgs = DirectCast(e, HandledMouseEventArgs)
        mwe.Handled = True
        'Este procedimiento se añade para evitar errores a la hora de cargar datos. Al mover la rueda del ratón se cambiaba el Manager
    End Sub

    Public Sub QueryFormShiftComboBox_MouseWheel(sender As Object, e As MouseEventArgs) Handles queryFormDataShiftComboBox.MouseWheel
        'Manejar el evento MouseWheel para evitar que se propague
        Dim mwe As HandledMouseEventArgs = DirectCast(e, HandledMouseEventArgs)
        mwe.Handled = True
        'Este procedimiento se añade para evitar errores a la hora de cargar datos. Al mover la rueda del ratón se cambiaba el Manager
    End Sub

    Public Sub QueryFormDataProcessComboBox_MouseWheel(sender As Object, e As MouseEventArgs) Handles queryFormDataProcessComboBox.MouseWheel
        'Manejar el evento MouseWheel para evitar que se propague
        Dim mwe As HandledMouseEventArgs = DirectCast(e, HandledMouseEventArgs)
        mwe.Handled = True
        'Este procedimiento se añade para evitar errores a la hora de cargar datos. Al mover la rueda del ratón se cambiaba el Manager
    End Sub

    Private Sub queryFormFullLoadButton_Click(sender As Object, e As EventArgs) Handles queryFormFullLoadButton.Click
        'Carga todos los datos en la tabla principal
        'Se pregunta antes al usuario'
        Dim confirmResult As DialogResult = MessageBox.Show("Se van a cargar tods los datos en la tabla principal. Dependiendo de la cantidad de registros, esto podría ralentizar su pc. ¿Está seguro de que desea continuar? ", "¿Continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirmResult = DialogResult.Yes Then
            DbQueryDataGridView.DataSource = Registro_ProduccionDataSet.Report_Table
        End If
    End Sub
End Class
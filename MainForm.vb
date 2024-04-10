'Se importan las librerías de conexión con la base de datos
Imports System.Data.OleDb

'-------------------------------------------------------
'-------------------->Espacios que se podrán eliminar<--------------------
Imports System.Data
Imports System.Data.SqlClient
'Imports System.Deployment.Application
'Imports System.Diagnostics.Eventing.Reader
'Imports System.DirectoryServices
'Imports System.Linq.Expressions
'Imports System.Runtime.Remoting.Channels
'Imports System.Security.Cryptography
'Imports System.Security.Policy
'Imports System.Windows.Forms.VisualStyles.VisualStyleElement
'Imports Prod_Report.Registro_ProduccionDataSetTableAdapters
'-------------------------------------------------------

Public Class MainForm
    'VARIABLES PRINCIPALES'
    Dim conn As OleDb.OleDbConnection
    Dim cmd As OleDb.OleDbCommand
    Dim temp_cmd As OleDb.OleDbCommand
    Dim query_cmd As OleDb.OleDbCommand
    Dim cache_cmd As OleDb.OleDbCommand

    'VERIFICACIÓN DE CONEXIÓN CON BASE DE DATOS'
    Private Sub DbConnectionPrep(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Registro_ProduccionDataSet.Active_Managers_Query' table. You can move, or remove it, as needed.
        Me.Active_Managers_QueryTableAdapter.Fill(Me.Registro_ProduccionDataSet.Active_Managers_Query)
        'TODO: This line of code loads data into the 'Registro_ProduccionDataSet.Managers_Table' table. You can move, or remove it, as needed.
        'TODO: This line of code loads data into the 'Registro_ProduccionDataSet.temp_Report_Table' table. You can move, or remove it, as needed.
        'Me.Temp_Report_TableTableAdapter.Fill(Me.Registro_ProduccionDataSet.temp_Report_Table)
        'OUTDATED
        '------------------------------------------------------
        ''Verifica si es posible realizar una conexión con la base de datos'
        'Dim dbProvider As String
        'Dim dbSource As String
        'dbProvider = "Provider=Microsoft.ACE.OLEDB.12.0;"
        'dbSource = "Data Source=\\n054fp03\DocCompartido2\Producción\021.- Registro Produccion\DB\Static\Registro_Produccion.accdb" 'VALOR A MODIFICAR SI CAMBIA LA RUTA'
        '------------------------------------------------------
        'Dim con As String
        'con = dbProvider & dbSource

        'con = MainFunctions.conStringBuilder()
        'conn = New OleDb.OleDbConnection(con)
        conn = MainFunctions.connOleDbBuilder(MainFunctions.conStringBuilder())

        Try
            conn.Open()
            'MsgBox("La conexión con la base de datos se ha efectuado correctamente", vbInformation, "Conexión establecida")
            conn.Close()

            'Registra el inicio de sesión en la tabla de login
            loginRecord()
        Catch ex As Exception
            MsgBox("Se ha producido un error durante la conexión con la base de datos: " & ex.Message, vbExclamation, "ERROR")
        End Try

    End Sub

    'LOADER PRINCIPAL DEL FORMULARIO'
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Registro_ProduccionDataSet1.temp_Report_Table' table. You can move, or remove it, as needed.
        'Me.Temp_Report_TableTableAdapter.Fill(Me.Registro_ProduccionDataSet1.temp_Report_Table)
        Me.Temp_Report_TableTableAdapter.Fill(Me.Registro_ProduccionDataSet.temp_Report_Table)
        'TODO: This line of code loads data into the 'Registro_ProduccionDataSet.Report_Table' table. You can move, or remove it, as needed.
        'Me.Report_TableTableAdapter.Fill(Me.Registro_ProduccionDataSet.Report_Table)
        'TODO: This line of code loads data into the 'Registro_ProduccionDataSet.ALL' table. You can move, or remove it, as needed.
        Me.ALLTableAdapter.Fill(Me.Registro_ProduccionDataSet.ALL)

        'Valores predeterminados de TextBox'
        refTextBox.Text = "Seleccionar de tabla"
        scrapTextBox.Text = 0
        buildNumberLabel.Text = "Build " & My.Application.Info.Version.ToString

        'Lista de managers desde la base de datos
        Me.Managers_TableTableAdapter.Fill(Me.Registro_ProduccionDataSet.Managers_Table)
        managerComboBox.SelectedIndex = -1 'Para que no muestre predeterminado ningún manager'

    End Sub

    'BOTÓN SALIR'
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Dim answer As Integer
        answer = MsgBox("¿Está seguro de que desea salir?. Los datos permanecerán en las tablas.", vbQuestion + vbYesNo + vbDefaultButton2, "¿Desea continuar?")
        If answer = vbYes Then
            conn.Close()
            Me.Close()
        End If
    End Sub

    'CERRAR FORMULARIO'
    Public Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim answer As Integer
        answer = MsgBox("¿Está seguro de que desea salir?. Los datos permanecerán en las tablas.", vbQuestion + vbYesNo + vbDefaultButton2, "¿Desea continuar?")
        If answer = vbNo Then
            e.Cancel = True
        End If
    End Sub

    'AÑADIR DATOS A BASE DE DATOS FINAL'
    Private Sub addDataButton_Click(sender As Object, e As EventArgs) Handles addDataButton.Click
        Try
            If (conn.State = ConnectionState.Closed) Then
                conn.Open()
            End If
            'Confirmación de ejecución
            Dim answer As Integer = MsgBox("Los datos serán guardados definitivamente en la base de datos. ¿Desea continuar? ", vbQuestion + vbYesNo + vbDefaultButton2, "¿Desea continuar?")
            If answer = vbYes Then
                'Volcado de datos de la tabla temporal en tabla principal
                Dim sql As String = "INSERT INTO Report_Table (type_Reference, type_Quantity, type_Date, type_SAGE, type_Week, type_Manager, type_Shift, type_Comments, type_Process, type_Line, type_FinalRef, type_Scrap, type_AM) SELECT temp_Reference, temp_Quantity, temp_Date, temp_Sage, temp_Week, temp_Manager, temp_Shift, temp_Comments, temp_Process, temp_Line, temp_FinalRef, temp_Scrap, temp_AM FROM temp_Report_Table"
                cmd = New OleDbCommand(sql, conn)
                cmd.ExecuteNonQuery()
                Dim sqlDelete As String = "DELETE FROM temp_Report_Table"
                Dim cmdDelete As New OleDbCommand(sqlDelete, conn)

                'Limpieza de la tabla temporal
                cmdDelete.ExecuteNonQuery()

                'Time Sleep de 2 segundos'
                Threading.Thread.Sleep(2000) 'Asegura que los datos son cargados correctamente antes de recargar el formulario'

                'Recarga del formulario
                MainForm_Load(sender, e)
            Else
                conn.Close()
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show("Error al agregar el registro: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    'CARGAR DATOS EN TABLA TEMPORAL'
    Private Sub loadDataButton_Click(sender As Object, e As EventArgs) Handles loadDataButton.Click
        Try
            conn.Close()
            conn.Open()

            'Variables Generales'
            Dim lastManagerName As String
            'Consulta SQL
            Dim temp_sql As String = "INSERT INTO temp_Report_Table (temp_Date, temp_Reference, temp_Quantity, temp_Sage, temp_Manager, temp_Shift, temp_Comments, temp_Process, temp_Line, temp_Week, temp_FinalRef, temp_Scrap, temp_AM) VALUES (@date, @reference, @quantity, @sage, @manager, @shift, @comments, @process, @line, @week, @finalRef, @scrap, @am)"
            'Database connection
            temp_cmd = New OleDbCommand(temp_sql, conn)
            'Date
            Dim dateSelected As DateTime = datePicker.Value
            Dim dateSelectedFormated As String = dateSelected.ToString("dd/MM/yyyy")
            temp_cmd.Parameters.AddWithValue("@date", dateSelectedFormated)
            'Reference
            temp_cmd.Parameters.AddWithValue("@reference", refTextBox.Text)
            refTextBox.Clear()
            'Quantity
            If IsNumeric(quantityTextBox.Text) Then
                temp_cmd.Parameters.AddWithValue("@quantity", CInt(quantityTextBox.Text))
                quantityTextBox.Clear()
            Else
                MessageBox.Show("ERROR. La cantidad debe ser un valor numérico", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                quantityTextBox.Clear()
                Exit Sub
            End If
            'Sage
            temp_cmd.Parameters.AddWithValue("@sage", sageCheckBox.Checked)
            'Manager
            If managerComboBox.Text <> "" Then
                temp_cmd.Parameters.AddWithValue("@manager", managerComboBox.Text)
                'Guarda el último manager usado para volver a ponerlo en la listBox. (Al recargar el formulario se borra)
                lastManagerName = managerComboBox.Text
            Else
                MessageBox.Show("ERROR. El valor de 'Encargado' no puede estar vacío", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            'Shift
            If shiftComboBox.Text <> "" Then
                temp_cmd.Parameters.AddWithValue("@shift", shiftComboBox.Text)
            Else
                MessageBox.Show("ERROR. El valor de 'Turno' no puede estar vacío", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            'Comments
            temp_cmd.Parameters.AddWithValue("@comments", commentsTextBox.Text)
            commentsTextBox.Clear()
            'Process
            temp_cmd.Parameters.AddWithValue("@process", processTextBox.Text)
            processTextBox.Clear()
            'Line
            If IsNumeric(lineTextBox.Text) Then
                temp_cmd.Parameters.AddWithValue("@line", lineTextBox.Text)
                lineTextBox.Clear()
            Else
                MsgBox("ERROR. La línea debe corresponder a un valor numérico", MessageBoxIcon.Warning)
                lineTextBox.Clear()
                Exit Sub
            End If
            'Week'
            temp_cmd.Parameters.AddWithValue("@week", MainFunctions.WeekNumber(datePicker.Value))
            'FinalRef'
            temp_cmd.Parameters.AddWithValue("@finalRef", finalRefTextBox.Text)
            finalRefTextBox.Clear()
            'Scrap'
            If IsNumeric(scrapTextBox.Text) Then
                temp_cmd.Parameters.AddWithValue("@scrap", CInt(scrapTextBox.Text))
                scrapTextBox.Clear()
            Else
                MsgBox("ERROR. La chatarra debe ser un valor numérico", MessageBoxIcon.Warning)
                scrapTextBox.Clear()
                Exit Sub
            End If
            'AM Check'
            temp_cmd.Parameters.AddWithValue("@am", amRefCheckBox.Checked)

            'Limpia el formulario de AM por si ha sido usado
            AftermarketReportForm.amTextBoxClear()

            temp_cmd.ExecuteNonQuery()
            searchBox.Clear()
            Threading.Thread.Sleep(1000)
            'MessageBox.Show("Cargado correctamente")
            'MainForm_Load(sender, e)
            conn.Close()
            MainForm_Load(sender, e)
            'Vuelve a colocar el nombre de Manager en la listBox para que no se borre
            managerComboBox.Text = lastManagerName
        Catch ex As Exception
            MessageBox.Show("Error al cargar el registro: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    'ETIQUETA BESZ CON FECHA ACTUALIZADA'
    Private Sub beszLabelBuilder() Handles MyBase.Load
        beszLabel.Text = "BESZ " & Year(Date.Now)
    End Sub

    'VARIABLES PARA EL BUSCADOR DE REFERENCIAS
    Dim dateSearchAdapter As OleDbDataAdapter
    Dim tableSearch As DataTable
    Dim sqlSearch As String

    'BUSCADOR DE REFERENCIAS EN LA TABLA PRINCIPAL
    Private Sub searchData(sqlSearch As String, dtg As DataGridView)
        Try
            cmd = New OleDbCommand
            dateSearchAdapter = New OleDbDataAdapter
            tableSearch = New DataTable

            cmd.Connection = conn
            cmd.CommandText = sqlSearch

            dateSearchAdapter.SelectCommand = cmd
            dateSearchAdapter.Fill(tableSearch)

            dtg.DataSource = tableSearch
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dateSearchAdapter.Dispose()
        End Try

    End Sub

    'RUTINA AUTOMÁTICA DE BUSCADOR DE REFERENCIAS'
    Private Sub searchBox_TextChanged(sender As Object, e As EventArgs) Handles searchBox.TextChanged
        'sqlSearch = "SELECT * FROM BENDING WHERE Reference LIKE '%" & searchBox.Text & "%'"
        sqlSearch = "SELECT * FROM ALL_Query WHERE Reference LIKE '%" & searchBox.Text & "%'"
        searchData(sqlSearch, procDataGridView)
    End Sub

    'COPIA DE DATO SELECCIONADO EN TABLA A TEXTBOX CORRESPONDIENTE'
    Private Sub procDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles procDataGridView.CellContentDoubleClick
        Try
            refTextBox.Text = procDataGridView.Rows(e.RowIndex).Cells(0).Value
            processTextBox.Text = procDataGridView.Rows(e.RowIndex).Cells(2).Value
            If procDataGridView.Rows(e.RowIndex).Cells(3).Value = "" Then
                MsgBox("La referencia seleccionada no tiene una línea de fabricación asociada en la base de datos. Introduzca el valor manualmente antes de cargar los datos. (Valor 0 predeterminado)", MessageBoxIcon.Warning)
                lineTextBox.Text = "0"
            Else
                lineTextBox.Text = procDataGridView.Rows(e.RowIndex).Cells(3).Value
            End If
            sageCheckBox.Checked = True
            amRefCheckBox.Checked = False
            finalRefTextBox.Text = procDataGridView.Rows(e.RowIndex).Cells(1).Value
        Catch ex As Exception
            MsgBox("Se ha producido un error en la copia de los datos de la tabla a las celdas. " & ex.Message, vbExclamation, "ERROR")
            refTextBox.Clear()
            processTextBox.Clear()
            lineTextBox.Clear()
            finalRefTextBox.Clear()
        End Try
    End Sub

    'BOTÓN ELIMINAR ENTRADA
    Private Sub deleteDataButton_Click(sender As Object, e As EventArgs) Handles deleteDataButton.Click
        'Elimina la entrada correspondiente al ID pasado por pantalla'
        Dim idDelete As Integer
        Dim userInput As String = InputBox("Introduzca el ID que desea eliminar: ")
        If Integer.TryParse(userInput, idDelete) Then
            Dim confirmResult As DialogResult = MessageBox.Show("¿Estás seguro de que deseas eliminar la entrada con ID" & idDelete & "?", "Confirmar eliminación", MessageBoxButtons.YesNo)
            If confirmResult = DialogResult.Yes Then
                Try
                    'Conexión con la base de datos'
                    conn.Open()

                    'Creación de la consulta SQL para eliminar la fila
                    Dim sqlDelete As String = "DELETE FROM temp_Report_Table WHERE ID = @ID"
                    Using cmd As New OleDbCommand(sqlDelete, conn)
                        cmd.Parameters.AddWithValue("@ID", idDelete)

                        'Ejecuta la consulta'
                        cmd.ExecuteNonQuery()
                    End Using
                    MessageBox.Show("Entrada eliminada correctamente")
                    MainForm_Load(sender, e)
                Catch ex As Exception
                    MessageBox.Show("Error al eliminar la entrada: " & ex.Message)
                Finally
                    conn.Close()
                End Try
            End If
        Else
            MessageBox.Show("ID no válido. Por favor, introduce un número entero.")
        End If

    End Sub

    'CHECK CELDAS VACÍAS'
    Dim checkOkLogo As Image = My.Resources.OK_Logo
    Dim checkNokLogo As Image = My.Resources.NOK_Logo

    Private Sub refCheckBoxLogo_TextChanged(sender As Object, e As EventArgs) Handles refTextBox.TextChanged
        If refTextBox.Text = "" Then
            refCheckBoxLogo.Image = checkNokLogo
        Else
            refCheckBoxLogo.Image = checkOkLogo
        End If
    End Sub

    Private Sub procCheckBoxLogo_TextChanged(sender As Object, e As EventArgs) Handles processTextBox.TextChanged
        If processTextBox.Text = "" Then
            procCheckBoxLogo.Image = My.Resources.NOK_Logo
        Else
            procCheckBoxLogo.Image = My.Resources.OK_Logo
        End If
    End Sub

    Private Sub quantityCheckBoxLogo_TextChanged(sender As Object, e As EventArgs) Handles quantityTextBox.TextChanged
        If quantityTextBox.Text = "" Then
            quantityCheckBoxLogo.Image = checkNokLogo
        Else
            quantityCheckBoxLogo.Image = checkOkLogo
        End If
    End Sub

    Private Sub lineCheckBoxLogo_TextChanged(sender As Object, e As EventArgs) Handles lineTextBox.TextChanged
        If lineTextBox.Text = "" Then
            lineCheckBoxLogo.Image = checkNokLogo
        Else
            lineCheckBoxLogo.Image = checkOkLogo
        End If
    End Sub

    Private Sub finalRefCheckBoxLogo_TextChanged(sender As Object, e As EventArgs) Handles finalRefTextBox.TextChanged
        If finalRefTextBox.Text = "" Then
            finalRefCheckBoxLogo.Image = checkNokLogo
        Else
            finalRefCheckBoxLogo.Image = checkOkLogo
        End If
    End Sub

    Private Sub scrapCheckBoxLogo_TextChanged(sender As Object, e As EventArgs) Handles scrapTextBox.TextChanged
        If scrapTextBox.Text = "" Then
            scrapCheckBoxLogo.Image = checkNokLogo
        Else
            scrapCheckBoxLogo.Image = checkOkLogo
        End If
    End Sub
    Private Sub updateFormButton_Click(sender As Object, e As EventArgs) Handles updateFormButton.Click
        MainForm_Load(sender, e)
    End Sub

    Private Sub toolsFormButton_Click(sender As Object, e As EventArgs) Handles toolsFormButton.Click
        ToolsForm.ShowDialog()
    End Sub

    Private Sub aftermarket_Button_Click(sender As Object, e As EventArgs) Handles aftermarket_Button.Click
        AftermarketReportForm.ShowDialog()
    End Sub

    'Email de contacto'
    Private Sub labelMailContact_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles labelMailContact.LinkClicked
        Try
            System.Diagnostics.Process.Start(String.Format("mailto:{0}", "alberto.gonzaga@bosal.com" & ";"))
        Catch ex As Exception
            MessageBox.Show("ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Registro en tabla LOGIN
    Public Sub loginRecord()
        'Registra el inicio de sesión en la tabla de login.
        'Se llama al procedimiento desde el loader inicial de comprobación de conexión con la base de datos
        Try
            Dim loginUsername As String
            Dim loginHostname As String
            Dim loginIpAddress As String
            Dim loginDate As String
            Dim loginTime As String

            loginUsername = MainFunctions.GetUsername()
            loginHostname = MainFunctions.GetHostname()
            loginIpAddress = MainFunctions.GetIpAddress()
            loginDate = DateTime.Now.ToString("dd/MM/yyyy")
            loginTime = DateTime.Now.ToString("HH:mm:ss")

            Dim conn As OleDbConnection
            conn = MainFunctions.connOleDbBuilder(MainFunctions.conStringBuilder)

            Using conn
                conn.Open()

                Dim loginDataRecordString As String

                'Cadena para el comando de SQL
                loginDataRecordString = "INSERT INTO Login_Report_Table (type_Date, type_Time, type_Username, type_Hostname, type_IP) VALUES (@Date, @Time, @Username, @Hostname, @IP)"

                'Comando de SQL
                Dim modifyCmd As New OleDbCommand(loginDataRecordString, conn)

                'Asignar datos a variables'
                modifyCmd.Parameters.AddWithValue("@Date", loginDate)
                modifyCmd.Parameters.AddWithValue("@Time", loginTime)
                modifyCmd.Parameters.AddWithValue("@Username", loginUsername)
                modifyCmd.Parameters.AddWithValue("@Hostname", loginHostname)
                modifyCmd.Parameters.AddWithValue("@IP", loginIpAddress)

                'Ejecutamos la consulta'
                modifyCmd.ExecuteNonQuery()

            End Using


        Catch ex As Exception
            MessageBox.Show("Error al registrar el login. " & ex.Message, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class




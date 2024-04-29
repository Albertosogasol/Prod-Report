<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DbQueryForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DbQueryForm))
        Me.queryFormFilterInitDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.queryFormFilterInitDateLabel = New System.Windows.Forms.Label()
        Me.queryFormFilterEndDateLabel = New System.Windows.Forms.Label()
        Me.queryFormFilterEndDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.queryFormFilterRefTextBox = New System.Windows.Forms.TextBox()
        Me.queryFormFilterRefLabel = New System.Windows.Forms.Label()
        Me.queryFormFilterShiftComboBox = New System.Windows.Forms.ComboBox()
        Me.queryFormFilterShiftLabel = New System.Windows.Forms.Label()
        Me.queryFormFilterGroupBox = New System.Windows.Forms.GroupBox()
        Me.queryFormFilterCleanButton = New System.Windows.Forms.Button()
        Me.queryFormFilterSearchButton = New System.Windows.Forms.Button()
        Me.queryFormFilterWeekTextBox = New System.Windows.Forms.TextBox()
        Me.queryFormFilterWeekLabel = New System.Windows.Forms.Label()
        Me.queryFormFilterManagerLabel = New System.Windows.Forms.Label()
        Me.queryFormFilterManagerComboBox = New System.Windows.Forms.ComboBox()
        Me.DbQueryDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeReferenceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeQuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeScrapDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeSAGEDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TypeWeekDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeManagerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeShiftDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeProcessDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeLineDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeCommentsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeFinalRefDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.type_AM = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ReportTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Registro_ProduccionDataSet = New Prod_Report.Registro_ProduccionDataSet()
        Me.queryFormDataGroupBox = New System.Windows.Forms.GroupBox()
        Me.queryFormDeleteButton = New System.Windows.Forms.Button()
        Me.queryFormDataAM = New System.Windows.Forms.CheckBox()
        Me.queryFormModifyButton = New System.Windows.Forms.Button()
        Me.queryFormDataFinalRefTextBox = New System.Windows.Forms.TextBox()
        Me.queryFormDataFinalRefLabel = New System.Windows.Forms.Label()
        Me.queryFormDataIdTextBox = New System.Windows.Forms.TextBox()
        Me.queryFormDataIdLabel = New System.Windows.Forms.Label()
        Me.queryFormDataManagerComboBox = New System.Windows.Forms.ComboBox()
        Me.ManagersTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.queryFormDataCommentTextBox = New System.Windows.Forms.TextBox()
        Me.queryFormDataCommentLabel = New System.Windows.Forms.Label()
        Me.queryFormDataProcessLabel = New System.Windows.Forms.Label()
        Me.queryFormDataLineTextBox = New System.Windows.Forms.TextBox()
        Me.queryFormDataProcessComboBox = New System.Windows.Forms.ComboBox()
        Me.queryFormDataLineLabel = New System.Windows.Forms.Label()
        Me.queryFormDataShiftLabel = New System.Windows.Forms.Label()
        Me.queryFormDataShiftComboBox = New System.Windows.Forms.ComboBox()
        Me.queryFormDataManagerLabel = New System.Windows.Forms.Label()
        Me.queryFormDataSage = New System.Windows.Forms.CheckBox()
        Me.queryFormDataScrapTextBox = New System.Windows.Forms.TextBox()
        Me.queryFormDataScrapLabel = New System.Windows.Forms.Label()
        Me.queryFormDataQuantityTextBox = New System.Windows.Forms.TextBox()
        Me.queryFormDataQuantityLabel = New System.Windows.Forms.Label()
        Me.queryFormDataWeekTextBox = New System.Windows.Forms.TextBox()
        Me.queryFormDataWeekLabel = New System.Windows.Forms.Label()
        Me.queryFormDataDateLabel = New System.Windows.Forms.Label()
        Me.queryFormDataRefTextBox = New System.Windows.Forms.TextBox()
        Me.queryFormDataRefLabel = New System.Windows.Forms.Label()
        Me.queryFormDataDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.queryFormCloseButton = New System.Windows.Forms.Button()
        Me.Report_TableTableAdapter = New Prod_Report.Registro_ProduccionDataSetTableAdapters.Report_TableTableAdapter()
        Me.queryFormRefreshButton = New System.Windows.Forms.Button()
        Me.Managers_TableTableAdapter = New Prod_Report.Registro_ProduccionDataSetTableAdapters.Managers_TableTableAdapter()
        Me.ManagersTableReportTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.queryFormFilterGroupBox.SuspendLayout()
        CType(Me.DbQueryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Registro_ProduccionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.queryFormDataGroupBox.SuspendLayout()
        CType(Me.ManagersTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ManagersTableReportTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'queryFormFilterInitDatePicker
        '
        Me.queryFormFilterInitDatePicker.CustomFormat = ""
        Me.queryFormFilterInitDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.queryFormFilterInitDatePicker.Location = New System.Drawing.Point(9, 31)
        Me.queryFormFilterInitDatePicker.Name = "queryFormFilterInitDatePicker"
        Me.queryFormFilterInitDatePicker.Size = New System.Drawing.Size(96, 20)
        Me.queryFormFilterInitDatePicker.TabIndex = 0
        Me.queryFormFilterInitDatePicker.Value = New Date(2023, 10, 16, 0, 0, 0, 0)
        '
        'queryFormFilterInitDateLabel
        '
        Me.queryFormFilterInitDateLabel.AutoSize = True
        Me.queryFormFilterInitDateLabel.Location = New System.Drawing.Point(6, 15)
        Me.queryFormFilterInitDateLabel.Name = "queryFormFilterInitDateLabel"
        Me.queryFormFilterInitDateLabel.Size = New System.Drawing.Size(67, 13)
        Me.queryFormFilterInitDateLabel.TabIndex = 1
        Me.queryFormFilterInitDateLabel.Text = "Fecha Inicial"
        '
        'queryFormFilterEndDateLabel
        '
        Me.queryFormFilterEndDateLabel.AutoSize = True
        Me.queryFormFilterEndDateLabel.Location = New System.Drawing.Point(121, 15)
        Me.queryFormFilterEndDateLabel.Name = "queryFormFilterEndDateLabel"
        Me.queryFormFilterEndDateLabel.Size = New System.Drawing.Size(62, 13)
        Me.queryFormFilterEndDateLabel.TabIndex = 3
        Me.queryFormFilterEndDateLabel.Text = "Fecha Final"
        '
        'queryFormFilterEndDatePicker
        '
        Me.queryFormFilterEndDatePicker.CustomFormat = ""
        Me.queryFormFilterEndDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.queryFormFilterEndDatePicker.Location = New System.Drawing.Point(124, 31)
        Me.queryFormFilterEndDatePicker.Name = "queryFormFilterEndDatePicker"
        Me.queryFormFilterEndDatePicker.Size = New System.Drawing.Size(96, 20)
        Me.queryFormFilterEndDatePicker.TabIndex = 2
        Me.queryFormFilterEndDatePicker.Value = New Date(2023, 11, 27, 13, 46, 50, 0)
        '
        'queryFormFilterRefTextBox
        '
        Me.queryFormFilterRefTextBox.Location = New System.Drawing.Point(9, 74)
        Me.queryFormFilterRefTextBox.Name = "queryFormFilterRefTextBox"
        Me.queryFormFilterRefTextBox.Size = New System.Drawing.Size(96, 20)
        Me.queryFormFilterRefTextBox.TabIndex = 4
        '
        'queryFormFilterRefLabel
        '
        Me.queryFormFilterRefLabel.AutoSize = True
        Me.queryFormFilterRefLabel.Location = New System.Drawing.Point(6, 58)
        Me.queryFormFilterRefLabel.Name = "queryFormFilterRefLabel"
        Me.queryFormFilterRefLabel.Size = New System.Drawing.Size(59, 13)
        Me.queryFormFilterRefLabel.TabIndex = 5
        Me.queryFormFilterRefLabel.Text = "Referencia"
        '
        'queryFormFilterShiftComboBox
        '
        Me.queryFormFilterShiftComboBox.FormattingEnabled = True
        Me.queryFormFilterShiftComboBox.Items.AddRange(New Object() {"", "A", "B", "C"})
        Me.queryFormFilterShiftComboBox.Location = New System.Drawing.Point(124, 122)
        Me.queryFormFilterShiftComboBox.Name = "queryFormFilterShiftComboBox"
        Me.queryFormFilterShiftComboBox.Size = New System.Drawing.Size(96, 21)
        Me.queryFormFilterShiftComboBox.TabIndex = 6
        '
        'queryFormFilterShiftLabel
        '
        Me.queryFormFilterShiftLabel.AutoSize = True
        Me.queryFormFilterShiftLabel.Location = New System.Drawing.Point(121, 106)
        Me.queryFormFilterShiftLabel.Name = "queryFormFilterShiftLabel"
        Me.queryFormFilterShiftLabel.Size = New System.Drawing.Size(35, 13)
        Me.queryFormFilterShiftLabel.TabIndex = 7
        Me.queryFormFilterShiftLabel.Text = "Turno"
        '
        'queryFormFilterGroupBox
        '
        Me.queryFormFilterGroupBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.queryFormFilterGroupBox.Controls.Add(Me.queryFormFilterCleanButton)
        Me.queryFormFilterGroupBox.Controls.Add(Me.queryFormFilterSearchButton)
        Me.queryFormFilterGroupBox.Controls.Add(Me.queryFormFilterWeekTextBox)
        Me.queryFormFilterGroupBox.Controls.Add(Me.queryFormFilterWeekLabel)
        Me.queryFormFilterGroupBox.Controls.Add(Me.queryFormFilterManagerLabel)
        Me.queryFormFilterGroupBox.Controls.Add(Me.queryFormFilterManagerComboBox)
        Me.queryFormFilterGroupBox.Controls.Add(Me.queryFormFilterInitDateLabel)
        Me.queryFormFilterGroupBox.Controls.Add(Me.queryFormFilterShiftLabel)
        Me.queryFormFilterGroupBox.Controls.Add(Me.queryFormFilterEndDatePicker)
        Me.queryFormFilterGroupBox.Controls.Add(Me.queryFormFilterRefTextBox)
        Me.queryFormFilterGroupBox.Controls.Add(Me.queryFormFilterRefLabel)
        Me.queryFormFilterGroupBox.Controls.Add(Me.queryFormFilterInitDatePicker)
        Me.queryFormFilterGroupBox.Controls.Add(Me.queryFormFilterShiftComboBox)
        Me.queryFormFilterGroupBox.Controls.Add(Me.queryFormFilterEndDateLabel)
        Me.queryFormFilterGroupBox.Location = New System.Drawing.Point(722, 13)
        Me.queryFormFilterGroupBox.Name = "queryFormFilterGroupBox"
        Me.queryFormFilterGroupBox.Size = New System.Drawing.Size(319, 175)
        Me.queryFormFilterGroupBox.TabIndex = 8
        Me.queryFormFilterGroupBox.TabStop = False
        Me.queryFormFilterGroupBox.Text = "Filtro"
        '
        'queryFormFilterCleanButton
        '
        Me.queryFormFilterCleanButton.Location = New System.Drawing.Point(235, 115)
        Me.queryFormFilterCleanButton.Name = "queryFormFilterCleanButton"
        Me.queryFormFilterCleanButton.Size = New System.Drawing.Size(69, 30)
        Me.queryFormFilterCleanButton.TabIndex = 13
        Me.queryFormFilterCleanButton.Text = "Limpiar"
        Me.queryFormFilterCleanButton.UseVisualStyleBackColor = True
        '
        'queryFormFilterSearchButton
        '
        Me.queryFormFilterSearchButton.Location = New System.Drawing.Point(235, 65)
        Me.queryFormFilterSearchButton.Name = "queryFormFilterSearchButton"
        Me.queryFormFilterSearchButton.Size = New System.Drawing.Size(69, 30)
        Me.queryFormFilterSearchButton.TabIndex = 12
        Me.queryFormFilterSearchButton.Text = "Filtrar"
        Me.queryFormFilterSearchButton.UseVisualStyleBackColor = True
        '
        'queryFormFilterWeekTextBox
        '
        Me.queryFormFilterWeekTextBox.Location = New System.Drawing.Point(124, 74)
        Me.queryFormFilterWeekTextBox.Name = "queryFormFilterWeekTextBox"
        Me.queryFormFilterWeekTextBox.Size = New System.Drawing.Size(96, 20)
        Me.queryFormFilterWeekTextBox.TabIndex = 10
        '
        'queryFormFilterWeekLabel
        '
        Me.queryFormFilterWeekLabel.AutoSize = True
        Me.queryFormFilterWeekLabel.Location = New System.Drawing.Point(121, 58)
        Me.queryFormFilterWeekLabel.Name = "queryFormFilterWeekLabel"
        Me.queryFormFilterWeekLabel.Size = New System.Drawing.Size(46, 13)
        Me.queryFormFilterWeekLabel.TabIndex = 11
        Me.queryFormFilterWeekLabel.Text = "Semana"
        '
        'queryFormFilterManagerLabel
        '
        Me.queryFormFilterManagerLabel.AutoSize = True
        Me.queryFormFilterManagerLabel.Location = New System.Drawing.Point(6, 106)
        Me.queryFormFilterManagerLabel.Name = "queryFormFilterManagerLabel"
        Me.queryFormFilterManagerLabel.Size = New System.Drawing.Size(59, 13)
        Me.queryFormFilterManagerLabel.TabIndex = 9
        Me.queryFormFilterManagerLabel.Text = "Encargado"
        '
        'queryFormFilterManagerComboBox
        '
        Me.queryFormFilterManagerComboBox.DataSource = Me.ManagersTableBindingSource
        Me.queryFormFilterManagerComboBox.DisplayMember = "type_Manager"
        Me.queryFormFilterManagerComboBox.FormattingEnabled = True
        Me.queryFormFilterManagerComboBox.Location = New System.Drawing.Point(9, 122)
        Me.queryFormFilterManagerComboBox.Name = "queryFormFilterManagerComboBox"
        Me.queryFormFilterManagerComboBox.Size = New System.Drawing.Size(96, 21)
        Me.queryFormFilterManagerComboBox.TabIndex = 8
        '
        'DbQueryDataGridView
        '
        Me.DbQueryDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DbQueryDataGridView.AutoGenerateColumns = False
        Me.DbQueryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DbQueryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.TypeDateDataGridViewTextBoxColumn, Me.TypeReferenceDataGridViewTextBoxColumn, Me.TypeQuantityDataGridViewTextBoxColumn, Me.TypeScrapDataGridViewTextBoxColumn, Me.TypeSAGEDataGridViewCheckBoxColumn, Me.TypeWeekDataGridViewTextBoxColumn, Me.TypeManagerDataGridViewTextBoxColumn, Me.TypeShiftDataGridViewTextBoxColumn, Me.TypeProcessDataGridViewTextBoxColumn, Me.TypeLineDataGridViewTextBoxColumn, Me.TypeCommentsDataGridViewTextBoxColumn, Me.TypeFinalRefDataGridViewTextBoxColumn, Me.type_AM})
        Me.DbQueryDataGridView.DataSource = Me.ReportTableBindingSource
        Me.DbQueryDataGridView.Location = New System.Drawing.Point(13, 293)
        Me.DbQueryDataGridView.Name = "DbQueryDataGridView"
        Me.DbQueryDataGridView.RowHeadersVisible = False
        Me.DbQueryDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DbQueryDataGridView.Size = New System.Drawing.Size(1028, 340)
        Me.DbQueryDataGridView.TabIndex = 9
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.IdDataGridViewTextBoxColumn.Width = 40
        '
        'TypeDateDataGridViewTextBoxColumn
        '
        Me.TypeDateDataGridViewTextBoxColumn.DataPropertyName = "type_Date"
        Me.TypeDateDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.TypeDateDataGridViewTextBoxColumn.Name = "TypeDateDataGridViewTextBoxColumn"
        '
        'TypeReferenceDataGridViewTextBoxColumn
        '
        Me.TypeReferenceDataGridViewTextBoxColumn.DataPropertyName = "type_Reference"
        Me.TypeReferenceDataGridViewTextBoxColumn.HeaderText = "Referencia"
        Me.TypeReferenceDataGridViewTextBoxColumn.Name = "TypeReferenceDataGridViewTextBoxColumn"
        Me.TypeReferenceDataGridViewTextBoxColumn.Width = 80
        '
        'TypeQuantityDataGridViewTextBoxColumn
        '
        Me.TypeQuantityDataGridViewTextBoxColumn.DataPropertyName = "type_Quantity"
        Me.TypeQuantityDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.TypeQuantityDataGridViewTextBoxColumn.Name = "TypeQuantityDataGridViewTextBoxColumn"
        Me.TypeQuantityDataGridViewTextBoxColumn.Width = 80
        '
        'TypeScrapDataGridViewTextBoxColumn
        '
        Me.TypeScrapDataGridViewTextBoxColumn.DataPropertyName = "type_Scrap"
        Me.TypeScrapDataGridViewTextBoxColumn.HeaderText = "Scrap"
        Me.TypeScrapDataGridViewTextBoxColumn.Name = "TypeScrapDataGridViewTextBoxColumn"
        Me.TypeScrapDataGridViewTextBoxColumn.Width = 80
        '
        'TypeSAGEDataGridViewCheckBoxColumn
        '
        Me.TypeSAGEDataGridViewCheckBoxColumn.DataPropertyName = "type_SAGE"
        Me.TypeSAGEDataGridViewCheckBoxColumn.HeaderText = "SAGE"
        Me.TypeSAGEDataGridViewCheckBoxColumn.Name = "TypeSAGEDataGridViewCheckBoxColumn"
        Me.TypeSAGEDataGridViewCheckBoxColumn.Width = 50
        '
        'TypeWeekDataGridViewTextBoxColumn
        '
        Me.TypeWeekDataGridViewTextBoxColumn.DataPropertyName = "type_Week"
        Me.TypeWeekDataGridViewTextBoxColumn.HeaderText = "Semana"
        Me.TypeWeekDataGridViewTextBoxColumn.Name = "TypeWeekDataGridViewTextBoxColumn"
        Me.TypeWeekDataGridViewTextBoxColumn.Width = 80
        '
        'TypeManagerDataGridViewTextBoxColumn
        '
        Me.TypeManagerDataGridViewTextBoxColumn.DataPropertyName = "type_Manager"
        Me.TypeManagerDataGridViewTextBoxColumn.HeaderText = "Encargado"
        Me.TypeManagerDataGridViewTextBoxColumn.Name = "TypeManagerDataGridViewTextBoxColumn"
        '
        'TypeShiftDataGridViewTextBoxColumn
        '
        Me.TypeShiftDataGridViewTextBoxColumn.DataPropertyName = "type_Shift"
        Me.TypeShiftDataGridViewTextBoxColumn.HeaderText = "Turno"
        Me.TypeShiftDataGridViewTextBoxColumn.Name = "TypeShiftDataGridViewTextBoxColumn"
        Me.TypeShiftDataGridViewTextBoxColumn.Width = 60
        '
        'TypeProcessDataGridViewTextBoxColumn
        '
        Me.TypeProcessDataGridViewTextBoxColumn.DataPropertyName = "type_Process"
        Me.TypeProcessDataGridViewTextBoxColumn.HeaderText = "Proceso"
        Me.TypeProcessDataGridViewTextBoxColumn.Name = "TypeProcessDataGridViewTextBoxColumn"
        '
        'TypeLineDataGridViewTextBoxColumn
        '
        Me.TypeLineDataGridViewTextBoxColumn.DataPropertyName = "type_Line"
        Me.TypeLineDataGridViewTextBoxColumn.HeaderText = "Línea"
        Me.TypeLineDataGridViewTextBoxColumn.Name = "TypeLineDataGridViewTextBoxColumn"
        Me.TypeLineDataGridViewTextBoxColumn.Width = 50
        '
        'TypeCommentsDataGridViewTextBoxColumn
        '
        Me.TypeCommentsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TypeCommentsDataGridViewTextBoxColumn.DataPropertyName = "type_Comments"
        Me.TypeCommentsDataGridViewTextBoxColumn.HeaderText = "Comentarios"
        Me.TypeCommentsDataGridViewTextBoxColumn.Name = "TypeCommentsDataGridViewTextBoxColumn"
        '
        'TypeFinalRefDataGridViewTextBoxColumn
        '
        Me.TypeFinalRefDataGridViewTextBoxColumn.DataPropertyName = "type_FinalRef"
        Me.TypeFinalRefDataGridViewTextBoxColumn.HeaderText = "Ref. Final"
        Me.TypeFinalRefDataGridViewTextBoxColumn.Name = "TypeFinalRefDataGridViewTextBoxColumn"
        '
        'type_AM
        '
        Me.type_AM.DataPropertyName = "type_AM"
        Me.type_AM.HeaderText = "type_AM"
        Me.type_AM.Name = "type_AM"
        Me.type_AM.Visible = False
        '
        'ReportTableBindingSource
        '
        Me.ReportTableBindingSource.DataMember = "Report_Table"
        Me.ReportTableBindingSource.DataSource = Me.Registro_ProduccionDataSet
        '
        'Registro_ProduccionDataSet
        '
        Me.Registro_ProduccionDataSet.DataSetName = "Registro_ProduccionDataSet"
        Me.Registro_ProduccionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'queryFormDataGroupBox
        '
        Me.queryFormDataGroupBox.Controls.Add(Me.queryFormDeleteButton)
        Me.queryFormDataGroupBox.Controls.Add(Me.queryFormDataAM)
        Me.queryFormDataGroupBox.Controls.Add(Me.queryFormModifyButton)
        Me.queryFormDataGroupBox.Controls.Add(Me.queryFormDataFinalRefTextBox)
        Me.queryFormDataGroupBox.Controls.Add(Me.queryFormDataFinalRefLabel)
        Me.queryFormDataGroupBox.Controls.Add(Me.queryFormDataIdTextBox)
        Me.queryFormDataGroupBox.Controls.Add(Me.queryFormDataIdLabel)
        Me.queryFormDataGroupBox.Controls.Add(Me.queryFormDataManagerComboBox)
        Me.queryFormDataGroupBox.Controls.Add(Me.queryFormDataCommentTextBox)
        Me.queryFormDataGroupBox.Controls.Add(Me.queryFormDataCommentLabel)
        Me.queryFormDataGroupBox.Controls.Add(Me.queryFormDataProcessLabel)
        Me.queryFormDataGroupBox.Controls.Add(Me.queryFormDataLineTextBox)
        Me.queryFormDataGroupBox.Controls.Add(Me.queryFormDataProcessComboBox)
        Me.queryFormDataGroupBox.Controls.Add(Me.queryFormDataLineLabel)
        Me.queryFormDataGroupBox.Controls.Add(Me.queryFormDataShiftLabel)
        Me.queryFormDataGroupBox.Controls.Add(Me.queryFormDataShiftComboBox)
        Me.queryFormDataGroupBox.Controls.Add(Me.queryFormDataManagerLabel)
        Me.queryFormDataGroupBox.Controls.Add(Me.queryFormDataSage)
        Me.queryFormDataGroupBox.Controls.Add(Me.queryFormDataScrapTextBox)
        Me.queryFormDataGroupBox.Controls.Add(Me.queryFormDataScrapLabel)
        Me.queryFormDataGroupBox.Controls.Add(Me.queryFormDataQuantityTextBox)
        Me.queryFormDataGroupBox.Controls.Add(Me.queryFormDataQuantityLabel)
        Me.queryFormDataGroupBox.Controls.Add(Me.queryFormDataWeekTextBox)
        Me.queryFormDataGroupBox.Controls.Add(Me.queryFormDataWeekLabel)
        Me.queryFormDataGroupBox.Controls.Add(Me.queryFormDataDateLabel)
        Me.queryFormDataGroupBox.Controls.Add(Me.queryFormDataRefTextBox)
        Me.queryFormDataGroupBox.Controls.Add(Me.queryFormDataRefLabel)
        Me.queryFormDataGroupBox.Controls.Add(Me.queryFormDataDatePicker)
        Me.queryFormDataGroupBox.Location = New System.Drawing.Point(13, 13)
        Me.queryFormDataGroupBox.Name = "queryFormDataGroupBox"
        Me.queryFormDataGroupBox.Size = New System.Drawing.Size(586, 263)
        Me.queryFormDataGroupBox.TabIndex = 10
        Me.queryFormDataGroupBox.TabStop = False
        Me.queryFormDataGroupBox.Text = "Datos"
        '
        'queryFormDeleteButton
        '
        Me.queryFormDeleteButton.Location = New System.Drawing.Point(484, 211)
        Me.queryFormDeleteButton.Name = "queryFormDeleteButton"
        Me.queryFormDeleteButton.Size = New System.Drawing.Size(75, 46)
        Me.queryFormDeleteButton.TabIndex = 16
        Me.queryFormDeleteButton.Text = "Eliminar entrada"
        Me.queryFormDeleteButton.UseVisualStyleBackColor = True
        '
        'queryFormDataAM
        '
        Me.queryFormDataAM.AutoSize = True
        Me.queryFormDataAM.Location = New System.Drawing.Point(464, 31)
        Me.queryFormDataAM.Name = "queryFormDataAM"
        Me.queryFormDataAM.Size = New System.Drawing.Size(42, 17)
        Me.queryFormDataAM.TabIndex = 40
        Me.queryFormDataAM.Text = "AM"
        Me.queryFormDataAM.UseVisualStyleBackColor = True
        Me.queryFormDataAM.Visible = False
        '
        'queryFormModifyButton
        '
        Me.queryFormModifyButton.Location = New System.Drawing.Point(484, 154)
        Me.queryFormModifyButton.Name = "queryFormModifyButton"
        Me.queryFormModifyButton.Size = New System.Drawing.Size(75, 46)
        Me.queryFormModifyButton.TabIndex = 15
        Me.queryFormModifyButton.Text = "Modificar entrada"
        Me.queryFormModifyButton.UseVisualStyleBackColor = True
        '
        'queryFormDataFinalRefTextBox
        '
        Me.queryFormDataFinalRefTextBox.Location = New System.Drawing.Point(353, 31)
        Me.queryFormDataFinalRefTextBox.Name = "queryFormDataFinalRefTextBox"
        Me.queryFormDataFinalRefTextBox.Size = New System.Drawing.Size(96, 20)
        Me.queryFormDataFinalRefTextBox.TabIndex = 38
        '
        'queryFormDataFinalRefLabel
        '
        Me.queryFormDataFinalRefLabel.AutoSize = True
        Me.queryFormDataFinalRefLabel.Location = New System.Drawing.Point(350, 15)
        Me.queryFormDataFinalRefLabel.Name = "queryFormDataFinalRefLabel"
        Me.queryFormDataFinalRefLabel.Size = New System.Drawing.Size(46, 13)
        Me.queryFormDataFinalRefLabel.TabIndex = 39
        Me.queryFormDataFinalRefLabel.Text = "FinalRef"
        '
        'queryFormDataIdTextBox
        '
        Me.queryFormDataIdTextBox.Location = New System.Drawing.Point(240, 31)
        Me.queryFormDataIdTextBox.Name = "queryFormDataIdTextBox"
        Me.queryFormDataIdTextBox.ReadOnly = True
        Me.queryFormDataIdTextBox.Size = New System.Drawing.Size(96, 20)
        Me.queryFormDataIdTextBox.TabIndex = 36
        '
        'queryFormDataIdLabel
        '
        Me.queryFormDataIdLabel.AutoSize = True
        Me.queryFormDataIdLabel.Location = New System.Drawing.Point(237, 15)
        Me.queryFormDataIdLabel.Name = "queryFormDataIdLabel"
        Me.queryFormDataIdLabel.Size = New System.Drawing.Size(18, 13)
        Me.queryFormDataIdLabel.TabIndex = 37
        Me.queryFormDataIdLabel.Text = "ID"
        '
        'queryFormDataManagerComboBox
        '
        Me.queryFormDataManagerComboBox.DataSource = Me.ManagersTableBindingSource
        Me.queryFormDataManagerComboBox.DisplayMember = "type_Manager"
        Me.queryFormDataManagerComboBox.FormattingEnabled = True
        Me.queryFormDataManagerComboBox.Location = New System.Drawing.Point(6, 121)
        Me.queryFormDataManagerComboBox.Name = "queryFormDataManagerComboBox"
        Me.queryFormDataManagerComboBox.Size = New System.Drawing.Size(96, 21)
        Me.queryFormDataManagerComboBox.TabIndex = 14
        '
        'ManagersTableBindingSource
        '
        Me.ManagersTableBindingSource.DataMember = "Managers_Table"
        Me.ManagersTableBindingSource.DataSource = Me.Registro_ProduccionDataSet
        '
        'queryFormDataCommentTextBox
        '
        Me.queryFormDataCommentTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.queryFormDataCommentTextBox.Location = New System.Drawing.Point(6, 174)
        Me.queryFormDataCommentTextBox.Multiline = True
        Me.queryFormDataCommentTextBox.Name = "queryFormDataCommentTextBox"
        Me.queryFormDataCommentTextBox.Size = New System.Drawing.Size(444, 83)
        Me.queryFormDataCommentTextBox.TabIndex = 35
        '
        'queryFormDataCommentLabel
        '
        Me.queryFormDataCommentLabel.AutoSize = True
        Me.queryFormDataCommentLabel.Location = New System.Drawing.Point(3, 154)
        Me.queryFormDataCommentLabel.Name = "queryFormDataCommentLabel"
        Me.queryFormDataCommentLabel.Size = New System.Drawing.Size(65, 13)
        Me.queryFormDataCommentLabel.TabIndex = 34
        Me.queryFormDataCommentLabel.Text = "Comentarios"
        '
        'queryFormDataProcessLabel
        '
        Me.queryFormDataProcessLabel.AutoSize = True
        Me.queryFormDataProcessLabel.Location = New System.Drawing.Point(350, 106)
        Me.queryFormDataProcessLabel.Name = "queryFormDataProcessLabel"
        Me.queryFormDataProcessLabel.Size = New System.Drawing.Size(46, 13)
        Me.queryFormDataProcessLabel.TabIndex = 30
        Me.queryFormDataProcessLabel.Text = "Proceso"
        '
        'queryFormDataLineTextBox
        '
        Me.queryFormDataLineTextBox.Location = New System.Drawing.Point(240, 122)
        Me.queryFormDataLineTextBox.Name = "queryFormDataLineTextBox"
        Me.queryFormDataLineTextBox.Size = New System.Drawing.Size(96, 20)
        Me.queryFormDataLineTextBox.TabIndex = 31
        '
        'queryFormDataProcessComboBox
        '
        Me.queryFormDataProcessComboBox.FormattingEnabled = True
        Me.queryFormDataProcessComboBox.Items.AddRange(New Object() {"BENDING", "BOX", "WELDING", "FINAL", "HEATSHIELD"})
        Me.queryFormDataProcessComboBox.Location = New System.Drawing.Point(353, 122)
        Me.queryFormDataProcessComboBox.Name = "queryFormDataProcessComboBox"
        Me.queryFormDataProcessComboBox.Size = New System.Drawing.Size(96, 21)
        Me.queryFormDataProcessComboBox.TabIndex = 29
        '
        'queryFormDataLineLabel
        '
        Me.queryFormDataLineLabel.AutoSize = True
        Me.queryFormDataLineLabel.Location = New System.Drawing.Point(237, 106)
        Me.queryFormDataLineLabel.Name = "queryFormDataLineLabel"
        Me.queryFormDataLineLabel.Size = New System.Drawing.Size(35, 13)
        Me.queryFormDataLineLabel.TabIndex = 32
        Me.queryFormDataLineLabel.Text = "Línea"
        '
        'queryFormDataShiftLabel
        '
        Me.queryFormDataShiftLabel.AutoSize = True
        Me.queryFormDataShiftLabel.Location = New System.Drawing.Point(115, 105)
        Me.queryFormDataShiftLabel.Name = "queryFormDataShiftLabel"
        Me.queryFormDataShiftLabel.Size = New System.Drawing.Size(35, 13)
        Me.queryFormDataShiftLabel.TabIndex = 15
        Me.queryFormDataShiftLabel.Text = "Turno"
        '
        'queryFormDataShiftComboBox
        '
        Me.queryFormDataShiftComboBox.FormattingEnabled = True
        Me.queryFormDataShiftComboBox.Items.AddRange(New Object() {"A", "B", "C"})
        Me.queryFormDataShiftComboBox.Location = New System.Drawing.Point(118, 121)
        Me.queryFormDataShiftComboBox.Name = "queryFormDataShiftComboBox"
        Me.queryFormDataShiftComboBox.Size = New System.Drawing.Size(96, 21)
        Me.queryFormDataShiftComboBox.TabIndex = 14
        '
        'queryFormDataManagerLabel
        '
        Me.queryFormDataManagerLabel.AutoSize = True
        Me.queryFormDataManagerLabel.Location = New System.Drawing.Point(3, 105)
        Me.queryFormDataManagerLabel.Name = "queryFormDataManagerLabel"
        Me.queryFormDataManagerLabel.Size = New System.Drawing.Size(59, 13)
        Me.queryFormDataManagerLabel.TabIndex = 28
        Me.queryFormDataManagerLabel.Text = "Encargado"
        '
        'queryFormDataSage
        '
        Me.queryFormDataSage.AutoSize = True
        Me.queryFormDataSage.Location = New System.Drawing.Point(118, 75)
        Me.queryFormDataSage.Name = "queryFormDataSage"
        Me.queryFormDataSage.Size = New System.Drawing.Size(55, 17)
        Me.queryFormDataSage.TabIndex = 26
        Me.queryFormDataSage.Text = "SAGE"
        Me.queryFormDataSage.UseVisualStyleBackColor = True
        '
        'queryFormDataScrapTextBox
        '
        Me.queryFormDataScrapTextBox.Location = New System.Drawing.Point(353, 74)
        Me.queryFormDataScrapTextBox.Name = "queryFormDataScrapTextBox"
        Me.queryFormDataScrapTextBox.Size = New System.Drawing.Size(96, 20)
        Me.queryFormDataScrapTextBox.TabIndex = 24
        '
        'queryFormDataScrapLabel
        '
        Me.queryFormDataScrapLabel.AutoSize = True
        Me.queryFormDataScrapLabel.Location = New System.Drawing.Point(350, 58)
        Me.queryFormDataScrapLabel.Name = "queryFormDataScrapLabel"
        Me.queryFormDataScrapLabel.Size = New System.Drawing.Size(35, 13)
        Me.queryFormDataScrapLabel.TabIndex = 25
        Me.queryFormDataScrapLabel.Text = "Scrap"
        '
        'queryFormDataQuantityTextBox
        '
        Me.queryFormDataQuantityTextBox.Location = New System.Drawing.Point(240, 74)
        Me.queryFormDataQuantityTextBox.Name = "queryFormDataQuantityTextBox"
        Me.queryFormDataQuantityTextBox.Size = New System.Drawing.Size(96, 20)
        Me.queryFormDataQuantityTextBox.TabIndex = 22
        '
        'queryFormDataQuantityLabel
        '
        Me.queryFormDataQuantityLabel.AutoSize = True
        Me.queryFormDataQuantityLabel.Location = New System.Drawing.Point(237, 58)
        Me.queryFormDataQuantityLabel.Name = "queryFormDataQuantityLabel"
        Me.queryFormDataQuantityLabel.Size = New System.Drawing.Size(49, 13)
        Me.queryFormDataQuantityLabel.TabIndex = 23
        Me.queryFormDataQuantityLabel.Text = "Cantidad"
        '
        'queryFormDataWeekTextBox
        '
        Me.queryFormDataWeekTextBox.Location = New System.Drawing.Point(118, 31)
        Me.queryFormDataWeekTextBox.Name = "queryFormDataWeekTextBox"
        Me.queryFormDataWeekTextBox.Size = New System.Drawing.Size(96, 20)
        Me.queryFormDataWeekTextBox.TabIndex = 20
        '
        'queryFormDataWeekLabel
        '
        Me.queryFormDataWeekLabel.AutoSize = True
        Me.queryFormDataWeekLabel.Location = New System.Drawing.Point(115, 15)
        Me.queryFormDataWeekLabel.Name = "queryFormDataWeekLabel"
        Me.queryFormDataWeekLabel.Size = New System.Drawing.Size(46, 13)
        Me.queryFormDataWeekLabel.TabIndex = 21
        Me.queryFormDataWeekLabel.Text = "Semana"
        '
        'queryFormDataDateLabel
        '
        Me.queryFormDataDateLabel.AutoSize = True
        Me.queryFormDataDateLabel.Location = New System.Drawing.Point(3, 15)
        Me.queryFormDataDateLabel.Name = "queryFormDataDateLabel"
        Me.queryFormDataDateLabel.Size = New System.Drawing.Size(37, 13)
        Me.queryFormDataDateLabel.TabIndex = 13
        Me.queryFormDataDateLabel.Text = "Fecha"
        '
        'queryFormDataRefTextBox
        '
        Me.queryFormDataRefTextBox.Location = New System.Drawing.Point(6, 74)
        Me.queryFormDataRefTextBox.Name = "queryFormDataRefTextBox"
        Me.queryFormDataRefTextBox.Size = New System.Drawing.Size(96, 20)
        Me.queryFormDataRefTextBox.TabIndex = 14
        '
        'queryFormDataRefLabel
        '
        Me.queryFormDataRefLabel.AutoSize = True
        Me.queryFormDataRefLabel.Location = New System.Drawing.Point(3, 58)
        Me.queryFormDataRefLabel.Name = "queryFormDataRefLabel"
        Me.queryFormDataRefLabel.Size = New System.Drawing.Size(59, 13)
        Me.queryFormDataRefLabel.TabIndex = 15
        Me.queryFormDataRefLabel.Text = "Referencia"
        '
        'queryFormDataDatePicker
        '
        Me.queryFormDataDatePicker.CustomFormat = ""
        Me.queryFormDataDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.queryFormDataDatePicker.Location = New System.Drawing.Point(6, 31)
        Me.queryFormDataDatePicker.Name = "queryFormDataDatePicker"
        Me.queryFormDataDatePicker.Size = New System.Drawing.Size(96, 20)
        Me.queryFormDataDatePicker.TabIndex = 12
        '
        'queryFormCloseButton
        '
        Me.queryFormCloseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.queryFormCloseButton.Location = New System.Drawing.Point(1079, 603)
        Me.queryFormCloseButton.Name = "queryFormCloseButton"
        Me.queryFormCloseButton.Size = New System.Drawing.Size(69, 30)
        Me.queryFormCloseButton.TabIndex = 14
        Me.queryFormCloseButton.Text = "Cerrar"
        Me.queryFormCloseButton.UseVisualStyleBackColor = True
        '
        'Report_TableTableAdapter
        '
        Me.Report_TableTableAdapter.ClearBeforeFill = True
        '
        'queryFormRefreshButton
        '
        Me.queryFormRefreshButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.queryFormRefreshButton.Location = New System.Drawing.Point(1079, 541)
        Me.queryFormRefreshButton.Name = "queryFormRefreshButton"
        Me.queryFormRefreshButton.Size = New System.Drawing.Size(69, 46)
        Me.queryFormRefreshButton.TabIndex = 41
        Me.queryFormRefreshButton.Text = "Actualizar"
        Me.queryFormRefreshButton.UseVisualStyleBackColor = True
        '
        'Managers_TableTableAdapter
        '
        Me.Managers_TableTableAdapter.ClearBeforeFill = True
        '
        'ManagersTableReportTableBindingSource
        '
        Me.ManagersTableReportTableBindingSource.DataMember = "Managers_TableReport_Table"
        Me.ManagersTableReportTableBindingSource.DataSource = Me.ManagersTableBindingSource
        '
        'DbQueryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1160, 645)
        Me.Controls.Add(Me.queryFormRefreshButton)
        Me.Controls.Add(Me.queryFormCloseButton)
        Me.Controls.Add(Me.queryFormDataGroupBox)
        Me.Controls.Add(Me.DbQueryDataGridView)
        Me.Controls.Add(Me.queryFormFilterGroupBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DbQueryForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultar registros"
        Me.queryFormFilterGroupBox.ResumeLayout(False)
        Me.queryFormFilterGroupBox.PerformLayout()
        CType(Me.DbQueryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Registro_ProduccionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.queryFormDataGroupBox.ResumeLayout(False)
        Me.queryFormDataGroupBox.PerformLayout()
        CType(Me.ManagersTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ManagersTableReportTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents queryFormFilterInitDatePicker As DateTimePicker
    Friend WithEvents queryFormFilterInitDateLabel As Label
    Friend WithEvents queryFormFilterEndDateLabel As Label
    Friend WithEvents queryFormFilterEndDatePicker As DateTimePicker
    Friend WithEvents queryFormFilterRefTextBox As TextBox
    Friend WithEvents queryFormFilterRefLabel As Label
    Friend WithEvents queryFormFilterShiftComboBox As ComboBox
    Friend WithEvents queryFormFilterShiftLabel As Label
    Friend WithEvents queryFormFilterGroupBox As GroupBox
    Friend WithEvents queryFormFilterSearchButton As Button
    Friend WithEvents queryFormFilterWeekTextBox As TextBox
    Friend WithEvents queryFormFilterWeekLabel As Label
    Friend WithEvents queryFormFilterManagerLabel As Label
    Friend WithEvents queryFormFilterManagerComboBox As ComboBox
    Friend WithEvents queryFormFilterCleanButton As Button
    Friend WithEvents DbQueryDataGridView As DataGridView
    Friend WithEvents Registro_ProduccionDataSet As Registro_ProduccionDataSet
    Friend WithEvents ReportTableBindingSource As BindingSource
    Friend WithEvents Report_TableTableAdapter As Registro_ProduccionDataSetTableAdapters.Report_TableTableAdapter
    Friend WithEvents queryFormDataGroupBox As GroupBox
    Friend WithEvents queryFormDataScrapTextBox As TextBox
    Friend WithEvents queryFormDataScrapLabel As Label
    Friend WithEvents queryFormDataQuantityTextBox As TextBox
    Friend WithEvents queryFormDataQuantityLabel As Label
    Friend WithEvents queryFormDataWeekTextBox As TextBox
    Friend WithEvents queryFormDataWeekLabel As Label
    Friend WithEvents queryFormDataDateLabel As Label
    Friend WithEvents queryFormDataRefTextBox As TextBox
    Friend WithEvents queryFormDataRefLabel As Label
    Friend WithEvents queryFormDataDatePicker As DateTimePicker
    Friend WithEvents queryFormDataCommentLabel As Label
    Friend WithEvents queryFormDataProcessLabel As Label
    Friend WithEvents queryFormDataLineTextBox As TextBox
    Friend WithEvents queryFormDataProcessComboBox As ComboBox
    Friend WithEvents queryFormDataLineLabel As Label
    Friend WithEvents queryFormDataShiftLabel As Label
    Friend WithEvents queryFormDataShiftComboBox As ComboBox
    Friend WithEvents queryFormDataManagerLabel As Label
    Friend WithEvents queryFormDataSage As CheckBox
    Friend WithEvents queryFormDataCommentTextBox As TextBox
    Friend WithEvents queryFormDataManagerComboBox As ComboBox
    Friend WithEvents queryFormDataIdTextBox As TextBox
    Friend WithEvents queryFormDataIdLabel As Label
    Friend WithEvents queryFormCloseButton As Button
    Friend WithEvents queryFormModifyButton As Button
    Friend WithEvents queryFormDataFinalRefTextBox As TextBox
    Friend WithEvents queryFormDataFinalRefLabel As Label
    Friend WithEvents queryFormDataAM As CheckBox
    Friend WithEvents queryFormDeleteButton As Button
    Friend WithEvents queryFormRefreshButton As Button
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TypeDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TypeReferenceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TypeQuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TypeScrapDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TypeSAGEDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents TypeWeekDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TypeManagerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TypeShiftDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TypeProcessDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TypeLineDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TypeCommentsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TypeFinalRefDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents type_AM As DataGridViewCheckBoxColumn
    Friend WithEvents ManagersTableBindingSource As BindingSource
    Friend WithEvents Managers_TableTableAdapter As Registro_ProduccionDataSetTableAdapters.Managers_TableTableAdapter
    Friend WithEvents ManagersTableReportTableBindingSource As BindingSource
End Class

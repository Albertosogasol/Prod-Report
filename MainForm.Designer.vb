<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.BosalLogo = New System.Windows.Forms.PictureBox()
        Me.title_Label = New System.Windows.Forms.Label()
        Me.datePicker = New System.Windows.Forms.DateTimePicker()
        Me.datePicker_Label = New System.Windows.Forms.Label()
        Me.refListBoxComplete = New System.Windows.Forms.ListBox()
        Me.ALLBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Registro_ProduccionDataSet = New Prod_Report.Registro_ProduccionDataSet()
        Me.refTextBox = New System.Windows.Forms.TextBox()
        Me.ref_Label = New System.Windows.Forms.Label()
        Me.quantityTextBox = New System.Windows.Forms.TextBox()
        Me.QuantityLabel = New System.Windows.Forms.Label()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.addDataButton = New System.Windows.Forms.Button()
        Me.Report_TableTableAdapter = New Prod_Report.Registro_ProduccionDataSetTableAdapters.Report_TableTableAdapter()
        Me.reportDataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TempReportTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Registro_ProduccionDataSet1 = New Prod_Report.Registro_ProduccionDataSet()
        Me.loadDataButton = New System.Windows.Forms.Button()
        Me.managerComboBox = New System.Windows.Forms.ComboBox()
        Me.ActiveManagersQueryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ManagersTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.managerLabel = New System.Windows.Forms.Label()
        Me.shiftComboBox = New System.Windows.Forms.ComboBox()
        Me.shiftLabel = New System.Windows.Forms.Label()
        Me.commentsTextBox = New System.Windows.Forms.TextBox()
        Me.commentsLabel = New System.Windows.Forms.Label()
        Me.processTextBox = New System.Windows.Forms.TextBox()
        Me.processLabel = New System.Windows.Forms.Label()
        Me.lineLabel = New System.Windows.Forms.Label()
        Me.lineTextBox = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Tab1Bending = New System.Windows.Forms.TabPage()
        Me.refListBending = New System.Windows.Forms.ListBox()
        Me.Tab2Box = New System.Windows.Forms.TabPage()
        Me.refListBox = New System.Windows.Forms.ListBox()
        Me.Tab2Welding = New System.Windows.Forms.TabPage()
        Me.refListWelding = New System.Windows.Forms.ListBox()
        Me.Tab4Final = New System.Windows.Forms.TabPage()
        Me.refListFinal = New System.Windows.Forms.ListBox()
        Me.Tab5All = New System.Windows.Forms.TabPage()
        Me.beszLabel = New System.Windows.Forms.Label()
        Me.procDataGridView = New System.Windows.Forms.DataGridView()
        Me.ReferenceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Final_Ref = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Process = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Line = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.searchBox = New System.Windows.Forms.TextBox()
        Me.searchBoxLabel = New System.Windows.Forms.Label()
        Me.deleteDataButton = New System.Windows.Forms.Button()
        Me.sageCheckBox = New System.Windows.Forms.CheckBox()
        Me.refCheckBoxLogo = New System.Windows.Forms.PictureBox()
        Me.procCheckBoxLogo = New System.Windows.Forms.PictureBox()
        Me.lineCheckBoxLogo = New System.Windows.Forms.PictureBox()
        Me.quantityCheckBoxLogo = New System.Windows.Forms.PictureBox()
        Me.updateFormButton = New System.Windows.Forms.Button()
        Me.finalRefTextBox = New System.Windows.Forms.TextBox()
        Me.finalRefLabel = New System.Windows.Forms.Label()
        Me.scrapTextBox = New System.Windows.Forms.TextBox()
        Me.scrapLabel = New System.Windows.Forms.Label()
        Me.finalRefCheckBoxLogo = New System.Windows.Forms.PictureBox()
        Me.scrapCheckBoxLogo = New System.Windows.Forms.PictureBox()
        Me.buildNumberLabel = New System.Windows.Forms.Label()
        Me.toolsFormButton = New System.Windows.Forms.Button()
        Me.aftermarket_Button = New System.Windows.Forms.Button()
        Me.amRefCheckBox = New System.Windows.Forms.CheckBox()
        Me.ReportTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ALLBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ALLTableAdapter = New Prod_Report.Registro_ProduccionDataSetTableAdapters.ALLTableAdapter()
        Me.Temp_Report_TableTableAdapter = New Prod_Report.Registro_ProduccionDataSetTableAdapters.temp_Report_TableTableAdapter()
        Me.ALLTableAdapterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.labelMailContact = New System.Windows.Forms.LinkLabel()
        Me.Managers_TableTableAdapter = New Prod_Report.Registro_ProduccionDataSetTableAdapters.Managers_TableTableAdapter()
        Me.Active_Managers_QueryTableAdapter = New Prod_Report.Registro_ProduccionDataSetTableAdapters.Active_Managers_QueryTableAdapter()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.temp_Date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.temp_FinalRef = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.temp_Reference = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.temp_Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.temp_Scrap = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.temp_SAGE = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.temp_Week = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.temp_Manager = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.temp_Shift = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.temp_Process = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.temp_Line = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.temp_Comments = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.BosalLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALLBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Registro_ProduccionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reportDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TempReportTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Registro_ProduccionDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActiveManagersQueryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ManagersTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.Tab1Bending.SuspendLayout()
        Me.Tab2Box.SuspendLayout()
        Me.Tab2Welding.SuspendLayout()
        Me.Tab4Final.SuspendLayout()
        Me.Tab5All.SuspendLayout()
        CType(Me.procDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.refCheckBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.procCheckBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lineCheckBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.quantityCheckBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.finalRefCheckBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.scrapCheckBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALLBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALLTableAdapterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BosalLogo
        '
        Me.BosalLogo.Image = Global.Prod_Report.My.Resources.Resources.Bosal_Black_Logo
        Me.BosalLogo.Location = New System.Drawing.Point(12, 12)
        Me.BosalLogo.Name = "BosalLogo"
        Me.BosalLogo.Size = New System.Drawing.Size(212, 50)
        Me.BosalLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BosalLogo.TabIndex = 0
        Me.BosalLogo.TabStop = False
        '
        'title_Label
        '
        Me.title_Label.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.title_Label.AutoSize = True
        Me.title_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title_Label.Location = New System.Drawing.Point(354, 77)
        Me.title_Label.Name = "title_Label"
        Me.title_Label.Size = New System.Drawing.Size(393, 39)
        Me.title_Label.TabIndex = 1
        Me.title_Label.Text = "Registro de Producción"
        '
        'datePicker
        '
        Me.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datePicker.Location = New System.Drawing.Point(29, 163)
        Me.datePicker.Name = "datePicker"
        Me.datePicker.Size = New System.Drawing.Size(162, 20)
        Me.datePicker.TabIndex = 2
        '
        'datePicker_Label
        '
        Me.datePicker_Label.AutoSize = True
        Me.datePicker_Label.Location = New System.Drawing.Point(26, 147)
        Me.datePicker_Label.Name = "datePicker_Label"
        Me.datePicker_Label.Size = New System.Drawing.Size(37, 13)
        Me.datePicker_Label.TabIndex = 3
        Me.datePicker_Label.Text = "Fecha"
        '
        'refListBoxComplete
        '
        Me.refListBoxComplete.DataSource = Me.ALLBindingSource
        Me.refListBoxComplete.DisplayMember = "Reference"
        Me.refListBoxComplete.FormattingEnabled = True
        Me.refListBoxComplete.Location = New System.Drawing.Point(0, 0)
        Me.refListBoxComplete.Name = "refListBoxComplete"
        Me.refListBoxComplete.Size = New System.Drawing.Size(238, 342)
        Me.refListBoxComplete.Sorted = True
        Me.refListBoxComplete.TabIndex = 4
        '
        'ALLBindingSource
        '
        Me.ALLBindingSource.DataMember = "ALL"
        Me.ALLBindingSource.DataSource = Me.Registro_ProduccionDataSet
        '
        'Registro_ProduccionDataSet
        '
        Me.Registro_ProduccionDataSet.DataSetName = "Registro_ProduccionDataSet"
        Me.Registro_ProduccionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'refTextBox
        '
        Me.refTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.refTextBox.Location = New System.Drawing.Point(571, 164)
        Me.refTextBox.Name = "refTextBox"
        Me.refTextBox.ReadOnly = True
        Me.refTextBox.Size = New System.Drawing.Size(111, 20)
        Me.refTextBox.TabIndex = 5
        '
        'ref_Label
        '
        Me.ref_Label.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ref_Label.AutoSize = True
        Me.ref_Label.Location = New System.Drawing.Point(568, 148)
        Me.ref_Label.Name = "ref_Label"
        Me.ref_Label.Size = New System.Drawing.Size(59, 13)
        Me.ref_Label.TabIndex = 6
        Me.ref_Label.Text = "Referencia"
        '
        'quantityTextBox
        '
        Me.quantityTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.quantityTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.quantityTextBox.Location = New System.Drawing.Point(719, 165)
        Me.quantityTextBox.Name = "quantityTextBox"
        Me.quantityTextBox.Size = New System.Drawing.Size(111, 20)
        Me.quantityTextBox.TabIndex = 7
        '
        'QuantityLabel
        '
        Me.QuantityLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.QuantityLabel.AutoSize = True
        Me.QuantityLabel.Location = New System.Drawing.Point(716, 148)
        Me.QuantityLabel.Name = "QuantityLabel"
        Me.QuantityLabel.Size = New System.Drawing.Size(49, 13)
        Me.QuantityLabel.TabIndex = 8
        Me.QuantityLabel.Text = "Cantidad"
        '
        'exitButton
        '
        Me.exitButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.exitButton.BackColor = System.Drawing.SystemColors.ControlLight
        Me.exitButton.Location = New System.Drawing.Point(1105, 620)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(79, 23)
        Me.exitButton.TabIndex = 9
        Me.exitButton.Text = "Salir"
        Me.exitButton.UseVisualStyleBackColor = False
        '
        'addDataButton
        '
        Me.addDataButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.addDataButton.BackColor = System.Drawing.SystemColors.ControlLight
        Me.addDataButton.Location = New System.Drawing.Point(712, 367)
        Me.addDataButton.Name = "addDataButton"
        Me.addDataButton.Size = New System.Drawing.Size(100, 50)
        Me.addDataButton.TabIndex = 10
        Me.addDataButton.Text = "Enviar a base de datos"
        Me.addDataButton.UseVisualStyleBackColor = False
        '
        'Report_TableTableAdapter
        '
        Me.Report_TableTableAdapter.ClearBeforeFill = True
        '
        'reportDataGridView1
        '
        Me.reportDataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.reportDataGridView1.AutoGenerateColumns = False
        Me.reportDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.reportDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.temp_Date, Me.temp_FinalRef, Me.temp_Reference, Me.temp_Quantity, Me.temp_Scrap, Me.temp_SAGE, Me.temp_Week, Me.temp_Manager, Me.temp_Shift, Me.temp_Process, Me.temp_Line, Me.temp_Comments})
        Me.reportDataGridView1.DataSource = Me.TempReportTableBindingSource
        Me.reportDataGridView1.Location = New System.Drawing.Point(29, 427)
        Me.reportDataGridView1.Name = "reportDataGridView1"
        Me.reportDataGridView1.RowHeadersWidth = 20
        Me.reportDataGridView1.Size = New System.Drawing.Size(1067, 216)
        Me.reportDataGridView1.TabIndex = 11
        '
        'TempReportTableBindingSource
        '
        Me.TempReportTableBindingSource.DataMember = "temp_Report_Table"
        Me.TempReportTableBindingSource.DataSource = Me.Registro_ProduccionDataSet
        '
        'Registro_ProduccionDataSet1
        '
        Me.Registro_ProduccionDataSet1.DataSetName = "Registro_ProduccionDataSet"
        Me.Registro_ProduccionDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'loadDataButton
        '
        Me.loadDataButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.loadDataButton.BackColor = System.Drawing.SystemColors.ControlLight
        Me.loadDataButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loadDataButton.Location = New System.Drawing.Point(595, 367)
        Me.loadDataButton.Name = "loadDataButton"
        Me.loadDataButton.Size = New System.Drawing.Size(100, 50)
        Me.loadDataButton.TabIndex = 12
        Me.loadDataButton.Text = "Cargar datos"
        Me.loadDataButton.UseVisualStyleBackColor = False
        '
        'managerComboBox
        '
        Me.managerComboBox.DataSource = Me.ActiveManagersQueryBindingSource
        Me.managerComboBox.DisplayMember = "type_Manager"
        Me.managerComboBox.FormattingEnabled = True
        Me.managerComboBox.Location = New System.Drawing.Point(29, 245)
        Me.managerComboBox.Name = "managerComboBox"
        Me.managerComboBox.Size = New System.Drawing.Size(121, 21)
        Me.managerComboBox.TabIndex = 13
        '
        'ActiveManagersQueryBindingSource
        '
        Me.ActiveManagersQueryBindingSource.DataMember = "Active_Managers_Query"
        Me.ActiveManagersQueryBindingSource.DataSource = Me.Registro_ProduccionDataSet
        '
        'ManagersTableBindingSource
        '
        Me.ManagersTableBindingSource.DataMember = "Managers_Table"
        Me.ManagersTableBindingSource.DataSource = Me.Registro_ProduccionDataSet
        '
        'managerLabel
        '
        Me.managerLabel.AutoSize = True
        Me.managerLabel.Location = New System.Drawing.Point(26, 230)
        Me.managerLabel.Name = "managerLabel"
        Me.managerLabel.Size = New System.Drawing.Size(59, 13)
        Me.managerLabel.TabIndex = 14
        Me.managerLabel.Text = "Encargado"
        '
        'shiftComboBox
        '
        Me.shiftComboBox.FormattingEnabled = True
        Me.shiftComboBox.Items.AddRange(New Object() {"A", "B", "C"})
        Me.shiftComboBox.Location = New System.Drawing.Point(169, 245)
        Me.shiftComboBox.Name = "shiftComboBox"
        Me.shiftComboBox.Size = New System.Drawing.Size(121, 21)
        Me.shiftComboBox.TabIndex = 15
        '
        'shiftLabel
        '
        Me.shiftLabel.AutoSize = True
        Me.shiftLabel.Location = New System.Drawing.Point(166, 228)
        Me.shiftLabel.Name = "shiftLabel"
        Me.shiftLabel.Size = New System.Drawing.Size(35, 13)
        Me.shiftLabel.TabIndex = 16
        Me.shiftLabel.Text = "Turno"
        '
        'commentsTextBox
        '
        Me.commentsTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.commentsTextBox.Location = New System.Drawing.Point(29, 334)
        Me.commentsTextBox.Multiline = True
        Me.commentsTextBox.Name = "commentsTextBox"
        Me.commentsTextBox.Size = New System.Drawing.Size(327, 83)
        Me.commentsTextBox.TabIndex = 17
        '
        'commentsLabel
        '
        Me.commentsLabel.AutoSize = True
        Me.commentsLabel.Location = New System.Drawing.Point(26, 318)
        Me.commentsLabel.Name = "commentsLabel"
        Me.commentsLabel.Size = New System.Drawing.Size(65, 13)
        Me.commentsLabel.TabIndex = 18
        Me.commentsLabel.Text = "Comentarios"
        '
        'processTextBox
        '
        Me.processTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.processTextBox.Location = New System.Drawing.Point(571, 231)
        Me.processTextBox.Name = "processTextBox"
        Me.processTextBox.ReadOnly = True
        Me.processTextBox.Size = New System.Drawing.Size(111, 20)
        Me.processTextBox.TabIndex = 19
        '
        'processLabel
        '
        Me.processLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.processLabel.AutoSize = True
        Me.processLabel.Location = New System.Drawing.Point(568, 215)
        Me.processLabel.Name = "processLabel"
        Me.processLabel.Size = New System.Drawing.Size(46, 13)
        Me.processLabel.TabIndex = 20
        Me.processLabel.Text = "Proceso"
        '
        'lineLabel
        '
        Me.lineLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lineLabel.AutoSize = True
        Me.lineLabel.Location = New System.Drawing.Point(716, 281)
        Me.lineLabel.Name = "lineLabel"
        Me.lineLabel.Size = New System.Drawing.Size(35, 13)
        Me.lineLabel.TabIndex = 21
        Me.lineLabel.Text = "Línea"
        '
        'lineTextBox
        '
        Me.lineTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lineTextBox.Location = New System.Drawing.Point(719, 299)
        Me.lineTextBox.Name = "lineTextBox"
        Me.lineTextBox.Size = New System.Drawing.Size(111, 20)
        Me.lineTextBox.TabIndex = 22
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Tab1Bending)
        Me.TabControl1.Controls.Add(Me.Tab2Box)
        Me.TabControl1.Controls.Add(Me.Tab2Welding)
        Me.TabControl1.Controls.Add(Me.Tab4Final)
        Me.TabControl1.Controls.Add(Me.Tab5All)
        Me.TabControl1.Location = New System.Drawing.Point(924, 132)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(246, 279)
        Me.TabControl1.TabIndex = 23
        Me.TabControl1.Visible = False
        '
        'Tab1Bending
        '
        Me.Tab1Bending.Controls.Add(Me.refListBending)
        Me.Tab1Bending.Location = New System.Drawing.Point(4, 22)
        Me.Tab1Bending.Name = "Tab1Bending"
        Me.Tab1Bending.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab1Bending.Size = New System.Drawing.Size(238, 253)
        Me.Tab1Bending.TabIndex = 0
        Me.Tab1Bending.Text = "Curvado"
        Me.Tab1Bending.UseVisualStyleBackColor = True
        '
        'refListBending
        '
        Me.refListBending.FormattingEnabled = True
        Me.refListBending.Location = New System.Drawing.Point(0, 0)
        Me.refListBending.Name = "refListBending"
        Me.refListBending.Size = New System.Drawing.Size(238, 342)
        Me.refListBending.Sorted = True
        Me.refListBending.TabIndex = 0
        '
        'Tab2Box
        '
        Me.Tab2Box.Controls.Add(Me.refListBox)
        Me.Tab2Box.Location = New System.Drawing.Point(4, 22)
        Me.Tab2Box.Name = "Tab2Box"
        Me.Tab2Box.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab2Box.Size = New System.Drawing.Size(238, 253)
        Me.Tab2Box.TabIndex = 1
        Me.Tab2Box.Text = "Cajas"
        Me.Tab2Box.UseVisualStyleBackColor = True
        '
        'refListBox
        '
        Me.refListBox.FormattingEnabled = True
        Me.refListBox.Location = New System.Drawing.Point(0, 0)
        Me.refListBox.Name = "refListBox"
        Me.refListBox.Size = New System.Drawing.Size(238, 342)
        Me.refListBox.Sorted = True
        Me.refListBox.TabIndex = 0
        '
        'Tab2Welding
        '
        Me.Tab2Welding.Controls.Add(Me.refListWelding)
        Me.Tab2Welding.Location = New System.Drawing.Point(4, 22)
        Me.Tab2Welding.Name = "Tab2Welding"
        Me.Tab2Welding.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab2Welding.Size = New System.Drawing.Size(238, 253)
        Me.Tab2Welding.TabIndex = 2
        Me.Tab2Welding.Text = "Soldadura"
        Me.Tab2Welding.UseVisualStyleBackColor = True
        '
        'refListWelding
        '
        Me.refListWelding.FormattingEnabled = True
        Me.refListWelding.Location = New System.Drawing.Point(0, 0)
        Me.refListWelding.Name = "refListWelding"
        Me.refListWelding.Size = New System.Drawing.Size(238, 342)
        Me.refListWelding.Sorted = True
        Me.refListWelding.TabIndex = 0
        '
        'Tab4Final
        '
        Me.Tab4Final.Controls.Add(Me.refListFinal)
        Me.Tab4Final.Location = New System.Drawing.Point(4, 22)
        Me.Tab4Final.Name = "Tab4Final"
        Me.Tab4Final.Size = New System.Drawing.Size(238, 253)
        Me.Tab4Final.TabIndex = 3
        Me.Tab4Final.Text = "Final"
        Me.Tab4Final.UseVisualStyleBackColor = True
        '
        'refListFinal
        '
        Me.refListFinal.FormattingEnabled = True
        Me.refListFinal.Location = New System.Drawing.Point(0, 0)
        Me.refListFinal.Name = "refListFinal"
        Me.refListFinal.Size = New System.Drawing.Size(238, 342)
        Me.refListFinal.Sorted = True
        Me.refListFinal.TabIndex = 0
        '
        'Tab5All
        '
        Me.Tab5All.Controls.Add(Me.refListBoxComplete)
        Me.Tab5All.Location = New System.Drawing.Point(4, 22)
        Me.Tab5All.Name = "Tab5All"
        Me.Tab5All.Size = New System.Drawing.Size(238, 253)
        Me.Tab5All.TabIndex = 4
        Me.Tab5All.Text = "Todo"
        Me.Tab5All.UseVisualStyleBackColor = True
        '
        'beszLabel
        '
        Me.beszLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.beszLabel.AutoSize = True
        Me.beszLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.beszLabel.Location = New System.Drawing.Point(9, 653)
        Me.beszLabel.Name = "beszLabel"
        Me.beszLabel.Size = New System.Drawing.Size(0, 13)
        Me.beszLabel.TabIndex = 24
        '
        'procDataGridView
        '
        Me.procDataGridView.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.procDataGridView.AutoGenerateColumns = False
        Me.procDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.procDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ReferenceDataGridViewTextBoxColumn, Me.Final_Ref, Me.Process, Me.Line})
        Me.procDataGridView.Cursor = System.Windows.Forms.Cursors.Default
        Me.procDataGridView.DataSource = Me.ALLBindingSource
        Me.procDataGridView.Location = New System.Drawing.Point(836, 68)
        Me.procDataGridView.Name = "procDataGridView"
        Me.procDataGridView.RowHeadersWidth = 15
        Me.procDataGridView.Size = New System.Drawing.Size(350, 349)
        Me.procDataGridView.TabIndex = 25
        '
        'ReferenceDataGridViewTextBoxColumn
        '
        Me.ReferenceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ReferenceDataGridViewTextBoxColumn.DataPropertyName = "Reference"
        Me.ReferenceDataGridViewTextBoxColumn.HeaderText = "Referencia"
        Me.ReferenceDataGridViewTextBoxColumn.Name = "ReferenceDataGridViewTextBoxColumn"
        Me.ReferenceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Final_Ref
        '
        Me.Final_Ref.DataPropertyName = "Final_Ref"
        Me.Final_Ref.HeaderText = "Ref. Final"
        Me.Final_Ref.Name = "Final_Ref"
        '
        'Process
        '
        Me.Process.DataPropertyName = "Process"
        Me.Process.HeaderText = "Proceso"
        Me.Process.Name = "Process"
        Me.Process.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Process.Width = 75
        '
        'Line
        '
        Me.Line.DataPropertyName = "Line"
        Me.Line.HeaderText = "Línea"
        Me.Line.Name = "Line"
        Me.Line.Width = 40
        '
        'searchBox
        '
        Me.searchBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.searchBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.searchBox.Location = New System.Drawing.Point(836, 42)
        Me.searchBox.Name = "searchBox"
        Me.searchBox.Size = New System.Drawing.Size(260, 20)
        Me.searchBox.TabIndex = 27
        '
        'searchBoxLabel
        '
        Me.searchBoxLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.searchBoxLabel.AutoSize = True
        Me.searchBoxLabel.Location = New System.Drawing.Point(833, 26)
        Me.searchBoxLabel.Name = "searchBoxLabel"
        Me.searchBoxLabel.Size = New System.Drawing.Size(95, 13)
        Me.searchBoxLabel.TabIndex = 28
        Me.searchBoxLabel.Text = "Buscar Referencia"
        '
        'deleteDataButton
        '
        Me.deleteDataButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.deleteDataButton.BackColor = System.Drawing.SystemColors.ControlLight
        Me.deleteDataButton.Location = New System.Drawing.Point(372, 367)
        Me.deleteDataButton.Name = "deleteDataButton"
        Me.deleteDataButton.Size = New System.Drawing.Size(100, 50)
        Me.deleteDataButton.TabIndex = 29
        Me.deleteDataButton.Text = "Eliminar entrada"
        Me.deleteDataButton.UseVisualStyleBackColor = False
        '
        'sageCheckBox
        '
        Me.sageCheckBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sageCheckBox.AutoSize = True
        Me.sageCheckBox.Checked = True
        Me.sageCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.sageCheckBox.Location = New System.Drawing.Point(571, 190)
        Me.sageCheckBox.Name = "sageCheckBox"
        Me.sageCheckBox.Size = New System.Drawing.Size(55, 17)
        Me.sageCheckBox.TabIndex = 30
        Me.sageCheckBox.Text = "SAGE"
        Me.sageCheckBox.UseVisualStyleBackColor = True
        '
        'refCheckBoxLogo
        '
        Me.refCheckBoxLogo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.refCheckBoxLogo.Image = CType(resources.GetObject("refCheckBoxLogo.Image"), System.Drawing.Image)
        Me.refCheckBoxLogo.Location = New System.Drawing.Point(545, 163)
        Me.refCheckBoxLogo.Name = "refCheckBoxLogo"
        Me.refCheckBoxLogo.Size = New System.Drawing.Size(20, 20)
        Me.refCheckBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.refCheckBoxLogo.TabIndex = 31
        Me.refCheckBoxLogo.TabStop = False
        '
        'procCheckBoxLogo
        '
        Me.procCheckBoxLogo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.procCheckBoxLogo.Image = Global.Prod_Report.My.Resources.Resources.NOK_Logo1
        Me.procCheckBoxLogo.Location = New System.Drawing.Point(545, 230)
        Me.procCheckBoxLogo.Name = "procCheckBoxLogo"
        Me.procCheckBoxLogo.Size = New System.Drawing.Size(20, 20)
        Me.procCheckBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.procCheckBoxLogo.TabIndex = 32
        Me.procCheckBoxLogo.TabStop = False
        '
        'lineCheckBoxLogo
        '
        Me.lineCheckBoxLogo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lineCheckBoxLogo.Image = Global.Prod_Report.My.Resources.Resources.NOK_Logo1
        Me.lineCheckBoxLogo.Location = New System.Drawing.Point(693, 300)
        Me.lineCheckBoxLogo.Name = "lineCheckBoxLogo"
        Me.lineCheckBoxLogo.Size = New System.Drawing.Size(20, 20)
        Me.lineCheckBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.lineCheckBoxLogo.TabIndex = 34
        Me.lineCheckBoxLogo.TabStop = False
        '
        'quantityCheckBoxLogo
        '
        Me.quantityCheckBoxLogo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.quantityCheckBoxLogo.Image = CType(resources.GetObject("quantityCheckBoxLogo.Image"), System.Drawing.Image)
        Me.quantityCheckBoxLogo.Location = New System.Drawing.Point(693, 165)
        Me.quantityCheckBoxLogo.Name = "quantityCheckBoxLogo"
        Me.quantityCheckBoxLogo.Size = New System.Drawing.Size(20, 20)
        Me.quantityCheckBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.quantityCheckBoxLogo.TabIndex = 33
        Me.quantityCheckBoxLogo.TabStop = False
        '
        'updateFormButton
        '
        Me.updateFormButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.updateFormButton.BackColor = System.Drawing.SystemColors.ControlLight
        Me.updateFormButton.Location = New System.Drawing.Point(1105, 571)
        Me.updateFormButton.Name = "updateFormButton"
        Me.updateFormButton.Size = New System.Drawing.Size(79, 43)
        Me.updateFormButton.TabIndex = 35
        Me.updateFormButton.Text = "Actualizar"
        Me.updateFormButton.UseVisualStyleBackColor = False
        '
        'finalRefTextBox
        '
        Me.finalRefTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.finalRefTextBox.Location = New System.Drawing.Point(571, 299)
        Me.finalRefTextBox.Name = "finalRefTextBox"
        Me.finalRefTextBox.ReadOnly = True
        Me.finalRefTextBox.Size = New System.Drawing.Size(111, 20)
        Me.finalRefTextBox.TabIndex = 36
        '
        'finalRefLabel
        '
        Me.finalRefLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.finalRefLabel.AutoSize = True
        Me.finalRefLabel.Location = New System.Drawing.Point(568, 283)
        Me.finalRefLabel.Name = "finalRefLabel"
        Me.finalRefLabel.Size = New System.Drawing.Size(84, 13)
        Me.finalRefLabel.TabIndex = 37
        Me.finalRefLabel.Text = "Referencia Final"
        '
        'scrapTextBox
        '
        Me.scrapTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.scrapTextBox.Location = New System.Drawing.Point(719, 230)
        Me.scrapTextBox.Name = "scrapTextBox"
        Me.scrapTextBox.Size = New System.Drawing.Size(111, 20)
        Me.scrapTextBox.TabIndex = 39
        '
        'scrapLabel
        '
        Me.scrapLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.scrapLabel.AutoSize = True
        Me.scrapLabel.Location = New System.Drawing.Point(716, 212)
        Me.scrapLabel.Name = "scrapLabel"
        Me.scrapLabel.Size = New System.Drawing.Size(35, 13)
        Me.scrapLabel.TabIndex = 38
        Me.scrapLabel.Text = "Scrap"
        '
        'finalRefCheckBoxLogo
        '
        Me.finalRefCheckBoxLogo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.finalRefCheckBoxLogo.Image = Global.Prod_Report.My.Resources.Resources.NOK_Logo1
        Me.finalRefCheckBoxLogo.Location = New System.Drawing.Point(545, 299)
        Me.finalRefCheckBoxLogo.Name = "finalRefCheckBoxLogo"
        Me.finalRefCheckBoxLogo.Size = New System.Drawing.Size(20, 20)
        Me.finalRefCheckBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.finalRefCheckBoxLogo.TabIndex = 40
        Me.finalRefCheckBoxLogo.TabStop = False
        '
        'scrapCheckBoxLogo
        '
        Me.scrapCheckBoxLogo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.scrapCheckBoxLogo.Image = CType(resources.GetObject("scrapCheckBoxLogo.Image"), System.Drawing.Image)
        Me.scrapCheckBoxLogo.Location = New System.Drawing.Point(693, 230)
        Me.scrapCheckBoxLogo.Name = "scrapCheckBoxLogo"
        Me.scrapCheckBoxLogo.Size = New System.Drawing.Size(20, 20)
        Me.scrapCheckBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.scrapCheckBoxLogo.TabIndex = 41
        Me.scrapCheckBoxLogo.TabStop = False
        '
        'buildNumberLabel
        '
        Me.buildNumberLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buildNumberLabel.AutoSize = True
        Me.buildNumberLabel.Location = New System.Drawing.Point(1115, 653)
        Me.buildNumberLabel.Name = "buildNumberLabel"
        Me.buildNumberLabel.Size = New System.Drawing.Size(39, 13)
        Me.buildNumberLabel.TabIndex = 42
        Me.buildNumberLabel.Text = "Label1"
        '
        'toolsFormButton
        '
        Me.toolsFormButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.toolsFormButton.BackColor = System.Drawing.SystemColors.ControlLight
        Me.toolsFormButton.Location = New System.Drawing.Point(1105, 522)
        Me.toolsFormButton.Name = "toolsFormButton"
        Me.toolsFormButton.Size = New System.Drawing.Size(79, 43)
        Me.toolsFormButton.TabIndex = 43
        Me.toolsFormButton.Text = "Herramientas"
        Me.toolsFormButton.UseVisualStyleBackColor = False
        '
        'aftermarket_Button
        '
        Me.aftermarket_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.aftermarket_Button.Location = New System.Drawing.Point(1105, 15)
        Me.aftermarket_Button.Name = "aftermarket_Button"
        Me.aftermarket_Button.Size = New System.Drawing.Size(75, 47)
        Me.aftermarket_Button.TabIndex = 44
        Me.aftermarket_Button.Text = "AM"
        Me.aftermarket_Button.UseVisualStyleBackColor = True
        '
        'amRefCheckBox
        '
        Me.amRefCheckBox.AutoSize = True
        Me.amRefCheckBox.Location = New System.Drawing.Point(720, 190)
        Me.amRefCheckBox.Name = "amRefCheckBox"
        Me.amRefCheckBox.Size = New System.Drawing.Size(42, 17)
        Me.amRefCheckBox.TabIndex = 45
        Me.amRefCheckBox.Text = "AM"
        Me.amRefCheckBox.UseVisualStyleBackColor = True
        Me.amRefCheckBox.Visible = False
        '
        'ReportTableBindingSource
        '
        Me.ReportTableBindingSource.DataMember = "Report_Table"
        Me.ReportTableBindingSource.DataSource = Me.Registro_ProduccionDataSet
        '
        'ALLBindingSource1
        '
        Me.ALLBindingSource1.DataMember = "ALL"
        Me.ALLBindingSource1.DataSource = Me.Registro_ProduccionDataSet
        '
        'ALLTableAdapter
        '
        Me.ALLTableAdapter.ClearBeforeFill = True
        '
        'Temp_Report_TableTableAdapter
        '
        Me.Temp_Report_TableTableAdapter.ClearBeforeFill = True
        '
        'ALLTableAdapterBindingSource
        '
        Me.ALLTableAdapterBindingSource.DataSource = GetType(Prod_Report.Registro_ProduccionDataSetTableAdapters.ALLTableAdapter)
        '
        'labelMailContact
        '
        Me.labelMailContact.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labelMailContact.AutoSize = True
        Me.labelMailContact.Location = New System.Drawing.Point(911, 653)
        Me.labelMailContact.Name = "labelMailContact"
        Me.labelMailContact.Size = New System.Drawing.Size(185, 13)
        Me.labelMailContact.TabIndex = 47
        Me.labelMailContact.TabStop = True
        Me.labelMailContact.Text = "Contact: alberto.gonzaga@bosal.com"
        '
        'Managers_TableTableAdapter
        '
        Me.Managers_TableTableAdapter.ClearBeforeFill = True
        '
        'Active_Managers_QueryTableAdapter
        '
        Me.Active_Managers_QueryTableAdapter.ClearBeforeFill = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.Width = 30
        '
        'temp_Date
        '
        Me.temp_Date.DataPropertyName = "temp_Date"
        Me.temp_Date.HeaderText = "Fecha"
        Me.temp_Date.Name = "temp_Date"
        '
        'temp_FinalRef
        '
        Me.temp_FinalRef.DataPropertyName = "temp_FinalRef"
        Me.temp_FinalRef.HeaderText = "Ref. Final"
        Me.temp_FinalRef.Name = "temp_FinalRef"
        '
        'temp_Reference
        '
        Me.temp_Reference.DataPropertyName = "temp_Reference"
        Me.temp_Reference.HeaderText = "Referencia"
        Me.temp_Reference.Name = "temp_Reference"
        Me.temp_Reference.Width = 80
        '
        'temp_Quantity
        '
        Me.temp_Quantity.DataPropertyName = "temp_Quantity"
        Me.temp_Quantity.HeaderText = "Cantidad"
        Me.temp_Quantity.Name = "temp_Quantity"
        Me.temp_Quantity.Width = 80
        '
        'temp_Scrap
        '
        Me.temp_Scrap.DataPropertyName = "temp_Scrap"
        Me.temp_Scrap.HeaderText = "Scrap"
        Me.temp_Scrap.Name = "temp_Scrap"
        Me.temp_Scrap.Width = 80
        '
        'temp_SAGE
        '
        Me.temp_SAGE.DataPropertyName = "temp_SAGE"
        Me.temp_SAGE.HeaderText = "SAGE"
        Me.temp_SAGE.Name = "temp_SAGE"
        Me.temp_SAGE.Width = 50
        '
        'temp_Week
        '
        Me.temp_Week.DataPropertyName = "temp_Week"
        Me.temp_Week.HeaderText = "Semana"
        Me.temp_Week.Name = "temp_Week"
        Me.temp_Week.Width = 80
        '
        'temp_Manager
        '
        Me.temp_Manager.DataPropertyName = "temp_Manager"
        Me.temp_Manager.HeaderText = "Encargado"
        Me.temp_Manager.Name = "temp_Manager"
        '
        'temp_Shift
        '
        Me.temp_Shift.DataPropertyName = "temp_Shift"
        Me.temp_Shift.HeaderText = "Turno"
        Me.temp_Shift.Name = "temp_Shift"
        Me.temp_Shift.Width = 60
        '
        'temp_Process
        '
        Me.temp_Process.DataPropertyName = "temp_Process"
        Me.temp_Process.HeaderText = "Proceso"
        Me.temp_Process.Name = "temp_Process"
        '
        'temp_Line
        '
        Me.temp_Line.DataPropertyName = "temp_Line"
        Me.temp_Line.HeaderText = "Línea"
        Me.temp_Line.Name = "temp_Line"
        Me.temp_Line.Width = 50
        '
        'temp_Comments
        '
        Me.temp_Comments.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.temp_Comments.DataPropertyName = "temp_Comments"
        Me.temp_Comments.HeaderText = "Comentarios"
        Me.temp_Comments.Name = "temp_Comments"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1193, 675)
        Me.Controls.Add(Me.labelMailContact)
        Me.Controls.Add(Me.amRefCheckBox)
        Me.Controls.Add(Me.aftermarket_Button)
        Me.Controls.Add(Me.toolsFormButton)
        Me.Controls.Add(Me.buildNumberLabel)
        Me.Controls.Add(Me.scrapCheckBoxLogo)
        Me.Controls.Add(Me.finalRefCheckBoxLogo)
        Me.Controls.Add(Me.scrapTextBox)
        Me.Controls.Add(Me.scrapLabel)
        Me.Controls.Add(Me.finalRefLabel)
        Me.Controls.Add(Me.finalRefTextBox)
        Me.Controls.Add(Me.updateFormButton)
        Me.Controls.Add(Me.lineCheckBoxLogo)
        Me.Controls.Add(Me.quantityCheckBoxLogo)
        Me.Controls.Add(Me.procCheckBoxLogo)
        Me.Controls.Add(Me.refCheckBoxLogo)
        Me.Controls.Add(Me.sageCheckBox)
        Me.Controls.Add(Me.deleteDataButton)
        Me.Controls.Add(Me.searchBoxLabel)
        Me.Controls.Add(Me.searchBox)
        Me.Controls.Add(Me.procDataGridView)
        Me.Controls.Add(Me.beszLabel)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.lineTextBox)
        Me.Controls.Add(Me.lineLabel)
        Me.Controls.Add(Me.processLabel)
        Me.Controls.Add(Me.processTextBox)
        Me.Controls.Add(Me.commentsLabel)
        Me.Controls.Add(Me.commentsTextBox)
        Me.Controls.Add(Me.shiftLabel)
        Me.Controls.Add(Me.shiftComboBox)
        Me.Controls.Add(Me.managerLabel)
        Me.Controls.Add(Me.managerComboBox)
        Me.Controls.Add(Me.loadDataButton)
        Me.Controls.Add(Me.reportDataGridView1)
        Me.Controls.Add(Me.addDataButton)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.QuantityLabel)
        Me.Controls.Add(Me.quantityTextBox)
        Me.Controls.Add(Me.ref_Label)
        Me.Controls.Add(Me.refTextBox)
        Me.Controls.Add(Me.datePicker_Label)
        Me.Controls.Add(Me.datePicker)
        Me.Controls.Add(Me.title_Label)
        Me.Controls.Add(Me.BosalLogo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Producción"
        CType(Me.BosalLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALLBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Registro_ProduccionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reportDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TempReportTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Registro_ProduccionDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActiveManagersQueryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ManagersTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.Tab1Bending.ResumeLayout(False)
        Me.Tab2Box.ResumeLayout(False)
        Me.Tab2Welding.ResumeLayout(False)
        Me.Tab4Final.ResumeLayout(False)
        Me.Tab5All.ResumeLayout(False)
        CType(Me.procDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.refCheckBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.procCheckBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lineCheckBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.quantityCheckBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.finalRefCheckBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.scrapCheckBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALLBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALLTableAdapterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BosalLogo As PictureBox
    Friend WithEvents title_Label As Label
    Friend WithEvents datePicker As DateTimePicker
    Friend WithEvents datePicker_Label As Label
    Friend WithEvents refListBoxComplete As ListBox
    Friend WithEvents Registro_ProduccionDataSet As Registro_ProduccionDataSet
    Friend WithEvents ALLBindingSource As BindingSource
    Friend WithEvents ALLTableAdapter As Registro_ProduccionDataSetTableAdapters.ALLTableAdapter
    Friend WithEvents refTextBox As TextBox
    Friend WithEvents ref_Label As Label
    Friend WithEvents quantityTextBox As TextBox
    Friend WithEvents QuantityLabel As Label
    Friend WithEvents exitButton As Button
    Friend WithEvents addDataButton As Button
    Friend WithEvents ReportTableBindingSource As BindingSource
    Friend WithEvents Report_TableTableAdapter As Registro_ProduccionDataSetTableAdapters.Report_TableTableAdapter
    Friend WithEvents reportDataGridView1 As DataGridView
    Friend WithEvents Registro_ProduccionDataSet1 As Registro_ProduccionDataSet
    Friend WithEvents TempReportTableBindingSource As BindingSource
    Friend WithEvents Temp_Report_TableTableAdapter As Registro_ProduccionDataSetTableAdapters.temp_Report_TableTableAdapter
    Friend WithEvents loadDataButton As Button
    Friend WithEvents managerComboBox As ComboBox
    Friend WithEvents managerLabel As Label
    Friend WithEvents shiftComboBox As ComboBox
    Friend WithEvents shiftLabel As Label
    Friend WithEvents commentsTextBox As TextBox
    Friend WithEvents commentsLabel As Label
    Friend WithEvents processTextBox As TextBox
    Friend WithEvents processLabel As Label
    Friend WithEvents lineLabel As Label
    Friend WithEvents lineTextBox As TextBox
    Friend WithEvents TempDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TempReferenceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TempQuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TempSAGEDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents TempWeekDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TempManagerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TempShiftDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TempCommentsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TempProcessDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TempLineDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    'Friend WithEvents BENDINGTableAdapter As Registro_ProduccionDataSetTableAdapters.BENDINGTableAdapter
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Tab1Bending As TabPage
    Friend WithEvents refListBending As ListBox
    Friend WithEvents Tab2Box As TabPage
    Friend WithEvents Tab2Welding As TabPage
    Friend WithEvents Tab4Final As TabPage
    Friend WithEvents Tab5All As TabPage
    Friend WithEvents refListBox As ListBox
    'Friend WithEvents BOXTableAdapter As Registro_ProduccionDataSetTableAdapters.BOXTableAdapter
    Friend WithEvents refListWelding As ListBox
    'Friend WithEvents WELDINGTableAdapter As Registro_ProduccionDataSetTableAdapters.WELDINGTableAdapter
    Friend WithEvents refListFinal As ListBox
    'Friend WithEvents FINALTableAdapter As Registro_ProduccionDataSetTableAdapters.FINALTableAdapter
    Friend WithEvents beszLabel As Label
    Friend WithEvents procDataGridView As DataGridView
    Friend WithEvents searchBox As TextBox
    Friend WithEvents ALLBindingSource1 As BindingSource
    Friend WithEvents ALLTableAdapterBindingSource As BindingSource
    Friend WithEvents searchBoxLabel As Label
    Friend WithEvents deleteDataButton As Button
    Friend WithEvents sageCheckBox As CheckBox
    Friend WithEvents refCheckBoxLogo As PictureBox
    Friend WithEvents procCheckBoxLogo As PictureBox
    Friend WithEvents lineCheckBoxLogo As PictureBox
    Friend WithEvents quantityCheckBoxLogo As PictureBox
    Friend WithEvents updateFormButton As Button
    Friend WithEvents finalRefTextBox As TextBox
    Friend WithEvents finalRefLabel As Label
    Friend WithEvents scrapTextBox As TextBox
    Friend WithEvents scrapLabel As Label
    Friend WithEvents finalRefCheckBoxLogo As PictureBox
    Friend WithEvents scrapCheckBoxLogo As PictureBox
    Friend WithEvents ReferenceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Final_Ref As DataGridViewTextBoxColumn
    Friend WithEvents Process As DataGridViewTextBoxColumn
    Friend WithEvents Line As DataGridViewTextBoxColumn
    Friend WithEvents buildNumberLabel As Label
    Friend WithEvents toolsFormButton As Button
    Friend WithEvents aftermarket_Button As Button
    Friend WithEvents amRefCheckBox As CheckBox
    Friend WithEvents labelMailContact As LinkLabel
    Friend WithEvents ManagersTableBindingSource As BindingSource
    Friend WithEvents Managers_TableTableAdapter As Registro_ProduccionDataSetTableAdapters.Managers_TableTableAdapter
    Friend WithEvents ActiveManagersQueryBindingSource As BindingSource
    Friend WithEvents Active_Managers_QueryTableAdapter As Registro_ProduccionDataSetTableAdapters.Active_Managers_QueryTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents temp_Date As DataGridViewTextBoxColumn
    Friend WithEvents temp_FinalRef As DataGridViewTextBoxColumn
    Friend WithEvents temp_Reference As DataGridViewTextBoxColumn
    Friend WithEvents temp_Quantity As DataGridViewTextBoxColumn
    Friend WithEvents temp_Scrap As DataGridViewTextBoxColumn
    Friend WithEvents temp_SAGE As DataGridViewCheckBoxColumn
    Friend WithEvents temp_Week As DataGridViewTextBoxColumn
    Friend WithEvents temp_Manager As DataGridViewTextBoxColumn
    Friend WithEvents temp_Shift As DataGridViewTextBoxColumn
    Friend WithEvents temp_Process As DataGridViewTextBoxColumn
    Friend WithEvents temp_Line As DataGridViewTextBoxColumn
    Friend WithEvents temp_Comments As DataGridViewTextBoxColumn
End Class

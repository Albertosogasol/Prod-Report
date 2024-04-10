<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExportDataForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ExportDataForm))
        Me.startExportDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.endExportDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.exportButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'startExportDatePicker
        '
        Me.startExportDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.startExportDatePicker.Location = New System.Drawing.Point(56, 53)
        Me.startExportDatePicker.Name = "startExportDatePicker"
        Me.startExportDatePicker.Size = New System.Drawing.Size(93, 20)
        Me.startExportDatePicker.TabIndex = 0
        '
        'endExportDatePicker
        '
        Me.endExportDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.endExportDatePicker.Location = New System.Drawing.Point(56, 94)
        Me.endExportDatePicker.Name = "endExportDatePicker"
        Me.endExportDatePicker.Size = New System.Drawing.Size(93, 20)
        Me.endExportDatePicker.TabIndex = 1
        '
        'exportButton
        '
        Me.exportButton.Location = New System.Drawing.Point(273, 75)
        Me.exportButton.Name = "exportButton"
        Me.exportButton.Size = New System.Drawing.Size(75, 23)
        Me.exportButton.TabIndex = 2
        Me.exportButton.Text = "Button1"
        Me.exportButton.UseVisualStyleBackColor = True
        '
        'ExportDataForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 342)
        Me.Controls.Add(Me.exportButton)
        Me.Controls.Add(Me.endExportDatePicker)
        Me.Controls.Add(Me.startExportDatePicker)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ExportDataForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ExportDataForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents startExportDatePicker As DateTimePicker
    Friend WithEvents endExportDatePicker As DateTimePicker
    Friend WithEvents exportButton As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ToolsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ToolsForm))
        Me.toolFormCloseButton = New System.Windows.Forms.Button()
        Me.refTreeViewButton = New System.Windows.Forms.Button()
        Me.exportDataButton = New System.Windows.Forms.PictureBox()
        Me.dbQueryFormButton = New System.Windows.Forms.Button()
        CType(Me.exportDataButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'toolFormCloseButton
        '
        Me.toolFormCloseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.toolFormCloseButton.Location = New System.Drawing.Point(397, 347)
        Me.toolFormCloseButton.Name = "toolFormCloseButton"
        Me.toolFormCloseButton.Size = New System.Drawing.Size(75, 42)
        Me.toolFormCloseButton.TabIndex = 1
        Me.toolFormCloseButton.Text = "Cerrar"
        Me.toolFormCloseButton.UseVisualStyleBackColor = True
        '
        'refTreeViewButton
        '
        Me.refTreeViewButton.Location = New System.Drawing.Point(342, 151)
        Me.refTreeViewButton.Name = "refTreeViewButton"
        Me.refTreeViewButton.Size = New System.Drawing.Size(75, 53)
        Me.refTreeViewButton.TabIndex = 2
        Me.refTreeViewButton.Text = "Arbol"
        Me.refTreeViewButton.UseVisualStyleBackColor = True
        Me.refTreeViewButton.Visible = False
        '
        'exportDataButton
        '
        Me.exportDataButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.exportDataButton.Image = CType(resources.GetObject("exportDataButton.Image"), System.Drawing.Image)
        Me.exportDataButton.Location = New System.Drawing.Point(355, 47)
        Me.exportDataButton.Name = "exportDataButton"
        Me.exportDataButton.Size = New System.Drawing.Size(77, 77)
        Me.exportDataButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.exportDataButton.TabIndex = 0
        Me.exportDataButton.TabStop = False
        Me.exportDataButton.Visible = False
        '
        'dbQueryFormButton
        '
        Me.dbQueryFormButton.Location = New System.Drawing.Point(41, 47)
        Me.dbQueryFormButton.Name = "dbQueryFormButton"
        Me.dbQueryFormButton.Size = New System.Drawing.Size(98, 54)
        Me.dbQueryFormButton.TabIndex = 3
        Me.dbQueryFormButton.Text = "Consultar base de datos"
        Me.dbQueryFormButton.UseVisualStyleBackColor = True
        '
        'ToolsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 401)
        Me.Controls.Add(Me.dbQueryFormButton)
        Me.Controls.Add(Me.refTreeViewButton)
        Me.Controls.Add(Me.toolFormCloseButton)
        Me.Controls.Add(Me.exportDataButton)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(500, 440)
        Me.MinimumSize = New System.Drawing.Size(500, 39)
        Me.Name = "ToolsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Herramientas"
        CType(Me.exportDataButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents exportDataButton As PictureBox
    Friend WithEvents toolFormCloseButton As Button
    Friend WithEvents refTreeViewButton As Button
    Friend WithEvents dbQueryFormButton As Button
End Class

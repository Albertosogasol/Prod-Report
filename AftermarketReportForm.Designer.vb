<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AftermarketReportForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AftermarketReportForm))
        Me.amRefTextbox = New System.Windows.Forms.TextBox()
        Me.amRefLabel = New System.Windows.Forms.Label()
        Me.amProcessLabel = New System.Windows.Forms.Label()
        Me.amFinalRefLabel = New System.Windows.Forms.Label()
        Me.amFinalRefTextBox = New System.Windows.Forms.TextBox()
        Me.amQuantityLabel = New System.Windows.Forms.Label()
        Me.amQuantityTextBox = New System.Windows.Forms.TextBox()
        Me.amScrapLabel = New System.Windows.Forms.Label()
        Me.amScrapTextBox = New System.Windows.Forms.TextBox()
        Me.amLineLabel = New System.Windows.Forms.Label()
        Me.amLineTextBox = New System.Windows.Forms.TextBox()
        Me.amProcessComboBox = New System.Windows.Forms.ComboBox()
        Me.amLoadDataButton = New System.Windows.Forms.Button()
        Me.amCancelButton = New System.Windows.Forms.Button()
        Me.amTitleLabel = New System.Windows.Forms.Label()
        Me.amNoteLabel = New System.Windows.Forms.Label()
        Me.amLineHelpLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'amRefTextbox
        '
        Me.amRefTextbox.Location = New System.Drawing.Point(64, 121)
        Me.amRefTextbox.Name = "amRefTextbox"
        Me.amRefTextbox.Size = New System.Drawing.Size(121, 20)
        Me.amRefTextbox.TabIndex = 0
        '
        'amRefLabel
        '
        Me.amRefLabel.AutoSize = True
        Me.amRefLabel.Location = New System.Drawing.Point(61, 105)
        Me.amRefLabel.Name = "amRefLabel"
        Me.amRefLabel.Size = New System.Drawing.Size(59, 13)
        Me.amRefLabel.TabIndex = 1
        Me.amRefLabel.Text = "Referencia"
        '
        'amProcessLabel
        '
        Me.amProcessLabel.AutoSize = True
        Me.amProcessLabel.Location = New System.Drawing.Point(61, 158)
        Me.amProcessLabel.Name = "amProcessLabel"
        Me.amProcessLabel.Size = New System.Drawing.Size(46, 13)
        Me.amProcessLabel.TabIndex = 3
        Me.amProcessLabel.Text = "Proceso"
        '
        'amFinalRefLabel
        '
        Me.amFinalRefLabel.AutoSize = True
        Me.amFinalRefLabel.Location = New System.Drawing.Point(61, 211)
        Me.amFinalRefLabel.Name = "amFinalRefLabel"
        Me.amFinalRefLabel.Size = New System.Drawing.Size(84, 13)
        Me.amFinalRefLabel.TabIndex = 5
        Me.amFinalRefLabel.Text = "Referencia Final"
        '
        'amFinalRefTextBox
        '
        Me.amFinalRefTextBox.Location = New System.Drawing.Point(64, 227)
        Me.amFinalRefTextBox.Name = "amFinalRefTextBox"
        Me.amFinalRefTextBox.Size = New System.Drawing.Size(121, 20)
        Me.amFinalRefTextBox.TabIndex = 4
        '
        'amQuantityLabel
        '
        Me.amQuantityLabel.AutoSize = True
        Me.amQuantityLabel.Location = New System.Drawing.Point(244, 105)
        Me.amQuantityLabel.Name = "amQuantityLabel"
        Me.amQuantityLabel.Size = New System.Drawing.Size(49, 13)
        Me.amQuantityLabel.TabIndex = 7
        Me.amQuantityLabel.Text = "Cantidad"
        '
        'amQuantityTextBox
        '
        Me.amQuantityTextBox.Location = New System.Drawing.Point(247, 121)
        Me.amQuantityTextBox.Name = "amQuantityTextBox"
        Me.amQuantityTextBox.Size = New System.Drawing.Size(121, 20)
        Me.amQuantityTextBox.TabIndex = 6
        '
        'amScrapLabel
        '
        Me.amScrapLabel.AutoSize = True
        Me.amScrapLabel.Location = New System.Drawing.Point(244, 158)
        Me.amScrapLabel.Name = "amScrapLabel"
        Me.amScrapLabel.Size = New System.Drawing.Size(35, 13)
        Me.amScrapLabel.TabIndex = 9
        Me.amScrapLabel.Text = "Scrap"
        '
        'amScrapTextBox
        '
        Me.amScrapTextBox.Location = New System.Drawing.Point(247, 174)
        Me.amScrapTextBox.Name = "amScrapTextBox"
        Me.amScrapTextBox.Size = New System.Drawing.Size(121, 20)
        Me.amScrapTextBox.TabIndex = 8
        '
        'amLineLabel
        '
        Me.amLineLabel.AutoSize = True
        Me.amLineLabel.Location = New System.Drawing.Point(244, 211)
        Me.amLineLabel.Name = "amLineLabel"
        Me.amLineLabel.Size = New System.Drawing.Size(35, 13)
        Me.amLineLabel.TabIndex = 11
        Me.amLineLabel.Text = "Línea"
        '
        'amLineTextBox
        '
        Me.amLineTextBox.Location = New System.Drawing.Point(247, 227)
        Me.amLineTextBox.Name = "amLineTextBox"
        Me.amLineTextBox.Size = New System.Drawing.Size(121, 20)
        Me.amLineTextBox.TabIndex = 10
        '
        'amProcessComboBox
        '
        Me.amProcessComboBox.FormattingEnabled = True
        Me.amProcessComboBox.Items.AddRange(New Object() {"BENDING", "BOX", "WELDING", "ATKINS", "SANDERSON", "FINAL"})
        Me.amProcessComboBox.Location = New System.Drawing.Point(64, 174)
        Me.amProcessComboBox.Name = "amProcessComboBox"
        Me.amProcessComboBox.Size = New System.Drawing.Size(121, 21)
        Me.amProcessComboBox.TabIndex = 12
        '
        'amLoadDataButton
        '
        Me.amLoadDataButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.amLoadDataButton.Location = New System.Drawing.Point(213, 366)
        Me.amLoadDataButton.Name = "amLoadDataButton"
        Me.amLoadDataButton.Size = New System.Drawing.Size(91, 29)
        Me.amLoadDataButton.TabIndex = 13
        Me.amLoadDataButton.Text = "Aceptar"
        Me.amLoadDataButton.UseVisualStyleBackColor = True
        '
        'amCancelButton
        '
        Me.amCancelButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.amCancelButton.Location = New System.Drawing.Point(330, 366)
        Me.amCancelButton.Name = "amCancelButton"
        Me.amCancelButton.Size = New System.Drawing.Size(91, 29)
        Me.amCancelButton.TabIndex = 14
        Me.amCancelButton.Text = "Cancelar"
        Me.amCancelButton.UseVisualStyleBackColor = True
        '
        'amTitleLabel
        '
        Me.amTitleLabel.AutoSize = True
        Me.amTitleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amTitleLabel.Location = New System.Drawing.Point(121, 41)
        Me.amTitleLabel.Name = "amTitleLabel"
        Me.amTitleLabel.Size = New System.Drawing.Size(193, 31)
        Me.amTitleLabel.TabIndex = 15
        Me.amTitleLabel.Text = "Referencia AM"
        '
        'amNoteLabel
        '
        Me.amNoteLabel.AutoSize = True
        Me.amNoteLabel.Location = New System.Drawing.Point(30, 325)
        Me.amNoteLabel.Name = "amNoteLabel"
        Me.amNoteLabel.Size = New System.Drawing.Size(345, 26)
        Me.amNoteLabel.TabIndex = 16
        Me.amNoteLabel.Text = "*Nota: Asegúrese de rellenar todos los campos correctamente antes de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "pulsar el " &
    "botón aceptar"
        '
        'amLineHelpLabel
        '
        Me.amLineHelpLabel.AutoSize = True
        Me.amLineHelpLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amLineHelpLabel.Location = New System.Drawing.Point(244, 250)
        Me.amLineHelpLabel.Name = "amLineHelpLabel"
        Me.amLineHelpLabel.Size = New System.Drawing.Size(175, 12)
        Me.amLineHelpLabel.TabIndex = 17
        Me.amLineHelpLabel.Text = "(Introducir unicamente el número de línea)"
        '
        'AftermarketReportForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 407)
        Me.Controls.Add(Me.amLineHelpLabel)
        Me.Controls.Add(Me.amNoteLabel)
        Me.Controls.Add(Me.amTitleLabel)
        Me.Controls.Add(Me.amCancelButton)
        Me.Controls.Add(Me.amLoadDataButton)
        Me.Controls.Add(Me.amProcessComboBox)
        Me.Controls.Add(Me.amLineLabel)
        Me.Controls.Add(Me.amLineTextBox)
        Me.Controls.Add(Me.amScrapLabel)
        Me.Controls.Add(Me.amScrapTextBox)
        Me.Controls.Add(Me.amQuantityLabel)
        Me.Controls.Add(Me.amQuantityTextBox)
        Me.Controls.Add(Me.amFinalRefLabel)
        Me.Controls.Add(Me.amFinalRefTextBox)
        Me.Controls.Add(Me.amProcessLabel)
        Me.Controls.Add(Me.amRefLabel)
        Me.Controls.Add(Me.amRefTextbox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(449, 446)
        Me.MinimumSize = New System.Drawing.Size(449, 446)
        Me.Name = "AftermarketReportForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de AM"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents amRefTextbox As TextBox
    Friend WithEvents amRefLabel As Label
    Friend WithEvents amProcessLabel As Label
    Friend WithEvents amFinalRefLabel As Label
    Friend WithEvents amFinalRefTextBox As TextBox
    Friend WithEvents amQuantityLabel As Label
    Friend WithEvents amQuantityTextBox As TextBox
    Friend WithEvents amScrapLabel As Label
    Friend WithEvents amScrapTextBox As TextBox
    Friend WithEvents amLineLabel As Label
    Friend WithEvents amLineTextBox As TextBox
    Friend WithEvents amProcessComboBox As ComboBox
    Friend WithEvents amLoadDataButton As Button
    Friend WithEvents amCancelButton As Button
    Friend WithEvents amTitleLabel As Label
    Friend WithEvents amNoteLabel As Label
    Friend WithEvents amLineHelpLabel As Label
End Class

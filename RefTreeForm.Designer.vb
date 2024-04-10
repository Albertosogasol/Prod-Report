<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RefTreeForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RefTreeForm))
        Me.refTreeView = New System.Windows.Forms.TreeView()
        Me.SuspendLayout()
        '
        'refTreeView
        '
        Me.refTreeView.Location = New System.Drawing.Point(422, 75)
        Me.refTreeView.Name = "refTreeView"
        Me.refTreeView.Size = New System.Drawing.Size(303, 264)
        Me.refTreeView.TabIndex = 0
        '
        'RefTreeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.refTreeView)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RefTreeForm"
        Me.Text = "RefTreeForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents refTreeView As TreeView
End Class

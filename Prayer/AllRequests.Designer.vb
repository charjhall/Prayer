<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AllRequests
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
        Me.RequestTextBox = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'RequestTextBox
        '
        Me.RequestTextBox.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.RequestTextBox.Location = New System.Drawing.Point(0, 60)
        Me.RequestTextBox.Name = "RequestTextBox"
        Me.RequestTextBox.Size = New System.Drawing.Size(800, 390)
        Me.RequestTextBox.TabIndex = 0
        Me.RequestTextBox.Text = ""
        '
        'AllRequests
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.RequestTextBox)
        Me.Name = "AllRequests"
        Me.Text = "AllRequests"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RequestTextBox As RichTextBox
End Class

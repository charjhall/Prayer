<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Welcome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Welcome))
        Me.AddRequestButton = New System.Windows.Forms.Button()
        Me.UploadFileButton = New System.Windows.Forms.Button()
        Me.OpenFileDialogRequests = New System.Windows.Forms.OpenFileDialog()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'AddRequestButton
        '
        Me.AddRequestButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.AddRequestButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.AddRequestButton.FlatAppearance.BorderSize = 0
        Me.AddRequestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddRequestButton.Font = New System.Drawing.Font("Goudy Old Style", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddRequestButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.AddRequestButton.Location = New System.Drawing.Point(9, 102)
        Me.AddRequestButton.Margin = New System.Windows.Forms.Padding(12)
        Me.AddRequestButton.Name = "AddRequestButton"
        Me.AddRequestButton.Size = New System.Drawing.Size(206, 139)
        Me.AddRequestButton.TabIndex = 10
        Me.AddRequestButton.Text = "Add a request"
        Me.AddRequestButton.UseVisualStyleBackColor = False
        '
        'UploadFileButton
        '
        Me.UploadFileButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.UploadFileButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.UploadFileButton.FlatAppearance.BorderSize = 0
        Me.UploadFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UploadFileButton.Font = New System.Drawing.Font("Goudy Old Style", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UploadFileButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.UploadFileButton.Location = New System.Drawing.Point(239, 102)
        Me.UploadFileButton.Margin = New System.Windows.Forms.Padding(12)
        Me.UploadFileButton.Name = "UploadFileButton"
        Me.UploadFileButton.Size = New System.Drawing.Size(206, 139)
        Me.UploadFileButton.TabIndex = 11
        Me.UploadFileButton.Text = "Upload a prayer request file"
        Me.UploadFileButton.UseVisualStyleBackColor = False
        '
        'OpenFileDialogRequests
        '
        Me.OpenFileDialogRequests.Filter = """txt files (*.txt)|*.txt|All files (*.*)|*.*"""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label5.Font = New System.Drawing.Font("Goudy Old Style", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(-2, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(464, 43)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Welcome to Prayer Reminder!"
        '
        'Welcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(456, 276)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.UploadFileButton)
        Me.Controls.Add(Me.AddRequestButton)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Welcome"
        Me.Text = "Welcome"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AddRequestButton As Button
    Friend WithEvents UploadFileButton As Button
    Friend WithEvents OpenFileDialogRequests As OpenFileDialog
    Friend WithEvents Label5 As Label
End Class

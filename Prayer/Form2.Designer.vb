<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Prayer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Prayer))
        Me.prayer_request_label = New System.Windows.Forms.Label()
        Me.EditRequestButton = New System.Windows.Forms.Button()
        Me.PrayerRequestTitle = New System.Windows.Forms.Label()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.UpdateRequestText = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'prayer_request_label
        '
        Me.prayer_request_label.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prayer_request_label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.prayer_request_label.Location = New System.Drawing.Point(0, 39)
        Me.prayer_request_label.Name = "prayer_request_label"
        Me.prayer_request_label.Size = New System.Drawing.Size(418, 125)
        Me.prayer_request_label.TabIndex = 1
        Me.prayer_request_label.Text = "Prayer Request"
        '
        'EditRequestButton
        '
        Me.EditRequestButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.EditRequestButton.Cursor = System.Windows.Forms.Cursors.Default
        Me.EditRequestButton.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.EditRequestButton.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditRequestButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.EditRequestButton.Location = New System.Drawing.Point(0, 374)
        Me.EditRequestButton.Name = "EditRequestButton"
        Me.EditRequestButton.Size = New System.Drawing.Size(418, 151)
        Me.EditRequestButton.TabIndex = 3
        Me.EditRequestButton.Text = "Edit This Request"
        Me.EditRequestButton.UseVisualStyleBackColor = False
        '
        'PrayerRequestTitle
        '
        Me.PrayerRequestTitle.Font = New System.Drawing.Font("Goudy Old Style", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrayerRequestTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.PrayerRequestTitle.Location = New System.Drawing.Point(0, 0)
        Me.PrayerRequestTitle.Name = "PrayerRequestTitle"
        Me.PrayerRequestTitle.Size = New System.Drawing.Size(418, 39)
        Me.PrayerRequestTitle.TabIndex = 4
        Me.PrayerRequestTitle.Text = "Prayer Request"
        '
        'UpdateButton
        '
        Me.UpdateButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.UpdateButton.Cursor = System.Windows.Forms.Cursors.Default
        Me.UpdateButton.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.UpdateButton.Location = New System.Drawing.Point(285, 167)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(134, 208)
        Me.UpdateButton.TabIndex = 7
        Me.UpdateButton.Text = "Submit Changes"
        Me.UpdateButton.UseVisualStyleBackColor = False
        Me.UpdateButton.Visible = False
        '
        'UpdateRequestText
        '
        Me.UpdateRequestText.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.UpdateRequestText.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateRequestText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.UpdateRequestText.Location = New System.Drawing.Point(6, 167)
        Me.UpdateRequestText.Name = "UpdateRequestText"
        Me.UpdateRequestText.Size = New System.Drawing.Size(273, 205)
        Me.UpdateRequestText.TabIndex = 8
        Me.UpdateRequestText.Text = ""
        Me.UpdateRequestText.Visible = False
        '
        'Prayer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(418, 525)
        Me.Controls.Add(Me.UpdateRequestText)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.PrayerRequestTitle)
        Me.Controls.Add(Me.EditRequestButton)
        Me.Controls.Add(Me.prayer_request_label)
        Me.Font = New System.Drawing.Font("Goudy Old Style", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Prayer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Prayer Reminder"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents prayer_request_label As Label
    Friend WithEvents EditRequestButton As Button
    Friend WithEvents PrayerRequestTitle As Label
    Friend WithEvents UpdateButton As Button
    Friend WithEvents UpdateRequestText As RichTextBox
End Class

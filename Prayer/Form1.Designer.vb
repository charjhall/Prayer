<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.OpenFileDialogRequests = New System.Windows.Forms.OpenFileDialog()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TimerEnabledButton = New System.Windows.Forms.Button()
        Me.NextTimeLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipText = "Notification" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.NotifyIcon1.BalloonTipTitle = "Notify"
        Me.NotifyIcon1.Text = "NotifyIcon"
        Me.NotifyIcon1.Visible = True
        '
        'OpenFileDialogRequests
        '
        Me.OpenFileDialogRequests.Filter = """txt files (*.txt)|*.txt|All files (*.*)|*.*"""
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Goudy Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(557, 156)
        Me.Button3.Margin = New System.Windows.Forms.Padding(9)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(121, 33)
        Me.Button3.TabIndex = 45
        Me.Button3.Text = "Refresh"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Goudy Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Button4.Location = New System.Drawing.Point(466, 228)
        Me.Button4.Margin = New System.Windows.Forms.Padding(9)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(212, 62)
        Me.Button4.TabIndex = 42
        Me.Button4.Text = "Show Next Request Now"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'TimerEnabledButton
        '
        Me.TimerEnabledButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.TimerEnabledButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.TimerEnabledButton.FlatAppearance.BorderSize = 0
        Me.TimerEnabledButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TimerEnabledButton.Font = New System.Drawing.Font("Goudy Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimerEnabledButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TimerEnabledButton.Location = New System.Drawing.Point(18, 156)
        Me.TimerEnabledButton.Margin = New System.Windows.Forms.Padding(9)
        Me.TimerEnabledButton.Name = "TimerEnabledButton"
        Me.TimerEnabledButton.Size = New System.Drawing.Size(154, 33)
        Me.TimerEnabledButton.TabIndex = 46
        Me.TimerEnabledButton.Text = "Pause"
        Me.TimerEnabledButton.UseVisualStyleBackColor = False
        '
        'NextTimeLabel
        '
        Me.NextTimeLabel.AutoSize = True
        Me.NextTimeLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NextTimeLabel.Font = New System.Drawing.Font("Goudy Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NextTimeLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.NextTimeLabel.Location = New System.Drawing.Point(390, 162)
        Me.NextTimeLabel.Name = "NextTimeLabel"
        Me.NextTimeLabel.Size = New System.Drawing.Size(79, 21)
        Me.NextTimeLabel.TabIndex = 44
        Me.NextTimeLabel.Text = "Next Time"
        Me.NextTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Font = New System.Drawing.Font("Goudy Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(218, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 21)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Next Request Time:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Goudy Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Button5.Location = New System.Drawing.Point(18, 228)
        Me.Button5.Margin = New System.Windows.Forms.Padding(9)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(212, 62)
        Me.Button5.TabIndex = 41
        Me.Button5.Text = "See an Example Request"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Goudy Old Style", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(18, 33)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(660, 87)
        Me.Button1.TabIndex = 47
        Me.Button1.Text = "Add a Prayer Request"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(696, 324)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.TimerEnabledButton)
        Me.Controls.Add(Me.NextTimeLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button5)
        Me.Font = New System.Drawing.Font("Goudy Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reminder Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents OpenFileDialogRequests As OpenFileDialog
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TimerEnabledButton As Button
    Friend WithEvents NextTimeLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button1 As Button
End Class

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
        Me.SetIntervalButton = New System.Windows.Forms.Button()
        Me.IntervalTextBox = New System.Windows.Forms.TextBox()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.SetSourceFile = New System.Windows.Forms.Button()
        Me.OpenFileDialogRequests = New System.Windows.Forms.OpenFileDialog()
        Me.ExampleButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.IndexNum = New System.Windows.Forms.Label()
        Me.ChangeIndexButton = New System.Windows.Forms.Button()
        Me.IndexTextBox = New System.Windows.Forms.TextBox()
        Me.IntervalNum = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'SetIntervalButton
        '
        Me.SetIntervalButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.SetIntervalButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.SetIntervalButton.FlatAppearance.BorderSize = 0
        Me.SetIntervalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SetIntervalButton.Font = New System.Drawing.Font("Goudy Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SetIntervalButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.SetIntervalButton.Location = New System.Drawing.Point(287, 139)
        Me.SetIntervalButton.Margin = New System.Windows.Forms.Padding(4)
        Me.SetIntervalButton.Name = "SetIntervalButton"
        Me.SetIntervalButton.Size = New System.Drawing.Size(149, 114)
        Me.SetIntervalButton.TabIndex = 6
        Me.SetIntervalButton.Text = "Set Interval"
        Me.SetIntervalButton.UseVisualStyleBackColor = False
        '
        'IntervalTextBox
        '
        Me.IntervalTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.IntervalTextBox.Font = New System.Drawing.Font("Goudy Old Style", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IntervalTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.IntervalTextBox.Location = New System.Drawing.Point(287, 94)
        Me.IntervalTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.IntervalTextBox.Name = "IntervalTextBox"
        Me.IntervalTextBox.Size = New System.Drawing.Size(149, 40)
        Me.IntervalTextBox.TabIndex = 4
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipText = "Notification" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.NotifyIcon1.BalloonTipTitle = "Notify"
        Me.NotifyIcon1.Text = "NotifyIcon"
        Me.NotifyIcon1.Visible = True
        '
        'SetSourceFile
        '
        Me.SetSourceFile.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.SetSourceFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.SetSourceFile.FlatAppearance.BorderSize = 0
        Me.SetSourceFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SetSourceFile.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.SetSourceFile.Location = New System.Drawing.Point(8, 306)
        Me.SetSourceFile.Margin = New System.Windows.Forms.Padding(12)
        Me.SetSourceFile.Name = "SetSourceFile"
        Me.SetSourceFile.Size = New System.Drawing.Size(458, 29)
        Me.SetSourceFile.TabIndex = 9
        Me.SetSourceFile.Text = "First time here? Click here to select your prayer request file."
        Me.SetSourceFile.UseVisualStyleBackColor = False
        '
        'OpenFileDialogRequests
        '
        Me.OpenFileDialogRequests.Filter = """txt files (*.txt)|*.txt|All files (*.*)|*.*"""
        '
        'ExampleButton
        '
        Me.ExampleButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.ExampleButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.ExampleButton.FlatAppearance.BorderSize = 0
        Me.ExampleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExampleButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ExampleButton.Location = New System.Drawing.Point(8, 269)
        Me.ExampleButton.Margin = New System.Windows.Forms.Padding(12)
        Me.ExampleButton.Name = "ExampleButton"
        Me.ExampleButton.Size = New System.Drawing.Size(222, 28)
        Me.ExampleButton.TabIndex = 13
        Me.ExampleButton.Text = "See an Example Request"
        Me.ExampleButton.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(85, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 19)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Line:"
        '
        'IndexNum
        '
        Me.IndexNum.AutoSize = True
        Me.IndexNum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.IndexNum.Location = New System.Drawing.Point(130, 72)
        Me.IndexNum.Name = "IndexNum"
        Me.IndexNum.Size = New System.Drawing.Size(35, 19)
        Me.IndexNum.TabIndex = 22
        Me.IndexNum.Text = "Line"
        '
        'ChangeIndexButton
        '
        Me.ChangeIndexButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.ChangeIndexButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.ChangeIndexButton.FlatAppearance.BorderSize = 0
        Me.ChangeIndexButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChangeIndexButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ChangeIndexButton.Location = New System.Drawing.Point(48, 140)
        Me.ChangeIndexButton.Name = "ChangeIndexButton"
        Me.ChangeIndexButton.Size = New System.Drawing.Size(149, 114)
        Me.ChangeIndexButton.TabIndex = 23
        Me.ChangeIndexButton.Text = "Change Line"
        Me.ChangeIndexButton.UseVisualStyleBackColor = False
        '
        'IndexTextBox
        '
        Me.IndexTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.IndexTextBox.Font = New System.Drawing.Font("Goudy Old Style", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IndexTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.IndexTextBox.Location = New System.Drawing.Point(48, 94)
        Me.IndexTextBox.Name = "IndexTextBox"
        Me.IndexTextBox.Size = New System.Drawing.Size(149, 40)
        Me.IndexTextBox.TabIndex = 24
        '
        'IntervalNum
        '
        Me.IntervalNum.AutoSize = True
        Me.IntervalNum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.IntervalNum.Location = New System.Drawing.Point(366, 72)
        Me.IntervalNum.Name = "IntervalNum"
        Me.IntervalNum.Size = New System.Drawing.Size(54, 19)
        Me.IntervalNum.TabIndex = 27
        Me.IntervalNum.Text = "Interval"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(302, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 19)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Interval:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Goudy Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(1, 0)
        Me.Button1.Margin = New System.Windows.Forms.Padding(12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(473, 60)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Add Prayer Request"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Goudy Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(244, 269)
        Me.Button2.Margin = New System.Windows.Forms.Padding(12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(222, 28)
        Me.Button2.TabIndex = 32
        Me.Button2.Text = "Show next Request Now"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(474, 342)
        Me.Controls.Add(Me.ExampleButton)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.SetSourceFile)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.IntervalNum)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.IndexTextBox)
        Me.Controls.Add(Me.ChangeIndexButton)
        Me.Controls.Add(Me.IndexNum)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SetIntervalButton)
        Me.Controls.Add(Me.IntervalTextBox)
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
    Friend WithEvents SetIntervalButton As Button
    Friend WithEvents IntervalTextBox As TextBox
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents SetSourceFile As Button
    Friend WithEvents OpenFileDialogRequests As OpenFileDialog
    Friend WithEvents ExampleButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents IndexNum As Label
    Friend WithEvents ChangeIndexButton As Button
    Friend WithEvents IndexTextBox As TextBox
    Friend WithEvents IntervalNum As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class

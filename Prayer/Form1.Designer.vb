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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NextTimeLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'SetIntervalButton
        '
        Me.SetIntervalButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.TableLayoutPanel1.SetColumnSpan(Me.SetIntervalButton, 3)
        Me.SetIntervalButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SetIntervalButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.SetIntervalButton.FlatAppearance.BorderSize = 0
        Me.SetIntervalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SetIntervalButton.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SetIntervalButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.SetIntervalButton.Location = New System.Drawing.Point(244, 110)
        Me.SetIntervalButton.Margin = New System.Windows.Forms.Padding(10)
        Me.SetIntervalButton.Name = "SetIntervalButton"
        Me.SetIntervalButton.Size = New System.Drawing.Size(214, 104)
        Me.SetIntervalButton.TabIndex = 6
        Me.SetIntervalButton.Text = "Set Interval"
        Me.SetIntervalButton.UseVisualStyleBackColor = False
        '
        'IntervalTextBox
        '
        Me.IntervalTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.TableLayoutPanel1.SetColumnSpan(Me.IntervalTextBox, 3)
        Me.IntervalTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.IntervalTextBox.Font = New System.Drawing.Font("Goudy Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IntervalTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.IntervalTextBox.Location = New System.Drawing.Point(241, 57)
        Me.IntervalTextBox.Margin = New System.Windows.Forms.Padding(7)
        Me.IntervalTextBox.Name = "IntervalTextBox"
        Me.IntervalTextBox.Size = New System.Drawing.Size(220, 30)
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
        Me.SetSourceFile.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SetSourceFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.SetSourceFile.FlatAppearance.BorderSize = 0
        Me.SetSourceFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SetSourceFile.Font = New System.Drawing.Font("Goudy Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SetSourceFile.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.SetSourceFile.Location = New System.Drawing.Point(319, 9)
        Me.SetSourceFile.Margin = New System.Windows.Forms.Padding(9)
        Me.SetSourceFile.Name = "SetSourceFile"
        Me.SetSourceFile.Size = New System.Drawing.Size(140, 62)
        Me.SetSourceFile.TabIndex = 9
        Me.SetSourceFile.Text = "Add a file"
        Me.SetSourceFile.UseVisualStyleBackColor = False
        '
        'OpenFileDialogRequests
        '
        Me.OpenFileDialogRequests.Filter = """txt files (*.txt)|*.txt|All files (*.*)|*.*"""
        '
        'ExampleButton
        '
        Me.ExampleButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.ExampleButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ExampleButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.ExampleButton.FlatAppearance.BorderSize = 0
        Me.ExampleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExampleButton.Font = New System.Drawing.Font("Goudy Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExampleButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ExampleButton.Location = New System.Drawing.Point(9, 9)
        Me.ExampleButton.Margin = New System.Windows.Forms.Padding(9)
        Me.ExampleButton.Name = "ExampleButton"
        Me.ExampleButton.Size = New System.Drawing.Size(137, 62)
        Me.ExampleButton.TabIndex = 13
        Me.ExampleButton.Text = "See an Example Request"
        Me.ExampleButton.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Goudy Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 50)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Line:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'IndexNum
        '
        Me.IndexNum.AutoSize = True
        Me.IndexNum.Dock = System.Windows.Forms.DockStyle.Fill
        Me.IndexNum.Font = New System.Drawing.Font("Goudy Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IndexNum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.IndexNum.Location = New System.Drawing.Point(120, 0)
        Me.IndexNum.Name = "IndexNum"
        Me.IndexNum.Size = New System.Drawing.Size(111, 50)
        Me.IndexNum.TabIndex = 22
        Me.IndexNum.Text = "Line"
        Me.IndexNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ChangeIndexButton
        '
        Me.ChangeIndexButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.TableLayoutPanel1.SetColumnSpan(Me.ChangeIndexButton, 2)
        Me.ChangeIndexButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChangeIndexButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.ChangeIndexButton.FlatAppearance.BorderSize = 0
        Me.ChangeIndexButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChangeIndexButton.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChangeIndexButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ChangeIndexButton.Location = New System.Drawing.Point(10, 110)
        Me.ChangeIndexButton.Margin = New System.Windows.Forms.Padding(10)
        Me.ChangeIndexButton.Name = "ChangeIndexButton"
        Me.ChangeIndexButton.Size = New System.Drawing.Size(214, 104)
        Me.ChangeIndexButton.TabIndex = 23
        Me.ChangeIndexButton.Text = "Change Line"
        Me.ChangeIndexButton.UseVisualStyleBackColor = False
        '
        'IndexTextBox
        '
        Me.IndexTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.TableLayoutPanel1.SetColumnSpan(Me.IndexTextBox, 2)
        Me.IndexTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.IndexTextBox.Font = New System.Drawing.Font("Goudy Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IndexTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.IndexTextBox.Location = New System.Drawing.Point(7, 57)
        Me.IndexTextBox.Margin = New System.Windows.Forms.Padding(7)
        Me.IndexTextBox.Name = "IndexTextBox"
        Me.IndexTextBox.Size = New System.Drawing.Size(220, 30)
        Me.IndexTextBox.TabIndex = 24
        '
        'IntervalNum
        '
        Me.IntervalNum.AutoSize = True
        Me.IntervalNum.Dock = System.Windows.Forms.DockStyle.Fill
        Me.IntervalNum.Font = New System.Drawing.Font("Goudy Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IntervalNum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.IntervalNum.Location = New System.Drawing.Point(330, 0)
        Me.IntervalNum.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.IntervalNum.Name = "IntervalNum"
        Me.IntervalNum.Size = New System.Drawing.Size(43, 50)
        Me.IntervalNum.TabIndex = 27
        Me.IntervalNum.Text = "Min"
        Me.IntervalNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Goudy Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(237, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 50)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Interval:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Goudy Old Style", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(474, 189)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Add Prayer Request"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Goudy Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(164, 9)
        Me.Button2.Margin = New System.Windows.Forms.Padding(9)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(137, 62)
        Me.Button2.TabIndex = 32
        Me.Button2.Text = "Show Next Request Now"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Goudy Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(374, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(1, 0, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 50)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Min"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label3, 2)
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Goudy Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(3, 224)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(228, 51)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Next Request Time:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NextTimeLabel
        '
        Me.NextTimeLabel.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.NextTimeLabel, 2)
        Me.NextTimeLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NextTimeLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NextTimeLabel.Font = New System.Drawing.Font("Goudy Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NextTimeLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.NextTimeLabel.Location = New System.Drawing.Point(237, 224)
        Me.NextTimeLabel.Name = "NextTimeLabel"
        Me.NextTimeLabel.Size = New System.Drawing.Size(133, 51)
        Me.NextTimeLabel.TabIndex = 35
        Me.NextTimeLabel.Text = "Next Time"
        Me.NextTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.NextTimeLabel, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.IndexNum, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.IntervalTextBox, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.SetIntervalButton, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.IntervalNum, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.IndexTextBox, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ChangeIndexButton, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 197)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.18182!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.18182!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.45454!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.18182!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(468, 275)
        Me.TableLayoutPanel1.TabIndex = 36
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.Controls.Add(Me.ExampleButton, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Button2, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.SetSourceFile, 2, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 478)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(468, 80)
        Me.TableLayoutPanel2.TabIndex = 37
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Button1, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel2, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel1, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.67337!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.25126!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.07538!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(474, 561)
        Me.TableLayoutPanel3.TabIndex = 38
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(474, 561)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Font = New System.Drawing.Font("Goudy Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reminder Settings"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)

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
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents NextTimeLabel As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
End Class

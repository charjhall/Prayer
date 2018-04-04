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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IntervalTextBox = New System.Windows.Forms.TextBox()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.SetSourceFile = New System.Windows.Forms.Button()
        Me.OpenFileDialogRequests = New System.Windows.Forms.OpenFileDialog()
        Me.DebugButton = New System.Windows.Forms.Button()
        Me.ExampleButton = New System.Windows.Forms.Button()
        Me.YColonButton = New System.Windows.Forms.Button()
        Me.YColonRequest = New System.Windows.Forms.Label()
        Me.ExReqTitle = New System.Windows.Forms.Label()
        Me.YColonLabel = New System.Windows.Forms.Label()
        Me.NColonLabel = New System.Windows.Forms.Label()
        Me.NColonText = New System.Windows.Forms.Label()
        Me.NColonButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.IndexNum = New System.Windows.Forms.Label()
        Me.ChangeIndexButton = New System.Windows.Forms.Button()
        Me.IndexTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.IntervalNum = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FileSourceLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.NewRequestRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.SubmitRequestButton = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.NextRequestLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
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
        Me.SetIntervalButton.Location = New System.Drawing.Point(321, 82)
        Me.SetIntervalButton.Margin = New System.Windows.Forms.Padding(4)
        Me.SetIntervalButton.Name = "SetIntervalButton"
        Me.SetIntervalButton.Size = New System.Drawing.Size(100, 34)
        Me.SetIntervalButton.TabIndex = 6
        Me.SetIntervalButton.Text = "Set Interval"
        Me.SetIntervalButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Goudy Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(13, 90)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 19)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Interval (in minutes)"
        '
        'IntervalTextBox
        '
        Me.IntervalTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.IntervalTextBox.Font = New System.Drawing.Font("Goudy Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IntervalTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.IntervalTextBox.Location = New System.Drawing.Point(145, 87)
        Me.IntervalTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.IntervalTextBox.Name = "IntervalTextBox"
        Me.IntervalTextBox.Size = New System.Drawing.Size(132, 26)
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
        Me.SetSourceFile.Dock = System.Windows.Forms.DockStyle.Top
        Me.SetSourceFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.SetSourceFile.FlatAppearance.BorderSize = 0
        Me.SetSourceFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SetSourceFile.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.SetSourceFile.Location = New System.Drawing.Point(0, 0)
        Me.SetSourceFile.Name = "SetSourceFile"
        Me.SetSourceFile.Size = New System.Drawing.Size(584, 50)
        Me.SetSourceFile.TabIndex = 9
        Me.SetSourceFile.Text = "First time here? Click here to select your prayer request file."
        Me.SetSourceFile.UseVisualStyleBackColor = False
        '
        'OpenFileDialogRequests
        '
        Me.OpenFileDialogRequests.Filter = """txt files (*.txt)|*.txt|All files (*.*)|*.*"""
        '
        'DebugButton
        '
        Me.DebugButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.DebugButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.DebugButton.FlatAppearance.BorderSize = 0
        Me.DebugButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DebugButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.DebugButton.Location = New System.Drawing.Point(2, 582)
        Me.DebugButton.Name = "DebugButton"
        Me.DebugButton.Size = New System.Drawing.Size(75, 27)
        Me.DebugButton.TabIndex = 12
        Me.DebugButton.Text = "Debug Form2"
        Me.DebugButton.UseVisualStyleBackColor = False
        '
        'ExampleButton
        '
        Me.ExampleButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.ExampleButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.ExampleButton.FlatAppearance.BorderSize = 0
        Me.ExampleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExampleButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ExampleButton.Location = New System.Drawing.Point(414, 582)
        Me.ExampleButton.Name = "ExampleButton"
        Me.ExampleButton.Size = New System.Drawing.Size(172, 28)
        Me.ExampleButton.TabIndex = 13
        Me.ExampleButton.Text = "See an Example Request"
        Me.ExampleButton.UseVisualStyleBackColor = False
        '
        'YColonButton
        '
        Me.YColonButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.YColonButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.YColonButton.FlatAppearance.BorderSize = 0
        Me.YColonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.YColonButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.YColonButton.Location = New System.Drawing.Point(323, 495)
        Me.YColonButton.Name = "YColonButton"
        Me.YColonButton.Size = New System.Drawing.Size(174, 26)
        Me.YColonButton.TabIndex = 14
        Me.YColonButton.Text = "View Request as popup"
        Me.YColonButton.UseVisualStyleBackColor = False
        Me.YColonButton.Visible = False
        '
        'YColonRequest
        '
        Me.YColonRequest.AutoSize = True
        Me.YColonRequest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.YColonRequest.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.YColonRequest.Location = New System.Drawing.Point(115, 500)
        Me.YColonRequest.Name = "YColonRequest"
        Me.YColonRequest.Size = New System.Drawing.Size(202, 21)
        Me.YColonRequest.TabIndex = 15
        Me.YColonRequest.Text = "Mom: peace in raising crazy kids"
        Me.YColonRequest.Visible = False
        '
        'ExReqTitle
        '
        Me.ExReqTitle.AutoSize = True
        Me.ExReqTitle.Font = New System.Drawing.Font("Goudy Old Style", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExReqTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.ExReqTitle.Location = New System.Drawing.Point(128, 461)
        Me.ExReqTitle.Name = "ExReqTitle"
        Me.ExReqTitle.Size = New System.Drawing.Size(189, 20)
        Me.ExReqTitle.TabIndex = 16
        Me.ExReqTitle.Text = "In your Prayer request txt file"
        Me.ExReqTitle.Visible = False
        '
        'YColonLabel
        '
        Me.YColonLabel.AutoSize = True
        Me.YColonLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.YColonLabel.Location = New System.Drawing.Point(142, 481)
        Me.YColonLabel.Name = "YColonLabel"
        Me.YColonLabel.Size = New System.Drawing.Size(137, 19)
        Me.YColonLabel.TabIndex = 17
        Me.YColonLabel.Text = "With colon seperator"
        Me.YColonLabel.Visible = False
        '
        'NColonLabel
        '
        Me.NColonLabel.AutoSize = True
        Me.NColonLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.NColonLabel.Location = New System.Drawing.Point(142, 532)
        Me.NColonLabel.Name = "NColonLabel"
        Me.NColonLabel.Size = New System.Drawing.Size(158, 19)
        Me.NColonLabel.TabIndex = 19
        Me.NColonLabel.Text = "Without colon seperator"
        Me.NColonLabel.Visible = False
        '
        'NColonText
        '
        Me.NColonText.AutoSize = True
        Me.NColonText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.NColonText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.NColonText.Location = New System.Drawing.Point(85, 551)
        Me.NColonText.Name = "NColonText"
        Me.NColonText.Size = New System.Drawing.Size(232, 21)
        Me.NColonText.TabIndex = 18
        Me.NColonText.Text = "Mom, have peace in raising crazy kids"
        Me.NColonText.Visible = False
        '
        'NColonButton
        '
        Me.NColonButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.NColonButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.NColonButton.FlatAppearance.BorderSize = 0
        Me.NColonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NColonButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.NColonButton.Location = New System.Drawing.Point(323, 548)
        Me.NColonButton.Name = "NColonButton"
        Me.NColonButton.Size = New System.Drawing.Size(174, 25)
        Me.NColonButton.TabIndex = 20
        Me.NColonButton.Text = "View Request as popup"
        Me.NColonButton.UseVisualStyleBackColor = False
        Me.NColonButton.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(458, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 19)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Index:"
        '
        'IndexNum
        '
        Me.IndexNum.AutoSize = True
        Me.IndexNum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.IndexNum.Location = New System.Drawing.Point(511, 157)
        Me.IndexNum.Name = "IndexNum"
        Me.IndexNum.Size = New System.Drawing.Size(43, 19)
        Me.IndexNum.TabIndex = 22
        Me.IndexNum.Text = "Index"
        '
        'ChangeIndexButton
        '
        Me.ChangeIndexButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.ChangeIndexButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.ChangeIndexButton.FlatAppearance.BorderSize = 0
        Me.ChangeIndexButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChangeIndexButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ChangeIndexButton.Location = New System.Drawing.Point(314, 153)
        Me.ChangeIndexButton.Name = "ChangeIndexButton"
        Me.ChangeIndexButton.Size = New System.Drawing.Size(107, 27)
        Me.ChangeIndexButton.TabIndex = 23
        Me.ChangeIndexButton.Text = "Change Index"
        Me.ChangeIndexButton.UseVisualStyleBackColor = False
        '
        'IndexTextBox
        '
        Me.IndexTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.IndexTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.IndexTextBox.Location = New System.Drawing.Point(145, 153)
        Me.IndexTextBox.Name = "IndexTextBox"
        Me.IndexTextBox.Size = New System.Drawing.Size(132, 26)
        Me.IndexTextBox.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Goudy Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(13, 157)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 19)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Index"
        '
        'IntervalNum
        '
        Me.IntervalNum.AutoSize = True
        Me.IntervalNum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.IntervalNum.Location = New System.Drawing.Point(511, 87)
        Me.IntervalNum.Name = "IntervalNum"
        Me.IntervalNum.Size = New System.Drawing.Size(54, 19)
        Me.IntervalNum.TabIndex = 27
        Me.IntervalNum.Text = "Interval"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(458, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 19)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Interval:"
        '
        'FileSourceLinkLabel
        '
        Me.FileSourceLinkLabel.AutoSize = True
        Me.FileSourceLinkLabel.Location = New System.Drawing.Point(-2, 551)
        Me.FileSourceLinkLabel.Name = "FileSourceLinkLabel"
        Me.FileSourceLinkLabel.Size = New System.Drawing.Size(76, 19)
        Me.FileSourceLinkLabel.TabIndex = 28
        Me.FileSourceLinkLabel.TabStop = True
        Me.FileSourceLinkLabel.Text = "File Source"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Goudy Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(0, 195)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(584, 34)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Add Prayer Request"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'NewRequestRichTextBox
        '
        Me.NewRequestRichTextBox.Location = New System.Drawing.Point(12, 236)
        Me.NewRequestRichTextBox.Name = "NewRequestRichTextBox"
        Me.NewRequestRichTextBox.Size = New System.Drawing.Size(560, 96)
        Me.NewRequestRichTextBox.TabIndex = 30
        Me.NewRequestRichTextBox.Text = ""
        Me.NewRequestRichTextBox.Visible = False
        '
        'SubmitRequestButton
        '
        Me.SubmitRequestButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.SubmitRequestButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.SubmitRequestButton.FlatAppearance.BorderSize = 0
        Me.SubmitRequestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SubmitRequestButton.Font = New System.Drawing.Font("Goudy Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubmitRequestButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.SubmitRequestButton.Location = New System.Drawing.Point(0, 339)
        Me.SubmitRequestButton.Margin = New System.Windows.Forms.Padding(4)
        Me.SubmitRequestButton.Name = "SubmitRequestButton"
        Me.SubmitRequestButton.Size = New System.Drawing.Size(584, 34)
        Me.SubmitRequestButton.TabIndex = 31
        Me.SubmitRequestButton.Text = "Submit Prayer Request"
        Me.SubmitRequestButton.UseVisualStyleBackColor = False
        Me.SubmitRequestButton.Visible = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Goudy Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(345, 429)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(220, 34)
        Me.Button2.TabIndex = 32
        Me.Button2.Text = "Show next Request Now"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'NextRequestLabel
        '
        Me.NextRequestLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.NextRequestLabel.Location = New System.Drawing.Point(104, 389)
        Me.NextRequestLabel.Name = "NextRequestLabel"
        Me.NextRequestLabel.Size = New System.Drawing.Size(450, 36)
        Me.NextRequestLabel.TabIndex = 33
        Me.NextRequestLabel.Text = "Next Request"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(8, 389)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 19)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Next Request:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(584, 621)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.NextRequestLabel)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.SubmitRequestButton)
        Me.Controls.Add(Me.NewRequestRichTextBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.FileSourceLinkLabel)
        Me.Controls.Add(Me.IntervalNum)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.IndexTextBox)
        Me.Controls.Add(Me.ChangeIndexButton)
        Me.Controls.Add(Me.IndexNum)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NColonButton)
        Me.Controls.Add(Me.NColonLabel)
        Me.Controls.Add(Me.NColonText)
        Me.Controls.Add(Me.YColonLabel)
        Me.Controls.Add(Me.ExReqTitle)
        Me.Controls.Add(Me.YColonRequest)
        Me.Controls.Add(Me.YColonButton)
        Me.Controls.Add(Me.ExampleButton)
        Me.Controls.Add(Me.DebugButton)
        Me.Controls.Add(Me.SetSourceFile)
        Me.Controls.Add(Me.SetIntervalButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.IntervalTextBox)
        Me.Font = New System.Drawing.Font("Goudy Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Reminder Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents SetIntervalButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents IntervalTextBox As TextBox
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents SetSourceFile As Button
    Friend WithEvents OpenFileDialogRequests As OpenFileDialog
    Friend WithEvents DebugButton As Button
    Friend WithEvents ExampleButton As Button
    Friend WithEvents YColonButton As Button
    Friend WithEvents YColonRequest As Label
    Friend WithEvents ExReqTitle As Label
    Friend WithEvents YColonLabel As Label
    Friend WithEvents NColonLabel As Label
    Friend WithEvents NColonText As Label
    Friend WithEvents NColonButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents IndexNum As Label
    Friend WithEvents ChangeIndexButton As Button
    Friend WithEvents IndexTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents IntervalNum As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents FileSourceLinkLabel As LinkLabel
    Friend WithEvents Button1 As Button
    Friend WithEvents NewRequestRichTextBox As RichTextBox
    Friend WithEvents SubmitRequestButton As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents NextRequestLabel As Label
    Friend WithEvents Label4 As Label
End Class

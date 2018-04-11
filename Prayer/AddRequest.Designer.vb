<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddRequest
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddRequest))
        Me.NewRequestRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.SubmitRequestButton = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NewRequestRichTextBox
        '
        Me.NewRequestRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NewRequestRichTextBox.Font = New System.Drawing.Font("Goudy Old Style", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewRequestRichTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.NewRequestRichTextBox.Location = New System.Drawing.Point(3, 3)
        Me.NewRequestRichTextBox.Name = "NewRequestRichTextBox"
        Me.NewRequestRichTextBox.Size = New System.Drawing.Size(390, 234)
        Me.NewRequestRichTextBox.TabIndex = 32
        Me.NewRequestRichTextBox.Text = ""
        '
        'SubmitRequestButton
        '
        Me.SubmitRequestButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.SubmitRequestButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SubmitRequestButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.SubmitRequestButton.FlatAppearance.BorderSize = 0
        Me.SubmitRequestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SubmitRequestButton.Font = New System.Drawing.Font("Goudy Old Style", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubmitRequestButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.SubmitRequestButton.Location = New System.Drawing.Point(4, 244)
        Me.SubmitRequestButton.Margin = New System.Windows.Forms.Padding(4)
        Me.SubmitRequestButton.Name = "SubmitRequestButton"
        Me.SubmitRequestButton.Size = New System.Drawing.Size(388, 53)
        Me.SubmitRequestButton.TabIndex = 33
        Me.SubmitRequestButton.Text = "Submit Prayer Request"
        Me.SubmitRequestButton.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.SubmitRequestButton, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.NewRequestRichTextBox, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(396, 301)
        Me.TableLayoutPanel1.TabIndex = 34
        '
        'AddRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 301)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddRequest"
        Me.Text = "AddRequest"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NewRequestRichTextBox As RichTextBox
    Friend WithEvents SubmitRequestButton As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class

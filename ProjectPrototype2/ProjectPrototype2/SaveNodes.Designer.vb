<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SaveNodes
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.tbFileName = New System.Windows.Forms.TextBox()
        Me.lblSave = New System.Windows.Forms.Label()
        Me.lblBack = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(123, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(69, 13)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Text = "SAVE FILE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.White
        Me.lblName.Location = New System.Drawing.Point(12, 55)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(88, 13)
        Me.lblName.TabIndex = 5
        Me.lblName.Text = "ENTER NAME"
        '
        'tbFileName
        '
        Me.tbFileName.Location = New System.Drawing.Point(106, 52)
        Me.tbFileName.Name = "tbFileName"
        Me.tbFileName.Size = New System.Drawing.Size(193, 20)
        Me.tbFileName.TabIndex = 7
        '
        'lblSave
        '
        Me.lblSave.AutoSize = True
        Me.lblSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSave.ForeColor = System.Drawing.Color.White
        Me.lblSave.Location = New System.Drawing.Point(137, 88)
        Me.lblSave.Name = "lblSave"
        Me.lblSave.Size = New System.Drawing.Size(43, 13)
        Me.lblSave.TabIndex = 8
        Me.lblSave.Text = "SAVE "
        '
        'lblBack
        '
        Me.lblBack.AutoSize = True
        Me.lblBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBack.ForeColor = System.Drawing.Color.White
        Me.lblBack.Location = New System.Drawing.Point(260, 9)
        Me.lblBack.Name = "lblBack"
        Me.lblBack.Size = New System.Drawing.Size(39, 13)
        Me.lblBack.TabIndex = 9
        Me.lblBack.Text = "BACK"
        '
        'SaveNodes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(315, 126)
        Me.Controls.Add(Me.lblBack)
        Me.Controls.Add(Me.lblSave)
        Me.Controls.Add(Me.tbFileName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "SaveNodes"
        Me.Text = "SaveNodes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents tbFileName As System.Windows.Forms.TextBox
    Friend WithEvents lblSave As System.Windows.Forms.Label
    Friend WithEvents lblBack As System.Windows.Forms.Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoadNodes
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
        Me.OpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.lblBack = New System.Windows.Forms.Label()
        Me.lblSelectFile = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.tbFilePath = New System.Windows.Forms.TextBox()
        Me.LblOk = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'OpenFile
        '
        Me.OpenFile.FileName = "File Open"
        '
        'lblBack
        '
        Me.lblBack.AutoSize = True
        Me.lblBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBack.ForeColor = System.Drawing.Color.White
        Me.lblBack.Location = New System.Drawing.Point(259, 8)
        Me.lblBack.Name = "lblBack"
        Me.lblBack.Size = New System.Drawing.Size(39, 13)
        Me.lblBack.TabIndex = 13
        Me.lblBack.Text = "BACK"
        '
        'lblSelectFile
        '
        Me.lblSelectFile.AutoSize = True
        Me.lblSelectFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectFile.ForeColor = System.Drawing.Color.White
        Me.lblSelectFile.Location = New System.Drawing.Point(115, 44)
        Me.lblSelectFile.Name = "lblSelectFile"
        Me.lblSelectFile.Size = New System.Drawing.Size(84, 13)
        Me.lblSelectFile.TabIndex = 12
        Me.lblSelectFile.Text = "SELECT FILE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(122, 8)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(70, 13)
        Me.lblTitle.TabIndex = 10
        Me.lblTitle.Text = "LOAD FILE"
        '
        'tbFilePath
        '
        Me.tbFilePath.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tbFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbFilePath.Enabled = False
        Me.tbFilePath.ForeColor = System.Drawing.Color.Black
        Me.tbFilePath.Location = New System.Drawing.Point(17, 74)
        Me.tbFilePath.Multiline = True
        Me.tbFilePath.Name = "tbFilePath"
        Me.tbFilePath.ReadOnly = True
        Me.tbFilePath.Size = New System.Drawing.Size(281, 20)
        Me.tbFilePath.TabIndex = 15
        Me.tbFilePath.TabStop = False
        '
        'LblOk
        '
        Me.LblOk.AutoSize = True
        Me.LblOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblOk.ForeColor = System.Drawing.Color.White
        Me.LblOk.Location = New System.Drawing.Point(142, 110)
        Me.LblOk.Name = "LblOk"
        Me.LblOk.Size = New System.Drawing.Size(24, 26)
        Me.LblOk.TabIndex = 16
        Me.LblOk.Text = "OK" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LoadNodes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(313, 138)
        Me.Controls.Add(Me.LblOk)
        Me.Controls.Add(Me.tbFilePath)
        Me.Controls.Add(Me.lblBack)
        Me.Controls.Add(Me.lblSelectFile)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "LoadNodes"
        Me.Text = "LoadNodes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lblBack As System.Windows.Forms.Label
    Friend WithEvents lblSelectFile As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents tbFilePath As System.Windows.Forms.TextBox
    Friend WithEvents LblOk As System.Windows.Forms.Label
End Class

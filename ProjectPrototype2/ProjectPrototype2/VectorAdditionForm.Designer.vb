<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VectorAdditionForm
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
        Me.lblVectorAddition = New System.Windows.Forms.Label()
        Me.lblVector1 = New System.Windows.Forms.Label()
        Me.lblVector2 = New System.Windows.Forms.Label()
        Me.lblX1 = New System.Windows.Forms.Label()
        Me.lblX2 = New System.Windows.Forms.Label()
        Me.tbX1 = New System.Windows.Forms.TextBox()
        Me.tbX2 = New System.Windows.Forms.TextBox()
        Me.tbY2 = New System.Windows.Forms.TextBox()
        Me.tbY1 = New System.Windows.Forms.TextBox()
        Me.lblY2 = New System.Windows.Forms.Label()
        Me.lblY1 = New System.Windows.Forms.Label()
        Me.lblAdd = New System.Windows.Forms.Label()
        Me.lblBack = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblVectorAddition
        '
        Me.lblVectorAddition.AutoSize = True
        Me.lblVectorAddition.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVectorAddition.ForeColor = System.Drawing.Color.White
        Me.lblVectorAddition.Location = New System.Drawing.Point(55, 39)
        Me.lblVectorAddition.Name = "lblVectorAddition"
        Me.lblVectorAddition.Size = New System.Drawing.Size(121, 13)
        Me.lblVectorAddition.TabIndex = 4
        Me.lblVectorAddition.Text = "VECTOR ADDITION" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblVector1
        '
        Me.lblVector1.AutoSize = True
        Me.lblVector1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVector1.ForeColor = System.Drawing.Color.White
        Me.lblVector1.Location = New System.Drawing.Point(55, 71)
        Me.lblVector1.Name = "lblVector1"
        Me.lblVector1.Size = New System.Drawing.Size(72, 13)
        Me.lblVector1.TabIndex = 5
        Me.lblVector1.Text = "VECTOR 1:"
        '
        'lblVector2
        '
        Me.lblVector2.AutoSize = True
        Me.lblVector2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVector2.ForeColor = System.Drawing.Color.White
        Me.lblVector2.Location = New System.Drawing.Point(55, 102)
        Me.lblVector2.Name = "lblVector2"
        Me.lblVector2.Size = New System.Drawing.Size(72, 13)
        Me.lblVector2.TabIndex = 6
        Me.lblVector2.Text = "VECTOR 2:"
        '
        'lblX1
        '
        Me.lblX1.AutoSize = True
        Me.lblX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblX1.ForeColor = System.Drawing.Color.White
        Me.lblX1.Location = New System.Drawing.Point(149, 71)
        Me.lblX1.Name = "lblX1"
        Me.lblX1.Size = New System.Drawing.Size(15, 13)
        Me.lblX1.TabIndex = 7
        Me.lblX1.Text = "X"
        '
        'lblX2
        '
        Me.lblX2.AutoSize = True
        Me.lblX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblX2.ForeColor = System.Drawing.Color.White
        Me.lblX2.Location = New System.Drawing.Point(149, 102)
        Me.lblX2.Name = "lblX2"
        Me.lblX2.Size = New System.Drawing.Size(15, 13)
        Me.lblX2.TabIndex = 8
        Me.lblX2.Text = "X"
        '
        'tbX1
        '
        Me.tbX1.Location = New System.Drawing.Point(170, 68)
        Me.tbX1.Name = "tbX1"
        Me.tbX1.Size = New System.Drawing.Size(34, 20)
        Me.tbX1.TabIndex = 9
        '
        'tbX2
        '
        Me.tbX2.Location = New System.Drawing.Point(170, 99)
        Me.tbX2.Name = "tbX2"
        Me.tbX2.Size = New System.Drawing.Size(34, 20)
        Me.tbX2.TabIndex = 10
        '
        'tbY2
        '
        Me.tbY2.Location = New System.Drawing.Point(254, 99)
        Me.tbY2.Name = "tbY2"
        Me.tbY2.Size = New System.Drawing.Size(34, 20)
        Me.tbY2.TabIndex = 14
        '
        'tbY1
        '
        Me.tbY1.Location = New System.Drawing.Point(254, 68)
        Me.tbY1.Name = "tbY1"
        Me.tbY1.Size = New System.Drawing.Size(34, 20)
        Me.tbY1.TabIndex = 13
        '
        'lblY2
        '
        Me.lblY2.AutoSize = True
        Me.lblY2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblY2.ForeColor = System.Drawing.Color.White
        Me.lblY2.Location = New System.Drawing.Point(233, 102)
        Me.lblY2.Name = "lblY2"
        Me.lblY2.Size = New System.Drawing.Size(15, 13)
        Me.lblY2.TabIndex = 12
        Me.lblY2.Text = "Y"
        '
        'lblY1
        '
        Me.lblY1.AutoSize = True
        Me.lblY1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblY1.ForeColor = System.Drawing.Color.White
        Me.lblY1.Location = New System.Drawing.Point(233, 71)
        Me.lblY1.Name = "lblY1"
        Me.lblY1.Size = New System.Drawing.Size(15, 13)
        Me.lblY1.TabIndex = 11
        Me.lblY1.Text = "Y"
        '
        'lblAdd
        '
        Me.lblAdd.AutoSize = True
        Me.lblAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdd.ForeColor = System.Drawing.Color.White
        Me.lblAdd.Location = New System.Drawing.Point(331, 71)
        Me.lblAdd.Name = "lblAdd"
        Me.lblAdd.Size = New System.Drawing.Size(33, 13)
        Me.lblAdd.TabIndex = 15
        Me.lblAdd.Text = "ADD"
        '
        'lblBack
        '
        Me.lblBack.AutoSize = True
        Me.lblBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBack.ForeColor = System.Drawing.Color.White
        Me.lblBack.Location = New System.Drawing.Point(326, 102)
        Me.lblBack.Name = "lblBack"
        Me.lblBack.Size = New System.Drawing.Size(43, 13)
        Me.lblBack.TabIndex = 16
        Me.lblBack.Text = "MENU"
        '
        'VectorAdditionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlText
        Me.ClientSize = New System.Drawing.Size(951, 651)
        Me.Controls.Add(Me.lblBack)
        Me.Controls.Add(Me.lblAdd)
        Me.Controls.Add(Me.tbY2)
        Me.Controls.Add(Me.tbY1)
        Me.Controls.Add(Me.lblY2)
        Me.Controls.Add(Me.lblY1)
        Me.Controls.Add(Me.tbX2)
        Me.Controls.Add(Me.tbX1)
        Me.Controls.Add(Me.lblX2)
        Me.Controls.Add(Me.lblX1)
        Me.Controls.Add(Me.lblVector2)
        Me.Controls.Add(Me.lblVector1)
        Me.Controls.Add(Me.lblVectorAddition)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "VectorAdditionForm"
        Me.Text = "Vector Addition"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblVectorAddition As System.Windows.Forms.Label
    Friend WithEvents lblVector1 As System.Windows.Forms.Label
    Friend WithEvents lblVector2 As System.Windows.Forms.Label
    Friend WithEvents lblX1 As System.Windows.Forms.Label
    Friend WithEvents lblX2 As System.Windows.Forms.Label
    Friend WithEvents tbX1 As System.Windows.Forms.TextBox
    Friend WithEvents tbX2 As System.Windows.Forms.TextBox
    Friend WithEvents tbY2 As System.Windows.Forms.TextBox
    Friend WithEvents tbY1 As System.Windows.Forms.TextBox
    Friend WithEvents lblY2 As System.Windows.Forms.Label
    Friend WithEvents lblY1 As System.Windows.Forms.Label
    Friend WithEvents lblAdd As System.Windows.Forms.Label
    Friend WithEvents lblBack As System.Windows.Forms.Label
End Class

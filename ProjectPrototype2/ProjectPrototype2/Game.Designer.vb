<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Game
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
        Me.lblBack = New System.Windows.Forms.Label()
        Me.lblStart = New System.Windows.Forms.Label()
        Me.lblGraphTheory = New System.Windows.Forms.Label()
        Me.lblLeft = New System.Windows.Forms.Label()
        Me.lblRight = New System.Windows.Forms.Label()
        Me.cbLeft = New System.Windows.Forms.CheckBox()
        Me.cbRight = New System.Windows.Forms.CheckBox()
        Me.lblStop = New System.Windows.Forms.Label()
        Me.lblChangeScenario = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblBack
        '
        Me.lblBack.AutoSize = True
        Me.lblBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBack.ForeColor = System.Drawing.Color.White
        Me.lblBack.Location = New System.Drawing.Point(369, 71)
        Me.lblBack.Name = "lblBack"
        Me.lblBack.Size = New System.Drawing.Size(78, 13)
        Me.lblBack.TabIndex = 31
        Me.lblBack.Text = "MAIN MENU" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblStart
        '
        Me.lblStart.AutoSize = True
        Me.lblStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStart.ForeColor = System.Drawing.Color.White
        Me.lblStart.Location = New System.Drawing.Point(55, 70)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(48, 13)
        Me.lblStart.TabIndex = 27
        Me.lblStart.Text = "START"
        '
        'lblGraphTheory
        '
        Me.lblGraphTheory.AutoSize = True
        Me.lblGraphTheory.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGraphTheory.ForeColor = System.Drawing.Color.White
        Me.lblGraphTheory.Location = New System.Drawing.Point(56, 40)
        Me.lblGraphTheory.Name = "lblGraphTheory"
        Me.lblGraphTheory.Size = New System.Drawing.Size(202, 13)
        Me.lblGraphTheory.TabIndex = 25
        Me.lblGraphTheory.Text = "CONVEX HULL CAR SIMULATION"
        '
        'lblLeft
        '
        Me.lblLeft.AutoSize = True
        Me.lblLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLeft.ForeColor = System.Drawing.Color.White
        Me.lblLeft.Location = New System.Drawing.Point(230, 70)
        Me.lblLeft.Name = "lblLeft"
        Me.lblLeft.Size = New System.Drawing.Size(37, 13)
        Me.lblLeft.TabIndex = 32
        Me.lblLeft.Text = "LEFT"
        '
        'lblRight
        '
        Me.lblRight.AutoSize = True
        Me.lblRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRight.ForeColor = System.Drawing.Color.White
        Me.lblRight.Location = New System.Drawing.Point(230, 94)
        Me.lblRight.Name = "lblRight"
        Me.lblRight.Size = New System.Drawing.Size(46, 13)
        Me.lblRight.TabIndex = 33
        Me.lblRight.Text = "RIGHT"
        '
        'cbLeft
        '
        Me.cbLeft.AutoSize = True
        Me.cbLeft.Location = New System.Drawing.Point(209, 70)
        Me.cbLeft.Name = "cbLeft"
        Me.cbLeft.Size = New System.Drawing.Size(15, 14)
        Me.cbLeft.TabIndex = 34
        Me.cbLeft.UseVisualStyleBackColor = True
        '
        'cbRight
        '
        Me.cbRight.AutoSize = True
        Me.cbRight.Location = New System.Drawing.Point(209, 94)
        Me.cbRight.Name = "cbRight"
        Me.cbRight.Size = New System.Drawing.Size(15, 14)
        Me.cbRight.TabIndex = 35
        Me.cbRight.UseVisualStyleBackColor = True
        '
        'lblStop
        '
        Me.lblStop.AutoSize = True
        Me.lblStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStop.ForeColor = System.Drawing.Color.White
        Me.lblStop.Location = New System.Drawing.Point(56, 94)
        Me.lblStop.Name = "lblStop"
        Me.lblStop.Size = New System.Drawing.Size(40, 13)
        Me.lblStop.TabIndex = 36
        Me.lblStop.Text = "STOP"
        '
        'lblChangeScenario
        '
        Me.lblChangeScenario.AutoSize = True
        Me.lblChangeScenario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChangeScenario.ForeColor = System.Drawing.Color.White
        Me.lblChangeScenario.Location = New System.Drawing.Point(345, 94)
        Me.lblChangeScenario.Name = "lblChangeScenario"
        Me.lblChangeScenario.Size = New System.Drawing.Size(125, 13)
        Me.lblChangeScenario.TabIndex = 37
        Me.lblChangeScenario.Text = "CHANGE SCENARIO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(953, 653)
        Me.Controls.Add(Me.lblChangeScenario)
        Me.Controls.Add(Me.lblStop)
        Me.Controls.Add(Me.cbRight)
        Me.Controls.Add(Me.cbLeft)
        Me.Controls.Add(Me.lblRight)
        Me.Controls.Add(Me.lblLeft)
        Me.Controls.Add(Me.lblBack)
        Me.Controls.Add(Me.lblStart)
        Me.Controls.Add(Me.lblGraphTheory)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Game"
        Me.Text = "Car Simulation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblBack As System.Windows.Forms.Label
    Friend WithEvents lblStart As System.Windows.Forms.Label
    Friend WithEvents lblGraphTheory As System.Windows.Forms.Label
    Friend WithEvents lblLeft As System.Windows.Forms.Label
    Friend WithEvents lblRight As System.Windows.Forms.Label
    Friend WithEvents cbLeft As System.Windows.Forms.CheckBox
    Friend WithEvents cbRight As System.Windows.Forms.CheckBox
    Friend WithEvents lblStop As System.Windows.Forms.Label
    Friend WithEvents lblChangeScenario As System.Windows.Forms.Label
End Class

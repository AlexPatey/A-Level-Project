<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblGraphTheory = New System.Windows.Forms.Label()
        Me.tbNoOfNodes = New System.Windows.Forms.TextBox()
        Me.lblNoOfNodes = New System.Windows.Forms.Label()
        Me.tbCoords = New System.Windows.Forms.TextBox()
        Me.lblCoords = New System.Windows.Forms.Label()
        Me.lblStart = New System.Windows.Forms.Label()
        Me.lblClear = New System.Windows.Forms.Label()
        Me.lblRandom = New System.Windows.Forms.Label()
        Me.lblSave = New System.Windows.Forms.Label()
        Me.lblLoad = New System.Windows.Forms.Label()
        Me.lblBack = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblGraphTheory
        '
        Me.lblGraphTheory.AutoSize = True
        Me.lblGraphTheory.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGraphTheory.ForeColor = System.Drawing.Color.White
        Me.lblGraphTheory.Location = New System.Drawing.Point(56, 40)
        Me.lblGraphTheory.Name = "lblGraphTheory"
        Me.lblGraphTheory.Size = New System.Drawing.Size(371, 13)
        Me.lblGraphTheory.TabIndex = 3
        Me.lblGraphTheory.Text = "CONVEX HULL SIMULATION USING QUICK HULL ALGORITHM" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'tbNoOfNodes
        '
        Me.tbNoOfNodes.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tbNoOfNodes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbNoOfNodes.Enabled = False
        Me.tbNoOfNodes.ForeColor = System.Drawing.Color.Black
        Me.tbNoOfNodes.Location = New System.Drawing.Point(156, 596)
        Me.tbNoOfNodes.Multiline = True
        Me.tbNoOfNodes.Name = "tbNoOfNodes"
        Me.tbNoOfNodes.ReadOnly = True
        Me.tbNoOfNodes.Size = New System.Drawing.Size(100, 20)
        Me.tbNoOfNodes.TabIndex = 16
        Me.tbNoOfNodes.TabStop = False
        '
        'lblNoOfNodes
        '
        Me.lblNoOfNodes.AutoSize = True
        Me.lblNoOfNodes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoOfNodes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblNoOfNodes.Location = New System.Drawing.Point(54, 599)
        Me.lblNoOfNodes.Name = "lblNoOfNodes"
        Me.lblNoOfNodes.Size = New System.Drawing.Size(96, 13)
        Me.lblNoOfNodes.TabIndex = 15
        Me.lblNoOfNodes.Text = "NO. OF NODES"
        '
        'tbCoords
        '
        Me.tbCoords.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tbCoords.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbCoords.Enabled = False
        Me.tbCoords.ForeColor = System.Drawing.Color.Black
        Me.tbCoords.Location = New System.Drawing.Point(156, 567)
        Me.tbCoords.Multiline = True
        Me.tbCoords.Name = "tbCoords"
        Me.tbCoords.ReadOnly = True
        Me.tbCoords.Size = New System.Drawing.Size(100, 20)
        Me.tbCoords.TabIndex = 14
        Me.tbCoords.TabStop = False
        '
        'lblCoords
        '
        Me.lblCoords.AutoSize = True
        Me.lblCoords.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCoords.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblCoords.Location = New System.Drawing.Point(54, 569)
        Me.lblCoords.Name = "lblCoords"
        Me.lblCoords.Size = New System.Drawing.Size(96, 13)
        Me.lblCoords.TabIndex = 17
        Me.lblCoords.Text = "COORDINATES"
        '
        'lblStart
        '
        Me.lblStart.AutoSize = True
        Me.lblStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStart.ForeColor = System.Drawing.Color.White
        Me.lblStart.Location = New System.Drawing.Point(55, 70)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(48, 13)
        Me.lblStart.TabIndex = 19
        Me.lblStart.Text = "START"
        '
        'lblClear
        '
        Me.lblClear.AutoSize = True
        Me.lblClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClear.ForeColor = System.Drawing.Color.White
        Me.lblClear.Location = New System.Drawing.Point(55, 89)
        Me.lblClear.Name = "lblClear"
        Me.lblClear.Size = New System.Drawing.Size(47, 13)
        Me.lblClear.TabIndex = 18
        Me.lblClear.Text = "CLEAR"
        '
        'lblRandom
        '
        Me.lblRandom.AutoSize = True
        Me.lblRandom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRandom.ForeColor = System.Drawing.Color.White
        Me.lblRandom.Location = New System.Drawing.Point(346, 70)
        Me.lblRandom.Name = "lblRandom"
        Me.lblRandom.Size = New System.Drawing.Size(81, 13)
        Me.lblRandom.TabIndex = 20
        Me.lblRandom.Text = "RANDOMIZE"
        '
        'lblSave
        '
        Me.lblSave.AutoSize = True
        Me.lblSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSave.ForeColor = System.Drawing.Color.White
        Me.lblSave.Location = New System.Drawing.Point(207, 70)
        Me.lblSave.Name = "lblSave"
        Me.lblSave.Size = New System.Drawing.Size(39, 13)
        Me.lblSave.TabIndex = 21
        Me.lblSave.Text = "SAVE"
        '
        'lblLoad
        '
        Me.lblLoad.AutoSize = True
        Me.lblLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoad.ForeColor = System.Drawing.Color.White
        Me.lblLoad.Location = New System.Drawing.Point(207, 89)
        Me.lblLoad.Name = "lblLoad"
        Me.lblLoad.Size = New System.Drawing.Size(40, 13)
        Me.lblLoad.TabIndex = 22
        Me.lblLoad.Text = "LOAD"
        '
        'lblBack
        '
        Me.lblBack.AutoSize = True
        Me.lblBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBack.ForeColor = System.Drawing.Color.White
        Me.lblBack.Location = New System.Drawing.Point(520, 70)
        Me.lblBack.Name = "lblBack"
        Me.lblBack.Size = New System.Drawing.Size(78, 13)
        Me.lblBack.TabIndex = 23
        Me.lblBack.Text = "MAIN MENU" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(953, 653)
        Me.Controls.Add(Me.lblBack)
        Me.Controls.Add(Me.lblLoad)
        Me.Controls.Add(Me.lblSave)
        Me.Controls.Add(Me.lblRandom)
        Me.Controls.Add(Me.lblStart)
        Me.Controls.Add(Me.lblClear)
        Me.Controls.Add(Me.lblCoords)
        Me.Controls.Add(Me.tbNoOfNodes)
        Me.Controls.Add(Me.lblNoOfNodes)
        Me.Controls.Add(Me.tbCoords)
        Me.Controls.Add(Me.lblGraphTheory)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "CONVEX HULL SIMULATION"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblGraphTheory As System.Windows.Forms.Label
    Friend WithEvents tbNoOfNodes As System.Windows.Forms.TextBox
    Friend WithEvents lblNoOfNodes As System.Windows.Forms.Label
    Friend WithEvents tbCoords As System.Windows.Forms.TextBox
    Friend WithEvents lblCoords As System.Windows.Forms.Label
    Friend WithEvents lblStart As System.Windows.Forms.Label
    Friend WithEvents lblClear As System.Windows.Forms.Label
    Friend WithEvents lblRandom As System.Windows.Forms.Label
    Friend WithEvents lblSave As System.Windows.Forms.Label
    Friend WithEvents lblLoad As System.Windows.Forms.Label
    Friend WithEvents lblBack As System.Windows.Forms.Label

End Class

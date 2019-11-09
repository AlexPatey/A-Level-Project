<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.lblConvexHull = New System.Windows.Forms.Label()
        Me.lblConvexHullGame = New System.Windows.Forms.Label()
        Me.lblVectorAddition = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblGraphTheory
        '
        Me.lblGraphTheory.AutoSize = True
        Me.lblGraphTheory.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGraphTheory.ForeColor = System.Drawing.Color.White
        Me.lblGraphTheory.Location = New System.Drawing.Point(38, 25)
        Me.lblGraphTheory.Name = "lblGraphTheory"
        Me.lblGraphTheory.Size = New System.Drawing.Size(216, 13)
        Me.lblGraphTheory.TabIndex = 4
        Me.lblGraphTheory.Text = "VECTOR GRAPHICS TEACHING AID"
        '
        'lblConvexHull
        '
        Me.lblConvexHull.AutoSize = True
        Me.lblConvexHull.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConvexHull.ForeColor = System.Drawing.Color.Gray
        Me.lblConvexHull.Location = New System.Drawing.Point(57, 52)
        Me.lblConvexHull.Name = "lblConvexHull"
        Me.lblConvexHull.Size = New System.Drawing.Size(173, 13)
        Me.lblConvexHull.TabIndex = 5
        Me.lblConvexHull.Text = "CONVEX HULL SIMULATION" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblConvexHullGame
        '
        Me.lblConvexHullGame.AutoSize = True
        Me.lblConvexHullGame.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConvexHullGame.ForeColor = System.Drawing.Color.Gray
        Me.lblConvexHullGame.Location = New System.Drawing.Point(70, 72)
        Me.lblConvexHullGame.Name = "lblConvexHullGame"
        Me.lblConvexHullGame.Size = New System.Drawing.Size(148, 13)
        Me.lblConvexHullGame.TabIndex = 6
        Me.lblConvexHullGame.Text = "CONVEX HULL CAR SIM" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblVectorAddition
        '
        Me.lblVectorAddition.AutoSize = True
        Me.lblVectorAddition.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVectorAddition.ForeColor = System.Drawing.Color.Gray
        Me.lblVectorAddition.Location = New System.Drawing.Point(84, 92)
        Me.lblVectorAddition.Name = "lblVectorAddition"
        Me.lblVectorAddition.Size = New System.Drawing.Size(121, 13)
        Me.lblVectorAddition.TabIndex = 7
        Me.lblVectorAddition.Text = "VECTOR ADDITION" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(292, 126)
        Me.Controls.Add(Me.lblVectorAddition)
        Me.Controls.Add(Me.lblConvexHullGame)
        Me.Controls.Add(Me.lblConvexHull)
        Me.Controls.Add(Me.lblGraphTheory)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form2"
        Me.Text = "MENU"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblGraphTheory As System.Windows.Forms.Label
    Friend WithEvents lblConvexHull As System.Windows.Forms.Label
    Friend WithEvents lblConvexHullGame As System.Windows.Forms.Label
    Friend WithEvents lblVectorAddition As System.Windows.Forms.Label
End Class

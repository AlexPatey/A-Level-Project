Public Class Form1
    Public graph As cGraph
    Public WithEvents graphGUI As cGraphGUI

    'SAVE AND LOAD
    'WORK THROUGH TEXTBOOK EXAMPLES
    'STEP BY STEP (SPEED UP SLOW DOWN) DRAW VECTOR ARROWS 
    'CAR EXAMPLE (CHANGE ANGLE BETWEEN VECTORS, WIDER OR THINNER)
    'CUBE EXAMPLE 

    Private Sub formInterfaceLoad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Form2.Hide()

        graph = New cGraph

        graphGUI = New cGraphGUI(Me, graph)

        'Allows the graph GUI to access the list of controls
        Me.Controls.Add(graphGUI)

        'Manually sets the size and location of the graph
        graphGUI.Location = New Point(115, 130)
        graphGUI.Size = New Size(721, 401)

    End Sub

    'Changes the "START" label colour to gray when the mouse hovers over the label
    Private Sub lblStartMouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblStart.MouseEnter

        lblStart.ForeColor = Color.Gray

    End Sub

    Private Sub lblStartMouseEClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblStart.MouseClick

        If Me.graph.nodes Is Nothing Then
        Else
            Me.graph.findConvexHull(Me.graph.nodes)
        End If

    End Sub

    'Changes the "START" label colour to white when the mouse leaves the labels area
    Private Sub lblStartMouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblStart.MouseLeave

        lblStart.ForeColor = Color.White

    End Sub

    'Changes the "CLEAR" label colour to gray when the mouse hovers over the label
    Private Sub lblClearMouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClear.MouseEnter

        lblClear.ForeColor = Color.Gray

    End Sub

    'Changes the "CLEAR" label colour to white when the mouse leaves the labels area
    Private Sub lblClearMouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClear.MouseLeave

        lblClear.ForeColor = Color.White

    End Sub

    'Changes "CONVEX HULL" label to light blue if not already and changes "DIJSTRAS SHORTEST PATH" label to gray

    Private Sub lblClearClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClear.Click

        Me.tbNoOfNodes.Text = Nothing
        Me.graphGUI.Clear()
        Me.graph.drawHull = False
        Me.graphGUI.Refresh()
       
    End Sub

    Protected Overrides ReadOnly Property CreateParams() As CreateParams

        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            Return cp
        End Get

    End Property

    Private Sub lblRandom_Click(sender As System.Object, e As System.EventArgs) Handles lblRandom.Click

        Me.graph.getRandomNodes()
        Me.graph.findConvexHull(Me.graph.nodes)

    End Sub

    Private Sub lblRandom_MouseEnter(sender As System.Object, e As System.EventArgs) Handles lblRandom.MouseEnter

        lblRandom.ForeColor = Color.Gray

    End Sub

    Private Sub lblRandom_MouseLeave(sender As System.Object, e As System.EventArgs) Handles lblRandom.MouseLeave

        lblRandom.ForeColor = Color.White

    End Sub

    Private Sub lblSave_Click(sender As System.Object, e As System.EventArgs) Handles lblSave.Click

        If Me.graph.nodes Is Nothing Then
            MsgBox("Please draw graph before saving.")
        Else
            SaveNodes.Show()
        End If

    End Sub

    Private Sub lblLoad_Click(sender As System.Object, e As System.EventArgs) Handles lblLoad.Click

        LoadNodes.Show()

    End Sub

    Private Sub lblSave_MouseEnter(sender As System.Object, e As System.EventArgs) Handles lblSave.MouseEnter

        lblSave.ForeColor = Color.Gray

    End Sub

    Private Sub lblSave_MouseLeave(sender As System.Object, e As System.EventArgs) Handles lblSave.MouseLeave

        lblSave.ForeColor = Color.White

    End Sub

    Private Sub lblLoad_MouseEnter(sender As System.Object, e As System.EventArgs) Handles lblLoad.MouseEnter

        lblLoad.ForeColor = Color.Gray

    End Sub

    Private Sub lblLoad_MouseLeave(sender As System.Object, e As System.EventArgs) Handles lblLoad.MouseLeave

        lblLoad.ForeColor = Color.White

    End Sub

    Private Sub lblBack_Click(sender As System.Object, e As System.EventArgs) Handles lblBack.Click

        Form2.Show()
        Me.Close()

    End Sub

    Private Sub lblBack_MouseEnter(sender As System.Object, e As System.EventArgs) Handles lblBack.MouseEnter

        Me.lblBack.ForeColor = Color.Gray

    End Sub

    Private Sub lblBack_MouseLeave(sender As System.Object, e As System.EventArgs) Handles lblBack.MouseLeave

        Me.lblBack.ForeColor = Color.White

    End Sub

    Private Sub LblSimulation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If graph.nodes Is Nothing Then
            MsgBox("Please draw more than three nodes for the simulation.")
        ElseIf graph.nodes.Length <= 3 Then
            MsgBox("Please draw more than three nodes for the simulation.")
        Else
            Me.graph.sim = True
        End If

    End Sub

    Private Sub LblSimulation_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs)

        '   Me.LblSimulation.ForeColor = Color.Gray

    End Sub

    Private Sub LblSimulation_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)

        '  Me.LblSimulation.ForeColor = Color.White

    End Sub

    Private Sub lblGraphTheory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblGraphTheory.Click

    End Sub

    Private Sub lblStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblStart.Click

        graph.sim = False

    End Sub
End Class

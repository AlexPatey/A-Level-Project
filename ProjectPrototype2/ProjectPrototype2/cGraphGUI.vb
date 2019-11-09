Imports System.Drawing.Drawing2D

Public Class cGraphGUI

    Inherits Panel
    Dim graph As cGraph
    Dim graphics As Graphics
    Dim target As Form1

    Public Sub New(ByRef target As Form, _
                   ByRef graph As cGraph)

        Me.target = target
        Me.graph = graph

    End Sub

    'The paint sub refreshes itself
    Private Sub paints(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Paint

        Me.drawToForm(Me.graph.nodes)

    End Sub

    'Called from the paint sub, draws everything onto a panel
    Private Sub drawToForm(ByVal nodes() As node)

        Invoke(Sub()
                   graphics = Me.CreateGraphics()

                   Me.drawGrid()

                   If nodes IsNot Nothing Then

                       drawNodes(nodes)

                   End If

                   If Me.graph.drawHull = True Then

                       drawConvexHull(Me.graph.convexNodes)

                   End If

                   If Me.graph.sim = True Then

                       Me.firstLine()

                   End If
               End Sub)
    End Sub


    Public Sub drawNodes(ByVal nodes() As node)

        For Looper = 0 To Me.graph.nodes.Length - 1

            Dim rec As Rectangle

            rec.X = CInt((Me.graph.nodes(Looper).x - 4) + Me.Width / 2)
            rec.Y = CInt((Me.Height / 2) - (Me.graph.nodes(Looper).y + 4))
            rec.Width = 8
            rec.Height = 8

            graphics.DrawEllipse(Pens.Red, rec)
            graphics.FillEllipse(Brushes.Red, rec)

        Next

    End Sub

    Private Sub drawConvexHull(ByVal convexNodes() As node)

        Dim width As Integer
        width = CInt(Me.Width / 2)
        Dim height As Integer
        height = CInt(Me.Height / 2)

        If convexNodes.Length <= 2 Then
        Else
            For looper = 0 To convexNodes.Length - 2
                Me.graphics.DrawLine(Pens.HotPink, convexNodes(looper).x + width, height - convexNodes(looper).y, convexNodes(looper + 1).x + width, height - convexNodes(looper + 1).y)
            Next
            Me.graphics.DrawLine(Pens.HotPink, convexNodes(convexNodes.Length - 1).x + width, height - convexNodes(convexNodes.Length - 1).y, convexNodes(0).x + width, height - convexNodes(0).y)

        End If

    End Sub

    Private Sub drawGrid()

        Dim background As Rectangle

        Dim origin As Point

        background.Width = 721
        background.Height = 401

        background.X = 0
        background.Y = 0

        graphics.FillRectangle(Brushes.White, background)
        origin.X = CInt(Me.Width / 2)
        origin.Y = CInt(Me.Height / 2)

        'Allows the panel to have graphics drawn onto it 

        'These loopers draw the graphs grid onto the panel
        For looper = 0 To Me.Height Step 20
            graphics.DrawLine(Pens.Gray, 0, looper, Me.Width, looper)
        Next
        For looper = 0 To Me.Width Step 20
            graphics.DrawLine(Pens.Gray, looper, 0, looper, Me.Height)
        Next

        'Draws the x and y axis onto the panel
        graphics.DrawLine(Pens.Black, origin.X, 0, origin.X, Me.Height)
        graphics.DrawLine(Pens.Black, 0, origin.Y, Me.Width, origin.Y)

    End Sub

    Public Sub Clear()
        Me.graph.nodes = Nothing
        Me.Refresh()
    End Sub

    'Determines whether the click was a left or right, then acts accordingly
    Private Sub eMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown

        'Creates a variable to store the mouse click coords for a temporary time
        Dim tempNode As node
        tempNode.x = CDec(PointToClient(Cursor.Position).X - Math.Round(Me.Width / 2))
        tempNode.y = CDec(-(PointToClient(Cursor.Position).Y - Math.Round(Me.Height / 2)))


        If e.Button = Windows.Forms.MouseButtons.Left Then

            Me.graph.addNode(tempNode, Form1, False)

        ElseIf e.Button = Windows.Forms.MouseButtons.Right Then

            Me.graph.removeNode(tempNode, Form1)

        End If

        If Me.graph.drawHull = True Then

            Me.graph.findConvexHull(Me.graph.nodes)

        End If

    End Sub

    'Updates the mouse coords box 
    Private Sub pnlGraph_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove

        Me.updateMouseCoords()

    End Sub

    'Updates the textbox on the form with the current coordinates of the mouse in relation to the graphs origin
    Public Sub updateMouseCoords()

        Form1.tbCoords.Text = "(" & CStr(PointToClient(Cursor.Position).X - Math.Round(Me.Width / 2) & " , " & (-(PointToClient(Cursor.Position).Y - Math.Round(Me.Height / 2)))) & ")"

    End Sub

End Class

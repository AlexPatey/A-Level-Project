Public Class VectorAdditionGUI
    Inherits Panel
    Dim graphics As Graphics

    Public Sub New()

    End Sub

    Private Sub paints(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Paint

        Me.drawToForm()

    End Sub


    Private Sub drawToForm()

        Invoke(Sub()
                   graphics = Me.CreateGraphics()

                   Me.drawGrid()
                   If VectorAdditionForm.tbX1.Text Is Nothing And VectorAdditionForm.tbX2.Text Is Nothing And VectorAdditionForm.tbY1 Is Nothing And VectorAdditionForm.tbY2.Text Is Nothing Then
                   Else
                       drawVectors(VectorAdditionForm.VectAdd.v1, VectorAdditionForm.VectAdd.v2)
                   End If
                   If VectorAdditionForm.VectAdd.drawV = True Then
                       drawResult(VectorAdditionForm.VectAdd.resultV)
                   End If

               End Sub)

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

    Private Sub drawVectors(ByVal v1 As node, ByVal v2 As node)

        Dim width As Integer = 360
        Dim height As Integer = 200

        graphics.DrawLine(Pens.HotPink, width, height, ((v1.x) * 20) + width, height - ((v1.y) * 20))
        graphics.DrawLine(Pens.HotPink, width, height, ((v2.x) * 20) + width, height - ((v2.y) * 20))

    End Sub

    Private Sub drawResult(ByVal V As node)

        Dim width As Integer = 360
        Dim height As Integer = 200

        graphics.DrawLine(Pens.Green, width, height, ((V.x) * 20) + width, height - ((V.y) * 20))

    End Sub
End Class

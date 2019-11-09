Imports System.Drawing.Drawing2D

Public Class cGameGUI

    Inherits Panel
    Dim game As cGame
    Dim graphics As Graphics
    Dim target As Game
    Public background As Rectangle

    Public Sub New(ByRef target As Form, ByRef game As cGame)

        Me.target = target
        Me.game = game

    End Sub

    Private Sub paints(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Paint

        Invoke(Sub()

                   graphics = Me.CreateGraphics()
                   Me.drawToForm()

               End Sub)

    End Sub

    Public Sub drawToForm()

        background.Width = 720
        background.Height = 400

        background.X = 0
        background.Y = 0

        graphics.FillRectangle(Brushes.White, background)

      
    End Sub

    Public Sub drawCar(ByRef car As Rectangle)

        graphics.FillRectangle(Brushes.Black, car)

        Me.drawNodes(Me.game.nodes)

    End Sub

    Public Sub drawNodes(ByRef nodes() As node)

        For looper = 0 To 3

            Dim rec As Rectangle
            rec.X = nodes(looper).x - 2
            rec.Y = nodes(looper).y - 2
            rec.Width = 4
            rec.Height = 4

            graphics.FillEllipse(Brushes.Red, rec)

        Next

        connectNodes(nodes)

    End Sub

    Public Sub connectNodes(ByRef nodes() As node)

        For looper = 0 To 2

            graphics.DrawLine(Pens.HotPink, nodes(looper).x, nodes(looper).y, nodes(looper + 1).x, nodes(looper + 1).y)

        Next

    End Sub

    Public Sub drawObjects()

        For looper = 0 To Me.game.objectNodes.Length - 1

            Dim rec As Rectangle
            rec.X = Me.game.objectNodes(looper).x - 3
            rec.Y = Me.game.objectNodes(looper).y - 3
            rec.Width = 6
            rec.Height = 6

            graphics.FillEllipse(Brushes.Green, rec)

        Next

    End Sub

End Class

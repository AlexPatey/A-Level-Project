Public Class cGame

    Public nodes(3) As node
    Public car As Rectangle
    Public objectNodes() As node
    Public stopSim As Boolean = False

    Public Sub New()

        car.Width = 20
        car.Height = 40
        car.X = 350
        car.Y = 180

        nodes(0).x = 350
        nodes(0).y = 180

        nodes(3).x = 370
        nodes(3).y = 180

        nodes(1).x = 350
        nodes(1).y = 140

        nodes(2).x = 370
        nodes(2).y = 140

    End Sub

    Public Sub turnCar(ByVal LorR As Boolean)

        Dim facesup As Boolean = False
        Dim facesleft As Boolean = False
        Dim facesdown As Boolean = False
        Dim facesright As Boolean = False

        'if left is ticked
        If LorR = True Then

            'if facing up
            If nodes(1).y < car.Y And nodes(2).y < car.Y Then

                car.Width = 40
                car.Height = 20
                car.Y = car.Y + 10
                car.X = car.X - 10

                nodes(0).y = nodes(0).y + 30
                nodes(0).x = car.X
                nodes(1).y = nodes(1).y + 70
                nodes(1).x = nodes(1).x - 50
                nodes(2).x = nodes(1).x
                nodes(2).y = nodes(2).y + 50
                nodes(3).x = car.X
                nodes(3).y = car.Y

                facesup = True

            End If

            'if facing left
            If nodes(1).x < car.X And facesup = False And facesdown = False Then

                car.Width = 20
                car.Height = 40
                car.X = car.X + 10
                car.Y = car.Y - 10

                nodes(0).x = nodes(0).x + 30
                nodes(0).y = nodes(0).y + 10
                nodes(1).x = nodes(0).x
                nodes(1).y = nodes(1).y + 50
                nodes(2).y = nodes(1).y
                nodes(3).x = car.X
                nodes(2).x = nodes(3).x

                nodes(3).y = nodes(0).y
                facesleft = True

            End If

            'if facing down
            If nodes(1).y > car.Y And nodes(0).y > car.Y And facesleft = False And facesup = False Then

                car.Width = 40
                car.Height = 20
                car.Y = car.Y + 10
                car.X = car.X - 10

                nodes(0).y = car.Y
                nodes(0).x = nodes(0).x + 10
                nodes(1).y = nodes(0).y
                nodes(1).x = nodes(1).x + 50
                nodes(2).x = nodes(1).x
                nodes(2).y = nodes(2).y - 50
                nodes(3).x = nodes(0).x
                nodes(3).y = nodes(0).y + 20

                facesdown = True
            End If

            'if facing right
            If facesleft = False And facesup = False And facesdown = False Then

                car.Width = 20
                car.Height = 40

                car.X = car.X + 10
                car.Y = car.Y - 10

                nodes(0).x = car.X
                nodes(0).y = car.Y
                nodes(1).x = nodes(0).x
                nodes(1).y = nodes(0).y - 40
                nodes(2).y = nodes(1).y
                nodes(2).x = nodes(1).x + 20
                nodes(3).y = nodes(0).y
                nodes(3).x = nodes(0).x + 20
            End If

        End If

        'user has selected right
        If LorR = False Then

            'if facing up
            If nodes(1).y < car.Y And nodes(2).y < car.Y Then

                car.Width = 40
                car.Height = 20
                car.Y = car.Y + 10
                car.X = car.X - 10

                nodes(0).y = car.Y
                nodes(0).x = car.X + 40
                nodes(1).y = nodes(0).y
                nodes(1).x = nodes(1).x + 70
                nodes(2).x = nodes(1).x
                nodes(2).y = nodes(1).y + 20
                nodes(3).x = nodes(0).x
                nodes(3).y = nodes(0).y + 20

                facesup = True

            End If

            'if facing right
            If car.Y = nodes(1).y And car.X < nodes(1).x And facesleft = False And facesdown = False And facesup = False Then

                car.Width = 20
                car.Height = 40
                car.X = car.X + 10
                car.Y = car.Y - 10

                nodes(0).x = car.X + 20
                nodes(0).y = car.Y + 40
                nodes(1).x = nodes(0).x
                nodes(1).y = nodes(0).y + 40
                nodes(2).y = nodes(1).y
                nodes(2).x = nodes(1).x - 20
                nodes(3).x = car.X
                nodes(3).y = car.Y + 40
                facesright = True

            End If

            'if facing down
            If nodes(1).y > car.Y And nodes(2).y > car.Y And facesright = False And facesup = False Then

                car.Width = 40
                car.Height = 20
                car.X = car.X - 10
                car.Y = car.Y + 10

                nodes(0).x = car.X
                nodes(0).y = car.Y + 20
                nodes(1).y = nodes(0).y
                nodes(1).x = nodes(0).x - 40
                nodes(2).x = nodes(1).x
                nodes(2).y = nodes(1).y - 20
                nodes(3).x = car.X
                nodes(3).y = car.Y

                facesdown = True

            End If

            'if facing left
            If facesdown = False And facesup = False And facesright = False Then

                car.Width = 20
                car.Height = 40
                car.X = car.X + 10
                car.Y = car.Y - 10

                nodes(0).x = car.X
                nodes(0).y = car.Y
                nodes(1).x = nodes(0).x
                nodes(1).y = nodes(0).y - 40
                nodes(2).y = nodes(1).y
                nodes(2).x = nodes(1).x + 20
                nodes(3).y = car.Y
                nodes(3).x = car.X + 20
            End If

        End If

        Game.gameGUI.Refresh()
        Game.gameGUI.drawCar(car)
        Game.gameGUI.drawObjects()

    End Sub

    Public Sub moveCar()

        Dim facesup As Boolean = False
        Dim facesleft As Boolean = False
        Dim facesdown As Boolean = False
        Dim facesright As Boolean = False

        'if facing up
        If nodes(1).y < car.Y And nodes(2).y < car.Y Then
            If car.Y <= Game.gameGUI.background.Y Then
                facesup = True
            Else
                car.Y = car.Y - 10

                For looper = 0 To 3

                    nodes(looper).y = nodes(looper).y - 10

                Next

                Game.gameGUI.Refresh()
                Game.gameGUI.drawCar(car)

                facesup = True
            End If
        End If

        'if facing left
        If nodes(1).x < car.X And facesup = False And facesdown = False Then
            If car.X <= Game.gameGUI.background.X Then
                facesleft = True
            Else
                car.X = car.X - 10

                For looper = 0 To 3

                    nodes(looper).x = nodes(looper).x - 10

                Next

                Game.gameGUI.Refresh()
                Game.gameGUI.drawCar(car)

                facesleft = True
            End If
        End If

        'if facing down
        If nodes(1).y > car.Y And nodes(0).y > car.Y And facesleft = False And facesup = False Then
            If car.Y + 40 >= Game.gameGUI.background.Y + 400 Then
                facesdown = True
            Else
                car.Y = car.Y + 10

                For looper = 0 To 3

                    nodes(looper).y = nodes(looper).y + 10

                Next

                Game.gameGUI.Refresh()
                Game.gameGUI.drawCar(car)

                facesdown = True
            End If
        End If

        'if facing right
        If facesleft = False And facesup = False And facesdown = False Then
            If car.X + 40 >= (Game.gameGUI.background.X + 720) Then
                facesright = True
            Else
                car.X = car.X + 10

                For looper = 0 To 3

                    nodes(looper).x = nodes(looper).x + 10

                Next

                Game.gameGUI.Refresh()
                Game.gameGUI.drawCar(car)

                facesright = True
            End If
        End If

    End Sub

    Public Sub playGame(ByVal LorR As Boolean)

        Dim hit As Boolean = False

        Do Until stopSim = True

            Application.DoEvents()

            moveCar()
            hit = checkEdge()

            Game.gameGUI.drawObjects()
            If hit = False Then hit = checkHull()
            If hit = True Then turnCar(LorR)
            wasteTime()

            hit = False

        Loop

    End Sub

    Public Sub wasteTime()

        Threading.Thread.Sleep(200)

    End Sub

    Public Function checkEdge() As Boolean

        If Game.gameGUI.background.X >= nodes(1).x Then

            Return True
        End If

        If Game.gameGUI.background.X + 721 <= nodes(1).x Then

            Return True
        End If

        If Game.gameGUI.background.Y >= nodes(1).y Then

            Return True
        End If

        If Game.gameGUI.background.Y + 401 <= nodes(1).y Then

            Return True
        End If

        Return False

    End Function

    Public Sub addObjects()

        Dim temp As node
        Dim inCar As Boolean = False

        For looper = 0 To 20

            Randomize()
            Randomize()

            temp.x = (Rnd(Rnd()) * 720)

            temp.y = (Rnd(Rnd()) * 400)

            'prevents nodes being drawn on top of car

            If temp.x > nodes(1).x And temp.x < nodes(2).x And temp.y > nodes(1).y And temp.y < car.Y + 40 Then
                inCar = True
            End If

            If inCar = False Then
                If objectNodes Is Nothing Then ReDim Preserve objectNodes(0) Else ReDim Preserve objectNodes(objectNodes.Length)

                objectNodes(looper) = temp
            End If

        Next

        Game.gameGUI.drawObjects()

    End Sub

    Public Function checkHull() As Boolean

        'checking when car faces up
        If nodes(1).y < car.Y And nodes(2).y < car.Y Then
            For looper = 0 To objectNodes.Length - 1
                If objectNodes(looper).x >= nodes(0).x And objectNodes(looper).x <= nodes(3).x Then
                    If objectNodes(looper).y >= nodes(1).y And objectNodes(looper).y <= nodes(0).y Then

                        Return True
                    End If
                End If
            Next
        End If


        'checking when car faces down
        If nodes(1).y > car.Y And nodes(2).y > car.Y Then
            For looper = 0 To objectNodes.Length - 1
                If objectNodes(looper).x <= nodes(0).x And objectNodes(looper).x >= nodes(3).x Then
                    If objectNodes(looper).y <= nodes(1).y And objectNodes(looper).y >= nodes(0).y Then

                        Return True
                    End If
                End If
            Next
        End If


        'checking when car faces left 
        If nodes(1).x < car.X And nodes(2).x < car.X Then
            For looper = 0 To objectNodes.Length - 1
                If objectNodes(looper).x >= nodes(2).x And objectNodes(looper).x <= nodes(3).x Then
                    If objectNodes(looper).y >= nodes(2).y And objectNodes(looper).y <= nodes(1).y Then

                        Return True
                    End If
                End If
            Next
        End If


        'checking when car faces right
        If nodes(1).x > car.X And nodes(2).x > car.X Then
            For looper = 0 To objectNodes.Length - 1
                If objectNodes(looper).x <= nodes(2).x And objectNodes(looper).x >= nodes(3).x Then
                    If objectNodes(looper).y <= nodes(2).y And objectNodes(looper).y >= nodes(1).y Then

                        Return True
                    End If
                End If
            Next
        End If


        Return False

    End Function
End Class

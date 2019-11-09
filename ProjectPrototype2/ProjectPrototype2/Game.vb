Public Class Game

    Public game As cGame
    Public WithEvents gameGUI As cGameGUI

    Private Sub Game_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Form2.Hide()

        game = New cGame

        gameGUI = New cGameGUI(Me, game)

        'Allows the graph GUI to access the list of controls
        Me.Controls.Add(gameGUI)

        gameGUI.Location = New Point(115, 130)
        gameGUI.Size = New Size(721, 401)
        game.stopSim = True

    End Sub

    Private Sub lblStart_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblStart.MouseEnter

        lblStart.ForeColor = Color.Gray

    End Sub

    Private Sub lblStart_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblStart.MouseLeave

        lblStart.ForeColor = Color.White

    End Sub

    Private Sub lblBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBack.Click

        If game.stopSim = False Then
            MsgBox("Please press stop before exiting to main menu.")
        Else
            Form2.Show()
            Me.Close()
        End If

    End Sub

    Private Sub lblBack_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBack.MouseEnter

        Me.lblBack.ForeColor = Color.Gray

    End Sub

    Private Sub lblBack_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBack.MouseLeave

        Me.lblBack.ForeColor = Color.White

    End Sub

    Private Sub lblStart_Click(sender As System.Object, e As System.EventArgs) Handles lblStart.Click, MyBase.KeyDown

        If cbLeft.Checked = False And cbRight.Checked = False Then
            MsgBox("Please tick a box to start.")
        ElseIf game.objectNodes Is Nothing Then
            game.stopSim = False
            Me.gameGUI.drawCar(Me.game.car)

            Me.game.addObjects()

            If cbLeft.Checked = True Then
                game.playGame(True)
            End If

            If cbRight.Checked = True Then
                game.playGame(False)
            End If
        Else
            game.stopSim = False

            If cbLeft.Checked = True Then
                game.playGame(True)
            End If

            If cbRight.Checked = True Then
                game.playGame(False)
            End If
        End If

    End Sub

    Private Sub cbLeft_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbLeft.CheckedChanged
        If cbLeft.Checked = True And cbRight.Checked = True Then
            cbRight.Checked = False
        End If
    End Sub

    Private Sub cbRight_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbRight.CheckedChanged
        If cbLeft.Checked = True And cbRight.Checked = True Then
            cbLeft.Checked = False
        End If
    End Sub

    Private Sub lblStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblStop.Click

        Me.game.stopSim = True

    End Sub

    Private Sub lblStop_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblStop.MouseEnter

        lblStop.ForeColor = Color.Gray

    End Sub

    Private Sub lblStop_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblStop.MouseLeave

        lblStop.ForeColor = Color.White

    End Sub

    Private Sub lblChangeScenario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblChangeScenario.Click

        If game.objectNodes Is Nothing Then
            MsgBox("Press start before changing scenario.")
        Else
            ReDim game.objectNodes(Nothing)
            gameGUI.Refresh()
            game.addObjects()
            gameGUI.drawCar(game.car)
        End If

    End Sub

    Private Sub lblChangeScenario_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblChangeScenario.MouseEnter

        lblChangeScenario.ForeColor = Color.Gray

    End Sub

    Private Sub lblChangeScenario_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblChangeScenario.MouseLeave

        lblChangeScenario.ForeColor = Color.White

    End Sub

End Class
Public Class Form2

    Private Sub lblConvexHull_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblConvexHull.Click

        Form1.Show()

    End Sub

    Private Sub lblConvexHull_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblConvexHull.MouseEnter

        Me.lblConvexHull.ForeColor = Color.LightBlue

    End Sub

    Private Sub lblConvexHull_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblConvexHull.MouseLeave

        Me.lblConvexHull.ForeColor = Color.Gray

    End Sub
   
    Private Sub lblConvexHullGame_Click(sender As System.Object, e As System.EventArgs) Handles lblConvexHullGame.Click

        Game.Show()

    End Sub

    Private Sub lblConvexHullGame_MouseEnter(sender As System.Object, e As System.EventArgs) Handles lblConvexHullGame.MouseEnter

        Me.lblConvexHullGame.ForeColor = Color.LightBlue

    End Sub

    Private Sub lblConvexHullGame_MouseLeave(sender As System.Object, e As System.EventArgs) Handles lblConvexHullGame.MouseLeave

        Me.lblConvexHullGame.ForeColor = Color.Gray

    End Sub

    Private Sub lblVectorAddition_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblVectorAddition.Click

        VectorAdditionForm.Show()

    End Sub

    Private Sub lblVectorAddition_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblVectorAddition.MouseEnter

        lblVectorAddition.ForeColor = Color.LightBlue

    End Sub

    Private Sub lblVectorAddition_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblVectorAddition.MouseLeave

        lblVectorAddition.ForeColor = Color.Gray

    End Sub
End Class
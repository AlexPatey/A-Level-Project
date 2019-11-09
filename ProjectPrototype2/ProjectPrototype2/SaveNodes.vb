Public Class SaveNodes

    Private Sub lblBack_Click(sender As System.Object, e As System.EventArgs) Handles lblBack.Click

        Me.Close()

    End Sub

    Private Sub lblBack_MouseEnter(sender As System.Object, e As System.EventArgs) Handles lblBack.MouseEnter

        lblBack.ForeColor = Color.Gray

    End Sub

    Private Sub lblBack_MouseLeave(sender As System.Object, e As System.EventArgs) Handles lblBack.MouseLeave

        lblBack.ForeColor = Color.White

    End Sub

    Private Sub lblSave_Click(sender As System.Object, e As System.EventArgs) Handles lblSave.Click

        If Me.tbFileName.Text = "" Then
            MsgBox("Please enter a file name")
        Else
            Form1.graph.saveGraph(Me.tbFileName.Text)
        End If

    End Sub

    Private Sub lblSave_MouseEnter(sender As System.Object, e As System.EventArgs) Handles lblSave.MouseEnter

        lblSave.ForeColor = Color.Gray

    End Sub

    Private Sub lblSave_MouseLeave(sender As System.Object, e As System.EventArgs) Handles lblSave.MouseLeave

        lblSave.ForeColor = Color.White

    End Sub

End Class
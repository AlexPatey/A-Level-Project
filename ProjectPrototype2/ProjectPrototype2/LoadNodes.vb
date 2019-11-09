Public Class LoadNodes

    Private Sub lblSelectFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSelectFile.Click

        OpenFile.ShowDialog()

    End Sub

    Private Sub lblSelectFile_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSelectFile.MouseEnter

        lblSelectFile.ForeColor = Color.Gray

    End Sub

    Private Sub lblSelectFile_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSelectFile.MouseLeave

        lblSelectFile.ForeColor = Color.White

    End Sub

    Private Sub OpenFile_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFile.FileOk

        Me.tbFilePath.Text = OpenFile.FileName

    End Sub

    Private Sub LblOk_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblOk.MouseEnter

        LblOk.ForeColor = Color.Gray

    End Sub

    Private Sub LblOk_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblOk.MouseLeave

        LblOk.ForeColor = Color.White

    End Sub

    Private Sub LblOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblOk.Click

        Form1.graph.loadGraph(Me.tbFilePath.Text)

        Me.Close()

    End Sub

    Private Sub lblBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBack.Click

        Me.Close()

    End Sub

    Private Sub lblBack_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBack.MouseEnter

        lblBack.ForeColor = Color.Gray

    End Sub

    Private Sub lblBack_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBack.MouseLeave

        lblBack.ForeColor = Color.White

    End Sub

End Class
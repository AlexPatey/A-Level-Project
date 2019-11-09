Public Class VectorAdditionForm

    Public WithEvents graphGUI As VectorAdditionGUI
    Public VectAdd As VectorAddition

    Private Sub VectorAdditionForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Form2.Hide()

        graphGUI = New VectorAdditionGUI
        VectAdd = New VectorAddition

        'Allows the graph GUI to access the list of controls
        Me.Controls.Add(graphGUI)

        'Manually sets the size and location of the graph
        graphGUI.Location = New Point(115, 130)
        graphGUI.Size = New Size(721, 401)

    End Sub

    Private Sub lblAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblAdd.Click

        If tbX1.Text Is Nothing Or tbX2.Text Is Nothing Or tbY1 Is Nothing Or tbY2.Text Is Nothing Then
            MsgBox("Please enter values in each text box before trying to add")
        Else
            Me.VectAdd.addVectors()
        End If

    End Sub

    Private Sub lblAdd_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblAdd.MouseEnter

        Me.lblAdd.ForeColor = Color.Gray

    End Sub

    Private Sub lblAdd_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblAdd.MouseLeave

        Me.lblAdd.ForeColor = Color.White

    End Sub

    Private Sub tbX1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbX1.TextChanged

        If Me.tbX1.Text = Nothing Or Me.tbX1.Text = "" Or Me.tbX1.Text = "-" Then

        Else
            Try
                Me.VectAdd.updateVectors(True, True, Me.tbX1.Text)
            Catch ex As Exception
                MsgBox("Please enter a number between -18 and 18")
            End Try
        End If

    End Sub

    

    Private Sub tbY1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbY1.TextChanged

        If Me.tbY1.Text = Nothing Or Me.tbY1.Text = "" Or Me.tbY1.Text = "-" Then

        Else
            'Try
            Me.VectAdd.updateVectors(False, True, Me.tbY1.Text)
            ' Catch ex As Exception
            'MsgBox("Please eneter a number between -10 and 10")
            ' End Try
        End If

    End Sub

    Private Sub tbY2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbY2.TextChanged

        If Me.tbY2.Text = Nothing Or Me.tbY2.Text = "" Or Me.tbY2.Text = "-" Then

        Else
            'Try
            Me.VectAdd.updateVectors(False, False, Me.tbY2.Text)
            ' Catch ex As Exception
            'MsgBox("Please eneter a number between -10 and 10")
            'End Try
        End If
    End Sub

    Private Sub lblBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBack.Click

        Form2.Show()
        Me.Close()

    End Sub

    Private Sub lblBack_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBack.MouseEnter

        Me.lblBack.ForeColor = Color.Gray

    End Sub

    Private Sub lblBack_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBack.MouseLeave

        Me.lblBack.ForeColor = Color.White

    End Sub

    Private Sub tbX2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbX2.TextChanged


        If Me.tbX2.Text = Nothing Or Me.tbX2.Text = "" Or Me.tbX2.Text = "-" Then

        Else
            'Try
            Me.VectAdd.updateVectors(True, False, Me.tbX2.Text)
            ' Catch ex As Exception
            'MsgBox("Please eneter a number between -10 and 10")
            'End Try
        End If

    End Sub
End Class
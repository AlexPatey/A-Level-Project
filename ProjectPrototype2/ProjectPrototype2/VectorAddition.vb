Public Class VectorAddition

    Public v1 As node
    Public v2 As node
    Public resultV As node
    Public drawV As Boolean

    Public Sub New()


    End Sub

    Public Sub addVectors()

        resultV.x = v1.x + v2.x
        resultV.y = v1.y + v2.y

        drawV = True

        VectorAdditionForm.Refresh()

    End Sub

    Public Sub updateVectors(ByVal isX As Boolean, ByVal isV1 As Boolean, ByVal value As Integer)

        If isX = True And isV1 = True Then
            v1.x = value
        else If isX = False And isV1 = True Then
            v1.y = value
        ElseIf isX = True And isV1 = False Then
            v2.x = value
        ElseIf isX = False And isV1 = False Then
            v2.y = value
        End If

        VectorAdditionForm.Refresh()

    End Sub

End Class


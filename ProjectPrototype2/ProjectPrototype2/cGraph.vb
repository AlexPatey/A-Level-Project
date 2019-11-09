Public Class cGraph

    Public nodes() As node
    Public convexNodes() As node
    Public drawHull As Boolean
    Public maxYnodes() As node

    Public Sub New()

    End Sub

    Public Sub addNode(ByVal node As node, ByVal target As Form1, ByVal random As Boolean)

        Dim nodeExists As Boolean = False

        'Dimensions the array to 1 if there is currently no space allocated, else redimensions the array to 1
        If Me.nodes Is Nothing Then ReDim nodes(0) Else ReDim Preserve nodes(nodes.Length)

        'Adds node to end of the array
        nodes(nodes.Length - 1) = node

        'Error check for any nodes which share the same coords
        For looper = 0 To nodes.Length - 2
            If nodes(looper).x = nodes(nodes.Length - 1).x And nodes(looper).y = nodes(nodes.Length - 1).y Then
                nodeExists = True
            End If
        Next

        Dim max As node
        Dim min As node

        max.x = node.x + 20
        max.y = node.y + 20
        min.x = node.x - 20
        min.y = node.y - 20

        'If the node is within a 10 pixel radius of another node it will not be added
        For looper = 0 To nodes.Length - 2
            If nodes(looper).x < max.x And nodes(looper).x > min.x Then
                If nodes(looper).y < max.y And nodes(looper).y > min.y Then
                    nodeExists = True
                    If random = False Then
                        MsgBox("Please leave a larger space between nodes.")
                    End If

                End If
            End If
        Next

        If nodeExists = True Then
            'Cuts of the last node which would be the duplicate
            ReDim Preserve nodes(nodes.Length - 2)
            nodeExists = False
        Else
            'Puts end node in correct position in relation to its x value
            order(nodes)
            'Updates the form textbox which tells the user how many nodes there are 
            target.tbNoOfNodes.Text = nodes.Length.ToString
        End If

        'Updates the GUI
        target.graphGUI.drawNodes(Me.nodes)

    End Sub

    Public Sub removeNode(ByVal node As node, ByVal target As Form1)

        Dim noOfNodes As Integer
        Dim max As node
        Dim min As node
        Dim badNode As Integer

        'max and min nodes are used so that the user does not have to click exactly on the pixel where the nodes is drawn, 
        'instead they have a radius in which they can click so that they do not have to be ultra-precise

        max.x = node.x + 10
        max.y = node.y + 10
        min.x = node.x - 10
        min.y = node.y - 10

        'determines wherether a nodes is within the area the user clicked

        For looper = 0 To nodes.Length - 1
            If nodes(looper).x <= max.x And nodes(looper).x >= min.x Then
                If nodes(looper).y <= max.y And nodes(looper).y >= min.y Then
                    noOfNodes += 1
                    badNode = looper
                End If
            End If
        Next

        'removes the selected node from the array of nodes

        If noOfNodes = 1 Then
            For looper2 = badNode To nodes.Length - 2
                nodes(looper2) = nodes(looper2 + 1)
            Next

            ReDim Preserve nodes(nodes.Length - 2)
            target.tbNoOfNodes.Text = (nodes.Length.ToString)
            target.graphGUI.Refresh()
        End If

    End Sub

    'Puts a single node in its correct position 
    Public Sub order(ByRef nodes() As node)

        Dim temp As node

        'Puts the new node in the correct position relative to its x value
        For looper = nodes.Length - 2 To 0 Step -1
            If nodes(looper).x > nodes(looper + 1).x Then
                temp = nodes(looper)
                nodes(looper) = nodes(looper + 1)
                nodes(looper + 1) = temp

                'If both nodes share the same x value, they are compared by y value, the node with the smallest y value is put first
            ElseIf nodes(looper).x = nodes(looper + 1).x And nodes(looper).y > nodes(looper).y Then

                temp = nodes(looper)
                nodes(looper) = nodes(looper + 1)
                nodes(looper + 1) = temp

            End If
        Next

    End Sub

    Public Sub findConvexHull(ByVal nodes As node())

        ' determines how many nodes have been passed through, if less than three appear, tehn an error message is shown, else the convex hull is to be solved.

        If nodes.Length <= 2 Then
            MsgBox("At least three points are required to form a hull")
            drawHull = False
        ElseIf nodes.Length = 3 Then
            ReDim Preserve convexNodes(2)
            convexNodes = nodes
            drawHull = True
        Else
            findQH(nodes, convexNodes)
            drawHull = True
        End If

        'updates the form

        Form1.graphGUI.Refresh()

    End Sub

    Public Sub findQH(ByVal nodes() As node, ByRef convexNodes() As node)

        Dim midPoint As node
        Dim Xmin As node
        Dim Xmax As node
        Dim s1() As node = Nothing
        Dim s2() As node = Nothing
        Dim bottomNodes() As node = Nothing
        Dim tempnodes() As node = Nothing
        convexNodes = Nothing

        Xmin = nodes(0)
        Xmax = nodes(nodes.Length - 1)

        'Finds midpoint

        midPoint.x = CInt(Xmin.x + ((Xmax.x - Xmin.x) / 2))
        midPoint.y = CInt(Xmin.y + ((Xmax.y - Xmin.y) / 2))

        'Split node array into two arrays (horizontal split through the midpoint)

        ' XMIN / XMAX IS ADDED TO S1 AND / OR S2 AND IT SHOULDNT (ERROR)

        splitS1AndS2(Xmin, Xmax, s1, s2, nodes)

        'if there are nodes in s1 (the top half), then the divide and conqeur sub-routine runs

        If s1 Is Nothing Then
        Else
            dAndQ(Xmin, Xmax, s1, convexNodes, True)
        End If

        'if there are nodes in s2 (the bottom half), then the divide and conqeur sub-routine runs

        If s2 Is Nothing Then
        Else
            dAndQ(Xmin, Xmax, s2, bottomNodes, False)
        End If

        'the x min and x max nodes are added to the convex hull

        If convexNodes Is Nothing Then ReDim Preserve convexNodes(0) Else ReDim Preserve convexNodes(convexNodes.Length)
        convexNodes(convexNodes.Length - 1) = Xmin
        order(convexNodes)
        If convexNodes Is Nothing Then ReDim Preserve convexNodes(0) Else ReDim Preserve convexNodes(convexNodes.Length)
        convexNodes(convexNodes.Length - 1) = Xmax
        order(convexNodes)

        'bottom nodes refer to the bottom half of the convex hull, which is combined with the convex hull at a later date
        'here the bottom half of the convex hull is added to the convex nodes variable

        If bottomNodes Is Nothing Then
        Else
            For looper = bottomNodes.Length - 1 To 0 Step -1
                If convexNodes Is Nothing Then ReDim Preserve convexNodes(0) Else ReDim Preserve convexNodes(convexNodes.Length)
                convexNodes(convexNodes.Length - 1) = bottomNodes(looper)
            Next
        End If

    End Sub

    Public Sub dAndQ(ByRef startPoint As node, ByRef endPoint As node, ByRef nodes() As node, ByRef convexNodes() As node, ByVal IsS1 As Boolean)

        Dim x As Boolean = True

        Dim area As Long = 0
        Dim areaToBeat As Long = 0
        Dim maxYNode As node
        Dim nodesLeft() As node = Nothing
        Dim LHS() As node = Nothing
        Dim RHS() As node = Nothing

        'finds highest y coord

        For looper = 0 To nodes.Length - 1
            area = furthestDistance(startPoint, endPoint, nodes(looper))
            If area > areaToBeat Then
                areaToBeat = area
                area = 0
                maxYNode.x = nodes(looper).x
                maxYNode.y = nodes(looper).y
            End If
        Next

        If maxYNode.x = 0 And maxYNode.y = 0 Then

        Else
            If convexNodes Is Nothing Then ReDim Preserve convexNodes(0) Else ReDim Preserve convexNodes(convexNodes.Length)
            convexNodes(convexNodes.Length - 1) = maxYNode
            order(convexNodes)
        End If

        If maxYnodes Is Nothing Then ReDim Preserve maxYnodes(0) Else ReDim Preserve maxYnodes(maxYnodes.Length)

        maxYnodes(maxYnodes.Length - 1) = maxYNode

        'removes nodes from the triangle created by the start point, end point and max y point

        If IsS1 = True Then
            findNodesLeft(startPoint, endPoint, maxYNode, nodes, nodesLeft, True)
        Else
            findNodesLeft(startPoint, endPoint, maxYNode, nodes, nodesLeft, False)
        End If

        'Splits remaining nodes into a left hand side and right hand side

        If nodesLeft Is Nothing Then
        Else
            For Looper = 0 To nodesLeft.Length - 1
                If nodesLeft(Looper).x < maxYNode.x Then
                    If LHS Is Nothing Then ReDim Preserve LHS(0) Else ReDim Preserve LHS(LHS.Length)
                    LHS(LHS.Length - 1) = nodesLeft(Looper)
                    order(LHS)
                ElseIf nodesLeft(Looper).x > maxYNode.x Then
                    If RHS Is Nothing Then ReDim Preserve RHS(0) Else ReDim Preserve RHS(RHS.Length)
                    RHS(RHS.Length - 1) = nodesLeft(Looper)
                    order(RHS)
                End If
            Next
        End If

        'recursively goes through the remaining nodes, the left hand side is always considered first, when there is no left hand side,
        'the right hand side is considered

        If LHS Is Nothing And RHS Is Nothing Then
        Else
            If LHS Is Nothing Then
            Else
                If LHS.Length = 1 Then
                    If convexNodes Is Nothing Then ReDim Preserve convexNodes(0) Else ReDim Preserve convexNodes(convexNodes.Length)
                    convexNodes(convexNodes.Length - 1) = LHS(0)
                    order(convexNodes)
                ElseIf LHS.Length > 1 Then
                    dAndQ(startPoint, maxYNode, LHS, convexNodes, IsS1)
                End If
            End If

            If RHS Is Nothing Then
            Else
                If RHS.Length = 1 Then
                    If convexNodes Is Nothing Then ReDim Preserve convexNodes(0) Else ReDim Preserve convexNodes(convexNodes.Length)
                    convexNodes(convexNodes.Length - 1) = RHS(0)
                    order(convexNodes)
                ElseIf RHS.Length > 1 Then
                    dAndQ(maxYNode, endPoint, RHS, convexNodes, IsS1)
                End If
            End If
        End If

    End Sub

    Public Function furthestDistance(ByRef a As node, ByRef b As node, ByRef c As node) As Long

        Dim sideBC As Long
        Dim sideCA As Long
        Dim length As Long

        'works out each sides length using pythagorus
        sideBC = CLng(Math.Sqrt(((c.x - b.x) ^ 2) + ((c.y - b.y) ^ 2)) / 2)
        sideCA = CLng(Math.Sqrt(((c.x - a.x) ^ 2) + ((c.y - a.y) ^ 2)) / 2)

        length = sideBC + sideCA

        Return length

    End Function

    Public Sub findNodesLeft(ByVal a As node, ByVal b As node, ByVal c As node, ByVal nodes() As node, ByRef nodesLeft() As node, ByVal s1 As Boolean)

        Dim grad1 As Decimal
        Dim grad2 As Decimal
        Dim y As Decimal
        Dim x As Decimal
        Dim z As Decimal
        Dim y2 As Decimal
        Dim x2 As Decimal
        Dim z2 As Decimal

        z2 = y2 - (grad2 * x2)

        'finds grad of two lines 
        If (c.x - a.x) = 0 Then
            grad1 = 10000000000000
            'Return
        Else
            grad1 = ((c.y - a.y) / (c.x - a.x))
        End If

        If (b.x - c.x) = 0 Then
            grad2 = 10000000000000
            'Return
        Else
            grad2 = ((b.y - c.y) / (b.x - c.x))
        End If

        'gives y and x a value to work out z
        y = a.y
        x = a.x
        z = y - (grad1 * x)

        y2 = b.y
        x2 = b.x
        z2 = y2 - (grad2 * x2)

        If s1 = True Then
            For looper = 0 To nodes.Length - 1
                x = nodes(looper).x
                y = (grad1 * x) + z
                x2 = nodes(looper).x
                y2 = (grad2 * x2) + z2
                If nodes(looper).y <= y And nodes(looper).y <= y2 Then
                    'must be in triangle, hence ignore it 
                Else
                    'is outside of triangle so needs to be added to the nodes left
                    If nodesLeft Is Nothing Then ReDim Preserve nodesLeft(0) Else ReDim Preserve nodesLeft(nodesLeft.Length)
                    nodesLeft(nodesLeft.Length - 1) = nodes(looper)
                End If
            Next

        Else

            For looper = 0 To nodes.Length - 1
                x = nodes(looper).x
                y = (grad1 * x) + z
                x2 = nodes(looper).x
                y2 = (grad2 * x2) + z2
                If nodes(looper).y >= y And nodes(looper).y >= y2 Then
                    'must be in triangle, hence ignore it 
                Else
                    'is outside of triangle so needs to be added to the nodes left
                    If nodesLeft Is Nothing Then ReDim Preserve nodesLeft(0) Else ReDim Preserve nodesLeft(nodesLeft.Length)
                    nodesLeft(nodesLeft.Length - 1) = nodes(looper)
                End If
            Next
        End If

    End Sub

    Public Sub splitS1AndS2(ByVal startPoint As node, ByVal endPoint As node, ByRef s1() As node, ByRef s2() As node, ByVal nodes() As node)

        Dim y As Decimal
        Dim x As Decimal
        Dim c As Decimal
        Dim grad As Decimal

        If (endPoint.x - startPoint.x) = 0 Then
            Return
        Else
            grad = (endPoint.y - startPoint.y) / (endPoint.x - startPoint.x)
        End If

        'works out the c value of the line from the minimum point to maximum point

        y = startPoint.y
        x = startPoint.x

        c = y - (grad * x)

        'after calculating the equation of the line that joins minimum and maximum X Coords, 
        'I loop the nodes that were passed in to see if they fall above the line,
        'and join S1, or below, and join S2

        For looper = 0 To nodes.Length - 1
            x = nodes(looper).x
            y = (grad * x) + c

            If nodes(looper).y > y Then
                If s1 Is Nothing Then ReDim Preserve s1(0) Else ReDim Preserve s1(s1.Length)
                s1(s1.Length - 1) = nodes(looper)

            ElseIf nodes(looper).y < y Then
                If s2 Is Nothing Then ReDim Preserve s2(0) Else ReDim Preserve s2(s2.Length)
                s2(s2.Length - 1) = nodes(looper)

            End If

        Next
    End Sub

    Public Sub getRandomNodes()

        nodes = Nothing

        Me.drawHull = False

        Dim posOrNeg As Integer
        Dim temp As node

        For looper = 0 To (Rnd() * 20 + 3)

            Randomize()
            Randomize()

            posOrNeg = Rnd(Rnd(1))
            temp.x = Rnd(Rnd()) * 360

            If posOrNeg = 0 Then

                temp.x = temp.x * -1

            End If

            posOrNeg = Rnd(1)
            temp.y = Rnd(Rnd()) * 200

            If posOrNeg = 0 Then

                temp.y = temp.y * -1

            End If

            addNode(temp, Form1, True)

        Next

    End Sub

    Public Sub saveGraph(ByVal fileName As String)
        Try
            FileOpen(1, "S:\" & fileName & ".txt", OpenMode.Output)

            For looper = 0 To Me.nodes.Length - 1
                PrintLine(1, Me.nodes(looper).x)
                PrintLine(1, Me.nodes(looper).y)
            Next

            FileClose(1)

            SaveNodes.Close()
        Catch ex As Exception
            MsgBox("Please try another file name.")
        End Try


    End Sub

    Public Sub loadGraph(ByVal fileName As String)

        nodes = Nothing

        Try

            FileOpen(1, fileName, OpenMode.Input)

            Do Until EOF(1)

                If nodes Is Nothing Then ReDim Preserve nodes(0) Else ReDim Preserve nodes(nodes.Length)
                nodes(nodes.Length - 1).x = LineInput(1)
                nodes(nodes.Length - 1).y = LineInput(1)

            Loop

            FileClose(1)

            Me.findConvexHull(nodes)

        Catch ex As Exception

            MsgBox("Please try another file.")

            nodes = Nothing

        End Try


    End Sub

End Class

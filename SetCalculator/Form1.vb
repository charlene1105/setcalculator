Public Class Form1

   
   
    Public setAElements() As String
    Public setBElements() As String
    Public setCElements() As String
    Public lastop As Char

    Public temp As IEnumerable(Of String) = {""}
    Public intersectedTemp As IEnumerable(Of String) = {""}
    Public nxtOperand As IEnumerable(Of String) = {""}


    '===================================================================================
    ' Set Buttons
    '===================================================================================
    Private Sub btnSetA_Click(sender As Object, e As EventArgs) Handles btnSetA.Click
        lblInput.Text &= "A"
        setAElements = txtSetA.Text.Split(" ")
    End Sub

    Private Sub btnSetB_Click(sender As Object, e As EventArgs) Handles btnSetB.Click
        lblInput.Text &= "B"
        setBElements = txtSetB.Text.Split(" ")
    End Sub

    Private Sub btnSetC_Click(sender As Object, e As EventArgs) Handles btnSetC.Click
        lblInput.Text &= "C"
        setCElements = txtSetC.Text.Split(" ")
    End Sub

    '===================================================================================
    'Operator Buttons
    '===================================================================================
    'Union
    Private Sub btnUnion_Click(sender As Object, e As EventArgs) Handles btnUnion.Click
        lblInput.Text &= "U"
    End Sub

    'Intersection
    Private Sub btnIntersection_Click(sender As Object, e As EventArgs) Handles btnIntersection.Click
        lblInput.Text &= "∩"
    End Sub

    'Difference
    Private Sub btnDifference_Click(sender As Object, e As EventArgs) Handles btnDifference.Click
        lblInput.Text &= "-"
    End Sub

    'Multiply
    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        lblInput.Text &= "*"

    End Sub

    'Complement
    Private Sub btnComplement_Click(sender As Object, e As EventArgs) Handles btnComplement.Click
        lblInput.Text = "Universal Set: AUB, Complement of Set C"
        lblAnswer.Text = ""
        setAElements = txtSetA.Text.Split(" ")
        setBElements = txtSetB.Text.Split(" ")
        setCElements = txtSetC.Text.Split(" ")
        Dim universalSet As IEnumerable(Of String)
        Dim intersectedSet As IEnumerable(Of String)
        universalSet = setAElements.Union(setBElements)
        intersectedSet = universalSet.Intersect(setCElements)
        universalSet = universalSet.Except(intersectedSet)
        Dim sortedTemp(universalSet.Count) As String
        For i = 0 To universalSet.Count - 1
            sortedTemp(i) = universalSet(i)
        Next
        Array.Sort(sortedTemp)
        For i = 0 To sortedTemp.Count - 1
            lblAnswer.Text &= sortedTemp(i) & " "
        Next
    End Sub

    'Subset
    Private Sub btnSubset_Click(sender As Object, e As EventArgs) Handles btnSubset.Click
        lblInput.Text &= "<"
    End Sub


    '===================================================================================
    'Other Buttons
    '===================================================================================
    'Backspace
    Private Sub btnBackspace_Click(sender As Object, e As EventArgs) Handles btnBackspace.Click
        If lblInput.Text.Count > 0 Then
            lblInput.Text = lblInput.Text.Remove(lblInput.Text.Count - 1, 1)
        End If
    End Sub

    'Clear
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblInput.Text = ""
        lblAnswer.Text = ""
    End Sub

    'Open Parenthesis
    Private Sub btnOpenParenthesis_Click(sender As Object, e As EventArgs)
        lblInput.Text &= "("
    End Sub

    'Close Parenthesis
    Private Sub btnCloseParenthesis_Click(sender As Object, e As EventArgs)
        lblInput.Text &= ")"
    End Sub


    Private Sub btnEquals_Click(sender As Object, e As EventArgs) Handles btnEquals.Click
        If txtSetA.Text = "" And txtSetB.Text = "" And txtSetC.Text = "" Then
            MessageBox.Show("No input")
        Else
            setAElements = txtSetA.Text.Split(" ")
            setBElements = txtSetB.Text.Split(" ")
            setCElements = txtSetC.Text.Split(" ")


            lblAnswer.Text = ""
            Dim input() As Char
            Dim oprtrcount As Integer
            Dim oprndcount As Integer
            Dim oprtrno As Integer = 0
            Dim oprndno As Integer = 0
            Dim subset As Integer = 0
            Dim noerror As Boolean = False

            input = lblInput.Text.ToCharArray
            For i = 0 To input.Count - 1
                'count the no of operator
                If input(i) = "U" Or input(i) = "∩" Or input(i) = "*" Or input(i) = "<" Or input(i) = "c" Or input(i) = "-" Then
                    oprtrcount += 1
                    'count the no of operands
                ElseIf input(i) = "A" Or input(i) = "B" Or input(i) = "C" Then
                    oprndcount += 1
                End If
            Next

            Dim operators(oprtrcount - 1) As Char
            Dim operands(oprndcount - 1) As Char

            For i = 0 To input.Count - 1
                'get the operands
                If i Mod 2 = 0 Then
                    If input(i) = "A" Or input(i) = "B" Or input(i) = "C" Then
                        operands(oprndno) = input(i)
                        oprndno += 1
                        noerror = False
                    Else
                        noerror = True
                        lblAnswer.Text = "Syntax Error"
                    End If
                    'get the operators
                Else
                    If input(i) = "U" Or input(i) = "∩" Or input(i) = "*" Or input(i) = "<" Or input(i) = "c" Or input(i) = "-" Then
                        operators(oprtrno) = input(i)
                        oprtrno += 1
                        noerror = False
                    Else
                        noerror = True
                        lblAnswer.Text = "Syntax Error"
                    End If
                End If
            Next


            If input.Last = "U" Or input.Last = "∩" Or input.Last = "*" Or input.Last = "<" Or input.Last = "-" Then
                lblAnswer.Text = "Syntax Error"
            Else
                If input.Count > 2 And noerror = False Then


                    Dim j As Integer = 1
                    temp = {""}
                    nxtOperand = {""}
                    For i = 0 To operators.Count - 1
                        If i = 0 Then
                            If operands(i) = "A" Then
                                temp = setAElements
                            ElseIf operands(i) = "B" Then
                                temp = setBElements
                            ElseIf operands(i) = "C" Then
                                temp = setCElements
                            End If
                        End If


                        If operands(j) = "A" Then
                            nxtOperand = setAElements
                        ElseIf operands(j) = "B" Then
                            nxtOperand = setBElements
                        ElseIf operands(j) = "C" Then
                            nxtOperand = setCElements
                        End If



                        If operators(i) = "U" Then
                            temp = temp.Union(nxtOperand)
                        ElseIf operators(i) = "∩" Then
                            temp = temp.Intersect(nxtOperand)
                        ElseIf operators(i) = "*" Then
                            lastop = "*"
                            Dim multipliedElements(temp.Count * nxtOperand.Count - 1) As String
                            Dim k As Integer = 0
                            For x = 0 To temp.Count - 1
                                For y = 0 To nxtOperand.Count - 1
                                    multipliedElements(k) = temp(x) & nxtOperand(y)
                                    k += 1
                                Next
                            Next
                            Array.Clear(temp, 0, temp.Count)
                            For p = 0 To multipliedElements.Count - 1
                                lblAnswer.Text &= " " & multipliedElements(p)
                            Next
                            temp = lblAnswer.Text.Split(" ")
                            lblAnswer.Text = ""
                        ElseIf operators(i) = "<" Then
                            For x = 0 To temp.Count - 1
                                If nxtOperand.Contains(temp(x)) Then
                                    subset += 1
                                End If
                            Next
                            If subset < temp.Count Then
                                lblAnswer.Text = "False"
                            Else
                                lblAnswer.Text = "True"
                            End If
                        ElseIf operators(i) = "-" Then
                            intersectedTemp = temp.Intersect(nxtOperand)
                            temp = temp.Union(nxtOperand)
                            temp = temp.Except(intersectedTemp)
                        End If
                        j += 1
                    Next

                    If input.Contains("<") Then

                    Else
                        printAnswer()
                    End If


                    'Clear and reset the input
                    Array.Clear(operands, 0, operands.Count)
                    Array.Clear(operators, 0, operators.Count)
                    oprndno = 0
                    oprndcount = 0
                    oprtrcount = 0
                    oprndno = 0


                Else
                    lblAnswer.Text = "Syntax Error"
                End If
            End If

       


        End If


        lastop = ""

    End Sub

    Public Sub printAnswer()
        Dim sortedTemp(temp.Count) As String
        For i = 0 To temp.Count - 1
            sortedTemp(i) = temp(i)
        Next
        If lastop <> "*" Then
            Array.Sort(sortedTemp)
        End If
        For i = 0 To sortedTemp.Count - 1
            lblAnswer.Text &= sortedTemp(i) & " "
        Next
    End Sub

    Private Sub btnSetAClr_Click(sender As Object, e As EventArgs) Handles btnSetAClr.Click
        txtSetA.Text = ""
    End Sub

    Private Sub btnSetBClr_Click(sender As Object, e As EventArgs) Handles btnSetBClr.Click
        txtSetB.Text = ""
    End Sub

    Private Sub btnSetCClr_Click(sender As Object, e As EventArgs) Handles btnSetCClr.Click
        txtSetC.Text = ""
    End Sub

 
    Private Sub txtSetA_TextChanged(sender As Object, e As EventArgs) Handles txtSetA.TextChanged
        If txtSetA.Text.Count > 1 Then
            If txtSetA.Text.Contains(" ") = False Then
                disableButtons()
                FlatLabel1.Visible = True
                FlatLabel1.Text = "Include spaces between each elements"
                Panel1.Enabled = False
                grpButtons.Enabled = False


            Else
                enableButtons()
                FlatLabel1.Visible = False
                Panel1.Enabled = True
                grpButtons.Enabled = True
            End If
        End If
    End Sub

    Private Sub txtSetB_TextChanged(sender As Object, e As EventArgs) Handles txtSetB.TextChanged
        If txtSetB.Text.Count > 1 Then
            If txtSetB.Text.Contains(" ") = False Then
                disableButtons()
                FlatLabel1.Visible = True
                FlatLabel1.Text = "Include spaces between each elements"
                Panel1.Enabled = False
                grpButtons.Enabled = False
            Else
                enableButtons()
                FlatLabel1.Visible = False
                Panel1.Enabled = True
                grpButtons.Enabled = True
            End If
        End If
    End Sub

    Private Sub txtSetC_TextChanged(sender As Object, e As EventArgs) Handles txtSetC.TextChanged
        If txtSetC.Text.Count > 1 Then
            If txtSetC.Text.Contains(" ") = False Then
                disableButtons()
                FlatLabel1.Visible = True
                FlatLabel1.Text = "Include spaces between each elements"
                Panel1.Enabled = False
                grpButtons.Enabled = False
            Else
                enableButtons()
                FlatLabel1.Visible = False
                Panel1.Enabled = True
                grpButtons.Enabled = True
            End If
        End If
    End Sub

    Public Sub disableButtons()
        btnSetA.BaseColor = Color.DarkSlateGray
        btnSetB.BaseColor = Color.DarkSlateGray
        btnSetC.BaseColor = Color.DarkSlateGray

        FlatButton5.BaseColor = Color.DarkSlateGray
        FlatButton6.BaseColor = Color.DarkSlateGray


        btnBackspace.BaseColor = Color.DarkSlateGray
        btnClear.BaseColor = Color.DarkSlateGray
        btnComplement.BaseColor = Color.DarkSlateGray
        btnDifference.BaseColor = Color.DarkSlateGray
        btnEquals.BaseColor = Color.DarkSlateGray
        btnIntersection.BaseColor = Color.DarkSlateGray
        btnMultiply.BaseColor = Color.DarkSlateGray
        btnUnion.BaseColor = Color.DarkSlateGray
        btnSubset.BaseColor = Color.DarkSlateGray
    End Sub

    Public Sub enableButtons()
        btnSetA.BaseColor = Color.MediumSeaGreen
        btnSetB.BaseColor = Color.Aqua
        btnSetC.BaseColor = Color.Teal

        FlatButton5.BaseColor = Color.Teal
        FlatButton6.BaseColor = Color.Teal

        btnBackspace.BaseColor = Color.Teal
        btnClear.BaseColor = Color.Teal
        btnComplement.BaseColor = Color.LightSeaGreen
        btnDifference.BaseColor = Color.LightSeaGreen
        btnEquals.BaseColor = Color.DarkCyan
        btnIntersection.BaseColor = Color.LightSeaGreen
        btnMultiply.BaseColor = Color.LightSeaGreen
        btnUnion.BaseColor = Color.LightSeaGreen
        btnSubset.BaseColor = Color.LightSeaGreen
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        disableButtons()
    End Sub
End Class

Public Class Form1

    Dim firstV As Double
    Dim secondV As Double
    Dim result As Double
    Dim oper As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxTJ.Text = ""

    End Sub

    Private Sub Number_Click(sender As Object, e As EventArgs) Handles ButtonP.Click, Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button3.Click, Button2.Click, Button10.Click, Button1.Click
        Dim b As Button = sender


        Try

            If (TextBoxTJ.Text = "0") Then
                TextBoxTJ.Text = ""
                TextBoxTJ.Text = b.Text
            ElseIf (b.Text = ".") Then
                If (Not TextBoxTJ.Text.Contains(".")) Then
                    TextBoxTJ.Text = TextBoxTJ.Text + b.Text
                End If
            Else
                TextBoxTJ.Text = TextBoxTJ.Text + b.Text
            End If

        Catch ex As Exception
            MsgBox("You input an invalid number please try again!")
        End Try


    End Sub

    Private Sub ButtonBS_Click(sender As Object, e As EventArgs) Handles ButtonBS.Click



        If (TextBoxTJ.Text.Length > 0) Then
            TextBoxTJ.Text = TextBoxTJ.Text.Remove(TextBoxTJ.Text.Length - 1, 1)
        End If


    End Sub

    Private Sub Operator_Click(sender As Object, e As EventArgs) Handles ButtonS.Click, ButtonM.Click, ButtonD.Click, ButtonA.Click
        Dim b As Button = sender

        Try
            firstV = TextBoxTJ.Text
            oper = b.Text
            TextBoxTJ.Text = ""

        Catch ex As Exception
            MsgBox("Your input is invalid try again!")
        End Try
    End Sub

    Private Sub ButtonE_Click(sender As Object, e As EventArgs) Handles ButtonE.Click
        Try
            secondV = TextBoxTJ.Text


            If oper = "+" Then
                result = firstV + secondV
                TextBoxTJ.Text = result

            ElseIf oper = "-" Then
                result = firstV - secondV
                TextBoxTJ.Text = result

            ElseIf oper = "x" Then
                result = firstV * secondV
                TextBoxTJ.Text = result

            ElseIf oper = "/" Then
                result = firstV / secondV
                TextBoxTJ.Text = result
            End If

            If (Not result = FormatNumber(result, 2)) Then
                TextBoxTJ.Text = FormatNumber(result, 2)
            ElseIf (result = FormatNumber(result, 0)) Then
                TextBoxTJ.Text = FormatNumber(result, 0)
            End If

        Catch ex As Exception
            MsgBox("Your input is invalid try again!")
        End Try

    End Sub

    Private Sub ButtonInter_Click(sender As Object, e As EventArgs) Handles ButtonInter.Click
        Try
            If (TextBoxTJ.Text.Contains("-")) Then
                TextBoxTJ.Text = TextBoxTJ.Text.Remove(0, 1)
            Else
                TextBoxTJ.Text = "-" + (TextBoxTJ.Text)
            End If

        Catch ex As Exception
            MsgBox("Your input is invalid try again!")
        End Try
    End Sub

    Private Sub ButtonClr_Click(sender As Object, e As EventArgs) Handles ButtonClr.Click
        TextBoxTJ.Text = ""
    End Sub
End Class

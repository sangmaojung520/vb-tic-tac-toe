Public Class Form1

    Dim checker As Boolean
    Dim plusone As Integer

    Private Sub Enable_False()
        Buttontic1.Enabled = False
        Buttontic2.Enabled = False
        Buttontic3.Enabled = False
        Buttontic4.Enabled = False
        Buttontic5.Enabled = False
        Buttontic6.Enabled = False
        Buttontic7.Enabled = False
        Buttontic8.Enabled = False
        Buttontic9.Enabled = False

    End Sub

    Private Sub score()
        If (Buttontic1.Text = "X" And Buttontic2.Text = "X" And Buttontic3.Text = "X") Then
            Buttontic1.BackColor = System.Drawing.Color.PowderBlue
            Buttontic2.BackColor = System.Drawing.Color.PowderBlue
            Buttontic3.BackColor = System.Drawing.Color.PowderBlue
            MsgBox("The Winner is player X", vbOKOnly, "TicTacToe")
            plusone = Convert.ToInt64(Label3.Text)
            Label3.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If

        If (Buttontic1.Text = "X" And Buttontic4.Text = "X" And Buttontic7.Text = "X") Then
            Buttontic1.BackColor = System.Drawing.Color.Pink
            Buttontic4.BackColor = System.Drawing.Color.Pink
            Buttontic7.BackColor = System.Drawing.Color.Pink
            MsgBox("The Winner is player X", vbOKOnly, "TicTacToe")
            plusone = Convert.ToInt64(Label3.Text)
            Label3.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If

        If (Buttontic1.Text = "X" And Buttontic5.Text = "X" And Buttontic9.Text = "X") Then
            Buttontic1.BackColor = System.Drawing.Color.Crimson
            Buttontic5.BackColor = System.Drawing.Color.Crimson
            Buttontic9.BackColor = System.Drawing.Color.Crimson
            MsgBox("The Winner is player X", vbOKOnly, "TicTacToe")
            plusone = Convert.ToInt64(Label3.Text)
            Label3.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If

        If (Buttontic3.Text = "X" And Buttontic5.Text = "X" And Buttontic7.Text = "X") Then
            Buttontic3.BackColor = System.Drawing.Color.CadetBlue
            Buttontic5.BackColor = System.Drawing.Color.CadetBlue
            Buttontic7.BackColor = System.Drawing.Color.CadetBlue
            MsgBox("The Winner is player X", vbOKOnly, "TicTacToe")
            plusone = Convert.ToInt64(Label3.Text)
            Label3.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If

        If (Buttontic2.Text = "X" And Buttontic5.Text = "X" And Buttontic8.Text = "X") Then
            Buttontic2.BackColor = System.Drawing.Color.SlateBlue
            Buttontic5.BackColor = System.Drawing.Color.SlateBlue
            Buttontic8.BackColor = System.Drawing.Color.SlateBlue
            MsgBox("The Winner is player X", vbOKOnly, "TicTacToe")
            plusone = Convert.ToInt64(Label3.Text)
            Label3.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If


        If (Buttontic3.Text = "X" And Buttontic6.Text = "X" And Buttontic9.Text = "X") Then
            Buttontic3.BackColor = System.Drawing.Color.Violet
            Buttontic6.BackColor = System.Drawing.Color.Violet
            Buttontic9.BackColor = System.Drawing.Color.Violet
            MsgBox("The Winner is player X", vbOKOnly, "TicTacToe")
            plusone = Convert.ToInt64(Label3.Text)
            Label3.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If

        If (Buttontic4.Text = "X" And Buttontic5.Text = "X" And Buttontic6.Text = "X") Then
            Buttontic4.BackColor = System.Drawing.Color.DarkSlateBlue
            Buttontic5.BackColor = System.Drawing.Color.DarkSlateBlue
            Buttontic6.BackColor = System.Drawing.Color.DarkSlateBlue
            MsgBox("The Winner is player X", vbOKOnly, "TicTacToe")
            plusone = Convert.ToInt64(Label3.Text)
            Label3.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If

        If (Buttontic7.Text = "X" And Buttontic8.Text = "X" And Buttontic9.Text = "X") Then
            Buttontic7.BackColor = System.Drawing.Color.Azure
            Buttontic8.BackColor = System.Drawing.Color.Azure
            Buttontic9.BackColor = System.Drawing.Color.Azure
            MsgBox("The Winner is player X", vbOKOnly, "TicTacToe")
            plusone = Convert.ToInt64(Label3.Text)
            Label3.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If

        '==============================================================================================

        If (Buttontic1.Text = "O" And Buttontic2.Text = "O" And Buttontic3.Text = "O") Then
            Buttontic1.BackColor = System.Drawing.Color.LemonChiffon
            Buttontic2.BackColor = System.Drawing.Color.LemonChiffon
            Buttontic3.BackColor = System.Drawing.Color.LemonChiffon
            MsgBox("The Winner is player O", vbOKOnly, "TicTacToe")
            plusone = Convert.ToInt64(Label4.Text)
            Label4.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If

        If (Buttontic1.Text = "O" And Buttontic4.Text = "O" And Buttontic7.Text = "O") Then
            Buttontic1.BackColor = System.Drawing.Color.AliceBlue
            Buttontic4.BackColor = System.Drawing.Color.AliceBlue
            Buttontic7.BackColor = System.Drawing.Color.AliceBlue
            MsgBox("The Winner is player O", vbOKOnly, "TicTacToe")
            plusone = Convert.ToInt64(Label4.Text)
            Label4.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If

        If (Buttontic1.Text = "X" And Buttontic5.Text = "X" And Buttontic9.Text = "X") Then
            Buttontic1.BackColor = System.Drawing.Color.BlueViolet
            Buttontic5.BackColor = System.Drawing.Color.BlueViolet
            Buttontic9.BackColor = System.Drawing.Color.BlueViolet
            MsgBox("The Winner is player O", vbOKOnly, "TicTacToe")
            plusone = Convert.ToInt64(Label4.Text)
            Label4.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If

        If (Buttontic3.Text = "X" And Buttontic5.Text = "X" And Buttontic7.Text = "X") Then
            Buttontic3.BackColor = System.Drawing.Color.NavajoWhite
            Buttontic5.BackColor = System.Drawing.Color.NavajoWhite
            Buttontic7.BackColor = System.Drawing.Color.NavajoWhite
            MsgBox("The Winner is player O", vbOKOnly, "TicTacToe")
            plusone = Convert.ToInt64(Label4.Text)
            Label4.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If

        If (Buttontic2.Text = "X" And Buttontic5.Text = "X" And Buttontic8.Text = "X") Then
            Buttontic2.BackColor = System.Drawing.Color.SandyBrown
            Buttontic5.BackColor = System.Drawing.Color.SandyBrown
            Buttontic8.BackColor = System.Drawing.Color.SandyBrown
            MsgBox("The Winner is player O", vbOKOnly, "TicTacToe")
            plusone = Convert.ToInt64(Label4.Text)
            Label4.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If


        If (Buttontic3.Text = "X" And Buttontic6.Text = "X" And Buttontic9.Text = "X") Then
            Buttontic3.BackColor = System.Drawing.Color.SeaGreen
            Buttontic6.BackColor = System.Drawing.Color.SeaGreen
            Buttontic9.BackColor = System.Drawing.Color.SeaGreen
            MsgBox("The Winner is player O", vbOKOnly, "TicTacToe")
            plusone = Convert.ToInt64(Label4.Text)
            Label4.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If

        If (Buttontic4.Text = "X" And Buttontic5.Text = "X" And Buttontic6.Text = "X") Then
            Buttontic4.BackColor = System.Drawing.Color.Azure
            Buttontic5.BackColor = System.Drawing.Color.Azure
            Buttontic6.BackColor = System.Drawing.Color.Azure
            MsgBox("The Winner is player O", vbOKOnly, "TicTacToe")
            plusone = Convert.ToInt64(Label4.Text)
            Label4.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If

        If (Buttontic7.Text = "X" And Buttontic8.Text = "X" And Buttontic9.Text = "X") Then
            Buttontic7.BackColor = System.Drawing.Color.DarkGreen
            Buttontic8.BackColor = System.Drawing.Color.DarkGreen
            Buttontic9.BackColor = System.Drawing.Color.DarkGreen
            MsgBox("The Winner is player O", vbOKOnly, "TicTacToe")
            plusone = Convert.ToInt64(Label4.Text)
            Label4.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If



    End Sub

    Private Sub Buttontic1_Click(sender As Object, e As EventArgs) Handles Buttontic1.Click
        If (checker = False) Then
            Buttontic1.Text = "X"
            checker = True
        Else
            Buttontic1.Text = "O"
            checker = False
        End If
        score()
        Buttontic1.Enabled = False
    End Sub

    Private Sub Buttontic2_Click(sender As Object, e As EventArgs) Handles Buttontic2.Click
        If (checker = False) Then
            Buttontic2.Text = "X"
            checker = True
        Else
            Buttontic2.Text = "O"
            checker = False
        End If
        score()
        Buttontic2.Enabled = False
    End Sub

    Private Sub Buttontic3_Click(sender As Object, e As EventArgs) Handles Buttontic3.Click
        If (checker = False) Then
            Buttontic3.Text = "X"
            checker = True
        Else
            Buttontic3.Text = "O"
            checker = False
        End If
        score()
        Buttontic3.Enabled = False
    End Sub

    Private Sub Buttontic4_Click(sender As Object, e As EventArgs) Handles Buttontic4.Click
        If (checker = False) Then
            Buttontic4.Text = "X"
            checker = True
        Else
            Buttontic4.Text = "O"
            checker = False
        End If
        score()
        Buttontic4.Enabled = False
    End Sub

    Private Sub Buttontic5_Click(sender As Object, e As EventArgs) Handles Buttontic5.Click
        If (checker = False) Then
            Buttontic5.Text = "X"
            checker = True
        Else
            Buttontic5.Text = "O"
            checker = False
        End If
        score()
        Buttontic5.Enabled = False
    End Sub

    Private Sub Buttontic6_Click(sender As Object, e As EventArgs) Handles Buttontic6.Click
        If (checker = False) Then
            Buttontic6.Text = "X"
            checker = True
        Else
            Buttontic6.Text = "O"
            checker = False
        End If
        score()
        Buttontic6.Enabled = False
    End Sub

    Private Sub Buttontic7_Click(sender As Object, e As EventArgs) Handles Buttontic7.Click
        If (checker = False) Then
            Buttontic7.Text = "X"
            checker = True
        Else
            Buttontic7.Text = "O"
            checker = False
        End If
        score()
        Buttontic7.Enabled = False
    End Sub

    Private Sub Buttontic8_Click(sender As Object, e As EventArgs) Handles Buttontic8.Click
        If (checker = False) Then
            Buttontic8.Text = "X"
            checker = True
        Else
            Buttontic8.Text = "O"
            checker = False
        End If
        score()
        Buttontic8.Enabled = False
    End Sub

    Private Sub Buttontic9_Click(sender As Object, e As EventArgs) Handles Buttontic9.Click
        If (checker = False) Then
            Buttontic9.Text = "X"
            checker = True
        Else
            Buttontic9.Text = "O"
            checker = False
        End If
        score()
        Buttontic9.Enabled = False
    End Sub

    Private Sub Buttontic10_Click(sender As Object, e As EventArgs) Handles Buttontic10.Click
        Buttontic1.Enabled = True
        Buttontic2.Enabled = True
        Buttontic3.Enabled = True
        Buttontic4.Enabled = True
        Buttontic5.Enabled = True
        Buttontic6.Enabled = True
        Buttontic7.Enabled = True
        Buttontic8.Enabled = True
        Buttontic9.Enabled = True

        Buttontic1.Text = ""
        Buttontic2.Text = ""
        Buttontic3.Text = ""
        Buttontic4.Text = ""
        Buttontic5.Text = ""
        Buttontic6.Text = ""
        Buttontic7.Text = ""
        Buttontic8.Text = ""
        Buttontic9.Text = ""

        Label3.Text = "0"
        Label4.Text = "0"

        Buttontic1.BackColor = System.Drawing.Color.WhiteSmoke
        Buttontic2.BackColor = System.Drawing.Color.WhiteSmoke
        Buttontic3.BackColor = System.Drawing.Color.WhiteSmoke
        Buttontic4.BackColor = System.Drawing.Color.WhiteSmoke
        Buttontic5.BackColor = System.Drawing.Color.WhiteSmoke
        Buttontic6.BackColor = System.Drawing.Color.WhiteSmoke
        Buttontic7.BackColor = System.Drawing.Color.WhiteSmoke
        Buttontic8.BackColor = System.Drawing.Color.WhiteSmoke
        Buttontic9.BackColor = System.Drawing.Color.WhiteSmoke

    End Sub

    Private Sub Buttontic11_Click(sender As Object, e As EventArgs) Handles Buttontic11.Click
        Buttontic1.Enabled = True
        Buttontic2.Enabled = True
        Buttontic3.Enabled = True
        Buttontic4.Enabled = True
        Buttontic5.Enabled = True
        Buttontic6.Enabled = True
        Buttontic7.Enabled = True
        Buttontic8.Enabled = True
        Buttontic9.Enabled = True

        Buttontic1.Text = ""
        Buttontic2.Text = ""
        Buttontic3.Text = ""
        Buttontic4.Text = ""
        Buttontic5.Text = ""
        Buttontic6.Text = ""
        Buttontic7.Text = ""
        Buttontic8.Text = ""
        Buttontic9.Text = ""

        Buttontic10.Enabled = True



        Buttontic1.BackColor = System.Drawing.Color.WhiteSmoke
        Buttontic2.BackColor = System.Drawing.Color.WhiteSmoke
        Buttontic3.BackColor = System.Drawing.Color.WhiteSmoke
        Buttontic4.BackColor = System.Drawing.Color.WhiteSmoke
        Buttontic5.BackColor = System.Drawing.Color.WhiteSmoke
        Buttontic6.BackColor = System.Drawing.Color.WhiteSmoke
        Buttontic7.BackColor = System.Drawing.Color.WhiteSmoke
        Buttontic8.BackColor = System.Drawing.Color.WhiteSmoke
        Buttontic9.BackColor = System.Drawing.Color.WhiteSmoke
    End Sub

    Private Sub Buttontic12_Click(sender As Object, e As EventArgs) Handles Buttontic12.Click
        Dim iexit As DialogResult
        iexit = MsgBox("Do you want to exit ?", vbYesNo, "TicTacToe")
        If iexit = DialogResult.Yes Then
            Application.Exit()

        End If
    End Sub
End Class

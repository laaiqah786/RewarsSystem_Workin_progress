Public Class Cart
    Public boolIsUser As Boolean
    Dim closeProgram As New ProgramClose
    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        Profile.Show()
        Me.Visible = False

    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim total As Double = 0
        Dim message As String = ""
        Dim Extra As String = ""

        'items
        Dim bread As String
        Dim oil As String
        Dim rama As String
        Dim eggs As String
        Dim oats As String
        Dim maize As String
        Dim rice As String
        Dim flour As String
        Dim sugar As String
        'prices
        Dim pbread As Double = 8.99
        Dim poil As Double = 14.99
        Dim prama As Double = 19.99
        Dim peggs As Double = 34.99
        Dim poats As Double = 27.99
        Dim pmaize As Double = 17.99
        Dim price As Double = 36.99
        Dim pflour As Double = 59.99
        Dim psugar As Double = 24.99

        If chkBread.Checked = True Then
            bread = "Bread: -------------"
            total += pbread
            message = message &
            bread & pbread.ToString("C2") &
            ControlChars.NewLine
        Else
            bread = ""
        End If
        If chkOil.Checked = True Then
            oil = "Oil: -------------"
            total += poil
            message = message &
            oil & poil.ToString("C2") &
            ControlChars.NewLine
        Else
            oil = ""
        End If
        If chkRama.Checked = True Then
            rama = "Rama: -------------"
            total += prama
            message = message &
            rama & prama.ToString("C2") &
            ControlChars.NewLine
        Else
            rama = ""
        End If
        If chkEggs.Checked = True Then
            eggs = "Eggs: -------------"
            total += peggs
            message = message &
            eggs & peggs.ToString("C2") &
            ControlChars.NewLine
        Else
            eggs = ""
        End If
        If chkOats.Checked = True Then
            oats = "Oats: -------------"
            total += poats
            message = message &
            oats & poats.ToString("C2") &
            ControlChars.NewLine
        Else
            oats = ""
        End If
        If chkMaize.Checked = True Then
            maize = "Maize: -------------"
            total += pmaize
            message = message &
            maize & pmaize.ToString("C2") &
            ControlChars.NewLine
        Else
            maize = ""
        End If
        If chkRice.Checked = True Then
            rice = "Rice: -------------"
            total += price
            message = message &
            rice & price.ToString("C2") &
            ControlChars.NewLine
        Else
            rice = ""
        End If
        If chkFlour.Checked = True Then
            flour = "Flour: -------------"
            total += pflour
            message = message &
            flour & pflour.ToString("C2") &
            ControlChars.NewLine
        Else
            flour = ""
        End If
        If chkSugar.Checked = True Then
            sugar = "Sugar: -------------"
            total += psugar
            message = message &
            sugar & psugar.ToString("C2") &
            ControlChars.NewLine
        Else
            sugar = ""
        End If

        If boolIsUser = True Then
            total = total - (total * 0.05)
            Extra = "As our loyal customer you get 5% discount. "
        Else
            total = total
        End If


        lblDisplay.Text = "//--------------------Receipt----------------------------//" &
                          message &
                          ControlChars.NewLine &
                          Extra &
                          "Your total is :-------------" & total.ToString("C2") &
                          ControlChars.NewLine &
                          "//-------Thank you------------//"

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        chkBread.Checked = False
        chkOil.Checked = False
        chkRama.Checked = False
        chkEggs.Checked = False
        chkOats.Checked = False
        chkMaize.Checked = False
        chkRice.Checked = False
        chkFlour.Checked = False
        chkSugar.Checked = False
        lblDisplay.Text = ""
        chkBread.Focus()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        closeProgram.CloseApp()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        chkBread.Checked = False
        chkOil.Checked = False
        chkRama.Checked = False
        chkEggs.Checked = False
        chkOats.Checked = False
        chkMaize.Checked = False
        chkRice.Checked = False
        chkFlour.Checked = False
        chkSugar.Checked = False
        lblDisplay.Text = ""
        chkBread.Focus()
        boolIsUser = False
        MainMenu.Show()
        Me.Visible = False
    End Sub
End Class
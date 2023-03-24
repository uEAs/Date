Public Class frmBundesjugendspiele
    Dim Lauf, Sprung, Stoß, Gesamt As Integer

    Private Sub BtnBerechne_Click(sender As Object, e As EventArgs) Handles btnBerechne.Click
        Lauf = txtLauf.Text
        Sprung = txtSprung.Text
        Stoß = txtStoß.Text

        Gesamt = Lauf + Sprung + Stoß

        lblGesamt.Text = Gesamt

        If Gesamt < 1400 Then
            lblUrkunde.Text = "Teilnehmer"
        ElseIf Gesamt < 1850 Then
            lblUrkunde.Text = "Sieger"
        Else lblUrkunde.Text = "Ehrenurkunde"
        End If

    End Sub

    Private Sub BtnLösche_Click(sender As Object, e As EventArgs) Handles btnLösche.Click
        txtLauf.Text = Nothing
        txtSprung.Text = Nothing
        txtStoß.Text = Nothing
        lblGesamt.Text = Nothing
        lblUrkunde.Text = Nothing
        txtLauf.Focus()
    End Sub

    Private Sub BtnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        End
    End Sub
End Class

Public Class frmGeschwindigkeitsgrad
    Dim s As Single 'Zeit in Sekunden
    Dim h As Single 'Zeit in stunden
    Dim v As Integer 'Geschwindigkeit in km/h
    Dim n As Integer 'Gesamtzahl der Fahrzeuge
    Dim x As Integer 'Anzahl der zu schnellen Fahrzeuge
    Dim p As Single 'Anteil der Raser in Prozent

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        txtZeit.Text = Nothing
        lblGeschwindigkeit.Text = Nothing
        txtZeit.Focus()

    End Sub

    Private Sub FrmGeschwindigkeitsgrad_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnEnde_Click(sender As Object, e As EventArgs) Handles btnEnde.Click
        MsgBox(p & "% der Fahrzeuge waren zu schnell unterwegs.", MsgBoxStyle.Information, "Auswertung")
        End
    End Sub

    Private Sub BtnBerechnen_Click(sender As Object, e As EventArgs) Handles btnBerechnen.Click
        'Eingabe
        s = txtZeit.Text
        'Verarbeitung
        h = s / 3600
        v = Math.Round(0.1 / h, 0)
        n = n + 1
        If v > 30 Then
            x = x + 1
        End If
        p = Math.Round(x / n * 100, 0)
        'Ausgabe
        lblGeschwindigkeit.Text = v
        lblGesamtzahl.Text = n
        lblZuSchnell.Text = x




    End Sub
End Class

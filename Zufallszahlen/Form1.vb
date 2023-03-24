Public Class frmZufallszahlen

    Dim OGrenze, UGrenze, Zufallszahl As Integer
    Private Sub LblZufallszahl_Click(sender As Object, e As EventArgs) Handles lblZufallszahl.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Zufallszahl As Single
        Zufallszahl = Int(Rnd() * (OGrenze - UGrenze + 1) + UGrenze)     'Diese funktion generiert eine Zufallszahl von zwischen der oberen und unteren Grenze.
        lblZufallszahl.Text = Zufallszahl
    End Sub

    Private Sub FrmZufallszahlen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()      'Dieser Befehl started den Zufallsgenerator.
        lblUGrenze.Text = hsbUGrenze.Value
        lblOGrenze.Text = hsbOGrenze.Value
    End Sub

    Private Sub LblUGrenze_Click(sender As Object, e As EventArgs) Handles lblUGrenze.Click

    End Sub

    Private Sub HsbUGrenze_Scroll(sender As Object, e As ScrollEventArgs) Handles hsbUGrenze.Scroll
        UGrenze = hsbUGrenze.Value
        lblUGrenze.Text = UGrenze
    End Sub

    Private Sub HsbOGrenze_Scroll(sender As Object, e As ScrollEventArgs) Handles hsbOGrenze.Scroll
        OGrenze = hsbOGrenze.Value
        lblOGrenze.Text = OGrenze
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class

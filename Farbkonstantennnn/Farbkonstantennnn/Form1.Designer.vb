<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblFarbe = New System.Windows.Forms.Label()
        Me.gprHintergrundfarbe = New System.Windows.Forms.GroupBox()
        Me.btnSchwarz = New System.Windows.Forms.Button()
        Me.btnBlue = New System.Windows.Forms.Button()
        Me.btnRot = New System.Windows.Forms.Button()
        Me.btnGreen = New System.Windows.Forms.Button()
        Me.btnGelb = New System.Windows.Forms.Button()
        Me.btnMagenta = New System.Windows.Forms.Button()
        Me.btnCyan = New System.Windows.Forms.Button()
        Me.btnWeiß = New System.Windows.Forms.Button()
        Me.grpVordergrundfarbe = New System.Windows.Forms.GroupBox()
        Me.btnBlack = New System.Windows.Forms.Button()
        Me.btnBlau = New System.Windows.Forms.Button()
        Me.btnRed = New System.Windows.Forms.Button()
        Me.btnGreeen = New System.Windows.Forms.Button()
        Me.btnYellow = New System.Windows.Forms.Button()
        Me.btnMagentaa = New System.Windows.Forms.Button()
        Me.btnCyann = New System.Windows.Forms.Button()
        Me.btnWhite = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.gprHintergrundfarbe.SuspendLayout()
        Me.grpVordergrundfarbe.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFarbe
        '
        Me.lblFarbe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFarbe.Location = New System.Drawing.Point(22, 30)
        Me.lblFarbe.Name = "lblFarbe"
        Me.lblFarbe.Size = New System.Drawing.Size(374, 27)
        Me.lblFarbe.TabIndex = 13
        Me.lblFarbe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gprHintergrundfarbe
        '
        Me.gprHintergrundfarbe.Controls.Add(Me.btnSchwarz)
        Me.gprHintergrundfarbe.Controls.Add(Me.btnBlue)
        Me.gprHintergrundfarbe.Controls.Add(Me.btnRot)
        Me.gprHintergrundfarbe.Controls.Add(Me.btnGreen)
        Me.gprHintergrundfarbe.Controls.Add(Me.btnGelb)
        Me.gprHintergrundfarbe.Controls.Add(Me.btnMagenta)
        Me.gprHintergrundfarbe.Controls.Add(Me.btnCyan)
        Me.gprHintergrundfarbe.Controls.Add(Me.btnWeiß)
        Me.gprHintergrundfarbe.Location = New System.Drawing.Point(12, 74)
        Me.gprHintergrundfarbe.Name = "gprHintergrundfarbe"
        Me.gprHintergrundfarbe.Size = New System.Drawing.Size(200, 179)
        Me.gprHintergrundfarbe.TabIndex = 24
        Me.gprHintergrundfarbe.TabStop = False
        Me.gprHintergrundfarbe.Text = "Hintergrundfarbe"
        '
        'btnSchwarz
        '
        Me.btnSchwarz.Location = New System.Drawing.Point(91, 145)
        Me.btnSchwarz.Name = "btnSchwarz"
        Me.btnSchwarz.Size = New System.Drawing.Size(75, 23)
        Me.btnSchwarz.TabIndex = 29
        Me.btnSchwarz.Text = "schwarz"
        Me.btnSchwarz.UseVisualStyleBackColor = True
        '
        'btnBlue
        '
        Me.btnBlue.Location = New System.Drawing.Point(10, 145)
        Me.btnBlue.Name = "btnBlue"
        Me.btnBlue.Size = New System.Drawing.Size(75, 23)
        Me.btnBlue.TabIndex = 28
        Me.btnBlue.Text = "blau"
        Me.btnBlue.UseVisualStyleBackColor = True
        '
        'btnRot
        '
        Me.btnRot.Location = New System.Drawing.Point(91, 102)
        Me.btnRot.Name = "btnRot"
        Me.btnRot.Size = New System.Drawing.Size(75, 23)
        Me.btnRot.TabIndex = 27
        Me.btnRot.Text = "rot"
        Me.btnRot.UseVisualStyleBackColor = True
        '
        'btnGreen
        '
        Me.btnGreen.Location = New System.Drawing.Point(91, 61)
        Me.btnGreen.Name = "btnGreen"
        Me.btnGreen.Size = New System.Drawing.Size(75, 23)
        Me.btnGreen.TabIndex = 26
        Me.btnGreen.Text = "grün"
        Me.btnGreen.UseVisualStyleBackColor = True
        '
        'btnGelb
        '
        Me.btnGelb.Location = New System.Drawing.Point(91, 19)
        Me.btnGelb.Name = "btnGelb"
        Me.btnGelb.Size = New System.Drawing.Size(75, 23)
        Me.btnGelb.TabIndex = 25
        Me.btnGelb.Text = "gelb"
        Me.btnGelb.UseVisualStyleBackColor = True
        '
        'btnMagenta
        '
        Me.btnMagenta.Location = New System.Drawing.Point(10, 102)
        Me.btnMagenta.Name = "btnMagenta"
        Me.btnMagenta.Size = New System.Drawing.Size(75, 23)
        Me.btnMagenta.TabIndex = 24
        Me.btnMagenta.Text = "magenta"
        Me.btnMagenta.UseVisualStyleBackColor = True
        '
        'btnCyan
        '
        Me.btnCyan.Location = New System.Drawing.Point(10, 61)
        Me.btnCyan.Name = "btnCyan"
        Me.btnCyan.Size = New System.Drawing.Size(75, 23)
        Me.btnCyan.TabIndex = 23
        Me.btnCyan.Text = "cyan"
        Me.btnCyan.UseVisualStyleBackColor = True
        '
        'btnWeiß
        '
        Me.btnWeiß.Location = New System.Drawing.Point(10, 19)
        Me.btnWeiß.Name = "btnWeiß"
        Me.btnWeiß.Size = New System.Drawing.Size(75, 23)
        Me.btnWeiß.TabIndex = 22
        Me.btnWeiß.Text = "weiß"
        Me.btnWeiß.UseVisualStyleBackColor = True
        '
        'grpVordergrundfarbe
        '
        Me.grpVordergrundfarbe.Controls.Add(Me.btnBlack)
        Me.grpVordergrundfarbe.Controls.Add(Me.btnBlau)
        Me.grpVordergrundfarbe.Controls.Add(Me.btnRed)
        Me.grpVordergrundfarbe.Controls.Add(Me.btnGreeen)
        Me.grpVordergrundfarbe.Controls.Add(Me.btnYellow)
        Me.grpVordergrundfarbe.Controls.Add(Me.btnMagentaa)
        Me.grpVordergrundfarbe.Controls.Add(Me.btnCyann)
        Me.grpVordergrundfarbe.Controls.Add(Me.btnWhite)
        Me.grpVordergrundfarbe.Location = New System.Drawing.Point(218, 74)
        Me.grpVordergrundfarbe.Name = "grpVordergrundfarbe"
        Me.grpVordergrundfarbe.Size = New System.Drawing.Size(200, 179)
        Me.grpVordergrundfarbe.TabIndex = 25
        Me.grpVordergrundfarbe.TabStop = False
        Me.grpVordergrundfarbe.Text = "Vordergrundfarbe"
        '
        'btnBlack
        '
        Me.btnBlack.Location = New System.Drawing.Point(103, 145)
        Me.btnBlack.Name = "btnBlack"
        Me.btnBlack.Size = New System.Drawing.Size(75, 23)
        Me.btnBlack.TabIndex = 31
        Me.btnBlack.Text = "schwarz"
        Me.btnBlack.UseVisualStyleBackColor = True
        '
        'btnBlau
        '
        Me.btnBlau.Location = New System.Drawing.Point(22, 145)
        Me.btnBlau.Name = "btnBlau"
        Me.btnBlau.Size = New System.Drawing.Size(75, 23)
        Me.btnBlau.TabIndex = 30
        Me.btnBlau.Text = "blau"
        Me.btnBlau.UseVisualStyleBackColor = True
        '
        'btnRed
        '
        Me.btnRed.Location = New System.Drawing.Point(103, 102)
        Me.btnRed.Name = "btnRed"
        Me.btnRed.Size = New System.Drawing.Size(75, 23)
        Me.btnRed.TabIndex = 29
        Me.btnRed.Text = "rot"
        Me.btnRed.UseVisualStyleBackColor = True
        '
        'btnGreeen
        '
        Me.btnGreeen.Location = New System.Drawing.Point(103, 61)
        Me.btnGreeen.Name = "btnGreeen"
        Me.btnGreeen.Size = New System.Drawing.Size(75, 23)
        Me.btnGreeen.TabIndex = 28
        Me.btnGreeen.Text = "grün"
        Me.btnGreeen.UseVisualStyleBackColor = True
        '
        'btnYellow
        '
        Me.btnYellow.Location = New System.Drawing.Point(103, 19)
        Me.btnYellow.Name = "btnYellow"
        Me.btnYellow.Size = New System.Drawing.Size(75, 23)
        Me.btnYellow.TabIndex = 27
        Me.btnYellow.Text = "gelb"
        Me.btnYellow.UseVisualStyleBackColor = True
        '
        'btnMagentaa
        '
        Me.btnMagentaa.Location = New System.Drawing.Point(22, 102)
        Me.btnMagentaa.Name = "btnMagentaa"
        Me.btnMagentaa.Size = New System.Drawing.Size(75, 23)
        Me.btnMagentaa.TabIndex = 26
        Me.btnMagentaa.Text = "magenta"
        Me.btnMagentaa.UseVisualStyleBackColor = True
        '
        'btnCyann
        '
        Me.btnCyann.Location = New System.Drawing.Point(22, 61)
        Me.btnCyann.Name = "btnCyann"
        Me.btnCyann.Size = New System.Drawing.Size(75, 23)
        Me.btnCyann.TabIndex = 25
        Me.btnCyann.Text = "cyan"
        Me.btnCyann.UseVisualStyleBackColor = True
        '
        'btnWhite
        '
        Me.btnWhite.Location = New System.Drawing.Point(22, 19)
        Me.btnWhite.Name = "btnWhite"
        Me.btnWhite.Size = New System.Drawing.Size(75, 23)
        Me.btnWhite.TabIndex = 24
        Me.btnWhite.Text = "weiß"
        Me.btnWhite.UseVisualStyleBackColor = True
        '
        'btnEnd
        '
        Me.btnEnd.Location = New System.Drawing.Point(178, 264)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(75, 23)
        Me.btnEnd.TabIndex = 26
        Me.btnEnd.Text = "Ende"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 299)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.grpVordergrundfarbe)
        Me.Controls.Add(Me.gprHintergrundfarbe)
        Me.Controls.Add(Me.lblFarbe)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.gprHintergrundfarbe.ResumeLayout(False)
        Me.grpVordergrundfarbe.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents lblFarbe As Label
    Friend WithEvents gprHintergrundfarbe As GroupBox
    Private WithEvents btnSchwarz As Button
    Private WithEvents btnBlue As Button
    Private WithEvents btnRot As Button
    Private WithEvents btnGreen As Button
    Private WithEvents btnGelb As Button
    Private WithEvents btnMagenta As Button
    Private WithEvents btnCyan As Button
    Private WithEvents btnWeiß As Button
    Friend WithEvents grpVordergrundfarbe As GroupBox
    Private WithEvents btnBlack As Button
    Private WithEvents btnBlau As Button
    Private WithEvents btnRed As Button
    Private WithEvents btnGreeen As Button
    Private WithEvents btnYellow As Button
    Private WithEvents btnMagentaa As Button
    Private WithEvents btnCyann As Button
    Private WithEvents btnWhite As Button
    Friend WithEvents btnEnd As Button
End Class

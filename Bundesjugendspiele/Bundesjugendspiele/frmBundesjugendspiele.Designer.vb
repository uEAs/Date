<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBundesjugendspiele
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
        Me.btnBerechne = New System.Windows.Forms.Button()
        Me.btnLösche = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtLauf = New System.Windows.Forms.TextBox()
        Me.txtSprung = New System.Windows.Forms.TextBox()
        Me.txtStoß = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblUrkunde = New System.Windows.Forms.Label()
        Me.lblGesamt = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBerechne
        '
        Me.btnBerechne.Location = New System.Drawing.Point(444, 257)
        Me.btnBerechne.Name = "btnBerechne"
        Me.btnBerechne.Size = New System.Drawing.Size(75, 23)
        Me.btnBerechne.TabIndex = 0
        Me.btnBerechne.Text = "Berechne"
        Me.btnBerechne.UseVisualStyleBackColor = True
        '
        'btnLösche
        '
        Me.btnLösche.Location = New System.Drawing.Point(444, 316)
        Me.btnLösche.Name = "btnLösche"
        Me.btnLösche.Size = New System.Drawing.Size(75, 23)
        Me.btnLösche.TabIndex = 1
        Me.btnLösche.Text = "Lösche"
        Me.btnLösche.UseVisualStyleBackColor = True
        '
        'btnEnd
        '
        Me.btnEnd.Location = New System.Drawing.Point(444, 373)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(75, 23)
        Me.btnEnd.TabIndex = 2
        Me.btnEnd.Text = "Ende"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Bundesjugendspiele.My.Resources.Resources.Bundesjugendspiele
        Me.PictureBox1.Location = New System.Drawing.Point(387, 65)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(193, 148)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'txtLauf
        '
        Me.txtLauf.Location = New System.Drawing.Point(124, 24)
        Me.txtLauf.Name = "txtLauf"
        Me.txtLauf.Size = New System.Drawing.Size(100, 20)
        Me.txtLauf.TabIndex = 4
        Me.txtLauf.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSprung
        '
        Me.txtSprung.Location = New System.Drawing.Point(124, 74)
        Me.txtSprung.Name = "txtSprung"
        Me.txtSprung.Size = New System.Drawing.Size(100, 20)
        Me.txtSprung.TabIndex = 5
        Me.txtSprung.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtStoß
        '
        Me.txtStoß.Location = New System.Drawing.Point(124, 125)
        Me.txtStoß.Name = "txtStoß"
        Me.txtStoß.Size = New System.Drawing.Size(100, 20)
        Me.txtStoß.TabIndex = 6
        Me.txtStoß.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lblUrkunde)
        Me.GroupBox1.Controls.Add(Me.lblGesamt)
        Me.GroupBox1.Location = New System.Drawing.Point(34, 280)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(272, 116)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ergebnis"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(30, 70)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Urkunde"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Gesamt"
        '
        'lblUrkunde
        '
        Me.lblUrkunde.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblUrkunde.Location = New System.Drawing.Point(146, 70)
        Me.lblUrkunde.Name = "lblUrkunde"
        Me.lblUrkunde.Size = New System.Drawing.Size(100, 23)
        Me.lblUrkunde.TabIndex = 1
        Me.lblUrkunde.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblGesamt
        '
        Me.lblGesamt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGesamt.Location = New System.Drawing.Point(146, 25)
        Me.lblGesamt.Name = "lblGesamt"
        Me.lblGesamt.Size = New System.Drawing.Size(100, 23)
        Me.lblGesamt.TabIndex = 0
        Me.lblGesamt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtLauf)
        Me.GroupBox2.Controls.Add(Me.txtSprung)
        Me.GroupBox2.Controls.Add(Me.txtStoß)
        Me.GroupBox2.Location = New System.Drawing.Point(34, 41)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(272, 172)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Punkteeingabe"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Stoß"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Sprung"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Lauf"
        '
        'frmBundesjugendspiele
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(660, 450)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnLösche)
        Me.Controls.Add(Me.btnBerechne)
        Me.Name = "frmBundesjugendspiele"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnBerechne As Button
    Friend WithEvents btnLösche As Button
    Friend WithEvents btnEnd As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtLauf As TextBox
    Friend WithEvents txtSprung As TextBox
    Friend WithEvents txtStoß As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblUrkunde As Label
    Friend WithEvents lblGesamt As Label
End Class

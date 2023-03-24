<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmZufallszahlen
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
        Me.lblZufallszahl = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.hsbUGrenze = New System.Windows.Forms.HScrollBar()
        Me.hsbOGrenze = New System.Windows.Forms.HScrollBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblUGrenze = New System.Windows.Forms.Label()
        Me.lblOGrenze = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblZufallszahl
        '
        Me.lblZufallszahl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblZufallszahl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZufallszahl.Location = New System.Drawing.Point(405, 177)
        Me.lblZufallszahl.Name = "lblZufallszahl"
        Me.lblZufallszahl.Size = New System.Drawing.Size(117, 23)
        Me.lblZufallszahl.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(423, 265)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Zufallszahl"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'hsbUGrenze
        '
        Me.hsbUGrenze.Location = New System.Drawing.Point(405, 37)
        Me.hsbUGrenze.Maximum = 109
        Me.hsbUGrenze.Name = "hsbUGrenze"
        Me.hsbUGrenze.Size = New System.Drawing.Size(105, 17)
        Me.hsbUGrenze.TabIndex = 2
        '
        'hsbOGrenze
        '
        Me.hsbOGrenze.Location = New System.Drawing.Point(405, 101)
        Me.hsbOGrenze.Maximum = 109
        Me.hsbOGrenze.Name = "hsbOGrenze"
        Me.hsbOGrenze.Size = New System.Drawing.Size(105, 17)
        Me.hsbOGrenze.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(136, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "U Grenze"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(140, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "O Grenze"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(140, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Zufallszahl"
        '
        'lblUGrenze
        '
        Me.lblUGrenze.AutoSize = True
        Me.lblUGrenze.Location = New System.Drawing.Point(736, 37)
        Me.lblUGrenze.Name = "lblUGrenze"
        Me.lblUGrenze.Size = New System.Drawing.Size(45, 13)
        Me.lblUGrenze.TabIndex = 7
        Me.lblUGrenze.Text = "Label1"
        Me.lblUGrenze.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblOGrenze
        '
        Me.lblOGrenze.AutoSize = True
        Me.lblOGrenze.Location = New System.Drawing.Point(736, 101)
        Me.lblOGrenze.Name = "lblOGrenze"
        Me.lblOGrenze.Size = New System.Drawing.Size(45, 13)
        Me.lblOGrenze.TabIndex = 8
        Me.lblOGrenze.Text = "Label5"
        Me.lblOGrenze.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmZufallszahlen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 333)
        Me.Controls.Add(Me.lblOGrenze)
        Me.Controls.Add(Me.lblUGrenze)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.hsbOGrenze)
        Me.Controls.Add(Me.hsbUGrenze)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblZufallszahl)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmZufallszahlen"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblZufallszahl As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents hsbUGrenze As HScrollBar
    Friend WithEvents hsbOGrenze As HScrollBar
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblUGrenze As Label
    Friend WithEvents lblOGrenze As Label
End Class

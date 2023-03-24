<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGeschwindigkeitsgrad
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
        Me.lblGesamtzahl = New System.Windows.Forms.Label()
        Me.lblZuSchnell = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblGeschwindigkeit = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtZeit = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnNew = New System.Windows.Forms.Button()
        Me.btnBerechnen = New System.Windows.Forms.Button()
        Me.btnEnde = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblGesamtzahl
        '
        Me.lblGesamtzahl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGesamtzahl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGesamtzahl.Location = New System.Drawing.Point(298, 195)
        Me.lblGesamtzahl.Name = "lblGesamtzahl"
        Me.lblGesamtzahl.Size = New System.Drawing.Size(100, 23)
        Me.lblGesamtzahl.TabIndex = 0
        '
        'lblZuSchnell
        '
        Me.lblZuSchnell.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblZuSchnell.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZuSchnell.Location = New System.Drawing.Point(298, 283)
        Me.lblZuSchnell.Name = "lblZuSchnell"
        Me.lblZuSchnell.Size = New System.Drawing.Size(100, 23)
        Me.lblZuSchnell.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(53, 293)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(200, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Anzahl der zu schnell gefahrenen:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(53, 205)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(161, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Gesamtzahl der Fahrzeuge:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(53, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(151, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Geschwindigkeit in km/h:"
        '
        'lblGeschwindigkeit
        '
        Me.lblGeschwindigkeit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGeschwindigkeit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGeschwindigkeit.Location = New System.Drawing.Point(298, 118)
        Me.lblGeschwindigkeit.Name = "lblGeschwindigkeit"
        Me.lblGeschwindigkeit.Size = New System.Drawing.Size(100, 23)
        Me.lblGeschwindigkeit.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(53, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Zeit in s:"
        '
        'txtZeit
        '
        Me.txtZeit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZeit.Location = New System.Drawing.Point(298, 43)
        Me.txtZeit.Name = "txtZeit"
        Me.txtZeit.Size = New System.Drawing.Size(100, 20)
        Me.txtZeit.TabIndex = 7
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(483, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(197, 306)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'BtnNew
        '
        Me.BtnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNew.Location = New System.Drawing.Point(56, 363)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(108, 23)
        Me.BtnNew.TabIndex = 9
        Me.BtnNew.Text = "neues Fahrzeug"
        Me.BtnNew.UseVisualStyleBackColor = True
        '
        'btnBerechnen
        '
        Me.btnBerechnen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBerechnen.Location = New System.Drawing.Point(312, 363)
        Me.btnBerechnen.Name = "btnBerechnen"
        Me.btnBerechnen.Size = New System.Drawing.Size(108, 23)
        Me.btnBerechnen.TabIndex = 10
        Me.btnBerechnen.Text = "Berechnen"
        Me.btnBerechnen.UseVisualStyleBackColor = True
        '
        'btnEnde
        '
        Me.btnEnde.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnde.Location = New System.Drawing.Point(578, 363)
        Me.btnEnde.Name = "btnEnde"
        Me.btnEnde.Size = New System.Drawing.Size(102, 23)
        Me.btnEnde.TabIndex = 11
        Me.btnEnde.Text = "Ende"
        Me.btnEnde.UseVisualStyleBackColor = True
        '
        'frmGeschwindigkeitsgrad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 398)
        Me.Controls.Add(Me.btnEnde)
        Me.Controls.Add(Me.btnBerechnen)
        Me.Controls.Add(Me.BtnNew)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtZeit)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblGeschwindigkeit)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblZuSchnell)
        Me.Controls.Add(Me.lblGesamtzahl)
        Me.Name = "frmGeschwindigkeitsgrad"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblGesamtzahl As Label
    Friend WithEvents lblZuSchnell As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblGeschwindigkeit As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtZeit As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnNew As Button
    Friend WithEvents btnBerechnen As Button
    Friend WithEvents btnEnde As Button
End Class

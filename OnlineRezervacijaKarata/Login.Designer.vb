<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxKorisnickoIme = New System.Windows.Forms.TextBox()
        Me.TextBoxLozinka = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonPrijava = New System.Windows.Forms.Button()
        Me.LabelNastaviKaoAdmin = New System.Windows.Forms.Label()
        Me.ButtonIzlaz = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(169, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(282, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ONLINE REZERVACIJA KARATA"
        '
        'TextBoxKorisnickoIme
        '
        Me.TextBoxKorisnickoIme.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxKorisnickoIme.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TextBoxKorisnickoIme.Location = New System.Drawing.Point(266, 107)
        Me.TextBoxKorisnickoIme.Name = "TextBoxKorisnickoIme"
        Me.TextBoxKorisnickoIme.Size = New System.Drawing.Size(200, 31)
        Me.TextBoxKorisnickoIme.TabIndex = 5
        '
        'TextBoxLozinka
        '
        Me.TextBoxLozinka.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxLozinka.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TextBoxLozinka.Location = New System.Drawing.Point(266, 173)
        Me.TextBoxLozinka.Name = "TextBoxLozinka"
        Me.TextBoxLozinka.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxLozinka.Size = New System.Drawing.Size(200, 31)
        Me.TextBoxLozinka.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(261, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 25)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Korisničko ime:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Location = New System.Drawing.Point(261, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 25)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Lozinka:"
        '
        'ButtonPrijava
        '
        Me.ButtonPrijava.BackColor = System.Drawing.Color.MidnightBlue
        Me.ButtonPrijava.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonPrijava.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonPrijava.FlatAppearance.BorderSize = 0
        Me.ButtonPrijava.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.ButtonPrijava.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.ButtonPrijava.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonPrijava.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPrijava.ForeColor = System.Drawing.Color.White
        Me.ButtonPrijava.Location = New System.Drawing.Point(266, 221)
        Me.ButtonPrijava.Name = "ButtonPrijava"
        Me.ButtonPrijava.Size = New System.Drawing.Size(215, 34)
        Me.ButtonPrijava.TabIndex = 9
        Me.ButtonPrijava.Text = "Prijavite se"
        Me.ButtonPrijava.UseVisualStyleBackColor = False
        '
        'LabelNastaviKaoAdmin
        '
        Me.LabelNastaviKaoAdmin.AutoSize = True
        Me.LabelNastaviKaoAdmin.BackColor = System.Drawing.Color.Transparent
        Me.LabelNastaviKaoAdmin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelNastaviKaoAdmin.Font = New System.Drawing.Font("Century Gothic", 14.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNastaviKaoAdmin.ForeColor = System.Drawing.Color.MidnightBlue
        Me.LabelNastaviKaoAdmin.Location = New System.Drawing.Point(274, 270)
        Me.LabelNastaviKaoAdmin.Name = "LabelNastaviKaoAdmin"
        Me.LabelNastaviKaoAdmin.Size = New System.Drawing.Size(207, 22)
        Me.LabelNastaviKaoAdmin.TabIndex = 10
        Me.LabelNastaviKaoAdmin.Text = "Nastavite Kao Admin"
        '
        'ButtonIzlaz
        '
        Me.ButtonIzlaz.BackColor = System.Drawing.Color.Transparent
        Me.ButtonIzlaz.CheckedState.Parent = Me.ButtonIzlaz
        Me.ButtonIzlaz.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonIzlaz.CustomImages.Parent = Me.ButtonIzlaz
        Me.ButtonIzlaz.FillColor = System.Drawing.Color.Transparent
        Me.ButtonIzlaz.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonIzlaz.ForeColor = System.Drawing.Color.Red
        Me.ButtonIzlaz.HoverState.Parent = Me.ButtonIzlaz
        Me.ButtonIzlaz.Location = New System.Drawing.Point(483, 3)
        Me.ButtonIzlaz.Name = "ButtonIzlaz"
        Me.ButtonIzlaz.ShadowDecoration.Parent = Me.ButtonIzlaz
        Me.ButtonIzlaz.Size = New System.Drawing.Size(33, 29)
        Me.ButtonIzlaz.TabIndex = 11
        Me.ButtonIzlaz.Text = "X"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(519, 313)
        Me.Controls.Add(Me.ButtonIzlaz)
        Me.Controls.Add(Me.LabelNastaviKaoAdmin)
        Me.Controls.Add(Me.ButtonPrijava)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxLozinka)
        Me.Controls.Add(Me.TextBoxKorisnickoIme)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Prijava"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxKorisnickoIme As TextBox
    Friend WithEvents TextBoxLozinka As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonPrijava As Button
    Friend WithEvents LabelNastaviKaoAdmin As Label
    Friend WithEvents ButtonIzlaz As Guna.UI2.WinForms.Guna2Button
End Class

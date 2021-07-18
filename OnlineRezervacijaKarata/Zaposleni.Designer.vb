<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Zaposleni
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Zaposleni))
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.LabelOdjava = New System.Windows.Forms.Label()
        Me.LabelPutnici = New System.Windows.Forms.Label()
        Me.DataGridViewZaposleni = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.ButtonNoviUnos = New System.Windows.Forms.Button()
        Me.ButtonObrisi = New System.Windows.Forms.Button()
        Me.ButtonIzmjeni = New System.Windows.Forms.Button()
        Me.ButtonDodajZaposlenog = New System.Windows.Forms.Button()
        Me.TextBoxJMBG = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxPrezimeZaposlenog = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBoxImeZaposlenog = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxBrojTel = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxLozinka = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PictureBoxRezervacija = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxKorisnickoIme = New Guna.UI2.WinForms.Guna2TextBox()
        CType(Me.DataGridViewZaposleni, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxRezervacija, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Crimson
        Me.Panel4.Location = New System.Drawing.Point(3, 101)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(175, 8)
        Me.Panel4.TabIndex = 20
        '
        'LabelOdjava
        '
        Me.LabelOdjava.AutoSize = True
        Me.LabelOdjava.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelOdjava.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelOdjava.ForeColor = System.Drawing.Color.Crimson
        Me.LabelOdjava.Location = New System.Drawing.Point(711, 75)
        Me.LabelOdjava.Name = "LabelOdjava"
        Me.LabelOdjava.Size = New System.Drawing.Size(89, 25)
        Me.LabelOdjava.TabIndex = 22
        Me.LabelOdjava.Text = "Odjava"
        '
        'LabelPutnici
        '
        Me.LabelPutnici.AutoSize = True
        Me.LabelPutnici.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelPutnici.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPutnici.ForeColor = System.Drawing.Color.Crimson
        Me.LabelPutnici.Location = New System.Drawing.Point(69, 75)
        Me.LabelPutnici.Name = "LabelPutnici"
        Me.LabelPutnici.Size = New System.Drawing.Size(109, 25)
        Me.LabelPutnici.TabIndex = 19
        Me.LabelPutnici.Text = "Zaposleni"
        '
        'DataGridViewZaposleni
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DataGridViewZaposleni.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewZaposleni.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewZaposleni.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewZaposleni.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridViewZaposleni.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridViewZaposleni.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Crimson
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewZaposleni.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewZaposleni.ColumnHeadersHeight = 26
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewZaposleni.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewZaposleni.EnableHeadersVisualStyles = False
        Me.DataGridViewZaposleni.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridViewZaposleni.Location = New System.Drawing.Point(23, 355)
        Me.DataGridViewZaposleni.Name = "DataGridViewZaposleni"
        Me.DataGridViewZaposleni.RowHeadersVisible = False
        Me.DataGridViewZaposleni.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewZaposleni.Size = New System.Drawing.Size(765, 169)
        Me.DataGridViewZaposleni.TabIndex = 58
        Me.DataGridViewZaposleni.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.DataGridViewZaposleni.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DataGridViewZaposleni.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DataGridViewZaposleni.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DataGridViewZaposleni.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DataGridViewZaposleni.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DataGridViewZaposleni.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DataGridViewZaposleni.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridViewZaposleni.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Crimson
        Me.DataGridViewZaposleni.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridViewZaposleni.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewZaposleni.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DataGridViewZaposleni.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DataGridViewZaposleni.ThemeStyle.HeaderStyle.Height = 26
        Me.DataGridViewZaposleni.ThemeStyle.ReadOnly = False
        Me.DataGridViewZaposleni.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DataGridViewZaposleni.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridViewZaposleni.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DataGridViewZaposleni.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DataGridViewZaposleni.ThemeStyle.RowsStyle.Height = 22
        Me.DataGridViewZaposleni.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridViewZaposleni.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'ButtonNoviUnos
        '
        Me.ButtonNoviUnos.BackColor = System.Drawing.Color.MidnightBlue
        Me.ButtonNoviUnos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonNoviUnos.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonNoviUnos.FlatAppearance.BorderSize = 0
        Me.ButtonNoviUnos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.ButtonNoviUnos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.ButtonNoviUnos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonNoviUnos.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNoviUnos.ForeColor = System.Drawing.Color.White
        Me.ButtonNoviUnos.Location = New System.Drawing.Point(559, 278)
        Me.ButtonNoviUnos.Name = "ButtonNoviUnos"
        Me.ButtonNoviUnos.Size = New System.Drawing.Size(122, 34)
        Me.ButtonNoviUnos.TabIndex = 57
        Me.ButtonNoviUnos.Text = "&Novi unos"
        Me.ButtonNoviUnos.UseVisualStyleBackColor = False
        '
        'ButtonObrisi
        '
        Me.ButtonObrisi.BackColor = System.Drawing.Color.Red
        Me.ButtonObrisi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonObrisi.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonObrisi.FlatAppearance.BorderSize = 0
        Me.ButtonObrisi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.ButtonObrisi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.ButtonObrisi.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonObrisi.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonObrisi.ForeColor = System.Drawing.Color.White
        Me.ButtonObrisi.Location = New System.Drawing.Point(421, 278)
        Me.ButtonObrisi.Name = "ButtonObrisi"
        Me.ButtonObrisi.Size = New System.Drawing.Size(122, 34)
        Me.ButtonObrisi.TabIndex = 56
        Me.ButtonObrisi.Text = "&Obriši "
        Me.ButtonObrisi.UseVisualStyleBackColor = False
        '
        'ButtonIzmjeni
        '
        Me.ButtonIzmjeni.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonIzmjeni.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonIzmjeni.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonIzmjeni.FlatAppearance.BorderSize = 0
        Me.ButtonIzmjeni.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.ButtonIzmjeni.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.ButtonIzmjeni.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonIzmjeni.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonIzmjeni.ForeColor = System.Drawing.Color.White
        Me.ButtonIzmjeni.Location = New System.Drawing.Point(285, 278)
        Me.ButtonIzmjeni.Name = "ButtonIzmjeni"
        Me.ButtonIzmjeni.Size = New System.Drawing.Size(122, 34)
        Me.ButtonIzmjeni.TabIndex = 55
        Me.ButtonIzmjeni.Text = "&Izmjeni"
        Me.ButtonIzmjeni.UseVisualStyleBackColor = False
        '
        'ButtonDodajZaposlenog
        '
        Me.ButtonDodajZaposlenog.BackColor = System.Drawing.Color.Green
        Me.ButtonDodajZaposlenog.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonDodajZaposlenog.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonDodajZaposlenog.FlatAppearance.BorderSize = 0
        Me.ButtonDodajZaposlenog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.ButtonDodajZaposlenog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.ButtonDodajZaposlenog.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonDodajZaposlenog.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDodajZaposlenog.ForeColor = System.Drawing.Color.White
        Me.ButtonDodajZaposlenog.Location = New System.Drawing.Point(72, 278)
        Me.ButtonDodajZaposlenog.Name = "ButtonDodajZaposlenog"
        Me.ButtonDodajZaposlenog.Size = New System.Drawing.Size(199, 34)
        Me.ButtonDodajZaposlenog.TabIndex = 54
        Me.ButtonDodajZaposlenog.Text = "&Dodaj zaposlenog"
        Me.ButtonDodajZaposlenog.UseVisualStyleBackColor = False
        '
        'TextBoxJMBG
        '
        Me.TextBoxJMBG.BorderColor = System.Drawing.Color.MidnightBlue
        Me.TextBoxJMBG.BorderThickness = 3
        Me.TextBoxJMBG.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBoxJMBG.DefaultText = ""
        Me.TextBoxJMBG.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextBoxJMBG.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextBoxJMBG.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBoxJMBG.DisabledState.Parent = Me.TextBoxJMBG
        Me.TextBoxJMBG.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBoxJMBG.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBoxJMBG.FocusedState.Parent = Me.TextBoxJMBG
        Me.TextBoxJMBG.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxJMBG.ForeColor = System.Drawing.Color.Crimson
        Me.TextBoxJMBG.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBoxJMBG.HoverState.Parent = Me.TextBoxJMBG
        Me.TextBoxJMBG.Location = New System.Drawing.Point(470, 150)
        Me.TextBoxJMBG.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBoxJMBG.Name = "TextBoxJMBG"
        Me.TextBoxJMBG.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBoxJMBG.PlaceholderText = ""
        Me.TextBoxJMBG.SelectedText = ""
        Me.TextBoxJMBG.ShadowDecoration.Parent = Me.TextBoxJMBG
        Me.TextBoxJMBG.Size = New System.Drawing.Size(227, 33)
        Me.TextBoxJMBG.TabIndex = 52
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 38)
        Me.Panel1.TabIndex = 44
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Crimson
        Me.Label2.Location = New System.Drawing.Point(712, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Admin"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(646, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(60, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(69, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(272, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Online Rezervacija Karata"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(60, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(68, 121)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 25)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Ime *"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(263, 121)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 25)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "Prezime *"
        '
        'TextBoxPrezimeZaposlenog
        '
        Me.TextBoxPrezimeZaposlenog.BorderColor = System.Drawing.Color.MidnightBlue
        Me.TextBoxPrezimeZaposlenog.BorderThickness = 3
        Me.TextBoxPrezimeZaposlenog.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBoxPrezimeZaposlenog.DefaultText = ""
        Me.TextBoxPrezimeZaposlenog.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextBoxPrezimeZaposlenog.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextBoxPrezimeZaposlenog.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBoxPrezimeZaposlenog.DisabledState.Parent = Me.TextBoxPrezimeZaposlenog
        Me.TextBoxPrezimeZaposlenog.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBoxPrezimeZaposlenog.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBoxPrezimeZaposlenog.FocusedState.Parent = Me.TextBoxPrezimeZaposlenog
        Me.TextBoxPrezimeZaposlenog.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPrezimeZaposlenog.ForeColor = System.Drawing.Color.Crimson
        Me.TextBoxPrezimeZaposlenog.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBoxPrezimeZaposlenog.HoverState.Parent = Me.TextBoxPrezimeZaposlenog
        Me.TextBoxPrezimeZaposlenog.Location = New System.Drawing.Point(267, 150)
        Me.TextBoxPrezimeZaposlenog.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBoxPrezimeZaposlenog.Name = "TextBoxPrezimeZaposlenog"
        Me.TextBoxPrezimeZaposlenog.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBoxPrezimeZaposlenog.PlaceholderText = ""
        Me.TextBoxPrezimeZaposlenog.SelectedText = ""
        Me.TextBoxPrezimeZaposlenog.ShadowDecoration.Parent = Me.TextBoxPrezimeZaposlenog
        Me.TextBoxPrezimeZaposlenog.Size = New System.Drawing.Size(175, 33)
        Me.TextBoxPrezimeZaposlenog.TabIndex = 47
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label12.Location = New System.Drawing.Point(314, 327)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(192, 25)
        Me.Label12.TabIndex = 49
        Me.Label12.Text = "Spisak zaposlenih"
        '
        'TextBoxImeZaposlenog
        '
        Me.TextBoxImeZaposlenog.BorderColor = System.Drawing.Color.MidnightBlue
        Me.TextBoxImeZaposlenog.BorderThickness = 3
        Me.TextBoxImeZaposlenog.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBoxImeZaposlenog.DefaultText = ""
        Me.TextBoxImeZaposlenog.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextBoxImeZaposlenog.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextBoxImeZaposlenog.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBoxImeZaposlenog.DisabledState.Parent = Me.TextBoxImeZaposlenog
        Me.TextBoxImeZaposlenog.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBoxImeZaposlenog.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBoxImeZaposlenog.FocusedState.Parent = Me.TextBoxImeZaposlenog
        Me.TextBoxImeZaposlenog.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxImeZaposlenog.ForeColor = System.Drawing.Color.Crimson
        Me.TextBoxImeZaposlenog.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBoxImeZaposlenog.HoverState.Parent = Me.TextBoxImeZaposlenog
        Me.TextBoxImeZaposlenog.Location = New System.Drawing.Point(73, 150)
        Me.TextBoxImeZaposlenog.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBoxImeZaposlenog.Name = "TextBoxImeZaposlenog"
        Me.TextBoxImeZaposlenog.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBoxImeZaposlenog.PlaceholderText = ""
        Me.TextBoxImeZaposlenog.SelectedText = ""
        Me.TextBoxImeZaposlenog.ShadowDecoration.Parent = Me.TextBoxImeZaposlenog
        Me.TextBoxImeZaposlenog.Size = New System.Drawing.Size(175, 33)
        Me.TextBoxImeZaposlenog.TabIndex = 45
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(68, 198)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 25)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Broj telefona *"
        '
        'TextBoxBrojTel
        '
        Me.TextBoxBrojTel.BorderColor = System.Drawing.Color.MidnightBlue
        Me.TextBoxBrojTel.BorderThickness = 3
        Me.TextBoxBrojTel.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBoxBrojTel.DefaultText = ""
        Me.TextBoxBrojTel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextBoxBrojTel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextBoxBrojTel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBoxBrojTel.DisabledState.Parent = Me.TextBoxBrojTel
        Me.TextBoxBrojTel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBoxBrojTel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBoxBrojTel.FocusedState.Parent = Me.TextBoxBrojTel
        Me.TextBoxBrojTel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxBrojTel.ForeColor = System.Drawing.Color.Crimson
        Me.TextBoxBrojTel.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBoxBrojTel.HoverState.Parent = Me.TextBoxBrojTel
        Me.TextBoxBrojTel.Location = New System.Drawing.Point(73, 227)
        Me.TextBoxBrojTel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBoxBrojTel.Name = "TextBoxBrojTel"
        Me.TextBoxBrojTel.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBoxBrojTel.PlaceholderText = ""
        Me.TextBoxBrojTel.SelectedText = ""
        Me.TextBoxBrojTel.ShadowDecoration.Parent = Me.TextBoxBrojTel
        Me.TextBoxBrojTel.Size = New System.Drawing.Size(175, 33)
        Me.TextBoxBrojTel.TabIndex = 60
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(465, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 25)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "JMBG *"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(465, 198)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(182, 25)
        Me.Label5.TabIndex = 64
        Me.Label5.Text = "Lozinka naloga *"
        '
        'TextBoxLozinka
        '
        Me.TextBoxLozinka.BorderColor = System.Drawing.Color.MidnightBlue
        Me.TextBoxLozinka.BorderThickness = 3
        Me.TextBoxLozinka.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBoxLozinka.DefaultText = ""
        Me.TextBoxLozinka.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextBoxLozinka.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextBoxLozinka.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBoxLozinka.DisabledState.Parent = Me.TextBoxLozinka
        Me.TextBoxLozinka.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBoxLozinka.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBoxLozinka.FocusedState.Parent = Me.TextBoxLozinka
        Me.TextBoxLozinka.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxLozinka.ForeColor = System.Drawing.Color.Crimson
        Me.TextBoxLozinka.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBoxLozinka.HoverState.Parent = Me.TextBoxLozinka
        Me.TextBoxLozinka.Location = New System.Drawing.Point(470, 227)
        Me.TextBoxLozinka.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBoxLozinka.Name = "TextBoxLozinka"
        Me.TextBoxLozinka.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBoxLozinka.PlaceholderText = ""
        Me.TextBoxLozinka.SelectedText = ""
        Me.TextBoxLozinka.ShadowDecoration.Parent = Me.TextBoxLozinka
        Me.TextBoxLozinka.Size = New System.Drawing.Size(175, 33)
        Me.TextBoxLozinka.TabIndex = 63
        '
        'PictureBoxRezervacija
        '
        Me.PictureBoxRezervacija.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxRezervacija.Image = CType(resources.GetObject("PictureBoxRezervacija.Image"), System.Drawing.Image)
        Me.PictureBoxRezervacija.Location = New System.Drawing.Point(646, 49)
        Me.PictureBoxRezervacija.Name = "PictureBoxRezervacija"
        Me.PictureBoxRezervacija.Size = New System.Drawing.Size(60, 51)
        Me.PictureBoxRezervacija.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxRezervacija.TabIndex = 21
        Me.PictureBoxRezervacija.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(3, 44)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(60, 51)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 23
        Me.PictureBox3.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(263, 198)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(174, 25)
        Me.Label7.TabIndex = 66
        Me.Label7.Text = "Korisničko ime *"
        '
        'TextBoxKorisnickoIme
        '
        Me.TextBoxKorisnickoIme.BorderColor = System.Drawing.Color.MidnightBlue
        Me.TextBoxKorisnickoIme.BorderThickness = 3
        Me.TextBoxKorisnickoIme.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBoxKorisnickoIme.DefaultText = ""
        Me.TextBoxKorisnickoIme.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextBoxKorisnickoIme.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextBoxKorisnickoIme.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBoxKorisnickoIme.DisabledState.Parent = Me.TextBoxKorisnickoIme
        Me.TextBoxKorisnickoIme.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBoxKorisnickoIme.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBoxKorisnickoIme.FocusedState.Parent = Me.TextBoxKorisnickoIme
        Me.TextBoxKorisnickoIme.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxKorisnickoIme.ForeColor = System.Drawing.Color.Crimson
        Me.TextBoxKorisnickoIme.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBoxKorisnickoIme.HoverState.Parent = Me.TextBoxKorisnickoIme
        Me.TextBoxKorisnickoIme.Location = New System.Drawing.Point(268, 227)
        Me.TextBoxKorisnickoIme.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBoxKorisnickoIme.Name = "TextBoxKorisnickoIme"
        Me.TextBoxKorisnickoIme.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBoxKorisnickoIme.PlaceholderText = ""
        Me.TextBoxKorisnickoIme.SelectedText = ""
        Me.TextBoxKorisnickoIme.ShadowDecoration.Parent = Me.TextBoxKorisnickoIme
        Me.TextBoxKorisnickoIme.Size = New System.Drawing.Size(175, 33)
        Me.TextBoxKorisnickoIme.TabIndex = 65
        '
        'Zaposleni
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PowderBlue
        Me.ClientSize = New System.Drawing.Size(800, 550)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBoxKorisnickoIme)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LabelPutnici)
        Me.Controls.Add(Me.TextBoxLozinka)
        Me.Controls.Add(Me.LabelOdjava)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBoxRezervacija)
        Me.Controls.Add(Me.TextBoxBrojTel)
        Me.Controls.Add(Me.DataGridViewZaposleni)
        Me.Controls.Add(Me.ButtonNoviUnos)
        Me.Controls.Add(Me.ButtonObrisi)
        Me.Controls.Add(Me.ButtonIzmjeni)
        Me.Controls.Add(Me.ButtonDodajZaposlenog)
        Me.Controls.Add(Me.TextBoxJMBG)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBoxPrezimeZaposlenog)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TextBoxImeZaposlenog)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Zaposleni"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Zaposleni"
        CType(Me.DataGridViewZaposleni, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxRezervacija, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel4 As Panel
    Friend WithEvents LabelOdjava As Label
    Friend WithEvents LabelPutnici As Label
    Friend WithEvents DataGridViewZaposleni As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents ButtonNoviUnos As Button
    Friend WithEvents ButtonObrisi As Button
    Friend WithEvents ButtonIzmjeni As Button
    Friend WithEvents ButtonDodajZaposlenog As Button
    Friend WithEvents TextBoxJMBG As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBoxPrezimeZaposlenog As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBoxImeZaposlenog As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxBrojTel As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBoxRezervacija As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxLozinka As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxKorisnickoIme As Guna.UI2.WinForms.Guna2TextBox
End Class

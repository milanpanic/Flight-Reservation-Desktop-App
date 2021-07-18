<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Letovi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Letovi))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBoxLogOut = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.LabelImeZaposlenog = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBoxPolaziste = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBoxDestinacija = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxSjedista = New Guna.UI2.WinForms.Guna2TextBox()
        Me.DateTimePickerDatumLeta = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LabelRezervacije = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBoxRezervacije = New System.Windows.Forms.PictureBox()
        Me.LabelPutnici = New System.Windows.Forms.Label()
        Me.LabelLetovi = New System.Windows.Forms.Label()
        Me.PictureBoxPutnici = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.DataGridViewSpisakLetova = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ButtonDodajLet = New System.Windows.Forms.Button()
        Me.ButtonIzmjeniLet = New System.Windows.Forms.Button()
        Me.ButtonObrisiLet = New System.Windows.Forms.Button()
        Me.ButtonNoviLet = New System.Windows.Forms.Button()
        Me.ComboBoxAvioLinija = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBoxLogOut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBoxRezervacije, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxPutnici, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewSpisakLetova, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBoxLogOut)
        Me.Panel1.Controls.Add(Me.LabelImeZaposlenog)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(816, 60)
        Me.Panel1.TabIndex = 0
        '
        'PictureBoxLogOut
        '
        Me.PictureBoxLogOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxLogOut.Image = CType(resources.GetObject("PictureBoxLogOut.Image"), System.Drawing.Image)
        Me.PictureBoxLogOut.Location = New System.Drawing.Point(751, 4)
        Me.PictureBoxLogOut.Name = "PictureBoxLogOut"
        Me.PictureBoxLogOut.ShadowDecoration.Parent = Me.PictureBoxLogOut
        Me.PictureBoxLogOut.Size = New System.Drawing.Size(53, 53)
        Me.PictureBoxLogOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxLogOut.TabIndex = 7
        Me.PictureBoxLogOut.TabStop = False
        '
        'LabelImeZaposlenog
        '
        Me.LabelImeZaposlenog.AutoSize = True
        Me.LabelImeZaposlenog.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelImeZaposlenog.ForeColor = System.Drawing.Color.Crimson
        Me.LabelImeZaposlenog.Location = New System.Drawing.Point(555, 33)
        Me.LabelImeZaposlenog.Name = "LabelImeZaposlenog"
        Me.LabelImeZaposlenog.Size = New System.Drawing.Size(152, 24)
        Me.LabelImeZaposlenog.TabIndex = 3
        Me.LabelImeZaposlenog.Text = "Korisničko ime"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(489, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(60, 54)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(69, 33)
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
        Me.PictureBox1.Size = New System.Drawing.Size(60, 54)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Crimson
        Me.Label3.Location = New System.Drawing.Point(411, 262)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Aviolinija *:"
        '
        'ComboBoxPolaziste
        '
        Me.ComboBoxPolaziste.BackColor = System.Drawing.Color.White
        Me.ComboBoxPolaziste.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxPolaziste.ForeColor = System.Drawing.Color.MidnightBlue
        Me.ComboBoxPolaziste.FormattingEnabled = True
        Me.ComboBoxPolaziste.Items.AddRange(New Object() {"Banjaluka", "Beograd", "Sarajevo", "Zagreb", "Ljubljana", "Cirih", "Berlin", "Beč"})
        Me.ComboBoxPolaziste.Location = New System.Drawing.Point(224, 207)
        Me.ComboBoxPolaziste.Name = "ComboBoxPolaziste"
        Me.ComboBoxPolaziste.Size = New System.Drawing.Size(154, 29)
        Me.ComboBoxPolaziste.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Crimson
        Me.Label4.Location = New System.Drawing.Point(95, 211)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Polazište *:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Crimson
        Me.Label5.Location = New System.Drawing.Point(394, 211)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(145, 25)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Destinacija *:"
        '
        'ComboBoxDestinacija
        '
        Me.ComboBoxDestinacija.BackColor = System.Drawing.Color.White
        Me.ComboBoxDestinacija.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxDestinacija.ForeColor = System.Drawing.Color.MidnightBlue
        Me.ComboBoxDestinacija.FormattingEnabled = True
        Me.ComboBoxDestinacija.Items.AddRange(New Object() {"Banjaluka", "Beograd", "Sarajevo", "Zagreb", "Ljubljana", "Cirih", "Berlin", "Beč"})
        Me.ComboBoxDestinacija.Location = New System.Drawing.Point(544, 207)
        Me.ComboBoxDestinacija.Name = "ComboBoxDestinacija"
        Me.ComboBoxDestinacija.Size = New System.Drawing.Size(154, 29)
        Me.ComboBoxDestinacija.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Crimson
        Me.Label6.Location = New System.Drawing.Point(133, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(245, 25)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Ukupan broj sjedišta *: "
        '
        'TextBoxSjedista
        '
        Me.TextBoxSjedista.BorderColor = System.Drawing.Color.MidnightBlue
        Me.TextBoxSjedista.BorderThickness = 3
        Me.TextBoxSjedista.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBoxSjedista.DefaultText = ""
        Me.TextBoxSjedista.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextBoxSjedista.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextBoxSjedista.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBoxSjedista.DisabledState.Parent = Me.TextBoxSjedista
        Me.TextBoxSjedista.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBoxSjedista.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBoxSjedista.FocusedState.Parent = Me.TextBoxSjedista
        Me.TextBoxSjedista.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSjedista.ForeColor = System.Drawing.Color.Crimson
        Me.TextBoxSjedista.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBoxSjedista.HoverState.Parent = Me.TextBoxSjedista
        Me.TextBoxSjedista.Location = New System.Drawing.Point(385, 149)
        Me.TextBoxSjedista.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBoxSjedista.Name = "TextBoxSjedista"
        Me.TextBoxSjedista.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBoxSjedista.PlaceholderText = ""
        Me.TextBoxSjedista.SelectedText = ""
        Me.TextBoxSjedista.ShadowDecoration.Parent = Me.TextBoxSjedista
        Me.TextBoxSjedista.Size = New System.Drawing.Size(154, 33)
        Me.TextBoxSjedista.TabIndex = 9
        '
        'DateTimePickerDatumLeta
        '
        Me.DateTimePickerDatumLeta.BorderColor = System.Drawing.Color.MidnightBlue
        Me.DateTimePickerDatumLeta.BorderThickness = 3
        Me.DateTimePickerDatumLeta.CheckedState.Parent = Me.DateTimePickerDatumLeta
        Me.DateTimePickerDatumLeta.FillColor = System.Drawing.Color.White
        Me.DateTimePickerDatumLeta.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.DateTimePickerDatumLeta.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DateTimePickerDatumLeta.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.DateTimePickerDatumLeta.HoverState.Parent = Me.DateTimePickerDatumLeta
        Me.DateTimePickerDatumLeta.Location = New System.Drawing.Point(224, 250)
        Me.DateTimePickerDatumLeta.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DateTimePickerDatumLeta.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DateTimePickerDatumLeta.Name = "DateTimePickerDatumLeta"
        Me.DateTimePickerDatumLeta.ShadowDecoration.Parent = Me.DateTimePickerDatumLeta
        Me.DateTimePickerDatumLeta.Size = New System.Drawing.Size(154, 36)
        Me.DateTimePickerDatumLeta.TabIndex = 11
        Me.DateTimePickerDatumLeta.Value = New Date(2021, 4, 26, 13, 12, 36, 582)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Crimson
        Me.Label7.Location = New System.Drawing.Point(73, 261)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(145, 25)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Datum leta *:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel2.Controls.Add(Me.LabelRezervacije)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.PictureBoxRezervacije)
        Me.Panel2.Controls.Add(Me.LabelPutnici)
        Me.Panel2.Controls.Add(Me.LabelLetovi)
        Me.Panel2.Controls.Add(Me.PictureBoxPutnici)
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 60)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(816, 79)
        Me.Panel2.TabIndex = 15
        '
        'LabelRezervacije
        '
        Me.LabelRezervacije.AutoSize = True
        Me.LabelRezervacije.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelRezervacije.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRezervacije.ForeColor = System.Drawing.Color.Crimson
        Me.LabelRezervacije.Location = New System.Drawing.Point(535, 33)
        Me.LabelRezervacije.Name = "LabelRezervacije"
        Me.LabelRezervacije.Size = New System.Drawing.Size(129, 25)
        Me.LabelRezervacije.TabIndex = 22
        Me.LabelRezervacije.Text = "Rezervacije"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel3.Location = New System.Drawing.Point(140, 63)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(129, 8)
        Me.Panel3.TabIndex = 17
        '
        'PictureBoxRezervacije
        '
        Me.PictureBoxRezervacije.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxRezervacije.Image = CType(resources.GetObject("PictureBoxRezervacije.Image"), System.Drawing.Image)
        Me.PictureBoxRezervacije.Location = New System.Drawing.Point(469, 6)
        Me.PictureBoxRezervacije.Name = "PictureBoxRezervacije"
        Me.PictureBoxRezervacije.Size = New System.Drawing.Size(60, 51)
        Me.PictureBoxRezervacije.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxRezervacije.TabIndex = 21
        Me.PictureBoxRezervacije.TabStop = False
        '
        'LabelPutnici
        '
        Me.LabelPutnici.AutoSize = True
        Me.LabelPutnici.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelPutnici.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPutnici.ForeColor = System.Drawing.Color.Crimson
        Me.LabelPutnici.Location = New System.Drawing.Point(358, 34)
        Me.LabelPutnici.Name = "LabelPutnici"
        Me.LabelPutnici.Size = New System.Drawing.Size(79, 25)
        Me.LabelPutnici.TabIndex = 19
        Me.LabelPutnici.Text = "Putnici"
        '
        'LabelLetovi
        '
        Me.LabelLetovi.AutoSize = True
        Me.LabelLetovi.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLetovi.ForeColor = System.Drawing.Color.Crimson
        Me.LabelLetovi.Location = New System.Drawing.Point(206, 33)
        Me.LabelLetovi.Name = "LabelLetovi"
        Me.LabelLetovi.Size = New System.Drawing.Size(70, 25)
        Me.LabelLetovi.TabIndex = 16
        Me.LabelLetovi.Text = "Letovi"
        '
        'PictureBoxPutnici
        '
        Me.PictureBoxPutnici.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxPutnici.Image = CType(resources.GetObject("PictureBoxPutnici.Image"), System.Drawing.Image)
        Me.PictureBoxPutnici.Location = New System.Drawing.Point(292, 7)
        Me.PictureBoxPutnici.Name = "PictureBoxPutnici"
        Me.PictureBoxPutnici.Size = New System.Drawing.Size(60, 51)
        Me.PictureBoxPutnici.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxPutnici.TabIndex = 18
        Me.PictureBoxPutnici.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(140, 6)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(60, 51)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        '
        'DataGridViewSpisakLetova
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DataGridViewSpisakLetova.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewSpisakLetova.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewSpisakLetova.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewSpisakLetova.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridViewSpisakLetova.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridViewSpisakLetova.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Crimson
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewSpisakLetova.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewSpisakLetova.ColumnHeadersHeight = 26
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewSpisakLetova.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewSpisakLetova.EnableHeadersVisualStyles = False
        Me.DataGridViewSpisakLetova.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridViewSpisakLetova.Location = New System.Drawing.Point(36, 375)
        Me.DataGridViewSpisakLetova.Name = "DataGridViewSpisakLetova"
        Me.DataGridViewSpisakLetova.RowHeadersVisible = False
        Me.DataGridViewSpisakLetova.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewSpisakLetova.Size = New System.Drawing.Size(741, 118)
        Me.DataGridViewSpisakLetova.TabIndex = 16
        Me.DataGridViewSpisakLetova.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.DataGridViewSpisakLetova.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DataGridViewSpisakLetova.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DataGridViewSpisakLetova.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DataGridViewSpisakLetova.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DataGridViewSpisakLetova.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DataGridViewSpisakLetova.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DataGridViewSpisakLetova.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridViewSpisakLetova.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Crimson
        Me.DataGridViewSpisakLetova.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridViewSpisakLetova.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewSpisakLetova.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DataGridViewSpisakLetova.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DataGridViewSpisakLetova.ThemeStyle.HeaderStyle.Height = 26
        Me.DataGridViewSpisakLetova.ThemeStyle.ReadOnly = False
        Me.DataGridViewSpisakLetova.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DataGridViewSpisakLetova.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridViewSpisakLetova.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DataGridViewSpisakLetova.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DataGridViewSpisakLetova.ThemeStyle.RowsStyle.Height = 22
        Me.DataGridViewSpisakLetova.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridViewSpisakLetova.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Crimson
        Me.Label12.Location = New System.Drawing.Point(344, 347)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(146, 25)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Spisak letova"
        '
        'ButtonDodajLet
        '
        Me.ButtonDodajLet.BackColor = System.Drawing.Color.Green
        Me.ButtonDodajLet.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonDodajLet.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonDodajLet.FlatAppearance.BorderSize = 0
        Me.ButtonDodajLet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.ButtonDodajLet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.ButtonDodajLet.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonDodajLet.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDodajLet.ForeColor = System.Drawing.Color.White
        Me.ButtonDodajLet.Location = New System.Drawing.Point(139, 305)
        Me.ButtonDodajLet.Name = "ButtonDodajLet"
        Me.ButtonDodajLet.Size = New System.Drawing.Size(122, 34)
        Me.ButtonDodajLet.TabIndex = 18
        Me.ButtonDodajLet.Text = "&Dodaj let"
        Me.ButtonDodajLet.UseVisualStyleBackColor = False
        '
        'ButtonIzmjeniLet
        '
        Me.ButtonIzmjeniLet.BackColor = System.Drawing.Color.Blue
        Me.ButtonIzmjeniLet.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonIzmjeniLet.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonIzmjeniLet.FlatAppearance.BorderSize = 0
        Me.ButtonIzmjeniLet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.ButtonIzmjeniLet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.ButtonIzmjeniLet.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonIzmjeniLet.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonIzmjeniLet.ForeColor = System.Drawing.Color.White
        Me.ButtonIzmjeniLet.Location = New System.Drawing.Point(275, 305)
        Me.ButtonIzmjeniLet.Name = "ButtonIzmjeniLet"
        Me.ButtonIzmjeniLet.Size = New System.Drawing.Size(122, 34)
        Me.ButtonIzmjeniLet.TabIndex = 19
        Me.ButtonIzmjeniLet.Text = "&Izmjeni"
        Me.ButtonIzmjeniLet.UseVisualStyleBackColor = False
        '
        'ButtonObrisiLet
        '
        Me.ButtonObrisiLet.BackColor = System.Drawing.Color.Red
        Me.ButtonObrisiLet.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonObrisiLet.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonObrisiLet.FlatAppearance.BorderSize = 0
        Me.ButtonObrisiLet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.ButtonObrisiLet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.ButtonObrisiLet.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonObrisiLet.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonObrisiLet.ForeColor = System.Drawing.Color.White
        Me.ButtonObrisiLet.Location = New System.Drawing.Point(411, 305)
        Me.ButtonObrisiLet.Name = "ButtonObrisiLet"
        Me.ButtonObrisiLet.Size = New System.Drawing.Size(122, 34)
        Me.ButtonObrisiLet.TabIndex = 20
        Me.ButtonObrisiLet.Text = "&Obriši let"
        Me.ButtonObrisiLet.UseVisualStyleBackColor = False
        '
        'ButtonNoviLet
        '
        Me.ButtonNoviLet.BackColor = System.Drawing.Color.Olive
        Me.ButtonNoviLet.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonNoviLet.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonNoviLet.FlatAppearance.BorderSize = 0
        Me.ButtonNoviLet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.ButtonNoviLet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.ButtonNoviLet.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonNoviLet.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNoviLet.ForeColor = System.Drawing.Color.White
        Me.ButtonNoviLet.Location = New System.Drawing.Point(549, 305)
        Me.ButtonNoviLet.Name = "ButtonNoviLet"
        Me.ButtonNoviLet.Size = New System.Drawing.Size(122, 34)
        Me.ButtonNoviLet.TabIndex = 21
        Me.ButtonNoviLet.Text = "&Novi unos"
        Me.ButtonNoviLet.UseVisualStyleBackColor = False
        '
        'ComboBoxAvioLinija
        '
        Me.ComboBoxAvioLinija.BackColor = System.Drawing.Color.White
        Me.ComboBoxAvioLinija.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxAvioLinija.ForeColor = System.Drawing.Color.MidnightBlue
        Me.ComboBoxAvioLinija.FormattingEnabled = True
        Me.ComboBoxAvioLinija.Items.AddRange(New Object() {"Air Serbia", "Turkish Airlines", "Croatia Airlines", "Finnair", "Swiss International Airlines", "Lufthansa"})
        Me.ComboBoxAvioLinija.Location = New System.Drawing.Point(544, 257)
        Me.ComboBoxAvioLinija.Name = "ComboBoxAvioLinija"
        Me.ComboBoxAvioLinija.Size = New System.Drawing.Size(154, 29)
        Me.ComboBoxAvioLinija.TabIndex = 22
        '
        'Letovi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(816, 506)
        Me.Controls.Add(Me.ComboBoxAvioLinija)
        Me.Controls.Add(Me.ButtonNoviLet)
        Me.Controls.Add(Me.ButtonObrisiLet)
        Me.Controls.Add(Me.ButtonIzmjeniLet)
        Me.Controls.Add(Me.ButtonDodajLet)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.DataGridViewSpisakLetova)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DateTimePickerDatumLeta)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBoxSjedista)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ComboBoxDestinacija)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBoxPolaziste)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Letovi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBoxLogOut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBoxRezervacije, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxPutnici, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewSpisakLetova, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LabelImeZaposlenog As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBoxPolaziste As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBoxDestinacija As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxSjedista As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents DateTimePickerDatumLeta As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LabelRezervacije As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBoxRezervacije As PictureBox
    Friend WithEvents LabelPutnici As Label
    Friend WithEvents LabelLetovi As Label
    Friend WithEvents PictureBoxPutnici As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents DataGridViewSpisakLetova As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label12 As Label
    Friend WithEvents ButtonDodajLet As Button
    Friend WithEvents ButtonIzmjeniLet As Button
    Friend WithEvents ButtonObrisiLet As Button
    Friend WithEvents ButtonNoviLet As Button
    Friend WithEvents ComboBoxAvioLinija As ComboBox
    Friend WithEvents PictureBoxLogOut As Guna.UI2.WinForms.Guna2PictureBox
End Class

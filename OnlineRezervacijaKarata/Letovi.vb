Imports System.Data.SqlClient
Public Class Letovi

    'Povezivanje sa bazom

    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\acer\Documents\OnlineRezervacijaKarata.mdf;Integrated Security=True;Connect Timeout=30")

    'Globalna varijabla koja sluzi za ispis trenutno ulogovanog zaposlenog na vrhu ekrana

    Public imeZaposlenog As String

    'DUGME KOJE OMOGUCAVA UNOS LETOVA
    Private Sub ButtonDodajLet_Click(sender As Object, e As EventArgs) Handles ButtonDodajLet.Click
        Try
            Con.Open()

            'SQL Upit za unos letova

            Dim upit = "INSERT INTO Letovi VALUES('" & TextBoxSjedista.Text & "', '" & ComboBoxPolaziste.SelectedItem.ToString() & "', '" & ComboBoxDestinacija.SelectedItem.ToString() & "', '" & DateTimePickerDatumLeta.Value.Date & "', '" & ComboBoxAvioLinija.SelectedItem.ToString() & "')"
            Dim sqlKomanda As SqlCommand
            sqlKomanda = New SqlCommand(upit, Con)
            sqlKomanda.ExecuteNonQuery()
            MessageBox.Show("Let uspješno dodat!", "Potvrdna poruka", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Con.Close()
            NoviUnos()

            'Ispis spiska letova u DataGriduLetovi

            SpisakLetova()
        Catch ex As Exception

        End Try
    End Sub

    'Brisanje svih postojecih vrijednosti u TextBoxu i ComboBoxovima, prilikom novog unosa
    Private Sub NoviUnos()
        TextBoxSjedista.Text = ""

        'Postavimo sve indekse Combo Boxova na -1 odnosno prazan string

        ComboBoxPolaziste.SelectedIndex = -1
        ComboBoxDestinacija.SelectedIndex = -1
        ComboBoxAvioLinija.SelectedIndex = -1
    End Sub

    'Ispis svih Letova u DataGridu
    Private Sub SpisakLetova()
        Con.Open()

        'SQL Upit koji uzima sve vrijednost iz tabele Letovi
        Dim ispis = "SELECT Polaziste, Destinacija AS DEST, AvioLinija, DatumLeta, BrojSjedista AS [SLOBODNA MJESTA]
                       From Letovi"
        Dim sqlKomanda = New SqlCommand(ispis, Con)
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sqlKomanda)
        Dim builder = New SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        DataGridViewSpisakLetova.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub ButtonNoviLet_Click(sender As Object, e As EventArgs) Handles ButtonNoviLet.Click

        'Poziv procedure NoviUnos i postavljanje svih vrijednost na prazan string

        NoviUnos()
    End Sub

    'Provjera da li je izabran neki Let, postavimo u pocetku vrijednost na 0, odnosno kao da nije nista izabrano

    Dim daLiJeIzabranLet = 0

    'Dodavanje Eventa kada se klikne kursorom misa na neku celiju
    Private Sub DataGridViewSpisakLetova_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridViewSpisakLetova.CellMouseClick

        'Uzimanje indexa izabranog reda

        Dim red As DataGridViewRow = DataGridViewSpisakLetova.Rows(e.RowIndex)

        'Popunjavanje svih celija

        TextBoxSjedista.Text = red.Cells(1).Value.ToString

        'Za ComboBox koristimo SelectedItem kako bi se uzela vrijdnost koja je izabrana

        ComboBoxPolaziste.SelectedItem = red.Cells(2).Value.ToString
        ComboBoxDestinacija.SelectedItem = red.Cells(3).Value.ToString

        'Za DateTimePicker uzimamo .Value da dobijemo izabranu vrijednost datuma

        DateTimePickerDatumLeta.Value = red.Cells(4).Value.ToString
        ComboBoxAvioLinija.SelectedItem = red.Cells(5).Value.ToString

        'Ako je prazan string znaci da nita nije izabrano, te varijabla ostaje 0
        If TextBoxSjedista.Text = "" Then
            daLiJeIzabranLet = 0
        Else
            'Ako je izabrana bilo koja vrijednost vrsimo konverziju u tip Integer i omogucavamo ponovo dodavanje/brisanje
            daLiJeIzabranLet = Convert.ToInt32(red.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub Letovi_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Poziv procedure i ispis svih letova u Formi

        SpisakLetova()

        'Ispis korisnickog imena zaposlenog u labelu na vrhu forme

        LabelImeZaposlenog.Text = imeZaposlenog
    End Sub

    Private Sub ButtonObrisiLet_Click(sender As Object, e As EventArgs) Handles ButtonObrisiLet.Click

        'Ukoliko nismo izabrali nijednu celiju ispisuje se greska

        If daLiJeIzabranLet = 0 Then
            MessageBox.Show("Molimo izaberite let.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                Con.Open()

                'SQL Upit koji omogucuje brisanje leta tako sto uzima vrijednost izabranog ID-a

                Dim upit = "DELETE FROM Letovi WHERE IDLeta =" & daLiJeIzabranLet & ""
                Dim sqlKomanda As SqlCommand
                sqlKomanda = New SqlCommand(upit, Con)
                sqlKomanda.ExecuteNonQuery()
                MessageBox.Show("Let uspješno obrisan!", "Potvrdna poruka", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Con.Close()
                NoviUnos()

                'Azurirati postojeci Spisak nakon brisanja leta i ispisati

                SpisakLetova()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub ButtonIzmjeniLet_Click(sender As Object, e As EventArgs) Handles ButtonIzmjeniLet.Click

        'Ukoliko nijedna celija nije izabrana ispisuje se greska

        If TextBoxSjedista.Text = "" Or ComboBoxPolaziste.SelectedIndex = -1 Or ComboBoxDestinacija.SelectedIndex = -1 Or ComboBoxAvioLinija.SelectedIndex = -1 Then
            MessageBox.Show("Odaberite let koji želite izmjeniti.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                Con.Open()

                'SQL Upit koji azurira vrijednost u tabeli Letovi na osnovu nasih unesenih izmjena

                Dim upit = "UPDATE Letovi SET BrojSjedista ='" & TextBoxSjedista.Text & "', Polaziste ='" & ComboBoxPolaziste.SelectedItem.ToString() & "', Destinacija ='" & ComboBoxDestinacija.SelectedItem.ToString() & "', DatumLeta='" & DateTimePickerDatumLeta.Value.Date & "', AvioLinija='" & ComboBoxAvioLinija.SelectedItem.ToString() & "' WHERE IDLeta=" & daLiJeIzabranLet & ""
                Dim sqlKomanda As SqlCommand
                sqlKomanda = New SqlCommand(upit, Con)
                sqlKomanda.ExecuteNonQuery()
                MessageBox.Show("Let uspješno izmjenjen!", "Potvrdna poruka", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Con.Close()
                NoviUnos()

                'Ponovo azurirati DataGrid nakon izmjena i ispisati

                SpisakLetova()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    'Klikom na labelu Putnici omogucavamo otvaranje forme Putnici
    Private Sub LabelPutnici_MouseClick(sender As Object, e As MouseEventArgs) Handles LabelPutnici.MouseClick

        'Instanca forme Putnici

        Dim putn = New Putnici

        'Prikazivanje forme Putnici

        putn.Show()

        'Zatvaranje prethodne forme

        Me.Hide()
    End Sub

    'Omogucavanje otvaranja forme Putnici klikom na slicicu
    Private Sub PictureBoxPutnici_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBoxPutnici.MouseClick
        Dim putn = New Putnici
        putn.Show()
        Me.Hide()
    End Sub

    'Nanosenjem misa na labelu mjenja se boja
    Private Sub LabelPutnici_MouseHover(sender As Object, e As EventArgs) Handles LabelPutnici.MouseHover
        LabelPutnici.ForeColor = System.Drawing.Color.MidnightBlue
    End Sub

    'Ako sklonimo mis boja je vracena na pocetnu

    Private Sub LabelPutnici_MouseLeave(sender As Object, e As EventArgs) Handles LabelPutnici.MouseLeave
        LabelPutnici.ForeColor = System.Drawing.Color.Crimson
    End Sub

    'Omogucimo promjenu pozadinske boje (BackColor) kad nanesemo na slicicu
    Private Sub PictureBoxPutnici_MouseHover(sender As Object, e As EventArgs) Handles PictureBoxPutnici.MouseHover
        PictureBoxPutnici.BackColor = System.Drawing.Color.MidnightBlue
    End Sub

    'Kada sklonemo kursor misa pozadinska boja je bijela

    Private Sub PictureBoxPutnici_MouseLeave(sender As Object, e As EventArgs) Handles PictureBoxPutnici.MouseLeave
        PictureBoxPutnici.BackColor = System.Drawing.Color.White
    End Sub

    'Omogucava prelazak u formu Rezervacije klikom na labelu Rezervacije

    Private Sub LabelRezervacije_MouseClick(sender As Object, e As MouseEventArgs) Handles LabelRezervacije.MouseClick
        Dim rezer = New Rezervacija
        rezer.Show()
        Me.Hide()
    End Sub

    'Omogucava se prelazak u formu Rezervacije klikom na slicicu kod Rezervacija
    Private Sub PictureBoxRezervacije_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBoxRezervacije.MouseClick
        Dim rezer = New Rezervacija
        rezer.Show()
        Me.Hide()
    End Sub

    'Kad nanesemo kursor misa na labelu promjeni se boja
    Private Sub LabelRezervacije_MouseHover(sender As Object, e As EventArgs) Handles LabelRezervacije.MouseHover
        LabelRezervacije.ForeColor = System.Drawing.Color.MidnightBlue
    End Sub

    'Kad sklonemo kursor misa sa labele vraca se pocetna boja
    Private Sub LabelRezervacije_MouseLeave(sender As Object, e As EventArgs) Handles LabelRezervacije.MouseLeave
        LabelRezervacije.ForeColor = System.Drawing.Color.Crimson
    End Sub

    'Promjena pozadinske boje slicice kad se nanese kursor misa
    Private Sub PictureBoxRezervacije_MouseHover(sender As Object, e As EventArgs) Handles PictureBoxRezervacije.MouseHover
        PictureBoxRezervacije.BackColor = System.Drawing.Color.MidnightBlue
    End Sub

    'Vracanje pozadinske boje slicice kad se kursor misa sklone
    Private Sub PictureBoxRezervacije_MouseLeave(sender As Object, e As EventArgs) Handles PictureBoxRezervacije.MouseLeave
        PictureBoxRezervacije.BackColor = System.Drawing.Color.White
    End Sub

    'Klikom na slicicu u gornjem desnomo uglu omogucava se prikaz forme Login
    Private Sub PictureBoxLogOut_Click(sender As Object, e As EventArgs) Handles PictureBoxLogOut.Click
        Dim prijava = New Login
        prijava.Show()
        Me.Hide()
    End Sub

End Class


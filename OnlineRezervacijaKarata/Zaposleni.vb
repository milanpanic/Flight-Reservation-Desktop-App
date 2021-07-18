Imports System.Data.SqlClient
Public Class Zaposleni

    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\acer\Documents\OnlineRezervacijaKarata.mdf;Integrated Security=True;Connect Timeout=30")

    'Dugme za dodavanje zaposlenog

    Private Sub ButtonDodajZaposlenog_Click(sender As Object, e As EventArgs) Handles ButtonDodajZaposlenog.Click

        'U slucaju da nesto od podataka nismo unijeli ispisuje se greska, buduci da su sva polja MANDATORNA

        If TextBoxImeZaposlenog.Text = "" Or TextBoxPrezimeZaposlenog.Text = "" Or TextBoxJMBG.Text = "" Or TextBoxBrojTel.Text = "" Or TextBoxLozinka.Text = "" Or TextBoxKorisnickoIme.Text = "" Then
            MessageBox.Show("Molimo unesite sve podatke!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                Con.Open()

                'Pomocu INSERT INTO unosimo uzimamo vrijednosti iz Text Boxova i unosimo u tabelu
                Dim upit = "INSERT INTO Zaposleni VALUES('" & TextBoxImeZaposlenog.Text & "', '" & TextBoxPrezimeZaposlenog.Text & "', '" & TextBoxJMBG.Text & "', '" & TextBoxBrojTel.Text & "', '" & TextBoxLozinka.Text & "', '" & TextBoxKorisnickoIme.Text & "')"
                Dim sqlKomanda As SqlCommand
                sqlKomanda = New SqlCommand(upit, Con)

                'Ovom funkcijom izvrsavamo prethodno definisani upit

                sqlKomanda.ExecuteNonQuery()

                'Ispis potvrdne poruke

                MessageBox.Show("Novi zaposleni uspješno dodat!", "Potvrdna poruka", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Con.Close()

                'Poziv sub-procedure koja brise sve vrijednosti iz Textboxova i omogucava novi unos

                NoviUnos()

                'Sub-procedura koja ispisuje sve zaposlene u DataGridViewu

                SpisakZaposlenih()

                ' U slucaju greske izvrsava se Catch blok
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub SpisakZaposlenih()
        Con.Open()

        'Upit za ispis svih zaposlenih

        Dim ispis = "SELECT * FROM Zaposleni"
        Dim sqlKomanda = New SqlCommand(ispis, Con)

        'Popounjavanje skupa podataka u bazi SQL-a

        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sqlKomanda)

        'SqlCommandBuilder - omogucava generisanje komandi za tabelu kako bi se upisale sve vrijednosti

        Dim builder = New SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)

        'Predstavlja podatke unutar memorije

        Dim ds As DataSet
        ds = New DataSet

        'Popunjava se DataSet

        adapter.Fill(ds)

        'DataSource - uzima sve podatke i prikazuje u DataGridu
        DataGridViewZaposleni.DataSource = ds.Tables(0)
        Con.Close()
    End Sub


    'Varijable koja provjerava da li je izabran zaposleni, postavimo je u pocetku na 0

    Dim daLiJeIzabranZaposleni = 0


    ' Omogucavanje novog unosa i postavljanje svih TextBoxova na prazan string ""
    Private Sub NoviUnos()
        TextBoxImeZaposlenog.Text = ""
        TextBoxPrezimeZaposlenog.Text = ""
        TextBoxJMBG.Text = ""
        TextBoxBrojTel.Text = ""
        TextBoxLozinka.Text = ""
        TextBoxKorisnickoIme.Text = ""

        'Stavljanje pocetnog fokusa TextBoxa ime zaposlenog
        TextBoxImeZaposlenog.Select()

        'Omogocuava da provjerimo da li je izabrana neka od celija (koristi se za brisanje)

        daLiJeIzabranZaposleni = 0
    End Sub

    'Ucitati spisak automatski prilikom ucitavanja forme
    Private Sub Zaposleni_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SpisakZaposlenih()
    End Sub

    'Ispis u TextBoxovima kada kliknemo na neku celiju u DataGridu zaposlenih
    Private Sub DataGridViewZaposleni_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridViewZaposleni.CellMouseClick

        'Uzimanje reda koji je izabran prilikom klika neke od celija i njegovog indeksa

        Dim red As DataGridViewRow = DataGridViewZaposleni.Rows(e.RowIndex)

        'Uzimanje svih vrijednosti iz redova i popunjavanje TextBoxova, takodje se koristi i za update
        'Cells(popunjva odgovarajucu celiju)

        TextBoxImeZaposlenog.Text = red.Cells(1).Value.ToString
        TextBoxPrezimeZaposlenog.Text = red.Cells(2).Value.ToString
        TextBoxJMBG.Text = red.Cells(3).Value.ToString
        TextBoxBrojTel.Text = red.Cells(4).Value.ToString
        TextBoxLozinka.Text = red.Cells(5).Value.ToString
        TextBoxKorisnickoIme.Text = red.Cells(6).Value.ToString

        'Ako je Ime prazan string vrijednost ostaje 0

        If TextBoxImeZaposlenog.Text = "" Then
            daLiJeIzabranZaposleni = 0
        Else
            'U slucaju da je neka vrijednost izabrana konvertujemo tip podatka u Integer 
            daLiJeIzabranZaposleni = Convert.ToInt32(red.Cells(0).Value.ToString)
        End If
    End Sub
    Private Sub ButtonObrisi_Click(sender As Object, e As EventArgs) Handles ButtonObrisi.Click

        'U slucaju da nismo nista izabrali ispisuje se greska

        If daLiJeIzabranZaposleni = 0 Then
            MessageBox.Show("Molimo izaberite zaposlenog.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                Con.Open()

                'SQL upit za brisanje zaposlenog koji uzima vrijednost izabrane celije

                Dim upit = "DELETE FROM Zaposleni WHERE IdZaposleni =" & daLiJeIzabranZaposleni & ""
                Dim sqlKomanda As SqlCommand
                sqlKomanda = New SqlCommand(upit, Con)
                sqlKomanda.ExecuteNonQuery()

                'Ukoliko je sve u redu dobijamo poruku da je uspjesno obrisan

                MessageBox.Show("Zaposleni uspješno obrisan!", "Potvrdna poruka", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Con.Close()
                'Ponovo obrisemo sve vrijednosti iz textboxova
                NoviUnos()
                SpisakZaposlenih()
            Catch ex As Exception

                'Ako se desi greska ispis Exceptiona..

                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    'Dugme za promjenu podataka zaposlenog
    Private Sub ButtonIzmjeni_Click(sender As Object, e As EventArgs) Handles ButtonIzmjeni.Click

        'Ako nismo nista izabrali ispisuje se greska

        If TextBoxImeZaposlenog.Text = "" Or TextBoxPrezimeZaposlenog.Text = "" Or TextBoxJMBG.Text = "" Or TextBoxBrojTel.Text = "" Or TextBoxLozinka.Text = "" Then
            MessageBox.Show("Odaberite zaposlenog kojem želite izmjeniti podatke.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                Con.Open()

                'SQL UPIT koji uzima vrijednosti TextBoxova i upisuje ih u bazu

                Dim upit = "UPDATE Zaposleni SET Ime ='" & TextBoxImeZaposlenog.Text & "', Prezime ='" & TextBoxPrezimeZaposlenog.Text & "', JMBG ='" & TextBoxJMBG.Text & "', BrojTelefona ='" & TextBoxBrojTel.Text & "', ZaposleniPass ='" & TextBoxLozinka.Text & "', KorisnickoIme ='" & TextBoxKorisnickoIme.Text & "' WHERE IdZaposleni =" & daLiJeIzabranZaposleni & ""
                Dim sqlKomanda As SqlCommand
                sqlKomanda = New SqlCommand(upit, Con)
                sqlKomanda.ExecuteNonQuery()

                MessageBox.Show("Podaci o zaposlenom uspješno izmjenjeni!", "Potvrdna poruka", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Con.Close()

                'Vracamo sve vrijednosti TextBoxova na prazan string

                NoviUnos()

                'Osvjezimo vrijednosti u DataGridViewu

                SpisakZaposlenih()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    'Klikom na tabelu odjava prelazimo u formu Login
    Private Sub LabelOdjava_Click(sender As Object, e As EventArgs) Handles LabelOdjava.Click

        'Instanca forme Login

        Dim prijava = New Login
        prijava.Show()
        Me.Hide()
    End Sub

    'Takodje omogucimo odjavu klikom na PictureBox(ikonicu na formi)
    Private Sub PictureBoxRezervacija_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBoxRezervacija.MouseClick
        Dim prijava = New Login
        prijava.Show()
        Me.Hide()
    End Sub

    'Promjenimo boju, nakon sto nanesemo kursor misa na Labelu Odjava
    Private Sub LabelOdjava_MouseHover(sender As Object, e As EventArgs) Handles LabelOdjava.MouseHover
        LabelOdjava.ForeColor = System.Drawing.Color.MidnightBlue
    End Sub

    'Vratimo staru boju nakon sto smo sklonili kursor misa sa Labele Odjava
    Private Sub LabelOdjava_MouseLeave(sender As Object, e As EventArgs) Handles LabelOdjava.MouseLeave
        LabelOdjava.ForeColor = System.Drawing.Color.Crimson
    End Sub
End Class
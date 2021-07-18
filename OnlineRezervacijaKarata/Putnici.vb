Imports System.Data.SqlClient
Public Class Putnici

    'Uspostavaljanje konekcije sa bazom

    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\acer\Documents\OnlineRezervacijaKarata.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub ButtonDodajPutnika_Click(sender As Object, e As EventArgs) Handles ButtonDodajPutnika.Click

        'Ako nije unijet neki podatak ispisuje se greks, jer su svi podaci MANDATORNI

        If TextBoxImePutnika.Text = "" Or TextBoxPrezimePutnika.Text = "" Or TextBoxEmail.Text = "" Or TextBoxBrojTelefona.Text = "" Then
            MessageBox.Show("Molimo unesite sve podatke!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                Con.Open()

                'SQL UPIT koji omogucava unos putnika

                Dim upit = "INSERT INTO Putnici VALUES('" & TextBoxImePutnika.Text & "', '" & TextBoxPrezimePutnika.Text & "', '" & TextBoxEmail.Text & "', '" & TextBoxBrojTelefona.Text & "')"
                Dim sqlKomanda As SqlCommand
                sqlKomanda = New SqlCommand(upit, Con)
                sqlKomanda.ExecuteNonQuery()
                MessageBox.Show("Putnik uspješno dodat!", "Potvrdna poruka", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Con.Close()

                'Procedura koja nakon dodatog putnika postavlja sve vrijednosti textboxova na prazan string

                NoviUnos()

                'Ispis svih putnika

                SpisakPutnika()
            Catch ex As Exception

            End Try
        End If
    End Sub

    'Procedura koja ispisuje sve putnike u DataGridViewu
    Private Sub SpisakPutnika()
        Con.Open()
        Dim ispis = "SELECT * FROM Putnici"
        Dim sqlKomanda = New SqlCommand(ispis, Con)
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sqlKomanda)
        Dim builder = New SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        DataGridViewPutnici.DataSource = ds.Tables(0)
        Con.Close()
    End Sub

    'Procedura koja postavlja sve vrijednosti TextBoxova na prazan string 
    Private Sub NoviUnos()
        TextBoxImePutnika.Text = ""
        TextBoxPrezimePutnika.Text = ""
        TextBoxEmail.Text = ""
        TextBoxBrojTelefona.Text = ""

        'Staviti fokus na ime putnika

        TextBoxImePutnika.Select()
    End Sub

    'Kad se forma ucita omoguciti prikaz spiska svih putnika
    Private Sub Putnici_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SpisakPutnika()
    End Sub

    'Klikom na dugme novi unos potavljaju se sve vrijednosti TextBoxova na prazan string

    Private Sub ButtonNoviUnos_Click(sender As Object, e As EventArgs) Handles ButtonNoviUnos.Click
        NoviUnos()
    End Sub

    'Varijabla koja provjerava da li je izabran putnik - koristi se za izmjenu i brisanje podataka o putniku

    Dim daLiJeIzabranPutnik = 0

    'Klikom na neku od celija uzima se index reda i ispunjavaju se sve celije
    Private Sub DataGridViewPutnici_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridViewPutnici.CellMouseClick
        Dim red As DataGridViewRow = DataGridViewPutnici.Rows(e.RowIndex)

        TextBoxImePutnika.Text = red.Cells(1).Value.ToString
        TextBoxPrezimePutnika.Text = red.Cells(2).Value.ToString
        TextBoxEmail.Text = red.Cells(3).Value.ToString
        TextBoxBrojTelefona.Text = red.Cells(4).Value.ToString

        'Ukoliko je ime putnika prazan string putnik nije izabran

        If TextBoxImePutnika.Text = "" Then
            daLiJeIzabranPutnik = 0
        Else
            'U svakom ostalom slucaju pretvara se tip podatka u Integer i uzima se vrijednost ID-a putnika
            daLiJeIzabranPutnik = Convert.ToInt32(red.Cells(0).Value.ToString)
        End If
    End Sub

    'Dugme za brisanje putnika
    Private Sub ButtonObrisi_Click(sender As Object, e As EventArgs) Handles ButtonObrisi.Click

        'Ako putnik nije izabran, tj. ako prvo kliknemo na dugme, a da prethodno nismo izabrali neku od celija ispisace se greska
        If daLiJeIzabranPutnik = 0 Then
            MessageBox.Show("Molimo izaberite putnika.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                Con.Open()

                'SQL Upit koji uzima IDPutnika i brise izabrani red

                Dim upit = "DELETE FROM Putnici WHERE IDPutnika =" & daLiJeIzabranPutnik & ""
                Dim sqlKomanda As SqlCommand
                sqlKomanda = New SqlCommand(upit, Con)
                sqlKomanda.ExecuteNonQuery()
                MessageBox.Show("Putnik uspješno uklonjen!", "Potvrdna poruka", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Con.Close()

                'Postaviti sve vrijednosti TextBoxova na prazan string nakon brisanja

                NoviUnos()

                'Ispisati azurirani spisak putnika

                SpisakPutnika()
            Catch ex As Exception
                'U slucaju greske ispisati defaultni exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    'Dugme za izmjenu podataka o putniku

    Private Sub ButtonIzmjeni_Click(sender As Object, e As EventArgs) Handles ButtonIzmjeni.Click

        'Ukoliko nismo odabrali putnika kojem zelimo mjenjati podatke, ispisuje se greska
        If TextBoxImePutnika.Text = "" Or TextBoxPrezimePutnika.Text = "" Or TextBoxEmail.Text = "" Or TextBoxBrojTelefona.Text = "" Then
            MessageBox.Show("Odaberite putnika kojem želite izmjeniti podatke.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                Con.Open()

                'SQL Upit koji mjenja podatke u skladu sa izabranim putnikom

                Dim upit = "UPDATE Putnici SET ImePutnika ='" & TextBoxImePutnika.Text & "', PrezimePutnika ='" & TextBoxPrezimePutnika.Text & "', Email ='" & TextBoxEmail.Text & "', Telefon='" & TextBoxBrojTelefona.Text & "' WHERE IDPutnika=" & daLiJeIzabranPutnik & ""
                Dim sqlKomanda As SqlCommand
                sqlKomanda = New SqlCommand(upit, Con)
                sqlKomanda.ExecuteNonQuery()
                MessageBox.Show("Podaci uspješno izmjenjeni!", "Potvrdna poruka", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Con.Close()

                'Omoguciti novi unos putnika, tj. postaviti TextBoxove na prazan string

                NoviUnos()

                'Ispis azuriranog spiska putnika

                SpisakPutnika()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    'Klikom na labelu Rezervacija otvara se forma Rezervacija
    Private Sub LabelRezervacija_MouseClick(sender As Object, e As MouseEventArgs) Handles LabelRezervacija.MouseClick
        Dim rez = New Rezervacija
        rez.Show()
        Me.Hide()
    End Sub

    'Klikom na slicuc Rezervacije otvara se forma Rezervacija
    Private Sub PictureBoxRezervacija_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBoxRezervacija.MouseClick
        Dim rez = New Rezervacija
        rez.Show()
        Me.Hide()
    End Sub

    'Nanosenjem misa na labelu Rezervacija mjenja se boja fonta
    Private Sub LabelRezervacija_MouseHover(sender As Object, e As EventArgs) Handles LabelRezervacija.MouseHover
        LabelRezervacija.ForeColor = System.Drawing.Color.MidnightBlue
    End Sub

    'Kad sklonimo mis boja se vrati na prvobitnu
    Private Sub LabelRezervacija_MouseLeave(sender As Object, e As EventArgs) Handles LabelRezervacija.MouseLeave
        LabelRezervacija.ForeColor = System.Drawing.Color.Crimson
    End Sub

    'Nanosenjem misa na labelu Letovi mjenja se boja fonta
    Private Sub LabelLetovi_MouseHover(sender As Object, e As EventArgs) Handles LabelLetovi.MouseHover
        LabelLetovi.ForeColor = System.Drawing.Color.MidnightBlue
    End Sub

    'Kad sklonemo mis sa labele Letovi boja se vrati na prvobitnu
    Private Sub LabelLetovi_MouseLeave(sender As Object, e As EventArgs) Handles LabelLetovi.MouseLeave
        LabelLetovi.ForeColor = System.Drawing.Color.Crimson
    End Sub

    'Klikom na labelu Letovi otvara nam se forma Letovi
    Private Sub LabelLetovi_MouseClick(sender As Object, e As MouseEventArgs) Handles LabelLetovi.MouseClick
        Dim leto = New Letovi
        leto.Show()
        Me.Hide()
    End Sub

    'Klikom na slicicu Letovi otvara nam se forma Letovi
    Private Sub PictureBox3_Letovi(sender As Object, e As MouseEventArgs) Handles PictureBoxLetovi.MouseClick
        Dim leto = New Letovi
        leto.Show()
        Me.Hide()
    End Sub

    'Nanosenjem misa na ikonicu mjenja se pozadinska boja
    Private Sub PictureBoxLetovi_MouseHover(sender As Object, e As EventArgs) Handles PictureBoxLetovi.MouseHover
        PictureBoxLetovi.BackColor = System.Drawing.Color.MidnightBlue
    End Sub

    'Kad sklonemo mis sa ikonice pozadinska boja se vraca na prvobitnu (bijelu)
    Private Sub PictureBoxLetovi_MouseLeave(sender As Object, e As EventArgs) Handles PictureBoxLetovi.MouseLeave
        PictureBoxLetovi.BackColor = System.Drawing.Color.White
    End Sub

    'Nanosenjem misa na ikonicu rezervacija mjenja se pozadniska boja
    Private Sub PictureBoxRezervacija_MouseHover(sender As Object, e As EventArgs) Handles PictureBoxRezervacija.MouseHover
        PictureBoxRezervacija.BackColor = System.Drawing.Color.MidnightBlue
    End Sub

    'Kad sklonemo mis sa ikonice pozadinska boja je ponovo prvobitna tj. bijela
    Private Sub PictureBoxRezervacija_MouseLeave(sender As Object, e As EventArgs) Handles PictureBoxRezervacija.MouseLeave
        PictureBoxRezervacija.BackColor = System.Drawing.Color.White
    End Sub

    'Klikom na dugme u gornjem desnom cosku vracamo se na formu Login
    Private Sub PictureBoxLogOut_Click(sender As Object, e As EventArgs) Handles PictureBoxLogOut.Click
        Dim prijava = New Login
        prijava.Show()
        Me.Hide()
    End Sub
End Class

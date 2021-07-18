Imports System.Data.SqlClient
Public Class Rezervacija

    'Povezivanje sa bazom

    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\acer\Documents\OnlineRezervacijaKarata.mdf;Integrated Security=True;Connect Timeout=30")

    'Ispis svih rezervacija
    Private Sub spisakRezervacija()
        Con.Open()

        'SQL UPIT KOJI POVEZUJE 4 TABELE ZA ISPIS REZERVACIJA KARATA

        Dim ispis = "SELECT IDR, ImePutnika AS Ime, PrezimePutnika AS Prezime, AvioLinija, Sjediste AS [SLOB MJESTA],
                            DatumLeta AS Polazak, Polaziste, DatumPovratka AS Povratak, Destinacija AS Dest, 
                            CAST(CijenaKM AS VARCHAR) + 'KM' AS CIJENA                       
                     FROM Rezervacija  
                     INNER JOIN Putnici  
                     ON Rezervacija.IDPutnika = Putnici.IDPutnika
                     INNER JOIN Letovi  
                     ON Rezervacija.IDLeta = Letovi.IDLeta
                     INNER JOIN CijenaKarte
                     ON CijenaKarte.IDLeta = Letovi.IDLeta"

        'Inicijalizacija SQL komande koja povezuje upit i bazu

        Dim sqlKomanda = New SqlCommand(ispis, Con)
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sqlKomanda)
        Dim builder = New SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)

        'Inicijalizacija dataseta

        Dim ds As DataSet
        ds = New DataSet
        'Dodavanje u DataSet i ispis

        adapter.Fill(ds)
        DataGridViewRezervacije.DataSource = ds.Tables(0)
        Con.Close()
    End Sub

    'Dodavanje ID-ova putnika iz tabele Putnici u ComboBoxIDPutnika
    Private Sub ispisiIDPutnika()
        Con.Open()
        Dim sql = "SELECT * FROM Putnici"
        Dim komanda As New SqlCommand(sql, Con)
        Dim adapter As New SqlDataAdapter(komanda)
        Dim tabela As New DataTable()
        adapter.Fill(tabela)

        'Uzimaju se sve vrijednosti iz tabele

        ComboBoxIDPutnika.DataSource = tabela

        'Davanje svojstva Display za ispisvanje vrijednosti

        ComboBoxIDPutnika.DisplayMember = "IDPutnika"

        'Definisanje svih vrijednosti ID-ova putnika na osnovu vrijednosti iz tabele
        ComboBoxIDPutnika.ValueMember = "IDPutnika"
        Con.Close()
    End Sub


    Private Sub ispisiImePutnika()
        Con.Open()

        'Ispisivanje imena putnika, na osnovu izabranog ID-a iz ComboBox-a

        Dim sql = "SELECT * FROM Putnici WHERE IDPutnika = " & ComboBoxIDPutnika.SelectedValue.ToString() & ""
        Dim komanda As New SqlCommand(sql, Con)
        Dim dt As New DataTable()

        'Inicijalizacija SQL Readera(citaca) koji cita sve redove iz baze

        Dim reader As SqlDataReader

        'Izvrsavanje readera na osnovu zadate komande

        reader = komanda.ExecuteReader

        'Izvrsavaj sve dok se unose rezervacije

        While reader.Read

            'U Text Box ime se upisuje vrijednost iz tabele Putnici - index(1) tj. iz prve celije - Ime

            TextBoxIme.Text = reader(1).ToString()
        End While
        Con.Close()
    End Sub

    Private Sub ispisiPrezimePutnika()
        Con.Open()

        'Ispisivanje prezimena putnika, na osnovu izabranog ID-a iz ComboBox-a

        Dim sql = "SELECT * FROM Putnici WHERE IDPutnika = " & ComboBoxIDPutnika.SelectedValue.ToString() & ""
        Dim komanda As New SqlCommand(sql, Con)
        Dim tabela As New DataTable()
        Dim reader As SqlDataReader

        reader = komanda.ExecuteReader

        'Izvrsavaj sve dok se unose rezervacije

        While reader.Read

            'U Text Box ime se upisuje vrijednost iz tabele Putnici - index(2) tj. iz druge celije - Prezime

            TextBoxPrezime.Text = reader(2).ToString()
        End While
        Con.Close()
    End Sub

    'Ispisivanje broja telefona putnika, na isti nacin kao i za ime i prezime
    Private Sub ispisiBrojTelefona()
        Con.Open()
        Dim sql = "SELECT * FROM Putnici WHERE IDPutnika = " & ComboBoxIDPutnika.SelectedValue.ToString() & ""
        Dim komanda As New SqlCommand(sql, Con)
        Dim tabela As New DataTable()
        Dim reader As SqlDataReader
        reader = komanda.ExecuteReader
        While reader.Read
            TextBoxBrojTelefona.Text = reader(4).ToString()
        End While
        Con.Close()
    End Sub

    'Ispisivanje polazista leta (Koristimo tabelu Letovi) na osnovu izabranog ID-a
    Private Sub ispisiPolaziste()
        Con.Open()
        Dim sql = "SELECT * FROM Letovi WHERE IDLeta = " & ComboBoxIDLeta.SelectedValue.ToString() & ""
        Dim komanda As New SqlCommand(sql, Con)
        Dim tabela As New DataTable()
        Dim reader As SqlDataReader
        reader = komanda.ExecuteReader
        While reader.Read
            TextBoxPolaziste.Text = reader(2).ToString()
        End While
        Con.Close()
    End Sub


    'Ispisivanje destinacije leta (Koristimo tabelu Letovi) na osnovu izabranog ID-a
    Private Sub ispisiDestinaciju()
        Con.Open()
        Dim sql = "SELECT * FROM Letovi WHERE IDLeta = " & ComboBoxIDLeta.SelectedValue.ToString() & ""
        Dim komanda As New SqlCommand(sql, Con)
        Dim tabela As New DataTable()
        Dim reader As SqlDataReader
        reader = komanda.ExecuteReader
        While reader.Read

            'Uzimamo vrijednost iz trece kolone iz tabele Letovi

            TextBoxDestinacija.Text = reader(3).ToString()
        End While
        Con.Close()
    End Sub

    'Ispisivanje datuma polaska leta (Koristimo tabelu Letovi) na osnovu izabranog ID-a
    Private Sub ispisiDatumPolaska()
        Con.Open()
        Dim sql = "SELECT * FROM Letovi WHERE IDLeta = " & ComboBoxIDLeta.SelectedValue.ToString() & ""
        Dim komanda As New SqlCommand(sql, Con)
        Dim tabela As New DataTable()
        Dim reader As SqlDataReader
        reader = komanda.ExecuteReader
        While reader.Read
            TextBoxDatumPolaska.Text = reader(4).ToString()
        End While
        Con.Close()
    End Sub

    Private Sub ispisiUkupanBrojSjedista()
        Con.Open()

        'Deklaracija niza(300) u koju ce biti sacuvane vrijednosti na osnovu ukupnog broja sjedista
        Dim nizSjedista(300) As Integer
        Dim ukupnoSjedista As Integer
        Dim i As Integer

        'SQL Upit na osnovu izabrane vrijednosti iz ComboBoxa

        Dim sql = "SELECT * FROM Letovi WHERE IDLeta = " & ComboBoxIDLeta.SelectedValue.ToString() & ""
        Dim komanda As New SqlCommand(sql, Con)
        Dim tabela As New DataTable()
        Dim reader As SqlDataReader
        reader = komanda.ExecuteReader


        While reader.Read

            'Pohranjujemo ukupan broj sjedista u varijablu ukupnoSjedista npr. neka je to 220

            ukupnoSjedista = reader(1).ToString()
        End While


        For i = 1 To ukupnoSjedista

            'U niz pohranjujemo vrijednosti u nasem slucaju od 1 do 220 

            nizSjedista(i) = i

            'U ComboBoxSjediste dodamo sve vrijednost 1-220 te na taj nacin omogucimo korisniku da izabere sjedsite po zelji

            ComboBoxSjediste.Items.Add(nizSjedista(i)).ToString()
        Next
        Con.Close()
    End Sub

    'Dodavanje vrijednosti u ComboBoxIDLeta na osnovu vrijednosti u tabeli Letovi
    Private Sub ispisiIDLeta()
        Con.Open()
        Dim sql = "SELECT * FROM Letovi"
        Dim komanda As New SqlCommand(sql, Con)
        Dim adapter As New SqlDataAdapter(komanda)
        Dim tabela As New DataTable()
        adapter.Fill(tabela)
        ComboBoxIDLeta.DataSource = tabela
        ComboBoxIDLeta.DisplayMember = "IDLeta"
        ComboBoxIDLeta.ValueMember = "IDLeta"
        Con.Close()
    End Sub

    'Ispis cijene karte za neki let
    Private Sub ispisiCijenuKarte()
        Con.Open()
        Dim sql = "SELECT * FROM CijenaKarte WHERE IDLeta = " & ComboBoxIDLeta.SelectedValue.ToString() & ""
        Dim komanda As New SqlCommand(sql, Con)
        Dim tabela As New DataTable()
        Dim reader As SqlDataReader
        reader = komanda.ExecuteReader
        While reader.Read

            'U slucaju da je izabrano jednosmjerno ispisati cijenu karte koja je i smjestena u bazi

            If RadioButtonJednosmjerno.Checked Then

                'Zaokruziti na 2 decimle i izvrsiti konkatenaciju " KM"

                TextBoxCijenaKarte.Text = Math.Round(reader(2), 2) & " KM"

                'Ako je izabrana povratna karta potrebno ju je pomnoziti sa 2 i umanjiti za 15%
                'Npr. Jednosmjerna karta BL-BG kosta 100 KM 
                'Povratna karta = 100 * 2 * 0.85 = 170 KM

            ElseIf RadioButtonPovratna.Checked Then
                TextBoxCijenaKarte.Text = Math.Round(reader(2) * 2 * 0.85, 2) & " KM"
            End If
        End While
        Con.Close()
    End Sub

    'Po ucitavanju forme ispisati ID-ove putnika, ID-ove letova i spisak rezervacija
    Private Sub Rezervacija_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ispisiIDPutnika()
        ispisiIDLeta()
        spisakRezervacija()

    End Sub

    'Staviti prazan string za svaki TextBox kad imamo noviUnos
    Private Sub NoviUnos()
        TextBoxIme.Text = ""
        TextBoxPrezime.Text = ""
        TextBoxPolaziste.Text = ""
        TextBoxDestinacija.Text = ""
        TextBoxBrojTelefona.Text = ""
        TextBoxDatumPolaska.Text = ""
        TextBoxCijenaKarte.Text = ""
        TextBoxIDRez.Text = ""
    End Sub

    ' D U G M E   Z A   R E Z E R V A C I J U
    Private Sub ButtonRezervisi_Click(sender As Object, e As EventArgs) Handles ButtonRezervisi.Click

        'Ukoliko nesto od podataka fali ispisati gresku

        If TextBoxIme.Text = "" Or TextBoxPrezime.Text = "" Or ComboBoxIDLeta.SelectedIndex = -1 Then
            MessageBox.Show("Molimo unesite sve podatke!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error)

            'Ako je izabrana jednosmjerna karta unositi podatke u IDPutnika, IDLeta i Sjediste
            'NE UNOSITI PODATKE ZA DATUM POVRATKA

        ElseIf RadioButtonJednosmjerno.Checked Then
            Try
                Con.Open()

                Dim upit = "INSERT INTO Rezervacija(IDPutnika, IDLeta, Sjediste) VALUES('" & ComboBoxIDPutnika.SelectedValue.ToString() & "', '" & ComboBoxIDLeta.SelectedValue.ToString() & "', '" & ComboBoxSjediste.Text.ToString() & "')"
                Dim sqlKomanda As SqlCommand
                sqlKomanda = New SqlCommand(upit, Con)
                sqlKomanda.ExecuteNonQuery()
                MessageBox.Show("Vaš let je rezervisan. Srećan put!", "Potvrdna poruka", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Con.Close()
                NoviUnos()

                'Azurirati DataGrid nakon unosa

                spisakRezervacija()
            Catch ex As Exception

            End Try

            'U slucaju da je karta povratna onda u tabelu unositi sve izabrane vrijednosti
        ElseIf RadioButtonPovratna.Checked Then
            Try
                Con.Open()
                Dim upit = "INSERT INTO Rezervacija VALUES('" & ComboBoxIDPutnika.SelectedValue.ToString() & "', '" & ComboBoxIDLeta.SelectedValue.ToString() & "', '" & DateTimePickerDatumPovratka.Value.Date & "', '" & ComboBoxSjediste.Text.ToString() & "')"
                Dim sqlKomanda As SqlCommand
                sqlKomanda = New SqlCommand(upit, Con)
                sqlKomanda.ExecuteNonQuery()
                MessageBox.Show("Vaš let je rezervisan. Srećan put!", "Potvrdna poruka", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Con.Close()
                NoviUnos()
                spisakRezervacija()
            Catch ex As Exception

            End Try

            'Ako nije izabran tip karte ispisati gresku

        Else
            MessageBox.Show("Niste odabrali tip karte!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    'Kada se izabere IDPutnika ispisati ime, prezime i broj telefona putnika
    Private Sub ComboBoxIDPutnika_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBoxIDPutnika.SelectionChangeCommitted
        ispisiImePutnika()
        ispisiPrezimePutnika()
        ispisiBrojTelefona()

    End Sub

    'Kad se izabere IDLeta ispisati polaziste, destinaciju, datum polaska, cijenukarte i ukupan broj sjedista
    Private Sub ComboBoxIDLeta_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBoxIDLeta.SelectionChangeCommitted
        ispisiPolaziste()
        ispisiDestinaciju()
        ispisiDatumPolaska()
        ispisiCijenuKarte()

        'Ovim se omogucuje da korisnik izabere sjediste iz ComboBoxa

        ispisiUkupanBrojSjedista()
    End Sub

    'Klikom na dugme NoviUnos podesiti sve TextBoxove na prazan string 
    Private Sub ButtonNoviUnos_Click(sender As Object, e As EventArgs) Handles ButtonNoviUnos.Click
        NoviUnos()
    End Sub

    'Inicijalizacija i dodjela vrijednosti varijabli

    Dim daLiJeIzabranaRezervacija = 0
    Private Sub ButtonPonistiRez_Click(sender As Object, e As EventArgs) Handles ButtonPonistiRez.Click

        'Ako u TextBox nije unijet ID rezervacije koji se ponistava ispisati gresku

        If TextBoxIDRez.Text = "" Then
            MessageBox.Show("Unesite ID Rezervacije koju želite otkazati.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                Con.Open()

                'SQL Upit kojim se na osnovu ID-a rezervacije koji je unijet u TextBox brise vrijednost tj. otkazuje rezervacija
                Dim upit = "DELETE FROM Rezervacija WHERE IDR =" & TextBoxIDRez.Text & ""
                Dim sqlKomanda As SqlCommand
                sqlKomanda = New SqlCommand(upit, Con)
                sqlKomanda.ExecuteNonQuery()
                MessageBox.Show("Rezervacija uspješno otkazana!", "Potvrdna poruka", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Con.Close()
                NoviUnos()
                spisakRezervacija()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    'Kad se klikne na labelu Putnici otvara nam se forma Putnici

    Private Sub LabelPutnici_MouseClick(sender As Object, e As MouseEventArgs) Handles LabelPutnici.MouseClick
        Dim putn = New Putnici
        putn.Show()
        Me.Hide()
    End Sub

    'Kad se klikne na slicicu takodje nas vodi na formu Putnici

    Private Sub PictureBoxPutnici_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBoxPutnici.MouseClick
        Dim putn = New Putnici
        putn.Show()
        Me.Hide()
    End Sub

    'Kada nanesemo kursor misa na labelu promjeni se boja fonta
    Private Sub LabelPutnici_MouseHover(sender As Object, e As EventArgs) Handles LabelPutnici.MouseHover
        LabelPutnici.ForeColor = System.Drawing.Color.MidnightBlue
    End Sub

    'kada se skloni kursor misa sa labele boja se vrati na pocetnu
    Private Sub LabelPutnici_MouseLeave(sender As Object, e As EventArgs) Handles LabelPutnici.MouseLeave
        LabelPutnici.ForeColor = System.Drawing.Color.Crimson
    End Sub

    Private Sub LabelLetovi_MouseHover(sender As Object, e As EventArgs) Handles LabelLetovi.MouseHover
        LabelLetovi.ForeColor = System.Drawing.Color.MidnightBlue
    End Sub

    Private Sub LabelLetovi_MouseLeave(sender As Object, e As EventArgs) Handles LabelLetovi.MouseLeave
        LabelLetovi.ForeColor = System.Drawing.Color.Crimson
    End Sub

    'Klikom na labelu Letovi otvara se forma Letovi
    Private Sub LabelLetovi_MouseClick(sender As Object, e As MouseEventArgs) Handles LabelLetovi.MouseClick
        Dim leto = New Letovi
        leto.Show()
        Me.Hide()
    End Sub

    'Isto kao i kad kliknemo na labelu vodi nas na formu Letovi
    Private Sub PictureBoxLetovi_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBoxLetovi.MouseClick
        Dim leto = New Letovi
        leto.Show()
        Me.Hide()
    End Sub

    'Promjena pozadinske boje slicice
    Private Sub PictureBoxLetovi_MouseHover(sender As Object, e As EventArgs) Handles PictureBoxLetovi.MouseHover
        PictureBoxLetovi.BackColor = System.Drawing.Color.MidnightBlue
    End Sub

    'Vracanje na prvobitnu boju
    Private Sub PictureBoxLetovi_MouseLeave(sender As Object, e As EventArgs) Handles PictureBoxLetovi.MouseLeave
        PictureBoxLetovi.BackColor = System.Drawing.Color.PaleTurquoise
    End Sub

    Private Sub PictureBoxPutnici_MouseHover(sender As Object, e As EventArgs) Handles PictureBoxPutnici.MouseHover
        PictureBoxPutnici.BackColor = System.Drawing.Color.MidnightBlue
    End Sub
    Private Sub PictureBoxPutnici_MouseLeave(sender As Object, e As EventArgs) Handles PictureBoxPutnici.MouseLeave
        PictureBoxPutnici.BackColor = System.Drawing.Color.PaleTurquoise
    End Sub

    'LogOut u gornjem desnom uglu, nas vraca na Login formu
    Private Sub PictureBoxLogOut_Click(sender As Object, e As EventArgs) Handles PictureBoxLogOut.Click
        Dim prijava = New Login
        prijava.Show()
        Me.Hide()
    End Sub

    'Dugme stampaj omoguce PrintPreview rezervacija
    Private Sub ButtonStampaj_Click(sender As Object, e As EventArgs) Handles ButtonStampaj.Click
        PrintPreviewDialog1.Show()
    End Sub

    'DEFINISANJE IZGLEDA PAPIRA NA KOJEM SE VRSI STAMPANJE
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        'Koristimo Graphics i metodu Draw String za ispis tipa, velicine i boje fonta 
        e.Graphics.DrawString("Rezervacije", New Font("Arial", 25), Brushes.Red, 250, 40)

        'Koristimo Bitmapu za iscrtavanje tabele iz DataGrida uzimaciju parametre Width - sirina i Height - visina

        Dim bm As New Bitmap(Me.DataGridViewRezervacije.Width, Me.DataGridViewRezervacije.Height)

        'Vrsi se iscrtavanje u obliku pravougonika, postavimo koordinate (X,Y) = (0,0)
        DataGridViewRezervacije.DrawToBitmap(bm, New Rectangle(0, 0, Me.DataGridViewRezervacije.Width, Me.DataGridViewRezervacije.Height))

        'Konacno iscrtavanje slike koordinate (X,Y) = (5, 100)
        e.Graphics.DrawImage(bm, 5, 100)

    End Sub

End Class

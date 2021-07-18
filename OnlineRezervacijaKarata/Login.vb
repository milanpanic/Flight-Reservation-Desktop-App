'Biblioteka za povezivanje sa bazom
Imports System.Data.SqlClient
Public Class Login
    'Kreiranje konekcije sa bazom i umetanje lokacije baze (file path)
    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\acer\Documents\OnlineRezervacijaKarata.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub ButtonPrijava_Click(sender As Object, e As EventArgs) Handles ButtonPrijava.Click

        'Ukoliko nije uneseno korisnicko ime ili lozinka ispisuje se greska

        If TextBoxKorisnickoIme.Text = "" Then
            MessageBox.Show("Unesite korisničko ime.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf TextBoxLozinka.Text = "" Then
            MessageBox.Show("Unesite lozinku.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            'Ukoliko je sve u redu otvaramo konekciju 

            Con.Open()

            'U skladu sa unesenim vrijednostima provjerimo u bazi koji zaposleni je unesen

            Dim upit = "SELECT * FROM Zaposleni WHERE KorisnickoIme='" & TextBoxKorisnickoIme.Text & "' AND ZaposleniPass='" & TextBoxLozinka.Text & "'"

            'SqlCommand - inicijalizacija unijetog upita

            Dim sqlKomanda As SqlCommand
            sqlKomanda = New SqlCommand(upit, Con)

            'Adapter - sluzi za popunjavanje DataSeta, u skladu sa unesenim podacima

            Dim adapter As SqlDataAdapter = New SqlDataAdapter(sqlKomanda)
            Dim ds = New DataSet()
            adapter.Fill(ds)

            'Deklaracija varijable

            Dim a As Integer
            'Brojac redova nakon unosa

            a = ds.Tables(0).Rows.Count

            'Ispis greske ako je nesto od unijetog pogresno

            If a = 0 Then
                MessageBox.Show("Pogrešno koriničko ime ili lozinka.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else

                'Ako je sve u redu otvaraju nam se letovi

                Dim leto = New Letovi
                'Prikaz imena zaposlenog na formi letovi

                leto.imeZaposlenog = TextBoxKorisnickoIme.Text

                'Prikaz forme letovi

                leto.Show()

                ' "Sakrijemo" login formu

                Me.Hide()
            End If
            'Zatvorimo trenutnu konekciju
            Con.Close()
        End If
    End Sub

    'Ukoliko izaberemo NastaviKaoAdmin imamo mogucnost dodavanja, izmjene i brisanja zaposlenih
    Private Sub LabelNastaviKaoAdmin_Click(sender As Object, e As EventArgs) Handles LabelNastaviKaoAdmin.Click
        Dim zapos = New Zaposleni
        zapos.Show()
        Me.Hide()
    End Sub

    'Event MouseHover - Kada nanesemo mis na labelu promjeni se boja u "Crimson"
    Private Sub LabelNastaviKaoAdmin_MouseHover(sender As Object, e As EventArgs) Handles LabelNastaviKaoAdmin.MouseHover
        LabelNastaviKaoAdmin.ForeColor = System.Drawing.Color.Crimson
    End Sub

    'Event MouseLeave - Kada sklonemo mis sa labele moja se vrati u pocetnu (MidnightBlue)
    Private Sub LabelNastaviKaoAdmin_MouseLeave(sender As Object, e As EventArgs) Handles LabelNastaviKaoAdmin.MouseLeave
        LabelNastaviKaoAdmin.ForeColor = System.Drawing.Color.MidnightBlue
    End Sub

    'Dugme izlaz - koje zatvara sve forme i izlazi iz aplikacije
    Private Sub ButtonIzlaz_Click(sender As Object, e As EventArgs) Handles ButtonIzlaz.Click
        Me.Close()
        Form1.Close()
        Letovi.Close()
        Putnici.Close()
        Rezervacija.Close()
        Zaposleni.Close()
    End Sub
End Class
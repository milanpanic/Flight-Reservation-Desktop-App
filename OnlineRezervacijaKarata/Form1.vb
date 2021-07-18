Public Class Form1

    'Timer koji omogucava punjenje ProgressBara u zadanom intervalu
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        'ProgressBar koji se ucitava, tako sto se uvecava za 5

        ProgressBarUcitavanje.Increment(5)

        'Labela koja prikazuje procente (%)

        LabelUcitavanje.Text = ProgressBarUcitavanje.Value & " %"

        'Kad se ProgressBar ucita do 100, prikazujemo drugu formu Login
        'Onemogucimo Timer po zavrsetku
        If ProgressBarUcitavanje.Value = 100 Then
            Me.Hide()
            Dim log = New Login
            log.Show()
            Timer1.Enabled = False

        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Prilikom pokretanja aplikacije pokrenemo Timer
        Timer1.Start()
    End Sub
End Class

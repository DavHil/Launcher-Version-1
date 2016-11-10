Public Class Form1

    Dim titel As String = "Launcher"

    Dim G As Graphics
    Dim MyFont = New Font("Arial", 10)
    Dim MyPen = New Pen(Brushes.White, 3)

    Dim PB_Schliessen As New PictureBox
    Dim PB_Minimieren As New PictureBox
    Dim PB_News As New PictureBox
    Dim PB_Spieler_Online As New PictureBox
    Dim PB_Homepage As New PictureBox
    Dim PB_Spiel_Starten As New PictureBox
    Dim PB_Spenden As New PictureBox


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Verzeichnis.Spielpfad_erstellen()
        With Me
            .FormBorderStyle = FormBorderStyle.None
            .Width = Datenbank.Launcher_Breite
            .Height = Datenbank.Launcher_Höhe
            .BackColor = Datenbank.Launcher_Hintergrundfarbe
            .ForeColor = Datenbank.Launcher_Schriftfarbe
            .Text = titel
            .ControlBox = False
            .MaximizeBox = False
            .MinimizeBox = False
            .BackgroundImage = Datenbank.Launcher_Hintergrundgrafik
            .AutoSizeMode = AutoSizeMode.GrowAndShrink
            .StartPosition = FormStartPosition.CenterScreen
            .WindowState = FormWindowState.Normal
            '.Icon = My.Resources
        End With
        If Datenbank.Launcher_Musik_Modus = True Then
            My.Computer.Audio.Play(Datenbank.Spiel_Pfad & Datenbank.Spiel_Pfad_Spiel & "/sounds/" & Datenbank.Launcher_Titel_Song & ".wav", AudioPlayMode.BackgroundLoop)
        Else
            My.Computer.Audio.Stop()
        End If
        init()
    End Sub

    Private Sub init()
        PB_Schliessen_Erstellen()
        PB_Minimieren_Erstellen()
        PB_News_Erstellen()
        PB_Spieler_Online_Erstellen()
        PB_Homepage_Erstellen()
        PB_Spiel_Starten_Erstellen()
        PB_Spenden_Erstellen()
    End Sub

#Region "Launcher Überschrift"
    Private Sub Launcher_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint

        G = e.Graphics

        With G
            .DrawString(Datenbank.Launcher_Titel, MyFont, Brushes.White, 25, 25)
            .DrawString(Datenbank.Spiel_Version, MyFont, Brushes.White, 600, 25)
            .DrawString("Dieser Launcher wurde von DavHil Enterprise entwickelt", MyFont, Brushes.White, 250, 575)
        End With

        With e.Graphics
            .SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
            .TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias
            .PixelOffsetMode = Drawing2D.PixelOffsetMode.HighQuality
            .InterpolationMode = Drawing2D.InterpolationMode.HighQualityBilinear
            .CompositingQuality = Drawing2D.CompositingQuality.HighQuality
        End With

    End Sub
#End Region

#Region "PB_Schliessen"
    Private Sub PB_Schliessen_Erstellen()
        With PB_Schliessen
            .Location = New Point(750, 8)
            .Size = Datenbank.Launcher_Windows_Buttons
            .Image = My.Resources.wButton_Schliessen_op
        End With
        AddHandler PB_Schliessen.Click, AddressOf PB_Schliessen_Click
        AddHandler PB_Schliessen.MouseEnter, AddressOf PB_Schliessen_MouseEnter
        AddHandler PB_Schliessen.MouseLeave, AddressOf PB_Schliessen_MouseLeave
        Controls.Add(PB_Schliessen)
        PB_Schliessen.Parent = Me
    End Sub

    Private Sub PB_Schliessen_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub
    Private Sub PB_Schliessen_MouseEnter(sender As Object, e As EventArgs)
        PB_Schliessen.Image = My.Resources.wButton_Schliessen_mp
    End Sub

    Private Sub PB_Schliessen_MouseLeave(sender As System.Object, e As System.EventArgs)
        PB_Schliessen.Parent = Me
        PB_Schliessen.Image = My.Resources.wButton_Schliessen_op
    End Sub
#End Region

#Region "PB_Mini"
    Private Sub PB_Minimieren_Erstellen()
        With PB_Minimieren
            .Location = New Point(705, 8)
            .Size = Datenbank.Launcher_Windows_Buttons
            .Image = My.Resources.wButton_Mini_op
        End With
        AddHandler PB_Minimieren.Click, AddressOf PB_Minimieren_Click
        AddHandler PB_Minimieren.MouseEnter, AddressOf PB_Minimieren_MouseEnter
        AddHandler PB_Minimieren.MouseLeave, AddressOf PB_Minimieren_MouseLeave
        Controls.Add(PB_Minimieren)
        PB_Minimieren.Parent = Me
    End Sub

    Private Sub PB_Minimieren_Click(sender As Object, e As EventArgs)
        WindowState = FormWindowState.Minimized
    End Sub
    Private Sub PB_Minimieren_MouseEnter(sender As Object, e As EventArgs)
        PB_Minimieren.Image = My.Resources.wButton_Mini_mp
    End Sub

    Private Sub PB_Minimieren_MouseLeave(sender As System.Object, e As System.EventArgs)
        PB_Minimieren.Parent = Me
        PB_Minimieren.Image = My.Resources.wButton_Mini_op
    End Sub
#End Region

#Region "PB_News"
    Private Sub PB_News_Erstellen()
        With PB_News
            .Location = New Point(0, 70)
            .Size = Datenbank.Launcher_News
            .Image = My.Resources.Background_Aktuelle_News
        End With
        AddHandler PB_News.Click, AddressOf PB_News_Click
        Controls.Add(PB_News)
        PB_News.Parent = Me
    End Sub

    Private Sub PB_News_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "PB_Spieler_Online"
    Private Sub PB_Spieler_Online_Erstellen()
        With PB_Spieler_Online
            .Location = New Point(449, 70)
            .Size = Datenbank.Launcher_Spieler_Online
            .Image = My.Resources.Background_Spieler_Online
        End With
        AddHandler PB_Spieler_Online.Click, AddressOf PB_Spieler_Online_Click
        Controls.Add(PB_Spieler_Online)
        PB_Spieler_Online.Parent = Me
    End Sub

    Private Sub PB_Spieler_Online_Click(sender As Object, e As EventArgs)

    End Sub
#End Region

#Region "PB_Homepage"
    Private Sub PB_Homepage_Erstellen()
        With PB_Homepage
            .Location = New Point(35, 490)
            .Size = Datenbank.Launcher_Homepage_Button
            .Image = My.Resources.Button_Homepage_op
        End With
        AddHandler PB_Homepage.Click, AddressOf PB_Homepage_Click
        AddHandler PB_Homepage.MouseEnter, AddressOf PB_Homepage_MouseEnter
        AddHandler PB_Homepage.MouseLeave, AddressOf PB_Homepage_MouseLeave
        Controls.Add(PB_Homepage)
        PB_Homepage.Parent = Me
    End Sub

    Private Sub PB_Homepage_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub PB_Homepage_MouseEnter(sender As Object, e As EventArgs)
        PB_Homepage.Image = My.Resources.Button_Homepage_mp
    End Sub

    Private Sub PB_Homepage_MouseLeave(sender As System.Object, e As System.EventArgs)
        PB_Homepage.Parent = Me
        PB_Homepage.Image = My.Resources.Button_Homepage_op
    End Sub
#End Region

#Region "PB_Spiel_Starten"
    Private Sub PB_Spiel_Starten_Erstellen()
        With PB_Spiel_Starten
            .Location = New Point(295, 490)
            .Size = Datenbank.Launcher_Spiel_Starten_Button
            .Image = My.Resources.Button_Spielen_op
        End With
        AddHandler PB_Spiel_Starten.Click, AddressOf PB_Spiel_Starten_Click
        AddHandler PB_Spiel_Starten.MouseEnter, AddressOf PB_Spiel_Starten_MouseEnter
        AddHandler PB_Spiel_Starten.MouseLeave, AddressOf PB_Spiel_Starten_MouseLeave
        Controls.Add(PB_Spiel_Starten)
        PB_Spiel_Starten.Parent = Me
    End Sub

    Private Sub PB_Spiel_Starten_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub PB_Spiel_Starten_MouseEnter(sender As Object, e As EventArgs)
        PB_Spiel_Starten.Image = My.Resources.Button_Spielen_mp
    End Sub

    Private Sub PB_Spiel_Starten_MouseLeave(sender As System.Object, e As System.EventArgs)
        PB_Spiel_Starten.Parent = Me
        PB_Spiel_Starten.Image = My.Resources.Button_Spielen_op
    End Sub
#End Region

#Region "PB_Spenden"
    Private Sub PB_Spenden_Erstellen()
        With PB_Spenden
            .Location = New Point(555, 490)
            .Size = Datenbank.Launcher_Spenden_Button
            .Image = My.Resources.Button_Spenden_op
        End With
        AddHandler PB_Spenden.Click, AddressOf PB_Spenden_Click
        AddHandler PB_Spenden.MouseEnter, AddressOf PB_Spenden_MouseEnter
        AddHandler PB_Spenden.MouseLeave, AddressOf PB_Spenden_MouseLeave
        Controls.Add(PB_Spenden)
        PB_Spenden.Parent = Me
    End Sub

    Private Sub PB_Spenden_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub PB_Spenden_MouseEnter(sender As Object, e As EventArgs)
        PB_Spenden.Image = My.Resources.Button_Spenden_mp
    End Sub

    Private Sub PB_Spenden_MouseLeave(sender As System.Object, e As System.EventArgs)
        PB_Spenden.Parent = Me
        PB_Spenden.Image = My.Resources.Button_Spenden_op
    End Sub
#End Region
End Class



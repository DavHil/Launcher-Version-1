Module Datenbank 'Dies ist die Datenbank des Spiels

    'Spiel Einstellungen
    Public Spiel_Name As String = "Spiele_Name"
    Public Spiel_Inhaber As String = "David Hilberath"
    Public Spiel_Coder As String = "David Hilberath"
    Public Spiel_Email As String = "info@DavHil.de"
    Public Spiel_Webseite As String = "http://DavHil.de"
    Public Spiel_Pfad As String = "C:\"
    Public Spiel_Pfad_Spiel As String = "\" & Datenbank.Spiel_Name & "\"
    Public Spiel_Version As String = String.Format("Version {0}.{1: 00}", My.Application.Info.Version.Major, My.Application.Info.Version.Minor)
    Public Spiel_Version_Status As String = "Alpha" 'Alpha | Beta | Release
    Public Spiel_Debug_Modus As Boolean = False
    Public Spiel_Vollbild As Boolean = False
    Public Spiel_Fenstervollbild As Boolean = True
    Public Spiel_Fenster As Boolean = False
    Public Spiel_FensterModus As String = "" 'Volldbild | Vollbild-Fenster | Fenster
    Public Spiel_Hintergrundfarbe As Color = Color.Peru
    Public Spiel_Schriftfarbe As Color = Color.Black
    Public Spiel_Sounds As Boolean = False
    Public Spiel_Musik As Boolean = False

    'Launcher Einstellungen
    Public Launcher_Titel As String = Datenbank.Spiel_Name & " - Launcher"
    Public Launcher_Breite As Integer = 800
    Public Launcher_Höhe As Integer = 600
    Public Launcher_Hintergrundgrafik = My.Resources.Launcher
    Public Launcher_Hintergrundfarbe As Color = Color.Black
    Public Launcher_Schriftfarbe As Color = Color.White
    Public Launcher_Musik_Modus As Boolean = False
    Public Launcher_Titel_Song As String = "Launcher_Title_Screen"
    Public Launcher_Windows_Buttons = New Size(37, 38)
    Public Launcher_News = New Size(351, 326)
    Public Launcher_Spieler_Online = New Size(351, 326)
    Public Launcher_Homepage_Button = New Size(201, 60)
    Public Launcher_Spiel_Starten_Button = New Size(201, 60)
    Public Launcher_Spenden_Button = New Size(201, 60)

End Module



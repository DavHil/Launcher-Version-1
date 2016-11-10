Module Verzeichnis
    Public Sub Spielpfad_erstellen()

        With My.Computer.FileSystem
            .CreateDirectory(Datenbank.Spiel_Pfad & Datenbank.Spiel_Pfad_Spiel & "/setting")
            .CreateDirectory(Datenbank.Spiel_Pfad & Datenbank.Spiel_Pfad_Spiel & "/sounds")
            .CreateDirectory(Datenbank.Spiel_Pfad & Datenbank.Spiel_Pfad_Spiel & "/temp")
            .CreateDirectory(Datenbank.Spiel_Pfad & Datenbank.Spiel_Pfad_Spiel & "/texture")
        End With

    End Sub
End Module

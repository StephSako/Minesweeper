Imports System.Configuration
Imports System.IO

Module ScoresFile

    Dim scores() As Double

    Sub WriteLogFile(ByVal Message As String)

        Dim sw As StreamWriter
        sw = File.AppendText(".\scores\" & Form1.niveauDifficulté & ".txt") ' On ouvre pour écrire à la fin du fichier

        sw.WriteLine(Message) ' On écrit le message
        sw.Flush() ' On efface les mémoires tampons
        sw.Close() ' On ferme le fichier des scores
    End Sub

    Public Sub resetLogFile()
        On Error GoTo erreur

        My.Computer.FileSystem.DeleteFile(".\scores\" & Form1.niveauDifficulté & ".txt") ' On supprime le fichier texte
        Dim fs As FileStream = File.Create(".\scores\" & Form1.niveauDifficulté & ".txt") ' On créé le fichier
        fs.Flush() ' On efface les mémoires tampons
        fs.Close() ' On ferme le fichier des scores

erreur:
        If Err.Number <> 0 Then
            MsgBox("Une erreur est survenue dans la sauvegarde du score.")
            Exit Sub
        End If
    End Sub

    Sub mountScores()
        Dim nb As Integer = 0
        Dim monStreamReader As New StreamReader(".\scores\" & Form1.niveauDifficulté & ".txt") 'Stream pour la lecture
        Dim ligne As String ' Variable contenant le texte de la ligne
        Do
            ligne = monStreamReader.ReadLine
            If Not ligne Is Nothing Then
                ReDim Preserve scores(nb)
                scores(nb) = CDbl(ligne)
                nb = nb + 1
            End If
        Loop Until ligne Is Nothing
        If Not scores Is Nothing Then
            Array.Sort(scores)
            For i = UBound(scores) To 0 Step -1
                ScoresAffiche.ListBoxScores.Items.Add(CStr(scores(i)))
            Next
        End If

        monStreamReader.Close()
    End Sub

End Module
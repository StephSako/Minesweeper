Public Class Form1

    Public x As Integer
    Public y As Integer
    Public grille(x, y) As String
    Public nbMine As Integer = 0
    Public NombreDeMines As Integer
    Public nbBombesTemp As Integer = NombreDeMines
    Public nbSecondes As Integer = 0, nbDixSec As Integer = 0, nbMilleSec As Integer = 0
    Public fin As Boolean
    Public niveauDifficulté As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PanelScore.BackColor = System.Drawing.SystemColors.Control
        Me.Enabled = False
        Difficulté.Visible = True
        LabelBombes.Text = NombreDeMines
        fin = False
        ButtonRetry.Image = New Bitmap(".\content.jpg")
    End Sub

    ' Evenement lors du click sur un bouton de la grille
    Public Sub btnGrile_Click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        If fin = False Then
            If sender.GetType.FullName <> "Minesweeper.Form1" Then
                TimerSec.Start()
                TimerDixSec.Start()
                TimerMilleSec.Start()
                Dim btn As Button
                btn = sender
                If MouseButtons = MouseButtons.Left Then
                    If btn.Image Is Nothing Then
                        ' On affiche la valeur du bouton si ce n'est pas une bombe
                        If grille(Strings.Left(Strings.Right(btn.Name, 5).ToString, 2).ToString, Strings.Right(btn.Name, 2).ToString) <> "*" Then
                            formatCase(btn)
                            verifVideAutour(btn)
                        Else ' J'ai perdu ...
                            PanelScore.BackColor = Color.Red
                            init_timer() ' On arrête les chronomètres
                            ButtonRetry.Image = New Bitmap("./triste.png")
                            afficherGrille()
                            fin = True
                        End If
                        btn.FlatStyle = FlatStyle.Standard
                    End If
                ElseIf MouseButtons = MouseButtons.Right Then
                    If btn.BackColor <> Color.White Then
                        If btn.Image Is Nothing Then
                            If nbBombesTemp > 0 Then
                                nbBombesTemp = nbBombesTemp - 1
                                LabelBombes.Text = nbBombesTemp
                                btn.FlatStyle = FlatStyle.Flat
                                btn.Image = New Bitmap(".\flag.png")
                                btn.ImageAlign = ContentAlignment.MiddleCenter
                                verifVictoire()
                            End If
                        Else
                            If nbBombesTemp < NombreDeMines Then
                                nbBombesTemp = nbBombesTemp + 1
                                LabelBombes.Text = nbBombesTemp
                                btn.FlatStyle = FlatStyle.Standard
                                btn.Image.Dispose()
                                btn.Image = Nothing
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub construireGrille()
        Dim n, m As Integer
        Dim random As New Random

        For i = 0 To NombreDeMines - 1
            n = random.Next(0, x)
            m = random.Next(0, y)
            If grille(n, m) <> "*" Then
                grille(n, m) = "*"
            Else
                i = i - 1
            End If
        Next

        ' Formation des nombres
        For i = 0 To x
            For j = 0 To y
                ' S'il ne s'agit pas déjà d'une bombe
                If grille(i, j) <> "*" Then
                    If i > 0 Then
                        If grille(i - 1, j) = "*" Then
                            nbMine = nbMine + 1
                        End If
                    End If

                    If i > 0 And j < y Then
                        If grille(i - 1, j + 1) = "*" Then
                            nbMine = nbMine + 1
                        End If
                    End If

                    If i > 0 And j > 0 Then
                        If grille(i - 1, j - 1) = "*" Then
                            nbMine = nbMine + 1
                        End If
                    End If

                    If i < x And j < y Then
                        If grille(i + 1, j + 1) = "*" Then
                            nbMine = nbMine + 1
                        End If
                    End If

                    If i < x Then
                        If grille(i + 1, j) = "*" Then
                            nbMine = nbMine + 1
                        End If
                    End If

                    If i < x And j > 0 Then
                        If grille(i + 1, j - 1) = "*" Then
                            nbMine = nbMine + 1
                        End If
                    End If

                    If j > 0 Then
                        If grille(i, j - 1) = "*" Then
                            nbMine = nbMine + 1
                        End If
                    End If

                    If j < y Then
                        If grille(i, j + 1) = "*" Then
                            nbMine = nbMine + 1
                        End If
                    End If
                    grille(i, j) = nbMine.ToString
                End If
                nbMine = 0
            Next
        Next
    End Sub

    Public Sub FormerGrille()
        init_timer()
        construireGrille()
        Dim positionX As Integer = 43
        Dim positionY As Integer = 117
        ' Formation de la grille de boutons
        For i = 0 To x
            For j = 0 To y
                Dim btnGrille As New Button
                If i <= 9 And j <= 9 Then
                    btnGrille.Name = "BtnGrille0" & i & ",0" & j
                ElseIf i <= 9 Then
                    btnGrille.Name = "BtnGrille0" & i & "," & j
                ElseIf j <= 9 Then
                    btnGrille.Name = "BtnGrille" & i & ",0" & j
                Else
                    btnGrille.Name = "BtnGrille" & i & "," & j
                End If
                Me.Controls.Add(btnGrille)
                ' On définit la position et la taille du bouton
                btnGrille.Location = New System.Drawing.Point(positionX, positionY)
                btnGrille.Size = New Size(25, 25)
                AddHandler btnGrille.MouseDown, AddressOf btnGrile_Click
                If j = y Then
                    positionY = 117
                Else
                    positionY = positionY + 25
                End If
            Next
            positionX = positionX + 25
        Next
    End Sub

    Public Sub afficherGrille()
        Dim btn As Button, ch As String = ""
        For i = 0 To x
            For j = 0 To y
                If i <= 9 And j <= 9 Then
                    ch = "BtnGrille0" & i & ",0" & j
                ElseIf i <= 9 Then
                    ch = "BtnGrille0" & i & "," & j
                ElseIf j <= 9 Then
                    ch = "BtnGrille" & i & ",0" & j
                Else
                    ch = "BtnGrille" & i & "," & j
                End If
                For Each ctrl In Me.Controls
                    If ctrl.Name.contains(ch) And ctrl.GetType.FullName = "System.Windows.Forms.Button" Then
                        btn = ctrl
                        If btn.BackColor <> Color.White And btn.Image Is Nothing Then
                            If grille(Strings.Left(Strings.Right(btn.Name, 5).ToString, 2).ToString, Strings.Right(btn.Name, 2).ToString) = "*" Then ' Si le bouton n'est pas une bombe
                                btn.Image = New Bitmap(".\bomb.png")
                                btn.ImageAlign = ContentAlignment.MiddleCenter
                                btn.FlatStyle = FlatStyle.Flat
                            Else
                                formatCase(btn)
                            End If
                            Exit For
                        ElseIf Not btn.Image Is Nothing And grille(Strings.Left(Strings.Right(btn.Name, 5).ToString, 2).ToString, Strings.Right(btn.Name, 2).ToString) <> "*" Then
                            btn.Image.Dispose()
                            btn.Image = Nothing
                            formatCase(btn)
                        End If
                    End If
                Next
            Next
        Next
    End Sub

    Public Sub deleteAllButtons()
        ' On recherche tous les boutons à supprimer
        Dim nb As Integer = 0
        Dim btn As Button
        For i = 0 To x
            For j = 0 To y
                For Each ctrl In Me.Controls
                    If ctrl.Name.Contains("BtnGrille") And ctrl.GetType.FullName = "System.Windows.Forms.Button" Then
                        btn = ctrl
                        Me.Controls.Remove(btn)
                        nb = nb + 1
                        Exit For
                    End If
                Next
            Next
        Next
    End Sub

    Private Sub ButtonRetry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRetry.Click
        ' On remet la grille à zéro
        For i = 0 To x
            For j = 0 To y
                grille(i, j) = ""
            Next
        Next
        PanelScore.BackColor = System.Drawing.SystemColors.Control
        ButtonRetry.Image = New Bitmap("./content.jpg")
        deleteAllButtons()
        FormerGrille()
        LabelTemps.Text = nbSecondes & "," & nbDixSec & nbMilleSec
        nbBombesTemp = NombreDeMines
        LabelBombes.Text = NombreDeMines
        fin = False
    End Sub

    Private Sub TimerSec_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerSec.Tick
        LabelTemps.Text = nbSecondes & "," & nbDixSec & nbMilleSec
        nbSecondes = nbSecondes + 1
    End Sub

    Private Sub TimerMilleSec_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerMilleSec.Tick
        LabelTemps.Text = nbSecondes & "," & nbDixSec & nbMilleSec
        nbMilleSec = nbMilleSec + 1
        If nbMilleSec = 9 Then
            nbMilleSec = 0
        End If
    End Sub

    Private Sub TimerDixSec_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerDixSec.Tick
        LabelTemps.Text = nbSecondes & "," & nbDixSec & nbMilleSec
        nbDixSec = nbDixSec + 1
        If nbDixSec = 9 Then
            nbDixSec = 0
        End If
    End Sub

    Public Sub init_timer()
        ' On arrête les chronomètres
        TimerSec.Stop()
        TimerDixSec.Stop()
        TimerMilleSec.Stop()
        nbDixSec = 0
        nbMilleSec = 0
        nbSecondes = 0
    End Sub

    Public Sub verifVideAutour(ByVal btn As Button)
        ' Si la case cliquée est une case vide
        If grille(Strings.Left(Strings.Right(btn.Name, 5).ToString, 2).ToString, Strings.Right(btn.Name, 2).ToString) = "0" Then

            If CInt(Strings.Left(Strings.Right(btn.Name, 5), 2) - 1) >= 0 And CInt(Strings.Right(btn.Name, 2) - 1) >= 0 Then
                recursivite(CInt(Strings.Left(Strings.Right(btn.Name, 5), 2) - 1), CInt(Strings.Right(btn.Name, 2) - 1))
            End If

            If CInt(Strings.Left(Strings.Right(btn.Name, 5), 2) + 1) <= x And CInt(Strings.Right(btn.Name, 2) + 1) <= y Then
                recursivite(CInt(Strings.Left(Strings.Right(btn.Name, 5), 2) + 1), CInt(Strings.Right(btn.Name, 2) + 1))
            End If

            If CInt(Strings.Left(Strings.Right(btn.Name, 5), 2) + 1) <= x Then
                recursivite(CInt(Strings.Left(Strings.Right(btn.Name, 5), 2) + 1), CInt(Strings.Right(btn.Name, 2)))
            End If

            If CInt(Strings.Right(btn.Name, 2) + 1) <= y Then
                recursivite(CInt(Strings.Left(Strings.Right(btn.Name, 5), 2)), CInt(Strings.Right(btn.Name, 2) + 1))
            End If

            If CInt(Strings.Right(btn.Name, 2) - 1) >= 0 Then
                recursivite(CInt(Strings.Left(Strings.Right(btn.Name, 5), 2)), CInt(Strings.Right(btn.Name, 2) - 1))
            End If

            If CInt(Strings.Left(Strings.Right(btn.Name, 5), 2) - 1) >= 0 Then
                recursivite(CInt(Strings.Left(Strings.Right(btn.Name, 5), 2) - 1), CInt(Strings.Right(btn.Name, 2)))
            End If

            If CInt(Strings.Left(Strings.Right(btn.Name, 5), 2) + 1) <= x And CInt(Strings.Right(btn.Name, 2) - 1) >= 0 Then
                recursivite(CInt(Strings.Left(Strings.Right(btn.Name, 5), 2) + 1), CInt(Strings.Right(btn.Name, 2) - 1))
            End If

            If CInt(Strings.Left(Strings.Right(btn.Name, 5), 2) - 1) >= 0 And CInt(Strings.Right(btn.Name, 2) + 1) <= y Then
                recursivite(CInt(Strings.Left(Strings.Right(btn.Name, 5), 2) - 1), CInt(Strings.Right(btn.Name, 2) + 1))
            End If
        End If
    End Sub

    Public Sub formatCase(ByVal btn As Button)
        btn.FlatStyle = FlatStyle.Standard
        btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9, FontStyle.Bold)
        btn.BackColor = Color.White
        Dim colorInd As String = grille(CInt(Strings.Left(Strings.Right(btn.Name, 5), 2)), CInt(Strings.Right(btn.Name, 2)))
        If colorInd <> "0" Then
            btn.Text = colorInd
        End If
        ' Mettons de la couleur
        If colorInd = "1" Then
            btn.ForeColor = Color.Blue
        ElseIf colorInd = "2" Then
            btn.ForeColor = Color.Green
        ElseIf colorInd = "3" Then
            btn.ForeColor = Color.Red
        ElseIf colorInd = "4" Then
            btn.ForeColor = Color.DarkBlue
        ElseIf colorInd = "5" Then
            btn.ForeColor = Color.Brown
        ElseIf colorInd = "6" Then
            btn.ForeColor = Color.Purple
        ElseIf colorInd = "7" Then
            btn.ForeColor = Color.Orange
        ElseIf colorInd = "8" Then
            btn.ForeColor = Color.Magenta
        Else
            btn.ForeColor = Color.Black
        End If
    End Sub

    Public Sub recursivite(ByVal i As Integer, ByVal j As Integer)
        ' Vérification sur le fait qu'il ne s'agisse pas d'un bouton se trouvant sur la diagonale (i et j impliqués)
        Dim chbtn As String
        If i <= 9 And j <= 9 Then
            chbtn = "BtnGrille0" & i & ",0" & j
        ElseIf i <= 9 Then
            chbtn = "BtnGrille0" & i & "," & j
        ElseIf j <= 9 Then
            chbtn = "BtnGrille" & i & ",0" & j
        Else
            chbtn = "BtnGrille" & i & "," & j
        End If
        Dim btnVerif As Button
        For Each ctrl In Me.Controls
            If ctrl.name = chbtn And ctrl.GetType.FullName = "System.Windows.Forms.Button" Then
                btnVerif = ctrl
                If btnVerif.BackColor <> Color.White Then
                    If grille(i, j) = "0" Then
                        btnVerif.FlatStyle = FlatStyle.Standard
                        btnVerif.BackColor = Color.White
                        ' Récursivité sur la vérification du prochain bouton
                        verifVideAutour(btnVerif)
                    Else
                        formatCase(btnVerif)
                    End If
                    Exit For
                End If
            End If
        Next
    End Sub

    Public Sub verifVictoire()
        Dim allBombsFinded As Boolean = False, btn As Button, nbBombsFinded As Integer = 0
        For Each ctrl In Me.Controls
            If ctrl.Name.Contains("BtnGrille") And ctrl.GetType.FullName = "System.Windows.Forms.Button" Then
                btn = ctrl
                If grille(CInt(Strings.Left(Strings.Right(btn.Name, 5), 2)), CInt(Strings.Right(btn.Name, 2))) = "*" _
                    And Not btn.Image Is Nothing Then ' Si le bouton a été marquée et qu'il s'agit bien d'une bombe
                    nbBombsFinded = nbBombsFinded + 1
                    If nbBombsFinded = NombreDeMines Then
                        PanelScore.BackColor = Color.Lime
                        ButtonRetry.Image = New Bitmap("./heureux.png")
                        fin = True
                        afficherGrille()
                        init_timer()
                        ScoresFile.WriteLogFile(LabelTemps.Text)
                        Exit For
                    End If
                End If
            End If
        Next
    End Sub

    Private Sub ButtonScores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonScores.Click
        Me.Enabled = False
        mountScores()
        ScoresAffiche.Show()
        ScoresAffiche.LabelDifficulté.Text = niveauDifficulté
    End Sub
End Class
Public Class Difficulté

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBoxDifficulté.SelectedIndex <> -1 Then
            If ComboBoxDifficulté.SelectedItem.ToString = "Debutant" Then
                Form1.x = 9
                Form1.y = 9
                Form1.NombreDeMines = 10
                Form1.nbBombesTemp = Form1.NombreDeMines
                Form1.Size = New Size(355, 422)
            ElseIf ComboBoxDifficulté.SelectedItem.ToString = "Intermediaire" Then
                Form1.x = 14
                Form1.y = 14
                Form1.NombreDeMines = 20
                Form1.nbBombesTemp = Form1.NombreDeMines
                Form1.Size = New Size(480, 580)
            ElseIf ComboBoxDifficulté.SelectedItem.ToString = "Expert" Then
                Form1.x = 19
                Form1.y = 19
                Form1.NombreDeMines = 30
                Form1.nbBombesTemp = Form1.NombreDeMines
                Form1.Size = New Size(605, 710)
            ElseIf ComboBoxDifficulté.SelectedItem.ToString = "Maitre" Then
                Form1.x = 29
                Form1.y = 19
                Form1.NombreDeMines = 40
                Form1.nbBombesTemp = Form1.NombreDeMines
                Form1.Size = New Size(870, 710)
            ElseIf ComboBoxDifficulté.SelectedItem.ToString = "Ninja" Then
                Form1.x = 34
                Form1.y = 19
                Form1.NombreDeMines = 50
                Form1.nbBombesTemp = Form1.NombreDeMines
                Form1.Size = New Size(995, 710)
            End If

            ReDim Form1.grille(Form1.x, Form1.y)

            Form1.niveauDifficulté = ComboBoxDifficulté.SelectedItem.ToString
            Form1.LabelBombes.Text = Form1.NombreDeMines
            Form1.Enabled = True
            Form1.Visible = True
            Form1.FormerGrille()
            Me.Close()
        End If
    End Sub

    Private Sub Difficulté_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TopMost = True
        Form1.Visible = False
    End Sub
End Class
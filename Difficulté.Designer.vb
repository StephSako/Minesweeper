<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Difficulté
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Difficulté))
        Me.ComboBoxDifficulté = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ComboBoxDifficulté
        '
        Me.ComboBoxDifficulté.FormattingEnabled = True
        Me.ComboBoxDifficulté.Items.AddRange(New Object() {"Debutant", "Intermediaire", "Expert", "Maitre", "Ninja"})
        Me.ComboBoxDifficulté.Location = New System.Drawing.Point(50, 12)
        Me.ComboBoxDifficulté.Name = "ComboBoxDifficulté"
        Me.ComboBoxDifficulté.Size = New System.Drawing.Size(143, 21)
        Me.ComboBoxDifficulté.TabIndex = 0
        Me.ComboBoxDifficulté.Text = "Choisissez votre difficulté"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(83, 39)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Valider"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Difficulté
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(245, 72)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBoxDifficulté)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Difficulté"
        Me.Text = "Choix de la difficulté"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ComboBoxDifficulté As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScoresAffiche
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ScoresAffiche))
        Me.ListBoxScores = New System.Windows.Forms.ListBox()
        Me.LabelDifficulté = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListBoxScores
        '
        Me.ListBoxScores.FormattingEnabled = True
        Me.ListBoxScores.Location = New System.Drawing.Point(13, 42)
        Me.ListBoxScores.Name = "ListBoxScores"
        Me.ListBoxScores.Size = New System.Drawing.Size(120, 108)
        Me.ListBoxScores.TabIndex = 0
        '
        'LabelDifficulté
        '
        Me.LabelDifficulté.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDifficulté.Location = New System.Drawing.Point(13, 13)
        Me.LabelDifficulté.Name = "LabelDifficulté"
        Me.LabelDifficulté.Size = New System.Drawing.Size(120, 23)
        Me.LabelDifficulté.TabIndex = 1
        Me.LabelDifficulté.Text = "LabelDifficulté"
        Me.LabelDifficulté.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ScoresAffiche
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(148, 164)
        Me.Controls.Add(Me.LabelDifficulté)
        Me.Controls.Add(Me.ListBoxScores)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ScoresAffiche"
        Me.Text = "Scores"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListBoxScores As System.Windows.Forms.ListBox
    Friend WithEvents LabelDifficulté As System.Windows.Forms.Label
End Class

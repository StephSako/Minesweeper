<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelTemps = New System.Windows.Forms.Label()
        Me.LabelBombes = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PanelScore = New System.Windows.Forms.Panel()
        Me.ButtonRetry = New System.Windows.Forms.Button()
        Me.TimerSec = New System.Windows.Forms.Timer(Me.components)
        Me.TimerDixSec = New System.Windows.Forms.Timer(Me.components)
        Me.TimerMilleSec = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ButtonScores = New System.Windows.Forms.Button()
        Me.PanelScore.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(221, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 22)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Temps"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelTemps
        '
        Me.LabelTemps.BackColor = System.Drawing.SystemColors.Control
        Me.LabelTemps.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTemps.ForeColor = System.Drawing.Color.Red
        Me.LabelTemps.Location = New System.Drawing.Point(221, 33)
        Me.LabelTemps.Name = "LabelTemps"
        Me.LabelTemps.Size = New System.Drawing.Size(66, 22)
        Me.LabelTemps.TabIndex = 3
        Me.LabelTemps.Text = "0,00"
        Me.LabelTemps.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelBombes
        '
        Me.LabelBombes.BackColor = System.Drawing.SystemColors.Control
        Me.LabelBombes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBombes.ForeColor = System.Drawing.Color.Red
        Me.LabelBombes.Location = New System.Drawing.Point(24, 33)
        Me.LabelBombes.Name = "LabelBombes"
        Me.LabelBombes.Size = New System.Drawing.Size(68, 22)
        Me.LabelBombes.TabIndex = 5
        Me.LabelBombes.Text = "--"
        Me.LabelBombes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Bombes"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelScore
        '
        Me.PanelScore.BackColor = System.Drawing.SystemColors.Control
        Me.PanelScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelScore.Controls.Add(Me.LabelTemps)
        Me.PanelScore.Controls.Add(Me.ButtonRetry)
        Me.PanelScore.Controls.Add(Me.LabelBombes)
        Me.PanelScore.Controls.Add(Me.Label1)
        Me.PanelScore.Controls.Add(Me.Label4)
        Me.PanelScore.Location = New System.Drawing.Point(12, 12)
        Me.PanelScore.Name = "PanelScore"
        Me.PanelScore.Size = New System.Drawing.Size(315, 70)
        Me.PanelScore.TabIndex = 6
        '
        'ButtonRetry
        '
        Me.ButtonRetry.BackColor = System.Drawing.Color.White
        Me.ButtonRetry.FlatAppearance.BorderSize = 0
        Me.ButtonRetry.Image = Global.Minesweeper.My.Resources.Resources.content
        Me.ButtonRetry.Location = New System.Drawing.Point(138, 13)
        Me.ButtonRetry.Name = "ButtonRetry"
        Me.ButtonRetry.Size = New System.Drawing.Size(45, 45)
        Me.ButtonRetry.TabIndex = 8
        Me.ButtonRetry.UseVisualStyleBackColor = False
        '
        'TimerSec
        '
        Me.TimerSec.Interval = 1000
        '
        'TimerDixSec
        '
        '
        'TimerMilleSec
        '
        Me.TimerMilleSec.Interval = 10
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(42, 88)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Choisir Difficulté"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ButtonScores
        '
        Me.ButtonScores.Location = New System.Drawing.Point(206, 88)
        Me.ButtonScores.Name = "ButtonScores"
        Me.ButtonScores.Size = New System.Drawing.Size(95, 23)
        Me.ButtonScores.TabIndex = 10
        Me.ButtonScores.Text = "Voir Scores"
        Me.ButtonScores.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 383)
        Me.Controls.Add(Me.ButtonScores)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PanelScore)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Minesweeper"
        Me.PanelScore.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabelTemps As System.Windows.Forms.Label
    Friend WithEvents LabelBombes As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PanelScore As System.Windows.Forms.Panel
    Friend WithEvents ButtonRetry As System.Windows.Forms.Button
    Friend WithEvents TimerSec As System.Windows.Forms.Timer
    Friend WithEvents TimerDixSec As System.Windows.Forms.Timer
    Friend WithEvents TimerMilleSec As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ButtonScores As System.Windows.Forms.Button

End Class

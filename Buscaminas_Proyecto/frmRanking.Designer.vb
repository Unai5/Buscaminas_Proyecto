﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRanking
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblRanking = New System.Windows.Forms.Label()
        Me.lstRanking = New System.Windows.Forms.ListBox()
        Me.btnDificultad = New System.Windows.Forms.Button()
        Me.btnRankingIndividual = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblRanking
        '
        Me.lblRanking.AutoSize = True
        Me.lblRanking.Font = New System.Drawing.Font("Cooper Black", 12.0!)
        Me.lblRanking.Location = New System.Drawing.Point(225, 22)
        Me.lblRanking.Name = "lblRanking"
        Me.lblRanking.Size = New System.Drawing.Size(93, 19)
        Me.lblRanking.TabIndex = 4
        Me.lblRanking.Text = "RANKING"
        '
        'lstRanking
        '
        Me.lstRanking.FormattingEnabled = True
        Me.lstRanking.Location = New System.Drawing.Point(203, 74)
        Me.lstRanking.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lstRanking.Name = "lstRanking"
        Me.lstRanking.Size = New System.Drawing.Size(260, 277)
        Me.lstRanking.TabIndex = 5
        '
        'btnDificultad
        '
        Me.btnDificultad.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDificultad.Font = New System.Drawing.Font("Cooper Black", 12.0!)
        Me.btnDificultad.Location = New System.Drawing.Point(54, 153)
        Me.btnDificultad.Name = "btnDificultad"
        Me.btnDificultad.Size = New System.Drawing.Size(115, 38)
        Me.btnDificultad.TabIndex = 6
        Me.btnDificultad.Text = "Dificultad"
        Me.btnDificultad.UseVisualStyleBackColor = False
        '
        'btnRankingIndividual
        '
        Me.btnRankingIndividual.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRankingIndividual.Font = New System.Drawing.Font("Cooper Black", 12.0!)
        Me.btnRankingIndividual.Location = New System.Drawing.Point(54, 232)
        Me.btnRankingIndividual.Name = "btnRankingIndividual"
        Me.btnRankingIndividual.Size = New System.Drawing.Size(115, 38)
        Me.btnRankingIndividual.TabIndex = 7
        Me.btnRankingIndividual.Text = "Resultados"
        Me.btnRankingIndividual.UseVisualStyleBackColor = False
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnVolver.Font = New System.Drawing.Font("Cooper Black", 12.0!)
        Me.btnVolver.Location = New System.Drawing.Point(217, 386)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(109, 36)
        Me.btnVolver.TabIndex = 8
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'frmRanking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 450)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnRankingIndividual)
        Me.Controls.Add(Me.btnDificultad)
        Me.Controls.Add(Me.lstRanking)
        Me.Controls.Add(Me.lblRanking)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmRanking"
        Me.Text = "frmRanking"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblRanking As Label
    Friend WithEvents lstRanking As ListBox
    Friend WithEvents btnDificultad As Button
    Friend WithEvents btnRankingIndividual As Button
    Friend WithEvents btnVolver As Button
End Class

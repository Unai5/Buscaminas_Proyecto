<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.SuspendLayout()
        '
        'lblRanking
        '
        Me.lblRanking.AutoSize = True
        Me.lblRanking.Font = New System.Drawing.Font("Cooper Black", 12.0!)
        Me.lblRanking.Location = New System.Drawing.Point(333, 42)
        Me.lblRanking.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRanking.Name = "lblRanking"
        Me.lblRanking.Size = New System.Drawing.Size(118, 23)
        Me.lblRanking.TabIndex = 4
        Me.lblRanking.Text = "RANKING"
        '
        'lstRanking
        '
        Me.lstRanking.FormattingEnabled = True
        Me.lstRanking.ItemHeight = 16
        Me.lstRanking.Location = New System.Drawing.Point(222, 100)
        Me.lstRanking.Name = "lstRanking"
        Me.lstRanking.Size = New System.Drawing.Size(346, 340)
        Me.lstRanking.TabIndex = 5
        '
        'frmRanking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 586)
        Me.Controls.Add(Me.lstRanking)
        Me.Controls.Add(Me.lblRanking)
        Me.Name = "frmRanking"
        Me.Text = "frmRanking"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblRanking As Label
    Friend WithEvents lstRanking As ListBox
End Class

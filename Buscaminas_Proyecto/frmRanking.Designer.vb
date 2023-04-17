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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lblRanking
        '
        Me.lblRanking.AutoSize = True
        Me.lblRanking.Font = New System.Drawing.Font("Cooper Black", 12.0!)
        Me.lblRanking.Location = New System.Drawing.Point(316, 35)
        Me.lblRanking.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRanking.Name = "lblRanking"
        Me.lblRanking.Size = New System.Drawing.Size(118, 23)
        Me.lblRanking.TabIndex = 4
        Me.lblRanking.Text = "RANKING"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(208, 133)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(324, 196)
        Me.ListBox1.TabIndex = 5
        '
        'frmRanking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 586)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.lblRanking)
        Me.Name = "frmRanking"
        Me.Text = "frmRanking"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblRanking As Label
    Friend WithEvents ListBox1 As ListBox
End Class

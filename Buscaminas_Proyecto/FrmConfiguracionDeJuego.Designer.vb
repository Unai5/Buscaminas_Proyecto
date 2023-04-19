<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConfiguracionDeJuego
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
        Me.radButtNormal = New System.Windows.Forms.RadioButton()
        Me.radButtFacil = New System.Windows.Forms.RadioButton()
        Me.radButtDificil = New System.Windows.Forms.RadioButton()
        Me.lblDificultad = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'radButtNormal
        '
        Me.radButtNormal.AutoSize = True
        Me.radButtNormal.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!)
        Me.radButtNormal.Location = New System.Drawing.Point(415, 198)
        Me.radButtNormal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radButtNormal.Name = "radButtNormal"
        Me.radButtNormal.Size = New System.Drawing.Size(88, 26)
        Me.radButtNormal.TabIndex = 4
        Me.radButtNormal.TabStop = True
        Me.radButtNormal.Text = "Normal"
        Me.radButtNormal.UseVisualStyleBackColor = True
        '
        'radButtFacil
        '
        Me.radButtFacil.AutoSize = True
        Me.radButtFacil.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radButtFacil.Location = New System.Drawing.Point(415, 144)
        Me.radButtFacil.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radButtFacil.Name = "radButtFacil"
        Me.radButtFacil.Size = New System.Drawing.Size(64, 26)
        Me.radButtFacil.TabIndex = 5
        Me.radButtFacil.TabStop = True
        Me.radButtFacil.Text = "Fácil"
        Me.radButtFacil.UseVisualStyleBackColor = True
        '
        'radButtDificil
        '
        Me.radButtDificil.AutoSize = True
        Me.radButtDificil.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!)
        Me.radButtDificil.Location = New System.Drawing.Point(415, 256)
        Me.radButtDificil.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radButtDificil.Name = "radButtDificil"
        Me.radButtDificil.Size = New System.Drawing.Size(72, 26)
        Me.radButtDificil.TabIndex = 6
        Me.radButtDificil.TabStop = True
        Me.radButtDificil.Text = "Difícil"
        Me.radButtDificil.UseVisualStyleBackColor = True
        '
        'lblDificultad
        '
        Me.lblDificultad.AutoSize = True
        Me.lblDificultad.Font = New System.Drawing.Font("Cooper Black", 12.0!)
        Me.lblDificultad.Location = New System.Drawing.Point(176, 142)
        Me.lblDificultad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDificultad.Name = "lblDificultad"
        Me.lblDificultad.Size = New System.Drawing.Size(113, 23)
        Me.lblDificultad.TabIndex = 7
        Me.lblDificultad.Text = "Dificultad"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(140, 46)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(438, 27)
        Me.lblTitulo.TabIndex = 9
        Me.lblTitulo.Text = "SELECCIONA EL MODO DE JUEGO"
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAceptar.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Location = New System.Drawing.Point(200, 346)
        Me.btnAceptar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(125, 46)
        Me.btnAceptar.TabIndex = 11
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnVolver.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.Location = New System.Drawing.Point(415, 346)
        Me.btnVolver.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(125, 46)
        Me.btnVolver.TabIndex = 12
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'FrmConfiguracionDeJuego
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(727, 530)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.lblDificultad)
        Me.Controls.Add(Me.radButtDificil)
        Me.Controls.Add(Me.radButtFacil)
        Me.Controls.Add(Me.radButtNormal)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmConfiguracionDeJuego"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents radButtNormal As RadioButton
    Friend WithEvents radButtFacil As RadioButton
    Friend WithEvents radButtDificil As RadioButton
    Friend WithEvents lblDificultad As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnVolver As Button
End Class

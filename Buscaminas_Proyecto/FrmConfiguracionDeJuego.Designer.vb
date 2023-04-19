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
        Me.chckCronometro = New System.Windows.Forms.CheckBox()
        Me.radButtNormal = New System.Windows.Forms.RadioButton()
        Me.radButtFacil = New System.Windows.Forms.RadioButton()
        Me.radButtDificil = New System.Windows.Forms.RadioButton()
        Me.lblDificultad = New System.Windows.Forms.Label()
        Me.lblCronometro = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'chckCronometro
        '
        Me.chckCronometro.AutoSize = True
        Me.chckCronometro.Location = New System.Drawing.Point(343, 121)
        Me.chckCronometro.Name = "chckCronometro"
        Me.chckCronometro.Size = New System.Drawing.Size(15, 14)
        Me.chckCronometro.TabIndex = 0
        Me.chckCronometro.UseVisualStyleBackColor = True
        '
        'radButtNormal
        '
        Me.radButtNormal.AutoSize = True
        Me.radButtNormal.Location = New System.Drawing.Point(311, 241)
        Me.radButtNormal.Name = "radButtNormal"
        Me.radButtNormal.Size = New System.Drawing.Size(58, 17)
        Me.radButtNormal.TabIndex = 4
        Me.radButtNormal.TabStop = True
        Me.radButtNormal.Text = "Normal"
        Me.radButtNormal.UseVisualStyleBackColor = True
        '
        'radButtFacil
        '
        Me.radButtFacil.AutoSize = True
        Me.radButtFacil.Location = New System.Drawing.Point(311, 195)
        Me.radButtFacil.Name = "radButtFacil"
        Me.radButtFacil.Size = New System.Drawing.Size(47, 17)
        Me.radButtFacil.TabIndex = 5
        Me.radButtFacil.TabStop = True
        Me.radButtFacil.Text = "Fácil"
        Me.radButtFacil.UseVisualStyleBackColor = True
        '
        'radButtDificil
        '
        Me.radButtDificil.AutoSize = True
        Me.radButtDificil.Location = New System.Drawing.Point(311, 286)
        Me.radButtDificil.Name = "radButtDificil"
        Me.radButtDificil.Size = New System.Drawing.Size(52, 17)
        Me.radButtDificil.TabIndex = 6
        Me.radButtDificil.TabStop = True
        Me.radButtDificil.Text = "Difícil"
        Me.radButtDificil.UseVisualStyleBackColor = True
        '
        'lblDificultad
        '
        Me.lblDificultad.AutoSize = True
        Me.lblDificultad.Font = New System.Drawing.Font("Cooper Black", 12.0!)
        Me.lblDificultad.Location = New System.Drawing.Point(132, 193)
        Me.lblDificultad.Name = "lblDificultad"
        Me.lblDificultad.Size = New System.Drawing.Size(92, 19)
        Me.lblDificultad.TabIndex = 7
        Me.lblDificultad.Text = "Dificultad"
        '
        'lblCronometro
        '
        Me.lblCronometro.AutoSize = True
        Me.lblCronometro.Location = New System.Drawing.Point(186, 121)
        Me.lblCronometro.Name = "lblCronometro"
        Me.lblCronometro.Size = New System.Drawing.Size(151, 13)
        Me.lblCronometro.TabIndex = 10
        Me.lblCronometro.Text = "Cronometrar tiempo de partida "
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(105, 37)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(349, 21)
        Me.lblTitulo.TabIndex = 9
        Me.lblTitulo.Text = "SELECCIONA EL MODO DE JUEGO"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(150, 351)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 37)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnVolver.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.Location = New System.Drawing.Point(311, 351)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(94, 37)
        Me.btnVolver.TabIndex = 12
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'FrmConfiguracionDeJuego
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 450)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblCronometro)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.lblDificultad)
        Me.Controls.Add(Me.radButtDificil)
        Me.Controls.Add(Me.radButtFacil)
        Me.Controls.Add(Me.radButtNormal)
        Me.Controls.Add(Me.chckCronometro)
        Me.Name = "FrmConfiguracionDeJuego"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chckCronometro As CheckBox
    Friend WithEvents radButtNormal As RadioButton
    Friend WithEvents radButtFacil As RadioButton
    Friend WithEvents radButtDificil As RadioButton
    Friend WithEvents lblDificultad As Label
    Friend WithEvents lblCronometro As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnVolver As Button
End Class

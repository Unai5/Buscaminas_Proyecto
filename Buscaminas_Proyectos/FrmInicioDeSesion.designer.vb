<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmInicioDeSesion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInicioDeSesion))
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.btnIniciarSesion = New System.Windows.Forms.Button()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.lblBuscaminas = New System.Windows.Forms.Label()
        Me.btnRegisto = New System.Windows.Forms.Button()
        Me.pnlUsr = New System.Windows.Forms.Panel()
        Me.pnlContraseña = New System.Windows.Forms.Panel()
        Me.lblContraseña = New System.Windows.Forms.Label()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.pnlUsr.SuspendLayout()
        Me.pnlContraseña.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.Location = New System.Drawing.Point(3, 10)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(161, 18)
        Me.lblUsuario.TabIndex = 0
        Me.lblUsuario.Text = "Nombre de Usuario :"
        '
        'btnIniciarSesion
        '
        Me.btnIniciarSesion.BackColor = System.Drawing.Color.LightGreen
        Me.btnIniciarSesion.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIniciarSesion.Location = New System.Drawing.Point(118, 284)
        Me.btnIniciarSesion.Name = "btnIniciarSesion"
        Me.btnIniciarSesion.Size = New System.Drawing.Size(140, 37)
        Me.btnIniciarSesion.TabIndex = 1
        Me.btnIniciarSesion.Text = "Iniciar Sesión"
        Me.btnIniciarSesion.UseVisualStyleBackColor = False
        '
        'txtUsuario
        '
        Me.txtUsuario.Font = New System.Drawing.Font("Rockwell", 11.25!)
        Me.txtUsuario.Location = New System.Drawing.Point(163, 8)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(163, 25)
        Me.txtUsuario.TabIndex = 2
        '
        'lblBuscaminas
        '
        Me.lblBuscaminas.AutoSize = True
        Me.lblBuscaminas.Font = New System.Drawing.Font("Cooper Black", 12.0!)
        Me.lblBuscaminas.Location = New System.Drawing.Point(186, 18)
        Me.lblBuscaminas.Name = "lblBuscaminas"
        Me.lblBuscaminas.Size = New System.Drawing.Size(125, 19)
        Me.lblBuscaminas.TabIndex = 3
        Me.lblBuscaminas.Text = "BUSCAMINAS"
        '
        'btnRegisto
        '
        Me.btnRegisto.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRegisto.FlatAppearance.BorderColor = System.Drawing.Color.Snow
        Me.btnRegisto.Font = New System.Drawing.Font("Cooper Black", 12.0!)
        Me.btnRegisto.Location = New System.Drawing.Point(268, 284)
        Me.btnRegisto.Name = "btnRegisto"
        Me.btnRegisto.Size = New System.Drawing.Size(115, 37)
        Me.btnRegisto.TabIndex = 4
        Me.btnRegisto.Text = "Registrarse"
        Me.btnRegisto.UseVisualStyleBackColor = False
        '
        'pnlUsr
        '
        Me.pnlUsr.BackColor = System.Drawing.Color.LightGreen
        Me.pnlUsr.Controls.Add(Me.lblUsuario)
        Me.pnlUsr.Controls.Add(Me.txtUsuario)
        Me.pnlUsr.Location = New System.Drawing.Point(84, 132)
        Me.pnlUsr.Name = "pnlUsr"
        Me.pnlUsr.Size = New System.Drawing.Size(334, 40)
        Me.pnlUsr.TabIndex = 5
        '
        'pnlContraseña
        '
        Me.pnlContraseña.BackColor = System.Drawing.Color.LightGreen
        Me.pnlContraseña.Controls.Add(Me.lblContraseña)
        Me.pnlContraseña.Controls.Add(Me.txtContraseña)
        Me.pnlContraseña.Location = New System.Drawing.Point(104, 189)
        Me.pnlContraseña.Name = "pnlContraseña"
        Me.pnlContraseña.Size = New System.Drawing.Size(292, 42)
        Me.pnlContraseña.TabIndex = 6
        '
        'lblContraseña
        '
        Me.lblContraseña.AutoSize = True
        Me.lblContraseña.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContraseña.Location = New System.Drawing.Point(11, 11)
        Me.lblContraseña.Name = "lblContraseña"
        Me.lblContraseña.Size = New System.Drawing.Size(103, 18)
        Me.lblContraseña.TabIndex = 0
        Me.lblContraseña.Text = "Contraseña :"
        '
        'txtContraseña
        '
        Me.txtContraseña.Font = New System.Drawing.Font("Rockwell", 11.25!)
        Me.txtContraseña.Location = New System.Drawing.Point(117, 8)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.Size = New System.Drawing.Size(163, 25)
        Me.txtContraseña.TabIndex = 2
        '
        'FrmInicioDeSesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(491, 442)
        Me.Controls.Add(Me.pnlContraseña)
        Me.Controls.Add(Me.pnlUsr)
        Me.Controls.Add(Me.btnRegisto)
        Me.Controls.Add(Me.lblBuscaminas)
        Me.Controls.Add(Me.btnIniciarSesion)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmInicioDeSesion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.pnlUsr.ResumeLayout(False)
        Me.pnlUsr.PerformLayout()
        Me.pnlContraseña.ResumeLayout(False)
        Me.pnlContraseña.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUsuario As Label
    Friend WithEvents btnIniciarSesion As Button
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents lblBuscaminas As Label
    Friend WithEvents btnRegisto As Button
    Friend WithEvents pnlUsr As Panel
    Friend WithEvents pnlContraseña As Panel
    Friend WithEvents lblContraseña As Label
    Friend WithEvents txtContraseña As TextBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInicioDeSesion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInicioDeSesion))
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.btnIniciarSesion = New System.Windows.Forms.Button()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.lblBuscaminas = New System.Windows.Forms.Label()
        Me.btnRegistrarse = New System.Windows.Forms.Button()
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
        Me.lblUsuario.Location = New System.Drawing.Point(4, 12)
        Me.lblUsuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(205, 23)
        Me.lblUsuario.TabIndex = 0
        Me.lblUsuario.Text = "Nombre de Usuario :"
        '
        'btnIniciarSesion
        '
        Me.btnIniciarSesion.BackColor = System.Drawing.Color.LightGreen
        Me.btnIniciarSesion.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIniciarSesion.Location = New System.Drawing.Point(158, 353)
        Me.btnIniciarSesion.Margin = New System.Windows.Forms.Padding(4)
        Me.btnIniciarSesion.Name = "btnIniciarSesion"
        Me.btnIniciarSesion.Size = New System.Drawing.Size(186, 46)
        Me.btnIniciarSesion.TabIndex = 1
        Me.btnIniciarSesion.Text = "Iniciar Sesión"
        Me.btnIniciarSesion.UseVisualStyleBackColor = False
        '
        'txtUsuario
        '
        Me.txtUsuario.Font = New System.Drawing.Font("Rockwell", 11.25!)
        Me.txtUsuario.Location = New System.Drawing.Point(217, 10)
        Me.txtUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(216, 30)
        Me.txtUsuario.TabIndex = 2
        '
        'lblBuscaminas
        '
        Me.lblBuscaminas.AutoSize = True
        Me.lblBuscaminas.Font = New System.Drawing.Font("Cooper Black", 12.0!)
        Me.lblBuscaminas.Location = New System.Drawing.Point(248, 22)
        Me.lblBuscaminas.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBuscaminas.Name = "lblBuscaminas"
        Me.lblBuscaminas.Size = New System.Drawing.Size(157, 23)
        Me.lblBuscaminas.TabIndex = 3
        Me.lblBuscaminas.Text = "BUSCAMINAS"
        '
        'btnRegistrarse
        '
        Me.btnRegistrarse.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRegistrarse.FlatAppearance.BorderColor = System.Drawing.Color.Snow
        Me.btnRegistrarse.Font = New System.Drawing.Font("Cooper Black", 12.0!)
        Me.btnRegistrarse.Location = New System.Drawing.Point(358, 353)
        Me.btnRegistrarse.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRegistrarse.Name = "btnRegistrarse"
        Me.btnRegistrarse.Size = New System.Drawing.Size(153, 46)
        Me.btnRegistrarse.TabIndex = 4
        Me.btnRegistrarse.Text = "Registrarse"
        Me.btnRegistrarse.UseVisualStyleBackColor = False
        '
        'pnlUsr
        '
        Me.pnlUsr.BackColor = System.Drawing.Color.LightGreen
        Me.pnlUsr.Controls.Add(Me.lblUsuario)
        Me.pnlUsr.Controls.Add(Me.txtUsuario)
        Me.pnlUsr.Location = New System.Drawing.Point(112, 166)
        Me.pnlUsr.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlUsr.Name = "pnlUsr"
        Me.pnlUsr.Size = New System.Drawing.Size(445, 49)
        Me.pnlUsr.TabIndex = 5
        '
        'pnlContraseña
        '
        Me.pnlContraseña.BackColor = System.Drawing.Color.LightGreen
        Me.pnlContraseña.Controls.Add(Me.lblContraseña)
        Me.pnlContraseña.Controls.Add(Me.txtContraseña)
        Me.pnlContraseña.Location = New System.Drawing.Point(139, 236)
        Me.pnlContraseña.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlContraseña.Name = "pnlContraseña"
        Me.pnlContraseña.Size = New System.Drawing.Size(389, 52)
        Me.pnlContraseña.TabIndex = 6
        '
        'lblContraseña
        '
        Me.lblContraseña.AutoSize = True
        Me.lblContraseña.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContraseña.Location = New System.Drawing.Point(15, 14)
        Me.lblContraseña.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblContraseña.Name = "lblContraseña"
        Me.lblContraseña.Size = New System.Drawing.Size(131, 23)
        Me.lblContraseña.TabIndex = 0
        Me.lblContraseña.Text = "Contraseña :"
        '
        'txtContraseña
        '
        Me.txtContraseña.Font = New System.Drawing.Font("Rockwell", 11.25!)
        Me.txtContraseña.Location = New System.Drawing.Point(156, 11)
        Me.txtContraseña.Margin = New System.Windows.Forms.Padding(4)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.Size = New System.Drawing.Size(216, 30)
        Me.txtContraseña.TabIndex = 2
        '
        'FrmInicioDeSesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(655, 544)
        Me.Controls.Add(Me.pnlContraseña)
        Me.Controls.Add(Me.pnlUsr)
        Me.Controls.Add(Me.btnRegistrarse)
        Me.Controls.Add(Me.lblBuscaminas)
        Me.Controls.Add(Me.btnIniciarSesion)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmInicioDeSesion"
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
    Friend WithEvents btnRegistrarse As Button
    Friend WithEvents pnlUsr As Panel
    Friend WithEvents pnlContraseña As Panel
    Friend WithEvents lblContraseña As Label
    Friend WithEvents txtContraseña As TextBox
End Class

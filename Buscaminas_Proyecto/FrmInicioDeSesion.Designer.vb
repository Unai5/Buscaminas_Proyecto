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
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.lblBuscaminas = New System.Windows.Forms.Label()
        Me.btnRankin = New System.Windows.Forms.Button()
        Me.panelUsr = New System.Windows.Forms.Panel()
        Me.panelContraseña = New System.Windows.Forms.Panel()
        Me.lblContraseña = New System.Windows.Forms.Label()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.panelUsr.SuspendLayout()
        Me.panelContraseña.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.Location = New System.Drawing.Point(11, 11)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(161, 18)
        Me.lblUsuario.TabIndex = 0
        Me.lblUsuario.Text = "Nombre de Usuario :"
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAceptar.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Location = New System.Drawing.Point(124, 287)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(94, 37)
        Me.btnAceptar.TabIndex = 1
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'txtUsuario
        '
        Me.txtUsuario.Font = New System.Drawing.Font("Rockwell", 11.25!)
        Me.txtUsuario.Location = New System.Drawing.Point(173, 8)
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
        'btnRankin
        '
        Me.btnRankin.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRankin.FlatAppearance.BorderColor = System.Drawing.Color.Snow
        Me.btnRankin.Font = New System.Drawing.Font("Cooper Black", 12.0!)
        Me.btnRankin.Location = New System.Drawing.Point(271, 287)
        Me.btnRankin.Name = "btnRankin"
        Me.btnRankin.Size = New System.Drawing.Size(100, 37)
        Me.btnRankin.TabIndex = 4
        Me.btnRankin.Text = "Rankin"
        Me.btnRankin.UseVisualStyleBackColor = False
        '
        'panelUsr
        '
        Me.panelUsr.BackColor = System.Drawing.Color.LightGreen
        Me.panelUsr.Controls.Add(Me.lblUsuario)
        Me.panelUsr.Controls.Add(Me.txtUsuario)
        Me.panelUsr.Location = New System.Drawing.Point(78, 135)
        Me.panelUsr.Name = "panelUsr"
        Me.panelUsr.Size = New System.Drawing.Size(346, 40)
        Me.panelUsr.TabIndex = 5
        '
        'panelContraseña
        '
        Me.panelContraseña.BackColor = System.Drawing.Color.Tomato
        Me.panelContraseña.Controls.Add(Me.lblContraseña)
        Me.panelContraseña.Controls.Add(Me.txtContraseña)
        Me.panelContraseña.Location = New System.Drawing.Point(104, 192)
        Me.panelContraseña.Name = "panelContraseña"
        Me.panelContraseña.Size = New System.Drawing.Size(292, 42)
        Me.panelContraseña.TabIndex = 6
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
        Me.txtContraseña.Location = New System.Drawing.Point(117, 9)
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
        Me.Controls.Add(Me.panelContraseña)
        Me.Controls.Add(Me.panelUsr)
        Me.Controls.Add(Me.btnRankin)
        Me.Controls.Add(Me.lblBuscaminas)
        Me.Controls.Add(Me.btnAceptar)
        Me.Name = "FrmInicioDeSesion"
        Me.Text = "Form1"
        Me.panelUsr.ResumeLayout(False)
        Me.panelUsr.PerformLayout()
        Me.panelContraseña.ResumeLayout(False)
        Me.panelContraseña.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUsuario As Label
    Friend WithEvents btnAceptar As Button
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents lblBuscaminas As Label
    Friend WithEvents btnRankin As Button
    Friend WithEvents panelUsr As Panel
    Friend WithEvents panelContraseña As Panel
    Friend WithEvents lblContraseña As Label
    Friend WithEvents txtContraseña As TextBox
End Class

﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegistro
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
        Me.lblRegistro = New System.Windows.Forms.Label()
        Me.pnlNuevoUsuario = New System.Windows.Forms.Panel()
        Me.lblNuevoUsuario = New System.Windows.Forms.Label()
        Me.txtNuevoUsuario = New System.Windows.Forms.TextBox()
        Me.pnlNuevaContraseña = New System.Windows.Forms.Panel()
        Me.lblNuevaContraseña = New System.Windows.Forms.Label()
        Me.txtNuevaContraseña = New System.Windows.Forms.TextBox()
        Me.pnlRepetirContraseña = New System.Windows.Forms.Panel()
        Me.lblRepetirContraseña = New System.Windows.Forms.Label()
        Me.txtRepetirContraseña = New System.Windows.Forms.TextBox()
        Me.btnCompletarRegistro = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.pnlNuevoUsuario.SuspendLayout()
        Me.pnlNuevaContraseña.SuspendLayout()
        Me.pnlRepetirContraseña.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblRegistro
        '
        Me.lblRegistro.AutoSize = True
        Me.lblRegistro.Font = New System.Drawing.Font("Cooper Black", 12.0!)
        Me.lblRegistro.Location = New System.Drawing.Point(245, 36)
        Me.lblRegistro.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRegistro.Name = "lblRegistro"
        Me.lblRegistro.Size = New System.Drawing.Size(157, 23)
        Me.lblRegistro.TabIndex = 4
        Me.lblRegistro.Text = "BUSCAMINAS"
        '
        'pnlNuevoUsuario
        '
        Me.pnlNuevoUsuario.BackColor = System.Drawing.Color.LightGreen
        Me.pnlNuevoUsuario.Controls.Add(Me.lblNuevoUsuario)
        Me.pnlNuevoUsuario.Controls.Add(Me.txtNuevoUsuario)
        Me.pnlNuevoUsuario.Location = New System.Drawing.Point(96, 118)
        Me.pnlNuevoUsuario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlNuevoUsuario.Name = "pnlNuevoUsuario"
        Me.pnlNuevoUsuario.Size = New System.Drawing.Size(469, 52)
        Me.pnlNuevoUsuario.TabIndex = 7
        '
        'lblNuevoUsuario
        '
        Me.lblNuevoUsuario.AutoSize = True
        Me.lblNuevoUsuario.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNuevoUsuario.Location = New System.Drawing.Point(15, 14)
        Me.lblNuevoUsuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNuevoUsuario.Name = "lblNuevoUsuario"
        Me.lblNuevoUsuario.Size = New System.Drawing.Size(160, 23)
        Me.lblNuevoUsuario.TabIndex = 0
        Me.lblNuevoUsuario.Text = "Nuevo Usuario :"
        '
        'txtNuevoUsuario
        '
        Me.txtNuevoUsuario.Font = New System.Drawing.Font("Rockwell", 11.25!)
        Me.txtNuevoUsuario.Location = New System.Drawing.Point(183, 11)
        Me.txtNuevoUsuario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNuevoUsuario.Name = "txtNuevoUsuario"
        Me.txtNuevoUsuario.Size = New System.Drawing.Size(263, 30)
        Me.txtNuevoUsuario.TabIndex = 2
        '
        'pnlNuevaContraseña
        '
        Me.pnlNuevaContraseña.BackColor = System.Drawing.Color.LightGreen
        Me.pnlNuevaContraseña.Controls.Add(Me.lblNuevaContraseña)
        Me.pnlNuevaContraseña.Controls.Add(Me.txtNuevaContraseña)
        Me.pnlNuevaContraseña.Location = New System.Drawing.Point(96, 206)
        Me.pnlNuevaContraseña.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlNuevaContraseña.Name = "pnlNuevaContraseña"
        Me.pnlNuevaContraseña.Size = New System.Drawing.Size(469, 52)
        Me.pnlNuevaContraseña.TabIndex = 8
        '
        'lblNuevaContraseña
        '
        Me.lblNuevaContraseña.AutoSize = True
        Me.lblNuevaContraseña.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNuevaContraseña.Location = New System.Drawing.Point(15, 14)
        Me.lblNuevaContraseña.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNuevaContraseña.Name = "lblNuevaContraseña"
        Me.lblNuevaContraseña.Size = New System.Drawing.Size(196, 23)
        Me.lblNuevaContraseña.TabIndex = 0
        Me.lblNuevaContraseña.Text = "Nueva Contraseña :"
        '
        'txtNuevaContraseña
        '
        Me.txtNuevaContraseña.Font = New System.Drawing.Font("Rockwell", 11.25!)
        Me.txtNuevaContraseña.Location = New System.Drawing.Point(219, 11)
        Me.txtNuevaContraseña.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNuevaContraseña.Name = "txtNuevaContraseña"
        Me.txtNuevaContraseña.Size = New System.Drawing.Size(227, 30)
        Me.txtNuevaContraseña.TabIndex = 2
        '
        'pnlRepetirContraseña
        '
        Me.pnlRepetirContraseña.BackColor = System.Drawing.Color.LightGreen
        Me.pnlRepetirContraseña.Controls.Add(Me.lblRepetirContraseña)
        Me.pnlRepetirContraseña.Controls.Add(Me.txtRepetirContraseña)
        Me.pnlRepetirContraseña.Location = New System.Drawing.Point(96, 297)
        Me.pnlRepetirContraseña.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlRepetirContraseña.Name = "pnlRepetirContraseña"
        Me.pnlRepetirContraseña.Size = New System.Drawing.Size(469, 52)
        Me.pnlRepetirContraseña.TabIndex = 8
        '
        'lblRepetirContraseña
        '
        Me.lblRepetirContraseña.AutoSize = True
        Me.lblRepetirContraseña.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRepetirContraseña.Location = New System.Drawing.Point(15, 14)
        Me.lblRepetirContraseña.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRepetirContraseña.Name = "lblRepetirContraseña"
        Me.lblRepetirContraseña.Size = New System.Drawing.Size(207, 23)
        Me.lblRepetirContraseña.TabIndex = 0
        Me.lblRepetirContraseña.Text = "Repetir Contraseña :"
        '
        'txtRepetirContraseña
        '
        Me.txtRepetirContraseña.Font = New System.Drawing.Font("Rockwell", 11.25!)
        Me.txtRepetirContraseña.Location = New System.Drawing.Point(229, 11)
        Me.txtRepetirContraseña.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtRepetirContraseña.Name = "txtRepetirContraseña"
        Me.txtRepetirContraseña.Size = New System.Drawing.Size(216, 30)
        Me.txtRepetirContraseña.TabIndex = 2
        '
        'btnCompletarRegistro
        '
        Me.btnCompletarRegistro.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCompletarRegistro.FlatAppearance.BorderColor = System.Drawing.Color.Snow
        Me.btnCompletarRegistro.Font = New System.Drawing.Font("Cooper Black", 12.0!)
        Me.btnCompletarRegistro.Location = New System.Drawing.Point(337, 402)
        Me.btnCompletarRegistro.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCompletarRegistro.Name = "btnCompletarRegistro"
        Me.btnCompletarRegistro.Size = New System.Drawing.Size(153, 46)
        Me.btnCompletarRegistro.TabIndex = 9
        Me.btnCompletarRegistro.Text = "Registrarse"
        Me.btnCompletarRegistro.UseVisualStyleBackColor = False
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnVolver.FlatAppearance.BorderColor = System.Drawing.Color.Snow
        Me.btnVolver.Font = New System.Drawing.Font("Cooper Black", 12.0!)
        Me.btnVolver.Location = New System.Drawing.Point(164, 402)
        Me.btnVolver.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(153, 46)
        Me.btnVolver.TabIndex = 10
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'FrmRegistro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 544)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnCompletarRegistro)
        Me.Controls.Add(Me.pnlRepetirContraseña)
        Me.Controls.Add(Me.pnlNuevaContraseña)
        Me.Controls.Add(Me.pnlNuevoUsuario)
        Me.Controls.Add(Me.lblRegistro)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmRegistro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmRegistro"
        Me.pnlNuevoUsuario.ResumeLayout(False)
        Me.pnlNuevoUsuario.PerformLayout()
        Me.pnlNuevaContraseña.ResumeLayout(False)
        Me.pnlNuevaContraseña.PerformLayout()
        Me.pnlRepetirContraseña.ResumeLayout(False)
        Me.pnlRepetirContraseña.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblRegistro As Label
    Friend WithEvents pnlNuevoUsuario As Panel
    Friend WithEvents lblNuevoUsuario As Label
    Friend WithEvents txtNuevoUsuario As TextBox
    Friend WithEvents pnlNuevaContraseña As Panel
    Friend WithEvents lblNuevaContraseña As Label
    Friend WithEvents txtNuevaContraseña As TextBox
    Friend WithEvents pnlRepetirContraseña As Panel
    Friend WithEvents lblRepetirContraseña As Label
    Friend WithEvents txtRepetirContraseña As TextBox
    Friend WithEvents btnCompletarRegistro As Button
    Friend WithEvents btnVolver As Button
End Class

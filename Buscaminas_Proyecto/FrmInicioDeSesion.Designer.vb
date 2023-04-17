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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblBuscaminas = New System.Windows.Forms.Label()
        Me.btnRankin = New System.Windows.Forms.Button()
        Me.panelUsr = New System.Windows.Forms.Panel()
        Me.panelUsr.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.Location = New System.Drawing.Point(12, 11)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(154, 17)
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
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Rockwell", 11.25!)
        Me.TextBox1.Location = New System.Drawing.Point(173, 8)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(163, 25)
        Me.TextBox1.TabIndex = 2
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
        Me.panelUsr.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.panelUsr.Controls.Add(Me.lblUsuario)
        Me.panelUsr.Controls.Add(Me.TextBox1)
        Me.panelUsr.Location = New System.Drawing.Point(78, 165)
        Me.panelUsr.Name = "panelUsr"
        Me.panelUsr.Size = New System.Drawing.Size(346, 40)
        Me.panelUsr.TabIndex = 5
        '
        'FrmInicioDeSesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(491, 442)
        Me.Controls.Add(Me.panelUsr)
        Me.Controls.Add(Me.btnRankin)
        Me.Controls.Add(Me.lblBuscaminas)
        Me.Controls.Add(Me.btnAceptar)
        Me.Name = "FrmInicioDeSesion"
        Me.Text = "Form1"
        Me.panelUsr.ResumeLayout(False)
        Me.panelUsr.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUsuario As Label
    Friend WithEvents btnAceptar As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblBuscaminas As Label
    Friend WithEvents btnRankin As Button
    Friend WithEvents panelUsr As Panel
End Class

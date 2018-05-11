<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblPalabra = New System.Windows.Forms.Label()
        Me.txbPalabra = New System.Windows.Forms.TextBox()
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.btnCantidad = New System.Windows.Forms.Button()
        Me.btnCanta = New System.Windows.Forms.Button()
        Me.lblA = New System.Windows.Forms.Label()
        Me.btnCantidadpreg = New System.Windows.Forms.Button()
        Me.lblCantPreg = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblPalabra
        '
        Me.lblPalabra.AutoSize = True
        Me.lblPalabra.Location = New System.Drawing.Point(23, 19)
        Me.lblPalabra.Name = "lblPalabra"
        Me.lblPalabra.Size = New System.Drawing.Size(57, 17)
        Me.lblPalabra.TabIndex = 0
        Me.lblPalabra.Text = "Palabra"
        '
        'txbPalabra
        '
        Me.txbPalabra.Location = New System.Drawing.Point(26, 48)
        Me.txbPalabra.Name = "txbPalabra"
        Me.txbPalabra.Size = New System.Drawing.Size(301, 22)
        Me.txbPalabra.TabIndex = 1
        '
        'lblMensaje
        '
        Me.lblMensaje.AutoSize = True
        Me.lblMensaje.Location = New System.Drawing.Point(23, 204)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(85, 17)
        Me.lblMensaje.TabIndex = 2
        Me.lblMensaje.Text = "Caracteres: "
        '
        'btnCantidad
        '
        Me.btnCantidad.Location = New System.Drawing.Point(26, 76)
        Me.btnCantidad.Name = "btnCantidad"
        Me.btnCantidad.Size = New System.Drawing.Size(301, 37)
        Me.btnCantidad.TabIndex = 3
        Me.btnCantidad.Text = "Cantidad de Caracteres"
        Me.btnCantidad.UseVisualStyleBackColor = True
        '
        'btnCanta
        '
        Me.btnCanta.Location = New System.Drawing.Point(26, 119)
        Me.btnCanta.Name = "btnCanta"
        Me.btnCanta.Size = New System.Drawing.Size(301, 37)
        Me.btnCanta.TabIndex = 4
        Me.btnCanta.Text = "Cantidad de a minusculas"
        Me.btnCanta.UseVisualStyleBackColor = True
        '
        'lblA
        '
        Me.lblA.AutoSize = True
        Me.lblA.Location = New System.Drawing.Point(23, 230)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(98, 17)
        Me.lblA.TabIndex = 5
        Me.lblA.Text = "a minusculas: "
        '
        'btnCantidadpreg
        '
        Me.btnCantidadpreg.Location = New System.Drawing.Point(26, 162)
        Me.btnCantidadpreg.Name = "btnCantidadpreg"
        Me.btnCantidadpreg.Size = New System.Drawing.Size(301, 37)
        Me.btnCantidadpreg.TabIndex = 6
        Me.btnCantidadpreg.Text = "Cantidad de una letra"
        Me.btnCantidadpreg.UseVisualStyleBackColor = True
        '
        'lblCantPreg
        '
        Me.lblCantPreg.AutoSize = True
        Me.lblCantPreg.Location = New System.Drawing.Point(23, 260)
        Me.lblCantPreg.Name = "lblCantPreg"
        Me.lblCantPreg.Size = New System.Drawing.Size(96, 17)
        Me.lblCantPreg.TabIndex = 7
        Me.lblCantPreg.Text = "Cantidad de : "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 324)
        Me.Controls.Add(Me.lblCantPreg)
        Me.Controls.Add(Me.btnCantidadpreg)
        Me.Controls.Add(Me.lblA)
        Me.Controls.Add(Me.btnCanta)
        Me.Controls.Add(Me.btnCantidad)
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.txbPalabra)
        Me.Controls.Add(Me.lblPalabra)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPalabra As System.Windows.Forms.Label
    Friend WithEvents txbPalabra As System.Windows.Forms.TextBox
    Friend WithEvents lblMensaje As System.Windows.Forms.Label
    Friend WithEvents btnCantidad As System.Windows.Forms.Button
    Friend WithEvents btnCanta As System.Windows.Forms.Button
    Friend WithEvents lblA As System.Windows.Forms.Label
    Friend WithEvents btnCantidadpreg As System.Windows.Forms.Button
    Friend WithEvents lblCantPreg As System.Windows.Forms.Label

End Class

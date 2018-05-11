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
        Me.btnMensaje = New System.Windows.Forms.Button()
        Me.btnPreguntarNombre = New System.Windows.Forms.Button()
        Me.txtBox = New System.Windows.Forms.TextBox()
        Me.btnLeertitulo = New System.Windows.Forms.Button()
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.btnCambiartitulo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnMensaje
        '
        Me.btnMensaje.Location = New System.Drawing.Point(12, 85)
        Me.btnMensaje.Name = "btnMensaje"
        Me.btnMensaje.Size = New System.Drawing.Size(99, 42)
        Me.btnMensaje.TabIndex = 0
        Me.btnMensaje.Text = "mensaje"
        Me.btnMensaje.UseVisualStyleBackColor = True
        '
        'btnPreguntarNombre
        '
        Me.btnPreguntarNombre.Location = New System.Drawing.Point(12, 150)
        Me.btnPreguntarNombre.Name = "btnPreguntarNombre"
        Me.btnPreguntarNombre.Size = New System.Drawing.Size(99, 59)
        Me.btnPreguntarNombre.TabIndex = 1
        Me.btnPreguntarNombre.Text = "Preguntar mi nombre"
        Me.btnPreguntarNombre.UseVisualStyleBackColor = True
        '
        'txtBox
        '
        Me.txtBox.Location = New System.Drawing.Point(155, 163)
        Me.txtBox.Name = "txtBox"
        Me.txtBox.Size = New System.Drawing.Size(95, 20)
        Me.txtBox.TabIndex = 2
        '
        'btnLeertitulo
        '
        Me.btnLeertitulo.Location = New System.Drawing.Point(155, 85)
        Me.btnLeertitulo.Name = "btnLeertitulo"
        Me.btnLeertitulo.Size = New System.Drawing.Size(101, 33)
        Me.btnLeertitulo.TabIndex = 3
        Me.btnLeertitulo.Text = "Leer titulo"
        Me.btnLeertitulo.UseVisualStyleBackColor = True
        '
        'lblMensaje
        '
        Me.lblMensaje.AutoSize = True
        Me.lblMensaje.Location = New System.Drawing.Point(24, 18)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(65, 13)
        Me.lblMensaje.TabIndex = 4
        Me.lblMensaje.Text = "Bienvenidos"
        '
        'btnCambiartitulo
        '
        Me.btnCambiartitulo.Location = New System.Drawing.Point(155, 189)
        Me.btnCambiartitulo.Name = "btnCambiartitulo"
        Me.btnCambiartitulo.Size = New System.Drawing.Size(95, 20)
        Me.btnCambiartitulo.TabIndex = 5
        Me.btnCambiartitulo.Text = "cambiar titulo"
        Me.btnCambiartitulo.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnCambiartitulo)
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.btnLeertitulo)
        Me.Controls.Add(Me.txtBox)
        Me.Controls.Add(Me.btnPreguntarNombre)
        Me.Controls.Add(Me.btnMensaje)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnMensaje As Button
    Friend WithEvents btnPreguntarNombre As Button
    Friend WithEvents txtBox As TextBox
    Friend WithEvents btnLeertitulo As Button
    Friend WithEvents lblMensaje As Label
    Friend WithEvents btnCambiartitulo As Button
End Class

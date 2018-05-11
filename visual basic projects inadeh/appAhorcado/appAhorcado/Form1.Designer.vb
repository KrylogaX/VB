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
        Me.btnTrampa = New System.Windows.Forms.Button()
        Me.lblTrampa = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnReiniciar = New System.Windows.Forms.Button()
        Me.lbl6 = New System.Windows.Forms.Label()
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnVerificar = New System.Windows.Forms.Button()
        Me.lblIntentos = New System.Windows.Forms.Label()
        Me.tbxVerificar = New System.Windows.Forms.TextBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnTrampa
        '
        Me.btnTrampa.Location = New System.Drawing.Point(31, 57)
        Me.btnTrampa.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTrampa.Name = "btnTrampa"
        Me.btnTrampa.Size = New System.Drawing.Size(75, 25)
        Me.btnTrampa.TabIndex = 29
        Me.btnTrampa.Text = "Trampa"
        Me.btnTrampa.UseVisualStyleBackColor = True
        '
        'lblTrampa
        '
        Me.lblTrampa.AutoSize = True
        Me.lblTrampa.Location = New System.Drawing.Point(27, 38)
        Me.lblTrampa.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTrampa.Name = "lblTrampa"
        Me.lblTrampa.Size = New System.Drawing.Size(57, 17)
        Me.lblTrampa.TabIndex = 28
        Me.lblTrampa.Text = "Palabra"
        Me.lblTrampa.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 454)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 29)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Inserte una letra:"
        '
        'btnReiniciar
        '
        Me.btnReiniciar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReiniciar.Location = New System.Drawing.Point(322, 428)
        Me.btnReiniciar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnReiniciar.Name = "btnReiniciar"
        Me.btnReiniciar.Size = New System.Drawing.Size(183, 46)
        Me.btnReiniciar.TabIndex = 26
        Me.btnReiniciar.Text = "Iniciar"
        Me.btnReiniciar.UseVisualStyleBackColor = True
        '
        'lbl6
        '
        Me.lbl6.AutoSize = True
        Me.lbl6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl6.Location = New System.Drawing.Point(368, 299)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(36, 39)
        Me.lbl6.TabIndex = 25
        Me.lbl6.Text = "_"
        '
        'lbl5
        '
        Me.lbl5.AutoSize = True
        Me.lbl5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5.Location = New System.Drawing.Point(327, 299)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(36, 39)
        Me.lbl5.TabIndex = 24
        Me.lbl5.Text = "_"
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl4.Location = New System.Drawing.Point(286, 299)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(36, 39)
        Me.lbl4.TabIndex = 23
        Me.lbl4.Text = "_"
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.Location = New System.Drawing.Point(243, 299)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(36, 39)
        Me.lbl3.TabIndex = 22
        Me.lbl3.Text = "_"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.Location = New System.Drawing.Point(200, 299)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(36, 39)
        Me.lbl2.TabIndex = 21
        Me.lbl2.Text = "_"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.Location = New System.Drawing.Point(159, 299)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(36, 39)
        Me.lbl1.TabIndex = 20
        Me.lbl1.Text = "_"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.appAhorcado.My.Resources.Resources.Intento7
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(150, 80)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(307, 217)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'btnVerificar
        '
        Me.btnVerificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerificar.Location = New System.Drawing.Point(322, 496)
        Me.btnVerificar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnVerificar.Name = "btnVerificar"
        Me.btnVerificar.Size = New System.Drawing.Size(183, 47)
        Me.btnVerificar.TabIndex = 18
        Me.btnVerificar.Text = "Verificar"
        Me.btnVerificar.UseVisualStyleBackColor = True
        '
        'lblIntentos
        '
        Me.lblIntentos.AutoSize = True
        Me.lblIntentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntentos.Location = New System.Drawing.Point(23, 366)
        Me.lblIntentos.Name = "lblIntentos"
        Me.lblIntentos.Size = New System.Drawing.Size(134, 58)
        Me.lblIntentos.TabIndex = 17
        Me.lblIntentos.Text = "Intentos " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Restantes:"
        '
        'tbxVerificar
        '
        Me.tbxVerificar.Enabled = False
        Me.tbxVerificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxVerificar.Location = New System.Drawing.Point(23, 496)
        Me.tbxVerificar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbxVerificar.MaxLength = 1
        Me.tbxVerificar.Name = "tbxVerificar"
        Me.tbxVerificar.Size = New System.Drawing.Size(293, 45)
        Me.tbxVerificar.TabIndex = 16
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(192, 16)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(203, 39)
        Me.lblTitulo.TabIndex = 15
        Me.lblTitulo.Text = "El Ahorcado"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 557)
        Me.Controls.Add(Me.btnTrampa)
        Me.Controls.Add(Me.lblTrampa)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnReiniciar)
        Me.Controls.Add(Me.lbl6)
        Me.Controls.Add(Me.lbl5)
        Me.Controls.Add(Me.lbl4)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnVerificar)
        Me.Controls.Add(Me.lblIntentos)
        Me.Controls.Add(Me.tbxVerificar)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnTrampa As Button
    Friend WithEvents lblTrampa As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnReiniciar As Button
    Friend WithEvents lbl6 As Label
    Friend WithEvents lbl5 As Label
    Friend WithEvents lbl4 As Label
    Friend WithEvents lbl3 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents lbl1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnVerificar As Button
    Friend WithEvents lblIntentos As Label
    Friend WithEvents tbxVerificar As TextBox
    Friend WithEvents lblTitulo As Label
End Class

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
        Me.btnsuma = New System.Windows.Forms.Button()
        Me.btnmultiplicacion = New System.Windows.Forms.Button()
        Me.btnsaludo = New System.Windows.Forms.Button()
        Me.btnamigo = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnsuma
        '
        Me.btnsuma.ForeColor = System.Drawing.SystemColors.InfoText
        Me.btnsuma.Location = New System.Drawing.Point(12, 22)
        Me.btnsuma.Name = "btnsuma"
        Me.btnsuma.Size = New System.Drawing.Size(103, 73)
        Me.btnsuma.TabIndex = 0
        Me.btnsuma.Text = "suma numeros"
        Me.btnsuma.UseVisualStyleBackColor = True
        '
        'btnmultiplicacion
        '
        Me.btnmultiplicacion.Location = New System.Drawing.Point(177, 22)
        Me.btnmultiplicacion.Name = "btnmultiplicacion"
        Me.btnmultiplicacion.Size = New System.Drawing.Size(95, 54)
        Me.btnmultiplicacion.TabIndex = 1
        Me.btnmultiplicacion.Text = "multiplicacion"
        Me.btnmultiplicacion.UseVisualStyleBackColor = True
        '
        'btnsaludo
        '
        Me.btnsaludo.Location = New System.Drawing.Point(164, 93)
        Me.btnsaludo.Name = "btnsaludo"
        Me.btnsaludo.Size = New System.Drawing.Size(108, 34)
        Me.btnsaludo.TabIndex = 2
        Me.btnsaludo.Text = "saludos"
        Me.btnsaludo.UseVisualStyleBackColor = True
        '
        'btnamigo
        '
        Me.btnamigo.Location = New System.Drawing.Point(22, 101)
        Me.btnamigo.Name = "btnamigo"
        Me.btnamigo.Size = New System.Drawing.Size(115, 58)
        Me.btnamigo.TabIndex = 3
        Me.btnamigo.Text = "saludo amigo"
        Me.btnamigo.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(-1, 226)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "saludo 2"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnamigo)
        Me.Controls.Add(Me.btnsaludo)
        Me.Controls.Add(Me.btnmultiplicacion)
        Me.Controls.Add(Me.btnsuma)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnsuma As Button
    Friend WithEvents btnmultiplicacion As Button
    Friend WithEvents btnsaludo As Button
    Friend WithEvents btnamigo As Button
    Friend WithEvents Button1 As Button
End Class

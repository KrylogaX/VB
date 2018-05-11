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
        Me.btnCargar1 = New System.Windows.Forms.Button()
        Me.btnCargar2 = New System.Windows.Forms.Button()
        Me.lbxArreglo1 = New System.Windows.Forms.ListBox()
        Me.lbxArreglo2 = New System.Windows.Forms.ListBox()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.btnSuma = New System.Windows.Forms.Button()
        Me.lbxSuma = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnCargar1
        '
        Me.btnCargar1.Location = New System.Drawing.Point(12, 12)
        Me.btnCargar1.Name = "btnCargar1"
        Me.btnCargar1.Size = New System.Drawing.Size(122, 28)
        Me.btnCargar1.TabIndex = 0
        Me.btnCargar1.Text = "Cargar Arreglo"
        Me.btnCargar1.UseVisualStyleBackColor = True
        '
        'btnCargar2
        '
        Me.btnCargar2.Location = New System.Drawing.Point(140, 12)
        Me.btnCargar2.Name = "btnCargar2"
        Me.btnCargar2.Size = New System.Drawing.Size(122, 28)
        Me.btnCargar2.TabIndex = 1
        Me.btnCargar2.Text = "Cargar Arreglo"
        Me.btnCargar2.UseVisualStyleBackColor = True
        '
        'lbxArreglo1
        '
        Me.lbxArreglo1.FormattingEnabled = True
        Me.lbxArreglo1.ItemHeight = 16
        Me.lbxArreglo1.Location = New System.Drawing.Point(12, 61)
        Me.lbxArreglo1.Name = "lbxArreglo1"
        Me.lbxArreglo1.Size = New System.Drawing.Size(122, 116)
        Me.lbxArreglo1.TabIndex = 2
        '
        'lbxArreglo2
        '
        Me.lbxArreglo2.FormattingEnabled = True
        Me.lbxArreglo2.ItemHeight = 16
        Me.lbxArreglo2.Location = New System.Drawing.Point(140, 61)
        Me.lbxArreglo2.Name = "lbxArreglo2"
        Me.lbxArreglo2.Size = New System.Drawing.Size(122, 116)
        Me.lbxArreglo2.TabIndex = 3
        '
        'btnMostrar
        '
        Me.btnMostrar.Location = New System.Drawing.Point(12, 183)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(250, 28)
        Me.btnMostrar.TabIndex = 4
        Me.btnMostrar.Text = "Mostrar"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'btnSuma
        '
        Me.btnSuma.Location = New System.Drawing.Point(292, 12)
        Me.btnSuma.Name = "btnSuma"
        Me.btnSuma.Size = New System.Drawing.Size(159, 28)
        Me.btnSuma.TabIndex = 5
        Me.btnSuma.Text = "Sumar Inversamente"
        Me.btnSuma.UseVisualStyleBackColor = True
        '
        'lbxSuma
        '
        Me.lbxSuma.FormattingEnabled = True
        Me.lbxSuma.ItemHeight = 16
        Me.lbxSuma.Location = New System.Drawing.Point(292, 61)
        Me.lbxSuma.Name = "lbxSuma"
        Me.lbxSuma.Size = New System.Drawing.Size(159, 116)
        Me.lbxSuma.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 277)
        Me.Controls.Add(Me.lbxSuma)
        Me.Controls.Add(Me.btnSuma)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.lbxArreglo2)
        Me.Controls.Add(Me.lbxArreglo1)
        Me.Controls.Add(Me.btnCargar2)
        Me.Controls.Add(Me.btnCargar1)
        Me.Name = "Form1"
        Me.Text = " "
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCargar1 As System.Windows.Forms.Button
    Friend WithEvents btnCargar2 As System.Windows.Forms.Button
    Friend WithEvents lbxArreglo1 As System.Windows.Forms.ListBox
    Friend WithEvents lbxArreglo2 As System.Windows.Forms.ListBox
    Friend WithEvents btnMostrar As System.Windows.Forms.Button
    Friend WithEvents btnSuma As System.Windows.Forms.Button
    Friend WithEvents lbxSuma As System.Windows.Forms.ListBox

End Class

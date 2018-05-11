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
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.lbxArreglo = New System.Windows.Forms.ListBox()
        Me.btnPares = New System.Windows.Forms.Button()
        Me.btnImpares = New System.Windows.Forms.Button()
        Me.lblPar = New System.Windows.Forms.Label()
        Me.lblImpar = New System.Windows.Forms.Label()
        Me.btnTodos = New System.Windows.Forms.Button()
        Me.btnMayor = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCargar
        '
        Me.btnCargar.Location = New System.Drawing.Point(12, 12)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(143, 29)
        Me.btnCargar.TabIndex = 0
        Me.btnCargar.Text = "Cargar Arreglo"
        Me.btnCargar.UseVisualStyleBackColor = True
        '
        'lbxArreglo
        '
        Me.lbxArreglo.FormattingEnabled = True
        Me.lbxArreglo.ItemHeight = 16
        Me.lbxArreglo.Location = New System.Drawing.Point(12, 47)
        Me.lbxArreglo.Name = "lbxArreglo"
        Me.lbxArreglo.Size = New System.Drawing.Size(143, 164)
        Me.lbxArreglo.TabIndex = 1
        '
        'btnPares
        '
        Me.btnPares.Location = New System.Drawing.Point(166, 140)
        Me.btnPares.Name = "btnPares"
        Me.btnPares.Size = New System.Drawing.Size(69, 30)
        Me.btnPares.TabIndex = 2
        Me.btnPares.Text = "Pares"
        Me.btnPares.UseVisualStyleBackColor = True
        '
        'btnImpares
        '
        Me.btnImpares.Location = New System.Drawing.Point(236, 140)
        Me.btnImpares.Name = "btnImpares"
        Me.btnImpares.Size = New System.Drawing.Size(69, 30)
        Me.btnImpares.TabIndex = 3
        Me.btnImpares.Text = "Impares"
        Me.btnImpares.UseVisualStyleBackColor = True
        '
        'lblPar
        '
        Me.lblPar.AutoSize = True
        Me.lblPar.Location = New System.Drawing.Point(170, 12)
        Me.lblPar.Name = "lblPar"
        Me.lblPar.Size = New System.Drawing.Size(57, 17)
        Me.lblPar.TabIndex = 4
        Me.lblPar.Text = "Pares : "
        '
        'lblImpar
        '
        Me.lblImpar.AutoSize = True
        Me.lblImpar.Location = New System.Drawing.Point(170, 47)
        Me.lblImpar.Name = "lblImpar"
        Me.lblImpar.Size = New System.Drawing.Size(70, 17)
        Me.lblImpar.TabIndex = 5
        Me.lblImpar.Text = "Impares : "
        '
        'btnTodos
        '
        Me.btnTodos.Location = New System.Drawing.Point(166, 176)
        Me.btnTodos.Name = "btnTodos"
        Me.btnTodos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnTodos.Size = New System.Drawing.Size(139, 32)
        Me.btnTodos.TabIndex = 6
        Me.btnTodos.Text = "Mostrar Todos"
        Me.btnTodos.UseVisualStyleBackColor = True
        '
        'btnMayor
        '
        Me.btnMayor.Location = New System.Drawing.Point(166, 101)
        Me.btnMayor.Name = "btnMayor"
        Me.btnMayor.Size = New System.Drawing.Size(139, 33)
        Me.btnMayor.TabIndex = 7
        Me.btnMayor.Text = "Mayor"
        Me.btnMayor.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(329, 232)
        Me.Controls.Add(Me.btnMayor)
        Me.Controls.Add(Me.btnTodos)
        Me.Controls.Add(Me.lblImpar)
        Me.Controls.Add(Me.lblPar)
        Me.Controls.Add(Me.btnImpares)
        Me.Controls.Add(Me.btnPares)
        Me.Controls.Add(Me.lbxArreglo)
        Me.Controls.Add(Me.btnCargar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCargar As System.Windows.Forms.Button
    Friend WithEvents lbxArreglo As System.Windows.Forms.ListBox
    Friend WithEvents btnPares As System.Windows.Forms.Button
    Friend WithEvents btnImpares As System.Windows.Forms.Button
    Friend WithEvents lblPar As System.Windows.Forms.Label
    Friend WithEvents lblImpar As System.Windows.Forms.Label
    Friend WithEvents btnTodos As System.Windows.Forms.Button
    Friend WithEvents btnMayor As System.Windows.Forms.Button

End Class

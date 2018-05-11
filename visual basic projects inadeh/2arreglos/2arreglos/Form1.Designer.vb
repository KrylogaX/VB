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
        Me.btnArreglo2 = New System.Windows.Forms.Button()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.lbxArreglo1 = New System.Windows.Forms.ListBox()
        Me.lbxArreglo2 = New System.Windows.Forms.ListBox()
        Me.btnArreglo1 = New System.Windows.Forms.Button()
        Me.lbxSumar = New System.Windows.Forms.ListBox()
        Me.btnSumar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnArreglo2
        '
        Me.btnArreglo2.Location = New System.Drawing.Point(121, 14)
        Me.btnArreglo2.Name = "btnArreglo2"
        Me.btnArreglo2.Size = New System.Drawing.Size(103, 27)
        Me.btnArreglo2.TabIndex = 1
        Me.btnArreglo2.Text = "Cargar Arreglo 2"
        Me.btnArreglo2.UseVisualStyleBackColor = True
        '
        'btnMostrar
        '
        Me.btnMostrar.Location = New System.Drawing.Point(12, 197)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(212, 27)
        Me.btnMostrar.TabIndex = 2
        Me.btnMostrar.Text = "Mostrar"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'lbxArreglo1
        '
        Me.lbxArreglo1.FormattingEnabled = True
        Me.lbxArreglo1.Location = New System.Drawing.Point(12, 47)
        Me.lbxArreglo1.Name = "lbxArreglo1"
        Me.lbxArreglo1.Size = New System.Drawing.Size(103, 147)
        Me.lbxArreglo1.TabIndex = 3
        '
        'lbxArreglo2
        '
        Me.lbxArreglo2.FormattingEnabled = True
        Me.lbxArreglo2.Location = New System.Drawing.Point(121, 47)
        Me.lbxArreglo2.Name = "lbxArreglo2"
        Me.lbxArreglo2.Size = New System.Drawing.Size(103, 147)
        Me.lbxArreglo2.TabIndex = 4
        '
        'btnArreglo1
        '
        Me.btnArreglo1.Location = New System.Drawing.Point(12, 14)
        Me.btnArreglo1.Name = "btnArreglo1"
        Me.btnArreglo1.Size = New System.Drawing.Size(103, 27)
        Me.btnArreglo1.TabIndex = 5
        Me.btnArreglo1.Text = "Cargar Arreglo 1"
        Me.btnArreglo1.UseVisualStyleBackColor = True
        '
        'lbxSumar
        '
        Me.lbxSumar.FormattingEnabled = True
        Me.lbxSumar.Location = New System.Drawing.Point(230, 47)
        Me.lbxSumar.Name = "lbxSumar"
        Me.lbxSumar.Size = New System.Drawing.Size(140, 147)
        Me.lbxSumar.TabIndex = 6
        '
        'btnSumar
        '
        Me.btnSumar.Location = New System.Drawing.Point(230, 14)
        Me.btnSumar.Name = "btnSumar"
        Me.btnSumar.Size = New System.Drawing.Size(140, 27)
        Me.btnSumar.TabIndex = 7
        Me.btnSumar.Text = "Sumar"
        Me.btnSumar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 233)
        Me.Controls.Add(Me.btnSumar)
        Me.Controls.Add(Me.lbxSumar)
        Me.Controls.Add(Me.btnArreglo1)
        Me.Controls.Add(Me.lbxArreglo2)
        Me.Controls.Add(Me.lbxArreglo1)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.btnArreglo2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnArreglo2 As Button
    Friend WithEvents btnMostrar As Button
    Friend WithEvents lbxArreglo1 As ListBox
    Friend WithEvents lbxArreglo2 As ListBox
    Friend WithEvents btnArreglo1 As Button
    Friend WithEvents lbxSumar As ListBox
    Friend WithEvents btnSumar As Button
End Class

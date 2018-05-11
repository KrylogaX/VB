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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbxIngresar1 = New System.Windows.Forms.TextBox()
        Me.tbxIngresar2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSuma = New System.Windows.Forms.Button()
        Me.btnResta = New System.Windows.Forms.Button()
        Me.btnMulti = New System.Windows.Forms.Button()
        Me.btnDivision = New System.Windows.Forms.Button()
        Me.btnCantidad = New System.Windows.Forms.Button()
        Me.lbxMostrar = New System.Windows.Forms.ListBox()
        Me.tbxArreglo = New System.Windows.Forms.Button()
        Me.btnPromedio = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'tbxIngresar1
        '
        Me.tbxIngresar1.Location = New System.Drawing.Point(143, 8)
        Me.tbxIngresar1.Name = "tbxIngresar1"
        Me.tbxIngresar1.Size = New System.Drawing.Size(100, 22)
        Me.tbxIngresar1.TabIndex = 1
        '
        'tbxIngresar2
        '
        Me.tbxIngresar2.Location = New System.Drawing.Point(143, 66)
        Me.tbxIngresar2.Name = "tbxIngresar2"
        Me.tbxIngresar2.Size = New System.Drawing.Size(100, 22)
        Me.tbxIngresar2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Label2"
        '
        'btnSuma
        '
        Me.btnSuma.Location = New System.Drawing.Point(12, 125)
        Me.btnSuma.Name = "btnSuma"
        Me.btnSuma.Size = New System.Drawing.Size(75, 23)
        Me.btnSuma.TabIndex = 4
        Me.btnSuma.Text = "Suma"
        Me.btnSuma.UseVisualStyleBackColor = True
        '
        'btnResta
        '
        Me.btnResta.Location = New System.Drawing.Point(93, 125)
        Me.btnResta.Name = "btnResta"
        Me.btnResta.Size = New System.Drawing.Size(75, 23)
        Me.btnResta.TabIndex = 5
        Me.btnResta.Text = "Resta"
        Me.btnResta.UseVisualStyleBackColor = True
        '
        'btnMulti
        '
        Me.btnMulti.Location = New System.Drawing.Point(174, 125)
        Me.btnMulti.Name = "btnMulti"
        Me.btnMulti.Size = New System.Drawing.Size(75, 23)
        Me.btnMulti.TabIndex = 6
        Me.btnMulti.Text = "Multi"
        Me.btnMulti.UseVisualStyleBackColor = True
        '
        'btnDivision
        '
        Me.btnDivision.Location = New System.Drawing.Point(255, 125)
        Me.btnDivision.Name = "btnDivision"
        Me.btnDivision.Size = New System.Drawing.Size(75, 23)
        Me.btnDivision.TabIndex = 7
        Me.btnDivision.Text = "Division"
        Me.btnDivision.UseVisualStyleBackColor = True
        '
        'btnCantidad
        '
        Me.btnCantidad.Location = New System.Drawing.Point(12, 261)
        Me.btnCantidad.Name = "btnCantidad"
        Me.btnCantidad.Size = New System.Drawing.Size(86, 23)
        Me.btnCantidad.TabIndex = 9
        Me.btnCantidad.Text = "Cantidad"
        Me.btnCantidad.UseVisualStyleBackColor = True
        '
        'lbxMostrar
        '
        Me.lbxMostrar.FormattingEnabled = True
        Me.lbxMostrar.ItemHeight = 16
        Me.lbxMostrar.Location = New System.Drawing.Point(143, 217)
        Me.lbxMostrar.Name = "lbxMostrar"
        Me.lbxMostrar.Size = New System.Drawing.Size(120, 164)
        Me.lbxMostrar.TabIndex = 10
        '
        'tbxArreglo
        '
        Me.tbxArreglo.Location = New System.Drawing.Point(316, 217)
        Me.tbxArreglo.Name = "tbxArreglo"
        Me.tbxArreglo.Size = New System.Drawing.Size(86, 23)
        Me.tbxArreglo.TabIndex = 11
        Me.tbxArreglo.Text = "Arreglo"
        Me.tbxArreglo.UseVisualStyleBackColor = True
        '
        'btnPromedio
        '
        Me.btnPromedio.Location = New System.Drawing.Point(316, 302)
        Me.btnPromedio.Name = "btnPromedio"
        Me.btnPromedio.Size = New System.Drawing.Size(134, 52)
        Me.btnPromedio.TabIndex = 12
        Me.btnPromedio.Text = "Promedio Arreglo"
        Me.btnPromedio.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(585, 435)
        Me.Controls.Add(Me.btnPromedio)
        Me.Controls.Add(Me.tbxArreglo)
        Me.Controls.Add(Me.lbxMostrar)
        Me.Controls.Add(Me.btnCantidad)
        Me.Controls.Add(Me.btnDivision)
        Me.Controls.Add(Me.btnMulti)
        Me.Controls.Add(Me.btnResta)
        Me.Controls.Add(Me.btnSuma)
        Me.Controls.Add(Me.tbxIngresar2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbxIngresar1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tbxIngresar1 As TextBox
    Friend WithEvents tbxIngresar2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSuma As Button
    Friend WithEvents btnResta As Button
    Friend WithEvents btnMulti As Button
    Friend WithEvents btnDivision As Button
    Friend WithEvents btnCantidad As Button
    Friend WithEvents lbxMostrar As ListBox
    Friend WithEvents tbxArreglo As Button
    Friend WithEvents btnPromedio As Button
End Class

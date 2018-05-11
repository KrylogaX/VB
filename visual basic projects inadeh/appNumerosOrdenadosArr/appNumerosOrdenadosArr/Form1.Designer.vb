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
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.tbxIngresar = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.btnDescendente = New System.Windows.Forms.Button()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Location = New System.Drawing.Point(12, 30)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(62, 17)
        Me.lblNumero.TabIndex = 8
        Me.lblNumero.Text = "Numero:"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(216, 27)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(121, 47)
        Me.btnAgregar.TabIndex = 7
        Me.btnAgregar.Text = "Agregar Numero"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'tbxIngresar
        '
        Me.tbxIngresar.Location = New System.Drawing.Point(12, 53)
        Me.tbxIngresar.Name = "tbxIngresar"
        Me.tbxIngresar.Size = New System.Drawing.Size(177, 22)
        Me.tbxIngresar.TabIndex = 6
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(12, 126)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(325, 196)
        Me.ListBox1.TabIndex = 5
        '
        'btnDescendente
        '
        Me.btnDescendente.Location = New System.Drawing.Point(361, 126)
        Me.btnDescendente.Name = "btnDescendente"
        Me.btnDescendente.Size = New System.Drawing.Size(211, 47)
        Me.btnDescendente.TabIndex = 9
        Me.btnDescendente.Text = "Mostrar Ordenados Descendente"
        Me.btnDescendente.UseVisualStyleBackColor = True
        '
        'btnMostrar
        '
        Me.btnMostrar.Location = New System.Drawing.Point(361, 179)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(211, 47)
        Me.btnMostrar.TabIndex = 10
        Me.btnMostrar.Text = "Mostrar Arreglo"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 361)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.btnDescendente)
        Me.Controls.Add(Me.lblNumero)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.tbxIngresar)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNumero As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents tbxIngresar As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents btnDescendente As Button
    Friend WithEvents btnMostrar As Button
End Class

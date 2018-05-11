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
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.tbxNombre = New System.Windows.Forms.TextBox()
        Me.tbxEdad = New System.Windows.Forms.TextBox()
        Me.lblEdad = New System.Windows.Forms.Label()
        Me.tbxRaza = New System.Windows.Forms.TextBox()
        Me.lblRaza = New System.Windows.Forms.Label()
        Me.tbxAmo = New System.Windows.Forms.TextBox()
        Me.lblAmo = New System.Windows.Forms.Label()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(50, 46)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(58, 17)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(53, 281)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(288, 52)
        Me.btnAgregar.TabIndex = 1
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'tbxNombre
        '
        Me.tbxNombre.Location = New System.Drawing.Point(135, 46)
        Me.tbxNombre.Name = "tbxNombre"
        Me.tbxNombre.Size = New System.Drawing.Size(206, 22)
        Me.tbxNombre.TabIndex = 2
        '
        'tbxEdad
        '
        Me.tbxEdad.Location = New System.Drawing.Point(135, 110)
        Me.tbxEdad.Name = "tbxEdad"
        Me.tbxEdad.Size = New System.Drawing.Size(206, 22)
        Me.tbxEdad.TabIndex = 4
        '
        'lblEdad
        '
        Me.lblEdad.AutoEllipsis = True
        Me.lblEdad.AutoSize = True
        Me.lblEdad.Location = New System.Drawing.Point(50, 110)
        Me.lblEdad.Name = "lblEdad"
        Me.lblEdad.Size = New System.Drawing.Size(41, 17)
        Me.lblEdad.TabIndex = 3
        Me.lblEdad.Text = "Edad"
        '
        'tbxRaza
        '
        Me.tbxRaza.Location = New System.Drawing.Point(135, 173)
        Me.tbxRaza.Name = "tbxRaza"
        Me.tbxRaza.Size = New System.Drawing.Size(206, 22)
        Me.tbxRaza.TabIndex = 6
        '
        'lblRaza
        '
        Me.lblRaza.AutoSize = True
        Me.lblRaza.Location = New System.Drawing.Point(50, 173)
        Me.lblRaza.Name = "lblRaza"
        Me.lblRaza.Size = New System.Drawing.Size(41, 17)
        Me.lblRaza.TabIndex = 5
        Me.lblRaza.Text = "Raza"
        '
        'tbxAmo
        '
        Me.tbxAmo.Location = New System.Drawing.Point(135, 239)
        Me.tbxAmo.Name = "tbxAmo"
        Me.tbxAmo.Size = New System.Drawing.Size(206, 22)
        Me.tbxAmo.TabIndex = 8
        '
        'lblAmo
        '
        Me.lblAmo.AutoSize = True
        Me.lblAmo.Location = New System.Drawing.Point(50, 239)
        Me.lblAmo.Name = "lblAmo"
        Me.lblAmo.Size = New System.Drawing.Size(36, 17)
        Me.lblAmo.TabIndex = 7
        Me.lblAmo.Text = "Amo"
        '
        'btnMostrar
        '
        Me.btnMostrar.Location = New System.Drawing.Point(53, 339)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(288, 52)
        Me.btnMostrar.TabIndex = 9
        Me.btnMostrar.Text = "Mostrar"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(400, 41)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(479, 340)
        Me.ListBox1.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(915, 421)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.tbxAmo)
        Me.Controls.Add(Me.lblAmo)
        Me.Controls.Add(Me.tbxRaza)
        Me.Controls.Add(Me.lblRaza)
        Me.Controls.Add(Me.tbxEdad)
        Me.Controls.Add(Me.lblEdad)
        Me.Controls.Add(Me.tbxNombre)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.lblNombre)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNombre As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents tbxNombre As TextBox
    Friend WithEvents tbxEdad As TextBox
    Friend WithEvents lblEdad As Label
    Friend WithEvents tbxRaza As TextBox
    Friend WithEvents lblRaza As Label
    Friend WithEvents tbxAmo As TextBox
    Friend WithEvents lblAmo As Label
    Friend WithEvents btnMostrar As Button
    Friend WithEvents ListBox1 As ListBox
End Class

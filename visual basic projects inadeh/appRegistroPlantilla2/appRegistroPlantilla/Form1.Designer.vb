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
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.lbxInfo = New System.Windows.Forms.ListBox()
        Me.tbxEdad = New System.Windows.Forms.TextBox()
        Me.lblEdad = New System.Windows.Forms.Label()
        Me.lblRaza = New System.Windows.Forms.Label()
        Me.tbxNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnBuscarXEdad = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.tbxde = New System.Windows.Forms.TextBox()
        Me.tbxhasta = New System.Windows.Forms.TextBox()
        Me.btnBuscarXRaza = New System.Windows.Forms.Button()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnMostrar
        '
        Me.btnMostrar.Location = New System.Drawing.Point(26, 288)
        Me.btnMostrar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(128, 26)
        Me.btnMostrar.TabIndex = 0
        Me.btnMostrar.Text = "Mostrar "
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'lbxInfo
        '
        Me.lbxInfo.FormattingEnabled = True
        Me.lbxInfo.Location = New System.Drawing.Point(196, 10)
        Me.lbxInfo.Margin = New System.Windows.Forms.Padding(2)
        Me.lbxInfo.Name = "lbxInfo"
        Me.lbxInfo.Size = New System.Drawing.Size(266, 368)
        Me.lbxInfo.TabIndex = 1
        '
        'tbxEdad
        '
        Me.tbxEdad.Location = New System.Drawing.Point(33, 200)
        Me.tbxEdad.Margin = New System.Windows.Forms.Padding(2)
        Me.tbxEdad.Name = "tbxEdad"
        Me.tbxEdad.Size = New System.Drawing.Size(121, 20)
        Me.tbxEdad.TabIndex = 25
        '
        'lblEdad
        '
        Me.lblEdad.AutoSize = True
        Me.lblEdad.Location = New System.Drawing.Point(59, 158)
        Me.lblEdad.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEdad.Name = "lblEdad"
        Me.lblEdad.Size = New System.Drawing.Size(32, 13)
        Me.lblEdad.TabIndex = 24
        Me.lblEdad.Text = "Edad"
        '
        'lblRaza
        '
        Me.lblRaza.AutoEllipsis = True
        Me.lblRaza.AutoSize = True
        Me.lblRaza.Location = New System.Drawing.Point(69, 86)
        Me.lblRaza.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRaza.Name = "lblRaza"
        Me.lblRaza.Size = New System.Drawing.Size(32, 13)
        Me.lblRaza.TabIndex = 22
        Me.lblRaza.Text = "Raza"
        '
        'tbxNombre
        '
        Me.tbxNombre.Location = New System.Drawing.Point(34, 49)
        Me.tbxNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.tbxNombre.Name = "tbxNombre"
        Me.tbxNombre.Size = New System.Drawing.Size(120, 20)
        Me.tbxNombre.TabIndex = 21
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(69, 21)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 20
        Me.lblNombre.Text = "Nombre"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(26, 258)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(128, 26)
        Me.btnAgregar.TabIndex = 26
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnBuscarXEdad
        '
        Me.btnBuscarXEdad.Location = New System.Drawing.Point(26, 348)
        Me.btnBuscarXEdad.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBuscarXEdad.Name = "btnBuscarXEdad"
        Me.btnBuscarXEdad.Size = New System.Drawing.Size(128, 26)
        Me.btnBuscarXEdad.TabIndex = 27
        Me.btnBuscarXEdad.Text = "Buscar X Edad"
        Me.btnBuscarXEdad.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Chihuahua", "Salchicha", "Dalmata", "Pastor Aleman"})
        Me.ComboBox1.Location = New System.Drawing.Point(33, 119)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 28
        '
        'tbxde
        '
        Me.tbxde.Location = New System.Drawing.Point(26, 320)
        Me.tbxde.Name = "tbxde"
        Me.tbxde.Size = New System.Drawing.Size(37, 20)
        Me.tbxde.TabIndex = 29
        '
        'tbxhasta
        '
        Me.tbxhasta.Location = New System.Drawing.Point(107, 323)
        Me.tbxhasta.Name = "tbxhasta"
        Me.tbxhasta.Size = New System.Drawing.Size(47, 20)
        Me.tbxhasta.TabIndex = 30
        '
        'btnBuscarXRaza
        '
        Me.btnBuscarXRaza.Location = New System.Drawing.Point(26, 412)
        Me.btnBuscarXRaza.Name = "btnBuscarXRaza"
        Me.btnBuscarXRaza.Size = New System.Drawing.Size(121, 23)
        Me.btnBuscarXRaza.TabIndex = 31
        Me.btnBuscarXRaza.Text = "Buscar X Raza"
        Me.btnBuscarXRaza.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Chihuahua", "Salchicha", "Dalmata", "Pastor Aleman"})
        Me.ComboBox2.Location = New System.Drawing.Point(26, 385)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 33
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 447)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.btnBuscarXRaza)
        Me.Controls.Add(Me.tbxhasta)
        Me.Controls.Add(Me.tbxde)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.btnBuscarXEdad)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.tbxEdad)
        Me.Controls.Add(Me.lblEdad)
        Me.Controls.Add(Me.lblRaza)
        Me.Controls.Add(Me.tbxNombre)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lbxInfo)
        Me.Controls.Add(Me.btnMostrar)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "RECORDERIS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnMostrar As Button
    Friend WithEvents lbxInfo As ListBox
    Friend WithEvents tbxEdad As TextBox
    Friend WithEvents lblEdad As Label
    Friend WithEvents lblRaza As Label
    Friend WithEvents tbxNombre As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnBuscarXEdad As Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents tbxde As System.Windows.Forms.TextBox
    Friend WithEvents tbxhasta As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscarXRaza As System.Windows.Forms.Button
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
End Class

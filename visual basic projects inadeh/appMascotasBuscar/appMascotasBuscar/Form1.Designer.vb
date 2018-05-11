<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.cmbRaza = New System.Windows.Forms.ComboBox()
        Me.bntBuscar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.lblRaza = New System.Windows.Forms.Label()
        Me.tbxEdad = New System.Windows.Forms.TextBox()
        Me.lblEdad = New System.Windows.Forms.Label()
        Me.tbxNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.btnMostrarTodos = New System.Windows.Forms.Button()
        Me.lbxInfo = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbxDesde = New System.Windows.Forms.TextBox()
        Me.tbxHasta = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbRazaBuscar = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbRaza
        '
        Me.cmbRaza.FormattingEnabled = True
        Me.cmbRaza.Items.AddRange(New Object() {"Chihuahua", "Salchicha", "Dalmata", "Pastor Aleman"})
        Me.cmbRaza.Location = New System.Drawing.Point(103, 149)
        Me.cmbRaza.Name = "cmbRaza"
        Me.cmbRaza.Size = New System.Drawing.Size(159, 24)
        Me.cmbRaza.TabIndex = 40
        '
        'bntBuscar
        '
        Me.bntBuscar.Location = New System.Drawing.Point(18, 169)
        Me.bntBuscar.Name = "bntBuscar"
        Me.bntBuscar.Size = New System.Drawing.Size(232, 32)
        Me.bntBuscar.TabIndex = 39
        Me.bntBuscar.Text = "Buscar"
        Me.bntBuscar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(21, 218)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(170, 32)
        Me.btnAgregar.TabIndex = 38
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'lblRaza
        '
        Me.lblRaza.AutoSize = True
        Me.lblRaza.Location = New System.Drawing.Point(18, 152)
        Me.lblRaza.Name = "lblRaza"
        Me.lblRaza.Size = New System.Drawing.Size(41, 17)
        Me.lblRaza.TabIndex = 36
        Me.lblRaza.Text = "Raza"
        '
        'tbxEdad
        '
        Me.tbxEdad.Location = New System.Drawing.Point(103, 89)
        Me.tbxEdad.Name = "tbxEdad"
        Me.tbxEdad.Size = New System.Drawing.Size(159, 22)
        Me.tbxEdad.TabIndex = 35
        '
        'lblEdad
        '
        Me.lblEdad.AutoEllipsis = True
        Me.lblEdad.AutoSize = True
        Me.lblEdad.Location = New System.Drawing.Point(18, 89)
        Me.lblEdad.Name = "lblEdad"
        Me.lblEdad.Size = New System.Drawing.Size(41, 17)
        Me.lblEdad.TabIndex = 34
        Me.lblEdad.Text = "Edad"
        '
        'tbxNombre
        '
        Me.tbxNombre.Location = New System.Drawing.Point(103, 25)
        Me.tbxNombre.Name = "tbxNombre"
        Me.tbxNombre.Size = New System.Drawing.Size(159, 22)
        Me.tbxNombre.TabIndex = 33
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(18, 25)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(58, 17)
        Me.lblNombre.TabIndex = 32
        Me.lblNombre.Text = "Nombre"
        '
        'btnMostrarTodos
        '
        Me.btnMostrarTodos.Location = New System.Drawing.Point(21, 279)
        Me.btnMostrarTodos.Name = "btnMostrarTodos"
        Me.btnMostrarTodos.Size = New System.Drawing.Size(170, 32)
        Me.btnMostrarTodos.TabIndex = 31
        Me.btnMostrarTodos.Text = "Mostrar Todos"
        Me.btnMostrarTodos.UseVisualStyleBackColor = True
        '
        'lbxInfo
        '
        Me.lbxInfo.FormattingEnabled = True
        Me.lbxInfo.ItemHeight = 16
        Me.lbxInfo.Location = New System.Drawing.Point(296, 12)
        Me.lbxInfo.Name = "lbxInfo"
        Me.lbxInfo.Size = New System.Drawing.Size(449, 468)
        Me.lbxInfo.TabIndex = 30
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbRazaBuscar)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tbxHasta)
        Me.GroupBox1.Controls.Add(Me.tbxDesde)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.bntBuscar)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 339)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(278, 219)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 17)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Desde"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(130, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Hasta"
        '
        'tbxDesde
        '
        Me.tbxDesde.Location = New System.Drawing.Point(61, 62)
        Me.tbxDesde.Name = "tbxDesde"
        Me.tbxDesde.Size = New System.Drawing.Size(63, 22)
        Me.tbxDesde.TabIndex = 42
        Me.tbxDesde.Text = "0"
        '
        'tbxHasta
        '
        Me.tbxHasta.Location = New System.Drawing.Point(181, 62)
        Me.tbxHasta.Name = "tbxHasta"
        Me.tbxHasta.Size = New System.Drawing.Size(63, 22)
        Me.tbxHasta.TabIndex = 44
        Me.tbxHasta.Text = "100"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 17)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Por edad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 17)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Por Raza"
        '
        'cmbRazaBuscar
        '
        Me.cmbRazaBuscar.FormattingEnabled = True
        Me.cmbRazaBuscar.Items.AddRange(New Object() {"Chihuahua", "Salchicha", "Dalmata", "Pastor Aleman"})
        Me.cmbRazaBuscar.Location = New System.Drawing.Point(85, 100)
        Me.cmbRazaBuscar.Name = "cmbRazaBuscar"
        Me.cmbRazaBuscar.Size = New System.Drawing.Size(159, 24)
        Me.cmbRazaBuscar.TabIndex = 42
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(757, 601)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmbRaza)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.lblRaza)
        Me.Controls.Add(Me.tbxEdad)
        Me.Controls.Add(Me.lblEdad)
        Me.Controls.Add(Me.tbxNombre)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.btnMostrarTodos)
        Me.Controls.Add(Me.lbxInfo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbRaza As ComboBox
    Friend WithEvents bntBuscar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents lblRaza As Label
    Friend WithEvents tbxEdad As TextBox
    Friend WithEvents lblEdad As Label
    Friend WithEvents tbxNombre As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents btnMostrarTodos As Button
    Friend WithEvents lbxInfo As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbRazaBuscar As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbxHasta As TextBox
    Friend WithEvents tbxDesde As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class

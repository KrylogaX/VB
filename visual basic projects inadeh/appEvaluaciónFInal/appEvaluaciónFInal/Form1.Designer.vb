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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.tbxCantMaletas = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbxDestino = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbxNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbxCedula = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnListar = New System.Windows.Forms.Button()
        Me.lbxPasajeros = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txbTotalVent = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnRegistrar)
        Me.GroupBox1.Controls.Add(Me.tbxCantMaletas)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tbxDestino)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tbxNombre)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.tbxCedula)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(516, 270)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registrar Pasajero"
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Location = New System.Drawing.Point(9, 222)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(251, 31)
        Me.btnRegistrar.TabIndex = 8
        Me.btnRegistrar.Text = "Registrar pasajero"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'tbxCantMaletas
        '
        Me.tbxCantMaletas.Location = New System.Drawing.Point(149, 178)
        Me.tbxCantMaletas.Name = "tbxCantMaletas"
        Me.tbxCantMaletas.Size = New System.Drawing.Size(112, 22)
        Me.tbxCantMaletas.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Cantidad de maletas"
        '
        'tbxDestino
        '
        Me.tbxDestino.Location = New System.Drawing.Point(109, 132)
        Me.tbxDestino.Name = "tbxDestino"
        Me.tbxDestino.Size = New System.Drawing.Size(152, 22)
        Me.tbxDestino.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Destino"
        '
        'tbxNombre
        '
        Me.tbxNombre.Location = New System.Drawing.Point(109, 86)
        Me.tbxNombre.Name = "tbxNombre"
        Me.tbxNombre.Size = New System.Drawing.Size(152, 22)
        Me.tbxNombre.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre"
        '
        'tbxCedula
        '
        Me.tbxCedula.Location = New System.Drawing.Point(109, 44)
        Me.tbxCedula.Name = "tbxCedula"
        Me.tbxCedula.Size = New System.Drawing.Size(152, 22)
        Me.tbxCedula.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cedula"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txbTotalVent)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.btnListar)
        Me.GroupBox2.Controls.Add(Me.lbxPasajeros)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 286)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(516, 319)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listar Pasajero"
        '
        'btnListar
        '
        Me.btnListar.Location = New System.Drawing.Point(0, 280)
        Me.btnListar.Name = "btnListar"
        Me.btnListar.Size = New System.Drawing.Size(242, 33)
        Me.btnListar.TabIndex = 1
        Me.btnListar.Text = "Listar pasajeros"
        Me.btnListar.UseVisualStyleBackColor = True
        '
        'lbxPasajeros
        '
        Me.lbxPasajeros.FormattingEnabled = True
        Me.lbxPasajeros.ItemHeight = 16
        Me.lbxPasajeros.Location = New System.Drawing.Point(9, 21)
        Me.lbxPasajeros.Name = "lbxPasajeros"
        Me.lbxPasajeros.Size = New System.Drawing.Size(328, 244)
        Me.lbxPasajeros.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(368, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 17)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Total Ventas"
        '
        'txbTotalVent
        '
        Me.txbTotalVent.Enabled = False
        Me.txbTotalVent.Location = New System.Drawing.Point(371, 100)
        Me.txbTotalVent.Name = "txbTotalVent"
        Me.txbTotalVent.Size = New System.Drawing.Size(85, 22)
        Me.txbTotalVent.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(539, 617)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tbxCantMaletas As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbxDestino As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbxNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbxCedula As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents btnListar As Button
    Friend WithEvents lbxPasajeros As ListBox
    Friend WithEvents txbTotalVent As TextBox
    Friend WithEvents Label5 As Label
End Class

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
        Me.btnDonacion = New System.Windows.Forms.Button()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.lbxLista = New System.Windows.Forms.ListBox()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.tbxNombre = New System.Windows.Forms.TextBox()
        Me.tbxMonto = New System.Windows.Forms.TextBox()
        Me.lblMonto = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnDonacion
        '
        Me.btnDonacion.Location = New System.Drawing.Point(64, 46)
        Me.btnDonacion.Name = "btnDonacion"
        Me.btnDonacion.Size = New System.Drawing.Size(144, 53)
        Me.btnDonacion.TabIndex = 0
        Me.btnDonacion.Text = "Nueva Donacion"
        Me.btnDonacion.UseVisualStyleBackColor = True
        '
        'btnMostrar
        '
        Me.btnMostrar.Location = New System.Drawing.Point(214, 46)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(144, 53)
        Me.btnMostrar.TabIndex = 1
        Me.btnMostrar.Text = "Mostrar Donaciones"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'lbxLista
        '
        Me.lbxLista.FormattingEnabled = True
        Me.lbxLista.ItemHeight = 16
        Me.lbxLista.Location = New System.Drawing.Point(64, 179)
        Me.lbxLista.Name = "lbxLista"
        Me.lbxLista.Size = New System.Drawing.Size(293, 228)
        Me.lbxLista.TabIndex = 2
        '
        'btnTotal
        '
        Me.btnTotal.Location = New System.Drawing.Point(64, 413)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(106, 52)
        Me.btnTotal.TabIndex = 3
        Me.btnTotal.Text = "Total Donaciones"
        Me.btnTotal.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(186, 431)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(123, 17)
        Me.lblTotal.TabIndex = 4
        Me.lblTotal.Text = "Total Donaciones:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(61, 120)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(58, 17)
        Me.lblNombre.TabIndex = 5
        Me.lblNombre.Text = "Nombre"
        '
        'tbxNombre
        '
        Me.tbxNombre.Location = New System.Drawing.Point(64, 151)
        Me.tbxNombre.Name = "tbxNombre"
        Me.tbxNombre.Size = New System.Drawing.Size(100, 22)
        Me.tbxNombre.TabIndex = 6
        '
        'tbxMonto
        '
        Me.tbxMonto.Location = New System.Drawing.Point(214, 151)
        Me.tbxMonto.Name = "tbxMonto"
        Me.tbxMonto.Size = New System.Drawing.Size(100, 22)
        Me.tbxMonto.TabIndex = 8
        '
        'lblMonto
        '
        Me.lblMonto.AutoSize = True
        Me.lblMonto.Location = New System.Drawing.Point(211, 120)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(47, 17)
        Me.lblMonto.TabIndex = 7
        Me.lblMonto.Text = "Monto"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 526)
        Me.Controls.Add(Me.tbxMonto)
        Me.Controls.Add(Me.lblMonto)
        Me.Controls.Add(Me.tbxNombre)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnTotal)
        Me.Controls.Add(Me.lbxLista)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.btnDonacion)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDonacion As Button
    Friend WithEvents btnMostrar As Button
    Friend WithEvents lbxLista As ListBox
    Friend WithEvents btnTotal As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents tbxNombre As TextBox
    Friend WithEvents tbxMonto As TextBox
    Friend WithEvents lblMonto As Label
End Class

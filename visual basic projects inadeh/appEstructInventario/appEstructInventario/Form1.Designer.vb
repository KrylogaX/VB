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
        Me.lbxLista = New System.Windows.Forms.ListBox()
        Me.btnListar = New System.Windows.Forms.Button()
        Me.tbxCantidad = New System.Windows.Forms.TextBox()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.tbxPrecioUnidad = New System.Windows.Forms.TextBox()
        Me.lblPrecioUnidad = New System.Windows.Forms.Label()
        Me.tbxDescripcion = New System.Windows.Forms.TextBox()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.tbxCodigo = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbxLista
        '
        Me.lbxLista.FormattingEnabled = True
        Me.lbxLista.ItemHeight = 16
        Me.lbxLista.Location = New System.Drawing.Point(370, 44)
        Me.lbxLista.Name = "lbxLista"
        Me.lbxLista.Size = New System.Drawing.Size(479, 340)
        Me.lbxLista.TabIndex = 21
        '
        'btnListar
        '
        Me.btnListar.Location = New System.Drawing.Point(23, 342)
        Me.btnListar.Name = "btnListar"
        Me.btnListar.Size = New System.Drawing.Size(288, 52)
        Me.btnListar.TabIndex = 20
        Me.btnListar.Text = "Listar"
        Me.btnListar.UseVisualStyleBackColor = True
        '
        'tbxCantidad
        '
        Me.tbxCantidad.Location = New System.Drawing.Point(105, 242)
        Me.tbxCantidad.Name = "tbxCantidad"
        Me.tbxCantidad.Size = New System.Drawing.Size(206, 22)
        Me.tbxCantidad.TabIndex = 19
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Location = New System.Drawing.Point(20, 242)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(64, 17)
        Me.lblCantidad.TabIndex = 18
        Me.lblCantidad.Text = "Cantidad"
        '
        'tbxPrecioUnidad
        '
        Me.tbxPrecioUnidad.Location = New System.Drawing.Point(123, 176)
        Me.tbxPrecioUnidad.Name = "tbxPrecioUnidad"
        Me.tbxPrecioUnidad.Size = New System.Drawing.Size(188, 22)
        Me.tbxPrecioUnidad.TabIndex = 17
        '
        'lblPrecioUnidad
        '
        Me.lblPrecioUnidad.AutoSize = True
        Me.lblPrecioUnidad.Location = New System.Drawing.Point(20, 176)
        Me.lblPrecioUnidad.Name = "lblPrecioUnidad"
        Me.lblPrecioUnidad.Size = New System.Drawing.Size(97, 17)
        Me.lblPrecioUnidad.TabIndex = 16
        Me.lblPrecioUnidad.Text = "Precio Unidad"
        '
        'tbxDescripcion
        '
        Me.tbxDescripcion.Location = New System.Drawing.Point(105, 113)
        Me.tbxDescripcion.Name = "tbxDescripcion"
        Me.tbxDescripcion.Size = New System.Drawing.Size(206, 22)
        Me.tbxDescripcion.TabIndex = 15
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoEllipsis = True
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(20, 113)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(82, 17)
        Me.lblDescripcion.TabIndex = 14
        Me.lblDescripcion.Text = "Descripcion"
        '
        'tbxCodigo
        '
        Me.tbxCodigo.Location = New System.Drawing.Point(105, 49)
        Me.tbxCodigo.Name = "tbxCodigo"
        Me.tbxCodigo.Size = New System.Drawing.Size(206, 22)
        Me.tbxCodigo.TabIndex = 13
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(23, 284)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(288, 52)
        Me.btnAgregar.TabIndex = 12
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(20, 49)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(52, 17)
        Me.lblCodigo.TabIndex = 11
        Me.lblCodigo.Text = "Codigo"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 462)
        Me.Controls.Add(Me.lbxLista)
        Me.Controls.Add(Me.btnListar)
        Me.Controls.Add(Me.tbxCantidad)
        Me.Controls.Add(Me.lblCantidad)
        Me.Controls.Add(Me.tbxPrecioUnidad)
        Me.Controls.Add(Me.lblPrecioUnidad)
        Me.Controls.Add(Me.tbxDescripcion)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.tbxCodigo)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.lblCodigo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbxLista As ListBox
    Friend WithEvents btnListar As Button
    Friend WithEvents tbxCantidad As TextBox
    Friend WithEvents lblCantidad As Label
    Friend WithEvents tbxPrecioUnidad As TextBox
    Friend WithEvents lblPrecioUnidad As Label
    Friend WithEvents tbxDescripcion As TextBox
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents tbxCodigo As TextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents lblCodigo As Label
End Class

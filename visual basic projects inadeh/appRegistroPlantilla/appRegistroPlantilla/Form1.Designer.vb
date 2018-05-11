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
        Me.btnMostrarPlanilla = New System.Windows.Forms.Button()
        Me.lbxInfo = New System.Windows.Forms.ListBox()
        Me.btnMostrarImpuestos = New System.Windows.Forms.Button()
        Me.tbxSalarioBruto = New System.Windows.Forms.TextBox()
        Me.lblSalarioBruto = New System.Windows.Forms.Label()
        Me.tbxCodigo = New System.Windows.Forms.TextBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.tbxNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.bntBuscar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnMostrarPlanilla
        '
        Me.btnMostrarPlanilla.Location = New System.Drawing.Point(14, 317)
        Me.btnMostrarPlanilla.Name = "btnMostrarPlanilla"
        Me.btnMostrarPlanilla.Size = New System.Drawing.Size(170, 32)
        Me.btnMostrarPlanilla.TabIndex = 0
        Me.btnMostrarPlanilla.Text = "Mostrar Planilla"
        Me.btnMostrarPlanilla.UseVisualStyleBackColor = True
        '
        'lbxInfo
        '
        Me.lbxInfo.FormattingEnabled = True
        Me.lbxInfo.ItemHeight = 16
        Me.lbxInfo.Location = New System.Drawing.Point(261, 12)
        Me.lbxInfo.Name = "lbxInfo"
        Me.lbxInfo.Size = New System.Drawing.Size(354, 468)
        Me.lbxInfo.TabIndex = 1
        '
        'btnMostrarImpuestos
        '
        Me.btnMostrarImpuestos.Location = New System.Drawing.Point(14, 279)
        Me.btnMostrarImpuestos.Name = "btnMostrarImpuestos"
        Me.btnMostrarImpuestos.Size = New System.Drawing.Size(170, 32)
        Me.btnMostrarImpuestos.TabIndex = 2
        Me.btnMostrarImpuestos.Text = "Mostrar Impuestos"
        Me.btnMostrarImpuestos.UseVisualStyleBackColor = True
        '
        'tbxSalarioBruto
        '
        Me.tbxSalarioBruto.Location = New System.Drawing.Point(114, 152)
        Me.tbxSalarioBruto.Name = "tbxSalarioBruto"
        Me.tbxSalarioBruto.Size = New System.Drawing.Size(141, 22)
        Me.tbxSalarioBruto.TabIndex = 25
        '
        'lblSalarioBruto
        '
        Me.lblSalarioBruto.AutoSize = True
        Me.lblSalarioBruto.Location = New System.Drawing.Point(11, 152)
        Me.lblSalarioBruto.Name = "lblSalarioBruto"
        Me.lblSalarioBruto.Size = New System.Drawing.Size(90, 17)
        Me.lblSalarioBruto.TabIndex = 24
        Me.lblSalarioBruto.Text = "Salario Bruto"
        '
        'tbxCodigo
        '
        Me.tbxCodigo.Location = New System.Drawing.Point(96, 89)
        Me.tbxCodigo.Name = "tbxCodigo"
        Me.tbxCodigo.Size = New System.Drawing.Size(159, 22)
        Me.tbxCodigo.TabIndex = 23
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoEllipsis = True
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(11, 89)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(52, 17)
        Me.lblCodigo.TabIndex = 22
        Me.lblCodigo.Text = "Codigo"
        '
        'tbxNombre
        '
        Me.tbxNombre.Location = New System.Drawing.Point(96, 25)
        Me.tbxNombre.Name = "tbxNombre"
        Me.tbxNombre.Size = New System.Drawing.Size(159, 22)
        Me.tbxNombre.TabIndex = 21
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(11, 25)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(58, 17)
        Me.lblNombre.TabIndex = 20
        Me.lblNombre.Text = "Nombre"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(14, 218)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(170, 32)
        Me.btnAgregar.TabIndex = 26
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'bntBuscar
        '
        Me.bntBuscar.Location = New System.Drawing.Point(12, 448)
        Me.bntBuscar.Name = "bntBuscar"
        Me.bntBuscar.Size = New System.Drawing.Size(170, 32)
        Me.bntBuscar.TabIndex = 27
        Me.bntBuscar.Text = "Buscar"
        Me.bntBuscar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 550)
        Me.Controls.Add(Me.bntBuscar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.tbxSalarioBruto)
        Me.Controls.Add(Me.lblSalarioBruto)
        Me.Controls.Add(Me.tbxCodigo)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.tbxNombre)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.btnMostrarImpuestos)
        Me.Controls.Add(Me.lbxInfo)
        Me.Controls.Add(Me.btnMostrarPlanilla)
        Me.Name = "Form1"
        Me.Text = "RECORDERIS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnMostrarPlanilla As Button
    Friend WithEvents lbxInfo As ListBox
    Friend WithEvents btnMostrarImpuestos As Button
    Friend WithEvents tbxSalarioBruto As TextBox
    Friend WithEvents lblSalarioBruto As Label
    Friend WithEvents tbxCodigo As TextBox
    Friend WithEvents lblCodigo As Label
    Friend WithEvents tbxNombre As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents bntBuscar As Button
End Class

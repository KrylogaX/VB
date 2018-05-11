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
        Me.lblNombreCompleto = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.txtSalario = New System.Windows.Forms.TextBox()
        Me.lblSalario = New System.Windows.Forms.Label()
        Me.lbxInfo = New System.Windows.Forms.ListBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnPlanilla = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblNombreCompleto
        '
        Me.lblNombreCompleto.AutoSize = True
        Me.lblNombreCompleto.Location = New System.Drawing.Point(12, 32)
        Me.lblNombreCompleto.Name = "lblNombreCompleto"
        Me.lblNombreCompleto.Size = New System.Drawing.Size(91, 13)
        Me.lblNombreCompleto.TabIndex = 0
        Me.lblNombreCompleto.Text = "Nombre Completo"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(109, 29)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(186, 20)
        Me.txtNombre.TabIndex = 1
        '
        'txtCedula
        '
        Me.txtCedula.Location = New System.Drawing.Point(109, 55)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(186, 20)
        Me.txtCedula.TabIndex = 3
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Location = New System.Drawing.Point(12, 58)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(40, 13)
        Me.lblCedula.TabIndex = 2
        Me.lblCedula.Text = "Cedula"
        '
        'txtSalario
        '
        Me.txtSalario.Location = New System.Drawing.Point(109, 81)
        Me.txtSalario.Name = "txtSalario"
        Me.txtSalario.Size = New System.Drawing.Size(186, 20)
        Me.txtSalario.TabIndex = 5
        '
        'lblSalario
        '
        Me.lblSalario.AutoSize = True
        Me.lblSalario.Location = New System.Drawing.Point(12, 84)
        Me.lblSalario.Name = "lblSalario"
        Me.lblSalario.Size = New System.Drawing.Size(63, 13)
        Me.lblSalario.TabIndex = 4
        Me.lblSalario.Text = "Salario neto"
        '
        'lbxInfo
        '
        Me.lbxInfo.FormattingEnabled = True
        Me.lbxInfo.Location = New System.Drawing.Point(15, 142)
        Me.lbxInfo.Name = "lbxInfo"
        Me.lbxInfo.Size = New System.Drawing.Size(281, 134)
        Me.lbxInfo.TabIndex = 6
        Me.lbxInfo.UseWaitCursor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(135, 108)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(79, 28)
        Me.btnGuardar.TabIndex = 7
        Me.btnGuardar.Text = "Agregar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnPlanilla
        '
        Me.btnPlanilla.Location = New System.Drawing.Point(15, 282)
        Me.btnPlanilla.Name = "btnPlanilla"
        Me.btnPlanilla.Size = New System.Drawing.Size(143, 22)
        Me.btnPlanilla.TabIndex = 8
        Me.btnPlanilla.Text = "Calcular Planilla Total"
        Me.btnPlanilla.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(173, 282)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(0, 13)
        Me.lblTotal.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(308, 314)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnPlanilla)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.lbxInfo)
        Me.Controls.Add(Me.txtSalario)
        Me.Controls.Add(Me.lblSalario)
        Me.Controls.Add(Me.txtCedula)
        Me.Controls.Add(Me.lblCedula)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblNombreCompleto)
        Me.Name = "Form1"
        Me.Text = "Información de Empleados"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNombreCompleto As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents lblCedula As Label
    Friend WithEvents txtSalario As TextBox
    Friend WithEvents lblSalario As Label
    Friend WithEvents lbxInfo As ListBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnPlanilla As Button
    Friend WithEvents lblTotal As Label
End Class

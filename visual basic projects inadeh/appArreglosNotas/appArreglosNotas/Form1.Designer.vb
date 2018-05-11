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
        Me.btnNombres = New System.Windows.Forms.Button()
        Me.lbxInfo = New System.Windows.Forms.ListBox()
        Me.lbxMostrar = New System.Windows.Forms.Button()
        Me.btnReprobados = New System.Windows.Forms.Button()
        Me.btnMayor = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnNombres
        '
        Me.btnNombres.Location = New System.Drawing.Point(12, 12)
        Me.btnNombres.Name = "btnNombres"
        Me.btnNombres.Size = New System.Drawing.Size(271, 29)
        Me.btnNombres.TabIndex = 0
        Me.btnNombres.Text = "Cargar Nombres y Notas"
        Me.btnNombres.UseVisualStyleBackColor = True
        '
        'lbxInfo
        '
        Me.lbxInfo.FormattingEnabled = True
        Me.lbxInfo.ItemHeight = 16
        Me.lbxInfo.Location = New System.Drawing.Point(12, 47)
        Me.lbxInfo.Name = "lbxInfo"
        Me.lbxInfo.Size = New System.Drawing.Size(271, 164)
        Me.lbxInfo.TabIndex = 2
        '
        'lbxMostrar
        '
        Me.lbxMostrar.Location = New System.Drawing.Point(12, 234)
        Me.lbxMostrar.Name = "lbxMostrar"
        Me.lbxMostrar.Size = New System.Drawing.Size(270, 29)
        Me.lbxMostrar.TabIndex = 3
        Me.lbxMostrar.Text = "Mostrar Informacion"
        Me.lbxMostrar.UseVisualStyleBackColor = True
        '
        'btnReprobados
        '
        Me.btnReprobados.Location = New System.Drawing.Point(12, 269)
        Me.btnReprobados.Name = "btnReprobados"
        Me.btnReprobados.Size = New System.Drawing.Size(270, 29)
        Me.btnReprobados.TabIndex = 4
        Me.btnReprobados.Text = "Mostrar Reprobados"
        Me.btnReprobados.UseVisualStyleBackColor = True
        '
        'btnMayor
        '
        Me.btnMayor.Location = New System.Drawing.Point(12, 304)
        Me.btnMayor.Name = "btnMayor"
        Me.btnMayor.Size = New System.Drawing.Size(270, 29)
        Me.btnMayor.TabIndex = 5
        Me.btnMayor.Text = "Mostrar Mayor Nota"
        Me.btnMayor.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 355)
        Me.Controls.Add(Me.btnMayor)
        Me.Controls.Add(Me.btnReprobados)
        Me.Controls.Add(Me.lbxMostrar)
        Me.Controls.Add(Me.lbxInfo)
        Me.Controls.Add(Me.btnNombres)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnNombres As System.Windows.Forms.Button
    Friend WithEvents lbxInfo As System.Windows.Forms.ListBox
    Friend WithEvents lbxMostrar As System.Windows.Forms.Button
    Friend WithEvents btnReprobados As System.Windows.Forms.Button
    Friend WithEvents btnMayor As System.Windows.Forms.Button

End Class

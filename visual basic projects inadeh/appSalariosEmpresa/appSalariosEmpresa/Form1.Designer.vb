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
        Me.btnCaptar = New System.Windows.Forms.Button()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.lbxSalarios = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnCaptar
        '
        Me.btnCaptar.Location = New System.Drawing.Point(12, 235)
        Me.btnCaptar.Name = "btnCaptar"
        Me.btnCaptar.Size = New System.Drawing.Size(117, 33)
        Me.btnCaptar.TabIndex = 0
        Me.btnCaptar.Text = "Captar"
        Me.btnCaptar.UseVisualStyleBackColor = True
        '
        'btnMostrar
        '
        Me.btnMostrar.Location = New System.Drawing.Point(135, 235)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(117, 33)
        Me.btnMostrar.TabIndex = 1
        Me.btnMostrar.Text = "Mostrar"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'lbxSalarios
        '
        Me.lbxSalarios.FormattingEnabled = True
        Me.lbxSalarios.ItemHeight = 16
        Me.lbxSalarios.Location = New System.Drawing.Point(12, 25)
        Me.lbxSalarios.Name = "lbxSalarios"
        Me.lbxSalarios.Size = New System.Drawing.Size(239, 196)
        Me.lbxSalarios.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(265, 280)
        Me.Controls.Add(Me.lbxSalarios)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.btnCaptar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCaptar As Button
    Friend WithEvents btnMostrar As Button
    Friend WithEvents lbxSalarios As ListBox
End Class

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
        Me.txtNotas = New System.Windows.Forms.TextBox()
        Me.lblNotafinal = New System.Windows.Forms.Label()
        Me.btnEvaluar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtNotas
        '
        Me.txtNotas.Location = New System.Drawing.Point(12, 12)
        Me.txtNotas.Name = "txtNotas"
        Me.txtNotas.Size = New System.Drawing.Size(260, 20)
        Me.txtNotas.TabIndex = 0
        '
        'lblNotafinal
        '
        Me.lblNotafinal.AutoSize = True
        Me.lblNotafinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 99.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotafinal.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblNotafinal.Location = New System.Drawing.Point(81, 91)
        Me.lblNotafinal.Name = "lblNotafinal"
        Me.lblNotafinal.Size = New System.Drawing.Size(0, 152)
        Me.lblNotafinal.TabIndex = 1
        '
        'btnEvaluar
        '
        Me.btnEvaluar.Location = New System.Drawing.Point(12, 50)
        Me.btnEvaluar.Name = "btnEvaluar"
        Me.btnEvaluar.Size = New System.Drawing.Size(259, 20)
        Me.btnEvaluar.TabIndex = 2
        Me.btnEvaluar.Text = "Evaluar Nota"
        Me.btnEvaluar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnEvaluar)
        Me.Controls.Add(Me.lblNotafinal)
        Me.Controls.Add(Me.txtNotas)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNotas As TextBox
    Friend WithEvents lblNotafinal As Label
    Friend WithEvents btnEvaluar As Button
End Class

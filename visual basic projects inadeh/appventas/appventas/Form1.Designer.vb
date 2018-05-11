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
        Me.txtTotalventas = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCalcularbono = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblBono = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtTotalventas
        '
        Me.txtTotalventas.Location = New System.Drawing.Point(35, 30)
        Me.txtTotalventas.Name = "txtTotalventas"
        Me.txtTotalventas.Size = New System.Drawing.Size(216, 20)
        Me.txtTotalventas.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Total ventas:"
        '
        'btnCalcularbono
        '
        Me.btnCalcularbono.Location = New System.Drawing.Point(35, 78)
        Me.btnCalcularbono.Name = "btnCalcularbono"
        Me.btnCalcularbono.Size = New System.Drawing.Size(215, 26)
        Me.btnCalcularbono.TabIndex = 2
        Me.btnCalcularbono.Text = "Calcular Bono"
        Me.btnCalcularbono.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Bono:"
        '
        'lblBono
        '
        Me.lblBono.AutoSize = True
        Me.lblBono.Location = New System.Drawing.Point(43, 173)
        Me.lblBono.Name = "lblBono"
        Me.lblBono.Size = New System.Drawing.Size(0, 13)
        Me.lblBono.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.lblBono)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCalcularbono)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTotalventas)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTotalventas As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCalcularbono As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lblBono As Label
End Class

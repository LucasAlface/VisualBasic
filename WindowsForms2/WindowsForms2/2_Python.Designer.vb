<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _2_Python
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(298, 179)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Boa Escolha!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(133, 222)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(537, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Escolha a opção correta para escrever no terminal"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(646, 364)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(142, 74)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = """Hello World!"""
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 364)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(139, 74)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "print(""Hello World!"")"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(646, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(142, 59)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "print(Hello World!)"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(9, 12)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(142, 74)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Hello World!"
        Me.Button4.UseVisualStyleBackColor = True
        '
        '_2_Python
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "_2_Python"
        Me.Text = "_2_Python"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class

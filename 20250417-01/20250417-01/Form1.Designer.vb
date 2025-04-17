<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lab1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(312, 144)
        Me.txt1.Multiline = True
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(186, 53)
        Me.txt1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(356, 232)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 39)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lab1
        '
        Me.lab1.AutoSize = True
        Me.lab1.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lab1.Location = New System.Drawing.Point(366, 300)
        Me.lab1.Name = "lab1"
        Me.lab1.Size = New System.Drawing.Size(77, 19)
        Me.lab1.TabIndex = 2
        Me.lab1.Text = "成績は："
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lab1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents lab1 As Label
End Class

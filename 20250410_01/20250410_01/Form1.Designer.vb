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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtteihen = New System.Windows.Forms.TextBox()
        Me.txttakasa = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.labkotae = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 47.99999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(186, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(482, 65)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "長方形の面積計算"
        '
        'txtteihen
        '
        Me.txtteihen.Location = New System.Drawing.Point(187, 136)
        Me.txtteihen.Multiline = True
        Me.txtteihen.Name = "txtteihen"
        Me.txtteihen.Size = New System.Drawing.Size(153, 60)
        Me.txtteihen.TabIndex = 1
        '
        'txttakasa
        '
        Me.txttakasa.Location = New System.Drawing.Point(515, 136)
        Me.txttakasa.Multiline = True
        Me.txttakasa.Name = "txttakasa"
        Me.txttakasa.Size = New System.Drawing.Size(153, 60)
        Me.txttakasa.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(238, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 31)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "底辺"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(569, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 31)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "高さ"
        '
        'labkotae
        '
        Me.labkotae.AutoSize = True
        Me.labkotae.Font = New System.Drawing.Font("Modern No. 20", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labkotae.Location = New System.Drawing.Point(478, 305)
        Me.labkotae.Name = "labkotae"
        Me.labkotae.Size = New System.Drawing.Size(153, 36)
        Me.labkotae.TabIndex = 5
        Me.labkotae.Text = "答えの面積"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(238, 305)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(153, 36)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "答えの面積"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Modern No. 20", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(375, 211)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 47)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "計算"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.labkotae)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txttakasa)
        Me.Controls.Add(Me.txtteihen)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtteihen As TextBox
    Friend WithEvents txttakasa As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents labkotae As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
End Class

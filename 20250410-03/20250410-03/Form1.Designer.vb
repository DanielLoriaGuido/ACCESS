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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pic1 = New System.Windows.Forms.PictureBox()
        Me.pic2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.labkekka = New System.Windows.Forms.Label()
        Me.num1 = New System.Windows.Forms.NumericUpDown()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button1.Location = New System.Drawing.Point(347, 133)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Click Me!"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'pic1
        '
        Me.pic1.Image = CType(resources.GetObject("pic1.Image"), System.Drawing.Image)
        Me.pic1.Location = New System.Drawing.Point(63, 172)
        Me.pic1.Name = "pic1"
        Me.pic1.Size = New System.Drawing.Size(164, 172)
        Me.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic1.TabIndex = 2
        Me.pic1.TabStop = False
        '
        'pic2
        '
        Me.pic2.Image = CType(resources.GetObject("pic2.Image"), System.Drawing.Image)
        Me.pic2.Location = New System.Drawing.Point(553, 172)
        Me.pic2.Name = "pic2"
        Me.pic2.Size = New System.Drawing.Size(164, 172)
        Me.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic2.TabIndex = 3
        Me.pic2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(327, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "成績を入力して"
        '
        'labkekka
        '
        Me.labkekka.AutoSize = True
        Me.labkekka.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.labkekka.Location = New System.Drawing.Point(327, 187)
        Me.labkekka.Name = "labkekka"
        Me.labkekka.Size = New System.Drawing.Size(101, 16)
        Me.labkekka.TabIndex = 6
        Me.labkekka.Text = "あなたは。。。"
        '
        'num1
        '
        Me.num1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.num1.Location = New System.Drawing.Point(330, 84)
        Me.num1.Name = "num1"
        Me.num1.Size = New System.Drawing.Size(120, 23)
        Me.num1.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.num1)
        Me.Controls.Add(Me.labkekka)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pic2)
        Me.Controls.Add(Me.pic1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents pic1 As PictureBox
    Friend WithEvents pic2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents labkekka As Label
    Friend WithEvents num1 As NumericUpDown
End Class

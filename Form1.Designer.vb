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
        Me.txtIDA = New System.Windows.Forms.TextBox()
        Me.txtCE = New System.Windows.Forms.TextBox()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtIDA
        '
        Me.txtIDA.Location = New System.Drawing.Point(12, 12)
        Me.txtIDA.Multiline = True
        Me.txtIDA.Name = "txtIDA"
        Me.txtIDA.Size = New System.Drawing.Size(240, 195)
        Me.txtIDA.TabIndex = 0
        '
        'txtCE
        '
        Me.txtCE.Location = New System.Drawing.Point(296, 12)
        Me.txtCE.Multiline = True
        Me.txtCE.Name = "txtCE"
        Me.txtCE.ReadOnly = True
        Me.txtCE.Size = New System.Drawing.Size(240, 195)
        Me.txtCE.TabIndex = 1
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(258, 12)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(30, 195)
        Me.btnConvert.TabIndex = 2
        Me.btnConvert.Text = "⇒"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 217)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.txtCE)
        Me.Controls.Add(Me.txtIDA)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "IDAtoCEASM"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtIDA As TextBox
    Friend WithEvents txtCE As TextBox
    Friend WithEvents btnConvert As Button
End Class

Public Class Form1

    ''' <summary>
    ''' ⇒ボタンをクリックしたとき
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ConvertButton_Click(sender As Object, e As EventArgs) Handles btnConvert.Click

        txtCE.Text = ""

        ' 入力したASMコードを格納
        Dim strIDA As String = txtIDA.Text

        ' IDAのASM命令をCE用に変換
        strIDA = strIDA.Replace("jnz", "jne")
        strIDA = strIDA.Replace("retn", "ret")

        Dim mc As System.Text.RegularExpressions.MatchCollection = System.Text.RegularExpressions.Regex.Matches(
                strIDA,
                "^(?<op>[a-z]{2,6})([\w|\d| |,|:|;|(|)|[|]|\\-|\+\|\\$|\\?|\\@]+)",
                System.Text.RegularExpressions.RegexOptions.IgnoreCase Or
                System.Text.RegularExpressions.RegexOptions.Multiline)

        ' コレクションすべてを出力
        For Each m As System.Text.RegularExpressions.Match In mc
            txtCE.Text &= (m.Groups("op").Value) & "*" & vbCrLf
        Next

        ' 読み取り専用解除
        txtCE.ReadOnly = False

    End Sub

    'クリックで全部選択
    Private Sub IDATextBox_Click(sender As Object, e As EventArgs) Handles txtIDA.Click
        txtIDA.SelectAll()
    End Sub

    'クリックで全部選択
    Private Sub CETextBox_Click(sender As Object, e As EventArgs) Handles txtCE.Click
        txtCE.SelectAll()
    End Sub

End Class

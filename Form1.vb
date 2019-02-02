Public Class Form1

    Protected Overrides Function ProcessDialogKey _
                (ByVal keyData As System.Windows.Forms.Keys) As Boolean

        If keyData = Keys.Enter Then
            Return MyBase.ProcessDialogKey(Keys.Tab)
        ElseIf keyData = Keys.Escape Then
            Return MyBase.ProcessDialogKey(Keys.Shift Or Keys.Tab)
        End If
        Return MyBase.ProcessDialogKey(keyData)

    End Function
End Class

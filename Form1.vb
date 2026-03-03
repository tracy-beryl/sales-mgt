

Public Class Form1

    Dim menuForm As New Form2()
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MessageBox.Show("Enter Username and Password")
            Exit Sub
            End
        End If

        menuForm.UserRole = "Admin"
        menuForm.Username = txtUsername.Text
        menuForm.Show()
        Me.Hide()

        txtUsername.Clear()
        txtPassword.Clear()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class

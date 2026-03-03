Public Class Form2
    Public UserRole As String

    Public Username As String
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnSales.Click
        Dim salesForm As New Form5()
        salesForm.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        Dim usersForm As New Form7()
        usersForm.Show()

    End Sub



    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result = MessageBox.Show("Are you sure you want to logout?", "Logout",
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Form1.Show()
            Me.Close()
            End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblWelcome.Text = "Welcome, " & Username


        If UserRole = "Clerk" Then
            btnUsers.Visible = False
            btnReports.Visible = False
        End If


    End Sub

    Private Sub btnSuppliers_Click(sender As Object, e As EventArgs) Handles btnSuppliers.Click
        Dim suppliersForm As New Form4()
        suppliersForm.Show()

    End Sub

    Private Sub btnProducts_Click(sender As Object, e As EventArgs) Handles btnProducts.Click
        Dim productsForm As New Form3()
        productsForm.Show()

        Me.Hide()

    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        Dim reportsForm As New Form6()
        reportsForm.Show()
    End Sub
End Class
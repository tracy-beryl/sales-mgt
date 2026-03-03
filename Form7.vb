Public Class Form7
    Private Sub UsersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles UsersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UsersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MyInventoryDataSet)
        MessageBox.Show("User saved successfully!", "Success",
                       MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MyInventoryDataSet.Users' table
        Me.UsersTableAdapter.Fill(Me.MyInventoryDataSet.Users)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Add new user
        UsersBindingSource.AddNew()

        ' Optional: Set focus to username field if you have specific controls
        ' You might want to disable the ID field if it's auto-generated
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ' Update existing user
        Try
            ' Save changes to the dataset
            Me.Validate()
            Me.UsersBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.MyInventoryDataSet)

            MessageBox.Show("User updated successfully!", "Success",
                           MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error updating user: " & ex.Message, "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Save user (both new and existing)
        Try
            Me.Validate()
            Me.UsersBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.MyInventoryDataSet)

            MessageBox.Show("User saved successfully!", "Success",
                           MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Optional: Refresh the data
            Me.UsersTableAdapter.Fill(Me.MyInventoryDataSet.Users)
        Catch ex As Exception
            MessageBox.Show("Error saving user: " & ex.Message, "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ' Search for users
        Try
            If String.IsNullOrEmpty(txtSearch.Text) Then
                ' If search box is empty, remove filter
                UsersBindingSource.RemoveFilter()
            Else
                ' Filter by Username or Role
                UsersBindingSource.Filter = String.Format(
                    "Username LIKE '%{0}%' OR Role LIKE '%{0}%'",
                    txtSearch.Text.Replace("'", "''"))
            End If
        Catch ex As Exception
            MessageBox.Show("Search error: " & ex.Message, "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Optional: Add a Delete button functionality
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If UsersBindingSource.Current Is Nothing Then
            MessageBox.Show("No user selected to delete.", "Warning",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim result = MessageBox.Show("Are you sure you want to delete this user?",
                                    "Confirm Delete",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Try
                UsersBindingSource.RemoveCurrent()
                Me.Validate()
                Me.UsersBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.MyInventoryDataSet)

                MessageBox.Show("User deleted successfully!", "Success",
                               MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error deleting user: " & ex.Message, "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    ' Optional: Clear search button
    Private Sub btnClearSearch_Click(sender As Object, e As EventArgs) Handles btnClearSearch.Click
        txtSearch.Clear()
        UsersBindingSource.RemoveFilter()
    End Sub

    ' Optional: Navigation buttons if you have them
    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        UsersBindingSource.MoveFirst()
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        UsersBindingSource.MovePrevious()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        UsersBindingSource.MoveNext()
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        UsersBindingSource.MoveLast()
    End Sub

    Private Sub UserIDLabel_Click(sender As Object, e As EventArgs)

    End Sub
End Class
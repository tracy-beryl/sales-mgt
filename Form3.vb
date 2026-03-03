Public Class Form3
    Private Sub ProductsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProductsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProductsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MyInventoryDataSet)
        CheckLowStock() ' Check for low stock after save
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MyInventoryDataSet.Products' table
        Me.ProductsTableAdapter.Fill(Me.MyInventoryDataSet.Products)
        CheckLowStock() ' Check for low stock on form load
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ProductsBindingSource.AddNew()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            Me.Validate()
            Me.ProductsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.MyInventoryDataSet)
            MessageBox.Show("Product updated successfully!", "Success",
                           MessageBoxButtons.OK, MessageBoxIcon.Information)
            CheckLowStock()
        Catch ex As Exception
            MessageBox.Show("Error updating product: " & ex.Message, "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If ProductsBindingSource.Current Is Nothing Then
            MessageBox.Show("No product selected.", "Warning",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim result = MessageBox.Show("Are you sure you want to delete this particular product?",
                                    "Confirm Delete",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Try
                ProductsBindingSource.RemoveCurrent()
                Me.Validate()
                Me.ProductsBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.MyInventoryDataSet)
                MessageBox.Show("Product deleted successfully!", "Success",
                               MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error deleting product: " & ex.Message, "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Me.Validate()
            Me.ProductsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.MyInventoryDataSet)
            MessageBox.Show("Product saved successfully!", "Success",
                           MessageBoxButtons.OK, MessageBoxIcon.Information)
            CheckLowStock()
        Catch ex As Exception
            MessageBox.Show("Error saving product: " & ex.Message, "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            If String.IsNullOrEmpty(txtSearch.Text) Then
                ProductsBindingSource.RemoveFilter()
            Else
                ProductsBindingSource.Filter =
                "ProductName LIKE '%" & txtSearch.Text & "%'"
            End If
        Catch ex As Exception
            MessageBox.Show("Search error: " & ex.Message)
        End Try
    End Sub

    ' Check for low stock products
    Private Sub CheckLowStock()
        For Each row As DataRowView In ProductsBindingSource
            Dim productRow As MyInventoryDataSet.ProductsRow = CType(row.Row, MyInventoryDataSet.ProductsRow)
            If productRow.QuantityInStock < productRow.ReorderLevel Then
                MessageBox.Show($"LOW STOCK ALERT: {productRow.ProductName} has only {productRow.QuantityInStock} units left!",
                              "Low Stock Warning",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning)
            End If
        Next
    End Sub

    ' Navigation buttons
    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        ProductsBindingSource.MoveFirst()
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        ProductsBindingSource.MovePrevious()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        ProductsBindingSource.MoveNext()
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        ProductsBindingSource.MoveLast()
    End Sub
End Class
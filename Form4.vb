Public Class Form4
    Private Sub SuppliersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles SuppliersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SuppliersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MyInventoryDataSet)
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MyInventoryDataSet.Suppliers' table
        Me.SuppliersTableAdapter.Fill(Me.MyInventoryDataSet.Suppliers)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        SuppliersBindingSource.AddNew()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        ' Enable editing (already enabled by default, but we can add visual feedback)
        MessageBox.Show("You can now edit the supplier details.", "Edit Mode",
                       MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Me.Validate()
            Me.SuppliersBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.MyInventoryDataSet)
            MessageBox.Show("Supplier saved successfully!", "Success",
                           MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error saving supplier: " & ex.Message, "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If SuppliersBindingSource.Current Is Nothing Then
            MessageBox.Show("No supplier selected.", "Warning",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim result = MessageBox.Show("Are you sure you want to delete this supplier? This may affect related products.",
                                    "Confirm Delete",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Try
                SuppliersBindingSource.RemoveCurrent()
                Me.Validate()
                Me.SuppliersBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.MyInventoryDataSet)
                MessageBox.Show("Supplier deleted successfully!", "Success",
                               MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Cannot delete supplier. It may have related products.", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            If String.IsNullOrEmpty(txtSearch.Text) Then
                SuppliersBindingSource.RemoveFilter()
            Else
                SuppliersBindingSource.Filter = "SupplierName LIKE '%" & txtSearch.Text & "%' OR Location LIKE '%" & txtSearch.Text & "%'"
            End If
        Catch ex As Exception
            MessageBox.Show("Search error: " & ex.Message, "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' View products by this supplier
    Private Sub btnViewProducts_Click(sender As Object, e As EventArgs) Handles btnViewProducts.Click
        If SuppliersBindingSource.Current Is Nothing Then
            MessageBox.Show("Please select a supplier.", "Warning",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim currentSupplier As DataRowView = CType(SuppliersBindingSource.Current, DataRowView)
        Dim supplierID As Integer = CInt(currentSupplier("SupplierID"))
        Dim supplierName As String = currentSupplier("SupplierName").ToString()

        ' Filter products by this supplier
        Dim productsForm As New Form3()
        productsForm.ProductsBindingSource.Filter = $"SupplierID = {supplierID}"
        productsForm.Text = $"Products by {supplierName}"
        productsForm.Show()
    End Sub

    ' Navigation
    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        SuppliersBindingSource.MoveFirst()
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        SuppliersBindingSource.MovePrevious()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        SuppliersBindingSource.MoveNext()
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        SuppliersBindingSource.MoveLast()
    End Sub
End Class
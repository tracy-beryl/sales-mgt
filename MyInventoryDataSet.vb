Partial Class MyInventoryDataSet
    Partial Public Class ProductsDataTable
        Private Sub ProductsDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.ProductIDColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class
End Class

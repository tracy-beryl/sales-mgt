Public Class Form5
    ' Variables only - NO control declarations since they're in designer
    Private currentSellingPrice As Decimal = 0
    Private currentBuyingPrice As Decimal = 0
    Private currentStock As Integer = 0
    Private currentReorderLevel As Integer = 0
    Private currentProductID As Integer = 0

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MyInventoryDataSet.Sales' table
        Me.SalesTableAdapter.Fill(Me.MyInventoryDataSet.Sales)

        ' Load products for combo box
        LoadProducts()

        ' Set default date to today
        dtpSaleDate.Value = DateTime.Now
    End Sub

    Private Sub LoadProducts()
        ' Clear and load products into the combo box
        cboProduct.Items.Clear()

        ' Add a default item
        cboProduct.Items.Add(New ProductItem(0, "-- Select Product --", 0, 0, 0))

        ' Get products from database
        For Each row As MyInventoryDataSet.ProductsRow In Me.MyInventoryDataSet.Products.Rows
            Dim displayText = $"{row.ProductName} - Stock: {row.QuantityInStock} - Price: {row.SellingPrice:C}"
            cboProduct.Items.Add(New ProductItem(row.ProductID, displayText,
                                                row.SellingPrice, row.BuyingPrice,
                                                row.QuantityInStock, row.ReorderLevel))
        Next

        If cboProduct.Items.Count > 0 Then
            cboProduct.SelectedIndex = 0
        End If
    End Sub

    Private Sub cboProduct_SelectedIndexChanged(sender As Object, e As EventArgs)
        If cboProduct.SelectedIndex > 0 Then
            Dim selectedProduct = CType(cboProduct.SelectedItem, ProductItem)
            currentProductID = selectedProduct.ProductID
            currentSellingPrice = selectedProduct.SellingPrice
            currentBuyingPrice = selectedProduct.BuyingPrice
            currentStock = selectedProduct.Stock
            currentReorderLevel = selectedProduct.ReorderLevel

            ' Update labels (these should exist in designer)
            lblSellingPrice.Text = $"Selling Price: {currentSellingPrice:C}"
            txtQuantity.Clear()
            lblTotalPrice.Text = "Total: 0.00"
            lblProfit.Text = "Profit: 0.00"
        Else
            ' No product selected
            currentProductID = 0
            currentSellingPrice = 0
            currentBuyingPrice = 0
            currentStock = 0
            lblSellingPrice.Text = "Selling Price: 0.00"
        End If
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs)
        If currentProductID = 0 Then
            MessageBox.Show("Please select a product.", "Warning",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim quantity As Integer
        If Not Integer.TryParse(txtQuantity.Text, quantity) Or quantity <= 0 Then
            MessageBox.Show("Please enter a valid quantity.", "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If quantity > currentStock Then
            MessageBox.Show($"Insufficient stock! Only {currentStock} units available.",
                          "Stock Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Calculate totals
        Dim totalPrice = quantity * currentSellingPrice
        Dim profit = (currentSellingPrice - currentBuyingPrice) * quantity

        lblTotalPrice.Text = $"Total: {totalPrice:C}"
        lblProfit.Text = $"Profit: {profit:C}"
    End Sub

    Private Sub btnProcessSale_Click(sender As Object, e As EventArgs)
        If currentProductID = 0 Then
            MessageBox.Show("Please select a product.", "Warning",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim quantity As Integer
        If Not Integer.TryParse(txtQuantity.Text, quantity) Or quantity <= 0 Then
            MessageBox.Show("Please enter a valid quantity.", "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If quantity > currentStock Then
            MessageBox.Show($"Insufficient stock! Only {currentStock} units available.",
                          "Stock Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Dim selectedProduct = CType(cboProduct.SelectedItem, ProductItem)
            Dim totalPrice = quantity * currentSellingPrice

            ' Add sale record
            Dim newRow = Me.MyInventoryDataSet.Sales.NewSalesRow()
            newRow.ProductID = selectedProduct.ProductID
            newRow.QuantitySold = quantity
            newRow.TotalPrice = totalPrice
            newRow.SaleDate = dtpSaleDate.Value
            newRow.SoldBy = GetCurrentUserID()
            Me.MyInventoryDataSet.Sales.AddSalesRow(newRow)

            ' Update stock
            UpdateProductStock(selectedProduct.ProductID, quantity)

            ' Save changes
            Me.Validate()
            Me.SalesBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.MyInventoryDataSet)

            MessageBox.Show($"Sale processed successfully!{Environment.NewLine}" &
                          $"Total: {totalPrice:C}{Environment.NewLine}" &
                          $"Profit: {(currentSellingPrice - currentBuyingPrice) * quantity:C}",
                          "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Check low stock after sale
            If currentStock - quantity < currentReorderLevel Then
                MessageBox.Show($"LOW STOCK ALERT: Only {currentStock - quantity} units left!",
                              "Low Stock Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

            ' Refresh
            LoadProducts()
            Me.SalesTableAdapter.Fill(Me.MyInventoryDataSet.Sales)
            txtQuantity.Clear()

        Catch ex As Exception
            MessageBox.Show("Error processing sale: " & ex.Message, "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UpdateProductStock(productID As Integer, quantitySold As Integer)
        Dim productRow = Me.MyInventoryDataSet.Products.FindByProductID(productID)

        If productRow IsNot Nothing Then
            productRow.QuantityInStock -= quantitySold
        End If
    End Sub

    Private Function GetCurrentUserID() As Integer
        ' You can modify this to get the actual logged-in user ID
        Return 1
    End Function

    Private Sub btnPrintReceipt_Click(sender As Object, e As EventArgs)
        If SalesBindingSource.Current Is Nothing Then
            MessageBox.Show("Please select a sale to print receipt.", "Warning",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim currentSale = CType(CType(SalesBindingSource.Current, DataRowView).Row, MyInventoryDataSet.SalesRow)
        Dim product = Me.MyInventoryDataSet.Products.FindByProductID(currentSale.ProductID)
        Dim productName = If(product IsNot Nothing, product.ProductName, "Unknown")

        ' Create simple receipt
        Dim receipt As String = ""
        receipt &= "=" & StrDup(40, "=") & Environment.NewLine
        receipt &= "         SALES RECEIPT" & Environment.NewLine
        receipt &= "=" & StrDup(40, "=") & Environment.NewLine
        receipt &= $"Date: {currentSale.SaleDate:dddd, MMMM d, yyyy HH:mm}" & Environment.NewLine
        receipt &= $"Receipt #: SALE-{currentSale.SaleID:D6}" & Environment.NewLine
        receipt &= "-" & StrDup(40, "-") & Environment.NewLine
        receipt &= $"Product: {productName}" & Environment.NewLine
        receipt &= $"Quantity: {currentSale.QuantitySold}" & Environment.NewLine
        receipt &= $"Unit Price: {currentSellingPrice:C}" & Environment.NewLine
        receipt &= $"Total: {currentSale.TotalPrice:C}" & Environment.NewLine
        receipt &= "=" & StrDup(40, "=") & Environment.NewLine
        receipt &= "     THANK YOU FOR YOUR PURCHASE!" & Environment.NewLine
        receipt &= "=" & StrDup(40, "=")

        MessageBox.Show(receipt, $"Receipt - Sale #{currentSale.SaleID}",
                       MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnSearchByDate_Click(sender As Object, e As EventArgs) Handles btnSearchByDate.Click
        Try
            Dim selectedDate = dtpSaleDate.Value.Date
            Dim nextDate = selectedDate.AddDays(1)

            SalesBindingSource.Filter = $"SaleDate >= #{selectedDate:MM/dd/yyyy}# AND SaleDate < #{nextDate:MM/dd/yyyy}#"

            ' Show summary
            Dim totalSales As Decimal = 0
            Dim totalQuantity As Integer = 0

            For Each row As DataRowView In SalesBindingSource
                Dim saleRow = CType(row.Row, MyInventoryDataSet.SalesRow)
                totalSales += saleRow.TotalPrice
                totalQuantity += saleRow.QuantitySold
            Next

            MessageBox.Show($"Daily Sales Summary - {selectedDate:dddd, MMMM d, yyyy}{Environment.NewLine}" &
                          $"Transactions: {SalesBindingSource.Count}{Environment.NewLine}" &
                          $"Items Sold: {totalQuantity}{Environment.NewLine}" &
                          $"Total Sales: {totalSales:C}",
                          "Daily Summary", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error searching by date: " & ex.Message)
        End Try
    End Sub

    Private Sub btnClearFilter_Click(sender As Object, e As EventArgs)
        SalesBindingSource.RemoveFilter()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Clear form for new sale
        If cboProduct.Items.Count > 0 Then
            cboProduct.SelectedIndex = 0
        End If
        txtQuantity.Clear()
        lblTotalPrice.Text = "Total: 0.00"
        lblProfit.Text = "Profit: 0.00"
        dtpSaleDate.Value = DateTime.Now
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Save button (BindingNavigator Save)
        Me.Validate()
        Me.SalesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MyInventoryDataSet)
        MessageBox.Show("Changes saved successfully!", "Success",
                       MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' Helper class for ComboBox items
    Private Class ProductItem
        Public Property ProductID As Integer
        Public Property DisplayText As String
        Public Property SellingPrice As Decimal
        Public Property BuyingPrice As Decimal
        Public Property Stock As Integer
        Public Property ReorderLevel As Integer

        Public Sub New(id As Integer, text As String, sPrice As Decimal, bPrice As Decimal, stock As Integer, Optional reorder As Integer = 0)
            ProductID = id
            DisplayText = text
            SellingPrice = sPrice
            BuyingPrice = bPrice
            Me.Stock = stock
            ReorderLevel = reorder
        End Sub

        Public Overrides Function ToString() As String
            Return DisplayText
        End Function
    End Class


End Class
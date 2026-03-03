Public Class Form6
    ' Declare a new dataset for this form
    Private localDataSet As New MyInventoryDataSet()

    ' Controls
    Private WithEvents btnDailySales As Button
    Private WithEvents btnStockReport As Button
    Private WithEvents btnLowStock As Button
    Private WithEvents btnProfitReport As Button
    Private WithEvents dgvReport As DataGridView
    Private WithEvents dtpStartDate As DateTimePicker
    Private WithEvents dtpEndDate As DateTimePicker
    Private WithEvents lblStart As Label
    Private WithEvents lblEnd As Label
    Private WithEvents btnExport As Button
    Private WithEvents lblTotal As Label

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupControls()
        LoadData()
    End Sub

    Private Sub LoadData()
        ' Load data into the local dataset
        ' You need to create table adapters and fill them
        Try
            Dim productsTA As New MyInventoryDataSetTableAdapters.ProductsTableAdapter()
            productsTA.Fill(localDataSet.Products)

            Dim suppliersTA As New MyInventoryDataSetTableAdapters.SuppliersTableAdapter()
            suppliersTA.Fill(localDataSet.Suppliers)

            Dim salesTA As New MyInventoryDataSetTableAdapters.SalesTableAdapter()
            salesTA.Fill(localDataSet.Sales)
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message)
        End Try
    End Sub

    Private Sub SetupControls()
        ' Set form properties
        Me.Text = "Reports"
        Me.Size = New Size(800, 600)

        ' Date pickers
        lblStart = New Label()
        lblStart.Text = "Start Date:"
        lblStart.Location = New Point(20, 20)
        lblStart.Size = New Size(70, 25)
        Me.Controls.Add(lblStart)

        dtpStartDate = New DateTimePicker()
        dtpStartDate.Location = New Point(100, 20)
        dtpStartDate.Size = New Size(150, 25)
        dtpStartDate.Value = DateTime.Now.AddDays(-30)
        Me.Controls.Add(dtpStartDate)

        lblEnd = New Label()
        lblEnd.Text = "End Date:"
        lblEnd.Location = New Point(270, 20)
        lblEnd.Size = New Size(70, 25)
        Me.Controls.Add(lblEnd)

        dtpEndDate = New DateTimePicker()
        dtpEndDate.Location = New Point(350, 20)
        dtpEndDate.Size = New Size(150, 25)
        dtpEndDate.Value = DateTime.Now
        Me.Controls.Add(dtpEndDate)

        ' Report buttons
        btnDailySales = New Button()
        btnDailySales.Text = "Daily Sales"
        btnDailySales.Location = New Point(20, 60)
        btnDailySales.Size = New Size(100, 35)
        Me.Controls.Add(btnDailySales)

        btnStockReport = New Button()
        btnStockReport.Text = "Stock Report"
        btnStockReport.Location = New Point(130, 60)
        btnStockReport.Size = New Size(100, 35)
        Me.Controls.Add(btnStockReport)

        btnLowStock = New Button()
        btnLowStock.Text = "Low Stock"
        btnLowStock.Location = New Point(240, 60)
        btnLowStock.Size = New Size(100, 35)
        Me.Controls.Add(btnLowStock)

        btnProfitReport = New Button()
        btnProfitReport.Text = "Profit Report"
        btnProfitReport.Location = New Point(350, 60)
        btnProfitReport.Size = New Size(100, 35)
        Me.Controls.Add(btnProfitReport)

        btnExport = New Button()
        btnExport.Text = "Export to Excel"
        btnExport.Location = New Point(460, 60)
        btnExport.Size = New Size(100, 35)
        Me.Controls.Add(btnExport)

        ' DataGridView for reports
        dgvReport = New DataGridView()
        dgvReport.Location = New Point(20, 110)
        dgvReport.Size = New Size(750, 400)
        dgvReport.AllowUserToAddRows = False
        dgvReport.AllowUserToDeleteRows = False
        dgvReport.ReadOnly = True
        dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Me.Controls.Add(dgvReport)

        ' Total label
        lblTotal = New Label()
        lblTotal.Location = New Point(20, 520)
        lblTotal.Size = New Size(300, 30)
        lblTotal.Font = New Font("Arial", 12, FontStyle.Bold)
        Me.Controls.Add(lblTotal)
    End Sub

    ' Daily Sales Report
    Private Sub btnDailySales_Click(sender As Object, e As EventArgs) Handles btnDailySales.Click
        Try
            Dim startDate = dtpStartDate.Value.Date
            Dim endDate = dtpEndDate.Value.Date.AddDays(1).AddSeconds(-1)

            ' Create DataTable for report
            Dim dt As New DataTable()
            dt.Columns.Add("Date", GetType(DateTime))
            dt.Columns.Add("Total Sales", GetType(Decimal))
            dt.Columns.Add("Number of Transactions", GetType(Integer))
            dt.Columns.Add("Average Sale", GetType(Decimal))

            ' Use localDataSet instead of Me.MyInventoryDataSet
            Dim salesTable = localDataSet.Sales

            ' Manual grouping without LINQ (to avoid LINQ errors)
            Dim salesByDate As New Dictionary(Of Date, List(Of MyInventoryDataSet.SalesRow))()

            For Each sale As MyInventoryDataSet.SalesRow In salesTable.Rows
                If sale.SaleDate >= startDate And sale.SaleDate <= endDate Then
                    Dim saleDate = sale.SaleDate.Date
                    If Not salesByDate.ContainsKey(saleDate) Then
                        salesByDate(saleDate) = New List(Of MyInventoryDataSet.SalesRow)()
                    End If
                    salesByDate(saleDate).Add(sale)
                End If
            Next

            Dim grandTotal As Decimal = 0

            ' Sort dates
            Dim sortedDates = salesByDate.Keys.ToList()
            sortedDates.Sort()

            For Each saleDate In sortedDates
                Dim sales = salesByDate(saleDate)
                Dim total = sales.Sum(Function(s) s.TotalPrice)
                Dim count = sales.Count
                Dim average = If(count > 0, total / count, 0)

                Dim row = dt.NewRow()
                row("Date") = saleDate
                row("Total Sales") = total
                row("Number of Transactions") = count
                row("Average Sale") = average
                dt.Rows.Add(row)
                grandTotal += total
            Next

            dgvReport.DataSource = dt
            lblTotal.Text = $"Grand Total: {grandTotal:C}"

        Catch ex As Exception
            MessageBox.Show("Error generating daily sales report: " & ex.Message)
        End Try
    End Sub

    ' Stock Report
    Private Sub btnStockReport_Click(sender As Object, e As EventArgs) Handles btnStockReport.Click
        Try
            Dim dt As New DataTable()
            dt.Columns.Add("Product ID", GetType(Integer))
            dt.Columns.Add("Product Name", GetType(String))
            dt.Columns.Add("Supplier", GetType(String))
            dt.Columns.Add("Buying Price", GetType(Decimal))
            dt.Columns.Add("Selling Price", GetType(Decimal))
            dt.Columns.Add("In Stock", GetType(Integer))
            dt.Columns.Add("Reorder Level", GetType(Integer))
            dt.Columns.Add("Stock Value", GetType(Decimal))
            dt.Columns.Add("Status", GetType(String))

            Dim totalStockValue As Decimal = 0

            ' Use localDataSet
            For Each product In localDataSet.Products
                Dim row = dt.NewRow()
                row("Product ID") = product.ProductID
                row("Product Name") = product.ProductName

                ' Find supplier
                Dim supplier = localDataSet.Suppliers.FindBySupplierID(product.SupplierID)
                row("Supplier") = If(supplier IsNot Nothing, supplier.SupplierName, "Unknown")

                row("Buying Price") = product.BuyingPrice
                row("Selling Price") = product.SellingPrice
                row("In Stock") = product.QuantityInStock
                row("Reorder Level") = product.ReorderLevel

                Dim stockValue = product.QuantityInStock * product.BuyingPrice
                row("Stock Value") = stockValue
                totalStockValue += stockValue

                row("Status") = If(product.QuantityInStock < product.ReorderLevel, "LOW STOCK!", "OK")

                dt.Rows.Add(row)
            Next

            dgvReport.DataSource = dt
            lblTotal.Text = $"Total Stock Value: {totalStockValue:C}"

        Catch ex As Exception
            MessageBox.Show("Error generating stock report: " & ex.Message)
        End Try
    End Sub

    ' Low Stock Report
    Private Sub btnLowStock_Click(sender As Object, e As EventArgs) Handles btnLowStock.Click
        Try
            Dim dt As New DataTable()
            dt.Columns.Add("Product ID", GetType(Integer))
            dt.Columns.Add("Product Name", GetType(String))
            dt.Columns.Add("Current Stock", GetType(Integer))
            dt.Columns.Add("Reorder Level", GetType(Integer))
            dt.Columns.Add("Deficit", GetType(Integer))
            dt.Columns.Add("Suggested Order", GetType(Integer))

            ' Use localDataSet
            For Each product In localDataSet.Products
                If product.QuantityInStock < product.ReorderLevel Then
                    Dim row = dt.NewRow()
                    row("Product ID") = product.ProductID
                    row("Product Name") = product.ProductName
                    row("Current Stock") = product.QuantityInStock
                    row("Reorder Level") = product.ReorderLevel
                    row("Deficit") = product.ReorderLevel - product.QuantityInStock
                    row("Suggested Order") = product.ReorderLevel * 2 - product.QuantityInStock
                    dt.Rows.Add(row)
                End If
            Next

            dgvReport.DataSource = dt
            lblTotal.Text = $"Total Low Stock Items: {dt.Rows.Count}"

            If dt.Rows.Count = 0 Then
                MessageBox.Show("No low stock items found!", "Good News",
                              MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Error generating low stock report: " & ex.Message)
        End Try
    End Sub

    ' Profit Report
    Private Sub btnProfitReport_Click(sender As Object, e As EventArgs) Handles btnProfitReport.Click
        Try
            Dim startDate = dtpStartDate.Value.Date
            Dim endDate = dtpEndDate.Value.Date.AddDays(1).AddSeconds(-1)

            Dim dt As New DataTable()
            dt.Columns.Add("Date", GetType(DateTime))
            dt.Columns.Add("Product", GetType(String))
            dt.Columns.Add("Quantity", GetType(Integer))
            dt.Columns.Add("Buying Price", GetType(Decimal))
            dt.Columns.Add("Selling Price", GetType(Decimal))
            dt.Columns.Add("Revenue", GetType(Decimal))
            dt.Columns.Add("Cost", GetType(Decimal))
            dt.Columns.Add("Profit", GetType(Decimal))
            dt.Columns.Add("Margin %", GetType(Decimal))

            Dim totalProfit As Decimal = 0
            Dim totalRevenue As Decimal = 0

            ' Use localDataSet - manual filtering without LINQ
            For Each sale In localDataSet.Sales
                If sale.SaleDate >= startDate And sale.SaleDate <= endDate Then
                    Dim product = localDataSet.Products.FindByProductID(sale.ProductID)
                    If product IsNot Nothing Then
                        Dim row = dt.NewRow()
                        row("Date") = sale.SaleDate
                        row("Product") = product.ProductName
                        row("Quantity") = sale.QuantitySold
                        row("Buying Price") = product.BuyingPrice
                        row("Selling Price") = product.SellingPrice

                        Dim revenue = sale.TotalPrice
                        Dim cost = product.BuyingPrice * sale.QuantitySold
                        Dim profit = revenue - cost
                        Dim margin = If(revenue > 0, (profit / revenue) * 100, 0)

                        row("Revenue") = revenue
                        row("Cost") = cost
                        row("Profit") = profit
                        row("Margin %") = Math.Round(margin, 2)

                        dt.Rows.Add(row)

                        totalProfit += profit
                        totalRevenue += revenue
                    End If
                End If
            Next

            dgvReport.DataSource = dt
            Dim profitMargin = If(totalRevenue > 0, (totalProfit / totalRevenue) * 100, 0)
            lblTotal.Text = $"Total Profit: {totalProfit:C} | Margin: {Math.Round(profitMargin, 2)}%"

        Catch ex As Exception
            MessageBox.Show("Error generating profit report: " & ex.Message)
        End Try
    End Sub

    ' Export to Excel
    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        If dgvReport.DataSource Is Nothing OrElse dgvReport.Rows.Count = 0 Then
            MessageBox.Show("No data to export.", "Warning",
                          MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim saveDialog As New SaveFileDialog()
            saveDialog.Filter = "CSV Files (*.csv)|*.csv|Excel Files (*.xlsx)|*.xlsx"
            saveDialog.DefaultExt = "csv"
            saveDialog.FileName = $"Report_{DateTime.Now:yyyyMMdd_HHmmss}"

            If saveDialog.ShowDialog() = DialogResult.OK Then
                ' Simple CSV export
                Using sw As New IO.StreamWriter(saveDialog.FileName)
                    ' Write headers
                    For i As Integer = 0 To dgvReport.Columns.Count - 1
                        sw.Write(dgvReport.Columns(i).HeaderText)
                        If i < dgvReport.Columns.Count - 1 Then sw.Write(",")
                    Next
                    sw.WriteLine()

                    ' Write data
                    For Each row As DataGridViewRow In dgvReport.Rows
                        For i As Integer = 0 To dgvReport.Columns.Count - 1
                            Dim value = If(row.Cells(i).Value Is Nothing, "", row.Cells(i).Value.ToString())
                            If value.Contains(",") Then value = """" & value & """"
                            sw.Write(value)
                            If i < dgvReport.Columns.Count - 1 Then sw.Write(",")
                        Next
                        sw.WriteLine()
                    Next
                End Using

                MessageBox.Show($"Report exported successfully to:{Environment.NewLine}{saveDialog.FileName}",
                              "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error exporting report: " & ex.Message, "Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private SharedDataSet As MyInventoryDataSet

    Public Sub SetDataSet(dataset As MyInventoryDataSet)
        SharedDataSet = dataset
    End Sub
End Class
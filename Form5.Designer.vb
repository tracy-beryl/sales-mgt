<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim SaleIDLabel As System.Windows.Forms.Label
        Dim ProductIDLabel As System.Windows.Forms.Label
        Dim QuantitySoldLabel As System.Windows.Forms.Label
        Dim TotalPriceLabel As System.Windows.Forms.Label
        Dim SaleDateLabel As System.Windows.Forms.Label
        Dim SoldByLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.MyInventoryDataSet = New Sales_Management_System.MyInventoryDataSet()
        Me.SalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalesTableAdapter = New Sales_Management_System.MyInventoryDataSetTableAdapters.SalesTableAdapter()
        Me.TableAdapterManager = New Sales_Management_System.MyInventoryDataSetTableAdapters.TableAdapterManager()
        Me.SalesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.SalesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SaleIDTextBox = New System.Windows.Forms.TextBox()
        Me.ProductIDTextBox = New System.Windows.Forms.TextBox()
        Me.QuantitySoldTextBox = New System.Windows.Forms.TextBox()
        Me.TotalPriceTextBox = New System.Windows.Forms.TextBox()
        Me.SaleDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.SoldByTextBox = New System.Windows.Forms.TextBox()
        Me.btnSearchByDate = New System.Windows.Forms.Button()
        Me.lblSellingPrice = New System.Windows.Forms.Label()
        Me.lblTotalPrice = New System.Windows.Forms.Label()
        Me.lblProfit = New System.Windows.Forms.Label()
        SaleIDLabel = New System.Windows.Forms.Label()
        ProductIDLabel = New System.Windows.Forms.Label()
        QuantitySoldLabel = New System.Windows.Forms.Label()
        TotalPriceLabel = New System.Windows.Forms.Label()
        SaleDateLabel = New System.Windows.Forms.Label()
        SoldByLabel = New System.Windows.Forms.Label()
        CType(Me.MyInventoryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SalesBindingNavigator.SuspendLayout()
        CType(Me.SalesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SaleIDLabel
        '
        SaleIDLabel.AutoSize = True
        SaleIDLabel.Location = New System.Drawing.Point(86, 83)
        SaleIDLabel.Name = "SaleIDLabel"
        SaleIDLabel.Size = New System.Drawing.Size(45, 13)
        SaleIDLabel.TabIndex = 17
        SaleIDLabel.Text = "Sale ID:"
        '
        'ProductIDLabel
        '
        ProductIDLabel.AutoSize = True
        ProductIDLabel.Location = New System.Drawing.Point(86, 109)
        ProductIDLabel.Name = "ProductIDLabel"
        ProductIDLabel.Size = New System.Drawing.Size(61, 13)
        ProductIDLabel.TabIndex = 19
        ProductIDLabel.Text = "Product ID:"
        '
        'QuantitySoldLabel
        '
        QuantitySoldLabel.AutoSize = True
        QuantitySoldLabel.Location = New System.Drawing.Point(86, 135)
        QuantitySoldLabel.Name = "QuantitySoldLabel"
        QuantitySoldLabel.Size = New System.Drawing.Size(73, 13)
        QuantitySoldLabel.TabIndex = 21
        QuantitySoldLabel.Text = "Quantity Sold:"
        '
        'TotalPriceLabel
        '
        TotalPriceLabel.AutoSize = True
        TotalPriceLabel.Location = New System.Drawing.Point(86, 161)
        TotalPriceLabel.Name = "TotalPriceLabel"
        TotalPriceLabel.Size = New System.Drawing.Size(61, 13)
        TotalPriceLabel.TabIndex = 23
        TotalPriceLabel.Text = "Total Price:"
        '
        'SaleDateLabel
        '
        SaleDateLabel.AutoSize = True
        SaleDateLabel.Location = New System.Drawing.Point(86, 188)
        SaleDateLabel.Name = "SaleDateLabel"
        SaleDateLabel.Size = New System.Drawing.Size(57, 13)
        SaleDateLabel.TabIndex = 25
        SaleDateLabel.Text = "Sale Date:"
        '
        'SoldByLabel
        '
        SoldByLabel.AutoSize = True
        SoldByLabel.Location = New System.Drawing.Point(86, 213)
        SoldByLabel.Name = "SoldByLabel"
        SoldByLabel.Size = New System.Drawing.Size(46, 13)
        SoldByLabel.TabIndex = 27
        SoldByLabel.Text = "Sold By:"
        '
        'MyInventoryDataSet
        '
        Me.MyInventoryDataSet.DataSetName = "MyInventoryDataSet"
        Me.MyInventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SalesBindingSource
        '
        Me.SalesBindingSource.DataMember = "Sales"
        Me.SalesBindingSource.DataSource = Me.MyInventoryDataSet
        '
        'SalesTableAdapter
        '
        Me.SalesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ProductsTableAdapter = Nothing
        Me.TableAdapterManager.SalesTableAdapter = Me.SalesTableAdapter
        Me.TableAdapterManager.SuppliersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sales_Management_System.MyInventoryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        '
        'SalesBindingNavigator
        '
        Me.SalesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SalesBindingNavigator.BindingSource = Me.SalesBindingSource
        Me.SalesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SalesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SalesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SalesBindingNavigatorSaveItem})
        Me.SalesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SalesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SalesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SalesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SalesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SalesBindingNavigator.Name = "SalesBindingNavigator"
        Me.SalesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SalesBindingNavigator.Size = New System.Drawing.Size(1058, 25)
        Me.SalesBindingNavigator.TabIndex = 0
        Me.SalesBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'SalesBindingNavigatorSaveItem
        '
        Me.SalesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SalesBindingNavigatorSaveItem.Image = CType(resources.GetObject("SalesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SalesBindingNavigatorSaveItem.Name = "SalesBindingNavigatorSaveItem"
        Me.SalesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.SalesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'SalesDataGridView
        '
        Me.SalesDataGridView.AutoGenerateColumns = False
        Me.SalesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SalesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.SalesDataGridView.DataSource = Me.SalesBindingSource
        Me.SalesDataGridView.Location = New System.Drawing.Point(60, 300)
        Me.SalesDataGridView.Name = "SalesDataGridView"
        Me.SalesDataGridView.Size = New System.Drawing.Size(767, 242)
        Me.SalesDataGridView.TabIndex = 13
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "SaleID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "SaleID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ProductID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ProductID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "QuantitySold"
        Me.DataGridViewTextBoxColumn3.HeaderText = "QuantitySold"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "TotalPrice"
        Me.DataGridViewTextBoxColumn4.HeaderText = "TotalPrice"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "SaleDate"
        Me.DataGridViewTextBoxColumn5.HeaderText = "SaleDate"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "SoldBy"
        Me.DataGridViewTextBoxColumn6.HeaderText = "SoldBy"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'txtSearch
        '
        Me.txtSearch.HideSelection = False
        Me.txtSearch.Location = New System.Drawing.Point(533, 206)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(100, 20)
        Me.txtSearch.TabIndex = 14
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(727, 80)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 15
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(738, 208)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 16
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(727, 125)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 17
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'SaleIDTextBox
        '
        Me.SaleIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesBindingSource, "SaleID", True))
        Me.SaleIDTextBox.Location = New System.Drawing.Point(165, 80)
        Me.SaleIDTextBox.Name = "SaleIDTextBox"
        Me.SaleIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SaleIDTextBox.TabIndex = 18
        '
        'ProductIDTextBox
        '
        Me.ProductIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesBindingSource, "ProductID", True))
        Me.ProductIDTextBox.Location = New System.Drawing.Point(165, 106)
        Me.ProductIDTextBox.Name = "ProductIDTextBox"
        Me.ProductIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ProductIDTextBox.TabIndex = 20
        '
        'QuantitySoldTextBox
        '
        Me.QuantitySoldTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesBindingSource, "QuantitySold", True))
        Me.QuantitySoldTextBox.Location = New System.Drawing.Point(165, 132)
        Me.QuantitySoldTextBox.Name = "QuantitySoldTextBox"
        Me.QuantitySoldTextBox.Size = New System.Drawing.Size(200, 20)
        Me.QuantitySoldTextBox.TabIndex = 22
        '
        'TotalPriceTextBox
        '
        Me.TotalPriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesBindingSource, "TotalPrice", True))
        Me.TotalPriceTextBox.Location = New System.Drawing.Point(165, 158)
        Me.TotalPriceTextBox.Name = "TotalPriceTextBox"
        Me.TotalPriceTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TotalPriceTextBox.TabIndex = 24
        '
        'SaleDateDateTimePicker
        '
        Me.SaleDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SalesBindingSource, "SaleDate", True))
        Me.SaleDateDateTimePicker.Location = New System.Drawing.Point(165, 184)
        Me.SaleDateDateTimePicker.Name = "SaleDateDateTimePicker"
        Me.SaleDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.SaleDateDateTimePicker.TabIndex = 26
        '
        'SoldByTextBox
        '
        Me.SoldByTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesBindingSource, "SoldBy", True))
        Me.SoldByTextBox.Location = New System.Drawing.Point(165, 210)
        Me.SoldByTextBox.Name = "SoldByTextBox"
        Me.SoldByTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SoldByTextBox.TabIndex = 28
        '
        'btnSearchByDate
        '
        Me.btnSearchByDate.Location = New System.Drawing.Point(726, 161)
        Me.btnSearchByDate.Name = "btnSearchByDate"
        Me.btnSearchByDate.Size = New System.Drawing.Size(87, 23)
        Me.btnSearchByDate.TabIndex = 29
        Me.btnSearchByDate.Text = "SearchByDate"
        Me.btnSearchByDate.UseVisualStyleBackColor = True
        '
        'lblSellingPrice
        '
        Me.lblSellingPrice.AutoSize = True
        Me.lblSellingPrice.Location = New System.Drawing.Point(548, 80)
        Me.lblSellingPrice.Name = "lblSellingPrice"
        Me.lblSellingPrice.Size = New System.Drawing.Size(62, 13)
        Me.lblSellingPrice.TabIndex = 30
        Me.lblSellingPrice.Text = "SellingPrice"
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.AutoSize = True
        Me.lblTotalPrice.Location = New System.Drawing.Point(555, 130)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(55, 13)
        Me.lblTotalPrice.TabIndex = 31
        Me.lblTotalPrice.Text = "TotalPrice"
        '
        'lblProfit
        '
        Me.lblProfit.AutoSize = True
        Me.lblProfit.Location = New System.Drawing.Point(555, 171)
        Me.lblProfit.Name = "lblProfit"
        Me.lblProfit.Size = New System.Drawing.Size(31, 13)
        Me.lblProfit.TabIndex = 32
        Me.lblProfit.Text = "Profit"
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1058, 562)
        Me.Controls.Add(Me.lblProfit)
        Me.Controls.Add(Me.lblTotalPrice)
        Me.Controls.Add(Me.lblSellingPrice)
        Me.Controls.Add(Me.btnSearchByDate)
        Me.Controls.Add(SaleIDLabel)
        Me.Controls.Add(Me.SaleIDTextBox)
        Me.Controls.Add(ProductIDLabel)
        Me.Controls.Add(Me.ProductIDTextBox)
        Me.Controls.Add(QuantitySoldLabel)
        Me.Controls.Add(Me.QuantitySoldTextBox)
        Me.Controls.Add(TotalPriceLabel)
        Me.Controls.Add(Me.TotalPriceTextBox)
        Me.Controls.Add(SaleDateLabel)
        Me.Controls.Add(Me.SaleDateDateTimePicker)
        Me.Controls.Add(SoldByLabel)
        Me.Controls.Add(Me.SoldByTextBox)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.SalesDataGridView)
        Me.Controls.Add(Me.SalesBindingNavigator)
        Me.Name = "Form5"
        Me.Text = "Form5"
        CType(Me.MyInventoryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SalesBindingNavigator.ResumeLayout(False)
        Me.SalesBindingNavigator.PerformLayout()
        CType(Me.SalesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MyInventoryDataSet As MyInventoryDataSet
    Friend WithEvents SalesBindingSource As BindingSource
    Friend WithEvents SalesTableAdapter As MyInventoryDataSetTableAdapters.SalesTableAdapter
    Friend WithEvents TableAdapterManager As MyInventoryDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SalesBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents SalesBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents dtpSaleDate As DateTimePicker
    Friend WithEvents SalesDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents cboProduct As ComboBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClearFilter As Button
    Friend WithEvents btnProcessSale As Button
    Friend WithEvents btnPrintReceipt As Button
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents SaleIDTextBox As TextBox
    Friend WithEvents ProductIDTextBox As TextBox
    Friend WithEvents QuantitySoldTextBox As TextBox
    Friend WithEvents TotalPriceTextBox As TextBox
    Friend WithEvents SaleDateDateTimePicker As DateTimePicker
    Friend WithEvents SoldByTextBox As TextBox
    Friend WithEvents btnSearchByDate As Button
    Friend WithEvents lblSellingPrice As Label
    Friend WithEvents lblTotalPrice As Label
    Friend WithEvents lblProfit As Label
End Class

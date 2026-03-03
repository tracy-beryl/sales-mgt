<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.btnProducts = New System.Windows.Forms.Button()
        Me.btnSuppliers = New System.Windows.Forms.Button()
        Me.btnSales = New System.Windows.Forms.Button()
        Me.btnUsers = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnProducts
        '
        Me.btnProducts.Location = New System.Drawing.Point(113, 99)
        Me.btnProducts.Name = "btnProducts"
        Me.btnProducts.Size = New System.Drawing.Size(75, 23)
        Me.btnProducts.TabIndex = 0
        Me.btnProducts.Text = " Products"
        Me.btnProducts.UseVisualStyleBackColor = True
        '
        'btnSuppliers
        '
        Me.btnSuppliers.Location = New System.Drawing.Point(274, 99)
        Me.btnSuppliers.Name = "btnSuppliers"
        Me.btnSuppliers.Size = New System.Drawing.Size(75, 23)
        Me.btnSuppliers.TabIndex = 1
        Me.btnSuppliers.Text = "Suppliers"
        Me.btnSuppliers.UseVisualStyleBackColor = True
        '
        'btnSales
        '
        Me.btnSales.Location = New System.Drawing.Point(464, 99)
        Me.btnSales.Name = "btnSales"
        Me.btnSales.Size = New System.Drawing.Size(75, 23)
        Me.btnSales.TabIndex = 2
        Me.btnSales.Text = "Sales"
        Me.btnSales.UseVisualStyleBackColor = True
        '
        'btnUsers
        '
        Me.btnUsers.Location = New System.Drawing.Point(274, 217)
        Me.btnUsers.Name = "btnUsers"
        Me.btnUsers.Size = New System.Drawing.Size(75, 23)
        Me.btnUsers.TabIndex = 3
        Me.btnUsers.Text = "Users"
        Me.btnUsers.UseVisualStyleBackColor = True
        '
        'btnReports
        '
        Me.btnReports.Location = New System.Drawing.Point(113, 217)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(75, 23)
        Me.btnReports.TabIndex = 4
        Me.btnReports.Text = "Reports"
        Me.btnReports.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(464, 217)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(75, 23)
        Me.btnLogout.TabIndex = 5
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Location = New System.Drawing.Point(288, 26)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(52, 13)
        Me.lblWelcome.TabIndex = 6
        Me.lblWelcome.Text = "Welcome"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnReports)
        Me.Controls.Add(Me.btnUsers)
        Me.Controls.Add(Me.btnSales)
        Me.Controls.Add(Me.btnSuppliers)
        Me.Controls.Add(Me.btnProducts)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnProducts As Button
    Friend WithEvents btnSuppliers As Button
    Friend WithEvents btnSales As Button
    Friend WithEvents btnUsers As Button
    Friend WithEvents btnReports As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents lblWelcome As Label
End Class

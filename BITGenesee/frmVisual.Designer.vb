<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVisual
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVisual))
        Me.lstNodes = New System.Windows.Forms.ListBox()
        Me.trvArcs = New System.Windows.Forms.TreeView()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.lstProducts = New System.Windows.Forms.ListBox()
        Me.txtCapacity = New System.Windows.Forms.TextBox()
        Me.txtFlow = New System.Windows.Forms.TextBox()
        Me.txtDemand = New System.Windows.Forms.TextBox()
        Me.btnSolve = New System.Windows.Forms.Button()
        Me.txtTotalCost = New System.Windows.Forms.TextBox()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.lblProdDem = New System.Windows.Forms.Label()
        Me.lblArcCost = New System.Windows.Forms.Label()
        Me.lblCapacity = New System.Windows.Forms.Label()
        Me.LblProdFlow = New System.Windows.Forms.Label()
        Me.lblSatisfiedDem = New System.Windows.Forms.Label()
        Me.txtSatisfiedDemand = New System.Windows.Forms.TextBox()
        Me.btnNodes = New System.Windows.Forms.Button()
        Me.btnProduct = New System.Windows.Forms.Button()
        Me.cbxSelected = New System.Windows.Forms.CheckBox()
        Me.btnArc = New System.Windows.Forms.Button()
        Me.btnShowMap = New System.Windows.Forms.Button()
        Me.BtnExport = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstNodes
        '
        Me.lstNodes.FormattingEnabled = True
        Me.lstNodes.ItemHeight = 20
        Me.lstNodes.Location = New System.Drawing.Point(28, 11)
        Me.lstNodes.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstNodes.Name = "lstNodes"
        Me.lstNodes.Size = New System.Drawing.Size(180, 364)
        Me.lstNodes.TabIndex = 0
        '
        'trvArcs
        '
        Me.trvArcs.Location = New System.Drawing.Point(339, 11)
        Me.trvArcs.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.trvArcs.Name = "trvArcs"
        Me.trvArcs.Size = New System.Drawing.Size(253, 364)
        Me.trvArcs.TabIndex = 1
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(414, 406)
        Me.txtCost.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(178, 26)
        Me.txtCost.TabIndex = 2
        '
        'lstProducts
        '
        Me.lstProducts.FormattingEnabled = True
        Me.lstProducts.ItemHeight = 20
        Me.lstProducts.Location = New System.Drawing.Point(28, 406)
        Me.lstProducts.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstProducts.Name = "lstProducts"
        Me.lstProducts.Size = New System.Drawing.Size(178, 144)
        Me.lstProducts.TabIndex = 3
        '
        'txtCapacity
        '
        Me.txtCapacity.Location = New System.Drawing.Point(414, 446)
        Me.txtCapacity.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCapacity.Name = "txtCapacity"
        Me.txtCapacity.Size = New System.Drawing.Size(178, 26)
        Me.txtCapacity.TabIndex = 4
        '
        'txtFlow
        '
        Me.txtFlow.Location = New System.Drawing.Point(414, 486)
        Me.txtFlow.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtFlow.Name = "txtFlow"
        Me.txtFlow.Size = New System.Drawing.Size(178, 26)
        Me.txtFlow.TabIndex = 5
        '
        'txtDemand
        '
        Me.txtDemand.Location = New System.Drawing.Point(164, 562)
        Me.txtDemand.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDemand.Name = "txtDemand"
        Me.txtDemand.Size = New System.Drawing.Size(148, 26)
        Me.txtDemand.TabIndex = 6
        '
        'btnSolve
        '
        Me.btnSolve.Location = New System.Drawing.Point(28, 606)
        Me.btnSolve.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSolve.Name = "btnSolve"
        Me.btnSolve.Size = New System.Drawing.Size(285, 35)
        Me.btnSolve.TabIndex = 7
        Me.btnSolve.Text = "Solve LP Model"
        Me.btnSolve.UseVisualStyleBackColor = True
        '
        'txtTotalCost
        '
        Me.txtTotalCost.Location = New System.Drawing.Point(164, 692)
        Me.txtTotalCost.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTotalCost.Name = "txtTotalCost"
        Me.txtTotalCost.Size = New System.Drawing.Size(148, 26)
        Me.txtTotalCost.TabIndex = 8
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Location = New System.Drawing.Point(24, 697)
        Me.lblTotalCost.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(81, 20)
        Me.lblTotalCost.TabIndex = 9
        Me.lblTotalCost.Text = "Total Cost"
        '
        'lblProdDem
        '
        Me.lblProdDem.AutoSize = True
        Me.lblProdDem.Location = New System.Drawing.Point(24, 566)
        Me.lblProdDem.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProdDem.Name = "lblProdDem"
        Me.lblProdDem.Size = New System.Drawing.Size(129, 20)
        Me.lblProdDem.TabIndex = 10
        Me.lblProdDem.Text = "Product Demand"
        '
        'lblArcCost
        '
        Me.lblArcCost.AutoSize = True
        Me.lblArcCost.Location = New System.Drawing.Point(273, 411)
        Me.lblArcCost.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblArcCost.Name = "lblArcCost"
        Me.lblArcCost.Size = New System.Drawing.Size(130, 20)
        Me.lblArcCost.TabIndex = 11
        Me.lblArcCost.Text = "Arc Cost Per Mile"
        '
        'lblCapacity
        '
        Me.lblCapacity.AutoSize = True
        Me.lblCapacity.Location = New System.Drawing.Point(225, 451)
        Me.lblCapacity.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCapacity.Name = "lblCapacity"
        Me.lblCapacity.Size = New System.Drawing.Size(178, 20)
        Me.lblCapacity.TabIndex = 12
        Me.lblCapacity.Text = "Remaining Arc Capacity"
        '
        'LblProdFlow
        '
        Me.LblProdFlow.AutoSize = True
        Me.LblProdFlow.Location = New System.Drawing.Point(302, 491)
        Me.LblProdFlow.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblProdFlow.Name = "LblProdFlow"
        Me.LblProdFlow.Size = New System.Drawing.Size(101, 20)
        Me.LblProdFlow.TabIndex = 13
        Me.LblProdFlow.Text = "Product Flow"
        '
        'lblSatisfiedDem
        '
        Me.lblSatisfiedDem.AutoSize = True
        Me.lblSatisfiedDem.Location = New System.Drawing.Point(24, 740)
        Me.lblSatisfiedDem.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSatisfiedDem.Name = "lblSatisfiedDem"
        Me.lblSatisfiedDem.Size = New System.Drawing.Size(136, 20)
        Me.lblSatisfiedDem.TabIndex = 14
        Me.lblSatisfiedDem.Text = "Satisfied Demand"
        '
        'txtSatisfiedDemand
        '
        Me.txtSatisfiedDemand.Location = New System.Drawing.Point(164, 735)
        Me.txtSatisfiedDemand.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSatisfiedDemand.Name = "txtSatisfiedDemand"
        Me.txtSatisfiedDemand.Size = New System.Drawing.Size(148, 26)
        Me.txtSatisfiedDemand.TabIndex = 15
        '
        'btnNodes
        '
        Me.btnNodes.Location = New System.Drawing.Point(387, 549)
        Me.btnNodes.Name = "btnNodes"
        Me.btnNodes.Size = New System.Drawing.Size(206, 37)
        Me.btnNodes.TabIndex = 16
        Me.btnNodes.Text = "Show Nodes Form"
        Me.btnNodes.UseVisualStyleBackColor = True
        '
        'btnProduct
        '
        Me.btnProduct.Location = New System.Drawing.Point(386, 606)
        Me.btnProduct.Name = "btnProduct"
        Me.btnProduct.Size = New System.Drawing.Size(206, 37)
        Me.btnProduct.TabIndex = 17
        Me.btnProduct.Text = "Show Products Form"
        Me.btnProduct.UseVisualStyleBackColor = True
        '
        'cbxSelected
        '
        Me.cbxSelected.AutoSize = True
        Me.cbxSelected.Location = New System.Drawing.Point(28, 652)
        Me.cbxSelected.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbxSelected.Name = "cbxSelected"
        Me.cbxSelected.Size = New System.Drawing.Size(251, 24)
        Me.cbxSelected.TabIndex = 18
        Me.cbxSelected.Text = "Solve for selected product only"
        Me.cbxSelected.UseVisualStyleBackColor = True
        '
        'btnArc
        '
        Me.btnArc.Location = New System.Drawing.Point(386, 665)
        Me.btnArc.Name = "btnArc"
        Me.btnArc.Size = New System.Drawing.Size(206, 37)
        Me.btnArc.TabIndex = 20
        Me.btnArc.Text = "Show Arc Form"
        Me.btnArc.UseVisualStyleBackColor = True
        '
        'btnShowMap
        '
        Me.btnShowMap.Location = New System.Drawing.Point(386, 723)
        Me.btnShowMap.Name = "btnShowMap"
        Me.btnShowMap.Size = New System.Drawing.Size(206, 37)
        Me.btnShowMap.TabIndex = 21
        Me.btnShowMap.Text = "Show Map Form"
        Me.btnShowMap.UseVisualStyleBackColor = True
        '
        'BtnExport
        '
        Me.BtnExport.Location = New System.Drawing.Point(28, 778)
        Me.BtnExport.Name = "BtnExport"
        Me.BtnExport.Size = New System.Drawing.Size(285, 28)
        Me.BtnExport.TabIndex = 22
        Me.BtnExport.Text = "Export Database"
        Me.BtnExport.UseVisualStyleBackColor = True
        '
        'frmVisual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(638, 818)
        Me.Controls.Add(Me.BtnExport)
        Me.Controls.Add(Me.btnShowMap)
        Me.Controls.Add(Me.btnArc)
        Me.Controls.Add(Me.cbxSelected)
        Me.Controls.Add(Me.btnProduct)
        Me.Controls.Add(Me.btnNodes)
        Me.Controls.Add(Me.txtSatisfiedDemand)
        Me.Controls.Add(Me.lblSatisfiedDem)
        Me.Controls.Add(Me.LblProdFlow)
        Me.Controls.Add(Me.lblCapacity)
        Me.Controls.Add(Me.lblArcCost)
        Me.Controls.Add(Me.lblProdDem)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.txtTotalCost)
        Me.Controls.Add(Me.btnSolve)
        Me.Controls.Add(Me.txtDemand)
        Me.Controls.Add(Me.txtFlow)
        Me.Controls.Add(Me.txtCapacity)
        Me.Controls.Add(Me.lstProducts)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.trvArcs)
        Me.Controls.Add(Me.lstNodes)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmVisual"
        Me.Text = "Network"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstNodes As ListBox
    Friend WithEvents trvArcs As TreeView
    Friend WithEvents txtCost As TextBox
    Friend WithEvents lstProducts As ListBox
    Friend WithEvents txtCapacity As TextBox
    Friend WithEvents txtFlow As TextBox
    Friend WithEvents txtDemand As TextBox
    Friend WithEvents btnSolve As Button
    Friend WithEvents txtTotalCost As TextBox
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents lblProdDem As Label
    Friend WithEvents lblArcCost As Label
    Friend WithEvents lblCapacity As Label
    Friend WithEvents LblProdFlow As Label
    Friend WithEvents lblSatisfiedDem As Label
    Friend WithEvents txtSatisfiedDemand As TextBox
    Friend WithEvents btnNodes As Button
    Friend WithEvents btnProduct As Button
    Friend WithEvents cbxSelected As CheckBox
    Friend WithEvents btnArc As Button
    Friend WithEvents btnShowMap As Button
    Friend WithEvents BtnExport As Button
End Class

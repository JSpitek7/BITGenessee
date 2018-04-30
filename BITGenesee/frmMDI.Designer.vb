<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMDI
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.SolverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SolveWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SolveLPModelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GeneseeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Team14ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NodesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArcsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SolverToolStripMenuItem, Me.DataToolStripMenuItem, Me.WindowToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.MdiWindowListItem = Me.WindowToolStripMenuItem
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(557, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 33)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(557, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'SolverToolStripMenuItem
        '
        Me.SolverToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SolveWindowToolStripMenuItem, Me.SolveLPModelToolStripMenuItem})
        Me.SolverToolStripMenuItem.Name = "SolverToolStripMenuItem"
        Me.SolverToolStripMenuItem.Size = New System.Drawing.Size(73, 29)
        Me.SolverToolStripMenuItem.Text = "Solver"
        '
        'DataToolStripMenuItem
        '
        Me.DataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NodesToolStripMenuItem, Me.ProductsToolStripMenuItem, Me.ArcsToolStripMenuItem})
        Me.DataToolStripMenuItem.Name = "DataToolStripMenuItem"
        Me.DataToolStripMenuItem.Size = New System.Drawing.Size(61, 29)
        Me.DataToolStripMenuItem.Text = "Data"
        '
        'WindowToolStripMenuItem
        '
        Me.WindowToolStripMenuItem.Name = "WindowToolStripMenuItem"
        Me.WindowToolStripMenuItem.Size = New System.Drawing.Size(90, 29)
        Me.WindowToolStripMenuItem.Text = "Window"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GeneseeToolStripMenuItem, Me.Team14ToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(74, 29)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'SolveWindowToolStripMenuItem
        '
        Me.SolveWindowToolStripMenuItem.Name = "SolveWindowToolStripMenuItem"
        Me.SolveWindowToolStripMenuItem.Size = New System.Drawing.Size(218, 30)
        Me.SolveWindowToolStripMenuItem.Text = "Solve Window"
        '
        'SolveLPModelToolStripMenuItem
        '
        Me.SolveLPModelToolStripMenuItem.Name = "SolveLPModelToolStripMenuItem"
        Me.SolveLPModelToolStripMenuItem.Size = New System.Drawing.Size(218, 30)
        Me.SolveLPModelToolStripMenuItem.Text = "Solve LP Model"
        '
        'GeneseeToolStripMenuItem
        '
        Me.GeneseeToolStripMenuItem.Name = "GeneseeToolStripMenuItem"
        Me.GeneseeToolStripMenuItem.Size = New System.Drawing.Size(210, 30)
        Me.GeneseeToolStripMenuItem.Text = "Genesee"
        '
        'Team14ToolStripMenuItem
        '
        Me.Team14ToolStripMenuItem.Name = "Team14ToolStripMenuItem"
        Me.Team14ToolStripMenuItem.Size = New System.Drawing.Size(210, 30)
        Me.Team14ToolStripMenuItem.Text = "Team 14"
        '
        'NodesToolStripMenuItem
        '
        Me.NodesToolStripMenuItem.Name = "NodesToolStripMenuItem"
        Me.NodesToolStripMenuItem.Size = New System.Drawing.Size(210, 30)
        Me.NodesToolStripMenuItem.Text = "Nodes"
        '
        'ProductsToolStripMenuItem
        '
        Me.ProductsToolStripMenuItem.Name = "ProductsToolStripMenuItem"
        Me.ProductsToolStripMenuItem.Size = New System.Drawing.Size(210, 30)
        Me.ProductsToolStripMenuItem.Text = "Products"
        '
        'ArcsToolStripMenuItem
        '
        Me.ArcsToolStripMenuItem.Name = "ArcsToolStripMenuItem"
        Me.ArcsToolStripMenuItem.Size = New System.Drawing.Size(210, 30)
        Me.ArcsToolStripMenuItem.Text = "Arcs"
        '
        'frmMDI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 395)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMDI"
        Me.Text = "Network Solver"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents SolverToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SolveWindowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SolveLPModelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NodesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ArcsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WindowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GeneseeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Team14ToolStripMenuItem As ToolStripMenuItem
End Class

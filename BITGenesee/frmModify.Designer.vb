<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModify
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
        Me.lstNode = New System.Windows.Forms.ListBox()
        Me.lblSelectNode = New System.Windows.Forms.Label()
        Me.btnChgDem = New System.Windows.Forms.Button()
        Me.txtDemand = New System.Windows.Forms.TextBox()
        Me.btnDefault = New System.Windows.Forms.Button()
        Me.lblDemand = New System.Windows.Forms.Label()
        Me.LstProd = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lstNode
        '
        Me.lstNode.FormattingEnabled = True
        Me.lstNode.ItemHeight = 20
        Me.lstNode.Location = New System.Drawing.Point(111, 37)
        Me.lstNode.Name = "lstNode"
        Me.lstNode.Size = New System.Drawing.Size(236, 24)
        Me.lstNode.TabIndex = 0
        '
        'lblSelectNode
        '
        Me.lblSelectNode.AutoSize = True
        Me.lblSelectNode.Location = New System.Drawing.Point(9, 38)
        Me.lblSelectNode.Name = "lblSelectNode"
        Me.lblSelectNode.Size = New System.Drawing.Size(96, 20)
        Me.lblSelectNode.TabIndex = 1
        Me.lblSelectNode.Text = "Select Node"
        '
        'btnChgDem
        '
        Me.btnChgDem.Location = New System.Drawing.Point(362, 95)
        Me.btnChgDem.Name = "btnChgDem"
        Me.btnChgDem.Size = New System.Drawing.Size(126, 41)
        Me.btnChgDem.TabIndex = 2
        Me.btnChgDem.Text = "Change Demand"
        Me.btnChgDem.UseVisualStyleBackColor = True
        '
        'txtDemand
        '
        Me.txtDemand.Location = New System.Drawing.Point(111, 110)
        Me.txtDemand.Name = "txtDemand"
        Me.txtDemand.Size = New System.Drawing.Size(236, 26)
        Me.txtDemand.TabIndex = 3
        '
        'btnDefault
        '
        Me.btnDefault.Location = New System.Drawing.Point(362, 37)
        Me.btnDefault.Name = "btnDefault"
        Me.btnDefault.Size = New System.Drawing.Size(126, 41)
        Me.btnDefault.TabIndex = 4
        Me.btnDefault.Text = "Reset"
        Me.btnDefault.UseVisualStyleBackColor = True
        '
        'lblDemand
        '
        Me.lblDemand.AutoSize = True
        Me.lblDemand.Location = New System.Drawing.Point(12, 113)
        Me.lblDemand.Name = "lblDemand"
        Me.lblDemand.Size = New System.Drawing.Size(70, 20)
        Me.lblDemand.TabIndex = 5
        Me.lblDemand.Text = "Demand"
        '
        'LstProd
        '
        Me.LstProd.FormattingEnabled = True
        Me.LstProd.ItemHeight = 20
        Me.LstProd.Location = New System.Drawing.Point(111, 67)
        Me.LstProd.Name = "LstProd"
        Me.LstProd.Size = New System.Drawing.Size(236, 24)
        Me.LstProd.TabIndex = 6
        '
        'frmModify
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 471)
        Me.Controls.Add(Me.LstProd)
        Me.Controls.Add(Me.lblDemand)
        Me.Controls.Add(Me.btnDefault)
        Me.Controls.Add(Me.txtDemand)
        Me.Controls.Add(Me.btnChgDem)
        Me.Controls.Add(Me.lblSelectNode)
        Me.Controls.Add(Me.lstNode)
        Me.Name = "frmModify"
        Me.Text = "frmModify"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstNode As ListBox
    Friend WithEvents lblSelectNode As Label
    Friend WithEvents btnChgDem As Button
    Friend WithEvents txtDemand As TextBox
    Friend WithEvents btnDefault As Button
    Friend WithEvents lblDemand As Label
    Friend WithEvents LstProd As ListBox
End Class

Public Class frmNodes
    Private Sub NodesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.NodesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)

    End Sub

    Private Sub frmNodes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.NodesTableAdapter.Fill(Me.DatabaseDataSet.Nodes)

    End Sub

    Private Sub BindingNavigatorMoveNextItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveNextItem.Click

    End Sub
    ' Displays Demand as Absolute value for better readability
    Private Sub Prod1DemTextBox_TextChanged(sender As Object, e As EventArgs) Handles Prod1DemTextBox.TextChanged
        Dim GenDemand As Integer
        Try
            GenDemand = Math.Abs(Convert.ToInt32(Prod1DemTextBox.Text))
            Prod1DemTextBox.Text = GenDemand
        Catch ex As Exception
            MsgBox("Must enter integer for demand constraints")
            Prod1DemTextBox.Text = ""
        End Try
    End Sub
    ' Displays Demand as Absolute value for better readability
    Private Sub Prod2DemTextBox_TextChanged(sender As Object, e As EventArgs) Handles Prod2DemTextBox.TextChanged
        Dim GenDemand As Integer
        Try
            GenDemand = Math.Abs(Convert.ToInt32(Prod2DemTextBox.Text))
            Prod2DemTextBox.Text = GenDemand
        Catch ex As Exception
            MsgBox("Must enter integer for demand constraints")
            Prod2DemTextBox.Text = ""
        End Try
    End Sub
    ' Displays Demand as Absolute value for better readability
    Private Sub Prod3DemTextBox_TextChanged(sender As Object, e As EventArgs) Handles Prod3DemTextBox.TextChanged
        Dim GenDemand As Integer
        Try
            GenDemand = Math.Abs(Convert.ToInt32(Prod3DemTextBox.Text))
            Prod3DemTextBox.Text = GenDemand
        Catch ex As Exception
            MsgBox("Must enter integer for demand constraints")
            Prod3DemTextBox.Text = ""
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            Me.Validate()
            Me.NodesBindingSource.EndEdit()
            Me.NodesTableAdapter.UpdateQuery(-1 * Convert.ToDecimal(Prod1DemTextBox.Text), -1 * Convert.ToDecimal(Prod2DemTextBox.Text), -1 * Convert.ToDecimal(Prod3DemTextBox.Text), CodeTextBox.Text)
            MsgBox("Update successful")
        Catch ex As Exception
            MsgBox("Update Error")
        End Try
    End Sub
End Class
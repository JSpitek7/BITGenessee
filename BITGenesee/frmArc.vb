Public Class frmArc
    Private Sub ArcsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ArcsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ArcsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet1)

    End Sub

    Private Sub frmNodes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.Nodes' table. You can move, or remove it, as needed.
        Me.ArcsTableAdapter1.Fill(Me.DatabaseDataSet1.Arcs)
    End Sub
    Private Sub BindingNavigatorMoveNextItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveNextItem.Click

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            Me.Validate()
            Me.ArcsBindingSource.EndEdit()
            Me.ArcsTableAdapter1.UpdateQuery(CDec(CapacityTextBox.Text), TailTextBox.Text, HeadTextBox.Text)
            MsgBox("Update successful")
        Catch ex As Exception
            MsgBox("Update Error")
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FindArcToolStripButton_Click(sender As Object, e As EventArgs) Handles FindArcToolStripButton.Click
        Try
            If Me.ArcsTableAdapter1.FindArc(Me.DatabaseDataSet1.Arcs, HeadToolStripTextBox.Text, TailToolStripTextBox.Text) = Nothing Then
                Throw New Exception
            End If
        Catch ex As Exception
            MessageBox.Show("Could not Find Arc")
        End Try

    End Sub
End Class
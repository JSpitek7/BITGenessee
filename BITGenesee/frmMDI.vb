Public Class frmMDI

    Private Property FormSList As New SortedList(Of String, Form)

    Private Function GetForm(name As String) As Form
        Dim newForm As Form
        If FormSList.ContainsKey(name) Then
            Return FormSList(name)
        Else
            Select Case name
                Case "Visual"
                    newForm = New frmVisual
                    FormSList.Add("Visual", newForm)
                Case "Arc"
                    newForm = New frmArc
                    FormSList.Add("Arc", newForm)
                Case "Nodes"
                    newForm = New frmNodes
                    FormSList.Add("Nodes", newForm)
                Case "Products"
                    newForm = New frmProducts
                    FormSList.Add("Products", newForm)
                Case "Map"
                    newForm = New frmMap
                    FormSList.Add("Map", newForm)
                Case Else
                    newForm = New Form
            End Select
            newForm.MdiParent = Me
            newForm.WindowState = FormWindowState.Maximized
            Return newForm
        End If
    End Function

    Private Sub frmMDI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetForm("Visual").Show()
        GetForm("Arc").Show()
        GetForm("Nodes").Show()
        GetForm("Products").Show()

        Dim netForm As frmVisual = GetForm("Visual")
        netForm.BringToFront()
        netForm.FormSList = FormSList
        netForm.Show()

    End Sub

    Private Sub SolveWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SolveWindowToolStripMenuItem.Click
        GetForm("Visual").BringToFront()
    End Sub

    Private Sub SolveLPModelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SolveLPModelToolStripMenuItem.Click
        Dim netForm As frmVisual = GetForm("Visual")
        netForm.BringToFront()
        netForm.SolveLPModel()
    End Sub

    Private Sub NodesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NodesToolStripMenuItem.Click
        GetForm("Nodes").BringToFront()
    End Sub

    Private Sub ProductsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductsToolStripMenuItem.Click
        GetForm("Products").BringToFront()
    End Sub

    Private Sub ArcsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArcsToolStripMenuItem.Click
        GetForm("Arc").BringToFront()
    End Sub
End Class
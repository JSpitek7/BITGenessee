Imports System.Data.OleDb
Public Class frmModify
    Dim newdata As New Database
    Dim WithEvents net As New Network
    Dim nodesList As New SortedList(Of String, Node)
    Dim prodlist As New SortedList(Of String, Product)
    Private Sub frmModify_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        newdata = frmVisual.data
        'load the list box with nodes
        nodesList = newdata.GetNodes
        For Each n In nodesList.Keys
            lstNode.Items.Add(n)
        Next

        ' load the list box with products
        prodlist = newdata.GetProducts
        For Each n In prodlist.Keys
            LstProd.Items.Add(n)
        Next
        'LstProd.SelectedIndex = 0
        'lstNode.SelectedIndex = 0
        BuildNetwork()
    End Sub
    Public Sub BuildNetwork()
        net.AddNodes(newdata.GetNodes)
        net.AddArcs(newdata.GetArcs(net.NodeList))
        net.AddProducts(newdata.GetProducts)
    End Sub

    Private Sub lstNode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstNode.SelectedIndexChanged
        If LstProd.SelectedItem = "" Or lstNode.SelectedItem = "" Then
        Else
            txtDemand.Text = Math.Abs(newdata.GetDemand(net.NodeList(lstNode.SelectedItem), net.ProdList(LstProd.SelectedItem)))
        End If

    End Sub

    Private Sub LstProd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstProd.SelectedIndexChanged
        If LstProd.SelectedItem = "" Or lstNode.SelectedItem = "" Then
        Else
            txtDemand.Text = Math.Abs(newdata.GetDemand(net.NodeList(lstNode.SelectedItem), net.ProdList(LstProd.SelectedItem)))
        End If
    End Sub

    Private Sub btnChgDem_Click(sender As Object, e As EventArgs) Handles btnChgDem.Click
        UpdateDemand(lstNode.SelectedItem, LstProd.SelectedItem, txtDemand.Text)
    End Sub
    Public Sub UpdateDemand(node As String, prod As String, demand As Decimal)
        Dim row() As DataRow = newdata.getdataset().Tables("Nodes").Select("Code =" & node)
        Dim prodnum As String
        Dim adapter As New OleDbDataAdapter
        If prod = "Cream Ale" Then
            prodnum = "Prod1Dem"
        ElseIf prod = "Genesee" Then
            prodnum = "Prod2Dem"
        Else
            prodnum = "Prod3Dem"
        End If
        row(0)(prodnum) = demand
        frmVisual.data = newdata
    End Sub
End Class
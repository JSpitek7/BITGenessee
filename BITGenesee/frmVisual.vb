﻿Public Class frmVisual

    Public Property FormSList As SortedList(Of String, Form)

    Dim data As New Database
    Dim dbnew As New Database
    Dim WithEvents net As New Network
    Dim opt As Optimization
    Dim nodesList As New SortedList(Of String, Node)
    Dim arcsList As New SortedList(Of String, Arc)
    Dim prodsList As New SortedList(Of String, Product)
    Dim solved As Boolean
    Dim problemType As String

    'sub idea taken from homework 3
    'updates tree view object based on selected city
    Private Sub UpdateTreeView(city As String)
        'clears any city already populating trv object
        trvArcs.Nodes.Clear()
        'creates new tree node object
        Dim newTreeNode As New TreeNode(city)
        'adds tree node to trvArcs
        trvArcs.Nodes.Add(newTreeNode)
        'adds arcsIn and arcsOut nodes as children of parent tree node
        Dim arcsIn As New TreeNode("ArcsIn")
        Dim arcsOut As New TreeNode("ArcsOut")
        newTreeNode.Nodes.Add(arcsIn)
        newTreeNode.Nodes.Add(arcsOut)
        Dim node As Node = nodesList(city)
        'adds each ingoing node to tree
        For Each Arc In node.ArcsIn
            Dim arcIn As New TreeNode(Arc.Tail.ID)
            arcsIn.Nodes.Add(arcIn)
        Next
        'adds each outgoing node to tree
        For Each Arc In node.ArcsOut
            Dim arcOut As New TreeNode(Arc.Head.ID)
            arcsOut.Nodes.Add(arcOut)
        Next

    End Sub

    'handles selection of arc node in tree object
    Private Sub trvNetwork_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles trvArcs.AfterSelect
        'sets selected node as parent node
        Dim tn As TreeNode = trvArcs.SelectedNode
        Dim arcID As String
        Try
            'checks to make sure correct node is selected
            If tn.Text = trvArcs.Nodes(0).Text OrElse tn.Parent.Text = trvArcs.Nodes(0).Text Then
                Throw New Exception("Select a destination or origin node.")
            End If
            'determines if click is in arcsIn or arcsOut
            If tn.Parent.Text = "ArcsIn" Then
                arcID = tn.Text & "-TO-" & trvArcs.Nodes(0).Text
            Else
                arcID = trvArcs.Nodes(0).Text & "-TO-" & tn.Text
            End If
            If solved Then
                'sets text box to cost of arc
                txtCost.Text = net.ArcList(arcID).Cost
                'sets text box to remaining arc capacity
                txtCapacity.Text = net.ArcList(arcID).Capacity
                'sets text box to arc flow for selected product
                txtFlow.Text = net.ArcList(arcID).MultiFlow(lstProducts.SelectedItem)
            Else
                txtCost.Text = arcsList(arcID).Cost
                txtCapacity.Text = arcsList(arcID).Capacity
                txtFlow.Text = 0
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Selection Error")
        End Try
    End Sub

    'handles selection in nodes list box
    Private Sub lstNodes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstNodes.SelectedIndexChanged
        UpdateTreeView(lstNodes.SelectedItem)


        'sets product demand text box to node demand for selected product
        If Not lstProducts.SelectedItem = "" Then
            If solved Then
                txtDemand.Text = Math.Abs(data.GetDemand(net.NodeList(lstNodes.SelectedItem),
                                                net.ProdList(lstProducts.SelectedItem)))
                'sets satisfied demand text box to node satisfied demand for selected product
                txtSatisfiedDemand.Text = Math.Abs(opt.SatisfiedNodeDem(lstNodes.SelectedItem & lstProducts.SelectedItem))
            Else
                txtDemand.Text = Math.Abs(data.GetDemand(nodesList(lstNodes.SelectedItem),
                                                prodsList(lstProducts.SelectedItem)))
                txtSatisfiedDemand.Text = 0
            End If

        End If

    End Sub

    'handles selection in products list box
    Private Sub lstProducts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstProducts.SelectedIndexChanged
        'sets text box to node demand for selected product
        'first checks to see if model has been solved to get most accurate data
        If solved Then
            txtDemand.Text = Math.Abs(data.GetDemand(net.NodeList(lstNodes.SelectedItem),
                                        net.ProdList(lstProducts.SelectedItem)))
            'sets satisfied demand text box to node satisfied demand for selected product
            txtSatisfiedDemand.Text = Math.Abs(opt.SatisfiedNodeDem(lstNodes.SelectedItem & lstProducts.SelectedItem))
        Else
            txtDemand.Text = Math.Abs(data.GetDemand(nodesList(lstNodes.SelectedItem),
                                             prodsList(lstProducts.SelectedItem)))
            txtSatisfiedDemand.Text = 0
        End If


    End Sub

    'builds network for solver model
    Public Sub BuildNetwork()
        opt = New Optimization
        If dbnew Is Nothing Then
            net.AddNodes(data.GetNodes)
            net.AddArcs(data.GetArcs(net.NodeList))
            net.AddProducts(data.GetProducts)
        Else
            Updatedb()
            net.AddNodes(dbnew.GetNodes)
            net.AddArcs(dbnew.GetArcs(net.NodeList))
            net.AddProducts(dbnew.GetProducts)
        End If

    End Sub

    'solves LP model
    Private Sub btnSolve_Click(sender As Object, e As EventArgs) Handles btnSolve.Click
        SolveLPModel()
    End Sub

    Public Sub SolveLPModel()
        solved = False
        BuildNetwork()

        Dim totalCost As Decimal = 0
        If cbxSelected.Checked Then
            problemType = lstProducts.SelectedItem
            totalCost += opt.MinCostFlow(net, lstProducts.SelectedItem)
        Else
            problemType = "All"
            totalCost += opt.MinCostFlow2(net)
        End If
        If totalCost > 0 Then
            solved = True
            MessageBox.Show("Optimal solution found.")
        End If

        If Int(totalCost) = 0 Then
            txtTotalCost.Text = "Error. Check demand constraints"
        Else
            txtTotalCost.Text = Math.Round(totalCost, 2).ToString("$0,00.00")
        End If
        txtDemand.Text = Math.Abs(data.GetDemand(net.NodeList(lstNodes.SelectedItem), net.ProdList(lstProducts.SelectedItem)))
        txtSatisfiedDemand.Text = Math.Abs(opt.SatisfiedNodeDem(lstNodes.SelectedItem & lstProducts.SelectedItem))
    End Sub

    Private Sub frmVisual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        data = New Database()
        'sets solved property to false
        solved = False
        'gets problem data from database

        nodesList = data.GetNodes()
        arcsList = data.GetArcs(nodesList)
        prodsList = data.GetProducts()

        Dim nodesQuery = From node In data.GetNodes()
                         Select node
        Dim arcsQuery = From arc In data.GetArcs(data.GetNodes())
                        Select arc
        Dim prodsQuery = From prod In data.GetProducts()
                         Select prod

        'populates nodes listBox
        For Each node In nodesQuery
            lstNodes.Items.Add(node.Key)
        Next
        'populates products listbox
        For Each product In prodsQuery
            lstProducts.Items.Add(product.Key)
        Next
        'selects first city
        lstNodes.SelectedIndex = 0
        'selects first product
        lstProducts.SelectedIndex = 0

    End Sub

    'shows frmNodes when btnNodes is clicked
    Private Sub btnNodes_Click(sender As Object, e As EventArgs) Handles btnNodes.Click
        Dim nodesForm As New frmNodes
        nodesForm.Show()
    End Sub

    'shows frmProducts when btnProducts is clicked
    Private Sub btnProduct_Click(sender As Object, e As EventArgs) Handles btnProduct.Click
        Dim prodForm As New frmProducts
        prodForm.Show()
    End Sub

    Private Sub btnArc_Click(sender As Object, e As EventArgs) Handles btnArc.Click
        Dim ArcForm As New frmArc
        ArcForm.Show()
    End Sub

    Private Sub btnShowMap_Click(sender As Object, e As EventArgs) Handles btnShowMap.Click
        ShowMap()
    End Sub

    Public Sub ShowMap()
        Dim newMap As frmMap ' = FormSList("Map")
        Try
            If solved = False Then
                Throw New Exception("Solve LP Model first.")
            Else
                newMap = New frmMap
                newMap.Net = net
                newMap.Opt = opt
                newMap.problemType = problemType

            End If

            newMap.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Sub

    Private Sub Updatedb()
        'build new database to grab updated tables
        dbnew = New Database()

        'populate network with updated tables

        nodesList = dbnew.GetNodes()
        arcsList = dbnew.GetArcs(nodesList)
        prodsList = dbnew.GetProducts()
    End Sub
    ' Exports the data in an XML file when clicked
    Private Sub BtnExport_Click(sender As Object, e As EventArgs) Handles BtnExport.Click
        Dim folder As New FolderBrowserDialog
        Dim filepath As String
        If folder.ShowDialog = Windows.Forms.DialogResult.OK Then
            filepath = folder.SelectedPath & "\Database.xml"
        End If
        Try
            If filepath IsNot Nothing Then
                If dbnew Is Nothing Then
                    data.Export(filepath)
                Else
                    dbnew.Export(filepath)
                End If
            Else
                Throw New Exception("Select a folder.")
            End If
        Catch ex As Exception

        End Try

    End Sub
End Class

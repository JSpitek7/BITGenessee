Public Class frmlogin

    Public main As frmMDI
    Dim userdata As New Database(True)

    ' gets username and password from user, checks them against the users in the database
    Private Sub btnlogin_click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            If Not userdata.UserFound(txtUsername.Text, txtPassword.Text) Then
                Throw New Exception("Username/Password not found.")
            Else
                Me.Hide()
                main = New frmMDI
                main.ShowDialog()


                Dim result As Integer = MessageBox.Show("Are you sure you want to exit the application?", "Exit", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    Application.Exit()
                Else
                    txtPassword.Text = ""
                    Me.Show()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Login Error")
        End Try
    End Sub

    Private Sub btncancel_click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim result As Integer = MessageBox.Show("Are you sure you want to exit the application?", "Exit", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub frmlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
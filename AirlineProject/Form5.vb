Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtusername.Text = "emp123" And txtpassword.Text = "emp@123" Then
            MessageBox.Show("You Have Successfully Login")
            Form3.Show()
            Me.Hide()
            txtusername.Text = ""
            txtpassword.Text = ""
            txtusername.Focus()
        ElseIf txtusername.Text = "" And txtpassword.Text = "" Then
            MessageBox.Show("Please enter valid Username and Password")
            txtusername.Text = ""
            txtpassword.Text = ""
            txtusername.Focus()
        ElseIf txtusername.Text = "" Then
            MessageBox.Show("Please Enter Valid Username")
            txtusername.Text = ""
            txtpassword.Text = ""
            txtusername.Focus()
        ElseIf txtpassword.Text = "" Then
            MessageBox.Show("Please Enter Valid Password")
            txtusername.Text = ""
            txtpassword.Text = ""
            txtusername.Focus()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class

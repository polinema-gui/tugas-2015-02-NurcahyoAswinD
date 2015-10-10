Public Class Form1
    Dim shit As Integer
    Dim taste As Integer
    Dim lewd As Integer
    Dim sox As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If taste = 0 Then
            TextBoxNum.Text &= "1"
        Else
            TextBoxNum.Text = "1"
            taste = 0
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If taste = 0 Then
            TextBoxNum.Text &= "2"
        Else
            TextBoxNum.Text = "2"
            taste = 0
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If taste = 0 Then
            TextBoxNum.Text &= "3"
        Else
            TextBoxNum.Text = "3"
            taste = 0
        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If taste = 0 Then
            TextBoxNum.Text &= "4"
        Else
            TextBoxNum.Text = "4"
            taste = 0
        End If
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If taste = 0 Then
            TextBoxNum.Text &= "5"
        Else
            TextBoxNum.Text = "5"
            taste = 0
        End If
    End Sub
    Private Sub ButtonPlus_Click(sender As Object, e As EventArgs) Handles ButtonPlus.Click
        sox = "plus"

        If shit = 0 Then
            shit = Convert.ToInt32(TextBoxNum.Text)
        Else
            lewd = Convert.ToInt32(TextBoxNum.Text)
            TextBoxNum.Text = shit + lewd
            shit = Convert.ToInt32(TextBoxNum.Text)
        End If

        taste = 1
    End Sub
    
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        taste = 0
        lewd = 0
        shit = 0
        Button1.Text = "1"
        Button2.Text = "2"
        Button3.Text = "3"
        Button4.Text = "4"
        Button5.Text = "5"
        Button6.Text = "6"
        Button7.Text = "7"
        Button8.Text = "8"
        Button9.Text = "9"
        Button10.Text = "0"
        FormBorderStyle = Windows.Forms.FormBorderStyle.Fixed3D
        MaximizeBox = False
        TextBoxNum.ReadOnly = True
        RightToLeftLayout = True
        TextBoxNum.Text = 0
        TextBoxNum.TextAlign = HorizontalAlignment.Right
        taste = 1
    End Sub

    Private Sub ButtonMin_Click(sender As Object, e As EventArgs) Handles ButtonMin.Click
        sox = "minus"

        If shit = 0 Then
            shit = Convert.ToInt32(TextBoxNum.Text)
        Else
            lewd = Convert.ToInt32(TextBoxNum.Text)
            TextBoxNum.Text = shit - lewd
            shit = Convert.ToInt32(TextBoxNum.Text)
        End If

        taste = 1
    End Sub

    Private Sub ButtonEquals_Click(sender As Object, e As EventArgs) Handles ButtonEquals.Click
        lewd = Convert.ToInt32(TextBoxNum.Text)
        Select Case sox
            Case "plus"
                TextBoxNum.Text = shit + lewd
            Case "minus"
                TextBoxNum.Text = shit - lewd
        End Select
        shit = Convert.ToInt32(TextBoxNum.Text)
    End Sub

    Private Sub ButtonRst_Click(sender As Object, e As EventArgs) Handles ButtonRst.Click
        taste = 0
        lewd = 0
        shit = 0
        TextBoxNum.Text = 0
    End Sub
End Class

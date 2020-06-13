Imports System.IO

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text IsNot "" Then
            ListView1.Items.Add(TextBox1.Text).SubItems.Add(DateTimePicker1.Value)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ListView1.SelectedItems.Count <> 0 Then
            Dim index As Integer = ListView1.FocusedItem.Index
            Dim text As String = TextBox1.Text

            If text <> "" Then
                ListView1.Items(index).Text = text
                ListView1.Items(index).SubItems(1).Text = DateTimePicker1.Value.ToString()
            End If
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ListView1.SelectedItems.Count <> 0 Then
            Dim index As Integer = ListView1.FocusedItem.Index
            ListView1.Items(index).Remove()
        End If
    End Sub
End Class

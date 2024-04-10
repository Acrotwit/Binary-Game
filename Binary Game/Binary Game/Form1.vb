Public Class Form1

    Public Sub LoadEvents(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub Settings_Button_Click(sender As Object, e As EventArgs) Handles Settings_Button.Click
        Dim Form2Load As New Form2
        Form2Load.Show()
        Me.Hide()

    End Sub

    Private Sub Start_Button_Click(sender As Object, e As EventArgs) Handles Start_Button.Click
        Dim Form4Load As New Form4
        Form4Load.Show()
        Me.Hide()
    End Sub

End Class



Public Class Form2
    Dim Form1Load As New Form1

    Private Sub Full_Screen_Button_Click(sender As Object, e As EventArgs) Handles Full_Screen_Button.Click

        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        Windowed_Borderless_Button.Location = New Point((ClientSize.Width - Windowed_Borderless_Button.Width) \ 2, (ClientSize.Height - Windowed_Borderless_Button.Height) / 2)
        Screen_Colour_Button.Location = New Point((ClientSize.Width - Screen_Colour_Button.Width) \ 2, (ClientSize.Height - Screen_Colour_Button.Height) / 2 - 200)
        Save_Exit_Button.Location = New Point((ClientSize.Width - Save_Exit_Button.Width) \ 3, (ClientSize.Height - Save_Exit_Button.Height) / 2 + 100)
        Exit_Without_Save_Button.Location = New Point(((ClientSize.Width - Exit_Without_Save_Button.Width) \ 3) * 2, (ClientSize.Height - Exit_Without_Save_Button.Height) / 2 + 100)
        Full_Screen_Button.Location = New Point((ClientSize.Width - Full_Screen_Button.Width) \ 2, (ClientSize.Height - Full_Screen_Button.Height) / 2 - 400)
    End Sub

    Private Sub Windowed_Borderless_Button_Click(sender As Object, e As EventArgs) Handles Windowed_Borderless_Button.Click
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        Windowed_Borderless_Button.Location = New Point((ClientSize.Width - Windowed_Borderless_Button.Width) \ 2, (ClientSize.Height - Windowed_Borderless_Button.Height) / 2)
        Screen_Colour_Button.Location = New Point((ClientSize.Width - Screen_Colour_Button.Width) \ 2, (ClientSize.Height - Screen_Colour_Button.Height) / 2 - 200)
        Save_Exit_Button.Location = New Point((ClientSize.Width - Save_Exit_Button.Width) \ 3, (ClientSize.Height - Save_Exit_Button.Height) / 2 + 100)
        Exit_Without_Save_Button.Location = New Point(((ClientSize.Width - Exit_Without_Save_Button.Width) \ 3) * 2, (ClientSize.Height - Exit_Without_Save_Button.Height) / 2 + 100)
        Full_Screen_Button.Location = New Point((ClientSize.Width - Full_Screen_Button.Width) \ 2, (ClientSize.Height - Full_Screen_Button.Height) / 2 - 400)
    End Sub

    Private Sub Screen_Colour_Button_Click(sender As Object, e As EventArgs) Handles Screen_Colour_Button.Click
        Dim rnd As New Random

        Me.BackColor = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256))
    End Sub

    Private Sub Save_Exit_Button_Click(sender As Object, e As EventArgs) Handles Save_Exit_Button.Click
        Form1Load.Show()
        Me.Hide()
    End Sub

    Private Sub Exit_Without_Save_Button_Click(sender As Object, e As EventArgs) Handles Exit_Without_Save_Button.Click
        Form1Load.Show()
        Me.Hide()
    End Sub

End Class
Imports System.IO
Public Class Form4
    Private Sub Button_Difficulty_Slct_Easy_Click(sender As Object, e As EventArgs) Handles Button_Difficulty_Slct_Easy.Click
        Dim Form3Load As New Form3
        Form3Load.Show()
        Me.Hide()
    End Sub

    Private Sub Button_Difficulty_Slct_Medium_Click(sender As Object, e As EventArgs) Handles Button_Difficulty_Slct_Medium.Click
        Dim Form5Load As New Form5
        Form5Load.Show()
        Me.Hide()
    End Sub

    Private Sub Button_Difficulty_Slct_Hard_Click(sender As Object, e As EventArgs) Handles Button_Difficulty_Slct_Hard.Click
        Dim Form6Load As New Form6
        Form6Load.Show()
        Me.Hide()
    End Sub

    Private Sub Button_Difficulty_Slct_Back_Click(sender As Object, e As EventArgs) Handles Button_Difficulty_Slct_Back.Click
        Dim Form1Load As New Form1
        Form1Load.Show()
        Me.Hide()
    End Sub

    Private Sub Form4Show(sender As Object, e As EventArgs) Handles Me.Shown
        Using reader1 As StreamReader = New StreamReader("highscores_easy.txt")
            Dim line As String
            line = reader1.ReadLine()
            While (line <> Nothing)
                Dim Easy_highscore = line.Split(" ")(1)

                If Easy_highscore < 5 Then
                    Button_Difficulty_Slct_Medium.Enabled = False
                End If
                Exit While

            End While
        End Using

        Using reader As StreamReader = New StreamReader("highscores_medium.txt")
            Dim line As String
            line = reader.ReadLine()
            While (line <> Nothing)
                Dim Medium_highscore = line.Split(" ")(1)

                If Medium_highscore < 5 Then
                    Button_Difficulty_Slct_Hard.Enabled = False
                End If

                Exit While
            End While
        End Using

        Using reader2 As StreamReader = New StreamReader("highscores_hard.txt")
            Dim line As String
            line = reader2.ReadLine()
            While (line <> Nothing)
                Dim Hard_highscore = line.Split(" ")(1)

                If Hard_highscore < 5 Then
                    Button_Difficulty_Slct_Extreme.Enabled = False
                End If

                Exit While
            End While
        End Using



    End Sub

    Private Sub Button_Difficulty_Slct_Extreme_Click(sender As Object, e As EventArgs) Handles Button_Difficulty_Slct_Extreme.Click
        Dim Form7Load As New Form1
        Form7Load.Show()
        Me.Hide()
    End Sub
End Class
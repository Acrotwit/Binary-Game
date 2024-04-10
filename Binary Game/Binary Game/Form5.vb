﻿Imports System.IO
Public Class Form5
    Dim rnd As New Random

    Dim Number_1, Number_2 As Integer




    Private Sub Button_Submit_Medium_Click(sender As Object, e As EventArgs) Handles Button_Submit_Medium.Click
        Dim userInput As New Integer
        Dim answer As Integer



        userInput = Convert.ToInt32(User_Answer_Subtract.Text)

        If userInput = Number_1 - Number_2 Then
            Label_Current_Score_Medium.Text += 1
            Number_1 = rnd.Next(0, 100)
            Number_2 = rnd.Next(0, 100)
            Label_Current_Denary_Medium.Text = Str(Number_1) & " - " & Str(Number_2)

        End If
    End Sub

    Private Sub Form3Show(sender As Object, e As EventArgs) Handles Me.Shown
        Label_Timer_Medium.Text = 60



        Using reader As StreamReader = New StreamReader("highscores_medium.txt")
            Dim line As String
            line = reader.ReadLine()
            While (line <> Nothing)
                Label_Highscore_Medium.Text = line.Split(" ")(1)
                Label_Highscore_Initials_Medium.Text = line.Split(" ")(0).ToUpper().Remove(3, 1)


                Exit While
            End While
        End Using

        Medium_Timer.Start()

        Number_1 = rnd.Next(0, 100)
        Number_2 = rnd.Next(0, 100)

        Label_Current_Denary_Medium.Text = Str(Number_1) & " - " & Str(Number_2)
    End Sub

    Private Sub TimerTick(sender As Object, e As EventArgs) Handles Medium_Timer.Tick
        If Label_Timer_Medium.Text > 0 Then
            Label_Timer_Medium.Text -= 1
        Else
            Medium_Timer.Stop()
            Label_Timer_Medium.Text = 60
            MessageBox.Show("Times up")

            Dim newHighscore As Boolean
            Dim form1load As New Form1
            Using reader As StreamReader = New StreamReader("highscores_medium.txt")
                Dim line As String

                line = reader.ReadLine()
                While (line <> Nothing)
                    If (Label_Current_Score_Medium.Text > line.Split(" ")(1)) Then
                        newHighscore = True
                        Exit While
                    Else
                        newHighscore = False
                        Exit While
                    End If
                End While
            End Using

            Dim userInitials As String = Nothing
            If newHighscore = True Then

                userInitials = InputBox("enter your initials:")
                If userInitials.Length > 3 Or userInitials.Length = 0 Or userInitials = " " Then
                    MessageBox.Show("Please enter valid initials")
                    userInitials = InputBox("Please enter your initials(3 Characters):")

                End If

                Using writer As StreamWriter = New StreamWriter("highscores_medium.txt")
                    writer.WriteLine(userInitials + ": " + Label_Current_Score_Medium.Text)
                End Using

            End If
        End If

    End Sub

    Private Sub User_Answer_Subtract_TextChanged(sender As Object, e As EventArgs) Handles User_Answer_Subtract.TextChanged

    End Sub

    Private Sub Button_Home_Medium_Click(sender As Object, e As EventArgs) Handles Button_Home_Medium.Click
        Dim form1load As New Form1
        form1load.Show()
        Me.Hide()
    End Sub
End Class
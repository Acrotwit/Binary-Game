<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label_Highscore_Medium = New System.Windows.Forms.Label()
        Me.Label_Highscore_Initials_Medium = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label_Current_Denary_Display_Medium = New System.Windows.Forms.Label()
        Me.Label_Current_Denary_Medium = New System.Windows.Forms.Label()
        Me.Label_Timer_Medium = New System.Windows.Forms.Label()
        Me.label_score = New System.Windows.Forms.Label()
        Me.Label_Current_Score_Medium = New System.Windows.Forms.Label()
        Me.Label_Current_Binary1_Display_Easy = New System.Windows.Forms.Label()
        Me.Button_Home_Medium = New System.Windows.Forms.Button()
        Me.Button_Submit_Medium = New System.Windows.Forms.Button()
        Me.Medium_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.User_Answer_Subtract = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label_Highscore_Medium
        '
        Me.Label_Highscore_Medium.AutoSize = True
        Me.Label_Highscore_Medium.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label_Highscore_Medium.Location = New System.Drawing.Point(1886, 26)
        Me.Label_Highscore_Medium.Name = "Label_Highscore_Medium"
        Me.Label_Highscore_Medium.Size = New System.Drawing.Size(181, 48)
        Me.Label_Highscore_Medium.TabIndex = 8
        Me.Label_Highscore_Medium.Text = "Highscore"
        '
        'Label_Highscore_Initials_Medium
        '
        Me.Label_Highscore_Initials_Medium.AutoSize = True
        Me.Label_Highscore_Initials_Medium.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label_Highscore_Initials_Medium.Location = New System.Drawing.Point(1719, 26)
        Me.Label_Highscore_Initials_Medium.Name = "Label_Highscore_Initials_Medium"
        Me.Label_Highscore_Initials_Medium.Size = New System.Drawing.Size(122, 48)
        Me.Label_Highscore_Initials_Medium.TabIndex = 9
        Me.Label_Highscore_Initials_Medium.Text = "Initials"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(1509, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(189, 48)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Highscore:"
        '
        'Label_Current_Denary_Display_Medium
        '
        Me.Label_Current_Denary_Display_Medium.AutoSize = True
        Me.Label_Current_Denary_Display_Medium.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label_Current_Denary_Display_Medium.Location = New System.Drawing.Point(700, 301)
        Me.Label_Current_Denary_Display_Medium.Name = "Label_Current_Denary_Display_Medium"
        Me.Label_Current_Denary_Display_Medium.Size = New System.Drawing.Size(167, 48)
        Me.Label_Current_Denary_Display_Medium.TabIndex = 12
        Me.Label_Current_Denary_Display_Medium.Text = "Equation:"
        '
        'Label_Current_Denary_Medium
        '
        Me.Label_Current_Denary_Medium.AutoSize = True
        Me.Label_Current_Denary_Medium.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label_Current_Denary_Medium.Location = New System.Drawing.Point(1034, 301)
        Me.Label_Current_Denary_Medium.Name = "Label_Current_Denary_Medium"
        Me.Label_Current_Denary_Medium.Size = New System.Drawing.Size(273, 48)
        Me.Label_Current_Denary_Medium.TabIndex = 13
        Me.Label_Current_Denary_Medium.Text = "Denary Number"
        '
        'Label_Timer_Medium
        '
        Me.Label_Timer_Medium.AutoSize = True
        Me.Label_Timer_Medium.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label_Timer_Medium.Location = New System.Drawing.Point(951, 188)
        Me.Label_Timer_Medium.Name = "Label_Timer_Medium"
        Me.Label_Timer_Medium.Size = New System.Drawing.Size(111, 48)
        Me.Label_Timer_Medium.TabIndex = 14
        Me.Label_Timer_Medium.Text = "Timer"
        '
        'label_score
        '
        Me.label_score.AutoSize = True
        Me.label_score.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.label_score.Location = New System.Drawing.Point(-1, -1)
        Me.label_score.Name = "label_score"
        Me.label_score.Size = New System.Drawing.Size(117, 48)
        Me.label_score.TabIndex = 15
        Me.label_score.Text = "Score:"
        '
        'Label_Current_Score_Medium
        '
        Me.Label_Current_Score_Medium.AutoSize = True
        Me.Label_Current_Score_Medium.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label_Current_Score_Medium.Location = New System.Drawing.Point(122, -1)
        Me.Label_Current_Score_Medium.Name = "Label_Current_Score_Medium"
        Me.Label_Current_Score_Medium.Size = New System.Drawing.Size(39, 48)
        Me.Label_Current_Score_Medium.TabIndex = 16
        Me.Label_Current_Score_Medium.Text = "0"
        '
        'Label_Current_Binary1_Display_Easy
        '
        Me.Label_Current_Binary1_Display_Easy.AutoSize = True
        Me.Label_Current_Binary1_Display_Easy.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label_Current_Binary1_Display_Easy.Location = New System.Drawing.Point(1024, 481)
        Me.Label_Current_Binary1_Display_Easy.Name = "Label_Current_Binary1_Display_Easy"
        Me.Label_Current_Binary1_Display_Easy.Size = New System.Drawing.Size(0, 48)
        Me.Label_Current_Binary1_Display_Easy.TabIndex = 25
        '
        'Button_Home_Medium
        '
        Me.Button_Home_Medium.Location = New System.Drawing.Point(33, 904)
        Me.Button_Home_Medium.Name = "Button_Home_Medium"
        Me.Button_Home_Medium.Size = New System.Drawing.Size(258, 80)
        Me.Button_Home_Medium.TabIndex = 34
        Me.Button_Home_Medium.Text = "Home"
        Me.Button_Home_Medium.UseVisualStyleBackColor = True
        '
        'Button_Submit_Medium
        '
        Me.Button_Submit_Medium.Location = New System.Drawing.Point(911, 889)
        Me.Button_Submit_Medium.Name = "Button_Submit_Medium"
        Me.Button_Submit_Medium.Size = New System.Drawing.Size(191, 77)
        Me.Button_Submit_Medium.TabIndex = 35
        Me.Button_Submit_Medium.Text = "Submit"
        Me.Button_Submit_Medium.UseVisualStyleBackColor = True
        '
        'Medium_Timer
        '
        Me.Medium_Timer.Interval = 1000
        '
        'User_Answer_Subtract
        '
        Me.User_Answer_Subtract.Location = New System.Drawing.Point(625, 535)
        Me.User_Answer_Subtract.Name = "User_Answer_Subtract"
        Me.User_Answer_Subtract.Size = New System.Drawing.Size(831, 31)
        Me.User_Answer_Subtract.TabIndex = 36
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2087, 1011)
        Me.Controls.Add(Me.User_Answer_Subtract)
        Me.Controls.Add(Me.Button_Submit_Medium)
        Me.Controls.Add(Me.Button_Home_Medium)
        Me.Controls.Add(Me.Label_Current_Binary1_Display_Easy)
        Me.Controls.Add(Me.Label_Current_Score_Medium)
        Me.Controls.Add(Me.label_score)
        Me.Controls.Add(Me.Label_Timer_Medium)
        Me.Controls.Add(Me.Label_Current_Denary_Medium)
        Me.Controls.Add(Me.Label_Current_Denary_Display_Medium)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label_Highscore_Initials_Medium)
        Me.Controls.Add(Me.Label_Highscore_Medium)
        Me.Name = "Form5"
        Me.Text = "Form5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label_Highscore_Medium As Label
    Friend WithEvents Label_Highscore_Initials_Medium As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label_Current_Denary_Display_Medium As Label
    Friend WithEvents Label_Current_Denary_Medium As Label
    Friend WithEvents Label_Timer_Medium As Label
    Friend WithEvents label_score As Label
    Friend WithEvents Label_Current_Score_Medium As Label
    Friend WithEvents Label_Current_Binary1_Display_Easy As Label
    Friend WithEvents Button_Home_Medium As Button
    Friend WithEvents Button_Submit_Medium As Button
    Friend WithEvents Medium_Timer As Timer
    Friend WithEvents User_Answer_Subtract As TextBox
End Class

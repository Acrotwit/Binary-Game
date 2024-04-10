<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Me.Label_Current_Denary_Display_Extreme = New System.Windows.Forms.Label()
        Me.Label_Current_Denary_Extreme = New System.Windows.Forms.Label()
        Me.Label_Timer_Extreme = New System.Windows.Forms.Label()
        Me.label_score = New System.Windows.Forms.Label()
        Me.Label_Current_Score_Extreme = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label_Highscore_Initials_Extreme = New System.Windows.Forms.Label()
        Me.Label_Highscore_Extreme = New System.Windows.Forms.Label()
        Me.User_Answer_Dividing = New System.Windows.Forms.TextBox()
        Me.Button_Submit_Hard = New System.Windows.Forms.Button()
        Me.Button_Home_Hard = New System.Windows.Forms.Button()
        Me.Timer_Extreme = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label_Current_Denary_Display_Extreme
        '
        Me.Label_Current_Denary_Display_Extreme.AutoSize = True
        Me.Label_Current_Denary_Display_Extreme.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label_Current_Denary_Display_Extreme.Location = New System.Drawing.Point(415, 269)
        Me.Label_Current_Denary_Display_Extreme.Name = "Label_Current_Denary_Display_Extreme"
        Me.Label_Current_Denary_Display_Extreme.Size = New System.Drawing.Size(167, 48)
        Me.Label_Current_Denary_Display_Extreme.TabIndex = 42
        Me.Label_Current_Denary_Display_Extreme.Text = "Equation:"
        '
        'Label_Current_Denary_Extreme
        '
        Me.Label_Current_Denary_Extreme.AutoSize = True
        Me.Label_Current_Denary_Extreme.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label_Current_Denary_Extreme.Location = New System.Drawing.Point(866, 269)
        Me.Label_Current_Denary_Extreme.Name = "Label_Current_Denary_Extreme"
        Me.Label_Current_Denary_Extreme.Size = New System.Drawing.Size(273, 48)
        Me.Label_Current_Denary_Extreme.TabIndex = 42
        Me.Label_Current_Denary_Extreme.Text = "Denary Number"
        '
        'Label_Timer_Extreme
        '
        Me.Label_Timer_Extreme.AutoSize = True
        Me.Label_Timer_Extreme.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label_Timer_Extreme.Location = New System.Drawing.Point(667, 178)
        Me.Label_Timer_Extreme.Name = "Label_Timer_Extreme"
        Me.Label_Timer_Extreme.Size = New System.Drawing.Size(111, 48)
        Me.Label_Timer_Extreme.TabIndex = 42
        Me.Label_Timer_Extreme.Text = "Timer"
        '
        'label_score
        '
        Me.label_score.AutoSize = True
        Me.label_score.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.label_score.Location = New System.Drawing.Point(12, 9)
        Me.label_score.Name = "label_score"
        Me.label_score.Size = New System.Drawing.Size(117, 48)
        Me.label_score.TabIndex = 42
        Me.label_score.Text = "Score:"
        '
        'Label_Current_Score_Extreme
        '
        Me.Label_Current_Score_Extreme.AutoSize = True
        Me.Label_Current_Score_Extreme.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label_Current_Score_Extreme.Location = New System.Drawing.Point(149, 9)
        Me.Label_Current_Score_Extreme.Name = "Label_Current_Score_Extreme"
        Me.Label_Current_Score_Extreme.Size = New System.Drawing.Size(39, 48)
        Me.Label_Current_Score_Extreme.TabIndex = 42
        Me.Label_Current_Score_Extreme.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(998, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(189, 48)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Highscore:"
        '
        'Label_Highscore_Initials_Extreme
        '
        Me.Label_Highscore_Initials_Extreme.AutoSize = True
        Me.Label_Highscore_Initials_Extreme.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label_Highscore_Initials_Extreme.Location = New System.Drawing.Point(1193, 9)
        Me.Label_Highscore_Initials_Extreme.Name = "Label_Highscore_Initials_Extreme"
        Me.Label_Highscore_Initials_Extreme.Size = New System.Drawing.Size(122, 48)
        Me.Label_Highscore_Initials_Extreme.TabIndex = 42
        Me.Label_Highscore_Initials_Extreme.Text = "Initials"
        '
        'Label_Highscore_Extreme
        '
        Me.Label_Highscore_Extreme.AutoSize = True
        Me.Label_Highscore_Extreme.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label_Highscore_Extreme.Location = New System.Drawing.Point(1340, 9)
        Me.Label_Highscore_Extreme.Name = "Label_Highscore_Extreme"
        Me.Label_Highscore_Extreme.Size = New System.Drawing.Size(181, 48)
        Me.Label_Highscore_Extreme.TabIndex = 42
        Me.Label_Highscore_Extreme.Text = "Highscore"
        '
        'User_Answer_Dividing
        '
        Me.User_Answer_Dividing.Location = New System.Drawing.Point(383, 551)
        Me.User_Answer_Dividing.Name = "User_Answer_Dividing"
        Me.User_Answer_Dividing.Size = New System.Drawing.Size(727, 31)
        Me.User_Answer_Dividing.TabIndex = 42
        '
        'Button_Submit_Hard
        '
        Me.Button_Submit_Hard.Location = New System.Drawing.Point(616, 689)
        Me.Button_Submit_Hard.Name = "Button_Submit_Hard"
        Me.Button_Submit_Hard.Size = New System.Drawing.Size(191, 77)
        Me.Button_Submit_Hard.TabIndex = 42
        Me.Button_Submit_Hard.Text = "Submit"
        Me.Button_Submit_Hard.UseVisualStyleBackColor = True
        '
        'Button_Home_Hard
        '
        Me.Button_Home_Hard.Location = New System.Drawing.Point(12, 816)
        Me.Button_Home_Hard.Name = "Button_Home_Hard"
        Me.Button_Home_Hard.Size = New System.Drawing.Size(258, 80)
        Me.Button_Home_Hard.TabIndex = 42
        Me.Button_Home_Hard.Text = "Home"
        Me.Button_Home_Hard.UseVisualStyleBackColor = True
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1532, 908)
        Me.Controls.Add(Me.Button_Home_Hard)
        Me.Controls.Add(Me.Button_Submit_Hard)
        Me.Controls.Add(Me.User_Answer_Dividing)
        Me.Controls.Add(Me.Label_Highscore_Extreme)
        Me.Controls.Add(Me.Label_Highscore_Initials_Extreme)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label_Current_Score_Extreme)
        Me.Controls.Add(Me.label_score)
        Me.Controls.Add(Me.Label_Timer_Extreme)
        Me.Controls.Add(Me.Label_Current_Denary_Extreme)
        Me.Controls.Add(Me.Label_Current_Denary_Display_Extreme)
        Me.Name = "Form7"
        Me.Text = "Form7"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label_Current_Denary_Display_Extreme As Label
    Friend WithEvents Label_Current_Denary_Extreme As Label
    Friend WithEvents Label_Timer_Extreme As Label
    Friend WithEvents label_score As Label
    Friend WithEvents Label_Current_Score_Extreme As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label_Highscore_Initials_Extreme As Label
    Friend WithEvents Label_Highscore_Extreme As Label
    Friend WithEvents User_Answer_Dividing As TextBox
    Friend WithEvents Button_Submit_Hard As Button
    Friend WithEvents Button_Home_Hard As Button
    Friend WithEvents Timer_Extreme As Timer
    Friend WithEvents Timer1 As Timer
End Class

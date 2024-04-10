<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Me.Label_Highscore_Hard = New System.Windows.Forms.Label()
        Me.Label_Highscore_Initials_Hard = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label_Current_Score_Hard = New System.Windows.Forms.Label()
        Me.label_score = New System.Windows.Forms.Label()
        Me.Label_Current_Denary_Hard = New System.Windows.Forms.Label()
        Me.Label_Current_Denary_Display_Medium = New System.Windows.Forms.Label()
        Me.Label_Timer_Hard = New System.Windows.Forms.Label()
        Me.Timer_Hard = New System.Windows.Forms.Timer(Me.components)
        Me.Button_Submit_Hard = New System.Windows.Forms.Button()
        Me.Button_Home_Hard = New System.Windows.Forms.Button()
        Me.User_Answer_Multiply = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label_Highscore_Hard
        '
        Me.Label_Highscore_Hard.AutoSize = True
        Me.Label_Highscore_Hard.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label_Highscore_Hard.Location = New System.Drawing.Point(1641, 29)
        Me.Label_Highscore_Hard.Name = "Label_Highscore_Hard"
        Me.Label_Highscore_Hard.Size = New System.Drawing.Size(181, 48)
        Me.Label_Highscore_Hard.TabIndex = 30
        Me.Label_Highscore_Hard.Text = "Highscore"
        '
        'Label_Highscore_Initials_Hard
        '
        Me.Label_Highscore_Initials_Hard.AutoSize = True
        Me.Label_Highscore_Initials_Hard.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label_Highscore_Initials_Hard.Location = New System.Drawing.Point(1479, 29)
        Me.Label_Highscore_Initials_Hard.Name = "Label_Highscore_Initials_Hard"
        Me.Label_Highscore_Initials_Hard.Size = New System.Drawing.Size(122, 48)
        Me.Label_Highscore_Initials_Hard.TabIndex = 31
        Me.Label_Highscore_Initials_Hard.Text = "Initials"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(1253, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(189, 48)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Highscore:"
        '
        'Label_Current_Score_Hard
        '
        Me.Label_Current_Score_Hard.AutoSize = True
        Me.Label_Current_Score_Hard.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label_Current_Score_Hard.Location = New System.Drawing.Point(137, 9)
        Me.Label_Current_Score_Hard.Name = "Label_Current_Score_Hard"
        Me.Label_Current_Score_Hard.Size = New System.Drawing.Size(39, 48)
        Me.Label_Current_Score_Hard.TabIndex = 33
        Me.Label_Current_Score_Hard.Text = "0"
        '
        'label_score
        '
        Me.label_score.AutoSize = True
        Me.label_score.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.label_score.Location = New System.Drawing.Point(12, 9)
        Me.label_score.Name = "label_score"
        Me.label_score.Size = New System.Drawing.Size(117, 48)
        Me.label_score.TabIndex = 34
        Me.label_score.Text = "Score:"
        '
        'Label_Current_Denary_Hard
        '
        Me.Label_Current_Denary_Hard.AutoSize = True
        Me.Label_Current_Denary_Hard.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label_Current_Denary_Hard.Location = New System.Drawing.Point(927, 381)
        Me.Label_Current_Denary_Hard.Name = "Label_Current_Denary_Hard"
        Me.Label_Current_Denary_Hard.Size = New System.Drawing.Size(273, 48)
        Me.Label_Current_Denary_Hard.TabIndex = 35
        Me.Label_Current_Denary_Hard.Text = "Denary Number"
        '
        'Label_Current_Denary_Display_Medium
        '
        Me.Label_Current_Denary_Display_Medium.AutoSize = True
        Me.Label_Current_Denary_Display_Medium.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label_Current_Denary_Display_Medium.Location = New System.Drawing.Point(512, 381)
        Me.Label_Current_Denary_Display_Medium.Name = "Label_Current_Denary_Display_Medium"
        Me.Label_Current_Denary_Display_Medium.Size = New System.Drawing.Size(167, 48)
        Me.Label_Current_Denary_Display_Medium.TabIndex = 36
        Me.Label_Current_Denary_Display_Medium.Text = "Equation:"
        '
        'Label_Timer_Hard
        '
        Me.Label_Timer_Hard.AutoSize = True
        Me.Label_Timer_Hard.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label_Timer_Hard.Location = New System.Drawing.Point(802, 276)
        Me.Label_Timer_Hard.Name = "Label_Timer_Hard"
        Me.Label_Timer_Hard.Size = New System.Drawing.Size(111, 48)
        Me.Label_Timer_Hard.TabIndex = 37
        Me.Label_Timer_Hard.Text = "Timer"
        '
        'Timer_Hard
        '
        Me.Timer_Hard.Interval = 1000
        '
        'Button_Submit_Hard
        '
        Me.Button_Submit_Hard.Location = New System.Drawing.Point(767, 934)
        Me.Button_Submit_Hard.Name = "Button_Submit_Hard"
        Me.Button_Submit_Hard.Size = New System.Drawing.Size(191, 77)
        Me.Button_Submit_Hard.TabIndex = 39
        Me.Button_Submit_Hard.Text = "Submit"
        Me.Button_Submit_Hard.UseVisualStyleBackColor = True
        '
        'Button_Home_Hard
        '
        Me.Button_Home_Hard.Location = New System.Drawing.Point(-3, 934)
        Me.Button_Home_Hard.Name = "Button_Home_Hard"
        Me.Button_Home_Hard.Size = New System.Drawing.Size(258, 80)
        Me.Button_Home_Hard.TabIndex = 40
        Me.Button_Home_Hard.Text = "Home"
        Me.Button_Home_Hard.UseVisualStyleBackColor = True
        '
        'User_Answer_Multiply
        '
        Me.User_Answer_Multiply.Location = New System.Drawing.Point(477, 635)
        Me.User_Answer_Multiply.Name = "User_Answer_Multiply"
        Me.User_Answer_Multiply.Size = New System.Drawing.Size(727, 31)
        Me.User_Answer_Multiply.TabIndex = 41
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1845, 1062)
        Me.Controls.Add(Me.User_Answer_Multiply)
        Me.Controls.Add(Me.Button_Home_Hard)
        Me.Controls.Add(Me.Button_Submit_Hard)
        Me.Controls.Add(Me.Label_Timer_Hard)
        Me.Controls.Add(Me.Label_Current_Denary_Display_Medium)
        Me.Controls.Add(Me.Label_Current_Denary_Hard)
        Me.Controls.Add(Me.label_score)
        Me.Controls.Add(Me.Label_Current_Score_Hard)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label_Highscore_Initials_Hard)
        Me.Controls.Add(Me.Label_Highscore_Hard)
        Me.Name = "Form6"
        Me.Text = "Form6"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label_Highscore_Hard As Label
    Friend WithEvents Label_Highscore_Initials_Hard As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label_Current_Score_Hard As Label
    Friend WithEvents label_score As Label
    Friend WithEvents Label_Current_Denary_Hard As Label
    Friend WithEvents Label_Current_Denary_Display_Medium As Label
    Friend WithEvents Label_Timer_Hard As Label
    Friend WithEvents Timer_Hard As Timer
    Friend WithEvents Button_Submit_Hard As Button
    Friend WithEvents Button_Home_Hard As Button
    Friend WithEvents User_Answer_Multiply As TextBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.Label_Current_Denary_Easy = New System.Windows.Forms.Label()
        Me.Label_Timer_Easy = New System.Windows.Forms.Label()
        Me.Button_Submit_Easy = New System.Windows.Forms.Button()
        Me.Label_Highscore_Easy = New System.Windows.Forms.Label()
        Me.Label_Current_Score_Easy = New System.Windows.Forms.Label()
        Me.Easy_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.label_score = New System.Windows.Forms.Label()
        Me.Label_Current_Denary_Display_Easy = New System.Windows.Forms.Label()
        Me.Label_Highscore_Initials_Easy = New System.Windows.Forms.Label()
        Me.Label_Highscore_Lbl = New System.Windows.Forms.Label()
        Me.Button_Home_Easy = New System.Windows.Forms.Button()
        Me.User_Answer_Additon = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label_Current_Denary_Easy
        '
        Me.Label_Current_Denary_Easy.AutoSize = True
        Me.Label_Current_Denary_Easy.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label_Current_Denary_Easy.Location = New System.Drawing.Point(1179, 251)
        Me.Label_Current_Denary_Easy.Name = "Label_Current_Denary_Easy"
        Me.Label_Current_Denary_Easy.Size = New System.Drawing.Size(273, 48)
        Me.Label_Current_Denary_Easy.TabIndex = 0
        Me.Label_Current_Denary_Easy.Text = "Denary Number"
        '
        'Label_Timer_Easy
        '
        Me.Label_Timer_Easy.AutoSize = True
        Me.Label_Timer_Easy.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label_Timer_Easy.Location = New System.Drawing.Point(1106, 102)
        Me.Label_Timer_Easy.Name = "Label_Timer_Easy"
        Me.Label_Timer_Easy.Size = New System.Drawing.Size(111, 48)
        Me.Label_Timer_Easy.TabIndex = 5
        Me.Label_Timer_Easy.Text = "Timer"
        '
        'Button_Submit_Easy
        '
        Me.Button_Submit_Easy.Location = New System.Drawing.Point(1026, 891)
        Me.Button_Submit_Easy.Name = "Button_Submit_Easy"
        Me.Button_Submit_Easy.Size = New System.Drawing.Size(191, 77)
        Me.Button_Submit_Easy.TabIndex = 6
        Me.Button_Submit_Easy.Text = "Submit"
        Me.Button_Submit_Easy.UseVisualStyleBackColor = True
        '
        'Label_Highscore_Easy
        '
        Me.Label_Highscore_Easy.AutoSize = True
        Me.Label_Highscore_Easy.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label_Highscore_Easy.Location = New System.Drawing.Point(2181, 9)
        Me.Label_Highscore_Easy.Name = "Label_Highscore_Easy"
        Me.Label_Highscore_Easy.Size = New System.Drawing.Size(181, 48)
        Me.Label_Highscore_Easy.TabIndex = 7
        Me.Label_Highscore_Easy.Text = "Highscore"
        '
        'Label_Current_Score_Easy
        '
        Me.Label_Current_Score_Easy.AutoSize = True
        Me.Label_Current_Score_Easy.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label_Current_Score_Easy.Location = New System.Drawing.Point(110, 9)
        Me.Label_Current_Score_Easy.Name = "Label_Current_Score_Easy"
        Me.Label_Current_Score_Easy.Size = New System.Drawing.Size(39, 48)
        Me.Label_Current_Score_Easy.TabIndex = 8
        Me.Label_Current_Score_Easy.Text = "0"
        '
        'Easy_Timer
        '
        Me.Easy_Timer.Interval = 1000
        '
        'label_score
        '
        Me.label_score.AutoSize = True
        Me.label_score.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.label_score.Location = New System.Drawing.Point(-4, 9)
        Me.label_score.Name = "label_score"
        Me.label_score.Size = New System.Drawing.Size(117, 48)
        Me.label_score.TabIndex = 9
        Me.label_score.Text = "Score:"
        '
        'Label_Current_Denary_Display_Easy
        '
        Me.Label_Current_Denary_Display_Easy.AutoSize = True
        Me.Label_Current_Denary_Display_Easy.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label_Current_Denary_Display_Easy.Location = New System.Drawing.Point(857, 251)
        Me.Label_Current_Denary_Display_Easy.Name = "Label_Current_Denary_Display_Easy"
        Me.Label_Current_Denary_Display_Easy.Size = New System.Drawing.Size(167, 48)
        Me.Label_Current_Denary_Display_Easy.TabIndex = 11
        Me.Label_Current_Denary_Display_Easy.Text = "Equation:"
        '
        'Label_Highscore_Initials_Easy
        '
        Me.Label_Highscore_Initials_Easy.AutoSize = True
        Me.Label_Highscore_Initials_Easy.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label_Highscore_Initials_Easy.Location = New System.Drawing.Point(2061, 9)
        Me.Label_Highscore_Initials_Easy.Name = "Label_Highscore_Initials_Easy"
        Me.Label_Highscore_Initials_Easy.Size = New System.Drawing.Size(122, 48)
        Me.Label_Highscore_Initials_Easy.TabIndex = 16
        Me.Label_Highscore_Initials_Easy.Text = "Initials"
        '
        'Label_Highscore_Lbl
        '
        Me.Label_Highscore_Lbl.AutoSize = True
        Me.Label_Highscore_Lbl.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label_Highscore_Lbl.Location = New System.Drawing.Point(1866, 9)
        Me.Label_Highscore_Lbl.Name = "Label_Highscore_Lbl"
        Me.Label_Highscore_Lbl.Size = New System.Drawing.Size(189, 48)
        Me.Label_Highscore_Lbl.TabIndex = 17
        Me.Label_Highscore_Lbl.Text = "Highscore:"
        '
        'Button_Home_Easy
        '
        Me.Button_Home_Easy.Location = New System.Drawing.Point(12, 1147)
        Me.Button_Home_Easy.Name = "Button_Home_Easy"
        Me.Button_Home_Easy.Size = New System.Drawing.Size(252, 69)
        Me.Button_Home_Easy.TabIndex = 18
        Me.Button_Home_Easy.Text = "Home"
        Me.Button_Home_Easy.UseVisualStyleBackColor = True
        '
        'User_Answer_Additon
        '
        Me.User_Answer_Additon.Location = New System.Drawing.Point(890, 802)
        Me.User_Answer_Additon.Name = "User_Answer_Additon"
        Me.User_Answer_Additon.Size = New System.Drawing.Size(489, 31)
        Me.User_Answer_Additon.TabIndex = 19
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2374, 1222)
        Me.Controls.Add(Me.User_Answer_Additon)
        Me.Controls.Add(Me.Button_Home_Easy)
        Me.Controls.Add(Me.Label_Highscore_Lbl)
        Me.Controls.Add(Me.Label_Highscore_Initials_Easy)
        Me.Controls.Add(Me.Label_Current_Denary_Display_Easy)
        Me.Controls.Add(Me.label_score)
        Me.Controls.Add(Me.Label_Current_Score_Easy)
        Me.Controls.Add(Me.Label_Highscore_Easy)
        Me.Controls.Add(Me.Button_Submit_Easy)
        Me.Controls.Add(Me.Label_Timer_Easy)
        Me.Controls.Add(Me.Label_Current_Denary_Easy)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label_Current_Denary_Easy As Label
    Friend WithEvents Label_Timer_Easy As Label
    Friend WithEvents Button_Submit_Easy As Button
    Friend WithEvents Label_Highscore_Easy As Label
    Friend WithEvents Label_Current_Score_Easy As Label
    Friend WithEvents Easy_Timer As Timer
    Friend WithEvents label_score As Label
    Friend WithEvents Label_Current_Denary_Display_Easy As Label
    Friend WithEvents Label_Highscore_Initials_Easy As Label
    Friend WithEvents Label_Highscore_Lbl As Label
    Friend WithEvents Button_Home_Easy As Button
    Friend WithEvents User_Answer_Additon As TextBox


End Class

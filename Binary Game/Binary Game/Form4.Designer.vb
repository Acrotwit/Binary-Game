<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.Button_Difficulty_Slct_Easy = New System.Windows.Forms.Button()
        Me.Button_Difficulty_Slct_Medium = New System.Windows.Forms.Button()
        Me.Button_Difficulty_Slct_Hard = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button_Difficulty_Slct_Back = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button_Difficulty_Slct_Extreme = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button_Difficulty_Slct_Easy
        '
        Me.Button_Difficulty_Slct_Easy.Location = New System.Drawing.Point(183, 290)
        Me.Button_Difficulty_Slct_Easy.Name = "Button_Difficulty_Slct_Easy"
        Me.Button_Difficulty_Slct_Easy.Size = New System.Drawing.Size(350, 80)
        Me.Button_Difficulty_Slct_Easy.TabIndex = 0
        Me.Button_Difficulty_Slct_Easy.Text = "Additon"
        Me.Button_Difficulty_Slct_Easy.UseVisualStyleBackColor = True
        '
        'Button_Difficulty_Slct_Medium
        '
        Me.Button_Difficulty_Slct_Medium.Location = New System.Drawing.Point(659, 290)
        Me.Button_Difficulty_Slct_Medium.Name = "Button_Difficulty_Slct_Medium"
        Me.Button_Difficulty_Slct_Medium.Size = New System.Drawing.Size(350, 80)
        Me.Button_Difficulty_Slct_Medium.TabIndex = 1
        Me.Button_Difficulty_Slct_Medium.Text = "Subtraction"
        Me.Button_Difficulty_Slct_Medium.UseVisualStyleBackColor = True
        '
        'Button_Difficulty_Slct_Hard
        '
        Me.Button_Difficulty_Slct_Hard.Location = New System.Drawing.Point(1113, 290)
        Me.Button_Difficulty_Slct_Hard.Name = "Button_Difficulty_Slct_Hard"
        Me.Button_Difficulty_Slct_Hard.Size = New System.Drawing.Size(350, 80)
        Me.Button_Difficulty_Slct_Hard.TabIndex = 2
        Me.Button_Difficulty_Slct_Hard.Text = "Multiplication"
        Me.Button_Difficulty_Slct_Hard.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(845, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(346, 48)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Select Your Difficulty"
        '
        'Button_Difficulty_Slct_Back
        '
        Me.Button_Difficulty_Slct_Back.Location = New System.Drawing.Point(845, 443)
        Me.Button_Difficulty_Slct_Back.Name = "Button_Difficulty_Slct_Back"
        Me.Button_Difficulty_Slct_Back.Size = New System.Drawing.Size(346, 81)
        Me.Button_Difficulty_Slct_Back.TabIndex = 4
        Me.Button_Difficulty_Slct_Back.Text = "Back"
        Me.Button_Difficulty_Slct_Back.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Button_Difficulty_Slct_Extreme
        '
        Me.Button_Difficulty_Slct_Extreme.Location = New System.Drawing.Point(1533, 290)
        Me.Button_Difficulty_Slct_Extreme.Name = "Button_Difficulty_Slct_Extreme"
        Me.Button_Difficulty_Slct_Extreme.Size = New System.Drawing.Size(350, 80)
        Me.Button_Difficulty_Slct_Extreme.TabIndex = 5
        Me.Button_Difficulty_Slct_Extreme.Text = "Division"
        Me.Button_Difficulty_Slct_Extreme.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2032, 704)
        Me.Controls.Add(Me.Button_Difficulty_Slct_Extreme)
        Me.Controls.Add(Me.Button_Difficulty_Slct_Back)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button_Difficulty_Slct_Hard)
        Me.Controls.Add(Me.Button_Difficulty_Slct_Medium)
        Me.Controls.Add(Me.Button_Difficulty_Slct_Easy)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_Difficulty_Slct_Easy As Button
    Friend WithEvents Button_Difficulty_Slct_Medium As Button
    Friend WithEvents Button_Difficulty_Slct_Hard As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button_Difficulty_Slct_Back As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button_Difficulty_Slct_Extreme As Button
End Class

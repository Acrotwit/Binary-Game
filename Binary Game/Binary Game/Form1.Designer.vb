<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Start_Button = New System.Windows.Forms.Button()
        Me.Settings_Button = New System.Windows.Forms.Button()
        Me.testLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Start_Button
        '
        Me.Start_Button.Location = New System.Drawing.Point(598, 203)
        Me.Start_Button.Name = "Start_Button"
        Me.Start_Button.Size = New System.Drawing.Size(446, 98)
        Me.Start_Button.TabIndex = 0
        Me.Start_Button.Text = "Start"
        Me.Start_Button.UseVisualStyleBackColor = True
        '
        'Settings_Button
        '
        Me.Settings_Button.Location = New System.Drawing.Point(598, 375)
        Me.Settings_Button.Name = "Settings_Button"
        Me.Settings_Button.Size = New System.Drawing.Size(446, 98)
        Me.Settings_Button.TabIndex = 2
        Me.Settings_Button.Text = "Settings"
        Me.Settings_Button.UseVisualStyleBackColor = True
        '
        'testLabel
        '
        Me.testLabel.AutoSize = True
        Me.testLabel.Location = New System.Drawing.Point(124, 472)
        Me.testLabel.Name = "testLabel"
        Me.testLabel.Size = New System.Drawing.Size(0, 25)
        Me.testLabel.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1738, 1003)
        Me.Controls.Add(Me.testLabel)
        Me.Controls.Add(Me.Settings_Button)
        Me.Controls.Add(Me.Start_Button)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Start_Button As Button
    Friend WithEvents Difficulty_Select_Button As Button
    Friend WithEvents Settings_Button As Button
    Friend WithEvents HighScore_TxtBox As TextBox
    Friend WithEvents testLabel As Label
End Class

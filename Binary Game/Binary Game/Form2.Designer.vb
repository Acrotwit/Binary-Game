<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Full_Screen_Button = New System.Windows.Forms.Button()
        Me.Windowed_Borderless_Button = New System.Windows.Forms.Button()
        Me.Screen_Colour_Button = New System.Windows.Forms.Button()
        Me.Save_Exit_Button = New System.Windows.Forms.Button()
        Me.Exit_Without_Save_Button = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Full_Screen_Button
        '
        Me.Full_Screen_Button.Location = New System.Drawing.Point(360, 164)
        Me.Full_Screen_Button.Name = "Full_Screen_Button"
        Me.Full_Screen_Button.Size = New System.Drawing.Size(446, 98)
        Me.Full_Screen_Button.TabIndex = 1
        Me.Full_Screen_Button.Text = "FullScreen"
        Me.Full_Screen_Button.UseVisualStyleBackColor = True
        '
        'Windowed_Borderless_Button
        '
        Me.Windowed_Borderless_Button.Location = New System.Drawing.Point(360, 343)
        Me.Windowed_Borderless_Button.Name = "Windowed_Borderless_Button"
        Me.Windowed_Borderless_Button.Size = New System.Drawing.Size(446, 98)
        Me.Windowed_Borderless_Button.TabIndex = 2
        Me.Windowed_Borderless_Button.Text = "Windowed Borderless"
        Me.Windowed_Borderless_Button.UseVisualStyleBackColor = True
        '
        'Screen_Colour_Button
        '
        Me.Screen_Colour_Button.Location = New System.Drawing.Point(360, 518)
        Me.Screen_Colour_Button.Name = "Screen_Colour_Button"
        Me.Screen_Colour_Button.Size = New System.Drawing.Size(446, 98)
        Me.Screen_Colour_Button.TabIndex = 3
        Me.Screen_Colour_Button.Text = "Screen Button"
        Me.Screen_Colour_Button.UseVisualStyleBackColor = True
        '
        'Save_Exit_Button
        '
        Me.Save_Exit_Button.Location = New System.Drawing.Point(287, 718)
        Me.Save_Exit_Button.Name = "Save_Exit_Button"
        Me.Save_Exit_Button.Size = New System.Drawing.Size(128, 71)
        Me.Save_Exit_Button.TabIndex = 4
        Me.Save_Exit_Button.Text = "Save and exit"
        Me.Save_Exit_Button.UseVisualStyleBackColor = True
        '
        'Exit_Without_Save_Button
        '
        Me.Exit_Without_Save_Button.Location = New System.Drawing.Point(744, 718)
        Me.Exit_Without_Save_Button.Name = "Exit_Without_Save_Button"
        Me.Exit_Without_Save_Button.Size = New System.Drawing.Size(118, 71)
        Me.Exit_Without_Save_Button.TabIndex = 5
        Me.Exit_Without_Save_Button.Text = "Exit without saving"
        Me.Exit_Without_Save_Button.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(614, 267)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 34)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1279, 998)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Exit_Without_Save_Button)
        Me.Controls.Add(Me.Save_Exit_Button)
        Me.Controls.Add(Me.Screen_Colour_Button)
        Me.Controls.Add(Me.Windowed_Borderless_Button)
        Me.Controls.Add(Me.Full_Screen_Button)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Full_Screen_Button As Button
    Friend WithEvents Windowed_Borderless_Button As Button
    Friend WithEvents Screen_Colour_Button As Button
    Friend WithEvents Save_Exit_Button As Button
    Friend WithEvents Exit_Without_Save_Button As Button
    Friend WithEvents Button1 As Button
End Class

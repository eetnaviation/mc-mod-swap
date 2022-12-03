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
        Me.swapButton = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.addonBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'swapButton
        '
        Me.swapButton.Location = New System.Drawing.Point(282, 12)
        Me.swapButton.Name = "swapButton"
        Me.swapButton.Size = New System.Drawing.Size(113, 23)
        Me.swapButton.TabIndex = 0
        Me.swapButton.Text = "Swap client"
        Me.swapButton.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"1.19.2 Meteor (DEVELOPMENT RELEASE)", "1.19 Meteor", "1.18.1 Ares", "1.17.1 Ares", "1.16.5 Ares", "1.16.5 Impact", "1.15.2 Impact", "1.12.2 Impact", "1.16.5 Inertia", "1.15.2 Inertia", "1.14.4 Inertia", "1.12.2 Wolfram", "1.11 Wolfram", "1.10 Wolfram", "1.9.4 Wolfram", "1.8 Wolfram"})
        Me.ComboBox1.Location = New System.Drawing.Point(12, 12)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(264, 23)
        Me.ComboBox1.TabIndex = 1
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"1.19 SeedCrackerX", "1.18.2 SeedCrackerX", "1.17 SeedCrackerX", "None"})
        Me.ComboBox2.Location = New System.Drawing.Point(12, 41)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(264, 23)
        Me.ComboBox2.TabIndex = 2
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 70)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(378, 23)
        Me.TextBox1.TabIndex = 4
        '
        'addonBtn
        '
        Me.addonBtn.Location = New System.Drawing.Point(282, 40)
        Me.addonBtn.Name = "addonBtn"
        Me.addonBtn.Size = New System.Drawing.Size(113, 24)
        Me.addonBtn.TabIndex = 5
        Me.addonBtn.Text = "Load addon"
        Me.addonBtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 103)
        Me.Controls.Add(Me.addonBtn)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.swapButton)
        Me.Name = "Form1"
        Me.Text = "MC Mod Swapper 1.0"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents swapButton As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents addonBtn As Button
End Class

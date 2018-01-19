<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class prmGUI
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
        Me.TrackBar1 = New System.Windows.Forms.TrackBar
        Me.Button1 = New System.Windows.Forms.Button
        Me.TrackBar2 = New System.Windows.Forms.TrackBar
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TrackBar3 = New System.Windows.Forms.TrackBar
        Me.Label3 = New System.Windows.Forms.Label
        Me.TrackBar4 = New System.Windows.Forms.TrackBar
        Me.Button2 = New System.Windows.Forms.Button
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(1, 2)
        Me.TrackBar1.Maximum = 8000
        Me.TrackBar1.Minimum = -8000
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(317, 45)
        Me.TrackBar1.TabIndex = 0
        Me.TrackBar1.Value = 1000
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.SkyBlue
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(99, 223)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(126, 25)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "&Done"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TrackBar2
        '
        Me.TrackBar2.Location = New System.Drawing.Point(29, 38)
        Me.TrackBar2.Maximum = 8000
        Me.TrackBar2.Minimum = -8000
        Me.TrackBar2.Name = "TrackBar2"
        Me.TrackBar2.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TrackBar2.Size = New System.Drawing.Size(45, 185)
        Me.TrackBar2.TabIndex = 3
        Me.TrackBar2.Value = 1000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "X:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(153, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Y:"
        '
        'TrackBar3
        '
        Me.TrackBar3.Location = New System.Drawing.Point(142, 39)
        Me.TrackBar3.Maximum = 8000
        Me.TrackBar3.Minimum = -8000
        Me.TrackBar3.Name = "TrackBar3"
        Me.TrackBar3.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TrackBar3.Size = New System.Drawing.Size(45, 185)
        Me.TrackBar3.TabIndex = 5
        Me.TrackBar3.Value = 1000
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(283, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Z:"
        '
        'TrackBar4
        '
        Me.TrackBar4.Location = New System.Drawing.Point(272, 38)
        Me.TrackBar4.Maximum = 8000
        Me.TrackBar4.Minimum = -8000
        Me.TrackBar4.Name = "TrackBar4"
        Me.TrackBar4.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TrackBar4.Size = New System.Drawing.Size(45, 185)
        Me.TrackBar4.TabIndex = 7
        Me.TrackBar4.Value = 1000
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.SkyBlue
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(302, 229)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(37, 25)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "&x"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'prmGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(329, 255)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TrackBar4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TrackBar3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TrackBar2)
        Me.Controls.Add(Me.TrackBar1)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "prmGUI"
        Me.Opacity = 0.9
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Scale"
        Me.TopMost = True
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TrackBar2 As System.Windows.Forms.TrackBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TrackBar3 As System.Windows.Forms.TrackBar
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TrackBar4 As System.Windows.Forms.TrackBar
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class

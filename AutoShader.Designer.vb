﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AutoShader
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
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown
        Me.NumericUpDown3 = New System.Windows.Forms.NumericUpDown
        Me.NumericUpDown4 = New System.Windows.Forms.NumericUpDown
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.CheckBox3 = New System.Windows.Forms.CheckBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button5 = New System.Windows.Forms.Button
        Me.NumericUpDown7 = New System.Windows.Forms.NumericUpDown
        Me.NumericUpDown6 = New System.Windows.Forms.NumericUpDown
        Me.NumericUpDown5 = New System.Windows.Forms.NumericUpDown
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog
        Me.Label1 = New System.Windows.Forms.Label
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel
        Me.LinkLabel4 = New System.Windows.Forms.LinkLabel
        Me.CheckBox4 = New System.Windows.Forms.CheckBox
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDown7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.TextBox2.Location = New System.Drawing.Point(44, 77)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(308, 24)
        Me.TextBox2.TabIndex = 13
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Re-Volt Models|*.prm;*.m"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.AliceBlue
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Font = New System.Drawing.Font("Calibri", 8.25!)
        Me.TextBox3.Location = New System.Drawing.Point(183, 6)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(253, 62)
        Me.TextBox3.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Location = New System.Drawing.Point(9, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(297, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Light position-                      X:                                        Y:" & _
            "                                      Z:"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox1.Location = New System.Drawing.Point(32, 107)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(145, 17)
        Me.CheckBox1.TabIndex = 23
        Me.CheckBox1.Text = "Render Wireframe as well"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.DecimalPlaces = 2
        Me.NumericUpDown2.Enabled = False
        Me.NumericUpDown2.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDown2.Location = New System.Drawing.Point(137, 134)
        Me.NumericUpDown2.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(40, 21)
        Me.NumericUpDown2.TabIndex = 24
        '
        'NumericUpDown3
        '
        Me.NumericUpDown3.DecimalPlaces = 2
        Me.NumericUpDown3.Enabled = False
        Me.NumericUpDown3.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDown3.Location = New System.Drawing.Point(223, 134)
        Me.NumericUpDown3.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.NumericUpDown3.Name = "NumericUpDown3"
        Me.NumericUpDown3.Size = New System.Drawing.Size(40, 21)
        Me.NumericUpDown3.TabIndex = 25
        Me.NumericUpDown3.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'NumericUpDown4
        '
        Me.NumericUpDown4.DecimalPlaces = 2
        Me.NumericUpDown4.Enabled = False
        Me.NumericUpDown4.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDown4.Location = New System.Drawing.Point(312, 134)
        Me.NumericUpDown4.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.NumericUpDown4.Name = "NumericUpDown4"
        Me.NumericUpDown4.Size = New System.Drawing.Size(40, 21)
        Me.NumericUpDown4.TabIndex = 26
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox2.Location = New System.Drawing.Point(183, 107)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(95, 17)
        Me.CheckBox2.TabIndex = 27
        Me.CheckBox2.Text = "Quads in Green"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox3.Location = New System.Drawing.Point(284, 107)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(70, 17)
        Me.CheckBox3.TabIndex = 28
        Me.CheckBox3.Text = "Tris in Red"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(456, 9)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(160, 23)
        Me.Button3.TabIndex = 29
        Me.Button3.Text = "Shade by vertex"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(456, 39)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(160, 23)
        Me.Button4.TabIndex = 30
        Me.Button4.Text = "Shade by Polygon"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown7)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown6)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown5)
        Me.GroupBox1.Location = New System.Drawing.Point(392, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(217, 56)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Main Color"
        '
        'Button5
        '
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(167, 26)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(37, 24)
        Me.Button5.TabIndex = 32
        Me.Button5.Text = "..."
        Me.Button5.UseVisualStyleBackColor = True
        '
        'NumericUpDown7
        '
        Me.NumericUpDown7.Location = New System.Drawing.Point(121, 28)
        Me.NumericUpDown7.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.NumericUpDown7.Name = "NumericUpDown7"
        Me.NumericUpDown7.Size = New System.Drawing.Size(40, 21)
        Me.NumericUpDown7.TabIndex = 34
        Me.NumericUpDown7.Value = New Decimal(New Integer() {255, 0, 0, 0})
        '
        'NumericUpDown6
        '
        Me.NumericUpDown6.Location = New System.Drawing.Point(75, 28)
        Me.NumericUpDown6.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.NumericUpDown6.Name = "NumericUpDown6"
        Me.NumericUpDown6.Size = New System.Drawing.Size(40, 21)
        Me.NumericUpDown6.TabIndex = 33
        Me.NumericUpDown6.Value = New Decimal(New Integer() {255, 0, 0, 0})
        '
        'NumericUpDown5
        '
        Me.NumericUpDown5.Location = New System.Drawing.Point(18, 28)
        Me.NumericUpDown5.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.NumericUpDown5.Name = "NumericUpDown5"
        Me.NumericUpDown5.Size = New System.Drawing.Size(40, 21)
        Me.NumericUpDown5.TabIndex = 32
        Me.NumericUpDown5.Value = New Decimal(New Integer() {255, 0, 0, 0})
        '
        'ColorDialog1
        '
        Me.ColorDialog1.Color = System.Drawing.Color.White
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(407, 137)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "made by KDL"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(487, 135)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(27, 13)
        Me.LinkLabel1.TabIndex = 35
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "blog"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(520, 135)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(24, 13)
        Me.LinkLabel2.TabIndex = 36
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "RVL"
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Location = New System.Drawing.Point(551, 135)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(26, 13)
        Me.LinkLabel3.TabIndex = 37
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "ORP"
        '
        'LinkLabel4
        '
        Me.LinkLabel4.AutoSize = True
        Me.LinkLabel4.Location = New System.Drawing.Point(583, 134)
        Me.LinkLabel4.Name = "LinkLabel4"
        Me.LinkLabel4.Size = New System.Drawing.Size(26, 13)
        Me.LinkLabel4.TabIndex = 38
        Me.LinkLabel4.TabStop = True
        Me.LinkLabel4.Text = "wiki"
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox4.Location = New System.Drawing.Point(44, 25)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(58, 17)
        Me.CheckBox4.TabIndex = 39
        Me.CheckBox4.Text = "Inverse"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'AutoShader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(624, 168)
        Me.Controls.Add(Me.CheckBox4)
        Me.Controls.Add(Me.LinkLabel4)
        Me.Controls.Add(Me.LinkLabel3)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.NumericUpDown4)
        Me.Controls.Add(Me.NumericUpDown3)
        Me.Controls.Add(Me.NumericUpDown2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Calibri", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "AutoShader"
        Me.Text = "AutoShade Car"
        Me.TopMost = True
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.NumericUpDown7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents NumericUpDown2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDown3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDown4 As System.Windows.Forms.NumericUpDown
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents NumericUpDown7 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDown6 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDown5 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel3 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel4 As System.Windows.Forms.LinkLabel
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox

End Class

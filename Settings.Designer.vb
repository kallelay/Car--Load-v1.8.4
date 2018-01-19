<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me._View = New System.Windows.Forms.Panel
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.Button12 = New System.Windows.Forms.Button
        Me.Button11 = New System.Windows.Forms.Button
        Me.RadioButton7 = New System.Windows.Forms.RadioButton
        Me.RadioButton4 = New System.Windows.Forms.RadioButton
        Me.RadioButton8 = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Button7 = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.RadioButton6 = New System.Windows.Forms.RadioButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.TrackBar1 = New System.Windows.Forms.TrackBar
        Me.RadioButton9 = New System.Windows.Forms.RadioButton
        Me.RadioButton10 = New System.Windows.Forms.RadioButton
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.Label7 = New System.Windows.Forms.Label
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me._3Dsettings = New System.Windows.Forms.Panel
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.TrackBar3 = New System.Windows.Forms.TrackBar
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me._Apparences = New System.Windows.Forms.Panel
        Me.CheckBox4 = New System.Windows.Forms.CheckBox
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TrackBar2 = New System.Windows.Forms.TrackBar
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label11 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me._Screenshot = New System.Windows.Forms.Panel
        Me.CheckBox3 = New System.Windows.Forms.CheckBox
        Me.Button6 = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Button5 = New System.Windows.Forms.Button
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.ofd = New System.Windows.Forms.OpenFileDialog
        Me.Button8 = New System.Windows.Forms.Button
        Me.RadioButton14 = New System.Windows.Forms.RadioButton
        Me.RadioButton13 = New System.Windows.Forms.RadioButton
        Me.RadioButton11 = New System.Windows.Forms.RadioButton
        Me.RadioButton5 = New System.Windows.Forms.RadioButton
        Me.Button1 = New System.Windows.Forms.Button
        Me.CheckBox9 = New Car_Load.KDLCheckbox
        Me.CheckBox14 = New Car_Load.KDLCheckbox
        Me.CheckBox13 = New Car_Load.KDLCheckbox
        Me.Checkbox1 = New Car_Load.KDLCheckbox
        Me.CheckBox2 = New Car_Load.KDLCheckbox
        Me.CheckBox10 = New Car_Load.KDLCheckbox
        Me.CheckBox18 = New Car_Load.KDLCheckbox
        Me.Button4 = New System.Windows.Forms.Button
        Me._View.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._3Dsettings.SuspendLayout()
        CType(Me.TrackBar3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me._Apparences.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._Screenshot.SuspendLayout()
        Me.SuspendLayout()
        '
        '_View
        '
        Me._View.BackColor = System.Drawing.Color.MintCream
        Me._View.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._View.Controls.Add(Me.CheckBox9)
        Me._View.Controls.Add(Me.CheckBox14)
        Me._View.Controls.Add(Me.CheckBox13)
        Me._View.Controls.Add(Me.NumericUpDown1)
        Me._View.Controls.Add(Me.Button12)
        Me._View.Controls.Add(Me.Button11)
        Me._View.Controls.Add(Me.Checkbox1)
        Me._View.Controls.Add(Me.CheckBox2)
        Me._View.Controls.Add(Me.CheckBox10)
        Me._View.Location = New System.Drawing.Point(435, 317)
        Me._View.Name = "_View"
        Me._View.Size = New System.Drawing.Size(352, 221)
        Me._View.TabIndex = 43
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(253, 30)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(63, 22)
        Me.NumericUpDown1.TabIndex = 10
        Me.NumericUpDown1.Value = New Decimal(New Integer() {250, 0, 0, 0})
        '
        'Button12
        '
        Me.Button12.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.Location = New System.Drawing.Point(281, 164)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(79, 24)
        Me.Button12.TabIndex = 8
        Me.Button12.Text = "default"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Location = New System.Drawing.Point(275, 191)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(84, 25)
        Me.Button11.TabIndex = 7
        Me.Button11.Text = "pick texture"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'RadioButton7
        '
        Me.RadioButton7.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton7.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.RadioButton7.FlatAppearance.BorderSize = 2
        Me.RadioButton7.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black
        Me.RadioButton7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.RadioButton7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadioButton7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.RadioButton7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton7.ForeColor = System.Drawing.Color.White
        Me.RadioButton7.Location = New System.Drawing.Point(37, 70)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(95, 22)
        Me.RadioButton7.TabIndex = 4
        Me.RadioButton7.Text = "OpenGL"
        Me.RadioButton7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton7.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton4.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.RadioButton4.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue
        Me.RadioButton4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue
        Me.RadioButton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.RadioButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton4.ForeColor = System.Drawing.Color.Navy
        Me.RadioButton4.Location = New System.Drawing.Point(34, 81)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(95, 22)
        Me.RadioButton4.TabIndex = 4
        Me.RadioButton4.Text = "Points"
        Me.RadioButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton4.UseVisualStyleBackColor = False
        '
        'RadioButton8
        '
        Me.RadioButton8.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton8.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.RadioButton8.FlatAppearance.BorderSize = 2
        Me.RadioButton8.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black
        Me.RadioButton8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.RadioButton8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadioButton8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.RadioButton8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton8.ForeColor = System.Drawing.Color.White
        Me.RadioButton8.Location = New System.Drawing.Point(37, 95)
        Me.RadioButton8.Name = "RadioButton8"
        Me.RadioButton8.Size = New System.Drawing.Size(95, 22)
        Me.RadioButton8.TabIndex = 3
        Me.RadioButton8.Text = "Software"
        Me.RadioButton8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton8.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Button7)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.RadioButton6)
        Me.GroupBox2.Controls.Add(Me.RadioButton7)
        Me.GroupBox2.Controls.Add(Me.RadioButton8)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TrackBar1)
        Me.GroupBox2.Controls.Add(Me.RadioButton9)
        Me.GroupBox2.Controls.Add(Me.RadioButton10)
        Me.GroupBox2.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.GroupBox2.Location = New System.Drawing.Point(176, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(165, 158)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "                              "
        Me.GroupBox2.UseCompatibleTextRendering = True
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button7.Location = New System.Drawing.Point(6, 14)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(158, 138)
        Me.Button7.TabIndex = 20
        Me.Button7.Text = "By clicking here, you're fully warned that the application is going to restart on" & _
            "ce you choose any of the rendering engines"
        Me.Button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Location = New System.Drawing.Point(9, -1)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 14)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Rendering Engine"
        '
        'RadioButton6
        '
        Me.RadioButton6.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton6.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.RadioButton6.FlatAppearance.BorderSize = 2
        Me.RadioButton6.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black
        Me.RadioButton6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.RadioButton6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadioButton6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.RadioButton6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton6.ForeColor = System.Drawing.Color.White
        Me.RadioButton6.Location = New System.Drawing.Point(37, 120)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(95, 22)
        Me.RadioButton6.TabIndex = 5
        Me.RadioButton6.Text = "Software 2"
        Me.RadioButton6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Zoom:"
        Me.Label4.Visible = False
        '
        'TrackBar1
        '
        Me.TrackBar1.AutoSize = False
        Me.TrackBar1.Location = New System.Drawing.Point(47, 131)
        Me.TrackBar1.Maximum = 100
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(123, 34)
        Me.TrackBar1.TabIndex = 7
        Me.TrackBar1.TickStyle = System.Windows.Forms.TickStyle.None
        Me.TrackBar1.Value = 17
        Me.TrackBar1.Visible = False
        '
        'RadioButton9
        '
        Me.RadioButton9.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton9.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.RadioButton9.FlatAppearance.BorderSize = 2
        Me.RadioButton9.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black
        Me.RadioButton9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.RadioButton9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadioButton9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.RadioButton9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton9.ForeColor = System.Drawing.Color.White
        Me.RadioButton9.Location = New System.Drawing.Point(37, 45)
        Me.RadioButton9.Name = "RadioButton9"
        Me.RadioButton9.Size = New System.Drawing.Size(95, 22)
        Me.RadioButton9.TabIndex = 2
        Me.RadioButton9.Text = "DirectX 8"
        Me.RadioButton9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton9.UseVisualStyleBackColor = True
        '
        'RadioButton10
        '
        Me.RadioButton10.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton10.Checked = True
        Me.RadioButton10.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.RadioButton10.FlatAppearance.BorderSize = 2
        Me.RadioButton10.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black
        Me.RadioButton10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.RadioButton10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadioButton10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.RadioButton10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton10.ForeColor = System.Drawing.Color.White
        Me.RadioButton10.Location = New System.Drawing.Point(37, 20)
        Me.RadioButton10.Name = "RadioButton10"
        Me.RadioButton10.Size = New System.Drawing.Size(95, 22)
        Me.RadioButton10.TabIndex = 1
        Me.RadioButton10.TabStop = True
        Me.RadioButton10.Text = "DirectX 9"
        Me.RadioButton10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton10.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton3.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.RadioButton3.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue
        Me.RadioButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue
        Me.RadioButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.RadioButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton3.ForeColor = System.Drawing.Color.Navy
        Me.RadioButton3.Location = New System.Drawing.Point(34, 106)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(95, 22)
        Me.RadioButton3.TabIndex = 3
        Me.RadioButton3.Text = "Ghost"
        Me.RadioButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton3.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(27, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Current color:"
        '
        'RadioButton2
        '
        Me.RadioButton2.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton2.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.RadioButton2.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue
        Me.RadioButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue
        Me.RadioButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.RadioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.ForeColor = System.Drawing.Color.Navy
        Me.RadioButton2.Location = New System.Drawing.Point(34, 56)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(95, 22)
        Me.RadioButton2.TabIndex = 2
        Me.RadioButton2.Text = "Wireframe"
        Me.RadioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton2.UseVisualStyleBackColor = False
        '
        '_3Dsettings
        '
        Me._3Dsettings.BackColor = System.Drawing.Color.MintCream
        Me._3Dsettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._3Dsettings.Controls.Add(Me.Label13)
        Me._3Dsettings.Controls.Add(Me.Label9)
        Me._3Dsettings.Controls.Add(Me.Label8)
        Me._3Dsettings.Controls.Add(Me.TrackBar3)
        Me._3Dsettings.Controls.Add(Me.GroupBox2)
        Me._3Dsettings.Controls.Add(Me.GroupBox1)
        Me._3Dsettings.Location = New System.Drawing.Point(5, 38)
        Me._3Dsettings.Name = "_3Dsettings"
        Me._3Dsettings.Size = New System.Drawing.Size(352, 221)
        Me._3Dsettings.TabIndex = 38
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Consolas", 9.0!)
        Me.Label13.Location = New System.Drawing.Point(220, 180)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(119, 14)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Alpha channel On"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Consolas", 9.0!)
        Me.Label9.Location = New System.Drawing.Point(34, 180)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 14)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "EnvMap On"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(14, 157)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "ModeX:"
        '
        'TrackBar3
        '
        Me.TrackBar3.AutoSize = False
        Me.TrackBar3.LargeChange = 1
        Me.TrackBar3.Location = New System.Drawing.Point(112, 180)
        Me.TrackBar3.Maximum = 1
        Me.TrackBar3.Name = "TrackBar3"
        Me.TrackBar3.Size = New System.Drawing.Size(101, 34)
        Me.TrackBar3.TabIndex = 20
        Me.TrackBar3.Value = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.RadioButton4)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.GroupBox1.Location = New System.Drawing.Point(5, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(165, 142)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "                           "
        Me.GroupBox1.UseCompatibleTextRendering = True
        '
        'RadioButton1
        '
        Me.RadioButton1.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton1.Checked = True
        Me.RadioButton1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.RadioButton1.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue
        Me.RadioButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue
        Me.RadioButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.RadioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.ForeColor = System.Drawing.Color.Navy
        Me.RadioButton1.Location = New System.Drawing.Point(34, 32)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(95, 22)
        Me.RadioButton1.TabIndex = 1
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Solid Normal"
        Me.RadioButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 14)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Rendering Type"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        '_Apparences
        '
        Me._Apparences.BackColor = System.Drawing.Color.Azure
        Me._Apparences.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Apparences.Controls.Add(Me.CheckBox4)
        Me._Apparences.Controls.Add(Me.GroupBox7)
        Me._Apparences.Controls.Add(Me.GroupBox5)
        Me._Apparences.Location = New System.Drawing.Point(521, 42)
        Me._Apparences.Name = "_Apparences"
        Me._Apparences.Size = New System.Drawing.Size(352, 221)
        Me._Apparences.TabIndex = 39
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Checked = True
        Me.CheckBox4.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox4.Location = New System.Drawing.Point(119, 168)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(103, 18)
        Me.CheckBox4.TabIndex = 20
        Me.CheckBox4.Text = "Always on Top"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label5)
        Me.GroupBox7.Controls.Add(Me.TrackBar2)
        Me.GroupBox7.Font = New System.Drawing.Font("Calibri", 8.25!)
        Me.GroupBox7.Location = New System.Drawing.Point(15, 3)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(309, 47)
        Me.GroupBox7.TabIndex = 19
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Opacity"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "0%"
        '
        'TrackBar2
        '
        Me.TrackBar2.AutoSize = False
        Me.TrackBar2.Location = New System.Drawing.Point(47, 9)
        Me.TrackBar2.Maximum = 100
        Me.TrackBar2.Minimum = 45
        Me.TrackBar2.Name = "TrackBar2"
        Me.TrackBar2.Size = New System.Drawing.Size(256, 32)
        Me.TrackBar2.TabIndex = 19
        Me.TrackBar2.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        Me.TrackBar2.Value = 80
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.Panel1)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.Button3)
        Me.GroupBox5.Controls.Add(Me.NumericUpDown2)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Location = New System.Drawing.Point(15, 67)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(309, 99)
        Me.GroupBox5.TabIndex = 17
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "                           "
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label12.Location = New System.Drawing.Point(6, 71)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(297, 21)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "(time in mins)"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(104, 15)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(66, 26)
        Me.Panel1.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(193, 49)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "seconds"
        '
        'Button3
        '
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Calibri", 8.25!)
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.Location = New System.Drawing.Point(196, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(107, 31)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "pick another"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.UseCompatibleTextRendering = True
        Me.Button3.UseVisualStyleBackColor = True
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Location = New System.Drawing.Point(131, 46)
        Me.NumericUpDown2.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(56, 22)
        Me.NumericUpDown2.TabIndex = 19
        Me.NumericUpDown2.Value = New Decimal(New Integer() {60, 0, 0, 0})
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(10, -1)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Render window"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(27, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Change Color Every:"
        '
        '_Screenshot
        '
        Me._Screenshot.BackColor = System.Drawing.Color.Honeydew
        Me._Screenshot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._Screenshot.Controls.Add(Me.Button4)
        Me._Screenshot.Controls.Add(Me.CheckBox3)
        Me._Screenshot.Controls.Add(Me.Button6)
        Me._Screenshot.Controls.Add(Me.GroupBox4)
        Me._Screenshot.Controls.Add(Me.CheckBox18)
        Me._Screenshot.Controls.Add(Me.GroupBox3)
        Me._Screenshot.Controls.Add(Me.Button5)
        Me._Screenshot.Location = New System.Drawing.Point(11, 268)
        Me._Screenshot.Name = "_Screenshot"
        Me._Screenshot.Size = New System.Drawing.Size(352, 221)
        Me._Screenshot.TabIndex = 41
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Checked = True
        Me.CheckBox3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox3.Location = New System.Drawing.Point(158, 93)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(144, 18)
        Me.CheckBox3.TabIndex = 47
        Me.CheckBox3.Text = "Confirm before exiting"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Calibri", 8.25!)
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button6.Location = New System.Drawing.Point(203, 43)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(132, 34)
        Me.Button6.TabIndex = 13
        Me.Button6.Text = "Change directory"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Font = New System.Drawing.Font("Calibri", 8.25!)
        Me.GroupBox4.Location = New System.Drawing.Point(131, 19)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(214, 47)
        Me.GroupBox4.TabIndex = 46
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Restart and enter ""Directory editing mode"""
        '
        'GroupBox3
        '
        Me.GroupBox3.Font = New System.Drawing.Font("Calibri", 8.25!)
        Me.GroupBox3.Location = New System.Drawing.Point(15, 22)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(89, 55)
        Me.GroupBox3.TabIndex = 45
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Sounds Toggle"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Calibri", 8.25!)
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.Location = New System.Drawing.Point(15, 108)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(101, 34)
        Me.Button5.TabIndex = 12
        Me.Button5.Text = "Screenshot"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.UseVisualStyleBackColor = False
        '
        'ColorDialog1
        '
        Me.ColorDialog1.AnyColor = True
        Me.ColorDialog1.FullOpen = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.BlanchedAlmond
        Me.Button2.Location = New System.Drawing.Point(4, -2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(22, 18)
        Me.Button2.TabIndex = 47
        Me.Button2.Text = "-"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.Button2.UseCompatibleTextRendering = True
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1132, 26)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Settings"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ofd
        '
        Me.ofd.Filter = "Image files|*.bmp;*.png;*.tiff;*.tif;*.jpeg;*.jpg;*.tga"
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button8.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.Button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button8.Location = New System.Drawing.Point(353, 205)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(88, 28)
        Me.Button8.TabIndex = 19
        Me.Button8.Text = "About"
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.UseVisualStyleBackColor = False
        '
        'RadioButton14
        '
        Me.RadioButton14.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton14.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadioButton14.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.RadioButton14.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RadioButton14.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RadioButton14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RadioButton14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton14.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RadioButton14.Location = New System.Drawing.Point(353, 93)
        Me.RadioButton14.Name = "RadioButton14"
        Me.RadioButton14.Size = New System.Drawing.Size(87, 27)
        Me.RadioButton14.TabIndex = 48
        Me.RadioButton14.Text = "View (2)"
        Me.RadioButton14.UseVisualStyleBackColor = False
        '
        'RadioButton13
        '
        Me.RadioButton13.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton13.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadioButton13.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.RadioButton13.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RadioButton13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RadioButton13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RadioButton13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton13.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.RadioButton13.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RadioButton13.Location = New System.Drawing.Point(351, 162)
        Me.RadioButton13.Name = "RadioButton13"
        Me.RadioButton13.Size = New System.Drawing.Size(87, 27)
        Me.RadioButton13.TabIndex = 46
        Me.RadioButton13.Text = "Extra"
        Me.RadioButton13.UseVisualStyleBackColor = False
        '
        'RadioButton11
        '
        Me.RadioButton11.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton11.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadioButton11.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.RadioButton11.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RadioButton11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RadioButton11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RadioButton11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton11.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RadioButton11.Location = New System.Drawing.Point(353, 60)
        Me.RadioButton11.Name = "RadioButton11"
        Me.RadioButton11.Size = New System.Drawing.Size(87, 27)
        Me.RadioButton11.TabIndex = 44
        Me.RadioButton11.Text = "View (1)"
        Me.RadioButton11.UseVisualStyleBackColor = False
        '
        'RadioButton5
        '
        Me.RadioButton5.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton5.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadioButton5.Checked = True
        Me.RadioButton5.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.RadioButton5.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RadioButton5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RadioButton5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RadioButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RadioButton5.Location = New System.Drawing.Point(333, 129)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(107, 27)
        Me.RadioButton5.TabIndex = 40
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "3D settings"
        Me.RadioButton5.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(435, -5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(22, 24)
        Me.Button1.TabIndex = 49
        Me.Button1.Text = "x"
        Me.Button1.UseCompatibleTextRendering = True
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CheckBox9
        '
        Me.CheckBox9.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox9.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox9.Checked = True
        Me.CheckBox9.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox9.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue
        Me.CheckBox9.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.CheckBox9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.CheckBox9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.CheckBox9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox9.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CheckBox9.ForeColor = System.Drawing.Color.Black
        Me.CheckBox9.Image = CType(resources.GetObject("CheckBox9.Image"), System.Drawing.Image)
        Me.CheckBox9.Image_Active = CType(resources.GetObject("CheckBox9.Image_Active"), System.Drawing.Image)
        Me.CheckBox9.Image_Hover = CType(resources.GetObject("CheckBox9.Image_Hover"), System.Drawing.Image)
        Me.CheckBox9.Image_Normal = CType(resources.GetObject("CheckBox9.Image_Normal"), System.Drawing.Image)
        Me.CheckBox9.Location = New System.Drawing.Point(7, 140)
        Me.CheckBox9.Name = "CheckBox9"
        Me.CheckBox9.Size = New System.Drawing.Size(108, 73)
        Me.CheckBox9.TabIndex = 3
        Me.CheckBox9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBox9.Txt = ""
        Me.CheckBox9.UseVisualStyleBackColor = True
        '
        'CheckBox14
        '
        Me.CheckBox14.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox14.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox14.Checked = True
        Me.CheckBox14.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox14.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue
        Me.CheckBox14.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.CheckBox14.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.CheckBox14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.CheckBox14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox14.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CheckBox14.ForeColor = System.Drawing.Color.DarkGray
        Me.CheckBox14.Image = CType(resources.GetObject("CheckBox14.Image"), System.Drawing.Image)
        Me.CheckBox14.Image_Active = CType(resources.GetObject("CheckBox14.Image_Active"), System.Drawing.Image)
        Me.CheckBox14.Image_Hover = CType(resources.GetObject("CheckBox14.Image_Hover"), System.Drawing.Image)
        Me.CheckBox14.Image_Normal = CType(resources.GetObject("CheckBox14.Image_Normal"), System.Drawing.Image)
        Me.CheckBox14.Location = New System.Drawing.Point(7, 74)
        Me.CheckBox14.Name = "CheckBox14"
        Me.CheckBox14.Size = New System.Drawing.Size(108, 60)
        Me.CheckBox14.TabIndex = 0
        Me.CheckBox14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBox14.Txt = ""
        Me.CheckBox14.UseVisualStyleBackColor = True
        '
        'CheckBox13
        '
        Me.CheckBox13.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox13.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox13.Checked = True
        Me.CheckBox13.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox13.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue
        Me.CheckBox13.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.CheckBox13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.CheckBox13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.CheckBox13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox13.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CheckBox13.ForeColor = System.Drawing.Color.DarkGray
        Me.CheckBox13.Image = CType(resources.GetObject("CheckBox13.Image"), System.Drawing.Image)
        Me.CheckBox13.Image_Active = CType(resources.GetObject("CheckBox13.Image_Active"), System.Drawing.Image)
        Me.CheckBox13.Image_Hover = CType(resources.GetObject("CheckBox13.Image_Hover"), System.Drawing.Image)
        Me.CheckBox13.Image_Normal = CType(resources.GetObject("CheckBox13.Image_Normal"), System.Drawing.Image)
        Me.CheckBox13.Location = New System.Drawing.Point(7, 13)
        Me.CheckBox13.Name = "CheckBox13"
        Me.CheckBox13.Size = New System.Drawing.Size(108, 49)
        Me.CheckBox13.TabIndex = 2
        Me.CheckBox13.Text = " "
        Me.CheckBox13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBox13.Txt = " "
        Me.CheckBox13.UseVisualStyleBackColor = True
        '
        'Checkbox1
        '
        Me.Checkbox1.Appearance = System.Windows.Forms.Appearance.Button
        Me.Checkbox1.BackColor = System.Drawing.Color.Transparent
        Me.Checkbox1.Checked = True
        Me.Checkbox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Checkbox1.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue
        Me.Checkbox1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Checkbox1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Checkbox1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Checkbox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Checkbox1.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Checkbox1.ForeColor = System.Drawing.Color.DarkGray
        Me.Checkbox1.Image = CType(resources.GetObject("Checkbox1.Image"), System.Drawing.Image)
        Me.Checkbox1.Image_Active = CType(resources.GetObject("Checkbox1.Image_Active"), System.Drawing.Image)
        Me.Checkbox1.Image_Hover = CType(resources.GetObject("Checkbox1.Image_Hover"), System.Drawing.Image)
        Me.Checkbox1.Image_Normal = CType(resources.GetObject("Checkbox1.Image_Normal"), System.Drawing.Image)
        Me.Checkbox1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Checkbox1.Location = New System.Drawing.Point(180, 13)
        Me.Checkbox1.Name = "Checkbox1"
        Me.Checkbox1.Size = New System.Drawing.Size(117, 49)
        Me.Checkbox1.TabIndex = 8
        Me.Checkbox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Checkbox1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Checkbox1.Txt = ""
        Me.Checkbox1.UseVisualStyleBackColor = False
        '
        'CheckBox2
        '
        Me.CheckBox2.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox2.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox2.Checked = True
        Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox2.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue
        Me.CheckBox2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.CheckBox2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.CheckBox2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.CheckBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox2.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CheckBox2.ForeColor = System.Drawing.Color.DarkGray
        Me.CheckBox2.Image = CType(resources.GetObject("CheckBox2.Image"), System.Drawing.Image)
        Me.CheckBox2.Image_Active = CType(resources.GetObject("CheckBox2.Image_Active"), System.Drawing.Image)
        Me.CheckBox2.Image_Hover = CType(resources.GetObject("CheckBox2.Image_Hover"), System.Drawing.Image)
        Me.CheckBox2.Image_Normal = CType(resources.GetObject("CheckBox2.Image_Normal"), System.Drawing.Image)
        Me.CheckBox2.Location = New System.Drawing.Point(178, 77)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(117, 54)
        Me.CheckBox2.TabIndex = 6
        Me.CheckBox2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBox2.Txt = ""
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox10
        '
        Me.CheckBox10.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox10.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox10.Checked = True
        Me.CheckBox10.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox10.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue
        Me.CheckBox10.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.CheckBox10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.CheckBox10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.CheckBox10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox10.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CheckBox10.ForeColor = System.Drawing.Color.DarkGray
        Me.CheckBox10.Image = CType(resources.GetObject("CheckBox10.Image"), System.Drawing.Image)
        Me.CheckBox10.Image_Active = CType(resources.GetObject("CheckBox10.Image_Active"), System.Drawing.Image)
        Me.CheckBox10.Image_Hover = CType(resources.GetObject("CheckBox10.Image_Hover"), System.Drawing.Image)
        Me.CheckBox10.Image_Normal = CType(resources.GetObject("CheckBox10.Image_Normal"), System.Drawing.Image)
        Me.CheckBox10.Location = New System.Drawing.Point(177, 138)
        Me.CheckBox10.Name = "CheckBox10"
        Me.CheckBox10.Size = New System.Drawing.Size(117, 75)
        Me.CheckBox10.TabIndex = 4
        Me.CheckBox10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBox10.Txt = ""
        Me.CheckBox10.UseVisualStyleBackColor = True
        '
        'CheckBox18
        '
        Me.CheckBox18.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox18.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox18.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue
        Me.CheckBox18.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.CheckBox18.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.CheckBox18.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.CheckBox18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox18.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox18.ForeColor = System.Drawing.Color.Gray
        Me.CheckBox18.Image = Global.Car_Load.My.Resources.Resources.sounds_n
        Me.CheckBox18.Image_Active = Global.Car_Load.My.Resources.Resources.sounds
        Me.CheckBox18.Image_Hover = Global.Car_Load.My.Resources.Resources.sounds_n
        Me.CheckBox18.Image_Normal = Global.Car_Load.My.Resources.Resources.sounds_n
        Me.CheckBox18.Location = New System.Drawing.Point(31, 47)
        Me.CheckBox18.Name = "CheckBox18"
        Me.CheckBox18.Size = New System.Drawing.Size(58, 55)
        Me.CheckBox18.TabIndex = 44
        Me.CheckBox18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBox18.Txt = ""
        Me.CheckBox18.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(158, 123)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(175, 27)
        Me.Button4.TabIndex = 48
        Me.Button4.Text = "Collect Log"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(1132, 677)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.RadioButton14)
        Me.Controls.Add(Me.RadioButton13)
        Me.Controls.Add(Me.RadioButton11)
        Me.Controls.Add(Me.RadioButton5)
        Me.Controls.Add(Me._View)
        Me.Controls.Add(Me._3Dsettings)
        Me.Controls.Add(Me._Apparences)
        Me.Controls.Add(Me._Screenshot)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Settings"
        Me.ShowInTaskbar = False
        Me.TopMost = True
        Me._View.ResumeLayout(False)
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me._3Dsettings.ResumeLayout(False)
        Me._3Dsettings.PerformLayout()
        CType(Me.TrackBar3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me._Apparences.ResumeLayout(False)
        Me._Apparences.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        Me._Screenshot.ResumeLayout(False)
        Me._Screenshot.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents _View As System.Windows.Forms.Panel
    Friend WithEvents RadioButton7 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton8 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents RadioButton6 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton9 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton10 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents _3Dsettings As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents _Apparences As System.Windows.Forms.Panel
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents _Screenshot As System.Windows.Forms.Panel
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents RadioButton14 As System.Windows.Forms.RadioButton
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents RadioButton13 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton11 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents TrackBar2 As System.Windows.Forms.TrackBar
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TrackBar3 As System.Windows.Forms.TrackBar
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents ofd As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Checkbox1 As Car_Load.KDLCheckbox
    Friend WithEvents CheckBox13 As Car_Load.KDLCheckbox
    Friend WithEvents CheckBox14 As Car_Load.KDLCheckbox
    Friend WithEvents CheckBox9 As Car_Load.KDLCheckbox
    Friend WithEvents CheckBox10 As Car_Load.KDLCheckbox
    Friend WithEvents CheckBox2 As Car_Load.KDLCheckbox
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents CheckBox18 As Car_Load.KDLCheckbox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class

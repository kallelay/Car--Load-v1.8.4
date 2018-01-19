Public Class Settings
    Dim L As New Timer
    Dim D As New Timer
    Dim K As New Timer
    Dim CurPos As Point
    Dim _form As New Form
    Dim lbl As New Label
    Dim modeX As IrrlichtNETCP.MaterialType = IrrlichtNETCP.MaterialType.Reflection2Layer 'Or IrrlichtNETCP.MaterialType.TransparentAlphaChannel
    Public Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = False Then Exit Sub
        For Each prm As Car_Model In Models
            prm.ScnNode.SetMaterialType(modeX)
            prm.ScnNode.SetMaterialFlag(IrrlichtNETCP.MaterialFlag.Wireframe, False)
            prm.ScnNode.SetMaterialFlag(IrrlichtNETCP.MaterialFlag.PointCloud, False)
        Next
    End Sub

    Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = False Then Exit Sub
        For Each prm As Car_Model In Models
            prm.ScnNode.SetMaterialType(modeX)
            prm.ScnNode.SetMaterialFlag(IrrlichtNETCP.MaterialFlag.Wireframe, True)
            prm.ScnNode.SetMaterialFlag(IrrlichtNETCP.MaterialFlag.PointCloud, False)
        Next
    End Sub
    Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = False Then Exit Sub
        For Each prm As Car_Model In Models
            prm.ScnNode.SetMaterialType(modeX)
            prm.ScnNode.SetMaterialFlag(IrrlichtNETCP.MaterialFlag.PointCloud, True)
            prm.ScnNode.SetMaterialFlag(IrrlichtNETCP.MaterialFlag.Wireframe, False)
        Next
    End Sub

    Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = False Then Exit Sub
        For Each prm As Car_Model In Models
            prm.ScnNode.SetMaterialType(IrrlichtNETCP.MaterialType.TransparentAddColor)
            prm.ScnNode.SetMaterialFlag(IrrlichtNETCP.MaterialFlag.Wireframe, False)
            prm.ScnNode.SetMaterialFlag(IrrlichtNETCP.MaterialFlag.PointCloud, False)

        Next
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub



    Private Sub RadioButton10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton10.CheckedChanged

        If Initialized = False Then Exit Sub
        If RadioButton10.Checked = False Then Exit Sub
        Shell("car_load.exe -dx9", AppWinStyle.NormalFocus)
        End

    End Sub


    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar1.Scroll
   
        ' Render.cam.Position = New IrrlichtNETCP.Vector3D(Render.cam.Position.X, Render.cte, Render.cam.Position.Z)

        ' For Each prm As Car_Model In Models

        '  Next
    End Sub
    Dim form_shown = True
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label1.DoubleClick
        If form_shown Then
            form_shown = False
            Me.Height = Label1.Height
        Else
            Me.Height = 266
           
            form_shown = True
        End If
    End Sub

    Private Sub Label1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label1.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += MousePosition - CurPos
            CurPos = MousePosition
        Else
            CurPos = MousePosition
        End If
    End Sub

    Private Sub Settings_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
     
    End Sub

    Private Sub Settings_InputLanguageChanging(ByVal sender As Object, ByVal e As System.Windows.Forms.InputLanguageChangingEventArgs) Handles Me.InputLanguageChanging

    End Sub



    Private Sub Settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



        If GetSetting("Car Load", "settings", "zoom", 0) > 0 Then TrackBar1.Value = GetSetting("Car Load", "settings", "zoom", 1)
        If Not IsNumeric(GetSetting("Car Load", "settings", "ChangeEach", "")) Then
            SaveSetting("Car Load", "settings", "ChangeEach", Split(GetSetting("Car Load", "settings", "ChangeEach", ""), " ")(0))
        End If
        Try
            Dim it$ = GetSetting("Car Load", "settings", "ChangeEach", 60)

            If it = "" Then it = 60


            NumericUpDown2.Value = GetSetting("Car Load", "settings", "ChangeEach", 60)


        Catch ex As Exception
            SaveSetting("Car Load", "settings", "ChangeEach", 60)
            NumericUpDown2.Value = GetSetting("Car Load", "settings", "ChangeEach", 60)
        End Try



        'sett!
        Me.Height = 266
        Me.Width = _3Dsettings.Left + _3Dsettings.Width + RadioButton5.Width + 5 '438 '372

        'init panels
        _Apparences.Location = _3Dsettings.Location

        _Screenshot.Location = _3Dsettings.Location
        _View.Location = _3Dsettings.Location
        'Dire.Location = _3Dsettings.Location


        _Apparences.Hide()
        _3Dsettings.Show()

        _Screenshot.Hide()
        _View.Hide()
        '  Dire.Hide()

        Select Case Render.DvType
            Case IrrlichtNETCP.DriverType.OpenGL
                RadioButton7.Checked = True
            Case IrrlichtNETCP.DriverType.Direct3D8
                RadioButton9.Checked = True
            Case IrrlichtNETCP.DriverType.Direct3D9
                RadioButton10.Checked = True
            Case IrrlichtNETCP.DriverType.Software
                RadioButton8.Checked = True
            Case IrrlichtNETCP.DriverType.Software2
                RadioButton6.Checked = True
        End Select
    End Sub

    Private Sub RadioButton9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton9.CheckedChanged
        If Initialized = False Then Exit Sub
        If RadioButton9.Checked = False Then Exit Sub
        Shell("car_load.exe -dx8", AppWinStyle.NormalFocus)
        End

    End Sub

    Private Sub RadioButton7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton7.CheckedChanged
        If Initialized = False Then Exit Sub
        If RadioButton7.Checked = False Then Exit Sub
        Shell("car_load.exe -gl", AppWinStyle.NormalFocus)
        End
    End Sub

    Private Sub RadioButton8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton8.CheckedChanged
        If Initialized = False Then Exit Sub
        If RadioButton8.Checked = False Then Exit Sub
        Shell("car_load.exe -sw", AppWinStyle.NormalFocus)
        End

    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        If Initialized = False Then Exit Sub
        If RadioButton6.Checked = False Then Exit Sub
        Shell("car_load.exe -sw2", AppWinStyle.NormalFocus)
        End

    End Sub

    Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If CheckBox3.Checked Then _
        If Not RenderForm.Restarting Then _
             If YesNo.Message("Exit?") = Windows.Forms.DialogResult.No Then Exit Sub


        SaveSetting("Car Load", "settings", "Opacity", TrackBar2.Value)
        SaveSetting("Car Load", "settings", "zoom", TrackBar1.Value)
        SaveSetting("Car Load", "settings", "ChangeEach", NumericUpDown2.Value)

        Select Case Render.DvType
            Case IrrlichtNETCP.DriverType.Direct3D8
                SaveSetting("Car Load", "settings", "lastrnd", "-dx8")
            Case IrrlichtNETCP.DriverType.Direct3D9
                SaveSetting("Car Load", "settings", "lastrnd", "-dx9")
            Case IrrlichtNETCP.DriverType.OpenGL
                SaveSetting("Car Load", "settings", "lastrnd", "-gl")
            Case IrrlichtNETCP.DriverType.Software
                SaveSetting("Car Load", "settings", "lastrnd", "-sw")
            Case IrrlichtNETCP.DriverType.Software2
                SaveSetting("Car Load", "settings", "lastrnd", "-sw2")
        End Select

        SaveSetting("Car Load", "settings", "modex", TrackBar3.Value)
        SaveSetting("Car Load", "settings", "floor", CheckBox10.Checked)
        SaveSetting("Car Load", "settings", "light", Checkbox1.Checked)
        SaveSetting("Car Load", "settings", "shadow", CheckBox2.Checked)
        SaveSetting("Car Load", "settings", "name", CheckBox13.Checked)
        SaveSetting("Car Load", "settings", "logo", CheckBox9.Checked)
        SaveSetting("Car Load", "settings", "gradient", CheckBox14.Checked)

        Render.Device.Dispose()
        Process.GetCurrentProcess.Kill()

        End

    End Sub

    Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        Try
            Dim image As IrrlichtNETCP.Image = Render.VideoDriver.CreateScreenShot()
        

            Dim name = _car.Theory.MainInfos.Name
            Do Until name(0) <> Chr(9) And name(0) <> " "
                name = Mid(name, 2)
            Loop

            Dim tmp = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) & "\" & name & ".png"
            'Dim tmp = "C:\Users\kallel\pics" & "\" & name.Replace("*", "_") & ".png"
            Render.VideoDriver.WriteImageIntoFile(image, tmp)

            image.Dispose()

            _form.BackColor = Color.Black
            _form.FormBorderStyle = Windows.Forms.FormBorderStyle.None

            _form.Size = New Point(RenderForm.Width / 2, RenderForm.Height / 2)

            _form.StartPosition = FormStartPosition.CenterScreen
            _form.Opacity = 0


            K.Interval = 10
            AddHandler K.Tick, AddressOf tickMe
            K.Start()


            lbl.AutoSize = False
            lbl.Width = RenderForm.Width / 2
            lbl.Height = 500
            lbl.TextAlign = ContentAlignment.TopCenter
            lbl.BackColor = Color.Transparent
            lbl.ForeColor = Color.DarkBlue
            lbl.Font = New Font("Arial", 8, FontStyle.Bold, GraphicsUnit.Point)

            _form.Controls.Add(lbl)
            lbl.Text = vbNewLine & "saved to... " & vbNewLine & tmp

            _form.TopMost = True
            _form.BackgroundImage = Drawing.Image.FromFile(tmp)
            _form.BackgroundImageLayout = ImageLayout.Stretch

            _form.Show()




            L.Interval = 10
            AddHandler L.Tick, AddressOf TickMeAgain


            D.Interval = 3000
            AddHandler D.Tick, AddressOf BeginNTimer
            D.Start()
        Catch

        End Try


    End Sub
    Sub tickMe()
        _form.Opacity += 0.03
        If _form.Opacity > 0.9 Then
            K.Stop()
        End If
    End Sub
    Sub TickMeAgain()
        _form.Opacity -= 0.03
        If _form.Opacity < 0.05 Then
            L.Stop()
            _form.Hide()
            _form.BackgroundImage.Dispose()

        End If
    End Sub
    Sub BeginNTimer()
        D.Stop()
        L.Start()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked = False Then Exit Sub

        'Hover(Selected)
        If Initialized Then
            If Selected.Name <> RadioButton5.Name Then Out(Selected)
        End If
        Selected = RadioButton5
        If Initialized Then Hover(Selected)
        RefreshAll()


        _Apparences.Hide()
        _3Dsettings.Show()

        _Screenshot.Hide()
        _View.Hide()
        '_Dire.Hide()
    End Sub

    Private Sub RadioButton11_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton11.CheckedChanged
        If RadioButton11.Checked = False Then Exit Sub

        Out(Selected)
        Selected = RadioButton11
        Hover(Selected)
        RefreshAll()


        _Apparences.Show()
        _3Dsettings.Hide()

        _Screenshot.Hide()
        _View.Hide()
        ' _Dire.Hide()
    End Sub


    Private Sub NumericUpDown2_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles NumericUpDown2.ValueChanged


        If NumericUpDown2.Value = 0 Then
            RenderForm.Timer1.Stop()
            Label12.Text = "disabled"
            Exit Sub
    

        End If

        RenderForm.Timer1.Start()
        RenderForm.Timer1.Interval = NumericUpDown2.Value * 1000 + 1


        Label12.Text = If(NumericUpDown2.Value >= 3600, NumericUpDown2.Value \ 3600 & " hours and ", "") & If(NumericUpDown2.Value >= 60, (NumericUpDown2.Value Mod 3600) \ 60 & " minutes and ", "") & NumericUpDown2.Value Mod 60 & " seconds."


    End Sub

    Private Sub TrackBar2_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TrackBar2.ValueChanged
        If Initialized <> True Then Exit Sub
        Me.Opacity = TrackBar2.Value / 100
        RenderForm.Opacity = Me.Opacity
        Car_browser.Opacity = Me.Opacity
        Editor.Opacity = Me.Opacity

        Label5.Text = TrackBar2.Value & "%"
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ColorDialog1.Color = Render._cc.dotNETColor
        If ColorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Render._cc = New IrrlichtNETCP.Color(ColorDialog1.Color.A, ColorDialog1.Color.R, ColorDialog1.Color.G, ColorDialog1.Color.B)
            Panel1.BackColor = ColorDialog1.Color



            SaveSetting("Car Load", "settings", "CC.R", Render._cc.R)
            SaveSetting("Car Load", "settings", "CC.G", Render._cc.G)
            SaveSetting("Car Load", "settings", "CC.B", Render._cc.B)

        End If

    End Sub

    Private Sub TrackBar2_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub



    Private Sub RadioButton13_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton13.CheckedChanged
        If RadioButton13.Checked = False Then Exit Sub

        Out(Selected)
        Selected = RadioButton13
        Hover(Selected)
        RefreshAll()


        _3Dsettings.Hide()
        _Apparences.Hide()
        _Screenshot.Show()
        _View.Hide()
        '_Dire.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        RenderForm.WindowState = FormWindowState.Minimized
        Me.WindowState = FormWindowState.Minimized
        Car_browser.WindowState = FormWindowState.Minimized
        Directory.WindowState = FormWindowState.Minimized
        Editor.WindowState = FormWindowState.Minimized
    End Sub


    Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        PlusOne()
    End Sub
    Sub PlusOne()

        If Car_browser.ListBox2.SelectedIndex + 1 = Car_browser.ListBox2.Items.Count Then Car_browser.ListBox2.SelectedIndex = -1
        Car_browser.ListBox2.SelectedIndex += 1
        'Car_browser.ListBox2_DoubleClick(sender, e)
    End Sub
    Sub MinusOne()

        If Car_browser.ListBox2.SelectedIndex <= 0 Then
            Car_browser.ListBox2.SelectedIndex = Car_browser.ListBox2.Items.Count - 1
            Exit Sub
        End If

        Car_browser.ListBox2.SelectedIndex -= 1
        'Car_browser.ListBox2_DoubleClick(sender, e)
    End Sub

    Private Sub _View_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radiobutton14.CheckedChanged
        If radiobutton14.Checked = False Then Exit Sub
        _Apparences.Hide()
        _3Dsettings.Hide()

        _Screenshot.Hide()
        _View.Show()

    End Sub



  

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Shell("car_load " & Command() & " /ss", AppWinStyle.NormalFocus)
        Dim pro As New Process
        pro = Process.GetCurrentProcess()
        pro.Kill()

    End Sub

    Private Sub RadioButton14_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton14.CheckedChanged
        If RadioButton14.Checked = False Then Exit Sub

        Out(Selected)
        Selected = RadioButton14
        Hover(Selected)
        RefreshAll()

        _Apparences.Hide()
        _3Dsettings.Hide()

        _Screenshot.Hide()
        _View.Show()
        '_Dire.Hide()
    End Sub



    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Shell("car_load /config")
        End
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
        Button1.Image = My.Resources.window_close
    End Sub

    Private Sub Button1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Button1.Image = My.Resources.window_close
    End Sub


    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        About.Show()
    End Sub


    Private Sub TrackBar1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TrackBar1.ValueChanged
        Render.cte = TrackBar1.Value
        If Not Initialized Then Exit Sub
        '     Render.cam.Position = New IrrlichtNETCP.Vector3D(Render.cam.Target.X + -Math.Cos(Render.alpha) * Render.cte, Render.cam.Position.Y, Render.cam.Target.Z + Math.Sin(Render.alpha) * Render.cte)

    End Sub


    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CheckBox9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox9.CheckedChanged

    End Sub

    Private Sub CheckBox10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox10.CheckedChanged
        If Initialized = False Then Exit Sub
        Editor.EnDis()
    End Sub

    Private Sub Settings_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

    End Sub
    Dim Selected As RadioButton = RadioButton5
    Sub RefreshAll()
        For Each ctrl As Control In Controls
            Try
                If InStr(ctrl.Name, "radiobutton", CompareMethod.Text) = 0 Then Exit Try
                Dim ctr = DirectCast(ctrl, RadioButton)
                If ctr.Name <> Selected.Name Then
                    Out(ctr)
                End If
            Catch ex As Exception

            End Try


        Next
    End Sub
    Sub Hover(ByRef but As RadioButton)
        ' Debugger.Break()
        Do Until but.Width >= 107
            Threading.Thread.Sleep(16)
            but.Left -= 2
            but.Width += 2
            Application.DoEvents()
        Loop
    End Sub

    Sub Out(ByRef but As RadioButton)

        If but.Name = Selected.Name Then Exit Sub
        Do Until but.Width <= 87
            Threading.Thread.Sleep(16)
            but.Left += 2
            but.Width -= 2
            Application.DoEvents()
        Loop
    End Sub
    

    Sub Hover(ByRef but As Button)
        Do Until but.Width >= 107
            Threading.Thread.Sleep(16)
            but.Left -= 2
            but.Width += 2
            Application.DoEvents()
        Loop
    End Sub

    Sub Out(ByRef but As Button)
        Do Until but.Width <= 87
            Threading.Thread.Sleep(16)
            but.Left += 2
            but.Width -= 2
            Application.DoEvents()
        Loop
    End Sub



    Private Sub RadioButton11_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton11.MouseHover
        Hover(RadioButton11)
    End Sub
    Private Sub RadioButton11_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton11.MouseLeave
        Out(RadioButton11)
    End Sub
    Private Sub RadioButton5_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton5.MouseHover
        Hover(RadioButton5)
    End Sub
    Private Sub RadioButton5_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton5.MouseLeave
        Out(RadioButton5)
    End Sub

    Private Sub RadioButton13_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton13.MouseHover
        Hover(RadioButton13)
    End Sub
    Private Sub RadioButton13_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton13.MouseLeave
        Out(RadioButton13)
    End Sub

    Private Sub RadioButton14_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton14.MouseHover
        Hover(RadioButton14)
    End Sub
    Private Sub RadioButton14_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton14.MouseLeave
        Out(RadioButton14)
    End Sub
    Private Sub button8_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button8.MouseHover
        Hover(Button8)
    End Sub
    Private Sub button8_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button8.MouseLeave
        Out(Button8)
    End Sub

    Private Sub _Screenshot_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles _Screenshot.Paint

    End Sub

    Private Sub CheckBox13_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox13.CheckedChanged

    End Sub



    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Button7.Hide()

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CheckBox8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Sub TrackBar3_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar3.Scroll
        If TrackBar3.Value = 1 Then
            modeX = IrrlichtNETCP.MaterialType.Solid ' Or IrrlichtNETCP.MaterialType.TransparentReflection2Layer

        Else
            modeX = IrrlichtNETCP.MaterialType.Reflection2Layer
        End If
        RadioButton1_CheckedChanged(sender, e)
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If Initialized = False Then Exit Sub
        Editor.EnDis()
    End Sub

   



    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
            SaveSetting("Car Load", "settings", "Floor Texture", ofd.FileName)
            TextureFloorFile = GetSetting("Car Load", "settings", "Floor Texture", "")
            Render.mShadowScnNode.GetMaterial(0).Texture1 = Render.Device.VideoDriver.GetTexture(TextureFloorFile)
        End If
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        TextureFloorFile = My.Computer.FileSystem.SpecialDirectories.Temp & "\mshadow.png"
        SaveSetting("Car Load", "settings", "Floor Texture", "")

        Render.mShadowScnNode.GetMaterial(0).Texture1 = Render.Device.VideoDriver.GetTexture(TextureFloorFile)

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
      
    End Sub

 



    Sub Checkbox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Checkbox1.CheckedChanged
        If Not Initialized Then Exit Sub

        If Checkbox1.Checked = False Then

            Render.Light.Visible = False
            For Each m As Car_Model In Models
                m.ScnNode.GetMaterial(0).EmissiveColor = IrrlichtNETCP.Color.Black
                m.ScnNode.GetMaterial(0).Lighting = False
                m.ScnNode.GetMaterial(0).Shininess = 0
                m.ScnNode.GetMaterial(0).SpecularColor = IrrlichtNETCP.Color.Black

            Next


        Else
            Render.Light.Visible = True
            For Each m As Car_Model In Models
                m.ScnNode.GetMaterial(0).EmissiveColor = New IrrlichtNETCP.Color(128, _car.Theory.MainInfos.EnvRGB.X, _car.Theory.MainInfos.EnvRGB.Y, _car.Theory.MainInfos.EnvRGB.Z)
                m.ScnNode.GetMaterial(0).Lighting = True
                m.ScnNode.GetMaterial(0).Shininess = 40
                m.ScnNode.GetMaterial(0).SpecularColor = New IrrlichtNETCP.Color(128, _car.Theory.MainInfos.EnvRGB.X, _car.Theory.MainInfos.EnvRGB.Y, _car.Theory.MainInfos.EnvRGB.Z)
            Next
        End If
    End Sub

    Private Sub TrackBar2_Scroll_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar2.Scroll

    End Sub

    Private Sub CheckBox18_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox18.CheckedChanged
        If Not Initialized Then Exit Sub
        If _car.Theory.Body Is Nothing Then
            message.Message("please select a car before pressing this button, then press this again")
            Exit Sub
        End If

        If CheckBox18.Checked = True Then
            If Editor.CheckBox2.Checked Then SoundOn()
        Else
            SoundOff()
        End If

    End Sub

    Private Sub NumericUpDown1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown1.ValueChanged
        If Not Initialized Then Exit Sub


        Dim txt = If(IsNumeric(NumericUpDown1.Text), Int(NumericUpDown1.Text), 250)

        SaveSetting("Car Load", "settings", "lightint", txt)
        Render.Light.Remove()
        Render.Light = Render.ScnMgr.AddLightSceneNode(Render.ScnMgr.RootSceneNode, New IrrlichtNETCP.Vector3D(-4, 5, 0), New IrrlichtNETCP.Color(255, 200, 200, 200), GetSetting("Car Load", "settings", "lightint", 250), -1)


    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If Not Initialized Then Exit Sub
        SaveSetting("Car Load", "settings", "Confirm", CheckBox3.Checked.ToString)

    End Sub

    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged
        If Not Initialized Then Exit Sub
        If CheckBox4.CheckState = CheckState.Checked Then
            Me.TopMost = True
            RenderForm.TopMost = True
            Car_browser.TopMost = True
            Editor.TopMost = True
        ElseIf CheckBox4.CheckState = CheckState.Indeterminate Then
            Me.TopMost = False
            RenderForm.TopMost = True
            Car_browser.TopMost = False
            Editor.TopMost = False
        Else
            Me.TopMost = False
            RenderForm.TopMost = False
            Car_browser.TopMost = False
            Editor.TopMost = False
        End If
    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        Dim x As New IO.StreamWriter(New IO.FileStream(Environ("temp") & "\car_Load.log", IO.FileMode.Create))
        x.WriteLine("Environment:")
        x.WriteLine("OS:" & My.Computer.Info.OSFullName & "," & My.Computer.Info.OSPlatform)
        x.WriteLine("Mem:" & My.Computer.Info.TotalPhysicalMemory & ",vir:" & My.Computer.Info.TotalVirtualMemory)
        x.WriteLine("avMem:" & My.Computer.Info.AvailablePhysicalMemory & ",virAvMem:" & My.Computer.Info.AvailableVirtualMemory)
        x.WriteLine("Culture:" & My.Computer.Info.InstalledUICulture.ToString)
        x.WriteLine("Float:" & CSng(19.5))
        x.WriteLine("LastException:" & Render.LatestExc.Message)
        x.WriteLine("LastExceptionSrc:" & Render.LatestExc.Source)
        x.WriteLine("LastExceptionTrace:" & Render.LatestExc.StackTrace)
        x.WriteLine("------------------------------------------------------")
        x.WriteLine("Started:" & Now.Date.ToLongDateString & "  " & Now.Date.ToLongTimeString)

        For i = 0 To RenderForm.EventLog1.Entries.Count - 1
            If InStr(RenderForm.EventLog1.Entries(i).Message, "Car_Load", CompareMethod.Text) = 0 Then Continue For
            x.WriteLine("MESSAGE:" & RenderForm.EventLog1.Entries(i).Message)
            x.WriteLine("SOURCE:" & RenderForm.EventLog1.Entries(i).Source)
            x.WriteLine("TIME g:" & RenderForm.EventLog1.Entries(i).TimeGenerated.ToLongDateString & " " & RenderForm.EventLog1.Entries(i).TimeGenerated.ToLongTimeString)
            x.WriteLine("TIME c:" & RenderForm.EventLog1.Entries(i).TimeWritten.ToLongDateString & " " & RenderForm.EventLog1.Entries(i).TimeWritten.ToLongTimeString)



        Next

        x.Flush()
        x.Close()


    End Sub
End Class
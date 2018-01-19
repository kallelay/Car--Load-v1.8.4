Public Class Editor
    Dim mpos As Point


    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Dim form_show = True
    Private Sub Label1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label1.DoubleClick
        If form_show Then
            form_show = False
            Me.Height = Label1.Height
        Else
            form_show = True
            Me.Height = 325
        End If
    End Sub

    Private Sub Label1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label1.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += MousePosition - mpos
            mpos = MousePosition
        Else
            mpos = MousePosition
        End If
    End Sub
    Public LastCampos As IrrlichtNETCP.Vector3D
 
    Dim X_ As Single = 0
    Dim Y_ As Single = 0

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Render.alpha += 0.01
        Dim alpha = Render.alpha
        Render.cam.Position = New IrrlichtNETCP.Vector3D(Render.cam.Target.X + -Math.Cos(alpha) * Render.cte, Render.cam.Position.Y, Render.cam.Target.Z + Math.Sin(alpha) * Render.cte)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Car_browser.ListBox2_DoubleClick(sender, e)
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = False Then
            Timer2.Stop()
        Else
            CheckBox3.Checked = False
            Timer2.Start()


        End If

        If Settings.CheckBox18.Checked = True And (CheckBox2.Checked Or CheckBox1.Checked) Then
            SoundOn()
        Else
            SoundOff()
        End If

    End Sub


    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If Not Initialized Then Exit Sub
        If _car.Theory.wheel(0) Is Nothing Then Exit Sub

        If CheckBox1.Checked Then Exit Sub

        For i = 0 To 3
            If _car.Theory.wheel(i).modelNumber <> -1 And _car.Theory.wheel(i).IsPowered = True Then
                If _Wheel(i).ScnNode Is Nothing Then Exit Sub
                Try
                    _Wheel(i).ScnNode.Rotation += New IrrlichtNETCP.Vector3D(TrackBar1.Value, 0, 0)
                Catch ex As Exception

                End Try



            End If
        Next i
        '    Render.cam.Position = New IrrlichtNETCP.Vector3D(X_, 7.5, Y_)

    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged


        If CheckBox3.Checked = False Then
            Timer3.Stop()
        Else
            CheckBox2.Checked = False
            Timer3.Start()


        End If


        If Settings.CheckBox18.Checked = True And (CheckBox2.Checked Or CheckBox1.Checked) Then
            SoundOn()
        Else
            SoundOff()
        End If


    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick

        If Not Initialized Then Exit Sub

        If _car.Theory.wheel(0) Is Nothing Then Exit Sub

        If CheckBox1.Checked Then Exit Sub

        For i = 0 To 3
            If _car.Theory.wheel(i).modelNumber <> -1 And _car.Theory.wheel(i).IsTurnable = True Then
                _Wheel(i).ScnNode.Rotation += New IrrlichtNETCP.Vector3D(TrackBar1.Value, 0, 0)
            End If
        Next i
        '    Render.cam.Position = New IrrlichtNETCP.Vector3D(X_, 7.5, Y_)

    End Sub

    Private Sub Editor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Size = New Size(470, 325)


        'panels
        Panels.Add(Panel1)
        Panels.Add(Panel2)
        Panels.Add(Panel4)
        Panels.Add(Panel9)
        Panels.Add(Panel11)
        Panels.Add(Panel13)
        Panels.Add(Panel15)

        '  Panel15.Controls.Add(Panel18)
        '   Panel18.Top = -26
        '  Panel18.Left = 0

        Panel18.BringToFront()

        For Each lblx As Control In TabPage1.Controls '.Panel4.Controls
            Try
                If IsNumeric(lblx.Text) = False Then Exit Try
                Dim lbl = DirectCast(lblx, RadioButton)
                AddHandler lbl.MouseMove, AddressOf HoverShowFile
                AddHandler lbl.MouseClick, AddressOf EditSlot
                lbl.Text = lbl.TabIndex
            Catch ex As Exception

            End Try

        Next
    




    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = False Then
            Timer4.Stop()
        Else
            Timer4.Start()


        End If


        If Settings.CheckBox18.Checked = True And (CheckBox2.Checked Or CheckBox1.Checked) Then
            SoundOn()
        Else
            SoundOff()
        End If



    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        On Error Resume Next
        _axle(0).ScnNode.Rotation += New IrrlichtNETCP.Vector3D(0, 1, 0)

        If _car.Theory.wheel(0) Is Nothing Then Exit Sub

        For i = 0 To 3
            If _car.Theory.wheel(i).modelNumber <> -1 Then
                _Wheel(i).ScnNode.Rotation += New IrrlichtNETCP.Vector3D(TrackBar1.Value, 0, 0)
            End If
        Next i
        '    Render.cam.Position = New IrrlichtNETCP.Vector3D(X_, 7.5, Y_)

    End Sub

    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Readme_generator.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If _car.Path = "" Then Exit Sub
        Dialog1.Show() 'Dialog1 is parameters editor
      
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If _car.Path = "" Then Exit Sub
        Shell("explorer.exe " & Chr(34) & Replace(_car.Path, "\\", "\") & Chr(34), AppWinStyle.NormalFocus)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If _car.Theory.MainInfos.Tpage = "" Then Exit Sub
        Dim X As New Form
        X.Size = New Size(256, 256)
        X.StartPosition = FormStartPosition.CenterScreen

        X.BackgroundImage = Image.FromFile(RvPath & "\" & Replace(Replace(Replace(_car.Theory.MainInfos.Tpage, "'", ""), ",", "."), Chr(9), ""))
        X.BackgroundImageLayout = ImageLayout.Stretch
        X.Text = "Preview Bitmap"
        X.TopMost = True

        X.Show()



    End Sub

    Private Sub checkIt(ByRef Ctr2 As CheckBox)

        EnDis()
       
        '  If _car.Theory.Aerial.ModelNumber <> -1 Then _Aerial.ScnNode.Visible = CheckBox7.Checked
    End Sub
    Sub EnDis()



        If _car.DirName = "" Then Exit Sub

        Render.ShadowScnNode.Visible = Settings.CheckBox2.Checked
        Render.mShadowScnNode.Visible = Settings.CheckBox10.Checked

        If cBODY IsNot Nothing Then
            cBODY.ScnNode.Visible = CheckBox4.Checked

        End If

        If _car.Theory.wheel(0).modelNumber <> -1 And _Wheel(0) IsNot Nothing Then _Wheel(0).ScnNode.Visible = KdlCheckbox2.Checked
        If _car.Theory.wheel(1).modelNumber <> -1 And _Wheel(1) IsNot Nothing Then _Wheel(1).ScnNode.Visible = CheckBox5.Checked
        If _car.Theory.wheel(2).modelNumber <> -1 And _Wheel(2) IsNot Nothing Then _Wheel(2).ScnNode.Visible = KdlCheckbox3.Checked
        If _car.Theory.wheel(3).modelNumber <> -1 And _Wheel(3) IsNot Nothing Then _Wheel(3).ScnNode.Visible = KdlCheckbox1.Checked

        If _car.Theory.Axle(0).modelNumber <> -1 Then _axle(0).ScnNode.Visible = KdlCheckbox4.Checked
        If _car.Theory.Axle(1).modelNumber <> -1 Then _axle(1).ScnNode.Visible = CheckBox7.Checked
        If _car.Theory.Axle(2).modelNumber <> -1 Then _axle(2).ScnNode.Visible = KdlCheckbox5.Checked
        If _car.Theory.Axle(3).modelNumber <> -1 Then _axle(3).ScnNode.Visible = KdlCheckbox6.Checked

        If _car.Theory.Spring(0).modelNumber <> -1 And _Spring(0) IsNot Nothing Then _Spring(0).ScnNode.Visible = KdlCheckbox7.Checked
        If _car.Theory.Spring(1).modelNumber <> -1 And _Spring(1) IsNot Nothing Then _Spring(1).ScnNode.Visible = CheckBox6.Checked
        If _car.Theory.Spring(2).modelNumber <> -1 And _Spring(2) IsNot Nothing Then _Spring(2).ScnNode.Visible = KdlCheckbox8.Checked
        If _car.Theory.Spring(3).modelNumber <> -1 And _Spring(3) IsNot Nothing Then _Spring(3).ScnNode.Visible = KdlCheckbox9.Checked


        For n = 0 To 3
            On Error Resume Next


            ' If _car.Theory.wheel(n).modelNumber <> -1 And _Wheel(n) IsNot Nothing Then _Wheel(n).ScnNode.Visible = CheckBox5.Checked
            'If _car.Theory.Spring(n).modelNumber <> -1 And _Spring(n) IsNot Nothing Then _Spring(n).ScnNode.Visible = CheckBox6.Checked
            If _car.Theory.PIN(n).modelNumber <> -1 Then _Pin(n).ScnNode.Visible = CheckBox8.Checked

            '  If _car.Theory.Axle(n).modelNumber <> -1 Then _axle(n).ScnNode.Visible = CheckBox7.Checked
        Next n


        If _car.Theory.Spinner.modelNumber <> -1 Then _Spinner.ScnNode.Visible = CheckBox9.Checked
    End Sub

    Sub checkbox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged
        checkIt(CheckBox4)

    End Sub

    Sub CheckBox8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox8.CheckedChanged
        checkIt(CheckBox8)
    End Sub

    Sub CheckBox9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox9.CheckedChanged
        EnDis()
    End Sub

    Sub CheckBox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox5.CheckedChanged
        EnDis()
    End Sub

    Sub CheckBox6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox6.CheckedChanged
        EnDis()


    End Sub

    Sub CheckBox7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox7.CheckedChanged
        EnDis()
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        ShowPanel(Panel2)
    End Sub
    Sub ShowPanel(ByRef p As Panel)
        For Each Panel As Panel In Panels
            Panel.Hide()
        Next
        p.Location = Panel1.Location
        p.Show()

    End Sub
    Dim Panels As New List(Of Panel)



  
    Private Sub RadioButton12_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton12.CheckedChanged
        ShowPanel(Panel1)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FileCopy(_car.Path & "\parameters.txt", _car.Path & "\parameters_" & Replace(Now.ToShortTimeString, ":", "_") & ".txt")
        _car.Sing.SaveToFile(_car.Path & "\parameters.txt")
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        ShowPanel(Panel4)
    End Sub

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Sub HoverShowFile(ByVal sender, ByVal e)
        Dim bt As RadioButton = DirectCast(sender, RadioButton)
        Label8.Text = _car.Theory.MainInfos.Model(Int(bt.Text))
        RadioButton14.Text = bt.Text
        If Label9.BackColor <> Color.FromArgb(32, 32, 32) Then Label10.BackColor = Color.AliceBlue 'Then
    End Sub
    Sub EditSlot(ByVal sender, ByVal e)
        Dim v As New TextBox
        v.Font = Label8.Font
        v.Text = Label8.Text
        v.Location = Label8.Location - New Point(2, 2)
        v.Height = Label8.Height
        v.Width = 1000
        Label8.Hide()
        TabPage1.Controls.Add(v)
        v.BackColor = Color.Gray
        v.Tag = DirectCast(sender, RadioButton)
        v.Show()
        Label9.BackColor = Color.FromArgb(32, 32, 32)
        Label9.Text = DirectCast(sender, RadioButton).Text
        v.AutoCompleteSource = AutoCompleteSource.CustomSource
        v.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        v.AutoCompleteCustomSource = Car_browser.ListBox
        v.BringToFront()

        Label9.BringToFront()
        Label10.BringToFront()
        Label10.BackColor = Color.FromArgb(32, 32, 32)
        'Debugger.Break()
        AddHandler v.LostFocus, AddressOf SaveModel
        AddHandler v.KeyDown, AddressOf PressKey

        v.Focus()

    End Sub
    Sub PressKey(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            DirectCast(DirectCast(sender, TextBox).Tag, RadioButton).Focus()

        End If


    End Sub
    Sub SaveModel(ByVal sender, ByVal e)
        Dim old$ = _car.Theory.MainInfos.Model(DirectCast(DirectCast(sender, TextBox).Tag, RadioButton).Text)
        Dim new$ = DirectCast(sender, TextBox).Text


        If old$ <> new$ Then
            _car.Theory.MainInfos.Model(DirectCast(DirectCast(sender, TextBox).Tag, RadioButton).Text) = DirectCast(sender, TextBox).Text
            Car_browser.ReLoadOneCarFromInfo()
        End If

        DirectCast(sender, TextBox).Hide()
        Label8.Show()
        Label9.BackColor = Color.AliceBlue
        Label9.Text = ""
        Label10.BackColor = Color.AliceBlue



    End Sub
 
    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub Button7_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        _car.Sing.SaveToFile(_car.Path & "\parameters.txt")

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        _car.Sing.SaveToFile(_car.Path & "\parameters.txt")

        Button3_Click(sender, e)
    End Sub

    Private Sub Timer5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub CheckBox10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged

    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ImageList1.ColorDepth = ColorDepth.Depth8Bit
    End Sub

    Private Sub Timer5_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer5.Tick
        If Not Panel4.Visible Then Exit Sub
        If TabControl1.SelectedTab Is TabPage2 Then
            Label14.Left -= 1
            If Label14.Left < -Label14.Width Then
                Label14.Left = Panel4.Width
            End If
        End If
    End Sub

    Private Sub ListView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.Click
        If ListView1.SelectedItems.Count = 0 Then Exit Sub

        Select Case Car_browser.selected
            Case Car_browser.chosen.texture
                _car.Theory.MainInfos.Tpage = ListView1.SelectedItems(0).Text
            Case Car_browser.chosen.carbox
                _car.Theory.MainInfos.TCarBox = ListView1.SelectedItems(0).Text

        End Select

        Car_browser.SelectPic(Car_browser.chosen.none)

        Car_browser.ReLoadOneCarFromInfo()

        Car_browser.TexPrint()


    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub Panel6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel6.Click
        Car_browser.SelectPic(Car_browser.chosen.texture)
    End Sub


    Private Sub Panel3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel3.Click
        Car_browser.SelectPic(Car_browser.chosen.texture)
    End Sub

    Private Sub Panel3_Mousemove(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel3.MouseMove
        If Not Panel8.BackgroundImage Is Panel3.BackgroundImage Then Panel8.BackgroundImage = Panel3.BackgroundImage
    End Sub

    Private Sub Panel3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel3.MouseLeave
        Panel8.BackgroundImage = Nothing
    End Sub

    Private Sub Panel5_MouseMove(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel5.MouseMove
        If Not Panel8.BackgroundImage Is Panel5.BackgroundImage Then Panel8.BackgroundImage = Panel5.BackgroundImage
    End Sub

    Private Sub Panel5_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel5.MouseLeave
        Panel8.BackgroundImage = Nothing
    End Sub



    Private Sub Panel3_Paint_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Panel5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel5.Click
        Car_browser.SelectPic(Car_browser.chosen.carbox)
    End Sub

    Private Sub Panel5_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub Panel7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel7.Click
        Car_browser.SelectPic(Car_browser.chosen.carbox)
    End Sub

    Private Sub Panel7_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel7.Paint

    End Sub

    Private Sub TabPage2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage2.Click
        Car_browser.SelectPic(Car_browser.chosen.none)

    End Sub
    Dim Img As Bitmap

    Private Sub Timer6_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer6.Tick
        On Error Resume Next
        If Not Initialized Then Exit Sub

        Label15.Text = String.Format("~FPS: {0}", Render.VideoDriver.FPS)


        'paint mode?
        If CheckBox16.Checked Then

            Img = Image.FromFile(Replace(RvPath & "\" & _car.Theory.MainInfos.Tpage, ",", "."))

            cBODY.tex.Lock()

            For i = 0 To cBODY.tex.OriginalSize.dotNETSize.Width - 1
                For j = 0 To cBODY.tex.OriginalSize.dotNETSize.Height - 1
                    cBODY.tex.SetPixel(i, j, fromColorToIrrColor(Img.GetPixel(i, j)))
                Next

            Next i
            cBODY.tex.Unlock()
            Img.Dispose()
            cBODY.tex.Unlock()
            cBODY.tex.MakeColorKey(Render.VideoDriver, IrrlichtNETCP.Color.Black)
            cBODY.tex.RegenerateMipMapLevels()



            '      Dim a = Render.ScnMgr.MeshManipulator.CreateMeshUniquePrimitives(cBODY.mesh)
            '       a.SetMaterialFlag(IrrlichtNETCP.MaterialFlag.Wireframe, True)
            '     Dim b = Render.ScnMgr.AddMeshSceneNode(a, Render.ScnMgr.RootSceneNode, -1)
            '    b.SetMaterialFlag(IrrlichtNETCP.MaterialFlag.Lighting, False)




            'cBODY.mesh.GetMeshBuffer(0).Material.Texture1.RegenerateMipMapLevels()

            '  cBODY.mesh.GetMeshBuffer(0).Material.Texture1 = Render.VideoDriver.GetTexture(Replace(_car.Theory.MainInfos.Tpage, ",", "."))
            'cBODY.ScnNode.GetMaterial(0).Texture1 = Render.VideoDriver.GetTexture(Replace(_car.Theory.MainInfos.Tpage, ",", "."))




        End If

    End Sub

    Private Sub Panel3_Mousemove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel3.MouseMove

    End Sub

    Private Sub Panel5_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel5.MouseMove

    End Sub

    Private Sub RadioButton24_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton24.CheckedChanged
        ShowPanel(Panel9)
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        ColorDialog1.AllowFullOpen = True
        ColorDialog1.FullOpen = True
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Panel10.BackColor = ColorDialog1.Color
            _car.Theory.MainInfos.EnvRGB = New IrrlichtNETCP.Vector3D(ColorDialog1.Color.R, ColorDialog1.Color.G, ColorDialog1.Color.B)
        End If
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        _car.Theory.MainInfos.Name = TextBox1.Text

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FileCopy(_car.Path & "\parameters.txt", _car.Path & "\parameters_" & Replace(Now.ToShortTimeString, ":", "_") & ".txt")
        _car.Sing.SaveToFile(_car.Path & "\parameters.txt")
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        _car.Sing.SaveToFile(_car.Path & "\parameters.txt")

    End Sub

    Private Sub Button9_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        _car.Sing.SaveToFile(_car.Path & "\parameters.txt")

        Button3_Click(sender, e)
    End Sub

    Private Sub CheckBox11_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox11.CheckedChanged
        Car_browser.SaveFrontEnd()
    End Sub

    Private Sub CheckBox10_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox10.CheckedChanged
        Car_browser.SaveFrontEnd()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Car_browser.SaveFrontEnd()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        Car_browser.SaveFrontEnd()
    End Sub

    Private Sub Label21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label21.Click

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        Car_browser.SaveFrontEnd()
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        Car_browser.SaveFrontEnd()
    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged
        Car_browser.SaveFrontEnd()
    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged
        Car_browser.SaveFrontEnd()
    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged
        Car_browser.SaveFrontEnd()
    End Sub

    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox8.TextChanged
        Car_browser.SaveFrontEnd()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        For Each x As Control In GroupBox10.Controls
            Try
                DirectCast(x, TextBox).Text = 0
            Catch
            End Try
        Next
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        Car_browser.SaveFrontEnd()
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        CheckBox10.Checked = True
        CheckBox11.Checked = True
        ComboBox1.SelectedIndex = 1
        ComboBox2.SelectedIndex = 4
        ComboBox3.SelectedIndex = 1

        TextBox3.Text = _car.Theory.RealInfos.TopSpeed * 100
        TextBox4.Text = 2
        TextBox5.Text = "1.5"
        TextBox6.Text = "50"
        TextBox7.Text = "0"
        TextBox8.Text = 0.5




    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        With Me
            .CheckBox10.Checked = Car_browser.Car_As_Loaded.Theory.MainInfos.BESTTIME
            .CheckBox11.Checked = Car_browser.Car_As_Loaded.Theory.MainInfos.SELECTABLE
            .ComboBox1.SelectedIndex = Car_browser.Car_As_Loaded.Theory.MainInfos.obtain + 1
            .ComboBox2.SelectedIndex = Car_browser.Car_As_Loaded.Theory.MainInfos.Rating '+ 1
            .ComboBox3.SelectedIndex = Car_browser.Car_As_Loaded.Theory.MainInfos.car_class '+ 1

            .TextBox3.Text = Car_browser.Car_As_Loaded.Theory.MainInfos.TopEnd
            .TextBox4.Text = Car_browser.Car_As_Loaded.Theory.MainInfos.Acceleration
            .TextBox5.Text = Car_browser.Car_As_Loaded.Theory.MainInfos.Weight
            .TextBox6.Text = Car_browser.Car_As_Loaded.Theory.MainInfos.Handling
            .TextBox7.Text = Car_browser.Car_As_Loaded.Theory.MainInfos.Trans

            Car_browser.Car_As_Loaded.isLoading = False

            .TextBox8.Text = Car_browser.Car_As_Loaded.Theory.MainInfos.MaxRev

        End With
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click


        Try
            If YesNo.Message("are you sure about resetting the whole car?") = Windows.Forms.DialogResult.Yes Then
                _car.Theory = Car_browser.Car_As_Loaded.Theory.Clone

                Car_browser.ReLoadOneCarInfo()
            End If

        Catch ex As Exception
            message.Message("Error, no init car is found")
        End Try


    End Sub

    Private Sub CheckBox12_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox12.CheckedChanged, CheckBox21.CheckedChanged
        If CheckBox12.Checked Then
            nHelp.Active = True
            pNote.Active = True
        Else
            nHelp.Active = False
            pNote.Active = False
        End If
    End Sub

    Private Sub nHelp_Draw(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawToolTipEventArgs) Handles nHelp.Draw
        e.DrawBackground()
        e.Graphics.DrawRectangle(Pens.LightSkyBlue, e.Bounds)
        e.Graphics.Dispose()

        e.DrawBorder()
        'e.Font = Me.Font
        e.DrawText(TextFormatFlags.Internal)
    End Sub

    
    Private Sub RadioButton25_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton25.CheckedChanged
        ShowPanel(Panel11)
    End Sub

    Private Sub TextBox9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox9.TextChanged
        Car_browser.SaveHandle()
    End Sub

    Private Sub TextBox10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox10.TextChanged
        Car_browser.SaveHandle()
    End Sub

    Private Sub TextBox11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox11.TextChanged
        Car_browser.SaveHandle()
    End Sub

    Private Sub TextBox12_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox12.TextChanged
        Car_browser.SaveHandle()
        Try
            Dim x As Single = If(CBool(CSng(2.5).ToString.IndexOf(",") > 0), CStr(TextBox12.Text), CStr(Replace(TextBox12.Text, ".", ",")))
            TrackBar2.Value = Math.Min(200, Int(x))



            If Math.Min(x, 200.0) <= 0 Then
                Panel12.BackColor = Color.Black
            ElseIf Math.Min(x, 200.0) > 0 And x <= 40 Then
                Panel12.BackColor = Color.FromArgb(0, 255 - (x / 40) * 128, 0)
            ElseIf Math.Min(x, 200.0) > 40 And x <= 45 Then
                Panel12.BackColor = Color.FromArgb(((x - 40) / 10) * 255, 128, 0)
            ElseIf Math.Min(x, 200.0) > 45 And x <= 70 Then
                Panel12.BackColor = Color.FromArgb(128, 255 - ((x - 40) * 255 / 30), 0)
            Else
                Panel12.BackColor = Color.Black
            End If


        Catch ex As Exception
            Panel12.BackColor = Color.Black
        End Try
    End Sub

    Private Sub TextBox13_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox13.TextChanged
        Car_browser.SaveHandle()
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        FileCopy(_car.Path & "\parameters.txt", _car.Path & "\parameters_" & Replace(Now.ToShortTimeString, ":", "_") & ".txt")
        Car_browser.SaveBody()
        Car_browser.SaveFrontEnd()
        Car_browser.SaveHandle()


        _car.Sing.SaveToFile(_car.Path & "\parameters.txt")
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        _car.Sing.SaveToFile(_car.Path & "\parameters.txt")
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        _car.Sing.SaveToFile(_car.Path & "\parameters.txt")

        Button3_Click(sender, e)
    End Sub

    Private Sub TrackBar2_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar2.Scroll
        TextBox12.Text = TrackBar2.Value
    End Sub
    Sub LockAllForms()
        'Settings.Enabled = False
        Car_browser.Enabled = False
        '  Me.Enabled = False
    End Sub
   
    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        LockAllForms()
        Current_Editing_Mode = CurEdMod.CoM
        Tablepad.doLoad()
        Tablepad.Show()
        m.Visible = True

    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        LockAllForms()
        Current_Editing_Mode = CurEdMod.Weapon
        Tablepad.doLoad()
        Tablepad.Show()
        m.Visible = True
    End Sub

    Private Sub Panel13_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel13.MouseMove

    End Sub



    Private Sub Panel13_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel13.Paint

    End Sub

    Private Sub NumericUpDown1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown1.ValueChanged
        If Car_browser.Printing Then Exit Sub
        Car_browser.SaveBody()
        Car_browser.ReLoadOneCarFromInfo()
    End Sub

    Private Sub TextBox14_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox14.TextChanged
        Car_browser.SaveBody()
    End Sub

    Private Sub TextBox15_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox15.TextChanged
        Car_browser.SaveBody()
    End Sub

    Private Sub TextBox17_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox17.TextChanged
        Car_browser.SaveBody()
    End Sub

    Private Sub TextBox16_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox16.TextChanged
       Car_browser.SaveBody()
    End Sub

    Private Sub TextBox19_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox19.TextChanged
        Car_browser.SaveBody()
    End Sub

    Private Sub TextBox18_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox18.TextChanged
        Car_browser.SaveBody()
    End Sub

    Private Sub TextBox20_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox20.TextChanged
        Car_browser.SaveBody()
    End Sub

    Private Sub TextBox21_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox21.TextChanged
        Car_browser.SaveBody()
    End Sub

    Private Sub TextBox22_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox22.TextChanged
        Car_browser.SaveBody()
    End Sub

    Private Sub TextBox23_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox23.TextChanged
        Car_browser.SaveBody()
    End Sub

    Private Sub TextBox25_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox25.TextChanged
        Car_browser.SaveBody()
    End Sub

    Private Sub TextBox28_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox28.TextChanged
        Car_browser.SaveBody()
    End Sub

    Private Sub TextBox27_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox27.TextChanged
        Car_browser.SaveBody()
    End Sub

    Private Sub TextBox26_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox26.TextChanged
        Car_browser.SaveBody()
    End Sub

    Private Sub TextBox31_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox31.TextChanged
        Car_browser.SaveBody()
    End Sub

    Private Sub TextBox30_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox30.TextChanged
        Car_browser.SaveBody()
    End Sub

    Private Sub TextBox29_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox29.TextChanged
        Car_browser.SaveBody()
    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        LockAllForms()
        Current_Editing_Mode = CurEdMod.Body
        Tablepad.doLoad()
        Tablepad.Show()
        m.Visible = True
    End Sub

    Private Sub RadioButton26_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton26.CheckedChanged
        ShowPanel(Panel13)
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click

        prmShade.Show()




    End Sub

    Private Sub Button6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Process.Start(PRM_Path, String.Format("double ""{0}""", RvPath & "\" & _car.Theory.MainInfos.Model(_car.Theory.Body.modelNumber)))
        Reloader.Show()
    End Sub

    Private Sub Button7_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Process.Start(PRM_Path, String.Format("single ""{0}""", RvPath & "\" & _car.Theory.MainInfos.Model(_car.Theory.Body.modelNumber)))
        Reloader.Show()
    End Sub

    Private Sub Button8_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        WHEELMODE = False
        prmOpacity.Show()

    End Sub

    Private Sub Button9_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Process.Start(rvCenter_Path, """" & _car.Theory.MainInfos.Model(_car.Theory.Body.modelNumber) & """")

    End Sub

    Private Sub Button27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button27.Click
        prmGUI.Stat = prmGUI.Xmod.Body
        prmGUI.Show()



    End Sub

    Private Sub Button10_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'HACK :this
        ' Dim i = selectedI
        SelectionMode = True
        selectedI += 3


    End Sub

    Private Sub RadioButton27_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton27.CheckedChanged
        ShowPanel(Panel15)
    End Sub

    Private Sub Button30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button30.Click
        Try
            TextBox45.Text = Math.Abs(_Wheel(Label51.Text).BoundingBox.minY / Render.ZoomFactor - _Wheel(Label51.Text).BoundingBox.maxY / Render.ZoomFactor) / 2
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button31.Click
        Dim mMax, mMin As Single
        mMax = Integer.MinValue
        mMin = Integer.MaxValue
        For i = 0 To _Wheel(Label51.Text).MyModel.vertnum - 1
            If Math.Abs(_Wheel(Label51.Text).MyModel.vexl(i).Position.Y - _Wheel(Label51.Text).BoundingBox.minY) < 0.1 Then
                If mMax < _Wheel(Label51.Text).MyModel.vexl(i).Position.X Then
                    mMax = _Wheel(Label51.Text).MyModel.vexl(i).Position.X
                End If
                If mMin > _Wheel(Label51.Text).MyModel.vexl(i).Position.X Then
                    mMin = _Wheel(Label51.Text).MyModel.vexl(i).Position.X
                End If
            End If

        Next

        TextBox32.Text = Math.Abs(mMax - mMin) / Render.ZoomFactor







    End Sub



    Private Sub RadioButton29_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton29.CheckedChanged

        If RadioButton29.Checked = False Then Exit Sub


        Label51.Text = 0
        Car_browser.PrintWheel(0)
    End Sub

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim X As New ColorDialog
        If YesNo.Message("Do you want to use 'y'? " & vbNewLine & " When set to 'y', the shading will be shaded according to the current color (use bright colors then!)" & vbNewLine & " If 'n', the exact color values will be used.") = Windows.Forms.DialogResult.Yes Then
            X.Color = Color.FromArgb(200, 200, 200)
            If X.ShowDialog = Windows.Forms.DialogResult.OK Then
                Process.Start(rvShade_Path, String.Format("""{0}"" y {1} {2} {3}", RvPath & _car.Theory.MainInfos.Model(_car.Theory.wheel(Label51.Text).modelNumber), X.Color.R, X.Color.G, X.Color.B))

            End If

        Else
            X.Color = Color.FromArgb(200, 200, 200)
            If X.ShowDialog = Windows.Forms.DialogResult.OK Then
                Process.Start(rvShade_Path, String.Format("""{0}"" n {1} {2} {3}", RvPath & _car.Theory.MainInfos.Model(_car.Theory.wheel(Label51.Text).modelNumber), X.Color.R, X.Color.G, X.Color.B))

            End If

        End If

    End Sub

    Private Sub Button10_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        WHEELMODE = True
        prmOpacity.Show()
   
    End Sub

    Private Sub Button11_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Process.Start(rvCenter_Path, """" & _car.Theory.MainInfos.Model(_car.Theory.wheel(Label51.Text).modelNumber) & """")

    End Sub

    Private Sub Button28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button28.Click
        Process.Start(PRM_Path, String.Format("double ""{0}""", RvPath & "\" & _car.Theory.MainInfos.Model(_car.Theory.wheel(Label51.Text).modelNumber)))
        Reloader.Show()
    End Sub

    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button25.Click
        If YesNo.Message("Do you want to resize the whole mesh (YES)    or X alone, Y alone and Z alone (No)?") = Windows.Forms.DialogResult.Yes Then
            Dim res$ = InputBox("Please enter a value of scale" & vbNewLine & "IE: nfs4: 0.8, double: 2, half: 0.5, tiny: 0.001, 3Ds: 3.33")
            If CSng(res) <> 0 Then
                Process.Start(PRM_Path, String.Format("scale ""{0}"" {1}", RvPath & _car.Theory.MainInfos.Model(_car.Theory.wheel(Label51.Text).modelNumber), res))
            Else
                message.Message("error, something has gone wrong and the mesh wasn't scaled")
            End If


        Else
            Dim res$ = InputBox("Please enter X Y Z [ex: 1.0 2 0.5]" & vbNewLine & "IE: nfs4: 0.8, double: 2, half: 0.5, tiny: 0.001, 3Ds: 3.33")

            Process.Start(PRM_Path, String.Format("scale ""{0}"" {1}", RvPath & _car.Theory.MainInfos.Model(_car.Theory.wheel(Label51.Text).modelNumber), res))

        End If

    End Sub

    Private Sub Button26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button26.Click
        Process.Start(PRM_Path, String.Format("single ""{0}""", RvPath & "\" & _car.Theory.MainInfos.Model(_car.Theory.wheel(Label51.Text).modelNumber)))
        Reloader.Show()
    End Sub



    Private Sub TextBox47_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox47.TextChanged
        Car_browser.SaveWheel(Label51.Text)
    End Sub
    Private Sub TextBox46_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox46.TextChanged
        Car_browser.SaveWheel(Label51.Text)
    End Sub



    Private Sub TextBox45_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox45.TextChanged
        Car_browser.SaveWheel(Label51.Text)
    End Sub
    Private Sub TextBox42_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox42.TextChanged
        Car_browser.SaveWheel(Label51.Text)
    End Sub
    Private Sub TextBox32_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox32.TextChanged
        Car_browser.SaveWheel(Label51.Text)
    End Sub
    Private Sub TextBox41_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox41.TextChanged
        Car_browser.SaveWheel(Label51.Text)
    End Sub
    Private Sub TextBox40_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox40.TextChanged
        Car_browser.SaveWheel(Label51.Text)
    End Sub
    Private Sub TextBox33_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox33.TextChanged
        Car_browser.SaveWheel(Label51.Text)
    End Sub
    Private Sub TextBox24_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox24.TextChanged
        Car_browser.SaveWheel(Label51.Text)
    End Sub
    Private Sub TextBox44_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox44.TextChanged
        Car_browser.SaveWheel(Label51.Text)
    End Sub

    Private Sub CheckBox14_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox14.CheckedChanged
        Car_browser.SaveWheel(Label51.Text)
    End Sub

    Private Sub CheckBox13_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox13.CheckedChanged

        Select Case CheckBox13.Checked
            Case True
                _Wheel(Label51.Text).ScnNode.Visible = True
            Case False
                _Wheel(Label51.Text).ScnNode.Visible = False
        End Select


        Car_browser.SaveWheel(Label51.Text)
    End Sub

    Private Sub CheckBox15_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox15.CheckedChanged
        Car_browser.SaveWheel(Label51.Text)
    End Sub

    Private Sub NumericUpDown2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown2.ValueChanged
        If Car_browser.Printing Then Exit Sub
        Car_browser.SaveWheel(Label51.Text)
        Car_browser.ReLoadOneCarFromInfo()
    End Sub

    Private Sub CheckBox16_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox16.CheckedChanged
        KdlCheckbox10.Checked = True
    End Sub

    Private Sub RadioButton30_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton30.CheckedChanged
        If RadioButton30.Checked = False Then Exit Sub
        Label51.Text = 1
        Car_browser.PrintWheel(1)
    End Sub

    Private Sub RadioButton31_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton31.CheckedChanged
        If RadioButton31.Checked = False Then Exit Sub
        Label51.Text = 2
        Car_browser.PrintWheel(2)
    End Sub

    Private Sub RadioButton32_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton32.CheckedChanged
        If RadioButton32.Checked = False Then Exit Sub
        Label51.Text = 3
        Car_browser.PrintWheel(3)
    End Sub



    Private Sub Panel18_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel18.Paint

    End Sub






    Private Sub TrackBar1_Scroll_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar1.Scroll
        If Settings.CheckBox18.Checked Then PitchSound()
    End Sub

    Private Sub Button35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button35.Click
        Car_browser.SaveWheel(0, False)
        Car_browser.SaveWheel(1, False)
        Car_browser.SaveWheel(2, False)
        Car_browser.SaveWheel(3, False)
    End Sub

    Private Sub Button33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button29.Click
        LockAllForms()
        Select Case Label51.Text
            Case 0
                Current_Editing_Mode = CurEdMod.wheel0_0
            Case 1
                Current_Editing_Mode = CurEdMod.wheel1_0
            Case 2
                Current_Editing_Mode = CurEdMod.wheel2_0
            Case 3
                Current_Editing_Mode = CurEdMod.wheel3_0
        End Select

        Tablepad.doLoad()
        Tablepad.Show()
        m.Visible = True
    End Sub

    Private Sub RadioButton12_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles RadioButton12.MouseMove
        If CheckBox21.Checked Then DirectCast(sender, RadioButton).Checked = True
    End Sub
    Private Sub RadioButton1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles RadioButton1.MouseMove
        If CheckBox21.Checked Then DirectCast(sender, RadioButton).Checked = True
    End Sub
    Private Sub RadioButton2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles RadioButton2.MouseMove
        If CheckBox21.Checked Then DirectCast(sender, RadioButton).Checked = True
    End Sub
    Private Sub RadioButton24_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles RadioButton24.MouseMove
        If CheckBox21.Checked Then DirectCast(sender, RadioButton).Checked = True
    End Sub
    Private Sub RadioButton25_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles RadioButton25.MouseMove
        If CheckBox21.Checked Then DirectCast(sender, RadioButton).Checked = True
    End Sub
    Private Sub RadioButton26_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles RadioButton26.MouseMove
        If CheckBox21.Checked Then DirectCast(sender, RadioButton).Checked = True
    End Sub
    Private Sub RadioButton27_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles RadioButton27.MouseMove
        If CheckBox21.Checked Then DirectCast(sender, RadioButton).Checked = True
    End Sub
    Private Sub RadioButton28_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles RadioButton28.MouseMove
        If CheckBox21.Checked Then DirectCast(sender, RadioButton).Checked = True
    End Sub
    Private Sub RadioButton34_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles RadioButton34.MouseMove
        If CheckBox21.Checked Then DirectCast(sender, RadioButton).Checked = True
    End Sub
    Private Sub RadioButton33_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles RadioButton33.MouseMove
        If CheckBox21.Checked Then DirectCast(sender, RadioButton).Checked = True
    End Sub

    Private Sub Button24_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click

        AutoShader.Show()
        AutoShader.TextBox2.Text = cBODY.Directory & "\" & cBODY.FileName

    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Sub KdlCheckbox10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KdlCheckbox10.CheckedChanged
        If Not Initialized Then Exit Sub

        If cBODY Is Nothing Then
            Tip.fShow("error, no cars loaded")
            Exit Sub
        End If

        If KdlCheckbox10.Checked Then

            If Not IO.File.Exists(Replace(RvPath & "\" & _car.Theory.MainInfos.Tpage, ",", ".")) Then
                Tip.fShow("Error, bitmap file not found")
                Exit Sub
            End If
            Dim Img As Bitmap = Image.FromFile(Replace(RvPath & "\" & _car.Theory.MainInfos.Tpage, ",", "."))

            cBODY.tex.Lock()

            For i = 0 To cBODY.tex.OriginalSize.dotNETSize.Width - 1
                For j = 0 To cBODY.tex.OriginalSize.dotNETSize.Height - 1
                    cBODY.tex.SetPixel(i, j, fromColorToIrrColor(Img.GetPixel(i, j)))
                Next

            Next i
            Img.Dispose()
            cBODY.tex.Unlock()
            cBODY.tex.MakeColorKey(Render.VideoDriver, IrrlichtNETCP.Color.Black)
            cBODY.tex.RegenerateMipMapLevels()


        Else
            For i = 0 To cBODY.tex.OriginalSize.dotNETSize.Width - 1
                For j = 0 To cBODY.tex.OriginalSize.dotNETSize.Height - 1
                    cBODY.tex.SetPixel(i, j, IrrlichtNETCP.Color.White)
                Next

            Next i
            cBODY.tex.RegenerateMipMapLevels()
        End If
    End Sub

    Private Sub KdlCheckbox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KdlCheckbox1.CheckedChanged
        EnDis()
    End Sub

    Private Sub KdlCheckbox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KdlCheckbox3.CheckedChanged
        EnDis()
    End Sub

    Private Sub KdlCheckbox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KdlCheckbox2.CheckedChanged
        EnDis()
    End Sub

    Private Sub KdlCheckbox8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KdlCheckbox8.CheckedChanged
        EnDis()

    End Sub

    Public CageMesh As IrrlichtNETCP.SceneNode
    Private Sub Button33_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button33.Click
        If cBODY Is Nothing Then Exit Sub
        Dim a = Render.ScnMgr.MeshManipulator.CreateMeshUniquePrimitives(cBODY.mesh)
        Render.ScnMgr.MeshManipulator.SetVertexColors(a, IrrlichtNETCP.Color.Blue)
        a.SetMaterialFlag(IrrlichtNETCP.MaterialFlag.Wireframe, True)

        CageMesh = Render.ScnMgr.AddMeshSceneNode(a, Render.ScnMgr.RootSceneNode, -1)
        CageMesh.SetMaterialFlag(IrrlichtNETCP.MaterialFlag.Lighting, False)
        CageMesh.GetMaterial(0).Texture1 = Nothing
        CageMesh.Position = _car.Theory.Body.Offset


    End Sub

    Private Sub KdlCheckbox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KdlCheckbox4.CheckedChanged
        EnDis()
    End Sub

    Private Sub KdlCheckbox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KdlCheckbox5.CheckedChanged
        EnDis()
    End Sub

    Private Sub KdlCheckbox6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KdlCheckbox6.CheckedChanged
        EnDis()
    End Sub

    Private Sub KdlCheckbox7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KdlCheckbox7.CheckedChanged
        EnDis()
    End Sub

    Private Sub KdlCheckbox9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KdlCheckbox9.CheckedChanged
        EnDis()
    End Sub

    Private Sub CheckBox17_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox17.CheckedChanged

    End Sub

    Private Sub Button36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button36.Click
        KdlCheckbox1.Checked = True
        KdlCheckbox2.Checked = True
        KdlCheckbox3.Checked = True
        CheckBox5.Checked = True
    End Sub

    Private Sub Button43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button43.Click
        KdlCheckbox1.Checked = False
        KdlCheckbox2.Checked = False
        KdlCheckbox3.Checked = False
        CheckBox5.Checked = False
    End Sub

    Private Sub Button37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button37.Click
        KdlCheckbox4.Checked = True
        KdlCheckbox5.Checked = True
        KdlCheckbox6.Checked = True
        CheckBox7.Checked = True
    End Sub

    Private Sub Button42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button42.Click
        KdlCheckbox4.Checked = False
        KdlCheckbox5.Checked = False
        KdlCheckbox6.Checked = False
        CheckBox7.Checked = False
    End Sub

    Private Sub Button38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button38.Click
        KdlCheckbox7.Checked = True
        KdlCheckbox8.Checked = True
        KdlCheckbox9.Checked = True
        CheckBox6.Checked = True
    End Sub

    Private Sub Button41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button41.Click
        KdlCheckbox7.Checked = False
        KdlCheckbox8.Checked = False
        KdlCheckbox9.Checked = False
        CheckBox6.Checked = False
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox4.SelectedIndexChanged
       

    End Sub

    Private Sub ComboBox4_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox4.TextChanged
        If Not Initialized Then Exit Sub

        _car.Theory.MainInfos.CollFile = ComboBox4.Text
        If IO.File.Exists(RvPath & "\" & ComboBox4.Text) Then
            Panel14.BackColor = Color.Lime
        Else
            Panel14.BackColor = Color.FromArgb(255, 220, 220)
        End If
    End Sub
End Class



Public Module Conv
    Function fromIrrColorToColor(ByVal irrColor As IrrlichtNETCP.Color) As System.Drawing.Color
        Return System.Drawing.Color.FromArgb(irrColor.A, irrColor.R, irrColor.G, irrColor.B)
    End Function
    Function fromColorToIrrColor(ByVal c As System.Drawing.Color) As IrrlichtNETCP.Color
        Return New IrrlichtNETCP.Color(255, c.R, c.G, c.B)
    End Function

End Module

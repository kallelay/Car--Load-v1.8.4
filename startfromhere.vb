Imports System.Windows.Forms
Imports IrrlichtNETCP
Imports Car_Load.Upperclass


Public Class startfromhere
    Public ReflectionM As Texture
    Public ScreenSaverMode = False
    Private Sub startfromhere_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
      
    End Sub
    Sub Progress(ByVal n)
        'Label3.Text = Format((n / 18) * 100, "0#.##") & "%"
        '   Label2.Text = Label3.Text
        Label2.Width = (n / 18) * Label3.Width
        Label6.Width = Label2.Width - 1
        Label6.Height = 9
        Label6.Location = Label2.Location + New Point(0, 0)

    End Sub
    Dim n = 0
    Private Sub startfromhere_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label4.Text = "v" & Split(CLversion, "v")(1)
        RountIt(Me)


        If InStr(Command, "/help", CompareMethod.Text) > 0 Then
            YesNo.Text = "Help"
            YesNo.Size = New Size(521, 232)
            YesNo.Message("You requested help " & vbNewLine & _
                   Chr(9) & "normal run: car_load /switch -renderswitch" & vbNewLine & _
            vbNewLine & _
            "Possible arguments:" & vbNewLine & _
             Chr(9) & "/config : Reconfiguring the directory" & vbNewLine & _
             Chr(9) & "/ss     : Screensaver mode" & vbNewLine & _
            vbNewLine & _
             Chr(9) & "/load(CAR INDEX)     : load a car" & vbNewLine & _
             Chr(9) & "/loadlast          : load latest car" & vbNewLine & _
           vbNewLine & _
             "Possible Render switches" & vbNewLine & _
             Chr(9) & "-dx8 : DirectX 8 mode" & vbNewLine & _
             Chr(9) & "-dx9 : DirectX 9 mode (default)" & vbNewLine & _
             Chr(9) & "-gl  : OpenGL mode" & vbNewLine & _
             Chr(9) & "-sw  : Software mode" & vbNewLine & _
             Chr(9) & "-sw2 : Another Software mode" & vbNewLine)
            End
        End If

        YesNo.TextBox1.Hide()
        Label1.Text = "Loading in progress"

        n += 1
        Progress(n)
        '255, 128, 192, 255
      
        Dim AeroOn As Boolean = False
        Dim StartByLoading As Boolean = False
        Application.DoEvents()
        Me.Show()
        Label1.Text = "Checking arguments"
        n += 1
        Progress(n)
        Application.DoEvents()
        If InStr(Command, "/config", CompareMethod.Text) > 0 Then
            Label1.Text = "Configuring Directory mode"
            Application.DoEvents()
            If Directory.ShowDialog() <> Windows.Forms.DialogResult.OK Then End
            Application.DoEvents()
            Me.Show()

        End If
        Application.DoEvents()

        Dim index As Integer
        If InStr(Command, "/loadlast", CompareMethod.Text) > 0 Then
            StartByLoading = True

            index = GetSetting("Car Load", "settings", "index", "0")
        End If

        If InStr(Command, "/load", CompareMethod.Text) > 0 And InStr(Command, "/loadlast", CompareMethod.Text) = 0 Then
            StartByLoading = True
            Try
                index = Split(Split(Command, "(")(1), ")")(0)

            Catch ex As Exception
                index = 0
            End Try

        End If


        If InStr(Command, "/aero", CompareMethod.Text) > 0 Then
            AeroOn = True
        End If
        Label1.Text = "Extracting RVL logo"
        n += 1
        Progress(n)
        Application.DoEvents()
        If Not Unix Then
            My.Resources.rvlive.Save(Environ("temp") & "\rvl.png", Imaging.ImageFormat.Png)

        Else
            My.Resources.rvlive.Save("rvl.png") ', Imaging.ImageFormat.Png)
        End If

        Dim cmd As String = ""

        Label1.Text = "Getting settings"
        n += 1
        Progress(n)

        If GetSetting("Car Load", "settings", "lastrnd") <> "" Then
            cmd = GetSetting("Car Load", "settings", "lastrnd") '<> ""
        End If

        Settings.TrackBar3.Value = GetSetting("Car Load", "settings", "modex", 1)

        With Settings

            .CheckBox10.Checked = GetSetting("Car Load", "settings", "floor", True)
            .CheckBox1.Checked = GetSetting("Car Load", "settings", "light", False)
            .CheckBox2.Checked = GetSetting("Car Load", "settings", "shadow", False)
            .CheckBox13.Checked = GetSetting("Car Load", "settings", "name", True)
            .CheckBox9.Checked = GetSetting("Car Load", "settings", "logo", True)
            .CheckBox14.Checked = GetSetting("Car Load", "settings", "gradient", True)
        End With


        Application.DoEvents()

        If Len(Command()) > 2 Then cmd = Command()

        If InStr(Command, "/ss") > 0 Then
            ScreenSaverMode = True
            cmd = Replace(cmd, "/ss", "")

        End If
        Application.DoEvents()
        Label1.Text = "Checking arguments"
        n += 1
        Progress(n)
        If cmd <> "" Then
            If InStr(cmd, "-") > 0 Then
                Select Case Replace(Split(Split(LCase(cmd) & " ", "-")(1), " ")(0), " ", "")
                    Case Is = "dx8"
                        Render.DvType = DriverType.Direct3D8
                        Settings.RadioButton9.Checked = True
                    Case Is = "dx9"
                        Render.DvType = DriverType.Direct3D9
                        Settings.RadioButton10.Checked = True
                    Case Is = "gl"
                        Render.DvType = DriverType.OpenGL
                        Settings.RadioButton7.Checked = True
                    Case Is = "sw"
                        Render.DvType = DriverType.Software
                        Settings.RadioButton8.Checked = True
                    Case Is = "sw2"
                        Render.DvType = DriverType.Software2
                        Settings.RadioButton6.Checked = True
                End Select
            End If
        End If


        Label1.Text = "Checking directories"
        n += 1
        Progress(n)
        Application.DoEvents()
        
        n += 1
        Progress(n)
        Application.DoEvents()
       
        Application.DoEvents()

        Label1.Text = "Extracting shadow.png"
        If IO.File.Exists(My.Computer.FileSystem.SpecialDirectories.Temp & "\shadow.png") Then IO.File.Delete(My.Computer.FileSystem.SpecialDirectories.Temp & "\shadow.png")
        My.Resources.cshadow.Save(My.Computer.FileSystem.SpecialDirectories.Temp & "\shadow.png", Drawing.Imaging.ImageFormat.Png)
        If IO.File.Exists(My.Computer.FileSystem.SpecialDirectories.Temp & "\mshadow.png") Then IO.File.Delete(My.Computer.FileSystem.SpecialDirectories.Temp & "\mshadow.png")
        My.Resources.revolt.Save(My.Computer.FileSystem.SpecialDirectories.Temp & "\mshadow.png", Drawing.Imaging.ImageFormat.Png)



        Application.DoEvents()

        Label1.Text = "Checking Re-Volt directory"
        n += 1
        Progress(n)
        'Rv Path
        If RvPath = "" Then
            If GetSetting("Car Load", "settings", "dir", "") = "" Then
                If Directory.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    RvPath = Directory.TextBox7.Text
                    SaveSetting("Car Load", "settings", "dir", RvPath)
                Else
                    End
                End If
            End If



            Application.DoEvents()
       End If

        'Checking if RVPATH exists
        If IO.Directory.Exists(GetSetting("Car Load", "settings", "dir", "")) = False Then

            message.Message(GetSetting("Car Load", "settings", "dir", "") & " doesn't exist DOT")
            If Directory.ShowDialog() = Windows.Forms.DialogResult.OK Then
                RvPath = Directory.TextBox7.Text
                SaveSetting("Car Load", "settings", "dir", RvPath)
            Else
                End
            End If


        End If

        RvPath = GetSetting("Car Load", "settings", "dir", "")

        'new timer (For opacity)

        Application.DoEvents()


        Label1.Text = "Loading Default color"
        Render._cc = New Color(255, GetSetting("Car Load", "settings", "CC.R", 128), GetSetting("Car Load", "settings", "CC.G", 192), GetSetting("Car Load", "settings", "CC.B", 255))
        Settings.Panel1.BackColor = fromIrrColorToColor(Render._cc)

        Label1.Text = "Reloader's calc."
        With Settings
            .Label12.Text = If(.NumericUpDown2.Value >= 3600, .NumericUpDown2.Value \ 3600 & " hours and ", "") & If(.NumericUpDown2.Value >= 60, (.NumericUpDown2.Value Mod 3600) \ 60 & " minutes and ", "") & .NumericUpDown2.Value Mod 60 & " seconds."

        End With


        Label1.Text = "Checking OS"
        If InStr(Environment.OSVersion.ToString, "Unix", CompareMethod.Text) > 0 Then
            Unix = True
        End If
   

        Application.DoEvents()
        Label1.Text = "Initializing opacity"
        n += 1
        Progress(n)
        tim.Interval = 1
        AddHandler tim.Tick, AddressOf opacityDo
        tim.Start()

        If AeroOn Then
            Label1.Text = "Initializing Aero mode"
            Application.DoEvents()
            If Environment.OSVersion.Version.Major >= 6 Then
                Dim v As New Form
                v.Location = New Point(0, 0)
                v.Size = Screen.PrimaryScreen.Bounds.Size
                v.BackColor = Drawing.Color.Navy
                v.FormBorderStyle = Windows.Forms.FormBorderStyle.None
                v.Show()


                Aero(Car_browser)
                Settings.TrackBar2.Value = 100
                Car_browser.Text = "Car Browser"
                Car_browser.BackColor = Drawing.Color.FromArgb(160, 180, 200)
                Car_browser.FormBorderStyle = Windows.Forms.FormBorderStyle.Fixed3D



                '  Aero(RenderForm)
                ' RenderForm.BackColor = Drawing.Color.Black
                ' RenderForm.ForeColor = Drawing.Color.White
                ' RenderForm.FormBorderStyle = Windows.Forms.FormBorderStyle.Fixed3D

                ' Aero(Settings, 0, -0, 5, 0)
                '

                'Settings.Label1.BackColor = Drawing.Color.AliceBlue

                ' Settings.FormBorderStyle = Windows.Forms.FormBorderStyle.Fixed3D
                ' Settings.ControlBox = False

                Aero(Editor, 1, 1, 1, 1)
                Editor.Text = "Editor"
                Editor.FormBorderStyle = Windows.Forms.FormBorderStyle.Fixed3D
                Editor.Height = 330







                Editor.FormBorderStyle = Windows.Forms.FormBorderStyle.Fixed3D
                ' Editor.ControlBox = False



            End If


        End If
        n += 1
        Progress(n)
        Label1.Text = "Initializing Render Form"
        Application.DoEvents()
        'Form1?
        RenderForm.Show()
        RenderForm.Opacity = 0
        RenderForm.Location = New Point(10, 10)
        RenderForm.Width = If(Screen.PrimaryScreen.Bounds.Width >= 1400, 850, 500)
        RenderForm.Height = If(Screen.PrimaryScreen.Bounds.Height >= 900, 600, 400)
        'RenderForm.Height = RenderForm.Label1.Height

        '_Render.Init(False)
        Application.DoEvents()
        n += 1
        Progress(n)
        Label1.Text = "Initializing cars"
        Application.DoEvents()
        'car_browser?
        Car_browser.Show()
        Car_browser.Opacity = 0
        Car_browser.Top = 10
        Car_browser.Left = Screen.PrimaryScreen.Bounds.Width - Car_browser.Width - 10

        n += 1
        Progress(n)
        Label1.Text = "Initializing settings"
        Application.DoEvents()
        'Settings?
        Settings.Show()
        Settings.Opacity = 0
        Settings.Left = 10
        Settings.Top = Screen.PrimaryScreen.Bounds.Height - Settings.Height - 35

        n += 1
        Progress(n)
        Label1.Text = "Initializing Editor"
        Application.DoEvents()
        'edit?
        Editor.Show()
        Editor.Opacity = 0
        Editor.Left = Screen.PrimaryScreen.Bounds.Width - Editor.Width - 10
        Editor.Top = Screen.PrimaryScreen.Bounds.Height - Editor.Height - 35

        n += 1
        Progress(n)
        Label1.Text = "Initializing Irrlicht"
        Application.DoEvents()
        Render.Init()

        m = Render.ScnMgr.AddAnimatedMeshSceneNode(Render.ScnMgr.GetMesh(Application.StartupPath & "\axe.obj"))
        m.SetMaterialFlag(IrrlichtNETCP.MaterialFlag.Lighting, False)
        m.Scale = New Vector3D(1, 1, -1)
        m.Visible = False

        n += 1
        Progress(n)
        Label1.Text = "Initializing Car Theory"
        Application.DoEvents()
        CarTheory()




        n += 1
        Progress(n)
        Label1.Text = "Initializing Cameras"
        Application.DoEvents()
        If Initialized = True Then Render.cam.Position = New Vector3D(5, 5, 5)
        Initialized = True

        'me<- hide
        Me.Location -= New Point(5000, 500)
        Me.Hide()
        Try
            Settings.TrackBar2.Value -= 1
        Catch

        End Try
        Try
            Settings.TrackBar2.Value += 1
        Catch

        End Try

        Label1.Text = "checking texture of floor"
        If IO.File.Exists(GetSetting("Car Load", "settings", "Floor Texture", "")) Then
            TextureFloorFile = GetSetting("Car Load", "settings", "Floor Texture", My.Computer.FileSystem.SpecialDirectories.Temp & "\mshadow.png")
        End If

        Label1.Text = "Getting On(Exit) check"
        Settings.CheckBox3.Checked = GetSetting("Car Load", "settings", "Confirm", "True")


        Settings.TrackBar3_Scroll(sender, e)


        Application.DoEvents()
        n += 1
        Progress(n)
        Label1.Text = "Initializing EnvMap"
        initEnvMap()
        Application.DoEvents()
        Label1.Text = "Initializing shadow"
        Render.InitShadow()

        Application.DoEvents()
        Label1.Text = "Starting Sounds Sharp"
        InitSounds()



        Label1.Text = "Activating Start By Loading"
        If StartByLoading Then
            Car_browser.ListBox2.SelectedIndex = index
        End If

        If AeroOn Then Editor.Height = 345

        Application.DoEvents()
        Label1.Text = "Starting rendering"
        n += 1
        Progress(n)
        Render.Go()

    End Sub
    Dim tim As New System.Windows.Forms.Timer()
    Sub opacityDo()


        If RenderForm.Opacity > 0.79 Then
            Settings.TrackBar2.Value = GetSetting("Car Load", "settings", "Opacity", 80)
            tim.Stop()
        End If

        RenderForm.Opacity += 0.03
        Car_browser.Opacity += 0.03
        Settings.Opacity += 0.03
        Editor.Opacity += 0.03

    End Sub

 
    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class

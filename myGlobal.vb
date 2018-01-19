Imports SoundsSharpNameSpace.SoundsSharp

Module myGlobal
    Public CLversion = "Car.Load() v1.8.4i"
    Public m As IrrlichtNETCP.AnimatedMeshSceneNode

    Public PRM_Path$ = Application.StartupPath & "\prm.exe"
    Public rvCenter_Path$ = Application.StartupPath & "\rvcenter.exe"
    Public rvShade_Path$ = Application.StartupPath & "\rvshade.exe"

    Public selectedI = 0
    Public SelectionMode = False

    Public Enum CurEdMod
        none
        CoM
        Weapon
        Body
        wheel0_0
        wheel1_0
        wheel2_0
        wheel3_0
        wheel0_1
        wheel1_1
        wheel2_1
        wheel3_1
        spring0
        spring1
        spring2
        spring3
        pin0
        pin1
        pin2
        pin3
        axle0
        axle1
        axle2
        axle3
        spinner_offset
        spinner_axis
        aerial_offset
        aerial_direction

    End Enum
    Public Current_Editing_Mode As CurEdMod = CurEdMod.none
    Sub RountIt(ByRef ct As Control)
        Dim p As New Drawing2D.GraphicsPath()
        p.StartFigure()

        p.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        p.AddLine(20, 0, ct.Width - 20, 0)
        p.AddArc(New Rectangle(ct.Width - 20, 0, 20, 20), -90, 90)
        p.AddLine(ct.Width, 20, ct.Width, ct.Height - 20)
        p.AddArc(New Rectangle(ct.Width - 20, ct.Height - 20, 20, 20), 0, 90)
        p.AddLine(ct.Width - 20, ct.Height, 20, ct.Height)
        p.AddArc(New Rectangle(0, ct.Height - 20, 20, 20), 90, 90)
        p.CloseFigure()
        ct.Region = New Region(p)

    End Sub
    Sub RountIt(ByRef ct As Form)
        Dim p As New Drawing2D.GraphicsPath()
        p.StartFigure()

        p.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        p.AddLine(20, 0, ct.Width - 20, 0)
        p.AddArc(New Rectangle(ct.Width - 20, 0, 20, 20), -90, 90)
        p.AddLine(ct.Width, 20, ct.Width, ct.Height - 20)
        p.AddArc(New Rectangle(ct.Width - 20, ct.Height - 20, 20, 20), 0, 90)
        p.AddLine(ct.Width - 20, ct.Height, 20, ct.Height)
        p.AddArc(New Rectangle(0, ct.Height - 20, 20, 20), 90, 90)
        p.CloseFigure()
        ct.Region = New Region(p)

    End Sub
    Sub RountIt(ByRef ct As Control, ByVal value&)
        Dim p As New Drawing2D.GraphicsPath()
        p.StartFigure()

        p.AddArc(New Rectangle(0, 0, value, value), 180, 90)
        p.AddLine(value, 0, ct.Width - value, 0)
        p.AddArc(New Rectangle(ct.Width - value, 0, value, value), -90, 90)
        p.AddLine(ct.Width, value, ct.Width, ct.Height - value)
        p.AddArc(New Rectangle(ct.Width - value, ct.Height - value, value, value), 0, 90)
        p.AddLine(ct.Width - value, ct.Height, value, ct.Height)
        p.AddArc(New Rectangle(0, ct.Height - value, value, value), 90, 90)
        p.CloseFigure()
        ct.Region = New Region(p)

    End Sub
    Public EnvMap As IrrlichtNETCP.Texture
    Public Sub initEnvMap()
        My.Resources.Envstill.Save(My.Computer.FileSystem.SpecialDirectories.Temp & "\envstill.png")
        EnvMap = Global.Car_Load.Render.VideoDriver.GetTexture(My.Computer.FileSystem.SpecialDirectories.Temp & "\envstill.png")
        EnvMap.MakeColorKey(Render.VideoDriver, IrrlichtNETCP.Color.Black)
        EnvMap.RegenerateMipMapLevels()
    End Sub
    Public SndMgr As SoundsSharpNameSpace.SoundsSharp.SoundManager
    Sub InitSounds()
        SndMgr = New SoundManager()
        SndMgr.Init()
    End Sub
    Public Sound As SoundAmbient
    Sub SoundOn()
        If Sound IsNot Nothing Then Sound.stop_()

        Select Case _car.Theory.MainInfos.car_class

            Case 0
                Sound = New SoundAmbient(RvPath & "\wavs\moto.wav", True)
            Case 1
                Sound = New SoundAmbient(RvPath & "\wavs\petrol.wav", True)
        End Select
        Sound.Play()
        PitchSound()

    End Sub
    Sub SoundOff()
        If Sound IsNot Nothing Then Sound.stop_()
    End Sub
    Sub PitchSound()
        If Sound Is Nothing Then Exit Sub

        Select Case _car.Theory.MainInfos.car_class

            Case 0
                If Editor.TrackBar1.Value <> 0 Then
                    Sound.Pitch((Editor.TrackBar1.Value + 5) / 17.5)
                Else
                    Sound.Pitch(0)
                End If

            Case 1
                Sound.Pitch((Editor.TrackBar1.Value + 6) / 17.5)

        End Select
    End Sub
End Module

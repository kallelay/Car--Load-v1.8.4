Imports IrrlichtNETCP
Imports System.Math


Public Class Car_browser
    Dim LastLoc As Point
    Dim carList As New ListBox
    Public Const Stock = "*tc6*moss*rc*mite*phat*moss*mud*beatall*Volken*dino*candy*gencar*pcxl*mouse*flag*tc2*r5*tc5*sgt*tc3*tc4*Adeon*fone*tc1*rotor*cougar*Toyeca*amw*wincar*wincar2*wincar3*cougar*panga*sugo*tc4*trolley*ufo*wincar4*q*"

    Public Sub setProgress(ByVal percent)

        Panel4.Width = (percent / 100) * Panel2.Width
    End Sub
    ' Drop Shadow around Form


    Private Sub Car_browser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carList.FormattingEnabled = False
        Me.Size = New Size(587, 373)

        Me.CreateParams.ClassStyle += &H20000


        Panel9.Location = New Point(109, 77)

        setProgress(0)
        Panel2.Hide()
        LoadAllCarsIntoList()

    End Sub

    Sub LoadAllCarsIntoList()
        Dim carPath As String = RvPath & "\cars"

        ListBox2.Items.Clear()
        carList.Items.Clear()

        'check if current path exists
        If IO.Directory.Exists(carPath) = False Then
            RenderForm.Hide()
            Settings.Hide()
            Editor.Hide()
            Directory.Show()


            Exit Sub


        End If



        Dim cars() = IO.Directory.GetDirectories(carPath)
        For i = LBound(cars) To UBound(cars)
            If IO.File.Exists(cars(i) & "\parameters.txt") Then
                Dim sing As New Singletons(cars(i) & "\parameters.txt")
                Dim name = Replace(Replace(sing.getSingleton("").getValue("Name"), vbTab, ""), ",", ".")
                Do Until name(0) = Chr(34)
                    name = Mid(name, 2)
                Loop

                name = name.Replace(Chr(34), "")

                Dim Pname = Replace(cars(i).Split("\").Last, vbTab, "")

                ListBox2.Items.Add(" " & vbTab & name & "   (" & Pname & ")")
            End If
        Next

        For i = 0 To ListBox2.Items.Count - 1
            Application.DoEvents()
            startfromhere.Label1.Text = "Activating Search engine"

            carList.Items.Add(ListBox2.Items(i).ToString)
        Next i

        Label23.Text = ListBox2.Items.Count & " cars"
    End Sub
    Public Printing = False
    Sub ListBox2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox2.DoubleClick
        _t = 0
        Dialog1.Close()

        '  On Error Resume Next
        If ListBox2.SelectedIndex = -1 Then Exit Sub

        LoadOneCar()
        LoadOneShadow()
        ' RenderForm.Focus()
        ' RenderForm.PictureBox1.Focus()
        '  RenderForm.PictureBox1.Focus()
        Car_Init = True
        ' _Render.nInit()

        Settings.RadioButton1_CheckedChanged(sender, e)
        Settings.RadioButton2_CheckedChanged(sender, e)
        Settings.RadioButton3_CheckedChanged(sender, e)
        Settings.RadioButton4_CheckedChanged(sender, e)
        Render.cam.Target = _car.Theory.Body.Offset
        TrackBar1_ValueChanged(sender, e)

        Editor.EnDis()
        Printing = True
        FilesPrint()
        TexPrint()
        PrintMain()
        PrintFrontEnd()

        PrintHandle()
        'TODO: printers
        PrintBody()
        PrintWheel(0)


        Printing = False

        Stats()
        If _car.Theory.RealInfos.TopSpeed < 200 Then
            Editor.TrackBar1.Maximum = Int(_car.Theory.RealInfos.TopSpeed)
        Else
            Editor.TrackBar1.Maximum = 200
        End If




    End Sub
    Public Enum chosen
        none = 0
        carbox = 2
        texture = 1
    End Enum
    Public Shared selected As chosen = chosen.none
    Sub SelectPic(ByVal which As chosen)

        selected = which

        Select Case which
            Case chosen.none
                Editor.Panel6.BorderStyle = BorderStyle.None
                Editor.Panel6.BackColor = Drawing.Color.Transparent
                Editor.Panel7.BorderStyle = BorderStyle.None
                Editor.Panel7.BackColor = Drawing.Color.Transparent

                Editor.ListView1.Visible = False
            Case chosen.texture
                Editor.Panel6.BorderStyle = BorderStyle.FixedSingle
                Editor.Panel6.BackColor = Drawing.Color.Azure
                Editor.Panel7.BorderStyle = BorderStyle.None
                Editor.Panel7.BackColor = Drawing.Color.Transparent

                Editor.ListView1.Visible = True
            Case chosen.carbox
                Editor.Panel6.BorderStyle = BorderStyle.None
                Editor.Panel6.BackColor = Drawing.Color.Transparent
                Editor.Panel7.BorderStyle = BorderStyle.FixedSingle
                Editor.Panel7.BackColor = Drawing.Color.Azure

                Editor.ListView1.Visible = True
        End Select


    End Sub

    Private PrintingCarComponent = False
    Public ListBox As New AutoCompleteStringCollection
    Public ListBoxForBmps As New AutoCompleteStringCollection

    Sub PrintWheel(ByVal i As Integer)

        ' If Not Printing Then Exit Sub
        If Not Initialized Then Exit Sub
        PrintingCarComponent = True


        With _car.Theory.wheel(i)

            Editor.Label51.Text = i

            Editor.NumericUpDown2.Value = .modelNumber
            Editor.CheckBox14.Checked = .IsPowered
            Editor.CheckBox13.Checked = .IsPresent
            Editor.CheckBox15.Checked = .IsTurnable

            Editor.TextBox47.Text = .SteerRatio
            Editor.TextBox46.Text = .EngineRatio
            Editor.TextBox45.Text = .Radius
            Editor.TextBox42.Text = .MaxPos
            Editor.TextBox32.Text = .SkidWidth

            Editor.TextBox41.Text = .ToeInn
            Editor.TextBox40.Text = .AxleFriction
            Editor.TextBox33.Text = .StaticFriction
            Editor.TextBox24.Text = .KinematicFriction

            Editor.TextBox44.Text = .Mass

        End With
        PrintingCarComponent = True

    End Sub
    Sub SaveWheel(ByVal i As Integer, Optional ByVal SaveNumber As Boolean = True)
        If Printing Or PrintingCarComponent Then Exit Sub
        ' On Error Resume Next
        With _car.Theory.wheel(i)
            i = Editor.Label51.Text

            If SaveNumber Then .modelNumber = Editor.NumericUpDown2.Value
            .IsPowered = Editor.CheckBox14.Checked
            .IsPresent = Editor.CheckBox13.Checked
            .IsTurnable = Editor.CheckBox15.Checked

            .SteerRatio = Editor.TextBox47.Text
            .EngineRatio = Editor.TextBox46.Text
            .Radius = Editor.TextBox45.Text
            .MaxPos = Editor.TextBox42.Text
            .SkidWidth = Editor.TextBox32.Text

            .ToeInn = Editor.TextBox41.Text
            .AxleFriction = Editor.TextBox40.Text
            .StaticFriction = Editor.TextBox33.Text
            .KinematicFriction = Editor.TextBox24.Text

            .Mass = Editor.TextBox44.Text

        End With
    End Sub


    Sub FilesPrint()

        ListBox.Clear()

        Dim allprms = IO.Directory.GetFiles(_car.Path, "*.prm")
        For i = 0 To UBound(allprms)
            ListBox.Add(Replace(Replace(allprms(i), RvPath & "\", "", , , CompareMethod.Text), RvPath, "", , , CompareMethod.Text))
        Next

        allprms = IO.Directory.GetFiles(_car.Path & "\..\misc", "*.m")
        For i = 0 To UBound(allprms)
            ListBox.Add(Replace(Replace(allprms(i), RvPath & "\", "", , , CompareMethod.Text), RvPath, "", , , CompareMethod.Text))
        Next

        ListBox.Add("NONE")

    End Sub
    Sub TexPrint()

        Editor.ListView1.Items.Clear()
        Editor.ImageList1.Images.Clear()

        Dim allprms = IO.Directory.GetFiles(_car.Path, "*.bmp")
        For i = 0 To UBound(allprms)
            Dim txt$ = Replace(Replace(allprms(i), RvPath & "\", "", , , CompareMethod.Text), RvPath, "", , , CompareMethod.Text)
            Try
                Dim mst = New IO.FileStream(RvPath & "\" & txt, IO.FileMode.Open)
                Editor.ImageList1.Images.Add(i, System.Drawing.Image.FromStream(mst))
                mst.Close()

                Editor.ListView1.Items.Add(txt, i)
            Catch ex As Exception
                Tip.fShow("Bitmap:" & txt & " couldn't be loaded")
                Editor.ListView1.Items.Add(txt)
            End Try


        Next

        Editor.ListView1.Items.Add("NONE")

        If IO.File.Exists(RvPath & "\" & _car.Theory.MainInfos.Tpage) Then
            Dim mst = New IO.FileStream((RvPath & "\" & _car.Theory.MainInfos.Tpage), IO.FileMode.Open)
            Editor.Panel3.BackgroundImage = System.Drawing.Image.FromStream(mst)
            mst.Close()
        Else
            Editor.Panel3.BackgroundImage = Nothing
        End If

        Try

            If Not IO.File.Exists(RvPath & "\" & _car.Theory.MainInfos.TCarBox) Then
                Editor.Panel5.BackgroundImage = Nothing
                Exit Try
            End If

            Dim mst = New IO.FileStream(RvPath & "\" & _car.Theory.MainInfos.TCarBox, IO.FileMode.Open)
            Editor.Panel5.BackgroundImage = System.Drawing.Image.FromStream(mst)
            mst.Close()
        Catch
            Editor.Panel5.BackgroundImage = Nothing
        End Try


    End Sub
    Sub PrintFrontEnd()
        With Editor
            .CheckBox10.Checked = _car.Theory.MainInfos.BESTTIME
            .CheckBox11.Checked = _car.Theory.MainInfos.SELECTABLE
            .ComboBox1.SelectedIndex = _car.Theory.MainInfos.obtain + 1
            .ComboBox2.SelectedIndex = _car.Theory.MainInfos.Rating '+ 1
            .ComboBox3.SelectedIndex = _car.Theory.MainInfos.car_class '+ 1

            .TextBox3.Text = _car.Theory.MainInfos.TopEnd
            .TextBox4.Text = _car.Theory.MainInfos.Acceleration
            .TextBox5.Text = _car.Theory.MainInfos.Weight
            .TextBox6.Text = _car.Theory.MainInfos.Handling
            .TextBox7.Text = _car.Theory.MainInfos.Trans

            _car.isLoading = False

            .TextBox8.Text = _car.Theory.MainInfos.MaxRev

        End With
    End Sub
    Sub PrintBody()
        With _car.Theory.Body
            Editor.NumericUpDown1.Value = .modelNumber
            Editor.TextBox14.Text = .Mass
            Editor.TextBox15.Text = .Hardness
            Editor.TextBox17.Text = .ResMode
            Editor.TextBox16.Text = .AngleRes
            Editor.TextBox19.Text = .ResMode
            Editor.TextBox18.Text = .Grip
            Editor.TextBox20.Text = .StaticFriction
            Editor.TextBox21.Text = .KinematicFriction

            Editor.TextBox22.Text = .Inertia(0).X
            Editor.TextBox23.Text = .Inertia(0).Y
            Editor.TextBox25.Text = .Inertia(0).Z

            Editor.TextBox28.Text = .Inertia(1).X
            Editor.TextBox27.Text = .Inertia(1).Y
            Editor.TextBox26.Text = .Inertia(1).Z


            Editor.TextBox31.Text = .Inertia(2).X
            Editor.TextBox30.Text = .Inertia(2).Y
            Editor.TextBox29.Text = .Inertia(2).Z

        End With
    End Sub
    Sub SaveBody()
        If Printing Then Exit Sub
        On Error Resume Next
        With _car.Theory.Body
            .modelNumber = Editor.NumericUpDown1.Value
            .Mass = Editor.TextBox14.Text
            .Hardness = Editor.TextBox15.Text
            .ResMode = Editor.TextBox17.Text
            .AngleRes = Editor.TextBox16.Text
            .ResMode = Editor.TextBox19.Text
            .Grip = Editor.TextBox18.Text
            .StaticFriction = Editor.TextBox20.Text
            .KinematicFriction = Editor.TextBox21.Text

            .Inertia(0).X = Editor.TextBox22.Text
            .Inertia(0).Y = Editor.TextBox23.Text
            .Inertia(0).Z = Editor.TextBox25.Text

            .Inertia(1).X = Editor.TextBox28.Text
            .Inertia(1).Y = Editor.TextBox27.Text
            .Inertia(1).Z = Editor.TextBox26.Text


            .Inertia(2).X = Editor.TextBox31.Text
            .Inertia(2).Y = Editor.TextBox30.Text
            .Inertia(2).Z = Editor.TextBox29.Text

        End With
    End Sub
    Sub SaveFrontEnd()
        If _car.isLoading Then Exit Sub

        With _car.Theory.MainInfos
            .BESTTIME = Editor.CheckBox10.Checked
            .SELECTABLE = Editor.CheckBox11.Checked
            .car_class = Editor.ComboBox3.SelectedIndex
            .obtain = Editor.ComboBox1.SelectedIndex - 1
            .Rating = Editor.ComboBox2.SelectedIndex


            Try
                .TopEnd = CSng(Editor.TextBox3.Text)
            Catch
                .TopEnd = 0
            End Try

            Try
                .Acceleration = CSng(Editor.TextBox4.Text)
            Catch
                .Acceleration = 0
            End Try

            Try
                .Weight = CSng(Editor.TextBox5.Text)
            Catch ex As Exception
                .Weight = 0
            End Try
            Try
                .Handling = CSng(Editor.TextBox6.Text)
            Catch ex As Exception
                .Handling = 0
            End Try
            Try
                .Trans = CSng(Editor.TextBox7.Text)
            Catch ex As Exception
                .Trans = 0
            End Try
            Try

                .MaxRev = CSng(Editor.TextBox8.Text)

            Catch ex As Exception
                .MaxRev = 0
            End Try




        End With



        ReLoadOneCarInfo()


    End Sub

    Sub PrintMain()
        Dim n As String = Replace(_car.Theory.MainInfos.Name, Chr(9), "")
        Do Until Convert.ToInt16(n(0)) >= 65
            n = n.Substring(1)
            Application.DoEvents()
        Loop
        Editor.TextBox1.Text = n


        Editor.ComboBox4.Items.Clear()


        ' _car.Theory.MainInfos.Name = n
        Editor.ComboBox4.Text = _car.Theory.MainInfos.CollFile
        Dim allhuls = IO.Directory.GetFiles(_car.Path, "*.hul")
        For i = 0 To UBound(allhuls)
            Editor.ComboBox4.Items.Add(Replace(Replace(allhuls(i), RvPath & "\", "", , , CompareMethod.Text), RvPath, "", , , CompareMethod.Text))
        Next
        Editor.ComboBox4.Items.Add("NONE")
        Editor.Panel10.BackColor = Drawing.Color.FromArgb(_car.Theory.MainInfos.EnvRGB.X, _car.Theory.MainInfos.EnvRGB.Y, _car.Theory.MainInfos.EnvRGB.Z)
        Editor.ColorDialog1.Color = Editor.Panel10.BackColor

        Editor.Label20.Text = Editor.Panel10.BackColor.ToString
    End Sub
    Sub PrintHandle()
        With Editor
            .TextBox9.Text = _car.Theory.RealInfos.SteerRate
            .TextBox10.Text = _car.Theory.RealInfos.SteerMode
            .TextBox11.Text = _car.Theory.RealInfos.EngineRate
            .TextBox12.Text = _car.Theory.RealInfos.TopSpeed
            .TextBox13.Text = _car.Theory.RealInfos.DownForceModifier
        End With
    End Sub
    Sub SaveHandle()
        If Printing Then Exit Sub
        Dim prepareToRefresh = False
        With _car.Theory.RealInfos
            Try
                .SteerRate = Editor.TextBox9.Text
            Catch ex As Exception
                .SteerRate = 0
            End Try
            Try
                .SteerMode = Editor.TextBox10.Text
            Catch ex As Exception
                .SteerMode = 0
            End Try
            Try
                .EngineRate = Editor.TextBox11.Text
            Catch ex As Exception
                .EngineRate = 0
            End Try
            Try
                If .TopSpeed <> Editor.TextBox12.Text Then prepareToRefresh = True
                .TopSpeed = Editor.TextBox12.Text

            Catch ex As Exception
                .TopSpeed = 0
            End Try
            Try
                .DownForceModifier = Editor.TextBox13.Text
            Catch ex As Exception
                .DownForceModifier = 0
            End Try

            If prepareToRefresh = True Then ReLoadOneCarInfo()

        End With
    End Sub
    Enum classes
        Electric = 0
        Glow = 1
        Special = 2

    End Enum
    Enum rating

        Rookie = 0
        Amateur = 1
        Advanced = 2
        Semi_Pro = 3
        Pro = 4
    End Enum
    Enum Obtain
        Carnival_Only = -1
        Anytime = 0
        Championship = 1
        Timetrial = 2
        Practice = 3
        Winning_Single_Races = 4
        Training = 5



    End Enum
    Sub Stats()
        Label5.Text = ""
        If cBODY IsNot Nothing Then Label4.Text = readPolys(Replace(RvPath & "\" & _car.Theory.MainInfos.Model(_car.Theory.Body.modelNumber), ",", "."))

        For i = 0 To 3

            If _Wheel(i) IsNot Nothing Then
                If _car.Theory.wheel(0).modelNumber = -1 Then
                    Label5.Text &= "-, "
                    Continue For
                End If

                Label5.Text &= readPolys(Replace(RvPath & "\" & _car.Theory.MainInfos.Model(_car.Theory.wheel(0).modelNumber), ",", ".")) & ", "
            Else
                Label5.Text &= "-, "
            End If
            If i = 1 Then Label5.Text &= vbNewLine
        Next i

        Label5.Text = Label5.Text.Substring(0, Len(Label5.Text) - 2)


        Label7.Text = _car.Theory.MainInfos.SELECTABLE
        Label9.Text = _car.Theory.MainInfos.BESTTIME

        Label11.Text = DirectCast(_car.Theory.MainInfos.car_class, classes).ToString
        Label13.Text = Replace(DirectCast(_car.Theory.MainInfos.obtain, Obtain).ToString, "_", " ")
        Label15.Text = Replace(DirectCast(_car.Theory.MainInfos.Rating, rating).ToString, "_", "-")

        Label17.Text = _car.Theory.RealInfos.TopSpeed & " mph" & vbNewLine & Int(_car.Theory.RealInfos.TopSpeed * 1.6) & "km/h"



    End Sub
    Sub ReLoadOneCarFromInfo()
        Application.DoEvents()
        Panel2.Show()
        setProgress(0)




        'TODO: REDO THIS (reload info: to avoid conflicts)


        Dim ftex = (Replace(RvPath & "\" & _car.Theory.MainInfos.Tpage, ",", "."))




        'Render.ScnMgr.Dispose(True)
        Application.DoEvents()
        setProgress(22)

        '  On Error Resume Next
        If (_car.Theory.Body.modelNumber) <> -1 Then
            If IO.File.Exists(Replace(Replace(RvPath & "\" & _car.Theory.MainInfos.Model(_car.Theory.Body.modelNumber), Chr(34), ""), ",", ".")) = True Then
                cBODY = New Car_Model(Replace(RvPath & "\" & _car.Theory.MainInfos.Model(_car.Theory.Body.modelNumber), Chr(34), ""))
                cBODY.Texture_ = ftex
                cBODY.Render()
                Try
                    cBODY.ScnNode.Position = _car.Theory.Body.Offset ' - _car.Theory.RealInfos.COM / 2
                Catch
                End Try



            End If
        Else
            Tip.fShow("~~Error: MODEL(" & _car.Theory.Body.modelNumber & ") doesn't exist" & vbNewLine)
            Debugger.Break()
        End If

        Application.DoEvents()
        setProgress(35)

        For i = 0 To 3
            If _car.Theory.wheel(i).modelNumber <> -1 Then
                If IO.File.Exists(Replace(RvPath & "\" & Replace(_car.Theory.MainInfos.Model(_car.Theory.wheel(i).modelNumber), Chr(34), ""), ",", ".")) = True Then
                    _Wheel(i) = New Car_Model(RvPath & "\" & Replace(_car.Theory.MainInfos.Model(_car.Theory.wheel(i).modelNumber), Chr(34), ""))
                    If _Wheel(i) IsNot Nothing Then
                        _Wheel(i).Texture_ = ftex
                        _Wheel(i).Render()
                        '  _Wheel(i).ScnNode.DebugObject = True
                        '  _Wheel(i).ScnNode.DebugDataVisible = DebugSceneType.BoundingBox
                        _Wheel(i).ScnNode.Position = _car.Theory.wheel(i).Offset(1) '+ _car.Theory.RealInfos  '+ _car.Theory.wheel(i).Offset(2) '- _car.Theory.Body.Offset





                    End If
                Else
                    Tip.fShow("~~Error: MODEL(" & _car.Theory.wheel(i).modelNumber & ") doesn't exist" & vbNewLine)
                End If

            End If
        Next

        Application.DoEvents()
        setProgress(45)
        For i = 0 To 3
            'TODO : springs
            If _car.Theory.Spring(i).modelNumber <> -1 Then

                _Spring(i) = New Car_Model(RvPath & "\" & _car.Theory.MainInfos.Model(_car.Theory.Spring(i).modelNumber).Replace(Chr(34), ""))
                _Spring(i).Texture_ = ftex
                _Spring(i).Render()

                '_Spring(i).ScnNode.Scale = _car.Theory.Spring(i).Length '(, 1)
                _Spring(i).ScnNode.Position = _car.Theory.Spring(i).Offset



                Dim A As New Vector3D
                A = _Wheel(i).ScnNode.Position - _Spring(i).ScnNode.Position

                Dim RotAngXY, RotAngYZ, RotAngXZ As Single

                RotAngXZ = Acos(-A.X / Sqrt(A.X ^ 2 + A.Z ^ 2))

                RotAngYZ = 0 'Acos(-A.Z / Sqrt(A.Y ^ 2 + A.Z ^ 2))

                RotAngXY = Acos(A.Y / Sqrt(A.X ^ 2 + A.Y ^ 2))



                Dim FixedScale = (A.X + _car.Theory.wheel(i).Offset(2).X) / (_Spring(i).ScnNode.BoundingBox.MaxEdge).Length





                _Spring(i).ScnNode.Scale = New Vector3D(1, _car.Theory.Spring(i).Length / 10 * _Spring(i).ScnNode.BoundingBox.MaxEdge.Length / getBBoxVectors(_Spring(i).BoundingBox).Length, 1)

                '    message.Message(A.X / getBBoxVectors(_spring(i).BoundingBox).Z & "," & _car.Theory.spring(i).Length)

                _Spring(i).ScnNode.Rotation = New Vector3D(RotAngYZ * (A.Z / Abs(A.Z)) * 180 / PI, RotAngXZ * (A.Z / Abs(A.Z)) * 180 / PI, 180 + (-1) ^ (i) * RotAngXY * 180 / PI) 'RotAngXY * (A.Y / Abs(A.Y)) * 180 / PI)***90





            End If


        Next

        Application.DoEvents()
        setProgress(55)

        'TODO: PINs

        For i = 0 To 3
            If _car.Theory.PIN(i).modelNumber <> -1 Then
                'If _Pin(i) IsNot Nothing Then
                _Pin(i) = New Car_Model(RvPath & "\" & _car.Theory.MainInfos.Model(_car.Theory.PIN(i).modelNumber).Replace(Chr(34), ""))
                _Pin(i).Texture_ = ftex
                _Pin(i).Render()
                _Pin(i).ScnNode.Position = _car.Theory.PIN(i).offSet

                _Pin(i).ScnNode.Scale *= _car.Theory.PIN(i).Length



                'End If
            End If
        Next

        Application.DoEvents()
        setProgress(65)

        For i = 0 To 3
            If _car.Theory.Axle(i).modelNumber <> -1 Then


                _axle(i) = New Car_Model(RvPath & "\" & _car.Theory.MainInfos.Model(_car.Theory.Axle(i).modelNumber).Replace(Chr(34), ""))
                _axle(i).Texture_ = ftex

                _axle(i).Render()

                _axle(i).ScnNode.Position = _car.Theory.Axle(i).offSet



                Dim A As New Vector3D
                A = _Wheel(i).ScnNode.Position - _axle(i).ScnNode.Position

                Dim RotAngXZ, RotAngXY As Single

                RotAngXZ = Acos(-A.X / Sqrt(A.X ^ 2 + A.Z ^ 2))

                RotAngXY = Acos(A.Y / Sqrt(A.X ^ 2 + A.Y ^ 2))

                Dim FixedScale = (A.X + _car.Theory.wheel(i).Offset(2).X) / (_axle(i).ScnNode.BoundingBox.MaxEdge).Length





                '   _axle(i).ScnNode.Scale = New Vector3D(1, 1, Abs(A.X / getBBoxVectors(_axle(i).BoundingBox).Z))

                '_axle(i).ScnNode.Scale = New Vector3D(1, 1, Abs(A.X / getBBoxVectors(_axle(i).BoundingBox).Z))

                _axle(i).ScnNode.Scale = New Vector3D(1, 1, _car.Theory.Axle(i).Length / 10 * _axle(i).ScnNode.BoundingBox.MaxEdge.Length / getBBoxVectors(_axle(i).BoundingBox).Length)


                '    message.Message(A.X / getBBoxVectors(_axle(i).BoundingBox).Z & "," & _car.Theory.Axle(i).Length)

                Dim Zrepo As Single = (A.Z / Abs(A.Z))
                If Single.IsNaN(Zrepo) Then Zrepo = If(i Mod 2 = 0, -1, 1)




                _axle(i).ScnNode.Rotation = New Vector3D(0, _
                                                        (RotAngXZ * Zrepo * 180 / PI - 90), _
                                                     (180 * (i + 1) + 90 + (-1) ^ (i) * RotAngXY * 180 / PI))
                'RotAngXY * (A.Y / Abs(A.Y)) * 180 / PI)***90

                '  message.Message("FirstCalc:" & _axle(i).ScnNode.BoundingBox.MaxEdge.Length / getBBoxVectors(_axle(i).BoundingBox).Z & "\nCL:" & _car.Theory.Axle(i).Length / 10 * _axle(i).ScnNode.BoundingBox.MaxEdge.Length / getBBoxVectors(_axle(i).BoundingBox).Length & "\nPara:" & _car.Theory.Axle(i).Length)



            End If
        Next

        Application.DoEvents()
        setProgress(75)

        If _car.Theory.Spinner.modelNumber <> -1 Then
            _Spinner = New Car_Model(RvPath & "\" & _car.Theory.MainInfos.Model(_car.Theory.Spinner.modelNumber).Replace(Chr(34), ""))

            _Spinner.Texture_ = ftex
            _Spinner.Render()
            '  MsgBox(_Spinner.PolysReadingProgress)
            _Spinner.ScnNode.Position = _car.Theory.Spinner.offSet

            ' _car.Theory.Spinner.Axis()
            '_Spinner.ScnNode.Scale = _car.Theory.Spinner.Axis 

        End If

        Application.DoEvents()
        setProgress(85)

        If _car.Theory.Aerial.ModelNumber <> -1 Then
            If IO.File.Exists(RvPath & "\" & _car.Theory.MainInfos.Model(_car.Theory.Aerial.ModelNumber).Replace(Chr(34), "")) = False Then
                Tip.fShow("~~Error: MODEL(" & _car.Theory.Aerial.ModelNumber & ") doesn't exist" & vbNewLine)
            End If
            _Aerial = New Car_Model(RvPath & "\" & _car.Theory.MainInfos.Model(_car.Theory.Aerial.ModelNumber).Replace(Chr(34), ""))
            If _Aerial IsNot Nothing Then

                _Aerial.Texture_ = RvPath & "\gfx\fxpage1.bmp"
                _Aerial.Render()



                _Aerial.ScnNode.Position = _car.Theory.Aerial.offset '+ New Vector3D(0,  _Aerial.BoundingBox.maxY * _car.Theory.Aerial.length, 0)
                _Aerial.ScnNode.Scale = New Vector3D(1, _car.Theory.Aerial.length * 2, 1)
                _Aerial.ScnNode.Rotation = _car.Theory.Aerial.Direction
                '_Aerial.ScnNode.Scale.SetLength(_car.Theory.Aerial.length)


            End If
        End If

        Application.DoEvents()
        setProgress(95)

        If _car.Theory.Aerial.TopModelNumber <> -1 Then
            Dim aerialtop As New Car_Model(RvPath & "\" & _car.Theory.MainInfos.Model(_car.Theory.Aerial.TopModelNumber).Replace(Chr(34), ""))
            If aerialtop IsNot Nothing Then
                aerialtop.Texture_ = RvPath & "\gfx\fxpage1.bmp"
                aerialtop.Render()
                '   aerialtop.ScnNode.Scale *= 5
                ' aerialtop.ScnNode.Position *= _car.Theory.Aerial.Direction.Y
                aerialtop.ScnNode.Position = _car.Theory.Aerial.offset + New Vector3D(0, _Aerial.BoundingBox.maxY * _car.Theory.Aerial.length * 2, 0) + New Vector3D(0, 0.1, 0)
                aerialtop.ScnNode.Scale = New Vector3D(1, -5, 1)
                '  aerialtop.ScnNode.Position += _car.Theory.Aerial.Direction
                '  aerialtop.ScnNode.Position += _car.Theory.Aerial.offset '+  ' ) '+' Aerial.ScnNode.BoundingBox.MaxEdge



            End If
        End If
        For Each PRMmodel As Car_Model In Models

            If PRMmodel.ScnNode IsNot Nothing And _Wheel(1) IsNot Nothing Then
                ' Debug.WriteLine("<-" & _Wheel(1).ScnNode.BoundingBox.MinEdge.Y * Render.ZoomFactor)

                '   If _Wheel(1).VxCount > 0 Then PRMmodel.ScnNode.Position += New Vector3D(0, -_Wheel(1).ScnNode.BoundingBox.MinEdge.Y * Render.ZoomFactor + 0.2, 0)
            End If



        Next
        Editor.EnDis()
        Application.DoEvents()

        Editor.RadioButton29.Checked = True

        Settings.Checkbox1_CheckedChanged("", New EventArgs)


        'saving car as default
        Car_As_Loaded = New Car("")
        Car_As_Loaded.Theory = _car.Theory.Clone
        Car_As_Loaded.isLoading = False


        setProgress(100)
        Panel2.Hide()

    End Sub
    Sub ReLoadOneCarInfo()
        Application.DoEvents()
        Panel2.Show()
        setProgress(0)

        Stats()

        setProgress(100)
        Panel2.Hide()
    End Sub
    Public Shared Car_As_Loaded As Car
    Sub LoadOneShadow()
        If cBODY Is Nothing Then
            Render.ShadowScnNode.Visible = False
            '  Render.mShadowScnNode.Visible = False
            Exit Sub
        End If

        ' Render.ShadowScnNode.Scale = New Vector3D(Math.Abs(cBODY.BoundingBox.maxX - cBODY.BoundingBox.minX) * 2 * Render.ZoomFactor, Math.Abs(cBODY.BoundingBox.maxY - cBODY.BoundingBox.minY) * 2 * Render.ZoomFactor, Math.Abs(cBODY.BoundingBox.maxZ - cBODY.BoundingBox.minZ) * 2 * Render.ZoomFactor)
        Render.ShadowScnNode.Visible = True
        Dim nBbox As New IrrlichtNETCP.Box3D
        For Each prm As Car_Model In Models

            If nBbox.MinEdge.X > prm.BoundingBox.minX + prm.ScnNode.Position.X Then
                nBbox.MinEdge.X = prm.BoundingBox.minX + prm.ScnNode.Position.X ' * Render.ZoomFactor
            End If
            If nBbox.MinEdge.Y > prm.BoundingBox.minY + prm.ScnNode.Position.Y Then
                nBbox.MinEdge.Y = prm.BoundingBox.minY + +prm.ScnNode.Position.Y '* Render.ZoomFactor
            End If
            If nBbox.MinEdge.Z > prm.BoundingBox.minZ + +prm.ScnNode.Position.Z Then
                nBbox.MinEdge.Z = prm.BoundingBox.minZ + +prm.ScnNode.Position.Z '* Render.ZoomFactor
            End If

            If nBbox.MaxEdge.X < prm.BoundingBox.maxX + +prm.ScnNode.Position.X Then
                nBbox.MaxEdge.X = prm.BoundingBox.maxX + +prm.ScnNode.Position.X '* Render.ZoomFactor
            End If
            If nBbox.MaxEdge.Y < prm.BoundingBox.maxY + prm.ScnNode.Position.Y Then
                nBbox.MaxEdge.Y = prm.BoundingBox.maxY + prm.ScnNode.Position.Y ' * Render.ZoomFactor
            End If
            If nBbox.MaxEdge.Z < prm.BoundingBox.maxZ + prm.ScnNode.Position.Z Then
                nBbox.MaxEdge.Z = prm.BoundingBox.maxZ + prm.ScnNode.Position.Z ' * Render.ZoomFactor
            End If

        Next

        Render.ShadowScnNode.Position = New Vector3D(nBbox.Center.X, nBbox.MinEdge.Y, nBbox.Center.Z) + New Vector3D(0, +0.02, 0)

        Render.ShadowScnNode.Scale = New Vector3D(nBbox.MaxEdge.X - nBbox.MinEdge.X, nBbox.MaxEdge.Y - nBbox.MinEdge.Y, nBbox.MaxEdge.Z - nBbox.MinEdge.Z) * 1.0 / 10
        Render.mShadowScnNode.Position = New Vector3D(nBbox.Center.X, nBbox.MinEdge.Y, nBbox.Center.Z)
    End Sub
    Sub LoadOneCar()
        CleanUpAll()
        Application.DoEvents()
        Panel2.Show()
        setProgress(0)
        If Models.Count <> 0 Then
       
            Models.Clear()

        End If




        Application.DoEvents()
        setProgress(5)


        Dim mycar = Split(Split(ListBox2.SelectedItem, "(")(1), ")")(0)

        _car = New Car(RvPath & "\cars\" & mycar)

        _car.Load()


        Dim auth$ = ""



        If InStr(_car.Theory.MainInfos.Name, "Halogaland", CompareMethod.Text) > 0 Then
            auth = "Halogaland"
            Label22.Text = auth
        End If

        If IO.Directory.GetFiles(RvPath & "\cars\" & mycar, "*read*me*").Length > 0 Then
            Label21.Visible = True
            Label22.Visible = True
            Button3.Visible = True
            Dim rm = IO.File.ReadAllText(IO.Directory.GetFiles(RvPath & "\cars\" & mycar, "*read*me*")(0))
            If InStr(rm, "---", CompareMethod.Text) > 0 And InStr(rm, "citywalker", CompareMethod.Text) > 0 Then
                auth = "Citywalker"

            ElseIf InStr(rm, "author name", CompareMethod.Text) > 0 Then
                auth = Split(rm, "author name", -1, CompareMethod.Text)(1).Split(vbNewLine)(0)
            ElseIf InStr(rm, "author", CompareMethod.Text) > 0 Then
                auth = Split(rm, "author", -1, CompareMethod.Text)(1).Split(vbNewLine)(0)
            ElseIf InStr(rm, "created by", CompareMethod.Text) > 0 Then
                auth = Split(rm, "created by", -1, CompareMethod.Text)(1).Split(vbNewLine)(0)
            ElseIf InStr(rm, "creator", CompareMethod.Text) > 0 Then
                auth = Split(rm, "creator", -1, CompareMethod.Text)(1).Split(vbNewLine)(0)
            ElseIf InStr(rm, "by", CompareMethod.Text) > 0 Then
                auth = Split(rm, "by", -1, CompareMethod.Text)(1).Split(vbNewLine)(0)
            Else
                If auth = "" Then auth = "Unknown"
            End If

            
            'BURNER's Sign

            If InStr(Split(rm, vbNewLine)(UBound(Split(rm, vbNewLine))), "Burner", CompareMethod.Text) = 1 Then
                auth = "Burner94"
            End If


            Do Until auth.Length = 0 Or (Convert.ToInt16(auth(0)) > 64 And Convert.ToInt16(CChar(auth(0))) < 123)
                auth = auth.Substring(1)
                Application.DoEvents()
                If auth.Length = 0 Then GoTo xFail
            Loop


            Do Until Convert.ToInt16(CChar(auth(auth.Length - 1))) > 64 And Convert.ToInt16(CChar(auth(auth.Length - 1))) < 123 Or Convert.ToInt16(CChar(auth(auth.Length - 1))) = 41

                auth = auth.Substring(0, auth.Length - 1)

                Application.DoEvents()

            Loop


xFail:

            Label22.Text = auth




        Else
            Label21.Visible = False
            Label22.Visible = False
            Button3.Visible = False
        End If

        If InStr(Stock, "*" & mycar & "*", CompareMethod.Text) Then
            auth = "Acclaim (STOCK CAR)"
            Label22.Text = "Acclaim (STOCK CAR)"
        End If

        If auth <> "" Then
            Label21.Visible = True
            Label22.Visible = True


        End If





        Application.DoEvents()
        setProgress(20)

        Dim ftex = (Replace(RvPath & "\" & _car.Theory.MainInfos.Tpage, ",", "."))
        ' IO.File.AppendAllText(Environ("temp") & "\carload.log", "ftex:" & ftex & vbNewLine)
        '  CARBMP.MakeTransparent(System.Drawing.Color.FromArgb(0, 0, 0))
        '  MkDir(Environ("temp") & "\carload\")
        '  Randomize()
        '
        '   Dim ftex = Environ("temp") & "\carload\" & _car.Theory.MainInfos.Tpage.Split("\").Last & "cartx" & Int(Rnd() * 50000) & ".png"
        '
        '    CARBMP.Save(ftex)
        '   CARBMP.Dispose()

        'Render.ScnMgr.Dispose(True)
        Application.DoEvents()
        setProgress(22)

        '  On Error Resume Next
        If (_car.Theory.Body.modelNumber) <> -1 Then
            If IO.File.Exists(Replace(Replace(RvPath & "\" & _car.Theory.MainInfos.Model(_car.Theory.Body.modelNumber), Chr(34), ""), ",", ".")) = True Then
                cBODY = New Car_Model(Replace(RvPath & "\" & _car.Theory.MainInfos.Model(_car.Theory.Body.modelNumber), Chr(34), ""))
                cBODY.Texture_ = ftex
                cBODY.Render()
                Try
                    cBODY.ScnNode.Position = _car.Theory.Body.Offset ' - _car.Theory.RealInfos.COM / 2
                Catch
                End Try



            End If
        Else
            Tip.fShow("~~Error: MODEL(" & _car.Theory.Body.modelNumber & ") doesn't exist" & vbNewLine)
            Debugger.Break()
        End If

        Application.DoEvents()
        setProgress(35)

        For i = 0 To 3
            If _car.Theory.wheel(i).modelNumber <> -1 Then
                If IO.File.Exists(Replace(RvPath & "\" & Replace(_car.Theory.MainInfos.Model(_car.Theory.wheel(i).modelNumber), Chr(34), ""), ",", ".")) = True Then
                    _Wheel(i) = New Car_Model(RvPath & "\" & Replace(_car.Theory.MainInfos.Model(_car.Theory.wheel(i).modelNumber), Chr(34), ""))
                    If _Wheel(i) IsNot Nothing Then
                        _Wheel(i).Texture_ = ftex
                        _Wheel(i).Render()
                        '  _Wheel(i).ScnNode.DebugObject = True
                        '  _Wheel(i).ScnNode.DebugDataVisible = DebugSceneType.BoundingBox
                        _Wheel(i).ScnNode.Position = _car.Theory.wheel(i).Offset(1) '+ _car.Theory.RealInfos  '+ _car.Theory.wheel(i).Offset(2) '- _car.Theory.Body.Offset



                     

                    End If
                Else
                    Tip.fShow("~~Error: MODEL(" & _car.Theory.wheel(i).modelNumber & ") doesn't exist" & vbNewLine)
                End If

            End If
        Next

        Application.DoEvents()
        setProgress(45)
        For i = 0 To 3
            'TODO : springs
            If _car.Theory.Spring(i).modelNumber <> -1 Then

                _Spring(i) = New Car_Model(RvPath & "\" & _car.Theory.MainInfos.Model(_car.Theory.Spring(i).modelNumber).Replace(Chr(34), ""))
                _Spring(i).Texture_ = ftex
                _Spring(i).Render()

                '_Spring(i).ScnNode.Scale = _car.Theory.Spring(i).Length '(, 1)
                _Spring(i).ScnNode.Position = _car.Theory.Spring(i).Offset



                Dim A As New Vector3D
                A = _Wheel(i).ScnNode.Position - _Spring(i).ScnNode.Position

                Dim RotAngXY, RotAngYZ, RotAngXZ As Single

                RotAngXZ = Acos(-A.X / Sqrt(A.X ^ 2 + A.Z ^ 2))

                RotAngYZ = 0 'Acos(-A.Z / Sqrt(A.Y ^ 2 + A.Z ^ 2))

                RotAngXY = Acos(A.Y / Sqrt(A.X ^ 2 + A.Y ^ 2))



                Dim FixedScale = (A.X + _car.Theory.wheel(i).Offset(2).X) / (_Spring(i).ScnNode.BoundingBox.MaxEdge).Length





                _Spring(i).ScnNode.Scale = New Vector3D(1, _car.Theory.Spring(i).Length / 10 * _Spring(i).ScnNode.BoundingBox.MaxEdge.Length / getBBoxVectors(_Spring(i).BoundingBox).Length, 1)

                '    message.Message(A.X / getBBoxVectors(_spring(i).BoundingBox).Z & "," & _car.Theory.spring(i).Length)

                _Spring(i).ScnNode.Rotation = New Vector3D(RotAngYZ * (A.Z / Abs(A.Z)) * 180 / PI, RotAngXZ * (A.Z / Abs(A.Z)) * 180 / PI, 180 + (-1) ^ (i) * RotAngXY * 180 / PI) 'RotAngXY * (A.Y / Abs(A.Y)) * 180 / PI)***90



           

            End If


        Next

        Application.DoEvents()
        setProgress(55)

        'TODO: PINs

        For i = 0 To 3
            If _car.Theory.PIN(i).modelNumber <> -1 Then
                'If _Pin(i) IsNot Nothing Then
                _Pin(i) = New Car_Model(RvPath & "\" & _car.Theory.MainInfos.Model(_car.Theory.PIN(i).modelNumber).Replace(Chr(34), ""))
                _Pin(i).Texture_ = ftex
                _Pin(i).Render()
                _Pin(i).ScnNode.Position = _car.Theory.PIN(i).offSet

                _Pin(i).ScnNode.Scale *= _car.Theory.PIN(i).Length



                'End If
            End If
        Next

        Application.DoEvents()
        setProgress(65)

        For i = 0 To 3
            If _car.Theory.Axle(i).modelNumber <> -1 Then


                _axle(i) = New Car_Model(RvPath & "\" & _car.Theory.MainInfos.Model(_car.Theory.Axle(i).modelNumber).Replace(Chr(34), ""))
                _axle(i).Texture_ = ftex

                _axle(i).Render()

                _axle(i).ScnNode.Position = _car.Theory.Axle(i).offSet



                Dim A As New Vector3D
                A = _Wheel(i).ScnNode.Position - _axle(i).ScnNode.Position

                Dim RotAngXZ, RotAngXY As Single

                RotAngXZ = Acos(-A.X / Sqrt(A.X ^ 2 + A.Z ^ 2))

                RotAngXY = Acos(A.Y / Sqrt(A.X ^ 2 + A.Y ^ 2))

                Dim FixedScale = (A.X + _car.Theory.wheel(i).Offset(2).X) / (_axle(i).ScnNode.BoundingBox.MaxEdge).Length





                '   _axle(i).ScnNode.Scale = New Vector3D(1, 1, Abs(A.X / getBBoxVectors(_axle(i).BoundingBox).Z))

                '_axle(i).ScnNode.Scale = New Vector3D(1, 1, Abs(A.X / getBBoxVectors(_axle(i).BoundingBox).Z))

                _axle(i).ScnNode.Scale = New Vector3D(1, 1, _car.Theory.Axle(i).Length / 10 * _axle(i).ScnNode.BoundingBox.MaxEdge.Length / getBBoxVectors(_axle(i).BoundingBox).Length)


                '    message.Message(A.X / getBBoxVectors(_axle(i).BoundingBox).Z & "," & _car.Theory.Axle(i).Length)

                Dim Zrepo As Single = (A.Z / Abs(A.Z))
                If Single.IsNaN(Zrepo) Then Zrepo = If(i Mod 2 = 0, -1, 1)




                _axle(i).ScnNode.Rotation = New Vector3D(0, _
                                                        (RotAngXZ * ZRepo * 180 / PI - 90), _
                                                     (180 * (i + 1) + 90 + (-1) ^ (i) * RotAngXY * 180 / PI))
                'RotAngXY * (A.Y / Abs(A.Y)) * 180 / PI)***90

                '  message.Message("FirstCalc:" & _axle(i).ScnNode.BoundingBox.MaxEdge.Length / getBBoxVectors(_axle(i).BoundingBox).Z & "\nCL:" & _car.Theory.Axle(i).Length / 10 * _axle(i).ScnNode.BoundingBox.MaxEdge.Length / getBBoxVectors(_axle(i).BoundingBox).Length & "\nPara:" & _car.Theory.Axle(i).Length)



            End If
        Next

        Application.DoEvents()
        setProgress(75)

        If _car.Theory.Spinner.modelNumber <> -1 Then
            _Spinner = New Car_Model(RvPath & "\" & _car.Theory.MainInfos.Model(_car.Theory.Spinner.modelNumber).Replace(Chr(34), ""))

            _Spinner.Texture_ = ftex
            _Spinner.Render()
            '  MsgBox(_Spinner.PolysReadingProgress)
            _Spinner.ScnNode.Position = _car.Theory.Spinner.offSet

            ' _car.Theory.Spinner.Axis()
            '_Spinner.ScnNode.Scale = _car.Theory.Spinner.Axis 

        End If

        Application.DoEvents()
        setProgress(85)

        If _car.Theory.Aerial.ModelNumber <> -1 Then
            If IO.File.Exists(RvPath & "\" & _car.Theory.MainInfos.Model(_car.Theory.Aerial.ModelNumber).Replace(Chr(34), "")) = False Then
                Tip.fShow("~~Error: MODEL(" & _car.Theory.Aerial.ModelNumber & ") doesn't exist" & vbNewLine)
            End If
            _Aerial = New Car_Model(RvPath & "\" & _car.Theory.MainInfos.Model(_car.Theory.Aerial.ModelNumber).Replace(Chr(34), ""))
            If _Aerial IsNot Nothing Then

                _Aerial.Texture_ = RvPath & "\gfx\fxpage1.bmp"
                _Aerial.Render()



                _Aerial.ScnNode.Position = _car.Theory.Aerial.offset '+ New Vector3D(0,  _Aerial.BoundingBox.maxY * _car.Theory.Aerial.length, 0)
                _Aerial.ScnNode.Scale = New Vector3D(1, _car.Theory.Aerial.length * 2, 1)
                _Aerial.ScnNode.Rotation = _car.Theory.Aerial.Direction
                '_Aerial.ScnNode.Scale.SetLength(_car.Theory.Aerial.length)

          
            End If
        End If

        Application.DoEvents()
        setProgress(95)

        If _car.Theory.Aerial.TopModelNumber <> -1 Then
            Dim aerialtop As New Car_Model(RvPath & "\" & _car.Theory.MainInfos.Model(_car.Theory.Aerial.TopModelNumber).Replace(Chr(34), ""))
            If aerialtop IsNot Nothing Then
                aerialtop.Texture_ = RvPath & "\gfx\fxpage1.bmp"
                aerialtop.Render()
                '   aerialtop.ScnNode.Scale *= 5
                ' aerialtop.ScnNode.Position *= _car.Theory.Aerial.Direction.Y
                aerialtop.ScnNode.Position = _car.Theory.Aerial.offset + New Vector3D(0, _Aerial.BoundingBox.maxY * _car.Theory.Aerial.length * 2, 0) + New Vector3D(0, 0.1, 0)
                aerialtop.ScnNode.Scale = New Vector3D(1, -5, 1)
                '  aerialtop.ScnNode.Position += _car.Theory.Aerial.Direction
                '  aerialtop.ScnNode.Position += _car.Theory.Aerial.offset '+  ' ) '+' Aerial.ScnNode.BoundingBox.MaxEdge



            End If
        End If
        For Each PRMmodel As Car_Model In Models

            If PRMmodel.ScnNode IsNot Nothing And _Wheel(1) IsNot Nothing Then
                ' Debug.WriteLine("<-" & _Wheel(1).ScnNode.BoundingBox.MinEdge.Y * Render.ZoomFactor)

                '   If _Wheel(1).VxCount > 0 Then PRMmodel.ScnNode.Position += New Vector3D(0, -_Wheel(1).ScnNode.BoundingBox.MinEdge.Y * Render.ZoomFactor + 0.2, 0)
            End If



        Next
        Editor.EnDis()
        Application.DoEvents()

        Editor.RadioButton29.Checked = True

        Settings.CheckBox1_CheckedChanged("", New EventArgs)


        'saving car as default
        Car_As_Loaded = New Car("")
        Car_As_Loaded.Theory = _car.Theory.Clone
        Car_As_Loaded.isLoading = False


        Render.ScnMgr.MeshManipulator.SetVertexColorAlpha(cBODY.mesh, 255)

        setProgress(100)
        Panel2.Hide()
    End Sub
    Sub CleanUpAll()
        For Each prm As Car_Model In Models

            If prm.mesh Is Nothing Then GoTo SkipMesh







            ' Render.ScnMgr.MeshCache.RemoveMesh(prm.mesh)

            prm.mesh.Dispose()

            prm.mesh = Nothing
            prm.ScnNode.Visible = False


skipMesh:
            If prm.ScnNode Is Nothing Then GoTo skipScnNode



            prm.ScnNode = Nothing
SkipScnNode:




            prm = Nothing
        Next

    End Sub

    Private Sub ListBox2_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles ListBox2.DrawItem
        'CODE FOUND FROM THE INTERNET
        If e.State And DrawItemState.Selected Then

            Dim TextLength As Single = TextRenderer.MeasureText(ListBox2.SelectedItem, ListBox2.Font).Width
            '  If wrong Then
            e.Graphics.FillRectangle(Brushes.LightSkyBlue, New Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height))
            'Else
            '    e.Graphics.FillRectangle(If(e.Index Mod 2 = 1, Brushes.AliceBlue, Brushes.White), New Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height))
            'End If
        Else


            e.Graphics.FillRectangle(If(e.Index Mod 2 = 1, Brushes.AliceBlue, Brushes.White), e.Bounds)
        End If
        'If InStr(Invalid, ListBox2.Items(e.Index).ToString.Split(Chr(9)).First) > 0 Then
        'e.Graphics.DrawString(ListBox2.Items(e.Index).ToString, ListBox2.Font, Brushes.DarkRed, e.Bounds)
        ' Else
        e.Graphics.DrawString(ListBox2.Items(e.Index).ToString, ListBox2.Font, Brushes.Black, e.Bounds)
        'End If

    End Sub
    Private Sub Label1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label1.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += MousePosition - LastLoc
            LastLoc = MousePosition
        Else
            LastLoc = MousePosition
        End If
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox2.SelectedIndexChanged
        Try
            If Editor.CageMesh IsNot Nothing Then
                Render.ScnMgr.AddToDeletionQueue(Editor.CageMesh)

            End If
        Catch ex As Exception

        End Try



        'Settings.Button5_Click(sender, e)
        ListBox2_DoubleClick(sender, e)
        Settings.CheckBox1_CheckedChanged(sender, e)
        If Settings.CheckBox18.Checked And (Editor.CheckBox1.Checked Or Editor.CheckBox2.Checked Or Editor.CheckBox3.Checked) Then SoundOn()
        SaveSetting("car load", "settings", "index", ListBox2.SelectedIndex)
        Label20.Text = "#" & ListBox2.SelectedIndex
        Editor.KdlCheckbox10_CheckedChanged(sender, e)
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Shell("explorer.exe http://z3.invisionfree.com/Revolt_Live/", AppWinStyle.NormalFocus)
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Settings.Timer1.Interval = NumericUpDown1.Value * 1000
            Settings.Timer1.Start()
            NumericUpDown1.Maximum = ListBox2.Items.Count - 1
        ElseIf CheckBox1.Checked = False Then
            Settings.Timer1.Stop()

        End If
    End Sub

    Private Sub NumericUpDown1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown1.ValueChanged
        Settings.Timer1.Interval = NumericUpDown1.Value * 1000
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Application.DoEvents()
        If Me.Width = 587 Then
            Do Until Panel3.Left <= 12
                Application.DoEvents()
                Panel3.Left -= 2
                ' Button2.Left -= 2
                Me.Width -= 2
            Loop
        Else
            Do Until Me.Width = 587
                Application.DoEvents()
                Panel3.Left += 2
                ' Button2.Left += 2
                Me.Width += 2
            Loop
        End If
    End Sub


    Private Sub TrackBar1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TrackBar1.ValueChanged
        If _Wheel(0) Is Nothing Or _Wheel(1) Is Nothing Then Exit Sub
        If TrackBar1.Value = 0 Then Exit Sub
        _Wheel(0).ScnNode.Rotation = New IrrlichtNETCP.Vector3D(0, -TrackBar1.Value, 0)
        '  _Wheel(1).ScnNode.Render()
        _Wheel(1).ScnNode.Rotation = New IrrlichtNETCP.Vector3D(0, -TrackBar1.Value, 0)


    End Sub

    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar1.Scroll

    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged

        If CheckBox2.Checked = False Then
            Editor.Timer1.Stop()
        Else
            Editor.LastCampos = Render.cam.Position
            Editor.Timer1.Start()


        End If

    End Sub

    Private Sub Label17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label17_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.GotFocus
        If TextBox1.Text = "Search" Then TextBox1.Text = ""

        TextBox1.ForeColor = Drawing.Color.Black
        '    TextBox1.Font = New Drawing.Font(Drawing.FontFamily.GenericSansSerif, 8.25, FontStyle.Regular, GraphicsUnit.Point)
        Do Until TextBox1.Width >= 160
            Application.DoEvents()
            TextBox1.Width += 1
            TextBox1.Left -= 1
            NumericUpDown1.Top += 1
            CheckBox1.Top += 1
            ' Application.DoEvents()
        Loop

        TextBox1.SelectionStart = Len(TextBox1.Text)

    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Escape Then
            ListBox2.Focus()
        End If

    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

    End Sub

    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.LostFocus
        If TextBox1.Text = "" Then

            TextBox1.Text = "Search"
            ListBox2.Items.AddRange(carList.Items())
            '   TextBox1.Font = New Drawing.Font(Drawing.FontFamily.GenericSansSerif, 8.25, FontStyle.Italic, GraphicsUnit.Point)

            TextBox1.ForeColor = Drawing.Color.Gray
            Do Until TextBox1.Width <= 90
                TextBox1.Width -= 1
                TextBox1.Left += 1
                Application.DoEvents()
                NumericUpDown1.Top -= 1
                CheckBox1.Top -= 1
            Loop

        End If
    End Sub
    Dim customSearchMode = False
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "Search" Then
            ListBox2.Items.AddRange(carList.Items())
        End If

        customSearchMode = InStr(TextBox1.Text, "#") > 0
        If Not Initialized Then Exit Sub
        ListBox2.Items.Clear()



        For i = 0 To carList.Items.Count - 1
            If InStr(carList.Items(i), TextBox1.Text, CompareMethod.Text) Then

                If Not customSearchMode Then
                    ListBox2.Items.Add(carList.Items(i))
                    Application.DoEvents()
                Else

                    'TODO: Carlist search

                End If


            End If
        Next
    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Car_browser_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim g As Drawing.Graphics = Me.CreateGraphics
        g.DrawArc(Pens.Black, 0, 0, 18, 18, 180, 90)


    End Sub
    Dim form_show = True
    Private Sub Label1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label1.DoubleClick
        If form_show Then
            form_show = False
            Me.Height = Label1.Height
        Else
            form_show = True
            Me.Height = 373
        End If
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        textviewer.TextBox1.Text = IO.File.ReadAllText((IO.Directory.GetFiles(_car.Path, "*read*me*")(0)))
        textviewer.TextBox1.SelectionStart = textviewer.TextBox1.SelectionLength
        textviewer.TextBox1.Select()

        textviewer.Show()
    End Sub
    Function NoZero(ByVal n As Single) As Single
        Return If(n = 0, 1, n)
    End Function
    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label2.MouseHover
        Tip.fShow("Available Physical Memory:" & Format(My.Computer.Info.AvailablePhysicalMemory / (1024 * 1024 * 1024), "#.#0") & "GB out of " & Format(My.Computer.Info.TotalPhysicalMemory / (1024 * 1024 * 1024), "#.#0") & "GB")

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Panel7.Visible = True


    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TextBox1.Focus()
        TextBox1.Text = "#mine"
        Panel7.Hide()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        Panel7.Hide()
        PanelfromRight(Panel8)
        TextBox2.Focus()
    End Sub
    Dim x As New Net.WebClient

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Application.DoEvents()
        TextBox3.AppendText("Getting " & TextBox2.Text & vbNewLine)
        Dim msg$ = x.DownloadString("http://rvzt.zackattackgames.com/main/comments.php?carname=" & Replace(TextBox2.Text, " ", "+"))

        If InStr(msg, "Error: no parameter found for value tag name author", CompareMethod.Text) > 0 Then
            TextBox3.AppendText("ERROR: NOT FOUND" & vbNewLine)


            '  Panel8.Hide()
            Exit Sub
        End If


        PanelToRight(Panel8)

        ShowPanel(Panel9)
        Dim pname$ = "http://rvzt.zackattackgames.com/dload/cars/images/" & Split(Split(msg, "<img src=""../dload/cars/images/")(1), Chr(34))(0)
        PictureBox1.ImageLocation = pname
        'Dim name$ = Split(Split(Split(msg, " <td class=""topic"">Car name:</td>")(1), "</a>")(0), ">")(1)
        Label29.Text = Replace(Split(Split(Split(msg, " <td class=""topic"">Car name:</td>")(1), "</a>")(0), ">")(2), vbNewLine, "")
        Label30.Text = CleanBuffer(Strings.Mid(Split(Split(Split(msg, " <td class=""topic"">Car author:</td>")(1), "</a>")(0), ">")(2), 4))
        Label31.Text = Split(Split(Split(msg, " <td class=""topic"">Downloads:</td>")(1), "</td>")(0), ">")(1)
        Label32.Text = Split(Split(Split(msg, " <td class=""topic"">Car type:</td>")(1), "</td>")(0), ">")(1)
        AddHandler x.DownloadProgressChanged, AddressOf progressChanged
        AddHandler x.DownloadDataCompleted, AddressOf Completed


        Application.DoEvents()

        If IO.File.Exists(tempDl) Then IO.File.Delete(tempDl)

        f = New IO.BinaryWriter(IO.File.Create(tempDl))




        x.DownloadDataAsync(New Uri("http://rvzt.zackattackgames.com/main/dload.php?carname=" & Replace(TextBox2.Text, " ", "+")))
        Do While (x.IsBusy) Or Not (finished)

            Application.DoEvents()

        Loop


        Try
            Dim V As New Ionic.Zip.ZipFile(tempDl)
            AddHandler V.ExtractProgress, AddressOf Extracting
            V.ExtractExistingFile = Ionic.Zip.ExtractExistingFileAction.OverwriteSilently


            V.ExtractAll(RvPath)


        Catch ex As Exception
            f.Close()
            f.BaseStream.Close()
            Try
                Dim V As New Ionic.Zip.ZipFile(tempDl)
                AddHandler V.ExtractProgress, AddressOf Extracting
                V.ExtractExistingFile = Ionic.Zip.ExtractExistingFileAction.OverwriteSilently


                V.ExtractAll(RvPath)
            Catch ex1 As Exception
                Tip.fShow("Sorry but things got wrong for some reason :(")

                hidePanel(Panel9)
                LoadAllCarsIntoList()


            End Try


        End Try




        hidePanel(Panel9)
        LoadAllCarsIntoList()
        TextBox1.Focus()
        TextBox1.Text = TextBox2.Text(0)
        For i = 1 To Len(TextBox2.Text) - 1
            TextBox1.Text &= TextBox2.Text(i)
            TextBox1.SelectionStart = Len(TextBox1.Text)
            Application.DoEvents()
            Threading.Thread.Sleep(10)

        Next

        ListBox2.SelectedIndex = 0

    End Sub
    Dim finished = False
    Dim f As IO.BinaryWriter


    Dim tempDl$ = My.Computer.FileSystem.SpecialDirectories.Temp & "\carload_tempcar.zip"
    Sub progressChanged(ByVal sender As Object, ByVal e As Net.DownloadProgressChangedEventArgs)
        Application.DoEvents()
        ProgressBar1.Style = ProgressBarStyle.Continuous

        ProgressBar1.Value = e.ProgressPercentage
        Label33.Text = "Downloading (" & Int(ProgressBar1.Value) & "%)"




    End Sub
    Function CleanBuffer(ByVal str As String) As String
        Do Until LCase(str(0)) >= "a" And LCase(str(0)) <= "z"
            str = Mid(str, 2)
        Loop

        Return str
    End Function
    Sub Completed(ByVal sender As Object, ByVal e As Net.DownloadDataCompletedEventArgs)
        f.Write(e.Result)
        f.Close()
        finished = True
    End Sub
    Sub Extracting(ByVal sender As Object, ByVal e As Ionic.Zip.ExtractProgressEventArgs)
        Application.DoEvents()
        Try
            ProgressBar1.Value = e.EntriesTotal * 100 / (e.EntriesTotal + Double.Epsilon)

        Catch ex As Exception

        End Try
        Label33.Text = "Extracting ..."
        ProgressBar1.Style = ProgressBarStyle.Marquee

    End Sub
    Private Sub Label30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label30.Click

    End Sub

    Private Sub Panel9_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel9.Paint

    End Sub

    Private Sub TextBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then Button7_Click(sender, e)
    End Sub



    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        PanelToRight(Panel8)

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

    End Sub
End Class
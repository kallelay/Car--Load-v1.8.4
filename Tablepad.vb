Imports IrrlichtNETCP
Imports System.Drawing


Public Class Tablepad
    Sub UnLockAllForms()
        Settings.Enabled = True
        Car_browser.Enabled = True
        Editor.Enabled = True
        Me.Hide()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        UnLockAllForms()

        Select Case Current_Editing_Mode
            Case CurEdMod.CoM
                _car.Theory.RealInfos.COM = m.Position
            Case CurEdMod.Weapon
                _car.Theory.RealInfos.WeaponGeneration = m.Position
            Case CurEdMod.Body
                _car.Theory.Body.Offset = m.Position
            Case CurEdMod.wheel0_0
                _car.Theory.wheel(0).Offset(1) = m.Position
            Case CurEdMod.wheel1_0
                _car.Theory.wheel(1).Offset(1) = m.Position
            Case CurEdMod.wheel2_0
                _car.Theory.wheel(2).Offset(1) = m.Position
            Case CurEdMod.wheel3_0
                _car.Theory.wheel(3).Offset(1) = m.Position
        End Select

        m.Visible = False
        Current_Editing_Mode = CurEdMod.none

        Me.Hide()


    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
    Dim mpos As Point
    Dim PosXY As Point
    Dim PosZ As Point
    Private Sub Label1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label1.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += MousePosition - mpos
            mpos = MousePosition
        Else
            mpos = MousePosition
        End If
    End Sub

    Private Sub Panel1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel1.MouseLeave
        Panel1.BackColor = Drawing.Color.AliceBlue
    End Sub
    Dim incX = -0.1
    Dim incY = 0.1

    Dim incZ = -0.1

    Dim invert = False

    Private Sub Panel1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If Panel1.BackColor <> Drawing.Color.LavenderBlush Then
            Panel1.BackColor = Drawing.Color.LavenderBlush
        End If




        If e.Button = Windows.Forms.MouseButtons.Left Then


            If invert = False Then
                m.Position = New IrrlichtNETCP.Vector3D(m.Position.X + (MousePosition.X - PosXY.X) * incX, m.Position.Y, m.Position.Z + (MousePosition.Y - PosXY.Y) * incY) ', m.Position.Z)

            Else
                m.Position = New IrrlichtNETCP.Vector3D(m.Position.X + (MousePosition.Y - PosXY.Y) * incY, m.Position.Y, m.Position.Z + (MousePosition.X - PosXY.X) * incX) ', m.Position.Z)
            End If

            'TODO: wheels etc.. move
            Select Case Current_Editing_Mode
                Case CurEdMod.Body
                    cBODY.ScnNode.Position = m.Position

            End Select






            PosXY = MousePosition


            'Y offset
        ElseIf e.Button = Windows.Forms.MouseButtons.Middle Then


            m.Position = New IrrlichtNETCP.Vector3D(m.Position.X, m.Position.Y + (MousePosition.Y - PosZ.Y) * incZ, m.Position.Z)

            Select Case Current_Editing_Mode
                Case CurEdMod.Body
                    cBODY.ScnNode.Position = m.Position

            End Select

            PosZ = MousePosition



        Else


            Select Case getPositionBlock(Render.cam.Position, New IrrlichtNETCP.Vector3D(0, 0, 0))
                Case 3
                    invert = False
                    incX = -0.1
                    incY = 0.1
                    m.Rotation = New IrrlichtNETCP.Vector3D(0, 0, 0)
                Case 1
                    invert = False
                    incX = 0.1
                    incY = -0.1
                    m.Rotation = New IrrlichtNETCP.Vector3D(0, 180, 0)
                Case 0
                    invert = True

                    incX = 0.1
                    incY = 0.1
                    m.Rotation = New IrrlichtNETCP.Vector3D(0, 90, 0)
                Case 2
                    incX = -0.1
                    incY = -0.1
                    m.Rotation = New IrrlichtNETCP.Vector3D(0, -90, 0)
                    invert = True

            End Select

            If CheckBox1.Checked Then
                incX *= 0.05
                incY *= 0.05
                incZ = 0.05 * -0.1
            Else
                incZ = -0.1
            End If

            PosZ = MousePosition
            PosXY = MousePosition
        End If

        Label2.Text = "x: " & Strings.Format(m.Position.X, "0#.#0")
        Label4.Text = "y: " & Strings.Format(m.Position.Y * 1.0, "0#.#0")
        Label5.Text = "z: " & Strings.Format(m.Position.Z * 1.0, "0#.#0")

        'Console.WriteLine("Car xyz=" & cBODY.ScnNode.Position.X & "," & cBODY.ScnNode.Position.Y & "," & cBODY.ScnNode.Position.Z)

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel2.MouseLeave
        Panel2.BackColor = Drawing.Color.AliceBlue
    End Sub

    Private Sub Panel2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel2.MouseMove
        If Panel2.BackColor <> Drawing.Color.LavenderBlush Then
            Panel2.BackColor = Drawing.Color.LavenderBlush
        End If




        If e.Button = Windows.Forms.MouseButtons.Left Then


            m.Position = New IrrlichtNETCP.Vector3D(m.Position.X, m.Position.Y + (MousePosition.Y - PosZ.Y) * incZ, m.Position.Z)

            Select Case Current_Editing_Mode
                Case CurEdMod.Body
                    cBODY.ScnNode.Position = m.Position
                Case CurEdMod.wheel0_0
                    _Wheel(0).ScnNode.Position = m.Position
                Case CurEdMod.wheel1_0
                    _Wheel(1).ScnNode.Position = m.Position
                Case CurEdMod.wheel2_0
                    _Wheel(2).ScnNode.Position = m.Position
                Case CurEdMod.wheel3_0
                    _Wheel(3).ScnNode.Position = m.Position
            End Select

            PosZ = MousePosition

        Else


            PosZ = MousePosition
        End If



        Label5.Text = "y: " & Strings.Format(m.Position.Y * 1.0, "0#.#0")

    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub
    Sub Hover(ByVal cmd As Button)
        Do Until cmd.Top <= 324
            Application.DoEvents()
            cmd.Top -= 2
            Threading.Thread.Sleep(10)
        Loop
    End Sub
    Sub HoverPanel(ByVal cmd As Button)
        Do Until cmd.Left <= 469
            Application.DoEvents()
            cmd.Left -= 2
            Threading.Thread.Sleep(10)
        Loop
    End Sub
    Sub unhover(ByVal cmd As Button)
        Do Until cmd.Top > 328
            Application.DoEvents()
            cmd.Top += 2
        Loop
    End Sub

    Sub unhoverPanel(ByVal cmd As Button)
        Do Until cmd.Left >= 479
            Application.DoEvents()
            cmd.Left += 2
        Loop
    End Sub

    Private Sub Tablepad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Tablepad_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        doLoad()
    End Sub
    Sub doLoad()
        If Me.Visible = False Then Me.Location = Settings.Location + New Point(Settings.Width + 50, -15)
        Label3.Text = "Edit: " & Current_Editing_Mode.ToString
        Select Case Current_Editing_Mode
            Case CurEdMod.CoM
                m.Position = _car.Theory.RealInfos.COM
            Case CurEdMod.Weapon
                m.Position = _car.Theory.RealInfos.WeaponGeneration
            Case CurEdMod.Body
                m.Position = _car.Theory.Body.Offset
            Case CurEdMod.wheel0_0
                m.Position = _car.Theory.wheel(0).Offset(1)
            Case CurEdMod.wheel1_0
                m.Position = _car.Theory.wheel(1).Offset(1)
            Case CurEdMod.wheel2_0
                m.Position = _car.Theory.wheel(2).Offset(1)
            Case CurEdMod.wheel3_0
                m.Position = _car.Theory.wheel(3).Offset(1)
        End Select


        m.Visible = True

        Label2.Text = "x: " & Strings.Format(m.Position.X * 1.0, "0#.#0")
        Label4.Text = "y: " & Strings.Format(m.Position.Y * 1.0, "0#.#0")
        Label5.Text = "z: " & Strings.Format(m.Position.Z * 1.0, "0#.#0")
    End Sub
    Sub redoLoad()
        Select Case Current_Editing_Mode
            Case CurEdMod.CoM
                m.Position = _car.Theory.RealInfos.COM
            Case CurEdMod.Weapon
                m.Position = _car.Theory.RealInfos.WeaponGeneration
            Case CurEdMod.Body
                m.Position = _car.Theory.Body.Offset
                cBODY.ScnNode.Position = _car.Theory.Body.Offset
            Case CurEdMod.wheel0_0
                m.Position = _car.Theory.wheel(0).Offset(1)
                _Wheel(0).ScnNode.Position = _car.Theory.wheel(0).Offset(1)
            Case CurEdMod.wheel1_0
                m.Position = _car.Theory.wheel(1).Offset(1)
                _Wheel(1).ScnNode.Position = _car.Theory.wheel(1).Offset(1)
            Case CurEdMod.wheel2_0
                m.Position = _car.Theory.wheel(2).Offset(1)
                _Wheel(2).ScnNode.Position = _car.Theory.wheel(2).Offset(1)
            Case CurEdMod.wheel3_0
                m.Position = _car.Theory.wheel(3).Offset(1)
                _Wheel(3).ScnNode.Position = _car.Theory.wheel(3).Offset(1)
        End Select
    End Sub
    Private Sub Button1_MouseMove(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseMove
        Hover(Button1)
    End Sub
    Private Sub Button1_MouseOut(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        unhover(Button1)
    End Sub
    Private Sub button2_MouseMove(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.MouseMove
        Hover(Button2)
    End Sub
    Private Sub button2_MouseOut(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.MouseLeave
        unhover(Button2)
    End Sub
    Private Sub button3_MouseMove(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.MouseMove
        Hover(Button3)
    End Sub
    Private Sub button3_MouseOut(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.MouseLeave
        unhover(Button3)
    End Sub
    Private Sub button4_MouseMove(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.MouseMove
        Hover(Button4)
    End Sub
    Private Sub button4_MouseOut(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.MouseLeave
        unhover(Button4)
    End Sub
    Private Sub button5_MouseMove(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.MouseMove
        Hover(Button5)
    End Sub
    Private Sub button5_MouseOut(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.MouseLeave
        unhover(Button5)
    End Sub
    Private Sub button6_MouseMove(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.MouseMove
        Hover(Button6)
    End Sub
    Private Sub button6_MouseOut(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.MouseLeave
        unhover(Button6)
    End Sub
    Private Sub button7_MouseMove(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.MouseMove
        HoverPanel(Button7)
    End Sub
    Private Sub button7_MouseOut(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.MouseLeave
        unhoverPanel(Button7)
    End Sub
    Private Sub button8_MouseMove(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.MouseMove
        HoverPanel(Button8)
    End Sub
    Private Sub button8_MouseOut(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.MouseLeave
        unhoverPanel(Button8)
    End Sub
    Public nPos As IrrlichtNETCP.Vector3D
    Public incVec As New IrrlichtNETCP.Vector3D
    Sub ActivateTimer(ByVal i As Single, ByVal j As Single, ByVal k As Single, ByVal newpos As IrrlichtNETCP.Vector3D)
        Timer1.Start()
        incVec = New IrrlichtNETCP.Vector3D(i, j, k)
        nPos = newpos
    End Sub
    Public Sub TranslateCamera(ByVal oldpos As IrrlichtNETCP.Vector3D, ByVal newpos As IrrlichtNETCP.Vector3D, ByRef camScnNode As IrrlichtNETCP.SceneNode)
        Dim diff As IrrlichtNETCP.Vector3D = newpos - oldpos 'diff vector

        Dim mMax As Single = Math.Abs(diff.X)
        If mMax < Math.Abs(diff.Y) Then mMax = Math.Abs(diff.Y)
        If mMax < Math.Abs(diff.Z) Then mMax = Math.Abs(diff.Z)


        Dim i, j, k As Single
        i = diff.X / mMax
        j = diff.Y / mMax
        k = diff.Z / mMax

        ActivateTimer(i, j, k, newpos)

        Render.cam.Rotation = New Vector3D(0, 0, 0)



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TranslateCamera(Render.cam.Position, New IrrlichtNETCP.Vector3D(0, 0, -15), Render.cam)
        TranslateCamera(Render.cam.Position, New IrrlichtNETCP.Vector3D(0, 15, 0), Render.cam)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Dim i = incVec.X
        Dim j = incVec.Y
        Dim k = incVec.Z


        Render.cam.Position += New IrrlichtNETCP.Vector3D(i, j, k)

        If Math.Abs(i) = 1 Then
            If Int(Math.Abs(Render.cam.Position.X - nPos.X)) <= 1 Then
                Timer1.Stop()
            End If
        End If

        If Math.Abs(j) = 1 Then
            If Int(Math.Abs(Render.cam.Position.Y - nPos.Y)) <= 1 Then
                Timer1.Stop()
            End If
        End If
        If Math.Abs(k) = 1 Then
            If Int(Math.Abs(Render.cam.Position.Z - nPos.Z)) <= 1 Then
                Timer1.Stop()
            End If

        End If




    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TranslateCamera(Render.cam.Position, New IrrlichtNETCP.Vector3D(0, -15, 0), Render.cam)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TranslateCamera(Render.cam.Position, New IrrlichtNETCP.Vector3D(-15, 0, 0), Render.cam)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TranslateCamera(Render.cam.Position, New IrrlichtNETCP.Vector3D(15, 0, 0), Render.cam)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        TranslateCamera(Render.cam.Position, New IrrlichtNETCP.Vector3D(0, 0, 15), Render.cam)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        TranslateCamera(Render.cam.Position, New IrrlichtNETCP.Vector3D(0, 0, -15), Render.cam)
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        'Label28.Show()
        Select Case Current_Editing_Mode
            Case CurEdMod.CoM
                Try
                    Dim v1 = (_car.Theory.wheel(0).Offset(1) + _car.Theory.wheel(1).Offset(1)) / 2
                    Dim v2 = (_car.Theory.wheel(2).Offset(1) + _car.Theory.wheel(3).Offset(1)) / 2
                    _car.Theory.RealInfos.COM = (v1 + v2) / 2
                    m.Position = (v1 + v2) / 2
                Catch 'ex As Exception
                    Try
                        Dim v1 = (_car.Theory.wheel(0).Offset(1) + _car.Theory.wheel(1).Offset(1)) / 2
                        _car.Theory.RealInfos.COM = v1
                        m.Position = v1
                    Catch 'ex As Exception
                        message.Message("sorry, wheels needed to be present!")
                    End Try

                End Try


            Case CurEdMod.Weapon
                m.Position = New IrrlichtNETCP.Vector3D((cBODY.BoundingBox.maxX + cBODY.BoundingBox.minX) / 2, cBODY.BoundingBox.maxY - 2, cBODY.BoundingBox.maxZ + 2)
                _car.Theory.RealInfos.WeaponGeneration = New IrrlichtNETCP.Vector3D((cBODY.BoundingBox.maxX + cBODY.BoundingBox.minX) / 2, cBODY.BoundingBox.maxY - 2, cBODY.BoundingBox.maxZ + 2)

            Case CurEdMod.Body
                m.Position = New Vector3D(0, 0, 0)


        End Select

    End Sub
    Sub Hover_2()

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click

        Select Case Current_Editing_Mode
            Case CurEdMod.CoM
                _car.Theory.RealInfos.COM = Car_browser.Car_As_Loaded.Theory.RealInfos.COM

            Case CurEdMod.Body
                _car.Theory.Body.Offset = Car_browser.Car_As_Loaded.Theory.Body.Offset

            Case CurEdMod.Weapon
                _car.Theory.RealInfos.WeaponGeneration = Car_browser.Car_As_Loaded.Theory.RealInfos.WeaponGeneration
            Case CurEdMod.wheel0_0
                _car.Theory.wheel(0).Offset(1) = Car_browser.Car_As_Loaded.Theory.wheel(0).Offset(1)
            Case CurEdMod.wheel1_0
                _car.Theory.wheel(1).Offset(1) = Car_browser.Car_As_Loaded.Theory.wheel(1).Offset(1)
            Case CurEdMod.wheel2_0
                _car.Theory.wheel(2).Offset(1) = Car_browser.Car_As_Loaded.Theory.wheel(2).Offset(1)
            Case CurEdMod.wheel3_0
                _car.Theory.wheel(3).Offset(1) = Car_browser.Car_As_Loaded.Theory.wheel(3).Offset(1)
        End Select

        redoLoad()

    End Sub


    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

    End Sub
End Class
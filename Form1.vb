Imports System.Math
Public Class RenderForm
    Dim LastLoc As Point
    Dim R As IrrlichtNETCP.Color


    Private Sub RenderForm_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If Editor.WindowState = FormWindowState.Normal Then Exit Sub
        Car_browser.WindowState = FormWindowState.Normal
        Editor.WindowState = FormWindowState.Normal
        Settings.WindowState = FormWindowState.Normal

    End Sub

    Private Sub RenderForm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
    
    End Sub
    Dim form_show = True
    Private Sub Label1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label1.DoubleClick
        If form_show Then
            form_show = False
            Me.Height = Label1.Height
        Else
            form_show = True
            Me.Height = 600
        End If
    End Sub

    Private Sub Label1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label1.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += MousePosition - LastLoc
            LastLoc = MousePosition
        Else
            LastLoc = MousePosition
        End If
    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Randomize()
        Randomize()
        Dim c = Rnd() * 20 + 235
        R = New IrrlichtNETCP.Color(255, Int(255 * (1 - Exp(-Rnd() * 255 / 51))), 128 + Int(128 * (1 - Exp(-Rnd() * 255 / 51))), Int(c))
        Timer2.Start()



    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick


        If R.R < Render._cc.R Then Render._cc.R -= 1
        If R.R > Render._cc.R Then Render._cc.R += 1



        If R.G < Render._cc.G Then Render._cc.G -= 1
        If R.G > Render._cc.G Then Render._cc.G += 1



        If R.B < Render._cc.B Then Render._cc.B -= 1
        If R.B > Render._cc.B Then Render._cc.B += 1


    End Sub
    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        If MoveMode Then
            Me.Size = New Size((MousePosition - Me.Location).X, (MousePosition - Me.Location).Y)
        End If



        If _car.Theory Is Nothing Then Exit Sub


        If _car.Theory.Spinner Is Nothing Then Exit Sub
        If _car.Theory.Spinner.modelNumber = -1 Then Exit Sub
        If _car.Theory.Spinner Is Nothing Then Exit Sub
        If _Spinner Is Nothing Then Exit Sub
        If _Spinner.ScnNode Is Nothing Then Exit Sub

        ' Timer3.Interval = Int(1000 / Render.VideoDriver.FPS)


        'Catch
        ' End Try



    End Sub

    Private Sub RenderForm_RegionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.RegionChanged

    End Sub

    Private Sub RenderForm_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        Label2.Location = New Point(Me.Width, Me.Height) - New Point(5, 5)

        Exit Sub

        Dim p As New Drawing2D.GraphicsPath()
        p.StartFigure()
        p.AddArc(New Rectangle(0, 0, 5, 5), 180, 90)
        p.AddLine(5, 0, Me.Width - 5, 0)
        p.AddArc(New Rectangle(Me.Width - 5, 0, 5, 5), -90, 90)
        p.AddLine(Me.Width, 5, Me.Width, Me.Height - 5)
        p.AddArc(New Rectangle(Me.Width - 5, Me.Height - 5, 5, 5), 0, 90)
        p.AddLine(Me.Width - 5, Me.Height, 5, Me.Height)
        p.AddArc(New Rectangle(0, Me.Height - 5, 5, 5), 90, 90)
        p.CloseFigure()
        Me.Region = New Region(p)

        p.Dispose()
    End Sub

    Private Sub RenderForm_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Dim LastSize As Point
    Private Sub Label2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label2.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Size = New Point(Me.Width, Me.Height) + MousePosition - LastSize
            LastSize = MousePosition
        Else
            LastSize = MousePosition
        End If
    End Sub





    Private Sub ToolTip1_Popup(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PopupEventArgs) Handles ToolTip1.Popup

    End Sub
    Dim lastpos As Point
    Dim beta As Single = 0
    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        If Render.Activated Then
            ' Render.alpha += 0.01
            '

            Render.alpha += (MousePosition.X - lastpos.X) / 150
            beta += (MousePosition.Y - lastpos.Y) / 150

            'Render.cam.Position = New IrrlichtNETCP.Vector3D(Render.cam.Target.X + Math.Cos(Render.alpha) * Render.cte, Render.cam.Target.Y, Render.cam.Target.Z + -Math.Sin(Render.alpha) * Render.cte)
            Render.cam.UpVector = New IrrlichtNETCP.Vector3D(0, 1, 0)
            '          Render.cam.Position.RotateXYBy(Render.alpha * 180, Render.cam.Position)
            '  Render.cam.Position = New IrrlichtNETCP.Vector3D(Render.cam.Target.X + Math.Cos(Render.alpha) * Render.cte, Render.cam.Position.Y, Render.cam.Target.Z + -Math.Sin(Render.alpha) * Render.cte)
            '  Render.cam.Position = New IrrlichtNETCP.Vector3D(Render.cam.Position.X, Render.cam.Target.Y + Math.Sin(beta) * Render.cte, Render.cam.Target.Z + Math.Cos(beta) * Render.cte)
            lastpos = MousePosition
        Else
            lastpos = MousePosition
        End If

    End Sub

    Private Sub picturebox1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picturebox1.Click

    End Sub

    Private Sub Timer5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer5.Tick

        Car_browser.Label2.Text = Format(Process.GetCurrentProcess.PrivateMemorySize / (1024 * 1024), "0#.#0") & "MB used"
        Dim intense = My.Computer.Info.AvailablePhysicalMemory / My.Computer.Info.TotalPhysicalMemory
        'Car_browser.ToolTip1.SetToolTip(Car_browser.Label2, "Virtual memory used/Total VRAM (in MB):" & vbNewLine & Format(Process.GetCurrentProcess.PrivateMemorySize / (1024 * 1024), "0#.#0") & "/" & Format(My.Computer.Info.TotalPhysicalMemory / (1024 * 1024), "0#.#0"))
          Car_browser.Label2.ForeColor = Color.FromArgb(255 * intense, (1 - intense) * 255, 0)
    End Sub
    Public Restarting = False
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        If YesNo.Message("Are you sure about restarting " & Application.ProductName) = Windows.Forms.DialogResult.Yes Then

            Process.Start(Application.ExecutablePath, "/loadlast")
            Restarting = True
            Settings.Button1_Click(sender, e)


        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
            Settings.Button1_Click(sender, e)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
        Settings.WindowState = FormWindowState.Minimized
        Car_browser.WindowState = FormWindowState.Minimized
        Directory.WindowState = FormWindowState.Minimized
        Editor.WindowState = FormWindowState.Minimized
    End Sub
    Dim previewMode = False
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Not previewMode Then
            previewMode = True
            Settings.Hide()
            Editor.Hide()
            Car_browser.Hide()
        Else
            previewMode = False
            Settings.Show()
            Editor.Show()
            Car_browser.Show()
        End If
    End Sub
    Dim MoveMode = False

    Private Sub Panel1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
        MoveMode = True
    End Sub

    Private Sub Panel1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseUp
        MoveMode = False
    End Sub
End Class

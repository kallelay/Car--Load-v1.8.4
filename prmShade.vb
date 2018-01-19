Public Class prmShade
    Sub setColor()
        Panel1.BackColor = Color.FromArgb(TrackBar4.Value, TrackBar1.Value, TrackBar2.Value, TrackBar3.Value)
        Render.ScnMgr.MeshManipulator.SetVertexColors(cBODY.mesh, New IrrlichtNETCP.Color(255, TrackBar1.Value, TrackBar2.Value, TrackBar3.Value))
    End Sub
    Function PointInBox(ByVal pt1 As Point, ByVal minBox As Point, ByVal maxBox As Point) As Boolean
        If pt1.X >= minBox.X And pt1.Y >= minBox.Y Then
            If pt1.X <= maxBox.X And pt1.Y <= maxBox.Y Then
                Return True
            End If
        Else
            Return False
        End If
    End Function

    Sub fadeOut()
        If Me.Opacity > 0.7 Then
            Me.Refresh()

            Application.DoEvents()
            Threading.Thread.Sleep(15)
            Me.Opacity -= 0.01


        End If
    End Sub

    Sub fadeIn()
        If Me.Opacity < 0.85 Then
            Me.Refresh()

            Threading.Thread.Sleep(5)

            Application.DoEvents()

            Me.Opacity += 0.02

        End If
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If PointInBox(MousePosition, Me.Location, Me.Location + Me.Size) Then
            fadeIn()
        Else
            fadeOut()
        End If
    End Sub
    Private Sub prmShade_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar1.Scroll
        setColor()
    End Sub

    Private Sub TrackBar2_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar2.Scroll
        setColor()
    End Sub

    Private Sub TrackBar3_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar3.Scroll
        setColor()
    End Sub

    Private Sub TrackBar4_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar4.Scroll
        setColor()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If YesNo.Message("Do you want to use 'y'? " & vbNewLine & " When set to 'y', the shading will be shaded according to the current color (use bright colors then!)" & vbNewLine & " If 'n', the exact color values will be used.") = Windows.Forms.DialogResult.Yes Then

            Process.Start(rvShade_Path, String.Format("""{0}"" y {1} {2} {3}", RvPath & _car.Theory.MainInfos.Model(_car.Theory.Body.modelNumber), TrackBar1.Value, TrackBar2.Value, TrackBar3.Value))

        Else
            Process.Start(rvShade_Path, String.Format("""{0}"" n {1} {2} {3}", RvPath & _car.Theory.MainInfos.Model(_car.Theory.Body.modelNumber), TrackBar1.Value, TrackBar2.Value, TrackBar3.Value))


        End If
        Me.Hide()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If YesNo.Message("Are you sure about canceling?") = Windows.Forms.DialogResult.Yes Then
            Me.Hide()
            Car_browser.LoadOneCar()
        End If
    End Sub

    Private Sub prmShade_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Settings.Checkbox1.Checked = False
    End Sub
End Class
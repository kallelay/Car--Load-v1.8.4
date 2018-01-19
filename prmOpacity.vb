Public Class prmOpacity

    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar1.Scroll
        Label1.BackColor = Color.FromArgb(TrackBar1.Value, Label1.BackColor.R, Label1.BackColor.G, Label1.BackColor.B)
        Label1.Text = TrackBar1.Value
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        If Not WHEELMODE Then Process.Start(PRM_Path, String.Format("trans ""{0}"" {1}", RvPath & _car.Theory.MainInfos.Model(_car.Theory.Body.modelNumber), TrackBar1.Value))
        If WHEELMODE Then Process.Start(PRM_Path, String.Format("trans ""{0}"" {1}", RvPath & _car.Theory.MainInfos.Model(_car.Theory.wheel(Editor.Label51.Text).modelNumber), TrackBar1.Value))

        Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If YesNo.Message("Are you sure about canceling?") = Windows.Forms.DialogResult.Yes Then
            Me.Hide()
           End If
    End Sub

    Private Sub prmOpacity_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
Public Class YesNo

    Private Sub YesNo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Function Message(ByVal text$) As DialogResult
        TextBox1.Text = text
        Label1.Text = text
        Return Me.ShowDialog
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Me.DialogResult = Windows.Forms.DialogResult.Yes
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Me.DialogResult = Windows.Forms.DialogResult.No
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

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class
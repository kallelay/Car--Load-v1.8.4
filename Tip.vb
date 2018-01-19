Public Class Tip

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Location = New Point((Screen.PrimaryScreen.Bounds.Width - Me.Width) / 2, 0)
    End Sub
    Sub fShow(ByVal str$)

        If Me.Visible Then
            Query(str)
            Exit Sub
        End If

        Label1.Text = str
        Label1.Show()
        Me.Show()
        Me.TopMost = True
        Me.Opacity = 0.01
        Me.Top = -Me.Height

        For i = 0 To Me.Height
            Me.Top += 1
            Me.Opacity = i / Me.Height
            Threading.Thread.Sleep(10)
            Application.DoEvents()
        Next




    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        For i = 100 To 1 Step -1
            Me.Opacity = i / 100
            Threading.Thread.Sleep(10)
        Next
        Me.Close()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Me.TopMost = True
    End Sub
End Class
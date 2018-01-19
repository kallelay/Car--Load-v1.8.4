Imports Car_Load.myGlobal
Imports IrrlichtNETCP

Public Class prmGUI
    Public Stat As Xmod = Xmod.none
    Public Enum Xmod
        none
        Body
        wheel
        spring

        pin

        axle

        spinner


    End Enum
    'Public mSelect As Car_browser

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim res$ = String.Format("{0} {1} {2}", TrackBar2.Value / 1000, TrackBar3.Value / 1000, TrackBar4.Value / 1000)

        Select Case Stat
            Case Xmod.Body

                Process.Start(PRM_Path, String.Format("scale ""{0}"" {1}", RvPath & "\" & _car.Theory.MainInfos.Model(_car.Theory.Body.modelNumber), res))
                res = Replace(res, "  ", " ")
                cBODY.ScnNode.Scale = New IrrlichtNETCP.Vector3D(res.Split(" ")(0), res.Split(" ")(1), res.Split(" ")(2))



        End Select

        Stat = Xmod.none
        Me.Hide()
    End Sub

    Private Sub TrackBar3_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar3.Scroll
        ChangeSize()
    End Sub
    Sub ChangeSize()

        Select Case Stat
            Case Xmod.Body
                cBODY.ScnNode.Scale = New IrrlichtNETCP.Vector3D(TrackBar2.Value / 1000, TrackBar3.Value / 1000, TrackBar4.Value / 1000)

        End Select
    End Sub

    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar1.Scroll
        TrackBar3.Value = TrackBar1.Value
        TrackBar4.Value = TrackBar1.Value
        TrackBar2.Value = TrackBar1.Value
        ChangeSize()


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If YesNo.Message("Are you sure about canceling?") = Windows.Forms.DialogResult.Yes Then
            Select Case Stat
                Case Xmod.Body
                    cBODY.ScnNode.Scale = New Vector3D(1, 1, 1)

            End Select

            Me.Hide()

        End If

        Stat = Xmod.none
    End Sub

    Private Sub TrackBar4_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar4.Scroll
        ChangeSize()
    End Sub

    Private Sub TrackBar2_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar2.Scroll
        ChangeSize()
    End Sub
End Class
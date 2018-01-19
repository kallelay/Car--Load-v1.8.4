Imports SoundsSharpNameSpace
Public Class About
    Dim Snd As SoundsSharp.Music
    Dim SndMgr As New SoundsSharpNameSpace.SoundsSharp.SoundManager()

    Dim CenterPoint As New Point(Me.Width / 2, 120) ' Me.Height / 2)
    Dim cur = -1
    Public Class Credits
        Public Header As String
        Public Label As String

        Public Sub Add(ByVal H, ByVal L)
            Header = H
            Label = L
        End Sub
        Public Sub _Update()
            About._Big.Text = Header
            About._small.Text = Label
        End Sub
    End Class

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadAbout()
        Change()
        _Big.Top = Me.Height

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        _Big.Top -= 2
        _small.Top -= 2
        If Math.Abs(CenterPoint.Y - _Big.Top) = 0 Then
            Timer2.Start()
            Timer1.Stop()
        End If

        If _small.Top <= -_small.Height Then
            Change()
            _Big.Top = Me.Height
            _small.Top = _Big.Top + _Big.Height
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        _Big.Top -= 2
        _small.Top -= 2
        Timer2.Stop()
        Timer1.Start()
    End Sub

    Sub Change()
        cur += 1
        If cur >= Credit.Count - 1 Then cur = 0
        Credit(cur)._Update()
    End Sub

    Dim Credit(14) As Credits
    Sub LoadAbout()
        For i = 0 To 13
            Credit(i) = New Credits
        Next
        Credit(0).Add("Car.load()", "")
        Credit(1).Add("Project by", "Re-Volt Live Forum")
        Credit(2).Add("Main programmer", "KDL 'kfalcon' [Kallel A.Y]")
        Credit(3).Add("Ideas and Help", "Zipperrulez" & vbNewLine & "Burner94")
        Credit(4).Add("Graphics", "KDL 'Kfalcon'")
        Credit(5).Add("Icons", "Mix of KDE Oxygen and Crystal [xp]")
        Credit(6).Add("Help tooltips", "taken from Parameters Notes v5.2 (modified)")
        Credit(7).Add("AI's Help tooltips", " Car Ai Details In Parameters.txt, What to tweak and how")
        Credit(8).Add("Parameters Notes' Original creator", " Rex Reynolds.")
        Credit(9).Add("Parameters Notes' Revision Team (v5)", "SuperTard (coordinator)" & vbNewLine & "LaserBeams (base notes + revisions)" & vbNewLine & "Nairb (added notes + revisions)")
        Credit(10).Add("Car AI details", "Citywalker (tutorial maker)")

        Credit(11).Add("Thanks to", "Zipperrulez, Burner 94" & vbNewLine & "Re-Volt Live team" & vbNewLine & "Our Re-Volt Pub team")
        Credit(12).Add("Thanks to", "Citywalker for the nice AI tutorial :)")
        Credit(12).Add("Thanks to", "Huki, Jigebren for Re-Volt v1.2")
        Credit(12).Add("Thanks to", "ADX for openVolts and Rv first demos" & vbNewLine & "DarkSabre for documentation" & vbNewLine & "RTTux for FreeVolts")
        Credit(13).Add("Copyrights", "All rights reserved, RVL forum and Kallel© 2011" & vbNewLine & "License: Freeware, not open source")

    End Sub

    Private Sub About_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        Me.Close()
    End Sub

    Private Sub _small_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub _Big_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Big.Click
        Me.Close()
    End Sub
End Class

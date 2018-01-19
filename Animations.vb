
Imports System.Math

Module Animations
    Sub ShowPanel(ByRef pan As Panel)
        Dim l, r, t, b As Integer
        l = pan.Left
        r = pan.Width
        t = pan.Top
        b = pan.Height

        pan.Show()

        pan.Size = New Size(0, 0)
        pan.Location = New Point(l + r / 2, t + b / 2)

        Dim pasX As Single = r / Max(r, b)
        Dim pasY As Single = b / Max(r, b)

        Dim fWidth, fHeight, fTop, fLeft As Single 'float

        fLeft = l + r / 2
        fTop = t + b / 2

        For i = 0 To Max(r, b) + 20


            fWidth += pasX
            fLeft -= pasX / 2
            fHeight += pasY
            fTop -= pasY / 2


            pan.Location = New Point(Int(fLeft), Int(fTop))
            pan.Size = New Point(Int(fWidth), Int(fHeight))

        Next

        For i = 0 To 20
            Threading.Thread.Sleep(5)
            fWidth -= pasX
            fLeft += pasX / 2
            fHeight -= pasY
            fTop += pasY / 2


            pan.Location = New Point(Int(fLeft), Int(fTop))
            pan.Size = New Point(Int(fWidth), Int(fHeight))

        Next

    End Sub
    Sub hidePanel(ByRef pan As Panel)
        Dim l, r, t, b As Integer
        l = pan.Left
        r = pan.Width
        t = pan.Top
        b = pan.Height



        Dim pasX As Single = r / Max(r, b)
        Dim pasY As Single = b / Max(r, b)

        Dim fWidth, fHeight, fTop, fLeft As Single 'float

        fLeft = l ' + r / 2
        fTop = t ' + b / 2
        fHeight = b
        fWidth = r

        For i = 0 To Max(r, b) - 1


            fWidth -= pasX * 2
            fLeft += pasX
            fHeight -= pasY * 2
            fTop += pasY


            pan.Location = New Point(Int(fLeft), Int(fTop))
            pan.Size = New Point(Int(fWidth), Int(fHeight))

        Next

        pan.Hide()
        pan.Location = New Point(l, t)
        pan.Size = New Size(r, b)

    End Sub
    Sub PanelToRight(ByRef pan As Panel)
        Dim ix = pan.Left
        For i = 0 To 2 Step 0.01
            Threading.Thread.Sleep(5)
            pan.Left += Exp(i * 2)
            Application.DoEvents()
        Next
        pan.Hide()
        pan.Left = ix
    End Sub
    Sub PanelfromRight(ByRef pan As Panel)
        Dim ix = pan.Left
        pan.Show()
        pan.Left -= 600
        For i = 2 To 0 Step -0.01
            Threading.Thread.Sleep(5)
            pan.Left += Exp(i)
            Application.DoEvents()
        Next

        For i = pan.Left To ix Step -1
            Threading.Thread.Sleep(5)
            pan.Left -= 1

        Next

        ' pan.Left = ix
    End Sub
End Module

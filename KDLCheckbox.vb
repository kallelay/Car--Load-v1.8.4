Public Class KDLCheckbox
    Inherits CheckBox
    Dim aImg, hImg, Img As Drawing.Image


    Public Property Image_Normal() As Drawing.Image
        Get
            Return Img
        End Get
        Set(ByVal value As Drawing.Image)
            Img = value
            If hImg Is Nothing Then hImg = value
        End Set
    End Property
    Public Property Image_Hover() As Drawing.Image
        Get
            Return hImg
        End Get
        Set(ByVal value As Drawing.Image)
            hImg = value
        End Set
    End Property
    Public Property Image_Active() As Drawing.Image
        Get
            Return aImg
        End Get
        Set(ByVal value As Drawing.Image)
            aImg = value
        End Set
    End Property
    Public Property Txt() As String
        Get
            Return Me.Text
        End Get
        Set(ByVal value As String)
            Me.Text = value
        End Set
    End Property


    Protected Overrides Sub OnCheckedChanged(ByVal e As System.EventArgs)
        If Me.Checked Then
            Me.Image = aImg
            Me.ForeColor = Color.DarkGray
        Else
            Me.Image = Img
            Me.ForeColor = Color.Gray
        End If
        MyBase.OnCheckedChanged(e)

    End Sub
    Protected Overrides Sub OnCheckStateChanged(ByVal e As System.EventArgs)
        MyBase.OnCheckStateChanged(e)
        If Me.Checked Then
            Me.Image = aImg
            Me.ForeColor = Color.DarkGray
        Else
            Me.Image = Img
            Me.ForeColor = Color.Gray
        End If
    End Sub
    Protected Overrides Sub CreateHandle()
        MyBase.CreateHandle()
        If Me.Checked Then
            Me.Image = aImg
            Me.ForeColor = Color.DarkGray
        Else
            Me.Image = Img
            Me.ForeColor = Color.Gray
        End If
    End Sub




    Function CheckInbox() As Boolean
        If MousePosition.X > MyBase.Parent.Parent.Location.X + MyBase.Parent.Location.X + MyBase.Location.X And _
        MousePosition.X < MyBase.Parent.Parent.Location.X + MyBase.Parent.Location.X + MyBase.Location.X + MyBase.Size.Width And _
            MousePosition.Y > MyBase.Parent.Parent.Location.Y + MyBase.Parent.Location.Y + MyBase.Location.Y And _
            MousePosition.Y < MyBase.Parent.Parent.Location.Y + MyBase.Parent.Location.Y + MyBase.Location.Y + MyBase.Size.Height Then _
            Return True

        Return False
    End Function
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If CheckInbox() Then
            If Me.Image IsNot aImg Then Me.Image = hImg
            Me.ForeColor = Color.Black
        Else
            If Me.Image IsNot aImg Then
                Me.ForeColor = Color.Gray
                Me.Image = Img
            Else
                Me.ForeColor = Color.DarkGray
            End If

        End If
    End Sub
End Class

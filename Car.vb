Imports IrrlichtNETCP

Public Module Global_
    Function readPolys(ByVal file$) As Int16
        Try
            Dim x = New IO.BinaryReader(New IO.FileStream(file, IO.FileMode.Open))
            Dim y = x.ReadInt16()
            x.Close()
            Return y

        Catch ex As Exception
            Return 0
        End Try

    End Function
End Module

Public Class Car_theory
    Public MainInfos As New Main
    Public RealInfos As New Real_Inf
    Public Body As New Body
    Public wheel(4) As Wheel
    Public Spring(4) As Spring
    Public PIN(4) As PIN
    Public Axle(4) As Axle
    Public Spinner As Spinner
    Public Aerial As Aerial
    Public carAi As AI

    Function Clone() As Car_theory
        Dim J As New Car_theory
        J.MainInfos = MainInfos.Clone
        J.Body = Body.Clone
        J.RealInfos = RealInfos.Clone
        J.wheel = wheel.Clone
        J.Spring = Spring.Clone
        J.PIN = PIN.Clone
        J.Axle = Axle.Clone
        J.Spinner = Spinner.clone
        J.Aerial = Aerial.clone
        If J.carAi IsNot Nothing Then J.carAi = carAi.Clone
        Return J

    End Function
End Class
Public Class Main
    Public Name As String
    Public Model(19) As String
    Public Tpage As String
    Public CollFile As String
    Public EnvRGB As Vector3D
    Public TCarBox As String = "NONE"

    Public BESTTIME As Boolean
    Public SELECTABLE As Boolean
    Public car_class As Integer
    Public obtain As Integer
    Public Rating As Integer

    Public TopEnd As Single
    Public Acceleration As Single
    Public Weight As Single
    Public Handling As Single

    Public Trans As Single
    Public MaxRev As Single
    Function Clone() As Main
        Dim J As New Main()
        With J
            .Name = Replace(Name, ",", ".")

            .Model = Model
            .Tpage = Tpage
            .CollFile = CollFile
            .EnvRGB = EnvRGB
            .TCarBox = TCarBox

            .BESTTIME = BESTTIME
            .SELECTABLE = SELECTABLE
            .car_class = car_class
            .obtain = obtain
            .Rating = Rating

            .TopEnd = TopEnd
            .Acceleration = Acceleration
            .Weight = Weight
            .Handling = Handling
            .Trans = Trans
            .MaxRev = MaxRev


        End With

        Return J


    End Function
End Class

Public Class Real_Inf
    Public SteerRate As Double
    Public SteerMode As Double
    Public EngineRate As Double
    Public TopSpeed As Double
    Public DownForceModifier As Double
    Public COM As Vector3D
    Public WeaponGeneration As Vector3D

    Function Clone() As Real_Inf
        Dim j As New Real_Inf
        With j
            .SteerRate = SteerRate
            .SteerMode = SteerMode
            .EngineRate = EngineRate
            .TopSpeed = TopSpeed
            .DownForceModifier = DownForceModifier
            .COM = COM
            .WeaponGeneration = WeaponGeneration
        End With
        Return j
    End Function
End Class

Public Class Body
    Public modelNumber As Integer
    Public Offset As Vector3D
    Public Mass As Double
    Public Inertia(3) As Vector3D
    '  Public Gravity As Double
    Public Hardness As Double
    Public Resistance As Double
    Public AngleRes As Double
    Public ResMode As Double
    Public Grip As Double
    Public StaticFriction As Double
    Public KinematicFriction As Double

    Function Clone() As Body
        Dim j As New Body
        With j
            .modelNumber = modelNumber
            .Mass = Mass
            .Inertia = Inertia
            .Hardness = Hardness
            .Resistance = Resistance
            .AngleRes = AngleRes
            .ResMode = ResMode
            .Grip = Grip
            .StaticFriction = StaticFriction
            .KinematicFriction = KinematicFriction
        End With

        Return j


    End Function
End Class

Public Class Wheel
    Public modelNumber As Integer
    Public Offset(2) As Vector3D
    Public IsPresent As Boolean
    Public IsPowered As Boolean
    Public IsTurnable As Boolean
    Public SteerRatio As Double
    Public EngineRatio As Double
    Public Radius As Double
    Public Mass As Double
    Public Gravity As Double
    Public MaxPos As Double
    Public SkidWidth As Double
    Public ToeInn As Double
    Public AxleFriction As Double
    Public Grip As Double
    Public StaticFriction As Double
    Public KinematicFriction As Double
End Class

Public Class Spring
    Public modelNumber As Integer
    Public Offset As Vector3D
    Public Length As Double
    Public Stiffness As Double
    Public Damping As Double
    Public Restitution As Double
End Class
Public Class PIN
    Public modelNumber As Integer
    Public offSet As Vector3D
    Public Length As Double
End Class
Public Class Axle
    Public modelNumber As Integer
    Public offSet As Vector3D
    Public Length As Double
End Class
Public Class Spinner
    Public modelNumber As Integer
    Public offSet As Vector3D
    Public Axis As Vector3D
    Public angVel As Double

    Function Clone() As Spinner
        Dim j As New Spinner
        With j
            .modelNumber = modelNumber
            .offSet = offSet
            .Axis = Axis
            .angVel = angVel
        End With

        Return j
    End Function
End Class
Public Class Aerial
    Public ModelNumber As Integer
    Public TopModelNumber As Integer
    Public offset As Vector3D
    Public Direction As Vector3D
    Public length As Double
    Public stiffness As Double
    Public damping As Double
    Function Clone() As Aerial
        Dim j As New Aerial
        With j
            .ModelNumber = ModelNumber
            .TopModelNumber = TopModelNumber
            .offset = offset
            .Direction = Direction
            .length = length
            .stiffness = stiffness
            .damping = damping
        End With
        Return j
    End Function
End Class

Public Class AI
    Public UnderThresh As Double
    Public UnderRange As Double
    Public UnderFront As Double
    Public UnderRear As Double
    Public UnderMax As Double
    Public OverThresh As Double
    Public OverRange As Double
    Public OverMax As Double
    Public OverAccThresh As Double
    Public OverAccRange As Double
    Public PickupBias As Double
    Public BlockBias As Double
    Public OvertakeBias As Double
    Public Suspension As Double
    Public Aggression As Double
    Function Clone() As AI
        Dim j As New AI
        With j
            .UnderFront = UnderFront
            .UnderMax = UnderMax
            .UnderRange = UnderRange
            .UnderRear = UnderRear
            .UnderThresh = UnderThresh

            .OverAccRange = OverAccRange
            .OverAccThresh = OverAccThresh
            .OverMax = OverMax
            .OverRange = OverRange
            .OvertakeBias = OvertakeBias
            .OverThresh = OverThresh

            .PickupBias = PickupBias
            .BlockBias = BlockBias
            .Suspension = Suspension
            .Aggression = Aggression
        End With

        Return j
    End Function

End Class

Public Class Car
    Public DirName As String = ""
    Public Path As String
    Public Theory As Car_theory
    Public isLoading As Boolean = False
    Sub New(ByVal Path_ As String)
        Me.DirName = Split(Path_, "\").Last
        Path = Path_
    End Sub
    Public Sing As Singletons
    Sub Load()
        _car.isLoading = True
        'THIS IS DARNED!!!! TOOK ME 6 HOURS TO LOAD THE CAR WHAT THE HACKING WORLD ??!!
        Sing = New Singletons(Path & "\parameters.txt")

        Dim Main = sing.getSingleton("")
        Me.Theory = New Car_theory
        With Me.Theory.MainInfos
            .Name = Replace(Main.getValue("Name"), Chr(34), "")
            For t = 0 To 18

                .Model(t) = Replace(Main.getValue("MODEL " & vbTab & t), Chr(34), "")

                'incompetent car makers... goes here
                If .Model(t) = Nothing Then
                    .Model(t) = Main.getValue(" " & t)

                    'hotfix: KR car
                    If .Model(t) = Nothing Then .Model(t) = """NONE"""


                    Do Until .Model(t)(0) = Chr(34)
                        .Model(t) = Mid(.Model(t), 2)
                        If .Model(t) = "" Then .Model(t) = """NONE"""
                    Loop
                    .Model(t) = Replace(.Model(t), Chr(34), "")

                End If
            Next t

            .Tpage = Replace(Main.getValue("TPAGE"), Chr(34), "")
            If .Tpage.Length > 4 Then
                Do Until .Tpage(0) = "c" Or .Tpage(0) = "C"
                    .Tpage = Mid(.Tpage, 2)
                Loop
            End If


            .TCarBox = Replace(Main.getValue(";)TCARBOX"), Chr(34), "")
            Try

                If .TCarBox = Nothing Then Exit Try
                Do Until LCase(.TCarBox(0)) = "c"  ' Or .TCarBox(0) = "C"
                    .TCarBox = Mid(.TCarBox, 2)
                    If .TCarBox = Nothing Then Exit Do
                Loop


            Catch

            End Try




            .CollFile = Replace(Main.getValue("COLL"), Chr(34), "")
            .EnvRGB = StrToVector(Replace(Main.getValue("EnvRGB"), Chr(34), "")) * New Vector3D(1 / Render.ZoomFactor, -1 / Render.ZoomFactor, 1 / Render.ZoomFactor)


            .BESTTIME = StrToBool(Main.getValue("BestTime"))
            .SELECTABLE = StrToBool(Main.getValue("Selectable"))
            .car_class = Int(Main.getValue("Class"))
            .obtain = Int(Main.getValue("Obtain"))
            .Rating = Main.getValue("Rating")
            .TopEnd = Main.getValue("TopEnd")

            If InStr(.Name, "Acc") > 0 Then
                .Acceleration = Main.getValue("Acc ")
            Else
                .Acceleration = Main.getValue("Acc")
            End If

            .Weight = Main.getValue("Weight")
            .Handling = Main.getValue("Handling")
            .Trans = Main.getValue("Trans")
            .MaxRev = Main.getValue("MaxRevs")
        End With

        With Me.Theory.RealInfos
            .SteerRate = Main.getValue("SteerRate")
            .SteerMode = Main.getValue("SteerMod")
            .EngineRate = Main.getValue("EngineRate")
            .TopSpeed = Main.getValue("TopSpeed")
            .DownForceModifier = Main.getValue("DownForceMod")

            .COM = StrToVector(Main.getValue("CoM")) * New Vector3D(1, -1, 1)

            .WeaponGeneration = StrToVector(Main.getValue("Weapon"))


        End With

        Dim body = sing.getSingleton("BODY")
        With Me.Theory.Body
            .modelNumber = body.getValue("ModelNum")
            .Offset = StrToVector(body.getValue("Offset"))
            .Mass = body.getValue("Mass")

            Dim _inertia$ = body.get3LinesValue("Inertia")
            .Inertia(0) = StrToVector(Split(_inertia, vbNewLine)(0))
            .Inertia(1) = StrToVector(Split(_inertia, vbNewLine)(1))
            .Inertia(2) = StrToVector(Split(_inertia, vbNewLine)(2))


            '.Inertia(1) = StrToVector(body.getValue(" " & vbTab))
            ' MsgBox(.Inertia(1).X)


            '   .Gravity = body.getValue("Gravity		2200"))
            .Hardness = body.getValue("Hardness")
            .Resistance = body.getValue("Resistance")
            .AngleRes = body.getValue("AngRes")
            .ResMode = body.getValue("ResMod")
            .Grip = body.getValue("Grip")
            .StaticFriction = body.getValue("StaticFriction")
            .KinematicFriction = body.getValue("KineticFriction")
        End With

        For u = 0 To 3
            Dim Wheel = sing.getSingleton("WHEEL " & u)
            Me.Theory.wheel(u) = New Wheel
            With Me.Theory.wheel(u)
                .modelNumber = Wheel.getValue("ModelNum")
                .Offset(1) = StrToVector(Wheel.getValue("Offset1"))
                .Offset(2) = StrToVector(Wheel.getValue("Offset2"))
                .IsPresent = StrToBool(Wheel.getValue("IsPresent"))
                .IsPowered = StrToBool(Wheel.getValue("IsPowered"))
                .IsTurnable = StrToBool(Wheel.getValue("IsTurnable"))
                .SteerRatio = Wheel.getValue("SteerRatio")
                .EngineRatio = Wheel.getValue("EngineRatio")
                .Radius = Wheel.getValue("Radius")
                .Mass = Wheel.getValue("Mass")
                .Gravity = Wheel.getValue("Gravity")
                .MaxPos = Wheel.getValue("MaxPos")
                .SkidWidth = Wheel.getValue("SkidWidth")
                .ToeInn = Wheel.getValue("ToeIn")
                .AxleFriction = Wheel.getValue("AxleFriction")
                .Grip = Wheel.getValue("Grip")
                .StaticFriction = Wheel.getValue("StaticFriction")

            End With
        Next

        For u = 0 To 3
            Dim spring = sing.getSingleton("SPRING " & u)
            Me.Theory.Spring(u) = New Spring
            With Me.Theory.Spring(u)
                .modelNumber = spring.getValue("ModelNum")
                .Offset = StrToVector(spring.getValue("Offset"))
                .Length = spring.getValue("Length")
                .Stiffness = spring.getValue("Stiffness")
                .Damping = spring.getValue("Damping")
                .Restitution = spring.getValue("Restitution")
            End With
        Next


        For u = 0 To 3
            Dim PIN = sing.getSingleton("PIN " & u)
            Me.Theory.PIN(u) = New PIN
            With Me.Theory.PIN(u)
                .modelNumber = PIN.getValue("ModelNum")
                .offSet = StrToVector(PIN.getValue("Offset"))
                .Length = PIN.getValue("Length")
            End With
        Next

        For u = 0 To 3
            Dim axle = sing.getSingleton("AXLE " & u)
            Me.Theory.Axle(u) = New Axle
            With Me.Theory.Axle(u)
                .modelNumber = axle.getValue("ModelNum")
                .offSet = StrToVector(axle.getValue("Offset"))
                .Length = axle.getValue("Length")
            End With
        Next

        Dim Spinner = sing.getSingleton("SPINNER")
        Me.Theory.Spinner = New Spinner
        With Me.Theory.Spinner
            .modelNumber = Spinner.getValue("ModelNum")
            .offSet = StrToVector(Spinner.getValue("Offset"))
            .Axis = StrToVector(Spinner.getValue("Axis"))
            .angVel = Spinner.getValue("AngVel")

        End With

        Dim Aerial = sing.getSingleton("AERIAL")
        Me.Theory.Aerial = New Aerial
        With Me.Theory.Aerial
            .ModelNumber = Aerial.getValue("SecModelNum")
            .TopModelNumber = Aerial.getValue("TopModelNum")
            .offset = StrToVector(Aerial.getValue("Offset"))
            .Direction = StrToVector(Aerial.getValue("Direction"))
            .length = Aerial.getValue("Length")
            .stiffness = Aerial.getValue("Stiffness")
            .damping = Aerial.getValue("Damping")
        End With

        Dim Ai = sing.getSingleton("AI")
        If Ai Is Nothing Then Exit Sub
        Me.Theory.carAi = New AI
        With Me.Theory.carAi
            .UnderThresh = Ai.getValue("UnderThresh")
            .UnderRange = Ai.getValue("UnderRange")
            .UnderFront = Ai.getValue("UnderFront	")
            .UnderRear = Ai.getValue("UnderRear")
            .UnderMax = Ai.getValue("UnderMax")
            .OverThresh = Ai.getValue("OverThresh")
            .OverRange = Ai.getValue("OverRange")
            .OverMax = Ai.getValue("OverMax")
            .OverAccThresh = Ai.getValue("OverAccThresh")
            .OverAccRange = Ai.getValue("OverAccRange")
            .PickupBias = Ai.getValue("PickupBias")
            .BlockBias = Ai.getValue("BlockBias")
            .OvertakeBias = Ai.getValue("OvertakeBias")
            .Suspension = Ai.getValue("Suspension")
            .Aggression = Ai.getValue("Aggression")
        End With
        'Debugger.Break()
        'MsgBox(Me.Theory.RealInfos.TopSpeed)
    End Sub

    Function StrToVector(ByVal str As String) As Vector3D
        'On Error Resume Next
       


        If InStr(str, ",") > 0 And InStr(CSng(0.5), ".") > 0 Then str = str.Replace(",", "")




        'Our vector is X Y Z

        str = Replace(Replace(str, Chr(9), " ", , , CompareMethod.Text), Space(2), Space(1), , , CompareMethod.Text)
        str = str.Replace("�", "")
        Do Until str(0) <> " " Or Len(str) = 0
            str = Mid(str, 2)
        Loop
        Dim j = 1
        Do Until J = str.Length - 1
            If str(j) = " " And str(j - 1) = "," Then
                str = str.Remove(j - 1, 1)
                j -= 1
            End If
            j += 1
        Loop





        'If str.Split(" ")(0).Split(".").Length > 2 Then str = Replace(str, str.Split(" ")(0), str.Split(" ")(0).Split(".")(0) & "." & str.Split(" ")(0).Split(".")(1))
        'If str.Split(" ")(1).Split(".").Length > 2 Then str = Replace(str, str.Split(" ")(1), str.Split(" ")(1).Split(".")(0) & "." & str.Split(" ")(1).Split(".")(1))
        'If str.Split(" ")(2).Split(".").Length > 2 Then str = Replace(str, str.Split(" ")(2), str.Split(" ")(2).Split(".")(0) & "." & str.Split(" ")(2).Split(".")(1))

        Return New Vector3D(CDbl(str.Split(" ")(0)) * Render.ZoomFactor, _
        -CDbl(str.Split(" ")(1)) * Render.ZoomFactor, _
        CDbl(str.Split(" ")(2)) * Render.ZoomFactor)

    End Function

    Function StrToBool(ByVal str As String) As Boolean
        On Error Resume Next
        Return CBool(Replace(Replace(str, " ", ""), vbTab, ""))
    End Function
    Function StrToStr(ByVal str As String)
        Return Replace(Split(str, Chr(34))(1), Chr(34), "")
    End Function

End Class
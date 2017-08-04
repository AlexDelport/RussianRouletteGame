Public Class Gun
    'Gun class deals with the gun in its entirity.

    Dim myPen As New Pen(Drawing.Color.Black, 5) 'The pen used for drawing, with it's parameters.
    Dim myBrush1 As New SolidBrush(Color.Black) 'The two brushes used for filling, with their parameters.
    Dim myBrush2 As New SolidBrush(Color.White)

    ''Defining each drawing.
    Dim myCylinder As Graphics
    Dim myRatchet As Graphics
    Dim myChamberHole1 As Graphics
    Dim myChamberHole2 As Graphics
    Dim myChamberHole3 As Graphics
    Dim myChamberHole4 As Graphics
    Dim myChamberHole5 As Graphics
    Dim myChamberHole6 As Graphics

    'Both of these to be used for bullet position.
    Dim RandomNum As New Random
    Public ChamberNum As Integer

    Public Sub DrawChambers()
        myChamberHole1 = RussianRouletteStart.CreateGraphics
        myChamberHole2 = RussianRouletteStart.CreateGraphics
        myChamberHole3 = RussianRouletteStart.CreateGraphics
        myChamberHole4 = RussianRouletteStart.CreateGraphics
        myChamberHole5 = RussianRouletteStart.CreateGraphics
        myChamberHole6 = RussianRouletteStart.CreateGraphics
    End Sub

    Public Sub DrawCylinder()
        'Drawing the cylinder and 6 chamber holes.

        myCylinder = RussianRouletteStart.CreateGraphics
        myRatchet = RussianRouletteStart.CreateGraphics

        DrawChambers()

        myCylinder.DrawEllipse(myPen, 325, 100, 400, 400)
        myRatchet.DrawEllipse(myPen, 505, 280, 50, 50)
        myRatchet.FillEllipse(myBrush1, 505, 280, 50, 50)

        myChamberHole1.DrawEllipse(myPen, 345, 255, 100, 100)
        myChamberHole2.DrawEllipse(myPen, 410, 140, 100, 100)
        myChamberHole3.DrawEllipse(myPen, 540, 140, 100, 100)
        myChamberHole4.DrawEllipse(myPen, 605, 255, 100, 100)
        myChamberHole5.DrawEllipse(myPen, 540, 360, 100, 100)
        myChamberHole6.DrawEllipse(myPen, 410, 360, 100, 100)

    End Sub

    Public Sub LoadBullet()
        'Drawing the bullet inserted in the chamber by "filling" the chamber.
        myChamberHole1 = RussianRouletteStart.CreateGraphics
        myChamberHole1.FillEllipse(myBrush1, 345, 255, 100, 100)
    End Sub

    Public Sub SpinCylinder()
        'Spinning the chamber. 
        'The "spinning effect" is achieved by "filling/unfilling" chamber holes.

        DrawChambers()

        Dim LoopTime As Integer = 0

        Do

            Dim ChamberNum As Integer

            If ChamberNum = 7 Then
                ChamberNum = 0
            Else
                ChamberNum += 1
            End If

            Select Case ChamberNum

                Case 1
                    myChamberHole2.FillEllipse(myBrush1, 410, 140, 100, 100)
                    myChamberHole1.FillEllipse(myBrush2, 345, 255, 100, 100)

                Case 2
                    myChamberHole3.FillEllipse(myBrush1, 540, 140, 100, 100)
                    myChamberHole2.FillEllipse(myBrush2, 410, 140, 100, 100)

                Case 3
                    myChamberHole4.FillEllipse(myBrush1, 605, 255, 100, 100)
                    myChamberHole3.FillEllipse(myBrush2, 540, 140, 100, 100)

                Case 4
                    myChamberHole5.FillEllipse(myBrush1, 540, 360, 100, 100)
                    myChamberHole4.FillEllipse(myBrush2, 605, 255, 100, 100)

                Case 5
                    myChamberHole6.FillEllipse(myBrush1, 410, 360, 100, 100)
                    myChamberHole5.FillEllipse(myBrush2, 540, 360, 100, 100)

                Case 6
                    myChamberHole1.FillEllipse(myBrush1, 345, 255, 100, 100)
                    myChamberHole6.FillEllipse(myBrush2, 410, 360, 100, 100)

            End Select

            LoopTime += 20

        Loop Until LoopTime = 10000

    End Sub

    Function BulletPosition()
        'Assigning the bullet to a random gun chamber
        ChamberNum = RandomNum.Next(1, 7)
        Return ChamberNum
    End Function

    'All the gun sound effects, listed below.
    Sub PlaySpinningCylinderSound()
        My.Computer.Audio.Play(My.Resources.revolverSpinCylinder, AudioPlayMode.Background)
    End Sub

    Sub PlayEmptyShotSound()
        My.Computer.Audio.Play(My.Resources.revolverEmptyShot, AudioPlayMode.Background)
    End Sub

    Sub PlayGunShotSound()
        My.Computer.Audio.Play(My.Resources.revolverGunShot, AudioPlayMode.Background)
    End Sub

End Class

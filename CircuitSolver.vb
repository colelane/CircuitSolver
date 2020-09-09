Option Strict On
Option Explicit On
Option Compare Text
Module CircuitSolver

    Sub Main()
        Dim userInput As String
        Console.WriteLine("What kind of circuit would you like to solve?")
        Console.WriteLine("1. Lab 3 oscillator")
        userInput = Console.ReadLine()
        If userInput = "1" Then
            Lab3Oscillator()

        End If


    End Sub
    Sub Lab3Oscillator()
        Dim R1, R2, C1, C2, C3, C4, C5, CP, CGS, CGD, CDS, L1, L2, F As Double
        Dim XC1, XC2, XC3, XC4, XC5, XCP, XCGS, XCGD, XCDS, XL1, XL2, ZT, ZTAngle As Double
        Dim goodData As Boolean
        Const PI = 3.14159265359


        Do
            Try


                Console.WriteLine("What is the value of R1?")
                R1 = CDbl(Console.ReadLine)
                Console.WriteLine("What is the value of R2?")
                R2 = CDbl(Console.ReadLine)
                Console.WriteLine("What is the value of C1?")
                C1 = CDbl(Console.ReadLine)
                Console.WriteLine("What is the value of C2?")
                C2 = CDbl(Console.ReadLine)
                Console.WriteLine("What is the value of C3?")
                C3 = CDbl(Console.ReadLine)
                Console.WriteLine("What is the value of C4?")
                C4 = CDbl(Console.ReadLine)
                Console.WriteLine("What is the value of C5?")
                C5 = CDbl(Console.ReadLine)
                Console.WriteLine("What is the value of CProbe?")
                CP = CDbl(Console.ReadLine)
                Console.WriteLine("What is the value of CGS?")
                CGS = CDbl(Console.ReadLine)
                Console.WriteLine("What is the value of CGD?")
                CGD = CDbl(Console.ReadLine)
                Console.WriteLine("What is the value of CDS?")
                CDS = CDbl(Console.ReadLine)
                Console.WriteLine("What is the value of L1?")
                L1 = CDbl(Console.ReadLine)
                Console.WriteLine("What is the value of L2?")
                L2 = CDbl(Console.ReadLine)
                Console.WriteLine("What is the value of F?")
                F = CDbl(Console.ReadLine)

                goodData = True
            Catch
                Console.WriteLine("Type exact values, no K's")
                goodData = False
            End Try
        Loop Until goodData = True






        XC1 = (1 / (2 * PI * F * C1))
        XC2 = (1 / (2 * PI * F * C2))
        XC3 = (1 / (2 * PI * F * C3))
        XC4 = (1 / (2 * PI * F * C4))
        XC5 = (1 / (2 * PI * F * C5))
        XCP = (1 / (2 * PI * F * CP))
        XCGS = (1 / (2 * PI * F * CGS))
        XCGD = (1 / (2 * PI * F * CGD))
        XCDS = (1 / (2 * PI * F * CDS))
        XL1 = (2 * PI * F * L1)
        XL2 = (2 * PI * F * L2)

        Console.WriteLine("XC1 = " & XC1)
        Console.WriteLine("XC2 = " & XC2)
        Console.WriteLine("XC3 = " & XC3)
        Console.WriteLine("XC4 = " & XC4)
        Console.WriteLine("XC5 = " & XC5)
        Console.WriteLine("XCP = " & XCP)
        Console.WriteLine("XCGS = " & XCGS)
        Console.WriteLine("XCGD = " & XCGD)
        Console.WriteLine("XCDS = " & XCDS)
        Console.ReadLine()

        ZT = ((1 / ((1 / R1) + (1 / XC2))) + XL2)
        ZTAngle = Math.Atan(-XC2 / R1) + 90
        Console.WriteLine(ZT)
        Console.WriteLine(ZTAngle)
        Console.ReadLine()






    End Sub

End Module

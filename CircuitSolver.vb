Module CircuitSolver

    Sub Main()
        Dim userInput As String
        Console.WriteLine("What kind of circuit would you like to solve?")
        Console.WriteLine("1. Lab 3 oscillator")
        userInput = Console.ReadLine()
        If userInput = 1 Then
            Lab3Oscillator()

        End If


    End Sub
    Sub Lab3Oscillator()
        Dim R1, R2, C1, C2, C3, C4, C5, CP, CGS, CGD, CDS, L1, L2, F As String
        Dim XC1, XC2, XC3, XC4, XC5, XCP, XCGS, XCGD, XCDS, XL1, XL2 As Double
        Dim goodData As Boolean
        Const PI = 3.14159265359

        Do
            Try
                Console.WriteLine("What is the value of R1?")
                R1 = CInt(Console.ReadLine)
                Console.WriteLine("What is the value of R2?")
                R2 = CInt(Console.ReadLine)
                Console.WriteLine("What is the value of C1?")
                C1 = CInt(Console.ReadLine)
                Console.WriteLine("What is the value of C2?")
                C2 = CInt(Console.ReadLine)
                Console.WriteLine("What is the value of C3?")
                C3 = CInt(Console.ReadLine)
                Console.WriteLine("What is the value of C4?")
                C4 = CInt(Console.ReadLine)
                Console.WriteLine("What is the value of C5?")
                C5 = CInt(Console.ReadLine)
                Console.WriteLine("What is the value of CProbe?")
                CP = CInt(Console.ReadLine)
                Console.WriteLine("What is the value of CGS?")
                CGS = CInt(Console.ReadLine)
                Console.WriteLine("What is the value of CGD?")
                CGD = CInt(Console.ReadLine)
                Console.WriteLine("What is the value of CDS?")
                CDS = CInt(Console.ReadLine)
                Console.WriteLine("What is the value of L1?")
                L1 = CInt(Console.ReadLine)
                Console.WriteLine("What is the value of L2?")
                L2 = CInt(Console.ReadLine)
                Console.WriteLine("What is the value of F?")
                F = CInt(Console.ReadLine)

                goodData = True
            Catch
                Console.WriteLine("Type exact values, no K's")
                goodData = False
            End Try
        Loop Until goodData = True



    End Sub

End Module

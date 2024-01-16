Option Explicit On
Option Strict On
'Owen Fujii
'RCET 1265
'Spring 2024
'Simple Calculator
'https://github.com/Masaharu41/Simple-Calculator.git 

Imports Microsoft.VisualBasic.ApplicationServices

Module SimplCalculator

    Sub Main()
        'Assign Variables
        Dim num1 As Integer
        Dim num2 As Integer
        Dim userInput As String

        'Take user input numbers
        Console.WriteLine("First Numeric Input:")
        num1 = Console.ReadLine()
        Console.WriteLine("Second Numeric Input:")
        num2 = Console.ReadLine()

        Console.WriteLine("Operation Type" & vbNewLine _
                          & "1. Product" & vbNewLine _
                          & "2. Sum" & vbNewLine)

        userInput = Console.ReadLine() As String

        If userInput = "P" Then
            Console.WriteLine($"{num1} * {num2}")

        ElseIf userInput = "S" Then
            Console.WriteLine($"{num1} + {num2}")

        End If


        Console.WriteLine($"You have {num1} & {num2}")

        Console.Read()

    End Sub

End Module

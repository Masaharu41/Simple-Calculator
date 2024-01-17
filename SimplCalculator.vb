'Owen Fujii
'RCET 1265
'Spring 2024
'Simple Calculator
'https://github.com/Masaharu41/Simple-Calculator.git 

'Imports Microsoft.VisualBasic.ApplicationServices

Option Explicit On
Option Strict On
Module SimplCalculator

    Sub Main()
        'Assign Variables
        Dim num1 As Integer
        Dim num2 As Integer
        Dim userInput As String

        'Take user input numbers
        Console.Write("First Numeric Input:")
        num1 = CInt(Console.ReadLine())
        Console.Write("Second Numeric Input:")
        num2 = CInt(Console.ReadLine())

        Console.Write("Operation Type" & vbNewLine _
                          & "1. Product" & vbNewLine _
                          & "2. Sum" & vbNewLine)

        userInput = Console.ReadLine()

        If userInput = "1" Then
            Console.Write($"{num1} * {num2} = ")
            Console.WriteLine(num1 * num2)
        ElseIf userInput = "2" Then
            Console.Write($"{num1} + {num2} = ")
            Console.WriteLine(num1 + num2)
        End If

        Console.Read()

    End Sub

End Module

Option Strict On
Imports System
Module Variables
    Sub Main()
        'declaration'
        Dim nombre, apellido As String
        Dim fechaNacimiento As Date

        Console.WriteLine("Ingrese su Nombre")
        nombre = Console.ReadLine()
        Console.WriteLine("Ingrese su Apellido")
        apellido = Console.ReadLine()
        Console.WriteLine("Ingrese su Fecha de nacimiento")
        fechaNacimiento = Convert.ToDateTime(Console.ReadLine())

        Console.WriteLine("Nombre: " & nombre & " " & "Apellido :" & apellido & " " & "Fecha de Nacimiento: " & fechaNacimiento)
    End Sub
End Module

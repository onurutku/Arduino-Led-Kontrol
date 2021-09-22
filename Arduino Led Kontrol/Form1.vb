Imports System
Imports System.ComponentModel
Imports System.Threading
Imports System.IO.Ports
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim MyCOMPort As SerialPort
        MyCOMPort = New SerialPort()
        MyCOMPort.PortName = "COM3"   'Assign the port name to the MyCOMPort object
        MyCOMPort.BaudRate = 9600      'Assign the Baudrate to the MyCOMPort object
        MyCOMPort.Open()
        MyCOMPort.Write("1")           ' Write an ascii "A"
        MyCOMPort.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim MyCOMPort As SerialPort
        MyCOMPort = New SerialPort()
        MyCOMPort.PortName = "COM3"   'Assign the port name to the MyCOMPort object
        MyCOMPort.BaudRate = 9600      'Assign the Baudrate to the MyCOMPort object
        MyCOMPort.Open()
        MyCOMPort.Write("0")           ' Write an ascii "A"
        MyCOMPort.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim MyCOMPort As SerialPort
        MyCOMPort = New SerialPort()
        MyCOMPort.PortName = "COM3"   'Assign the port name to the MyCOMPort object
        MyCOMPort.BaudRate = 9600      'Assign the Baudrate to the MyCOMPort object
        MyCOMPort.Open()
        MyCOMPort.Write("2")           ' Write an ascii "A"
        MyCOMPort.Close()
    End Sub
End Class

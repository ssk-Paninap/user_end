﻿Public Class Form1
    ' Shared variables to hold user input data
    Public Shared StudentID As String
    Public Shared FullName As String
    Public Shared YearLevel As Integer
    Public Shared Course As Integer
    Public Shared Reason As String
    Public Shared Duration As Integer
    Public Shared PCNumber As Integer
    Public Shared LabNumber As Integer

    Private Sub genticket_Click(sender As Object, e As EventArgs) Handles genticket.Click
        ' Hide the current form
        Me.Hide()

        ' Open the next form (personalInfoForm)
        Dim personalInfoForm As New personal_info1()

        personalInfoForm.ShowDialog()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' This method can be used to initialize your form
    End Sub
End Class

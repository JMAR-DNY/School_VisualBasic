'Programmed by: Jeffrey Marron
'CRN 1475
Option Explicit On
Option Strict On
Imports System.IO

'used to declare global variables
Public Module frmMainModule

    '******************NOTE:**********************
    'created one array of studentRecords instead of 8 parallel arrays of floating data to clean up code
    'Tried this syntax from MSDN but it wouldn't work:
    'Public listOfStudentRecords() As studentRecord = New studentRecord(18) {}
    'https://msdn.microsoft.com/en-us/library/487y7874(v=vs.100).aspx 'syntax from MSDN for array of class type objects

    'someone described in a youTube video how to declare New array objects inside {} brackets using a loop however I could not find
    'the appropriate syntax online or in the textbook/course materials


    Public listOfStudentRecords() As studentRecord = {New studentRecord, New studentRecord, New studentRecord, New studentRecord, New studentRecord,
        New studentRecord, New studentRecord, New studentRecord, New studentRecord, New studentRecord, New studentRecord, New studentRecord,
        New studentRecord, New studentRecord, New studentRecord, New studentRecord, New studentRecord, New studentRecord}

    Public ClassAverage As Double = 0

End Module 'frmMainModule

Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FileParser()
        lstNames.SelectedIndex = 0 'sets the current selection of lstNames to 0 index value
    End Sub 'frmMain


    Public Sub CreateMyBorderlesWindow()
        MaximizeBox = False
        MinimizeBox = False
        StartPosition = FormStartPosition.CenterScreen
        ControlBox = False
    End Sub 'CreateMyBorderlesWindow

    'parses grades.csv file located in Grades.exe directory
    Public Sub FileParser()
        Dim i As Integer = 0
        Dim FilePath As String = "grades.csv"
        Dim sr As StreamReader = New StreamReader(FilePath)
        Dim IDNUM As Integer = 53785

        Try
            Do While sr.EndOfStream() > True
                Dim columns() As String = sr.ReadLine().Split(","c)
                listOfStudentRecords(i).FirstName = columns(0)
                listOfStudentRecords(i).LastName = columns(1)
                listOfStudentRecords(i).Assignment1 = Convert.ToDouble(columns(2))
                listOfStudentRecords(i).Assignment2 = Convert.ToDouble(columns(3))
                listOfStudentRecords(i).Assignment3 = Convert.ToDouble(columns(4))
                listOfStudentRecords(i).Project = Convert.ToDouble(columns(5))
                listOfStudentRecords(i).Midterm = Convert.ToDouble(columns(6))
                listOfStudentRecords(i).Final = Convert.ToDouble(columns(7))
                'Calculate Average
                listOfStudentRecords(i).Average = Math.Truncate((Convert.ToDouble(((listOfStudentRecords(i).Assignment1 * 2) + (listOfStudentRecords(i).Assignment2 * 2) +
                    (listOfStudentRecords(i).Assignment3 * 2) + (listOfStudentRecords(i).Project * 4) + (listOfStudentRecords(i).Midterm * 5) +
                    (listOfStudentRecords(i).Final * 5)) / 20)) + 0.5)
                listOfStudentRecords(i).LetterGrade = CalcLetterGrade(listOfStudentRecords(i).Average)

                'adds name at i index of listOfStudentRecords to the lstNames list box
                lstNames.Items.Add((listOfStudentRecords(i).LastName) + ", " + (listOfStudentRecords(i).FirstName))
                ListBox1.Items.Add(IDNUM)
                IDNUM = IDNUM + 1
                ClassAverage = listOfStudentRecords(i).Average + ClassAverage
                i = i + 1 'used as counter to calculate the classAverage
            Loop
            sr.Close()
        Catch e As Exception
            MsgBox("Failed to read input line")
        End Try
        ClassAverage = Math.Truncate((ClassAverage / i) + 0.5) 'classAverage calculation
    End Sub 'FileParser

    'uses double value in a select case to determine letter grade. Returns string value
    Public Function CalcLetterGrade(t As Double) As String
        Dim Temp As String = ""
        Dim number As Double = t
        Select Case number
            Case 0 To 59
                Temp = "E"
            Case 60 To 66
                Temp = "D"
            Case 67 To 69
                Temp = "D+"
            Case 70 To 72
                Temp = "C-"
            Case 73 To 76
                Temp = "C"
            Case 77 To 79
                Temp = "C+"
            Case 80 To 82
                Temp = "B-"
            Case 83 To 86
                Temp = "B"
            Case 87 To 89
                Temp = "B+"
            Case 90 To 92
                Temp = "A-"
            Case 93 To 100
                Temp = "A"
            Case Else
                Debug.WriteLine("Invalid Grade")
        End Select

        Return Temp
    End Function 'CalcLetterGrade

    'Sends info from listOfStudentRecords array to the output labels according to corresponding index value in lstNames
    Private Sub lstNames_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstNames.SelectedIndexChanged
        Dim i As Integer = Me.lstNames.SelectedIndex
        'lblAsgn1Out.Text = Convert.ToString(listOfStudentRecords(i).Assignment1)
        'lblAsgn2Out.Text = Convert.ToString(listOfStudentRecords(i).Assignment2)
        'lblAsgn3Out.Text = Convert.ToString(listOfStudentRecords(i).Assignment3)
        'lblProjOut.Text = Convert.ToString(listOfStudentRecords(i).Project)
        'lblMidOut.Text = Convert.ToString(listOfStudentRecords(i).Midterm)
        'lblFinOut.Text = Convert.ToString(listOfStudentRecords(i).Final)
        ' lblAvgOut.Text = Convert.ToString(listOfStudentRecords(i).Average)
        'lblGradeOut.Text = (listOfStudentRecords(i).LetterGrade)
    End Sub 'lstNames_SelectedIndexChanged

    'Button Handlers***********************************************

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim result = MessageBox.Show(" Are you sure you want to exit", "Leaving?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub 'btnExit_Click

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click

        Form1.Show()
        'END Button Handlers********************************************
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
    End Sub
End Class 'frmMain

'studentRecord class - stores the data from one student
Public Class studentRecord
    Public Assignment1 As Double, Assignment2 As Double, Assignment3 As Double,
        Project As Double, Midterm As Double, Final As Double, Average As Double
    Public LetterGrade As String, FirstName As String, LastName As String
End Class'studentRecord
'Programmed by: Jeffrey Marron
'CRN 1475
Option Explicit On
Option Strict On
Imports System.IO

'used to declare global variables
Public Module frmMainModule

    Public listOfStudentRecords() As studentRecord = {New studentRecord, New studentRecord, New studentRecord, New studentRecord, New studentRecord,
        New studentRecord, New studentRecord, New studentRecord, New studentRecord, New studentRecord, New studentRecord, New studentRecord,
        New studentRecord, New studentRecord, New studentRecord, New studentRecord, New studentRecord, New studentRecord}

    Public ClassAverage As Double = 0

End Module 'frmMainModule

Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreateMyBorderlesWindow()
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
        Dim results As DialogResult
        OpenFileDialog1.InitialDirectory = "C:\" 'sets default directory
        OpenFileDialog1.Filter = "csv File|*.csv" 'sets the save file type
        OpenFileDialog1.Title = "Open a CSV File" 'sets dialog box title
        results = OpenFileDialog1.ShowDialog
        Dim sr As StreamReader

        'OK button selection
        If results = DialogResult.OK Then
            sr = New StreamReader(OpenFileDialog1.FileName)
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
                    ClassAverage = listOfStudentRecords(i).Average + ClassAverage
                    i = i + 1 'used as counter to calculate the classAverage
                Loop
                sr.Close()
            Catch e As Exception
                MsgBox("Failed to read input line")
            End Try
            ClassAverage = Math.Truncate((ClassAverage / i) + 0.5) 'classAverage calculation
            lstNames.SelectedIndex = 0
        End If

        'cancel button selection
        If results = DialogResult.Cancel Then
            Dim result = MessageBox.Show("File not opened", "Grades", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
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
        lblAsgn1Out.Text = Convert.ToString(listOfStudentRecords(i).Assignment1)
        lblAsgn2Out.Text = Convert.ToString(listOfStudentRecords(i).Assignment2)
        lblAsgn3Out.Text = Convert.ToString(listOfStudentRecords(i).Assignment3)
        lblProjOut.Text = Convert.ToString(listOfStudentRecords(i).Project)
        lblMidOut.Text = Convert.ToString(listOfStudentRecords(i).Midterm)
        lblFinOut.Text = Convert.ToString(listOfStudentRecords(i).Final)
        lblAvgOut.Text = Convert.ToString(listOfStudentRecords(i).Average)
        lblGradeOut.Text = (listOfStudentRecords(i).LetterGrade)
    End Sub 'lstNames_SelectedIndexChanged

    'Button Handlers***********************************************
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuItemExitToolStrip.Click
        Dim result = MessageBox.Show(" Are you sure you want to exit", "Leaving?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub SummaryReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuItemSummaryReportToolStrip.Click
        Dim FileWriter As StreamWriter
        Dim results As DialogResult
        SaveFileDialog1.InitialDirectory = "C:\" 'sets default directory
        SaveFileDialog1.Filter = "Text File|*.txt" 'sets the save file type
        SaveFileDialog1.Title = "Save a Text File" 'sets dialog box title
        SaveFileDialog1.FileName = "report.txt" ' sets default save file name
        results = SaveFileDialog1.ShowDialog 'opens dialog box

        'OK button selection
        If results = DialogResult.OK Then
            FileWriter = New StreamWriter(SaveFileDialog1.FileName, False)
            FileWriter.WriteLine("Summary Report Created: " + DateTime.Now.ToString("dddd, MMMM dd, yyyy"))
            FileWriter.WriteLine()
            FileWriter.WriteLine("Class Average: " + ClassAverage.ToString)
            FileWriter.WriteLine()
            FileWriter.WriteLine()
            'function to loop through array of studentRecord objects
            For i As Integer = 0 To 17
                FileWriter.WriteLine(listOfStudentRecords(i).FirstName + " " + listOfStudentRecords(i).LastName + " " + listOfStudentRecords(i).Assignment1.ToString + " " +
                 listOfStudentRecords(i).Assignment2.ToString + " " + listOfStudentRecords(i).Assignment3.ToString + " " +
                 listOfStudentRecords(i).Project.ToString + " " + listOfStudentRecords(i).Midterm.ToString + " " +
                 listOfStudentRecords(i).Final.ToString + " ---> " + listOfStudentRecords(i).Average.ToString + " " + listOfStudentRecords(i).LetterGrade)
            Next

            Dim result = MessageBox.Show("Summary Report has been created", "Grades", MessageBoxButtons.OK)
            FileWriter.Close()
        End If

        'calcel button selection
        If results = DialogResult.Cancel Then
            Dim result = MessageBox.Show("No Summary Report has been Created", "Grades", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub mnuItemOpenFileToolStrip_Click(sender As Object, e As EventArgs) Handles mnuItemOpenFileToolStrip.Click
        FileParser()
    End Sub
    'END Button Handlers********************************************

End Class 'frmMain

'studentRecord class - stores the data from one student
Public Class studentRecord
    Public Assignment1 As Double, Assignment2 As Double, Assignment3 As Double,
        Project As Double, Midterm As Double, Final As Double, Average As Double
    Public LetterGrade As String, FirstName As String, LastName As String
End Class'studentRecord
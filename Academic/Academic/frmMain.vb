'Programmed by: Jeffrey Marron
'CRN 1475
Option Explicit On
Option Strict On

Public Module frmMainModule
    Public BaseSalary As Double = 50000, Lecturer As Double = 1.0, Instructor As Double = 1.25, AstProf As Double = 1.5,
        AssocProf As Double = 1.75, Prof As Double = 2.0
End Module

Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreateMyBorderlesWindow()
    End Sub

    'Menu&Format********************************
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()   'closes all forms and calls
        End     'ends any further process execution
    End Sub

    Public Sub CreateMyBorderlesWindow()
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        MinimizeBox = False
        StartPosition = FormStartPosition.CenterScreen
        ' Remove the control box so the form will only display client area.
        ControlBox = False
    End Sub 'CreateMyBorderlesWindow

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("This program was written by:" + vbCrLf + vbCrLf + "JAM", "Academic", MessageBoxButtons.OK)
    End Sub
    'END Menu&Format***************************

    'Calculate Functions***********************
    Public Function CheckBoxValue() As Double
        Dim TEMP As Double
        If chkBachelors.Checked Then
            TEMP = 0
        End If
        If chkMasters.Checked Then
            TEMP += 4000
        End If
        If chkDoctorate.Checked Then
            TEMP += 8000
        End If
        Return TEMP
    End Function

    Public Function RadioButtonValue() As Double
        Dim TEMP As Double
        If optLecturer.Checked Then
            TEMP = Lecturer
        End If
        If optInstructor.Checked Then
            TEMP = Instructor
        End If
        If optAssisProfessor.Checked Then
            TEMP = AstProf
        End If
        If optAssocProfessor.Checked Then
            TEMP = AssocProf
        End If
        If optProfessor.Checked Then
            TEMP = Prof
        End If
        Return TEMP
    End Function

    Public Sub CalcSalary()
        lblOutput.Text = FormatCurrency(((RadioButtonValue() * BaseSalary) + CheckBoxValue()),  , TriState.False)
    End Sub
    'END Calculate Functions*************************

    'Radio Button Handlers*************************
    Private Sub optLecturer_CheckedChanged(sender As Object, e As EventArgs) Handles optLecturer.CheckedChanged
        CalcSalary()
    End Sub

    Private Sub optInstructor_CheckedChanged(sender As Object, e As EventArgs) Handles optInstructor.CheckedChanged
        CalcSalary()
    End Sub

    Private Sub optAssisProfessor_CheckedChanged(sender As Object, e As EventArgs) Handles optAssisProfessor.CheckedChanged
        CalcSalary()
    End Sub

    Private Sub optAssocProfessor_CheckedChanged(sender As Object, e As EventArgs) Handles optAssocProfessor.CheckedChanged
        CalcSalary()
    End Sub

    Private Sub optProfessor_CheckedChanged(sender As Object, e As EventArgs) Handles optProfessor.CheckedChanged
        CalcSalary()
    End Sub
    'End Radio Button Handlers**************************

    'Check Box Handlers********************************
    Private Sub chkBachelors_CheckedChanged(sender As Object, e As EventArgs) Handles chkBachelors.CheckedChanged
        CalcSalary()
        chkBachelors.Checked = True
    End Sub

    Private Sub chkMasters_CheckedChanged(sender As Object, e As EventArgs) Handles chkMasters.CheckedChanged
        CalcSalary()
    End Sub

    Private Sub chkDoctorate_CheckedChanged(sender As Object, e As EventArgs) Handles chkDoctorate.CheckedChanged
        CalcSalary()
    End Sub
    'END Check Box Handlers*******************************
End Class
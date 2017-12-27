Imports System.Math

Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreateMyBorderlesWindow() 'calls function to eliminate the window controls
        vsbTemp.Minimum = -35
        vsbTemp.Maximum = 39
        vsbTemp.LargeChange = 5
        vsbTemp.Value = -35     'this fixed: value in design was set to 0 but thumb would reposition to middle of vscroll

        vsbWindSpeed.Minimum = 5
        vsbWindSpeed.Maximum = 49
        vsbWindSpeed.LargeChange = 5
    End Sub 'frmMain_Load

    Private Sub vsbWindSpeed_ValueChanged(sender As Object, e As ScrollEventArgs) Handles vsbWindSpeed.Scroll
        lblWindSpeedOut.Text = vsbWindSpeed.Value
        lblOldWCFOutput.Text = CaclulateOldWindChill().ToString
        lblNewWCFOutput.Text = CalculateNewWindChill().ToString
        lblChangeWCFOutput.Text = CalculateDifference().ToString
    End Sub 'vsbWindSpeed_ValueChanged

    Private Sub vsbTemp_ValueChanged(sender As Object, e As ScrollEventArgs) Handles vsbTemp.Scroll
        lblTempOut.Text = vsbTemp.Value * -1 'this inverts the value
        lblOldWCFOutput.Text = CaclulateOldWindChill().ToString
        lblNewWCFOutput.Text = CalculateNewWindChill().ToString
        lblChangeWCFOutput.Text = CalculateDifference().ToString
    End Sub 'vsbTemp_ValueChanged

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Application.Exit()   'closes all forms and calls
        End     'ends any further process execution
    End Sub 'cmdExit_Click

    Public Sub CreateMyBorderlesWindow()
        MaximizeBox = False
        MinimizeBox = False
    End Sub 'CreateMyBorderlesWindow

    Private Function CaclulateOldWindChill() As Integer
        Dim TEMP As Integer = vsbTemp.Value * -1, WIND As Integer = vsbWindSpeed.Value, OldWindChillFactorOutput As Integer

        OldWindChillFactorOutput = (0.0817 * (3.71 * (Math.Pow(WIND, 0.5)) + 5.81 - 0.25 * WIND) * (TEMP - 91.4) + 91.4)

        Return OldWindChillFactorOutput
    End Function 'CaclulateOldWindChill

    Public Function CalculateNewWindChill() As Integer
        Dim TEMP As Integer = vsbTemp.Value * -1, WIND As Integer = vsbWindSpeed.Value, NewWindChillFactorOutput As Integer

        NewWindChillFactorOutput = (35.74 + 0.6215 * TEMP - 35.75 * (Pow(WIND, 0.16)) + 0.4275 * TEMP * (Pow(WIND, 0.16)))

        Return NewWindChillFactorOutput
    End Function 'CalculateNewWindChill

    Public Function CalculateDifference() As Integer
        Dim OLDWC As Integer = CaclulateOldWindChill(), NEWWC As Integer = CalculateNewWindChill(), ChangeInWindChillFactorOutput As Integer

        ChangeInWindChillFactorOutput = NEWWC - OLDWC

        Return ChangeInWindChillFactorOutput
    End Function 'CalculateDifference

    Private Sub cmdInfo_Click(sender As Object, e As EventArgs) Handles cmdInfo.Click
        MessageBox.Show("Note: Wind speeds below 5mph or above 45mph have little effect
        on the wind-chill factor" + vbCrLf + vbCrLf + "JAM", "Wind-Chill Calculation", MessageBoxButtons.OK)

    End Sub 'cmdInfo_Click
End Class 'FrmMain

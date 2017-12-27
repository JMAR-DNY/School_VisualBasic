<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPos45 = New System.Windows.Forms.Label()
        Me.lblPos35 = New System.Windows.Forms.Label()
        Me.lblNeg35 = New System.Windows.Forms.Label()
        Me.vsbWindSpeed = New System.Windows.Forms.VScrollBar()
        Me.vsbTemp = New System.Windows.Forms.VScrollBar()
        Me.lblWindSpeed = New System.Windows.Forms.Label()
        Me.lblWindSpeedOut = New System.Windows.Forms.Label()
        Me.lblMPH = New System.Windows.Forms.Label()
        Me.lblTemp = New System.Windows.Forms.Label()
        Me.lblTempOut = New System.Windows.Forms.Label()
        Me.lblF = New System.Windows.Forms.Label()
        Me.lblOldWCFactor = New System.Windows.Forms.Label()
        Me.lblOldWCFOutput = New System.Windows.Forms.Label()
        Me.lblDegF1 = New System.Windows.Forms.Label()
        Me.lblDegF2 = New System.Windows.Forms.Label()
        Me.lblDegF3 = New System.Windows.Forms.Label()
        Me.lblNewWCFactor = New System.Windows.Forms.Label()
        Me.lblNewWCFOutput = New System.Windows.Forms.Label()
        Me.lblChangeWCFOutput = New System.Windows.Forms.Label()
        Me.lblChangeWCFactor = New System.Windows.Forms.Label()
        Me.cmdInfo = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "5"
        '
        'lblPos45
        '
        Me.lblPos45.AutoSize = True
        Me.lblPos45.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPos45.Location = New System.Drawing.Point(36, 249)
        Me.lblPos45.Name = "lblPos45"
        Me.lblPos45.Size = New System.Drawing.Size(26, 17)
        Me.lblPos45.TabIndex = 1
        Me.lblPos45.Text = "45"
        '
        'lblPos35
        '
        Me.lblPos35.AutoSize = True
        Me.lblPos35.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPos35.Location = New System.Drawing.Point(315, 43)
        Me.lblPos35.Name = "lblPos35"
        Me.lblPos35.Size = New System.Drawing.Size(26, 17)
        Me.lblPos35.TabIndex = 2
        Me.lblPos35.Text = "35"
        '
        'lblNeg35
        '
        Me.lblNeg35.AutoSize = True
        Me.lblNeg35.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNeg35.Location = New System.Drawing.Point(309, 249)
        Me.lblNeg35.Name = "lblNeg35"
        Me.lblNeg35.Size = New System.Drawing.Size(32, 17)
        Me.lblNeg35.TabIndex = 3
        Me.lblNeg35.Text = "-35"
        '
        'vsbWindSpeed
        '
        Me.vsbWindSpeed.Location = New System.Drawing.Point(65, 43)
        Me.vsbWindSpeed.Name = "vsbWindSpeed"
        Me.vsbWindSpeed.Size = New System.Drawing.Size(21, 223)
        Me.vsbWindSpeed.TabIndex = 4
        '
        'vsbTemp
        '
        Me.vsbTemp.Location = New System.Drawing.Point(341, 43)
        Me.vsbTemp.Name = "vsbTemp"
        Me.vsbTemp.Size = New System.Drawing.Size(21, 223)
        Me.vsbTemp.TabIndex = 5
        '
        'lblWindSpeed
        '
        Me.lblWindSpeed.AutoSize = True
        Me.lblWindSpeed.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWindSpeed.Location = New System.Drawing.Point(159, 111)
        Me.lblWindSpeed.Name = "lblWindSpeed"
        Me.lblWindSpeed.Size = New System.Drawing.Size(95, 17)
        Me.lblWindSpeed.TabIndex = 6
        Me.lblWindSpeed.Text = "Wind Speed"
        '
        'lblWindSpeedOut
        '
        Me.lblWindSpeedOut.AutoSize = True
        Me.lblWindSpeedOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWindSpeedOut.Location = New System.Drawing.Point(185, 148)
        Me.lblWindSpeedOut.Name = "lblWindSpeedOut"
        Me.lblWindSpeedOut.Size = New System.Drawing.Size(17, 17)
        Me.lblWindSpeedOut.TabIndex = 7
        Me.lblWindSpeedOut.Text = "5"
        '
        'lblMPH
        '
        Me.lblMPH.AutoSize = True
        Me.lblMPH.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMPH.Location = New System.Drawing.Point(159, 180)
        Me.lblMPH.Name = "lblMPH"
        Me.lblMPH.Size = New System.Drawing.Size(83, 17)
        Me.lblMPH.TabIndex = 8
        Me.lblMPH.Text = "Miles/hour"
        '
        'lblTemp
        '
        Me.lblTemp.AutoSize = True
        Me.lblTemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTemp.Location = New System.Drawing.Point(385, 111)
        Me.lblTemp.Name = "lblTemp"
        Me.lblTemp.Size = New System.Drawing.Size(101, 17)
        Me.lblTemp.TabIndex = 9
        Me.lblTemp.Text = "Temperature"
        '
        'lblTempOut
        '
        Me.lblTempOut.AutoSize = True
        Me.lblTempOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTempOut.Location = New System.Drawing.Point(412, 148)
        Me.lblTempOut.Name = "lblTempOut"
        Me.lblTempOut.Size = New System.Drawing.Size(26, 17)
        Me.lblTempOut.TabIndex = 10
        Me.lblTempOut.Text = "35"
        '
        'lblF
        '
        Me.lblF.AutoSize = True
        Me.lblF.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblF.Location = New System.Drawing.Point(385, 180)
        Me.lblF.Name = "lblF"
        Me.lblF.Size = New System.Drawing.Size(86, 17)
        Me.lblF.TabIndex = 11
        Me.lblF.Text = "Fahrenheit"
        '
        'lblOldWCFactor
        '
        Me.lblOldWCFactor.AutoSize = True
        Me.lblOldWCFactor.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOldWCFactor.Location = New System.Drawing.Point(69, 332)
        Me.lblOldWCFactor.Name = "lblOldWCFactor"
        Me.lblOldWCFactor.Size = New System.Drawing.Size(173, 17)
        Me.lblOldWCFactor.TabIndex = 12
        Me.lblOldWCFactor.Text = "Old Wind-chill factor is"
        '
        'lblOldWCFOutput
        '
        Me.lblOldWCFOutput.AutoSize = True
        Me.lblOldWCFOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOldWCFOutput.Location = New System.Drawing.Point(289, 332)
        Me.lblOldWCFOutput.Name = "lblOldWCFOutput"
        Me.lblOldWCFOutput.Size = New System.Drawing.Size(26, 17)
        Me.lblOldWCFOutput.TabIndex = 13
        Me.lblOldWCFOutput.Text = "33"
        '
        'lblDegF1
        '
        Me.lblDegF1.AutoSize = True
        Me.lblDegF1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDegF1.Location = New System.Drawing.Point(339, 332)
        Me.lblDegF1.Name = "lblDegF1"
        Me.lblDegF1.Size = New System.Drawing.Size(150, 17)
        Me.lblDegF1.TabIndex = 14
        Me.lblDegF1.Text = "degrees Fahrenheit"
        '
        'lblDegF2
        '
        Me.lblDegF2.AutoSize = True
        Me.lblDegF2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDegF2.Location = New System.Drawing.Point(339, 379)
        Me.lblDegF2.Name = "lblDegF2"
        Me.lblDegF2.Size = New System.Drawing.Size(150, 17)
        Me.lblDegF2.TabIndex = 15
        Me.lblDegF2.Text = "degrees Fahrenheit"
        '
        'lblDegF3
        '
        Me.lblDegF3.AutoSize = True
        Me.lblDegF3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDegF3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblDegF3.Location = New System.Drawing.Point(339, 420)
        Me.lblDegF3.Name = "lblDegF3"
        Me.lblDegF3.Size = New System.Drawing.Size(150, 17)
        Me.lblDegF3.TabIndex = 16
        Me.lblDegF3.Text = "degrees Fahrenheit"
        '
        'lblNewWCFactor
        '
        Me.lblNewWCFactor.AutoSize = True
        Me.lblNewWCFactor.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewWCFactor.Location = New System.Drawing.Point(69, 379)
        Me.lblNewWCFactor.Name = "lblNewWCFactor"
        Me.lblNewWCFactor.Size = New System.Drawing.Size(178, 17)
        Me.lblNewWCFactor.TabIndex = 17
        Me.lblNewWCFactor.Text = "New Wind-chill factor is"
        '
        'lblNewWCFOutput
        '
        Me.lblNewWCFOutput.AutoSize = True
        Me.lblNewWCFOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewWCFOutput.Location = New System.Drawing.Point(289, 379)
        Me.lblNewWCFOutput.Name = "lblNewWCFOutput"
        Me.lblNewWCFOutput.Size = New System.Drawing.Size(26, 17)
        Me.lblNewWCFOutput.TabIndex = 18
        Me.lblNewWCFOutput.Text = "31"
        '
        'lblChangeWCFOutput
        '
        Me.lblChangeWCFOutput.AutoSize = True
        Me.lblChangeWCFOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChangeWCFOutput.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblChangeWCFOutput.Location = New System.Drawing.Point(289, 420)
        Me.lblChangeWCFOutput.Name = "lblChangeWCFOutput"
        Me.lblChangeWCFOutput.Size = New System.Drawing.Size(23, 17)
        Me.lblChangeWCFOutput.TabIndex = 19
        Me.lblChangeWCFOutput.Text = "-2"
        '
        'lblChangeWCFactor
        '
        Me.lblChangeWCFactor.AutoSize = True
        Me.lblChangeWCFactor.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChangeWCFactor.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblChangeWCFactor.Location = New System.Drawing.Point(32, 420)
        Me.lblChangeWCFactor.Name = "lblChangeWCFactor"
        Me.lblChangeWCFactor.Size = New System.Drawing.Size(221, 17)
        Me.lblChangeWCFactor.TabIndex = 20
        Me.lblChangeWCFactor.Text = "Change in Wind-chill factor is"
        '
        'cmdInfo
        '
        Me.cmdInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdInfo.Location = New System.Drawing.Point(109, 452)
        Me.cmdInfo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmdInfo.Name = "cmdInfo"
        Me.cmdInfo.Size = New System.Drawing.Size(115, 34)
        Me.cmdInfo.TabIndex = 21
        Me.cmdInfo.Text = "Information"
        Me.cmdInfo.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Location = New System.Drawing.Point(292, 452)
        Me.cmdExit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(115, 34)
        Me.cmdExit.TabIndex = 23
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 498)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdInfo)
        Me.Controls.Add(Me.lblChangeWCFactor)
        Me.Controls.Add(Me.lblChangeWCFOutput)
        Me.Controls.Add(Me.lblNewWCFOutput)
        Me.Controls.Add(Me.lblNewWCFactor)
        Me.Controls.Add(Me.lblDegF3)
        Me.Controls.Add(Me.lblDegF2)
        Me.Controls.Add(Me.lblDegF1)
        Me.Controls.Add(Me.lblOldWCFOutput)
        Me.Controls.Add(Me.lblOldWCFactor)
        Me.Controls.Add(Me.lblF)
        Me.Controls.Add(Me.lblTempOut)
        Me.Controls.Add(Me.lblTemp)
        Me.Controls.Add(Me.lblMPH)
        Me.Controls.Add(Me.lblWindSpeedOut)
        Me.Controls.Add(Me.lblWindSpeed)
        Me.Controls.Add(Me.vsbTemp)
        Me.Controls.Add(Me.vsbWindSpeed)
        Me.Controls.Add(Me.lblNeg35)
        Me.Controls.Add(Me.lblPos35)
        Me.Controls.Add(Me.lblPos45)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WindChill Factor by jm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblPos45 As Label
    Friend WithEvents lblPos35 As Label
    Friend WithEvents lblNeg35 As Label
    Friend WithEvents vsbWindSpeed As VScrollBar
    Friend WithEvents vsbTemp As VScrollBar
    Friend WithEvents lblWindSpeed As Label
    Friend WithEvents lblWindSpeedOut As Label
    Friend WithEvents lblMPH As Label
    Friend WithEvents lblTemp As Label
    Friend WithEvents lblTempOut As Label
    Friend WithEvents lblF As Label
    Friend WithEvents lblOldWCFactor As Label
    Friend WithEvents lblOldWCFOutput As Label
    Friend WithEvents lblDegF1 As Label
    Friend WithEvents lblDegF2 As Label
    Friend WithEvents lblDegF3 As Label
    Friend WithEvents lblNewWCFactor As Label
    Friend WithEvents lblNewWCFOutput As Label
    Friend WithEvents lblChangeWCFOutput As Label
    Friend WithEvents lblChangeWCFactor As Label
    Friend WithEvents cmdInfo As Button
    Friend WithEvents cmdExit As Button
End Class

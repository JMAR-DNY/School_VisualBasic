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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpRank = New System.Windows.Forms.GroupBox()
        Me.optProfessor = New System.Windows.Forms.RadioButton()
        Me.optAssocProfessor = New System.Windows.Forms.RadioButton()
        Me.optAssisProfessor = New System.Windows.Forms.RadioButton()
        Me.optInstructor = New System.Windows.Forms.RadioButton()
        Me.optLecturer = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkDoctorate = New System.Windows.Forms.CheckBox()
        Me.chkMasters = New System.Windows.Forms.CheckBox()
        Me.chkBachelors = New System.Windows.Forms.CheckBox()
        Me.lblSalary = New System.Windows.Forms.Label()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.grpRank.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.PowderBlue
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(381, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "mnuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'grpRank
        '
        Me.grpRank.Controls.Add(Me.optProfessor)
        Me.grpRank.Controls.Add(Me.optAssocProfessor)
        Me.grpRank.Controls.Add(Me.optAssisProfessor)
        Me.grpRank.Controls.Add(Me.optInstructor)
        Me.grpRank.Controls.Add(Me.optLecturer)
        Me.grpRank.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpRank.Location = New System.Drawing.Point(12, 52)
        Me.grpRank.Name = "grpRank"
        Me.grpRank.Size = New System.Drawing.Size(165, 201)
        Me.grpRank.TabIndex = 2
        Me.grpRank.TabStop = False
        Me.grpRank.Text = "Academic Rank"
        '
        'optProfessor
        '
        Me.optProfessor.AutoSize = True
        Me.optProfessor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optProfessor.Location = New System.Drawing.Point(25, 168)
        Me.optProfessor.Name = "optProfessor"
        Me.optProfessor.Size = New System.Drawing.Size(69, 17)
        Me.optProfessor.TabIndex = 8
        Me.optProfessor.TabStop = True
        Me.optProfessor.Text = "Professor"
        Me.optProfessor.UseVisualStyleBackColor = True
        '
        'optAssocProfessor
        '
        Me.optAssocProfessor.AutoSize = True
        Me.optAssocProfessor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optAssocProfessor.Location = New System.Drawing.Point(25, 133)
        Me.optAssocProfessor.Name = "optAssocProfessor"
        Me.optAssocProfessor.Size = New System.Drawing.Size(118, 17)
        Me.optAssocProfessor.TabIndex = 7
        Me.optAssocProfessor.TabStop = True
        Me.optAssocProfessor.Text = "Associate Professor"
        Me.optAssocProfessor.UseVisualStyleBackColor = True
        '
        'optAssisProfessor
        '
        Me.optAssisProfessor.AutoSize = True
        Me.optAssisProfessor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optAssisProfessor.Location = New System.Drawing.Point(25, 99)
        Me.optAssisProfessor.Name = "optAssisProfessor"
        Me.optAssisProfessor.Size = New System.Drawing.Size(114, 17)
        Me.optAssisProfessor.TabIndex = 6
        Me.optAssisProfessor.TabStop = True
        Me.optAssisProfessor.Text = "Assistant Professor"
        Me.optAssisProfessor.UseVisualStyleBackColor = True
        '
        'optInstructor
        '
        Me.optInstructor.AutoSize = True
        Me.optInstructor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optInstructor.Location = New System.Drawing.Point(25, 67)
        Me.optInstructor.Name = "optInstructor"
        Me.optInstructor.Size = New System.Drawing.Size(69, 17)
        Me.optInstructor.TabIndex = 5
        Me.optInstructor.TabStop = True
        Me.optInstructor.Text = "Instructor"
        Me.optInstructor.UseVisualStyleBackColor = True
        '
        'optLecturer
        '
        Me.optLecturer.AutoSize = True
        Me.optLecturer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optLecturer.Location = New System.Drawing.Point(25, 32)
        Me.optLecturer.Name = "optLecturer"
        Me.optLecturer.Size = New System.Drawing.Size(64, 17)
        Me.optLecturer.TabIndex = 4
        Me.optLecturer.TabStop = True
        Me.optLecturer.Text = "Lecturer"
        Me.optLecturer.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkDoctorate)
        Me.GroupBox2.Controls.Add(Me.chkMasters)
        Me.GroupBox2.Controls.Add(Me.chkBachelors)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(204, 52)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(165, 136)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Academic Degree"
        '
        'chkDoctorate
        '
        Me.chkDoctorate.AutoSize = True
        Me.chkDoctorate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDoctorate.Location = New System.Drawing.Point(18, 100)
        Me.chkDoctorate.Name = "chkDoctorate"
        Me.chkDoctorate.Size = New System.Drawing.Size(73, 17)
        Me.chkDoctorate.TabIndex = 6
        Me.chkDoctorate.Text = "Doctorate"
        Me.chkDoctorate.UseVisualStyleBackColor = True
        '
        'chkMasters
        '
        Me.chkMasters.AutoSize = True
        Me.chkMasters.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMasters.Location = New System.Drawing.Point(18, 68)
        Me.chkMasters.Name = "chkMasters"
        Me.chkMasters.Size = New System.Drawing.Size(63, 17)
        Me.chkMasters.TabIndex = 5
        Me.chkMasters.Text = "Masters"
        Me.chkMasters.UseVisualStyleBackColor = True
        '
        'chkBachelors
        '
        Me.chkBachelors.AutoSize = True
        Me.chkBachelors.Checked = True
        Me.chkBachelors.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBachelors.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBachelors.Location = New System.Drawing.Point(18, 32)
        Me.chkBachelors.Name = "chkBachelors"
        Me.chkBachelors.Size = New System.Drawing.Size(73, 17)
        Me.chkBachelors.TabIndex = 4
        Me.chkBachelors.Text = "Bachelors"
        Me.chkBachelors.UseVisualStyleBackColor = True
        '
        'lblSalary
        '
        Me.lblSalary.AutoSize = True
        Me.lblSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalary.Location = New System.Drawing.Point(201, 206)
        Me.lblSalary.Name = "lblSalary"
        Me.lblSalary.Size = New System.Drawing.Size(46, 13)
        Me.lblSalary.TabIndex = 4
        Me.lblSalary.Text = "Salary:"
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblOutput.Location = New System.Drawing.Point(204, 232)
        Me.lblOutput.MaximumSize = New System.Drawing.Size(165, 21)
        Me.lblOutput.MinimumSize = New System.Drawing.Size(165, 21)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Padding = New System.Windows.Forms.Padding(0, 0, 6, 6)
        Me.lblOutput.Size = New System.Drawing.Size(165, 21)
        Me.lblOutput.TabIndex = 5
        Me.lblOutput.Text = "$50,000.00                                                 "
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 273)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.lblSalary)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.grpRank)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Academic by JAM"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.grpRank.ResumeLayout(False)
        Me.grpRank.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents grpRank As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents optProfessor As RadioButton
    Friend WithEvents optAssocProfessor As RadioButton
    Friend WithEvents optAssisProfessor As RadioButton
    Friend WithEvents optInstructor As RadioButton
    Friend WithEvents optLecturer As RadioButton
    Friend WithEvents chkDoctorate As CheckBox
    Friend WithEvents chkMasters As CheckBox
    Friend WithEvents chkBachelors As CheckBox
    Friend WithEvents lblSalary As Label
    Friend WithEvents lblOutput As Label
End Class

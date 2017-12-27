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
        Me.components = New System.ComponentModel.Container()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.lbl6 = New System.Windows.Forms.Label()
        Me.lblReleased = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblArtist = New System.Windows.Forms.Label()
        Me.lblGenre = New System.Windows.Forms.Label()
        Me.lblDuration = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.btnAddToCart = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnFinishOrder = New System.Windows.Forms.Button()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.picVGA1 = New System.Windows.Forms.PictureBox()
        CType(Me.picVGA1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.Location = New System.Drawing.Point(27, 28)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(36, 13)
        Me.lbl1.TabIndex = 0
        Me.lbl1.Text = "Title:"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.Location = New System.Drawing.Point(27, 63)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(40, 13)
        Me.lbl2.TabIndex = 1
        Me.lbl2.Text = "Artist:"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'ImageList2
        '
        Me.ImageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList2.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.Location = New System.Drawing.Point(27, 95)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(45, 13)
        Me.lbl3.TabIndex = 2
        Me.lbl3.Text = "Genre:"
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl4.Location = New System.Drawing.Point(27, 126)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(59, 13)
        Me.lbl4.TabIndex = 3
        Me.lbl4.Text = "Duration:"
        '
        'lbl5
        '
        Me.lbl5.AutoSize = True
        Me.lbl5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5.Location = New System.Drawing.Point(27, 157)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(92, 13)
        Me.lbl5.TabIndex = 4
        Me.lbl5.Text = "First Released:"
        '
        'lbl6
        '
        Me.lbl6.AutoSize = True
        Me.lbl6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl6.Location = New System.Drawing.Point(27, 188)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(40, 13)
        Me.lbl6.TabIndex = 5
        Me.lbl6.Text = "Price:"
        '
        'lblReleased
        '
        Me.lblReleased.AutoSize = True
        Me.lblReleased.Location = New System.Drawing.Point(148, 157)
        Me.lblReleased.Name = "lblReleased"
        Me.lblReleased.Size = New System.Drawing.Size(39, 13)
        Me.lblReleased.TabIndex = 6
        Me.lblReleased.Text = "Label1"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(148, 28)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(39, 13)
        Me.lblTitle.TabIndex = 7
        Me.lblTitle.Text = "Label2"
        '
        'lblArtist
        '
        Me.lblArtist.AutoSize = True
        Me.lblArtist.Location = New System.Drawing.Point(148, 63)
        Me.lblArtist.Name = "lblArtist"
        Me.lblArtist.Size = New System.Drawing.Size(39, 13)
        Me.lblArtist.TabIndex = 8
        Me.lblArtist.Text = "Label3"
        '
        'lblGenre
        '
        Me.lblGenre.AutoSize = True
        Me.lblGenre.Location = New System.Drawing.Point(148, 95)
        Me.lblGenre.Name = "lblGenre"
        Me.lblGenre.Size = New System.Drawing.Size(39, 13)
        Me.lblGenre.TabIndex = 9
        Me.lblGenre.Text = "Label4"
        '
        'lblDuration
        '
        Me.lblDuration.AutoSize = True
        Me.lblDuration.Location = New System.Drawing.Point(148, 126)
        Me.lblDuration.Name = "lblDuration"
        Me.lblDuration.Size = New System.Drawing.Size(39, 13)
        Me.lblDuration.TabIndex = 10
        Me.lblDuration.Text = "Label5"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(148, 188)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(39, 13)
        Me.lblPrice.TabIndex = 11
        Me.lblPrice.Text = "Label6"
        '
        'btnAddToCart
        '
        Me.btnAddToCart.Image = Global.myTunes.My.Resources.Resources.AddToCartBtn
        Me.btnAddToCart.Location = New System.Drawing.Point(439, 199)
        Me.btnAddToCart.Name = "btnAddToCart"
        Me.btnAddToCart.Size = New System.Drawing.Size(56, 45)
        Me.btnAddToCart.TabIndex = 16
        Me.btnAddToCart.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Image = Global.myTunes.My.Resources.Resources.RightBtn
        Me.btnNext.Location = New System.Drawing.Point(330, 250)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(68, 45)
        Me.btnNext.TabIndex = 15
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnFinishOrder
        '
        Me.btnFinishOrder.Image = Global.myTunes.My.Resources.Resources.FinishOrderBtn
        Me.btnFinishOrder.Location = New System.Drawing.Point(225, 250)
        Me.btnFinishOrder.Name = "btnFinishOrder"
        Me.btnFinishOrder.Size = New System.Drawing.Size(79, 45)
        Me.btnFinishOrder.TabIndex = 14
        Me.btnFinishOrder.UseVisualStyleBackColor = True
        '
        'btnPrev
        '
        Me.btnPrev.Image = Global.myTunes.My.Resources.Resources.LeftBtn
        Me.btnPrev.Location = New System.Drawing.Point(132, 250)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(68, 45)
        Me.btnPrev.TabIndex = 13
        Me.btnPrev.UseVisualStyleBackColor = True
        '
        'picVGA1
        '
        Me.picVGA1.Location = New System.Drawing.Point(330, 28)
        Me.picVGA1.MaximumSize = New System.Drawing.Size(165, 165)
        Me.picVGA1.MinimumSize = New System.Drawing.Size(165, 165)
        Me.picVGA1.Name = "picVGA1"
        Me.picVGA1.Size = New System.Drawing.Size(165, 165)
        Me.picVGA1.TabIndex = 12
        Me.picVGA1.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 325)
        Me.Controls.Add(Me.btnAddToCart)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnFinishOrder)
        Me.Controls.Add(Me.btnPrev)
        Me.Controls.Add(Me.picVGA1)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblDuration)
        Me.Controls.Add(Me.lblGenre)
        Me.Controls.Add(Me.lblArtist)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblReleased)
        Me.Controls.Add(Me.lbl6)
        Me.Controls.Add(Me.lbl5)
        Me.Controls.Add(Me.lbl4)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl1)
        Me.MaximumSize = New System.Drawing.Size(543, 364)
        Me.MinimumSize = New System.Drawing.Size(543, 364)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Music Selections by JAM"
        CType(Me.picVGA1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl1 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents ImageList2 As ImageList
    Friend WithEvents lbl3 As Label
    Friend WithEvents lbl4 As Label
    Friend WithEvents lbl5 As Label
    Friend WithEvents lbl6 As Label
    Friend WithEvents lblReleased As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblArtist As Label
    Friend WithEvents lblGenre As Label
    Friend WithEvents lblDuration As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents picVGA1 As PictureBox
    Friend WithEvents btnPrev As Button
    Friend WithEvents btnFinishOrder As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnAddToCart As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnBait = New System.Windows.Forms.Button()
        Me.btnCast = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnGoFish = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.lblTrout = New System.Windows.Forms.Label()
        Me.lblCola = New System.Windows.Forms.Label()
        Me.lblRustyBike = New System.Windows.Forms.Label()
        Me.lblSneaker = New System.Windows.Forms.Label()
        Me.lblCast = New System.Windows.Forms.Label()
        Me.lblCastTitle = New System.Windows.Forms.Label()
        Me.btnPlayAgain = New System.Windows.Forms.Button()
        Me.lblXSnag = New System.Windows.Forms.Label()
        Me.pbCatch = New System.Windows.Forms.PictureBox()
        Me.pbBoyFishing = New System.Windows.Forms.PictureBox()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        CType(Me.pbCatch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBoyFishing, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBait
        '
        Me.btnBait.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBait.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBait.Location = New System.Drawing.Point(603, 20)
        Me.btnBait.Name = "btnBait"
        Me.btnBait.Size = New System.Drawing.Size(161, 73)
        Me.btnBait.TabIndex = 0
        Me.btnBait.Text = "Step one - Bait your hook"
        Me.btnBait.UseVisualStyleBackColor = False
        '
        'btnCast
        '
        Me.btnCast.BackColor = System.Drawing.Color.Olive
        Me.btnCast.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCast.Location = New System.Drawing.Point(603, 99)
        Me.btnCast.Name = "btnCast"
        Me.btnCast.Size = New System.Drawing.Size(161, 71)
        Me.btnCast.TabIndex = 1
        Me.btnCast.Text = "Step two - Cast your line"
        Me.btnCast.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Red
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(875, 159)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(80, 47)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnGoFish
        '
        Me.btnGoFish.BackColor = System.Drawing.Color.GreenYellow
        Me.btnGoFish.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGoFish.Location = New System.Drawing.Point(604, 176)
        Me.btnGoFish.Name = "btnGoFish"
        Me.btnGoFish.Size = New System.Drawing.Size(160, 68)
        Me.btnGoFish.TabIndex = 3
        Me.btnGoFish.Text = "Go Fish!"
        Me.btnGoFish.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(133, 15)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(217, 33)
        Me.lblTitle.TabIndex = 5
        Me.lblTitle.Text = "Let's go fishing!"
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(187, 62)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(361, 24)
        Me.lblInfo.TabIndex = 6
        Me.lblInfo.Text = "Try your luck, can you catch a trout today?"
        '
        'lblTrout
        '
        Me.lblTrout.AutoSize = True
        Me.lblTrout.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrout.Location = New System.Drawing.Point(596, 310)
        Me.lblTrout.Name = "lblTrout"
        Me.lblTrout.Size = New System.Drawing.Size(0, 24)
        Me.lblTrout.TabIndex = 8
        '
        'lblCola
        '
        Me.lblCola.AutoSize = True
        Me.lblCola.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCola.Location = New System.Drawing.Point(596, 339)
        Me.lblCola.Name = "lblCola"
        Me.lblCola.Size = New System.Drawing.Size(0, 24)
        Me.lblCola.TabIndex = 9
        '
        'lblRustyBike
        '
        Me.lblRustyBike.AutoSize = True
        Me.lblRustyBike.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRustyBike.Location = New System.Drawing.Point(596, 371)
        Me.lblRustyBike.Name = "lblRustyBike"
        Me.lblRustyBike.Size = New System.Drawing.Size(0, 24)
        Me.lblRustyBike.TabIndex = 10
        '
        'lblSneaker
        '
        Me.lblSneaker.AutoSize = True
        Me.lblSneaker.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSneaker.Location = New System.Drawing.Point(596, 397)
        Me.lblSneaker.Name = "lblSneaker"
        Me.lblSneaker.Size = New System.Drawing.Size(0, 24)
        Me.lblSneaker.TabIndex = 11
        '
        'lblCast
        '
        Me.lblCast.AutoSize = True
        Me.lblCast.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCast.Location = New System.Drawing.Point(852, 269)
        Me.lblCast.Name = "lblCast"
        Me.lblCast.Size = New System.Drawing.Size(0, 24)
        Me.lblCast.TabIndex = 13
        '
        'lblCastTitle
        '
        Me.lblCastTitle.AutoSize = True
        Me.lblCastTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCastTitle.Location = New System.Drawing.Point(625, 267)
        Me.lblCastTitle.Name = "lblCastTitle"
        Me.lblCastTitle.Size = New System.Drawing.Size(118, 24)
        Me.lblCastTitle.TabIndex = 14
        Me.lblCastTitle.Text = "No. Casts left"
        '
        'btnPlayAgain
        '
        Me.btnPlayAgain.BackColor = System.Drawing.Color.Yellow
        Me.btnPlayAgain.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayAgain.Location = New System.Drawing.Point(855, 62)
        Me.btnPlayAgain.Name = "btnPlayAgain"
        Me.btnPlayAgain.Size = New System.Drawing.Size(128, 71)
        Me.btnPlayAgain.TabIndex = 16
        Me.btnPlayAgain.Text = "Play again"
        Me.btnPlayAgain.UseVisualStyleBackColor = False
        '
        'lblXSnag
        '
        Me.lblXSnag.AutoSize = True
        Me.lblXSnag.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblXSnag.Location = New System.Drawing.Point(600, 459)
        Me.lblXSnag.Name = "lblXSnag"
        Me.lblXSnag.Size = New System.Drawing.Size(0, 24)
        Me.lblXSnag.TabIndex = 17
        '
        'pbCatch
        '
        Me.pbCatch.BackColor = System.Drawing.Color.Transparent
        Me.pbCatch.Location = New System.Drawing.Point(365, 367)
        Me.pbCatch.Name = "pbCatch"
        Me.pbCatch.Size = New System.Drawing.Size(134, 116)
        Me.pbCatch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbCatch.TabIndex = 12
        Me.pbCatch.TabStop = False
        '
        'pbBoyFishing
        '
        Me.pbBoyFishing.Image = Global.Fishing_roulette_assignment.My.Resources.Resource1.boy_fishing
        Me.pbBoyFishing.Location = New System.Drawing.Point(40, 114)
        Me.pbBoyFishing.Name = "pbBoyFishing"
        Me.pbBoyFishing.Size = New System.Drawing.Size(554, 358)
        Me.pbBoyFishing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbBoyFishing.TabIndex = 7
        Me.pbBoyFishing.TabStop = False
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(28, 26)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(75, 23)
        Me.AxWindowsMediaPlayer1.TabIndex = 18
        Me.AxWindowsMediaPlayer1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1051, 613)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.lblXSnag)
        Me.Controls.Add(Me.btnPlayAgain)
        Me.Controls.Add(Me.lblCastTitle)
        Me.Controls.Add(Me.lblCast)
        Me.Controls.Add(Me.pbCatch)
        Me.Controls.Add(Me.lblSneaker)
        Me.Controls.Add(Me.lblRustyBike)
        Me.Controls.Add(Me.lblCola)
        Me.Controls.Add(Me.lblTrout)
        Me.Controls.Add(Me.pbBoyFishing)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnGoFish)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCast)
        Me.Controls.Add(Me.btnBait)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pbCatch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBoyFishing, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBait As System.Windows.Forms.Button
    Friend WithEvents btnCast As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnGoFish As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents pbBoyFishing As System.Windows.Forms.PictureBox
    Friend WithEvents lblTrout As System.Windows.Forms.Label
    Friend WithEvents lblCola As System.Windows.Forms.Label
    Friend WithEvents lblRustyBike As System.Windows.Forms.Label
    Friend WithEvents lblSneaker As System.Windows.Forms.Label
    Friend WithEvents pbCatch As System.Windows.Forms.PictureBox
    Friend WithEvents lblCast As System.Windows.Forms.Label
    Friend WithEvents lblCastTitle As System.Windows.Forms.Label
    Friend WithEvents btnPlayAgain As System.Windows.Forms.Button
    Friend WithEvents lblXSnag As System.Windows.Forms.Label
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Win_Game
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.lblWinGameover = New System.Windows.Forms.Label()
        Me.lblWin = New System.Windows.Forms.Label()
        Me.pbWinGameover = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.pbWinGameover, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(912, 792)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(219, 45)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(4, 5)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(100, 35)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(114, 5)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(100, 35)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'lblWinGameover
        '
        Me.lblWinGameover.AutoSize = True
        Me.lblWinGameover.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWinGameover.Location = New System.Drawing.Point(788, 337)
        Me.lblWinGameover.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWinGameover.Name = "lblWinGameover"
        Me.lblWinGameover.Size = New System.Drawing.Size(249, 52)
        Me.lblWinGameover.TabIndex = 2
        Me.lblWinGameover.Text = "Game Over"
        '
        'lblWin
        '
        Me.lblWin.AutoSize = True
        Me.lblWin.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWin.Location = New System.Drawing.Point(350, 648)
        Me.lblWin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWin.Name = "lblWin"
        Me.lblWin.Size = New System.Drawing.Size(687, 37)
        Me.lblWin.TabIndex = 3
        Me.lblWin.Text = "Woo Hoo.  You won.  You caught  a  Beauty :-)"
        '
        'pbWinGameover
        '
        Me.pbWinGameover.Image = Global.Fishing_roulette_assignment.My.Resources.Resource1.happy_fisherman
        Me.pbWinGameover.Location = New System.Drawing.Point(94, 128)
        Me.pbWinGameover.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pbWinGameover.Name = "pbWinGameover"
        Me.pbWinGameover.Size = New System.Drawing.Size(644, 485)
        Me.pbWinGameover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbWinGameover.TabIndex = 1
        Me.pbWinGameover.TabStop = False
        '
        'Win_Game
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(1149, 855)
        Me.Controls.Add(Me.lblWin)
        Me.Controls.Add(Me.lblWinGameover)
        Me.Controls.Add(Me.pbWinGameover)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Win_Game"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Win_Game"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.pbWinGameover, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents pbWinGameover As System.Windows.Forms.PictureBox
    Friend WithEvents lblWinGameover As System.Windows.Forms.Label
    Friend WithEvents lblWin As System.Windows.Forms.Label

End Class

Public Class Form1

    'associate Class of FishCatch with current form
    Dim myfishcatch As New FishCatch

    Dim intTrout As Integer
    Dim intCola As Integer
    Dim intSneaker As Integer
    Dim intBike As Integer
    Dim intSnag As Integer

    'pull through main background audio file
    'Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
    'PlayLoopingBackgroundSoundFile()
    'My.Computer.Audio.Play("https://drive.google.com/file/d/0B0_j_bLfv1V_TEtDaDd0ZTdhNFU/view?usp=sharing", AudioPlayMode.BackgroundLoop)

    ' End Sub

    'to action button click for bait on hook as a dialog box.
    Private Sub btnBait_Click(sender As Object, e As EventArgs) Handles btnBait.Click
        Dim dialogform As New Worm_on_hook
        dialogform.Show()
    End Sub

    'to action button to cast your line in.
    Private Sub btnCast_Click(sender As Object, e As EventArgs) Handles btnCast.Click
        Dim dialogform As New Cast_out_line
        dialogform.Show()
    End Sub


    'to set action for button Go Fish - the game commences
    Private Sub btnGoFish_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGoFish.Click

        'pulls through If, Then statement for Spin action (counter goes down from 6)
        myfishcatch.spin()


        'set random generator
        Dim gofish As New Random()
        Dim intComputerChoice As Integer = gofish.Next(1, 6)

        lblCast.Text = myfishcatch.Counter

        'show summary of name and number of items caught on Label
        Select Case intComputerChoice
            Case 1 'trout catch
                pbCatch.Image = My.Resources.Resource1.trout
                myfishcatch.IsCaught = True
                intTrout += 1
                lblTrout.Text = ("You caught" & " " & intTrout & " " & "Trout")

            Case 2 'cola catch
                pbCatch.Image = My.Resources.Resource1.cola
                intCola += 1
                lblCola.Text = ("You caught" & " " & intCola & " " & "Cola cans")

            Case 3 'bike catch
                pbCatch.Image = My.Resources.Resource1.rusty_bike
                intBike += 1
                lblRustyBike.Text = ("You caught" & " " & intBike & " " & "Rusty bikes! LOL")

            Case 4 'bike catch
                pbCatch.Image = My.Resources.Resource1.sneaker
                intSneaker += 1
                lblSneaker.Text = ("You caught" & " " & intSneaker & " " & "Sneakers")

            Case 5 'snag
                pbCatch.Image = My.Resources.Resource1.Red_X_snag
                myfishcatch.Snag = True
                intSnag += 1
                lblXSnag.Text = ("You got snagged")
                myfishcatch.spinSnag()


        End Select


        UpdateDisplay()

    End Sub


    Private Sub UpdateDisplay()
        'This updates what is seen on the screen 
        Me.Text = myfishcatch.Name
        lblCast.Text = myfishcatch.Caught
    End Sub

    'replay or Play Again button - same as Go Fish Button (same thing all over)
    Private Sub btnPlayAgain_Click(sender As Object, e As EventArgs) Handles btnPlayAgain.Click
        'pulls through If, Then statement for Spin action (counter goes down from 6)

        Dim Form1 = New Form1
        Form1.Show()

    End Sub


    'Exit button to close game
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    '    'review this code to see if my images can be merged

    '    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    '    '    Dim newimage As New Bitmap(ImageList1.Images(0).Width, ImageList1.Images(0).Height)
    '    '    Dim g As Graphics = Graphics.FromImage(newimage)
    '    '    g.DrawImage(ImageList1.Images(0), 0, 0)
    '    '    g.DrawImage(ImageList1.Images(1), 0, 0)
    '    '    PictureBox1.Image = newimage
    '    '    g.Dispose()
    '    'End Sub

    Private Sub PlayLoopingBackgroundSoundFile()
        Throw New NotImplementedException
    End Sub








End Class

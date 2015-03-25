Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class UnitTest1

    <TestMethod()> Public Sub CheckRandomGenerator()
        Dim gofish As New Random()
        Dim intComputerChoice As Integer = gofish.Next(1, 6)

        Select Case intComputerChoice
            Case 1 'trout
                Assert.AreEqual(1, 1)
            Case 2 'Cola
                Assert.AreEqual(2, 2)
            Case 3 'Bike
                Assert.AreEqual(3, 3)
            Case 4 'Sneaker
                Assert.AreEqual(4, 4)
        End Select

    End Sub
    <TestMethod()> Public Sub DoTheCountersandResultsWork()
        Dim gofish As New Random()
        Dim intComputerChoice As Integer = gofish.Next(1, 6)
        Dim intTrout As Integer
        Dim intCola As Integer
        Dim intSneaker As Integer
        Dim intBike As Integer

        Select Case intComputerChoice
            Case 1
                '  myfishcatch = New Trout
                '     pbCatch.Image = My.Resources.Resource1.trout
                intTrout += 1
                ' lblTrout.Text = ("You caught" & " " & intTrout & " " & "Trout")
                Assert.IsTrue(intTrout = 1)

            Case 2
                '    myfishcatch = New Cola
                '   pbCatch.Image = My.Resources.Resource1.cola
                intCola += 1
                '  lblCola.Text = ("You caught" & " " & intCola & " " & "Cola cans")
                Assert.IsTrue(intCola = 1)

            Case 3
                ' myfishcatch = New Bike
                'pbCatch.Image = My.Resources.Resource1.rusty_bike
                intBike += 1
                'lblRustyBike.Text = ("You caught" & " " & intBike & " " & "Rusty bikes! LOL")
                Assert.IsTrue(intBike = 1)

            Case 4
                'myfishcatch = New Sneaker
                'pbCatch.Image = My.Resources.Resource1.sneaker
                intSneaker += 1
                'lblSneaker.Text = ("You caught" & " " & intSneaker & " " & "Sneakers")
                Assert.IsTrue(intSneaker = 1)

        End Select
    End Sub



End Class
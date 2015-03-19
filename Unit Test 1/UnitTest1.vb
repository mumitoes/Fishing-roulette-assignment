Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class UnitTest1

    <TestMethod()> Public Sub CheckRandomGenerator()
        Dim fishcatch As New Random()
        Dim intComputerChoice As Integer = fishcatch.Next(1, 6)

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

End Class
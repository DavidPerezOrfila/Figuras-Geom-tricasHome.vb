Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim p1 As punto = New punto

        MessageBox.Show(p1.ToString)

        Dim p2 As punto = New punto(1, 2)

        MessageBox.Show(p2.ToString)

        p1.setX(5)
        p1.setY(9)

        MessageBox.Show(p1.ToString)

    End Sub


End Class

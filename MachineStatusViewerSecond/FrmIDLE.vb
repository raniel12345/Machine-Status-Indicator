Public Class FrmIDLE

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        Form1.idleCount = 0
    End Sub

    Private Sub FrmIDLE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.AutoSize = True
        Timer1.Start()
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label1.Left -= 10
        If Label1.Left <= -Width Then
            Label1.Left = Width
        End If
    End Sub

End Class
Public Class Form1

    Public idleCount As Integer = 0

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim h As Integer = Screen.PrimaryScreen.WorkingArea.Height - Me.Height

        Me.Location = New Point(System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width - Me.Width, h)
        'Me.ShowInTaskbar = False
        Label1.Cursor = Cursors.Hand
    End Sub

    Private Sub IndicatorTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IndicatorTimer.Tick
        idleCount += 1
        lblIDLECount.Text = idleCount.ToString()

        If idleCount >= 10 Then
            Me.WindowState = FormWindowState.Minimized
            idleCount = 0
        End If
    End Sub


    Private Sub BtnRunProd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRunProd.Click
        FrmRunProd.Show()

        Try
            For Each form In My.Application.OpenForms
                If (form.name = FrmOnGoingRep.Name) Then
                    FrmOnGoingRep.Close()
                End If

                If (form.name = FrmNoMaterial.Name) Then
                    FrmNoMaterial.Close()
                End If

                If (form.name = FrmIDLE.Name) Then
                    FrmIDLE.Close()
                End If

                If (form.name = FrmEBR.Name) Then
                    FrmEBR.Close()
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Form1_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        IndicatorTimer.Start()
    End Sub

    Private Sub Form1_Deactivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Deactivate
        IndicatorTimer.Stop()
    End Sub

    Private Sub Form1_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        IndicatorTimer.Start()
        Exit Sub
    End Sub

    Private Sub BtnOngoRep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOngoRep.Click
        FrmOnGoingRep.Show()

        Try
            For Each form In My.Application.OpenForms
                If (form.name = FrmRunProd.Name) Then
                    FrmRunProd.Close()
                End If

                If (form.name = FrmNoMaterial.Name) Then
                    FrmNoMaterial.Close()
                End If

                If (form.name = FrmIDLE.Name) Then
                    FrmIDLE.Close()
                End If

                If (form.name = FrmEBR.Name) Then
                    FrmEBR.Close()
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnIDLE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIDLE.Click
        FrmIDLE.Show()

        Try
            For Each form In My.Application.OpenForms
                If (form.name = FrmRunProd.Name) Then
                    FrmRunProd.Close()
                End If

                If (form.name = FrmNoMaterial.Name) Then
                    FrmNoMaterial.Close()
                End If

                If (form.name = FrmOnGoingRep.Name) Then
                    FrmOnGoingRep.Close()
                End If

                If (form.name = FrmEBR.Name) Then
                    FrmEBR.Close()
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnNoMaterial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNoMaterial.Click
        FrmNoMaterial.Show()

        Try
            For Each form In My.Application.OpenForms
                If (form.name = FrmRunProd.Name) Then
                    FrmRunProd.Close()
                End If

                If (form.name = FrmIDLE.Name) Then
                    FrmIDLE.Close()
                End If

                If (form.name = FrmOnGoingRep.Name) Then
                    FrmOnGoingRep.Close()
                End If

                If (form.name = FrmEBR.Name) Then
                    FrmEBR.Close()
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnEBR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEBR.Click
        FrmEBR.Show()

        Try
            For Each form In My.Application.OpenForms
                If (form.name = FrmRunProd.Name) Then
                    FrmRunProd.Close()
                End If

                If (form.name = FrmIDLE.Name) Then
                    FrmIDLE.Close()
                End If

                If (form.name = FrmOnGoingRep.Name) Then
                    FrmOnGoingRep.Close()
                End If

                If (form.name = FrmNoMaterial.Name) Then
                    FrmNoMaterial.Close()
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Application.Exit()
    End Sub
End Class

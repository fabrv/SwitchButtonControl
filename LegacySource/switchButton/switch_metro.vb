Public Class switch_metro
    Public on_off = 0
    Public one_to_four = 1


    Private Sub pb_switch_Click(sender As Object, e As EventArgs) Handles pb_switch.Click
        timer_move.Start()
    End Sub

    Private Sub timer_move_Tick(sender As Object, e As EventArgs) Handles timer_move.Tick
        Select Case on_off
            Case 0
                Select Case one_to_four
                    Case 4
                        pb_switch.Image = My.Resources.switch_1
                        one_to_four = 4
                        on_off = 1
                        timer_move.Stop()
                    Case 3
                        pb_switch.Image = My.Resources.switch_2
                        one_to_four = 4
                    Case 2
                        pb_switch.Image = My.Resources.switch_3
                        one_to_four = 3
                    Case 1
                        pb_switch.Image = My.Resources.switch_4
                        one_to_four = 2
                End Select
            Case 1
                Select Case one_to_four
                    Case 1
                        pb_switch.Image = My.Resources.switch_4
                        one_to_four = 1
                        on_off = 0
                        timer_move.Stop()
                    Case 2
                        pb_switch.Image = My.Resources.switch_3
                        one_to_four = 1
                    Case 3
                        pb_switch.Image = My.Resources.switch_2
                        one_to_four = 2
                    Case 4
                        pb_switch.Image = My.Resources.switch_1
                        one_to_four = 3
                End Select
        End Select
    End Sub
End Class

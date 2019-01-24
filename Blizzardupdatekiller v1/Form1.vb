Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim psi As New ProcessStartInfo("core/Blizzardupdatekiller.bat")
        psi.RedirectStandardError = True
        psi.RedirectStandardOutput = True
        psi.CreateNoWindow = True
        psi.WindowStyle = ProcessWindowStyle.Hidden
        psi.UseShellExecute = False

        Dim process As Process = Process.Start(psi)
        Dim Title As String
        Title = "Done"

        Dim Result = MsgBox("Successfully killed the process!", MsgBoxStyle.OkOnly, Title)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Title As String
        Title = "Info"

        Dim Result = MsgBox("Made by THEGUY3ds for d3reflection to kill blizzard updater.", MsgBoxStyle.OkOnly, Title)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Title As String
        Title = "Mod agent"

        Dim Result = MsgBox("Injects a modified version of the blizzard updater agent that allows the updater agent to auto shutoff. (Click ok to continue)", MsgBoxStyle.OkOnly, Title)

        Dim psi As New ProcessStartInfo("core/copy.bat")
        psi.RedirectStandardError = True
        psi.RedirectStandardOutput = True
        psi.CreateNoWindow = True
        psi.WindowStyle = ProcessWindowStyle.Hidden
        psi.UseShellExecute = False

        Dim process As Process = Process.Start(psi)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim psi As New ProcessStartInfo("core/restore.bat")
        psi.RedirectStandardError = True
        psi.RedirectStandardOutput = True
        psi.CreateNoWindow = True
        psi.WindowStyle = ProcessWindowStyle.Hidden
        psi.UseShellExecute = False


        Dim process As Process = Process.Start(psi)
        Dim Title As String
        Title = "Done"

        Dim Result = MsgBox("Successfully restored the files.", MsgBoxStyle.OkOnly, Title)
    End Sub
End Class
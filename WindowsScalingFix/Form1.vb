Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadValuesFromRegistry()
    End Sub

    Sub ReadValuesFromRegistry()
        txtScaleFactor.Text = Microsoft.Win32.Registry.GetValue("HKEY_CURRENT_USER\Control Panel\Desktop", "DesktopDPIOverride", "-")
        txtDPI.Text = Microsoft.Win32.Registry.GetValue("HKEY_CURRENT_USER\Control Panel\Desktop", "LogPixels", "-")
        chkDPIScaling.Checked = Microsoft.Win32.Registry.GetValue("HKEY_CURRENT_USER\Control Panel\Desktop", "Win8DpiScaling", False)
    End Sub

    Private Sub btnSetDPI_Click(sender As Object, e As EventArgs) Handles btnSetDPI.Click
        Try
            Dim val As Integer = txtDPI.Text
            Microsoft.Win32.Registry.SetValue("HKEY_CURRENT_USER\Control Panel\Desktop", "LogPixels", val, Microsoft.Win32.RegistryValueKind.DWord)
        Catch
            MsgBox("Could not save DPI value")
        End Try

    End Sub

    Private Sub btnSetScaleFactor_Click(sender As Object, e As EventArgs) Handles btnSetScaleFactor.Click
        Try
            Dim val As Integer = txtScaleFactor.Text
            Microsoft.Win32.Registry.SetValue("HKEY_CURRENT_USER\Control Panel\Desktop", "DesktopDPIOverride", val, Microsoft.Win32.RegistryValueKind.DWord)
        Catch
            MsgBox("Could not save DPI value")
        End Try
    End Sub

    Private Sub chkDPIScaling_CheckedChanged(sender As Object, e As EventArgs) Handles chkDPIScaling.CheckedChanged
        Dim val As Int32 = 0
        If chkDPIScaling.Checked Then
            val = 1
        End If
        Microsoft.Win32.Registry.SetValue("HKEY_CURRENT_USER\Control Panel\Desktop", "Win8DpiScaling", Val, Microsoft.Win32.RegistryValueKind.DWord)
    End Sub
End Class
